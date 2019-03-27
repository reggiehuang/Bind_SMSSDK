using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='SSLSocketFactoryEx']"
	[global::Android.Runtime.Register ("com/mob/tools/network/SSLSocketFactoryEx", DoNotGenerateAcw=true)]
	public partial class SSLSocketFactoryEx : global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/SSLSocketFactoryEx", typeof (SSLSocketFactoryEx));
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

		protected SSLSocketFactoryEx (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='SSLSocketFactoryEx']/constructor[@name='SSLSocketFactoryEx' and count(parameter)=1 and parameter[1][@type='java.security.KeyStore']]"
		[Register (".ctor", "(Ljava/security/KeyStore;)V", "")]
		public unsafe SSLSocketFactoryEx (global::Java.Security.KeyStore truststore)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/security/KeyStore;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((truststore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) truststore).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_allowAllHostnameVerifier;
#pragma warning disable 0169
		static Delegate GetAllowAllHostnameVerifierHandler ()
		{
			if (cb_allowAllHostnameVerifier == null)
				cb_allowAllHostnameVerifier = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AllowAllHostnameVerifier);
			return cb_allowAllHostnameVerifier;
		}

		static void n_AllowAllHostnameVerifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.SSLSocketFactoryEx __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.SSLSocketFactoryEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowAllHostnameVerifier ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='SSLSocketFactoryEx']/method[@name='allowAllHostnameVerifier' and count(parameter)=0]"
		[Register ("allowAllHostnameVerifier", "()V", "GetAllowAllHostnameVerifierHandler")]
		public virtual unsafe void AllowAllHostnameVerifier ()
		{
			const string __id = "allowAllHostnameVerifier.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
