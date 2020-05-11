using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Twitter {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.twitter']/class[@name='MappedFileReader']"
	[global::Android.Runtime.Register ("cn/sharesdk/twitter/MappedFileReader", DoNotGenerateAcw=true)]
	public partial class MappedFileReader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/twitter/MappedFileReader", typeof (MappedFileReader));
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

		protected MappedFileReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.twitter']/class[@name='MappedFileReader']/constructor[@name='MappedFileReader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe MappedFileReader (string fileName, int arraySize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue (arraySize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_getFileLength;
#pragma warning disable 0169
		static Delegate GetGetFileLengthHandler ()
		{
			if (cb_getFileLength == null)
				cb_getFileLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFileLength);
			return cb_getFileLength;
		}

		static long n_GetFileLength (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Twitter.MappedFileReader __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Twitter.MappedFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileLength;
		}
#pragma warning restore 0169

		public virtual unsafe long FileLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.twitter']/class[@name='MappedFileReader']/method[@name='getFileLength' and count(parameter)=0]"
			[Register ("getFileLength", "()J", "GetGetFileLengthHandler")]
			get {
				const string __id = "getFileLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.twitter']/class[@name='MappedFileReader']/method[@name='byteToBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteToBase64", "([B)Ljava/lang/String;", "")]
		public static unsafe string ByteToBase64 (byte[] bytePart)
		{
			const string __id = "byteToBase64.([B)Ljava/lang/String;";
			IntPtr native_bytePart = JNIEnv.NewArray (bytePart);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytePart);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytePart != null) {
					JNIEnv.CopyArray (native_bytePart, bytePart);
					JNIEnv.DeleteLocalRef (native_bytePart);
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Twitter.MappedFileReader __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Twitter.MappedFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.twitter']/class[@name='MappedFileReader']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getArray;
#pragma warning disable 0169
		static Delegate GetGetArrayHandler ()
		{
			if (cb_getArray == null)
				cb_getArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetArray);
			return cb_getArray;
		}

		static IntPtr n_GetArray (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Twitter.MappedFileReader __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Twitter.MappedFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.twitter']/class[@name='MappedFileReader']/method[@name='getArray' and count(parameter)=0]"
		[Register ("getArray", "()[B", "GetGetArrayHandler")]
		public virtual unsafe byte[] GetArray ()
		{
			const string __id = "getArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Twitter.MappedFileReader __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Twitter.MappedFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.twitter']/class[@name='MappedFileReader']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public virtual unsafe int Read ()
		{
			const string __id = "read.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
