

using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using XBuild;
using XBuild.AB;

namespace XGame
{
    [InitializeOnLoad]
    public static class BuildCustom
    {
        static BuildCustom()
        {
            BuildAPI.RegisterBeforeBuildPackageCallback(OnBeforeBuildPackage);
            ABAPI.RegisterLoadAssetBundle(LoadAssetBundle);
        }

        internal static void OnBeforeBuildPackage(BuildParams buildParam)
        {
            //GenXLua();
            EditorSceneManager.OpenScene(buildParam.startScene);
            var init = GameObject.Find(BuildConfig.startSceneInitObjectPath);
            if (init != null)
            {
                var app = init.gameObject.GetComponent<App>();
                app.IsAbRes = true;
                app.IsAbLua = true;
                app.IsAbCfg = true;
                EditorSceneManager.SaveOpenScenes();
            }
        }

        private static void GenXLua()
        {
            CSObjectWrapEditor.Generator.ClearAll();
            CSObjectWrapEditor.Generator.GenAll();
        }

        private static AssetBundle LoadAssetBundle(string path)
        {
            return AssetBundle.LoadFromFile(path);
        }
    }
}