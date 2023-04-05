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
    public class XDebugModulesWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XDebug.Modules);
			Utils.BeginObjectRegister(type, L, translator, 1, 6, 5, 5);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetModulesWidth", _m_GetModulesWidth);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetModulesPosition", _m_GetModulesPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetModulePosition", _m_GetModulePosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Copy", _m_Copy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "orient", _g_get_orient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gap", _g_get_gap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "moduleList", _g_get_moduleList);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "orient", _s_set_orient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gap", _s_set_gap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "width", _s_set_width);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "height", _s_set_height);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "moduleList", _s_set_moduleList);
            
			
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
					
					XDebug.Modules gen_ret = new XDebug.Modules();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Modules constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<XDebug.Modules>(L, 1) && translator.Assignable<XDebug.Modules>(L, 2))
				{
					XDebug.Modules leftside = (XDebug.Modules)translator.GetObject(L, 1, typeof(XDebug.Modules));
					XDebug.Modules rightside = (XDebug.Modules)translator.GetObject(L, 2, typeof(XDebug.Modules));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need XDebug.Modules!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetModulesWidth(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        float gen_ret = gen_to_be_invoked.GetModulesWidth(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetModulesPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XDebug.Location _location = (XDebug.Location)translator.GetObject(L, 2, typeof(XDebug.Location));
                    XDebug.Icon _icon = (XDebug.Icon)translator.GetObject(L, 3, typeof(XDebug.Icon));
                    
                        UnityEngine.Vector2 gen_ret = gen_to_be_invoked.GetModulesPosition( _location, _icon );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetModulePosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XDebug.Location _location = (XDebug.Location)translator.GetObject(L, 2, typeof(XDebug.Location));
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Vector2 gen_ret = gen_to_be_invoked.GetModulePosition( _location, _index );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Copy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XDebug.Modules _modules = (XDebug.Modules)translator.GetObject(L, 2, typeof(XDebug.Modules));
                    
                    gen_to_be_invoked.Copy( _modules );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<XDebug.Modules>(L, 2)) 
                {
                    XDebug.Modules _other = (XDebug.Modules)translator.GetObject(L, 2, typeof(XDebug.Modules));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Modules.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_orient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                translator.PushXDebugOrient(L, gen_to_be_invoked.orient);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.width);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_height(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.height);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_moduleList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.moduleList);
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
			    translator.Push(L, XDebug.Modules.defaultModules);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_orient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                XDebug.Orient gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.orient = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gap = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.width = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_height(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.height = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_moduleList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Modules gen_to_be_invoked = (XDebug.Modules)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.moduleList = (System.Collections.Generic.List<XDebug.Module>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<XDebug.Module>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
