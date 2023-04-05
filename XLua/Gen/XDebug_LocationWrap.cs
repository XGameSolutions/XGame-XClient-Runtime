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
    public class XDebugLocationWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XDebug.Location);
			Utils.BeginObjectRegister(type, L, translator, 1, 5, 9, 5);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPosition", _m_GetPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Copy", _m_Copy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnChanged", _m_OnChanged);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "align", _g_get_align);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "left", _g_get_left);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "right", _g_get_right);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "top", _g_get_top);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bottom", _g_get_bottom);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textAnchor", _g_get_textAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorMin", _g_get_anchorMin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorMax", _g_get_anchorMax);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", _g_get_pivot);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "align", _s_set_align);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "left", _s_set_left);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "right", _s_set_right);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "top", _s_set_top);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bottom", _s_set_bottom);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 4, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultLeft", _g_get_defaultLeft);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultRight", _g_get_defaultRight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultTop", _g_get_defaultTop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultBottom", _g_get_defaultBottom);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XDebug.Location gen_ret = new XDebug.Location();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Location constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<XDebug.Location>(L, 1) && translator.Assignable<XDebug.Location>(L, 2))
				{
					XDebug.Location leftside = (XDebug.Location)translator.GetObject(L, 1, typeof(XDebug.Location));
					XDebug.Location rightside = (XDebug.Location)translator.GetObject(L, 2, typeof(XDebug.Location));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need XDebug.Location!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _chartWidht = (float)LuaAPI.lua_tonumber(L, 2);
                    float _chartHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector2 gen_ret = gen_to_be_invoked.GetPosition( _chartWidht, _chartHeight );
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
            
            
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XDebug.Location _location = (XDebug.Location)translator.GetObject(L, 2, typeof(XDebug.Location));
                    
                    gen_to_be_invoked.Copy( _location );
                    
                    
                    
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
            
            
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<XDebug.Location>(L, 2)) 
                {
                    XDebug.Location _other = (XDebug.Location)translator.GetObject(L, 2, typeof(XDebug.Location));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Location.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OnChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnChanged(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_align(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                translator.PushXDebugLocationAlign(L, gen_to_be_invoked.align);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_left(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.left);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_right(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.right);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_top(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.top);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bottom(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.bottom);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_textAnchor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineTextAnchor(L, gen_to_be_invoked.textAnchor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_anchorMin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.anchorMin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_anchorMax(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.anchorMax);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.pivot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultLeft(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.Location.defaultLeft);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultRight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.Location.defaultRight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultTop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.Location.defaultTop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultBottom(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XDebug.Location.defaultBottom);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_align(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                XDebug.Location.Align gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.align = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_left(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.left = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_right(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.right = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_top(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.top = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bottom(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XDebug.Location gen_to_be_invoked = (XDebug.Location)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bottom = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
