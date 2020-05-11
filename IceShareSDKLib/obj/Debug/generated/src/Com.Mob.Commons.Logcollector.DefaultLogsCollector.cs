using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Logcollector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='DefaultLogsCollector']"
	[global::Android.Runtime.Register ("com/mob/commons/logcollector/DefaultLogsCollector", DoNotGenerateAcw=true)]
	public partial class DefaultLogsCollector : global::Java.Lang.Object, global::Com.Mob.Tools.Log.ILogCollector, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {


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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/logcollector/DefaultLogsCollector", typeof (DefaultLogsCollector));
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

		protected DefaultLogsCollector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addSDK_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAddSDK_Ljava_lang_String_IHandler ()
		{
			if (cb_addSDK_Ljava_lang_String_I == null)
				cb_addSDK_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddSDK_Ljava_lang_String_I);
			return cb_addSDK_Ljava_lang_String_I;
		}

		static void n_AddSDK_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mob.Commons.Logcollector.DefaultLogsCollector __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Logcollector.DefaultLogsCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSDK (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='DefaultLogsCollector']/method[@name='addSDK' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("addSDK", "(Ljava/lang/String;I)V", "GetAddSDK_Ljava_lang_String_IHandler")]
		public virtual unsafe void AddSDK (string p0, int p1)
		{
			const string __id = "addSDK.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='DefaultLogsCollector']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/mob/commons/logcollector/DefaultLogsCollector;", "")]
		public static unsafe global::Com.Mob.Commons.Logcollector.DefaultLogsCollector Get ()
		{
			const string __id = "get.()Lcom/mob/commons/logcollector/DefaultLogsCollector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Logcollector.DefaultLogsCollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.logcollector']/class[@name='DefaultLogsCollector']/method[@name='log' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
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
}
