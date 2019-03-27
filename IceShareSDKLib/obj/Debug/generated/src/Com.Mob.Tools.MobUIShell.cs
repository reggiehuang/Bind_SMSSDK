using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']"
	[global::Android.Runtime.Register ("com/mob/tools/MobUIShell", DoNotGenerateAcw=true)]
	public partial class MobUIShell : global::Android.App.Activity {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/MobUIShell", typeof (MobUIShell));
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

		protected MobUIShell (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']/constructor[@name='MobUIShell' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobUIShell ()
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

		static Delegate cb_getDefault;
#pragma warning disable 0169
		static Delegate GetGetDefaultHandler ()
		{
			if (cb_getDefault == null)
				cb_getDefault = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefault);
			return cb_getDefault;
		}

		static IntPtr n_GetDefault (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.MobUIShell __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobUIShell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Default);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mob.Tools.FakeActivity Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Lcom/mob/tools/FakeActivity;", "GetGetDefaultHandler")]
			get {
				const string __id = "getDefault.()Lcom/mob/tools/FakeActivity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExecutor;
#pragma warning disable 0169
		static Delegate GetGetExecutorHandler ()
		{
			if (cb_getExecutor == null)
				cb_getExecutor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExecutor);
			return cb_getExecutor;
		}

		static IntPtr n_GetExecutor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.MobUIShell __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobUIShell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Executor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Executor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']/method[@name='getExecutor' and count(parameter)=0]"
			[Register ("getExecutor", "()Ljava/lang/Object;", "GetGetExecutorHandler")]
			get {
				const string __id = "getExecutor.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']/method[@name='registerExecutor' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("registerExecutor", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		protected static unsafe string RegisterExecutor (global::Java.Lang.Object executor)
		{
			const string __id = "registerExecutor.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((executor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']/method[@name='registerExecutor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("registerExecutor", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", "")]
		protected static unsafe string RegisterExecutor (string scheme, global::Java.Lang.Object executor)
		{
			const string __id = "registerExecutor.(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scheme);
				__args [1] = new JniArgumentValue ((executor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']/method[@name='setTheme' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTheme", "(I)V", "")]
		public override sealed unsafe void SetTheme (int resid)
		{
			const string __id = "setTheme.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resid);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobUIShell']/method[@name='toMobUIShellUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("toMobUIShellUri", "(Ljava/lang/String;Ljava/util/HashMap;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri ToMobUIShellUri (string fakeActivity, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> @params)
		{
			const string __id = "toMobUIShellUri.(Ljava/lang/String;Ljava/util/HashMap;)Landroid/net/Uri;";
			IntPtr native_fakeActivity = JNIEnv.NewString (fakeActivity);
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fakeActivity);
				__args [1] = new JniArgumentValue (native__params);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fakeActivity);
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

	}
}
