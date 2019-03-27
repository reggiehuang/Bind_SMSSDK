using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Each.MapEach']"
	[Register ("com/mob/tools/java8/Each$MapEach", "", "Com.Mob.Tools.Java8.IEachMapEachInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial interface IEachMapEach : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Each.MapEach']/method[@name='each' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("each", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetEach_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IEachMapEachInvoker, IceShareSDKLib")]
		void Each (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Each$MapEach", DoNotGenerateAcw=true)]
	internal class IEachMapEachInvoker : global::Java.Lang.Object, IEachMapEach {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Each$MapEach", typeof (IEachMapEachInvoker));

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

		public static IEachMapEach GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEachMapEach> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Each.MapEach"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEachMapEachInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_each_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEach_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_each_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_each_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Each_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_each_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Each_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.Tools.Java8.IEachMapEach __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IEachMapEach> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Each (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_each_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Each (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_each_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_each_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "each", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_each_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Each']"
	[Register ("com/mob/tools/java8/Each", "", "Com.Mob.Tools.Java8.IEachInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IEach : global::Com.Mob.Tools.Java8.IFunction {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Each']/method[@name='each' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("each", "(Ljava/lang/Object;)V", "GetEach_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IEachInvoker, IceShareSDKLib")]
		void Each (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Each", DoNotGenerateAcw=true)]
	internal class IEachInvoker : global::Java.Lang.Object, IEach {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Each", typeof (IEachInvoker));

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

		public static IEach GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEach> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Each"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEachInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_each_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEach_Ljava_lang_Object_Handler ()
		{
			if (cb_each_Ljava_lang_Object_ == null)
				cb_each_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Each_Ljava_lang_Object_);
			return cb_each_Ljava_lang_Object_;
		}

		static void n_Each_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IEach __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IEach> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Each (p0);
		}
#pragma warning restore 0169

		IntPtr id_each_Ljava_lang_Object_;
		public unsafe void Each (global::Java.Lang.Object p0)
		{
			if (id_each_Ljava_lang_Object_ == IntPtr.Zero)
				id_each_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "each", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_each_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
