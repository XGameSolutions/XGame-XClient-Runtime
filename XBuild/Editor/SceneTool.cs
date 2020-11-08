using UnityEditor;

namespace XBuild
{
    public static class SceneTool
    {
        public static void RefreshSettingList()
        {
            var buildCfg = BuildConfig.GetConfig();
            var paths = AssetDatabase.FindAssets("t:scene", new[] { "Assets/ResScene" });

            var list = new EditorBuildSettingsScene[paths.Length + 1];
            list[0] = new EditorBuildSettingsScene(buildCfg.startScenePath, true);
            for (int i = 0; i < paths.Length; i++)
            {
                list[i + 1] = new EditorBuildSettingsScene(paths[i], true);
            }
            EditorBuildSettings.scenes = list;
            BuildLog.Log("RefreshSettingList DONE!");
        }
    }
}