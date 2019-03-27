using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='HttpResponseCallback']"
	[Register ("com/mob/tools/network/HttpResponseCallback", "", "Com.Mob.Tools.Network.IHttpResponseCallbackInvoker")]
	public partial interface IHttpResponseCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='HttpResponseCallback']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='com.mob.tools.network.HttpConnection']]"
		[Register ("onResponse", "(Lcom/mob/tools/network/HttpConnection;)V", "GetOnResponse_Lcom_mob_tools_network_HttpConnection_Handler:Com.Mob.Tools.Network.IHttpResponseCallbackInvoker, IceShareSDKLib")]
		void OnResponse (global::Com.Mob.Tools.Network.IHttpConnection p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/network/HttpResponseCallback", DoNotGenerateAcw=true)]
	internal class IHttpResponseCallbackInvoker : global::Java.Lang.Object, IHttpResponseCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/network/HttpResponseCallback", typeof (IHttpResponseCallbackInvoker));

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

		public static IHttpResponseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpResponseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.network.HttpResponseCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpResponseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mob.Tools.Network.IHttpResponseCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpConnection p0 = (global::Com.Mob.Tools.Network.IHttpConnection)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Lcom_mob_tools_network_HttpConnection_;
		public unsafe void OnResponse (global::Com.Mob.Tools.Network.IHttpConnection p0)
		{
			if (id_onResponse_Lcom_mob_tools_network_HttpConnection_ == IntPtr.Zero)
				id_onResponse_Lcom_mob_tools_network_HttpConnection_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lcom/mob/tools/network/HttpConnection;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Lcom_mob_tools_network_HttpConnection_, __args);
		}

	}

}
