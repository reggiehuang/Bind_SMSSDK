using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mob/tools/SSDKHandlerThread", DoNotGenerateAcw=true)]
	public abstract partial class SSDKHandlerThread : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/field[@name='handler']"
		[Register ("handler")]
		protected global::Android.OS.Handler Handler {
			get {
				const string __id = "handler.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "handler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/SSDKHandlerThread", typeof (SSDKHandlerThread));
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

		protected SSDKHandlerThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/constructor[@name='SSDKHandlerThread' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SSDKHandlerThread ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "")]
		public unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Landroid_os_Message_Handler ()
		{
			if (cb_onMessage_Landroid_os_Message_ == null)
				cb_onMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessage_Landroid_os_Message_);
			return cb_onMessage_Landroid_os_Message_;
		}

		static void n_OnMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.SSDKHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.SSDKHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("onMessage", "(Landroid/os/Message;)V", "GetOnMessage_Landroid_os_Message_Handler")]
		protected abstract void OnMessage (global::Android.OS.Message p0);

		static Delegate cb_onStart_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetOnStart_Landroid_os_Message_Handler ()
		{
			if (cb_onStart_Landroid_os_Message_ == null)
				cb_onStart_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStart_Landroid_os_Message_);
			return cb_onStart_Landroid_os_Message_;
		}

		static void n_OnStart_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::Com.Mob.Tools.SSDKHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.SSDKHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnStart (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("onStart", "(Landroid/os/Message;)V", "GetOnStart_Landroid_os_Message_Handler")]
		protected virtual unsafe void OnStart (global::Android.OS.Message msg)
		{
			const string __id = "onStart.(Landroid/os/Message;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStop_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetOnStop_Landroid_os_Message_Handler ()
		{
			if (cb_onStop_Landroid_os_Message_ == null)
				cb_onStop_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStop_Landroid_os_Message_);
			return cb_onStop_Landroid_os_Message_;
		}

		static void n_OnStop_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::Com.Mob.Tools.SSDKHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.SSDKHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnStop (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='onStop' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("onStop", "(Landroid/os/Message;)V", "GetOnStop_Landroid_os_Message_Handler")]
		protected virtual unsafe void OnStop (global::Android.OS.Message msg)
		{
			const string __id = "onStop.(Landroid/os/Message;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startThread;
#pragma warning disable 0169
		static Delegate GetStartThreadHandler ()
		{
			if (cb_startThread == null)
				cb_startThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartThread);
			return cb_startThread;
		}

		static void n_StartThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.SSDKHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.SSDKHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartThread ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='startThread' and count(parameter)=0]"
		[Register ("startThread", "()V", "GetStartThreadHandler")]
		public virtual unsafe void StartThread ()
		{
			const string __id = "startThread.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startThread_IILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetStartThread_IILjava_lang_Object_Handler ()
		{
			if (cb_startThread_IILjava_lang_Object_ == null)
				cb_startThread_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_StartThread_IILjava_lang_Object_);
			return cb_startThread_IILjava_lang_Object_;
		}

		static void n_StartThread_IILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int arg1, int arg2, IntPtr native_obj)
		{
			global::Com.Mob.Tools.SSDKHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.SSDKHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.StartThread (arg1, arg2, obj);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='startThread' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("startThread", "(IILjava/lang/Object;)V", "GetStartThread_IILjava_lang_Object_Handler")]
		public virtual unsafe void StartThread (int arg1, int arg2, global::Java.Lang.Object obj)
		{
			const string __id = "startThread.(IILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (arg1);
				__args [1] = new JniArgumentValue (arg2);
				__args [2] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopThread;
#pragma warning disable 0169
		static Delegate GetStopThreadHandler ()
		{
			if (cb_stopThread == null)
				cb_stopThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopThread);
			return cb_stopThread;
		}

		static void n_StopThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.SSDKHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.SSDKHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopThread ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='stopThread' and count(parameter)=0]"
		[Register ("stopThread", "()V", "GetStopThreadHandler")]
		public virtual unsafe void StopThread ()
		{
			const string __id = "stopThread.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopThread_IILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetStopThread_IILjava_lang_Object_Handler ()
		{
			if (cb_stopThread_IILjava_lang_Object_ == null)
				cb_stopThread_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_StopThread_IILjava_lang_Object_);
			return cb_stopThread_IILjava_lang_Object_;
		}

		static void n_StopThread_IILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int arg1, int arg2, IntPtr native_obj)
		{
			global::Com.Mob.Tools.SSDKHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.SSDKHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.StopThread (arg1, arg2, obj);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='stopThread' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("stopThread", "(IILjava/lang/Object;)V", "GetStopThread_IILjava_lang_Object_Handler")]
		public virtual unsafe void StopThread (int arg1, int arg2, global::Java.Lang.Object obj)
		{
			const string __id = "stopThread.(IILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (arg1);
				__args [1] = new JniArgumentValue (arg2);
				__args [2] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/SSDKHandlerThread", DoNotGenerateAcw=true)]
	internal partial class SSDKHandlerThreadInvoker : SSDKHandlerThread {

		public SSDKHandlerThreadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/SSDKHandlerThread", typeof (SSDKHandlerThreadInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='SSDKHandlerThread']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("onMessage", "(Landroid/os/Message;)V", "GetOnMessage_Landroid_os_Message_Handler")]
		protected override unsafe void OnMessage (global::Android.OS.Message p0)
		{
			const string __id = "onMessage.(Landroid/os/Message;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
