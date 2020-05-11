using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/ShareSDK", DoNotGenerateAcw=true)]
	public partial class ShareSDK : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/field[@name='SDK_TAG']"
		[Register ("SDK_TAG")]
		public const string SdkTag = (string) "SHARESDK";


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/field[@name='SDK_VERSION_CODE']"
		[Register ("SDK_VERSION_CODE")]
		public static int SdkVersionCode {
			get {
				const string __id = "SDK_VERSION_CODE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/field[@name='SDK_VERSION_NAME']"
		[Register ("SDK_VERSION_NAME")]
		public const string SdkVersionName = (string) "3.3.0";
		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/ShareSDK", typeof (ShareSDK));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ShareSDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/constructor[@name='ShareSDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShareSDK ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe bool IsDebug {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='isDebug' and count(parameter)=0]"
			[Register ("isDebug", "()Z", "")]
			get {
				const string __id = "isDebug.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsRemoveCookieOnAuthorize {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='isRemoveCookieOnAuthorize' and count(parameter)=0]"
			[Register ("isRemoveCookieOnAuthorize", "()Z", "")]
			get {
				const string __id = "isRemoveCookieOnAuthorize.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='closeDebug' and count(parameter)=0]"
		[Register ("closeDebug", "()V", "")]
		public static unsafe void CloseDebug ()
		{
			const string __id = "closeDebug.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='deleteCache' and count(parameter)=0]"
		[Register ("deleteCache", "()V", "")]
		public static unsafe void DeleteCache ()
		{
			const string __id = "deleteCache.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='getPlatform' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPlatform", "(Ljava/lang/String;)Lcn/sharesdk/framework/Platform;", "")]
		public static unsafe global::CN.Sharesdk.Framework.Platform GetPlatform (string name)
		{
			const string __id = "getPlatform.(Ljava/lang/String;)Lcn/sharesdk/framework/Platform;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='getPlatformList' and count(parameter)=0]"
		[Register ("getPlatformList", "()[Lcn/sharesdk/framework/Platform;", "")]
		public static unsafe global::CN.Sharesdk.Framework.Platform[] GetPlatformList ()
		{
			const string __id = "getPlatformList.()[Lcn/sharesdk/framework/Platform;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::CN.Sharesdk.Framework.Platform[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::CN.Sharesdk.Framework.Platform));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getService", "(Ljava/lang/Class;)Lcn/sharesdk/framework/Service;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends cn.sharesdk.framework.Service"})]
		public static unsafe global::Java.Lang.Object GetService (global::Java.Lang.Class name)
		{
			const string __id = "getService.(Ljava/lang/Class;)Lcn/sharesdk/framework/Service;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((name == null) ? IntPtr.Zero : ((global::Java.Lang.Object) name).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='logApiEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("logApiEvent", "(Ljava/lang/String;I)V", "")]
		public static unsafe void LogApiEvent (string api, int platformId)
		{
			const string __id = "logApiEvent.(Ljava/lang/String;I)V";
			IntPtr native_api = JNIEnv.NewString (api);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_api);
				__args [1] = new JniArgumentValue (platformId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_api);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='logDemoEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='cn.sharesdk.framework.Platform']]"
		[Register ("logDemoEvent", "(ILcn/sharesdk/framework/Platform;)V", "")]
		public static unsafe void LogDemoEvent (int id, global::CN.Sharesdk.Framework.Platform platform)
		{
			const string __id = "logDemoEvent.(ILcn/sharesdk/framework/Platform;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='platformIdToName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("platformIdToName", "(I)Ljava/lang/String;", "")]
		public static unsafe string PlatformIdToName (int platformId)
		{
			const string __id = "platformIdToName.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (platformId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='platformNameToId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("platformNameToId", "(Ljava/lang/String;)I", "")]
		public static unsafe int PlatformNameToId (string platformName)
		{
			const string __id = "platformNameToId.(Ljava/lang/String;)I";
			IntPtr native_platformName = JNIEnv.NewString (platformName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_platformName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_platformName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='registerPlatform' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends cn.sharesdk.framework.CustomPlatform&gt;']]"
		[Register ("registerPlatform", "(Ljava/lang/Class;)V", "")]
		public static unsafe void RegisterPlatform (global::Java.Lang.Class platform)
		{
			const string __id = "registerPlatform.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='registerService' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends cn.sharesdk.framework.Service&gt;']]"
		[Register ("registerService", "(Ljava/lang/Class;)V", "")]
		public static unsafe void RegisterService (global::Java.Lang.Class service)
		{
			const string __id = "registerService.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='removeCookieOnAuthorize' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("removeCookieOnAuthorize", "(Z)V", "")]
		public static unsafe void RemoveCookieOnAuthorize (bool @remove)
		{
			const string __id = "removeCookieOnAuthorize.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (@remove);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='setConnTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConnTimeout", "(I)V", "")]
		public static unsafe void SetConnTimeout (int timeout)
		{
			const string __id = "setConnTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='setPlatformDevInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setPlatformDevInfo", "(Ljava/lang/String;Ljava/util/HashMap;)V", "")]
		public static unsafe void SetPlatformDevInfo (string platform, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> devInfo)
		{
			const string __id = "setPlatformDevInfo.(Ljava/lang/String;Ljava/util/HashMap;)V";
			IntPtr native_platform = JNIEnv.NewString (platform);
			IntPtr native_devInfo = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (devInfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_platform);
				__args [1] = new JniArgumentValue (native_devInfo);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_platform);
				JNIEnv.DeleteLocalRef (native_devInfo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReadTimeout", "(I)V", "")]
		public static unsafe void SetReadTimeout (int timeout)
		{
			const string __id = "setReadTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='unregisterPlatform' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends cn.sharesdk.framework.CustomPlatform&gt;']]"
		[Register ("unregisterPlatform", "(Ljava/lang/Class;)V", "")]
		public static unsafe void UnregisterPlatform (global::Java.Lang.Class platform)
		{
			const string __id = "unregisterPlatform.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ShareSDK']/method[@name='unregisterService' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends cn.sharesdk.framework.Service&gt;']]"
		[Register ("unregisterService", "(Ljava/lang/Class;)V", "")]
		public static unsafe void UnregisterService (global::Java.Lang.Class service)
		{
			const string __id = "unregisterService.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
