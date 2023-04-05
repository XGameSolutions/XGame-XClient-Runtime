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
    public class XDebugHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XDebug.Helper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 13, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetNowTime", _m_GetNowTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HideAllObject", _m_HideAllObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DestoryAllChilds", _m_DestoryAllChilds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFullName", _m_GetFullName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddObject", _m_AddObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddTextObject", _m_AddTextObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddButtonObject", _m_AddButtonObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsValueEqualsColor", _m_IsValueEqualsColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseFloatFromString", _m_ParseFloatFromString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseStringFromString", _m_ParseStringFromString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetColor", _m_GetColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddEventListener", _m_AddEventListener_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XDebug.Helper gen_ret = new XDebug.Helper();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Helper constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNowTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        string gen_ret = XDebug.Helper.GetNowTime(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HideAllObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.GameObject _obj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string _match = LuaAPI.lua_tostring(L, 2);
                    
                    XDebug.Helper.HideAllObject( _obj, _match );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject _obj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    XDebug.Helper.HideAllObject( _obj );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string _match = LuaAPI.lua_tostring(L, 2);
                    
                    XDebug.Helper.HideAllObject( _parent, _match );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Transform>(L, 1)) 
                {
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                    XDebug.Helper.HideAllObject( _parent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Helper.HideAllObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestoryAllChilds_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                    XDebug.Helper.DestoryAllChilds( _parent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFullName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform _transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        string gen_ret = XDebug.Helper.GetFullName( _transform );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Vector2 _anchorMin;translator.Get(L, 3, out _anchorMin);
                    UnityEngine.Vector2 _anchorMax;translator.Get(L, 4, out _anchorMax);
                    UnityEngine.Vector2 _pivot;translator.Get(L, 5, out _pivot);
                    UnityEngine.Vector2 _sizeDelta;translator.Get(L, 6, out _sizeDelta);
                    
                        UnityEngine.GameObject gen_ret = XDebug.Helper.AddObject( _name, _parent, _anchorMin, _anchorMax, _pivot, _sizeDelta );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTextObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 11&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Font>(L, 3)&& translator.Assignable<UnityEngine.Color>(L, 4)&& translator.Assignable<UnityEngine.TextAnchor>(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& translator.Assignable<UnityEngine.Vector2>(L, 7)&& translator.Assignable<UnityEngine.Vector2>(L, 8)&& translator.Assignable<UnityEngine.Vector2>(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Font _font = (UnityEngine.Font)translator.GetObject(L, 3, typeof(UnityEngine.Font));
                    UnityEngine.Color _color;translator.Get(L, 4, out _color);
                    UnityEngine.TextAnchor _anchor;translator.Get(L, 5, out _anchor);
                    UnityEngine.Vector2 _anchorMin;translator.Get(L, 6, out _anchorMin);
                    UnityEngine.Vector2 _anchorMax;translator.Get(L, 7, out _anchorMax);
                    UnityEngine.Vector2 _pivot;translator.Get(L, 8, out _pivot);
                    UnityEngine.Vector2 _sizeDelta;translator.Get(L, 9, out _sizeDelta);
                    int _fontSize = LuaAPI.xlua_tointeger(L, 10);
                    float _textRotation = (float)LuaAPI.lua_tonumber(L, 11);
                    
                        UnityEngine.UI.Text gen_ret = XDebug.Helper.AddTextObject( _name, _parent, _font, _color, _anchor, _anchorMin, _anchorMax, _pivot, _sizeDelta, _fontSize, _textRotation );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 10&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Font>(L, 3)&& translator.Assignable<UnityEngine.Color>(L, 4)&& translator.Assignable<UnityEngine.TextAnchor>(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& translator.Assignable<UnityEngine.Vector2>(L, 7)&& translator.Assignable<UnityEngine.Vector2>(L, 8)&& translator.Assignable<UnityEngine.Vector2>(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Font _font = (UnityEngine.Font)translator.GetObject(L, 3, typeof(UnityEngine.Font));
                    UnityEngine.Color _color;translator.Get(L, 4, out _color);
                    UnityEngine.TextAnchor _anchor;translator.Get(L, 5, out _anchor);
                    UnityEngine.Vector2 _anchorMin;translator.Get(L, 6, out _anchorMin);
                    UnityEngine.Vector2 _anchorMax;translator.Get(L, 7, out _anchorMax);
                    UnityEngine.Vector2 _pivot;translator.Get(L, 8, out _pivot);
                    UnityEngine.Vector2 _sizeDelta;translator.Get(L, 9, out _sizeDelta);
                    int _fontSize = LuaAPI.xlua_tointeger(L, 10);
                    
                        UnityEngine.UI.Text gen_ret = XDebug.Helper.AddTextObject( _name, _parent, _font, _color, _anchor, _anchorMin, _anchorMax, _pivot, _sizeDelta, _fontSize );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Font>(L, 3)&& translator.Assignable<UnityEngine.Color>(L, 4)&& translator.Assignable<UnityEngine.TextAnchor>(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& translator.Assignable<UnityEngine.Vector2>(L, 7)&& translator.Assignable<UnityEngine.Vector2>(L, 8)&& translator.Assignable<UnityEngine.Vector2>(L, 9)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Font _font = (UnityEngine.Font)translator.GetObject(L, 3, typeof(UnityEngine.Font));
                    UnityEngine.Color _color;translator.Get(L, 4, out _color);
                    UnityEngine.TextAnchor _anchor;translator.Get(L, 5, out _anchor);
                    UnityEngine.Vector2 _anchorMin;translator.Get(L, 6, out _anchorMin);
                    UnityEngine.Vector2 _anchorMax;translator.Get(L, 7, out _anchorMax);
                    UnityEngine.Vector2 _pivot;translator.Get(L, 8, out _pivot);
                    UnityEngine.Vector2 _sizeDelta;translator.Get(L, 9, out _sizeDelta);
                    
                        UnityEngine.UI.Text gen_ret = XDebug.Helper.AddTextObject( _name, _parent, _font, _color, _anchor, _anchorMin, _anchorMax, _pivot, _sizeDelta );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XDebug.Helper.AddTextObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddButtonObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Font _font = (UnityEngine.Font)translator.GetObject(L, 3, typeof(UnityEngine.Font));
                    int _fontSize = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Color _color;translator.Get(L, 5, out _color);
                    UnityEngine.TextAnchor _anchor;translator.Get(L, 6, out _anchor);
                    UnityEngine.Vector2 _anchorMin;translator.Get(L, 7, out _anchorMin);
                    UnityEngine.Vector2 _anchorMax;translator.Get(L, 8, out _anchorMax);
                    UnityEngine.Vector2 _pivot;translator.Get(L, 9, out _pivot);
                    UnityEngine.Vector2 _sizeDelta;translator.Get(L, 10, out _sizeDelta);
                    
                        UnityEngine.UI.Button gen_ret = XDebug.Helper.AddButtonObject( _name, _parent, _font, _fontSize, _color, _anchor, _anchorMin, _anchorMax, _pivot, _sizeDelta );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsValueEqualsColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Color32 _color1;translator.Get(L, 1, out _color1);
                    UnityEngine.Color32 _color2;translator.Get(L, 2, out _color2);
                    
                        bool gen_ret = XDebug.Helper.IsValueEqualsColor( _color1, _color2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseFloatFromString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _jsonData = LuaAPI.lua_tostring(L, 1);
                    
                        System.Collections.Generic.List<float> gen_ret = XDebug.Helper.ParseFloatFromString( _jsonData );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseStringFromString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _jsonData = LuaAPI.lua_tostring(L, 1);
                    
                        System.Collections.Generic.List<string> gen_ret = XDebug.Helper.ParseStringFromString( _jsonData );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _hexColorStr = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Color32 gen_ret = XDebug.Helper.GetColor( _hexColorStr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddEventListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject _obj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    UnityEngine.EventSystems.EventTriggerType _type;translator.Get(L, 2, out _type);
                    UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData> _call = translator.GetDelegate<UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>>(L, 3);
                    
                    XDebug.Helper.AddEventListener( _obj, _type, _call );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
