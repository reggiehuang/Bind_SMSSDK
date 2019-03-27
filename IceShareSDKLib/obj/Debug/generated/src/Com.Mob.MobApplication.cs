using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob']/class[@name='MobApplication']"
	[global::Android.Runtime.Register ("com/mob/MobApplication", DoNotGenerateAcw=true)]
	public partial class MobApplication : global::Android.App.Application, global::Com.Mob.Tools.Proguard.IProtectedMemberKeeper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/MobApplication", typeof (MobApplication));
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

		protected MobApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob']/class[@name='MobApplication']/constructor[@name='MobApplication' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobApplication ()
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

		static Delegate cb_getAppSecret;
#pragma warning disable 0169
		static Delegate GetGetAppSecretHandler ()
		{
			if (cb_getAppSecret == null)
				cb_getAppSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppSecret);
			return cb_getAppSecret;
		}

		static IntPtr n_GetAppSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.MobApplication __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppSecret);
		}
#pragma warning restore 0169

		protected virtual unsafe string AppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobApplication']/method[@name='getAppSecret' and count(parameter)=0]"
			[Register ("getAppSecret", "()Ljava/lang/String;", "GetGetAppSecretHandler")]
			get {
				const string __id = "getAppSecret.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppkey;
#pragma warning disable 0169
		static Delegate GetGetAppkeyHandler ()
		{
			if (cb_getAppkey == null)
				cb_getAppkey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppkey);
			return cb_getAppkey;
		}

		static IntPtr n_GetAppkey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.MobApplication __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Appkey);
		}
#pragma warning restore 0169

		protected virtual unsafe string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobApplication']/method[@name='getAppkey' and count(parameter)=0]"
			[Register ("getAppkey", "()Ljava/lang/String;", "GetGetAppkeyHandler")]
			get {
				const string __id = "getAppkey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
