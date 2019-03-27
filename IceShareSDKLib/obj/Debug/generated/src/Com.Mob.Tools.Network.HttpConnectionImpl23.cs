using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HttpConnectionImpl23']"
	[global::Android.Runtime.Register ("com/mob/tools/network/HttpConnectionImpl23", DoNotGenerateAcw=true)]
	public partial class HttpConnectionImpl23 : global::Java.Lang.Object, global::Com.Mob.Tools.Network.IHttpConnection {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/HttpConnectionImpl23", typeof (HttpConnectionImpl23));
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

		protected HttpConnectionImpl23 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HttpConnectionImpl23']/constructor[@name='HttpConnectionImpl23' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
		[Register (".ctor", "(Ljava/net/HttpURLConnection;)V", "")]
		public unsafe HttpConnectionImpl23 (global::Java.Net.HttpURLConnection conn)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/HttpURLConnection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getErrorStream;
#pragma warning disable 0169
		static Delegate GetGetErrorStreamHandler ()
		{
			if (cb_getErrorStream == null)
				cb_getErrorStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorStream);
			return cb_getErrorStream;
		}

		static IntPtr n_GetErrorStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.HttpConnectionImpl23 __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HttpConnectionImpl23> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ErrorStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream ErrorStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HttpConnectionImpl23']/method[@name='getErrorStream' and count(parameter)=0]"
			[Register ("getErrorStream", "()Ljava/io/InputStream;", "GetGetErrorStreamHandler")]
			get {
				const string __id = "getErrorStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderFields;
#pragma warning disable 0169
		static Delegate GetGetHeaderFieldsHandler ()
		{
			if (cb_getHeaderFields == null)
				cb_getHeaderFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderFields);
			return cb_getHeaderFields;
		}

		static IntPtr n_GetHeaderFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.HttpConnectionImpl23 __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HttpConnectionImpl23> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.HeaderFields);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> HeaderFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HttpConnectionImpl23']/method[@name='getHeaderFields' and count(parameter)=0]"
			[Register ("getHeaderFields", "()Ljava/util/Map;", "GetGetHeaderFieldsHandler")]
			get {
				const string __id = "getHeaderFields.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.HttpConnectionImpl23 __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HttpConnectionImpl23> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HttpConnectionImpl23']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseCode;
#pragma warning disable 0169
		static Delegate GetGetResponseCodeHandler ()
		{
			if (cb_getResponseCode == null)
				cb_getResponseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResponseCode);
			return cb_getResponseCode;
		}

		static int n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.HttpConnectionImpl23 __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HttpConnectionImpl23> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		public virtual unsafe int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HttpConnectionImpl23']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get {
				const string __id = "getResponseCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
