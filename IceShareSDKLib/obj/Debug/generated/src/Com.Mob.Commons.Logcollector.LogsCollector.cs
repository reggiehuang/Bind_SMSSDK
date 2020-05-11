using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Logcollector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='LogsCollector']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mob/commons/logcollector/LogsCollector", DoNotGenerateAcw=true)]
	public abstract partial class LogsCollector : global::Java.Lang.Object, global::Com.Mob.Tools.Log.ILogCollector, global::Com.Mob.Tools.Proguard.IProtectedMemberKeeper, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {


		public static class InterfaceConsts {

			// The following are fields from: com.mob.tools.log.LogCollector

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.log']/interface[@name='LogCollector']/field[@name='LEVEL_CRASH']"
			[Register ("LEVEL_CRASH")]
			public const int LevelCrash = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.log']/interface[@name='LogCollector']/field[@name='LEVEL_NATIVE']"
			[Register ("LEVEL_NATIVE")]
			public const int LevelNative = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.log']/interface[@name='LogCollector']/field[@name='LEVEL_NORMAL']"
			[Register ("LEVEL_NORMAL")]
			public const int LevelNormal = (int) 0;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/logcollector/LogsCollector", typeof (LogsCollector));
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

		protected LogsCollector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='LogsCollector']/constructor[@name='LogsCollector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogsCollector ()
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
			global::Com.Mob.Commons.Logcollector.LogsCollector __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Logcollector.LogsCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKTag);
		}
#pragma warning restore 0169

		protected abstract string SDKTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='LogsCollector']/method[@name='getSDKTag' and count(parameter)=0]"
			[Register ("getSDKTag", "()Ljava/lang/String;", "GetGetSDKTagHandler")] get;
		}

		static Delegate cb_getSDKVersion;
#pragma warning disable 0169
		static Delegate GetGetSDKVersionHandler ()
		{
			if (cb_getSDKVersion == null)
				cb_getSDKVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSDKVersion);
			return cb_getSDKVersion;
		}

		static int n_GetSDKVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Commons.Logcollector.LogsCollector __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Logcollector.LogsCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SDKVersion;
		}
#pragma warning restore 0169

		protected abstract int SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='LogsCollector']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()I", "GetGetSDKVersionHandler")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='LogsCollector']/method[@name='log' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Log (string p0, int p1, int p2, string p3, string p4)
		{
			const string __id = "log.(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/commons/logcollector/LogsCollector", DoNotGenerateAcw=true)]
	internal partial class LogsCollectorInvoker : LogsCollector {

		public LogsCollectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/logcollector/LogsCollector", typeof (LogsCollectorInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe string SDKTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='LogsCollector']/method[@name='getSDKTag' and count(parameter)=0]"
			[Register ("getSDKTag", "()Ljava/lang/String;", "GetGetSDKTagHandler")]
			get {
				const string __id = "getSDKTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected override unsafe int SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='LogsCollector']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()I", "GetGetSDKVersionHandler")]
			get {
				const string __id = "getSDKVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
