using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Authorize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.authorize']/class[@name='DeviceAuthorizer']"
	[global::Android.Runtime.Register ("com/mob/commons/authorize/DeviceAuthorizer", DoNotGenerateAcw=true)]
	public sealed partial class DeviceAuthorizer : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/commons/authorize/DeviceAuthorizer", typeof (DeviceAuthorizer));
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

		internal DeviceAuthorizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.authorize']/class[@name='DeviceAuthorizer']/constructor[@name='DeviceAuthorizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceAuthorizer ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.authorize']/class[@name='DeviceAuthorizer']/method[@name='authorize' and count(parameter)=1 and parameter[1][@type='com.mob.commons.MobProduct']]"
		[Register ("authorize", "(Lcom/mob/commons/MobProduct;)Ljava/lang/String;", "")]
		public static unsafe string Authorize (global::Com.Mob.Commons.IMobProduct p0)
		{
			const string __id = "authorize.(Lcom/mob/commons/MobProduct;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.authorize']/class[@name='DeviceAuthorizer']/method[@name='authorizeForOnce' and count(parameter)=0]"
		[Register ("authorizeForOnce", "()Ljava/lang/String;", "")]
		public static unsafe string AuthorizeForOnce ()
		{
			const string __id = "authorizeForOnce.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
