using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SMSLog']"
	[global::Android.Runtime.Register ("cn/smssdk/utils/SMSLog", DoNotGenerateAcw=true)]
	public partial class SMSLog : global::Com.Mob.Tools.Log.NLog {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SMSLog']/field[@name='FORMAT']"
		[Register ("FORMAT")]
		public const string Format = (string) "[SMSSDK][%s][%s] %s";
		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/utils/SMSLog", typeof (SMSLog));
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

		protected SMSLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Mob.Tools.Log.NLog Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SMSLog']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/mob/tools/log/NLog;", "")]
			get {
				const string __id = "getInstance.()Lcom/mob/tools/log/NLog;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSDKTag;
#pragma warning disable 0169
		static Delegate GetGetSDKTagHandler ()
		{
			if (cb_getSDKTag == null)
				cb_getSDKTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSDKTag);
			return cb_getSDKTag;
		}

		static IntPtr n_GetSDKTag (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SMSLog __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SMSLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKTag);
		}
#pragma warning restore 0169

		protected override unsafe string SDKTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SMSLog']/method[@name='getSDKTag' and count(parameter)=0]"
			[Register ("getSDKTag", "()Ljava/lang/String;", "GetGetSDKTagHandler")]
			get {
				const string __id = "getSDKTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SMSLog']/method[@name='prepare' and count(parameter)=0]"
		[Register ("prepare", "()Lcom/mob/tools/log/NLog;", "")]
		public static unsafe global::Com.Mob.Tools.Log.NLog Prepare ()
		{
			const string __id = "prepare.()Lcom/mob/tools/log/NLog;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
