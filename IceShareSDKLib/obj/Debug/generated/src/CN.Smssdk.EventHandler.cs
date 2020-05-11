using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']"
	[global::Android.Runtime.Register ("cn/smssdk/EventHandler", DoNotGenerateAcw=true)]
	public partial class EventHandler : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/EventHandler", typeof (EventHandler));
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

		protected EventHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/constructor[@name='EventHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventHandler ()
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

		static Delegate cb_afterEvent_IILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAfterEvent_IILjava_lang_Object_Handler ()
		{
			if (cb_afterEvent_IILjava_lang_Object_ == null)
				cb_afterEvent_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_AfterEvent_IILjava_lang_Object_);
			return cb_afterEvent_IILjava_lang_Object_;
		}

		static void n_AfterEvent_IILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AfterEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='afterEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("afterEvent", "(IILjava/lang/Object;)V", "GetAfterEvent_IILjava_lang_Object_Handler")]
		public virtual unsafe void AfterEvent (int p0, int p1, global::Java.Lang.Object p2)
		{
			const string __id = "afterEvent.(IILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_beforeEvent_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetBeforeEvent_ILjava_lang_Object_Handler ()
		{
			if (cb_beforeEvent_ILjava_lang_Object_ == null)
				cb_beforeEvent_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_BeforeEvent_ILjava_lang_Object_);
			return cb_beforeEvent_ILjava_lang_Object_;
		}

		static void n_BeforeEvent_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BeforeEvent (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='beforeEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("beforeEvent", "(ILjava/lang/Object;)V", "GetBeforeEvent_ILjava_lang_Object_Handler")]
		public virtual unsafe void BeforeEvent (int p0, global::Java.Lang.Object p1)
		{
			const string __id = "beforeEvent.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRegister;
#pragma warning disable 0169
		static Delegate GetOnRegisterHandler ()
		{
			if (cb_onRegister == null)
				cb_onRegister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRegister);
			return cb_onRegister;
		}

		static void n_OnRegister (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRegister ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='onRegister' and count(parameter)=0]"
		[Register ("onRegister", "()V", "GetOnRegisterHandler")]
		public virtual unsafe void OnRegister ()
		{
			const string __id = "onRegister.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onUnregister;
#pragma warning disable 0169
		static Delegate GetOnUnregisterHandler ()
		{
			if (cb_onUnregister == null)
				cb_onUnregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnregister);
			return cb_onUnregister;
		}

		static void n_OnUnregister (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnregister ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='onUnregister' and count(parameter)=0]"
		[Register ("onUnregister", "()V", "GetOnUnregisterHandler")]
		public virtual unsafe void OnUnregister ()
		{
			const string __id = "onUnregister.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
