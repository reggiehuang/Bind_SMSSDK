using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Hashon']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/Hashon", DoNotGenerateAcw=true)]
	public partial class Hashon : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='Hashon.TabulateAdapter']"
		[Register ("com/mob/tools/utils/Hashon$TabulateAdapter", "", "Com.Mob.Tools.Utils.Hashon/ITabulateAdapterInvoker")]
		public partial interface ITabulateAdapter : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='Hashon.TabulateAdapter']/method[@name='tabulate' and count(parameter)=0]"
			[Register ("tabulate", "()Ljava/lang/Object;", "GetTabulateHandler:Com.Mob.Tools.Utils.Hashon/ITabulateAdapterInvoker, IceShareSDKLib")]
			global::Java.Lang.Object Tabulate ();

		}

		[global::Android.Runtime.Register ("com/mob/tools/utils/Hashon$TabulateAdapter", DoNotGenerateAcw=true)]
		internal partial class ITabulateAdapterInvoker : global::Java.Lang.Object, ITabulateAdapter {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/Hashon$TabulateAdapter", typeof (ITabulateAdapterInvoker));

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

			public static ITabulateAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITabulateAdapter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.utils.Hashon.TabulateAdapter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITabulateAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_tabulate;
#pragma warning disable 0169
			static Delegate GetTabulateHandler ()
			{
				if (cb_tabulate == null)
					cb_tabulate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Tabulate);
				return cb_tabulate;
			}

			static IntPtr n_Tabulate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.Utils.Hashon.ITabulateAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.Hashon.ITabulateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Tabulate ());
			}
#pragma warning restore 0169

			IntPtr id_tabulate;
			public unsafe global::Java.Lang.Object Tabulate ()
			{
				if (id_tabulate == IntPtr.Zero)
					id_tabulate = JNIEnv.GetMethodID (class_ref, "tabulate", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tabulate), JniHandleOwnership.TransferLocalRef);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/Hashon", typeof (Hashon));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Hashon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Hashon']/constructor[@name='Hashon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Hashon ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_format_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_lang_String_Handler ()
		{
			if (cb_format_Ljava_lang_String_ == null)
				cb_format_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_lang_String_);
			return cb_format_Ljava_lang_String_;
		}

		static IntPtr n_Format_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonStr)
		{
			global::Com.Mob.Tools.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string jsonStr = JNIEnv.GetString (native_jsonStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (jsonStr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Hashon']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("format", "(Ljava/lang/String;)Ljava/lang/String;", "GetFormat_Ljava_lang_String_Handler")]
		public virtual unsafe string Format (string jsonStr)
		{
			const string __id = "format.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_jsonStr = JNIEnv.NewString (jsonStr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonStr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonStr);
			}
		}

		static Delegate cb_fromHashMap_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetFromHashMap_Ljava_util_HashMap_Handler ()
		{
			if (cb_fromHashMap_Ljava_util_HashMap_ == null)
				cb_fromHashMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromHashMap_Ljava_util_HashMap_);
			return cb_fromHashMap_Ljava_util_HashMap_;
		}

		static IntPtr n_FromHashMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_map)
		{
			global::Com.Mob.Tools.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var map = global::Android.Runtime.JavaDictionary.FromJniHandle (native_map, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FromHashMap (map));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Hashon']/method[@name='fromHashMap' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, T&gt;']]"
		[Register ("fromHashMap", "(Ljava/util/HashMap;)Ljava/lang/String;", "GetFromHashMap_Ljava_util_HashMap_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe string FromHashMap (global::System.Collections.IDictionary map)
		{
			const string __id = "fromHashMap.(Ljava/util/HashMap;)Ljava/lang/String;";
			IntPtr native_map = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_map);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static Delegate cb_fromJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromJson_Ljava_lang_String_Handler ()
		{
			if (cb_fromJson_Ljava_lang_String_ == null)
				cb_fromJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromJson_Ljava_lang_String_);
			return cb_fromJson_Ljava_lang_String_;
		}

		static IntPtr n_FromJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonStr)
		{
			global::Com.Mob.Tools.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string jsonStr = JNIEnv.GetString (native_jsonStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.FromJson (jsonStr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Hashon']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Ljava/util/HashMap;", "GetFromJson_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::System.Collections.IDictionary FromJson (string jsonStr)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_jsonStr = JNIEnv.NewString (jsonStr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonStr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonStr);
			}
		}

		static Delegate cb_fromJson_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetFromJson_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_fromJson_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_fromJson_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FromJson_Ljava_lang_String_Ljava_lang_Class_);
			return cb_fromJson_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_FromJson_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_json, IntPtr native_clazz)
		{
			global::Com.Mob.Tools.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string json = JNIEnv.GetString (native_json, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromJson (json, clazz));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Hashon']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "GetFromJson_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object FromJson (string json, global::Java.Lang.Class clazz)
		{
			const string __id = "fromJson.(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_json);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static Delegate cb_fromObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFromObject_Ljava_lang_Object_Handler ()
		{
			if (cb_fromObject_Ljava_lang_Object_ == null)
				cb_fromObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromObject_Ljava_lang_Object_);
			return cb_fromObject_Ljava_lang_Object_;
		}

		static IntPtr n_FromObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Com.Mob.Tools.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FromObject (@object));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Hashon']/method[@name='fromObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("fromObject", "(Ljava/lang/Object;)Ljava/lang/String;", "GetFromObject_Ljava_lang_Object_Handler")]
		public virtual unsafe string FromObject (global::Java.Lang.Object @object)
		{
			const string __id = "fromObject.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
