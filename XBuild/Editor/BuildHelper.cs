/******************************************/
/*                                        */
/*     Copyright (c) 2020 monitor1394     */
/*     https://github.com/monitor1394     */
/*                                        */
/******************************************/

using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace XBuild
{
    public static class BuildHelper
    {
        private const BindingFlags s_StaticMembers = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
        private static Regex s_VersionRegex = new Regex(@"\d+\.\d+\.\d+");
        public static void CreateDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void ClearDir(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (var file in Directory.GetFileSystemEntries(path))
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                    else
                    {
                        ClearDir(file);
                    }
                }
                Directory.Delete(path);
            }
        }

        private static List<string> s_filterList = new List<string>();
        public static bool CopyDir(string sourPath, string destPath, string filters = null)
        {
            s_filterList.Clear();
            if (!string.IsNullOrEmpty(filters))
            {
                foreach (var f in filters.Split('|')) s_filterList.Add(f);
            }
            var sourDir = new DirectoryInfo(sourPath);
            var destDir = new DirectoryInfo(destPath);
            if (!sourDir.Exists)
            {
                BuildLog.LogError("BuildHelper.CopyDir ERROR: sourPath not exist:" + sourPath);
                return false;
            }
            if (!destDir.Exists)
            {
                destDir.Create();
            }
            foreach (var file in sourDir.GetFiles())
            {
                if (!IsInFilterList(s_filterList, file.Name))
                {
                    CopyFile(file.FullName, destPath);
                }
            }
            foreach (var dir in sourDir.GetDirectories())
            {
                if (!IsInFilterList(s_filterList, dir.Name))
                {
                    CopyDir(dir.FullName, destDir.FullName + "/" + dir.Name, filters);
                }
            }
            return true;
        }

        private static bool IsInFilterList(List<string> filterList, string path)
        {
            if (path.StartsWith(".")) return true;
            if (filterList.Count == 0) return false;
            foreach (var filter in filterList)
            {
                if (path.Contains(filter)) return true;
            }
            return false;
        }

        public static bool CopyFile(string sourFilePath, string destDir, bool checkExists = true)
        {
            if (checkExists)
            {
                if (!File.Exists(sourFilePath)) return false;
                if (!Directory.Exists(destDir)) return false;
            }
            string fileName = Path.GetFileName(sourFilePath);
            File.Copy(sourFilePath, destDir + "/" + fileName, true);
            return true;
        }

        public static string GetABDir(BuildTarget target)
        {
            var buildCfg = BuildConfig.GetConfig();
            return buildCfg.abDir + target;
        }

        public static string GetABDirPath(BuildTarget target)
        {
            return Application.dataPath + "/../" + GetABDir(target);
        }

        public static BuildParams GetBuildParamsFromCommandLine(BuildTarget target)
        {
            BuildParams param;
            var args = Environment.GetCommandLineArgs();
            if (Application.isBatchMode && args != null && args.Length >= 10)
            {
                var strParams = args[9];
                param = BuildParams.Parse(strParams);
            }
            else
            {
                param = new BuildParams();
            }
            param.target = target;
            return param;
        }

        public static int ParseVersionCode(string version)
        {
            if (!s_VersionRegex.IsMatch(version))
            {
                BuildLog.LogError("ParseVersionCode ERROR:version format error:" + version);
                return 0;
            }
            var list = version.Split('.');
            var v1 = int.Parse(list[0]);
            var v2 = int.Parse(list[1]);
            var v3 = int.Parse(list[2]);
            return v1 * 1000000 + v2 * 1000 + v3;
        }

        public static string GetTimeString()
        {
            DateTime now = DateTime.Now;
            return now.ToString("yyyymmdd_HHMM", DateTimeFormatInfo.InvariantInfo);
        }

        public static string GetPackageFileNameExtention(BuildTarget target)
        {
            switch (target)
            {
                case BuildTarget.StandaloneWindows: return ".zip";
                case BuildTarget.Android: return ".apk";
                case BuildTarget.iOS: return ".ipa";
                default: return "";
            }
        }

        public static string RunCmd(string cmd)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = "/C " + cmd;
            try
            {
                p.Start();
                p.WaitForExit();
                return p.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
                p.Close();
                return e.Message;
            }
        }

        public static string RunBash(string cmd)
        {
            cmd = cmd.Replace("\"", "\\\"");
            Process p = new Process();
            p.StartInfo.FileName = "/bin/bash";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = string.Format("-c \"{0}\"", cmd);
            try
            {
                p.Start();
                p.WaitForExit();
                return p.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
                p.Close();
                return e.Message;
            }
        }

        public static Assembly EditorAssembly
        {
            get
            {
                return typeof(EditorWindow).Assembly;
            }
        }

        public static System.Object RefectionInvoke(Assembly assembly, string className, string methodName,
            System.Object obj, Type[] types, params System.Object[] parameters)
        {
            var T = assembly.GetType(className);
            BuildLog.Log(T);
            var method = T.GetMethod(methodName, s_StaticMembers, null, types, null);
            BuildLog.Log(method);
            return method.Invoke(obj, parameters);
        }
    }
}

