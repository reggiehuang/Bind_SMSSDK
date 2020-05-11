using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='HttpConnection']"
	[Register ("com/mob/tools/network/HttpConnection", "", "Com.Mob.Tools.Network.IHttpConnectionInvoker")]
	public partial interface IHttpConnection : IJavaObject, IJavaPeerable {

		global::System.IO.Stream ErrorStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='HttpConnection']/method[@name='getErrorStream' and count(parameter)=0]"
			[Register ("getErrorStream", "()Ljava/io/InputStream;", "GetGetErrorStreamHandler:Com.Mob.Tools.Network.IHttpConnectionInvoker, IceShareSDKLib")] get;
		}

		global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> HeaderFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='HttpConnection']/method[@name='getHeaderFields' and count(parameter)=0]"
			[Register ("getHeaderFields", "()Ljava/util/Map;", "GetGetHeaderFieldsHandler:Com.Mob.Tools.Network.IHttpConnectionInvoker, IceShareSDKLib")] get;
		}

		global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='HttpConnection']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler:Com.Mob.Tools.Network.IHttpConnectionInvoker, IceShareSDKLib")] get;
		}

		int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='HttpConnection']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler:Com.Mob.Tools.Network.IHttpConnectionInvoker, IceShareSDKLib")] get;
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/network/HttpConnection", DoNotGenerateAcw=true)]
	internal partial class IHttpConnectionInvoker : global::Java.Lang.Object, IHttpConnection {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/network/HttpConnection", typeof (IHttpConnectionInvoker));

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

		public static IHttpConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.network.HttpConnection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mob.Tools.Network.IHttpConnection __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ErrorStream);
		}
#pragma warning restore 0169

		IntPtr id_getErrorStream;
		public unsafe global::System.IO.Stream ErrorStream {
			get {
				if (id_getErrorStream == IntPtr.Zero)
					id_getErrorStream = JNIEnv.GetMethodID (class_ref, "getErrorStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorStream), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mob.Tools.Network.IHttpConnection __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.HeaderFields);
		}
#pragma warning restore 0169

		IntPtr id_getHeaderFields;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> HeaderFields {
			get {
				if (id_getHeaderFields == IntPtr.Zero)
					id_getHeaderFields = JNIEnv.GetMethodID (class_ref, "getHeaderFields", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderFields), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mob.Tools.Network.IHttpConnection __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		IntPtr id_getInputStream;
		public unsafe global::System.IO.Stream InputStream {
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mob.Tools.Network.IHttpConnection __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		IntPtr id_getResponseCode;
		public unsafe int ResponseCode {
			get {
				if (id_getResponseCode == IntPtr.Zero)
					id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getResponseCode);
			}
		}

	}

}
