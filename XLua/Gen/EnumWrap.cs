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
    
    public class UnityEngineAvatarTargetWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AvatarTarget), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AvatarTarget), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AvatarTarget), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Root", UnityEngine.AvatarTarget.Root);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Body", UnityEngine.AvatarTarget.Body);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftFoot", UnityEngine.AvatarTarget.LeftFoot);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightFoot", UnityEngine.AvatarTarget.RightFoot);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftHand", UnityEngine.AvatarTarget.LeftHand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightHand", UnityEngine.AvatarTarget.RightHand);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AvatarTarget), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAvatarTarget(L, (UnityEngine.AvatarTarget)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Root"))
                {
                    translator.PushUnityEngineAvatarTarget(L, UnityEngine.AvatarTarget.Root);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Body"))
                {
                    translator.PushUnityEngineAvatarTarget(L, UnityEngine.AvatarTarget.Body);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftFoot"))
                {
                    translator.PushUnityEngineAvatarTarget(L, UnityEngine.AvatarTarget.LeftFoot);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightFoot"))
                {
                    translator.PushUnityEngineAvatarTarget(L, UnityEngine.AvatarTarget.RightFoot);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftHand"))
                {
                    translator.PushUnityEngineAvatarTarget(L, UnityEngine.AvatarTarget.LeftHand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightHand"))
                {
                    translator.PushUnityEngineAvatarTarget(L, UnityEngine.AvatarTarget.RightHand);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AvatarTarget!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AvatarTarget! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAvatarIKGoalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AvatarIKGoal), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AvatarIKGoal), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AvatarIKGoal), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftFoot", UnityEngine.AvatarIKGoal.LeftFoot);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightFoot", UnityEngine.AvatarIKGoal.RightFoot);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftHand", UnityEngine.AvatarIKGoal.LeftHand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightHand", UnityEngine.AvatarIKGoal.RightHand);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AvatarIKGoal), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAvatarIKGoal(L, (UnityEngine.AvatarIKGoal)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftFoot"))
                {
                    translator.PushUnityEngineAvatarIKGoal(L, UnityEngine.AvatarIKGoal.LeftFoot);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightFoot"))
                {
                    translator.PushUnityEngineAvatarIKGoal(L, UnityEngine.AvatarIKGoal.RightFoot);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftHand"))
                {
                    translator.PushUnityEngineAvatarIKGoal(L, UnityEngine.AvatarIKGoal.LeftHand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightHand"))
                {
                    translator.PushUnityEngineAvatarIKGoal(L, UnityEngine.AvatarIKGoal.RightHand);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AvatarIKGoal!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AvatarIKGoal! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAvatarIKHintWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AvatarIKHint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AvatarIKHint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AvatarIKHint), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftKnee", UnityEngine.AvatarIKHint.LeftKnee);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightKnee", UnityEngine.AvatarIKHint.RightKnee);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftElbow", UnityEngine.AvatarIKHint.LeftElbow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightElbow", UnityEngine.AvatarIKHint.RightElbow);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AvatarIKHint), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAvatarIKHint(L, (UnityEngine.AvatarIKHint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftKnee"))
                {
                    translator.PushUnityEngineAvatarIKHint(L, UnityEngine.AvatarIKHint.LeftKnee);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightKnee"))
                {
                    translator.PushUnityEngineAvatarIKHint(L, UnityEngine.AvatarIKHint.RightKnee);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftElbow"))
                {
                    translator.PushUnityEngineAvatarIKHint(L, UnityEngine.AvatarIKHint.LeftElbow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightElbow"))
                {
                    translator.PushUnityEngineAvatarIKHint(L, UnityEngine.AvatarIKHint.RightElbow);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AvatarIKHint!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AvatarIKHint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnimatorControllerParameterTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnimatorControllerParameterType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnimatorControllerParameterType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnimatorControllerParameterType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Float", UnityEngine.AnimatorControllerParameterType.Float);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Int", UnityEngine.AnimatorControllerParameterType.Int);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bool", UnityEngine.AnimatorControllerParameterType.Bool);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Trigger", UnityEngine.AnimatorControllerParameterType.Trigger);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnimatorControllerParameterType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnimatorControllerParameterType(L, (UnityEngine.AnimatorControllerParameterType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Float"))
                {
                    translator.PushUnityEngineAnimatorControllerParameterType(L, UnityEngine.AnimatorControllerParameterType.Float);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Int"))
                {
                    translator.PushUnityEngineAnimatorControllerParameterType(L, UnityEngine.AnimatorControllerParameterType.Int);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bool"))
                {
                    translator.PushUnityEngineAnimatorControllerParameterType(L, UnityEngine.AnimatorControllerParameterType.Bool);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Trigger"))
                {
                    translator.PushUnityEngineAnimatorControllerParameterType(L, UnityEngine.AnimatorControllerParameterType.Trigger);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnimatorControllerParameterType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnimatorControllerParameterType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnimatorRecorderModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnimatorRecorderMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnimatorRecorderMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnimatorRecorderMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Offline", UnityEngine.AnimatorRecorderMode.Offline);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Playback", UnityEngine.AnimatorRecorderMode.Playback);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Record", UnityEngine.AnimatorRecorderMode.Record);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnimatorRecorderMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnimatorRecorderMode(L, (UnityEngine.AnimatorRecorderMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Offline"))
                {
                    translator.PushUnityEngineAnimatorRecorderMode(L, UnityEngine.AnimatorRecorderMode.Offline);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Playback"))
                {
                    translator.PushUnityEngineAnimatorRecorderMode(L, UnityEngine.AnimatorRecorderMode.Playback);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Record"))
                {
                    translator.PushUnityEngineAnimatorRecorderMode(L, UnityEngine.AnimatorRecorderMode.Record);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnimatorRecorderMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnimatorRecorderMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineDurationUnitWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.DurationUnit), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.DurationUnit), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.DurationUnit), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed", UnityEngine.DurationUnit.Fixed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normalized", UnityEngine.DurationUnit.Normalized);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.DurationUnit), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineDurationUnit(L, (UnityEngine.DurationUnit)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed"))
                {
                    translator.PushUnityEngineDurationUnit(L, UnityEngine.DurationUnit.Fixed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normalized"))
                {
                    translator.PushUnityEngineDurationUnit(L, UnityEngine.DurationUnit.Normalized);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.DurationUnit!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.DurationUnit! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnimatorCullingModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnimatorCullingMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnimatorCullingMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnimatorCullingMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AlwaysAnimate", UnityEngine.AnimatorCullingMode.AlwaysAnimate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CullUpdateTransforms", UnityEngine.AnimatorCullingMode.CullUpdateTransforms);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CullCompletely", UnityEngine.AnimatorCullingMode.CullCompletely);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnimatorCullingMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnimatorCullingMode(L, (UnityEngine.AnimatorCullingMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "AlwaysAnimate"))
                {
                    translator.PushUnityEngineAnimatorCullingMode(L, UnityEngine.AnimatorCullingMode.AlwaysAnimate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CullUpdateTransforms"))
                {
                    translator.PushUnityEngineAnimatorCullingMode(L, UnityEngine.AnimatorCullingMode.CullUpdateTransforms);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CullCompletely"))
                {
                    translator.PushUnityEngineAnimatorCullingMode(L, UnityEngine.AnimatorCullingMode.CullCompletely);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnimatorCullingMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnimatorCullingMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnimatorUpdateModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnimatorUpdateMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnimatorUpdateMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnimatorUpdateMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", UnityEngine.AnimatorUpdateMode.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AnimatePhysics", UnityEngine.AnimatorUpdateMode.AnimatePhysics);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnscaledTime", UnityEngine.AnimatorUpdateMode.UnscaledTime);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnimatorUpdateMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnimatorUpdateMode(L, (UnityEngine.AnimatorUpdateMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushUnityEngineAnimatorUpdateMode(L, UnityEngine.AnimatorUpdateMode.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AnimatePhysics"))
                {
                    translator.PushUnityEngineAnimatorUpdateMode(L, UnityEngine.AnimatorUpdateMode.AnimatePhysics);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UnscaledTime"))
                {
                    translator.PushUnityEngineAnimatorUpdateMode(L, UnityEngine.AnimatorUpdateMode.UnscaledTime);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnimatorUpdateMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnimatorUpdateMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineBodyDofWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.BodyDof), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.BodyDof), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.BodyDof), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpineFrontBack", UnityEngine.BodyDof.SpineFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpineLeftRight", UnityEngine.BodyDof.SpineLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpineRollLeftRight", UnityEngine.BodyDof.SpineRollLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChestFrontBack", UnityEngine.BodyDof.ChestFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChestLeftRight", UnityEngine.BodyDof.ChestLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChestRollLeftRight", UnityEngine.BodyDof.ChestRollLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperChestFrontBack", UnityEngine.BodyDof.UpperChestFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperChestLeftRight", UnityEngine.BodyDof.UpperChestLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperChestRollLeftRight", UnityEngine.BodyDof.UpperChestRollLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LastBodyDof", UnityEngine.BodyDof.LastBodyDof);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.BodyDof), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineBodyDof(L, (UnityEngine.BodyDof)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "SpineFrontBack"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.SpineFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpineLeftRight"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.SpineLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpineRollLeftRight"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.SpineRollLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ChestFrontBack"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.ChestFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ChestLeftRight"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.ChestLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ChestRollLeftRight"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.ChestRollLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperChestFrontBack"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.UpperChestFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperChestLeftRight"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.UpperChestLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperChestRollLeftRight"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.UpperChestRollLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LastBodyDof"))
                {
                    translator.PushUnityEngineBodyDof(L, UnityEngine.BodyDof.LastBodyDof);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.BodyDof!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.BodyDof! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineHeadDofWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.HeadDof), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.HeadDof), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.HeadDof), L, null, 14, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NeckFrontBack", UnityEngine.HeadDof.NeckFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NeckLeftRight", UnityEngine.HeadDof.NeckLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NeckRollLeftRight", UnityEngine.HeadDof.NeckRollLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HeadFrontBack", UnityEngine.HeadDof.HeadFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HeadLeftRight", UnityEngine.HeadDof.HeadLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HeadRollLeftRight", UnityEngine.HeadDof.HeadRollLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftEyeDownUp", UnityEngine.HeadDof.LeftEyeDownUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftEyeInOut", UnityEngine.HeadDof.LeftEyeInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightEyeDownUp", UnityEngine.HeadDof.RightEyeDownUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightEyeInOut", UnityEngine.HeadDof.RightEyeInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JawDownUp", UnityEngine.HeadDof.JawDownUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JawLeftRight", UnityEngine.HeadDof.JawLeftRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LastHeadDof", UnityEngine.HeadDof.LastHeadDof);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.HeadDof), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineHeadDof(L, (UnityEngine.HeadDof)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "NeckFrontBack"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.NeckFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NeckLeftRight"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.NeckLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NeckRollLeftRight"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.NeckRollLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HeadFrontBack"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.HeadFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HeadLeftRight"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.HeadLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HeadRollLeftRight"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.HeadRollLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftEyeDownUp"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.LeftEyeDownUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftEyeInOut"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.LeftEyeInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightEyeDownUp"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.RightEyeDownUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightEyeInOut"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.RightEyeInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JawDownUp"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.JawDownUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JawLeftRight"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.JawLeftRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LastHeadDof"))
                {
                    translator.PushUnityEngineHeadDof(L, UnityEngine.HeadDof.LastHeadDof);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.HeadDof!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.HeadDof! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineLegDofWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.LegDof), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.LegDof), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.LegDof), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLegFrontBack", UnityEngine.LegDof.UpperLegFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLegInOut", UnityEngine.LegDof.UpperLegInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLegRollInOut", UnityEngine.LegDof.UpperLegRollInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LegCloseOpen", UnityEngine.LegDof.LegCloseOpen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LegRollInOut", UnityEngine.LegDof.LegRollInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FootCloseOpen", UnityEngine.LegDof.FootCloseOpen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FootInOut", UnityEngine.LegDof.FootInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ToesUpDown", UnityEngine.LegDof.ToesUpDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LastLegDof", UnityEngine.LegDof.LastLegDof);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.LegDof), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineLegDof(L, (UnityEngine.LegDof)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLegFrontBack"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.UpperLegFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLegInOut"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.UpperLegInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLegRollInOut"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.UpperLegRollInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LegCloseOpen"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.LegCloseOpen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LegRollInOut"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.LegRollInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FootCloseOpen"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.FootCloseOpen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FootInOut"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.FootInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ToesUpDown"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.ToesUpDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LastLegDof"))
                {
                    translator.PushUnityEngineLegDof(L, UnityEngine.LegDof.LastLegDof);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.LegDof!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.LegDof! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineArmDofWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ArmDof), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ArmDof), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ArmDof), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ShoulderDownUp", UnityEngine.ArmDof.ShoulderDownUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ShoulderFrontBack", UnityEngine.ArmDof.ShoulderFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArmDownUp", UnityEngine.ArmDof.ArmDownUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArmFrontBack", UnityEngine.ArmDof.ArmFrontBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArmRollInOut", UnityEngine.ArmDof.ArmRollInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ForeArmCloseOpen", UnityEngine.ArmDof.ForeArmCloseOpen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ForeArmRollInOut", UnityEngine.ArmDof.ForeArmRollInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HandDownUp", UnityEngine.ArmDof.HandDownUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HandInOut", UnityEngine.ArmDof.HandInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LastArmDof", UnityEngine.ArmDof.LastArmDof);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ArmDof), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineArmDof(L, (UnityEngine.ArmDof)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ShoulderDownUp"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.ShoulderDownUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ShoulderFrontBack"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.ShoulderFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ArmDownUp"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.ArmDownUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ArmFrontBack"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.ArmFrontBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ArmRollInOut"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.ArmRollInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ForeArmCloseOpen"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.ForeArmCloseOpen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ForeArmRollInOut"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.ForeArmRollInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HandDownUp"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.HandDownUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HandInOut"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.HandInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LastArmDof"))
                {
                    translator.PushUnityEngineArmDof(L, UnityEngine.ArmDof.LastArmDof);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ArmDof!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ArmDof! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineFingerDofWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.FingerDof), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.FingerDof), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.FingerDof), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProximalDownUp", UnityEngine.FingerDof.ProximalDownUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProximalInOut", UnityEngine.FingerDof.ProximalInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IntermediateCloseOpen", UnityEngine.FingerDof.IntermediateCloseOpen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DistalCloseOpen", UnityEngine.FingerDof.DistalCloseOpen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LastFingerDof", UnityEngine.FingerDof.LastFingerDof);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.FingerDof), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineFingerDof(L, (UnityEngine.FingerDof)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ProximalDownUp"))
                {
                    translator.PushUnityEngineFingerDof(L, UnityEngine.FingerDof.ProximalDownUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProximalInOut"))
                {
                    translator.PushUnityEngineFingerDof(L, UnityEngine.FingerDof.ProximalInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IntermediateCloseOpen"))
                {
                    translator.PushUnityEngineFingerDof(L, UnityEngine.FingerDof.IntermediateCloseOpen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DistalCloseOpen"))
                {
                    translator.PushUnityEngineFingerDof(L, UnityEngine.FingerDof.DistalCloseOpen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LastFingerDof"))
                {
                    translator.PushUnityEngineFingerDof(L, UnityEngine.FingerDof.LastFingerDof);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.FingerDof!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.FingerDof! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineHumanPartDofWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.HumanPartDof), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.HumanPartDof), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.HumanPartDof), L, null, 18, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Body", UnityEngine.HumanPartDof.Body);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Head", UnityEngine.HumanPartDof.Head);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftLeg", UnityEngine.HumanPartDof.LeftLeg);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightLeg", UnityEngine.HumanPartDof.RightLeg);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftArm", UnityEngine.HumanPartDof.LeftArm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightArm", UnityEngine.HumanPartDof.RightArm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftThumb", UnityEngine.HumanPartDof.LeftThumb);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftIndex", UnityEngine.HumanPartDof.LeftIndex);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftMiddle", UnityEngine.HumanPartDof.LeftMiddle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftRing", UnityEngine.HumanPartDof.LeftRing);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftLittle", UnityEngine.HumanPartDof.LeftLittle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightThumb", UnityEngine.HumanPartDof.RightThumb);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightIndex", UnityEngine.HumanPartDof.RightIndex);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightMiddle", UnityEngine.HumanPartDof.RightMiddle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightRing", UnityEngine.HumanPartDof.RightRing);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightLittle", UnityEngine.HumanPartDof.RightLittle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LastHumanPartDof", UnityEngine.HumanPartDof.LastHumanPartDof);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.HumanPartDof), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineHumanPartDof(L, (UnityEngine.HumanPartDof)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Body"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.Body);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Head"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.Head);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftLeg"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LeftLeg);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightLeg"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.RightLeg);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftArm"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LeftArm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightArm"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.RightArm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftThumb"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LeftThumb);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftIndex"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LeftIndex);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftMiddle"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LeftMiddle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftRing"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LeftRing);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftLittle"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LeftLittle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightThumb"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.RightThumb);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightIndex"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.RightIndex);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightMiddle"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.RightMiddle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightRing"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.RightRing);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightLittle"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.RightLittle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LastHumanPartDof"))
                {
                    translator.PushUnityEngineHumanPartDof(L, UnityEngine.HumanPartDof.LastHumanPartDof);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.HumanPartDof!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.HumanPartDof! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineHumanBodyBonesWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.HumanBodyBones), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.HumanBodyBones), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.HumanBodyBones), L, null, 57, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.HumanBodyBones));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.HumanBodyBones), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineHumanBodyBones(L, (UnityEngine.HumanBodyBones)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.HumanBodyBones), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.HumanBodyBones) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.HumanBodyBones! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAvatarMaskBodyPartWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AvatarMaskBodyPart), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AvatarMaskBodyPart), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AvatarMaskBodyPart), L, null, 15, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Root", UnityEngine.AvatarMaskBodyPart.Root);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Body", UnityEngine.AvatarMaskBodyPart.Body);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Head", UnityEngine.AvatarMaskBodyPart.Head);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftLeg", UnityEngine.AvatarMaskBodyPart.LeftLeg);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightLeg", UnityEngine.AvatarMaskBodyPart.RightLeg);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftArm", UnityEngine.AvatarMaskBodyPart.LeftArm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightArm", UnityEngine.AvatarMaskBodyPart.RightArm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftFingers", UnityEngine.AvatarMaskBodyPart.LeftFingers);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightFingers", UnityEngine.AvatarMaskBodyPart.RightFingers);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftFootIK", UnityEngine.AvatarMaskBodyPart.LeftFootIK);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightFootIK", UnityEngine.AvatarMaskBodyPart.RightFootIK);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftHandIK", UnityEngine.AvatarMaskBodyPart.LeftHandIK);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightHandIK", UnityEngine.AvatarMaskBodyPart.RightHandIK);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LastBodyPart", UnityEngine.AvatarMaskBodyPart.LastBodyPart);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AvatarMaskBodyPart), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAvatarMaskBodyPart(L, (UnityEngine.AvatarMaskBodyPart)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Root"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.Root);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Body"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.Body);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Head"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.Head);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftLeg"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.LeftLeg);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightLeg"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.RightLeg);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftArm"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.LeftArm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightArm"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.RightArm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftFingers"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.LeftFingers);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightFingers"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.RightFingers);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftFootIK"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.LeftFootIK);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightFootIK"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.RightFootIK);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftHandIK"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.LeftHandIK);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightHandIK"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.RightHandIK);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LastBodyPart"))
                {
                    translator.PushUnityEngineAvatarMaskBodyPart(L, UnityEngine.AvatarMaskBodyPart.LastBodyPart);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AvatarMaskBodyPart!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AvatarMaskBodyPart! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEnginePlayModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.PlayMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.PlayMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.PlayMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StopSameLayer", UnityEngine.PlayMode.StopSameLayer);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StopAll", UnityEngine.PlayMode.StopAll);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.PlayMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEnginePlayMode(L, (UnityEngine.PlayMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "StopSameLayer"))
                {
                    translator.PushUnityEnginePlayMode(L, UnityEngine.PlayMode.StopSameLayer);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "StopAll"))
                {
                    translator.PushUnityEnginePlayMode(L, UnityEngine.PlayMode.StopAll);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.PlayMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.PlayMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineQueueModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.QueueMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.QueueMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.QueueMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompleteOthers", UnityEngine.QueueMode.CompleteOthers);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PlayNow", UnityEngine.QueueMode.PlayNow);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.QueueMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineQueueMode(L, (UnityEngine.QueueMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "CompleteOthers"))
                {
                    translator.PushUnityEngineQueueMode(L, UnityEngine.QueueMode.CompleteOthers);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PlayNow"))
                {
                    translator.PushUnityEngineQueueMode(L, UnityEngine.QueueMode.PlayNow);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.QueueMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.QueueMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnimationBlendModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnimationBlendMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnimationBlendMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnimationBlendMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Blend", UnityEngine.AnimationBlendMode.Blend);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Additive", UnityEngine.AnimationBlendMode.Additive);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnimationBlendMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnimationBlendMode(L, (UnityEngine.AnimationBlendMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Blend"))
                {
                    translator.PushUnityEngineAnimationBlendMode(L, UnityEngine.AnimationBlendMode.Blend);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Additive"))
                {
                    translator.PushUnityEngineAnimationBlendMode(L, UnityEngine.AnimationBlendMode.Additive);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnimationBlendMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnimationBlendMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnimationPlayModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnimationPlayMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnimationPlayMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnimationPlayMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stop", UnityEngine.AnimationPlayMode.Stop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Queue", UnityEngine.AnimationPlayMode.Queue);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mix", UnityEngine.AnimationPlayMode.Mix);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnimationPlayMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnimationPlayMode(L, (UnityEngine.AnimationPlayMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Stop"))
                {
                    translator.PushUnityEngineAnimationPlayMode(L, UnityEngine.AnimationPlayMode.Stop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Queue"))
                {
                    translator.PushUnityEngineAnimationPlayMode(L, UnityEngine.AnimationPlayMode.Queue);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mix"))
                {
                    translator.PushUnityEngineAnimationPlayMode(L, UnityEngine.AnimationPlayMode.Mix);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnimationPlayMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnimationPlayMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnimationCullingTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnimationCullingType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnimationCullingType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnimationCullingType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AlwaysAnimate", UnityEngine.AnimationCullingType.AlwaysAnimate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BasedOnRenderers", UnityEngine.AnimationCullingType.BasedOnRenderers);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnimationCullingType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnimationCullingType(L, (UnityEngine.AnimationCullingType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "AlwaysAnimate"))
                {
                    translator.PushUnityEngineAnimationCullingType(L, UnityEngine.AnimationCullingType.AlwaysAnimate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BasedOnRenderers"))
                {
                    translator.PushUnityEngineAnimationCullingType(L, UnityEngine.AnimationCullingType.BasedOnRenderers);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnimationCullingType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnimationCullingType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAssetBundleLoadResultWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AssetBundleLoadResult), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AssetBundleLoadResult), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AssetBundleLoadResult), L, null, 15, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Success", UnityEngine.AssetBundleLoadResult.Success);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Cancelled", UnityEngine.AssetBundleLoadResult.Cancelled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotMatchingCrc", UnityEngine.AssetBundleLoadResult.NotMatchingCrc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FailedCache", UnityEngine.AssetBundleLoadResult.FailedCache);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotValidAssetBundle", UnityEngine.AssetBundleLoadResult.NotValidAssetBundle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NoSerializedData", UnityEngine.AssetBundleLoadResult.NoSerializedData);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotCompatible", UnityEngine.AssetBundleLoadResult.NotCompatible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AlreadyLoaded", UnityEngine.AssetBundleLoadResult.AlreadyLoaded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FailedRead", UnityEngine.AssetBundleLoadResult.FailedRead);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FailedDecompression", UnityEngine.AssetBundleLoadResult.FailedDecompression);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FailedWrite", UnityEngine.AssetBundleLoadResult.FailedWrite);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FailedDeleteRecompressionTarget", UnityEngine.AssetBundleLoadResult.FailedDeleteRecompressionTarget);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RecompressionTargetIsLoaded", UnityEngine.AssetBundleLoadResult.RecompressionTargetIsLoaded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RecompressionTargetExistsButNotArchive", UnityEngine.AssetBundleLoadResult.RecompressionTargetExistsButNotArchive);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AssetBundleLoadResult), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAssetBundleLoadResult(L, (UnityEngine.AssetBundleLoadResult)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Success"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.Success);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Cancelled"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.Cancelled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotMatchingCrc"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.NotMatchingCrc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FailedCache"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.FailedCache);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotValidAssetBundle"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.NotValidAssetBundle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NoSerializedData"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.NoSerializedData);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotCompatible"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.NotCompatible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AlreadyLoaded"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.AlreadyLoaded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FailedRead"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.FailedRead);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FailedDecompression"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.FailedDecompression);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FailedWrite"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.FailedWrite);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FailedDeleteRecompressionTarget"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.FailedDeleteRecompressionTarget);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RecompressionTargetIsLoaded"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.RecompressionTargetIsLoaded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RecompressionTargetExistsButNotArchive"))
                {
                    translator.PushUnityEngineAssetBundleLoadResult(L, UnityEngine.AssetBundleLoadResult.RecompressionTargetExistsButNotArchive);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AssetBundleLoadResult!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AssetBundleLoadResult! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCompressionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CompressionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CompressionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CompressionType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.CompressionType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lzma", UnityEngine.CompressionType.Lzma);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lz4", UnityEngine.CompressionType.Lz4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lz4HC", UnityEngine.CompressionType.Lz4HC);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CompressionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCompressionType(L, (UnityEngine.CompressionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineCompressionType(L, UnityEngine.CompressionType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lzma"))
                {
                    translator.PushUnityEngineCompressionType(L, UnityEngine.CompressionType.Lzma);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lz4"))
                {
                    translator.PushUnityEngineCompressionType(L, UnityEngine.CompressionType.Lz4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lz4HC"))
                {
                    translator.PushUnityEngineCompressionType(L, UnityEngine.CompressionType.Lz4HC);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CompressionType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CompressionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCompressionLevelWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CompressionLevel), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CompressionLevel), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CompressionLevel), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.CompressionLevel.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fastest", UnityEngine.CompressionLevel.Fastest);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fast", UnityEngine.CompressionLevel.Fast);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", UnityEngine.CompressionLevel.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "High", UnityEngine.CompressionLevel.High);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Maximum", UnityEngine.CompressionLevel.Maximum);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CompressionLevel), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCompressionLevel(L, (UnityEngine.CompressionLevel)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineCompressionLevel(L, UnityEngine.CompressionLevel.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fastest"))
                {
                    translator.PushUnityEngineCompressionLevel(L, UnityEngine.CompressionLevel.Fastest);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fast"))
                {
                    translator.PushUnityEngineCompressionLevel(L, UnityEngine.CompressionLevel.Fast);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushUnityEngineCompressionLevel(L, UnityEngine.CompressionLevel.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "High"))
                {
                    translator.PushUnityEngineCompressionLevel(L, UnityEngine.CompressionLevel.High);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Maximum"))
                {
                    translator.PushUnityEngineCompressionLevel(L, UnityEngine.CompressionLevel.Maximum);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CompressionLevel!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CompressionLevel! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioSpeakerModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioSpeakerMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioSpeakerMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioSpeakerMode), L, null, 9, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mono", UnityEngine.AudioSpeakerMode.Mono);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stereo", UnityEngine.AudioSpeakerMode.Stereo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Quad", UnityEngine.AudioSpeakerMode.Quad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Surround", UnityEngine.AudioSpeakerMode.Surround);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mode5point1", UnityEngine.AudioSpeakerMode.Mode5point1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mode7point1", UnityEngine.AudioSpeakerMode.Mode7point1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Prologic", UnityEngine.AudioSpeakerMode.Prologic);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioSpeakerMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioSpeakerMode(L, (UnityEngine.AudioSpeakerMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Mono"))
                {
                    translator.PushUnityEngineAudioSpeakerMode(L, UnityEngine.AudioSpeakerMode.Mono);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Stereo"))
                {
                    translator.PushUnityEngineAudioSpeakerMode(L, UnityEngine.AudioSpeakerMode.Stereo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Quad"))
                {
                    translator.PushUnityEngineAudioSpeakerMode(L, UnityEngine.AudioSpeakerMode.Quad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Surround"))
                {
                    translator.PushUnityEngineAudioSpeakerMode(L, UnityEngine.AudioSpeakerMode.Surround);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mode5point1"))
                {
                    translator.PushUnityEngineAudioSpeakerMode(L, UnityEngine.AudioSpeakerMode.Mode5point1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mode7point1"))
                {
                    translator.PushUnityEngineAudioSpeakerMode(L, UnityEngine.AudioSpeakerMode.Mode7point1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Prologic"))
                {
                    translator.PushUnityEngineAudioSpeakerMode(L, UnityEngine.AudioSpeakerMode.Prologic);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioSpeakerMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioSpeakerMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioDataLoadStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioDataLoadState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioDataLoadState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioDataLoadState), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unloaded", UnityEngine.AudioDataLoadState.Unloaded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loading", UnityEngine.AudioDataLoadState.Loading);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loaded", UnityEngine.AudioDataLoadState.Loaded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Failed", UnityEngine.AudioDataLoadState.Failed);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioDataLoadState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioDataLoadState(L, (UnityEngine.AudioDataLoadState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unloaded"))
                {
                    translator.PushUnityEngineAudioDataLoadState(L, UnityEngine.AudioDataLoadState.Unloaded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Loading"))
                {
                    translator.PushUnityEngineAudioDataLoadState(L, UnityEngine.AudioDataLoadState.Loading);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Loaded"))
                {
                    translator.PushUnityEngineAudioDataLoadState(L, UnityEngine.AudioDataLoadState.Loaded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Failed"))
                {
                    translator.PushUnityEngineAudioDataLoadState(L, UnityEngine.AudioDataLoadState.Failed);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioDataLoadState!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioDataLoadState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioCompressionFormatWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioCompressionFormat), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioCompressionFormat), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioCompressionFormat), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PCM", UnityEngine.AudioCompressionFormat.PCM);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vorbis", UnityEngine.AudioCompressionFormat.Vorbis);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ADPCM", UnityEngine.AudioCompressionFormat.ADPCM);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MP3", UnityEngine.AudioCompressionFormat.MP3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VAG", UnityEngine.AudioCompressionFormat.VAG);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HEVAG", UnityEngine.AudioCompressionFormat.HEVAG);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XMA", UnityEngine.AudioCompressionFormat.XMA);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AAC", UnityEngine.AudioCompressionFormat.AAC);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "GCADPCM", UnityEngine.AudioCompressionFormat.GCADPCM);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ATRAC9", UnityEngine.AudioCompressionFormat.ATRAC9);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioCompressionFormat), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioCompressionFormat(L, (UnityEngine.AudioCompressionFormat)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "PCM"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.PCM);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vorbis"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.Vorbis);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ADPCM"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.ADPCM);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MP3"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.MP3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VAG"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.VAG);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HEVAG"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.HEVAG);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "XMA"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.XMA);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AAC"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.AAC);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "GCADPCM"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.GCADPCM);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ATRAC9"))
                {
                    translator.PushUnityEngineAudioCompressionFormat(L, UnityEngine.AudioCompressionFormat.ATRAC9);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioCompressionFormat!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioCompressionFormat! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioClipLoadTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioClipLoadType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioClipLoadType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioClipLoadType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecompressOnLoad", UnityEngine.AudioClipLoadType.DecompressOnLoad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompressedInMemory", UnityEngine.AudioClipLoadType.CompressedInMemory);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Streaming", UnityEngine.AudioClipLoadType.Streaming);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioClipLoadType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioClipLoadType(L, (UnityEngine.AudioClipLoadType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "DecompressOnLoad"))
                {
                    translator.PushUnityEngineAudioClipLoadType(L, UnityEngine.AudioClipLoadType.DecompressOnLoad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CompressedInMemory"))
                {
                    translator.PushUnityEngineAudioClipLoadType(L, UnityEngine.AudioClipLoadType.CompressedInMemory);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Streaming"))
                {
                    translator.PushUnityEngineAudioClipLoadType(L, UnityEngine.AudioClipLoadType.Streaming);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioClipLoadType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioClipLoadType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioVelocityUpdateModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioVelocityUpdateMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioVelocityUpdateMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioVelocityUpdateMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Auto", UnityEngine.AudioVelocityUpdateMode.Auto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed", UnityEngine.AudioVelocityUpdateMode.Fixed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dynamic", UnityEngine.AudioVelocityUpdateMode.Dynamic);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioVelocityUpdateMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioVelocityUpdateMode(L, (UnityEngine.AudioVelocityUpdateMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Auto"))
                {
                    translator.PushUnityEngineAudioVelocityUpdateMode(L, UnityEngine.AudioVelocityUpdateMode.Auto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed"))
                {
                    translator.PushUnityEngineAudioVelocityUpdateMode(L, UnityEngine.AudioVelocityUpdateMode.Fixed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Dynamic"))
                {
                    translator.PushUnityEngineAudioVelocityUpdateMode(L, UnityEngine.AudioVelocityUpdateMode.Dynamic);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioVelocityUpdateMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioVelocityUpdateMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioRolloffModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioRolloffMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioRolloffMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioRolloffMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Logarithmic", UnityEngine.AudioRolloffMode.Logarithmic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", UnityEngine.AudioRolloffMode.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", UnityEngine.AudioRolloffMode.Custom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioRolloffMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioRolloffMode(L, (UnityEngine.AudioRolloffMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Logarithmic"))
                {
                    translator.PushUnityEngineAudioRolloffMode(L, UnityEngine.AudioRolloffMode.Logarithmic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushUnityEngineAudioRolloffMode(L, UnityEngine.AudioRolloffMode.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushUnityEngineAudioRolloffMode(L, UnityEngine.AudioRolloffMode.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioRolloffMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioRolloffMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioSourceCurveTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioSourceCurveType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioSourceCurveType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioSourceCurveType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CustomRolloff", UnityEngine.AudioSourceCurveType.CustomRolloff);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpatialBlend", UnityEngine.AudioSourceCurveType.SpatialBlend);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ReverbZoneMix", UnityEngine.AudioSourceCurveType.ReverbZoneMix);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Spread", UnityEngine.AudioSourceCurveType.Spread);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioSourceCurveType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioSourceCurveType(L, (UnityEngine.AudioSourceCurveType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "CustomRolloff"))
                {
                    translator.PushUnityEngineAudioSourceCurveType(L, UnityEngine.AudioSourceCurveType.CustomRolloff);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpatialBlend"))
                {
                    translator.PushUnityEngineAudioSourceCurveType(L, UnityEngine.AudioSourceCurveType.SpatialBlend);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ReverbZoneMix"))
                {
                    translator.PushUnityEngineAudioSourceCurveType(L, UnityEngine.AudioSourceCurveType.ReverbZoneMix);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Spread"))
                {
                    translator.PushUnityEngineAudioSourceCurveType(L, UnityEngine.AudioSourceCurveType.Spread);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioSourceCurveType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioSourceCurveType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioReverbPresetWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioReverbPreset), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioReverbPreset), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioReverbPreset), L, null, 29, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.AudioReverbPreset));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioReverbPreset), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioReverbPreset(L, (UnityEngine.AudioReverbPreset)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.AudioReverbPreset), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.AudioReverbPreset) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioReverbPreset! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineWebCamFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.WebCamFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.WebCamFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.WebCamFlags), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FrontFacing", UnityEngine.WebCamFlags.FrontFacing);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoFocusPointSupported", UnityEngine.WebCamFlags.AutoFocusPointSupported);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.WebCamFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineWebCamFlags(L, (UnityEngine.WebCamFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "FrontFacing"))
                {
                    translator.PushUnityEngineWebCamFlags(L, UnityEngine.WebCamFlags.FrontFacing);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoFocusPointSupported"))
                {
                    translator.PushUnityEngineWebCamFlags(L, UnityEngine.WebCamFlags.AutoFocusPointSupported);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.WebCamFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.WebCamFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineWebCamKindWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.WebCamKind), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.WebCamKind), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.WebCamKind), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WideAngle", UnityEngine.WebCamKind.WideAngle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Telephoto", UnityEngine.WebCamKind.Telephoto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ColorAndDepth", UnityEngine.WebCamKind.ColorAndDepth);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.WebCamKind), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineWebCamKind(L, (UnityEngine.WebCamKind)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "WideAngle"))
                {
                    translator.PushUnityEngineWebCamKind(L, UnityEngine.WebCamKind.WideAngle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Telephoto"))
                {
                    translator.PushUnityEngineWebCamKind(L, UnityEngine.WebCamKind.Telephoto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ColorAndDepth"))
                {
                    translator.PushUnityEngineWebCamKind(L, UnityEngine.WebCamKind.ColorAndDepth);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.WebCamKind!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.WebCamKind! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSendMessageOptionsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SendMessageOptions), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SendMessageOptions), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SendMessageOptions), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RequireReceiver", UnityEngine.SendMessageOptions.RequireReceiver);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DontRequireReceiver", UnityEngine.SendMessageOptions.DontRequireReceiver);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SendMessageOptions), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSendMessageOptions(L, (UnityEngine.SendMessageOptions)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "RequireReceiver"))
                {
                    translator.PushUnityEngineSendMessageOptions(L, UnityEngine.SendMessageOptions.RequireReceiver);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontRequireReceiver"))
                {
                    translator.PushUnityEngineSendMessageOptions(L, UnityEngine.SendMessageOptions.DontRequireReceiver);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SendMessageOptions!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SendMessageOptions! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEnginePrimitiveTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.PrimitiveType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.PrimitiveType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.PrimitiveType), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sphere", UnityEngine.PrimitiveType.Sphere);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Capsule", UnityEngine.PrimitiveType.Capsule);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Cylinder", UnityEngine.PrimitiveType.Cylinder);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Cube", UnityEngine.PrimitiveType.Cube);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Plane", UnityEngine.PrimitiveType.Plane);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Quad", UnityEngine.PrimitiveType.Quad);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.PrimitiveType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEnginePrimitiveType(L, (UnityEngine.PrimitiveType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Sphere"))
                {
                    translator.PushUnityEnginePrimitiveType(L, UnityEngine.PrimitiveType.Sphere);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Capsule"))
                {
                    translator.PushUnityEnginePrimitiveType(L, UnityEngine.PrimitiveType.Capsule);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Cylinder"))
                {
                    translator.PushUnityEnginePrimitiveType(L, UnityEngine.PrimitiveType.Cylinder);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Cube"))
                {
                    translator.PushUnityEnginePrimitiveType(L, UnityEngine.PrimitiveType.Cube);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Plane"))
                {
                    translator.PushUnityEnginePrimitiveType(L, UnityEngine.PrimitiveType.Plane);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Quad"))
                {
                    translator.PushUnityEnginePrimitiveType(L, UnityEngine.PrimitiveType.Quad);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.PrimitiveType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.PrimitiveType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpaceWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Space), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Space), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Space), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "World", UnityEngine.Space.World);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Self", UnityEngine.Space.Self);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Space), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpace(L, (UnityEngine.Space)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "World"))
                {
                    translator.PushUnityEngineSpace(L, UnityEngine.Space.World);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Self"))
                {
                    translator.PushUnityEngineSpace(L, UnityEngine.Space.Self);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Space!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Space! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRuntimePlatformWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RuntimePlatform), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RuntimePlatform), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RuntimePlatform), L, null, 42, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.RuntimePlatform));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RuntimePlatform), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRuntimePlatform(L, (UnityEngine.RuntimePlatform)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.RuntimePlatform), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.RuntimePlatform) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RuntimePlatform! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSystemLanguageWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SystemLanguage), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SystemLanguage), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SystemLanguage), L, null, 45, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.SystemLanguage));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SystemLanguage), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSystemLanguage(L, (UnityEngine.SystemLanguage)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.SystemLanguage), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.SystemLanguage) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SystemLanguage! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineLogTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.LogType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.LogType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.LogType), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Error", UnityEngine.LogType.Error);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Assert", UnityEngine.LogType.Assert);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Warning", UnityEngine.LogType.Warning);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Log", UnityEngine.LogType.Log);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Exception", UnityEngine.LogType.Exception);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.LogType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineLogType(L, (UnityEngine.LogType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Error"))
                {
                    translator.PushUnityEngineLogType(L, UnityEngine.LogType.Error);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Assert"))
                {
                    translator.PushUnityEngineLogType(L, UnityEngine.LogType.Assert);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Warning"))
                {
                    translator.PushUnityEngineLogType(L, UnityEngine.LogType.Warning);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Log"))
                {
                    translator.PushUnityEngineLogType(L, UnityEngine.LogType.Log);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Exception"))
                {
                    translator.PushUnityEngineLogType(L, UnityEngine.LogType.Exception);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.LogType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.LogType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineLogOptionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.LogOption), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.LogOption), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.LogOption), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.LogOption.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NoStacktrace", UnityEngine.LogOption.NoStacktrace);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.LogOption), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineLogOption(L, (UnityEngine.LogOption)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineLogOption(L, UnityEngine.LogOption.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NoStacktrace"))
                {
                    translator.PushUnityEngineLogOption(L, UnityEngine.LogOption.NoStacktrace);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.LogOption!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.LogOption! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineThreadPriorityWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ThreadPriority), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ThreadPriority), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ThreadPriority), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Low", UnityEngine.ThreadPriority.Low);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BelowNormal", UnityEngine.ThreadPriority.BelowNormal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", UnityEngine.ThreadPriority.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "High", UnityEngine.ThreadPriority.High);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ThreadPriority), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineThreadPriority(L, (UnityEngine.ThreadPriority)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Low"))
                {
                    translator.PushUnityEngineThreadPriority(L, UnityEngine.ThreadPriority.Low);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BelowNormal"))
                {
                    translator.PushUnityEngineThreadPriority(L, UnityEngine.ThreadPriority.BelowNormal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushUnityEngineThreadPriority(L, UnityEngine.ThreadPriority.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "High"))
                {
                    translator.PushUnityEngineThreadPriority(L, UnityEngine.ThreadPriority.High);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ThreadPriority!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ThreadPriority! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineWeightedModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.WeightedMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.WeightedMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.WeightedMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.WeightedMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "In", UnityEngine.WeightedMode.In);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Out", UnityEngine.WeightedMode.Out);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", UnityEngine.WeightedMode.Both);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.WeightedMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineWeightedMode(L, (UnityEngine.WeightedMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineWeightedMode(L, UnityEngine.WeightedMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "In"))
                {
                    translator.PushUnityEngineWeightedMode(L, UnityEngine.WeightedMode.In);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Out"))
                {
                    translator.PushUnityEngineWeightedMode(L, UnityEngine.WeightedMode.Out);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushUnityEngineWeightedMode(L, UnityEngine.WeightedMode.Both);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.WeightedMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.WeightedMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineWrapModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.WrapMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.WrapMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.WrapMode), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Once", UnityEngine.WrapMode.Once);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loop", UnityEngine.WrapMode.Loop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PingPong", UnityEngine.WrapMode.PingPong);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", UnityEngine.WrapMode.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ClampForever", UnityEngine.WrapMode.ClampForever);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clamp", UnityEngine.WrapMode.Clamp);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.WrapMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineWrapMode(L, (UnityEngine.WrapMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Once"))
                {
                    translator.PushUnityEngineWrapMode(L, UnityEngine.WrapMode.Once);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Loop"))
                {
                    translator.PushUnityEngineWrapMode(L, UnityEngine.WrapMode.Loop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PingPong"))
                {
                    translator.PushUnityEngineWrapMode(L, UnityEngine.WrapMode.PingPong);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushUnityEngineWrapMode(L, UnityEngine.WrapMode.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ClampForever"))
                {
                    translator.PushUnityEngineWrapMode(L, UnityEngine.WrapMode.ClampForever);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Clamp"))
                {
                    translator.PushUnityEngineWrapMode(L, UnityEngine.WrapMode.Clamp);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.WrapMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.WrapMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineStackTraceLogTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.StackTraceLogType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.StackTraceLogType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.StackTraceLogType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.StackTraceLogType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScriptOnly", UnityEngine.StackTraceLogType.ScriptOnly);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Full", UnityEngine.StackTraceLogType.Full);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.StackTraceLogType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineStackTraceLogType(L, (UnityEngine.StackTraceLogType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineStackTraceLogType(L, UnityEngine.StackTraceLogType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScriptOnly"))
                {
                    translator.PushUnityEngineStackTraceLogType(L, UnityEngine.StackTraceLogType.ScriptOnly);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Full"))
                {
                    translator.PushUnityEngineStackTraceLogType(L, UnityEngine.StackTraceLogType.Full);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.StackTraceLogType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.StackTraceLogType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUserAuthorizationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UserAuthorization), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UserAuthorization), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UserAuthorization), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WebCam", UnityEngine.UserAuthorization.WebCam);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Microphone", UnityEngine.UserAuthorization.Microphone);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UserAuthorization), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUserAuthorization(L, (UnityEngine.UserAuthorization)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "WebCam"))
                {
                    translator.PushUnityEngineUserAuthorization(L, UnityEngine.UserAuthorization.WebCam);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Microphone"))
                {
                    translator.PushUnityEngineUserAuthorization(L, UnityEngine.UserAuthorization.Microphone);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UserAuthorization!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UserAuthorization! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineApplicationInstallModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ApplicationInstallMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ApplicationInstallMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ApplicationInstallMode), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", UnityEngine.ApplicationInstallMode.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Store", UnityEngine.ApplicationInstallMode.Store);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DeveloperBuild", UnityEngine.ApplicationInstallMode.DeveloperBuild);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Adhoc", UnityEngine.ApplicationInstallMode.Adhoc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Enterprise", UnityEngine.ApplicationInstallMode.Enterprise);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Editor", UnityEngine.ApplicationInstallMode.Editor);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ApplicationInstallMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineApplicationInstallMode(L, (UnityEngine.ApplicationInstallMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushUnityEngineApplicationInstallMode(L, UnityEngine.ApplicationInstallMode.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Store"))
                {
                    translator.PushUnityEngineApplicationInstallMode(L, UnityEngine.ApplicationInstallMode.Store);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DeveloperBuild"))
                {
                    translator.PushUnityEngineApplicationInstallMode(L, UnityEngine.ApplicationInstallMode.DeveloperBuild);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Adhoc"))
                {
                    translator.PushUnityEngineApplicationInstallMode(L, UnityEngine.ApplicationInstallMode.Adhoc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Enterprise"))
                {
                    translator.PushUnityEngineApplicationInstallMode(L, UnityEngine.ApplicationInstallMode.Enterprise);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Editor"))
                {
                    translator.PushUnityEngineApplicationInstallMode(L, UnityEngine.ApplicationInstallMode.Editor);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ApplicationInstallMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ApplicationInstallMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineApplicationSandboxTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ApplicationSandboxType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ApplicationSandboxType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ApplicationSandboxType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", UnityEngine.ApplicationSandboxType.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotSandboxed", UnityEngine.ApplicationSandboxType.NotSandboxed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sandboxed", UnityEngine.ApplicationSandboxType.Sandboxed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SandboxBroken", UnityEngine.ApplicationSandboxType.SandboxBroken);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ApplicationSandboxType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineApplicationSandboxType(L, (UnityEngine.ApplicationSandboxType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushUnityEngineApplicationSandboxType(L, UnityEngine.ApplicationSandboxType.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotSandboxed"))
                {
                    translator.PushUnityEngineApplicationSandboxType(L, UnityEngine.ApplicationSandboxType.NotSandboxed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sandboxed"))
                {
                    translator.PushUnityEngineApplicationSandboxType(L, UnityEngine.ApplicationSandboxType.Sandboxed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SandboxBroken"))
                {
                    translator.PushUnityEngineApplicationSandboxType(L, UnityEngine.ApplicationSandboxType.SandboxBroken);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ApplicationSandboxType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ApplicationSandboxType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAudioTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AudioType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AudioType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AudioType), L, null, 14, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UNKNOWN", UnityEngine.AudioType.UNKNOWN);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ACC", UnityEngine.AudioType.ACC);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AIFF", UnityEngine.AudioType.AIFF);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IT", UnityEngine.AudioType.IT);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MOD", UnityEngine.AudioType.MOD);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MPEG", UnityEngine.AudioType.MPEG);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OGGVORBIS", UnityEngine.AudioType.OGGVORBIS);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "S3M", UnityEngine.AudioType.S3M);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WAV", UnityEngine.AudioType.WAV);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XM", UnityEngine.AudioType.XM);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XMA", UnityEngine.AudioType.XMA);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VAG", UnityEngine.AudioType.VAG);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AUDIOQUEUE", UnityEngine.AudioType.AUDIOQUEUE);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AudioType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAudioType(L, (UnityEngine.AudioType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UNKNOWN"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.UNKNOWN);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ACC"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.ACC);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AIFF"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.AIFF);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IT"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.IT);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MOD"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.MOD);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MPEG"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.MPEG);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OGGVORBIS"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.OGGVORBIS);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "S3M"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.S3M);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WAV"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.WAV);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "XM"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.XM);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "XMA"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.XMA);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VAG"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.VAG);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AUDIOQUEUE"))
                {
                    translator.PushUnityEngineAudioType(L, UnityEngine.AudioType.AUDIOQUEUE);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AudioType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AudioType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCameraGateFitModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Camera.GateFitMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Camera.GateFitMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Camera.GateFitMode), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.Camera.GateFitMode.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.Camera.GateFitMode.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fill", UnityEngine.Camera.GateFitMode.Fill);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Overscan", UnityEngine.Camera.GateFitMode.Overscan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.Camera.GateFitMode.None);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Camera.GateFitMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCameraGateFitMode(L, (UnityEngine.Camera.GateFitMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineCameraGateFitMode(L, UnityEngine.Camera.GateFitMode.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineCameraGateFitMode(L, UnityEngine.Camera.GateFitMode.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fill"))
                {
                    translator.PushUnityEngineCameraGateFitMode(L, UnityEngine.Camera.GateFitMode.Fill);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Overscan"))
                {
                    translator.PushUnityEngineCameraGateFitMode(L, UnityEngine.Camera.GateFitMode.Overscan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineCameraGateFitMode(L, UnityEngine.Camera.GateFitMode.None);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Camera.GateFitMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Camera.GateFitMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCameraFieldOfViewAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Camera.FieldOfViewAxis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Camera.FieldOfViewAxis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Camera.FieldOfViewAxis), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.Camera.FieldOfViewAxis.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.Camera.FieldOfViewAxis.Horizontal);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Camera.FieldOfViewAxis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCameraFieldOfViewAxis(L, (UnityEngine.Camera.FieldOfViewAxis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineCameraFieldOfViewAxis(L, UnityEngine.Camera.FieldOfViewAxis.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineCameraFieldOfViewAxis(L, UnityEngine.Camera.FieldOfViewAxis.Horizontal);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Camera.FieldOfViewAxis!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Camera.FieldOfViewAxis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCameraStereoscopicEyeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Camera.StereoscopicEye), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Camera.StereoscopicEye), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Camera.StereoscopicEye), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.Camera.StereoscopicEye.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.Camera.StereoscopicEye.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Camera.StereoscopicEye), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCameraStereoscopicEye(L, (UnityEngine.Camera.StereoscopicEye)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineCameraStereoscopicEye(L, UnityEngine.Camera.StereoscopicEye.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineCameraStereoscopicEye(L, UnityEngine.Camera.StereoscopicEye.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Camera.StereoscopicEye!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Camera.StereoscopicEye! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCameraMonoOrStereoscopicEyeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Camera.MonoOrStereoscopicEye), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Camera.MonoOrStereoscopicEye), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Camera.MonoOrStereoscopicEye), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.Camera.MonoOrStereoscopicEye.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.Camera.MonoOrStereoscopicEye.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mono", UnityEngine.Camera.MonoOrStereoscopicEye.Mono);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Camera.MonoOrStereoscopicEye), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCameraMonoOrStereoscopicEye(L, (UnityEngine.Camera.MonoOrStereoscopicEye)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineCameraMonoOrStereoscopicEye(L, UnityEngine.Camera.MonoOrStereoscopicEye.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineCameraMonoOrStereoscopicEye(L, UnityEngine.Camera.MonoOrStereoscopicEye.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mono"))
                {
                    translator.PushUnityEngineCameraMonoOrStereoscopicEye(L, UnityEngine.Camera.MonoOrStereoscopicEye.Mono);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Camera.MonoOrStereoscopicEye!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Camera.MonoOrStereoscopicEye! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineReflectionProbeReflectionProbeEventWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ReflectionProbeAdded", UnityEngine.ReflectionProbe.ReflectionProbeEvent.ReflectionProbeAdded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ReflectionProbeRemoved", UnityEngine.ReflectionProbe.ReflectionProbeEvent.ReflectionProbeRemoved);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineReflectionProbeReflectionProbeEvent(L, (UnityEngine.ReflectionProbe.ReflectionProbeEvent)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ReflectionProbeAdded"))
                {
                    translator.PushUnityEngineReflectionProbeReflectionProbeEvent(L, UnityEngine.ReflectionProbe.ReflectionProbeEvent.ReflectionProbeAdded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ReflectionProbeRemoved"))
                {
                    translator.PushUnityEngineReflectionProbeReflectionProbeEvent(L, UnityEngine.ReflectionProbe.ReflectionProbeEvent.ReflectionProbeRemoved);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ReflectionProbe.ReflectionProbeEvent!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ReflectionProbe.ReflectionProbeEvent! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineFullScreenModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.FullScreenMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.FullScreenMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.FullScreenMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExclusiveFullScreen", UnityEngine.FullScreenMode.ExclusiveFullScreen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FullScreenWindow", UnityEngine.FullScreenMode.FullScreenWindow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaximizedWindow", UnityEngine.FullScreenMode.MaximizedWindow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Windowed", UnityEngine.FullScreenMode.Windowed);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.FullScreenMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineFullScreenMode(L, (UnityEngine.FullScreenMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ExclusiveFullScreen"))
                {
                    translator.PushUnityEngineFullScreenMode(L, UnityEngine.FullScreenMode.ExclusiveFullScreen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FullScreenWindow"))
                {
                    translator.PushUnityEngineFullScreenMode(L, UnityEngine.FullScreenMode.FullScreenWindow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaximizedWindow"))
                {
                    translator.PushUnityEngineFullScreenMode(L, UnityEngine.FullScreenMode.MaximizedWindow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Windowed"))
                {
                    translator.PushUnityEngineFullScreenMode(L, UnityEngine.FullScreenMode.Windowed);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.FullScreenMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.FullScreenMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineComputeBufferModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ComputeBufferMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ComputeBufferMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ComputeBufferMode), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Immutable", UnityEngine.ComputeBufferMode.Immutable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dynamic", UnityEngine.ComputeBufferMode.Dynamic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Circular", UnityEngine.ComputeBufferMode.Circular);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StreamOut", UnityEngine.ComputeBufferMode.StreamOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SubUpdates", UnityEngine.ComputeBufferMode.SubUpdates);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ComputeBufferMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineComputeBufferMode(L, (UnityEngine.ComputeBufferMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Immutable"))
                {
                    translator.PushUnityEngineComputeBufferMode(L, UnityEngine.ComputeBufferMode.Immutable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Dynamic"))
                {
                    translator.PushUnityEngineComputeBufferMode(L, UnityEngine.ComputeBufferMode.Dynamic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Circular"))
                {
                    translator.PushUnityEngineComputeBufferMode(L, UnityEngine.ComputeBufferMode.Circular);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "StreamOut"))
                {
                    translator.PushUnityEngineComputeBufferMode(L, UnityEngine.ComputeBufferMode.StreamOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SubUpdates"))
                {
                    translator.PushUnityEngineComputeBufferMode(L, UnityEngine.ComputeBufferMode.SubUpdates);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ComputeBufferMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ComputeBufferMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineD3DHDRDisplayBitDepthWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.D3DHDRDisplayBitDepth), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.D3DHDRDisplayBitDepth), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.D3DHDRDisplayBitDepth), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "D3DHDRDisplayBitDepth10", UnityEngine.D3DHDRDisplayBitDepth.D3DHDRDisplayBitDepth10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "D3DHDRDisplayBitDepth16", UnityEngine.D3DHDRDisplayBitDepth.D3DHDRDisplayBitDepth16);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.D3DHDRDisplayBitDepth), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineD3DHDRDisplayBitDepth(L, (UnityEngine.D3DHDRDisplayBitDepth)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "D3DHDRDisplayBitDepth10"))
                {
                    translator.PushUnityEngineD3DHDRDisplayBitDepth(L, UnityEngine.D3DHDRDisplayBitDepth.D3DHDRDisplayBitDepth10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "D3DHDRDisplayBitDepth16"))
                {
                    translator.PushUnityEngineD3DHDRDisplayBitDepth(L, UnityEngine.D3DHDRDisplayBitDepth.D3DHDRDisplayBitDepth16);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.D3DHDRDisplayBitDepth!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.D3DHDRDisplayBitDepth! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRenderingPathWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RenderingPath), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RenderingPath), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RenderingPath), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UsePlayerSettings", UnityEngine.RenderingPath.UsePlayerSettings);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VertexLit", UnityEngine.RenderingPath.VertexLit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Forward", UnityEngine.RenderingPath.Forward);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DeferredLighting", UnityEngine.RenderingPath.DeferredLighting);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DeferredShading", UnityEngine.RenderingPath.DeferredShading);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RenderingPath), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRenderingPath(L, (UnityEngine.RenderingPath)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UsePlayerSettings"))
                {
                    translator.PushUnityEngineRenderingPath(L, UnityEngine.RenderingPath.UsePlayerSettings);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VertexLit"))
                {
                    translator.PushUnityEngineRenderingPath(L, UnityEngine.RenderingPath.VertexLit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Forward"))
                {
                    translator.PushUnityEngineRenderingPath(L, UnityEngine.RenderingPath.Forward);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DeferredLighting"))
                {
                    translator.PushUnityEngineRenderingPath(L, UnityEngine.RenderingPath.DeferredLighting);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DeferredShading"))
                {
                    translator.PushUnityEngineRenderingPath(L, UnityEngine.RenderingPath.DeferredShading);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RenderingPath!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RenderingPath! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTransparencySortModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TransparencySortMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TransparencySortMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TransparencySortMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", UnityEngine.TransparencySortMode.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Perspective", UnityEngine.TransparencySortMode.Perspective);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Orthographic", UnityEngine.TransparencySortMode.Orthographic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CustomAxis", UnityEngine.TransparencySortMode.CustomAxis);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TransparencySortMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTransparencySortMode(L, (UnityEngine.TransparencySortMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushUnityEngineTransparencySortMode(L, UnityEngine.TransparencySortMode.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Perspective"))
                {
                    translator.PushUnityEngineTransparencySortMode(L, UnityEngine.TransparencySortMode.Perspective);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Orthographic"))
                {
                    translator.PushUnityEngineTransparencySortMode(L, UnityEngine.TransparencySortMode.Orthographic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CustomAxis"))
                {
                    translator.PushUnityEngineTransparencySortMode(L, UnityEngine.TransparencySortMode.CustomAxis);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TransparencySortMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TransparencySortMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineStereoTargetEyeMaskWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.StereoTargetEyeMask), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.StereoTargetEyeMask), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.StereoTargetEyeMask), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.StereoTargetEyeMask.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.StereoTargetEyeMask.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.StereoTargetEyeMask.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", UnityEngine.StereoTargetEyeMask.Both);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.StereoTargetEyeMask), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineStereoTargetEyeMask(L, (UnityEngine.StereoTargetEyeMask)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineStereoTargetEyeMask(L, UnityEngine.StereoTargetEyeMask.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineStereoTargetEyeMask(L, UnityEngine.StereoTargetEyeMask.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineStereoTargetEyeMask(L, UnityEngine.StereoTargetEyeMask.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushUnityEngineStereoTargetEyeMask(L, UnityEngine.StereoTargetEyeMask.Both);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.StereoTargetEyeMask!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.StereoTargetEyeMask! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCameraTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CameraType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CameraType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CameraType), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Game", UnityEngine.CameraType.Game);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SceneView", UnityEngine.CameraType.SceneView);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Preview", UnityEngine.CameraType.Preview);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VR", UnityEngine.CameraType.VR);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Reflection", UnityEngine.CameraType.Reflection);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CameraType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCameraType(L, (UnityEngine.CameraType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Game"))
                {
                    translator.PushUnityEngineCameraType(L, UnityEngine.CameraType.Game);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SceneView"))
                {
                    translator.PushUnityEngineCameraType(L, UnityEngine.CameraType.SceneView);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Preview"))
                {
                    translator.PushUnityEngineCameraType(L, UnityEngine.CameraType.Preview);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VR"))
                {
                    translator.PushUnityEngineCameraType(L, UnityEngine.CameraType.VR);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Reflection"))
                {
                    translator.PushUnityEngineCameraType(L, UnityEngine.CameraType.Reflection);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CameraType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CameraType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineComputeBufferTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ComputeBufferType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ComputeBufferType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ComputeBufferType), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", UnityEngine.ComputeBufferType.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Raw", UnityEngine.ComputeBufferType.Raw);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Append", UnityEngine.ComputeBufferType.Append);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Counter", UnityEngine.ComputeBufferType.Counter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Constant", UnityEngine.ComputeBufferType.Constant);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Structured", UnityEngine.ComputeBufferType.Structured);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IndirectArguments", UnityEngine.ComputeBufferType.IndirectArguments);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ComputeBufferType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineComputeBufferType(L, (UnityEngine.ComputeBufferType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushUnityEngineComputeBufferType(L, UnityEngine.ComputeBufferType.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Raw"))
                {
                    translator.PushUnityEngineComputeBufferType(L, UnityEngine.ComputeBufferType.Raw);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Append"))
                {
                    translator.PushUnityEngineComputeBufferType(L, UnityEngine.ComputeBufferType.Append);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Counter"))
                {
                    translator.PushUnityEngineComputeBufferType(L, UnityEngine.ComputeBufferType.Counter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Constant"))
                {
                    translator.PushUnityEngineComputeBufferType(L, UnityEngine.ComputeBufferType.Constant);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Structured"))
                {
                    translator.PushUnityEngineComputeBufferType(L, UnityEngine.ComputeBufferType.Structured);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IndirectArguments"))
                {
                    translator.PushUnityEngineComputeBufferType(L, UnityEngine.ComputeBufferType.IndirectArguments);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ComputeBufferType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ComputeBufferType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineFogModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.FogMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.FogMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.FogMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", UnityEngine.FogMode.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Exponential", UnityEngine.FogMode.Exponential);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExponentialSquared", UnityEngine.FogMode.ExponentialSquared);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.FogMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineFogMode(L, (UnityEngine.FogMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushUnityEngineFogMode(L, UnityEngine.FogMode.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Exponential"))
                {
                    translator.PushUnityEngineFogMode(L, UnityEngine.FogMode.Exponential);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExponentialSquared"))
                {
                    translator.PushUnityEngineFogMode(L, UnityEngine.FogMode.ExponentialSquared);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.FogMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.FogMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineReceiveGIWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ReceiveGI), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ReceiveGI), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ReceiveGI), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lightmaps", UnityEngine.ReceiveGI.Lightmaps);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LightProbes", UnityEngine.ReceiveGI.LightProbes);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ReceiveGI), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineReceiveGI(L, (UnityEngine.ReceiveGI)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Lightmaps"))
                {
                    translator.PushUnityEngineReceiveGI(L, UnityEngine.ReceiveGI.Lightmaps);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LightProbes"))
                {
                    translator.PushUnityEngineReceiveGI(L, UnityEngine.ReceiveGI.LightProbes);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ReceiveGI!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ReceiveGI! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineShadowProjectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ShadowProjection), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ShadowProjection), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ShadowProjection), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CloseFit", UnityEngine.ShadowProjection.CloseFit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StableFit", UnityEngine.ShadowProjection.StableFit);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ShadowProjection), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineShadowProjection(L, (UnityEngine.ShadowProjection)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "CloseFit"))
                {
                    translator.PushUnityEngineShadowProjection(L, UnityEngine.ShadowProjection.CloseFit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "StableFit"))
                {
                    translator.PushUnityEngineShadowProjection(L, UnityEngine.ShadowProjection.StableFit);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ShadowProjection!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ShadowProjection! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineShadowQualityWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ShadowQuality), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ShadowQuality), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ShadowQuality), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Disable", UnityEngine.ShadowQuality.Disable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HardOnly", UnityEngine.ShadowQuality.HardOnly);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", UnityEngine.ShadowQuality.All);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ShadowQuality), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineShadowQuality(L, (UnityEngine.ShadowQuality)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Disable"))
                {
                    translator.PushUnityEngineShadowQuality(L, UnityEngine.ShadowQuality.Disable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HardOnly"))
                {
                    translator.PushUnityEngineShadowQuality(L, UnityEngine.ShadowQuality.HardOnly);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushUnityEngineShadowQuality(L, UnityEngine.ShadowQuality.All);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ShadowQuality!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ShadowQuality! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineShadowResolutionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ShadowResolution), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ShadowResolution), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ShadowResolution), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Low", UnityEngine.ShadowResolution.Low);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Medium", UnityEngine.ShadowResolution.Medium);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "High", UnityEngine.ShadowResolution.High);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VeryHigh", UnityEngine.ShadowResolution.VeryHigh);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ShadowResolution), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineShadowResolution(L, (UnityEngine.ShadowResolution)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Low"))
                {
                    translator.PushUnityEngineShadowResolution(L, UnityEngine.ShadowResolution.Low);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Medium"))
                {
                    translator.PushUnityEngineShadowResolution(L, UnityEngine.ShadowResolution.Medium);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "High"))
                {
                    translator.PushUnityEngineShadowResolution(L, UnityEngine.ShadowResolution.High);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VeryHigh"))
                {
                    translator.PushUnityEngineShadowResolution(L, UnityEngine.ShadowResolution.VeryHigh);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ShadowResolution!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ShadowResolution! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineShadowmaskModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ShadowmaskMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ShadowmaskMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ShadowmaskMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shadowmask", UnityEngine.ShadowmaskMode.Shadowmask);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DistanceShadowmask", UnityEngine.ShadowmaskMode.DistanceShadowmask);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ShadowmaskMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineShadowmaskMode(L, (UnityEngine.ShadowmaskMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Shadowmask"))
                {
                    translator.PushUnityEngineShadowmaskMode(L, UnityEngine.ShadowmaskMode.Shadowmask);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DistanceShadowmask"))
                {
                    translator.PushUnityEngineShadowmaskMode(L, UnityEngine.ShadowmaskMode.DistanceShadowmask);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ShadowmaskMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ShadowmaskMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCameraClearFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CameraClearFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CameraClearFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CameraClearFlags), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Skybox", UnityEngine.CameraClearFlags.Skybox);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Color", UnityEngine.CameraClearFlags.Color);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SolidColor", UnityEngine.CameraClearFlags.SolidColor);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Depth", UnityEngine.CameraClearFlags.Depth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Nothing", UnityEngine.CameraClearFlags.Nothing);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CameraClearFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCameraClearFlags(L, (UnityEngine.CameraClearFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Skybox"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Skybox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Color"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Color);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SolidColor"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.SolidColor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Depth"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Depth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Nothing"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Nothing);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CameraClearFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CameraClearFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineDepthTextureModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.DepthTextureMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.DepthTextureMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.DepthTextureMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.DepthTextureMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Depth", UnityEngine.DepthTextureMode.Depth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DepthNormals", UnityEngine.DepthTextureMode.DepthNormals);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MotionVectors", UnityEngine.DepthTextureMode.MotionVectors);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.DepthTextureMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineDepthTextureMode(L, (UnityEngine.DepthTextureMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineDepthTextureMode(L, UnityEngine.DepthTextureMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Depth"))
                {
                    translator.PushUnityEngineDepthTextureMode(L, UnityEngine.DepthTextureMode.Depth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DepthNormals"))
                {
                    translator.PushUnityEngineDepthTextureMode(L, UnityEngine.DepthTextureMode.DepthNormals);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MotionVectors"))
                {
                    translator.PushUnityEngineDepthTextureMode(L, UnityEngine.DepthTextureMode.MotionVectors);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.DepthTextureMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.DepthTextureMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTexGenModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TexGenMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TexGenMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TexGenMode), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.TexGenMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SphereMap", UnityEngine.TexGenMode.SphereMap);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Object", UnityEngine.TexGenMode.Object);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EyeLinear", UnityEngine.TexGenMode.EyeLinear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubeReflect", UnityEngine.TexGenMode.CubeReflect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubeNormal", UnityEngine.TexGenMode.CubeNormal);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TexGenMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTexGenMode(L, (UnityEngine.TexGenMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineTexGenMode(L, UnityEngine.TexGenMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SphereMap"))
                {
                    translator.PushUnityEngineTexGenMode(L, UnityEngine.TexGenMode.SphereMap);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Object"))
                {
                    translator.PushUnityEngineTexGenMode(L, UnityEngine.TexGenMode.Object);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EyeLinear"))
                {
                    translator.PushUnityEngineTexGenMode(L, UnityEngine.TexGenMode.EyeLinear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubeReflect"))
                {
                    translator.PushUnityEngineTexGenMode(L, UnityEngine.TexGenMode.CubeReflect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubeNormal"))
                {
                    translator.PushUnityEngineTexGenMode(L, UnityEngine.TexGenMode.CubeNormal);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TexGenMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TexGenMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAnisotropicFilteringWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AnisotropicFiltering), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AnisotropicFiltering), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AnisotropicFiltering), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Disable", UnityEngine.AnisotropicFiltering.Disable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Enable", UnityEngine.AnisotropicFiltering.Enable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ForceEnable", UnityEngine.AnisotropicFiltering.ForceEnable);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AnisotropicFiltering), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAnisotropicFiltering(L, (UnityEngine.AnisotropicFiltering)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Disable"))
                {
                    translator.PushUnityEngineAnisotropicFiltering(L, UnityEngine.AnisotropicFiltering.Disable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Enable"))
                {
                    translator.PushUnityEngineAnisotropicFiltering(L, UnityEngine.AnisotropicFiltering.Enable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ForceEnable"))
                {
                    translator.PushUnityEngineAnisotropicFiltering(L, UnityEngine.AnisotropicFiltering.ForceEnable);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AnisotropicFiltering!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AnisotropicFiltering! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSkinWeightsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SkinWeights), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SkinWeights), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SkinWeights), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OneBone", UnityEngine.SkinWeights.OneBone);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TwoBones", UnityEngine.SkinWeights.TwoBones);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FourBones", UnityEngine.SkinWeights.FourBones);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unlimited", UnityEngine.SkinWeights.Unlimited);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SkinWeights), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSkinWeights(L, (UnityEngine.SkinWeights)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "OneBone"))
                {
                    translator.PushUnityEngineSkinWeights(L, UnityEngine.SkinWeights.OneBone);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TwoBones"))
                {
                    translator.PushUnityEngineSkinWeights(L, UnityEngine.SkinWeights.TwoBones);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FourBones"))
                {
                    translator.PushUnityEngineSkinWeights(L, UnityEngine.SkinWeights.FourBones);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unlimited"))
                {
                    translator.PushUnityEngineSkinWeights(L, UnityEngine.SkinWeights.Unlimited);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SkinWeights!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SkinWeights! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineMeshTopologyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.MeshTopology), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.MeshTopology), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.MeshTopology), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Triangles", UnityEngine.MeshTopology.Triangles);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Quads", UnityEngine.MeshTopology.Quads);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lines", UnityEngine.MeshTopology.Lines);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LineStrip", UnityEngine.MeshTopology.LineStrip);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Points", UnityEngine.MeshTopology.Points);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.MeshTopology), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineMeshTopology(L, (UnityEngine.MeshTopology)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Triangles"))
                {
                    translator.PushUnityEngineMeshTopology(L, UnityEngine.MeshTopology.Triangles);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Quads"))
                {
                    translator.PushUnityEngineMeshTopology(L, UnityEngine.MeshTopology.Quads);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lines"))
                {
                    translator.PushUnityEngineMeshTopology(L, UnityEngine.MeshTopology.Lines);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LineStrip"))
                {
                    translator.PushUnityEngineMeshTopology(L, UnityEngine.MeshTopology.LineStrip);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Points"))
                {
                    translator.PushUnityEngineMeshTopology(L, UnityEngine.MeshTopology.Points);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.MeshTopology!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.MeshTopology! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSkinQualityWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SkinQuality), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SkinQuality), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SkinQuality), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Auto", UnityEngine.SkinQuality.Auto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bone1", UnityEngine.SkinQuality.Bone1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bone2", UnityEngine.SkinQuality.Bone2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bone4", UnityEngine.SkinQuality.Bone4);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SkinQuality), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSkinQuality(L, (UnityEngine.SkinQuality)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Auto"))
                {
                    translator.PushUnityEngineSkinQuality(L, UnityEngine.SkinQuality.Auto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bone1"))
                {
                    translator.PushUnityEngineSkinQuality(L, UnityEngine.SkinQuality.Bone1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bone2"))
                {
                    translator.PushUnityEngineSkinQuality(L, UnityEngine.SkinQuality.Bone2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bone4"))
                {
                    translator.PushUnityEngineSkinQuality(L, UnityEngine.SkinQuality.Bone4);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SkinQuality!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SkinQuality! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineColorSpaceWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ColorSpace), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ColorSpace), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ColorSpace), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Uninitialized", UnityEngine.ColorSpace.Uninitialized);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Gamma", UnityEngine.ColorSpace.Gamma);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", UnityEngine.ColorSpace.Linear);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ColorSpace), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineColorSpace(L, (UnityEngine.ColorSpace)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Uninitialized"))
                {
                    translator.PushUnityEngineColorSpace(L, UnityEngine.ColorSpace.Uninitialized);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Gamma"))
                {
                    translator.PushUnityEngineColorSpace(L, UnityEngine.ColorSpace.Gamma);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushUnityEngineColorSpace(L, UnityEngine.ColorSpace.Linear);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ColorSpace!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ColorSpace! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineColorGamutWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ColorGamut), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ColorGamut), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ColorGamut), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "sRGB", UnityEngine.ColorGamut.sRGB);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rec709", UnityEngine.ColorGamut.Rec709);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rec2020", UnityEngine.ColorGamut.Rec2020);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DisplayP3", UnityEngine.ColorGamut.DisplayP3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HDR10", UnityEngine.ColorGamut.HDR10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DolbyHDR", UnityEngine.ColorGamut.DolbyHDR);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ColorGamut), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineColorGamut(L, (UnityEngine.ColorGamut)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "sRGB"))
                {
                    translator.PushUnityEngineColorGamut(L, UnityEngine.ColorGamut.sRGB);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rec709"))
                {
                    translator.PushUnityEngineColorGamut(L, UnityEngine.ColorGamut.Rec709);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rec2020"))
                {
                    translator.PushUnityEngineColorGamut(L, UnityEngine.ColorGamut.Rec2020);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DisplayP3"))
                {
                    translator.PushUnityEngineColorGamut(L, UnityEngine.ColorGamut.DisplayP3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HDR10"))
                {
                    translator.PushUnityEngineColorGamut(L, UnityEngine.ColorGamut.HDR10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DolbyHDR"))
                {
                    translator.PushUnityEngineColorGamut(L, UnityEngine.ColorGamut.DolbyHDR);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ColorGamut!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ColorGamut! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineScreenOrientationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ScreenOrientation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ScreenOrientation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ScreenOrientation), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Portrait", UnityEngine.ScreenOrientation.Portrait);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PortraitUpsideDown", UnityEngine.ScreenOrientation.PortraitUpsideDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LandscapeLeft", UnityEngine.ScreenOrientation.LandscapeLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LandscapeRight", UnityEngine.ScreenOrientation.LandscapeRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoRotation", UnityEngine.ScreenOrientation.AutoRotation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Landscape", UnityEngine.ScreenOrientation.Landscape);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ScreenOrientation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineScreenOrientation(L, (UnityEngine.ScreenOrientation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Portrait"))
                {
                    translator.PushUnityEngineScreenOrientation(L, UnityEngine.ScreenOrientation.Portrait);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PortraitUpsideDown"))
                {
                    translator.PushUnityEngineScreenOrientation(L, UnityEngine.ScreenOrientation.PortraitUpsideDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LandscapeLeft"))
                {
                    translator.PushUnityEngineScreenOrientation(L, UnityEngine.ScreenOrientation.LandscapeLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LandscapeRight"))
                {
                    translator.PushUnityEngineScreenOrientation(L, UnityEngine.ScreenOrientation.LandscapeRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoRotation"))
                {
                    translator.PushUnityEngineScreenOrientation(L, UnityEngine.ScreenOrientation.AutoRotation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Landscape"))
                {
                    translator.PushUnityEngineScreenOrientation(L, UnityEngine.ScreenOrientation.Landscape);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ScreenOrientation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ScreenOrientation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineFilterModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.FilterMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.FilterMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.FilterMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Point", UnityEngine.FilterMode.Point);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bilinear", UnityEngine.FilterMode.Bilinear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Trilinear", UnityEngine.FilterMode.Trilinear);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.FilterMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineFilterMode(L, (UnityEngine.FilterMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Point"))
                {
                    translator.PushUnityEngineFilterMode(L, UnityEngine.FilterMode.Point);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bilinear"))
                {
                    translator.PushUnityEngineFilterMode(L, UnityEngine.FilterMode.Bilinear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Trilinear"))
                {
                    translator.PushUnityEngineFilterMode(L, UnityEngine.FilterMode.Trilinear);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.FilterMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.FilterMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTextureWrapModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TextureWrapMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TextureWrapMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TextureWrapMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Repeat", UnityEngine.TextureWrapMode.Repeat);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clamp", UnityEngine.TextureWrapMode.Clamp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mirror", UnityEngine.TextureWrapMode.Mirror);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MirrorOnce", UnityEngine.TextureWrapMode.MirrorOnce);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TextureWrapMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTextureWrapMode(L, (UnityEngine.TextureWrapMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Repeat"))
                {
                    translator.PushUnityEngineTextureWrapMode(L, UnityEngine.TextureWrapMode.Repeat);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Clamp"))
                {
                    translator.PushUnityEngineTextureWrapMode(L, UnityEngine.TextureWrapMode.Clamp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mirror"))
                {
                    translator.PushUnityEngineTextureWrapMode(L, UnityEngine.TextureWrapMode.Mirror);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MirrorOnce"))
                {
                    translator.PushUnityEngineTextureWrapMode(L, UnityEngine.TextureWrapMode.MirrorOnce);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TextureWrapMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TextureWrapMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineNPOTSupportWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.NPOTSupport), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.NPOTSupport), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.NPOTSupport), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Restricted", UnityEngine.NPOTSupport.Restricted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Full", UnityEngine.NPOTSupport.Full);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.NPOTSupport), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineNPOTSupport(L, (UnityEngine.NPOTSupport)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Restricted"))
                {
                    translator.PushUnityEngineNPOTSupport(L, UnityEngine.NPOTSupport.Restricted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Full"))
                {
                    translator.PushUnityEngineNPOTSupport(L, UnityEngine.NPOTSupport.Full);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.NPOTSupport!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.NPOTSupport! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTextureFormatWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TextureFormat), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TextureFormat), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TextureFormat), L, null, 77, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.TextureFormat));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TextureFormat), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTextureFormat(L, (UnityEngine.TextureFormat)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.TextureFormat), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.TextureFormat) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TextureFormat! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCubemapFaceWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CubemapFace), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CubemapFace), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CubemapFace), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", UnityEngine.CubemapFace.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PositiveX", UnityEngine.CubemapFace.PositiveX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NegativeX", UnityEngine.CubemapFace.NegativeX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PositiveY", UnityEngine.CubemapFace.PositiveY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NegativeY", UnityEngine.CubemapFace.NegativeY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PositiveZ", UnityEngine.CubemapFace.PositiveZ);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NegativeZ", UnityEngine.CubemapFace.NegativeZ);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CubemapFace), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCubemapFace(L, (UnityEngine.CubemapFace)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushUnityEngineCubemapFace(L, UnityEngine.CubemapFace.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PositiveX"))
                {
                    translator.PushUnityEngineCubemapFace(L, UnityEngine.CubemapFace.PositiveX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NegativeX"))
                {
                    translator.PushUnityEngineCubemapFace(L, UnityEngine.CubemapFace.NegativeX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PositiveY"))
                {
                    translator.PushUnityEngineCubemapFace(L, UnityEngine.CubemapFace.PositiveY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NegativeY"))
                {
                    translator.PushUnityEngineCubemapFace(L, UnityEngine.CubemapFace.NegativeY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PositiveZ"))
                {
                    translator.PushUnityEngineCubemapFace(L, UnityEngine.CubemapFace.PositiveZ);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NegativeZ"))
                {
                    translator.PushUnityEngineCubemapFace(L, UnityEngine.CubemapFace.NegativeZ);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CubemapFace!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CubemapFace! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRenderTextureFormatWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RenderTextureFormat), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RenderTextureFormat), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RenderTextureFormat), L, null, 29, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.RenderTextureFormat));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RenderTextureFormat), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRenderTextureFormat(L, (UnityEngine.RenderTextureFormat)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.RenderTextureFormat), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.RenderTextureFormat) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RenderTextureFormat! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineVRTextureUsageWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.VRTextureUsage), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.VRTextureUsage), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.VRTextureUsage), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.VRTextureUsage.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OneEye", UnityEngine.VRTextureUsage.OneEye);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TwoEyes", UnityEngine.VRTextureUsage.TwoEyes);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DeviceSpecific", UnityEngine.VRTextureUsage.DeviceSpecific);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.VRTextureUsage), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineVRTextureUsage(L, (UnityEngine.VRTextureUsage)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineVRTextureUsage(L, UnityEngine.VRTextureUsage.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OneEye"))
                {
                    translator.PushUnityEngineVRTextureUsage(L, UnityEngine.VRTextureUsage.OneEye);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TwoEyes"))
                {
                    translator.PushUnityEngineVRTextureUsage(L, UnityEngine.VRTextureUsage.TwoEyes);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DeviceSpecific"))
                {
                    translator.PushUnityEngineVRTextureUsage(L, UnityEngine.VRTextureUsage.DeviceSpecific);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.VRTextureUsage!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.VRTextureUsage! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRenderTextureCreationFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RenderTextureCreationFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RenderTextureCreationFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RenderTextureCreationFlags), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MipMap", UnityEngine.RenderTextureCreationFlags.MipMap);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoGenerateMips", UnityEngine.RenderTextureCreationFlags.AutoGenerateMips);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SRGB", UnityEngine.RenderTextureCreationFlags.SRGB);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EyeTexture", UnityEngine.RenderTextureCreationFlags.EyeTexture);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnableRandomWrite", UnityEngine.RenderTextureCreationFlags.EnableRandomWrite);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CreatedFromScript", UnityEngine.RenderTextureCreationFlags.CreatedFromScript);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllowVerticalFlip", UnityEngine.RenderTextureCreationFlags.AllowVerticalFlip);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NoResolvedColorSurface", UnityEngine.RenderTextureCreationFlags.NoResolvedColorSurface);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DynamicallyScalable", UnityEngine.RenderTextureCreationFlags.DynamicallyScalable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BindMS", UnityEngine.RenderTextureCreationFlags.BindMS);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RenderTextureCreationFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRenderTextureCreationFlags(L, (UnityEngine.RenderTextureCreationFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "MipMap"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.MipMap);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoGenerateMips"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.AutoGenerateMips);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SRGB"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.SRGB);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EyeTexture"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.EyeTexture);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnableRandomWrite"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.EnableRandomWrite);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CreatedFromScript"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.CreatedFromScript);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AllowVerticalFlip"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.AllowVerticalFlip);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NoResolvedColorSurface"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.NoResolvedColorSurface);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DynamicallyScalable"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.DynamicallyScalable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BindMS"))
                {
                    translator.PushUnityEngineRenderTextureCreationFlags(L, UnityEngine.RenderTextureCreationFlags.BindMS);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RenderTextureCreationFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RenderTextureCreationFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRenderTextureReadWriteWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RenderTextureReadWrite), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RenderTextureReadWrite), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RenderTextureReadWrite), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", UnityEngine.RenderTextureReadWrite.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", UnityEngine.RenderTextureReadWrite.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "sRGB", UnityEngine.RenderTextureReadWrite.sRGB);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RenderTextureReadWrite), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRenderTextureReadWrite(L, (UnityEngine.RenderTextureReadWrite)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushUnityEngineRenderTextureReadWrite(L, UnityEngine.RenderTextureReadWrite.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushUnityEngineRenderTextureReadWrite(L, UnityEngine.RenderTextureReadWrite.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "sRGB"))
                {
                    translator.PushUnityEngineRenderTextureReadWrite(L, UnityEngine.RenderTextureReadWrite.sRGB);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RenderTextureReadWrite!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RenderTextureReadWrite! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRenderTextureMemorylessWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RenderTextureMemoryless), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RenderTextureMemoryless), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RenderTextureMemoryless), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.RenderTextureMemoryless.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Color", UnityEngine.RenderTextureMemoryless.Color);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Depth", UnityEngine.RenderTextureMemoryless.Depth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MSAA", UnityEngine.RenderTextureMemoryless.MSAA);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RenderTextureMemoryless), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRenderTextureMemoryless(L, (UnityEngine.RenderTextureMemoryless)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineRenderTextureMemoryless(L, UnityEngine.RenderTextureMemoryless.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Color"))
                {
                    translator.PushUnityEngineRenderTextureMemoryless(L, UnityEngine.RenderTextureMemoryless.Color);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Depth"))
                {
                    translator.PushUnityEngineRenderTextureMemoryless(L, UnityEngine.RenderTextureMemoryless.Depth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MSAA"))
                {
                    translator.PushUnityEngineRenderTextureMemoryless(L, UnityEngine.RenderTextureMemoryless.MSAA);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RenderTextureMemoryless!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RenderTextureMemoryless! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineMaterialGlobalIlluminationFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.MaterialGlobalIlluminationFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.MaterialGlobalIlluminationFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.MaterialGlobalIlluminationFlags), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.MaterialGlobalIlluminationFlags.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RealtimeEmissive", UnityEngine.MaterialGlobalIlluminationFlags.RealtimeEmissive);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BakedEmissive", UnityEngine.MaterialGlobalIlluminationFlags.BakedEmissive);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmissiveIsBlack", UnityEngine.MaterialGlobalIlluminationFlags.EmissiveIsBlack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AnyEmissive", UnityEngine.MaterialGlobalIlluminationFlags.AnyEmissive);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.MaterialGlobalIlluminationFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineMaterialGlobalIlluminationFlags(L, (UnityEngine.MaterialGlobalIlluminationFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineMaterialGlobalIlluminationFlags(L, UnityEngine.MaterialGlobalIlluminationFlags.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RealtimeEmissive"))
                {
                    translator.PushUnityEngineMaterialGlobalIlluminationFlags(L, UnityEngine.MaterialGlobalIlluminationFlags.RealtimeEmissive);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BakedEmissive"))
                {
                    translator.PushUnityEngineMaterialGlobalIlluminationFlags(L, UnityEngine.MaterialGlobalIlluminationFlags.BakedEmissive);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmissiveIsBlack"))
                {
                    translator.PushUnityEngineMaterialGlobalIlluminationFlags(L, UnityEngine.MaterialGlobalIlluminationFlags.EmissiveIsBlack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AnyEmissive"))
                {
                    translator.PushUnityEngineMaterialGlobalIlluminationFlags(L, UnityEngine.MaterialGlobalIlluminationFlags.AnyEmissive);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.MaterialGlobalIlluminationFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.MaterialGlobalIlluminationFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCustomRenderTextureInitializationSourceWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CustomRenderTextureInitializationSource), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CustomRenderTextureInitializationSource), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CustomRenderTextureInitializationSource), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TextureAndColor", UnityEngine.CustomRenderTextureInitializationSource.TextureAndColor);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Material", UnityEngine.CustomRenderTextureInitializationSource.Material);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CustomRenderTextureInitializationSource), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCustomRenderTextureInitializationSource(L, (UnityEngine.CustomRenderTextureInitializationSource)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "TextureAndColor"))
                {
                    translator.PushUnityEngineCustomRenderTextureInitializationSource(L, UnityEngine.CustomRenderTextureInitializationSource.TextureAndColor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Material"))
                {
                    translator.PushUnityEngineCustomRenderTextureInitializationSource(L, UnityEngine.CustomRenderTextureInitializationSource.Material);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CustomRenderTextureInitializationSource!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CustomRenderTextureInitializationSource! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCustomRenderTextureUpdateModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CustomRenderTextureUpdateMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CustomRenderTextureUpdateMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CustomRenderTextureUpdateMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnLoad", UnityEngine.CustomRenderTextureUpdateMode.OnLoad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Realtime", UnityEngine.CustomRenderTextureUpdateMode.Realtime);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnDemand", UnityEngine.CustomRenderTextureUpdateMode.OnDemand);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CustomRenderTextureUpdateMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCustomRenderTextureUpdateMode(L, (UnityEngine.CustomRenderTextureUpdateMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "OnLoad"))
                {
                    translator.PushUnityEngineCustomRenderTextureUpdateMode(L, UnityEngine.CustomRenderTextureUpdateMode.OnLoad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Realtime"))
                {
                    translator.PushUnityEngineCustomRenderTextureUpdateMode(L, UnityEngine.CustomRenderTextureUpdateMode.Realtime);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnDemand"))
                {
                    translator.PushUnityEngineCustomRenderTextureUpdateMode(L, UnityEngine.CustomRenderTextureUpdateMode.OnDemand);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CustomRenderTextureUpdateMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CustomRenderTextureUpdateMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCustomRenderTextureUpdateZoneSpaceWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normalized", UnityEngine.CustomRenderTextureUpdateZoneSpace.Normalized);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pixel", UnityEngine.CustomRenderTextureUpdateZoneSpace.Pixel);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCustomRenderTextureUpdateZoneSpace(L, (UnityEngine.CustomRenderTextureUpdateZoneSpace)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Normalized"))
                {
                    translator.PushUnityEngineCustomRenderTextureUpdateZoneSpace(L, UnityEngine.CustomRenderTextureUpdateZoneSpace.Normalized);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pixel"))
                {
                    translator.PushUnityEngineCustomRenderTextureUpdateZoneSpace(L, UnityEngine.CustomRenderTextureUpdateZoneSpace.Pixel);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CustomRenderTextureUpdateZoneSpace!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CustomRenderTextureUpdateZoneSpace! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineLineTextureModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.LineTextureMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.LineTextureMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.LineTextureMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stretch", UnityEngine.LineTextureMode.Stretch);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tile", UnityEngine.LineTextureMode.Tile);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DistributePerSegment", UnityEngine.LineTextureMode.DistributePerSegment);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RepeatPerSegment", UnityEngine.LineTextureMode.RepeatPerSegment);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.LineTextureMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineLineTextureMode(L, (UnityEngine.LineTextureMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Stretch"))
                {
                    translator.PushUnityEngineLineTextureMode(L, UnityEngine.LineTextureMode.Stretch);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tile"))
                {
                    translator.PushUnityEngineLineTextureMode(L, UnityEngine.LineTextureMode.Tile);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DistributePerSegment"))
                {
                    translator.PushUnityEngineLineTextureMode(L, UnityEngine.LineTextureMode.DistributePerSegment);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RepeatPerSegment"))
                {
                    translator.PushUnityEngineLineTextureMode(L, UnityEngine.LineTextureMode.RepeatPerSegment);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.LineTextureMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.LineTextureMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineLineAlignmentWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.LineAlignment), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.LineAlignment), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.LineAlignment), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "View", UnityEngine.LineAlignment.View);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TransformZ", UnityEngine.LineAlignment.TransformZ);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.LineAlignment), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineLineAlignment(L, (UnityEngine.LineAlignment)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "View"))
                {
                    translator.PushUnityEngineLineAlignment(L, UnityEngine.LineAlignment.View);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TransformZ"))
                {
                    translator.PushUnityEngineLineAlignment(L, UnityEngine.LineAlignment.TransformZ);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.LineAlignment!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.LineAlignment! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineLODFadeModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.LODFadeMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.LODFadeMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.LODFadeMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.LODFadeMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CrossFade", UnityEngine.LODFadeMode.CrossFade);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpeedTree", UnityEngine.LODFadeMode.SpeedTree);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.LODFadeMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineLODFadeMode(L, (UnityEngine.LODFadeMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineLODFadeMode(L, UnityEngine.LODFadeMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CrossFade"))
                {
                    translator.PushUnityEngineLODFadeMode(L, UnityEngine.LODFadeMode.CrossFade);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpeedTree"))
                {
                    translator.PushUnityEngineLODFadeMode(L, UnityEngine.LODFadeMode.SpeedTree);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.LODFadeMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.LODFadeMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTexture2DEXRFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.Texture2D.EXRFlags.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutputAsFloat", UnityEngine.Texture2D.EXRFlags.OutputAsFloat);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompressZIP", UnityEngine.Texture2D.EXRFlags.CompressZIP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompressRLE", UnityEngine.Texture2D.EXRFlags.CompressRLE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompressPIZ", UnityEngine.Texture2D.EXRFlags.CompressPIZ);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTexture2DEXRFlags(L, (UnityEngine.Texture2D.EXRFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutputAsFloat"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.OutputAsFloat);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CompressZIP"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.CompressZIP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CompressRLE"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.CompressRLE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CompressPIZ"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.CompressPIZ);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Texture2D.EXRFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Texture2D.EXRFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineKeyCodeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.KeyCode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.KeyCode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.KeyCode), L, null, 327, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.KeyCode));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.KeyCode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineKeyCode(L, (UnityEngine.KeyCode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.KeyCode), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.KeyCode) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.KeyCode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineGradientModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.GradientMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.GradientMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.GradientMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Blend", UnityEngine.GradientMode.Blend);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed", UnityEngine.GradientMode.Fixed);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.GradientMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineGradientMode(L, (UnityEngine.GradientMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Blend"))
                {
                    translator.PushUnityEngineGradientMode(L, UnityEngine.GradientMode.Blend);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed"))
                {
                    translator.PushUnityEngineGradientMode(L, UnityEngine.GradientMode.Fixed);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.GradientMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.GradientMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRuntimeInitializeLoadTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RuntimeInitializeLoadType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RuntimeInitializeLoadType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RuntimeInitializeLoadType), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AfterSceneLoad", UnityEngine.RuntimeInitializeLoadType.AfterSceneLoad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BeforeSceneLoad", UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AfterAssembliesLoaded", UnityEngine.RuntimeInitializeLoadType.AfterAssembliesLoaded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BeforeSplashScreen", UnityEngine.RuntimeInitializeLoadType.BeforeSplashScreen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SubsystemRegistration", UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RuntimeInitializeLoadType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRuntimeInitializeLoadType(L, (UnityEngine.RuntimeInitializeLoadType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "AfterSceneLoad"))
                {
                    translator.PushUnityEngineRuntimeInitializeLoadType(L, UnityEngine.RuntimeInitializeLoadType.AfterSceneLoad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BeforeSceneLoad"))
                {
                    translator.PushUnityEngineRuntimeInitializeLoadType(L, UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AfterAssembliesLoaded"))
                {
                    translator.PushUnityEngineRuntimeInitializeLoadType(L, UnityEngine.RuntimeInitializeLoadType.AfterAssembliesLoaded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BeforeSplashScreen"))
                {
                    translator.PushUnityEngineRuntimeInitializeLoadType(L, UnityEngine.RuntimeInitializeLoadType.BeforeSplashScreen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SubsystemRegistration"))
                {
                    translator.PushUnityEngineRuntimeInitializeLoadType(L, UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RuntimeInitializeLoadType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RuntimeInitializeLoadType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineHideFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.HideFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.HideFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.HideFlags), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.HideFlags.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HideInHierarchy", UnityEngine.HideFlags.HideInHierarchy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HideInInspector", UnityEngine.HideFlags.HideInInspector);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DontSaveInEditor", UnityEngine.HideFlags.DontSaveInEditor);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotEditable", UnityEngine.HideFlags.NotEditable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DontSaveInBuild", UnityEngine.HideFlags.DontSaveInBuild);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DontUnloadUnusedAsset", UnityEngine.HideFlags.DontUnloadUnusedAsset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DontSave", UnityEngine.HideFlags.DontSave);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HideAndDontSave", UnityEngine.HideFlags.HideAndDontSave);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.HideFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineHideFlags(L, (UnityEngine.HideFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HideInHierarchy"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.HideInHierarchy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HideInInspector"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.HideInInspector);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontSaveInEditor"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontSaveInEditor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotEditable"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.NotEditable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontSaveInBuild"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontSaveInBuild);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontUnloadUnusedAsset"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontUnloadUnusedAsset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontSave"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontSave);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HideAndDontSave"))
                {
                    translator.PushUnityEngineHideFlags(L, UnityEngine.HideFlags.HideAndDontSave);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.HideFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.HideFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSnapAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SnapAxis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SnapAxis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SnapAxis), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.SnapAxis.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "X", UnityEngine.SnapAxis.X);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Y", UnityEngine.SnapAxis.Y);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Z", UnityEngine.SnapAxis.Z);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", UnityEngine.SnapAxis.All);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SnapAxis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSnapAxis(L, (UnityEngine.SnapAxis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineSnapAxis(L, UnityEngine.SnapAxis.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "X"))
                {
                    translator.PushUnityEngineSnapAxis(L, UnityEngine.SnapAxis.X);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Y"))
                {
                    translator.PushUnityEngineSnapAxis(L, UnityEngine.SnapAxis.Y);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Z"))
                {
                    translator.PushUnityEngineSnapAxis(L, UnityEngine.SnapAxis.Z);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushUnityEngineSnapAxis(L, UnityEngine.SnapAxis.All);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SnapAxis!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SnapAxis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineBatteryStatusWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.BatteryStatus), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.BatteryStatus), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.BatteryStatus), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", UnityEngine.BatteryStatus.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Charging", UnityEngine.BatteryStatus.Charging);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Discharging", UnityEngine.BatteryStatus.Discharging);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotCharging", UnityEngine.BatteryStatus.NotCharging);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Full", UnityEngine.BatteryStatus.Full);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.BatteryStatus), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineBatteryStatus(L, (UnityEngine.BatteryStatus)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushUnityEngineBatteryStatus(L, UnityEngine.BatteryStatus.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Charging"))
                {
                    translator.PushUnityEngineBatteryStatus(L, UnityEngine.BatteryStatus.Charging);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Discharging"))
                {
                    translator.PushUnityEngineBatteryStatus(L, UnityEngine.BatteryStatus.Discharging);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotCharging"))
                {
                    translator.PushUnityEngineBatteryStatus(L, UnityEngine.BatteryStatus.NotCharging);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Full"))
                {
                    translator.PushUnityEngineBatteryStatus(L, UnityEngine.BatteryStatus.Full);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.BatteryStatus!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.BatteryStatus! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineOperatingSystemFamilyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.OperatingSystemFamily), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.OperatingSystemFamily), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.OperatingSystemFamily), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Other", UnityEngine.OperatingSystemFamily.Other);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MacOSX", UnityEngine.OperatingSystemFamily.MacOSX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Windows", UnityEngine.OperatingSystemFamily.Windows);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linux", UnityEngine.OperatingSystemFamily.Linux);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.OperatingSystemFamily), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineOperatingSystemFamily(L, (UnityEngine.OperatingSystemFamily)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Other"))
                {
                    translator.PushUnityEngineOperatingSystemFamily(L, UnityEngine.OperatingSystemFamily.Other);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MacOSX"))
                {
                    translator.PushUnityEngineOperatingSystemFamily(L, UnityEngine.OperatingSystemFamily.MacOSX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Windows"))
                {
                    translator.PushUnityEngineOperatingSystemFamily(L, UnityEngine.OperatingSystemFamily.Windows);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Linux"))
                {
                    translator.PushUnityEngineOperatingSystemFamily(L, UnityEngine.OperatingSystemFamily.Linux);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.OperatingSystemFamily!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.OperatingSystemFamily! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineDeviceTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.DeviceType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.DeviceType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.DeviceType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", UnityEngine.DeviceType.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Handheld", UnityEngine.DeviceType.Handheld);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Console", UnityEngine.DeviceType.Console);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Desktop", UnityEngine.DeviceType.Desktop);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.DeviceType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineDeviceType(L, (UnityEngine.DeviceType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushUnityEngineDeviceType(L, UnityEngine.DeviceType.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Handheld"))
                {
                    translator.PushUnityEngineDeviceType(L, UnityEngine.DeviceType.Handheld);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Console"))
                {
                    translator.PushUnityEngineDeviceType(L, UnityEngine.DeviceType.Console);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Desktop"))
                {
                    translator.PushUnityEngineDeviceType(L, UnityEngine.DeviceType.Desktop);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.DeviceType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.DeviceType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineDrivenTransformPropertiesWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.DrivenTransformProperties), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.DrivenTransformProperties), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.DrivenTransformProperties), L, null, 26, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.DrivenTransformProperties));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.DrivenTransformProperties), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineDrivenTransformProperties(L, (UnityEngine.DrivenTransformProperties)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.DrivenTransformProperties), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.DrivenTransformProperties) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.DrivenTransformProperties! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRectTransformEdgeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RectTransform.Edge), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RectTransform.Edge), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RectTransform.Edge), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.RectTransform.Edge.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.RectTransform.Edge.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.RectTransform.Edge.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.RectTransform.Edge.Bottom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RectTransform.Edge), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRectTransformEdge(L, (UnityEngine.RectTransform.Edge)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Bottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RectTransform.Edge!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RectTransform.Edge! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRectTransformAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RectTransform.Axis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RectTransform.Axis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RectTransform.Axis), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.RectTransform.Axis.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.RectTransform.Axis.Vertical);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RectTransform.Axis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRectTransformAxis(L, (UnityEngine.RectTransform.Axis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineRectTransformAxis(L, UnityEngine.RectTransform.Axis.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineRectTransformAxis(L, UnityEngine.RectTransform.Axis.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RectTransform.Axis!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RectTransform.Axis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpriteDrawModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpriteDrawMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpriteDrawMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpriteDrawMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Simple", UnityEngine.SpriteDrawMode.Simple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sliced", UnityEngine.SpriteDrawMode.Sliced);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tiled", UnityEngine.SpriteDrawMode.Tiled);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpriteDrawMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpriteDrawMode(L, (UnityEngine.SpriteDrawMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Simple"))
                {
                    translator.PushUnityEngineSpriteDrawMode(L, UnityEngine.SpriteDrawMode.Simple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sliced"))
                {
                    translator.PushUnityEngineSpriteDrawMode(L, UnityEngine.SpriteDrawMode.Sliced);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tiled"))
                {
                    translator.PushUnityEngineSpriteDrawMode(L, UnityEngine.SpriteDrawMode.Tiled);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpriteDrawMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpriteDrawMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpriteTileModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpriteTileMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpriteTileMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpriteTileMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Continuous", UnityEngine.SpriteTileMode.Continuous);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Adaptive", UnityEngine.SpriteTileMode.Adaptive);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpriteTileMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpriteTileMode(L, (UnityEngine.SpriteTileMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Continuous"))
                {
                    translator.PushUnityEngineSpriteTileMode(L, UnityEngine.SpriteTileMode.Continuous);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Adaptive"))
                {
                    translator.PushUnityEngineSpriteTileMode(L, UnityEngine.SpriteTileMode.Adaptive);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpriteTileMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpriteTileMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpriteMaskInteractionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpriteMaskInteraction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpriteMaskInteraction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpriteMaskInteraction), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.SpriteMaskInteraction.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VisibleInsideMask", UnityEngine.SpriteMaskInteraction.VisibleInsideMask);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VisibleOutsideMask", UnityEngine.SpriteMaskInteraction.VisibleOutsideMask);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpriteMaskInteraction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpriteMaskInteraction(L, (UnityEngine.SpriteMaskInteraction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineSpriteMaskInteraction(L, UnityEngine.SpriteMaskInteraction.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VisibleInsideMask"))
                {
                    translator.PushUnityEngineSpriteMaskInteraction(L, UnityEngine.SpriteMaskInteraction.VisibleInsideMask);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VisibleOutsideMask"))
                {
                    translator.PushUnityEngineSpriteMaskInteraction(L, UnityEngine.SpriteMaskInteraction.VisibleOutsideMask);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpriteMaskInteraction!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpriteMaskInteraction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpriteMeshTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpriteMeshType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpriteMeshType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpriteMeshType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FullRect", UnityEngine.SpriteMeshType.FullRect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tight", UnityEngine.SpriteMeshType.Tight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpriteMeshType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpriteMeshType(L, (UnityEngine.SpriteMeshType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "FullRect"))
                {
                    translator.PushUnityEngineSpriteMeshType(L, UnityEngine.SpriteMeshType.FullRect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tight"))
                {
                    translator.PushUnityEngineSpriteMeshType(L, UnityEngine.SpriteMeshType.Tight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpriteMeshType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpriteMeshType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpriteAlignmentWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpriteAlignment), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpriteAlignment), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpriteAlignment), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Center", UnityEngine.SpriteAlignment.Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLeft", UnityEngine.SpriteAlignment.TopLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopCenter", UnityEngine.SpriteAlignment.TopCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopRight", UnityEngine.SpriteAlignment.TopRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftCenter", UnityEngine.SpriteAlignment.LeftCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightCenter", UnityEngine.SpriteAlignment.RightCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomLeft", UnityEngine.SpriteAlignment.BottomLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomCenter", UnityEngine.SpriteAlignment.BottomCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomRight", UnityEngine.SpriteAlignment.BottomRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", UnityEngine.SpriteAlignment.Custom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpriteAlignment), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpriteAlignment(L, (UnityEngine.SpriteAlignment)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Center"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopLeft"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.TopLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopCenter"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.TopCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopRight"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.TopRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftCenter"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.LeftCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightCenter"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.RightCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomLeft"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.BottomLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomCenter"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.BottomCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomRight"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.BottomRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushUnityEngineSpriteAlignment(L, UnityEngine.SpriteAlignment.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpriteAlignment!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpriteAlignment! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpritePackingModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpritePackingMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpritePackingMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpritePackingMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tight", UnityEngine.SpritePackingMode.Tight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rectangle", UnityEngine.SpritePackingMode.Rectangle);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpritePackingMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpritePackingMode(L, (UnityEngine.SpritePackingMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Tight"))
                {
                    translator.PushUnityEngineSpritePackingMode(L, UnityEngine.SpritePackingMode.Tight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rectangle"))
                {
                    translator.PushUnityEngineSpritePackingMode(L, UnityEngine.SpritePackingMode.Rectangle);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpritePackingMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpritePackingMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpritePackingRotationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpritePackingRotation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpritePackingRotation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpritePackingRotation), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.SpritePackingRotation.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlipHorizontal", UnityEngine.SpritePackingRotation.FlipHorizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlipVertical", UnityEngine.SpritePackingRotation.FlipVertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rotate180", UnityEngine.SpritePackingRotation.Rotate180);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Any", UnityEngine.SpritePackingRotation.Any);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpritePackingRotation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpritePackingRotation(L, (UnityEngine.SpritePackingRotation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineSpritePackingRotation(L, UnityEngine.SpritePackingRotation.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlipHorizontal"))
                {
                    translator.PushUnityEngineSpritePackingRotation(L, UnityEngine.SpritePackingRotation.FlipHorizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlipVertical"))
                {
                    translator.PushUnityEngineSpritePackingRotation(L, UnityEngine.SpritePackingRotation.FlipVertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rotate180"))
                {
                    translator.PushUnityEngineSpritePackingRotation(L, UnityEngine.SpritePackingRotation.Rotate180);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Any"))
                {
                    translator.PushUnityEngineSpritePackingRotation(L, UnityEngine.SpritePackingRotation.Any);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpritePackingRotation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpritePackingRotation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineSpriteSortPointWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.SpriteSortPoint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.SpriteSortPoint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.SpriteSortPoint), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Center", UnityEngine.SpriteSortPoint.Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pivot", UnityEngine.SpriteSortPoint.Pivot);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.SpriteSortPoint), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineSpriteSortPoint(L, (UnityEngine.SpriteSortPoint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Center"))
                {
                    translator.PushUnityEngineSpriteSortPoint(L, UnityEngine.SpriteSortPoint.Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pivot"))
                {
                    translator.PushUnityEngineSpriteSortPoint(L, UnityEngine.SpriteSortPoint.Pivot);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.SpriteSortPoint!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.SpriteSortPoint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineGridLayoutCellLayoutWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.GridLayout.CellLayout), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.GridLayout.CellLayout), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.GridLayout.CellLayout), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rectangle", UnityEngine.GridLayout.CellLayout.Rectangle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hexagon", UnityEngine.GridLayout.CellLayout.Hexagon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Isometric", UnityEngine.GridLayout.CellLayout.Isometric);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IsometricZAsY", UnityEngine.GridLayout.CellLayout.IsometricZAsY);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.GridLayout.CellLayout), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineGridLayoutCellLayout(L, (UnityEngine.GridLayout.CellLayout)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Rectangle"))
                {
                    translator.PushUnityEngineGridLayoutCellLayout(L, UnityEngine.GridLayout.CellLayout.Rectangle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hexagon"))
                {
                    translator.PushUnityEngineGridLayoutCellLayout(L, UnityEngine.GridLayout.CellLayout.Hexagon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Isometric"))
                {
                    translator.PushUnityEngineGridLayoutCellLayout(L, UnityEngine.GridLayout.CellLayout.Isometric);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IsometricZAsY"))
                {
                    translator.PushUnityEngineGridLayoutCellLayout(L, UnityEngine.GridLayout.CellLayout.IsometricZAsY);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.GridLayout.CellLayout!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.GridLayout.CellLayout! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineGridLayoutCellSwizzleWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.GridLayout.CellSwizzle), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.GridLayout.CellSwizzle), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.GridLayout.CellSwizzle), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XYZ", UnityEngine.GridLayout.CellSwizzle.XYZ);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XZY", UnityEngine.GridLayout.CellSwizzle.XZY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "YXZ", UnityEngine.GridLayout.CellSwizzle.YXZ);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "YZX", UnityEngine.GridLayout.CellSwizzle.YZX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ZXY", UnityEngine.GridLayout.CellSwizzle.ZXY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ZYX", UnityEngine.GridLayout.CellSwizzle.ZYX);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.GridLayout.CellSwizzle), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineGridLayoutCellSwizzle(L, (UnityEngine.GridLayout.CellSwizzle)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "XYZ"))
                {
                    translator.PushUnityEngineGridLayoutCellSwizzle(L, UnityEngine.GridLayout.CellSwizzle.XYZ);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "XZY"))
                {
                    translator.PushUnityEngineGridLayoutCellSwizzle(L, UnityEngine.GridLayout.CellSwizzle.XZY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "YXZ"))
                {
                    translator.PushUnityEngineGridLayoutCellSwizzle(L, UnityEngine.GridLayout.CellSwizzle.YXZ);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "YZX"))
                {
                    translator.PushUnityEngineGridLayoutCellSwizzle(L, UnityEngine.GridLayout.CellSwizzle.YZX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ZXY"))
                {
                    translator.PushUnityEngineGridLayoutCellSwizzle(L, UnityEngine.GridLayout.CellSwizzle.ZXY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ZYX"))
                {
                    translator.PushUnityEngineGridLayoutCellSwizzle(L, UnityEngine.GridLayout.CellSwizzle.ZYX);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.GridLayout.CellSwizzle!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.GridLayout.CellSwizzle! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEnginePointerTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.PointerType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.PointerType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.PointerType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse", UnityEngine.PointerType.Mouse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Touch", UnityEngine.PointerType.Touch);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pen", UnityEngine.PointerType.Pen);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.PointerType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEnginePointerType(L, (UnityEngine.PointerType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse"))
                {
                    translator.PushUnityEnginePointerType(L, UnityEngine.PointerType.Mouse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Touch"))
                {
                    translator.PushUnityEnginePointerType(L, UnityEngine.PointerType.Touch);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pen"))
                {
                    translator.PushUnityEnginePointerType(L, UnityEngine.PointerType.Pen);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.PointerType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.PointerType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ScaleMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StretchToFill", UnityEngine.ScaleMode.StretchToFill);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleAndCrop", UnityEngine.ScaleMode.ScaleAndCrop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleToFit", UnityEngine.ScaleMode.ScaleToFit);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ScaleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineScaleMode(L, (UnityEngine.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "StretchToFill"))
                {
                    translator.PushUnityEngineScaleMode(L, UnityEngine.ScaleMode.StretchToFill);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleAndCrop"))
                {
                    translator.PushUnityEngineScaleMode(L, UnityEngine.ScaleMode.ScaleAndCrop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleToFit"))
                {
                    translator.PushUnityEngineScaleMode(L, UnityEngine.ScaleMode.ScaleToFit);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ScaleMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineFocusTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.FocusType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.FocusType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.FocusType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keyboard", UnityEngine.FocusType.Keyboard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Passive", UnityEngine.FocusType.Passive);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.FocusType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineFocusType(L, (UnityEngine.FocusType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Keyboard"))
                {
                    translator.PushUnityEngineFocusType(L, UnityEngine.FocusType.Keyboard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Passive"))
                {
                    translator.PushUnityEngineFocusType(L, UnityEngine.FocusType.Passive);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.FocusType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.FocusType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineImagePositionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ImagePosition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ImagePosition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ImagePosition), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ImageLeft", UnityEngine.ImagePosition.ImageLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ImageAbove", UnityEngine.ImagePosition.ImageAbove);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ImageOnly", UnityEngine.ImagePosition.ImageOnly);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TextOnly", UnityEngine.ImagePosition.TextOnly);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ImagePosition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineImagePosition(L, (UnityEngine.ImagePosition)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ImageLeft"))
                {
                    translator.PushUnityEngineImagePosition(L, UnityEngine.ImagePosition.ImageLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ImageAbove"))
                {
                    translator.PushUnityEngineImagePosition(L, UnityEngine.ImagePosition.ImageAbove);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ImageOnly"))
                {
                    translator.PushUnityEngineImagePosition(L, UnityEngine.ImagePosition.ImageOnly);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TextOnly"))
                {
                    translator.PushUnityEngineImagePosition(L, UnityEngine.ImagePosition.TextOnly);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ImagePosition!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ImagePosition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTouchPhaseWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TouchPhase), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TouchPhase), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TouchPhase), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Began", UnityEngine.TouchPhase.Began);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Moved", UnityEngine.TouchPhase.Moved);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stationary", UnityEngine.TouchPhase.Stationary);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ended", UnityEngine.TouchPhase.Ended);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Canceled", UnityEngine.TouchPhase.Canceled);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TouchPhase), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTouchPhase(L, (UnityEngine.TouchPhase)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Began"))
                {
                    translator.PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Began);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Moved"))
                {
                    translator.PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Moved);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Stationary"))
                {
                    translator.PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Stationary);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ended"))
                {
                    translator.PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Ended);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Canceled"))
                {
                    translator.PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Canceled);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TouchPhase!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TouchPhase! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineIMECompositionModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.IMECompositionMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.IMECompositionMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.IMECompositionMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Auto", UnityEngine.IMECompositionMode.Auto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "On", UnityEngine.IMECompositionMode.On);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Off", UnityEngine.IMECompositionMode.Off);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.IMECompositionMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineIMECompositionMode(L, (UnityEngine.IMECompositionMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Auto"))
                {
                    translator.PushUnityEngineIMECompositionMode(L, UnityEngine.IMECompositionMode.Auto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "On"))
                {
                    translator.PushUnityEngineIMECompositionMode(L, UnityEngine.IMECompositionMode.On);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Off"))
                {
                    translator.PushUnityEngineIMECompositionMode(L, UnityEngine.IMECompositionMode.Off);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.IMECompositionMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.IMECompositionMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTouchTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TouchType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TouchType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TouchType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Direct", UnityEngine.TouchType.Direct);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Indirect", UnityEngine.TouchType.Indirect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stylus", UnityEngine.TouchType.Stylus);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TouchType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTouchType(L, (UnityEngine.TouchType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Direct"))
                {
                    translator.PushUnityEngineTouchType(L, UnityEngine.TouchType.Direct);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Indirect"))
                {
                    translator.PushUnityEngineTouchType(L, UnityEngine.TouchType.Indirect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Stylus"))
                {
                    translator.PushUnityEngineTouchType(L, UnityEngine.TouchType.Stylus);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TouchType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TouchType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineDeviceOrientationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.DeviceOrientation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.DeviceOrientation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.DeviceOrientation), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", UnityEngine.DeviceOrientation.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Portrait", UnityEngine.DeviceOrientation.Portrait);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PortraitUpsideDown", UnityEngine.DeviceOrientation.PortraitUpsideDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LandscapeLeft", UnityEngine.DeviceOrientation.LandscapeLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LandscapeRight", UnityEngine.DeviceOrientation.LandscapeRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FaceUp", UnityEngine.DeviceOrientation.FaceUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FaceDown", UnityEngine.DeviceOrientation.FaceDown);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.DeviceOrientation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineDeviceOrientation(L, (UnityEngine.DeviceOrientation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushUnityEngineDeviceOrientation(L, UnityEngine.DeviceOrientation.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Portrait"))
                {
                    translator.PushUnityEngineDeviceOrientation(L, UnityEngine.DeviceOrientation.Portrait);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PortraitUpsideDown"))
                {
                    translator.PushUnityEngineDeviceOrientation(L, UnityEngine.DeviceOrientation.PortraitUpsideDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LandscapeLeft"))
                {
                    translator.PushUnityEngineDeviceOrientation(L, UnityEngine.DeviceOrientation.LandscapeLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LandscapeRight"))
                {
                    translator.PushUnityEngineDeviceOrientation(L, UnityEngine.DeviceOrientation.LandscapeRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FaceUp"))
                {
                    translator.PushUnityEngineDeviceOrientation(L, UnityEngine.DeviceOrientation.FaceUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FaceDown"))
                {
                    translator.PushUnityEngineDeviceOrientation(L, UnityEngine.DeviceOrientation.FaceDown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.DeviceOrientation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.DeviceOrientation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineLocationServiceStatusWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.LocationServiceStatus), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.LocationServiceStatus), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.LocationServiceStatus), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stopped", UnityEngine.LocationServiceStatus.Stopped);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Initializing", UnityEngine.LocationServiceStatus.Initializing);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Running", UnityEngine.LocationServiceStatus.Running);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Failed", UnityEngine.LocationServiceStatus.Failed);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.LocationServiceStatus), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineLocationServiceStatus(L, (UnityEngine.LocationServiceStatus)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Stopped"))
                {
                    translator.PushUnityEngineLocationServiceStatus(L, UnityEngine.LocationServiceStatus.Stopped);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Initializing"))
                {
                    translator.PushUnityEngineLocationServiceStatus(L, UnityEngine.LocationServiceStatus.Initializing);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Running"))
                {
                    translator.PushUnityEngineLocationServiceStatus(L, UnityEngine.LocationServiceStatus.Running);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Failed"))
                {
                    translator.PushUnityEngineLocationServiceStatus(L, UnityEngine.LocationServiceStatus.Failed);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.LocationServiceStatus!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.LocationServiceStatus! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRigidbodyConstraintsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RigidbodyConstraints), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RigidbodyConstraints), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RigidbodyConstraints), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.RigidbodyConstraints.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezePositionX", UnityEngine.RigidbodyConstraints.FreezePositionX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezePositionY", UnityEngine.RigidbodyConstraints.FreezePositionY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezePositionZ", UnityEngine.RigidbodyConstraints.FreezePositionZ);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezeRotationX", UnityEngine.RigidbodyConstraints.FreezeRotationX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezeRotationY", UnityEngine.RigidbodyConstraints.FreezeRotationY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezeRotationZ", UnityEngine.RigidbodyConstraints.FreezeRotationZ);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezePosition", UnityEngine.RigidbodyConstraints.FreezePosition);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezeRotation", UnityEngine.RigidbodyConstraints.FreezeRotation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezeAll", UnityEngine.RigidbodyConstraints.FreezeAll);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RigidbodyConstraints), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRigidbodyConstraints(L, (UnityEngine.RigidbodyConstraints)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezePositionX"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezePositionX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezePositionY"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezePositionY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezePositionZ"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezePositionZ);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezeRotationX"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezeRotationX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezeRotationY"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezeRotationY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezeRotationZ"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezeRotationZ);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezePosition"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezePosition);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezeRotation"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezeRotation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezeAll"))
                {
                    translator.PushUnityEngineRigidbodyConstraints(L, UnityEngine.RigidbodyConstraints.FreezeAll);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RigidbodyConstraints!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RigidbodyConstraints! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineForceModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ForceMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ForceMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ForceMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Force", UnityEngine.ForceMode.Force);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Acceleration", UnityEngine.ForceMode.Acceleration);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Impulse", UnityEngine.ForceMode.Impulse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VelocityChange", UnityEngine.ForceMode.VelocityChange);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ForceMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineForceMode(L, (UnityEngine.ForceMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Force"))
                {
                    translator.PushUnityEngineForceMode(L, UnityEngine.ForceMode.Force);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Acceleration"))
                {
                    translator.PushUnityEngineForceMode(L, UnityEngine.ForceMode.Acceleration);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Impulse"))
                {
                    translator.PushUnityEngineForceMode(L, UnityEngine.ForceMode.Impulse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VelocityChange"))
                {
                    translator.PushUnityEngineForceMode(L, UnityEngine.ForceMode.VelocityChange);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ForceMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ForceMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineJointProjectionModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.JointProjectionMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.JointProjectionMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.JointProjectionMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.JointProjectionMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PositionAndRotation", UnityEngine.JointProjectionMode.PositionAndRotation);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.JointProjectionMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineJointProjectionMode(L, (UnityEngine.JointProjectionMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineJointProjectionMode(L, UnityEngine.JointProjectionMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PositionAndRotation"))
                {
                    translator.PushUnityEngineJointProjectionMode(L, UnityEngine.JointProjectionMode.PositionAndRotation);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.JointProjectionMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.JointProjectionMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineMeshColliderCookingOptionsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.MeshColliderCookingOptions), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.MeshColliderCookingOptions), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.MeshColliderCookingOptions), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.MeshColliderCookingOptions.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CookForFasterSimulation", UnityEngine.MeshColliderCookingOptions.CookForFasterSimulation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnableMeshCleaning", UnityEngine.MeshColliderCookingOptions.EnableMeshCleaning);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WeldColocatedVertices", UnityEngine.MeshColliderCookingOptions.WeldColocatedVertices);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UseFastMidphase", UnityEngine.MeshColliderCookingOptions.UseFastMidphase);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.MeshColliderCookingOptions), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineMeshColliderCookingOptions(L, (UnityEngine.MeshColliderCookingOptions)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineMeshColliderCookingOptions(L, UnityEngine.MeshColliderCookingOptions.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CookForFasterSimulation"))
                {
                    translator.PushUnityEngineMeshColliderCookingOptions(L, UnityEngine.MeshColliderCookingOptions.CookForFasterSimulation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnableMeshCleaning"))
                {
                    translator.PushUnityEngineMeshColliderCookingOptions(L, UnityEngine.MeshColliderCookingOptions.EnableMeshCleaning);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WeldColocatedVertices"))
                {
                    translator.PushUnityEngineMeshColliderCookingOptions(L, UnityEngine.MeshColliderCookingOptions.WeldColocatedVertices);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UseFastMidphase"))
                {
                    translator.PushUnityEngineMeshColliderCookingOptions(L, UnityEngine.MeshColliderCookingOptions.UseFastMidphase);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.MeshColliderCookingOptions!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.MeshColliderCookingOptions! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRigidbodyInterpolationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RigidbodyInterpolation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RigidbodyInterpolation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RigidbodyInterpolation), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.RigidbodyInterpolation.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Interpolate", UnityEngine.RigidbodyInterpolation.Interpolate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Extrapolate", UnityEngine.RigidbodyInterpolation.Extrapolate);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RigidbodyInterpolation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRigidbodyInterpolation(L, (UnityEngine.RigidbodyInterpolation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineRigidbodyInterpolation(L, UnityEngine.RigidbodyInterpolation.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Interpolate"))
                {
                    translator.PushUnityEngineRigidbodyInterpolation(L, UnityEngine.RigidbodyInterpolation.Interpolate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Extrapolate"))
                {
                    translator.PushUnityEngineRigidbodyInterpolation(L, UnityEngine.RigidbodyInterpolation.Extrapolate);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RigidbodyInterpolation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RigidbodyInterpolation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEnginePhysicMaterialCombineWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.PhysicMaterialCombine), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.PhysicMaterialCombine), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.PhysicMaterialCombine), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Average", UnityEngine.PhysicMaterialCombine.Average);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Minimum", UnityEngine.PhysicMaterialCombine.Minimum);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Multiply", UnityEngine.PhysicMaterialCombine.Multiply);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Maximum", UnityEngine.PhysicMaterialCombine.Maximum);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.PhysicMaterialCombine), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEnginePhysicMaterialCombine(L, (UnityEngine.PhysicMaterialCombine)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Average"))
                {
                    translator.PushUnityEnginePhysicMaterialCombine(L, UnityEngine.PhysicMaterialCombine.Average);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Minimum"))
                {
                    translator.PushUnityEnginePhysicMaterialCombine(L, UnityEngine.PhysicMaterialCombine.Minimum);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Multiply"))
                {
                    translator.PushUnityEnginePhysicMaterialCombine(L, UnityEngine.PhysicMaterialCombine.Multiply);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Maximum"))
                {
                    translator.PushUnityEnginePhysicMaterialCombine(L, UnityEngine.PhysicMaterialCombine.Maximum);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.PhysicMaterialCombine!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.PhysicMaterialCombine! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCollisionFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CollisionFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CollisionFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CollisionFlags), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.CollisionFlags.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sides", UnityEngine.CollisionFlags.Sides);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Above", UnityEngine.CollisionFlags.Above);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Below", UnityEngine.CollisionFlags.Below);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CollidedSides", UnityEngine.CollisionFlags.CollidedSides);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CollidedAbove", UnityEngine.CollisionFlags.CollidedAbove);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CollidedBelow", UnityEngine.CollisionFlags.CollidedBelow);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CollisionFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCollisionFlags(L, (UnityEngine.CollisionFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineCollisionFlags(L, UnityEngine.CollisionFlags.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sides"))
                {
                    translator.PushUnityEngineCollisionFlags(L, UnityEngine.CollisionFlags.Sides);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Above"))
                {
                    translator.PushUnityEngineCollisionFlags(L, UnityEngine.CollisionFlags.Above);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Below"))
                {
                    translator.PushUnityEngineCollisionFlags(L, UnityEngine.CollisionFlags.Below);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CollidedSides"))
                {
                    translator.PushUnityEngineCollisionFlags(L, UnityEngine.CollisionFlags.CollidedSides);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CollidedAbove"))
                {
                    translator.PushUnityEngineCollisionFlags(L, UnityEngine.CollisionFlags.CollidedAbove);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CollidedBelow"))
                {
                    translator.PushUnityEngineCollisionFlags(L, UnityEngine.CollisionFlags.CollidedBelow);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CollisionFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CollisionFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineQueryTriggerInteractionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.QueryTriggerInteraction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.QueryTriggerInteraction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.QueryTriggerInteraction), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UseGlobal", UnityEngine.QueryTriggerInteraction.UseGlobal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ignore", UnityEngine.QueryTriggerInteraction.Ignore);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Collide", UnityEngine.QueryTriggerInteraction.Collide);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.QueryTriggerInteraction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineQueryTriggerInteraction(L, (UnityEngine.QueryTriggerInteraction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UseGlobal"))
                {
                    translator.PushUnityEngineQueryTriggerInteraction(L, UnityEngine.QueryTriggerInteraction.UseGlobal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ignore"))
                {
                    translator.PushUnityEngineQueryTriggerInteraction(L, UnityEngine.QueryTriggerInteraction.Ignore);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Collide"))
                {
                    translator.PushUnityEngineQueryTriggerInteraction(L, UnityEngine.QueryTriggerInteraction.Collide);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.QueryTriggerInteraction!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.QueryTriggerInteraction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCollisionDetectionModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CollisionDetectionMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CollisionDetectionMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CollisionDetectionMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Discrete", UnityEngine.CollisionDetectionMode.Discrete);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Continuous", UnityEngine.CollisionDetectionMode.Continuous);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ContinuousDynamic", UnityEngine.CollisionDetectionMode.ContinuousDynamic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ContinuousSpeculative", UnityEngine.CollisionDetectionMode.ContinuousSpeculative);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CollisionDetectionMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCollisionDetectionMode(L, (UnityEngine.CollisionDetectionMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Discrete"))
                {
                    translator.PushUnityEngineCollisionDetectionMode(L, UnityEngine.CollisionDetectionMode.Discrete);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Continuous"))
                {
                    translator.PushUnityEngineCollisionDetectionMode(L, UnityEngine.CollisionDetectionMode.Continuous);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ContinuousDynamic"))
                {
                    translator.PushUnityEngineCollisionDetectionMode(L, UnityEngine.CollisionDetectionMode.ContinuousDynamic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ContinuousSpeculative"))
                {
                    translator.PushUnityEngineCollisionDetectionMode(L, UnityEngine.CollisionDetectionMode.ContinuousSpeculative);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CollisionDetectionMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CollisionDetectionMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRotationDriveModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RotationDriveMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RotationDriveMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RotationDriveMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XYAndZ", UnityEngine.RotationDriveMode.XYAndZ);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Slerp", UnityEngine.RotationDriveMode.Slerp);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RotationDriveMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRotationDriveMode(L, (UnityEngine.RotationDriveMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "XYAndZ"))
                {
                    translator.PushUnityEngineRotationDriveMode(L, UnityEngine.RotationDriveMode.XYAndZ);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Slerp"))
                {
                    translator.PushUnityEngineRotationDriveMode(L, UnityEngine.RotationDriveMode.Slerp);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RotationDriveMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RotationDriveMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCapsuleDirection2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CapsuleDirection2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CapsuleDirection2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CapsuleDirection2D), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.CapsuleDirection2D.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.CapsuleDirection2D.Horizontal);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CapsuleDirection2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCapsuleDirection2D(L, (UnityEngine.CapsuleDirection2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineCapsuleDirection2D(L, UnityEngine.CapsuleDirection2D.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineCapsuleDirection2D(L, UnityEngine.CapsuleDirection2D.Horizontal);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CapsuleDirection2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CapsuleDirection2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRigidbodyConstraints2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RigidbodyConstraints2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RigidbodyConstraints2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RigidbodyConstraints2D), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.RigidbodyConstraints2D.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezePositionX", UnityEngine.RigidbodyConstraints2D.FreezePositionX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezePositionY", UnityEngine.RigidbodyConstraints2D.FreezePositionY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezeRotation", UnityEngine.RigidbodyConstraints2D.FreezeRotation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezePosition", UnityEngine.RigidbodyConstraints2D.FreezePosition);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FreezeAll", UnityEngine.RigidbodyConstraints2D.FreezeAll);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RigidbodyConstraints2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRigidbodyConstraints2D(L, (UnityEngine.RigidbodyConstraints2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineRigidbodyConstraints2D(L, UnityEngine.RigidbodyConstraints2D.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezePositionX"))
                {
                    translator.PushUnityEngineRigidbodyConstraints2D(L, UnityEngine.RigidbodyConstraints2D.FreezePositionX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezePositionY"))
                {
                    translator.PushUnityEngineRigidbodyConstraints2D(L, UnityEngine.RigidbodyConstraints2D.FreezePositionY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezeRotation"))
                {
                    translator.PushUnityEngineRigidbodyConstraints2D(L, UnityEngine.RigidbodyConstraints2D.FreezeRotation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezePosition"))
                {
                    translator.PushUnityEngineRigidbodyConstraints2D(L, UnityEngine.RigidbodyConstraints2D.FreezePosition);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FreezeAll"))
                {
                    translator.PushUnityEngineRigidbodyConstraints2D(L, UnityEngine.RigidbodyConstraints2D.FreezeAll);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RigidbodyConstraints2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RigidbodyConstraints2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRigidbodyInterpolation2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RigidbodyInterpolation2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RigidbodyInterpolation2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RigidbodyInterpolation2D), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.RigidbodyInterpolation2D.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Interpolate", UnityEngine.RigidbodyInterpolation2D.Interpolate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Extrapolate", UnityEngine.RigidbodyInterpolation2D.Extrapolate);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RigidbodyInterpolation2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRigidbodyInterpolation2D(L, (UnityEngine.RigidbodyInterpolation2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineRigidbodyInterpolation2D(L, UnityEngine.RigidbodyInterpolation2D.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Interpolate"))
                {
                    translator.PushUnityEngineRigidbodyInterpolation2D(L, UnityEngine.RigidbodyInterpolation2D.Interpolate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Extrapolate"))
                {
                    translator.PushUnityEngineRigidbodyInterpolation2D(L, UnityEngine.RigidbodyInterpolation2D.Extrapolate);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RigidbodyInterpolation2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RigidbodyInterpolation2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRigidbodySleepMode2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RigidbodySleepMode2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RigidbodySleepMode2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RigidbodySleepMode2D), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NeverSleep", UnityEngine.RigidbodySleepMode2D.NeverSleep);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StartAwake", UnityEngine.RigidbodySleepMode2D.StartAwake);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StartAsleep", UnityEngine.RigidbodySleepMode2D.StartAsleep);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RigidbodySleepMode2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRigidbodySleepMode2D(L, (UnityEngine.RigidbodySleepMode2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "NeverSleep"))
                {
                    translator.PushUnityEngineRigidbodySleepMode2D(L, UnityEngine.RigidbodySleepMode2D.NeverSleep);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "StartAwake"))
                {
                    translator.PushUnityEngineRigidbodySleepMode2D(L, UnityEngine.RigidbodySleepMode2D.StartAwake);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "StartAsleep"))
                {
                    translator.PushUnityEngineRigidbodySleepMode2D(L, UnityEngine.RigidbodySleepMode2D.StartAsleep);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RigidbodySleepMode2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RigidbodySleepMode2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCollisionDetectionMode2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CollisionDetectionMode2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CollisionDetectionMode2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CollisionDetectionMode2D), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Discrete", UnityEngine.CollisionDetectionMode2D.Discrete);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Continuous", UnityEngine.CollisionDetectionMode2D.Continuous);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CollisionDetectionMode2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCollisionDetectionMode2D(L, (UnityEngine.CollisionDetectionMode2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Discrete"))
                {
                    translator.PushUnityEngineCollisionDetectionMode2D(L, UnityEngine.CollisionDetectionMode2D.Discrete);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Continuous"))
                {
                    translator.PushUnityEngineCollisionDetectionMode2D(L, UnityEngine.CollisionDetectionMode2D.Continuous);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CollisionDetectionMode2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CollisionDetectionMode2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRigidbodyType2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RigidbodyType2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RigidbodyType2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RigidbodyType2D), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dynamic", UnityEngine.RigidbodyType2D.Dynamic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Kinematic", UnityEngine.RigidbodyType2D.Kinematic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Static", UnityEngine.RigidbodyType2D.Static);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RigidbodyType2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRigidbodyType2D(L, (UnityEngine.RigidbodyType2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Dynamic"))
                {
                    translator.PushUnityEngineRigidbodyType2D(L, UnityEngine.RigidbodyType2D.Dynamic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Kinematic"))
                {
                    translator.PushUnityEngineRigidbodyType2D(L, UnityEngine.RigidbodyType2D.Kinematic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Static"))
                {
                    translator.PushUnityEngineRigidbodyType2D(L, UnityEngine.RigidbodyType2D.Static);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RigidbodyType2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RigidbodyType2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineForceMode2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ForceMode2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ForceMode2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ForceMode2D), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Force", UnityEngine.ForceMode2D.Force);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Impulse", UnityEngine.ForceMode2D.Impulse);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ForceMode2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineForceMode2D(L, (UnityEngine.ForceMode2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Force"))
                {
                    translator.PushUnityEngineForceMode2D(L, UnityEngine.ForceMode2D.Force);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Impulse"))
                {
                    translator.PushUnityEngineForceMode2D(L, UnityEngine.ForceMode2D.Impulse);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ForceMode2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ForceMode2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineJointLimitState2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.JointLimitState2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.JointLimitState2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.JointLimitState2D), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Inactive", UnityEngine.JointLimitState2D.Inactive);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerLimit", UnityEngine.JointLimitState2D.LowerLimit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLimit", UnityEngine.JointLimitState2D.UpperLimit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EqualLimits", UnityEngine.JointLimitState2D.EqualLimits);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.JointLimitState2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineJointLimitState2D(L, (UnityEngine.JointLimitState2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Inactive"))
                {
                    translator.PushUnityEngineJointLimitState2D(L, UnityEngine.JointLimitState2D.Inactive);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerLimit"))
                {
                    translator.PushUnityEngineJointLimitState2D(L, UnityEngine.JointLimitState2D.LowerLimit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLimit"))
                {
                    translator.PushUnityEngineJointLimitState2D(L, UnityEngine.JointLimitState2D.UpperLimit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EqualLimits"))
                {
                    translator.PushUnityEngineJointLimitState2D(L, UnityEngine.JointLimitState2D.EqualLimits);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.JointLimitState2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.JointLimitState2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEffectorSelection2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EffectorSelection2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EffectorSelection2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EffectorSelection2D), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rigidbody", UnityEngine.EffectorSelection2D.Rigidbody);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Collider", UnityEngine.EffectorSelection2D.Collider);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EffectorSelection2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEffectorSelection2D(L, (UnityEngine.EffectorSelection2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Rigidbody"))
                {
                    translator.PushUnityEngineEffectorSelection2D(L, UnityEngine.EffectorSelection2D.Rigidbody);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Collider"))
                {
                    translator.PushUnityEngineEffectorSelection2D(L, UnityEngine.EffectorSelection2D.Collider);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EffectorSelection2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EffectorSelection2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEffectorForceMode2DWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EffectorForceMode2D), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EffectorForceMode2D), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EffectorForceMode2D), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Constant", UnityEngine.EffectorForceMode2D.Constant);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InverseLinear", UnityEngine.EffectorForceMode2D.InverseLinear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InverseSquared", UnityEngine.EffectorForceMode2D.InverseSquared);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EffectorForceMode2D), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEffectorForceMode2D(L, (UnityEngine.EffectorForceMode2D)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Constant"))
                {
                    translator.PushUnityEngineEffectorForceMode2D(L, UnityEngine.EffectorForceMode2D.Constant);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InverseLinear"))
                {
                    translator.PushUnityEngineEffectorForceMode2D(L, UnityEngine.EffectorForceMode2D.InverseLinear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InverseSquared"))
                {
                    translator.PushUnityEngineEffectorForceMode2D(L, UnityEngine.EffectorForceMode2D.InverseSquared);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EffectorForceMode2D!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EffectorForceMode2D! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCompositeCollider2DGeometryTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CompositeCollider2D.GeometryType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CompositeCollider2D.GeometryType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CompositeCollider2D.GeometryType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Outlines", UnityEngine.CompositeCollider2D.GeometryType.Outlines);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Polygons", UnityEngine.CompositeCollider2D.GeometryType.Polygons);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CompositeCollider2D.GeometryType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCompositeCollider2DGeometryType(L, (UnityEngine.CompositeCollider2D.GeometryType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Outlines"))
                {
                    translator.PushUnityEngineCompositeCollider2DGeometryType(L, UnityEngine.CompositeCollider2D.GeometryType.Outlines);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Polygons"))
                {
                    translator.PushUnityEngineCompositeCollider2DGeometryType(L, UnityEngine.CompositeCollider2D.GeometryType.Polygons);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CompositeCollider2D.GeometryType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CompositeCollider2D.GeometryType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCompositeCollider2DGenerationTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CompositeCollider2D.GenerationType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CompositeCollider2D.GenerationType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CompositeCollider2D.GenerationType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Synchronous", UnityEngine.CompositeCollider2D.GenerationType.Synchronous);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Manual", UnityEngine.CompositeCollider2D.GenerationType.Manual);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CompositeCollider2D.GenerationType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCompositeCollider2DGenerationType(L, (UnityEngine.CompositeCollider2D.GenerationType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Synchronous"))
                {
                    translator.PushUnityEngineCompositeCollider2DGenerationType(L, UnityEngine.CompositeCollider2D.GenerationType.Synchronous);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Manual"))
                {
                    translator.PushUnityEngineCompositeCollider2DGenerationType(L, UnityEngine.CompositeCollider2D.GenerationType.Manual);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CompositeCollider2D.GenerationType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CompositeCollider2D.GenerationType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineScreenCaptureStereoScreenCaptureModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftEye", UnityEngine.ScreenCapture.StereoScreenCaptureMode.LeftEye);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightEye", UnityEngine.ScreenCapture.StereoScreenCaptureMode.RightEye);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BothEyes", UnityEngine.ScreenCapture.StereoScreenCaptureMode.BothEyes);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineScreenCaptureStereoScreenCaptureMode(L, (UnityEngine.ScreenCapture.StereoScreenCaptureMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftEye"))
                {
                    translator.PushUnityEngineScreenCaptureStereoScreenCaptureMode(L, UnityEngine.ScreenCapture.StereoScreenCaptureMode.LeftEye);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightEye"))
                {
                    translator.PushUnityEngineScreenCaptureStereoScreenCaptureMode(L, UnityEngine.ScreenCapture.StereoScreenCaptureMode.RightEye);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BothEyes"))
                {
                    translator.PushUnityEngineScreenCaptureStereoScreenCaptureMode(L, UnityEngine.ScreenCapture.StereoScreenCaptureMode.BothEyes);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.ScreenCapture.StereoScreenCaptureMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.ScreenCapture.StereoScreenCaptureMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTextAnchorWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TextAnchor), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TextAnchor), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TextAnchor), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLeft", UnityEngine.TextAnchor.UpperLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperCenter", UnityEngine.TextAnchor.UpperCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperRight", UnityEngine.TextAnchor.UpperRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleLeft", UnityEngine.TextAnchor.MiddleLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleCenter", UnityEngine.TextAnchor.MiddleCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleRight", UnityEngine.TextAnchor.MiddleRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerLeft", UnityEngine.TextAnchor.LowerLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerCenter", UnityEngine.TextAnchor.LowerCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerRight", UnityEngine.TextAnchor.LowerRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TextAnchor), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTextAnchor(L, (UnityEngine.TextAnchor)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TextAnchor!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TextAnchor! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineHorizontalWrapModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.HorizontalWrapMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.HorizontalWrapMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.HorizontalWrapMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Wrap", UnityEngine.HorizontalWrapMode.Wrap);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Overflow", UnityEngine.HorizontalWrapMode.Overflow);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.HorizontalWrapMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineHorizontalWrapMode(L, (UnityEngine.HorizontalWrapMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Wrap"))
                {
                    translator.PushUnityEngineHorizontalWrapMode(L, UnityEngine.HorizontalWrapMode.Wrap);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Overflow"))
                {
                    translator.PushUnityEngineHorizontalWrapMode(L, UnityEngine.HorizontalWrapMode.Overflow);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.HorizontalWrapMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.HorizontalWrapMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineVerticalWrapModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.VerticalWrapMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.VerticalWrapMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.VerticalWrapMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Truncate", UnityEngine.VerticalWrapMode.Truncate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Overflow", UnityEngine.VerticalWrapMode.Overflow);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.VerticalWrapMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineVerticalWrapMode(L, (UnityEngine.VerticalWrapMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Truncate"))
                {
                    translator.PushUnityEngineVerticalWrapMode(L, UnityEngine.VerticalWrapMode.Truncate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Overflow"))
                {
                    translator.PushUnityEngineVerticalWrapMode(L, UnityEngine.VerticalWrapMode.Overflow);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.VerticalWrapMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.VerticalWrapMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineGridBrushBaseToolWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.GridBrushBase.Tool), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.GridBrushBase.Tool), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.GridBrushBase.Tool), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Select", UnityEngine.GridBrushBase.Tool.Select);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Move", UnityEngine.GridBrushBase.Tool.Move);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Paint", UnityEngine.GridBrushBase.Tool.Paint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Box", UnityEngine.GridBrushBase.Tool.Box);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pick", UnityEngine.GridBrushBase.Tool.Pick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Erase", UnityEngine.GridBrushBase.Tool.Erase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FloodFill", UnityEngine.GridBrushBase.Tool.FloodFill);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.GridBrushBase.Tool), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineGridBrushBaseTool(L, (UnityEngine.GridBrushBase.Tool)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Select"))
                {
                    translator.PushUnityEngineGridBrushBaseTool(L, UnityEngine.GridBrushBase.Tool.Select);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Move"))
                {
                    translator.PushUnityEngineGridBrushBaseTool(L, UnityEngine.GridBrushBase.Tool.Move);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Paint"))
                {
                    translator.PushUnityEngineGridBrushBaseTool(L, UnityEngine.GridBrushBase.Tool.Paint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Box"))
                {
                    translator.PushUnityEngineGridBrushBaseTool(L, UnityEngine.GridBrushBase.Tool.Box);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pick"))
                {
                    translator.PushUnityEngineGridBrushBaseTool(L, UnityEngine.GridBrushBase.Tool.Pick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Erase"))
                {
                    translator.PushUnityEngineGridBrushBaseTool(L, UnityEngine.GridBrushBase.Tool.Erase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FloodFill"))
                {
                    translator.PushUnityEngineGridBrushBaseTool(L, UnityEngine.GridBrushBase.Tool.FloodFill);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.GridBrushBase.Tool!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.GridBrushBase.Tool! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineGridBrushBaseRotationDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.GridBrushBase.RotationDirection), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.GridBrushBase.RotationDirection), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.GridBrushBase.RotationDirection), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clockwise", UnityEngine.GridBrushBase.RotationDirection.Clockwise);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CounterClockwise", UnityEngine.GridBrushBase.RotationDirection.CounterClockwise);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.GridBrushBase.RotationDirection), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineGridBrushBaseRotationDirection(L, (UnityEngine.GridBrushBase.RotationDirection)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Clockwise"))
                {
                    translator.PushUnityEngineGridBrushBaseRotationDirection(L, UnityEngine.GridBrushBase.RotationDirection.Clockwise);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CounterClockwise"))
                {
                    translator.PushUnityEngineGridBrushBaseRotationDirection(L, UnityEngine.GridBrushBase.RotationDirection.CounterClockwise);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.GridBrushBase.RotationDirection!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.GridBrushBase.RotationDirection! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineGridBrushBaseFlipAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.GridBrushBase.FlipAxis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.GridBrushBase.FlipAxis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.GridBrushBase.FlipAxis), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "X", UnityEngine.GridBrushBase.FlipAxis.X);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Y", UnityEngine.GridBrushBase.FlipAxis.Y);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.GridBrushBase.FlipAxis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineGridBrushBaseFlipAxis(L, (UnityEngine.GridBrushBase.FlipAxis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "X"))
                {
                    translator.PushUnityEngineGridBrushBaseFlipAxis(L, UnityEngine.GridBrushBase.FlipAxis.X);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Y"))
                {
                    translator.PushUnityEngineGridBrushBaseFlipAxis(L, UnityEngine.GridBrushBase.FlipAxis.Y);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.GridBrushBase.FlipAxis!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.GridBrushBase.FlipAxis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRenderModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RenderMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RenderMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RenderMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScreenSpaceOverlay", UnityEngine.RenderMode.ScreenSpaceOverlay);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScreenSpaceCamera", UnityEngine.RenderMode.ScreenSpaceCamera);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WorldSpace", UnityEngine.RenderMode.WorldSpace);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RenderMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRenderMode(L, (UnityEngine.RenderMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ScreenSpaceOverlay"))
                {
                    translator.PushUnityEngineRenderMode(L, UnityEngine.RenderMode.ScreenSpaceOverlay);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScreenSpaceCamera"))
                {
                    translator.PushUnityEngineRenderMode(L, UnityEngine.RenderMode.ScreenSpaceCamera);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WorldSpace"))
                {
                    translator.PushUnityEngineRenderMode(L, UnityEngine.RenderMode.WorldSpace);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RenderMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RenderMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineAdditionalCanvasShaderChannelsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.AdditionalCanvasShaderChannels), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.AdditionalCanvasShaderChannels), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.AdditionalCanvasShaderChannels), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.AdditionalCanvasShaderChannels.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TexCoord1", UnityEngine.AdditionalCanvasShaderChannels.TexCoord1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TexCoord2", UnityEngine.AdditionalCanvasShaderChannels.TexCoord2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TexCoord3", UnityEngine.AdditionalCanvasShaderChannels.TexCoord3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", UnityEngine.AdditionalCanvasShaderChannels.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tangent", UnityEngine.AdditionalCanvasShaderChannels.Tangent);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.AdditionalCanvasShaderChannels), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineAdditionalCanvasShaderChannels(L, (UnityEngine.AdditionalCanvasShaderChannels)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineAdditionalCanvasShaderChannels(L, UnityEngine.AdditionalCanvasShaderChannels.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TexCoord1"))
                {
                    translator.PushUnityEngineAdditionalCanvasShaderChannels(L, UnityEngine.AdditionalCanvasShaderChannels.TexCoord1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TexCoord2"))
                {
                    translator.PushUnityEngineAdditionalCanvasShaderChannels(L, UnityEngine.AdditionalCanvasShaderChannels.TexCoord2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TexCoord3"))
                {
                    translator.PushUnityEngineAdditionalCanvasShaderChannels(L, UnityEngine.AdditionalCanvasShaderChannels.TexCoord3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushUnityEngineAdditionalCanvasShaderChannels(L, UnityEngine.AdditionalCanvasShaderChannels.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tangent"))
                {
                    translator.PushUnityEngineAdditionalCanvasShaderChannels(L, UnityEngine.AdditionalCanvasShaderChannels.Tangent);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.AdditionalCanvasShaderChannels!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.AdditionalCanvasShaderChannels! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUISystemProfilerApiSampleTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UISystemProfilerApi.SampleType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UISystemProfilerApi.SampleType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UISystemProfilerApi.SampleType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Layout", UnityEngine.UISystemProfilerApi.SampleType.Layout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Render", UnityEngine.UISystemProfilerApi.SampleType.Render);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UISystemProfilerApi.SampleType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUISystemProfilerApiSampleType(L, (UnityEngine.UISystemProfilerApi.SampleType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Layout"))
                {
                    translator.PushUnityEngineUISystemProfilerApiSampleType(L, UnityEngine.UISystemProfilerApi.SampleType.Layout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Render"))
                {
                    translator.PushUnityEngineUISystemProfilerApiSampleType(L, UnityEngine.UISystemProfilerApi.SampleType.Render);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UISystemProfilerApi.SampleType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UISystemProfilerApi.SampleType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineWindZoneModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.WindZoneMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.WindZoneMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.WindZoneMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Directional", UnityEngine.WindZoneMode.Directional);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Spherical", UnityEngine.WindZoneMode.Spherical);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.WindZoneMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineWindZoneMode(L, (UnityEngine.WindZoneMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Directional"))
                {
                    translator.PushUnityEngineWindZoneMode(L, UnityEngine.WindZoneMode.Directional);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Spherical"))
                {
                    translator.PushUnityEngineWindZoneMode(L, UnityEngine.WindZoneMode.Spherical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.WindZoneMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.WindZoneMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasUpdateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasUpdate), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Prelayout", UnityEngine.UI.CanvasUpdate.Prelayout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Layout", UnityEngine.UI.CanvasUpdate.Layout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PostLayout", UnityEngine.UI.CanvasUpdate.PostLayout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreRender", UnityEngine.UI.CanvasUpdate.PreRender);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LatePreRender", UnityEngine.UI.CanvasUpdate.LatePreRender);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxUpdateValue", UnityEngine.UI.CanvasUpdate.MaxUpdateValue);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasUpdate(L, (UnityEngine.UI.CanvasUpdate)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Prelayout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.Prelayout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Layout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.Layout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PostLayout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.PostLayout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreRender"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.PreRender);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LatePreRender"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.LatePreRender);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxUpdateValue"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.MaxUpdateValue);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasUpdate!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasUpdate! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Type), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Type), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Type), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Simple", UnityEngine.UI.Image.Type.Simple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sliced", UnityEngine.UI.Image.Type.Sliced);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tiled", UnityEngine.UI.Image.Type.Tiled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Filled", UnityEngine.UI.Image.Type.Filled);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Type), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageType(L, (UnityEngine.UI.Image.Type)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Simple"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Simple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sliced"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Sliced);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tiled"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Tiled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Filled"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Filled);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Type!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Type! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageFillMethodWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.FillMethod), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.Image.FillMethod.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.Image.FillMethod.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial90", UnityEngine.UI.Image.FillMethod.Radial90);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial180", UnityEngine.UI.Image.FillMethod.Radial180);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial360", UnityEngine.UI.Image.FillMethod.Radial360);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageFillMethod(L, (UnityEngine.UI.Image.FillMethod)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial90"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial90);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial180"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial180);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial360"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial360);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.FillMethod!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.FillMethod! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOriginHorizontalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.OriginHorizontal.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.OriginHorizontal.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOriginHorizontal(L, (UnityEngine.UI.Image.OriginHorizontal)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOriginHorizontal(L, UnityEngine.UI.Image.OriginHorizontal.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOriginHorizontal(L, UnityEngine.UI.Image.OriginHorizontal.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.OriginHorizontal!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.OriginHorizontal! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOriginVerticalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.OriginVertical.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.OriginVertical.Top);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOriginVertical(L, (UnityEngine.UI.Image.OriginVertical)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOriginVertical(L, UnityEngine.UI.Image.OriginVertical.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOriginVertical(L, UnityEngine.UI.Image.OriginVertical.Top);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.OriginVertical!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.OriginVertical! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin90Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin90), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomLeft", UnityEngine.UI.Image.Origin90.BottomLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLeft", UnityEngine.UI.Image.Origin90.TopLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopRight", UnityEngine.UI.Image.Origin90.TopRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomRight", UnityEngine.UI.Image.Origin90.BottomRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin90(L, (UnityEngine.UI.Image.Origin90)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "BottomLeft"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.BottomLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopLeft"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.TopLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopRight"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.TopRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomRight"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.BottomRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin90!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin90! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin180Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin180), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.Origin180.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.Origin180.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.Origin180.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.Origin180.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin180(L, (UnityEngine.UI.Image.Origin180)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin180!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin180! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin360Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin360), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.Origin360.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.Origin360.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.Origin360.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.Origin360.Left);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin360(L, (UnityEngine.UI.Image.Origin360)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Left);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin360!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin360! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldContentTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.ContentType), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Standard", UnityEngine.UI.InputField.ContentType.Standard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Autocorrected", UnityEngine.UI.InputField.ContentType.Autocorrected);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IntegerNumber", UnityEngine.UI.InputField.ContentType.IntegerNumber);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecimalNumber", UnityEngine.UI.InputField.ContentType.DecimalNumber);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alphanumeric", UnityEngine.UI.InputField.ContentType.Alphanumeric);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", UnityEngine.UI.InputField.ContentType.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.UI.InputField.ContentType.EmailAddress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Password", UnityEngine.UI.InputField.ContentType.Password);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pin", UnityEngine.UI.InputField.ContentType.Pin);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", UnityEngine.UI.InputField.ContentType.Custom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldContentType(L, (UnityEngine.UI.InputField.ContentType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Standard"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Standard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Autocorrected"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Autocorrected);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IntegerNumber"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.IntegerNumber);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DecimalNumber"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.DecimalNumber);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alphanumeric"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Alphanumeric);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.EmailAddress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Password"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Password);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pin"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Pin);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.ContentType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.ContentType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldInputTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.InputType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Standard", UnityEngine.UI.InputField.InputType.Standard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoCorrect", UnityEngine.UI.InputField.InputType.AutoCorrect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Password", UnityEngine.UI.InputField.InputType.Password);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldInputType(L, (UnityEngine.UI.InputField.InputType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Standard"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.Standard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoCorrect"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.AutoCorrect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Password"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.Password);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.InputType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.InputType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldCharacterValidationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.InputField.CharacterValidation.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Integer", UnityEngine.UI.InputField.CharacterValidation.Integer);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Decimal", UnityEngine.UI.InputField.CharacterValidation.Decimal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alphanumeric", UnityEngine.UI.InputField.CharacterValidation.Alphanumeric);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", UnityEngine.UI.InputField.CharacterValidation.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.UI.InputField.CharacterValidation.EmailAddress);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldCharacterValidation(L, (UnityEngine.UI.InputField.CharacterValidation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Integer"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Integer);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Decimal"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Decimal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alphanumeric"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Alphanumeric);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.EmailAddress);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.CharacterValidation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.CharacterValidation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldLineTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.LineType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SingleLine", UnityEngine.UI.InputField.LineType.SingleLine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MultiLineSubmit", UnityEngine.UI.InputField.LineType.MultiLineSubmit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MultiLineNewline", UnityEngine.UI.InputField.LineType.MultiLineNewline);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldLineType(L, (UnityEngine.UI.InputField.LineType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "SingleLine"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.SingleLine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MultiLineSubmit"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.MultiLineSubmit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MultiLineNewline"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.MultiLineNewline);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.LineType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.LineType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIAspectRatioFitterAspectModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.AspectRatioFitter.AspectMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WidthControlsHeight", UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HeightControlsWidth", UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitInParent", UnityEngine.UI.AspectRatioFitter.AspectMode.FitInParent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnvelopeParent", UnityEngine.UI.AspectRatioFitter.AspectMode.EnvelopeParent);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, (UnityEngine.UI.AspectRatioFitter.AspectMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WidthControlsHeight"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HeightControlsWidth"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitInParent"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.FitInParent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnvelopeParent"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.EnvelopeParent);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.AspectRatioFitter.AspectMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.AspectRatioFitter.AspectMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPixelSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleWithScreenSize", UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPhysicalSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScaleMode(L, (UnityEngine.UI.CanvasScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScaleMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScreenMatchModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidthOrHeight", UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Expand", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shrink", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, (UnityEngine.UI.CanvasScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Expand"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScreenMatchMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerUnitWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Centimeters", UnityEngine.UI.CanvasScaler.Unit.Centimeters);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Millimeters", UnityEngine.UI.CanvasScaler.Unit.Millimeters);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Inches", UnityEngine.UI.CanvasScaler.Unit.Inches);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Points", UnityEngine.UI.CanvasScaler.Unit.Points);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Picas", UnityEngine.UI.CanvasScaler.Unit.Picas);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerUnit(L, (UnityEngine.UI.CanvasScaler.Unit)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Centimeters"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Centimeters);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Millimeters"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Millimeters);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Inches"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Inches);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Points"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Points);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Picas"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Picas);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.Unit!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.Unit! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIContentSizeFitterFitModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unconstrained", UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MinSize", UnityEngine.UI.ContentSizeFitter.FitMode.MinSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreferredSize", UnityEngine.UI.ContentSizeFitter.FitMode.PreferredSize);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIContentSizeFitterFitMode(L, (UnityEngine.UI.ContentSizeFitter.FitMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unconstrained"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MinSize"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.MinSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreferredSize"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.PreferredSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ContentSizeFitter.FitMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ContentSizeFitter.FitMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupCornerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLeft", UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperRight", UnityEngine.UI.GridLayoutGroup.Corner.UpperRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerLeft", UnityEngine.UI.GridLayoutGroup.Corner.LowerLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerRight", UnityEngine.UI.GridLayoutGroup.Corner.LowerRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupCorner(L, (UnityEngine.UI.GridLayoutGroup.Corner)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLeft"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperRight"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.UpperRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerLeft"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.LowerLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerRight"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.LowerRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Corner!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Corner! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.GridLayoutGroup.Axis.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.GridLayoutGroup.Axis.Vertical);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupAxis(L, (UnityEngine.UI.GridLayoutGroup.Axis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupAxis(L, UnityEngine.UI.GridLayoutGroup.Axis.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupAxis(L, UnityEngine.UI.GridLayoutGroup.Axis.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Axis!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Axis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupConstraintWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Flexible", UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedColumnCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedRowCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupConstraint(L, (UnityEngine.UI.GridLayoutGroup.Constraint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Flexible"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedColumnCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedRowCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Constraint!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Constraint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUINavigationModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Navigation.Mode), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Navigation.Mode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.Navigation.Mode.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.Navigation.Mode.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Automatic", UnityEngine.UI.Navigation.Mode.Automatic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Explicit", UnityEngine.UI.Navigation.Mode.Explicit);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUINavigationMode(L, (UnityEngine.UI.Navigation.Mode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Automatic"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Automatic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Explicit"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Explicit);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Navigation.Mode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Navigation.Mode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollRectMovementTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unrestricted", UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Elastic", UnityEngine.UI.ScrollRect.MovementType.Elastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clamped", UnityEngine.UI.ScrollRect.MovementType.Clamped);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollRectMovementType(L, (UnityEngine.UI.ScrollRect.MovementType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unrestricted"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Elastic"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Elastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Clamped"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Clamped);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ScrollRect.MovementType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ScrollRect.MovementType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollRectScrollbarVisibilityWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Permanent", UnityEngine.UI.ScrollRect.ScrollbarVisibility.Permanent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoHide", UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHide);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoHideAndExpandViewport", UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, (UnityEngine.UI.ScrollRect.ScrollbarVisibility)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Permanent"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.Permanent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoHide"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHide);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoHideAndExpandViewport"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ScrollRect.ScrollbarVisibility!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ScrollRect.ScrollbarVisibility! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollbarDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftToRight", UnityEngine.UI.Scrollbar.Direction.LeftToRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightToLeft", UnityEngine.UI.Scrollbar.Direction.RightToLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomToTop", UnityEngine.UI.Scrollbar.Direction.BottomToTop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopToBottom", UnityEngine.UI.Scrollbar.Direction.TopToBottom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollbarDirection(L, (UnityEngine.UI.Scrollbar.Direction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftToRight"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.LeftToRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightToLeft"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.RightToLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomToTop"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.BottomToTop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopToBottom"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.TopToBottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Scrollbar.Direction!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Scrollbar.Direction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUISelectableTransitionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Selectable.Transition), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Selectable.Transition.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ColorTint", UnityEngine.UI.Selectable.Transition.ColorTint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpriteSwap", UnityEngine.UI.Selectable.Transition.SpriteSwap);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Animation", UnityEngine.UI.Selectable.Transition.Animation);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUISelectableTransition(L, (UnityEngine.UI.Selectable.Transition)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ColorTint"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.ColorTint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpriteSwap"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.SpriteSwap);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Animation"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.Animation);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Selectable.Transition!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Selectable.Transition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUISliderDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Slider.Direction), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftToRight", UnityEngine.UI.Slider.Direction.LeftToRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightToLeft", UnityEngine.UI.Slider.Direction.RightToLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomToTop", UnityEngine.UI.Slider.Direction.BottomToTop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopToBottom", UnityEngine.UI.Slider.Direction.TopToBottom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUISliderDirection(L, (UnityEngine.UI.Slider.Direction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftToRight"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.LeftToRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightToLeft"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.RightToLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomToTop"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.BottomToTop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopToBottom"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.TopToBottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Slider.Direction!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Slider.Direction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIToggleToggleTransitionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Toggle.ToggleTransition.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fade", UnityEngine.UI.Toggle.ToggleTransition.Fade);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIToggleToggleTransition(L, (UnityEngine.UI.Toggle.ToggleTransition)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIToggleToggleTransition(L, UnityEngine.UI.Toggle.ToggleTransition.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fade"))
                {
                    translator.PushUnityEngineUIToggleToggleTransition(L, UnityEngine.UI.Toggle.ToggleTransition.Fade);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Toggle.ToggleTransition!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Toggle.ToggleTransition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XDebugOrientWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XDebug.Orient), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XDebug.Orient), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XDebug.Orient), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizonal", XDebug.Orient.Horizonal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", XDebug.Orient.Vertical);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XDebug.Orient), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXDebugOrient(L, (XDebug.Orient)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizonal"))
                {
                    translator.PushXDebugOrient(L, XDebug.Orient.Horizonal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushXDebugOrient(L, XDebug.Orient.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XDebug.Orient!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XDebug.Orient! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XDebugLocationAlignWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XDebug.Location.Align), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XDebug.Location.Align), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XDebug.Location.Align), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLeft", XDebug.Location.Align.TopLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopRight", XDebug.Location.Align.TopRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopCenter", XDebug.Location.Align.TopCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomLeft", XDebug.Location.Align.BottomLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomRight", XDebug.Location.Align.BottomRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomCenter", XDebug.Location.Align.BottomCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Center", XDebug.Location.Align.Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CenterLeft", XDebug.Location.Align.CenterLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CenterRight", XDebug.Location.Align.CenterRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XDebug.Location.Align), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXDebugLocationAlign(L, (XDebug.Location.Align)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "TopLeft"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.TopLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopRight"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.TopRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopCenter"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.TopCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomLeft"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.BottomLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomRight"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.BottomRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomCenter"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.BottomCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Center"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CenterLeft"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.CenterLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CenterRight"))
                {
                    translator.PushXDebugLocationAlign(L, XDebug.Location.Align.CenterRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XDebug.Location.Align!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XDebug.Location.Align! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XDebugModuleTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XDebug.Module.Type), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XDebug.Module.Type), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XDebug.Module.Type), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", XDebug.Module.Type.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Chart", XDebug.Module.Type.Chart);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XDebug.Module.Type), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXDebugModuleType(L, (XDebug.Module.Type)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushXDebugModuleType(L, XDebug.Module.Type.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Chart"))
                {
                    translator.PushXDebugModuleType(L, XDebug.Module.Type.Chart);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XDebug.Module.Type!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XDebug.Module.Type! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XDebugXLogLogLevelWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XDebug.XLog.LogLevel), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XDebug.XLog.LogLevel), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XDebug.XLog.LogLevel), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", XDebug.XLog.LogLevel.All);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Debug", XDebug.XLog.LogLevel.Debug);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Warn", XDebug.XLog.LogLevel.Warn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Info", XDebug.XLog.LogLevel.Info);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Proto", XDebug.XLog.LogLevel.Proto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vital", XDebug.XLog.LogLevel.Vital);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Error", XDebug.XLog.LogLevel.Error);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XDebug.XLog.LogLevel), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXDebugXLogLogLevel(L, (XDebug.XLog.LogLevel)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushXDebugXLogLogLevel(L, XDebug.XLog.LogLevel.All);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Debug"))
                {
                    translator.PushXDebugXLogLogLevel(L, XDebug.XLog.LogLevel.Debug);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Warn"))
                {
                    translator.PushXDebugXLogLogLevel(L, XDebug.XLog.LogLevel.Warn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Info"))
                {
                    translator.PushXDebugXLogLogLevel(L, XDebug.XLog.LogLevel.Info);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Proto"))
                {
                    translator.PushXDebugXLogLogLevel(L, XDebug.XLog.LogLevel.Proto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vital"))
                {
                    translator.PushXDebugXLogLogLevel(L, XDebug.XLog.LogLevel.Vital);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Error"))
                {
                    translator.PushXDebugXLogLogLevel(L, XDebug.XLog.LogLevel.Error);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XDebug.XLog.LogLevel!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XDebug.XLog.LogLevel! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}