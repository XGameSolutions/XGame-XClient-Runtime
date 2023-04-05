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
    public class XDebugXLogWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XDebug.XLog);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 5, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddLevel", _m_AddLevel_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearLevel", _m_ClearLevel_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Debug", _m_Debug_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Warn", _m_Warn_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Info", _m_Info_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Proto", _m_Proto_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Vital", _m_Vital_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Error", _m_Error_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLogInfo", _m_GetLogInfo_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "errorCount", _g_get_errorCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "exceptionCount", _g_get_exceptionCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "myInfo", _g_get_myInfo);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sb", _g_get_sb);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "errorCount", _s_set_errorCount);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "exceptionCount", _s_set_exceptionCount);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "myInfo", _s_set_myInfo);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "sb", _s_set_sb);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XDebug.XLog gen_ret = new XDebug.XLog();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.XLog constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.XLog gen_to_be_invoked = (XDebug.XLog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Init(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLevel_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _level = LuaAPI.xlua_tointeger(L, 1);
                    
                    XDebug.XLog.AddLevel( _level );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<XDebug.XLog.LogLevel>(L, 1)) 
                {
                    XDebug.XLog.LogLevel _level;translator.Get(L, 1, out _level);
                    
                    XDebug.XLog.AddLevel( _level );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.XLog.AddLevel!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearLevel_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    XDebug.XLog.ClearLevel(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Debug_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    XDebug.XLog.Debug( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Warn_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    XDebug.XLog.Warn( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Info_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    XDebug.XLog.Info( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Proto_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    XDebug.XLog.Proto( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Vital_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    XDebug.XLog.Vital( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Error_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    XDebug.XLog.Error( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLogInfo_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = XDebug.XLog.GetLogInfo( _log );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.XLog.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_errorCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, XDebug.XLog.errorCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_exceptionCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, XDebug.XLog.exceptionCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_myInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.XLog.myInfo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.XLog.sb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_errorCount(RealStatePtr L)
        {
		    try {
                
			    XDebug.XLog.errorCount = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_exceptionCount(RealStatePtr L)
        {
		    try {
                
			    XDebug.XLog.exceptionCount = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_myInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    XDebug.XLog.myInfo = (XDebug.XLog.MyInfo)translator.GetObject(L, 1, typeof(XDebug.XLog.MyInfo));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    XDebug.XLog.sb = (System.Text.StringBuilder)translator.GetObject(L, 1, typeof(System.Text.StringBuilder));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
