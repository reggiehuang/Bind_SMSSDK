using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.log']/class[@name='MobUncaughtExceptionHandler']"
	[global::Android.Runtime.Register ("com/mob/tools/log/MobUncaughtExceptionHandler", DoNotGenerateAcw=true)]
	public partial class MobUncaughtExceptionHandler : global::Java.Lang.Object, global::Java.Lang.Thread.IUncaughtExceptionHandler {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/log/MobUncaughtExceptionHandler", typeof (MobUncaughtExceptionHandler));
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

		protected MobUncaughtExceptionHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='MobUncaughtExceptionHandler']/method[@name='closeLog' and count(parameter)=0]"
		[Register ("closeLog", "()V", "")]
		public static unsafe void CloseLog ()
		{
			const string __id = "closeLog.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='MobUncaughtExceptionHandler']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "")]
		public static unsafe void Disable ()
		{
			const string __id = "disable.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='MobUncaughtExceptionHandler']/method[@name='openLog' and count(parameter)=0]"
		[Register ("openLog", "()V", "")]
		public static unsafe void OpenLog ()
		{
			const string __id = "openLog.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='MobUncaughtExceptionHandler']/method[@name='register' and count(parameter)=0]"
		[Register ("register", "()V", "")]
		public static unsafe void Register ()
		{
			const string __id = "register.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_ex)
		{
			global::Com.Mob.Tools.Log.MobUncaughtExceptionHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.MobUncaughtExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_thread, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.UncaughtException (thread, ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='MobUncaughtExceptionHandler']/method[@name='uncaughtException' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void UncaughtException (global::Java.Lang.Thread thread, global::Java.Lang.Throwable ex)
		{
			const string __id = "uncaughtException.(Ljava/lang/Thread;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
				__args [1] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
