using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.commons']/interface[@name='MobProduct']"
	[Register ("com/mob/commons/MobProduct", "", "Com.Mob.Commons.IMobProductInvoker")]
	public partial interface IMobProduct : IJavaObject {

		string ProductTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/interface[@name='MobProduct']/method[@name='getProductTag' and count(parameter)=0]"
			[Register ("getProductTag", "()Ljava/lang/String;", "GetGetProductTagHandler:Com.Mob.Commons.IMobProductInvoker, IceShareSDKLib")] get;
		}

		int Sdkver {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/interface[@name='MobProduct']/method[@name='getSdkver' and count(parameter)=0]"
			[Register ("getSdkver", "()I", "GetGetSdkverHandler:Com.Mob.Commons.IMobProductInvoker, IceShareSDKLib")] get;
		}

	}

	[global::Android.Runtime.Register ("com/mob/commons/MobProduct", DoNotGenerateAcw=true)]
	internal class IMobProductInvoker : global::Java.Lang.Object, IMobProduct {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/commons/MobProduct", typeof (IMobProductInvoker));

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

		public static IMobProduct GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMobProduct> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.commons.MobProduct"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMobProductInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getProductTag;
#pragma warning disable 0169
		static Delegate GetGetProductTagHandler ()
		{
			if (cb_getProductTag == null)
				cb_getProductTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductTag);
			return cb_getProductTag;
		}

		static IntPtr n_GetProductTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Commons.IMobProduct __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.IMobProduct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductTag);
		}
#pragma warning restore 0169

		IntPtr id_getProductTag;
		public unsafe string ProductTag {
			get {
				if (id_getProductTag == IntPtr.Zero)
					id_getProductTag = JNIEnv.GetMethodID (class_ref, "getProductTag", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductTag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSdkver;
#pragma warning disable 0169
		static Delegate GetGetSdkverHandler ()
		{
			if (cb_getSdkver == null)
				cb_getSdkver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSdkver);
			return cb_getSdkver;
		}

		static int n_GetSdkver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Commons.IMobProduct __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.IMobProduct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sdkver;
		}
#pragma warning restore 0169

		IntPtr id_getSdkver;
		public unsafe int Sdkver {
			get {
				if (id_getSdkver == IntPtr.Zero)
					id_getSdkver = JNIEnv.GetMethodID (class_ref, "getSdkver", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSdkver);
			}
		}

	}

}
