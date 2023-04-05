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
    public class XDebugModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XDebug.Module);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 7, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "type", _g_get_type);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "key", _g_get_key);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "color", _g_get_color);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "panel", _g_get_panel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "button", _g_get_button);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", _g_get_text);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "type", _s_set_type);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "key", _s_set_key);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "color", _s_set_color);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "panel", _s_set_panel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "button", _s_set_button);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", _s_set_text);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultModules", _g_get_defaultModules);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XDebug.Module gen_ret = new XDebug.Module();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Module constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<XDebug.Module>(L, 2)) 
                {
                    XDebug.Module _other = (XDebug.Module)translator.GetObject(L, 2, typeof(XDebug.Module));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Module.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_type(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                translator.PushXDebugModuleType(L, gen_to_be_invoked.type);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_key(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.key);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_color(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.color);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.panel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_button(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.button);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultModules(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.Module.defaultModules);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_type(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                XDebug.Module.Type gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.type = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_key(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.key = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_color(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.color = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.panel = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_button(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.button = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Module gen_to_be_invoked = (XDebug.Module)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.text = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
