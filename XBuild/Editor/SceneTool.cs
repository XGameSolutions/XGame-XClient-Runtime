/******************************************/
/*                                        */
/*     Copyright (c) 2020 monitor1394     */
/*     https://github.com/monitor1394     */
/*                                        */
/******************************************/

using UnityEditor;

namespace XBuild
{
    public static class SceneTool
    {
        public static void RefreshSettingList(bool justStartScene)
        {
            var buildCfg = BuildConfig.GetConfig();
            if (justStartScene)
            {
                var list = new EditorBuildSettingsScene[1];
                list[0] = new EditorBuildSettingsScene(buildCfg.startScenePath, true);
                EditorBuildSettings.scenes = list;
            }
            else
            {
                var paths = AssetDatabase.FindAssets("t:scene", new[] { "Assets/ResScene" });
                var list = new EditorBuildSettingsScene[paths.Length + 1];
                list[0] = new EditorBuildSettingsScene(buildCfg.startScenePath, true);
                for (int i = 0; i < paths.Length; i++)
                {
                    var path = AssetDatabase.GUIDToAssetPath(paths[i]);
                    list[i + 1] = new EditorBuildSettingsScene(path, true);
                }
                EditorBuildSettings.scenes = list;
            }
            BuildLog.Log("RefreshSettingList DONE!");
        }
    }
}