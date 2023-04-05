#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class XDebugXLogMyInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XDebug.XLog.MyInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 24, 17);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "deviceName", _g_get_deviceName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deviceId", _g_get_deviceId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "os", _g_get_os);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "osVersion", _g_get_osVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cpu", _g_get_cpu);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gpu", _g_get_gpu);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "networkType", _g_get_networkType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "networkOperator", _g_get_networkOperator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameTime", _g_get_gameTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "apkVersion", _g_get_apkVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "latestAssetVersion", _g_get_latestAssetVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localAssetVersion", _g_get_localAssetVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "runMode", _g_get_runMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "serverType", _g_get_serverType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sdkPlatformId", _g_get_sdkPlatformId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sdkPlatformTag", _g_get_sdkPlatformTag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "suid", _g_get_suid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sdkPlatformName", _g_get_sdkPlatformName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "roleName", _g_get_roleName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "roleId", _g_get_roleId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lbsProvinceCode", _g_get_lbsProvinceCode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lbsCity", _g_get_lbsCity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lbsIp", _g_get_lbsIp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mapId", _g_get_mapId);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "networkType", _s_set_networkType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "networkOperator", _s_set_networkOperator);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "apkVersion", _s_set_apkVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "latestAssetVersion", _s_set_latestAssetVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localAssetVersion", _s_set_localAssetVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "runMode", _s_set_runMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "serverType", _s_set_serverType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sdkPlatformId", _s_set_sdkPlatformId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sdkPlatformTag", _s_set_sdkPlatformTag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "suid", _s_set_suid);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sdkPlatformName", _s_set_sdkPlatformName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "roleName", _s_set_roleName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "roleId", _s_set_roleId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lbsProvinceCode", _s_set_lbsProvinceCode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lbsCity", _s_set_lbsCity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lbsIp", _s_set_lbsIp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mapId", _s_set_mapId);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XDebug.XLog.MyInfo gen_ret = new XDebug.XLog.MyInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.XLog.MyInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Init(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.deviceName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.deviceId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_os(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.os);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_osVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.osVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cpu(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.cpu);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gpu(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.gpu);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_networkType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.networkType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_networkOperator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.networkOperator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gameTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.gameTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_apkVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.apkVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_latestAssetVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.latestAssetVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localAssetVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.localAssetVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_runMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.runMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_serverType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.serverType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sdkPlatformId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sdkPlatformId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sdkPlatformTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.sdkPlatformTag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_suid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.suid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sdkPlatformName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.sdkPlatformName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_roleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.roleName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_roleId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.roleId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lbsProvinceCode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.lbsProvinceCode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lbsCity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.lbsCity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lbsIp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.lbsIp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mapId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.mapId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_networkType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.networkType = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_networkOperator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.networkOperator = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_apkVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.apkVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_latestAssetVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.latestAssetVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_localAssetVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.localAssetVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_runMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.runMode = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_serverType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.serverType = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sdkPlatformId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sdkPlatformId = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sdkPlatformTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sdkPlatformTag = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_suid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.suid = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sdkPlatformName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sdkPlatformName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_roleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.roleName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_roleId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.roleId = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lbsProvinceCode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lbsProvinceCode = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lbsCity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lbsCity = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lbsIp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lbsIp = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mapId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.XLog.MyInfo gen_to_be_invoked = (XDebug.XLog.MyInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mapId = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
