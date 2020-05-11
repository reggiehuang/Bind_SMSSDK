using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.net']/class[@name='HttpResponseCallbackImp']"
	[global::Android.Runtime.Register ("cn/smssdk/net/HttpResponseCallbackImp", DoNotGenerateAcw=true)]
	public partial class HttpResponseCallbackImp : global::Java.Lang.Object, global::Com.Mob.Tools.Network.IHttpResponseCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/net/HttpResponseCallbackImp", typeof (HttpResponseCallbackImp));
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

		protected HttpResponseCallbackImp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.net']/class[@name='HttpResponseCallbackImp']/constructor[@name='HttpResponseCallbackImp' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
		public unsafe HttpResponseCallbackImp (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/HashMap;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_handleInput_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetHandleInput_Ljava_io_InputStream_Handler ()
		{
			if (cb_handleInput_Ljava_io_InputStream_ == null)
				cb_handleInput_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleInput_Ljava_io_InputStream_);
			return cb_handleInput_Ljava_io_InputStream_;
		}

		static void n_HandleInput_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Net.HttpResponseCallbackImp __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Net.HttpResponseCallbackImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleInput (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.net']/class[@name='HttpResponseCallbackImp']/method[@name='handleInput' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("handleInput", "(Ljava/io/InputStream;)V", "GetHandleInput_Ljava_io_InputStream_Handler")]
		public virtual unsafe void HandleInput (global::System.IO.Stream p0)
		{
			const string __id = "handleInput.(Ljava/io/InputStream;)V";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onResponse_Lcom_mob_tools_network_HttpConnection_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Lcom_mob_tools_network_HttpConnection_Handler ()
		{
			if (cb_onResponse_Lcom_mob_tools_network_HttpConnection_ == null)
				cb_onResponse_Lcom_mob_tools_network_HttpConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Lcom_mob_tools_network_HttpConnection_);
			return cb_onResponse_Lcom_mob_tools_network_HttpConnection_;
		}

		static void n_OnResponse_Lcom_mob_tools_network_HttpConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Net.HttpResponseCallbackImp __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Net.HttpResponseCallbackImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpConnection p0 = (global::Com.Mob.Tools.Network.IHttpConnection)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.net']/class[@name='HttpResponseCallbackImp']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='com.mob.tools.network.HttpConnection']]"
		[Register ("onResponse", "(Lcom/mob/tools/network/HttpConnection;)V", "GetOnResponse_Lcom_mob_tools_network_HttpConnection_Handler")]
		public virtual unsafe void OnResponse (global::Com.Mob.Tools.Network.IHttpConnection p0)
		{
			const string __id = "onResponse.(Lcom/mob/tools/network/HttpConnection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
