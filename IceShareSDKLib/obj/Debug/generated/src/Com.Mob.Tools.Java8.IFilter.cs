using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Filter.MapFilter']"
	[Register ("com/mob/tools/java8/Filter$MapFilter", "", "Com.Mob.Tools.Java8.IFilterMapFilterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial interface IFilterMapFilter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Filter.MapFilter']/method[@name='filter' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("filter", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetFilter_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IFilterMapFilterInvoker, IceShareSDKLib")]
		bool Filter (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Filter$MapFilter", DoNotGenerateAcw=true)]
	internal class IFilterMapFilterInvoker : global::Java.Lang.Object, IFilterMapFilter {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Filter$MapFilter", typeof (IFilterMapFilterInvoker));

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

		public static IFilterMapFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFilterMapFilter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Filter.MapFilter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFilterMapFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_filter_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFilter_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_filter_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_filter_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Filter_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_filter_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static bool n_Filter_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.Tools.Java8.IFilterMapFilter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFilterMapFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Filter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_filter_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe bool Filter (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_filter_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_filter_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "filter", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_filter_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Filter']"
	[Register ("com/mob/tools/java8/Filter", "", "Com.Mob.Tools.Java8.IFilterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IFilter : global::Com.Mob.Tools.Java8.IFunction {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Filter']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("filter", "(Ljava/lang/Object;)Z", "GetFilter_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IFilterInvoker, IceShareSDKLib")]
		bool Filter (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Filter", DoNotGenerateAcw=true)]
	internal class IFilterInvoker : global::Java.Lang.Object, IFilter {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Filter", typeof (IFilterInvoker));

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

		public static IFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFilter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Filter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_filter_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFilter_Ljava_lang_Object_Handler ()
		{
			if (cb_filter_Ljava_lang_Object_ == null)
				cb_filter_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Filter_Ljava_lang_Object_);
			return cb_filter_Ljava_lang_Object_;
		}

		static bool n_Filter_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IFilter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Filter (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_filter_Ljava_lang_Object_;
		public unsafe bool Filter (global::Java.Lang.Object p0)
		{
			if (id_filter_Ljava_lang_Object_ == IntPtr.Zero)
				id_filter_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "filter", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_filter_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
