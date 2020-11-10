/******************************************/
/*                                        */
/*     Copyright (c) 2020 monitor1394     */
/*     https://github.com/monitor1394     */
/*                                        */
/******************************************/

using System;
using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;

namespace XBuild
{
    public static class BuildCallback
    {
        /// <summary>
        /// 打AB前的回调
        /// </summary>
        public static void OnBeforeBuildAB(BuildParams buildParam)
        {
        }

        /// <summary>
        /// 打AB后的回调
        /// </summary>
        public static void OnAfterBuildAB(BuildParams buildParam)
        {
        }

        /// <summary>
        /// 打包体前的回调
        /// </summary>
        public static void OnBeforeBuildPackage(BuildParams buildParam)
        {
            var buildConfig = BuildConfig.GetConfig();
            SceneTool.RefreshSettingList(true);
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

        /// <summary>
        /// 打包体后的回调
        /// </summary>
        public static void OnAfterBuildPackage(BuildParams buildParam, bool success)
        {
            SceneTool.RefreshSettingList(false);
        }
    }
}