using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='MapMaker']"
	[Register ("com/mob/tools/java8/MapMaker", "", "Com.Mob.Tools.Java8.IMapMakerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
	public partial interface IMapMaker : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='MapMaker']/method[@name='toMap' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("toMap", "(Ljava/lang/Object;Ljava/util/Map;)V", "GetToMap_Ljava_lang_Object_Ljava_util_Map_Handler:Com.Mob.Tools.Java8.IMapMakerInvoker, IceShareSDKLib")]
		void ToMap (global::Java.Lang.Object p0, global::System.Collections.IDictionary p1);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/MapMaker", DoNotGenerateAcw=true)]
	internal partial class IMapMakerInvoker : global::Java.Lang.Object, IMapMaker {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/MapMaker", typeof (IMapMakerInvoker));

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

		public static IMapMaker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMaker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.MapMaker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMakerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_toMap_Ljava_lang_Object_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetToMap_Ljava_lang_Object_Ljava_util_Map_Handler ()
		{
			if (cb_toMap_Ljava_lang_Object_Ljava_util_Map_ == null)
				cb_toMap_Ljava_lang_Object_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToMap_Ljava_lang_Object_Ljava_util_Map_);
			return cb_toMap_Ljava_lang_Object_Ljava_util_Map_;
		}

		static void n_ToMap_Ljava_lang_Object_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.Tools.Java8.IMapMaker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ToMap (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_toMap_Ljava_lang_Object_Ljava_util_Map_;
		public unsafe void ToMap (global::Java.Lang.Object p0, global::System.Collections.IDictionary p1)
		{
			if (id_toMap_Ljava_lang_Object_Ljava_util_Map_ == IntPtr.Zero)
				id_toMap_Ljava_lang_Object_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "toMap", "(Ljava/lang/Object;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toMap_Ljava_lang_Object_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
