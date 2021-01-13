/******************************************/
/*                                        */
/*     Copyright (c) 2020 monitor1394     */
/*     https://github.com/monitor1394     */
/*                                        */
/******************************************/

using System;
using UnityEditor.SceneManagement;

namespace XBuild
{
    public static class BuildCallback
    {
        private static Action<BuildParams> s_OnBeforeBuildAB;
        private static Action<BuildParams> s_OnAfterBuildAB;
        private static Action<BuildParams> s_OnBeforeBuildPackage;
        private static Action<BuildParams> s_OnAfterBuildPackage;

        /// <summary>
        /// 注册Build AB前的回调
        /// </summary>
        public static void RegisterBeforeBuildABCallback(Action<BuildParams> callback)
        {
            s_OnBeforeBuildAB = callback;
        }
        /// <summary>
        /// 注册Build AB后的回调
        /// </summary>
        /// <param name="callback"></param>
        public static void RegisterAfterBuildABCallback(Action<BuildParams> callback)
        {
            s_OnAfterBuildAB = callback;
        }
        /// <summary>
        /// 注册打包前的回调
        /// </summary>
        public static void RegisterBeforeBuildPackageCallback(Action<BuildParams> callback)
        {
            s_OnBeforeBuildPackage = callback;
        }
        /// <summary>
        /// 注册打包后的回调
        /// </summary>
        public static void RegisterAfterBuildPacakgeCallback(Action<BuildParams> callback)
        {
            s_OnAfterBuildPackage = callback;
        }

        /// <summary>
        /// 打AB前的回调
        /// </summary>
        internal static void OnBeforeBuildAB(BuildParams buildParam)
        {
            if (s_OnBeforeBuildAB != null)
            {
                s_OnBeforeBuildAB(buildParam);
            }
        }

        /// <summary>
        /// 打AB后的回调
        /// </summary>
        internal static void OnAfterBuildAB(BuildParams buildParam)
        {
            if (s_OnAfterBuildAB != null)
            {
                s_OnAfterBuildAB(buildParam);
            }
        }

        /// <summary>
        /// 打包体前的回调
        /// </summary>
        internal static void OnBeforeBuildPackage(BuildParams buildParam)
        {
            SceneTool.RefreshSettingList(true);
            EditorSceneManager.OpenScene(buildParam.startScene);
            if (s_OnBeforeBuildPackage != null)
            {
                s_OnBeforeBuildPackage(buildParam);
            }
        }

        /// <summary>
        /// 打包体后的回调
        /// </summary>
        internal static void OnAfterBuildPackage(BuildParams buildParam, bool success)
        {
            SceneTool.RefreshSettingList(false);
            if (s_OnAfterBuildPackage != null)
            {
                s_OnAfterBuildPackage(buildParam);
            }
        }
    }
}