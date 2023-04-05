#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;


namespace XLua
{
    public partial class ObjectTranslator
    {
        
        class IniterAdderUnityEngineVector2
        {
            static IniterAdderUnityEngineVector2()
            {
                LuaEnv.AddIniter(Init);
            }
			
			static void Init(LuaEnv luaenv, ObjectTranslator translator)
			{
			
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector2>(translator.PushUnityEngineVector2, translator.Get, translator.UpdateUnityEngineVector2);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector3>(translator.PushUnityEngineVector3, translator.Get, translator.UpdateUnityEngineVector3);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector4>(translator.PushUnityEngineVector4, translator.Get, translator.UpdateUnityEngineVector4);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Color>(translator.PushUnityEngineColor, translator.Get, translator.UpdateUnityEngineColor);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Quaternion>(translator.PushUnityEngineQuaternion, translator.Get, translator.UpdateUnityEngineQuaternion);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Ray>(translator.PushUnityEngineRay, translator.Get, translator.UpdateUnityEngineRay);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Bounds>(translator.PushUnityEngineBounds, translator.Get, translator.UpdateUnityEngineBounds);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Ray2D>(translator.PushUnityEngineRay2D, translator.Get, translator.UpdateUnityEngineRay2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AvatarTarget>(translator.PushUnityEngineAvatarTarget, translator.Get, translator.UpdateUnityEngineAvatarTarget);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AvatarIKGoal>(translator.PushUnityEngineAvatarIKGoal, translator.Get, translator.UpdateUnityEngineAvatarIKGoal);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AvatarIKHint>(translator.PushUnityEngineAvatarIKHint, translator.Get, translator.UpdateUnityEngineAvatarIKHint);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnimatorControllerParameterType>(translator.PushUnityEngineAnimatorControllerParameterType, translator.Get, translator.UpdateUnityEngineAnimatorControllerParameterType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnimatorRecorderMode>(translator.PushUnityEngineAnimatorRecorderMode, translator.Get, translator.UpdateUnityEngineAnimatorRecorderMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.DurationUnit>(translator.PushUnityEngineDurationUnit, translator.Get, translator.UpdateUnityEngineDurationUnit);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnimatorCullingMode>(translator.PushUnityEngineAnimatorCullingMode, translator.Get, translator.UpdateUnityEngineAnimatorCullingMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnimatorUpdateMode>(translator.PushUnityEngineAnimatorUpdateMode, translator.Get, translator.UpdateUnityEngineAnimatorUpdateMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.BodyDof>(translator.PushUnityEngineBodyDof, translator.Get, translator.UpdateUnityEngineBodyDof);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.HeadDof>(translator.PushUnityEngineHeadDof, translator.Get, translator.UpdateUnityEngineHeadDof);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.LegDof>(translator.PushUnityEngineLegDof, translator.Get, translator.UpdateUnityEngineLegDof);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ArmDof>(translator.PushUnityEngineArmDof, translator.Get, translator.UpdateUnityEngineArmDof);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.FingerDof>(translator.PushUnityEngineFingerDof, translator.Get, translator.UpdateUnityEngineFingerDof);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.HumanPartDof>(translator.PushUnityEngineHumanPartDof, translator.Get, translator.UpdateUnityEngineHumanPartDof);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.HumanBodyBones>(translator.PushUnityEngineHumanBodyBones, translator.Get, translator.UpdateUnityEngineHumanBodyBones);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AvatarMaskBodyPart>(translator.PushUnityEngineAvatarMaskBodyPart, translator.Get, translator.UpdateUnityEngineAvatarMaskBodyPart);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.PlayMode>(translator.PushUnityEnginePlayMode, translator.Get, translator.UpdateUnityEnginePlayMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.QueueMode>(translator.PushUnityEngineQueueMode, translator.Get, translator.UpdateUnityEngineQueueMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnimationBlendMode>(translator.PushUnityEngineAnimationBlendMode, translator.Get, translator.UpdateUnityEngineAnimationBlendMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnimationPlayMode>(translator.PushUnityEngineAnimationPlayMode, translator.Get, translator.UpdateUnityEngineAnimationPlayMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnimationCullingType>(translator.PushUnityEngineAnimationCullingType, translator.Get, translator.UpdateUnityEngineAnimationCullingType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AssetBundleLoadResult>(translator.PushUnityEngineAssetBundleLoadResult, translator.Get, translator.UpdateUnityEngineAssetBundleLoadResult);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CompressionType>(translator.PushUnityEngineCompressionType, translator.Get, translator.UpdateUnityEngineCompressionType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CompressionLevel>(translator.PushUnityEngineCompressionLevel, translator.Get, translator.UpdateUnityEngineCompressionLevel);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioSpeakerMode>(translator.PushUnityEngineAudioSpeakerMode, translator.Get, translator.UpdateUnityEngineAudioSpeakerMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioDataLoadState>(translator.PushUnityEngineAudioDataLoadState, translator.Get, translator.UpdateUnityEngineAudioDataLoadState);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioCompressionFormat>(translator.PushUnityEngineAudioCompressionFormat, translator.Get, translator.UpdateUnityEngineAudioCompressionFormat);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioClipLoadType>(translator.PushUnityEngineAudioClipLoadType, translator.Get, translator.UpdateUnityEngineAudioClipLoadType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioVelocityUpdateMode>(translator.PushUnityEngineAudioVelocityUpdateMode, translator.Get, translator.UpdateUnityEngineAudioVelocityUpdateMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioRolloffMode>(translator.PushUnityEngineAudioRolloffMode, translator.Get, translator.UpdateUnityEngineAudioRolloffMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioSourceCurveType>(translator.PushUnityEngineAudioSourceCurveType, translator.Get, translator.UpdateUnityEngineAudioSourceCurveType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioReverbPreset>(translator.PushUnityEngineAudioReverbPreset, translator.Get, translator.UpdateUnityEngineAudioReverbPreset);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.WebCamFlags>(translator.PushUnityEngineWebCamFlags, translator.Get, translator.UpdateUnityEngineWebCamFlags);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.WebCamKind>(translator.PushUnityEngineWebCamKind, translator.Get, translator.UpdateUnityEngineWebCamKind);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SendMessageOptions>(translator.PushUnityEngineSendMessageOptions, translator.Get, translator.UpdateUnityEngineSendMessageOptions);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.PrimitiveType>(translator.PushUnityEnginePrimitiveType, translator.Get, translator.UpdateUnityEnginePrimitiveType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Space>(translator.PushUnityEngineSpace, translator.Get, translator.UpdateUnityEngineSpace);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RuntimePlatform>(translator.PushUnityEngineRuntimePlatform, translator.Get, translator.UpdateUnityEngineRuntimePlatform);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SystemLanguage>(translator.PushUnityEngineSystemLanguage, translator.Get, translator.UpdateUnityEngineSystemLanguage);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.LogType>(translator.PushUnityEngineLogType, translator.Get, translator.UpdateUnityEngineLogType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.LogOption>(translator.PushUnityEngineLogOption, translator.Get, translator.UpdateUnityEngineLogOption);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ThreadPriority>(translator.PushUnityEngineThreadPriority, translator.Get, translator.UpdateUnityEngineThreadPriority);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.WeightedMode>(translator.PushUnityEngineWeightedMode, translator.Get, translator.UpdateUnityEngineWeightedMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.WrapMode>(translator.PushUnityEngineWrapMode, translator.Get, translator.UpdateUnityEngineWrapMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.StackTraceLogType>(translator.PushUnityEngineStackTraceLogType, translator.Get, translator.UpdateUnityEngineStackTraceLogType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UserAuthorization>(translator.PushUnityEngineUserAuthorization, translator.Get, translator.UpdateUnityEngineUserAuthorization);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ApplicationInstallMode>(translator.PushUnityEngineApplicationInstallMode, translator.Get, translator.UpdateUnityEngineApplicationInstallMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ApplicationSandboxType>(translator.PushUnityEngineApplicationSandboxType, translator.Get, translator.UpdateUnityEngineApplicationSandboxType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AudioType>(translator.PushUnityEngineAudioType, translator.Get, translator.UpdateUnityEngineAudioType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Camera.GateFitMode>(translator.PushUnityEngineCameraGateFitMode, translator.Get, translator.UpdateUnityEngineCameraGateFitMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Camera.FieldOfViewAxis>(translator.PushUnityEngineCameraFieldOfViewAxis, translator.Get, translator.UpdateUnityEngineCameraFieldOfViewAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Camera.StereoscopicEye>(translator.PushUnityEngineCameraStereoscopicEye, translator.Get, translator.UpdateUnityEngineCameraStereoscopicEye);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Camera.MonoOrStereoscopicEye>(translator.PushUnityEngineCameraMonoOrStereoscopicEye, translator.Get, translator.UpdateUnityEngineCameraMonoOrStereoscopicEye);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ReflectionProbe.ReflectionProbeEvent>(translator.PushUnityEngineReflectionProbeReflectionProbeEvent, translator.Get, translator.UpdateUnityEngineReflectionProbeReflectionProbeEvent);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.FullScreenMode>(translator.PushUnityEngineFullScreenMode, translator.Get, translator.UpdateUnityEngineFullScreenMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ComputeBufferMode>(translator.PushUnityEngineComputeBufferMode, translator.Get, translator.UpdateUnityEngineComputeBufferMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.D3DHDRDisplayBitDepth>(translator.PushUnityEngineD3DHDRDisplayBitDepth, translator.Get, translator.UpdateUnityEngineD3DHDRDisplayBitDepth);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RenderingPath>(translator.PushUnityEngineRenderingPath, translator.Get, translator.UpdateUnityEngineRenderingPath);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TransparencySortMode>(translator.PushUnityEngineTransparencySortMode, translator.Get, translator.UpdateUnityEngineTransparencySortMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.StereoTargetEyeMask>(translator.PushUnityEngineStereoTargetEyeMask, translator.Get, translator.UpdateUnityEngineStereoTargetEyeMask);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CameraType>(translator.PushUnityEngineCameraType, translator.Get, translator.UpdateUnityEngineCameraType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ComputeBufferType>(translator.PushUnityEngineComputeBufferType, translator.Get, translator.UpdateUnityEngineComputeBufferType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.FogMode>(translator.PushUnityEngineFogMode, translator.Get, translator.UpdateUnityEngineFogMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ReceiveGI>(translator.PushUnityEngineReceiveGI, translator.Get, translator.UpdateUnityEngineReceiveGI);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ShadowProjection>(translator.PushUnityEngineShadowProjection, translator.Get, translator.UpdateUnityEngineShadowProjection);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ShadowQuality>(translator.PushUnityEngineShadowQuality, translator.Get, translator.UpdateUnityEngineShadowQuality);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ShadowResolution>(translator.PushUnityEngineShadowResolution, translator.Get, translator.UpdateUnityEngineShadowResolution);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ShadowmaskMode>(translator.PushUnityEngineShadowmaskMode, translator.Get, translator.UpdateUnityEngineShadowmaskMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CameraClearFlags>(translator.PushUnityEngineCameraClearFlags, translator.Get, translator.UpdateUnityEngineCameraClearFlags);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.DepthTextureMode>(translator.PushUnityEngineDepthTextureMode, translator.Get, translator.UpdateUnityEngineDepthTextureMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TexGenMode>(translator.PushUnityEngineTexGenMode, translator.Get, translator.UpdateUnityEngineTexGenMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AnisotropicFiltering>(translator.PushUnityEngineAnisotropicFiltering, translator.Get, translator.UpdateUnityEngineAnisotropicFiltering);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SkinWeights>(translator.PushUnityEngineSkinWeights, translator.Get, translator.UpdateUnityEngineSkinWeights);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.MeshTopology>(translator.PushUnityEngineMeshTopology, translator.Get, translator.UpdateUnityEngineMeshTopology);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SkinQuality>(translator.PushUnityEngineSkinQuality, translator.Get, translator.UpdateUnityEngineSkinQuality);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ColorSpace>(translator.PushUnityEngineColorSpace, translator.Get, translator.UpdateUnityEngineColorSpace);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ColorGamut>(translator.PushUnityEngineColorGamut, translator.Get, translator.UpdateUnityEngineColorGamut);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ScreenOrientation>(translator.PushUnityEngineScreenOrientation, translator.Get, translator.UpdateUnityEngineScreenOrientation);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.FilterMode>(translator.PushUnityEngineFilterMode, translator.Get, translator.UpdateUnityEngineFilterMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TextureWrapMode>(translator.PushUnityEngineTextureWrapMode, translator.Get, translator.UpdateUnityEngineTextureWrapMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.NPOTSupport>(translator.PushUnityEngineNPOTSupport, translator.Get, translator.UpdateUnityEngineNPOTSupport);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TextureFormat>(translator.PushUnityEngineTextureFormat, translator.Get, translator.UpdateUnityEngineTextureFormat);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CubemapFace>(translator.PushUnityEngineCubemapFace, translator.Get, translator.UpdateUnityEngineCubemapFace);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RenderTextureFormat>(translator.PushUnityEngineRenderTextureFormat, translator.Get, translator.UpdateUnityEngineRenderTextureFormat);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.VRTextureUsage>(translator.PushUnityEngineVRTextureUsage, translator.Get, translator.UpdateUnityEngineVRTextureUsage);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RenderTextureCreationFlags>(translator.PushUnityEngineRenderTextureCreationFlags, translator.Get, translator.UpdateUnityEngineRenderTextureCreationFlags);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RenderTextureReadWrite>(translator.PushUnityEngineRenderTextureReadWrite, translator.Get, translator.UpdateUnityEngineRenderTextureReadWrite);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RenderTextureMemoryless>(translator.PushUnityEngineRenderTextureMemoryless, translator.Get, translator.UpdateUnityEngineRenderTextureMemoryless);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.MaterialGlobalIlluminationFlags>(translator.PushUnityEngineMaterialGlobalIlluminationFlags, translator.Get, translator.UpdateUnityEngineMaterialGlobalIlluminationFlags);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CustomRenderTextureInitializationSource>(translator.PushUnityEngineCustomRenderTextureInitializationSource, translator.Get, translator.UpdateUnityEngineCustomRenderTextureInitializationSource);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CustomRenderTextureUpdateMode>(translator.PushUnityEngineCustomRenderTextureUpdateMode, translator.Get, translator.UpdateUnityEngineCustomRenderTextureUpdateMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CustomRenderTextureUpdateZoneSpace>(translator.PushUnityEngineCustomRenderTextureUpdateZoneSpace, translator.Get, translator.UpdateUnityEngineCustomRenderTextureUpdateZoneSpace);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.LineTextureMode>(translator.PushUnityEngineLineTextureMode, translator.Get, translator.UpdateUnityEngineLineTextureMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.LineAlignment>(translator.PushUnityEngineLineAlignment, translator.Get, translator.UpdateUnityEngineLineAlignment);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.LODFadeMode>(translator.PushUnityEngineLODFadeMode, translator.Get, translator.UpdateUnityEngineLODFadeMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Texture2D.EXRFlags>(translator.PushUnityEngineTexture2DEXRFlags, translator.Get, translator.UpdateUnityEngineTexture2DEXRFlags);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.KeyCode>(translator.PushUnityEngineKeyCode, translator.Get, translator.UpdateUnityEngineKeyCode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.GradientMode>(translator.PushUnityEngineGradientMode, translator.Get, translator.UpdateUnityEngineGradientMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RuntimeInitializeLoadType>(translator.PushUnityEngineRuntimeInitializeLoadType, translator.Get, translator.UpdateUnityEngineRuntimeInitializeLoadType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.HideFlags>(translator.PushUnityEngineHideFlags, translator.Get, translator.UpdateUnityEngineHideFlags);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SnapAxis>(translator.PushUnityEngineSnapAxis, translator.Get, translator.UpdateUnityEngineSnapAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.BatteryStatus>(translator.PushUnityEngineBatteryStatus, translator.Get, translator.UpdateUnityEngineBatteryStatus);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.OperatingSystemFamily>(translator.PushUnityEngineOperatingSystemFamily, translator.Get, translator.UpdateUnityEngineOperatingSystemFamily);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.DeviceType>(translator.PushUnityEngineDeviceType, translator.Get, translator.UpdateUnityEngineDeviceType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.DrivenTransformProperties>(translator.PushUnityEngineDrivenTransformProperties, translator.Get, translator.UpdateUnityEngineDrivenTransformProperties);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RectTransform.Edge>(translator.PushUnityEngineRectTransformEdge, translator.Get, translator.UpdateUnityEngineRectTransformEdge);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RectTransform.Axis>(translator.PushUnityEngineRectTransformAxis, translator.Get, translator.UpdateUnityEngineRectTransformAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpriteDrawMode>(translator.PushUnityEngineSpriteDrawMode, translator.Get, translator.UpdateUnityEngineSpriteDrawMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpriteTileMode>(translator.PushUnityEngineSpriteTileMode, translator.Get, translator.UpdateUnityEngineSpriteTileMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpriteMaskInteraction>(translator.PushUnityEngineSpriteMaskInteraction, translator.Get, translator.UpdateUnityEngineSpriteMaskInteraction);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpriteMeshType>(translator.PushUnityEngineSpriteMeshType, translator.Get, translator.UpdateUnityEngineSpriteMeshType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpriteAlignment>(translator.PushUnityEngineSpriteAlignment, translator.Get, translator.UpdateUnityEngineSpriteAlignment);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpritePackingMode>(translator.PushUnityEngineSpritePackingMode, translator.Get, translator.UpdateUnityEngineSpritePackingMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpritePackingRotation>(translator.PushUnityEngineSpritePackingRotation, translator.Get, translator.UpdateUnityEngineSpritePackingRotation);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.SpriteSortPoint>(translator.PushUnityEngineSpriteSortPoint, translator.Get, translator.UpdateUnityEngineSpriteSortPoint);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.GridLayout.CellLayout>(translator.PushUnityEngineGridLayoutCellLayout, translator.Get, translator.UpdateUnityEngineGridLayoutCellLayout);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.GridLayout.CellSwizzle>(translator.PushUnityEngineGridLayoutCellSwizzle, translator.Get, translator.UpdateUnityEngineGridLayoutCellSwizzle);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.PointerType>(translator.PushUnityEnginePointerType, translator.Get, translator.UpdateUnityEnginePointerType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ScaleMode>(translator.PushUnityEngineScaleMode, translator.Get, translator.UpdateUnityEngineScaleMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.FocusType>(translator.PushUnityEngineFocusType, translator.Get, translator.UpdateUnityEngineFocusType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ImagePosition>(translator.PushUnityEngineImagePosition, translator.Get, translator.UpdateUnityEngineImagePosition);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TouchPhase>(translator.PushUnityEngineTouchPhase, translator.Get, translator.UpdateUnityEngineTouchPhase);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.IMECompositionMode>(translator.PushUnityEngineIMECompositionMode, translator.Get, translator.UpdateUnityEngineIMECompositionMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TouchType>(translator.PushUnityEngineTouchType, translator.Get, translator.UpdateUnityEngineTouchType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.DeviceOrientation>(translator.PushUnityEngineDeviceOrientation, translator.Get, translator.UpdateUnityEngineDeviceOrientation);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.LocationServiceStatus>(translator.PushUnityEngineLocationServiceStatus, translator.Get, translator.UpdateUnityEngineLocationServiceStatus);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RigidbodyConstraints>(translator.PushUnityEngineRigidbodyConstraints, translator.Get, translator.UpdateUnityEngineRigidbodyConstraints);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ForceMode>(translator.PushUnityEngineForceMode, translator.Get, translator.UpdateUnityEngineForceMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.JointProjectionMode>(translator.PushUnityEngineJointProjectionMode, translator.Get, translator.UpdateUnityEngineJointProjectionMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.MeshColliderCookingOptions>(translator.PushUnityEngineMeshColliderCookingOptions, translator.Get, translator.UpdateUnityEngineMeshColliderCookingOptions);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RigidbodyInterpolation>(translator.PushUnityEngineRigidbodyInterpolation, translator.Get, translator.UpdateUnityEngineRigidbodyInterpolation);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.PhysicMaterialCombine>(translator.PushUnityEnginePhysicMaterialCombine, translator.Get, translator.UpdateUnityEnginePhysicMaterialCombine);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CollisionFlags>(translator.PushUnityEngineCollisionFlags, translator.Get, translator.UpdateUnityEngineCollisionFlags);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.QueryTriggerInteraction>(translator.PushUnityEngineQueryTriggerInteraction, translator.Get, translator.UpdateUnityEngineQueryTriggerInteraction);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CollisionDetectionMode>(translator.PushUnityEngineCollisionDetectionMode, translator.Get, translator.UpdateUnityEngineCollisionDetectionMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RotationDriveMode>(translator.PushUnityEngineRotationDriveMode, translator.Get, translator.UpdateUnityEngineRotationDriveMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CapsuleDirection2D>(translator.PushUnityEngineCapsuleDirection2D, translator.Get, translator.UpdateUnityEngineCapsuleDirection2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RigidbodyConstraints2D>(translator.PushUnityEngineRigidbodyConstraints2D, translator.Get, translator.UpdateUnityEngineRigidbodyConstraints2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RigidbodyInterpolation2D>(translator.PushUnityEngineRigidbodyInterpolation2D, translator.Get, translator.UpdateUnityEngineRigidbodyInterpolation2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RigidbodySleepMode2D>(translator.PushUnityEngineRigidbodySleepMode2D, translator.Get, translator.UpdateUnityEngineRigidbodySleepMode2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CollisionDetectionMode2D>(translator.PushUnityEngineCollisionDetectionMode2D, translator.Get, translator.UpdateUnityEngineCollisionDetectionMode2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RigidbodyType2D>(translator.PushUnityEngineRigidbodyType2D, translator.Get, translator.UpdateUnityEngineRigidbodyType2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ForceMode2D>(translator.PushUnityEngineForceMode2D, translator.Get, translator.UpdateUnityEngineForceMode2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.JointLimitState2D>(translator.PushUnityEngineJointLimitState2D, translator.Get, translator.UpdateUnityEngineJointLimitState2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.EffectorSelection2D>(translator.PushUnityEngineEffectorSelection2D, translator.Get, translator.UpdateUnityEngineEffectorSelection2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.EffectorForceMode2D>(translator.PushUnityEngineEffectorForceMode2D, translator.Get, translator.UpdateUnityEngineEffectorForceMode2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CompositeCollider2D.GeometryType>(translator.PushUnityEngineCompositeCollider2DGeometryType, translator.Get, translator.UpdateUnityEngineCompositeCollider2DGeometryType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.CompositeCollider2D.GenerationType>(translator.PushUnityEngineCompositeCollider2DGenerationType, translator.Get, translator.UpdateUnityEngineCompositeCollider2DGenerationType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.ScreenCapture.StereoScreenCaptureMode>(translator.PushUnityEngineScreenCaptureStereoScreenCaptureMode, translator.Get, translator.UpdateUnityEngineScreenCaptureStereoScreenCaptureMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TextAnchor>(translator.PushUnityEngineTextAnchor, translator.Get, translator.UpdateUnityEngineTextAnchor);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.HorizontalWrapMode>(translator.PushUnityEngineHorizontalWrapMode, translator.Get, translator.UpdateUnityEngineHorizontalWrapMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.VerticalWrapMode>(translator.PushUnityEngineVerticalWrapMode, translator.Get, translator.UpdateUnityEngineVerticalWrapMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.GridBrushBase.Tool>(translator.PushUnityEngineGridBrushBaseTool, translator.Get, translator.UpdateUnityEngineGridBrushBaseTool);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.GridBrushBase.RotationDirection>(translator.PushUnityEngineGridBrushBaseRotationDirection, translator.Get, translator.UpdateUnityEngineGridBrushBaseRotationDirection);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.GridBrushBase.FlipAxis>(translator.PushUnityEngineGridBrushBaseFlipAxis, translator.Get, translator.UpdateUnityEngineGridBrushBaseFlipAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RenderMode>(translator.PushUnityEngineRenderMode, translator.Get, translator.UpdateUnityEngineRenderMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.AdditionalCanvasShaderChannels>(translator.PushUnityEngineAdditionalCanvasShaderChannels, translator.Get, translator.UpdateUnityEngineAdditionalCanvasShaderChannels);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UISystemProfilerApi.SampleType>(translator.PushUnityEngineUISystemProfilerApiSampleType, translator.Get, translator.UpdateUnityEngineUISystemProfilerApiSampleType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.WindZoneMode>(translator.PushUnityEngineWindZoneMode, translator.Get, translator.UpdateUnityEngineWindZoneMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasUpdate>(translator.PushUnityEngineUICanvasUpdate, translator.Get, translator.UpdateUnityEngineUICanvasUpdate);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Type>(translator.PushUnityEngineUIImageType, translator.Get, translator.UpdateUnityEngineUIImageType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.FillMethod>(translator.PushUnityEngineUIImageFillMethod, translator.Get, translator.UpdateUnityEngineUIImageFillMethod);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.OriginHorizontal>(translator.PushUnityEngineUIImageOriginHorizontal, translator.Get, translator.UpdateUnityEngineUIImageOriginHorizontal);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.OriginVertical>(translator.PushUnityEngineUIImageOriginVertical, translator.Get, translator.UpdateUnityEngineUIImageOriginVertical);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin90>(translator.PushUnityEngineUIImageOrigin90, translator.Get, translator.UpdateUnityEngineUIImageOrigin90);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin180>(translator.PushUnityEngineUIImageOrigin180, translator.Get, translator.UpdateUnityEngineUIImageOrigin180);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin360>(translator.PushUnityEngineUIImageOrigin360, translator.Get, translator.UpdateUnityEngineUIImageOrigin360);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.ContentType>(translator.PushUnityEngineUIInputFieldContentType, translator.Get, translator.UpdateUnityEngineUIInputFieldContentType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.InputType>(translator.PushUnityEngineUIInputFieldInputType, translator.Get, translator.UpdateUnityEngineUIInputFieldInputType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.CharacterValidation>(translator.PushUnityEngineUIInputFieldCharacterValidation, translator.Get, translator.UpdateUnityEngineUIInputFieldCharacterValidation);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.LineType>(translator.PushUnityEngineUIInputFieldLineType, translator.Get, translator.UpdateUnityEngineUIInputFieldLineType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.AspectRatioFitter.AspectMode>(translator.PushUnityEngineUIAspectRatioFitterAspectMode, translator.Get, translator.UpdateUnityEngineUIAspectRatioFitterAspectMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasScaler.ScaleMode>(translator.PushUnityEngineUICanvasScalerScaleMode, translator.Get, translator.UpdateUnityEngineUICanvasScalerScaleMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasScaler.ScreenMatchMode>(translator.PushUnityEngineUICanvasScalerScreenMatchMode, translator.Get, translator.UpdateUnityEngineUICanvasScalerScreenMatchMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasScaler.Unit>(translator.PushUnityEngineUICanvasScalerUnit, translator.Get, translator.UpdateUnityEngineUICanvasScalerUnit);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.ContentSizeFitter.FitMode>(translator.PushUnityEngineUIContentSizeFitterFitMode, translator.Get, translator.UpdateUnityEngineUIContentSizeFitterFitMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.GridLayoutGroup.Corner>(translator.PushUnityEngineUIGridLayoutGroupCorner, translator.Get, translator.UpdateUnityEngineUIGridLayoutGroupCorner);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.GridLayoutGroup.Axis>(translator.PushUnityEngineUIGridLayoutGroupAxis, translator.Get, translator.UpdateUnityEngineUIGridLayoutGroupAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.GridLayoutGroup.Constraint>(translator.PushUnityEngineUIGridLayoutGroupConstraint, translator.Get, translator.UpdateUnityEngineUIGridLayoutGroupConstraint);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Navigation.Mode>(translator.PushUnityEngineUINavigationMode, translator.Get, translator.UpdateUnityEngineUINavigationMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.ScrollRect.MovementType>(translator.PushUnityEngineUIScrollRectMovementType, translator.Get, translator.UpdateUnityEngineUIScrollRectMovementType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.ScrollRect.ScrollbarVisibility>(translator.PushUnityEngineUIScrollRectScrollbarVisibility, translator.Get, translator.UpdateUnityEngineUIScrollRectScrollbarVisibility);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Scrollbar.Direction>(translator.PushUnityEngineUIScrollbarDirection, translator.Get, translator.UpdateUnityEngineUIScrollbarDirection);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Selectable.Transition>(translator.PushUnityEngineUISelectableTransition, translator.Get, translator.UpdateUnityEngineUISelectableTransition);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Slider.Direction>(translator.PushUnityEngineUISliderDirection, translator.Get, translator.UpdateUnityEngineUISliderDirection);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Toggle.ToggleTransition>(translator.PushUnityEngineUIToggleToggleTransition, translator.Get, translator.UpdateUnityEngineUIToggleToggleTransition);
				translator.RegisterPushAndGetAndUpdate<XDebug.Orient>(translator.PushXDebugOrient, translator.Get, translator.UpdateXDebugOrient);
				translator.RegisterPushAndGetAndUpdate<XDebug.Location.Align>(translator.PushXDebugLocationAlign, translator.Get, translator.UpdateXDebugLocationAlign);
				translator.RegisterPushAndGetAndUpdate<XDebug.Module.Type>(translator.PushXDebugModuleType, translator.Get, translator.UpdateXDebugModuleType);
				translator.RegisterPushAndGetAndUpdate<XDebug.XLog.LogLevel>(translator.PushXDebugXLogLogLevel, translator.Get, translator.UpdateXDebugXLogLogLevel);
			
			}
        }
        
        static IniterAdderUnityEngineVector2 s_IniterAdderUnityEngineVector2_dumb_obj = new IniterAdderUnityEngineVector2();
        static IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj {get{return s_IniterAdderUnityEngineVector2_dumb_obj;}}
        
        
        int UnityEngineVector2_TypeID = -1;
        public void PushUnityEngineVector2(RealStatePtr L, UnityEngine.Vector2 val)
        {
            if (UnityEngineVector2_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector2_TypeID = getTypeId(L, typeof(UnityEngine.Vector2), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 8, UnityEngineVector2_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector2 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector2 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector2_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector2");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector2");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector2)objectCasters.GetCaster(typeof(UnityEngine.Vector2))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector2(RealStatePtr L, int index, UnityEngine.Vector2 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector2_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector2");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector2 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVector3_TypeID = -1;
        public void PushUnityEngineVector3(RealStatePtr L, UnityEngine.Vector3 val)
        {
            if (UnityEngineVector3_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector3_TypeID = getTypeId(L, typeof(UnityEngine.Vector3), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 12, UnityEngineVector3_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector3 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector3 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector3_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector3");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector3");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector3)objectCasters.GetCaster(typeof(UnityEngine.Vector3))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector3(RealStatePtr L, int index, UnityEngine.Vector3 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector3_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector3");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector3 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVector4_TypeID = -1;
        public void PushUnityEngineVector4(RealStatePtr L, UnityEngine.Vector4 val)
        {
            if (UnityEngineVector4_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector4_TypeID = getTypeId(L, typeof(UnityEngine.Vector4), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineVector4_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector4 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector4 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector4_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector4");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector4");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector4)objectCasters.GetCaster(typeof(UnityEngine.Vector4))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector4(RealStatePtr L, int index, UnityEngine.Vector4 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector4_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector4");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector4 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineColor_TypeID = -1;
        public void PushUnityEngineColor(RealStatePtr L, UnityEngine.Color val)
        {
            if (UnityEngineColor_TypeID == -1)
            {
			    bool is_first;
                UnityEngineColor_TypeID = getTypeId(L, typeof(UnityEngine.Color), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineColor_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Color ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Color val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Color");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Color");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Color)objectCasters.GetCaster(typeof(UnityEngine.Color))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineColor(RealStatePtr L, int index, UnityEngine.Color val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Color");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Color ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineQuaternion_TypeID = -1;
        public void PushUnityEngineQuaternion(RealStatePtr L, UnityEngine.Quaternion val)
        {
            if (UnityEngineQuaternion_TypeID == -1)
            {
			    bool is_first;
                UnityEngineQuaternion_TypeID = getTypeId(L, typeof(UnityEngine.Quaternion), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineQuaternion_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Quaternion ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Quaternion val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQuaternion_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Quaternion");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Quaternion");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Quaternion)objectCasters.GetCaster(typeof(UnityEngine.Quaternion))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineQuaternion(RealStatePtr L, int index, UnityEngine.Quaternion val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQuaternion_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Quaternion");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Quaternion ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRay_TypeID = -1;
        public void PushUnityEngineRay(RealStatePtr L, UnityEngine.Ray val)
        {
            if (UnityEngineRay_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRay_TypeID = getTypeId(L, typeof(UnityEngine.Ray), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 24, UnityEngineRay_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Ray ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Ray val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Ray");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Ray)objectCasters.GetCaster(typeof(UnityEngine.Ray))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRay(RealStatePtr L, int index, UnityEngine.Ray val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Ray ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineBounds_TypeID = -1;
        public void PushUnityEngineBounds(RealStatePtr L, UnityEngine.Bounds val)
        {
            if (UnityEngineBounds_TypeID == -1)
            {
			    bool is_first;
                UnityEngineBounds_TypeID = getTypeId(L, typeof(UnityEngine.Bounds), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 24, UnityEngineBounds_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Bounds ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Bounds val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBounds_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Bounds");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Bounds");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Bounds)objectCasters.GetCaster(typeof(UnityEngine.Bounds))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineBounds(RealStatePtr L, int index, UnityEngine.Bounds val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBounds_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Bounds");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Bounds ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRay2D_TypeID = -1;
        public void PushUnityEngineRay2D(RealStatePtr L, UnityEngine.Ray2D val)
        {
            if (UnityEngineRay2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRay2D_TypeID = getTypeId(L, typeof(UnityEngine.Ray2D), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineRay2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Ray2D ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Ray2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Ray2D");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Ray2D)objectCasters.GetCaster(typeof(UnityEngine.Ray2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRay2D(RealStatePtr L, int index, UnityEngine.Ray2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Ray2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAvatarTarget_TypeID = -1;
		int UnityEngineAvatarTarget_EnumRef = -1;
        
        public void PushUnityEngineAvatarTarget(RealStatePtr L, UnityEngine.AvatarTarget val)
        {
            if (UnityEngineAvatarTarget_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAvatarTarget_TypeID = getTypeId(L, typeof(UnityEngine.AvatarTarget), out is_first);
				
				if (UnityEngineAvatarTarget_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AvatarTarget));
				    UnityEngineAvatarTarget_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAvatarTarget_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAvatarTarget_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AvatarTarget ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAvatarTarget_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AvatarTarget val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarTarget_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarTarget");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AvatarTarget");
                }
				val = (UnityEngine.AvatarTarget)e;
                
            }
            else
            {
                val = (UnityEngine.AvatarTarget)objectCasters.GetCaster(typeof(UnityEngine.AvatarTarget))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAvatarTarget(RealStatePtr L, int index, UnityEngine.AvatarTarget val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarTarget_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarTarget");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AvatarTarget ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAvatarIKGoal_TypeID = -1;
		int UnityEngineAvatarIKGoal_EnumRef = -1;
        
        public void PushUnityEngineAvatarIKGoal(RealStatePtr L, UnityEngine.AvatarIKGoal val)
        {
            if (UnityEngineAvatarIKGoal_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAvatarIKGoal_TypeID = getTypeId(L, typeof(UnityEngine.AvatarIKGoal), out is_first);
				
				if (UnityEngineAvatarIKGoal_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AvatarIKGoal));
				    UnityEngineAvatarIKGoal_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAvatarIKGoal_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAvatarIKGoal_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AvatarIKGoal ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAvatarIKGoal_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AvatarIKGoal val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarIKGoal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarIKGoal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AvatarIKGoal");
                }
				val = (UnityEngine.AvatarIKGoal)e;
                
            }
            else
            {
                val = (UnityEngine.AvatarIKGoal)objectCasters.GetCaster(typeof(UnityEngine.AvatarIKGoal))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAvatarIKGoal(RealStatePtr L, int index, UnityEngine.AvatarIKGoal val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarIKGoal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarIKGoal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AvatarIKGoal ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAvatarIKHint_TypeID = -1;
		int UnityEngineAvatarIKHint_EnumRef = -1;
        
        public void PushUnityEngineAvatarIKHint(RealStatePtr L, UnityEngine.AvatarIKHint val)
        {
            if (UnityEngineAvatarIKHint_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAvatarIKHint_TypeID = getTypeId(L, typeof(UnityEngine.AvatarIKHint), out is_first);
				
				if (UnityEngineAvatarIKHint_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AvatarIKHint));
				    UnityEngineAvatarIKHint_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAvatarIKHint_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAvatarIKHint_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AvatarIKHint ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAvatarIKHint_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AvatarIKHint val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarIKHint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarIKHint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AvatarIKHint");
                }
				val = (UnityEngine.AvatarIKHint)e;
                
            }
            else
            {
                val = (UnityEngine.AvatarIKHint)objectCasters.GetCaster(typeof(UnityEngine.AvatarIKHint))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAvatarIKHint(RealStatePtr L, int index, UnityEngine.AvatarIKHint val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarIKHint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarIKHint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AvatarIKHint ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnimatorControllerParameterType_TypeID = -1;
		int UnityEngineAnimatorControllerParameterType_EnumRef = -1;
        
        public void PushUnityEngineAnimatorControllerParameterType(RealStatePtr L, UnityEngine.AnimatorControllerParameterType val)
        {
            if (UnityEngineAnimatorControllerParameterType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnimatorControllerParameterType_TypeID = getTypeId(L, typeof(UnityEngine.AnimatorControllerParameterType), out is_first);
				
				if (UnityEngineAnimatorControllerParameterType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnimatorControllerParameterType));
				    UnityEngineAnimatorControllerParameterType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnimatorControllerParameterType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnimatorControllerParameterType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnimatorControllerParameterType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnimatorControllerParameterType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnimatorControllerParameterType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorControllerParameterType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorControllerParameterType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnimatorControllerParameterType");
                }
				val = (UnityEngine.AnimatorControllerParameterType)e;
                
            }
            else
            {
                val = (UnityEngine.AnimatorControllerParameterType)objectCasters.GetCaster(typeof(UnityEngine.AnimatorControllerParameterType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnimatorControllerParameterType(RealStatePtr L, int index, UnityEngine.AnimatorControllerParameterType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorControllerParameterType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorControllerParameterType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnimatorControllerParameterType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnimatorRecorderMode_TypeID = -1;
		int UnityEngineAnimatorRecorderMode_EnumRef = -1;
        
        public void PushUnityEngineAnimatorRecorderMode(RealStatePtr L, UnityEngine.AnimatorRecorderMode val)
        {
            if (UnityEngineAnimatorRecorderMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnimatorRecorderMode_TypeID = getTypeId(L, typeof(UnityEngine.AnimatorRecorderMode), out is_first);
				
				if (UnityEngineAnimatorRecorderMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnimatorRecorderMode));
				    UnityEngineAnimatorRecorderMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnimatorRecorderMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnimatorRecorderMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnimatorRecorderMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnimatorRecorderMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnimatorRecorderMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorRecorderMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorRecorderMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnimatorRecorderMode");
                }
				val = (UnityEngine.AnimatorRecorderMode)e;
                
            }
            else
            {
                val = (UnityEngine.AnimatorRecorderMode)objectCasters.GetCaster(typeof(UnityEngine.AnimatorRecorderMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnimatorRecorderMode(RealStatePtr L, int index, UnityEngine.AnimatorRecorderMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorRecorderMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorRecorderMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnimatorRecorderMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineDurationUnit_TypeID = -1;
		int UnityEngineDurationUnit_EnumRef = -1;
        
        public void PushUnityEngineDurationUnit(RealStatePtr L, UnityEngine.DurationUnit val)
        {
            if (UnityEngineDurationUnit_TypeID == -1)
            {
			    bool is_first;
                UnityEngineDurationUnit_TypeID = getTypeId(L, typeof(UnityEngine.DurationUnit), out is_first);
				
				if (UnityEngineDurationUnit_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.DurationUnit));
				    UnityEngineDurationUnit_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineDurationUnit_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineDurationUnit_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.DurationUnit ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineDurationUnit_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.DurationUnit val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDurationUnit_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DurationUnit");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.DurationUnit");
                }
				val = (UnityEngine.DurationUnit)e;
                
            }
            else
            {
                val = (UnityEngine.DurationUnit)objectCasters.GetCaster(typeof(UnityEngine.DurationUnit))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineDurationUnit(RealStatePtr L, int index, UnityEngine.DurationUnit val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDurationUnit_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DurationUnit");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.DurationUnit ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnimatorCullingMode_TypeID = -1;
		int UnityEngineAnimatorCullingMode_EnumRef = -1;
        
        public void PushUnityEngineAnimatorCullingMode(RealStatePtr L, UnityEngine.AnimatorCullingMode val)
        {
            if (UnityEngineAnimatorCullingMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnimatorCullingMode_TypeID = getTypeId(L, typeof(UnityEngine.AnimatorCullingMode), out is_first);
				
				if (UnityEngineAnimatorCullingMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnimatorCullingMode));
				    UnityEngineAnimatorCullingMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnimatorCullingMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnimatorCullingMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnimatorCullingMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnimatorCullingMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnimatorCullingMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorCullingMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorCullingMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnimatorCullingMode");
                }
				val = (UnityEngine.AnimatorCullingMode)e;
                
            }
            else
            {
                val = (UnityEngine.AnimatorCullingMode)objectCasters.GetCaster(typeof(UnityEngine.AnimatorCullingMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnimatorCullingMode(RealStatePtr L, int index, UnityEngine.AnimatorCullingMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorCullingMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorCullingMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnimatorCullingMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnimatorUpdateMode_TypeID = -1;
		int UnityEngineAnimatorUpdateMode_EnumRef = -1;
        
        public void PushUnityEngineAnimatorUpdateMode(RealStatePtr L, UnityEngine.AnimatorUpdateMode val)
        {
            if (UnityEngineAnimatorUpdateMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnimatorUpdateMode_TypeID = getTypeId(L, typeof(UnityEngine.AnimatorUpdateMode), out is_first);
				
				if (UnityEngineAnimatorUpdateMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnimatorUpdateMode));
				    UnityEngineAnimatorUpdateMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnimatorUpdateMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnimatorUpdateMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnimatorUpdateMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnimatorUpdateMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnimatorUpdateMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorUpdateMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorUpdateMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnimatorUpdateMode");
                }
				val = (UnityEngine.AnimatorUpdateMode)e;
                
            }
            else
            {
                val = (UnityEngine.AnimatorUpdateMode)objectCasters.GetCaster(typeof(UnityEngine.AnimatorUpdateMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnimatorUpdateMode(RealStatePtr L, int index, UnityEngine.AnimatorUpdateMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimatorUpdateMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimatorUpdateMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnimatorUpdateMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineBodyDof_TypeID = -1;
		int UnityEngineBodyDof_EnumRef = -1;
        
        public void PushUnityEngineBodyDof(RealStatePtr L, UnityEngine.BodyDof val)
        {
            if (UnityEngineBodyDof_TypeID == -1)
            {
			    bool is_first;
                UnityEngineBodyDof_TypeID = getTypeId(L, typeof(UnityEngine.BodyDof), out is_first);
				
				if (UnityEngineBodyDof_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.BodyDof));
				    UnityEngineBodyDof_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineBodyDof_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineBodyDof_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.BodyDof ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineBodyDof_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.BodyDof val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBodyDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.BodyDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.BodyDof");
                }
				val = (UnityEngine.BodyDof)e;
                
            }
            else
            {
                val = (UnityEngine.BodyDof)objectCasters.GetCaster(typeof(UnityEngine.BodyDof))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineBodyDof(RealStatePtr L, int index, UnityEngine.BodyDof val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBodyDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.BodyDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.BodyDof ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineHeadDof_TypeID = -1;
		int UnityEngineHeadDof_EnumRef = -1;
        
        public void PushUnityEngineHeadDof(RealStatePtr L, UnityEngine.HeadDof val)
        {
            if (UnityEngineHeadDof_TypeID == -1)
            {
			    bool is_first;
                UnityEngineHeadDof_TypeID = getTypeId(L, typeof(UnityEngine.HeadDof), out is_first);
				
				if (UnityEngineHeadDof_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.HeadDof));
				    UnityEngineHeadDof_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineHeadDof_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineHeadDof_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.HeadDof ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineHeadDof_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.HeadDof val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHeadDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HeadDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.HeadDof");
                }
				val = (UnityEngine.HeadDof)e;
                
            }
            else
            {
                val = (UnityEngine.HeadDof)objectCasters.GetCaster(typeof(UnityEngine.HeadDof))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineHeadDof(RealStatePtr L, int index, UnityEngine.HeadDof val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHeadDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HeadDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.HeadDof ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineLegDof_TypeID = -1;
		int UnityEngineLegDof_EnumRef = -1;
        
        public void PushUnityEngineLegDof(RealStatePtr L, UnityEngine.LegDof val)
        {
            if (UnityEngineLegDof_TypeID == -1)
            {
			    bool is_first;
                UnityEngineLegDof_TypeID = getTypeId(L, typeof(UnityEngine.LegDof), out is_first);
				
				if (UnityEngineLegDof_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.LegDof));
				    UnityEngineLegDof_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineLegDof_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineLegDof_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.LegDof ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineLegDof_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.LegDof val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLegDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LegDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.LegDof");
                }
				val = (UnityEngine.LegDof)e;
                
            }
            else
            {
                val = (UnityEngine.LegDof)objectCasters.GetCaster(typeof(UnityEngine.LegDof))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineLegDof(RealStatePtr L, int index, UnityEngine.LegDof val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLegDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LegDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.LegDof ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineArmDof_TypeID = -1;
		int UnityEngineArmDof_EnumRef = -1;
        
        public void PushUnityEngineArmDof(RealStatePtr L, UnityEngine.ArmDof val)
        {
            if (UnityEngineArmDof_TypeID == -1)
            {
			    bool is_first;
                UnityEngineArmDof_TypeID = getTypeId(L, typeof(UnityEngine.ArmDof), out is_first);
				
				if (UnityEngineArmDof_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ArmDof));
				    UnityEngineArmDof_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineArmDof_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineArmDof_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ArmDof ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineArmDof_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ArmDof val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineArmDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ArmDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ArmDof");
                }
				val = (UnityEngine.ArmDof)e;
                
            }
            else
            {
                val = (UnityEngine.ArmDof)objectCasters.GetCaster(typeof(UnityEngine.ArmDof))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineArmDof(RealStatePtr L, int index, UnityEngine.ArmDof val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineArmDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ArmDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ArmDof ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineFingerDof_TypeID = -1;
		int UnityEngineFingerDof_EnumRef = -1;
        
        public void PushUnityEngineFingerDof(RealStatePtr L, UnityEngine.FingerDof val)
        {
            if (UnityEngineFingerDof_TypeID == -1)
            {
			    bool is_first;
                UnityEngineFingerDof_TypeID = getTypeId(L, typeof(UnityEngine.FingerDof), out is_first);
				
				if (UnityEngineFingerDof_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.FingerDof));
				    UnityEngineFingerDof_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineFingerDof_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineFingerDof_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.FingerDof ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineFingerDof_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.FingerDof val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFingerDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FingerDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.FingerDof");
                }
				val = (UnityEngine.FingerDof)e;
                
            }
            else
            {
                val = (UnityEngine.FingerDof)objectCasters.GetCaster(typeof(UnityEngine.FingerDof))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineFingerDof(RealStatePtr L, int index, UnityEngine.FingerDof val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFingerDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FingerDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.FingerDof ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineHumanPartDof_TypeID = -1;
		int UnityEngineHumanPartDof_EnumRef = -1;
        
        public void PushUnityEngineHumanPartDof(RealStatePtr L, UnityEngine.HumanPartDof val)
        {
            if (UnityEngineHumanPartDof_TypeID == -1)
            {
			    bool is_first;
                UnityEngineHumanPartDof_TypeID = getTypeId(L, typeof(UnityEngine.HumanPartDof), out is_first);
				
				if (UnityEngineHumanPartDof_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.HumanPartDof));
				    UnityEngineHumanPartDof_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineHumanPartDof_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineHumanPartDof_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.HumanPartDof ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineHumanPartDof_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.HumanPartDof val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHumanPartDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HumanPartDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.HumanPartDof");
                }
				val = (UnityEngine.HumanPartDof)e;
                
            }
            else
            {
                val = (UnityEngine.HumanPartDof)objectCasters.GetCaster(typeof(UnityEngine.HumanPartDof))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineHumanPartDof(RealStatePtr L, int index, UnityEngine.HumanPartDof val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHumanPartDof_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HumanPartDof");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.HumanPartDof ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineHumanBodyBones_TypeID = -1;
		int UnityEngineHumanBodyBones_EnumRef = -1;
        
        public void PushUnityEngineHumanBodyBones(RealStatePtr L, UnityEngine.HumanBodyBones val)
        {
            if (UnityEngineHumanBodyBones_TypeID == -1)
            {
			    bool is_first;
                UnityEngineHumanBodyBones_TypeID = getTypeId(L, typeof(UnityEngine.HumanBodyBones), out is_first);
				
				if (UnityEngineHumanBodyBones_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.HumanBodyBones));
				    UnityEngineHumanBodyBones_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineHumanBodyBones_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineHumanBodyBones_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.HumanBodyBones ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineHumanBodyBones_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.HumanBodyBones val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHumanBodyBones_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HumanBodyBones");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.HumanBodyBones");
                }
				val = (UnityEngine.HumanBodyBones)e;
                
            }
            else
            {
                val = (UnityEngine.HumanBodyBones)objectCasters.GetCaster(typeof(UnityEngine.HumanBodyBones))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineHumanBodyBones(RealStatePtr L, int index, UnityEngine.HumanBodyBones val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHumanBodyBones_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HumanBodyBones");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.HumanBodyBones ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAvatarMaskBodyPart_TypeID = -1;
		int UnityEngineAvatarMaskBodyPart_EnumRef = -1;
        
        public void PushUnityEngineAvatarMaskBodyPart(RealStatePtr L, UnityEngine.AvatarMaskBodyPart val)
        {
            if (UnityEngineAvatarMaskBodyPart_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAvatarMaskBodyPart_TypeID = getTypeId(L, typeof(UnityEngine.AvatarMaskBodyPart), out is_first);
				
				if (UnityEngineAvatarMaskBodyPart_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AvatarMaskBodyPart));
				    UnityEngineAvatarMaskBodyPart_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAvatarMaskBodyPart_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAvatarMaskBodyPart_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AvatarMaskBodyPart ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAvatarMaskBodyPart_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AvatarMaskBodyPart val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarMaskBodyPart_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarMaskBodyPart");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AvatarMaskBodyPart");
                }
				val = (UnityEngine.AvatarMaskBodyPart)e;
                
            }
            else
            {
                val = (UnityEngine.AvatarMaskBodyPart)objectCasters.GetCaster(typeof(UnityEngine.AvatarMaskBodyPart))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAvatarMaskBodyPart(RealStatePtr L, int index, UnityEngine.AvatarMaskBodyPart val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAvatarMaskBodyPart_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AvatarMaskBodyPart");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AvatarMaskBodyPart ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEnginePlayMode_TypeID = -1;
		int UnityEnginePlayMode_EnumRef = -1;
        
        public void PushUnityEnginePlayMode(RealStatePtr L, UnityEngine.PlayMode val)
        {
            if (UnityEnginePlayMode_TypeID == -1)
            {
			    bool is_first;
                UnityEnginePlayMode_TypeID = getTypeId(L, typeof(UnityEngine.PlayMode), out is_first);
				
				if (UnityEnginePlayMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.PlayMode));
				    UnityEnginePlayMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEnginePlayMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEnginePlayMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.PlayMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEnginePlayMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.PlayMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePlayMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PlayMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.PlayMode");
                }
				val = (UnityEngine.PlayMode)e;
                
            }
            else
            {
                val = (UnityEngine.PlayMode)objectCasters.GetCaster(typeof(UnityEngine.PlayMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEnginePlayMode(RealStatePtr L, int index, UnityEngine.PlayMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePlayMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PlayMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.PlayMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineQueueMode_TypeID = -1;
		int UnityEngineQueueMode_EnumRef = -1;
        
        public void PushUnityEngineQueueMode(RealStatePtr L, UnityEngine.QueueMode val)
        {
            if (UnityEngineQueueMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineQueueMode_TypeID = getTypeId(L, typeof(UnityEngine.QueueMode), out is_first);
				
				if (UnityEngineQueueMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.QueueMode));
				    UnityEngineQueueMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineQueueMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineQueueMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.QueueMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineQueueMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.QueueMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQueueMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.QueueMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.QueueMode");
                }
				val = (UnityEngine.QueueMode)e;
                
            }
            else
            {
                val = (UnityEngine.QueueMode)objectCasters.GetCaster(typeof(UnityEngine.QueueMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineQueueMode(RealStatePtr L, int index, UnityEngine.QueueMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQueueMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.QueueMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.QueueMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnimationBlendMode_TypeID = -1;
		int UnityEngineAnimationBlendMode_EnumRef = -1;
        
        public void PushUnityEngineAnimationBlendMode(RealStatePtr L, UnityEngine.AnimationBlendMode val)
        {
            if (UnityEngineAnimationBlendMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnimationBlendMode_TypeID = getTypeId(L, typeof(UnityEngine.AnimationBlendMode), out is_first);
				
				if (UnityEngineAnimationBlendMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnimationBlendMode));
				    UnityEngineAnimationBlendMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnimationBlendMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnimationBlendMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnimationBlendMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnimationBlendMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnimationBlendMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimationBlendMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimationBlendMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnimationBlendMode");
                }
				val = (UnityEngine.AnimationBlendMode)e;
                
            }
            else
            {
                val = (UnityEngine.AnimationBlendMode)objectCasters.GetCaster(typeof(UnityEngine.AnimationBlendMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnimationBlendMode(RealStatePtr L, int index, UnityEngine.AnimationBlendMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimationBlendMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimationBlendMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnimationBlendMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnimationPlayMode_TypeID = -1;
		int UnityEngineAnimationPlayMode_EnumRef = -1;
        
        public void PushUnityEngineAnimationPlayMode(RealStatePtr L, UnityEngine.AnimationPlayMode val)
        {
            if (UnityEngineAnimationPlayMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnimationPlayMode_TypeID = getTypeId(L, typeof(UnityEngine.AnimationPlayMode), out is_first);
				
				if (UnityEngineAnimationPlayMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnimationPlayMode));
				    UnityEngineAnimationPlayMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnimationPlayMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnimationPlayMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnimationPlayMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnimationPlayMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnimationPlayMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimationPlayMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimationPlayMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnimationPlayMode");
                }
				val = (UnityEngine.AnimationPlayMode)e;
                
            }
            else
            {
                val = (UnityEngine.AnimationPlayMode)objectCasters.GetCaster(typeof(UnityEngine.AnimationPlayMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnimationPlayMode(RealStatePtr L, int index, UnityEngine.AnimationPlayMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimationPlayMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimationPlayMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnimationPlayMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnimationCullingType_TypeID = -1;
		int UnityEngineAnimationCullingType_EnumRef = -1;
        
        public void PushUnityEngineAnimationCullingType(RealStatePtr L, UnityEngine.AnimationCullingType val)
        {
            if (UnityEngineAnimationCullingType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnimationCullingType_TypeID = getTypeId(L, typeof(UnityEngine.AnimationCullingType), out is_first);
				
				if (UnityEngineAnimationCullingType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnimationCullingType));
				    UnityEngineAnimationCullingType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnimationCullingType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnimationCullingType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnimationCullingType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnimationCullingType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnimationCullingType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimationCullingType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimationCullingType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnimationCullingType");
                }
				val = (UnityEngine.AnimationCullingType)e;
                
            }
            else
            {
                val = (UnityEngine.AnimationCullingType)objectCasters.GetCaster(typeof(UnityEngine.AnimationCullingType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnimationCullingType(RealStatePtr L, int index, UnityEngine.AnimationCullingType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnimationCullingType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnimationCullingType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnimationCullingType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAssetBundleLoadResult_TypeID = -1;
		int UnityEngineAssetBundleLoadResult_EnumRef = -1;
        
        public void PushUnityEngineAssetBundleLoadResult(RealStatePtr L, UnityEngine.AssetBundleLoadResult val)
        {
            if (UnityEngineAssetBundleLoadResult_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAssetBundleLoadResult_TypeID = getTypeId(L, typeof(UnityEngine.AssetBundleLoadResult), out is_first);
				
				if (UnityEngineAssetBundleLoadResult_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AssetBundleLoadResult));
				    UnityEngineAssetBundleLoadResult_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAssetBundleLoadResult_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAssetBundleLoadResult_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AssetBundleLoadResult ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAssetBundleLoadResult_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AssetBundleLoadResult val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAssetBundleLoadResult_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AssetBundleLoadResult");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AssetBundleLoadResult");
                }
				val = (UnityEngine.AssetBundleLoadResult)e;
                
            }
            else
            {
                val = (UnityEngine.AssetBundleLoadResult)objectCasters.GetCaster(typeof(UnityEngine.AssetBundleLoadResult))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAssetBundleLoadResult(RealStatePtr L, int index, UnityEngine.AssetBundleLoadResult val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAssetBundleLoadResult_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AssetBundleLoadResult");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AssetBundleLoadResult ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCompressionType_TypeID = -1;
		int UnityEngineCompressionType_EnumRef = -1;
        
        public void PushUnityEngineCompressionType(RealStatePtr L, UnityEngine.CompressionType val)
        {
            if (UnityEngineCompressionType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCompressionType_TypeID = getTypeId(L, typeof(UnityEngine.CompressionType), out is_first);
				
				if (UnityEngineCompressionType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CompressionType));
				    UnityEngineCompressionType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCompressionType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCompressionType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CompressionType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCompressionType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CompressionType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompressionType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompressionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CompressionType");
                }
				val = (UnityEngine.CompressionType)e;
                
            }
            else
            {
                val = (UnityEngine.CompressionType)objectCasters.GetCaster(typeof(UnityEngine.CompressionType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCompressionType(RealStatePtr L, int index, UnityEngine.CompressionType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompressionType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompressionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CompressionType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCompressionLevel_TypeID = -1;
		int UnityEngineCompressionLevel_EnumRef = -1;
        
        public void PushUnityEngineCompressionLevel(RealStatePtr L, UnityEngine.CompressionLevel val)
        {
            if (UnityEngineCompressionLevel_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCompressionLevel_TypeID = getTypeId(L, typeof(UnityEngine.CompressionLevel), out is_first);
				
				if (UnityEngineCompressionLevel_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CompressionLevel));
				    UnityEngineCompressionLevel_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCompressionLevel_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCompressionLevel_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CompressionLevel ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCompressionLevel_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CompressionLevel val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompressionLevel_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompressionLevel");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CompressionLevel");
                }
				val = (UnityEngine.CompressionLevel)e;
                
            }
            else
            {
                val = (UnityEngine.CompressionLevel)objectCasters.GetCaster(typeof(UnityEngine.CompressionLevel))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCompressionLevel(RealStatePtr L, int index, UnityEngine.CompressionLevel val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompressionLevel_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompressionLevel");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CompressionLevel ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioSpeakerMode_TypeID = -1;
		int UnityEngineAudioSpeakerMode_EnumRef = -1;
        
        public void PushUnityEngineAudioSpeakerMode(RealStatePtr L, UnityEngine.AudioSpeakerMode val)
        {
            if (UnityEngineAudioSpeakerMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioSpeakerMode_TypeID = getTypeId(L, typeof(UnityEngine.AudioSpeakerMode), out is_first);
				
				if (UnityEngineAudioSpeakerMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioSpeakerMode));
				    UnityEngineAudioSpeakerMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioSpeakerMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioSpeakerMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioSpeakerMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioSpeakerMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioSpeakerMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioSpeakerMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioSpeakerMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioSpeakerMode");
                }
				val = (UnityEngine.AudioSpeakerMode)e;
                
            }
            else
            {
                val = (UnityEngine.AudioSpeakerMode)objectCasters.GetCaster(typeof(UnityEngine.AudioSpeakerMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioSpeakerMode(RealStatePtr L, int index, UnityEngine.AudioSpeakerMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioSpeakerMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioSpeakerMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioSpeakerMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioDataLoadState_TypeID = -1;
		int UnityEngineAudioDataLoadState_EnumRef = -1;
        
        public void PushUnityEngineAudioDataLoadState(RealStatePtr L, UnityEngine.AudioDataLoadState val)
        {
            if (UnityEngineAudioDataLoadState_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioDataLoadState_TypeID = getTypeId(L, typeof(UnityEngine.AudioDataLoadState), out is_first);
				
				if (UnityEngineAudioDataLoadState_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioDataLoadState));
				    UnityEngineAudioDataLoadState_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioDataLoadState_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioDataLoadState_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioDataLoadState ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioDataLoadState_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioDataLoadState val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioDataLoadState_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioDataLoadState");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioDataLoadState");
                }
				val = (UnityEngine.AudioDataLoadState)e;
                
            }
            else
            {
                val = (UnityEngine.AudioDataLoadState)objectCasters.GetCaster(typeof(UnityEngine.AudioDataLoadState))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioDataLoadState(RealStatePtr L, int index, UnityEngine.AudioDataLoadState val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioDataLoadState_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioDataLoadState");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioDataLoadState ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioCompressionFormat_TypeID = -1;
		int UnityEngineAudioCompressionFormat_EnumRef = -1;
        
        public void PushUnityEngineAudioCompressionFormat(RealStatePtr L, UnityEngine.AudioCompressionFormat val)
        {
            if (UnityEngineAudioCompressionFormat_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioCompressionFormat_TypeID = getTypeId(L, typeof(UnityEngine.AudioCompressionFormat), out is_first);
				
				if (UnityEngineAudioCompressionFormat_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioCompressionFormat));
				    UnityEngineAudioCompressionFormat_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioCompressionFormat_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioCompressionFormat_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioCompressionFormat ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioCompressionFormat_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioCompressionFormat val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioCompressionFormat_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioCompressionFormat");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioCompressionFormat");
                }
				val = (UnityEngine.AudioCompressionFormat)e;
                
            }
            else
            {
                val = (UnityEngine.AudioCompressionFormat)objectCasters.GetCaster(typeof(UnityEngine.AudioCompressionFormat))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioCompressionFormat(RealStatePtr L, int index, UnityEngine.AudioCompressionFormat val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioCompressionFormat_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioCompressionFormat");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioCompressionFormat ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioClipLoadType_TypeID = -1;
		int UnityEngineAudioClipLoadType_EnumRef = -1;
        
        public void PushUnityEngineAudioClipLoadType(RealStatePtr L, UnityEngine.AudioClipLoadType val)
        {
            if (UnityEngineAudioClipLoadType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioClipLoadType_TypeID = getTypeId(L, typeof(UnityEngine.AudioClipLoadType), out is_first);
				
				if (UnityEngineAudioClipLoadType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioClipLoadType));
				    UnityEngineAudioClipLoadType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioClipLoadType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioClipLoadType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioClipLoadType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioClipLoadType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioClipLoadType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioClipLoadType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioClipLoadType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioClipLoadType");
                }
				val = (UnityEngine.AudioClipLoadType)e;
                
            }
            else
            {
                val = (UnityEngine.AudioClipLoadType)objectCasters.GetCaster(typeof(UnityEngine.AudioClipLoadType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioClipLoadType(RealStatePtr L, int index, UnityEngine.AudioClipLoadType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioClipLoadType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioClipLoadType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioClipLoadType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioVelocityUpdateMode_TypeID = -1;
		int UnityEngineAudioVelocityUpdateMode_EnumRef = -1;
        
        public void PushUnityEngineAudioVelocityUpdateMode(RealStatePtr L, UnityEngine.AudioVelocityUpdateMode val)
        {
            if (UnityEngineAudioVelocityUpdateMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioVelocityUpdateMode_TypeID = getTypeId(L, typeof(UnityEngine.AudioVelocityUpdateMode), out is_first);
				
				if (UnityEngineAudioVelocityUpdateMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioVelocityUpdateMode));
				    UnityEngineAudioVelocityUpdateMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioVelocityUpdateMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioVelocityUpdateMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioVelocityUpdateMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioVelocityUpdateMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioVelocityUpdateMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioVelocityUpdateMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioVelocityUpdateMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioVelocityUpdateMode");
                }
				val = (UnityEngine.AudioVelocityUpdateMode)e;
                
            }
            else
            {
                val = (UnityEngine.AudioVelocityUpdateMode)objectCasters.GetCaster(typeof(UnityEngine.AudioVelocityUpdateMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioVelocityUpdateMode(RealStatePtr L, int index, UnityEngine.AudioVelocityUpdateMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioVelocityUpdateMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioVelocityUpdateMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioVelocityUpdateMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioRolloffMode_TypeID = -1;
		int UnityEngineAudioRolloffMode_EnumRef = -1;
        
        public void PushUnityEngineAudioRolloffMode(RealStatePtr L, UnityEngine.AudioRolloffMode val)
        {
            if (UnityEngineAudioRolloffMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioRolloffMode_TypeID = getTypeId(L, typeof(UnityEngine.AudioRolloffMode), out is_first);
				
				if (UnityEngineAudioRolloffMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioRolloffMode));
				    UnityEngineAudioRolloffMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioRolloffMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioRolloffMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioRolloffMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioRolloffMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioRolloffMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioRolloffMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioRolloffMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioRolloffMode");
                }
				val = (UnityEngine.AudioRolloffMode)e;
                
            }
            else
            {
                val = (UnityEngine.AudioRolloffMode)objectCasters.GetCaster(typeof(UnityEngine.AudioRolloffMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioRolloffMode(RealStatePtr L, int index, UnityEngine.AudioRolloffMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioRolloffMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioRolloffMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioRolloffMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioSourceCurveType_TypeID = -1;
		int UnityEngineAudioSourceCurveType_EnumRef = -1;
        
        public void PushUnityEngineAudioSourceCurveType(RealStatePtr L, UnityEngine.AudioSourceCurveType val)
        {
            if (UnityEngineAudioSourceCurveType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioSourceCurveType_TypeID = getTypeId(L, typeof(UnityEngine.AudioSourceCurveType), out is_first);
				
				if (UnityEngineAudioSourceCurveType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioSourceCurveType));
				    UnityEngineAudioSourceCurveType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioSourceCurveType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioSourceCurveType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioSourceCurveType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioSourceCurveType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioSourceCurveType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioSourceCurveType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioSourceCurveType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioSourceCurveType");
                }
				val = (UnityEngine.AudioSourceCurveType)e;
                
            }
            else
            {
                val = (UnityEngine.AudioSourceCurveType)objectCasters.GetCaster(typeof(UnityEngine.AudioSourceCurveType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioSourceCurveType(RealStatePtr L, int index, UnityEngine.AudioSourceCurveType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioSourceCurveType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioSourceCurveType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioSourceCurveType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioReverbPreset_TypeID = -1;
		int UnityEngineAudioReverbPreset_EnumRef = -1;
        
        public void PushUnityEngineAudioReverbPreset(RealStatePtr L, UnityEngine.AudioReverbPreset val)
        {
            if (UnityEngineAudioReverbPreset_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioReverbPreset_TypeID = getTypeId(L, typeof(UnityEngine.AudioReverbPreset), out is_first);
				
				if (UnityEngineAudioReverbPreset_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioReverbPreset));
				    UnityEngineAudioReverbPreset_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioReverbPreset_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioReverbPreset_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioReverbPreset ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioReverbPreset_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioReverbPreset val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioReverbPreset_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioReverbPreset");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioReverbPreset");
                }
				val = (UnityEngine.AudioReverbPreset)e;
                
            }
            else
            {
                val = (UnityEngine.AudioReverbPreset)objectCasters.GetCaster(typeof(UnityEngine.AudioReverbPreset))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioReverbPreset(RealStatePtr L, int index, UnityEngine.AudioReverbPreset val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioReverbPreset_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioReverbPreset");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioReverbPreset ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineWebCamFlags_TypeID = -1;
		int UnityEngineWebCamFlags_EnumRef = -1;
        
        public void PushUnityEngineWebCamFlags(RealStatePtr L, UnityEngine.WebCamFlags val)
        {
            if (UnityEngineWebCamFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineWebCamFlags_TypeID = getTypeId(L, typeof(UnityEngine.WebCamFlags), out is_first);
				
				if (UnityEngineWebCamFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.WebCamFlags));
				    UnityEngineWebCamFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineWebCamFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineWebCamFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.WebCamFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineWebCamFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.WebCamFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWebCamFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WebCamFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.WebCamFlags");
                }
				val = (UnityEngine.WebCamFlags)e;
                
            }
            else
            {
                val = (UnityEngine.WebCamFlags)objectCasters.GetCaster(typeof(UnityEngine.WebCamFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineWebCamFlags(RealStatePtr L, int index, UnityEngine.WebCamFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWebCamFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WebCamFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.WebCamFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineWebCamKind_TypeID = -1;
		int UnityEngineWebCamKind_EnumRef = -1;
        
        public void PushUnityEngineWebCamKind(RealStatePtr L, UnityEngine.WebCamKind val)
        {
            if (UnityEngineWebCamKind_TypeID == -1)
            {
			    bool is_first;
                UnityEngineWebCamKind_TypeID = getTypeId(L, typeof(UnityEngine.WebCamKind), out is_first);
				
				if (UnityEngineWebCamKind_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.WebCamKind));
				    UnityEngineWebCamKind_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineWebCamKind_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineWebCamKind_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.WebCamKind ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineWebCamKind_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.WebCamKind val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWebCamKind_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WebCamKind");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.WebCamKind");
                }
				val = (UnityEngine.WebCamKind)e;
                
            }
            else
            {
                val = (UnityEngine.WebCamKind)objectCasters.GetCaster(typeof(UnityEngine.WebCamKind))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineWebCamKind(RealStatePtr L, int index, UnityEngine.WebCamKind val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWebCamKind_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WebCamKind");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.WebCamKind ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSendMessageOptions_TypeID = -1;
		int UnityEngineSendMessageOptions_EnumRef = -1;
        
        public void PushUnityEngineSendMessageOptions(RealStatePtr L, UnityEngine.SendMessageOptions val)
        {
            if (UnityEngineSendMessageOptions_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSendMessageOptions_TypeID = getTypeId(L, typeof(UnityEngine.SendMessageOptions), out is_first);
				
				if (UnityEngineSendMessageOptions_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SendMessageOptions));
				    UnityEngineSendMessageOptions_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSendMessageOptions_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSendMessageOptions_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SendMessageOptions ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSendMessageOptions_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SendMessageOptions val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSendMessageOptions_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SendMessageOptions");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SendMessageOptions");
                }
				val = (UnityEngine.SendMessageOptions)e;
                
            }
            else
            {
                val = (UnityEngine.SendMessageOptions)objectCasters.GetCaster(typeof(UnityEngine.SendMessageOptions))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSendMessageOptions(RealStatePtr L, int index, UnityEngine.SendMessageOptions val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSendMessageOptions_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SendMessageOptions");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SendMessageOptions ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEnginePrimitiveType_TypeID = -1;
		int UnityEnginePrimitiveType_EnumRef = -1;
        
        public void PushUnityEnginePrimitiveType(RealStatePtr L, UnityEngine.PrimitiveType val)
        {
            if (UnityEnginePrimitiveType_TypeID == -1)
            {
			    bool is_first;
                UnityEnginePrimitiveType_TypeID = getTypeId(L, typeof(UnityEngine.PrimitiveType), out is_first);
				
				if (UnityEnginePrimitiveType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.PrimitiveType));
				    UnityEnginePrimitiveType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEnginePrimitiveType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEnginePrimitiveType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.PrimitiveType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEnginePrimitiveType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.PrimitiveType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePrimitiveType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PrimitiveType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.PrimitiveType");
                }
				val = (UnityEngine.PrimitiveType)e;
                
            }
            else
            {
                val = (UnityEngine.PrimitiveType)objectCasters.GetCaster(typeof(UnityEngine.PrimitiveType))(L, index, null);
            }
        }
		
        public void UpdateUnityEnginePrimitiveType(RealStatePtr L, int index, UnityEngine.PrimitiveType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePrimitiveType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PrimitiveType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.PrimitiveType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpace_TypeID = -1;
		int UnityEngineSpace_EnumRef = -1;
        
        public void PushUnityEngineSpace(RealStatePtr L, UnityEngine.Space val)
        {
            if (UnityEngineSpace_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpace_TypeID = getTypeId(L, typeof(UnityEngine.Space), out is_first);
				
				if (UnityEngineSpace_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.Space));
				    UnityEngineSpace_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpace_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpace_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.Space ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpace_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Space val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Space");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.Space");
                }
				val = (UnityEngine.Space)e;
                
            }
            else
            {
                val = (UnityEngine.Space)objectCasters.GetCaster(typeof(UnityEngine.Space))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpace(RealStatePtr L, int index, UnityEngine.Space val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Space");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.Space ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRuntimePlatform_TypeID = -1;
		int UnityEngineRuntimePlatform_EnumRef = -1;
        
        public void PushUnityEngineRuntimePlatform(RealStatePtr L, UnityEngine.RuntimePlatform val)
        {
            if (UnityEngineRuntimePlatform_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRuntimePlatform_TypeID = getTypeId(L, typeof(UnityEngine.RuntimePlatform), out is_first);
				
				if (UnityEngineRuntimePlatform_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RuntimePlatform));
				    UnityEngineRuntimePlatform_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRuntimePlatform_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRuntimePlatform_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RuntimePlatform ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRuntimePlatform_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RuntimePlatform val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRuntimePlatform_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RuntimePlatform");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RuntimePlatform");
                }
				val = (UnityEngine.RuntimePlatform)e;
                
            }
            else
            {
                val = (UnityEngine.RuntimePlatform)objectCasters.GetCaster(typeof(UnityEngine.RuntimePlatform))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRuntimePlatform(RealStatePtr L, int index, UnityEngine.RuntimePlatform val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRuntimePlatform_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RuntimePlatform");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RuntimePlatform ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSystemLanguage_TypeID = -1;
		int UnityEngineSystemLanguage_EnumRef = -1;
        
        public void PushUnityEngineSystemLanguage(RealStatePtr L, UnityEngine.SystemLanguage val)
        {
            if (UnityEngineSystemLanguage_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSystemLanguage_TypeID = getTypeId(L, typeof(UnityEngine.SystemLanguage), out is_first);
				
				if (UnityEngineSystemLanguage_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SystemLanguage));
				    UnityEngineSystemLanguage_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSystemLanguage_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSystemLanguage_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SystemLanguage ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSystemLanguage_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SystemLanguage val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSystemLanguage_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SystemLanguage");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SystemLanguage");
                }
				val = (UnityEngine.SystemLanguage)e;
                
            }
            else
            {
                val = (UnityEngine.SystemLanguage)objectCasters.GetCaster(typeof(UnityEngine.SystemLanguage))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSystemLanguage(RealStatePtr L, int index, UnityEngine.SystemLanguage val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSystemLanguage_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SystemLanguage");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SystemLanguage ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineLogType_TypeID = -1;
		int UnityEngineLogType_EnumRef = -1;
        
        public void PushUnityEngineLogType(RealStatePtr L, UnityEngine.LogType val)
        {
            if (UnityEngineLogType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineLogType_TypeID = getTypeId(L, typeof(UnityEngine.LogType), out is_first);
				
				if (UnityEngineLogType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.LogType));
				    UnityEngineLogType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineLogType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineLogType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.LogType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineLogType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.LogType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLogType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LogType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.LogType");
                }
				val = (UnityEngine.LogType)e;
                
            }
            else
            {
                val = (UnityEngine.LogType)objectCasters.GetCaster(typeof(UnityEngine.LogType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineLogType(RealStatePtr L, int index, UnityEngine.LogType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLogType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LogType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.LogType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineLogOption_TypeID = -1;
		int UnityEngineLogOption_EnumRef = -1;
        
        public void PushUnityEngineLogOption(RealStatePtr L, UnityEngine.LogOption val)
        {
            if (UnityEngineLogOption_TypeID == -1)
            {
			    bool is_first;
                UnityEngineLogOption_TypeID = getTypeId(L, typeof(UnityEngine.LogOption), out is_first);
				
				if (UnityEngineLogOption_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.LogOption));
				    UnityEngineLogOption_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineLogOption_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineLogOption_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.LogOption ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineLogOption_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.LogOption val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLogOption_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LogOption");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.LogOption");
                }
				val = (UnityEngine.LogOption)e;
                
            }
            else
            {
                val = (UnityEngine.LogOption)objectCasters.GetCaster(typeof(UnityEngine.LogOption))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineLogOption(RealStatePtr L, int index, UnityEngine.LogOption val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLogOption_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LogOption");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.LogOption ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineThreadPriority_TypeID = -1;
		int UnityEngineThreadPriority_EnumRef = -1;
        
        public void PushUnityEngineThreadPriority(RealStatePtr L, UnityEngine.ThreadPriority val)
        {
            if (UnityEngineThreadPriority_TypeID == -1)
            {
			    bool is_first;
                UnityEngineThreadPriority_TypeID = getTypeId(L, typeof(UnityEngine.ThreadPriority), out is_first);
				
				if (UnityEngineThreadPriority_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ThreadPriority));
				    UnityEngineThreadPriority_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineThreadPriority_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineThreadPriority_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ThreadPriority ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineThreadPriority_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ThreadPriority val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineThreadPriority_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ThreadPriority");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ThreadPriority");
                }
				val = (UnityEngine.ThreadPriority)e;
                
            }
            else
            {
                val = (UnityEngine.ThreadPriority)objectCasters.GetCaster(typeof(UnityEngine.ThreadPriority))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineThreadPriority(RealStatePtr L, int index, UnityEngine.ThreadPriority val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineThreadPriority_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ThreadPriority");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ThreadPriority ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineWeightedMode_TypeID = -1;
		int UnityEngineWeightedMode_EnumRef = -1;
        
        public void PushUnityEngineWeightedMode(RealStatePtr L, UnityEngine.WeightedMode val)
        {
            if (UnityEngineWeightedMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineWeightedMode_TypeID = getTypeId(L, typeof(UnityEngine.WeightedMode), out is_first);
				
				if (UnityEngineWeightedMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.WeightedMode));
				    UnityEngineWeightedMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineWeightedMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineWeightedMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.WeightedMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineWeightedMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.WeightedMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWeightedMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WeightedMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.WeightedMode");
                }
				val = (UnityEngine.WeightedMode)e;
                
            }
            else
            {
                val = (UnityEngine.WeightedMode)objectCasters.GetCaster(typeof(UnityEngine.WeightedMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineWeightedMode(RealStatePtr L, int index, UnityEngine.WeightedMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWeightedMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WeightedMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.WeightedMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineWrapMode_TypeID = -1;
		int UnityEngineWrapMode_EnumRef = -1;
        
        public void PushUnityEngineWrapMode(RealStatePtr L, UnityEngine.WrapMode val)
        {
            if (UnityEngineWrapMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineWrapMode_TypeID = getTypeId(L, typeof(UnityEngine.WrapMode), out is_first);
				
				if (UnityEngineWrapMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.WrapMode));
				    UnityEngineWrapMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineWrapMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineWrapMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.WrapMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineWrapMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.WrapMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.WrapMode");
                }
				val = (UnityEngine.WrapMode)e;
                
            }
            else
            {
                val = (UnityEngine.WrapMode)objectCasters.GetCaster(typeof(UnityEngine.WrapMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineWrapMode(RealStatePtr L, int index, UnityEngine.WrapMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.WrapMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineStackTraceLogType_TypeID = -1;
		int UnityEngineStackTraceLogType_EnumRef = -1;
        
        public void PushUnityEngineStackTraceLogType(RealStatePtr L, UnityEngine.StackTraceLogType val)
        {
            if (UnityEngineStackTraceLogType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineStackTraceLogType_TypeID = getTypeId(L, typeof(UnityEngine.StackTraceLogType), out is_first);
				
				if (UnityEngineStackTraceLogType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.StackTraceLogType));
				    UnityEngineStackTraceLogType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineStackTraceLogType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineStackTraceLogType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.StackTraceLogType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineStackTraceLogType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.StackTraceLogType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineStackTraceLogType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.StackTraceLogType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.StackTraceLogType");
                }
				val = (UnityEngine.StackTraceLogType)e;
                
            }
            else
            {
                val = (UnityEngine.StackTraceLogType)objectCasters.GetCaster(typeof(UnityEngine.StackTraceLogType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineStackTraceLogType(RealStatePtr L, int index, UnityEngine.StackTraceLogType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineStackTraceLogType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.StackTraceLogType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.StackTraceLogType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUserAuthorization_TypeID = -1;
		int UnityEngineUserAuthorization_EnumRef = -1;
        
        public void PushUnityEngineUserAuthorization(RealStatePtr L, UnityEngine.UserAuthorization val)
        {
            if (UnityEngineUserAuthorization_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUserAuthorization_TypeID = getTypeId(L, typeof(UnityEngine.UserAuthorization), out is_first);
				
				if (UnityEngineUserAuthorization_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UserAuthorization));
				    UnityEngineUserAuthorization_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUserAuthorization_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUserAuthorization_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UserAuthorization ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUserAuthorization_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UserAuthorization val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUserAuthorization_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UserAuthorization");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UserAuthorization");
                }
				val = (UnityEngine.UserAuthorization)e;
                
            }
            else
            {
                val = (UnityEngine.UserAuthorization)objectCasters.GetCaster(typeof(UnityEngine.UserAuthorization))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUserAuthorization(RealStatePtr L, int index, UnityEngine.UserAuthorization val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUserAuthorization_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UserAuthorization");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UserAuthorization ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineApplicationInstallMode_TypeID = -1;
		int UnityEngineApplicationInstallMode_EnumRef = -1;
        
        public void PushUnityEngineApplicationInstallMode(RealStatePtr L, UnityEngine.ApplicationInstallMode val)
        {
            if (UnityEngineApplicationInstallMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineApplicationInstallMode_TypeID = getTypeId(L, typeof(UnityEngine.ApplicationInstallMode), out is_first);
				
				if (UnityEngineApplicationInstallMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ApplicationInstallMode));
				    UnityEngineApplicationInstallMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineApplicationInstallMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineApplicationInstallMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ApplicationInstallMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineApplicationInstallMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ApplicationInstallMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineApplicationInstallMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ApplicationInstallMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ApplicationInstallMode");
                }
				val = (UnityEngine.ApplicationInstallMode)e;
                
            }
            else
            {
                val = (UnityEngine.ApplicationInstallMode)objectCasters.GetCaster(typeof(UnityEngine.ApplicationInstallMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineApplicationInstallMode(RealStatePtr L, int index, UnityEngine.ApplicationInstallMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineApplicationInstallMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ApplicationInstallMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ApplicationInstallMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineApplicationSandboxType_TypeID = -1;
		int UnityEngineApplicationSandboxType_EnumRef = -1;
        
        public void PushUnityEngineApplicationSandboxType(RealStatePtr L, UnityEngine.ApplicationSandboxType val)
        {
            if (UnityEngineApplicationSandboxType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineApplicationSandboxType_TypeID = getTypeId(L, typeof(UnityEngine.ApplicationSandboxType), out is_first);
				
				if (UnityEngineApplicationSandboxType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ApplicationSandboxType));
				    UnityEngineApplicationSandboxType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineApplicationSandboxType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineApplicationSandboxType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ApplicationSandboxType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineApplicationSandboxType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ApplicationSandboxType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineApplicationSandboxType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ApplicationSandboxType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ApplicationSandboxType");
                }
				val = (UnityEngine.ApplicationSandboxType)e;
                
            }
            else
            {
                val = (UnityEngine.ApplicationSandboxType)objectCasters.GetCaster(typeof(UnityEngine.ApplicationSandboxType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineApplicationSandboxType(RealStatePtr L, int index, UnityEngine.ApplicationSandboxType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineApplicationSandboxType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ApplicationSandboxType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ApplicationSandboxType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAudioType_TypeID = -1;
		int UnityEngineAudioType_EnumRef = -1;
        
        public void PushUnityEngineAudioType(RealStatePtr L, UnityEngine.AudioType val)
        {
            if (UnityEngineAudioType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAudioType_TypeID = getTypeId(L, typeof(UnityEngine.AudioType), out is_first);
				
				if (UnityEngineAudioType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AudioType));
				    UnityEngineAudioType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAudioType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAudioType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AudioType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAudioType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AudioType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AudioType");
                }
				val = (UnityEngine.AudioType)e;
                
            }
            else
            {
                val = (UnityEngine.AudioType)objectCasters.GetCaster(typeof(UnityEngine.AudioType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAudioType(RealStatePtr L, int index, UnityEngine.AudioType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAudioType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AudioType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AudioType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCameraGateFitMode_TypeID = -1;
		int UnityEngineCameraGateFitMode_EnumRef = -1;
        
        public void PushUnityEngineCameraGateFitMode(RealStatePtr L, UnityEngine.Camera.GateFitMode val)
        {
            if (UnityEngineCameraGateFitMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCameraGateFitMode_TypeID = getTypeId(L, typeof(UnityEngine.Camera.GateFitMode), out is_first);
				
				if (UnityEngineCameraGateFitMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.Camera.GateFitMode));
				    UnityEngineCameraGateFitMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCameraGateFitMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCameraGateFitMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.Camera.GateFitMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCameraGateFitMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Camera.GateFitMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraGateFitMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.GateFitMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.Camera.GateFitMode");
                }
				val = (UnityEngine.Camera.GateFitMode)e;
                
            }
            else
            {
                val = (UnityEngine.Camera.GateFitMode)objectCasters.GetCaster(typeof(UnityEngine.Camera.GateFitMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCameraGateFitMode(RealStatePtr L, int index, UnityEngine.Camera.GateFitMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraGateFitMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.GateFitMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.Camera.GateFitMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCameraFieldOfViewAxis_TypeID = -1;
		int UnityEngineCameraFieldOfViewAxis_EnumRef = -1;
        
        public void PushUnityEngineCameraFieldOfViewAxis(RealStatePtr L, UnityEngine.Camera.FieldOfViewAxis val)
        {
            if (UnityEngineCameraFieldOfViewAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCameraFieldOfViewAxis_TypeID = getTypeId(L, typeof(UnityEngine.Camera.FieldOfViewAxis), out is_first);
				
				if (UnityEngineCameraFieldOfViewAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.Camera.FieldOfViewAxis));
				    UnityEngineCameraFieldOfViewAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCameraFieldOfViewAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCameraFieldOfViewAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.Camera.FieldOfViewAxis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCameraFieldOfViewAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Camera.FieldOfViewAxis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraFieldOfViewAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.FieldOfViewAxis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.Camera.FieldOfViewAxis");
                }
				val = (UnityEngine.Camera.FieldOfViewAxis)e;
                
            }
            else
            {
                val = (UnityEngine.Camera.FieldOfViewAxis)objectCasters.GetCaster(typeof(UnityEngine.Camera.FieldOfViewAxis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCameraFieldOfViewAxis(RealStatePtr L, int index, UnityEngine.Camera.FieldOfViewAxis val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraFieldOfViewAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.FieldOfViewAxis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.Camera.FieldOfViewAxis ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCameraStereoscopicEye_TypeID = -1;
		int UnityEngineCameraStereoscopicEye_EnumRef = -1;
        
        public void PushUnityEngineCameraStereoscopicEye(RealStatePtr L, UnityEngine.Camera.StereoscopicEye val)
        {
            if (UnityEngineCameraStereoscopicEye_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCameraStereoscopicEye_TypeID = getTypeId(L, typeof(UnityEngine.Camera.StereoscopicEye), out is_first);
				
				if (UnityEngineCameraStereoscopicEye_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.Camera.StereoscopicEye));
				    UnityEngineCameraStereoscopicEye_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCameraStereoscopicEye_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCameraStereoscopicEye_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.Camera.StereoscopicEye ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCameraStereoscopicEye_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Camera.StereoscopicEye val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraStereoscopicEye_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.StereoscopicEye");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.Camera.StereoscopicEye");
                }
				val = (UnityEngine.Camera.StereoscopicEye)e;
                
            }
            else
            {
                val = (UnityEngine.Camera.StereoscopicEye)objectCasters.GetCaster(typeof(UnityEngine.Camera.StereoscopicEye))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCameraStereoscopicEye(RealStatePtr L, int index, UnityEngine.Camera.StereoscopicEye val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraStereoscopicEye_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.StereoscopicEye");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.Camera.StereoscopicEye ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCameraMonoOrStereoscopicEye_TypeID = -1;
		int UnityEngineCameraMonoOrStereoscopicEye_EnumRef = -1;
        
        public void PushUnityEngineCameraMonoOrStereoscopicEye(RealStatePtr L, UnityEngine.Camera.MonoOrStereoscopicEye val)
        {
            if (UnityEngineCameraMonoOrStereoscopicEye_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCameraMonoOrStereoscopicEye_TypeID = getTypeId(L, typeof(UnityEngine.Camera.MonoOrStereoscopicEye), out is_first);
				
				if (UnityEngineCameraMonoOrStereoscopicEye_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.Camera.MonoOrStereoscopicEye));
				    UnityEngineCameraMonoOrStereoscopicEye_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCameraMonoOrStereoscopicEye_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCameraMonoOrStereoscopicEye_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.Camera.MonoOrStereoscopicEye ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCameraMonoOrStereoscopicEye_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Camera.MonoOrStereoscopicEye val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraMonoOrStereoscopicEye_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.MonoOrStereoscopicEye");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.Camera.MonoOrStereoscopicEye");
                }
				val = (UnityEngine.Camera.MonoOrStereoscopicEye)e;
                
            }
            else
            {
                val = (UnityEngine.Camera.MonoOrStereoscopicEye)objectCasters.GetCaster(typeof(UnityEngine.Camera.MonoOrStereoscopicEye))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCameraMonoOrStereoscopicEye(RealStatePtr L, int index, UnityEngine.Camera.MonoOrStereoscopicEye val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraMonoOrStereoscopicEye_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Camera.MonoOrStereoscopicEye");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.Camera.MonoOrStereoscopicEye ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineReflectionProbeReflectionProbeEvent_TypeID = -1;
		int UnityEngineReflectionProbeReflectionProbeEvent_EnumRef = -1;
        
        public void PushUnityEngineReflectionProbeReflectionProbeEvent(RealStatePtr L, UnityEngine.ReflectionProbe.ReflectionProbeEvent val)
        {
            if (UnityEngineReflectionProbeReflectionProbeEvent_TypeID == -1)
            {
			    bool is_first;
                UnityEngineReflectionProbeReflectionProbeEvent_TypeID = getTypeId(L, typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent), out is_first);
				
				if (UnityEngineReflectionProbeReflectionProbeEvent_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent));
				    UnityEngineReflectionProbeReflectionProbeEvent_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineReflectionProbeReflectionProbeEvent_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineReflectionProbeReflectionProbeEvent_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ReflectionProbe.ReflectionProbeEvent ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineReflectionProbeReflectionProbeEvent_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ReflectionProbe.ReflectionProbeEvent val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineReflectionProbeReflectionProbeEvent_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ReflectionProbe.ReflectionProbeEvent");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ReflectionProbe.ReflectionProbeEvent");
                }
				val = (UnityEngine.ReflectionProbe.ReflectionProbeEvent)e;
                
            }
            else
            {
                val = (UnityEngine.ReflectionProbe.ReflectionProbeEvent)objectCasters.GetCaster(typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineReflectionProbeReflectionProbeEvent(RealStatePtr L, int index, UnityEngine.ReflectionProbe.ReflectionProbeEvent val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineReflectionProbeReflectionProbeEvent_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ReflectionProbe.ReflectionProbeEvent");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ReflectionProbe.ReflectionProbeEvent ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineFullScreenMode_TypeID = -1;
		int UnityEngineFullScreenMode_EnumRef = -1;
        
        public void PushUnityEngineFullScreenMode(RealStatePtr L, UnityEngine.FullScreenMode val)
        {
            if (UnityEngineFullScreenMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineFullScreenMode_TypeID = getTypeId(L, typeof(UnityEngine.FullScreenMode), out is_first);
				
				if (UnityEngineFullScreenMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.FullScreenMode));
				    UnityEngineFullScreenMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineFullScreenMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineFullScreenMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.FullScreenMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineFullScreenMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.FullScreenMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFullScreenMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FullScreenMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.FullScreenMode");
                }
				val = (UnityEngine.FullScreenMode)e;
                
            }
            else
            {
                val = (UnityEngine.FullScreenMode)objectCasters.GetCaster(typeof(UnityEngine.FullScreenMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineFullScreenMode(RealStatePtr L, int index, UnityEngine.FullScreenMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFullScreenMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FullScreenMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.FullScreenMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineComputeBufferMode_TypeID = -1;
		int UnityEngineComputeBufferMode_EnumRef = -1;
        
        public void PushUnityEngineComputeBufferMode(RealStatePtr L, UnityEngine.ComputeBufferMode val)
        {
            if (UnityEngineComputeBufferMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineComputeBufferMode_TypeID = getTypeId(L, typeof(UnityEngine.ComputeBufferMode), out is_first);
				
				if (UnityEngineComputeBufferMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ComputeBufferMode));
				    UnityEngineComputeBufferMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineComputeBufferMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineComputeBufferMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ComputeBufferMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineComputeBufferMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ComputeBufferMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineComputeBufferMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ComputeBufferMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ComputeBufferMode");
                }
				val = (UnityEngine.ComputeBufferMode)e;
                
            }
            else
            {
                val = (UnityEngine.ComputeBufferMode)objectCasters.GetCaster(typeof(UnityEngine.ComputeBufferMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineComputeBufferMode(RealStatePtr L, int index, UnityEngine.ComputeBufferMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineComputeBufferMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ComputeBufferMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ComputeBufferMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineD3DHDRDisplayBitDepth_TypeID = -1;
		int UnityEngineD3DHDRDisplayBitDepth_EnumRef = -1;
        
        public void PushUnityEngineD3DHDRDisplayBitDepth(RealStatePtr L, UnityEngine.D3DHDRDisplayBitDepth val)
        {
            if (UnityEngineD3DHDRDisplayBitDepth_TypeID == -1)
            {
			    bool is_first;
                UnityEngineD3DHDRDisplayBitDepth_TypeID = getTypeId(L, typeof(UnityEngine.D3DHDRDisplayBitDepth), out is_first);
				
				if (UnityEngineD3DHDRDisplayBitDepth_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.D3DHDRDisplayBitDepth));
				    UnityEngineD3DHDRDisplayBitDepth_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineD3DHDRDisplayBitDepth_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineD3DHDRDisplayBitDepth_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.D3DHDRDisplayBitDepth ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineD3DHDRDisplayBitDepth_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.D3DHDRDisplayBitDepth val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineD3DHDRDisplayBitDepth_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.D3DHDRDisplayBitDepth");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.D3DHDRDisplayBitDepth");
                }
				val = (UnityEngine.D3DHDRDisplayBitDepth)e;
                
            }
            else
            {
                val = (UnityEngine.D3DHDRDisplayBitDepth)objectCasters.GetCaster(typeof(UnityEngine.D3DHDRDisplayBitDepth))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineD3DHDRDisplayBitDepth(RealStatePtr L, int index, UnityEngine.D3DHDRDisplayBitDepth val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineD3DHDRDisplayBitDepth_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.D3DHDRDisplayBitDepth");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.D3DHDRDisplayBitDepth ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRenderingPath_TypeID = -1;
		int UnityEngineRenderingPath_EnumRef = -1;
        
        public void PushUnityEngineRenderingPath(RealStatePtr L, UnityEngine.RenderingPath val)
        {
            if (UnityEngineRenderingPath_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRenderingPath_TypeID = getTypeId(L, typeof(UnityEngine.RenderingPath), out is_first);
				
				if (UnityEngineRenderingPath_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RenderingPath));
				    UnityEngineRenderingPath_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRenderingPath_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRenderingPath_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RenderingPath ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRenderingPath_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RenderingPath val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderingPath_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderingPath");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RenderingPath");
                }
				val = (UnityEngine.RenderingPath)e;
                
            }
            else
            {
                val = (UnityEngine.RenderingPath)objectCasters.GetCaster(typeof(UnityEngine.RenderingPath))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRenderingPath(RealStatePtr L, int index, UnityEngine.RenderingPath val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderingPath_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderingPath");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RenderingPath ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTransparencySortMode_TypeID = -1;
		int UnityEngineTransparencySortMode_EnumRef = -1;
        
        public void PushUnityEngineTransparencySortMode(RealStatePtr L, UnityEngine.TransparencySortMode val)
        {
            if (UnityEngineTransparencySortMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTransparencySortMode_TypeID = getTypeId(L, typeof(UnityEngine.TransparencySortMode), out is_first);
				
				if (UnityEngineTransparencySortMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TransparencySortMode));
				    UnityEngineTransparencySortMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTransparencySortMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTransparencySortMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TransparencySortMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTransparencySortMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TransparencySortMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTransparencySortMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TransparencySortMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TransparencySortMode");
                }
				val = (UnityEngine.TransparencySortMode)e;
                
            }
            else
            {
                val = (UnityEngine.TransparencySortMode)objectCasters.GetCaster(typeof(UnityEngine.TransparencySortMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTransparencySortMode(RealStatePtr L, int index, UnityEngine.TransparencySortMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTransparencySortMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TransparencySortMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TransparencySortMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineStereoTargetEyeMask_TypeID = -1;
		int UnityEngineStereoTargetEyeMask_EnumRef = -1;
        
        public void PushUnityEngineStereoTargetEyeMask(RealStatePtr L, UnityEngine.StereoTargetEyeMask val)
        {
            if (UnityEngineStereoTargetEyeMask_TypeID == -1)
            {
			    bool is_first;
                UnityEngineStereoTargetEyeMask_TypeID = getTypeId(L, typeof(UnityEngine.StereoTargetEyeMask), out is_first);
				
				if (UnityEngineStereoTargetEyeMask_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.StereoTargetEyeMask));
				    UnityEngineStereoTargetEyeMask_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineStereoTargetEyeMask_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineStereoTargetEyeMask_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.StereoTargetEyeMask ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineStereoTargetEyeMask_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.StereoTargetEyeMask val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineStereoTargetEyeMask_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.StereoTargetEyeMask");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.StereoTargetEyeMask");
                }
				val = (UnityEngine.StereoTargetEyeMask)e;
                
            }
            else
            {
                val = (UnityEngine.StereoTargetEyeMask)objectCasters.GetCaster(typeof(UnityEngine.StereoTargetEyeMask))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineStereoTargetEyeMask(RealStatePtr L, int index, UnityEngine.StereoTargetEyeMask val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineStereoTargetEyeMask_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.StereoTargetEyeMask");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.StereoTargetEyeMask ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCameraType_TypeID = -1;
		int UnityEngineCameraType_EnumRef = -1;
        
        public void PushUnityEngineCameraType(RealStatePtr L, UnityEngine.CameraType val)
        {
            if (UnityEngineCameraType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCameraType_TypeID = getTypeId(L, typeof(UnityEngine.CameraType), out is_first);
				
				if (UnityEngineCameraType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CameraType));
				    UnityEngineCameraType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCameraType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCameraType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CameraType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCameraType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CameraType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CameraType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CameraType");
                }
				val = (UnityEngine.CameraType)e;
                
            }
            else
            {
                val = (UnityEngine.CameraType)objectCasters.GetCaster(typeof(UnityEngine.CameraType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCameraType(RealStatePtr L, int index, UnityEngine.CameraType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CameraType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CameraType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineComputeBufferType_TypeID = -1;
		int UnityEngineComputeBufferType_EnumRef = -1;
        
        public void PushUnityEngineComputeBufferType(RealStatePtr L, UnityEngine.ComputeBufferType val)
        {
            if (UnityEngineComputeBufferType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineComputeBufferType_TypeID = getTypeId(L, typeof(UnityEngine.ComputeBufferType), out is_first);
				
				if (UnityEngineComputeBufferType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ComputeBufferType));
				    UnityEngineComputeBufferType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineComputeBufferType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineComputeBufferType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ComputeBufferType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineComputeBufferType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ComputeBufferType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineComputeBufferType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ComputeBufferType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ComputeBufferType");
                }
				val = (UnityEngine.ComputeBufferType)e;
                
            }
            else
            {
                val = (UnityEngine.ComputeBufferType)objectCasters.GetCaster(typeof(UnityEngine.ComputeBufferType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineComputeBufferType(RealStatePtr L, int index, UnityEngine.ComputeBufferType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineComputeBufferType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ComputeBufferType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ComputeBufferType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineFogMode_TypeID = -1;
		int UnityEngineFogMode_EnumRef = -1;
        
        public void PushUnityEngineFogMode(RealStatePtr L, UnityEngine.FogMode val)
        {
            if (UnityEngineFogMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineFogMode_TypeID = getTypeId(L, typeof(UnityEngine.FogMode), out is_first);
				
				if (UnityEngineFogMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.FogMode));
				    UnityEngineFogMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineFogMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineFogMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.FogMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineFogMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.FogMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFogMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FogMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.FogMode");
                }
				val = (UnityEngine.FogMode)e;
                
            }
            else
            {
                val = (UnityEngine.FogMode)objectCasters.GetCaster(typeof(UnityEngine.FogMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineFogMode(RealStatePtr L, int index, UnityEngine.FogMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFogMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FogMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.FogMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineReceiveGI_TypeID = -1;
		int UnityEngineReceiveGI_EnumRef = -1;
        
        public void PushUnityEngineReceiveGI(RealStatePtr L, UnityEngine.ReceiveGI val)
        {
            if (UnityEngineReceiveGI_TypeID == -1)
            {
			    bool is_first;
                UnityEngineReceiveGI_TypeID = getTypeId(L, typeof(UnityEngine.ReceiveGI), out is_first);
				
				if (UnityEngineReceiveGI_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ReceiveGI));
				    UnityEngineReceiveGI_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineReceiveGI_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineReceiveGI_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ReceiveGI ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineReceiveGI_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ReceiveGI val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineReceiveGI_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ReceiveGI");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ReceiveGI");
                }
				val = (UnityEngine.ReceiveGI)e;
                
            }
            else
            {
                val = (UnityEngine.ReceiveGI)objectCasters.GetCaster(typeof(UnityEngine.ReceiveGI))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineReceiveGI(RealStatePtr L, int index, UnityEngine.ReceiveGI val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineReceiveGI_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ReceiveGI");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ReceiveGI ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineShadowProjection_TypeID = -1;
		int UnityEngineShadowProjection_EnumRef = -1;
        
        public void PushUnityEngineShadowProjection(RealStatePtr L, UnityEngine.ShadowProjection val)
        {
            if (UnityEngineShadowProjection_TypeID == -1)
            {
			    bool is_first;
                UnityEngineShadowProjection_TypeID = getTypeId(L, typeof(UnityEngine.ShadowProjection), out is_first);
				
				if (UnityEngineShadowProjection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ShadowProjection));
				    UnityEngineShadowProjection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineShadowProjection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineShadowProjection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ShadowProjection ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineShadowProjection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ShadowProjection val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowProjection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowProjection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ShadowProjection");
                }
				val = (UnityEngine.ShadowProjection)e;
                
            }
            else
            {
                val = (UnityEngine.ShadowProjection)objectCasters.GetCaster(typeof(UnityEngine.ShadowProjection))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineShadowProjection(RealStatePtr L, int index, UnityEngine.ShadowProjection val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowProjection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowProjection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ShadowProjection ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineShadowQuality_TypeID = -1;
		int UnityEngineShadowQuality_EnumRef = -1;
        
        public void PushUnityEngineShadowQuality(RealStatePtr L, UnityEngine.ShadowQuality val)
        {
            if (UnityEngineShadowQuality_TypeID == -1)
            {
			    bool is_first;
                UnityEngineShadowQuality_TypeID = getTypeId(L, typeof(UnityEngine.ShadowQuality), out is_first);
				
				if (UnityEngineShadowQuality_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ShadowQuality));
				    UnityEngineShadowQuality_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineShadowQuality_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineShadowQuality_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ShadowQuality ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineShadowQuality_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ShadowQuality val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowQuality_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowQuality");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ShadowQuality");
                }
				val = (UnityEngine.ShadowQuality)e;
                
            }
            else
            {
                val = (UnityEngine.ShadowQuality)objectCasters.GetCaster(typeof(UnityEngine.ShadowQuality))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineShadowQuality(RealStatePtr L, int index, UnityEngine.ShadowQuality val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowQuality_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowQuality");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ShadowQuality ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineShadowResolution_TypeID = -1;
		int UnityEngineShadowResolution_EnumRef = -1;
        
        public void PushUnityEngineShadowResolution(RealStatePtr L, UnityEngine.ShadowResolution val)
        {
            if (UnityEngineShadowResolution_TypeID == -1)
            {
			    bool is_first;
                UnityEngineShadowResolution_TypeID = getTypeId(L, typeof(UnityEngine.ShadowResolution), out is_first);
				
				if (UnityEngineShadowResolution_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ShadowResolution));
				    UnityEngineShadowResolution_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineShadowResolution_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineShadowResolution_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ShadowResolution ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineShadowResolution_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ShadowResolution val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowResolution_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowResolution");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ShadowResolution");
                }
				val = (UnityEngine.ShadowResolution)e;
                
            }
            else
            {
                val = (UnityEngine.ShadowResolution)objectCasters.GetCaster(typeof(UnityEngine.ShadowResolution))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineShadowResolution(RealStatePtr L, int index, UnityEngine.ShadowResolution val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowResolution_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowResolution");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ShadowResolution ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineShadowmaskMode_TypeID = -1;
		int UnityEngineShadowmaskMode_EnumRef = -1;
        
        public void PushUnityEngineShadowmaskMode(RealStatePtr L, UnityEngine.ShadowmaskMode val)
        {
            if (UnityEngineShadowmaskMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineShadowmaskMode_TypeID = getTypeId(L, typeof(UnityEngine.ShadowmaskMode), out is_first);
				
				if (UnityEngineShadowmaskMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ShadowmaskMode));
				    UnityEngineShadowmaskMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineShadowmaskMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineShadowmaskMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ShadowmaskMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineShadowmaskMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ShadowmaskMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowmaskMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowmaskMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ShadowmaskMode");
                }
				val = (UnityEngine.ShadowmaskMode)e;
                
            }
            else
            {
                val = (UnityEngine.ShadowmaskMode)objectCasters.GetCaster(typeof(UnityEngine.ShadowmaskMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineShadowmaskMode(RealStatePtr L, int index, UnityEngine.ShadowmaskMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineShadowmaskMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ShadowmaskMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ShadowmaskMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCameraClearFlags_TypeID = -1;
		int UnityEngineCameraClearFlags_EnumRef = -1;
        
        public void PushUnityEngineCameraClearFlags(RealStatePtr L, UnityEngine.CameraClearFlags val)
        {
            if (UnityEngineCameraClearFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCameraClearFlags_TypeID = getTypeId(L, typeof(UnityEngine.CameraClearFlags), out is_first);
				
				if (UnityEngineCameraClearFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CameraClearFlags));
				    UnityEngineCameraClearFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCameraClearFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCameraClearFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CameraClearFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCameraClearFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CameraClearFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraClearFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CameraClearFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CameraClearFlags");
                }
				val = (UnityEngine.CameraClearFlags)e;
                
            }
            else
            {
                val = (UnityEngine.CameraClearFlags)objectCasters.GetCaster(typeof(UnityEngine.CameraClearFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCameraClearFlags(RealStatePtr L, int index, UnityEngine.CameraClearFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCameraClearFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CameraClearFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CameraClearFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineDepthTextureMode_TypeID = -1;
		int UnityEngineDepthTextureMode_EnumRef = -1;
        
        public void PushUnityEngineDepthTextureMode(RealStatePtr L, UnityEngine.DepthTextureMode val)
        {
            if (UnityEngineDepthTextureMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineDepthTextureMode_TypeID = getTypeId(L, typeof(UnityEngine.DepthTextureMode), out is_first);
				
				if (UnityEngineDepthTextureMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.DepthTextureMode));
				    UnityEngineDepthTextureMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineDepthTextureMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineDepthTextureMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.DepthTextureMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineDepthTextureMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.DepthTextureMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDepthTextureMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DepthTextureMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.DepthTextureMode");
                }
				val = (UnityEngine.DepthTextureMode)e;
                
            }
            else
            {
                val = (UnityEngine.DepthTextureMode)objectCasters.GetCaster(typeof(UnityEngine.DepthTextureMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineDepthTextureMode(RealStatePtr L, int index, UnityEngine.DepthTextureMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDepthTextureMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DepthTextureMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.DepthTextureMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTexGenMode_TypeID = -1;
		int UnityEngineTexGenMode_EnumRef = -1;
        
        public void PushUnityEngineTexGenMode(RealStatePtr L, UnityEngine.TexGenMode val)
        {
            if (UnityEngineTexGenMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTexGenMode_TypeID = getTypeId(L, typeof(UnityEngine.TexGenMode), out is_first);
				
				if (UnityEngineTexGenMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TexGenMode));
				    UnityEngineTexGenMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTexGenMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTexGenMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TexGenMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTexGenMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TexGenMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTexGenMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TexGenMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TexGenMode");
                }
				val = (UnityEngine.TexGenMode)e;
                
            }
            else
            {
                val = (UnityEngine.TexGenMode)objectCasters.GetCaster(typeof(UnityEngine.TexGenMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTexGenMode(RealStatePtr L, int index, UnityEngine.TexGenMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTexGenMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TexGenMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TexGenMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAnisotropicFiltering_TypeID = -1;
		int UnityEngineAnisotropicFiltering_EnumRef = -1;
        
        public void PushUnityEngineAnisotropicFiltering(RealStatePtr L, UnityEngine.AnisotropicFiltering val)
        {
            if (UnityEngineAnisotropicFiltering_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAnisotropicFiltering_TypeID = getTypeId(L, typeof(UnityEngine.AnisotropicFiltering), out is_first);
				
				if (UnityEngineAnisotropicFiltering_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AnisotropicFiltering));
				    UnityEngineAnisotropicFiltering_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAnisotropicFiltering_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAnisotropicFiltering_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AnisotropicFiltering ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAnisotropicFiltering_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AnisotropicFiltering val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnisotropicFiltering_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnisotropicFiltering");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AnisotropicFiltering");
                }
				val = (UnityEngine.AnisotropicFiltering)e;
                
            }
            else
            {
                val = (UnityEngine.AnisotropicFiltering)objectCasters.GetCaster(typeof(UnityEngine.AnisotropicFiltering))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAnisotropicFiltering(RealStatePtr L, int index, UnityEngine.AnisotropicFiltering val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAnisotropicFiltering_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AnisotropicFiltering");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AnisotropicFiltering ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSkinWeights_TypeID = -1;
		int UnityEngineSkinWeights_EnumRef = -1;
        
        public void PushUnityEngineSkinWeights(RealStatePtr L, UnityEngine.SkinWeights val)
        {
            if (UnityEngineSkinWeights_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSkinWeights_TypeID = getTypeId(L, typeof(UnityEngine.SkinWeights), out is_first);
				
				if (UnityEngineSkinWeights_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SkinWeights));
				    UnityEngineSkinWeights_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSkinWeights_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSkinWeights_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SkinWeights ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSkinWeights_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SkinWeights val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSkinWeights_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SkinWeights");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SkinWeights");
                }
				val = (UnityEngine.SkinWeights)e;
                
            }
            else
            {
                val = (UnityEngine.SkinWeights)objectCasters.GetCaster(typeof(UnityEngine.SkinWeights))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSkinWeights(RealStatePtr L, int index, UnityEngine.SkinWeights val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSkinWeights_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SkinWeights");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SkinWeights ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineMeshTopology_TypeID = -1;
		int UnityEngineMeshTopology_EnumRef = -1;
        
        public void PushUnityEngineMeshTopology(RealStatePtr L, UnityEngine.MeshTopology val)
        {
            if (UnityEngineMeshTopology_TypeID == -1)
            {
			    bool is_first;
                UnityEngineMeshTopology_TypeID = getTypeId(L, typeof(UnityEngine.MeshTopology), out is_first);
				
				if (UnityEngineMeshTopology_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.MeshTopology));
				    UnityEngineMeshTopology_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineMeshTopology_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineMeshTopology_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.MeshTopology ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineMeshTopology_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.MeshTopology val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineMeshTopology_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.MeshTopology");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.MeshTopology");
                }
				val = (UnityEngine.MeshTopology)e;
                
            }
            else
            {
                val = (UnityEngine.MeshTopology)objectCasters.GetCaster(typeof(UnityEngine.MeshTopology))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineMeshTopology(RealStatePtr L, int index, UnityEngine.MeshTopology val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineMeshTopology_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.MeshTopology");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.MeshTopology ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSkinQuality_TypeID = -1;
		int UnityEngineSkinQuality_EnumRef = -1;
        
        public void PushUnityEngineSkinQuality(RealStatePtr L, UnityEngine.SkinQuality val)
        {
            if (UnityEngineSkinQuality_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSkinQuality_TypeID = getTypeId(L, typeof(UnityEngine.SkinQuality), out is_first);
				
				if (UnityEngineSkinQuality_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SkinQuality));
				    UnityEngineSkinQuality_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSkinQuality_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSkinQuality_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SkinQuality ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSkinQuality_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SkinQuality val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSkinQuality_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SkinQuality");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SkinQuality");
                }
				val = (UnityEngine.SkinQuality)e;
                
            }
            else
            {
                val = (UnityEngine.SkinQuality)objectCasters.GetCaster(typeof(UnityEngine.SkinQuality))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSkinQuality(RealStatePtr L, int index, UnityEngine.SkinQuality val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSkinQuality_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SkinQuality");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SkinQuality ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineColorSpace_TypeID = -1;
		int UnityEngineColorSpace_EnumRef = -1;
        
        public void PushUnityEngineColorSpace(RealStatePtr L, UnityEngine.ColorSpace val)
        {
            if (UnityEngineColorSpace_TypeID == -1)
            {
			    bool is_first;
                UnityEngineColorSpace_TypeID = getTypeId(L, typeof(UnityEngine.ColorSpace), out is_first);
				
				if (UnityEngineColorSpace_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ColorSpace));
				    UnityEngineColorSpace_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineColorSpace_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineColorSpace_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ColorSpace ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineColorSpace_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ColorSpace val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColorSpace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ColorSpace");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ColorSpace");
                }
				val = (UnityEngine.ColorSpace)e;
                
            }
            else
            {
                val = (UnityEngine.ColorSpace)objectCasters.GetCaster(typeof(UnityEngine.ColorSpace))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineColorSpace(RealStatePtr L, int index, UnityEngine.ColorSpace val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColorSpace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ColorSpace");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ColorSpace ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineColorGamut_TypeID = -1;
		int UnityEngineColorGamut_EnumRef = -1;
        
        public void PushUnityEngineColorGamut(RealStatePtr L, UnityEngine.ColorGamut val)
        {
            if (UnityEngineColorGamut_TypeID == -1)
            {
			    bool is_first;
                UnityEngineColorGamut_TypeID = getTypeId(L, typeof(UnityEngine.ColorGamut), out is_first);
				
				if (UnityEngineColorGamut_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ColorGamut));
				    UnityEngineColorGamut_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineColorGamut_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineColorGamut_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ColorGamut ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineColorGamut_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ColorGamut val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColorGamut_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ColorGamut");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ColorGamut");
                }
				val = (UnityEngine.ColorGamut)e;
                
            }
            else
            {
                val = (UnityEngine.ColorGamut)objectCasters.GetCaster(typeof(UnityEngine.ColorGamut))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineColorGamut(RealStatePtr L, int index, UnityEngine.ColorGamut val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColorGamut_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ColorGamut");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ColorGamut ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineScreenOrientation_TypeID = -1;
		int UnityEngineScreenOrientation_EnumRef = -1;
        
        public void PushUnityEngineScreenOrientation(RealStatePtr L, UnityEngine.ScreenOrientation val)
        {
            if (UnityEngineScreenOrientation_TypeID == -1)
            {
			    bool is_first;
                UnityEngineScreenOrientation_TypeID = getTypeId(L, typeof(UnityEngine.ScreenOrientation), out is_first);
				
				if (UnityEngineScreenOrientation_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ScreenOrientation));
				    UnityEngineScreenOrientation_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineScreenOrientation_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineScreenOrientation_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ScreenOrientation ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineScreenOrientation_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ScreenOrientation val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineScreenOrientation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ScreenOrientation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ScreenOrientation");
                }
				val = (UnityEngine.ScreenOrientation)e;
                
            }
            else
            {
                val = (UnityEngine.ScreenOrientation)objectCasters.GetCaster(typeof(UnityEngine.ScreenOrientation))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineScreenOrientation(RealStatePtr L, int index, UnityEngine.ScreenOrientation val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineScreenOrientation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ScreenOrientation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ScreenOrientation ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineFilterMode_TypeID = -1;
		int UnityEngineFilterMode_EnumRef = -1;
        
        public void PushUnityEngineFilterMode(RealStatePtr L, UnityEngine.FilterMode val)
        {
            if (UnityEngineFilterMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineFilterMode_TypeID = getTypeId(L, typeof(UnityEngine.FilterMode), out is_first);
				
				if (UnityEngineFilterMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.FilterMode));
				    UnityEngineFilterMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineFilterMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineFilterMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.FilterMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineFilterMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.FilterMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFilterMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FilterMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.FilterMode");
                }
				val = (UnityEngine.FilterMode)e;
                
            }
            else
            {
                val = (UnityEngine.FilterMode)objectCasters.GetCaster(typeof(UnityEngine.FilterMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineFilterMode(RealStatePtr L, int index, UnityEngine.FilterMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFilterMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FilterMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.FilterMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTextureWrapMode_TypeID = -1;
		int UnityEngineTextureWrapMode_EnumRef = -1;
        
        public void PushUnityEngineTextureWrapMode(RealStatePtr L, UnityEngine.TextureWrapMode val)
        {
            if (UnityEngineTextureWrapMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTextureWrapMode_TypeID = getTypeId(L, typeof(UnityEngine.TextureWrapMode), out is_first);
				
				if (UnityEngineTextureWrapMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TextureWrapMode));
				    UnityEngineTextureWrapMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTextureWrapMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTextureWrapMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TextureWrapMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTextureWrapMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TextureWrapMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextureWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextureWrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TextureWrapMode");
                }
				val = (UnityEngine.TextureWrapMode)e;
                
            }
            else
            {
                val = (UnityEngine.TextureWrapMode)objectCasters.GetCaster(typeof(UnityEngine.TextureWrapMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTextureWrapMode(RealStatePtr L, int index, UnityEngine.TextureWrapMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextureWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextureWrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TextureWrapMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineNPOTSupport_TypeID = -1;
		int UnityEngineNPOTSupport_EnumRef = -1;
        
        public void PushUnityEngineNPOTSupport(RealStatePtr L, UnityEngine.NPOTSupport val)
        {
            if (UnityEngineNPOTSupport_TypeID == -1)
            {
			    bool is_first;
                UnityEngineNPOTSupport_TypeID = getTypeId(L, typeof(UnityEngine.NPOTSupport), out is_first);
				
				if (UnityEngineNPOTSupport_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.NPOTSupport));
				    UnityEngineNPOTSupport_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineNPOTSupport_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineNPOTSupport_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.NPOTSupport ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineNPOTSupport_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.NPOTSupport val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineNPOTSupport_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.NPOTSupport");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.NPOTSupport");
                }
				val = (UnityEngine.NPOTSupport)e;
                
            }
            else
            {
                val = (UnityEngine.NPOTSupport)objectCasters.GetCaster(typeof(UnityEngine.NPOTSupport))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineNPOTSupport(RealStatePtr L, int index, UnityEngine.NPOTSupport val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineNPOTSupport_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.NPOTSupport");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.NPOTSupport ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTextureFormat_TypeID = -1;
		int UnityEngineTextureFormat_EnumRef = -1;
        
        public void PushUnityEngineTextureFormat(RealStatePtr L, UnityEngine.TextureFormat val)
        {
            if (UnityEngineTextureFormat_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTextureFormat_TypeID = getTypeId(L, typeof(UnityEngine.TextureFormat), out is_first);
				
				if (UnityEngineTextureFormat_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TextureFormat));
				    UnityEngineTextureFormat_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTextureFormat_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTextureFormat_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TextureFormat ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTextureFormat_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TextureFormat val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextureFormat_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextureFormat");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TextureFormat");
                }
				val = (UnityEngine.TextureFormat)e;
                
            }
            else
            {
                val = (UnityEngine.TextureFormat)objectCasters.GetCaster(typeof(UnityEngine.TextureFormat))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTextureFormat(RealStatePtr L, int index, UnityEngine.TextureFormat val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextureFormat_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextureFormat");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TextureFormat ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCubemapFace_TypeID = -1;
		int UnityEngineCubemapFace_EnumRef = -1;
        
        public void PushUnityEngineCubemapFace(RealStatePtr L, UnityEngine.CubemapFace val)
        {
            if (UnityEngineCubemapFace_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCubemapFace_TypeID = getTypeId(L, typeof(UnityEngine.CubemapFace), out is_first);
				
				if (UnityEngineCubemapFace_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CubemapFace));
				    UnityEngineCubemapFace_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCubemapFace_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCubemapFace_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CubemapFace ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCubemapFace_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CubemapFace val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCubemapFace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CubemapFace");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CubemapFace");
                }
				val = (UnityEngine.CubemapFace)e;
                
            }
            else
            {
                val = (UnityEngine.CubemapFace)objectCasters.GetCaster(typeof(UnityEngine.CubemapFace))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCubemapFace(RealStatePtr L, int index, UnityEngine.CubemapFace val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCubemapFace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CubemapFace");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CubemapFace ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRenderTextureFormat_TypeID = -1;
		int UnityEngineRenderTextureFormat_EnumRef = -1;
        
        public void PushUnityEngineRenderTextureFormat(RealStatePtr L, UnityEngine.RenderTextureFormat val)
        {
            if (UnityEngineRenderTextureFormat_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRenderTextureFormat_TypeID = getTypeId(L, typeof(UnityEngine.RenderTextureFormat), out is_first);
				
				if (UnityEngineRenderTextureFormat_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RenderTextureFormat));
				    UnityEngineRenderTextureFormat_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRenderTextureFormat_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRenderTextureFormat_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RenderTextureFormat ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRenderTextureFormat_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RenderTextureFormat val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureFormat_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureFormat");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RenderTextureFormat");
                }
				val = (UnityEngine.RenderTextureFormat)e;
                
            }
            else
            {
                val = (UnityEngine.RenderTextureFormat)objectCasters.GetCaster(typeof(UnityEngine.RenderTextureFormat))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRenderTextureFormat(RealStatePtr L, int index, UnityEngine.RenderTextureFormat val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureFormat_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureFormat");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RenderTextureFormat ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVRTextureUsage_TypeID = -1;
		int UnityEngineVRTextureUsage_EnumRef = -1;
        
        public void PushUnityEngineVRTextureUsage(RealStatePtr L, UnityEngine.VRTextureUsage val)
        {
            if (UnityEngineVRTextureUsage_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVRTextureUsage_TypeID = getTypeId(L, typeof(UnityEngine.VRTextureUsage), out is_first);
				
				if (UnityEngineVRTextureUsage_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.VRTextureUsage));
				    UnityEngineVRTextureUsage_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineVRTextureUsage_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineVRTextureUsage_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.VRTextureUsage ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineVRTextureUsage_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.VRTextureUsage val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVRTextureUsage_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.VRTextureUsage");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.VRTextureUsage");
                }
				val = (UnityEngine.VRTextureUsage)e;
                
            }
            else
            {
                val = (UnityEngine.VRTextureUsage)objectCasters.GetCaster(typeof(UnityEngine.VRTextureUsage))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVRTextureUsage(RealStatePtr L, int index, UnityEngine.VRTextureUsage val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVRTextureUsage_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.VRTextureUsage");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.VRTextureUsage ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRenderTextureCreationFlags_TypeID = -1;
		int UnityEngineRenderTextureCreationFlags_EnumRef = -1;
        
        public void PushUnityEngineRenderTextureCreationFlags(RealStatePtr L, UnityEngine.RenderTextureCreationFlags val)
        {
            if (UnityEngineRenderTextureCreationFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRenderTextureCreationFlags_TypeID = getTypeId(L, typeof(UnityEngine.RenderTextureCreationFlags), out is_first);
				
				if (UnityEngineRenderTextureCreationFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RenderTextureCreationFlags));
				    UnityEngineRenderTextureCreationFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRenderTextureCreationFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRenderTextureCreationFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RenderTextureCreationFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRenderTextureCreationFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RenderTextureCreationFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureCreationFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureCreationFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RenderTextureCreationFlags");
                }
				val = (UnityEngine.RenderTextureCreationFlags)e;
                
            }
            else
            {
                val = (UnityEngine.RenderTextureCreationFlags)objectCasters.GetCaster(typeof(UnityEngine.RenderTextureCreationFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRenderTextureCreationFlags(RealStatePtr L, int index, UnityEngine.RenderTextureCreationFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureCreationFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureCreationFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RenderTextureCreationFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRenderTextureReadWrite_TypeID = -1;
		int UnityEngineRenderTextureReadWrite_EnumRef = -1;
        
        public void PushUnityEngineRenderTextureReadWrite(RealStatePtr L, UnityEngine.RenderTextureReadWrite val)
        {
            if (UnityEngineRenderTextureReadWrite_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRenderTextureReadWrite_TypeID = getTypeId(L, typeof(UnityEngine.RenderTextureReadWrite), out is_first);
				
				if (UnityEngineRenderTextureReadWrite_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RenderTextureReadWrite));
				    UnityEngineRenderTextureReadWrite_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRenderTextureReadWrite_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRenderTextureReadWrite_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RenderTextureReadWrite ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRenderTextureReadWrite_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RenderTextureReadWrite val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureReadWrite_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureReadWrite");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RenderTextureReadWrite");
                }
				val = (UnityEngine.RenderTextureReadWrite)e;
                
            }
            else
            {
                val = (UnityEngine.RenderTextureReadWrite)objectCasters.GetCaster(typeof(UnityEngine.RenderTextureReadWrite))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRenderTextureReadWrite(RealStatePtr L, int index, UnityEngine.RenderTextureReadWrite val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureReadWrite_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureReadWrite");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RenderTextureReadWrite ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRenderTextureMemoryless_TypeID = -1;
		int UnityEngineRenderTextureMemoryless_EnumRef = -1;
        
        public void PushUnityEngineRenderTextureMemoryless(RealStatePtr L, UnityEngine.RenderTextureMemoryless val)
        {
            if (UnityEngineRenderTextureMemoryless_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRenderTextureMemoryless_TypeID = getTypeId(L, typeof(UnityEngine.RenderTextureMemoryless), out is_first);
				
				if (UnityEngineRenderTextureMemoryless_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RenderTextureMemoryless));
				    UnityEngineRenderTextureMemoryless_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRenderTextureMemoryless_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRenderTextureMemoryless_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RenderTextureMemoryless ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRenderTextureMemoryless_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RenderTextureMemoryless val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureMemoryless_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureMemoryless");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RenderTextureMemoryless");
                }
				val = (UnityEngine.RenderTextureMemoryless)e;
                
            }
            else
            {
                val = (UnityEngine.RenderTextureMemoryless)objectCasters.GetCaster(typeof(UnityEngine.RenderTextureMemoryless))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRenderTextureMemoryless(RealStatePtr L, int index, UnityEngine.RenderTextureMemoryless val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderTextureMemoryless_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderTextureMemoryless");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RenderTextureMemoryless ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineMaterialGlobalIlluminationFlags_TypeID = -1;
		int UnityEngineMaterialGlobalIlluminationFlags_EnumRef = -1;
        
        public void PushUnityEngineMaterialGlobalIlluminationFlags(RealStatePtr L, UnityEngine.MaterialGlobalIlluminationFlags val)
        {
            if (UnityEngineMaterialGlobalIlluminationFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineMaterialGlobalIlluminationFlags_TypeID = getTypeId(L, typeof(UnityEngine.MaterialGlobalIlluminationFlags), out is_first);
				
				if (UnityEngineMaterialGlobalIlluminationFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.MaterialGlobalIlluminationFlags));
				    UnityEngineMaterialGlobalIlluminationFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineMaterialGlobalIlluminationFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineMaterialGlobalIlluminationFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.MaterialGlobalIlluminationFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineMaterialGlobalIlluminationFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.MaterialGlobalIlluminationFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineMaterialGlobalIlluminationFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.MaterialGlobalIlluminationFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.MaterialGlobalIlluminationFlags");
                }
				val = (UnityEngine.MaterialGlobalIlluminationFlags)e;
                
            }
            else
            {
                val = (UnityEngine.MaterialGlobalIlluminationFlags)objectCasters.GetCaster(typeof(UnityEngine.MaterialGlobalIlluminationFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineMaterialGlobalIlluminationFlags(RealStatePtr L, int index, UnityEngine.MaterialGlobalIlluminationFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineMaterialGlobalIlluminationFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.MaterialGlobalIlluminationFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.MaterialGlobalIlluminationFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCustomRenderTextureInitializationSource_TypeID = -1;
		int UnityEngineCustomRenderTextureInitializationSource_EnumRef = -1;
        
        public void PushUnityEngineCustomRenderTextureInitializationSource(RealStatePtr L, UnityEngine.CustomRenderTextureInitializationSource val)
        {
            if (UnityEngineCustomRenderTextureInitializationSource_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCustomRenderTextureInitializationSource_TypeID = getTypeId(L, typeof(UnityEngine.CustomRenderTextureInitializationSource), out is_first);
				
				if (UnityEngineCustomRenderTextureInitializationSource_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CustomRenderTextureInitializationSource));
				    UnityEngineCustomRenderTextureInitializationSource_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCustomRenderTextureInitializationSource_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCustomRenderTextureInitializationSource_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CustomRenderTextureInitializationSource ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCustomRenderTextureInitializationSource_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CustomRenderTextureInitializationSource val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCustomRenderTextureInitializationSource_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CustomRenderTextureInitializationSource");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CustomRenderTextureInitializationSource");
                }
				val = (UnityEngine.CustomRenderTextureInitializationSource)e;
                
            }
            else
            {
                val = (UnityEngine.CustomRenderTextureInitializationSource)objectCasters.GetCaster(typeof(UnityEngine.CustomRenderTextureInitializationSource))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCustomRenderTextureInitializationSource(RealStatePtr L, int index, UnityEngine.CustomRenderTextureInitializationSource val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCustomRenderTextureInitializationSource_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CustomRenderTextureInitializationSource");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CustomRenderTextureInitializationSource ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCustomRenderTextureUpdateMode_TypeID = -1;
		int UnityEngineCustomRenderTextureUpdateMode_EnumRef = -1;
        
        public void PushUnityEngineCustomRenderTextureUpdateMode(RealStatePtr L, UnityEngine.CustomRenderTextureUpdateMode val)
        {
            if (UnityEngineCustomRenderTextureUpdateMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCustomRenderTextureUpdateMode_TypeID = getTypeId(L, typeof(UnityEngine.CustomRenderTextureUpdateMode), out is_first);
				
				if (UnityEngineCustomRenderTextureUpdateMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CustomRenderTextureUpdateMode));
				    UnityEngineCustomRenderTextureUpdateMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCustomRenderTextureUpdateMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCustomRenderTextureUpdateMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CustomRenderTextureUpdateMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCustomRenderTextureUpdateMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CustomRenderTextureUpdateMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCustomRenderTextureUpdateMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CustomRenderTextureUpdateMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CustomRenderTextureUpdateMode");
                }
				val = (UnityEngine.CustomRenderTextureUpdateMode)e;
                
            }
            else
            {
                val = (UnityEngine.CustomRenderTextureUpdateMode)objectCasters.GetCaster(typeof(UnityEngine.CustomRenderTextureUpdateMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCustomRenderTextureUpdateMode(RealStatePtr L, int index, UnityEngine.CustomRenderTextureUpdateMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCustomRenderTextureUpdateMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CustomRenderTextureUpdateMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CustomRenderTextureUpdateMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCustomRenderTextureUpdateZoneSpace_TypeID = -1;
		int UnityEngineCustomRenderTextureUpdateZoneSpace_EnumRef = -1;
        
        public void PushUnityEngineCustomRenderTextureUpdateZoneSpace(RealStatePtr L, UnityEngine.CustomRenderTextureUpdateZoneSpace val)
        {
            if (UnityEngineCustomRenderTextureUpdateZoneSpace_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCustomRenderTextureUpdateZoneSpace_TypeID = getTypeId(L, typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace), out is_first);
				
				if (UnityEngineCustomRenderTextureUpdateZoneSpace_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace));
				    UnityEngineCustomRenderTextureUpdateZoneSpace_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCustomRenderTextureUpdateZoneSpace_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCustomRenderTextureUpdateZoneSpace_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CustomRenderTextureUpdateZoneSpace ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCustomRenderTextureUpdateZoneSpace_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CustomRenderTextureUpdateZoneSpace val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCustomRenderTextureUpdateZoneSpace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CustomRenderTextureUpdateZoneSpace");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CustomRenderTextureUpdateZoneSpace");
                }
				val = (UnityEngine.CustomRenderTextureUpdateZoneSpace)e;
                
            }
            else
            {
                val = (UnityEngine.CustomRenderTextureUpdateZoneSpace)objectCasters.GetCaster(typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCustomRenderTextureUpdateZoneSpace(RealStatePtr L, int index, UnityEngine.CustomRenderTextureUpdateZoneSpace val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCustomRenderTextureUpdateZoneSpace_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CustomRenderTextureUpdateZoneSpace");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CustomRenderTextureUpdateZoneSpace ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineLineTextureMode_TypeID = -1;
		int UnityEngineLineTextureMode_EnumRef = -1;
        
        public void PushUnityEngineLineTextureMode(RealStatePtr L, UnityEngine.LineTextureMode val)
        {
            if (UnityEngineLineTextureMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineLineTextureMode_TypeID = getTypeId(L, typeof(UnityEngine.LineTextureMode), out is_first);
				
				if (UnityEngineLineTextureMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.LineTextureMode));
				    UnityEngineLineTextureMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineLineTextureMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineLineTextureMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.LineTextureMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineLineTextureMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.LineTextureMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLineTextureMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LineTextureMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.LineTextureMode");
                }
				val = (UnityEngine.LineTextureMode)e;
                
            }
            else
            {
                val = (UnityEngine.LineTextureMode)objectCasters.GetCaster(typeof(UnityEngine.LineTextureMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineLineTextureMode(RealStatePtr L, int index, UnityEngine.LineTextureMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLineTextureMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LineTextureMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.LineTextureMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineLineAlignment_TypeID = -1;
		int UnityEngineLineAlignment_EnumRef = -1;
        
        public void PushUnityEngineLineAlignment(RealStatePtr L, UnityEngine.LineAlignment val)
        {
            if (UnityEngineLineAlignment_TypeID == -1)
            {
			    bool is_first;
                UnityEngineLineAlignment_TypeID = getTypeId(L, typeof(UnityEngine.LineAlignment), out is_first);
				
				if (UnityEngineLineAlignment_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.LineAlignment));
				    UnityEngineLineAlignment_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineLineAlignment_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineLineAlignment_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.LineAlignment ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineLineAlignment_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.LineAlignment val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLineAlignment_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LineAlignment");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.LineAlignment");
                }
				val = (UnityEngine.LineAlignment)e;
                
            }
            else
            {
                val = (UnityEngine.LineAlignment)objectCasters.GetCaster(typeof(UnityEngine.LineAlignment))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineLineAlignment(RealStatePtr L, int index, UnityEngine.LineAlignment val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLineAlignment_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LineAlignment");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.LineAlignment ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineLODFadeMode_TypeID = -1;
		int UnityEngineLODFadeMode_EnumRef = -1;
        
        public void PushUnityEngineLODFadeMode(RealStatePtr L, UnityEngine.LODFadeMode val)
        {
            if (UnityEngineLODFadeMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineLODFadeMode_TypeID = getTypeId(L, typeof(UnityEngine.LODFadeMode), out is_first);
				
				if (UnityEngineLODFadeMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.LODFadeMode));
				    UnityEngineLODFadeMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineLODFadeMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineLODFadeMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.LODFadeMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineLODFadeMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.LODFadeMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLODFadeMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LODFadeMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.LODFadeMode");
                }
				val = (UnityEngine.LODFadeMode)e;
                
            }
            else
            {
                val = (UnityEngine.LODFadeMode)objectCasters.GetCaster(typeof(UnityEngine.LODFadeMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineLODFadeMode(RealStatePtr L, int index, UnityEngine.LODFadeMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLODFadeMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LODFadeMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.LODFadeMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTexture2DEXRFlags_TypeID = -1;
		int UnityEngineTexture2DEXRFlags_EnumRef = -1;
        
        public void PushUnityEngineTexture2DEXRFlags(RealStatePtr L, UnityEngine.Texture2D.EXRFlags val)
        {
            if (UnityEngineTexture2DEXRFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTexture2DEXRFlags_TypeID = getTypeId(L, typeof(UnityEngine.Texture2D.EXRFlags), out is_first);
				
				if (UnityEngineTexture2DEXRFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.Texture2D.EXRFlags));
				    UnityEngineTexture2DEXRFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTexture2DEXRFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTexture2DEXRFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.Texture2D.EXRFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTexture2DEXRFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Texture2D.EXRFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTexture2DEXRFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Texture2D.EXRFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.Texture2D.EXRFlags");
                }
				val = (UnityEngine.Texture2D.EXRFlags)e;
                
            }
            else
            {
                val = (UnityEngine.Texture2D.EXRFlags)objectCasters.GetCaster(typeof(UnityEngine.Texture2D.EXRFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTexture2DEXRFlags(RealStatePtr L, int index, UnityEngine.Texture2D.EXRFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTexture2DEXRFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Texture2D.EXRFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.Texture2D.EXRFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineKeyCode_TypeID = -1;
		int UnityEngineKeyCode_EnumRef = -1;
        
        public void PushUnityEngineKeyCode(RealStatePtr L, UnityEngine.KeyCode val)
        {
            if (UnityEngineKeyCode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineKeyCode_TypeID = getTypeId(L, typeof(UnityEngine.KeyCode), out is_first);
				
				if (UnityEngineKeyCode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.KeyCode));
				    UnityEngineKeyCode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineKeyCode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineKeyCode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.KeyCode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineKeyCode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.KeyCode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineKeyCode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.KeyCode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.KeyCode");
                }
				val = (UnityEngine.KeyCode)e;
                
            }
            else
            {
                val = (UnityEngine.KeyCode)objectCasters.GetCaster(typeof(UnityEngine.KeyCode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineKeyCode(RealStatePtr L, int index, UnityEngine.KeyCode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineKeyCode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.KeyCode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.KeyCode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineGradientMode_TypeID = -1;
		int UnityEngineGradientMode_EnumRef = -1;
        
        public void PushUnityEngineGradientMode(RealStatePtr L, UnityEngine.GradientMode val)
        {
            if (UnityEngineGradientMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineGradientMode_TypeID = getTypeId(L, typeof(UnityEngine.GradientMode), out is_first);
				
				if (UnityEngineGradientMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.GradientMode));
				    UnityEngineGradientMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineGradientMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineGradientMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.GradientMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineGradientMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.GradientMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGradientMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GradientMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.GradientMode");
                }
				val = (UnityEngine.GradientMode)e;
                
            }
            else
            {
                val = (UnityEngine.GradientMode)objectCasters.GetCaster(typeof(UnityEngine.GradientMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineGradientMode(RealStatePtr L, int index, UnityEngine.GradientMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGradientMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GradientMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.GradientMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRuntimeInitializeLoadType_TypeID = -1;
		int UnityEngineRuntimeInitializeLoadType_EnumRef = -1;
        
        public void PushUnityEngineRuntimeInitializeLoadType(RealStatePtr L, UnityEngine.RuntimeInitializeLoadType val)
        {
            if (UnityEngineRuntimeInitializeLoadType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRuntimeInitializeLoadType_TypeID = getTypeId(L, typeof(UnityEngine.RuntimeInitializeLoadType), out is_first);
				
				if (UnityEngineRuntimeInitializeLoadType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RuntimeInitializeLoadType));
				    UnityEngineRuntimeInitializeLoadType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRuntimeInitializeLoadType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRuntimeInitializeLoadType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RuntimeInitializeLoadType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRuntimeInitializeLoadType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RuntimeInitializeLoadType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRuntimeInitializeLoadType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RuntimeInitializeLoadType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RuntimeInitializeLoadType");
                }
				val = (UnityEngine.RuntimeInitializeLoadType)e;
                
            }
            else
            {
                val = (UnityEngine.RuntimeInitializeLoadType)objectCasters.GetCaster(typeof(UnityEngine.RuntimeInitializeLoadType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRuntimeInitializeLoadType(RealStatePtr L, int index, UnityEngine.RuntimeInitializeLoadType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRuntimeInitializeLoadType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RuntimeInitializeLoadType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RuntimeInitializeLoadType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineHideFlags_TypeID = -1;
		int UnityEngineHideFlags_EnumRef = -1;
        
        public void PushUnityEngineHideFlags(RealStatePtr L, UnityEngine.HideFlags val)
        {
            if (UnityEngineHideFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineHideFlags_TypeID = getTypeId(L, typeof(UnityEngine.HideFlags), out is_first);
				
				if (UnityEngineHideFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.HideFlags));
				    UnityEngineHideFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineHideFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineHideFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.HideFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineHideFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.HideFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHideFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HideFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.HideFlags");
                }
				val = (UnityEngine.HideFlags)e;
                
            }
            else
            {
                val = (UnityEngine.HideFlags)objectCasters.GetCaster(typeof(UnityEngine.HideFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineHideFlags(RealStatePtr L, int index, UnityEngine.HideFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHideFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HideFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.HideFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSnapAxis_TypeID = -1;
		int UnityEngineSnapAxis_EnumRef = -1;
        
        public void PushUnityEngineSnapAxis(RealStatePtr L, UnityEngine.SnapAxis val)
        {
            if (UnityEngineSnapAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSnapAxis_TypeID = getTypeId(L, typeof(UnityEngine.SnapAxis), out is_first);
				
				if (UnityEngineSnapAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SnapAxis));
				    UnityEngineSnapAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSnapAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSnapAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SnapAxis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSnapAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SnapAxis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSnapAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SnapAxis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SnapAxis");
                }
				val = (UnityEngine.SnapAxis)e;
                
            }
            else
            {
                val = (UnityEngine.SnapAxis)objectCasters.GetCaster(typeof(UnityEngine.SnapAxis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSnapAxis(RealStatePtr L, int index, UnityEngine.SnapAxis val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSnapAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SnapAxis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SnapAxis ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineBatteryStatus_TypeID = -1;
		int UnityEngineBatteryStatus_EnumRef = -1;
        
        public void PushUnityEngineBatteryStatus(RealStatePtr L, UnityEngine.BatteryStatus val)
        {
            if (UnityEngineBatteryStatus_TypeID == -1)
            {
			    bool is_first;
                UnityEngineBatteryStatus_TypeID = getTypeId(L, typeof(UnityEngine.BatteryStatus), out is_first);
				
				if (UnityEngineBatteryStatus_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.BatteryStatus));
				    UnityEngineBatteryStatus_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineBatteryStatus_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineBatteryStatus_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.BatteryStatus ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineBatteryStatus_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.BatteryStatus val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBatteryStatus_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.BatteryStatus");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.BatteryStatus");
                }
				val = (UnityEngine.BatteryStatus)e;
                
            }
            else
            {
                val = (UnityEngine.BatteryStatus)objectCasters.GetCaster(typeof(UnityEngine.BatteryStatus))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineBatteryStatus(RealStatePtr L, int index, UnityEngine.BatteryStatus val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBatteryStatus_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.BatteryStatus");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.BatteryStatus ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineOperatingSystemFamily_TypeID = -1;
		int UnityEngineOperatingSystemFamily_EnumRef = -1;
        
        public void PushUnityEngineOperatingSystemFamily(RealStatePtr L, UnityEngine.OperatingSystemFamily val)
        {
            if (UnityEngineOperatingSystemFamily_TypeID == -1)
            {
			    bool is_first;
                UnityEngineOperatingSystemFamily_TypeID = getTypeId(L, typeof(UnityEngine.OperatingSystemFamily), out is_first);
				
				if (UnityEngineOperatingSystemFamily_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.OperatingSystemFamily));
				    UnityEngineOperatingSystemFamily_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineOperatingSystemFamily_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineOperatingSystemFamily_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.OperatingSystemFamily ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineOperatingSystemFamily_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.OperatingSystemFamily val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineOperatingSystemFamily_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.OperatingSystemFamily");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.OperatingSystemFamily");
                }
				val = (UnityEngine.OperatingSystemFamily)e;
                
            }
            else
            {
                val = (UnityEngine.OperatingSystemFamily)objectCasters.GetCaster(typeof(UnityEngine.OperatingSystemFamily))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineOperatingSystemFamily(RealStatePtr L, int index, UnityEngine.OperatingSystemFamily val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineOperatingSystemFamily_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.OperatingSystemFamily");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.OperatingSystemFamily ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineDeviceType_TypeID = -1;
		int UnityEngineDeviceType_EnumRef = -1;
        
        public void PushUnityEngineDeviceType(RealStatePtr L, UnityEngine.DeviceType val)
        {
            if (UnityEngineDeviceType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineDeviceType_TypeID = getTypeId(L, typeof(UnityEngine.DeviceType), out is_first);
				
				if (UnityEngineDeviceType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.DeviceType));
				    UnityEngineDeviceType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineDeviceType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineDeviceType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.DeviceType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineDeviceType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.DeviceType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDeviceType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DeviceType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.DeviceType");
                }
				val = (UnityEngine.DeviceType)e;
                
            }
            else
            {
                val = (UnityEngine.DeviceType)objectCasters.GetCaster(typeof(UnityEngine.DeviceType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineDeviceType(RealStatePtr L, int index, UnityEngine.DeviceType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDeviceType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DeviceType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.DeviceType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineDrivenTransformProperties_TypeID = -1;
		int UnityEngineDrivenTransformProperties_EnumRef = -1;
        
        public void PushUnityEngineDrivenTransformProperties(RealStatePtr L, UnityEngine.DrivenTransformProperties val)
        {
            if (UnityEngineDrivenTransformProperties_TypeID == -1)
            {
			    bool is_first;
                UnityEngineDrivenTransformProperties_TypeID = getTypeId(L, typeof(UnityEngine.DrivenTransformProperties), out is_first);
				
				if (UnityEngineDrivenTransformProperties_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.DrivenTransformProperties));
				    UnityEngineDrivenTransformProperties_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineDrivenTransformProperties_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineDrivenTransformProperties_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.DrivenTransformProperties ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineDrivenTransformProperties_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.DrivenTransformProperties val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDrivenTransformProperties_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DrivenTransformProperties");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.DrivenTransformProperties");
                }
				val = (UnityEngine.DrivenTransformProperties)e;
                
            }
            else
            {
                val = (UnityEngine.DrivenTransformProperties)objectCasters.GetCaster(typeof(UnityEngine.DrivenTransformProperties))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineDrivenTransformProperties(RealStatePtr L, int index, UnityEngine.DrivenTransformProperties val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDrivenTransformProperties_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DrivenTransformProperties");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.DrivenTransformProperties ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRectTransformEdge_TypeID = -1;
		int UnityEngineRectTransformEdge_EnumRef = -1;
        
        public void PushUnityEngineRectTransformEdge(RealStatePtr L, UnityEngine.RectTransform.Edge val)
        {
            if (UnityEngineRectTransformEdge_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRectTransformEdge_TypeID = getTypeId(L, typeof(UnityEngine.RectTransform.Edge), out is_first);
				
				if (UnityEngineRectTransformEdge_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RectTransform.Edge));
				    UnityEngineRectTransformEdge_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRectTransformEdge_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRectTransformEdge_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RectTransform.Edge ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRectTransformEdge_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RectTransform.Edge val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformEdge_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Edge");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RectTransform.Edge");
                }
				val = (UnityEngine.RectTransform.Edge)e;
                
            }
            else
            {
                val = (UnityEngine.RectTransform.Edge)objectCasters.GetCaster(typeof(UnityEngine.RectTransform.Edge))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRectTransformEdge(RealStatePtr L, int index, UnityEngine.RectTransform.Edge val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformEdge_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Edge");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RectTransform.Edge ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRectTransformAxis_TypeID = -1;
		int UnityEngineRectTransformAxis_EnumRef = -1;
        
        public void PushUnityEngineRectTransformAxis(RealStatePtr L, UnityEngine.RectTransform.Axis val)
        {
            if (UnityEngineRectTransformAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRectTransformAxis_TypeID = getTypeId(L, typeof(UnityEngine.RectTransform.Axis), out is_first);
				
				if (UnityEngineRectTransformAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RectTransform.Axis));
				    UnityEngineRectTransformAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRectTransformAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRectTransformAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RectTransform.Axis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRectTransformAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RectTransform.Axis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RectTransform.Axis");
                }
				val = (UnityEngine.RectTransform.Axis)e;
                
            }
            else
            {
                val = (UnityEngine.RectTransform.Axis)objectCasters.GetCaster(typeof(UnityEngine.RectTransform.Axis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRectTransformAxis(RealStatePtr L, int index, UnityEngine.RectTransform.Axis val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RectTransform.Axis ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpriteDrawMode_TypeID = -1;
		int UnityEngineSpriteDrawMode_EnumRef = -1;
        
        public void PushUnityEngineSpriteDrawMode(RealStatePtr L, UnityEngine.SpriteDrawMode val)
        {
            if (UnityEngineSpriteDrawMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpriteDrawMode_TypeID = getTypeId(L, typeof(UnityEngine.SpriteDrawMode), out is_first);
				
				if (UnityEngineSpriteDrawMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpriteDrawMode));
				    UnityEngineSpriteDrawMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpriteDrawMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpriteDrawMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpriteDrawMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpriteDrawMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpriteDrawMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteDrawMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteDrawMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpriteDrawMode");
                }
				val = (UnityEngine.SpriteDrawMode)e;
                
            }
            else
            {
                val = (UnityEngine.SpriteDrawMode)objectCasters.GetCaster(typeof(UnityEngine.SpriteDrawMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpriteDrawMode(RealStatePtr L, int index, UnityEngine.SpriteDrawMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteDrawMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteDrawMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpriteDrawMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpriteTileMode_TypeID = -1;
		int UnityEngineSpriteTileMode_EnumRef = -1;
        
        public void PushUnityEngineSpriteTileMode(RealStatePtr L, UnityEngine.SpriteTileMode val)
        {
            if (UnityEngineSpriteTileMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpriteTileMode_TypeID = getTypeId(L, typeof(UnityEngine.SpriteTileMode), out is_first);
				
				if (UnityEngineSpriteTileMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpriteTileMode));
				    UnityEngineSpriteTileMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpriteTileMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpriteTileMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpriteTileMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpriteTileMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpriteTileMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteTileMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteTileMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpriteTileMode");
                }
				val = (UnityEngine.SpriteTileMode)e;
                
            }
            else
            {
                val = (UnityEngine.SpriteTileMode)objectCasters.GetCaster(typeof(UnityEngine.SpriteTileMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpriteTileMode(RealStatePtr L, int index, UnityEngine.SpriteTileMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteTileMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteTileMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpriteTileMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpriteMaskInteraction_TypeID = -1;
		int UnityEngineSpriteMaskInteraction_EnumRef = -1;
        
        public void PushUnityEngineSpriteMaskInteraction(RealStatePtr L, UnityEngine.SpriteMaskInteraction val)
        {
            if (UnityEngineSpriteMaskInteraction_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpriteMaskInteraction_TypeID = getTypeId(L, typeof(UnityEngine.SpriteMaskInteraction), out is_first);
				
				if (UnityEngineSpriteMaskInteraction_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpriteMaskInteraction));
				    UnityEngineSpriteMaskInteraction_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpriteMaskInteraction_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpriteMaskInteraction_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpriteMaskInteraction ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpriteMaskInteraction_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpriteMaskInteraction val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteMaskInteraction_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteMaskInteraction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpriteMaskInteraction");
                }
				val = (UnityEngine.SpriteMaskInteraction)e;
                
            }
            else
            {
                val = (UnityEngine.SpriteMaskInteraction)objectCasters.GetCaster(typeof(UnityEngine.SpriteMaskInteraction))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpriteMaskInteraction(RealStatePtr L, int index, UnityEngine.SpriteMaskInteraction val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteMaskInteraction_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteMaskInteraction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpriteMaskInteraction ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpriteMeshType_TypeID = -1;
		int UnityEngineSpriteMeshType_EnumRef = -1;
        
        public void PushUnityEngineSpriteMeshType(RealStatePtr L, UnityEngine.SpriteMeshType val)
        {
            if (UnityEngineSpriteMeshType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpriteMeshType_TypeID = getTypeId(L, typeof(UnityEngine.SpriteMeshType), out is_first);
				
				if (UnityEngineSpriteMeshType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpriteMeshType));
				    UnityEngineSpriteMeshType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpriteMeshType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpriteMeshType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpriteMeshType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpriteMeshType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpriteMeshType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteMeshType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteMeshType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpriteMeshType");
                }
				val = (UnityEngine.SpriteMeshType)e;
                
            }
            else
            {
                val = (UnityEngine.SpriteMeshType)objectCasters.GetCaster(typeof(UnityEngine.SpriteMeshType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpriteMeshType(RealStatePtr L, int index, UnityEngine.SpriteMeshType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteMeshType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteMeshType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpriteMeshType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpriteAlignment_TypeID = -1;
		int UnityEngineSpriteAlignment_EnumRef = -1;
        
        public void PushUnityEngineSpriteAlignment(RealStatePtr L, UnityEngine.SpriteAlignment val)
        {
            if (UnityEngineSpriteAlignment_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpriteAlignment_TypeID = getTypeId(L, typeof(UnityEngine.SpriteAlignment), out is_first);
				
				if (UnityEngineSpriteAlignment_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpriteAlignment));
				    UnityEngineSpriteAlignment_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpriteAlignment_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpriteAlignment_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpriteAlignment ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpriteAlignment_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpriteAlignment val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteAlignment_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteAlignment");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpriteAlignment");
                }
				val = (UnityEngine.SpriteAlignment)e;
                
            }
            else
            {
                val = (UnityEngine.SpriteAlignment)objectCasters.GetCaster(typeof(UnityEngine.SpriteAlignment))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpriteAlignment(RealStatePtr L, int index, UnityEngine.SpriteAlignment val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteAlignment_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteAlignment");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpriteAlignment ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpritePackingMode_TypeID = -1;
		int UnityEngineSpritePackingMode_EnumRef = -1;
        
        public void PushUnityEngineSpritePackingMode(RealStatePtr L, UnityEngine.SpritePackingMode val)
        {
            if (UnityEngineSpritePackingMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpritePackingMode_TypeID = getTypeId(L, typeof(UnityEngine.SpritePackingMode), out is_first);
				
				if (UnityEngineSpritePackingMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpritePackingMode));
				    UnityEngineSpritePackingMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpritePackingMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpritePackingMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpritePackingMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpritePackingMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpritePackingMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpritePackingMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpritePackingMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpritePackingMode");
                }
				val = (UnityEngine.SpritePackingMode)e;
                
            }
            else
            {
                val = (UnityEngine.SpritePackingMode)objectCasters.GetCaster(typeof(UnityEngine.SpritePackingMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpritePackingMode(RealStatePtr L, int index, UnityEngine.SpritePackingMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpritePackingMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpritePackingMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpritePackingMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpritePackingRotation_TypeID = -1;
		int UnityEngineSpritePackingRotation_EnumRef = -1;
        
        public void PushUnityEngineSpritePackingRotation(RealStatePtr L, UnityEngine.SpritePackingRotation val)
        {
            if (UnityEngineSpritePackingRotation_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpritePackingRotation_TypeID = getTypeId(L, typeof(UnityEngine.SpritePackingRotation), out is_first);
				
				if (UnityEngineSpritePackingRotation_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpritePackingRotation));
				    UnityEngineSpritePackingRotation_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpritePackingRotation_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpritePackingRotation_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpritePackingRotation ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpritePackingRotation_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpritePackingRotation val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpritePackingRotation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpritePackingRotation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpritePackingRotation");
                }
				val = (UnityEngine.SpritePackingRotation)e;
                
            }
            else
            {
                val = (UnityEngine.SpritePackingRotation)objectCasters.GetCaster(typeof(UnityEngine.SpritePackingRotation))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpritePackingRotation(RealStatePtr L, int index, UnityEngine.SpritePackingRotation val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpritePackingRotation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpritePackingRotation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpritePackingRotation ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineSpriteSortPoint_TypeID = -1;
		int UnityEngineSpriteSortPoint_EnumRef = -1;
        
        public void PushUnityEngineSpriteSortPoint(RealStatePtr L, UnityEngine.SpriteSortPoint val)
        {
            if (UnityEngineSpriteSortPoint_TypeID == -1)
            {
			    bool is_first;
                UnityEngineSpriteSortPoint_TypeID = getTypeId(L, typeof(UnityEngine.SpriteSortPoint), out is_first);
				
				if (UnityEngineSpriteSortPoint_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.SpriteSortPoint));
				    UnityEngineSpriteSortPoint_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineSpriteSortPoint_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineSpriteSortPoint_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.SpriteSortPoint ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineSpriteSortPoint_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.SpriteSortPoint val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteSortPoint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteSortPoint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.SpriteSortPoint");
                }
				val = (UnityEngine.SpriteSortPoint)e;
                
            }
            else
            {
                val = (UnityEngine.SpriteSortPoint)objectCasters.GetCaster(typeof(UnityEngine.SpriteSortPoint))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineSpriteSortPoint(RealStatePtr L, int index, UnityEngine.SpriteSortPoint val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineSpriteSortPoint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.SpriteSortPoint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.SpriteSortPoint ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineGridLayoutCellLayout_TypeID = -1;
		int UnityEngineGridLayoutCellLayout_EnumRef = -1;
        
        public void PushUnityEngineGridLayoutCellLayout(RealStatePtr L, UnityEngine.GridLayout.CellLayout val)
        {
            if (UnityEngineGridLayoutCellLayout_TypeID == -1)
            {
			    bool is_first;
                UnityEngineGridLayoutCellLayout_TypeID = getTypeId(L, typeof(UnityEngine.GridLayout.CellLayout), out is_first);
				
				if (UnityEngineGridLayoutCellLayout_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.GridLayout.CellLayout));
				    UnityEngineGridLayoutCellLayout_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineGridLayoutCellLayout_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineGridLayoutCellLayout_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.GridLayout.CellLayout ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineGridLayoutCellLayout_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.GridLayout.CellLayout val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridLayoutCellLayout_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridLayout.CellLayout");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.GridLayout.CellLayout");
                }
				val = (UnityEngine.GridLayout.CellLayout)e;
                
            }
            else
            {
                val = (UnityEngine.GridLayout.CellLayout)objectCasters.GetCaster(typeof(UnityEngine.GridLayout.CellLayout))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineGridLayoutCellLayout(RealStatePtr L, int index, UnityEngine.GridLayout.CellLayout val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridLayoutCellLayout_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridLayout.CellLayout");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.GridLayout.CellLayout ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineGridLayoutCellSwizzle_TypeID = -1;
		int UnityEngineGridLayoutCellSwizzle_EnumRef = -1;
        
        public void PushUnityEngineGridLayoutCellSwizzle(RealStatePtr L, UnityEngine.GridLayout.CellSwizzle val)
        {
            if (UnityEngineGridLayoutCellSwizzle_TypeID == -1)
            {
			    bool is_first;
                UnityEngineGridLayoutCellSwizzle_TypeID = getTypeId(L, typeof(UnityEngine.GridLayout.CellSwizzle), out is_first);
				
				if (UnityEngineGridLayoutCellSwizzle_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.GridLayout.CellSwizzle));
				    UnityEngineGridLayoutCellSwizzle_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineGridLayoutCellSwizzle_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineGridLayoutCellSwizzle_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.GridLayout.CellSwizzle ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineGridLayoutCellSwizzle_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.GridLayout.CellSwizzle val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridLayoutCellSwizzle_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridLayout.CellSwizzle");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.GridLayout.CellSwizzle");
                }
				val = (UnityEngine.GridLayout.CellSwizzle)e;
                
            }
            else
            {
                val = (UnityEngine.GridLayout.CellSwizzle)objectCasters.GetCaster(typeof(UnityEngine.GridLayout.CellSwizzle))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineGridLayoutCellSwizzle(RealStatePtr L, int index, UnityEngine.GridLayout.CellSwizzle val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridLayoutCellSwizzle_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridLayout.CellSwizzle");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.GridLayout.CellSwizzle ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEnginePointerType_TypeID = -1;
		int UnityEnginePointerType_EnumRef = -1;
        
        public void PushUnityEnginePointerType(RealStatePtr L, UnityEngine.PointerType val)
        {
            if (UnityEnginePointerType_TypeID == -1)
            {
			    bool is_first;
                UnityEnginePointerType_TypeID = getTypeId(L, typeof(UnityEngine.PointerType), out is_first);
				
				if (UnityEnginePointerType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.PointerType));
				    UnityEnginePointerType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEnginePointerType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEnginePointerType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.PointerType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEnginePointerType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.PointerType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePointerType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PointerType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.PointerType");
                }
				val = (UnityEngine.PointerType)e;
                
            }
            else
            {
                val = (UnityEngine.PointerType)objectCasters.GetCaster(typeof(UnityEngine.PointerType))(L, index, null);
            }
        }
		
        public void UpdateUnityEnginePointerType(RealStatePtr L, int index, UnityEngine.PointerType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePointerType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PointerType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.PointerType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineScaleMode_TypeID = -1;
		int UnityEngineScaleMode_EnumRef = -1;
        
        public void PushUnityEngineScaleMode(RealStatePtr L, UnityEngine.ScaleMode val)
        {
            if (UnityEngineScaleMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineScaleMode_TypeID = getTypeId(L, typeof(UnityEngine.ScaleMode), out is_first);
				
				if (UnityEngineScaleMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ScaleMode));
				    UnityEngineScaleMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineScaleMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineScaleMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ScaleMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineScaleMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ScaleMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ScaleMode");
                }
				val = (UnityEngine.ScaleMode)e;
                
            }
            else
            {
                val = (UnityEngine.ScaleMode)objectCasters.GetCaster(typeof(UnityEngine.ScaleMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineScaleMode(RealStatePtr L, int index, UnityEngine.ScaleMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ScaleMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineFocusType_TypeID = -1;
		int UnityEngineFocusType_EnumRef = -1;
        
        public void PushUnityEngineFocusType(RealStatePtr L, UnityEngine.FocusType val)
        {
            if (UnityEngineFocusType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineFocusType_TypeID = getTypeId(L, typeof(UnityEngine.FocusType), out is_first);
				
				if (UnityEngineFocusType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.FocusType));
				    UnityEngineFocusType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineFocusType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineFocusType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.FocusType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineFocusType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.FocusType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFocusType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FocusType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.FocusType");
                }
				val = (UnityEngine.FocusType)e;
                
            }
            else
            {
                val = (UnityEngine.FocusType)objectCasters.GetCaster(typeof(UnityEngine.FocusType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineFocusType(RealStatePtr L, int index, UnityEngine.FocusType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineFocusType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.FocusType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.FocusType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineImagePosition_TypeID = -1;
		int UnityEngineImagePosition_EnumRef = -1;
        
        public void PushUnityEngineImagePosition(RealStatePtr L, UnityEngine.ImagePosition val)
        {
            if (UnityEngineImagePosition_TypeID == -1)
            {
			    bool is_first;
                UnityEngineImagePosition_TypeID = getTypeId(L, typeof(UnityEngine.ImagePosition), out is_first);
				
				if (UnityEngineImagePosition_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ImagePosition));
				    UnityEngineImagePosition_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineImagePosition_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineImagePosition_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ImagePosition ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineImagePosition_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ImagePosition val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineImagePosition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ImagePosition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ImagePosition");
                }
				val = (UnityEngine.ImagePosition)e;
                
            }
            else
            {
                val = (UnityEngine.ImagePosition)objectCasters.GetCaster(typeof(UnityEngine.ImagePosition))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineImagePosition(RealStatePtr L, int index, UnityEngine.ImagePosition val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineImagePosition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ImagePosition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ImagePosition ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTouchPhase_TypeID = -1;
		int UnityEngineTouchPhase_EnumRef = -1;
        
        public void PushUnityEngineTouchPhase(RealStatePtr L, UnityEngine.TouchPhase val)
        {
            if (UnityEngineTouchPhase_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTouchPhase_TypeID = getTypeId(L, typeof(UnityEngine.TouchPhase), out is_first);
				
				if (UnityEngineTouchPhase_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TouchPhase));
				    UnityEngineTouchPhase_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTouchPhase_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTouchPhase_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TouchPhase ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTouchPhase_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TouchPhase val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTouchPhase_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TouchPhase");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TouchPhase");
                }
				val = (UnityEngine.TouchPhase)e;
                
            }
            else
            {
                val = (UnityEngine.TouchPhase)objectCasters.GetCaster(typeof(UnityEngine.TouchPhase))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTouchPhase(RealStatePtr L, int index, UnityEngine.TouchPhase val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTouchPhase_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TouchPhase");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TouchPhase ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineIMECompositionMode_TypeID = -1;
		int UnityEngineIMECompositionMode_EnumRef = -1;
        
        public void PushUnityEngineIMECompositionMode(RealStatePtr L, UnityEngine.IMECompositionMode val)
        {
            if (UnityEngineIMECompositionMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineIMECompositionMode_TypeID = getTypeId(L, typeof(UnityEngine.IMECompositionMode), out is_first);
				
				if (UnityEngineIMECompositionMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.IMECompositionMode));
				    UnityEngineIMECompositionMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineIMECompositionMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineIMECompositionMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.IMECompositionMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineIMECompositionMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.IMECompositionMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineIMECompositionMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.IMECompositionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.IMECompositionMode");
                }
				val = (UnityEngine.IMECompositionMode)e;
                
            }
            else
            {
                val = (UnityEngine.IMECompositionMode)objectCasters.GetCaster(typeof(UnityEngine.IMECompositionMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineIMECompositionMode(RealStatePtr L, int index, UnityEngine.IMECompositionMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineIMECompositionMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.IMECompositionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.IMECompositionMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTouchType_TypeID = -1;
		int UnityEngineTouchType_EnumRef = -1;
        
        public void PushUnityEngineTouchType(RealStatePtr L, UnityEngine.TouchType val)
        {
            if (UnityEngineTouchType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTouchType_TypeID = getTypeId(L, typeof(UnityEngine.TouchType), out is_first);
				
				if (UnityEngineTouchType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TouchType));
				    UnityEngineTouchType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTouchType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTouchType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TouchType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTouchType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TouchType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTouchType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TouchType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TouchType");
                }
				val = (UnityEngine.TouchType)e;
                
            }
            else
            {
                val = (UnityEngine.TouchType)objectCasters.GetCaster(typeof(UnityEngine.TouchType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTouchType(RealStatePtr L, int index, UnityEngine.TouchType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTouchType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TouchType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TouchType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineDeviceOrientation_TypeID = -1;
		int UnityEngineDeviceOrientation_EnumRef = -1;
        
        public void PushUnityEngineDeviceOrientation(RealStatePtr L, UnityEngine.DeviceOrientation val)
        {
            if (UnityEngineDeviceOrientation_TypeID == -1)
            {
			    bool is_first;
                UnityEngineDeviceOrientation_TypeID = getTypeId(L, typeof(UnityEngine.DeviceOrientation), out is_first);
				
				if (UnityEngineDeviceOrientation_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.DeviceOrientation));
				    UnityEngineDeviceOrientation_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineDeviceOrientation_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineDeviceOrientation_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.DeviceOrientation ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineDeviceOrientation_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.DeviceOrientation val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDeviceOrientation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DeviceOrientation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.DeviceOrientation");
                }
				val = (UnityEngine.DeviceOrientation)e;
                
            }
            else
            {
                val = (UnityEngine.DeviceOrientation)objectCasters.GetCaster(typeof(UnityEngine.DeviceOrientation))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineDeviceOrientation(RealStatePtr L, int index, UnityEngine.DeviceOrientation val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineDeviceOrientation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.DeviceOrientation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.DeviceOrientation ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineLocationServiceStatus_TypeID = -1;
		int UnityEngineLocationServiceStatus_EnumRef = -1;
        
        public void PushUnityEngineLocationServiceStatus(RealStatePtr L, UnityEngine.LocationServiceStatus val)
        {
            if (UnityEngineLocationServiceStatus_TypeID == -1)
            {
			    bool is_first;
                UnityEngineLocationServiceStatus_TypeID = getTypeId(L, typeof(UnityEngine.LocationServiceStatus), out is_first);
				
				if (UnityEngineLocationServiceStatus_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.LocationServiceStatus));
				    UnityEngineLocationServiceStatus_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineLocationServiceStatus_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineLocationServiceStatus_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.LocationServiceStatus ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineLocationServiceStatus_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.LocationServiceStatus val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLocationServiceStatus_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LocationServiceStatus");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.LocationServiceStatus");
                }
				val = (UnityEngine.LocationServiceStatus)e;
                
            }
            else
            {
                val = (UnityEngine.LocationServiceStatus)objectCasters.GetCaster(typeof(UnityEngine.LocationServiceStatus))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineLocationServiceStatus(RealStatePtr L, int index, UnityEngine.LocationServiceStatus val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineLocationServiceStatus_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.LocationServiceStatus");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.LocationServiceStatus ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRigidbodyConstraints_TypeID = -1;
		int UnityEngineRigidbodyConstraints_EnumRef = -1;
        
        public void PushUnityEngineRigidbodyConstraints(RealStatePtr L, UnityEngine.RigidbodyConstraints val)
        {
            if (UnityEngineRigidbodyConstraints_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRigidbodyConstraints_TypeID = getTypeId(L, typeof(UnityEngine.RigidbodyConstraints), out is_first);
				
				if (UnityEngineRigidbodyConstraints_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RigidbodyConstraints));
				    UnityEngineRigidbodyConstraints_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRigidbodyConstraints_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRigidbodyConstraints_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RigidbodyConstraints ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRigidbodyConstraints_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RigidbodyConstraints val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyConstraints_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyConstraints");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RigidbodyConstraints");
                }
				val = (UnityEngine.RigidbodyConstraints)e;
                
            }
            else
            {
                val = (UnityEngine.RigidbodyConstraints)objectCasters.GetCaster(typeof(UnityEngine.RigidbodyConstraints))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRigidbodyConstraints(RealStatePtr L, int index, UnityEngine.RigidbodyConstraints val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyConstraints_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyConstraints");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RigidbodyConstraints ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineForceMode_TypeID = -1;
		int UnityEngineForceMode_EnumRef = -1;
        
        public void PushUnityEngineForceMode(RealStatePtr L, UnityEngine.ForceMode val)
        {
            if (UnityEngineForceMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineForceMode_TypeID = getTypeId(L, typeof(UnityEngine.ForceMode), out is_first);
				
				if (UnityEngineForceMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ForceMode));
				    UnityEngineForceMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineForceMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineForceMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ForceMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineForceMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ForceMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineForceMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ForceMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ForceMode");
                }
				val = (UnityEngine.ForceMode)e;
                
            }
            else
            {
                val = (UnityEngine.ForceMode)objectCasters.GetCaster(typeof(UnityEngine.ForceMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineForceMode(RealStatePtr L, int index, UnityEngine.ForceMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineForceMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ForceMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ForceMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineJointProjectionMode_TypeID = -1;
		int UnityEngineJointProjectionMode_EnumRef = -1;
        
        public void PushUnityEngineJointProjectionMode(RealStatePtr L, UnityEngine.JointProjectionMode val)
        {
            if (UnityEngineJointProjectionMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineJointProjectionMode_TypeID = getTypeId(L, typeof(UnityEngine.JointProjectionMode), out is_first);
				
				if (UnityEngineJointProjectionMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.JointProjectionMode));
				    UnityEngineJointProjectionMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineJointProjectionMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineJointProjectionMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.JointProjectionMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineJointProjectionMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.JointProjectionMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineJointProjectionMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.JointProjectionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.JointProjectionMode");
                }
				val = (UnityEngine.JointProjectionMode)e;
                
            }
            else
            {
                val = (UnityEngine.JointProjectionMode)objectCasters.GetCaster(typeof(UnityEngine.JointProjectionMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineJointProjectionMode(RealStatePtr L, int index, UnityEngine.JointProjectionMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineJointProjectionMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.JointProjectionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.JointProjectionMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineMeshColliderCookingOptions_TypeID = -1;
		int UnityEngineMeshColliderCookingOptions_EnumRef = -1;
        
        public void PushUnityEngineMeshColliderCookingOptions(RealStatePtr L, UnityEngine.MeshColliderCookingOptions val)
        {
            if (UnityEngineMeshColliderCookingOptions_TypeID == -1)
            {
			    bool is_first;
                UnityEngineMeshColliderCookingOptions_TypeID = getTypeId(L, typeof(UnityEngine.MeshColliderCookingOptions), out is_first);
				
				if (UnityEngineMeshColliderCookingOptions_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.MeshColliderCookingOptions));
				    UnityEngineMeshColliderCookingOptions_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineMeshColliderCookingOptions_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineMeshColliderCookingOptions_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.MeshColliderCookingOptions ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineMeshColliderCookingOptions_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.MeshColliderCookingOptions val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineMeshColliderCookingOptions_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.MeshColliderCookingOptions");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.MeshColliderCookingOptions");
                }
				val = (UnityEngine.MeshColliderCookingOptions)e;
                
            }
            else
            {
                val = (UnityEngine.MeshColliderCookingOptions)objectCasters.GetCaster(typeof(UnityEngine.MeshColliderCookingOptions))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineMeshColliderCookingOptions(RealStatePtr L, int index, UnityEngine.MeshColliderCookingOptions val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineMeshColliderCookingOptions_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.MeshColliderCookingOptions");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.MeshColliderCookingOptions ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRigidbodyInterpolation_TypeID = -1;
		int UnityEngineRigidbodyInterpolation_EnumRef = -1;
        
        public void PushUnityEngineRigidbodyInterpolation(RealStatePtr L, UnityEngine.RigidbodyInterpolation val)
        {
            if (UnityEngineRigidbodyInterpolation_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRigidbodyInterpolation_TypeID = getTypeId(L, typeof(UnityEngine.RigidbodyInterpolation), out is_first);
				
				if (UnityEngineRigidbodyInterpolation_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RigidbodyInterpolation));
				    UnityEngineRigidbodyInterpolation_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRigidbodyInterpolation_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRigidbodyInterpolation_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RigidbodyInterpolation ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRigidbodyInterpolation_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RigidbodyInterpolation val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyInterpolation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyInterpolation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RigidbodyInterpolation");
                }
				val = (UnityEngine.RigidbodyInterpolation)e;
                
            }
            else
            {
                val = (UnityEngine.RigidbodyInterpolation)objectCasters.GetCaster(typeof(UnityEngine.RigidbodyInterpolation))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRigidbodyInterpolation(RealStatePtr L, int index, UnityEngine.RigidbodyInterpolation val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyInterpolation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyInterpolation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RigidbodyInterpolation ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEnginePhysicMaterialCombine_TypeID = -1;
		int UnityEnginePhysicMaterialCombine_EnumRef = -1;
        
        public void PushUnityEnginePhysicMaterialCombine(RealStatePtr L, UnityEngine.PhysicMaterialCombine val)
        {
            if (UnityEnginePhysicMaterialCombine_TypeID == -1)
            {
			    bool is_first;
                UnityEnginePhysicMaterialCombine_TypeID = getTypeId(L, typeof(UnityEngine.PhysicMaterialCombine), out is_first);
				
				if (UnityEnginePhysicMaterialCombine_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.PhysicMaterialCombine));
				    UnityEnginePhysicMaterialCombine_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEnginePhysicMaterialCombine_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEnginePhysicMaterialCombine_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.PhysicMaterialCombine ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEnginePhysicMaterialCombine_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.PhysicMaterialCombine val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePhysicMaterialCombine_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PhysicMaterialCombine");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.PhysicMaterialCombine");
                }
				val = (UnityEngine.PhysicMaterialCombine)e;
                
            }
            else
            {
                val = (UnityEngine.PhysicMaterialCombine)objectCasters.GetCaster(typeof(UnityEngine.PhysicMaterialCombine))(L, index, null);
            }
        }
		
        public void UpdateUnityEnginePhysicMaterialCombine(RealStatePtr L, int index, UnityEngine.PhysicMaterialCombine val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEnginePhysicMaterialCombine_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.PhysicMaterialCombine");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.PhysicMaterialCombine ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCollisionFlags_TypeID = -1;
		int UnityEngineCollisionFlags_EnumRef = -1;
        
        public void PushUnityEngineCollisionFlags(RealStatePtr L, UnityEngine.CollisionFlags val)
        {
            if (UnityEngineCollisionFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCollisionFlags_TypeID = getTypeId(L, typeof(UnityEngine.CollisionFlags), out is_first);
				
				if (UnityEngineCollisionFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CollisionFlags));
				    UnityEngineCollisionFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCollisionFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCollisionFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CollisionFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCollisionFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CollisionFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCollisionFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CollisionFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CollisionFlags");
                }
				val = (UnityEngine.CollisionFlags)e;
                
            }
            else
            {
                val = (UnityEngine.CollisionFlags)objectCasters.GetCaster(typeof(UnityEngine.CollisionFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCollisionFlags(RealStatePtr L, int index, UnityEngine.CollisionFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCollisionFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CollisionFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CollisionFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineQueryTriggerInteraction_TypeID = -1;
		int UnityEngineQueryTriggerInteraction_EnumRef = -1;
        
        public void PushUnityEngineQueryTriggerInteraction(RealStatePtr L, UnityEngine.QueryTriggerInteraction val)
        {
            if (UnityEngineQueryTriggerInteraction_TypeID == -1)
            {
			    bool is_first;
                UnityEngineQueryTriggerInteraction_TypeID = getTypeId(L, typeof(UnityEngine.QueryTriggerInteraction), out is_first);
				
				if (UnityEngineQueryTriggerInteraction_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.QueryTriggerInteraction));
				    UnityEngineQueryTriggerInteraction_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineQueryTriggerInteraction_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineQueryTriggerInteraction_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.QueryTriggerInteraction ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineQueryTriggerInteraction_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.QueryTriggerInteraction val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQueryTriggerInteraction_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.QueryTriggerInteraction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.QueryTriggerInteraction");
                }
				val = (UnityEngine.QueryTriggerInteraction)e;
                
            }
            else
            {
                val = (UnityEngine.QueryTriggerInteraction)objectCasters.GetCaster(typeof(UnityEngine.QueryTriggerInteraction))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineQueryTriggerInteraction(RealStatePtr L, int index, UnityEngine.QueryTriggerInteraction val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQueryTriggerInteraction_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.QueryTriggerInteraction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.QueryTriggerInteraction ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCollisionDetectionMode_TypeID = -1;
		int UnityEngineCollisionDetectionMode_EnumRef = -1;
        
        public void PushUnityEngineCollisionDetectionMode(RealStatePtr L, UnityEngine.CollisionDetectionMode val)
        {
            if (UnityEngineCollisionDetectionMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCollisionDetectionMode_TypeID = getTypeId(L, typeof(UnityEngine.CollisionDetectionMode), out is_first);
				
				if (UnityEngineCollisionDetectionMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CollisionDetectionMode));
				    UnityEngineCollisionDetectionMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCollisionDetectionMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCollisionDetectionMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CollisionDetectionMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCollisionDetectionMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CollisionDetectionMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCollisionDetectionMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CollisionDetectionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CollisionDetectionMode");
                }
				val = (UnityEngine.CollisionDetectionMode)e;
                
            }
            else
            {
                val = (UnityEngine.CollisionDetectionMode)objectCasters.GetCaster(typeof(UnityEngine.CollisionDetectionMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCollisionDetectionMode(RealStatePtr L, int index, UnityEngine.CollisionDetectionMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCollisionDetectionMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CollisionDetectionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CollisionDetectionMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRotationDriveMode_TypeID = -1;
		int UnityEngineRotationDriveMode_EnumRef = -1;
        
        public void PushUnityEngineRotationDriveMode(RealStatePtr L, UnityEngine.RotationDriveMode val)
        {
            if (UnityEngineRotationDriveMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRotationDriveMode_TypeID = getTypeId(L, typeof(UnityEngine.RotationDriveMode), out is_first);
				
				if (UnityEngineRotationDriveMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RotationDriveMode));
				    UnityEngineRotationDriveMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRotationDriveMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRotationDriveMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RotationDriveMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRotationDriveMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RotationDriveMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRotationDriveMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RotationDriveMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RotationDriveMode");
                }
				val = (UnityEngine.RotationDriveMode)e;
                
            }
            else
            {
                val = (UnityEngine.RotationDriveMode)objectCasters.GetCaster(typeof(UnityEngine.RotationDriveMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRotationDriveMode(RealStatePtr L, int index, UnityEngine.RotationDriveMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRotationDriveMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RotationDriveMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RotationDriveMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCapsuleDirection2D_TypeID = -1;
		int UnityEngineCapsuleDirection2D_EnumRef = -1;
        
        public void PushUnityEngineCapsuleDirection2D(RealStatePtr L, UnityEngine.CapsuleDirection2D val)
        {
            if (UnityEngineCapsuleDirection2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCapsuleDirection2D_TypeID = getTypeId(L, typeof(UnityEngine.CapsuleDirection2D), out is_first);
				
				if (UnityEngineCapsuleDirection2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CapsuleDirection2D));
				    UnityEngineCapsuleDirection2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCapsuleDirection2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCapsuleDirection2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CapsuleDirection2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCapsuleDirection2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CapsuleDirection2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCapsuleDirection2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CapsuleDirection2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CapsuleDirection2D");
                }
				val = (UnityEngine.CapsuleDirection2D)e;
                
            }
            else
            {
                val = (UnityEngine.CapsuleDirection2D)objectCasters.GetCaster(typeof(UnityEngine.CapsuleDirection2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCapsuleDirection2D(RealStatePtr L, int index, UnityEngine.CapsuleDirection2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCapsuleDirection2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CapsuleDirection2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CapsuleDirection2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRigidbodyConstraints2D_TypeID = -1;
		int UnityEngineRigidbodyConstraints2D_EnumRef = -1;
        
        public void PushUnityEngineRigidbodyConstraints2D(RealStatePtr L, UnityEngine.RigidbodyConstraints2D val)
        {
            if (UnityEngineRigidbodyConstraints2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRigidbodyConstraints2D_TypeID = getTypeId(L, typeof(UnityEngine.RigidbodyConstraints2D), out is_first);
				
				if (UnityEngineRigidbodyConstraints2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RigidbodyConstraints2D));
				    UnityEngineRigidbodyConstraints2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRigidbodyConstraints2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRigidbodyConstraints2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RigidbodyConstraints2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRigidbodyConstraints2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RigidbodyConstraints2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyConstraints2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyConstraints2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RigidbodyConstraints2D");
                }
				val = (UnityEngine.RigidbodyConstraints2D)e;
                
            }
            else
            {
                val = (UnityEngine.RigidbodyConstraints2D)objectCasters.GetCaster(typeof(UnityEngine.RigidbodyConstraints2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRigidbodyConstraints2D(RealStatePtr L, int index, UnityEngine.RigidbodyConstraints2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyConstraints2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyConstraints2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RigidbodyConstraints2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRigidbodyInterpolation2D_TypeID = -1;
		int UnityEngineRigidbodyInterpolation2D_EnumRef = -1;
        
        public void PushUnityEngineRigidbodyInterpolation2D(RealStatePtr L, UnityEngine.RigidbodyInterpolation2D val)
        {
            if (UnityEngineRigidbodyInterpolation2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRigidbodyInterpolation2D_TypeID = getTypeId(L, typeof(UnityEngine.RigidbodyInterpolation2D), out is_first);
				
				if (UnityEngineRigidbodyInterpolation2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RigidbodyInterpolation2D));
				    UnityEngineRigidbodyInterpolation2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRigidbodyInterpolation2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRigidbodyInterpolation2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RigidbodyInterpolation2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRigidbodyInterpolation2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RigidbodyInterpolation2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyInterpolation2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyInterpolation2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RigidbodyInterpolation2D");
                }
				val = (UnityEngine.RigidbodyInterpolation2D)e;
                
            }
            else
            {
                val = (UnityEngine.RigidbodyInterpolation2D)objectCasters.GetCaster(typeof(UnityEngine.RigidbodyInterpolation2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRigidbodyInterpolation2D(RealStatePtr L, int index, UnityEngine.RigidbodyInterpolation2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyInterpolation2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyInterpolation2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RigidbodyInterpolation2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRigidbodySleepMode2D_TypeID = -1;
		int UnityEngineRigidbodySleepMode2D_EnumRef = -1;
        
        public void PushUnityEngineRigidbodySleepMode2D(RealStatePtr L, UnityEngine.RigidbodySleepMode2D val)
        {
            if (UnityEngineRigidbodySleepMode2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRigidbodySleepMode2D_TypeID = getTypeId(L, typeof(UnityEngine.RigidbodySleepMode2D), out is_first);
				
				if (UnityEngineRigidbodySleepMode2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RigidbodySleepMode2D));
				    UnityEngineRigidbodySleepMode2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRigidbodySleepMode2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRigidbodySleepMode2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RigidbodySleepMode2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRigidbodySleepMode2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RigidbodySleepMode2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodySleepMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodySleepMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RigidbodySleepMode2D");
                }
				val = (UnityEngine.RigidbodySleepMode2D)e;
                
            }
            else
            {
                val = (UnityEngine.RigidbodySleepMode2D)objectCasters.GetCaster(typeof(UnityEngine.RigidbodySleepMode2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRigidbodySleepMode2D(RealStatePtr L, int index, UnityEngine.RigidbodySleepMode2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodySleepMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodySleepMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RigidbodySleepMode2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCollisionDetectionMode2D_TypeID = -1;
		int UnityEngineCollisionDetectionMode2D_EnumRef = -1;
        
        public void PushUnityEngineCollisionDetectionMode2D(RealStatePtr L, UnityEngine.CollisionDetectionMode2D val)
        {
            if (UnityEngineCollisionDetectionMode2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCollisionDetectionMode2D_TypeID = getTypeId(L, typeof(UnityEngine.CollisionDetectionMode2D), out is_first);
				
				if (UnityEngineCollisionDetectionMode2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CollisionDetectionMode2D));
				    UnityEngineCollisionDetectionMode2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCollisionDetectionMode2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCollisionDetectionMode2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CollisionDetectionMode2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCollisionDetectionMode2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CollisionDetectionMode2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCollisionDetectionMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CollisionDetectionMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CollisionDetectionMode2D");
                }
				val = (UnityEngine.CollisionDetectionMode2D)e;
                
            }
            else
            {
                val = (UnityEngine.CollisionDetectionMode2D)objectCasters.GetCaster(typeof(UnityEngine.CollisionDetectionMode2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCollisionDetectionMode2D(RealStatePtr L, int index, UnityEngine.CollisionDetectionMode2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCollisionDetectionMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CollisionDetectionMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CollisionDetectionMode2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRigidbodyType2D_TypeID = -1;
		int UnityEngineRigidbodyType2D_EnumRef = -1;
        
        public void PushUnityEngineRigidbodyType2D(RealStatePtr L, UnityEngine.RigidbodyType2D val)
        {
            if (UnityEngineRigidbodyType2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRigidbodyType2D_TypeID = getTypeId(L, typeof(UnityEngine.RigidbodyType2D), out is_first);
				
				if (UnityEngineRigidbodyType2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RigidbodyType2D));
				    UnityEngineRigidbodyType2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRigidbodyType2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRigidbodyType2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RigidbodyType2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRigidbodyType2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RigidbodyType2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyType2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyType2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RigidbodyType2D");
                }
				val = (UnityEngine.RigidbodyType2D)e;
                
            }
            else
            {
                val = (UnityEngine.RigidbodyType2D)objectCasters.GetCaster(typeof(UnityEngine.RigidbodyType2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRigidbodyType2D(RealStatePtr L, int index, UnityEngine.RigidbodyType2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRigidbodyType2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RigidbodyType2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RigidbodyType2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineForceMode2D_TypeID = -1;
		int UnityEngineForceMode2D_EnumRef = -1;
        
        public void PushUnityEngineForceMode2D(RealStatePtr L, UnityEngine.ForceMode2D val)
        {
            if (UnityEngineForceMode2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineForceMode2D_TypeID = getTypeId(L, typeof(UnityEngine.ForceMode2D), out is_first);
				
				if (UnityEngineForceMode2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ForceMode2D));
				    UnityEngineForceMode2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineForceMode2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineForceMode2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ForceMode2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineForceMode2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ForceMode2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineForceMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ForceMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ForceMode2D");
                }
				val = (UnityEngine.ForceMode2D)e;
                
            }
            else
            {
                val = (UnityEngine.ForceMode2D)objectCasters.GetCaster(typeof(UnityEngine.ForceMode2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineForceMode2D(RealStatePtr L, int index, UnityEngine.ForceMode2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineForceMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ForceMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ForceMode2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineJointLimitState2D_TypeID = -1;
		int UnityEngineJointLimitState2D_EnumRef = -1;
        
        public void PushUnityEngineJointLimitState2D(RealStatePtr L, UnityEngine.JointLimitState2D val)
        {
            if (UnityEngineJointLimitState2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineJointLimitState2D_TypeID = getTypeId(L, typeof(UnityEngine.JointLimitState2D), out is_first);
				
				if (UnityEngineJointLimitState2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.JointLimitState2D));
				    UnityEngineJointLimitState2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineJointLimitState2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineJointLimitState2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.JointLimitState2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineJointLimitState2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.JointLimitState2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineJointLimitState2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.JointLimitState2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.JointLimitState2D");
                }
				val = (UnityEngine.JointLimitState2D)e;
                
            }
            else
            {
                val = (UnityEngine.JointLimitState2D)objectCasters.GetCaster(typeof(UnityEngine.JointLimitState2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineJointLimitState2D(RealStatePtr L, int index, UnityEngine.JointLimitState2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineJointLimitState2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.JointLimitState2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.JointLimitState2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineEffectorSelection2D_TypeID = -1;
		int UnityEngineEffectorSelection2D_EnumRef = -1;
        
        public void PushUnityEngineEffectorSelection2D(RealStatePtr L, UnityEngine.EffectorSelection2D val)
        {
            if (UnityEngineEffectorSelection2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineEffectorSelection2D_TypeID = getTypeId(L, typeof(UnityEngine.EffectorSelection2D), out is_first);
				
				if (UnityEngineEffectorSelection2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.EffectorSelection2D));
				    UnityEngineEffectorSelection2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineEffectorSelection2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineEffectorSelection2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.EffectorSelection2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineEffectorSelection2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.EffectorSelection2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEffectorSelection2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EffectorSelection2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.EffectorSelection2D");
                }
				val = (UnityEngine.EffectorSelection2D)e;
                
            }
            else
            {
                val = (UnityEngine.EffectorSelection2D)objectCasters.GetCaster(typeof(UnityEngine.EffectorSelection2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineEffectorSelection2D(RealStatePtr L, int index, UnityEngine.EffectorSelection2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEffectorSelection2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EffectorSelection2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.EffectorSelection2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineEffectorForceMode2D_TypeID = -1;
		int UnityEngineEffectorForceMode2D_EnumRef = -1;
        
        public void PushUnityEngineEffectorForceMode2D(RealStatePtr L, UnityEngine.EffectorForceMode2D val)
        {
            if (UnityEngineEffectorForceMode2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineEffectorForceMode2D_TypeID = getTypeId(L, typeof(UnityEngine.EffectorForceMode2D), out is_first);
				
				if (UnityEngineEffectorForceMode2D_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.EffectorForceMode2D));
				    UnityEngineEffectorForceMode2D_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineEffectorForceMode2D_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineEffectorForceMode2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.EffectorForceMode2D ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineEffectorForceMode2D_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.EffectorForceMode2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEffectorForceMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EffectorForceMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.EffectorForceMode2D");
                }
				val = (UnityEngine.EffectorForceMode2D)e;
                
            }
            else
            {
                val = (UnityEngine.EffectorForceMode2D)objectCasters.GetCaster(typeof(UnityEngine.EffectorForceMode2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineEffectorForceMode2D(RealStatePtr L, int index, UnityEngine.EffectorForceMode2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEffectorForceMode2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EffectorForceMode2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.EffectorForceMode2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCompositeCollider2DGeometryType_TypeID = -1;
		int UnityEngineCompositeCollider2DGeometryType_EnumRef = -1;
        
        public void PushUnityEngineCompositeCollider2DGeometryType(RealStatePtr L, UnityEngine.CompositeCollider2D.GeometryType val)
        {
            if (UnityEngineCompositeCollider2DGeometryType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCompositeCollider2DGeometryType_TypeID = getTypeId(L, typeof(UnityEngine.CompositeCollider2D.GeometryType), out is_first);
				
				if (UnityEngineCompositeCollider2DGeometryType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CompositeCollider2D.GeometryType));
				    UnityEngineCompositeCollider2DGeometryType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCompositeCollider2DGeometryType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCompositeCollider2DGeometryType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CompositeCollider2D.GeometryType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCompositeCollider2DGeometryType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CompositeCollider2D.GeometryType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompositeCollider2DGeometryType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompositeCollider2D.GeometryType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CompositeCollider2D.GeometryType");
                }
				val = (UnityEngine.CompositeCollider2D.GeometryType)e;
                
            }
            else
            {
                val = (UnityEngine.CompositeCollider2D.GeometryType)objectCasters.GetCaster(typeof(UnityEngine.CompositeCollider2D.GeometryType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCompositeCollider2DGeometryType(RealStatePtr L, int index, UnityEngine.CompositeCollider2D.GeometryType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompositeCollider2DGeometryType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompositeCollider2D.GeometryType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CompositeCollider2D.GeometryType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineCompositeCollider2DGenerationType_TypeID = -1;
		int UnityEngineCompositeCollider2DGenerationType_EnumRef = -1;
        
        public void PushUnityEngineCompositeCollider2DGenerationType(RealStatePtr L, UnityEngine.CompositeCollider2D.GenerationType val)
        {
            if (UnityEngineCompositeCollider2DGenerationType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineCompositeCollider2DGenerationType_TypeID = getTypeId(L, typeof(UnityEngine.CompositeCollider2D.GenerationType), out is_first);
				
				if (UnityEngineCompositeCollider2DGenerationType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.CompositeCollider2D.GenerationType));
				    UnityEngineCompositeCollider2DGenerationType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineCompositeCollider2DGenerationType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineCompositeCollider2DGenerationType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.CompositeCollider2D.GenerationType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineCompositeCollider2DGenerationType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.CompositeCollider2D.GenerationType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompositeCollider2DGenerationType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompositeCollider2D.GenerationType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.CompositeCollider2D.GenerationType");
                }
				val = (UnityEngine.CompositeCollider2D.GenerationType)e;
                
            }
            else
            {
                val = (UnityEngine.CompositeCollider2D.GenerationType)objectCasters.GetCaster(typeof(UnityEngine.CompositeCollider2D.GenerationType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineCompositeCollider2DGenerationType(RealStatePtr L, int index, UnityEngine.CompositeCollider2D.GenerationType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineCompositeCollider2DGenerationType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.CompositeCollider2D.GenerationType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.CompositeCollider2D.GenerationType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineScreenCaptureStereoScreenCaptureMode_TypeID = -1;
		int UnityEngineScreenCaptureStereoScreenCaptureMode_EnumRef = -1;
        
        public void PushUnityEngineScreenCaptureStereoScreenCaptureMode(RealStatePtr L, UnityEngine.ScreenCapture.StereoScreenCaptureMode val)
        {
            if (UnityEngineScreenCaptureStereoScreenCaptureMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineScreenCaptureStereoScreenCaptureMode_TypeID = getTypeId(L, typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode), out is_first);
				
				if (UnityEngineScreenCaptureStereoScreenCaptureMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode));
				    UnityEngineScreenCaptureStereoScreenCaptureMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineScreenCaptureStereoScreenCaptureMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineScreenCaptureStereoScreenCaptureMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.ScreenCapture.StereoScreenCaptureMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineScreenCaptureStereoScreenCaptureMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.ScreenCapture.StereoScreenCaptureMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineScreenCaptureStereoScreenCaptureMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ScreenCapture.StereoScreenCaptureMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.ScreenCapture.StereoScreenCaptureMode");
                }
				val = (UnityEngine.ScreenCapture.StereoScreenCaptureMode)e;
                
            }
            else
            {
                val = (UnityEngine.ScreenCapture.StereoScreenCaptureMode)objectCasters.GetCaster(typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineScreenCaptureStereoScreenCaptureMode(RealStatePtr L, int index, UnityEngine.ScreenCapture.StereoScreenCaptureMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineScreenCaptureStereoScreenCaptureMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.ScreenCapture.StereoScreenCaptureMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.ScreenCapture.StereoScreenCaptureMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTextAnchor_TypeID = -1;
		int UnityEngineTextAnchor_EnumRef = -1;
        
        public void PushUnityEngineTextAnchor(RealStatePtr L, UnityEngine.TextAnchor val)
        {
            if (UnityEngineTextAnchor_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTextAnchor_TypeID = getTypeId(L, typeof(UnityEngine.TextAnchor), out is_first);
				
				if (UnityEngineTextAnchor_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TextAnchor));
				    UnityEngineTextAnchor_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTextAnchor_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTextAnchor_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TextAnchor ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTextAnchor_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TextAnchor val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextAnchor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextAnchor");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TextAnchor");
                }
				val = (UnityEngine.TextAnchor)e;
                
            }
            else
            {
                val = (UnityEngine.TextAnchor)objectCasters.GetCaster(typeof(UnityEngine.TextAnchor))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTextAnchor(RealStatePtr L, int index, UnityEngine.TextAnchor val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextAnchor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextAnchor");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TextAnchor ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineHorizontalWrapMode_TypeID = -1;
		int UnityEngineHorizontalWrapMode_EnumRef = -1;
        
        public void PushUnityEngineHorizontalWrapMode(RealStatePtr L, UnityEngine.HorizontalWrapMode val)
        {
            if (UnityEngineHorizontalWrapMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineHorizontalWrapMode_TypeID = getTypeId(L, typeof(UnityEngine.HorizontalWrapMode), out is_first);
				
				if (UnityEngineHorizontalWrapMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.HorizontalWrapMode));
				    UnityEngineHorizontalWrapMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineHorizontalWrapMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineHorizontalWrapMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.HorizontalWrapMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineHorizontalWrapMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.HorizontalWrapMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHorizontalWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HorizontalWrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.HorizontalWrapMode");
                }
				val = (UnityEngine.HorizontalWrapMode)e;
                
            }
            else
            {
                val = (UnityEngine.HorizontalWrapMode)objectCasters.GetCaster(typeof(UnityEngine.HorizontalWrapMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineHorizontalWrapMode(RealStatePtr L, int index, UnityEngine.HorizontalWrapMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineHorizontalWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.HorizontalWrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.HorizontalWrapMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVerticalWrapMode_TypeID = -1;
		int UnityEngineVerticalWrapMode_EnumRef = -1;
        
        public void PushUnityEngineVerticalWrapMode(RealStatePtr L, UnityEngine.VerticalWrapMode val)
        {
            if (UnityEngineVerticalWrapMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVerticalWrapMode_TypeID = getTypeId(L, typeof(UnityEngine.VerticalWrapMode), out is_first);
				
				if (UnityEngineVerticalWrapMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.VerticalWrapMode));
				    UnityEngineVerticalWrapMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineVerticalWrapMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineVerticalWrapMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.VerticalWrapMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineVerticalWrapMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.VerticalWrapMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVerticalWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.VerticalWrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.VerticalWrapMode");
                }
				val = (UnityEngine.VerticalWrapMode)e;
                
            }
            else
            {
                val = (UnityEngine.VerticalWrapMode)objectCasters.GetCaster(typeof(UnityEngine.VerticalWrapMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVerticalWrapMode(RealStatePtr L, int index, UnityEngine.VerticalWrapMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVerticalWrapMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.VerticalWrapMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.VerticalWrapMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineGridBrushBaseTool_TypeID = -1;
		int UnityEngineGridBrushBaseTool_EnumRef = -1;
        
        public void PushUnityEngineGridBrushBaseTool(RealStatePtr L, UnityEngine.GridBrushBase.Tool val)
        {
            if (UnityEngineGridBrushBaseTool_TypeID == -1)
            {
			    bool is_first;
                UnityEngineGridBrushBaseTool_TypeID = getTypeId(L, typeof(UnityEngine.GridBrushBase.Tool), out is_first);
				
				if (UnityEngineGridBrushBaseTool_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.GridBrushBase.Tool));
				    UnityEngineGridBrushBaseTool_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineGridBrushBaseTool_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineGridBrushBaseTool_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.GridBrushBase.Tool ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineGridBrushBaseTool_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.GridBrushBase.Tool val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridBrushBaseTool_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridBrushBase.Tool");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.GridBrushBase.Tool");
                }
				val = (UnityEngine.GridBrushBase.Tool)e;
                
            }
            else
            {
                val = (UnityEngine.GridBrushBase.Tool)objectCasters.GetCaster(typeof(UnityEngine.GridBrushBase.Tool))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineGridBrushBaseTool(RealStatePtr L, int index, UnityEngine.GridBrushBase.Tool val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridBrushBaseTool_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridBrushBase.Tool");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.GridBrushBase.Tool ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineGridBrushBaseRotationDirection_TypeID = -1;
		int UnityEngineGridBrushBaseRotationDirection_EnumRef = -1;
        
        public void PushUnityEngineGridBrushBaseRotationDirection(RealStatePtr L, UnityEngine.GridBrushBase.RotationDirection val)
        {
            if (UnityEngineGridBrushBaseRotationDirection_TypeID == -1)
            {
			    bool is_first;
                UnityEngineGridBrushBaseRotationDirection_TypeID = getTypeId(L, typeof(UnityEngine.GridBrushBase.RotationDirection), out is_first);
				
				if (UnityEngineGridBrushBaseRotationDirection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.GridBrushBase.RotationDirection));
				    UnityEngineGridBrushBaseRotationDirection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineGridBrushBaseRotationDirection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineGridBrushBaseRotationDirection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.GridBrushBase.RotationDirection ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineGridBrushBaseRotationDirection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.GridBrushBase.RotationDirection val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridBrushBaseRotationDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridBrushBase.RotationDirection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.GridBrushBase.RotationDirection");
                }
				val = (UnityEngine.GridBrushBase.RotationDirection)e;
                
            }
            else
            {
                val = (UnityEngine.GridBrushBase.RotationDirection)objectCasters.GetCaster(typeof(UnityEngine.GridBrushBase.RotationDirection))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineGridBrushBaseRotationDirection(RealStatePtr L, int index, UnityEngine.GridBrushBase.RotationDirection val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridBrushBaseRotationDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridBrushBase.RotationDirection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.GridBrushBase.RotationDirection ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineGridBrushBaseFlipAxis_TypeID = -1;
		int UnityEngineGridBrushBaseFlipAxis_EnumRef = -1;
        
        public void PushUnityEngineGridBrushBaseFlipAxis(RealStatePtr L, UnityEngine.GridBrushBase.FlipAxis val)
        {
            if (UnityEngineGridBrushBaseFlipAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineGridBrushBaseFlipAxis_TypeID = getTypeId(L, typeof(UnityEngine.GridBrushBase.FlipAxis), out is_first);
				
				if (UnityEngineGridBrushBaseFlipAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.GridBrushBase.FlipAxis));
				    UnityEngineGridBrushBaseFlipAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineGridBrushBaseFlipAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineGridBrushBaseFlipAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.GridBrushBase.FlipAxis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineGridBrushBaseFlipAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.GridBrushBase.FlipAxis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridBrushBaseFlipAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridBrushBase.FlipAxis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.GridBrushBase.FlipAxis");
                }
				val = (UnityEngine.GridBrushBase.FlipAxis)e;
                
            }
            else
            {
                val = (UnityEngine.GridBrushBase.FlipAxis)objectCasters.GetCaster(typeof(UnityEngine.GridBrushBase.FlipAxis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineGridBrushBaseFlipAxis(RealStatePtr L, int index, UnityEngine.GridBrushBase.FlipAxis val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineGridBrushBaseFlipAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.GridBrushBase.FlipAxis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.GridBrushBase.FlipAxis ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRenderMode_TypeID = -1;
		int UnityEngineRenderMode_EnumRef = -1;
        
        public void PushUnityEngineRenderMode(RealStatePtr L, UnityEngine.RenderMode val)
        {
            if (UnityEngineRenderMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRenderMode_TypeID = getTypeId(L, typeof(UnityEngine.RenderMode), out is_first);
				
				if (UnityEngineRenderMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RenderMode));
				    UnityEngineRenderMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRenderMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRenderMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RenderMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRenderMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RenderMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RenderMode");
                }
				val = (UnityEngine.RenderMode)e;
                
            }
            else
            {
                val = (UnityEngine.RenderMode)objectCasters.GetCaster(typeof(UnityEngine.RenderMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRenderMode(RealStatePtr L, int index, UnityEngine.RenderMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRenderMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RenderMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RenderMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineAdditionalCanvasShaderChannels_TypeID = -1;
		int UnityEngineAdditionalCanvasShaderChannels_EnumRef = -1;
        
        public void PushUnityEngineAdditionalCanvasShaderChannels(RealStatePtr L, UnityEngine.AdditionalCanvasShaderChannels val)
        {
            if (UnityEngineAdditionalCanvasShaderChannels_TypeID == -1)
            {
			    bool is_first;
                UnityEngineAdditionalCanvasShaderChannels_TypeID = getTypeId(L, typeof(UnityEngine.AdditionalCanvasShaderChannels), out is_first);
				
				if (UnityEngineAdditionalCanvasShaderChannels_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.AdditionalCanvasShaderChannels));
				    UnityEngineAdditionalCanvasShaderChannels_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineAdditionalCanvasShaderChannels_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineAdditionalCanvasShaderChannels_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.AdditionalCanvasShaderChannels ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineAdditionalCanvasShaderChannels_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.AdditionalCanvasShaderChannels val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAdditionalCanvasShaderChannels_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AdditionalCanvasShaderChannels");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.AdditionalCanvasShaderChannels");
                }
				val = (UnityEngine.AdditionalCanvasShaderChannels)e;
                
            }
            else
            {
                val = (UnityEngine.AdditionalCanvasShaderChannels)objectCasters.GetCaster(typeof(UnityEngine.AdditionalCanvasShaderChannels))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineAdditionalCanvasShaderChannels(RealStatePtr L, int index, UnityEngine.AdditionalCanvasShaderChannels val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineAdditionalCanvasShaderChannels_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.AdditionalCanvasShaderChannels");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.AdditionalCanvasShaderChannels ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUISystemProfilerApiSampleType_TypeID = -1;
		int UnityEngineUISystemProfilerApiSampleType_EnumRef = -1;
        
        public void PushUnityEngineUISystemProfilerApiSampleType(RealStatePtr L, UnityEngine.UISystemProfilerApi.SampleType val)
        {
            if (UnityEngineUISystemProfilerApiSampleType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUISystemProfilerApiSampleType_TypeID = getTypeId(L, typeof(UnityEngine.UISystemProfilerApi.SampleType), out is_first);
				
				if (UnityEngineUISystemProfilerApiSampleType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UISystemProfilerApi.SampleType));
				    UnityEngineUISystemProfilerApiSampleType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUISystemProfilerApiSampleType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUISystemProfilerApiSampleType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UISystemProfilerApi.SampleType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUISystemProfilerApiSampleType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UISystemProfilerApi.SampleType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISystemProfilerApiSampleType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UISystemProfilerApi.SampleType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UISystemProfilerApi.SampleType");
                }
				val = (UnityEngine.UISystemProfilerApi.SampleType)e;
                
            }
            else
            {
                val = (UnityEngine.UISystemProfilerApi.SampleType)objectCasters.GetCaster(typeof(UnityEngine.UISystemProfilerApi.SampleType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUISystemProfilerApiSampleType(RealStatePtr L, int index, UnityEngine.UISystemProfilerApi.SampleType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISystemProfilerApiSampleType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UISystemProfilerApi.SampleType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UISystemProfilerApi.SampleType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineWindZoneMode_TypeID = -1;
		int UnityEngineWindZoneMode_EnumRef = -1;
        
        public void PushUnityEngineWindZoneMode(RealStatePtr L, UnityEngine.WindZoneMode val)
        {
            if (UnityEngineWindZoneMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineWindZoneMode_TypeID = getTypeId(L, typeof(UnityEngine.WindZoneMode), out is_first);
				
				if (UnityEngineWindZoneMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.WindZoneMode));
				    UnityEngineWindZoneMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineWindZoneMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineWindZoneMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.WindZoneMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineWindZoneMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.WindZoneMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWindZoneMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WindZoneMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.WindZoneMode");
                }
				val = (UnityEngine.WindZoneMode)e;
                
            }
            else
            {
                val = (UnityEngine.WindZoneMode)objectCasters.GetCaster(typeof(UnityEngine.WindZoneMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineWindZoneMode(RealStatePtr L, int index, UnityEngine.WindZoneMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineWindZoneMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.WindZoneMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.WindZoneMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasUpdate_TypeID = -1;
		int UnityEngineUICanvasUpdate_EnumRef = -1;
        
        public void PushUnityEngineUICanvasUpdate(RealStatePtr L, UnityEngine.UI.CanvasUpdate val)
        {
            if (UnityEngineUICanvasUpdate_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasUpdate_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasUpdate), out is_first);
				
				if (UnityEngineUICanvasUpdate_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasUpdate));
				    UnityEngineUICanvasUpdate_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasUpdate_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasUpdate_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasUpdate ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasUpdate_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasUpdate val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasUpdate_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasUpdate");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasUpdate");
                }
				val = (UnityEngine.UI.CanvasUpdate)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasUpdate)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasUpdate))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasUpdate(RealStatePtr L, int index, UnityEngine.UI.CanvasUpdate val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasUpdate_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasUpdate");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasUpdate ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageType_TypeID = -1;
		int UnityEngineUIImageType_EnumRef = -1;
        
        public void PushUnityEngineUIImageType(RealStatePtr L, UnityEngine.UI.Image.Type val)
        {
            if (UnityEngineUIImageType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageType_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Type), out is_first);
				
				if (UnityEngineUIImageType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Type));
				    UnityEngineUIImageType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Type ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Type val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Type");
                }
				val = (UnityEngine.UI.Image.Type)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Type)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Type))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageType(RealStatePtr L, int index, UnityEngine.UI.Image.Type val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Type ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageFillMethod_TypeID = -1;
		int UnityEngineUIImageFillMethod_EnumRef = -1;
        
        public void PushUnityEngineUIImageFillMethod(RealStatePtr L, UnityEngine.UI.Image.FillMethod val)
        {
            if (UnityEngineUIImageFillMethod_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageFillMethod_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.FillMethod), out is_first);
				
				if (UnityEngineUIImageFillMethod_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.FillMethod));
				    UnityEngineUIImageFillMethod_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageFillMethod_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageFillMethod_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.FillMethod ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageFillMethod_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.FillMethod val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.FillMethod");
                }
				val = (UnityEngine.UI.Image.FillMethod)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.FillMethod)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.FillMethod))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageFillMethod(RealStatePtr L, int index, UnityEngine.UI.Image.FillMethod val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.FillMethod ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOriginHorizontal_TypeID = -1;
		int UnityEngineUIImageOriginHorizontal_EnumRef = -1;
        
        public void PushUnityEngineUIImageOriginHorizontal(RealStatePtr L, UnityEngine.UI.Image.OriginHorizontal val)
        {
            if (UnityEngineUIImageOriginHorizontal_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOriginHorizontal_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.OriginHorizontal), out is_first);
				
				if (UnityEngineUIImageOriginHorizontal_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.OriginHorizontal));
				    UnityEngineUIImageOriginHorizontal_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOriginHorizontal_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOriginHorizontal_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.OriginHorizontal ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOriginHorizontal_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.OriginHorizontal val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.OriginHorizontal");
                }
				val = (UnityEngine.UI.Image.OriginHorizontal)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.OriginHorizontal)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.OriginHorizontal))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOriginHorizontal(RealStatePtr L, int index, UnityEngine.UI.Image.OriginHorizontal val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.OriginHorizontal ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOriginVertical_TypeID = -1;
		int UnityEngineUIImageOriginVertical_EnumRef = -1;
        
        public void PushUnityEngineUIImageOriginVertical(RealStatePtr L, UnityEngine.UI.Image.OriginVertical val)
        {
            if (UnityEngineUIImageOriginVertical_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOriginVertical_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.OriginVertical), out is_first);
				
				if (UnityEngineUIImageOriginVertical_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.OriginVertical));
				    UnityEngineUIImageOriginVertical_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOriginVertical_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOriginVertical_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.OriginVertical ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOriginVertical_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.OriginVertical val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.OriginVertical");
                }
				val = (UnityEngine.UI.Image.OriginVertical)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.OriginVertical)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.OriginVertical))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOriginVertical(RealStatePtr L, int index, UnityEngine.UI.Image.OriginVertical val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.OriginVertical ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin90_TypeID = -1;
		int UnityEngineUIImageOrigin90_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin90(RealStatePtr L, UnityEngine.UI.Image.Origin90 val)
        {
            if (UnityEngineUIImageOrigin90_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin90_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin90), out is_first);
				
				if (UnityEngineUIImageOrigin90_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin90));
				    UnityEngineUIImageOrigin90_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin90_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin90_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin90 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin90_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin90 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin90");
                }
				val = (UnityEngine.UI.Image.Origin90)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin90)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin90))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin90(RealStatePtr L, int index, UnityEngine.UI.Image.Origin90 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin90 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin180_TypeID = -1;
		int UnityEngineUIImageOrigin180_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin180(RealStatePtr L, UnityEngine.UI.Image.Origin180 val)
        {
            if (UnityEngineUIImageOrigin180_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin180_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin180), out is_first);
				
				if (UnityEngineUIImageOrigin180_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin180));
				    UnityEngineUIImageOrigin180_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin180_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin180_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin180 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin180_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin180 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin180");
                }
				val = (UnityEngine.UI.Image.Origin180)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin180)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin180))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin180(RealStatePtr L, int index, UnityEngine.UI.Image.Origin180 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin180 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin360_TypeID = -1;
		int UnityEngineUIImageOrigin360_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin360(RealStatePtr L, UnityEngine.UI.Image.Origin360 val)
        {
            if (UnityEngineUIImageOrigin360_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin360_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin360), out is_first);
				
				if (UnityEngineUIImageOrigin360_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin360));
				    UnityEngineUIImageOrigin360_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin360_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin360_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin360 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin360_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin360 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin360");
                }
				val = (UnityEngine.UI.Image.Origin360)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin360)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin360))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin360(RealStatePtr L, int index, UnityEngine.UI.Image.Origin360 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin360 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldContentType_TypeID = -1;
		int UnityEngineUIInputFieldContentType_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldContentType(RealStatePtr L, UnityEngine.UI.InputField.ContentType val)
        {
            if (UnityEngineUIInputFieldContentType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldContentType_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.ContentType), out is_first);
				
				if (UnityEngineUIInputFieldContentType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.ContentType));
				    UnityEngineUIInputFieldContentType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldContentType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldContentType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.ContentType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldContentType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.ContentType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldContentType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.ContentType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.ContentType");
                }
				val = (UnityEngine.UI.InputField.ContentType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.ContentType)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.ContentType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldContentType(RealStatePtr L, int index, UnityEngine.UI.InputField.ContentType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldContentType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.ContentType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.ContentType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldInputType_TypeID = -1;
		int UnityEngineUIInputFieldInputType_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldInputType(RealStatePtr L, UnityEngine.UI.InputField.InputType val)
        {
            if (UnityEngineUIInputFieldInputType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldInputType_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.InputType), out is_first);
				
				if (UnityEngineUIInputFieldInputType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.InputType));
				    UnityEngineUIInputFieldInputType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldInputType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldInputType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.InputType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldInputType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.InputType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldInputType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.InputType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.InputType");
                }
				val = (UnityEngine.UI.InputField.InputType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.InputType)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.InputType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldInputType(RealStatePtr L, int index, UnityEngine.UI.InputField.InputType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldInputType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.InputType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.InputType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldCharacterValidation_TypeID = -1;
		int UnityEngineUIInputFieldCharacterValidation_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldCharacterValidation(RealStatePtr L, UnityEngine.UI.InputField.CharacterValidation val)
        {
            if (UnityEngineUIInputFieldCharacterValidation_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldCharacterValidation_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.CharacterValidation), out is_first);
				
				if (UnityEngineUIInputFieldCharacterValidation_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.CharacterValidation));
				    UnityEngineUIInputFieldCharacterValidation_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldCharacterValidation_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldCharacterValidation_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.CharacterValidation ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldCharacterValidation_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.CharacterValidation val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldCharacterValidation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.CharacterValidation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.CharacterValidation");
                }
				val = (UnityEngine.UI.InputField.CharacterValidation)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.CharacterValidation)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.CharacterValidation))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldCharacterValidation(RealStatePtr L, int index, UnityEngine.UI.InputField.CharacterValidation val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldCharacterValidation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.CharacterValidation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.CharacterValidation ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldLineType_TypeID = -1;
		int UnityEngineUIInputFieldLineType_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldLineType(RealStatePtr L, UnityEngine.UI.InputField.LineType val)
        {
            if (UnityEngineUIInputFieldLineType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldLineType_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.LineType), out is_first);
				
				if (UnityEngineUIInputFieldLineType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.LineType));
				    UnityEngineUIInputFieldLineType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldLineType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldLineType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.LineType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldLineType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.LineType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldLineType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.LineType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.LineType");
                }
				val = (UnityEngine.UI.InputField.LineType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.LineType)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.LineType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldLineType(RealStatePtr L, int index, UnityEngine.UI.InputField.LineType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldLineType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.LineType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.LineType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIAspectRatioFitterAspectMode_TypeID = -1;
		int UnityEngineUIAspectRatioFitterAspectMode_EnumRef = -1;
        
        public void PushUnityEngineUIAspectRatioFitterAspectMode(RealStatePtr L, UnityEngine.UI.AspectRatioFitter.AspectMode val)
        {
            if (UnityEngineUIAspectRatioFitterAspectMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIAspectRatioFitterAspectMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), out is_first);
				
				if (UnityEngineUIAspectRatioFitterAspectMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.AspectRatioFitter.AspectMode));
				    UnityEngineUIAspectRatioFitterAspectMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIAspectRatioFitterAspectMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIAspectRatioFitterAspectMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.AspectRatioFitter.AspectMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIAspectRatioFitterAspectMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.AspectRatioFitter.AspectMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIAspectRatioFitterAspectMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.AspectRatioFitter.AspectMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.AspectRatioFitter.AspectMode");
                }
				val = (UnityEngine.UI.AspectRatioFitter.AspectMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.AspectRatioFitter.AspectMode)objectCasters.GetCaster(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIAspectRatioFitterAspectMode(RealStatePtr L, int index, UnityEngine.UI.AspectRatioFitter.AspectMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIAspectRatioFitterAspectMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.AspectRatioFitter.AspectMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.AspectRatioFitter.AspectMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasScalerScaleMode_TypeID = -1;
		int UnityEngineUICanvasScalerScaleMode_EnumRef = -1;
        
        public void PushUnityEngineUICanvasScalerScaleMode(RealStatePtr L, UnityEngine.UI.CanvasScaler.ScaleMode val)
        {
            if (UnityEngineUICanvasScalerScaleMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasScalerScaleMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasScaler.ScaleMode), out is_first);
				
				if (UnityEngineUICanvasScalerScaleMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasScaler.ScaleMode));
				    UnityEngineUICanvasScalerScaleMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasScalerScaleMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasScalerScaleMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasScaler.ScaleMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasScalerScaleMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasScaler.ScaleMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasScaler.ScaleMode");
                }
				val = (UnityEngine.UI.CanvasScaler.ScaleMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasScaler.ScaleMode)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasScaler.ScaleMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasScalerScaleMode(RealStatePtr L, int index, UnityEngine.UI.CanvasScaler.ScaleMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasScaler.ScaleMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasScalerScreenMatchMode_TypeID = -1;
		int UnityEngineUICanvasScalerScreenMatchMode_EnumRef = -1;
        
        public void PushUnityEngineUICanvasScalerScreenMatchMode(RealStatePtr L, UnityEngine.UI.CanvasScaler.ScreenMatchMode val)
        {
            if (UnityEngineUICanvasScalerScreenMatchMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasScalerScreenMatchMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), out is_first);
				
				if (UnityEngineUICanvasScalerScreenMatchMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode));
				    UnityEngineUICanvasScalerScreenMatchMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasScalerScreenMatchMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasScalerScreenMatchMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasScaler.ScreenMatchMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasScalerScreenMatchMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasScaler.ScreenMatchMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScreenMatchMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScreenMatchMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasScaler.ScreenMatchMode");
                }
				val = (UnityEngine.UI.CanvasScaler.ScreenMatchMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasScaler.ScreenMatchMode)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasScalerScreenMatchMode(RealStatePtr L, int index, UnityEngine.UI.CanvasScaler.ScreenMatchMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScreenMatchMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScreenMatchMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasScaler.ScreenMatchMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasScalerUnit_TypeID = -1;
		int UnityEngineUICanvasScalerUnit_EnumRef = -1;
        
        public void PushUnityEngineUICanvasScalerUnit(RealStatePtr L, UnityEngine.UI.CanvasScaler.Unit val)
        {
            if (UnityEngineUICanvasScalerUnit_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasScalerUnit_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasScaler.Unit), out is_first);
				
				if (UnityEngineUICanvasScalerUnit_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasScaler.Unit));
				    UnityEngineUICanvasScalerUnit_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasScalerUnit_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasScalerUnit_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasScaler.Unit ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasScalerUnit_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasScaler.Unit val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerUnit_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.Unit");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasScaler.Unit");
                }
				val = (UnityEngine.UI.CanvasScaler.Unit)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasScaler.Unit)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasScaler.Unit))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasScalerUnit(RealStatePtr L, int index, UnityEngine.UI.CanvasScaler.Unit val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerUnit_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.Unit");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasScaler.Unit ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIContentSizeFitterFitMode_TypeID = -1;
		int UnityEngineUIContentSizeFitterFitMode_EnumRef = -1;
        
        public void PushUnityEngineUIContentSizeFitterFitMode(RealStatePtr L, UnityEngine.UI.ContentSizeFitter.FitMode val)
        {
            if (UnityEngineUIContentSizeFitterFitMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIContentSizeFitterFitMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.ContentSizeFitter.FitMode), out is_first);
				
				if (UnityEngineUIContentSizeFitterFitMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.ContentSizeFitter.FitMode));
				    UnityEngineUIContentSizeFitterFitMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIContentSizeFitterFitMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIContentSizeFitterFitMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.ContentSizeFitter.FitMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIContentSizeFitterFitMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.ContentSizeFitter.FitMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIContentSizeFitterFitMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ContentSizeFitter.FitMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.ContentSizeFitter.FitMode");
                }
				val = (UnityEngine.UI.ContentSizeFitter.FitMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.ContentSizeFitter.FitMode)objectCasters.GetCaster(typeof(UnityEngine.UI.ContentSizeFitter.FitMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIContentSizeFitterFitMode(RealStatePtr L, int index, UnityEngine.UI.ContentSizeFitter.FitMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIContentSizeFitterFitMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ContentSizeFitter.FitMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.ContentSizeFitter.FitMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIGridLayoutGroupCorner_TypeID = -1;
		int UnityEngineUIGridLayoutGroupCorner_EnumRef = -1;
        
        public void PushUnityEngineUIGridLayoutGroupCorner(RealStatePtr L, UnityEngine.UI.GridLayoutGroup.Corner val)
        {
            if (UnityEngineUIGridLayoutGroupCorner_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIGridLayoutGroupCorner_TypeID = getTypeId(L, typeof(UnityEngine.UI.GridLayoutGroup.Corner), out is_first);
				
				if (UnityEngineUIGridLayoutGroupCorner_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.GridLayoutGroup.Corner));
				    UnityEngineUIGridLayoutGroupCorner_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIGridLayoutGroupCorner_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIGridLayoutGroupCorner_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.GridLayoutGroup.Corner ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIGridLayoutGroupCorner_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.GridLayoutGroup.Corner val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupCorner_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Corner");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.GridLayoutGroup.Corner");
                }
				val = (UnityEngine.UI.GridLayoutGroup.Corner)e;
                
            }
            else
            {
                val = (UnityEngine.UI.GridLayoutGroup.Corner)objectCasters.GetCaster(typeof(UnityEngine.UI.GridLayoutGroup.Corner))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIGridLayoutGroupCorner(RealStatePtr L, int index, UnityEngine.UI.GridLayoutGroup.Corner val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupCorner_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Corner");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.GridLayoutGroup.Corner ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIGridLayoutGroupAxis_TypeID = -1;
		int UnityEngineUIGridLayoutGroupAxis_EnumRef = -1;
        
        public void PushUnityEngineUIGridLayoutGroupAxis(RealStatePtr L, UnityEngine.UI.GridLayoutGroup.Axis val)
        {
            if (UnityEngineUIGridLayoutGroupAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIGridLayoutGroupAxis_TypeID = getTypeId(L, typeof(UnityEngine.UI.GridLayoutGroup.Axis), out is_first);
				
				if (UnityEngineUIGridLayoutGroupAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.GridLayoutGroup.Axis));
				    UnityEngineUIGridLayoutGroupAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIGridLayoutGroupAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIGridLayoutGroupAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.GridLayoutGroup.Axis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIGridLayoutGroupAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.GridLayoutGroup.Axis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.GridLayoutGroup.Axis");
                }
				val = (UnityEngine.UI.GridLayoutGroup.Axis)e;
                
            }
            else
            {
                val = (UnityEngine.UI.GridLayoutGroup.Axis)objectCasters.GetCaster(typeof(UnityEngine.UI.GridLayoutGroup.Axis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIGridLayoutGroupAxis(RealStatePtr L, int index, UnityEngine.UI.GridLayoutGroup.Axis val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.GridLayoutGroup.Axis ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIGridLayoutGroupConstraint_TypeID = -1;
		int UnityEngineUIGridLayoutGroupConstraint_EnumRef = -1;
        
        public void PushUnityEngineUIGridLayoutGroupConstraint(RealStatePtr L, UnityEngine.UI.GridLayoutGroup.Constraint val)
        {
            if (UnityEngineUIGridLayoutGroupConstraint_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIGridLayoutGroupConstraint_TypeID = getTypeId(L, typeof(UnityEngine.UI.GridLayoutGroup.Constraint), out is_first);
				
				if (UnityEngineUIGridLayoutGroupConstraint_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.GridLayoutGroup.Constraint));
				    UnityEngineUIGridLayoutGroupConstraint_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIGridLayoutGroupConstraint_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIGridLayoutGroupConstraint_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.GridLayoutGroup.Constraint ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIGridLayoutGroupConstraint_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.GridLayoutGroup.Constraint val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupConstraint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Constraint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.GridLayoutGroup.Constraint");
                }
				val = (UnityEngine.UI.GridLayoutGroup.Constraint)e;
                
            }
            else
            {
                val = (UnityEngine.UI.GridLayoutGroup.Constraint)objectCasters.GetCaster(typeof(UnityEngine.UI.GridLayoutGroup.Constraint))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIGridLayoutGroupConstraint(RealStatePtr L, int index, UnityEngine.UI.GridLayoutGroup.Constraint val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupConstraint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Constraint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.GridLayoutGroup.Constraint ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUINavigationMode_TypeID = -1;
		int UnityEngineUINavigationMode_EnumRef = -1;
        
        public void PushUnityEngineUINavigationMode(RealStatePtr L, UnityEngine.UI.Navigation.Mode val)
        {
            if (UnityEngineUINavigationMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUINavigationMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.Navigation.Mode), out is_first);
				
				if (UnityEngineUINavigationMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Navigation.Mode));
				    UnityEngineUINavigationMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUINavigationMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUINavigationMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Navigation.Mode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUINavigationMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Navigation.Mode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUINavigationMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Navigation.Mode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Navigation.Mode");
                }
				val = (UnityEngine.UI.Navigation.Mode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Navigation.Mode)objectCasters.GetCaster(typeof(UnityEngine.UI.Navigation.Mode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUINavigationMode(RealStatePtr L, int index, UnityEngine.UI.Navigation.Mode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUINavigationMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Navigation.Mode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Navigation.Mode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIScrollRectMovementType_TypeID = -1;
		int UnityEngineUIScrollRectMovementType_EnumRef = -1;
        
        public void PushUnityEngineUIScrollRectMovementType(RealStatePtr L, UnityEngine.UI.ScrollRect.MovementType val)
        {
            if (UnityEngineUIScrollRectMovementType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIScrollRectMovementType_TypeID = getTypeId(L, typeof(UnityEngine.UI.ScrollRect.MovementType), out is_first);
				
				if (UnityEngineUIScrollRectMovementType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.ScrollRect.MovementType));
				    UnityEngineUIScrollRectMovementType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIScrollRectMovementType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIScrollRectMovementType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.ScrollRect.MovementType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIScrollRectMovementType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.ScrollRect.MovementType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectMovementType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.MovementType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.ScrollRect.MovementType");
                }
				val = (UnityEngine.UI.ScrollRect.MovementType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.ScrollRect.MovementType)objectCasters.GetCaster(typeof(UnityEngine.UI.ScrollRect.MovementType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIScrollRectMovementType(RealStatePtr L, int index, UnityEngine.UI.ScrollRect.MovementType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectMovementType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.MovementType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.ScrollRect.MovementType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIScrollRectScrollbarVisibility_TypeID = -1;
		int UnityEngineUIScrollRectScrollbarVisibility_EnumRef = -1;
        
        public void PushUnityEngineUIScrollRectScrollbarVisibility(RealStatePtr L, UnityEngine.UI.ScrollRect.ScrollbarVisibility val)
        {
            if (UnityEngineUIScrollRectScrollbarVisibility_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIScrollRectScrollbarVisibility_TypeID = getTypeId(L, typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), out is_first);
				
				if (UnityEngineUIScrollRectScrollbarVisibility_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility));
				    UnityEngineUIScrollRectScrollbarVisibility_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIScrollRectScrollbarVisibility_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIScrollRectScrollbarVisibility_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.ScrollRect.ScrollbarVisibility ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIScrollRectScrollbarVisibility_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.ScrollRect.ScrollbarVisibility val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectScrollbarVisibility_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.ScrollbarVisibility");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.ScrollRect.ScrollbarVisibility");
                }
				val = (UnityEngine.UI.ScrollRect.ScrollbarVisibility)e;
                
            }
            else
            {
                val = (UnityEngine.UI.ScrollRect.ScrollbarVisibility)objectCasters.GetCaster(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIScrollRectScrollbarVisibility(RealStatePtr L, int index, UnityEngine.UI.ScrollRect.ScrollbarVisibility val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectScrollbarVisibility_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.ScrollbarVisibility");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.ScrollRect.ScrollbarVisibility ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIScrollbarDirection_TypeID = -1;
		int UnityEngineUIScrollbarDirection_EnumRef = -1;
        
        public void PushUnityEngineUIScrollbarDirection(RealStatePtr L, UnityEngine.UI.Scrollbar.Direction val)
        {
            if (UnityEngineUIScrollbarDirection_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIScrollbarDirection_TypeID = getTypeId(L, typeof(UnityEngine.UI.Scrollbar.Direction), out is_first);
				
				if (UnityEngineUIScrollbarDirection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Scrollbar.Direction));
				    UnityEngineUIScrollbarDirection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIScrollbarDirection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIScrollbarDirection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Scrollbar.Direction ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIScrollbarDirection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Scrollbar.Direction val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollbarDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Scrollbar.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Scrollbar.Direction");
                }
				val = (UnityEngine.UI.Scrollbar.Direction)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Scrollbar.Direction)objectCasters.GetCaster(typeof(UnityEngine.UI.Scrollbar.Direction))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIScrollbarDirection(RealStatePtr L, int index, UnityEngine.UI.Scrollbar.Direction val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollbarDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Scrollbar.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Scrollbar.Direction ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUISelectableTransition_TypeID = -1;
		int UnityEngineUISelectableTransition_EnumRef = -1;
        
        public void PushUnityEngineUISelectableTransition(RealStatePtr L, UnityEngine.UI.Selectable.Transition val)
        {
            if (UnityEngineUISelectableTransition_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUISelectableTransition_TypeID = getTypeId(L, typeof(UnityEngine.UI.Selectable.Transition), out is_first);
				
				if (UnityEngineUISelectableTransition_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Selectable.Transition));
				    UnityEngineUISelectableTransition_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUISelectableTransition_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUISelectableTransition_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Selectable.Transition ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUISelectableTransition_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Selectable.Transition val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISelectableTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Selectable.Transition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Selectable.Transition");
                }
				val = (UnityEngine.UI.Selectable.Transition)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Selectable.Transition)objectCasters.GetCaster(typeof(UnityEngine.UI.Selectable.Transition))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUISelectableTransition(RealStatePtr L, int index, UnityEngine.UI.Selectable.Transition val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISelectableTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Selectable.Transition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Selectable.Transition ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUISliderDirection_TypeID = -1;
		int UnityEngineUISliderDirection_EnumRef = -1;
        
        public void PushUnityEngineUISliderDirection(RealStatePtr L, UnityEngine.UI.Slider.Direction val)
        {
            if (UnityEngineUISliderDirection_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUISliderDirection_TypeID = getTypeId(L, typeof(UnityEngine.UI.Slider.Direction), out is_first);
				
				if (UnityEngineUISliderDirection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Slider.Direction));
				    UnityEngineUISliderDirection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUISliderDirection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUISliderDirection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Slider.Direction ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUISliderDirection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Slider.Direction val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISliderDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Slider.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Slider.Direction");
                }
				val = (UnityEngine.UI.Slider.Direction)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Slider.Direction)objectCasters.GetCaster(typeof(UnityEngine.UI.Slider.Direction))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUISliderDirection(RealStatePtr L, int index, UnityEngine.UI.Slider.Direction val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISliderDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Slider.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Slider.Direction ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIToggleToggleTransition_TypeID = -1;
		int UnityEngineUIToggleToggleTransition_EnumRef = -1;
        
        public void PushUnityEngineUIToggleToggleTransition(RealStatePtr L, UnityEngine.UI.Toggle.ToggleTransition val)
        {
            if (UnityEngineUIToggleToggleTransition_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIToggleToggleTransition_TypeID = getTypeId(L, typeof(UnityEngine.UI.Toggle.ToggleTransition), out is_first);
				
				if (UnityEngineUIToggleToggleTransition_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Toggle.ToggleTransition));
				    UnityEngineUIToggleToggleTransition_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIToggleToggleTransition_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIToggleToggleTransition_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Toggle.ToggleTransition ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIToggleToggleTransition_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Toggle.ToggleTransition val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIToggleToggleTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Toggle.ToggleTransition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Toggle.ToggleTransition");
                }
				val = (UnityEngine.UI.Toggle.ToggleTransition)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Toggle.ToggleTransition)objectCasters.GetCaster(typeof(UnityEngine.UI.Toggle.ToggleTransition))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIToggleToggleTransition(RealStatePtr L, int index, UnityEngine.UI.Toggle.ToggleTransition val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIToggleToggleTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Toggle.ToggleTransition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Toggle.ToggleTransition ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int XDebugOrient_TypeID = -1;
		int XDebugOrient_EnumRef = -1;
        
        public void PushXDebugOrient(RealStatePtr L, XDebug.Orient val)
        {
            if (XDebugOrient_TypeID == -1)
            {
			    bool is_first;
                XDebugOrient_TypeID = getTypeId(L, typeof(XDebug.Orient), out is_first);
				
				if (XDebugOrient_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(XDebug.Orient));
				    XDebugOrient_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, XDebugOrient_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, XDebugOrient_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for XDebug.Orient ,value="+val);
            }
			
			LuaAPI.lua_getref(L, XDebugOrient_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out XDebug.Orient val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugOrient_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.Orient");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for XDebug.Orient");
                }
				val = (XDebug.Orient)e;
                
            }
            else
            {
                val = (XDebug.Orient)objectCasters.GetCaster(typeof(XDebug.Orient))(L, index, null);
            }
        }
		
        public void UpdateXDebugOrient(RealStatePtr L, int index, XDebug.Orient val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugOrient_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.Orient");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for XDebug.Orient ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int XDebugLocationAlign_TypeID = -1;
		int XDebugLocationAlign_EnumRef = -1;
        
        public void PushXDebugLocationAlign(RealStatePtr L, XDebug.Location.Align val)
        {
            if (XDebugLocationAlign_TypeID == -1)
            {
			    bool is_first;
                XDebugLocationAlign_TypeID = getTypeId(L, typeof(XDebug.Location.Align), out is_first);
				
				if (XDebugLocationAlign_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(XDebug.Location.Align));
				    XDebugLocationAlign_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, XDebugLocationAlign_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, XDebugLocationAlign_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for XDebug.Location.Align ,value="+val);
            }
			
			LuaAPI.lua_getref(L, XDebugLocationAlign_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out XDebug.Location.Align val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugLocationAlign_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.Location.Align");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for XDebug.Location.Align");
                }
				val = (XDebug.Location.Align)e;
                
            }
            else
            {
                val = (XDebug.Location.Align)objectCasters.GetCaster(typeof(XDebug.Location.Align))(L, index, null);
            }
        }
		
        public void UpdateXDebugLocationAlign(RealStatePtr L, int index, XDebug.Location.Align val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugLocationAlign_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.Location.Align");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for XDebug.Location.Align ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int XDebugModuleType_TypeID = -1;
		int XDebugModuleType_EnumRef = -1;
        
        public void PushXDebugModuleType(RealStatePtr L, XDebug.Module.Type val)
        {
            if (XDebugModuleType_TypeID == -1)
            {
			    bool is_first;
                XDebugModuleType_TypeID = getTypeId(L, typeof(XDebug.Module.Type), out is_first);
				
				if (XDebugModuleType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(XDebug.Module.Type));
				    XDebugModuleType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, XDebugModuleType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, XDebugModuleType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for XDebug.Module.Type ,value="+val);
            }
			
			LuaAPI.lua_getref(L, XDebugModuleType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out XDebug.Module.Type val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugModuleType_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.Module.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for XDebug.Module.Type");
                }
				val = (XDebug.Module.Type)e;
                
            }
            else
            {
                val = (XDebug.Module.Type)objectCasters.GetCaster(typeof(XDebug.Module.Type))(L, index, null);
            }
        }
		
        public void UpdateXDebugModuleType(RealStatePtr L, int index, XDebug.Module.Type val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugModuleType_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.Module.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for XDebug.Module.Type ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int XDebugXLogLogLevel_TypeID = -1;
		int XDebugXLogLogLevel_EnumRef = -1;
        
        public void PushXDebugXLogLogLevel(RealStatePtr L, XDebug.XLog.LogLevel val)
        {
            if (XDebugXLogLogLevel_TypeID == -1)
            {
			    bool is_first;
                XDebugXLogLogLevel_TypeID = getTypeId(L, typeof(XDebug.XLog.LogLevel), out is_first);
				
				if (XDebugXLogLogLevel_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(XDebug.XLog.LogLevel));
				    XDebugXLogLogLevel_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, XDebugXLogLogLevel_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, XDebugXLogLogLevel_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for XDebug.XLog.LogLevel ,value="+val);
            }
			
			LuaAPI.lua_getref(L, XDebugXLogLogLevel_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out XDebug.XLog.LogLevel val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugXLogLogLevel_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.XLog.LogLevel");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for XDebug.XLog.LogLevel");
                }
				val = (XDebug.XLog.LogLevel)e;
                
            }
            else
            {
                val = (XDebug.XLog.LogLevel)objectCasters.GetCaster(typeof(XDebug.XLog.LogLevel))(L, index, null);
            }
        }
		
        public void UpdateXDebugXLogLogLevel(RealStatePtr L, int index, XDebug.XLog.LogLevel val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XDebugXLogLogLevel_TypeID)
				{
				    throw new Exception("invalid userdata for XDebug.XLog.LogLevel");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for XDebug.XLog.LogLevel ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        
		// table cast optimze
		
        
    }
	
	public partial class StaticLuaCallbacks
    {
	    internal static bool __tryArrayGet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int index)
		{
		
			if (type == typeof(UnityEngine.Vector2[]))
			{
			    UnityEngine.Vector2[] array = obj as UnityEngine.Vector2[];
				translator.PushUnityEngineVector2(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector3[]))
			{
			    UnityEngine.Vector3[] array = obj as UnityEngine.Vector3[];
				translator.PushUnityEngineVector3(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector4[]))
			{
			    UnityEngine.Vector4[] array = obj as UnityEngine.Vector4[];
				translator.PushUnityEngineVector4(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Color[]))
			{
			    UnityEngine.Color[] array = obj as UnityEngine.Color[];
				translator.PushUnityEngineColor(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Quaternion[]))
			{
			    UnityEngine.Quaternion[] array = obj as UnityEngine.Quaternion[];
				translator.PushUnityEngineQuaternion(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray[]))
			{
			    UnityEngine.Ray[] array = obj as UnityEngine.Ray[];
				translator.PushUnityEngineRay(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Bounds[]))
			{
			    UnityEngine.Bounds[] array = obj as UnityEngine.Bounds[];
				translator.PushUnityEngineBounds(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray2D[]))
			{
			    UnityEngine.Ray2D[] array = obj as UnityEngine.Ray2D[];
				translator.PushUnityEngineRay2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarTarget[]))
			{
			    UnityEngine.AvatarTarget[] array = obj as UnityEngine.AvatarTarget[];
				translator.PushUnityEngineAvatarTarget(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarIKGoal[]))
			{
			    UnityEngine.AvatarIKGoal[] array = obj as UnityEngine.AvatarIKGoal[];
				translator.PushUnityEngineAvatarIKGoal(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarIKHint[]))
			{
			    UnityEngine.AvatarIKHint[] array = obj as UnityEngine.AvatarIKHint[];
				translator.PushUnityEngineAvatarIKHint(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorControllerParameterType[]))
			{
			    UnityEngine.AnimatorControllerParameterType[] array = obj as UnityEngine.AnimatorControllerParameterType[];
				translator.PushUnityEngineAnimatorControllerParameterType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorRecorderMode[]))
			{
			    UnityEngine.AnimatorRecorderMode[] array = obj as UnityEngine.AnimatorRecorderMode[];
				translator.PushUnityEngineAnimatorRecorderMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.DurationUnit[]))
			{
			    UnityEngine.DurationUnit[] array = obj as UnityEngine.DurationUnit[];
				translator.PushUnityEngineDurationUnit(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorCullingMode[]))
			{
			    UnityEngine.AnimatorCullingMode[] array = obj as UnityEngine.AnimatorCullingMode[];
				translator.PushUnityEngineAnimatorCullingMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorUpdateMode[]))
			{
			    UnityEngine.AnimatorUpdateMode[] array = obj as UnityEngine.AnimatorUpdateMode[];
				translator.PushUnityEngineAnimatorUpdateMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.BodyDof[]))
			{
			    UnityEngine.BodyDof[] array = obj as UnityEngine.BodyDof[];
				translator.PushUnityEngineBodyDof(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.HeadDof[]))
			{
			    UnityEngine.HeadDof[] array = obj as UnityEngine.HeadDof[];
				translator.PushUnityEngineHeadDof(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.LegDof[]))
			{
			    UnityEngine.LegDof[] array = obj as UnityEngine.LegDof[];
				translator.PushUnityEngineLegDof(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ArmDof[]))
			{
			    UnityEngine.ArmDof[] array = obj as UnityEngine.ArmDof[];
				translator.PushUnityEngineArmDof(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.FingerDof[]))
			{
			    UnityEngine.FingerDof[] array = obj as UnityEngine.FingerDof[];
				translator.PushUnityEngineFingerDof(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.HumanPartDof[]))
			{
			    UnityEngine.HumanPartDof[] array = obj as UnityEngine.HumanPartDof[];
				translator.PushUnityEngineHumanPartDof(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.HumanBodyBones[]))
			{
			    UnityEngine.HumanBodyBones[] array = obj as UnityEngine.HumanBodyBones[];
				translator.PushUnityEngineHumanBodyBones(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarMaskBodyPart[]))
			{
			    UnityEngine.AvatarMaskBodyPart[] array = obj as UnityEngine.AvatarMaskBodyPart[];
				translator.PushUnityEngineAvatarMaskBodyPart(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.PlayMode[]))
			{
			    UnityEngine.PlayMode[] array = obj as UnityEngine.PlayMode[];
				translator.PushUnityEnginePlayMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.QueueMode[]))
			{
			    UnityEngine.QueueMode[] array = obj as UnityEngine.QueueMode[];
				translator.PushUnityEngineQueueMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimationBlendMode[]))
			{
			    UnityEngine.AnimationBlendMode[] array = obj as UnityEngine.AnimationBlendMode[];
				translator.PushUnityEngineAnimationBlendMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimationPlayMode[]))
			{
			    UnityEngine.AnimationPlayMode[] array = obj as UnityEngine.AnimationPlayMode[];
				translator.PushUnityEngineAnimationPlayMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimationCullingType[]))
			{
			    UnityEngine.AnimationCullingType[] array = obj as UnityEngine.AnimationCullingType[];
				translator.PushUnityEngineAnimationCullingType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AssetBundleLoadResult[]))
			{
			    UnityEngine.AssetBundleLoadResult[] array = obj as UnityEngine.AssetBundleLoadResult[];
				translator.PushUnityEngineAssetBundleLoadResult(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompressionType[]))
			{
			    UnityEngine.CompressionType[] array = obj as UnityEngine.CompressionType[];
				translator.PushUnityEngineCompressionType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompressionLevel[]))
			{
			    UnityEngine.CompressionLevel[] array = obj as UnityEngine.CompressionLevel[];
				translator.PushUnityEngineCompressionLevel(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioSpeakerMode[]))
			{
			    UnityEngine.AudioSpeakerMode[] array = obj as UnityEngine.AudioSpeakerMode[];
				translator.PushUnityEngineAudioSpeakerMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioDataLoadState[]))
			{
			    UnityEngine.AudioDataLoadState[] array = obj as UnityEngine.AudioDataLoadState[];
				translator.PushUnityEngineAudioDataLoadState(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioCompressionFormat[]))
			{
			    UnityEngine.AudioCompressionFormat[] array = obj as UnityEngine.AudioCompressionFormat[];
				translator.PushUnityEngineAudioCompressionFormat(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioClipLoadType[]))
			{
			    UnityEngine.AudioClipLoadType[] array = obj as UnityEngine.AudioClipLoadType[];
				translator.PushUnityEngineAudioClipLoadType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioVelocityUpdateMode[]))
			{
			    UnityEngine.AudioVelocityUpdateMode[] array = obj as UnityEngine.AudioVelocityUpdateMode[];
				translator.PushUnityEngineAudioVelocityUpdateMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioRolloffMode[]))
			{
			    UnityEngine.AudioRolloffMode[] array = obj as UnityEngine.AudioRolloffMode[];
				translator.PushUnityEngineAudioRolloffMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioSourceCurveType[]))
			{
			    UnityEngine.AudioSourceCurveType[] array = obj as UnityEngine.AudioSourceCurveType[];
				translator.PushUnityEngineAudioSourceCurveType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioReverbPreset[]))
			{
			    UnityEngine.AudioReverbPreset[] array = obj as UnityEngine.AudioReverbPreset[];
				translator.PushUnityEngineAudioReverbPreset(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.WebCamFlags[]))
			{
			    UnityEngine.WebCamFlags[] array = obj as UnityEngine.WebCamFlags[];
				translator.PushUnityEngineWebCamFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.WebCamKind[]))
			{
			    UnityEngine.WebCamKind[] array = obj as UnityEngine.WebCamKind[];
				translator.PushUnityEngineWebCamKind(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SendMessageOptions[]))
			{
			    UnityEngine.SendMessageOptions[] array = obj as UnityEngine.SendMessageOptions[];
				translator.PushUnityEngineSendMessageOptions(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.PrimitiveType[]))
			{
			    UnityEngine.PrimitiveType[] array = obj as UnityEngine.PrimitiveType[];
				translator.PushUnityEnginePrimitiveType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Space[]))
			{
			    UnityEngine.Space[] array = obj as UnityEngine.Space[];
				translator.PushUnityEngineSpace(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RuntimePlatform[]))
			{
			    UnityEngine.RuntimePlatform[] array = obj as UnityEngine.RuntimePlatform[];
				translator.PushUnityEngineRuntimePlatform(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SystemLanguage[]))
			{
			    UnityEngine.SystemLanguage[] array = obj as UnityEngine.SystemLanguage[];
				translator.PushUnityEngineSystemLanguage(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.LogType[]))
			{
			    UnityEngine.LogType[] array = obj as UnityEngine.LogType[];
				translator.PushUnityEngineLogType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.LogOption[]))
			{
			    UnityEngine.LogOption[] array = obj as UnityEngine.LogOption[];
				translator.PushUnityEngineLogOption(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ThreadPriority[]))
			{
			    UnityEngine.ThreadPriority[] array = obj as UnityEngine.ThreadPriority[];
				translator.PushUnityEngineThreadPriority(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.WeightedMode[]))
			{
			    UnityEngine.WeightedMode[] array = obj as UnityEngine.WeightedMode[];
				translator.PushUnityEngineWeightedMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.WrapMode[]))
			{
			    UnityEngine.WrapMode[] array = obj as UnityEngine.WrapMode[];
				translator.PushUnityEngineWrapMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.StackTraceLogType[]))
			{
			    UnityEngine.StackTraceLogType[] array = obj as UnityEngine.StackTraceLogType[];
				translator.PushUnityEngineStackTraceLogType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UserAuthorization[]))
			{
			    UnityEngine.UserAuthorization[] array = obj as UnityEngine.UserAuthorization[];
				translator.PushUnityEngineUserAuthorization(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ApplicationInstallMode[]))
			{
			    UnityEngine.ApplicationInstallMode[] array = obj as UnityEngine.ApplicationInstallMode[];
				translator.PushUnityEngineApplicationInstallMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ApplicationSandboxType[]))
			{
			    UnityEngine.ApplicationSandboxType[] array = obj as UnityEngine.ApplicationSandboxType[];
				translator.PushUnityEngineApplicationSandboxType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioType[]))
			{
			    UnityEngine.AudioType[] array = obj as UnityEngine.AudioType[];
				translator.PushUnityEngineAudioType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.GateFitMode[]))
			{
			    UnityEngine.Camera.GateFitMode[] array = obj as UnityEngine.Camera.GateFitMode[];
				translator.PushUnityEngineCameraGateFitMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.FieldOfViewAxis[]))
			{
			    UnityEngine.Camera.FieldOfViewAxis[] array = obj as UnityEngine.Camera.FieldOfViewAxis[];
				translator.PushUnityEngineCameraFieldOfViewAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.StereoscopicEye[]))
			{
			    UnityEngine.Camera.StereoscopicEye[] array = obj as UnityEngine.Camera.StereoscopicEye[];
				translator.PushUnityEngineCameraStereoscopicEye(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.MonoOrStereoscopicEye[]))
			{
			    UnityEngine.Camera.MonoOrStereoscopicEye[] array = obj as UnityEngine.Camera.MonoOrStereoscopicEye[];
				translator.PushUnityEngineCameraMonoOrStereoscopicEye(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent[]))
			{
			    UnityEngine.ReflectionProbe.ReflectionProbeEvent[] array = obj as UnityEngine.ReflectionProbe.ReflectionProbeEvent[];
				translator.PushUnityEngineReflectionProbeReflectionProbeEvent(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.FullScreenMode[]))
			{
			    UnityEngine.FullScreenMode[] array = obj as UnityEngine.FullScreenMode[];
				translator.PushUnityEngineFullScreenMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ComputeBufferMode[]))
			{
			    UnityEngine.ComputeBufferMode[] array = obj as UnityEngine.ComputeBufferMode[];
				translator.PushUnityEngineComputeBufferMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.D3DHDRDisplayBitDepth[]))
			{
			    UnityEngine.D3DHDRDisplayBitDepth[] array = obj as UnityEngine.D3DHDRDisplayBitDepth[];
				translator.PushUnityEngineD3DHDRDisplayBitDepth(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderingPath[]))
			{
			    UnityEngine.RenderingPath[] array = obj as UnityEngine.RenderingPath[];
				translator.PushUnityEngineRenderingPath(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TransparencySortMode[]))
			{
			    UnityEngine.TransparencySortMode[] array = obj as UnityEngine.TransparencySortMode[];
				translator.PushUnityEngineTransparencySortMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.StereoTargetEyeMask[]))
			{
			    UnityEngine.StereoTargetEyeMask[] array = obj as UnityEngine.StereoTargetEyeMask[];
				translator.PushUnityEngineStereoTargetEyeMask(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CameraType[]))
			{
			    UnityEngine.CameraType[] array = obj as UnityEngine.CameraType[];
				translator.PushUnityEngineCameraType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ComputeBufferType[]))
			{
			    UnityEngine.ComputeBufferType[] array = obj as UnityEngine.ComputeBufferType[];
				translator.PushUnityEngineComputeBufferType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.FogMode[]))
			{
			    UnityEngine.FogMode[] array = obj as UnityEngine.FogMode[];
				translator.PushUnityEngineFogMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ReceiveGI[]))
			{
			    UnityEngine.ReceiveGI[] array = obj as UnityEngine.ReceiveGI[];
				translator.PushUnityEngineReceiveGI(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowProjection[]))
			{
			    UnityEngine.ShadowProjection[] array = obj as UnityEngine.ShadowProjection[];
				translator.PushUnityEngineShadowProjection(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowQuality[]))
			{
			    UnityEngine.ShadowQuality[] array = obj as UnityEngine.ShadowQuality[];
				translator.PushUnityEngineShadowQuality(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowResolution[]))
			{
			    UnityEngine.ShadowResolution[] array = obj as UnityEngine.ShadowResolution[];
				translator.PushUnityEngineShadowResolution(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowmaskMode[]))
			{
			    UnityEngine.ShadowmaskMode[] array = obj as UnityEngine.ShadowmaskMode[];
				translator.PushUnityEngineShadowmaskMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CameraClearFlags[]))
			{
			    UnityEngine.CameraClearFlags[] array = obj as UnityEngine.CameraClearFlags[];
				translator.PushUnityEngineCameraClearFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.DepthTextureMode[]))
			{
			    UnityEngine.DepthTextureMode[] array = obj as UnityEngine.DepthTextureMode[];
				translator.PushUnityEngineDepthTextureMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TexGenMode[]))
			{
			    UnityEngine.TexGenMode[] array = obj as UnityEngine.TexGenMode[];
				translator.PushUnityEngineTexGenMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnisotropicFiltering[]))
			{
			    UnityEngine.AnisotropicFiltering[] array = obj as UnityEngine.AnisotropicFiltering[];
				translator.PushUnityEngineAnisotropicFiltering(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SkinWeights[]))
			{
			    UnityEngine.SkinWeights[] array = obj as UnityEngine.SkinWeights[];
				translator.PushUnityEngineSkinWeights(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.MeshTopology[]))
			{
			    UnityEngine.MeshTopology[] array = obj as UnityEngine.MeshTopology[];
				translator.PushUnityEngineMeshTopology(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SkinQuality[]))
			{
			    UnityEngine.SkinQuality[] array = obj as UnityEngine.SkinQuality[];
				translator.PushUnityEngineSkinQuality(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ColorSpace[]))
			{
			    UnityEngine.ColorSpace[] array = obj as UnityEngine.ColorSpace[];
				translator.PushUnityEngineColorSpace(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ColorGamut[]))
			{
			    UnityEngine.ColorGamut[] array = obj as UnityEngine.ColorGamut[];
				translator.PushUnityEngineColorGamut(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ScreenOrientation[]))
			{
			    UnityEngine.ScreenOrientation[] array = obj as UnityEngine.ScreenOrientation[];
				translator.PushUnityEngineScreenOrientation(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.FilterMode[]))
			{
			    UnityEngine.FilterMode[] array = obj as UnityEngine.FilterMode[];
				translator.PushUnityEngineFilterMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextureWrapMode[]))
			{
			    UnityEngine.TextureWrapMode[] array = obj as UnityEngine.TextureWrapMode[];
				translator.PushUnityEngineTextureWrapMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.NPOTSupport[]))
			{
			    UnityEngine.NPOTSupport[] array = obj as UnityEngine.NPOTSupport[];
				translator.PushUnityEngineNPOTSupport(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextureFormat[]))
			{
			    UnityEngine.TextureFormat[] array = obj as UnityEngine.TextureFormat[];
				translator.PushUnityEngineTextureFormat(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CubemapFace[]))
			{
			    UnityEngine.CubemapFace[] array = obj as UnityEngine.CubemapFace[];
				translator.PushUnityEngineCubemapFace(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureFormat[]))
			{
			    UnityEngine.RenderTextureFormat[] array = obj as UnityEngine.RenderTextureFormat[];
				translator.PushUnityEngineRenderTextureFormat(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.VRTextureUsage[]))
			{
			    UnityEngine.VRTextureUsage[] array = obj as UnityEngine.VRTextureUsage[];
				translator.PushUnityEngineVRTextureUsage(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureCreationFlags[]))
			{
			    UnityEngine.RenderTextureCreationFlags[] array = obj as UnityEngine.RenderTextureCreationFlags[];
				translator.PushUnityEngineRenderTextureCreationFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureReadWrite[]))
			{
			    UnityEngine.RenderTextureReadWrite[] array = obj as UnityEngine.RenderTextureReadWrite[];
				translator.PushUnityEngineRenderTextureReadWrite(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureMemoryless[]))
			{
			    UnityEngine.RenderTextureMemoryless[] array = obj as UnityEngine.RenderTextureMemoryless[];
				translator.PushUnityEngineRenderTextureMemoryless(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.MaterialGlobalIlluminationFlags[]))
			{
			    UnityEngine.MaterialGlobalIlluminationFlags[] array = obj as UnityEngine.MaterialGlobalIlluminationFlags[];
				translator.PushUnityEngineMaterialGlobalIlluminationFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CustomRenderTextureInitializationSource[]))
			{
			    UnityEngine.CustomRenderTextureInitializationSource[] array = obj as UnityEngine.CustomRenderTextureInitializationSource[];
				translator.PushUnityEngineCustomRenderTextureInitializationSource(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CustomRenderTextureUpdateMode[]))
			{
			    UnityEngine.CustomRenderTextureUpdateMode[] array = obj as UnityEngine.CustomRenderTextureUpdateMode[];
				translator.PushUnityEngineCustomRenderTextureUpdateMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace[]))
			{
			    UnityEngine.CustomRenderTextureUpdateZoneSpace[] array = obj as UnityEngine.CustomRenderTextureUpdateZoneSpace[];
				translator.PushUnityEngineCustomRenderTextureUpdateZoneSpace(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.LineTextureMode[]))
			{
			    UnityEngine.LineTextureMode[] array = obj as UnityEngine.LineTextureMode[];
				translator.PushUnityEngineLineTextureMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.LineAlignment[]))
			{
			    UnityEngine.LineAlignment[] array = obj as UnityEngine.LineAlignment[];
				translator.PushUnityEngineLineAlignment(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.LODFadeMode[]))
			{
			    UnityEngine.LODFadeMode[] array = obj as UnityEngine.LODFadeMode[];
				translator.PushUnityEngineLODFadeMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Texture2D.EXRFlags[]))
			{
			    UnityEngine.Texture2D.EXRFlags[] array = obj as UnityEngine.Texture2D.EXRFlags[];
				translator.PushUnityEngineTexture2DEXRFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.KeyCode[]))
			{
			    UnityEngine.KeyCode[] array = obj as UnityEngine.KeyCode[];
				translator.PushUnityEngineKeyCode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.GradientMode[]))
			{
			    UnityEngine.GradientMode[] array = obj as UnityEngine.GradientMode[];
				translator.PushUnityEngineGradientMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RuntimeInitializeLoadType[]))
			{
			    UnityEngine.RuntimeInitializeLoadType[] array = obj as UnityEngine.RuntimeInitializeLoadType[];
				translator.PushUnityEngineRuntimeInitializeLoadType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.HideFlags[]))
			{
			    UnityEngine.HideFlags[] array = obj as UnityEngine.HideFlags[];
				translator.PushUnityEngineHideFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SnapAxis[]))
			{
			    UnityEngine.SnapAxis[] array = obj as UnityEngine.SnapAxis[];
				translator.PushUnityEngineSnapAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.BatteryStatus[]))
			{
			    UnityEngine.BatteryStatus[] array = obj as UnityEngine.BatteryStatus[];
				translator.PushUnityEngineBatteryStatus(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.OperatingSystemFamily[]))
			{
			    UnityEngine.OperatingSystemFamily[] array = obj as UnityEngine.OperatingSystemFamily[];
				translator.PushUnityEngineOperatingSystemFamily(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.DeviceType[]))
			{
			    UnityEngine.DeviceType[] array = obj as UnityEngine.DeviceType[];
				translator.PushUnityEngineDeviceType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.DrivenTransformProperties[]))
			{
			    UnityEngine.DrivenTransformProperties[] array = obj as UnityEngine.DrivenTransformProperties[];
				translator.PushUnityEngineDrivenTransformProperties(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Edge[]))
			{
			    UnityEngine.RectTransform.Edge[] array = obj as UnityEngine.RectTransform.Edge[];
				translator.PushUnityEngineRectTransformEdge(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Axis[]))
			{
			    UnityEngine.RectTransform.Axis[] array = obj as UnityEngine.RectTransform.Axis[];
				translator.PushUnityEngineRectTransformAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteDrawMode[]))
			{
			    UnityEngine.SpriteDrawMode[] array = obj as UnityEngine.SpriteDrawMode[];
				translator.PushUnityEngineSpriteDrawMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteTileMode[]))
			{
			    UnityEngine.SpriteTileMode[] array = obj as UnityEngine.SpriteTileMode[];
				translator.PushUnityEngineSpriteTileMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteMaskInteraction[]))
			{
			    UnityEngine.SpriteMaskInteraction[] array = obj as UnityEngine.SpriteMaskInteraction[];
				translator.PushUnityEngineSpriteMaskInteraction(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteMeshType[]))
			{
			    UnityEngine.SpriteMeshType[] array = obj as UnityEngine.SpriteMeshType[];
				translator.PushUnityEngineSpriteMeshType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteAlignment[]))
			{
			    UnityEngine.SpriteAlignment[] array = obj as UnityEngine.SpriteAlignment[];
				translator.PushUnityEngineSpriteAlignment(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpritePackingMode[]))
			{
			    UnityEngine.SpritePackingMode[] array = obj as UnityEngine.SpritePackingMode[];
				translator.PushUnityEngineSpritePackingMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpritePackingRotation[]))
			{
			    UnityEngine.SpritePackingRotation[] array = obj as UnityEngine.SpritePackingRotation[];
				translator.PushUnityEngineSpritePackingRotation(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteSortPoint[]))
			{
			    UnityEngine.SpriteSortPoint[] array = obj as UnityEngine.SpriteSortPoint[];
				translator.PushUnityEngineSpriteSortPoint(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridLayout.CellLayout[]))
			{
			    UnityEngine.GridLayout.CellLayout[] array = obj as UnityEngine.GridLayout.CellLayout[];
				translator.PushUnityEngineGridLayoutCellLayout(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridLayout.CellSwizzle[]))
			{
			    UnityEngine.GridLayout.CellSwizzle[] array = obj as UnityEngine.GridLayout.CellSwizzle[];
				translator.PushUnityEngineGridLayoutCellSwizzle(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.PointerType[]))
			{
			    UnityEngine.PointerType[] array = obj as UnityEngine.PointerType[];
				translator.PushUnityEnginePointerType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ScaleMode[]))
			{
			    UnityEngine.ScaleMode[] array = obj as UnityEngine.ScaleMode[];
				translator.PushUnityEngineScaleMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.FocusType[]))
			{
			    UnityEngine.FocusType[] array = obj as UnityEngine.FocusType[];
				translator.PushUnityEngineFocusType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ImagePosition[]))
			{
			    UnityEngine.ImagePosition[] array = obj as UnityEngine.ImagePosition[];
				translator.PushUnityEngineImagePosition(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TouchPhase[]))
			{
			    UnityEngine.TouchPhase[] array = obj as UnityEngine.TouchPhase[];
				translator.PushUnityEngineTouchPhase(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.IMECompositionMode[]))
			{
			    UnityEngine.IMECompositionMode[] array = obj as UnityEngine.IMECompositionMode[];
				translator.PushUnityEngineIMECompositionMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TouchType[]))
			{
			    UnityEngine.TouchType[] array = obj as UnityEngine.TouchType[];
				translator.PushUnityEngineTouchType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.DeviceOrientation[]))
			{
			    UnityEngine.DeviceOrientation[] array = obj as UnityEngine.DeviceOrientation[];
				translator.PushUnityEngineDeviceOrientation(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.LocationServiceStatus[]))
			{
			    UnityEngine.LocationServiceStatus[] array = obj as UnityEngine.LocationServiceStatus[];
				translator.PushUnityEngineLocationServiceStatus(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyConstraints[]))
			{
			    UnityEngine.RigidbodyConstraints[] array = obj as UnityEngine.RigidbodyConstraints[];
				translator.PushUnityEngineRigidbodyConstraints(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ForceMode[]))
			{
			    UnityEngine.ForceMode[] array = obj as UnityEngine.ForceMode[];
				translator.PushUnityEngineForceMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.JointProjectionMode[]))
			{
			    UnityEngine.JointProjectionMode[] array = obj as UnityEngine.JointProjectionMode[];
				translator.PushUnityEngineJointProjectionMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.MeshColliderCookingOptions[]))
			{
			    UnityEngine.MeshColliderCookingOptions[] array = obj as UnityEngine.MeshColliderCookingOptions[];
				translator.PushUnityEngineMeshColliderCookingOptions(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyInterpolation[]))
			{
			    UnityEngine.RigidbodyInterpolation[] array = obj as UnityEngine.RigidbodyInterpolation[];
				translator.PushUnityEngineRigidbodyInterpolation(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.PhysicMaterialCombine[]))
			{
			    UnityEngine.PhysicMaterialCombine[] array = obj as UnityEngine.PhysicMaterialCombine[];
				translator.PushUnityEnginePhysicMaterialCombine(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CollisionFlags[]))
			{
			    UnityEngine.CollisionFlags[] array = obj as UnityEngine.CollisionFlags[];
				translator.PushUnityEngineCollisionFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.QueryTriggerInteraction[]))
			{
			    UnityEngine.QueryTriggerInteraction[] array = obj as UnityEngine.QueryTriggerInteraction[];
				translator.PushUnityEngineQueryTriggerInteraction(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CollisionDetectionMode[]))
			{
			    UnityEngine.CollisionDetectionMode[] array = obj as UnityEngine.CollisionDetectionMode[];
				translator.PushUnityEngineCollisionDetectionMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RotationDriveMode[]))
			{
			    UnityEngine.RotationDriveMode[] array = obj as UnityEngine.RotationDriveMode[];
				translator.PushUnityEngineRotationDriveMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CapsuleDirection2D[]))
			{
			    UnityEngine.CapsuleDirection2D[] array = obj as UnityEngine.CapsuleDirection2D[];
				translator.PushUnityEngineCapsuleDirection2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyConstraints2D[]))
			{
			    UnityEngine.RigidbodyConstraints2D[] array = obj as UnityEngine.RigidbodyConstraints2D[];
				translator.PushUnityEngineRigidbodyConstraints2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyInterpolation2D[]))
			{
			    UnityEngine.RigidbodyInterpolation2D[] array = obj as UnityEngine.RigidbodyInterpolation2D[];
				translator.PushUnityEngineRigidbodyInterpolation2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodySleepMode2D[]))
			{
			    UnityEngine.RigidbodySleepMode2D[] array = obj as UnityEngine.RigidbodySleepMode2D[];
				translator.PushUnityEngineRigidbodySleepMode2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CollisionDetectionMode2D[]))
			{
			    UnityEngine.CollisionDetectionMode2D[] array = obj as UnityEngine.CollisionDetectionMode2D[];
				translator.PushUnityEngineCollisionDetectionMode2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyType2D[]))
			{
			    UnityEngine.RigidbodyType2D[] array = obj as UnityEngine.RigidbodyType2D[];
				translator.PushUnityEngineRigidbodyType2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ForceMode2D[]))
			{
			    UnityEngine.ForceMode2D[] array = obj as UnityEngine.ForceMode2D[];
				translator.PushUnityEngineForceMode2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.JointLimitState2D[]))
			{
			    UnityEngine.JointLimitState2D[] array = obj as UnityEngine.JointLimitState2D[];
				translator.PushUnityEngineJointLimitState2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.EffectorSelection2D[]))
			{
			    UnityEngine.EffectorSelection2D[] array = obj as UnityEngine.EffectorSelection2D[];
				translator.PushUnityEngineEffectorSelection2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.EffectorForceMode2D[]))
			{
			    UnityEngine.EffectorForceMode2D[] array = obj as UnityEngine.EffectorForceMode2D[];
				translator.PushUnityEngineEffectorForceMode2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompositeCollider2D.GeometryType[]))
			{
			    UnityEngine.CompositeCollider2D.GeometryType[] array = obj as UnityEngine.CompositeCollider2D.GeometryType[];
				translator.PushUnityEngineCompositeCollider2DGeometryType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompositeCollider2D.GenerationType[]))
			{
			    UnityEngine.CompositeCollider2D.GenerationType[] array = obj as UnityEngine.CompositeCollider2D.GenerationType[];
				translator.PushUnityEngineCompositeCollider2DGenerationType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode[]))
			{
			    UnityEngine.ScreenCapture.StereoScreenCaptureMode[] array = obj as UnityEngine.ScreenCapture.StereoScreenCaptureMode[];
				translator.PushUnityEngineScreenCaptureStereoScreenCaptureMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextAnchor[]))
			{
			    UnityEngine.TextAnchor[] array = obj as UnityEngine.TextAnchor[];
				translator.PushUnityEngineTextAnchor(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.HorizontalWrapMode[]))
			{
			    UnityEngine.HorizontalWrapMode[] array = obj as UnityEngine.HorizontalWrapMode[];
				translator.PushUnityEngineHorizontalWrapMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.VerticalWrapMode[]))
			{
			    UnityEngine.VerticalWrapMode[] array = obj as UnityEngine.VerticalWrapMode[];
				translator.PushUnityEngineVerticalWrapMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridBrushBase.Tool[]))
			{
			    UnityEngine.GridBrushBase.Tool[] array = obj as UnityEngine.GridBrushBase.Tool[];
				translator.PushUnityEngineGridBrushBaseTool(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridBrushBase.RotationDirection[]))
			{
			    UnityEngine.GridBrushBase.RotationDirection[] array = obj as UnityEngine.GridBrushBase.RotationDirection[];
				translator.PushUnityEngineGridBrushBaseRotationDirection(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridBrushBase.FlipAxis[]))
			{
			    UnityEngine.GridBrushBase.FlipAxis[] array = obj as UnityEngine.GridBrushBase.FlipAxis[];
				translator.PushUnityEngineGridBrushBaseFlipAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderMode[]))
			{
			    UnityEngine.RenderMode[] array = obj as UnityEngine.RenderMode[];
				translator.PushUnityEngineRenderMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.AdditionalCanvasShaderChannels[]))
			{
			    UnityEngine.AdditionalCanvasShaderChannels[] array = obj as UnityEngine.AdditionalCanvasShaderChannels[];
				translator.PushUnityEngineAdditionalCanvasShaderChannels(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UISystemProfilerApi.SampleType[]))
			{
			    UnityEngine.UISystemProfilerApi.SampleType[] array = obj as UnityEngine.UISystemProfilerApi.SampleType[];
				translator.PushUnityEngineUISystemProfilerApiSampleType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.WindZoneMode[]))
			{
			    UnityEngine.WindZoneMode[] array = obj as UnityEngine.WindZoneMode[];
				translator.PushUnityEngineWindZoneMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasUpdate[]))
			{
			    UnityEngine.UI.CanvasUpdate[] array = obj as UnityEngine.UI.CanvasUpdate[];
				translator.PushUnityEngineUICanvasUpdate(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Type[]))
			{
			    UnityEngine.UI.Image.Type[] array = obj as UnityEngine.UI.Image.Type[];
				translator.PushUnityEngineUIImageType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.FillMethod[]))
			{
			    UnityEngine.UI.Image.FillMethod[] array = obj as UnityEngine.UI.Image.FillMethod[];
				translator.PushUnityEngineUIImageFillMethod(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginHorizontal[]))
			{
			    UnityEngine.UI.Image.OriginHorizontal[] array = obj as UnityEngine.UI.Image.OriginHorizontal[];
				translator.PushUnityEngineUIImageOriginHorizontal(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginVertical[]))
			{
			    UnityEngine.UI.Image.OriginVertical[] array = obj as UnityEngine.UI.Image.OriginVertical[];
				translator.PushUnityEngineUIImageOriginVertical(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin90[]))
			{
			    UnityEngine.UI.Image.Origin90[] array = obj as UnityEngine.UI.Image.Origin90[];
				translator.PushUnityEngineUIImageOrigin90(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin180[]))
			{
			    UnityEngine.UI.Image.Origin180[] array = obj as UnityEngine.UI.Image.Origin180[];
				translator.PushUnityEngineUIImageOrigin180(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin360[]))
			{
			    UnityEngine.UI.Image.Origin360[] array = obj as UnityEngine.UI.Image.Origin360[];
				translator.PushUnityEngineUIImageOrigin360(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.ContentType[]))
			{
			    UnityEngine.UI.InputField.ContentType[] array = obj as UnityEngine.UI.InputField.ContentType[];
				translator.PushUnityEngineUIInputFieldContentType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.InputType[]))
			{
			    UnityEngine.UI.InputField.InputType[] array = obj as UnityEngine.UI.InputField.InputType[];
				translator.PushUnityEngineUIInputFieldInputType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.CharacterValidation[]))
			{
			    UnityEngine.UI.InputField.CharacterValidation[] array = obj as UnityEngine.UI.InputField.CharacterValidation[];
				translator.PushUnityEngineUIInputFieldCharacterValidation(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.LineType[]))
			{
			    UnityEngine.UI.InputField.LineType[] array = obj as UnityEngine.UI.InputField.LineType[];
				translator.PushUnityEngineUIInputFieldLineType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.AspectRatioFitter.AspectMode[]))
			{
			    UnityEngine.UI.AspectRatioFitter.AspectMode[] array = obj as UnityEngine.UI.AspectRatioFitter.AspectMode[];
				translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScaleMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScaleMode[] array = obj as UnityEngine.UI.CanvasScaler.ScaleMode[];
				translator.PushUnityEngineUICanvasScalerScaleMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScreenMatchMode[] array = obj as UnityEngine.UI.CanvasScaler.ScreenMatchMode[];
				translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.Unit[]))
			{
			    UnityEngine.UI.CanvasScaler.Unit[] array = obj as UnityEngine.UI.CanvasScaler.Unit[];
				translator.PushUnityEngineUICanvasScalerUnit(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ContentSizeFitter.FitMode[]))
			{
			    UnityEngine.UI.ContentSizeFitter.FitMode[] array = obj as UnityEngine.UI.ContentSizeFitter.FitMode[];
				translator.PushUnityEngineUIContentSizeFitterFitMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Corner[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Corner[] array = obj as UnityEngine.UI.GridLayoutGroup.Corner[];
				translator.PushUnityEngineUIGridLayoutGroupCorner(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Axis[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Axis[] array = obj as UnityEngine.UI.GridLayoutGroup.Axis[];
				translator.PushUnityEngineUIGridLayoutGroupAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Constraint[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Constraint[] array = obj as UnityEngine.UI.GridLayoutGroup.Constraint[];
				translator.PushUnityEngineUIGridLayoutGroupConstraint(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Navigation.Mode[]))
			{
			    UnityEngine.UI.Navigation.Mode[] array = obj as UnityEngine.UI.Navigation.Mode[];
				translator.PushUnityEngineUINavigationMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.MovementType[]))
			{
			    UnityEngine.UI.ScrollRect.MovementType[] array = obj as UnityEngine.UI.ScrollRect.MovementType[];
				translator.PushUnityEngineUIScrollRectMovementType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility[]))
			{
			    UnityEngine.UI.ScrollRect.ScrollbarVisibility[] array = obj as UnityEngine.UI.ScrollRect.ScrollbarVisibility[];
				translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Scrollbar.Direction[]))
			{
			    UnityEngine.UI.Scrollbar.Direction[] array = obj as UnityEngine.UI.Scrollbar.Direction[];
				translator.PushUnityEngineUIScrollbarDirection(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Selectable.Transition[]))
			{
			    UnityEngine.UI.Selectable.Transition[] array = obj as UnityEngine.UI.Selectable.Transition[];
				translator.PushUnityEngineUISelectableTransition(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Slider.Direction[]))
			{
			    UnityEngine.UI.Slider.Direction[] array = obj as UnityEngine.UI.Slider.Direction[];
				translator.PushUnityEngineUISliderDirection(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Toggle.ToggleTransition[]))
			{
			    UnityEngine.UI.Toggle.ToggleTransition[] array = obj as UnityEngine.UI.Toggle.ToggleTransition[];
				translator.PushUnityEngineUIToggleToggleTransition(L, array[index]);
				return true;
			}
			else if (type == typeof(XDebug.Orient[]))
			{
			    XDebug.Orient[] array = obj as XDebug.Orient[];
				translator.PushXDebugOrient(L, array[index]);
				return true;
			}
			else if (type == typeof(XDebug.Location.Align[]))
			{
			    XDebug.Location.Align[] array = obj as XDebug.Location.Align[];
				translator.PushXDebugLocationAlign(L, array[index]);
				return true;
			}
			else if (type == typeof(XDebug.Module.Type[]))
			{
			    XDebug.Module.Type[] array = obj as XDebug.Module.Type[];
				translator.PushXDebugModuleType(L, array[index]);
				return true;
			}
			else if (type == typeof(XDebug.XLog.LogLevel[]))
			{
			    XDebug.XLog.LogLevel[] array = obj as XDebug.XLog.LogLevel[];
				translator.PushXDebugXLogLogLevel(L, array[index]);
				return true;
			}
            return false;
		}
		
		internal static bool __tryArraySet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx)
		{
		
			if (type == typeof(UnityEngine.Vector2[]))
			{
			    UnityEngine.Vector2[] array = obj as UnityEngine.Vector2[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector3[]))
			{
			    UnityEngine.Vector3[] array = obj as UnityEngine.Vector3[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector4[]))
			{
			    UnityEngine.Vector4[] array = obj as UnityEngine.Vector4[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Color[]))
			{
			    UnityEngine.Color[] array = obj as UnityEngine.Color[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Quaternion[]))
			{
			    UnityEngine.Quaternion[] array = obj as UnityEngine.Quaternion[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray[]))
			{
			    UnityEngine.Ray[] array = obj as UnityEngine.Ray[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Bounds[]))
			{
			    UnityEngine.Bounds[] array = obj as UnityEngine.Bounds[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray2D[]))
			{
			    UnityEngine.Ray2D[] array = obj as UnityEngine.Ray2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarTarget[]))
			{
			    UnityEngine.AvatarTarget[] array = obj as UnityEngine.AvatarTarget[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarIKGoal[]))
			{
			    UnityEngine.AvatarIKGoal[] array = obj as UnityEngine.AvatarIKGoal[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarIKHint[]))
			{
			    UnityEngine.AvatarIKHint[] array = obj as UnityEngine.AvatarIKHint[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorControllerParameterType[]))
			{
			    UnityEngine.AnimatorControllerParameterType[] array = obj as UnityEngine.AnimatorControllerParameterType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorRecorderMode[]))
			{
			    UnityEngine.AnimatorRecorderMode[] array = obj as UnityEngine.AnimatorRecorderMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.DurationUnit[]))
			{
			    UnityEngine.DurationUnit[] array = obj as UnityEngine.DurationUnit[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorCullingMode[]))
			{
			    UnityEngine.AnimatorCullingMode[] array = obj as UnityEngine.AnimatorCullingMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimatorUpdateMode[]))
			{
			    UnityEngine.AnimatorUpdateMode[] array = obj as UnityEngine.AnimatorUpdateMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.BodyDof[]))
			{
			    UnityEngine.BodyDof[] array = obj as UnityEngine.BodyDof[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.HeadDof[]))
			{
			    UnityEngine.HeadDof[] array = obj as UnityEngine.HeadDof[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.LegDof[]))
			{
			    UnityEngine.LegDof[] array = obj as UnityEngine.LegDof[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ArmDof[]))
			{
			    UnityEngine.ArmDof[] array = obj as UnityEngine.ArmDof[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.FingerDof[]))
			{
			    UnityEngine.FingerDof[] array = obj as UnityEngine.FingerDof[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.HumanPartDof[]))
			{
			    UnityEngine.HumanPartDof[] array = obj as UnityEngine.HumanPartDof[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.HumanBodyBones[]))
			{
			    UnityEngine.HumanBodyBones[] array = obj as UnityEngine.HumanBodyBones[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AvatarMaskBodyPart[]))
			{
			    UnityEngine.AvatarMaskBodyPart[] array = obj as UnityEngine.AvatarMaskBodyPart[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.PlayMode[]))
			{
			    UnityEngine.PlayMode[] array = obj as UnityEngine.PlayMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.QueueMode[]))
			{
			    UnityEngine.QueueMode[] array = obj as UnityEngine.QueueMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimationBlendMode[]))
			{
			    UnityEngine.AnimationBlendMode[] array = obj as UnityEngine.AnimationBlendMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimationPlayMode[]))
			{
			    UnityEngine.AnimationPlayMode[] array = obj as UnityEngine.AnimationPlayMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnimationCullingType[]))
			{
			    UnityEngine.AnimationCullingType[] array = obj as UnityEngine.AnimationCullingType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AssetBundleLoadResult[]))
			{
			    UnityEngine.AssetBundleLoadResult[] array = obj as UnityEngine.AssetBundleLoadResult[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompressionType[]))
			{
			    UnityEngine.CompressionType[] array = obj as UnityEngine.CompressionType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompressionLevel[]))
			{
			    UnityEngine.CompressionLevel[] array = obj as UnityEngine.CompressionLevel[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioSpeakerMode[]))
			{
			    UnityEngine.AudioSpeakerMode[] array = obj as UnityEngine.AudioSpeakerMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioDataLoadState[]))
			{
			    UnityEngine.AudioDataLoadState[] array = obj as UnityEngine.AudioDataLoadState[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioCompressionFormat[]))
			{
			    UnityEngine.AudioCompressionFormat[] array = obj as UnityEngine.AudioCompressionFormat[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioClipLoadType[]))
			{
			    UnityEngine.AudioClipLoadType[] array = obj as UnityEngine.AudioClipLoadType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioVelocityUpdateMode[]))
			{
			    UnityEngine.AudioVelocityUpdateMode[] array = obj as UnityEngine.AudioVelocityUpdateMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioRolloffMode[]))
			{
			    UnityEngine.AudioRolloffMode[] array = obj as UnityEngine.AudioRolloffMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioSourceCurveType[]))
			{
			    UnityEngine.AudioSourceCurveType[] array = obj as UnityEngine.AudioSourceCurveType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioReverbPreset[]))
			{
			    UnityEngine.AudioReverbPreset[] array = obj as UnityEngine.AudioReverbPreset[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.WebCamFlags[]))
			{
			    UnityEngine.WebCamFlags[] array = obj as UnityEngine.WebCamFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.WebCamKind[]))
			{
			    UnityEngine.WebCamKind[] array = obj as UnityEngine.WebCamKind[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SendMessageOptions[]))
			{
			    UnityEngine.SendMessageOptions[] array = obj as UnityEngine.SendMessageOptions[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.PrimitiveType[]))
			{
			    UnityEngine.PrimitiveType[] array = obj as UnityEngine.PrimitiveType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Space[]))
			{
			    UnityEngine.Space[] array = obj as UnityEngine.Space[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RuntimePlatform[]))
			{
			    UnityEngine.RuntimePlatform[] array = obj as UnityEngine.RuntimePlatform[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SystemLanguage[]))
			{
			    UnityEngine.SystemLanguage[] array = obj as UnityEngine.SystemLanguage[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.LogType[]))
			{
			    UnityEngine.LogType[] array = obj as UnityEngine.LogType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.LogOption[]))
			{
			    UnityEngine.LogOption[] array = obj as UnityEngine.LogOption[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ThreadPriority[]))
			{
			    UnityEngine.ThreadPriority[] array = obj as UnityEngine.ThreadPriority[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.WeightedMode[]))
			{
			    UnityEngine.WeightedMode[] array = obj as UnityEngine.WeightedMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.WrapMode[]))
			{
			    UnityEngine.WrapMode[] array = obj as UnityEngine.WrapMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.StackTraceLogType[]))
			{
			    UnityEngine.StackTraceLogType[] array = obj as UnityEngine.StackTraceLogType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UserAuthorization[]))
			{
			    UnityEngine.UserAuthorization[] array = obj as UnityEngine.UserAuthorization[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ApplicationInstallMode[]))
			{
			    UnityEngine.ApplicationInstallMode[] array = obj as UnityEngine.ApplicationInstallMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ApplicationSandboxType[]))
			{
			    UnityEngine.ApplicationSandboxType[] array = obj as UnityEngine.ApplicationSandboxType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AudioType[]))
			{
			    UnityEngine.AudioType[] array = obj as UnityEngine.AudioType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.GateFitMode[]))
			{
			    UnityEngine.Camera.GateFitMode[] array = obj as UnityEngine.Camera.GateFitMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.FieldOfViewAxis[]))
			{
			    UnityEngine.Camera.FieldOfViewAxis[] array = obj as UnityEngine.Camera.FieldOfViewAxis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.StereoscopicEye[]))
			{
			    UnityEngine.Camera.StereoscopicEye[] array = obj as UnityEngine.Camera.StereoscopicEye[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Camera.MonoOrStereoscopicEye[]))
			{
			    UnityEngine.Camera.MonoOrStereoscopicEye[] array = obj as UnityEngine.Camera.MonoOrStereoscopicEye[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ReflectionProbe.ReflectionProbeEvent[]))
			{
			    UnityEngine.ReflectionProbe.ReflectionProbeEvent[] array = obj as UnityEngine.ReflectionProbe.ReflectionProbeEvent[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.FullScreenMode[]))
			{
			    UnityEngine.FullScreenMode[] array = obj as UnityEngine.FullScreenMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ComputeBufferMode[]))
			{
			    UnityEngine.ComputeBufferMode[] array = obj as UnityEngine.ComputeBufferMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.D3DHDRDisplayBitDepth[]))
			{
			    UnityEngine.D3DHDRDisplayBitDepth[] array = obj as UnityEngine.D3DHDRDisplayBitDepth[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderingPath[]))
			{
			    UnityEngine.RenderingPath[] array = obj as UnityEngine.RenderingPath[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TransparencySortMode[]))
			{
			    UnityEngine.TransparencySortMode[] array = obj as UnityEngine.TransparencySortMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.StereoTargetEyeMask[]))
			{
			    UnityEngine.StereoTargetEyeMask[] array = obj as UnityEngine.StereoTargetEyeMask[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CameraType[]))
			{
			    UnityEngine.CameraType[] array = obj as UnityEngine.CameraType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ComputeBufferType[]))
			{
			    UnityEngine.ComputeBufferType[] array = obj as UnityEngine.ComputeBufferType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.FogMode[]))
			{
			    UnityEngine.FogMode[] array = obj as UnityEngine.FogMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ReceiveGI[]))
			{
			    UnityEngine.ReceiveGI[] array = obj as UnityEngine.ReceiveGI[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowProjection[]))
			{
			    UnityEngine.ShadowProjection[] array = obj as UnityEngine.ShadowProjection[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowQuality[]))
			{
			    UnityEngine.ShadowQuality[] array = obj as UnityEngine.ShadowQuality[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowResolution[]))
			{
			    UnityEngine.ShadowResolution[] array = obj as UnityEngine.ShadowResolution[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ShadowmaskMode[]))
			{
			    UnityEngine.ShadowmaskMode[] array = obj as UnityEngine.ShadowmaskMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CameraClearFlags[]))
			{
			    UnityEngine.CameraClearFlags[] array = obj as UnityEngine.CameraClearFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.DepthTextureMode[]))
			{
			    UnityEngine.DepthTextureMode[] array = obj as UnityEngine.DepthTextureMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TexGenMode[]))
			{
			    UnityEngine.TexGenMode[] array = obj as UnityEngine.TexGenMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AnisotropicFiltering[]))
			{
			    UnityEngine.AnisotropicFiltering[] array = obj as UnityEngine.AnisotropicFiltering[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SkinWeights[]))
			{
			    UnityEngine.SkinWeights[] array = obj as UnityEngine.SkinWeights[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.MeshTopology[]))
			{
			    UnityEngine.MeshTopology[] array = obj as UnityEngine.MeshTopology[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SkinQuality[]))
			{
			    UnityEngine.SkinQuality[] array = obj as UnityEngine.SkinQuality[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ColorSpace[]))
			{
			    UnityEngine.ColorSpace[] array = obj as UnityEngine.ColorSpace[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ColorGamut[]))
			{
			    UnityEngine.ColorGamut[] array = obj as UnityEngine.ColorGamut[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ScreenOrientation[]))
			{
			    UnityEngine.ScreenOrientation[] array = obj as UnityEngine.ScreenOrientation[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.FilterMode[]))
			{
			    UnityEngine.FilterMode[] array = obj as UnityEngine.FilterMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextureWrapMode[]))
			{
			    UnityEngine.TextureWrapMode[] array = obj as UnityEngine.TextureWrapMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.NPOTSupport[]))
			{
			    UnityEngine.NPOTSupport[] array = obj as UnityEngine.NPOTSupport[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextureFormat[]))
			{
			    UnityEngine.TextureFormat[] array = obj as UnityEngine.TextureFormat[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CubemapFace[]))
			{
			    UnityEngine.CubemapFace[] array = obj as UnityEngine.CubemapFace[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureFormat[]))
			{
			    UnityEngine.RenderTextureFormat[] array = obj as UnityEngine.RenderTextureFormat[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.VRTextureUsage[]))
			{
			    UnityEngine.VRTextureUsage[] array = obj as UnityEngine.VRTextureUsage[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureCreationFlags[]))
			{
			    UnityEngine.RenderTextureCreationFlags[] array = obj as UnityEngine.RenderTextureCreationFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureReadWrite[]))
			{
			    UnityEngine.RenderTextureReadWrite[] array = obj as UnityEngine.RenderTextureReadWrite[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderTextureMemoryless[]))
			{
			    UnityEngine.RenderTextureMemoryless[] array = obj as UnityEngine.RenderTextureMemoryless[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.MaterialGlobalIlluminationFlags[]))
			{
			    UnityEngine.MaterialGlobalIlluminationFlags[] array = obj as UnityEngine.MaterialGlobalIlluminationFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CustomRenderTextureInitializationSource[]))
			{
			    UnityEngine.CustomRenderTextureInitializationSource[] array = obj as UnityEngine.CustomRenderTextureInitializationSource[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CustomRenderTextureUpdateMode[]))
			{
			    UnityEngine.CustomRenderTextureUpdateMode[] array = obj as UnityEngine.CustomRenderTextureUpdateMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CustomRenderTextureUpdateZoneSpace[]))
			{
			    UnityEngine.CustomRenderTextureUpdateZoneSpace[] array = obj as UnityEngine.CustomRenderTextureUpdateZoneSpace[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.LineTextureMode[]))
			{
			    UnityEngine.LineTextureMode[] array = obj as UnityEngine.LineTextureMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.LineAlignment[]))
			{
			    UnityEngine.LineAlignment[] array = obj as UnityEngine.LineAlignment[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.LODFadeMode[]))
			{
			    UnityEngine.LODFadeMode[] array = obj as UnityEngine.LODFadeMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Texture2D.EXRFlags[]))
			{
			    UnityEngine.Texture2D.EXRFlags[] array = obj as UnityEngine.Texture2D.EXRFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.KeyCode[]))
			{
			    UnityEngine.KeyCode[] array = obj as UnityEngine.KeyCode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.GradientMode[]))
			{
			    UnityEngine.GradientMode[] array = obj as UnityEngine.GradientMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RuntimeInitializeLoadType[]))
			{
			    UnityEngine.RuntimeInitializeLoadType[] array = obj as UnityEngine.RuntimeInitializeLoadType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.HideFlags[]))
			{
			    UnityEngine.HideFlags[] array = obj as UnityEngine.HideFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SnapAxis[]))
			{
			    UnityEngine.SnapAxis[] array = obj as UnityEngine.SnapAxis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.BatteryStatus[]))
			{
			    UnityEngine.BatteryStatus[] array = obj as UnityEngine.BatteryStatus[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.OperatingSystemFamily[]))
			{
			    UnityEngine.OperatingSystemFamily[] array = obj as UnityEngine.OperatingSystemFamily[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.DeviceType[]))
			{
			    UnityEngine.DeviceType[] array = obj as UnityEngine.DeviceType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.DrivenTransformProperties[]))
			{
			    UnityEngine.DrivenTransformProperties[] array = obj as UnityEngine.DrivenTransformProperties[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Edge[]))
			{
			    UnityEngine.RectTransform.Edge[] array = obj as UnityEngine.RectTransform.Edge[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Axis[]))
			{
			    UnityEngine.RectTransform.Axis[] array = obj as UnityEngine.RectTransform.Axis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteDrawMode[]))
			{
			    UnityEngine.SpriteDrawMode[] array = obj as UnityEngine.SpriteDrawMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteTileMode[]))
			{
			    UnityEngine.SpriteTileMode[] array = obj as UnityEngine.SpriteTileMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteMaskInteraction[]))
			{
			    UnityEngine.SpriteMaskInteraction[] array = obj as UnityEngine.SpriteMaskInteraction[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteMeshType[]))
			{
			    UnityEngine.SpriteMeshType[] array = obj as UnityEngine.SpriteMeshType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteAlignment[]))
			{
			    UnityEngine.SpriteAlignment[] array = obj as UnityEngine.SpriteAlignment[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpritePackingMode[]))
			{
			    UnityEngine.SpritePackingMode[] array = obj as UnityEngine.SpritePackingMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpritePackingRotation[]))
			{
			    UnityEngine.SpritePackingRotation[] array = obj as UnityEngine.SpritePackingRotation[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.SpriteSortPoint[]))
			{
			    UnityEngine.SpriteSortPoint[] array = obj as UnityEngine.SpriteSortPoint[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridLayout.CellLayout[]))
			{
			    UnityEngine.GridLayout.CellLayout[] array = obj as UnityEngine.GridLayout.CellLayout[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridLayout.CellSwizzle[]))
			{
			    UnityEngine.GridLayout.CellSwizzle[] array = obj as UnityEngine.GridLayout.CellSwizzle[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.PointerType[]))
			{
			    UnityEngine.PointerType[] array = obj as UnityEngine.PointerType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ScaleMode[]))
			{
			    UnityEngine.ScaleMode[] array = obj as UnityEngine.ScaleMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.FocusType[]))
			{
			    UnityEngine.FocusType[] array = obj as UnityEngine.FocusType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ImagePosition[]))
			{
			    UnityEngine.ImagePosition[] array = obj as UnityEngine.ImagePosition[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TouchPhase[]))
			{
			    UnityEngine.TouchPhase[] array = obj as UnityEngine.TouchPhase[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.IMECompositionMode[]))
			{
			    UnityEngine.IMECompositionMode[] array = obj as UnityEngine.IMECompositionMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TouchType[]))
			{
			    UnityEngine.TouchType[] array = obj as UnityEngine.TouchType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.DeviceOrientation[]))
			{
			    UnityEngine.DeviceOrientation[] array = obj as UnityEngine.DeviceOrientation[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.LocationServiceStatus[]))
			{
			    UnityEngine.LocationServiceStatus[] array = obj as UnityEngine.LocationServiceStatus[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyConstraints[]))
			{
			    UnityEngine.RigidbodyConstraints[] array = obj as UnityEngine.RigidbodyConstraints[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ForceMode[]))
			{
			    UnityEngine.ForceMode[] array = obj as UnityEngine.ForceMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.JointProjectionMode[]))
			{
			    UnityEngine.JointProjectionMode[] array = obj as UnityEngine.JointProjectionMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.MeshColliderCookingOptions[]))
			{
			    UnityEngine.MeshColliderCookingOptions[] array = obj as UnityEngine.MeshColliderCookingOptions[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyInterpolation[]))
			{
			    UnityEngine.RigidbodyInterpolation[] array = obj as UnityEngine.RigidbodyInterpolation[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.PhysicMaterialCombine[]))
			{
			    UnityEngine.PhysicMaterialCombine[] array = obj as UnityEngine.PhysicMaterialCombine[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CollisionFlags[]))
			{
			    UnityEngine.CollisionFlags[] array = obj as UnityEngine.CollisionFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.QueryTriggerInteraction[]))
			{
			    UnityEngine.QueryTriggerInteraction[] array = obj as UnityEngine.QueryTriggerInteraction[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CollisionDetectionMode[]))
			{
			    UnityEngine.CollisionDetectionMode[] array = obj as UnityEngine.CollisionDetectionMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RotationDriveMode[]))
			{
			    UnityEngine.RotationDriveMode[] array = obj as UnityEngine.RotationDriveMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CapsuleDirection2D[]))
			{
			    UnityEngine.CapsuleDirection2D[] array = obj as UnityEngine.CapsuleDirection2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyConstraints2D[]))
			{
			    UnityEngine.RigidbodyConstraints2D[] array = obj as UnityEngine.RigidbodyConstraints2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyInterpolation2D[]))
			{
			    UnityEngine.RigidbodyInterpolation2D[] array = obj as UnityEngine.RigidbodyInterpolation2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodySleepMode2D[]))
			{
			    UnityEngine.RigidbodySleepMode2D[] array = obj as UnityEngine.RigidbodySleepMode2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CollisionDetectionMode2D[]))
			{
			    UnityEngine.CollisionDetectionMode2D[] array = obj as UnityEngine.CollisionDetectionMode2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RigidbodyType2D[]))
			{
			    UnityEngine.RigidbodyType2D[] array = obj as UnityEngine.RigidbodyType2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ForceMode2D[]))
			{
			    UnityEngine.ForceMode2D[] array = obj as UnityEngine.ForceMode2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.JointLimitState2D[]))
			{
			    UnityEngine.JointLimitState2D[] array = obj as UnityEngine.JointLimitState2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.EffectorSelection2D[]))
			{
			    UnityEngine.EffectorSelection2D[] array = obj as UnityEngine.EffectorSelection2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.EffectorForceMode2D[]))
			{
			    UnityEngine.EffectorForceMode2D[] array = obj as UnityEngine.EffectorForceMode2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompositeCollider2D.GeometryType[]))
			{
			    UnityEngine.CompositeCollider2D.GeometryType[] array = obj as UnityEngine.CompositeCollider2D.GeometryType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.CompositeCollider2D.GenerationType[]))
			{
			    UnityEngine.CompositeCollider2D.GenerationType[] array = obj as UnityEngine.CompositeCollider2D.GenerationType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.ScreenCapture.StereoScreenCaptureMode[]))
			{
			    UnityEngine.ScreenCapture.StereoScreenCaptureMode[] array = obj as UnityEngine.ScreenCapture.StereoScreenCaptureMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextAnchor[]))
			{
			    UnityEngine.TextAnchor[] array = obj as UnityEngine.TextAnchor[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.HorizontalWrapMode[]))
			{
			    UnityEngine.HorizontalWrapMode[] array = obj as UnityEngine.HorizontalWrapMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.VerticalWrapMode[]))
			{
			    UnityEngine.VerticalWrapMode[] array = obj as UnityEngine.VerticalWrapMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridBrushBase.Tool[]))
			{
			    UnityEngine.GridBrushBase.Tool[] array = obj as UnityEngine.GridBrushBase.Tool[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridBrushBase.RotationDirection[]))
			{
			    UnityEngine.GridBrushBase.RotationDirection[] array = obj as UnityEngine.GridBrushBase.RotationDirection[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.GridBrushBase.FlipAxis[]))
			{
			    UnityEngine.GridBrushBase.FlipAxis[] array = obj as UnityEngine.GridBrushBase.FlipAxis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RenderMode[]))
			{
			    UnityEngine.RenderMode[] array = obj as UnityEngine.RenderMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.AdditionalCanvasShaderChannels[]))
			{
			    UnityEngine.AdditionalCanvasShaderChannels[] array = obj as UnityEngine.AdditionalCanvasShaderChannels[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UISystemProfilerApi.SampleType[]))
			{
			    UnityEngine.UISystemProfilerApi.SampleType[] array = obj as UnityEngine.UISystemProfilerApi.SampleType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.WindZoneMode[]))
			{
			    UnityEngine.WindZoneMode[] array = obj as UnityEngine.WindZoneMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasUpdate[]))
			{
			    UnityEngine.UI.CanvasUpdate[] array = obj as UnityEngine.UI.CanvasUpdate[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Type[]))
			{
			    UnityEngine.UI.Image.Type[] array = obj as UnityEngine.UI.Image.Type[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.FillMethod[]))
			{
			    UnityEngine.UI.Image.FillMethod[] array = obj as UnityEngine.UI.Image.FillMethod[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginHorizontal[]))
			{
			    UnityEngine.UI.Image.OriginHorizontal[] array = obj as UnityEngine.UI.Image.OriginHorizontal[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginVertical[]))
			{
			    UnityEngine.UI.Image.OriginVertical[] array = obj as UnityEngine.UI.Image.OriginVertical[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin90[]))
			{
			    UnityEngine.UI.Image.Origin90[] array = obj as UnityEngine.UI.Image.Origin90[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin180[]))
			{
			    UnityEngine.UI.Image.Origin180[] array = obj as UnityEngine.UI.Image.Origin180[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin360[]))
			{
			    UnityEngine.UI.Image.Origin360[] array = obj as UnityEngine.UI.Image.Origin360[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.ContentType[]))
			{
			    UnityEngine.UI.InputField.ContentType[] array = obj as UnityEngine.UI.InputField.ContentType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.InputType[]))
			{
			    UnityEngine.UI.InputField.InputType[] array = obj as UnityEngine.UI.InputField.InputType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.CharacterValidation[]))
			{
			    UnityEngine.UI.InputField.CharacterValidation[] array = obj as UnityEngine.UI.InputField.CharacterValidation[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.LineType[]))
			{
			    UnityEngine.UI.InputField.LineType[] array = obj as UnityEngine.UI.InputField.LineType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.AspectRatioFitter.AspectMode[]))
			{
			    UnityEngine.UI.AspectRatioFitter.AspectMode[] array = obj as UnityEngine.UI.AspectRatioFitter.AspectMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScaleMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScaleMode[] array = obj as UnityEngine.UI.CanvasScaler.ScaleMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScreenMatchMode[] array = obj as UnityEngine.UI.CanvasScaler.ScreenMatchMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.Unit[]))
			{
			    UnityEngine.UI.CanvasScaler.Unit[] array = obj as UnityEngine.UI.CanvasScaler.Unit[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ContentSizeFitter.FitMode[]))
			{
			    UnityEngine.UI.ContentSizeFitter.FitMode[] array = obj as UnityEngine.UI.ContentSizeFitter.FitMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Corner[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Corner[] array = obj as UnityEngine.UI.GridLayoutGroup.Corner[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Axis[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Axis[] array = obj as UnityEngine.UI.GridLayoutGroup.Axis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Constraint[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Constraint[] array = obj as UnityEngine.UI.GridLayoutGroup.Constraint[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Navigation.Mode[]))
			{
			    UnityEngine.UI.Navigation.Mode[] array = obj as UnityEngine.UI.Navigation.Mode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.MovementType[]))
			{
			    UnityEngine.UI.ScrollRect.MovementType[] array = obj as UnityEngine.UI.ScrollRect.MovementType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility[]))
			{
			    UnityEngine.UI.ScrollRect.ScrollbarVisibility[] array = obj as UnityEngine.UI.ScrollRect.ScrollbarVisibility[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Scrollbar.Direction[]))
			{
			    UnityEngine.UI.Scrollbar.Direction[] array = obj as UnityEngine.UI.Scrollbar.Direction[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Selectable.Transition[]))
			{
			    UnityEngine.UI.Selectable.Transition[] array = obj as UnityEngine.UI.Selectable.Transition[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Slider.Direction[]))
			{
			    UnityEngine.UI.Slider.Direction[] array = obj as UnityEngine.UI.Slider.Direction[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Toggle.ToggleTransition[]))
			{
			    UnityEngine.UI.Toggle.ToggleTransition[] array = obj as UnityEngine.UI.Toggle.ToggleTransition[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(XDebug.Orient[]))
			{
			    XDebug.Orient[] array = obj as XDebug.Orient[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(XDebug.Location.Align[]))
			{
			    XDebug.Location.Align[] array = obj as XDebug.Location.Align[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(XDebug.Module.Type[]))
			{
			    XDebug.Module.Type[] array = obj as XDebug.Module.Type[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(XDebug.XLog.LogLevel[]))
			{
			    XDebug.XLog.LogLevel[] array = obj as XDebug.XLog.LogLevel[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
            return false;
		}
	}
}