using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Utag {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.commons.utag']/interface[@name='UserTagError']"
	[Register ("com/mob/commons/utag/UserTagError", "", "Com.Mob.Commons.Utag.IUserTagErrorInvoker")]
	public partial interface IUserTagError : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/interface[@name='UserTagError']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Mob.Commons.Utag.IUserTagErrorInvoker, IceShareSDKLib")]
		void OnError (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("com/mob/commons/utag/UserTagError", DoNotGenerateAcw=true)]
	internal partial class IUserTagErrorInvoker : global::Java.Lang.Object, IUserTagError {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/utag/UserTagError", typeof (IUserTagErrorInvoker));

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

		public static IUserTagError GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUserTagError> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.commons.utag.UserTagError"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUserTagErrorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Commons.Utag.IUserTagError __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.IUserTagError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
		}

	}

}
