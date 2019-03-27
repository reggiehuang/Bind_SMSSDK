using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Optional']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/Optional", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial class Optional : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/java8/Optional", typeof (Optional));
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

		protected Optional (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Optional']/constructor[@name='Optional' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe Optional (global::Java.Lang.Object value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Optional']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			const string __id = "get.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_orElse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOrElse_Ljava_lang_Object_Handler ()
		{
			if (cb_orElse_Ljava_lang_Object_ == null)
				cb_orElse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OrElse_Ljava_lang_Object_);
			return cb_orElse_Ljava_lang_Object_;
		}

		static IntPtr n_OrElse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_spare)
		{
			global::Com.Mob.Tools.Java8.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object spare = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_spare, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OrElse (spare));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Optional']/method[@name='orElse' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("orElse", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetOrElse_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object OrElse (global::Java.Lang.Object spare)
		{
			const string __id = "orElse.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_spare = JNIEnv.ToLocalJniHandle (spare);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_spare);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_spare);
			}
		}

	}
}
