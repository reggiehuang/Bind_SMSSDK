using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='RawNetworkCallback']"
	[Register ("com/mob/tools/network/RawNetworkCallback", "", "Com.Mob.Tools.Network.IRawNetworkCallbackInvoker")]
	public partial interface IRawNetworkCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='RawNetworkCallback']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("onResponse", "(Ljava/io/InputStream;)V", "GetOnResponse_Ljava_io_InputStream_Handler:Com.Mob.Tools.Network.IRawNetworkCallbackInvoker, IceShareSDKLib")]
		void OnResponse (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/network/RawNetworkCallback", DoNotGenerateAcw=true)]
	internal class IRawNetworkCallbackInvoker : global::Java.Lang.Object, IRawNetworkCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/network/RawNetworkCallback", typeof (IRawNetworkCallbackInvoker));

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

		public static IRawNetworkCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRawNetworkCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.network.RawNetworkCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRawNetworkCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResponse_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Ljava_io_InputStream_Handler ()
		{
			if (cb_onResponse_Ljava_io_InputStream_ == null)
				cb_onResponse_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Ljava_io_InputStream_);
			return cb_onResponse_Ljava_io_InputStream_;
		}

		static void n_OnResponse_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Tools.Network.IRawNetworkCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IRawNetworkCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Ljava_io_InputStream_;
		public unsafe void OnResponse (global::System.IO.Stream p0)
		{
			if (id_onResponse_Ljava_io_InputStream_ == IntPtr.Zero)
				id_onResponse_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Ljava_io_InputStream_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
