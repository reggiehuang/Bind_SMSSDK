using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Peek.MapPeek']"
	[Register ("com/mob/tools/java8/Peek$MapPeek", "", "Com.Mob.Tools.Java8.IPeekMapPeekInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial interface IPeekMapPeek : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Peek.MapPeek']/method[@name='peek' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("peek", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetPeek_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IPeekMapPeekInvoker, IceShareSDKLib")]
		void Peek (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Peek$MapPeek", DoNotGenerateAcw=true)]
	internal partial class IPeekMapPeekInvoker : global::Java.Lang.Object, IPeekMapPeek {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Peek$MapPeek", typeof (IPeekMapPeekInvoker));

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

		public static IPeekMapPeek GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPeekMapPeek> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Peek.MapPeek"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPeekMapPeekInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_peek_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPeek_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_peek_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_peek_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Peek_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_peek_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Peek_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.Tools.Java8.IPeekMapPeek __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IPeekMapPeek> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Peek (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_peek_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Peek (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_peek_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_peek_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "peek", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_peek_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Peek']"
	[Register ("com/mob/tools/java8/Peek", "", "Com.Mob.Tools.Java8.IPeekInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IPeek : global::Com.Mob.Tools.Java8.IFunction {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Peek']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("peek", "(Ljava/lang/Object;)V", "GetPeek_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IPeekInvoker, IceShareSDKLib")]
		void Peek (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Peek", DoNotGenerateAcw=true)]
	internal partial class IPeekInvoker : global::Java.Lang.Object, IPeek {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Peek", typeof (IPeekInvoker));

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

		public static IPeek GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPeek> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Peek"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPeekInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_peek_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPeek_Ljava_lang_Object_Handler ()
		{
			if (cb_peek_Ljava_lang_Object_ == null)
				cb_peek_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Peek_Ljava_lang_Object_);
			return cb_peek_Ljava_lang_Object_;
		}

		static void n_Peek_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IPeek __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IPeek> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Peek (p0);
		}
#pragma warning restore 0169

		IntPtr id_peek_Ljava_lang_Object_;
		public unsafe void Peek (global::Java.Lang.Object p0)
		{
			if (id_peek_Ljava_lang_Object_ == IntPtr.Zero)
				id_peek_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "peek", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_peek_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
