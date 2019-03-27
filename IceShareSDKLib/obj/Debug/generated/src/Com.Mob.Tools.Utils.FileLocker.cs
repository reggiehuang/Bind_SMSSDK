using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/FileLocker", DoNotGenerateAcw=true)]
	public partial class FileLocker : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/utils/FileLocker", typeof (FileLocker));
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

		protected FileLocker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']/constructor[@name='FileLocker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileLocker ()
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

		static Delegate cb_lock_Z;
#pragma warning disable 0169
		static Delegate GetLock_ZHandler ()
		{
			if (cb_lock_Z == null)
				cb_lock_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_Lock_Z);
			return cb_lock_Z;
		}

		static bool n_Lock_Z (IntPtr jnienv, IntPtr native__this, bool block)
		{
			global::Com.Mob.Tools.Utils.FileLocker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.FileLocker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Lock (block);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']/method[@name='lock' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("lock", "(Z)Z", "GetLock_ZHandler")]
		public virtual unsafe bool Lock (bool block)
		{
			const string __id = "lock.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (block);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_lock_ZJJ;
#pragma warning disable 0169
		static Delegate GetLock_ZJJHandler ()
		{
			if (cb_lock_ZJJ == null)
				cb_lock_ZJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, long, long, bool>) n_Lock_ZJJ);
			return cb_lock_ZJJ;
		}

		static bool n_Lock_ZJJ (IntPtr jnienv, IntPtr native__this, bool block, long timeout, long sleepInterval)
		{
			global::Com.Mob.Tools.Utils.FileLocker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.FileLocker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Lock (block, timeout, sleepInterval);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']/method[@name='lock' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("lock", "(ZJJ)Z", "GetLock_ZJJHandler")]
		public virtual unsafe bool Lock (bool block, long timeout, long sleepInterval)
		{
			const string __id = "lock.(ZJJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (block);
				__args [1] = new JniArgumentValue (timeout);
				__args [2] = new JniArgumentValue (sleepInterval);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_lock_Ljava_lang_Runnable_Z;
#pragma warning disable 0169
		static Delegate GetLock_Ljava_lang_Runnable_ZHandler ()
		{
			if (cb_lock_Ljava_lang_Runnable_Z == null)
				cb_lock_Ljava_lang_Runnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Lock_Ljava_lang_Runnable_Z);
			return cb_lock_Ljava_lang_Runnable_Z;
		}

		static void n_Lock_Ljava_lang_Runnable_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_onLock, bool block)
		{
			global::Com.Mob.Tools.Utils.FileLocker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.FileLocker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable onLock = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_onLock, JniHandleOwnership.DoNotTransfer);
			__this.Lock (onLock, block);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']/method[@name='lock' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='boolean']]"
		[Register ("lock", "(Ljava/lang/Runnable;Z)V", "GetLock_Ljava_lang_Runnable_ZHandler")]
		public virtual unsafe void Lock (global::Java.Lang.IRunnable onLock, bool block)
		{
			const string __id = "lock.(Ljava/lang/Runnable;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((onLock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onLock).Handle);
				__args [1] = new JniArgumentValue (block);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.FileLocker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.FileLocker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setLockFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLockFile_Ljava_lang_String_Handler ()
		{
			if (cb_setLockFile_Ljava_lang_String_ == null)
				cb_setLockFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLockFile_Ljava_lang_String_);
			return cb_setLockFile_Ljava_lang_String_;
		}

		static void n_SetLockFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Mob.Tools.Utils.FileLocker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.FileLocker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.SetLockFile (path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']/method[@name='setLockFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLockFile", "(Ljava/lang/String;)V", "GetSetLockFile_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLockFile (string path)
		{
			const string __id = "setLockFile.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_unlock;
#pragma warning disable 0169
		static Delegate GetUnlockHandler ()
		{
			if (cb_unlock == null)
				cb_unlock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unlock);
			return cb_unlock;
		}

		static void n_Unlock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.FileLocker __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.FileLocker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileLocker']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		public virtual unsafe void Unlock ()
		{
			const string __id = "unlock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
