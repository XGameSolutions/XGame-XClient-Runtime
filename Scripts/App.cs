using System.IO;
using UnityEngine;
using XLua;
using XDebug;
using XRemoteDebug;
using XCommon.Runtime;

public class App : XMonoSingleton<App>
{
    public int type = 0;
    public bool IsAbRes = false;
    public bool IsAbLua = false;
    public bool IsAbCfg = false;

    protected override void OnInit()
    {
        if (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.WindowsPlayer ||
            Application.platform == RuntimePlatform.IPhonePlayer)
        {
            IsAbRes = true;
            IsAbLua = true;
            IsAbCfg = true;
        }
        XLog.Instance.Init();
        ABMgr.Instance.Init();
        XLuaMgr.Instance.Init();
        RemoteDebugClient.Instance.Init();
    }


    public override void Startup()
    {
        XLuaMgr.Instance.Startup();
    }

    private void OnDestroy()
    {
    }
}
