using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Inject.MapInject']"
	[Register ("com/mob/tools/java8/Inject$MapInject", "", "Com.Mob.Tools.Java8.IInjectMapInjectInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V", "R"})]
	public partial interface IInjectMapInject : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Inject.MapInject']/method[@name='inject' and count(parameter)=3 and parameter[1][@type='K'] and parameter[2][@type='V'] and parameter[3][@type='R']]"
		[Register ("inject", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IInjectMapInjectInvoker, IceShareSDKLib")]
		global::Java.Lang.Object Inject (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Inject$MapInject", DoNotGenerateAcw=true)]
	internal class IInjectMapInjectInvoker : global::Java.Lang.Object, IInjectMapInject {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Inject$MapInject", typeof (IInjectMapInjectInvoker));

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

		public static IInjectMapInject GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInjectMapInject> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Inject.MapInject"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInjectMapInjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mob.Tools.Java8.IInjectMapInject __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IInjectMapInject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Inject (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Inject (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "inject", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inject_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Inject']"
	[Register ("com/mob/tools/java8/Inject", "", "Com.Mob.Tools.Java8.IInjectInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface IInject : global::Com.Mob.Tools.Java8.IFunction {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Inject']/method[@name='inject' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='R']]"
		[Register ("inject", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInject_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IInjectInvoker, IceShareSDKLib")]
		global::Java.Lang.Object Inject (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Inject", DoNotGenerateAcw=true)]
	internal class IInjectInvoker : global::Java.Lang.Object, IInject {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Inject", typeof (IInjectInvoker));

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

		public static IInject GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInject> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Inject"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_inject_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInject_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_inject_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_inject_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Inject_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_inject_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Inject_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.Tools.Java8.IInject __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IInject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Inject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_inject_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Inject (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_inject_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_inject_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "inject", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inject_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
