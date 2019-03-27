using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FileDownloadListener']"
	[global::Android.Runtime.Register ("com/mob/tools/network/FileDownloadListener", DoNotGenerateAcw=true)]
	public abstract partial class FileDownloadListener : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/FileDownloadListener", typeof (FileDownloadListener));
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

		protected FileDownloadListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FileDownloadListener']/constructor[@name='FileDownloadListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileDownloadListener ()
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

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.FileDownloadListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FileDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FileDownloadListener']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.FileDownloadListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FileDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FileDownloadListener']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onProgress_IJJ;
#pragma warning disable 0169
		static Delegate GetOnProgress_IJJHandler ()
		{
			if (cb_onProgress_IJJ == null)
				cb_onProgress_IJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long, long>) n_OnProgress_IJJ);
			return cb_onProgress_IJJ;
		}

		static void n_OnProgress_IJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2)
		{
			global::Com.Mob.Tools.Network.FileDownloadListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FileDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FileDownloadListener']/method[@name='onProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onProgress", "(IJJ)V", "GetOnProgress_IJJHandler")]
		protected abstract void OnProgress (int p0, long p1, long p2);

	}

	[global::Android.Runtime.Register ("com/mob/tools/network/FileDownloadListener", DoNotGenerateAcw=true)]
	internal partial class FileDownloadListenerInvoker : FileDownloadListener {

		public FileDownloadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/network/FileDownloadListener", typeof (FileDownloadListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FileDownloadListener']/method[@name='onProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onProgress", "(IJJ)V", "GetOnProgress_IJJHandler")]
		protected override unsafe void OnProgress (int p0, long p1, long p2)
		{
			const string __id = "onProgress.(IJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
