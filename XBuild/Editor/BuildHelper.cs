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

namespace XBuild
{
    public static class BuildHelper
    {
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

        public static bool CopyDir(string sourPath, string destPath, bool createDestDirIfNotExist = true)
        {
            var sourDir = new DirectoryInfo(sourPath);
            var destDir = new DirectoryInfo(destPath);
            if (!sourDir.Exists)
            {
                BuildLog.LogError("BuildHelper.CopyDir ERROR: sourPath not exist:" + sourPath);
                return false;
            }
            if (!destDir.Exists)
            {
                if (createDestDirIfNotExist) destDir.Create();
                else
                {
                    BuildLog.LogError("BuildHelper.CopyDir ERROR: destPath not exist:" + sourPath);
                    return false;
                }
            }
            foreach (var file in sourDir.GetFiles())
            {
                CopyFile(file.FullName, destPath);
            }
            foreach (var dir in sourDir.GetDirectories())
            {
                CopyDir(dir.FullName, destDir.FullName + "/" + dir.Name, createDestDirIfNotExist);
            }
            return true;
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
    }
}

