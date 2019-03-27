using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.CollectByte']"
	[Register ("com/mob/tools/java8/Collect$CollectByte", "", "Com.Mob.Tools.Java8.ICollectCollectByteInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface ICollectCollectByte : global::Com.Mob.Tools.Java8.ICollect {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Collect$CollectByte", DoNotGenerateAcw=true)]
	internal class ICollectCollectByteInvoker : global::Java.Lang.Object, ICollectCollectByte {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Collect$CollectByte", typeof (ICollectCollectByteInvoker));

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

		public static ICollectCollectByte GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollectCollectByte> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Collect.CollectByte"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectCollectByteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCollect_Ljava_lang_Object_Handler ()
		{
			if (cb_collect_Ljava_lang_Object_ == null)
				cb_collect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Ljava_lang_Object_);
			return cb_collect_Ljava_lang_Object_;
		}

		static IntPtr n_Collect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.ICollectCollectByte __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectCollectByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_collect_Ljava_lang_Object_;
		public unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0)
		{
			if (id_collect_Ljava_lang_Object_ == IntPtr.Zero)
				id_collect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Mob.Tools.Java8.Flow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.CollectDouble']"
	[Register ("com/mob/tools/java8/Collect$CollectDouble", "", "Com.Mob.Tools.Java8.ICollectCollectDoubleInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface ICollectCollectDouble : global::Com.Mob.Tools.Java8.ICollect {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Collect$CollectDouble", DoNotGenerateAcw=true)]
	internal class ICollectCollectDoubleInvoker : global::Java.Lang.Object, ICollectCollectDouble {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Collect$CollectDouble", typeof (ICollectCollectDoubleInvoker));

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

		public static ICollectCollectDouble GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollectCollectDouble> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Collect.CollectDouble"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectCollectDoubleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCollect_Ljava_lang_Object_Handler ()
		{
			if (cb_collect_Ljava_lang_Object_ == null)
				cb_collect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Ljava_lang_Object_);
			return cb_collect_Ljava_lang_Object_;
		}

		static IntPtr n_Collect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.ICollectCollectDouble __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectCollectDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_collect_Ljava_lang_Object_;
		public unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0)
		{
			if (id_collect_Ljava_lang_Object_ == IntPtr.Zero)
				id_collect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Mob.Tools.Java8.Flow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.CollectFloat']"
	[Register ("com/mob/tools/java8/Collect$CollectFloat", "", "Com.Mob.Tools.Java8.ICollectCollectFloatInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface ICollectCollectFloat : global::Com.Mob.Tools.Java8.ICollect {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Collect$CollectFloat", DoNotGenerateAcw=true)]
	internal class ICollectCollectFloatInvoker : global::Java.Lang.Object, ICollectCollectFloat {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Collect$CollectFloat", typeof (ICollectCollectFloatInvoker));

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

		public static ICollectCollectFloat GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollectCollectFloat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Collect.CollectFloat"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectCollectFloatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCollect_Ljava_lang_Object_Handler ()
		{
			if (cb_collect_Ljava_lang_Object_ == null)
				cb_collect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Ljava_lang_Object_);
			return cb_collect_Ljava_lang_Object_;
		}

		static IntPtr n_Collect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.ICollectCollectFloat __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectCollectFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_collect_Ljava_lang_Object_;
		public unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0)
		{
			if (id_collect_Ljava_lang_Object_ == IntPtr.Zero)
				id_collect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Mob.Tools.Java8.Flow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.CollectInt']"
	[Register ("com/mob/tools/java8/Collect$CollectInt", "", "Com.Mob.Tools.Java8.ICollectCollectIntInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface ICollectCollectInt : global::Com.Mob.Tools.Java8.ICollect {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Collect$CollectInt", DoNotGenerateAcw=true)]
	internal class ICollectCollectIntInvoker : global::Java.Lang.Object, ICollectCollectInt {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Collect$CollectInt", typeof (ICollectCollectIntInvoker));

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

		public static ICollectCollectInt GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollectCollectInt> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Collect.CollectInt"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectCollectIntInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCollect_Ljava_lang_Object_Handler ()
		{
			if (cb_collect_Ljava_lang_Object_ == null)
				cb_collect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Ljava_lang_Object_);
			return cb_collect_Ljava_lang_Object_;
		}

		static IntPtr n_Collect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.ICollectCollectInt __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectCollectInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_collect_Ljava_lang_Object_;
		public unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0)
		{
			if (id_collect_Ljava_lang_Object_ == IntPtr.Zero)
				id_collect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Mob.Tools.Java8.Flow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.CollectLong']"
	[Register ("com/mob/tools/java8/Collect$CollectLong", "", "Com.Mob.Tools.Java8.ICollectCollectLongInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface ICollectCollectLong : global::Com.Mob.Tools.Java8.ICollect {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Collect$CollectLong", DoNotGenerateAcw=true)]
	internal class ICollectCollectLongInvoker : global::Java.Lang.Object, ICollectCollectLong {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Collect$CollectLong", typeof (ICollectCollectLongInvoker));

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

		public static ICollectCollectLong GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollectCollectLong> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Collect.CollectLong"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectCollectLongInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCollect_Ljava_lang_Object_Handler ()
		{
			if (cb_collect_Ljava_lang_Object_ == null)
				cb_collect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Ljava_lang_Object_);
			return cb_collect_Ljava_lang_Object_;
		}

		static IntPtr n_Collect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.ICollectCollectLong __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectCollectLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_collect_Ljava_lang_Object_;
		public unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0)
		{
			if (id_collect_Ljava_lang_Object_ == IntPtr.Zero)
				id_collect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Mob.Tools.Java8.Flow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.CollectShort']"
	[Register ("com/mob/tools/java8/Collect$CollectShort", "", "Com.Mob.Tools.Java8.ICollectCollectShortInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface ICollectCollectShort : global::Com.Mob.Tools.Java8.ICollect {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Collect$CollectShort", DoNotGenerateAcw=true)]
	internal class ICollectCollectShortInvoker : global::Java.Lang.Object, ICollectCollectShort {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Collect$CollectShort", typeof (ICollectCollectShortInvoker));

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

		public static ICollectCollectShort GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollectCollectShort> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Collect.CollectShort"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectCollectShortInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCollect_Ljava_lang_Object_Handler ()
		{
			if (cb_collect_Ljava_lang_Object_ == null)
				cb_collect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Ljava_lang_Object_);
			return cb_collect_Ljava_lang_Object_;
		}

		static IntPtr n_Collect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.ICollectCollectShort __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectCollectShort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_collect_Ljava_lang_Object_;
		public unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0)
		{
			if (id_collect_Ljava_lang_Object_ == IntPtr.Zero)
				id_collect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Mob.Tools.Java8.Flow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect']"
	[Register ("com/mob/tools/java8/Collect", "", "Com.Mob.Tools.Java8.ICollectInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface ICollect : global::Com.Mob.Tools.Java8.IFunction {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect']/method[@name='collect' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;", "GetCollect_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.ICollectInvoker, IceShareSDKLib")]
		global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Collect", DoNotGenerateAcw=true)]
	internal class ICollectInvoker : global::Java.Lang.Object, ICollect {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/java8/Collect", typeof (ICollectInvoker));

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

		public static ICollect GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollect> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Collect"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCollect_Ljava_lang_Object_Handler ()
		{
			if (cb_collect_Ljava_lang_Object_ == null)
				cb_collect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Ljava_lang_Object_);
			return cb_collect_Ljava_lang_Object_;
		}

		static IntPtr n_Collect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.ICollect __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_collect_Ljava_lang_Object_;
		public unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Java.Lang.Object p0)
		{
			if (id_collect_Ljava_lang_Object_ == IntPtr.Zero)
				id_collect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Mob.Tools.Java8.Flow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
