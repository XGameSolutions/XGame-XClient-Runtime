

using UnityEditor.SceneManagement;
using UnityEngine;
using XBuild;

namespace XGame
{
    /// <summary>
    /// XBuild的一些定制
    /// </summary>
    public static class BuildCustom
    {
        static BuildCustom()
        {
            BuildCallback.RegisterBeforeBuildPackageCallback(OnBeforeBuildPackage);
        }

        internal static void OnBeforeBuildPackage(BuildParams buildParam)
        {
            var buildConfig = BuildConfig.GetConfig();
            EditorSceneManager.OpenScene(buildParam.startScene);
            var init = GameObject.Find(buildConfig.startSceneInitObjectPath);
            if (init != null)
            {
                var startScript = init.gameObject.GetComponent<GameStart>();
                startScript.IsAbRes = true;
                startScript.IsAbLua = true;
                startScript.IsAbCfg = true;
                EditorSceneManager.SaveOpenScenes();
            }
        }
    }
}