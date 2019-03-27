using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Twitter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.twitter']/interface[@name='UpLoadViewCallBack']"
	[Register ("cn/sharesdk/twitter/UpLoadViewCallBack", "", "CN.Sharesdk.Twitter.IUpLoadViewCallBackInvoker")]
	public partial interface IUpLoadViewCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.twitter']/interface[@name='UpLoadViewCallBack']/method[@name='onResule' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onResule", "(Ljava/lang/String;)V", "GetOnResule_Ljava_lang_String_Handler:CN.Sharesdk.Twitter.IUpLoadViewCallBackInvoker, IceShareSDKLib")]
		void OnResule (string p0);

	}

	[global::Android.Runtime.Register ("cn/sharesdk/twitter/UpLoadViewCallBack", DoNotGenerateAcw=true)]
	internal class IUpLoadViewCallBackInvoker : global::Java.Lang.Object, IUpLoadViewCallBack {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/sharesdk/twitter/UpLoadViewCallBack", typeof (IUpLoadViewCallBackInvoker));

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

		public static IUpLoadViewCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUpLoadViewCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.sharesdk.twitter.UpLoadViewCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUpLoadViewCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResule_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnResule_Ljava_lang_String_Handler ()
		{
			if (cb_onResule_Ljava_lang_String_ == null)
				cb_onResule_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResule_Ljava_lang_String_);
			return cb_onResule_Ljava_lang_String_;
		}

		static void n_OnResule_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Twitter.IUpLoadViewCallBack __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Twitter.IUpLoadViewCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResule (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResule_Ljava_lang_String_;
		public unsafe void OnResule (string p0)
		{
			if (id_onResule_Ljava_lang_String_ == IntPtr.Zero)
				id_onResule_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onResule", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResule_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
