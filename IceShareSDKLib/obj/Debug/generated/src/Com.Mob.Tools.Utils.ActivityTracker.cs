using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ActivityTracker']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/ActivityTracker", DoNotGenerateAcw=true)]
	public partial class ActivityTracker : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']"
		[Register ("com/mob/tools/utils/ActivityTracker$Tracker", "", "Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker")]
		public partial interface ITracker : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']/method[@name='onCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("onCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler:Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker, IceShareSDKLib")]
			void OnCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']/method[@name='onDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onDestroyed", "(Landroid/app/Activity;)V", "GetOnDestroyed_Landroid_app_Activity_Handler:Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker, IceShareSDKLib")]
			void OnDestroyed (global::Android.App.Activity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']/method[@name='onPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onPaused", "(Landroid/app/Activity;)V", "GetOnPaused_Landroid_app_Activity_Handler:Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker, IceShareSDKLib")]
			void OnPaused (global::Android.App.Activity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']/method[@name='onResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onResumed", "(Landroid/app/Activity;)V", "GetOnResumed_Landroid_app_Activity_Handler:Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker, IceShareSDKLib")]
			void OnResumed (global::Android.App.Activity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']/method[@name='onSaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("onSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler:Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker, IceShareSDKLib")]
			void OnSaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']/method[@name='onStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onStarted", "(Landroid/app/Activity;)V", "GetOnStarted_Landroid_app_Activity_Handler:Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker, IceShareSDKLib")]
			void OnStarted (global::Android.App.Activity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ActivityTracker.Tracker']/method[@name='onStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onStopped", "(Landroid/app/Activity;)V", "GetOnStopped_Landroid_app_Activity_Handler:Com.Mob.Tools.Utils.ActivityTracker/ITrackerInvoker, IceShareSDKLib")]
			void OnStopped (global::Android.App.Activity p0);

		}

		[global::Android.Runtime.Register ("com/mob/tools/utils/ActivityTracker$Tracker", DoNotGenerateAcw=true)]
		internal partial class ITrackerInvoker : global::Java.Lang.Object, ITracker {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/ActivityTracker$Tracker", typeof (ITrackerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ITracker GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITracker> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.utils.ActivityTracker.Tracker"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
			{
				if (cb_onCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
					cb_onCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreated_Landroid_app_Activity_Landroid_os_Bundle_);
				return cb_onCreated_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			static void n_OnCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mob.Tools.Utils.ActivityTracker.ITracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCreated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCreated_Landroid_app_Activity_Landroid_os_Bundle_;
			public unsafe void OnCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
			{
				if (id_onCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreated_Landroid_app_Activity_Landroid_os_Bundle_, __args);
			}

			static Delegate cb_onDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnDestroyed_Landroid_app_Activity_Handler ()
			{
				if (cb_onDestroyed_Landroid_app_Activity_ == null)
					cb_onDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroyed_Landroid_app_Activity_);
				return cb_onDestroyed_Landroid_app_Activity_;
			}

			static void n_OnDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Utils.ActivityTracker.ITracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDestroyed_Landroid_app_Activity_;
			public unsafe void OnDestroyed (global::Android.App.Activity p0)
			{
				if (id_onDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
					id_onDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onDestroyed", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroyed_Landroid_app_Activity_, __args);
			}

			static Delegate cb_onPaused_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnPaused_Landroid_app_Activity_Handler ()
			{
				if (cb_onPaused_Landroid_app_Activity_ == null)
					cb_onPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPaused_Landroid_app_Activity_);
				return cb_onPaused_Landroid_app_Activity_;
			}

			static void n_OnPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Utils.ActivityTracker.ITracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPaused (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPaused_Landroid_app_Activity_;
			public unsafe void OnPaused (global::Android.App.Activity p0)
			{
				if (id_onPaused_Landroid_app_Activity_ == IntPtr.Zero)
					id_onPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onPaused", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPaused_Landroid_app_Activity_, __args);
			}

			static Delegate cb_onResumed_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnResumed_Landroid_app_Activity_Handler ()
			{
				if (cb_onResumed_Landroid_app_Activity_ == null)
					cb_onResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResumed_Landroid_app_Activity_);
				return cb_onResumed_Landroid_app_Activity_;
			}

			static void n_OnResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Utils.ActivityTracker.ITracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResumed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResumed_Landroid_app_Activity_;
			public unsafe void OnResumed (global::Android.App.Activity p0)
			{
				if (id_onResumed_Landroid_app_Activity_ == IntPtr.Zero)
					id_onResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onResumed", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResumed_Landroid_app_Activity_, __args);
			}

			static Delegate cb_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
			{
				if (cb_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
					cb_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
				return cb_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			static void n_OnSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mob.Tools.Utils.ActivityTracker.ITracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSaveInstanceState (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
			public unsafe void OnSaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
			{
				if (id_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, __args);
			}

			static Delegate cb_onStarted_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnStarted_Landroid_app_Activity_Handler ()
			{
				if (cb_onStarted_Landroid_app_Activity_ == null)
					cb_onStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStarted_Landroid_app_Activity_);
				return cb_onStarted_Landroid_app_Activity_;
			}

			static void n_OnStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Utils.ActivityTracker.ITracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStarted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStarted_Landroid_app_Activity_;
			public unsafe void OnStarted (global::Android.App.Activity p0)
			{
				if (id_onStarted_Landroid_app_Activity_ == IntPtr.Zero)
					id_onStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onStarted", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStarted_Landroid_app_Activity_, __args);
			}

			static Delegate cb_onStopped_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnStopped_Landroid_app_Activity_Handler ()
			{
				if (cb_onStopped_Landroid_app_Activity_ == null)
					cb_onStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStopped_Landroid_app_Activity_);
				return cb_onStopped_Landroid_app_Activity_;
			}

			static void n_OnStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Utils.ActivityTracker.ITracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStopped (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStopped_Landroid_app_Activity_;
			public unsafe void OnStopped (global::Android.App.Activity p0)
			{
				if (id_onStopped_Landroid_app_Activity_ == IntPtr.Zero)
					id_onStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onStopped", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopped_Landroid_app_Activity_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/ActivityTracker", typeof (ActivityTracker));
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

		protected ActivityTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_;
#pragma warning disable 0169
		static Delegate GetAddTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_Handler ()
		{
			if (cb_addTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_ == null)
				cb_addTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_);
			return cb_addTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_;
		}

		static void n_AddTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tracker)
		{
			global::Com.Mob.Tools.Utils.ActivityTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Utils.ActivityTracker.ITracker tracker = (global::Com.Mob.Tools.Utils.ActivityTracker.ITracker)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (native_tracker, JniHandleOwnership.DoNotTransfer);
			__this.AddTracker (tracker);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ActivityTracker']/method[@name='addTracker' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.ActivityTracker.Tracker']]"
		[Register ("addTracker", "(Lcom/mob/tools/utils/ActivityTracker$Tracker;)V", "GetAddTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_Handler")]
		public virtual unsafe void AddTracker (global::Com.Mob.Tools.Utils.ActivityTracker.ITracker tracker)
		{
			const string __id = "addTracker.(Lcom/mob/tools/utils/ActivityTracker$Tracker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tracker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tracker).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ActivityTracker']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/mob/tools/utils/ActivityTracker;", "")]
		public static unsafe global::Com.Mob.Tools.Utils.ActivityTracker GetInstance (global::Android.Content.Context context)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/mob/tools/utils/ActivityTracker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_;
#pragma warning disable 0169
		static Delegate GetRemoveTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_Handler ()
		{
			if (cb_removeTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_ == null)
				cb_removeTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_);
			return cb_removeTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_;
		}

		static void n_RemoveTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tracker)
		{
			global::Com.Mob.Tools.Utils.ActivityTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Utils.ActivityTracker.ITracker tracker = (global::Com.Mob.Tools.Utils.ActivityTracker.ITracker)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ActivityTracker.ITracker> (native_tracker, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTracker (tracker);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ActivityTracker']/method[@name='removeTracker' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.ActivityTracker.Tracker']]"
		[Register ("removeTracker", "(Lcom/mob/tools/utils/ActivityTracker$Tracker;)V", "GetRemoveTracker_Lcom_mob_tools_utils_ActivityTracker_Tracker_Handler")]
		public virtual unsafe void RemoveTracker (global::Com.Mob.Tools.Utils.ActivityTracker.ITracker tracker)
		{
			const string __id = "removeTracker.(Lcom/mob/tools/utils/ActivityTracker$Tracker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tracker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tracker).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
