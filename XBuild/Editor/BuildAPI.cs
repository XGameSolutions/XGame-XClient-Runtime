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

    [MenuItem("XBuild/Build_Window")]
    public static void BuildWindow()
    {
        BuildLog.Instance.Init("BuildAPI.BuildWindow");
        BuildTool.BuildWindow();
    }

    [MenuItem("XBuild/Build_Window_AB")]
    public static void BuildWindowAB()
    {
        BuildLog.Instance.Init("BuildAPI.BuildWindowAB");
        BuildTool.BuildWindowAB();
    }

    [MenuItem("XBuild/Build_OSX_AB")]
    public static void BuildOSXAB()
    {
        BuildLog.Instance.Init("BuildAPI.BuildOSXAB");
        BuildTool.BuildOSXAB();
    }

    [MenuItem("XBuild/Build_iOS_Xcode")]
    public static void BuildIOSXcode()
    {
        BuildLog.Instance.Init("BuildAPI.BuildIOSXcode");
        BuildTool.BuildIOSXcode();
    }

    [MenuItem("XBuild/Build_iOS_AB")]
    public static void BuildIOSAB()
    {
        BuildLog.Instance.Init("BuildAPI.BuildIOSAB");
        BuildTool.BuildIOSAB();
    }

    [MenuItem("XBuild/Scene_RefreshList")]
    public static void SceneRefreshSettingList()
    {
        SceneTool.RefreshSettingList();
    }
}