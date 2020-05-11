using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/Data", DoNotGenerateAcw=true)]
	public partial class Data : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/Data", typeof (Data));
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

		protected Data (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/constructor[@name='Data' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Data ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='AES128Decode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("AES128Decode", "([B[B)[B", "")]
		public static unsafe byte[] AES128Decode (byte[] keyBytes, byte[] cipherText)
		{
			const string __id = "AES128Decode.([B[B)[B";
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			IntPtr native_cipherText = JNIEnv.NewArray (cipherText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_keyBytes);
				__args [1] = new JniArgumentValue (native_cipherText);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
				if (cipherText != null) {
					JNIEnv.CopyArray (native_cipherText, cipherText);
					JNIEnv.DeleteLocalRef (native_cipherText);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='AES128Decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("AES128Decode", "(Ljava/lang/String;[B)Ljava/lang/String;", "")]
		public static unsafe string AES128Decode (string key, byte[] cipherText)
		{
			const string __id = "AES128Decode.(Ljava/lang/String;[B)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_cipherText = JNIEnv.NewArray (cipherText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_cipherText);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (cipherText != null) {
					JNIEnv.CopyArray (native_cipherText, cipherText);
					JNIEnv.DeleteLocalRef (native_cipherText);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='AES128Encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("AES128Encode", "([B[B)[B", "")]
		public static unsafe byte[] AES128Encode (byte[] key, byte[] data)
		{
			const string __id = "AES128Encode.([B[B)[B";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='AES128Encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("AES128Encode", "([BLjava/lang/String;)[B", "")]
		public static unsafe byte[] AES128Encode (byte[] key, string text)
		{
			const string __id = "AES128Encode.([BLjava/lang/String;)[B";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='AES128Encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("AES128Encode", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] AES128Encode (string key, string text)
		{
			const string __id = "AES128Encode.(Ljava/lang/String;Ljava/lang/String;)[B";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='Base64AES' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Base64AES", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Base64AES (string msg, string key)
		{
			const string __id = "Base64AES.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='CRC32' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("CRC32", "([B)Ljava/lang/String;", "")]
		public static unsafe string CRC32 (byte[] data)
		{
			const string __id = "CRC32.([B)Ljava/lang/String;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='MD5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("MD5", "([B)Ljava/lang/String;", "")]
		public static unsafe string MD5 (byte[] data)
		{
			const string __id = "MD5.([B)Ljava/lang/String;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='MD5' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("MD5", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string MD5 (global::Java.IO.File data)
		{
			const string __id = "MD5.(Ljava/io/File;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='MD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("MD5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string MD5 (string data)
		{
			const string __id = "MD5.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='SHA1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("SHA1", "([B)[B", "")]
		public static unsafe byte[] SHA1 (byte[] data)
		{
			const string __id = "SHA1.([B)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='SHA1' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("SHA1", "(Ljava/io/File;)[B", "")]
		public static unsafe byte[] SHA1 (global::Java.IO.File data)
		{
			const string __id = "SHA1.(Ljava/io/File;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='SHA1' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("SHA1", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] SHA1 (global::System.IO.Stream data)
		{
			const string __id = "SHA1.(Ljava/io/InputStream;)[B";
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='SHA1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SHA1", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] SHA1 (string text)
		{
			const string __id = "SHA1.(Ljava/lang/String;)[B";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='base62' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("base62", "(J)Ljava/lang/String;", "")]
		public static unsafe string Base62 (long value)
		{
			const string __id = "base62.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='byteToHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteToHex", "([B)Ljava/lang/String;", "")]
		public static unsafe string ByteToHex (byte[] data)
		{
			const string __id = "byteToHex.([B)Ljava/lang/String;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='byteToHex' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("byteToHex", "([BII)Ljava/lang/String;", "")]
		public static unsafe string ByteToHex (byte[] data, int offset, int len)
		{
			const string __id = "byteToHex.([BII)Ljava/lang/String;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (len);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='rawMD5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("rawMD5", "([B)[B", "")]
		public static unsafe byte[] RawMD5 (byte[] data)
		{
			const string __id = "rawMD5.([B)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='rawMD5' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("rawMD5", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] RawMD5 (global::System.IO.Stream data)
		{
			const string __id = "rawMD5.(Ljava/io/InputStream;)[B";
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='rawMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rawMD5", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] RawMD5 (string data)
		{
			const string __id = "rawMD5.(Ljava/lang/String;)[B";
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='rawRSADecode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("rawRSADecode", "([B[BI)[B", "")]
		public static unsafe byte[] RawRSADecode (byte[] data, byte[] privateKey, int keySize)
		{
			const string __id = "rawRSADecode.([B[BI)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_privateKey = JNIEnv.NewArray (privateKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (native_privateKey);
				__args [2] = new JniArgumentValue (keySize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				if (privateKey != null) {
					JNIEnv.CopyArray (native_privateKey, privateKey);
					JNIEnv.DeleteLocalRef (native_privateKey);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='rawRSAEncode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("rawRSAEncode", "([B[BI)[B", "")]
		public static unsafe byte[] RawRSAEncode (byte[] data, byte[] publicKey, int keySize)
		{
			const string __id = "rawRSAEncode.([B[BI)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (native_publicKey);
				__args [2] = new JniArgumentValue (keySize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				if (publicKey != null) {
					JNIEnv.CopyArray (native_publicKey, publicKey);
					JNIEnv.DeleteLocalRef (native_publicKey);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='urlEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string s)
		{
			const string __id = "urlEncode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Data']/method[@name='urlEncode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string s, string enc)
		{
			const string __id = "urlEncode.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			IntPtr native_enc = JNIEnv.NewString (enc);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_enc);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_enc);
			}
		}

	}
}
