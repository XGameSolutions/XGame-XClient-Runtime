
using UnityEngine;
using XCommon.Runtime;

public class ABMgr : XMonoSingleton<ABMgr>
{
    private const string EDITOR_AB_DIR = "ResAB";
    private static AssetBundle s_ABLua;
    private static AssetBundle s_ABCfg;

    public static string patchPath;
    public static string abPath;
    public static string abPlatform;
    public static string protocal;

    protected override void OnInit()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            abPlatform = "Android";
            protocal = "";
            abPath = string.Format("{0}!assets/", Application.dataPath);
            patchPath = string.Format("{0}/patch/", Application.persistentDataPath);
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            abPlatform = "iOS";
            protocal = "file://";
            abPath = string.Format("{0}/", Application.streamingAssetsPath);
            patchPath = string.Format("{0}/patch/", Application.persistentDataPath);
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            abPlatform = "StandaloneWindows";
            protocal = "file:///";
            abPath = string.Format("{0}/../{1}/{2}/{3}/", Application.dataPath, EDITOR_AB_DIR, abPlatform, abPlatform);
            patchPath = string.Format("{0}/../patch/", Application.dataPath);
        }
        else if (Application.platform == RuntimePlatform.OSXEditor)
        {
            abPlatform = "StandaloneOSX";
            protocal = "file://";
            abPath = string.Format("{0}/../{1}/{2}/{3}/", Application.dataPath, EDITOR_AB_DIR, abPlatform, abPlatform);
            patchPath = string.Format("{0}/../patch/", Application.dataPath);
        }
    }

    public static AssetBundle LoadAB(string abName)
    {
        var path = string.Format("{0}/../{1}/{2}", Application.dataPath, EDITOR_AB_DIR, abName);
        return AssetBundle.LoadFromFile(path);
    }

    public static byte[] LoadLuaFile(string filePath)
    {
        if (!string.IsNullOrEmpty(patchPath))
        {

        }
        if (App.Instance.IsAbLua)
        {

        }
        if (App.Instance.IsAbCfg)
        {

        }
        return null;
    }
}