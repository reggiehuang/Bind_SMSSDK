using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/CachePool", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial class CachePool : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='CachePool.OnRemoveListener']"
		[Register ("com/mob/tools/gui/CachePool$OnRemoveListener", "", "Com.Mob.Tools.Gui.CachePool/IOnRemoveListenerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public partial interface IOnRemoveListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='CachePool.OnRemoveListener']/method[@name='onRemove' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
			[Register ("onRemove", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetOnRemove_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Gui.CachePool/IOnRemoveListenerInvoker, IceShareSDKLib")]
			void OnRemove (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("com/mob/tools/gui/CachePool$OnRemoveListener", DoNotGenerateAcw=true)]
		internal partial class IOnRemoveListenerInvoker : global::Java.Lang.Object, IOnRemoveListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/CachePool$OnRemoveListener", typeof (IOnRemoveListenerInvoker));

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

			public static IOnRemoveListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRemoveListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.gui.CachePool.OnRemoveListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRemoveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onRemove_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnRemove_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_onRemove_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_onRemove_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemove_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_onRemove_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static void n_OnRemove_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mob.Tools.Gui.CachePool.IOnRemoveListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool.IOnRemoveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemove (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onRemove_Ljava_lang_Object_Ljava_lang_Object_;
			public unsafe void OnRemove (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_onRemove_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_onRemove_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onRemove", "(Ljava/lang/Object;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemove_Ljava_lang_Object_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		// event args for com.mob.tools.gui.CachePool.OnRemoveListener.onRemove
		public partial class RemoveEventArgs : global::System.EventArgs {

			public RemoveEventArgs (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Java.Lang.Object p0;
			public global::Java.Lang.Object P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mob/tools/gui/CachePool_OnRemoveListenerImplementor")]
		internal sealed partial class IOnRemoveListenerImplementor : global::Java.Lang.Object, IOnRemoveListener {

			object sender;

			public IOnRemoveListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/tools/gui/CachePool_OnRemoveListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoveEventArgs> Handler;
#pragma warning restore 0649

			public void OnRemove (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RemoveEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnRemoveListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/CachePool", typeof (CachePool));
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

		protected CachePool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/constructor[@name='CachePool' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe CachePool (int capacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (capacity);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			global::Com.Mob.Tools.Gui.CachePool __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Mob.Tools.Gui.CachePool __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/method[@name='get' and count(parameter)=1 and parameter[1][@type='K']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (global::Java.Lang.Object key)
		{
			const string __id = "get.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static bool n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mob.Tools.Gui.CachePool __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (key, value);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/method[@name='put' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Put (global::Java.Lang.Object key, global::Java.Lang.Object value)
		{
			const string __id = "put.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_IHandler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_I == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_Put_Ljava_lang_Object_Ljava_lang_Object_I);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_I;
		}

		static bool n_Put_Ljava_lang_Object_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, int size)
		{
			global::Com.Mob.Tools.Gui.CachePool __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (key, value, size);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/method[@name='put' and count(parameter)=3 and parameter[1][@type='K'] and parameter[2][@type='V'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;I)Z", "GetPut_Ljava_lang_Object_Ljava_lang_Object_IHandler")]
		public virtual unsafe bool Put (global::Java.Lang.Object key, global::Java.Lang.Object value, int size)
		{
			const string __id = "put.(Ljava/lang/Object;Ljava/lang/Object;I)Z";
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_Handler ()
		{
			if (cb_setOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_ == null)
				cb_setOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_);
			return cb_setOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_;
		}

		static void n_SetOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mob.Tools.Gui.CachePool __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.CachePool.IOnRemoveListener listener = (global::Com.Mob.Tools.Gui.CachePool.IOnRemoveListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool.IOnRemoveListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRemoveListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/method[@name='setOnRemoveListener' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.CachePool.OnRemoveListener&lt;K, V&gt;']]"
		[Register ("setOnRemoveListener", "(Lcom/mob/tools/gui/CachePool$OnRemoveListener;)V", "GetSetOnRemoveListener_Lcom_mob_tools_gui_CachePool_OnRemoveListener_Handler")]
		public virtual unsafe void SetOnRemoveListener (global::Com.Mob.Tools.Gui.CachePool.IOnRemoveListener listener)
		{
			const string __id = "setOnRemoveListener.(Lcom/mob/tools/gui/CachePool$OnRemoveListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.CachePool __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_trimBeforeTime_J;
#pragma warning disable 0169
		static Delegate GetTrimBeforeTime_JHandler ()
		{
			if (cb_trimBeforeTime_J == null)
				cb_trimBeforeTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_TrimBeforeTime_J);
			return cb_trimBeforeTime_J;
		}

		static void n_TrimBeforeTime_J (IntPtr jnienv, IntPtr native__this, long time)
		{
			global::Com.Mob.Tools.Gui.CachePool __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.CachePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimBeforeTime (time);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='CachePool']/method[@name='trimBeforeTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("trimBeforeTime", "(J)V", "GetTrimBeforeTime_JHandler")]
		public virtual unsafe void TrimBeforeTime (long time)
		{
			const string __id = "trimBeforeTime.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (time);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
