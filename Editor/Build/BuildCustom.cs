

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
            EditorSceneManager.OpenScene(buildParam.startScene);
            var init = GameObject.Find(BuildConfig.startSceneInitObjectPath);
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