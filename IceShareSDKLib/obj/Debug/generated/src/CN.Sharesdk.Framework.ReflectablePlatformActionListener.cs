using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/ReflectablePlatformActionListener", DoNotGenerateAcw=true)]
	public partial class ReflectablePlatformActionListener : global::Java.Lang.Object, global::CN.Sharesdk.Framework.IPlatformActionListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/framework/ReflectablePlatformActionListener", typeof (ReflectablePlatformActionListener));
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

		protected ReflectablePlatformActionListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']/constructor[@name='ReflectablePlatformActionListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReflectablePlatformActionListener ()
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

		static Delegate cb_onCancel_Lcn_sharesdk_framework_Platform_I;
#pragma warning disable 0169
		static Delegate GetOnCancel_Lcn_sharesdk_framework_Platform_IHandler ()
		{
			if (cb_onCancel_Lcn_sharesdk_framework_Platform_I == null)
				cb_onCancel_Lcn_sharesdk_framework_Platform_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnCancel_Lcn_sharesdk_framework_Platform_I);
			return cb_onCancel_Lcn_sharesdk_framework_Platform_I;
		}

		static void n_OnCancel_Lcn_sharesdk_framework_Platform_I (IntPtr jnienv, IntPtr native__this, IntPtr native_platform, int action)
		{
			global::CN.Sharesdk.Framework.ReflectablePlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.ReflectablePlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform platform = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_platform, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (platform, action);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']/method[@name='onCancel' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int']]"
		[Register ("onCancel", "(Lcn/sharesdk/framework/Platform;I)V", "GetOnCancel_Lcn_sharesdk_framework_Platform_IHandler")]
		public virtual unsafe void OnCancel (global::CN.Sharesdk.Framework.Platform platform, int action)
		{
			const string __id = "onCancel.(Lcn/sharesdk/framework/Platform;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				__args [1] = new JniArgumentValue (action);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_Handler ()
		{
			if (cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ == null)
				cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_);
			return cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_;
		}

		static void n_OnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platform, int action, IntPtr native_res)
		{
			global::CN.Sharesdk.Framework.ReflectablePlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.ReflectablePlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform platform = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_platform, JniHandleOwnership.DoNotTransfer);
			var res = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_res, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (platform, action, res);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onComplete", "(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V", "GetOnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_Handler")]
		public virtual unsafe void OnComplete (global::CN.Sharesdk.Framework.Platform platform, int action, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> res)
		{
			const string __id = "onComplete.(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V";
			IntPtr native_res = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (res);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				__args [1] = new JniArgumentValue (action);
				__args [2] = new JniArgumentValue (native_res);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_res);
			}
		}

		static Delegate cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_Handler ()
		{
			if (cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ == null)
				cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_);
			return cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_;
		}

		static void n_OnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platform, int action, IntPtr native_t)
		{
			global::CN.Sharesdk.Framework.ReflectablePlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.ReflectablePlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform platform = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_platform, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.OnError (platform, action, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V", "GetOnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_Handler")]
		public virtual unsafe void OnError (global::CN.Sharesdk.Framework.Platform platform, int action, global::Java.Lang.Throwable t)
		{
			const string __id = "onError.(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				__args [1] = new JniArgumentValue (action);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnCancelCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetOnCancelCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setOnCancelCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setOnCancelCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnCancelCallback_ILandroid_os_Handler_Callback_);
			return cb_setOnCancelCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetOnCancelCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int what, IntPtr native__callback)
		{
			global::CN.Sharesdk.Framework.ReflectablePlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.ReflectablePlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback @callback = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCancelCallback (what, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']/method[@name='setOnCancelCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setOnCancelCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetOnCancelCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetOnCancelCallback (int what, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "setOnCancelCallback.(ILandroid/os/Handler$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnCompleteCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetOnCompleteCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setOnCompleteCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setOnCompleteCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnCompleteCallback_ILandroid_os_Handler_Callback_);
			return cb_setOnCompleteCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetOnCompleteCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int what, IntPtr native__callback)
		{
			global::CN.Sharesdk.Framework.ReflectablePlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.ReflectablePlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback @callback = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompleteCallback (what, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']/method[@name='setOnCompleteCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setOnCompleteCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetOnCompleteCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetOnCompleteCallback (int what, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "setOnCompleteCallback.(ILandroid/os/Handler$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnErrorCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setOnErrorCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setOnErrorCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnErrorCallback_ILandroid_os_Handler_Callback_);
			return cb_setOnErrorCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetOnErrorCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int what, IntPtr native__callback)
		{
			global::CN.Sharesdk.Framework.ReflectablePlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.ReflectablePlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback @callback = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetOnErrorCallback (what, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='ReflectablePlatformActionListener']/method[@name='setOnErrorCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setOnErrorCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetOnErrorCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetOnErrorCallback (int what, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "setOnErrorCallback.(ILandroid/os/Handler$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
