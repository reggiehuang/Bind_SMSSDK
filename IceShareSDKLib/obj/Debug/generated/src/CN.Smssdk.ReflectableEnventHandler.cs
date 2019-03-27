using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']"
	[global::Android.Runtime.Register ("cn/smssdk/ReflectableEnventHandler", DoNotGenerateAcw=true)]
	public partial class ReflectableEnventHandler : global::CN.Smssdk.EventHandler {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/smssdk/ReflectableEnventHandler", typeof (ReflectableEnventHandler));
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

		protected ReflectableEnventHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/constructor[@name='ReflectableEnventHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReflectableEnventHandler ()
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

		static Delegate cb_setAfterEventCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetAfterEventCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setAfterEventCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setAfterEventCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetAfterEventCallback_ILandroid_os_Handler_Callback_);
			return cb_setAfterEventCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetAfterEventCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAfterEventCallback (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setAfterEventCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setAfterEventCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetAfterEventCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetAfterEventCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			const string __id = "setAfterEventCallback.(ILandroid/os/Handler$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetBeforeEventCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetBeforeEventCallback_ILandroid_os_Handler_Callback_);
			return cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetBeforeEventCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetBeforeEventCallback (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setBeforeEventCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setBeforeEventCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetBeforeEventCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetBeforeEventCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			const string __id = "setBeforeEventCallback.(ILandroid/os/Handler$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetOnRegisterCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnRegisterCallback_ILandroid_os_Handler_Callback_);
			return cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetOnRegisterCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRegisterCallback (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setOnRegisterCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setOnRegisterCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetOnRegisterCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetOnRegisterCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			const string __id = "setOnRegisterCallback.(ILandroid/os/Handler$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetOnUnregisterCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnUnregisterCallback_ILandroid_os_Handler_Callback_);
			return cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetOnUnregisterCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnUnregisterCallback (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setOnUnregisterCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setOnUnregisterCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetOnUnregisterCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetOnUnregisterCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			const string __id = "setOnUnregisterCallback.(ILandroid/os/Handler$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
