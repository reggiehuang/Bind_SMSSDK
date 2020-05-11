using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Wechat.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']"
	[global::Android.Runtime.Register ("cn/sharesdk/wechat/utils/WXMediaMessage", DoNotGenerateAcw=true)]
	public sealed partial class WXMediaMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/field[@name='ACTION_WXAPPMESSAGE']"
		[Register ("ACTION_WXAPPMESSAGE")]
		public const string ActionWxappmessage = (string) "com.tencent.mm.sdk.openapi.Intent.ACTION_WXAPPMESSAGE";


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				const string __id = "description.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "description.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/field[@name='MediaObjectInfo']"
		[Register ("MediaObjectInfo")]
		public global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject MediaObjectInfo {
			get {
				const string __id = "MediaObjectInfo.Lcn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "MediaObjectInfo.Lcn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/field[@name='sdkVer']"
		[Register ("sdkVer")]
		public int SdkVer {
			get {
				const string __id = "sdkVer.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sdkVer.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/field[@name='thumbData']"
		[Register ("thumbData")]
		public IList<byte> ThumbData {
			get {
				const string __id = "thumbData.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "thumbData.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				const string __id = "title.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "title.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		[Register ("cn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject", DoNotGenerateAcw=true)]
		public abstract class MediaObject : Java.Lang.Object {

			internal MediaObject ()
			{
			}

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

		[Register ("cn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'MediaObject' type. This type will be removed in a future release.", error: true)]
		public abstract class MediaObjectConsts : MediaObject {

			private MediaObjectConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']"
		[Register ("cn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject", "", "CN.Sharesdk.Wechat.Utils.WXMediaMessage/IMediaObjectInvoker")]
		public partial interface IMediaObject : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='checkArgs' and count(parameter)=0]"
			[Register ("checkArgs", "()Z", "GetCheckArgsHandler:CN.Sharesdk.Wechat.Utils.WXMediaMessage/IMediaObjectInvoker, IceShareSDKLib")]
			bool CheckArgs ();

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("serialize", "(Landroid/os/Bundle;)V", "GetSerialize_Landroid_os_Bundle_Handler:CN.Sharesdk.Wechat.Utils.WXMediaMessage/IMediaObjectInvoker, IceShareSDKLib")]
			void Serialize (global::Android.OS.Bundle p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='type' and count(parameter)=0]"
			[Register ("type", "()I", "GetTypeHandler:CN.Sharesdk.Wechat.Utils.WXMediaMessage/IMediaObjectInvoker, IceShareSDKLib")]
			int Type ();

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("unserialize", "(Landroid/os/Bundle;)V", "GetUnserialize_Landroid_os_Bundle_Handler:CN.Sharesdk.Wechat.Utils.WXMediaMessage/IMediaObjectInvoker, IceShareSDKLib")]
			void Unserialize (global::Android.OS.Bundle p0);

		}

		[global::Android.Runtime.Register ("cn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject", DoNotGenerateAcw=true)]
		internal partial class IMediaObjectInvoker : global::Java.Lang.Object, IMediaObject {

			static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject", typeof (IMediaObjectInvoker));

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

			public static IMediaObject GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMediaObject> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "cn.sharesdk.wechat.utils.WXMediaMessage.IMediaObject"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMediaObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			IntPtr id_checkArgs;
			public unsafe bool CheckArgs ()
			{
				if (id_checkArgs == IntPtr.Zero)
					id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkArgs);
			}

			static Delegate cb_serialize_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSerialize_Landroid_os_Bundle_Handler ()
			{
				if (cb_serialize_Landroid_os_Bundle_ == null)
					cb_serialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Serialize_Landroid_os_Bundle_);
				return cb_serialize_Landroid_os_Bundle_;
			}

			static void n_Serialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Serialize (p0);
			}
#pragma warning restore 0169

			IntPtr id_serialize_Landroid_os_Bundle_;
			public unsafe void Serialize (global::Android.OS.Bundle p0)
			{
				if (id_serialize_Landroid_os_Bundle_ == IntPtr.Zero)
					id_serialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serialize_Landroid_os_Bundle_, __args);
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
				global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type ();
			}
#pragma warning restore 0169

			IntPtr id_type;
			public unsafe int Type ()
			{
				if (id_type == IntPtr.Zero)
					id_type = JNIEnv.GetMethodID (class_ref, "type", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_type);
			}

			static Delegate cb_unserialize_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetUnserialize_Landroid_os_Bundle_Handler ()
			{
				if (cb_unserialize_Landroid_os_Bundle_ == null)
					cb_unserialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unserialize_Landroid_os_Bundle_);
				return cb_unserialize_Landroid_os_Bundle_;
			}

			static void n_Unserialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Unserialize (p0);
			}
#pragma warning restore 0169

			IntPtr id_unserialize_Landroid_os_Bundle_;
			public unsafe void Unserialize (global::Android.OS.Bundle p0)
			{
				if (id_unserialize_Landroid_os_Bundle_ == IntPtr.Zero)
					id_unserialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "unserialize", "(Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unserialize_Landroid_os_Bundle_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/wechat/utils/WXMediaMessage", typeof (WXMediaMessage));
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

		internal WXMediaMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/constructor[@name='WXMediaMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WXMediaMessage ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/constructor[@name='WXMediaMessage' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.wechat.utils.WXMediaMessage.IMediaObject']]"
		[Register (".ctor", "(Lcn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject;)V", "")]
		public unsafe WXMediaMessage (global::CN.Sharesdk.Wechat.Utils.WXMediaMessage.IMediaObject paramIMediaObject)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcn/sharesdk/wechat/utils/WXMediaMessage$IMediaObject;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((paramIMediaObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramIMediaObject).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WXMediaMessage']/method[@name='setThumbImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setThumbImage", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe void SetThumbImage (global::Android.Graphics.Bitmap paramBitmap)
		{
			const string __id = "setThumbImage.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((paramBitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramBitmap).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
