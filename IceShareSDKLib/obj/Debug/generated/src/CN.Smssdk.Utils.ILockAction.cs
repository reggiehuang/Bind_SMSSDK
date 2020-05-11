using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk.Utils {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk.utils']/interface[@name='LockAction']"
	[Register ("cn/smssdk/utils/LockAction", "", "CN.Smssdk.Utils.ILockActionInvoker")]
	public partial interface ILockAction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/interface[@name='LockAction']/method[@name='run' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.FileLocker']]"
		[Register ("run", "(Lcom/mob/tools/utils/FileLocker;)Z", "GetRun_Lcom_mob_tools_utils_FileLocker_Handler:CN.Smssdk.Utils.ILockActionInvoker, IceShareSDKLib")]
		bool Run (global::Com.Mob.Tools.Utils.FileLocker p0);

	}

	[global::Android.Runtime.Register ("cn/smssdk/utils/LockAction", DoNotGenerateAcw=true)]
	internal partial class ILockActionInvoker : global::Java.Lang.Object, ILockAction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/utils/LockAction", typeof (ILockActionInvoker));

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

		public static ILockAction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILockAction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.utils.LockAction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILockActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_run_Lcom_mob_tools_utils_FileLocker_;
#pragma warning disable 0169
		static Delegate GetRun_Lcom_mob_tools_utils_FileLocker_Handler ()
		{
			if (cb_run_Lcom_mob_tools_utils_FileLocker_ == null)
				cb_run_Lcom_mob_tools_utils_FileLocker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Run_Lcom_mob_tools_utils_FileLocker_);
			return cb_run_Lcom_mob_tools_utils_FileLocker_;
		}

		static bool n_Run_Lcom_mob_tools_utils_FileLocker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.ILockAction __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.ILockAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Utils.FileLocker p0 = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.FileLocker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Run (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_run_Lcom_mob_tools_utils_FileLocker_;
		public unsafe bool Run (global::Com.Mob.Tools.Utils.FileLocker p0)
		{
			if (id_run_Lcom_mob_tools_utils_FileLocker_ == IntPtr.Zero)
				id_run_Lcom_mob_tools_utils_FileLocker_ = JNIEnv.GetMethodID (class_ref, "run", "(Lcom/mob/tools/utils/FileLocker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_run_Lcom_mob_tools_utils_FileLocker_, __args);
			return __ret;
		}

	}

}
