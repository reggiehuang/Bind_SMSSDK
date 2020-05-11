using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']"
	[global::Android.Runtime.Register ("com/mob/tools/MobHandlerThread", DoNotGenerateAcw=true)]
	public partial class MobHandlerThread : global::Java.Lang.Thread {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/MobHandlerThread", typeof (MobHandlerThread));
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

		protected MobHandlerThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/constructor[@name='MobHandlerThread' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobHandlerThread ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/constructor[@name='MobHandlerThread' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MobHandlerThread (int priority)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (priority);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getLooper;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetLooperHandler ()
		{
			if (cb_getLooper == null)
				cb_getLooper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLooper);
			return cb_getLooper;
		}

		[Obsolete]
		static IntPtr n_GetLooper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.MobHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Looper);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Android.OS.Looper Looper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='getLooper' and count(parameter)=0]"
			[Register ("getLooper", "()Landroid/os/Looper;", "GetGetLooperHandler")]
			get {
				const string __id = "getLooper.()Landroid/os/Looper;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThreadId;
#pragma warning disable 0169
		static Delegate GetGetThreadIdHandler ()
		{
			if (cb_getThreadId == null)
				cb_getThreadId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThreadId);
			return cb_getThreadId;
		}

		static int n_GetThreadId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.MobHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThreadId;
		}
#pragma warning restore 0169

		public virtual unsafe int ThreadId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='getThreadId' and count(parameter)=0]"
			[Register ("getThreadId", "()I", "GetGetThreadIdHandler")]
			get {
				const string __id = "getThreadId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='newHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler.Callback']]"
		[Register ("newHandler", "(Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler NewHandler (global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "newHandler.(Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='newHandler' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("newHandler", "(Ljava/lang/Runnable;Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler NewHandler (global::Java.Lang.IRunnable beforeRun, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "newHandler.(Ljava/lang/Runnable;Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((beforeRun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) beforeRun).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='newHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("newHandler", "(Ljava/lang/String;Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler NewHandler (string name, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "newHandler.(Ljava/lang/String;Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='newHandler' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("newHandler", "(Ljava/lang/String;Ljava/lang/Runnable;Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler NewHandler (string name, global::Java.Lang.IRunnable beforeRun, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "newHandler.(Ljava/lang/String;Ljava/lang/Runnable;Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((beforeRun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) beforeRun).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_onLooperPrepared;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetOnLooperPreparedHandler ()
		{
			if (cb_onLooperPrepared == null)
				cb_onLooperPrepared = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLooperPrepared);
			return cb_onLooperPrepared;
		}

		[Obsolete]
		static void n_OnLooperPrepared (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.MobHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLooperPrepared ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='onLooperPrepared' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("onLooperPrepared", "()V", "GetOnLooperPreparedHandler")]
		protected virtual unsafe void OnLooperPrepared ()
		{
			const string __id = "onLooperPrepared.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onLooperPrepared_Landroid_os_Looper_;
#pragma warning disable 0169
		static Delegate GetOnLooperPrepared_Landroid_os_Looper_Handler ()
		{
			if (cb_onLooperPrepared_Landroid_os_Looper_ == null)
				cb_onLooperPrepared_Landroid_os_Looper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLooperPrepared_Landroid_os_Looper_);
			return cb_onLooperPrepared_Landroid_os_Looper_;
		}

		static void n_OnLooperPrepared_Landroid_os_Looper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_looper)
		{
			global::Com.Mob.Tools.MobHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Looper looper = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_looper, JniHandleOwnership.DoNotTransfer);
			__this.OnLooperPrepared (looper);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='onLooperPrepared' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
		[Register ("onLooperPrepared", "(Landroid/os/Looper;)V", "GetOnLooperPrepared_Landroid_os_Looper_Handler")]
		protected virtual unsafe void OnLooperPrepared (global::Android.OS.Looper looper)
		{
			const string __id = "onLooperPrepared.(Landroid/os/Looper;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_quit;
#pragma warning disable 0169
		static Delegate GetQuitHandler ()
		{
			if (cb_quit == null)
				cb_quit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Quit);
			return cb_quit;
		}

		static bool n_Quit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.MobHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='quit' and count(parameter)=0]"
		[Register ("quit", "()Z", "GetQuitHandler")]
		public virtual unsafe bool Quit ()
		{
			const string __id = "quit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_realRun;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetRealRunHandler ()
		{
			if (cb_realRun == null)
				cb_realRun = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RealRun);
			return cb_realRun;
		}

		[Obsolete]
		static void n_RealRun (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.MobHandlerThread __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.MobHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RealRun ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobHandlerThread']/method[@name='realRun' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("realRun", "()V", "GetRealRunHandler")]
		public virtual unsafe void RealRun ()
		{
			const string __id = "realRun.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
