using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Log {

	[Register ("com/mob/tools/log/LogCollector", DoNotGenerateAcw=true)]
	public abstract class LogCollector : Java.Lang.Object {

		internal LogCollector ()
		{
		}

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

	[Register ("com/mob/tools/log/LogCollector", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'LogCollector' type. This type will be removed in a future release.", error: true)]
	public abstract class LogCollectorConsts : LogCollector {

		private LogCollectorConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.log']/interface[@name='LogCollector']"
	[Register ("com/mob/tools/log/LogCollector", "", "Com.Mob.Tools.Log.ILogCollectorInvoker")]
	public partial interface ILogCollector : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/interface[@name='LogCollector']/method[@name='log' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", "GetLog_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_Handler:Com.Mob.Tools.Log.ILogCollectorInvoker, IceShareSDKLib")]
		void Log (string p0, int p1, int p2, string p3, string p4);

	}

	[global::Android.Runtime.Register ("com/mob/tools/log/LogCollector", DoNotGenerateAcw=true)]
	internal partial class ILogCollectorInvoker : global::Java.Lang.Object, ILogCollector {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/log/LogCollector", typeof (ILogCollectorInvoker));

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

		public static ILogCollector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogCollector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.log.LogCollector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogCollectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_ == null)
				cb_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_);
			return cb_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Mob.Tools.Log.ILogCollector __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.ILogCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_;
		public unsafe void Log (string p0, int p1, int p2, string p3, string p4)
		{
			if (id_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

}
