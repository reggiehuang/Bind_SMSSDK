using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Wechat.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']"
	[global::Android.Runtime.Register ("cn/sharesdk/wechat/utils/WXEmojiObject", DoNotGenerateAcw=true)]
	public partial class WXEmojiObject : global::Java.Lang.Object, global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/field[@name='emojiData']"
		[Register ("emojiData")]
		public IList<byte> EmojiData {
			get {
				const string __id = "emojiData.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "emojiData.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/field[@name='emojiPath']"
		[Register ("emojiPath")]
		public string EmojiPath {
			get {
				const string __id = "emojiPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "emojiPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: cn.sharesdk.wechat.utils.WXMediaMessage.IMediaObject

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_APPDATA']"
			[Register ("TYPE_APPDATA")]
			public const int TypeAppdata = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOJI']"
			[Register ("TYPE_EMOJI")]
			public const int TypeEmoji = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_FILE']"
			[Register ("TYPE_FILE")]
			public const int TypeFile = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_IMAGE']"
			[Register ("TYPE_IMAGE")]
			public const int TypeImage = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_MINIPROGRAM']"
			[Register ("TYPE_MINIPROGRAM")]
			public const int TypeMiniprogram = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_MUSIC']"
			[Register ("TYPE_MUSIC")]
			public const int TypeMusic = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_TEXT']"
			[Register ("TYPE_TEXT")]
			public const int TypeText = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_UNKNOWN']"
			[Register ("TYPE_UNKNOWN")]
			public const int TypeUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_URL']"
			[Register ("TYPE_URL")]
			public const int TypeUrl = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_VIDEO']"
			[Register ("TYPE_VIDEO")]
			public const int TypeVideo = (int) 4;
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/wechat/utils/WXEmojiObject", typeof (WXEmojiObject));
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

		protected WXEmojiObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/constructor[@name='WXEmojiObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WXEmojiObject ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/constructor[@name='WXEmojiObject' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe WXEmojiObject (byte[] paramArrayOfByte)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_paramArrayOfByte = JNIEnv.NewArray (paramArrayOfByte);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paramArrayOfByte);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (paramArrayOfByte != null) {
					JNIEnv.CopyArray (native_paramArrayOfByte, paramArrayOfByte);
					JNIEnv.DeleteLocalRef (native_paramArrayOfByte);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/constructor[@name='WXEmojiObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe WXEmojiObject (string paramString)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_paramString = JNIEnv.NewString (paramString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paramString);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_paramString);
			}
		}

		static Delegate cb_checkArgs;
#pragma warning disable 0169
		static Delegate GetCheckArgsHandler ()
		{
			if (cb_checkArgs == null)
				cb_checkArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckArgs);
			return cb_checkArgs;
		}

		static bool n_CheckArgs (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Wechat.Utils.WXEmojiObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXEmojiObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		public virtual unsafe bool CheckArgs ()
		{
			const string __id = "checkArgs.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_serialize_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSerialize_Landroid_os_Bundle_Handler ()
		{
			if (cb_serialize_Landroid_os_Bundle_ == null)
				cb_serialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Serialize_Landroid_os_Bundle_);
			return cb_serialize_Landroid_os_Bundle_;
		}

		static void n_Serialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramBundle)
		{
			global::CN.Sharesdk.Wechat.Utils.WXEmojiObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXEmojiObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle paramBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_paramBundle, JniHandleOwnership.DoNotTransfer);
			__this.Serialize (paramBundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("serialize", "(Landroid/os/Bundle;)V", "GetSerialize_Landroid_os_Bundle_Handler")]
		public virtual unsafe void Serialize (global::Android.OS.Bundle paramBundle)
		{
			const string __id = "serialize.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((paramBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramBundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEmojiData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetEmojiData_arrayBHandler ()
		{
			if (cb_setEmojiData_arrayB == null)
				cb_setEmojiData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmojiData_arrayB);
			return cb_setEmojiData_arrayB;
		}

		static void n_SetEmojiData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_paramArrayOfByte)
		{
			global::CN.Sharesdk.Wechat.Utils.WXEmojiObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXEmojiObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] paramArrayOfByte = (byte[]) JNIEnv.GetArray (native_paramArrayOfByte, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetEmojiData (paramArrayOfByte);
			if (paramArrayOfByte != null)
				JNIEnv.CopyArray (paramArrayOfByte, native_paramArrayOfByte);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/method[@name='setEmojiData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setEmojiData", "([B)V", "GetSetEmojiData_arrayBHandler")]
		public virtual unsafe void SetEmojiData (byte[] paramArrayOfByte)
		{
			const string __id = "setEmojiData.([B)V";
			IntPtr native_paramArrayOfByte = JNIEnv.NewArray (paramArrayOfByte);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paramArrayOfByte);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (paramArrayOfByte != null) {
					JNIEnv.CopyArray (native_paramArrayOfByte, paramArrayOfByte);
					JNIEnv.DeleteLocalRef (native_paramArrayOfByte);
				}
			}
		}

		static Delegate cb_setEmojiPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmojiPath_Ljava_lang_String_Handler ()
		{
			if (cb_setEmojiPath_Ljava_lang_String_ == null)
				cb_setEmojiPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmojiPath_Ljava_lang_String_);
			return cb_setEmojiPath_Ljava_lang_String_;
		}

		static void n_SetEmojiPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramString)
		{
			global::CN.Sharesdk.Wechat.Utils.WXEmojiObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXEmojiObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string paramString = JNIEnv.GetString (native_paramString, JniHandleOwnership.DoNotTransfer);
			__this.SetEmojiPath (paramString);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/method[@name='setEmojiPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmojiPath", "(Ljava/lang/String;)V", "GetSetEmojiPath_Ljava_lang_String_Handler")]
		public virtual unsafe void SetEmojiPath (string paramString)
		{
			const string __id = "setEmojiPath.(Ljava/lang/String;)V";
			IntPtr native_paramString = JNIEnv.NewString (paramString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paramString);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_paramString);
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Type);
			return cb_type;
		}

		static int n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Wechat.Utils.WXEmojiObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXEmojiObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()I", "GetTypeHandler")]
		public virtual unsafe int Type ()
		{
			const string __id = "type.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_unserialize_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUnserialize_Landroid_os_Bundle_Handler ()
		{
			if (cb_unserialize_Landroid_os_Bundle_ == null)
				cb_unserialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unserialize_Landroid_os_Bundle_);
			return cb_unserialize_Landroid_os_Bundle_;
		}

		static void n_Unserialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramBundle)
		{
			global::CN.Sharesdk.Wechat.Utils.WXEmojiObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXEmojiObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle paramBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_paramBundle, JniHandleOwnership.DoNotTransfer);
			__this.Unserialize (paramBundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXEmojiObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("unserialize", "(Landroid/os/Bundle;)V", "GetUnserialize_Landroid_os_Bundle_Handler")]
		public virtual unsafe void Unserialize (global::Android.OS.Bundle paramBundle)
		{
			const string __id = "unserialize.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((paramBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramBundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
