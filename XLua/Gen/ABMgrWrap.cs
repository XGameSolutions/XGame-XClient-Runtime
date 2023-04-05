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
    public class ABMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ABMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 4, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAB", _m_LoadAB_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadLuaFile", _m_LoadLuaFile_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "patchPath", _g_get_patchPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "abPath", _g_get_abPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "abPlatform", _g_get_abPlatform);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "protocal", _g_get_protocal);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "patchPath", _s_set_patchPath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "abPath", _s_set_abPath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "abPlatform", _s_set_abPlatform);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "protocal", _s_set_protocal);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ABMgr gen_ret = new ABMgr();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ABMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _abName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AssetBundle gen_ret = ABMgr.LoadAB( _abName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadLuaFile_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filePath = LuaAPI.lua_tostring(L, 1);
                    
                        byte[] gen_ret = ABMgr.LoadLuaFile( _filePath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_patchPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ABMgr.patchPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_abPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ABMgr.abPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_abPlatform(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ABMgr.abPlatform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_protocal(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ABMgr.protocal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_patchPath(RealStatePtr L)
        {
		    try {
                
			    ABMgr.patchPath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_abPath(RealStatePtr L)
        {
		    try {
                
			    ABMgr.abPath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_abPlatform(RealStatePtr L)
        {
		    try {
                
			    ABMgr.abPlatform = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_protocal(RealStatePtr L)
        {
		    try {
                
			    ABMgr.protocal = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
