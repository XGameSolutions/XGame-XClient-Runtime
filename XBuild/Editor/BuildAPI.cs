/******************************************/
/*                                        */
/*     Copyright (c) 2020 monitor1394     */
/*     https://github.com/monitor1394     */
/*                                        */
/******************************************/

using UnityEditor;
using UnityEngine;
using XBuild;

public static class BuildAPI
{
    [MenuItem("XBuild/Build_ExportDefaultConfig")]
    public static void ExportDefaultBuildConfig()
    {
        ScriptableObject buildCfg = ScriptableObject.CreateInstance<BuildConfig>();
        AssetDatabase.CreateAsset(buildCfg, BuildConfig.configPath);
    }

    [MenuItem("XBuild/Build_Window_AB")]
    public static void BuildWindowAB()
    {
        BuildLog.Instance.Init("BuildAPI.BuildWindowAB");
        BuildTool.BuildWindowAB();
    }

    [MenuItem("XBuild/Build_Window_Exe")]
    public static void BuildWindowExe()
    {
        BuildLog.Instance.Init("BuildAPI.BuildWindowExe");
        BuildTool.BuildWindowExe();
    }

    [MenuItem("XBuild/Build_Window_AB_And_Exe")]
    public static void BuildWindowABAndExe()
    {
        BuildLog.Instance.Init("BuildAPI.BuildWindowABAndExe");
        BuildTool.BuildWindowABAndExe();
    }

    [MenuItem("XBuild/Build_OSX_AB")]
    public static void BuildOSXAB()
    {
        BuildLog.Instance.Init("BuildAPI.BuildOSXAB");
        BuildTool.BuildOSXAB();
    }

    [MenuItem("XBuild/Build_iOS_AB")]
    public static void BuildIOSAB()
    {
        BuildLog.Instance.Init("BuildAPI.BuildIOSAB");
        BuildTool.BuildIOSAB();
    }

    [MenuItem("XBuild/Build_iOS_Xcode")]
    public static void BuildIOSXcode()
    {
        BuildLog.Instance.Init("BuildAPI.BuildIOSXcode");
        BuildTool.BuildIOSXcode();
    }

    [MenuItem("XBuild/Build_iOS_AB_And_Xcode")]
    public static void BuildIOSABAndXcode()
    {
        BuildLog.Instance.Init("BuildAPI.BuildIOSABAndXcode");
        BuildTool.BuildIOSAB();
        BuildTool.BuildIOSXcode();
    }

    [MenuItem("XBuild/Build_Android_AB")]
    public static void BuildAndroidAB()
    {
        BuildLog.Instance.Init("BuildAPI.BuildAndroidAB");
        BuildTool.BuildAndroidAB();
    }

    [MenuItem("XBuild/Build_Android_Apk")]
    public static void BuildAndroidApk()
    {
        BuildLog.Instance.Init("BuildAPI.BuildAndroidApk");
        BuildTool.BuildAndroidApk();
    }

    [MenuItem("XBuild/Build_Android_AB_And_Apk")]
    public static void BuildAndroidABAndApk()
    {
        BuildLog.Instance.Init("BuildAPI.BuildAndroidABAndApk");
        BuildTool.BuildAndroidABAndApk();
    }

    [MenuItem("XBuild/Scene_RefreshList")]
    public static void SceneRefreshSettingList()
    {
        SceneTool.RefreshSettingList(false);
    }
}