using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/SharePrefrenceHelper", DoNotGenerateAcw=true)]
	public partial class SharePrefrenceHelper : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='SharePrefrenceHelper.OnCommitListener']"
		[Register ("com/mob/tools/utils/SharePrefrenceHelper$OnCommitListener", "", "Com.Mob.Tools.Utils.SharePrefrenceHelper/IOnCommitListenerInvoker")]
		public partial interface IOnCommitListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='SharePrefrenceHelper.OnCommitListener']/method[@name='onCommit' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onCommit", "(Ljava/lang/Throwable;)V", "GetOnCommit_Ljava_lang_Throwable_Handler:Com.Mob.Tools.Utils.SharePrefrenceHelper/IOnCommitListenerInvoker, IceShareSDKLib")]
			void OnCommit (global::Java.Lang.Throwable p0);

		}

		[global::Android.Runtime.Register ("com/mob/tools/utils/SharePrefrenceHelper$OnCommitListener", DoNotGenerateAcw=true)]
		internal partial class IOnCommitListenerInvoker : global::Java.Lang.Object, IOnCommitListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/SharePrefrenceHelper$OnCommitListener", typeof (IOnCommitListenerInvoker));

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

			public static IOnCommitListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCommitListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.utils.SharePrefrenceHelper.OnCommitListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCommitListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCommit_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnCommit_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onCommit_Ljava_lang_Throwable_ == null)
					cb_onCommit_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCommit_Ljava_lang_Throwable_);
				return cb_onCommit_Ljava_lang_Throwable_;
			}

			static void n_OnCommit_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCommit (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCommit_Ljava_lang_Throwable_;
			public unsafe void OnCommit (global::Java.Lang.Throwable p0)
			{
				if (id_onCommit_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onCommit_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onCommit", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCommit_Ljava_lang_Throwable_, __args);
			}

		}

		// event args for com.mob.tools.utils.SharePrefrenceHelper.OnCommitListener.onCommit
		public partial class CommitEventArgs : global::System.EventArgs {

			public CommitEventArgs (global::Java.Lang.Throwable p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Throwable p0;
			public global::Java.Lang.Throwable P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mob/tools/utils/SharePrefrenceHelper_OnCommitListenerImplementor")]
		internal sealed partial class IOnCommitListenerImplementor : global::Java.Lang.Object, IOnCommitListener {

			object sender;

			public IOnCommitListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/tools/utils/SharePrefrenceHelper_OnCommitListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CommitEventArgs> Handler;
#pragma warning restore 0649

			public void OnCommit (global::Java.Lang.Throwable p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CommitEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCommitListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/SharePrefrenceHelper", typeof (SharePrefrenceHelper));
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

		protected SharePrefrenceHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/constructor[@name='SharePrefrenceHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SharePrefrenceHelper (global::Android.Content.Context c)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/HashMap;", "GetGetAllHandler")]
			get {
				const string __id = "getAll.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetBoolean (string key)
		{
			const string __id = "getBoolean.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getFloat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFloat_Ljava_lang_String_Handler ()
		{
			if (cb_getFloat_Ljava_lang_String_ == null)
				cb_getFloat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetFloat_Ljava_lang_String_);
			return cb_getFloat_Ljava_lang_String_;
		}

		static float n_GetFloat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFloat (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFloat", "(Ljava/lang/String;)F", "GetGetFloat_Ljava_lang_String_Handler")]
		public virtual unsafe float GetFloat (string key)
		{
			const string __id = "getFloat.(Ljava/lang/String;)F";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static int n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)I", "GetGetInt_Ljava_lang_String_Handler")]
		public virtual unsafe int GetInt (string key)
		{
			const string __id = "getInt.(Ljava/lang/String;)I";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual unsafe long GetLong (string key)
		{
			const string __id = "getLong.(Ljava/lang/String;)J";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string key)
		{
			const string __id = "getString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_open_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Open_Ljava_lang_String_);
			return cb_open_Ljava_lang_String_;
		}

		static void n_Open_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Open (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;)V", "GetOpen_Ljava_lang_String_Handler")]
		public virtual unsafe void Open (string name)
		{
			const string __id = "open.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_open_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_IHandler ()
		{
			if (cb_open_Ljava_lang_String_I == null)
				cb_open_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Open_Ljava_lang_String_I);
			return cb_open_Ljava_lang_String_I;
		}

		static void n_Open_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int version)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Open (name, version);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("open", "(Ljava/lang/String;I)V", "GetOpen_Ljava_lang_String_IHandler")]
		public virtual unsafe void Open (string name, int version)
		{
			const string __id = "open.(Ljava/lang/String;I)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (version);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_Object_);
			return cb_put_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPut_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Put (string key, global::Java.Lang.Object value)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_putAll_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetPutAll_Ljava_util_HashMap_Handler ()
		{
			if (cb_putAll_Ljava_util_HashMap_ == null)
				cb_putAll_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutAll_Ljava_util_HashMap_);
			return cb_putAll_Ljava_util_HashMap_;
		}

		static void n_PutAll_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_all)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var all = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_all, JniHandleOwnership.DoNotTransfer);
			__this.PutAll (all);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='putAll' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("putAll", "(Ljava/util/HashMap;)V", "GetPutAll_Ljava_util_HashMap_Handler")]
		public virtual unsafe void PutAll (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> all)
		{
			const string __id = "putAll.(Ljava/util/HashMap;)V";
			IntPtr native_all = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (all);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_all);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_all);
			}
		}

		static Delegate cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_Ljava_lang_Boolean_Handler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_ == null)
				cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutBoolean_Ljava_lang_String_Ljava_lang_Boolean_);
			return cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
		}

		static void n_PutBoolean_Ljava_lang_String_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean value = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "GetPutBoolean_Ljava_lang_String_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void PutBoolean (string key, global::Java.Lang.Boolean value)
		{
			const string __id = "putBoolean.(Ljava/lang/String;Ljava/lang/Boolean;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_putFloat_Ljava_lang_String_Ljava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetPutFloat_Ljava_lang_String_Ljava_lang_Float_Handler ()
		{
			if (cb_putFloat_Ljava_lang_String_Ljava_lang_Float_ == null)
				cb_putFloat_Ljava_lang_String_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutFloat_Ljava_lang_String_Ljava_lang_Float_);
			return cb_putFloat_Ljava_lang_String_Ljava_lang_Float_;
		}

		static void n_PutFloat_Ljava_lang_String_Ljava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Float value = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutFloat (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='putFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Float']]"
		[Register ("putFloat", "(Ljava/lang/String;Ljava/lang/Float;)V", "GetPutFloat_Ljava_lang_String_Ljava_lang_Float_Handler")]
		public virtual unsafe void PutFloat (string key, global::Java.Lang.Float value)
		{
			const string __id = "putFloat.(Ljava/lang/String;Ljava/lang/Float;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_putInt_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetPutInt_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_putInt_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_putInt_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutInt_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_putInt_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static void n_PutInt_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutInt (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("putInt", "(Ljava/lang/String;Ljava/lang/Integer;)V", "GetPutInt_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe void PutInt (string key, global::Java.Lang.Integer value)
		{
			const string __id = "putInt.(Ljava/lang/String;Ljava/lang/Integer;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_putLong_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_putLong_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_putLong_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutLong_Ljava_lang_String_Ljava_lang_Long_);
			return cb_putLong_Ljava_lang_String_Ljava_lang_Long_;
		}

		static void n_PutLong_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long value = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("putLong", "(Ljava/lang/String;Ljava/lang/Long;)V", "GetPutLong_Ljava_lang_String_Ljava_lang_Long_Handler")]
		public virtual unsafe void PutLong (string key, global::Java.Lang.Long value)
		{
			const string __id = "putLong.(Ljava/lang/String;Ljava/lang/Long;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutString (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutString (string key, string value)
		{
			const string __id = "putString.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Remove (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string key)
		{
			const string __id = "remove.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_setOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_Handler ()
		{
			if (cb_setOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_ == null)
				cb_setOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_);
			return cb_setOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_;
		}

		static void n_SetOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener listener = (global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCommitListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SharePrefrenceHelper']/method[@name='setOnCommitListener' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.SharePrefrenceHelper.OnCommitListener']]"
		[Register ("setOnCommitListener", "(Lcom/mob/tools/utils/SharePrefrenceHelper$OnCommitListener;)V", "GetSetOnCommitListener_Lcom_mob_tools_utils_SharePrefrenceHelper_OnCommitListener_Handler")]
		public virtual unsafe void SetOnCommitListener (global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener listener)
		{
			const string __id = "setOnCommitListener.(Lcom/mob/tools/utils/SharePrefrenceHelper$OnCommitListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener"
		public event EventHandler<global::Com.Mob.Tools.Utils.SharePrefrenceHelper.CommitEventArgs> Commit {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener, global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListenerImplementor>(
						ref weak_implementor_SetOnCommitListener,
						__CreateIOnCommitListenerImplementor,
						SetOnCommitListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListener, global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListenerImplementor>(
						ref weak_implementor_SetOnCommitListener,
						global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListenerImplementor.__IsEmpty,
						__v => SetOnCommitListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCommitListener;

		global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListenerImplementor __CreateIOnCommitListenerImplementor ()
		{
			return new global::Com.Mob.Tools.Utils.SharePrefrenceHelper.IOnCommitListenerImplementor (this);
		}
#endregion
	}
}
