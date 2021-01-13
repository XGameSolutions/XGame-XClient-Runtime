/******************************************/
/*                                        */
/*     Copyright (c) 2020 monitor1394     */
/*     https://github.com/monitor1394     */
/*                                        */
/******************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;
#if UNITY_EDITOR_OSX
using UnityEditor.iOS.Xcode;
#endif
using System.IO;

namespace XBuild
{
    public static class BuildTool
    {
        private static BuildParams s_Param;

        public static void BuildWindowExe()
        {
            BuildLog.Log("BuildWindowExe ...");
            InitBuildParams(BuildTarget.StandaloneWindows);
            BuildPackage(s_Param);
            BuildLog.Log("BuildWindowExe DONE!");
        }

        public static void BuildWindowAB()
        {
            BuildLog.Log("BuildWindowAB ...");
            InitBuildParams(BuildTarget.StandaloneWindows);
            BuildAB(s_Param, true);
            BuildLog.Log("BuildWindowAB DONE!");
        }

        public static void BuildWindowABAndExe()
        {
            BuildLog.Log("BuildWindowABAndExe ...");
            InitBuildParams(BuildTarget.StandaloneWindows);
            BuildAB(s_Param, false);
            BuildPackage(s_Param);
            BuildLog.Log("BuildWindowABAndExe DONE!");
        }

        public static void BuildOSXAB()
        {
            BuildLog.Log("BuildOSXAB ...");
            InitBuildParams(BuildTarget.StandaloneOSX);
            BuildAB(s_Param, true);
            BuildLog.Log("BuildOSXAB DONE!");
        }

        public static void BuildIOSAB()
        {
            BuildLog.Log("BuildIOSAB ...");
            InitBuildParams(BuildTarget.iOS);
            BuildAB(s_Param, true);
            BuildLog.Log("BuildIOSAB DONE!");
        }

        public static void BuildIOSXcode()
        {
            BuildLog.Log("BuildIOSXcode ...");
            InitBuildParams(BuildTarget.iOS);
            BuildPackage(s_Param);
            BuildLog.Log("BuildIOSXcode DONE!");
        }

        public static void BuildIOSABAndXcode()
        {
            BuildLog.Log("BuildIOSABAndXcode ...");
            InitBuildParams(BuildTarget.iOS);
            BuildAB(s_Param, false);
            BuildPackage(s_Param);
            BuildLog.Log("BuildIOSABAndXcode DONE!");
        }

        public static void BuildAndroidAB()
        {
            BuildLog.Log("BuildAndroidAB ...");
            InitBuildParams(BuildTarget.Android);
            BuildAB(s_Param, true);
            BuildLog.Log("BuildAndroidAB DONE!");
        }

        public static void BuildAndroidApk()
        {
            BuildLog.Log("BuildAndroidApk ...");
            InitBuildParams(BuildTarget.Android);
            BuildPackage(s_Param);
            BuildLog.Log("BuildAndroidApk DONE!");
        }

        public static void BuildAndroidABAndApk()
        {
            BuildLog.Log("BuildAndroidABAndApk ...");
            InitBuildParams(BuildTarget.Android);
            BuildAB(s_Param, false);
            BuildPackage(s_Param);
            BuildLog.Log("BuildAndroidABAndApk DONE!");
        }

        private static void InitBuildParams(BuildTarget target)
        {
            if (s_Param == null)
            {
                s_Param = BuildHelper.GetBuildParamsFromCommandLine(target);
                BuildLog.Log("BuildParams:" + s_Param);
            }
            else
            {
                s_Param.target = target;
            }
        }

        private static void BuildPackage(BuildParams param)
        {
            BuildCallback.OnBeforeBuildPackage(param);
            var flag = BuildPlayer(param);
            BuildCallback.OnAfterBuildPackage(param, flag);
            if (flag)
            {
                BuildXCodeProject(param);
            }
        }

        private static void BuildAB(BuildParams param, bool onlyBuildAB)
        {
            var abDir = BuildHelper.GetABDir(param.target);
            var abPath = BuildHelper.GetABDirPath(param.target);
            var option = BuildAssetBundleOptions.None;
            option |= BuildAssetBundleOptions.ChunkBasedCompression;
            BuildHelper.CreateDir(abPath);
            BuildPipeline.BuildAssetBundles(abDir, option, param.target);
            BuildLog.Log("BuildAB DONE!");
        }

        private static bool BuildPlayer(BuildParams param)
        {
            var sourAbPath = BuildHelper.GetABDirPath(param.target);
            var destAbPath = Application.streamingAssetsPath;
            if (!Directory.Exists(sourAbPath))
            {
                BuildLog.LogError("ab path not exists:" + sourAbPath);
                return false;
            }
            BuildHelper.ClearDir(destAbPath);
            BuildHelper.CopyDir(sourAbPath, destAbPath, ".manifest|.meta");

            PlayerSettings.productName = param.productName;
            PlayerSettings.companyName = param.companyName;
            PlayerSettings.applicationIdentifier = param.applicationIdentifier;
            PlayerSettings.bundleVersion = param.version;
            PlayerSettings.Android.bundleVersionCode = param.GetVersionCode();
            PlayerSettings.iOS.buildNumber = param.GetVersionCode().ToString();
            PlayerSettings.iOS.appleEnableAutomaticSigning = true;
            PlayerSettings.iOS.appleDeveloperTeamID = param.appleDeveloperTeamID;
            BuildPlayerOptions op = new BuildPlayerOptions();
            op.scenes = new[] { param.startScene };
            op.locationPathName = param.GetLocationPathName();
            op.target = param.target;
            op.options = param.isDebug ?
                (BuildOptions.Development | BuildOptions.AllowDebugging | BuildOptions.ConnectWithProfiler) :
                BuildOptions.None;

            var result = BuildPipeline.BuildPlayer(op);
            var summary = result.summary;
            if (summary.result == BuildResult.Succeeded)
            {

            }
            if (summary.result == BuildResult.Failed)
            {
                return false;
            }
            return true;
        }

        private static void BuildXCodeProject(BuildParams param)
        {
#if UNITY_EDITOR_OSX
            if (param.target != BuildTarget.iOS) return;
            var xcodeprojPath = Application.dataPath + "/../xgame/Unity-iPhone.xcodeproj";
            var projPath = xcodeprojPath + "/project.pbxproj";
            if (!File.Exists(projPath))
            {
                BuildLog.LogError("xcode project path ERROR:" + projPath);
                return;
            }
            PBXProject proj = new PBXProject();
            proj.ReadFromFile(projPath);
            BuildLog.Log("open xcode project:" + proj);
            var target = proj.GetUnityMainTargetGuid();

            File.WriteAllText(projPath, proj.WriteToString());
            //BuildHelper.RunBash("open -a Xcode " + xcodeprojPath);
            var askForBuildLocation = false;
            // BuildHelper.RefectionInvoke(BuildHelper.EditorAssembly, "UnityEditor.BuildPlayerWindow",
            //     "BuildPlayerAndRun", null, new Type[] { }, null);
            BuildHelper.RefectionInvoke(BuildHelper.EditorAssembly, "UnityEditor.BuildPlayerWindow",
                "BuildPlayerAndRun", null, new Type[] { typeof(bool) }, new object[] { askForBuildLocation });
#endif
        }
    }
}

