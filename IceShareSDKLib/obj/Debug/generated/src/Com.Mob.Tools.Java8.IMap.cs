using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapByte']"
	[Register ("com/mob/tools/java8/Map$MapByte", "", "Com.Mob.Tools.Java8.IMapMapByteInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface IMapMapByte : global::Com.Mob.Tools.Java8.IMap {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map$MapByte", DoNotGenerateAcw=true)]
	internal partial class IMapMapByteInvoker : global::Java.Lang.Object, IMapMapByte {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map$MapByte", typeof (IMapMapByteInvoker));

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

		public static IMapMapByte GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMapByte> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map.MapByte"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMapByteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IMapMapByte __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapDouble']"
	[Register ("com/mob/tools/java8/Map$MapDouble", "", "Com.Mob.Tools.Java8.IMapMapDoubleInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface IMapMapDouble : global::Com.Mob.Tools.Java8.IMap {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map$MapDouble", DoNotGenerateAcw=true)]
	internal partial class IMapMapDoubleInvoker : global::Java.Lang.Object, IMapMapDouble {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map$MapDouble", typeof (IMapMapDoubleInvoker));

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

		public static IMapMapDouble GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMapDouble> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map.MapDouble"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMapDoubleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IMapMapDouble __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapFloat']"
	[Register ("com/mob/tools/java8/Map$MapFloat", "", "Com.Mob.Tools.Java8.IMapMapFloatInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface IMapMapFloat : global::Com.Mob.Tools.Java8.IMap {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map$MapFloat", DoNotGenerateAcw=true)]
	internal partial class IMapMapFloatInvoker : global::Java.Lang.Object, IMapMapFloat {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map$MapFloat", typeof (IMapMapFloatInvoker));

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

		public static IMapMapFloat GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMapFloat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map.MapFloat"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMapFloatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IMapMapFloat __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapInt']"
	[Register ("com/mob/tools/java8/Map$MapInt", "", "Com.Mob.Tools.Java8.IMapMapIntInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface IMapMapInt : global::Com.Mob.Tools.Java8.IMap {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map$MapInt", DoNotGenerateAcw=true)]
	internal partial class IMapMapIntInvoker : global::Java.Lang.Object, IMapMapInt {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map$MapInt", typeof (IMapMapIntInvoker));

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

		public static IMapMapInt GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMapInt> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map.MapInt"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMapIntInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IMapMapInt __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapLong']"
	[Register ("com/mob/tools/java8/Map$MapLong", "", "Com.Mob.Tools.Java8.IMapMapLongInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface IMapMapLong : global::Com.Mob.Tools.Java8.IMap {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map$MapLong", DoNotGenerateAcw=true)]
	internal partial class IMapMapLongInvoker : global::Java.Lang.Object, IMapMapLong {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map$MapLong", typeof (IMapMapLongInvoker));

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

		public static IMapMapLong GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMapLong> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map.MapLong"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMapLongInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IMapMapLong __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapMap']"
	[Register ("com/mob/tools/java8/Map$MapMap", "", "Com.Mob.Tools.Java8.IMapMapMapInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V", "R"})]
	public partial interface IMapMapMap : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapMap']/method[@name='map' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("map", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetMap_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IMapMapMapInvoker, IceShareSDKLib")]
		global::Java.Lang.Object Map (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map$MapMap", DoNotGenerateAcw=true)]
	internal partial class IMapMapMapInvoker : global::Java.Lang.Object, IMapMapMap {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map$MapMap", typeof (IMapMapMapInvoker));

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

		public static IMapMapMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMapMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map.MapMap"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMapMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.Tools.Java8.IMapMapMap __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_map_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map.MapShort']"
	[Register ("com/mob/tools/java8/Map$MapShort", "", "Com.Mob.Tools.Java8.IMapMapShortInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"N"})]
	public partial interface IMapMapShort : global::Com.Mob.Tools.Java8.IMap {

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map$MapShort", DoNotGenerateAcw=true)]
	internal partial class IMapMapShortInvoker : global::Java.Lang.Object, IMapMapShort {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map$MapShort", typeof (IMapMapShortInvoker));

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

		public static IMapMapShort GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapMapShort> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map.MapShort"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapMapShortInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IMapMapShort __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapShort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map']"
	[Register ("com/mob/tools/java8/Map", "", "Com.Mob.Tools.Java8.IMapInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface IMap : global::Com.Mob.Tools.Java8.IFunction {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Map']/method[@name='map' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("map", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetMap_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.IMapInvoker, IceShareSDKLib")]
		global::Java.Lang.Object Map (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/Map", DoNotGenerateAcw=true)]
	internal partial class IMapInvoker : global::Java.Lang.Object, IMap {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Map", typeof (IMapInvoker));

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

		public static IMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Map"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Java8.IMap __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object p0)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
