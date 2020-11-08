
using System;
using UnityEditor;
using UnityEngine;

namespace XBuild
{
    [Serializable]
    public class BuildConfig : ScriptableObject
    {
        public const string configPath = "Assets/Src/XBuild/Editor/config.asset";
        public string abDir = "ResAB/";
        public string abDirRelativeToDataPath = "/../ResAB/";
        public string startScenePath = "Assets/Plugins/start.unity";
        public string startSceneInitObjectPath = "init";
        public string productName = "xgame";
        public string companyName = "monitor1394";
        public string apkFileName = "xgame";
        public string applicationIdentifier = "com.monitor1394.xgame";

        public static BuildConfig GetConfig()
        {
            var config = AssetDatabase.LoadAssetAtPath<BuildConfig>(configPath);
            if (config != null) return config;
            else return new BuildConfig();
        }
    }
}