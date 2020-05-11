using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/ApplicationTracker", DoNotGenerateAcw=true)]
	public partial class ApplicationTracker : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']"
		[global::Android.Runtime.Register ("com/mob/tools/utils/ApplicationTracker$Tracker", DoNotGenerateAcw=true)]
		public abstract partial class Tracker : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/ApplicationTracker$Tracker", typeof (Tracker));
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

			protected Tracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/constructor[@name='ApplicationTracker.Tracker' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Tracker ()
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

			static Delegate cb_onActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityConfigurationChanged (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onActivityConfigurationChanged' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onActivityConfigurationChanged", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnActivityConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnActivityConfigurationChanged (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onActivityConfigurationChanged.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onAttachAgent_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnAttachAgent_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onAttachAgent_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onAttachAgent_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAttachAgent_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onAttachAgent_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnAttachAgent_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnAttachAgent (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onAttachAgent' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onAttachAgent", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnAttachAgent_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnAttachAgent (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onAttachAgent.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnBackgroundVisibleBehindChanged (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onBackgroundVisibleBehindChanged' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onBackgroundVisibleBehindChanged", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnBackgroundVisibleBehindChanged_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnBackgroundVisibleBehindChanged (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onBackgroundVisibleBehindChanged.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onBindApplication_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnBindApplication_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onBindApplication_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onBindApplication_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBindApplication_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onBindApplication_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnBindApplication_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnBindApplication (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onBindApplication' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onBindApplication", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnBindApplication_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnBindApplication (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onBindApplication.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onBindService_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnBindService_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onBindService_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onBindService_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBindService_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onBindService_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnBindService_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnBindService (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onBindService' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onBindService", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnBindService_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnBindService (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onBindService.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnCancelVisibleBehind (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onCancelVisibleBehind' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onCancelVisibleBehind", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnCancelVisibleBehind_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnCancelVisibleBehind (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onCancelVisibleBehind.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onCleanUpContext_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnCleanUpContext_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onCleanUpContext_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onCleanUpContext_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCleanUpContext_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onCleanUpContext_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnCleanUpContext_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnCleanUpContext (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onCleanUpContext' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onCleanUpContext", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnCleanUpContext_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnCleanUpContext (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onCleanUpContext.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnConfigurationChanged (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onConfigurationChanged' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onConfigurationChanged", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnConfigurationChanged_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnConfigurationChanged (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onConfigurationChanged.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateBackupAgent (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onCreateBackupAgent' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onCreateBackupAgent", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnCreateBackupAgent_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnCreateBackupAgent (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onCreateBackupAgent.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onCreateService_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnCreateService_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onCreateService_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onCreateService_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateService_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onCreateService_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnCreateService_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateService (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onCreateService' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onCreateService", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnCreateService_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnCreateService (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onCreateService.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onDestroyActivity_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnDestroyActivity_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onDestroyActivity_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onDestroyActivity_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDestroyActivity_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onDestroyActivity_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnDestroyActivity_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyActivity (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onDestroyActivity' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onDestroyActivity", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnDestroyActivity_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnDestroyActivity (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onDestroyActivity.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyBackupAgent (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onDestroyBackupAgent' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onDestroyBackupAgent", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnDestroyBackupAgent_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnDestroyBackupAgent (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onDestroyBackupAgent.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnDispatchPackageBroadcast (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onDispatchPackageBroadcast' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onDispatchPackageBroadcast", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnDispatchPackageBroadcast_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnDispatchPackageBroadcast (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onDispatchPackageBroadcast.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onDumpActivity_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnDumpActivity_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onDumpActivity_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onDumpActivity_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDumpActivity_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onDumpActivity_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnDumpActivity_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnDumpActivity (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onDumpActivity' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onDumpActivity", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnDumpActivity_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnDumpActivity (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onDumpActivity.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onDumpHeap_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnDumpHeap_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onDumpHeap_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onDumpHeap_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDumpHeap_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onDumpHeap_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnDumpHeap_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnDumpHeap (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onDumpHeap' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onDumpHeap", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnDumpHeap_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnDumpHeap (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onDumpHeap.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onDumpProvider_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnDumpProvider_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onDumpProvider_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onDumpProvider_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDumpProvider_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onDumpProvider_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnDumpProvider_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnDumpProvider (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onDumpProvider' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onDumpProvider", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnDumpProvider_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnDumpProvider (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onDumpProvider.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onDumpService_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnDumpService_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onDumpService_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onDumpService_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDumpService_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onDumpService_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnDumpService_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnDumpService (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onDumpService' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onDumpService", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnDumpService_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnDumpService (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onDumpService.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onEnableJit_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnEnableJit_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onEnableJit_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onEnableJit_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnEnableJit_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onEnableJit_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnEnableJit_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnEnableJit (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onEnableJit' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onEnableJit", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnEnableJit_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnEnableJit (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onEnableJit.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnEnterAnimationComplete (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onEnterAnimationComplete' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onEnterAnimationComplete", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnEnterAnimationComplete_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnEnterAnimationComplete (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onEnterAnimationComplete.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onExitApplication_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnExitApplication_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onExitApplication_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onExitApplication_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnExitApplication_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onExitApplication_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnExitApplication_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnExitApplication (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onExitApplication' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onExitApplication", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnExitApplication_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnExitApplication (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onExitApplication.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnGcWhenIdle (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onGcWhenIdle' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onGcWhenIdle", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnGcWhenIdle_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnGcWhenIdle (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onGcWhenIdle.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onHideWindow_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnHideWindow_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onHideWindow_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onHideWindow_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnHideWindow_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onHideWindow_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnHideWindow_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnHideWindow (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onHideWindow' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onHideWindow", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnHideWindow_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnHideWindow (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onHideWindow.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onInstallProvider_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnInstallProvider_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onInstallProvider_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onInstallProvider_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInstallProvider_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onInstallProvider_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnInstallProvider_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnInstallProvider (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onInstallProvider' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onInstallProvider", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnInstallProvider_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnInstallProvider (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onInstallProvider.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onLaunchActivity_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnLaunchActivity_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onLaunchActivity_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onLaunchActivity_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLaunchActivity_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onLaunchActivity_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnLaunchActivity_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnLaunchActivity (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onLaunchActivity' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onLaunchActivity", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnLaunchActivity_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnLaunchActivity (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onLaunchActivity.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalVoiceInteractionStarted (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onLocalVoiceInteractionStarted' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onLocalVoiceInteractionStarted", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnLocalVoiceInteractionStarted_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnLocalVoiceInteractionStarted (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onLocalVoiceInteractionStarted.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onLowMemory_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnLowMemory_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onLowMemory_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onLowMemory_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLowMemory_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onLowMemory_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnLowMemory_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnLowMemory (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onLowMemory' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onLowMemory", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnLowMemory_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnLowMemory (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onLowMemory.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnMultiWindowModeChanged (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onMultiWindowModeChanged' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onMultiWindowModeChanged", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnMultiWindowModeChanged_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnMultiWindowModeChanged (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onMultiWindowModeChanged.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onNewIntent_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnNewIntent_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onNewIntent_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onNewIntent_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNewIntent_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onNewIntent_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnNewIntent_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnNewIntent (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onNewIntent' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onNewIntent", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnNewIntent_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnNewIntent (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onNewIntent.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnOnNewActivityOptions (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onOnNewActivityOptions' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onOnNewActivityOptions", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnOnNewActivityOptions_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnOnNewActivityOptions (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onOnNewActivityOptions.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onPauseActivity_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnPauseActivity_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onPauseActivity_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onPauseActivity_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPauseActivity_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onPauseActivity_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnPauseActivity_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnPauseActivity (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onPauseActivity' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onPauseActivity", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnPauseActivity_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnPauseActivity (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onPauseActivity.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnPauseActivityFinishing (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onPauseActivityFinishing' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onPauseActivityFinishing", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnPauseActivityFinishing_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnPauseActivityFinishing (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onPauseActivityFinishing.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnPictureInPictureModeChanged (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onPictureInPictureModeChanged' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onPictureInPictureModeChanged", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnPictureInPictureModeChanged_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnPictureInPictureModeChanged (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onPictureInPictureModeChanged.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onProfilerControl_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnProfilerControl_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onProfilerControl_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onProfilerControl_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnProfilerControl_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onProfilerControl_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnProfilerControl_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnProfilerControl (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onProfilerControl' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onProfilerControl", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnProfilerControl_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnProfilerControl (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onProfilerControl.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onReceiver_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnReceiver_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onReceiver_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onReceiver_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceiver_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onReceiver_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnReceiver_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnReceiver (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onReceiver", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnReceiver_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnReceiver (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onReceiver.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnRelaunchActivity (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onRelaunchActivity' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onRelaunchActivity", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnRelaunchActivity_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnRelaunchActivity (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onRelaunchActivity.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onRemoveProvider_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnRemoveProvider_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onRemoveProvider_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onRemoveProvider_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoveProvider_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onRemoveProvider_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnRemoveProvider_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoveProvider (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onRemoveProvider' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onRemoveProvider", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnRemoveProvider_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnRemoveProvider (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onRemoveProvider.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnRequestAssistContextExtras (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onRequestAssistContextExtras' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onRequestAssistContextExtras", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnRequestAssistContextExtras_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnRequestAssistContextExtras (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onRequestAssistContextExtras.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onResumeActivity_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnResumeActivity_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onResumeActivity_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onResumeActivity_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResumeActivity_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onResumeActivity_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnResumeActivity_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnResumeActivity (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onResumeActivity' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onResumeActivity", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnResumeActivity_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnResumeActivity (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onResumeActivity.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onScheduleCrash_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnScheduleCrash_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onScheduleCrash_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onScheduleCrash_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnScheduleCrash_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onScheduleCrash_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnScheduleCrash_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnScheduleCrash (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onScheduleCrash' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onScheduleCrash", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnScheduleCrash_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnScheduleCrash (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onScheduleCrash.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onSendResult_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnSendResult_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onSendResult_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onSendResult_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSendResult_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onSendResult_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnSendResult_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnSendResult (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onSendResult' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onSendResult", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnSendResult_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnSendResult (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onSendResult.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onServiceArgs_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnServiceArgs_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onServiceArgs_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onServiceArgs_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnServiceArgs_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onServiceArgs_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnServiceArgs_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnServiceArgs (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onServiceArgs' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onServiceArgs", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnServiceArgs_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnServiceArgs (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onServiceArgs.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnSetCoreSettings (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onSetCoreSettings' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onSetCoreSettings", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnSetCoreSettings_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnSetCoreSettings (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onSetCoreSettings.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onShowWindow_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnShowWindow_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onShowWindow_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onShowWindow_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnShowWindow_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onShowWindow_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnShowWindow_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnShowWindow (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onShowWindow' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onShowWindow", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnShowWindow_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnShowWindow (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onShowWindow.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onSleeping_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnSleeping_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onSleeping_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onSleeping_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSleeping_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onSleeping_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnSleeping_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnSleeping (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onSleeping' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onSleeping", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnSleeping_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnSleeping (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onSleeping.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnStartBinderTracking (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onStartBinderTracking' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onStartBinderTracking", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnStartBinderTracking_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnStartBinderTracking (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onStartBinderTracking.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStopActivityHide_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnStopActivityHide_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onStopActivityHide_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onStopActivityHide_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStopActivityHide_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onStopActivityHide_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnStopActivityHide_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnStopActivityHide (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onStopActivityHide' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onStopActivityHide", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnStopActivityHide_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnStopActivityHide (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onStopActivityHide.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStopActivityShow_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnStopActivityShow_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onStopActivityShow_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onStopActivityShow_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStopActivityShow_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onStopActivityShow_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnStopActivityShow_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnStopActivityShow (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onStopActivityShow' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onStopActivityShow", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnStopActivityShow_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnStopActivityShow (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onStopActivityShow.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnStopBinderTrackingAndDump (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onStopBinderTrackingAndDump' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onStopBinderTrackingAndDump", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnStopBinderTrackingAndDump_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnStopBinderTrackingAndDump (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onStopBinderTrackingAndDump.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStopService_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnStopService_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onStopService_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onStopService_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStopService_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onStopService_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnStopService_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnStopService (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onStopService' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onStopService", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnStopService_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnStopService (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onStopService.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onSuicide_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnSuicide_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onSuicide_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onSuicide_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuicide_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onSuicide_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnSuicide_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnSuicide (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onSuicide' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onSuicide", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnSuicide_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnSuicide (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onSuicide.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnTranslucentConversionComplete (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onTranslucentConversionComplete' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onTranslucentConversionComplete", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnTranslucentConversionComplete_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnTranslucentConversionComplete (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onTranslucentConversionComplete.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onTrimMemory_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnTrimMemory_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onTrimMemory_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onTrimMemory_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTrimMemory_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onTrimMemory_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnTrimMemory_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnTrimMemory (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onTrimMemory' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onTrimMemory", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnTrimMemory_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnTrimMemory (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onTrimMemory.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onUnbindService_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnUnbindService_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onUnbindService_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onUnbindService_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUnbindService_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onUnbindService_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnUnbindService_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnUnbindService (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onUnbindService' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onUnbindService", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnUnbindService_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnUnbindService (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onUnbindService.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnUnstableProviderDied (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onUnstableProviderDied' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onUnstableProviderDied", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnUnstableProviderDied_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnUnstableProviderDied (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onUnstableProviderDied.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetOnUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_Handler ()
			{
				if (cb_onUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_ == null)
					cb_onUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_);
				return cb_onUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_;
			}

			static void n_OnUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_msg)
			{
				global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_thread, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdatePackageCompatibilityInfo (thread, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker.Tracker']/method[@name='onUpdatePackageCompatibilityInfo' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.os.Message']]"
			[Register ("onUpdatePackageCompatibilityInfo", "(Ljava/lang/Object;Landroid/os/Message;)V", "GetOnUpdatePackageCompatibilityInfo_Ljava_lang_Object_Landroid_os_Message_Handler")]
			protected virtual unsafe void OnUpdatePackageCompatibilityInfo (global::Java.Lang.Object thread, global::Android.OS.Message msg)
			{
				const string __id = "onUpdatePackageCompatibilityInfo.(Ljava/lang/Object;Landroid/os/Message;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/mob/tools/utils/ApplicationTracker$Tracker", DoNotGenerateAcw=true)]
		internal partial class TrackerInvoker : Tracker {

			public TrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/ApplicationTracker$Tracker", typeof (TrackerInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/ApplicationTracker", typeof (ApplicationTracker));
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

		protected ApplicationTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker']/constructor[@name='ApplicationTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplicationTracker ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker']/method[@name='addTracker' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.ApplicationTracker.Tracker']]"
		[Register ("addTracker", "(Lcom/mob/tools/utils/ApplicationTracker$Tracker;)V", "")]
		public static unsafe void AddTracker (global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker t)
		{
			const string __id = "addTracker.(Lcom/mob/tools/utils/ApplicationTracker$Tracker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ApplicationTracker']/method[@name='removeTracker' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.ApplicationTracker.Tracker']]"
		[Register ("removeTracker", "(Lcom/mob/tools/utils/ApplicationTracker$Tracker;)V", "")]
		public static unsafe void RemoveTracker (global::Com.Mob.Tools.Utils.ApplicationTracker.Tracker t)
		{
			const string __id = "removeTracker.(Lcom/mob/tools/utils/ApplicationTracker$Tracker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
