using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/InnerShareParams", DoNotGenerateAcw=true)]
	public abstract partial class InnerShareParams : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='CUSTOM_FLAG']"
		[Register ("CUSTOM_FLAG")]
		protected const string CustomFlag = (string) "customFlag";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='GROPU_ID']"
		[Register ("GROPU_ID")]
		protected const string GropuId = (string) "groupID";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='IMAGE_ARRAY']"
		[Register ("IMAGE_ARRAY")]
		protected const string ImageArray = (string) "imageArray";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='IS_FAMILY']"
		[Register ("IS_FAMILY")]
		protected const string IsFamily = (string) "isFamily";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='IS_FRIEND']"
		[Register ("IS_FRIEND")]
		protected const string IsFriend = (string) "isFriend";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='IS_LOG_EVEN']"
		[Register ("IS_LOG_EVEN")]
		protected const string IsLogEven = (string) "isLogEven";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='IS_PUBLIC']"
		[Register ("IS_PUBLIC")]
		protected const string IsPublic = (string) "isPublic";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='IS_SHARE_TENCENT_WEIBO']"
		[Register ("IS_SHARE_TENCENT_WEIBO")]
		protected const string IsShareTencentWeibo = (string) "isShareTencentWeibo";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='TAGS']"
		[Register ("TAGS")]
		protected const string Tags = (string) "tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='WX_MINIPROGRAM_MINIPROGRAM_TYPE']"
		[Register ("WX_MINIPROGRAM_MINIPROGRAM_TYPE")]
		protected const string WxMiniprogramMiniprogramType = (string) "wxMiniProgramType";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='WX_MINIPROGRAM_PATH']"
		[Register ("WX_MINIPROGRAM_PATH")]
		protected const string WxMiniprogramPath = (string) "wxPath";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='WX_MINIPROGRAM_USER_NAME']"
		[Register ("WX_MINIPROGRAM_USER_NAME")]
		protected const string WxMiniprogramUserName = (string) "wxUserName";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/field[@name='WX_MINIPROGRAM_WITH_SHARETICKET']"
		[Register ("WX_MINIPROGRAM_WITH_SHARETICKET")]
		protected const string WxMiniprogramWithShareticket = (string) "wxWithShareTicket";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/framework/InnerShareParams", typeof (InnerShareParams));
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

		protected InnerShareParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/constructor[@name='InnerShareParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InnerShareParams ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/constructor[@name='InnerShareParams' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe InnerShareParams (string jsonParams)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_jsonParams = JNIEnv.NewString (jsonParams);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonParams);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonParams);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/constructor[@name='InnerShareParams' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
		public unsafe InnerShareParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> @params)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/HashMap;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__params);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			__this.Address = address;
		}
#pragma warning restore 0169

		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAddress.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuthor;
#pragma warning disable 0169
		static Delegate GetGetAuthorHandler ()
		{
			if (cb_getAuthor == null)
				cb_getAuthor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthor);
			return cb_getAuthor;
		}

		static IntPtr n_GetAuthor (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Author);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthor_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthor_Ljava_lang_String_ == null)
				cb_setAuthor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthor_Ljava_lang_String_);
			return cb_setAuthor_Ljava_lang_String_;
		}

		static void n_SetAuthor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_author)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string author = JNIEnv.GetString (native_author, JniHandleOwnership.DoNotTransfer);
			__this.Author = author;
		}
#pragma warning restore 0169

		public virtual unsafe string Author {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getAuthor' and count(parameter)=0]"
			[Register ("getAuthor", "()Ljava/lang/String;", "GetGetAuthorHandler")]
			get {
				const string __id = "getAuthor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setAuthor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthor", "(Ljava/lang/String;)V", "GetSetAuthor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuthor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getComment;
#pragma warning disable 0169
		static Delegate GetGetCommentHandler ()
		{
			if (cb_getComment == null)
				cb_getComment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetComment);
			return cb_getComment;
		}

		static IntPtr n_GetComment (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Comment);
		}
#pragma warning restore 0169

		static Delegate cb_setComment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetComment_Ljava_lang_String_Handler ()
		{
			if (cb_setComment_Ljava_lang_String_ == null)
				cb_setComment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetComment_Ljava_lang_String_);
			return cb_setComment_Ljava_lang_String_;
		}

		static void n_SetComment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_comment)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string comment = JNIEnv.GetString (native_comment, JniHandleOwnership.DoNotTransfer);
			__this.Comment = comment;
		}
#pragma warning restore 0169

		public virtual unsafe string Comment {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getComment' and count(parameter)=0]"
			[Register ("getComment", "()Ljava/lang/String;", "GetGetCommentHandler")]
			get {
				const string __id = "getComment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setComment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setComment", "(Ljava/lang/String;)V", "GetSetComment_Ljava_lang_String_Handler")]
			set {
				const string __id = "setComment.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetContentType);
			return cb_getContentType;
		}

		static int n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentType;
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_I;
#pragma warning disable 0169
		static Delegate GetSetContentType_IHandler ()
		{
			if (cb_setContentType_I == null)
				cb_setContentType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetContentType_I);
			return cb_setContentType_I;
		}

		static void n_SetContentType_I (IntPtr jnienv, IntPtr native__this, int contentType)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = contentType;
		}
#pragma warning restore 0169

		public virtual unsafe int ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()I", "GetGetContentTypeHandler")]
			get {
				const string __id = "getContentType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setContentType", "(I)V", "GetSetContentType_IHandler")]
			set {
				const string __id = "setContentType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExecuteUrl;
#pragma warning disable 0169
		static Delegate GetGetExecuteUrlHandler ()
		{
			if (cb_getExecuteUrl == null)
				cb_getExecuteUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExecuteUrl);
			return cb_getExecuteUrl;
		}

		static IntPtr n_GetExecuteUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExecuteUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string ExecuteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getExecuteUrl' and count(parameter)=0]"
			[Register ("getExecuteUrl", "()Ljava/lang/String;", "GetGetExecuteUrlHandler")]
			get {
				const string __id = "getExecuteUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtInfo;
#pragma warning disable 0169
		static Delegate GetGetExtInfoHandler ()
		{
			if (cb_getExtInfo == null)
				cb_getExtInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtInfo);
			return cb_getExtInfo;
		}

		static IntPtr n_GetExtInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExtInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setExtInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtInfo_Ljava_lang_String_Handler ()
		{
			if (cb_setExtInfo_Ljava_lang_String_ == null)
				cb_setExtInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtInfo_Ljava_lang_String_);
			return cb_setExtInfo_Ljava_lang_String_;
		}

		static void n_SetExtInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extInfo)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string extInfo = JNIEnv.GetString (native_extInfo, JniHandleOwnership.DoNotTransfer);
			__this.ExtInfo = extInfo;
		}
#pragma warning restore 0169

		public virtual unsafe string ExtInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getExtInfo' and count(parameter)=0]"
			[Register ("getExtInfo", "()Ljava/lang/String;", "GetGetExtInfoHandler")]
			get {
				const string __id = "getExtInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setExtInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExtInfo", "(Ljava/lang/String;)V", "GetSetExtInfo_Ljava_lang_String_Handler")]
			set {
				const string __id = "setExtInfo.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isFamily;
#pragma warning disable 0169
		static Delegate GetIsFamilyHandler ()
		{
			if (cb_isFamily == null)
				cb_isFamily = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFamily);
			return cb_isFamily;
		}

		static bool n_IsFamily (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Family;
		}
#pragma warning restore 0169

		static Delegate cb_setFamily_Z;
#pragma warning disable 0169
		static Delegate GetSetFamily_ZHandler ()
		{
			if (cb_setFamily_Z == null)
				cb_setFamily_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFamily_Z);
			return cb_setFamily_Z;
		}

		static void n_SetFamily_Z (IntPtr jnienv, IntPtr native__this, bool isFamily)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Family = isFamily;
		}
#pragma warning restore 0169

		public virtual unsafe bool Family {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='isFamily' and count(parameter)=0]"
			[Register ("isFamily", "()Z", "GetIsFamilyHandler")]
			get {
				const string __id = "isFamily.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setFamily' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFamily", "(Z)V", "GetSetFamily_ZHandler")]
			set {
				const string __id = "setFamily.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFilePath;
#pragma warning disable 0169
		static Delegate GetGetFilePathHandler ()
		{
			if (cb_getFilePath == null)
				cb_getFilePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilePath);
			return cb_getFilePath;
		}

		static IntPtr n_GetFilePath (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FilePath);
		}
#pragma warning restore 0169

		static Delegate cb_setFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setFilePath_Ljava_lang_String_ == null)
				cb_setFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilePath_Ljava_lang_String_);
			return cb_setFilePath_Ljava_lang_String_;
		}

		static void n_SetFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filePath)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string filePath = JNIEnv.GetString (native_filePath, JniHandleOwnership.DoNotTransfer);
			__this.FilePath = filePath;
		}
#pragma warning restore 0169

		public virtual unsafe string FilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getFilePath' and count(parameter)=0]"
			[Register ("getFilePath", "()Ljava/lang/String;", "GetGetFilePathHandler")]
			get {
				const string __id = "getFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFilePath", "(Ljava/lang/String;)V", "GetSetFilePath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFilePath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isFriend;
#pragma warning disable 0169
		static Delegate GetIsFriendHandler ()
		{
			if (cb_isFriend == null)
				cb_isFriend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFriend);
			return cb_isFriend;
		}

		static bool n_IsFriend (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Friend;
		}
#pragma warning restore 0169

		static Delegate cb_setFriend_Z;
#pragma warning disable 0169
		static Delegate GetSetFriend_ZHandler ()
		{
			if (cb_setFriend_Z == null)
				cb_setFriend_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFriend_Z);
			return cb_setFriend_Z;
		}

		static void n_SetFriend_Z (IntPtr jnienv, IntPtr native__this, bool isFriend)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Friend = isFriend;
		}
#pragma warning restore 0169

		public virtual unsafe bool Friend {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='isFriend' and count(parameter)=0]"
			[Register ("isFriend", "()Z", "GetIsFriendHandler")]
			get {
				const string __id = "isFriend.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setFriend' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFriend", "(Z)V", "GetSetFriend_ZHandler")]
			set {
				const string __id = "setFriend.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGroupId;
#pragma warning disable 0169
		static Delegate GetGetGroupIdHandler ()
		{
			if (cb_getGroupId == null)
				cb_getGroupId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupId);
			return cb_getGroupId;
		}

		static IntPtr n_GetGroupId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupId);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_setGroupId_Ljava_lang_String_ == null)
				cb_setGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupId_Ljava_lang_String_);
			return cb_setGroupId_Ljava_lang_String_;
		}

		static void n_SetGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groupId)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string groupId = JNIEnv.GetString (native_groupId, JniHandleOwnership.DoNotTransfer);
			__this.GroupId = groupId;
		}
#pragma warning restore 0169

		public virtual unsafe string GroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getGroupId' and count(parameter)=0]"
			[Register ("getGroupId", "()Ljava/lang/String;", "GetGetGroupIdHandler")]
			get {
				const string __id = "getGroupId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupId", "(Ljava/lang/String;)V", "GetSetGroupId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setGroupId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHidden;
#pragma warning disable 0169
		static Delegate GetGetHiddenHandler ()
		{
			if (cb_getHidden == null)
				cb_getHidden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHidden);
			return cb_getHidden;
		}

		static int n_GetHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hidden;
		}
#pragma warning restore 0169

		static Delegate cb_setHidden_I;
#pragma warning disable 0169
		static Delegate GetSetHidden_IHandler ()
		{
			if (cb_setHidden_I == null)
				cb_setHidden_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHidden_I);
			return cb_setHidden_I;
		}

		static void n_SetHidden_I (IntPtr jnienv, IntPtr native__this, int hidden)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hidden = hidden;
		}
#pragma warning restore 0169

		public virtual unsafe int Hidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getHidden' and count(parameter)=0]"
			[Register ("getHidden", "()I", "GetGetHiddenHandler")]
			get {
				const string __id = "getHidden.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setHidden' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHidden", "(I)V", "GetSetHidden_IHandler")]
			set {
				const string __id = "setHidden.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageData;
#pragma warning disable 0169
		static Delegate GetGetImageDataHandler ()
		{
			if (cb_getImageData == null)
				cb_getImageData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageData);
			return cb_getImageData;
		}

		static IntPtr n_GetImageData (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageData);
		}
#pragma warning restore 0169

		static Delegate cb_setImageData_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImageData_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImageData_Landroid_graphics_Bitmap_ == null)
				cb_setImageData_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageData_Landroid_graphics_Bitmap_);
			return cb_setImageData_Landroid_graphics_Bitmap_;
		}

		static void n_SetImageData_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageData)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap imageData = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_imageData, JniHandleOwnership.DoNotTransfer);
			__this.ImageData = imageData;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap ImageData {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getImageData' and count(parameter)=0]"
			[Register ("getImageData", "()Landroid/graphics/Bitmap;", "GetGetImageDataHandler")]
			get {
				const string __id = "getImageData.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setImageData' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setImageData", "(Landroid/graphics/Bitmap;)V", "GetSetImageData_Landroid_graphics_Bitmap_Handler")]
			set {
				const string __id = "setImageData.(Landroid/graphics/Bitmap;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImagePath;
#pragma warning disable 0169
		static Delegate GetGetImagePathHandler ()
		{
			if (cb_getImagePath == null)
				cb_getImagePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImagePath);
			return cb_getImagePath;
		}

		static IntPtr n_GetImagePath (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImagePath);
		}
#pragma warning restore 0169

		static Delegate cb_setImagePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImagePath_Ljava_lang_String_Handler ()
		{
			if (cb_setImagePath_Ljava_lang_String_ == null)
				cb_setImagePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImagePath_Ljava_lang_String_);
			return cb_setImagePath_Ljava_lang_String_;
		}

		static void n_SetImagePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePath)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string imagePath = JNIEnv.GetString (native_imagePath, JniHandleOwnership.DoNotTransfer);
			__this.ImagePath = imagePath;
		}
#pragma warning restore 0169

		public virtual unsafe string ImagePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getImagePath' and count(parameter)=0]"
			[Register ("getImagePath", "()Ljava/lang/String;", "GetGetImagePathHandler")]
			get {
				const string __id = "getImagePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setImagePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImagePath", "(Ljava/lang/String;)V", "GetSetImagePath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setImagePath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getImageUrl;
#pragma warning disable 0169
		static Delegate GetGetImageUrlHandler ()
		{
			if (cb_getImageUrl == null)
				cb_getImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUrl);
			return cb_getImageUrl;
		}

		static IntPtr n_GetImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setImageUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setImageUrl_Ljava_lang_String_ == null)
				cb_setImageUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageUrl_Ljava_lang_String_);
			return cb_setImageUrl_Ljava_lang_String_;
		}

		static void n_SetImageUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageUrl)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string imageUrl = JNIEnv.GetString (native_imageUrl, JniHandleOwnership.DoNotTransfer);
			__this.ImageUrl = imageUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getImageUrl' and count(parameter)=0]"
			[Register ("getImageUrl", "()Ljava/lang/String;", "GetGetImageUrlHandler")]
			get {
				const string __id = "getImageUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageUrl", "(Ljava/lang/String;)V", "GetSetImageUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setImageUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInstallUrl;
#pragma warning disable 0169
		static Delegate GetGetInstallUrlHandler ()
		{
			if (cb_getInstallUrl == null)
				cb_getInstallUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstallUrl);
			return cb_getInstallUrl;
		}

		static IntPtr n_GetInstallUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InstallUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string InstallUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getInstallUrl' and count(parameter)=0]"
			[Register ("getInstallUrl", "()Ljava/lang/String;", "GetGetInstallUrlHandler")]
			get {
				const string __id = "getInstallUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLatitude);
			return cb_getLatitude;
		}

		static float n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitude_F;
#pragma warning disable 0169
		static Delegate GetSetLatitude_FHandler ()
		{
			if (cb_setLatitude_F == null)
				cb_setLatitude_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLatitude_F);
			return cb_setLatitude_F;
		}

		static void n_SetLatitude_F (IntPtr jnienv, IntPtr native__this, float latitude)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = latitude;
		}
#pragma warning restore 0169

		public virtual unsafe float Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()F", "GetGetLatitudeHandler")]
			get {
				const string __id = "getLatitude.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLatitude", "(F)V", "GetSetLatitude_FHandler")]
			set {
				const string __id = "setLatitude.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLongitude);
			return cb_getLongitude;
		}

		static float n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitude_F;
#pragma warning disable 0169
		static Delegate GetSetLongitude_FHandler ()
		{
			if (cb_setLongitude_F == null)
				cb_setLongitude_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLongitude_F);
			return cb_setLongitude_F;
		}

		static void n_SetLongitude_F (IntPtr jnienv, IntPtr native__this, float longitude)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longitude = longitude;
		}
#pragma warning restore 0169

		public virtual unsafe float Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()F", "GetGetLongitudeHandler")]
			get {
				const string __id = "getLongitude.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLongitude", "(F)V", "GetSetLongitude_FHandler")]
			set {
				const string __id = "setLongitude.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMusicUrl;
#pragma warning disable 0169
		static Delegate GetGetMusicUrlHandler ()
		{
			if (cb_getMusicUrl == null)
				cb_getMusicUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMusicUrl);
			return cb_getMusicUrl;
		}

		static IntPtr n_GetMusicUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MusicUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setMusicUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMusicUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setMusicUrl_Ljava_lang_String_ == null)
				cb_setMusicUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMusicUrl_Ljava_lang_String_);
			return cb_setMusicUrl_Ljava_lang_String_;
		}

		static void n_SetMusicUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_musicUrl)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string musicUrl = JNIEnv.GetString (native_musicUrl, JniHandleOwnership.DoNotTransfer);
			__this.MusicUrl = musicUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string MusicUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getMusicUrl' and count(parameter)=0]"
			[Register ("getMusicUrl", "()Ljava/lang/String;", "GetGetMusicUrlHandler")]
			get {
				const string __id = "getMusicUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setMusicUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMusicUrl", "(Ljava/lang/String;)V", "GetSetMusicUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMusicUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNotebook;
#pragma warning disable 0169
		static Delegate GetGetNotebookHandler ()
		{
			if (cb_getNotebook == null)
				cb_getNotebook = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotebook);
			return cb_getNotebook;
		}

		static IntPtr n_GetNotebook (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Notebook);
		}
#pragma warning restore 0169

		static Delegate cb_setNotebook_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotebook_Ljava_lang_String_Handler ()
		{
			if (cb_setNotebook_Ljava_lang_String_ == null)
				cb_setNotebook_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotebook_Ljava_lang_String_);
			return cb_setNotebook_Ljava_lang_String_;
		}

		static void n_SetNotebook_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notebook)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string notebook = JNIEnv.GetString (native_notebook, JniHandleOwnership.DoNotTransfer);
			__this.Notebook = notebook;
		}
#pragma warning restore 0169

		public virtual unsafe string Notebook {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getNotebook' and count(parameter)=0]"
			[Register ("getNotebook", "()Ljava/lang/String;", "GetGetNotebookHandler")]
			get {
				const string __id = "getNotebook.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setNotebook' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotebook", "(Ljava/lang/String;)V", "GetSetNotebook_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNotebook.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOpenCustomEven;
#pragma warning disable 0169
		static Delegate GetGetOpenCustomEvenHandler ()
		{
			if (cb_getOpenCustomEven == null)
				cb_getOpenCustomEven = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetOpenCustomEven);
			return cb_getOpenCustomEven;
		}

		static bool n_GetOpenCustomEven (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenCustomEven;
		}
#pragma warning restore 0169

		static Delegate cb_setOpenCustomEven_Z;
#pragma warning disable 0169
		static Delegate GetSetOpenCustomEven_ZHandler ()
		{
			if (cb_setOpenCustomEven_Z == null)
				cb_setOpenCustomEven_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOpenCustomEven_Z);
			return cb_setOpenCustomEven_Z;
		}

		static void n_SetOpenCustomEven_Z (IntPtr jnienv, IntPtr native__this, bool isLogEven)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenCustomEven = isLogEven;
		}
#pragma warning restore 0169

		public virtual unsafe bool OpenCustomEven {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getOpenCustomEven' and count(parameter)=0]"
			[Register ("getOpenCustomEven", "()Z", "GetGetOpenCustomEvenHandler")]
			get {
				const string __id = "getOpenCustomEven.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setOpenCustomEven' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOpenCustomEven", "(Z)V", "GetSetOpenCustomEven_ZHandler")]
			set {
				const string __id = "setOpenCustomEven.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isPublic;
#pragma warning disable 0169
		static Delegate GetIsPublicHandler ()
		{
			if (cb_isPublic == null)
				cb_isPublic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPublic);
			return cb_isPublic;
		}

		static bool n_IsPublic (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Public;
		}
#pragma warning restore 0169

		static Delegate cb_setPublic_Z;
#pragma warning disable 0169
		static Delegate GetSetPublic_ZHandler ()
		{
			if (cb_setPublic_Z == null)
				cb_setPublic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPublic_Z);
			return cb_setPublic_Z;
		}

		static void n_SetPublic_Z (IntPtr jnienv, IntPtr native__this, bool isPublic)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Public = isPublic;
		}
#pragma warning restore 0169

		public virtual unsafe bool Public {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='isPublic' and count(parameter)=0]"
			[Register ("isPublic", "()Z", "GetIsPublicHandler")]
			get {
				const string __id = "isPublic.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setPublic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPublic", "(Z)V", "GetSetPublic_ZHandler")]
			set {
				const string __id = "setPublic.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSafetyLevel;
#pragma warning disable 0169
		static Delegate GetGetSafetyLevelHandler ()
		{
			if (cb_getSafetyLevel == null)
				cb_getSafetyLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSafetyLevel);
			return cb_getSafetyLevel;
		}

		static int n_GetSafetyLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SafetyLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setSafetyLevel_I;
#pragma warning disable 0169
		static Delegate GetSetSafetyLevel_IHandler ()
		{
			if (cb_setSafetyLevel_I == null)
				cb_setSafetyLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSafetyLevel_I);
			return cb_setSafetyLevel_I;
		}

		static void n_SetSafetyLevel_I (IntPtr jnienv, IntPtr native__this, int safetyLevel)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SafetyLevel = safetyLevel;
		}
#pragma warning restore 0169

		public virtual unsafe int SafetyLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getSafetyLevel' and count(parameter)=0]"
			[Register ("getSafetyLevel", "()I", "GetGetSafetyLevelHandler")]
			get {
				const string __id = "getSafetyLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setSafetyLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSafetyLevel", "(I)V", "GetSetSafetyLevel_IHandler")]
			set {
				const string __id = "setSafetyLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScence;
#pragma warning disable 0169
		static Delegate GetGetScenceHandler ()
		{
			if (cb_getScence == null)
				cb_getScence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScence);
			return cb_getScence;
		}

		static int n_GetScence (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scence;
		}
#pragma warning restore 0169

		static Delegate cb_setScence_I;
#pragma warning disable 0169
		static Delegate GetSetScence_IHandler ()
		{
			if (cb_setScence_I == null)
				cb_setScence_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScence_I);
			return cb_setScence_I;
		}

		static void n_SetScence_I (IntPtr jnienv, IntPtr native__this, int scence)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scence = scence;
		}
#pragma warning restore 0169

		public virtual unsafe int Scence {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getScence' and count(parameter)=0]"
			[Register ("getScence", "()I", "GetGetScenceHandler")]
			get {
				const string __id = "getScence.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setScence' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScence", "(I)V", "GetSetScence_IHandler")]
			set {
				const string __id = "setScence.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShareTencentWeibo;
#pragma warning disable 0169
		static Delegate GetIsShareTencentWeiboHandler ()
		{
			if (cb_isShareTencentWeibo == null)
				cb_isShareTencentWeibo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShareTencentWeibo);
			return cb_isShareTencentWeibo;
		}

		static bool n_IsShareTencentWeibo (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShareTencentWeibo;
		}
#pragma warning restore 0169

		static Delegate cb_setShareTencentWeibo_Z;
#pragma warning disable 0169
		static Delegate GetSetShareTencentWeibo_ZHandler ()
		{
			if (cb_setShareTencentWeibo_Z == null)
				cb_setShareTencentWeibo_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShareTencentWeibo_Z);
			return cb_setShareTencentWeibo_Z;
		}

		static void n_SetShareTencentWeibo_Z (IntPtr jnienv, IntPtr native__this, bool isShareTencentWeibo)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareTencentWeibo = isShareTencentWeibo;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShareTencentWeibo {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='isShareTencentWeibo' and count(parameter)=0]"
			[Register ("isShareTencentWeibo", "()Z", "GetIsShareTencentWeiboHandler")]
			get {
				const string __id = "isShareTencentWeibo.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setShareTencentWeibo' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShareTencentWeibo", "(Z)V", "GetSetShareTencentWeibo_ZHandler")]
			set {
				const string __id = "setShareTencentWeibo.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShareType;
#pragma warning disable 0169
		static Delegate GetGetShareTypeHandler ()
		{
			if (cb_getShareType == null)
				cb_getShareType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShareType);
			return cb_getShareType;
		}

		static int n_GetShareType (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShareType;
		}
#pragma warning restore 0169

		static Delegate cb_setShareType_I;
#pragma warning disable 0169
		static Delegate GetSetShareType_IHandler ()
		{
			if (cb_setShareType_I == null)
				cb_setShareType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShareType_I);
			return cb_setShareType_I;
		}

		static void n_SetShareType_I (IntPtr jnienv, IntPtr native__this, int shareType)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareType = shareType;
		}
#pragma warning restore 0169

		public virtual unsafe int ShareType {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getShareType' and count(parameter)=0]"
			[Register ("getShareType", "()I", "GetGetShareTypeHandler")]
			get {
				const string __id = "getShareType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setShareType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShareType", "(I)V", "GetSetShareType_IHandler")]
			set {
				const string __id = "setShareType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSite;
#pragma warning disable 0169
		static Delegate GetGetSiteHandler ()
		{
			if (cb_getSite == null)
				cb_getSite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSite);
			return cb_getSite;
		}

		static IntPtr n_GetSite (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Site);
		}
#pragma warning restore 0169

		static Delegate cb_setSite_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSite_Ljava_lang_String_Handler ()
		{
			if (cb_setSite_Ljava_lang_String_ == null)
				cb_setSite_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSite_Ljava_lang_String_);
			return cb_setSite_Ljava_lang_String_;
		}

		static void n_SetSite_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string site = JNIEnv.GetString (native_site, JniHandleOwnership.DoNotTransfer);
			__this.Site = site;
		}
#pragma warning restore 0169

		public virtual unsafe string Site {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getSite' and count(parameter)=0]"
			[Register ("getSite", "()Ljava/lang/String;", "GetGetSiteHandler")]
			get {
				const string __id = "getSite.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setSite' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSite", "(Ljava/lang/String;)V", "GetSetSite_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSite.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSiteUrl;
#pragma warning disable 0169
		static Delegate GetGetSiteUrlHandler ()
		{
			if (cb_getSiteUrl == null)
				cb_getSiteUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteUrl);
			return cb_getSiteUrl;
		}

		static IntPtr n_GetSiteUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSiteUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setSiteUrl_Ljava_lang_String_ == null)
				cb_setSiteUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteUrl_Ljava_lang_String_);
			return cb_setSiteUrl_Ljava_lang_String_;
		}

		static void n_SetSiteUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_siteUrl)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string siteUrl = JNIEnv.GetString (native_siteUrl, JniHandleOwnership.DoNotTransfer);
			__this.SiteUrl = siteUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string SiteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getSiteUrl' and count(parameter)=0]"
			[Register ("getSiteUrl", "()Ljava/lang/String;", "GetGetSiteUrlHandler")]
			get {
				const string __id = "getSiteUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setSiteUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteUrl", "(Ljava/lang/String;)V", "GetSetSiteUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSiteUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStack;
#pragma warning disable 0169
		static Delegate GetGetStackHandler ()
		{
			if (cb_getStack == null)
				cb_getStack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStack);
			return cb_getStack;
		}

		static IntPtr n_GetStack (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Stack);
		}
#pragma warning restore 0169

		static Delegate cb_setStack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStack_Ljava_lang_String_Handler ()
		{
			if (cb_setStack_Ljava_lang_String_ == null)
				cb_setStack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStack_Ljava_lang_String_);
			return cb_setStack_Ljava_lang_String_;
		}

		static void n_SetStack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stack)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string stack = JNIEnv.GetString (native_stack, JniHandleOwnership.DoNotTransfer);
			__this.Stack = stack;
		}
#pragma warning restore 0169

		public virtual unsafe string Stack {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getStack' and count(parameter)=0]"
			[Register ("getStack", "()Ljava/lang/String;", "GetGetStackHandler")]
			get {
				const string __id = "getStack.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setStack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStack", "(Ljava/lang/String;)V", "GetSetStack_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStack.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSubreddit;
#pragma warning disable 0169
		static Delegate GetGetSubredditHandler ()
		{
			if (cb_getSubreddit == null)
				cb_getSubreddit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubreddit);
			return cb_getSubreddit;
		}

		static IntPtr n_GetSubreddit (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Subreddit);
		}
#pragma warning restore 0169

		static Delegate cb_setSubreddit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubreddit_Ljava_lang_String_Handler ()
		{
			if (cb_setSubreddit_Ljava_lang_String_ == null)
				cb_setSubreddit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubreddit_Ljava_lang_String_);
			return cb_setSubreddit_Ljava_lang_String_;
		}

		static void n_SetSubreddit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sr)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sr = JNIEnv.GetString (native_sr, JniHandleOwnership.DoNotTransfer);
			__this.Subreddit = sr;
		}
#pragma warning restore 0169

		public virtual unsafe string Subreddit {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getSubreddit' and count(parameter)=0]"
			[Register ("getSubreddit", "()Ljava/lang/String;", "GetGetSubredditHandler")]
			get {
				const string __id = "getSubreddit.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setSubreddit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubreddit", "(Ljava/lang/String;)V", "GetSetSubreddit_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSubreddit.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.Text = text;
		}
#pragma warning restore 0169

		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				const string __id = "setText.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.Title = title;
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTitle.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTitleUrl;
#pragma warning disable 0169
		static Delegate GetGetTitleUrlHandler ()
		{
			if (cb_getTitleUrl == null)
				cb_getTitleUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleUrl);
			return cb_getTitleUrl;
		}

		static IntPtr n_GetTitleUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TitleUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setTitleUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleUrl_Ljava_lang_String_ == null)
				cb_setTitleUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitleUrl_Ljava_lang_String_);
			return cb_setTitleUrl_Ljava_lang_String_;
		}

		static void n_SetTitleUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_titleUrl)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string titleUrl = JNIEnv.GetString (native_titleUrl, JniHandleOwnership.DoNotTransfer);
			__this.TitleUrl = titleUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string TitleUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getTitleUrl' and count(parameter)=0]"
			[Register ("getTitleUrl", "()Ljava/lang/String;", "GetGetTitleUrlHandler")]
			get {
				const string __id = "getTitleUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setTitleUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitleUrl", "(Ljava/lang/String;)V", "GetSetTitleUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTitleUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Url = url;
		}
#pragma warning restore 0169

		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVenueDescription;
#pragma warning disable 0169
		static Delegate GetGetVenueDescriptionHandler ()
		{
			if (cb_getVenueDescription == null)
				cb_getVenueDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVenueDescription);
			return cb_getVenueDescription;
		}

		static IntPtr n_GetVenueDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VenueDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setVenueDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVenueDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setVenueDescription_Ljava_lang_String_ == null)
				cb_setVenueDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVenueDescription_Ljava_lang_String_);
			return cb_setVenueDescription_Ljava_lang_String_;
		}

		static void n_SetVenueDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_venueDescription)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string venueDescription = JNIEnv.GetString (native_venueDescription, JniHandleOwnership.DoNotTransfer);
			__this.VenueDescription = venueDescription;
		}
#pragma warning restore 0169

		public virtual unsafe string VenueDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getVenueDescription' and count(parameter)=0]"
			[Register ("getVenueDescription", "()Ljava/lang/String;", "GetGetVenueDescriptionHandler")]
			get {
				const string __id = "getVenueDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setVenueDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVenueDescription", "(Ljava/lang/String;)V", "GetSetVenueDescription_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVenueDescription.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVenueName;
#pragma warning disable 0169
		static Delegate GetGetVenueNameHandler ()
		{
			if (cb_getVenueName == null)
				cb_getVenueName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVenueName);
			return cb_getVenueName;
		}

		static IntPtr n_GetVenueName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VenueName);
		}
#pragma warning restore 0169

		static Delegate cb_setVenueName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVenueName_Ljava_lang_String_Handler ()
		{
			if (cb_setVenueName_Ljava_lang_String_ == null)
				cb_setVenueName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVenueName_Ljava_lang_String_);
			return cb_setVenueName_Ljava_lang_String_;
		}

		static void n_SetVenueName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_venueName)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string venueName = JNIEnv.GetString (native_venueName, JniHandleOwnership.DoNotTransfer);
			__this.VenueName = venueName;
		}
#pragma warning restore 0169

		public virtual unsafe string VenueName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getVenueName' and count(parameter)=0]"
			[Register ("getVenueName", "()Ljava/lang/String;", "GetGetVenueNameHandler")]
			get {
				const string __id = "getVenueName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setVenueName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVenueName", "(Ljava/lang/String;)V", "GetSetVenueName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVenueName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWxMiniProgramType;
#pragma warning disable 0169
		static Delegate GetGetWxMiniProgramTypeHandler ()
		{
			if (cb_getWxMiniProgramType == null)
				cb_getWxMiniProgramType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWxMiniProgramType);
			return cb_getWxMiniProgramType;
		}

		static int n_GetWxMiniProgramType (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WxMiniProgramType;
		}
#pragma warning restore 0169

		static Delegate cb_setWxMiniProgramType_I;
#pragma warning disable 0169
		static Delegate GetSetWxMiniProgramType_IHandler ()
		{
			if (cb_setWxMiniProgramType_I == null)
				cb_setWxMiniProgramType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWxMiniProgramType_I);
			return cb_setWxMiniProgramType_I;
		}

		static void n_SetWxMiniProgramType_I (IntPtr jnienv, IntPtr native__this, int miniProgramType)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WxMiniProgramType = miniProgramType;
		}
#pragma warning restore 0169

		public virtual unsafe int WxMiniProgramType {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getWxMiniProgramType' and count(parameter)=0]"
			[Register ("getWxMiniProgramType", "()I", "GetGetWxMiniProgramTypeHandler")]
			get {
				const string __id = "getWxMiniProgramType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setWxMiniProgramType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWxMiniProgramType", "(I)V", "GetSetWxMiniProgramType_IHandler")]
			set {
				const string __id = "setWxMiniProgramType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWxPath;
#pragma warning disable 0169
		static Delegate GetGetWxPathHandler ()
		{
			if (cb_getWxPath == null)
				cb_getWxPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWxPath);
			return cb_getWxPath;
		}

		static IntPtr n_GetWxPath (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WxPath);
		}
#pragma warning restore 0169

		static Delegate cb_setWxPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWxPath_Ljava_lang_String_Handler ()
		{
			if (cb_setWxPath_Ljava_lang_String_ == null)
				cb_setWxPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWxPath_Ljava_lang_String_);
			return cb_setWxPath_Ljava_lang_String_;
		}

		static void n_SetWxPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_wxPath)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string wxPath = JNIEnv.GetString (native_wxPath, JniHandleOwnership.DoNotTransfer);
			__this.WxPath = wxPath;
		}
#pragma warning restore 0169

		public virtual unsafe string WxPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getWxPath' and count(parameter)=0]"
			[Register ("getWxPath", "()Ljava/lang/String;", "GetGetWxPathHandler")]
			get {
				const string __id = "getWxPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setWxPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setWxPath", "(Ljava/lang/String;)V", "GetSetWxPath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setWxPath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWxUserName;
#pragma warning disable 0169
		static Delegate GetGetWxUserNameHandler ()
		{
			if (cb_getWxUserName == null)
				cb_getWxUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWxUserName);
			return cb_getWxUserName;
		}

		static IntPtr n_GetWxUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WxUserName);
		}
#pragma warning restore 0169

		static Delegate cb_setWxUserName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWxUserName_Ljava_lang_String_Handler ()
		{
			if (cb_setWxUserName_Ljava_lang_String_ == null)
				cb_setWxUserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWxUserName_Ljava_lang_String_);
			return cb_setWxUserName_Ljava_lang_String_;
		}

		static void n_SetWxUserName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_wxUserName)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string wxUserName = JNIEnv.GetString (native_wxUserName, JniHandleOwnership.DoNotTransfer);
			__this.WxUserName = wxUserName;
		}
#pragma warning restore 0169

		public virtual unsafe string WxUserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getWxUserName' and count(parameter)=0]"
			[Register ("getWxUserName", "()Ljava/lang/String;", "GetGetWxUserNameHandler")]
			get {
				const string __id = "getWxUserName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setWxUserName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setWxUserName", "(Ljava/lang/String;)V", "GetSetWxUserName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setWxUserName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWxWithShareTicket;
#pragma warning disable 0169
		static Delegate GetGetWxWithShareTicketHandler ()
		{
			if (cb_getWxWithShareTicket == null)
				cb_getWxWithShareTicket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWxWithShareTicket);
			return cb_getWxWithShareTicket;
		}

		static bool n_GetWxWithShareTicket (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WxWithShareTicket;
		}
#pragma warning restore 0169

		static Delegate cb_setWxWithShareTicket_Z;
#pragma warning disable 0169
		static Delegate GetSetWxWithShareTicket_ZHandler ()
		{
			if (cb_setWxWithShareTicket_Z == null)
				cb_setWxWithShareTicket_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWxWithShareTicket_Z);
			return cb_setWxWithShareTicket_Z;
		}

		static void n_SetWxWithShareTicket_Z (IntPtr jnienv, IntPtr native__this, bool withShareTicket)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WxWithShareTicket = withShareTicket;
		}
#pragma warning restore 0169

		public virtual unsafe bool WxWithShareTicket {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getWxWithShareTicket' and count(parameter)=0]"
			[Register ("getWxWithShareTicket", "()Z", "GetGetWxWithShareTicketHandler")]
			get {
				const string __id = "getWxWithShareTicket.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setWxWithShareTicket' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWxWithShareTicket", "(Z)V", "GetSetWxWithShareTicket_ZHandler")]
			set {
				const string __id = "setWxWithShareTicket.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_lang_Class_);
			return cb_get_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_type)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class type = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key, type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Get (string key, global::Java.Lang.Class type)
		{
			const string __id = "get.(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getCustomFlag;
#pragma warning disable 0169
		static Delegate GetGetCustomFlagHandler ()
		{
			if (cb_getCustomFlag == null)
				cb_getCustomFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomFlag);
			return cb_getCustomFlag;
		}

		static IntPtr n_GetCustomFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCustomFlag ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getCustomFlag' and count(parameter)=0]"
		[Register ("getCustomFlag", "()[Ljava/lang/String;", "GetGetCustomFlagHandler")]
		public virtual unsafe string[] GetCustomFlag ()
		{
			const string __id = "getCustomFlag.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getImageArray;
#pragma warning disable 0169
		static Delegate GetGetImageArrayHandler ()
		{
			if (cb_getImageArray == null)
				cb_getImageArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageArray);
			return cb_getImageArray;
		}

		static IntPtr n_GetImageArray (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetImageArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getImageArray' and count(parameter)=0]"
		[Register ("getImageArray", "()[Ljava/lang/String;", "GetGetImageArrayHandler")]
		public virtual unsafe string[] GetImageArray ()
		{
			const string __id = "getImageArray.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTags ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='getTags' and count(parameter)=0]"
		[Register ("getTags", "()[Ljava/lang/String;", "GetGetTagsHandler")]
		public virtual unsafe string[] GetTags ()
		{
			const string __id = "getTags.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_Object_);
			return cb_set_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Set (string key, global::Java.Lang.Object value)
		{
			const string __id = "set.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_setCustomFlag_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomFlag_arrayLjava_lang_String_Handler ()
		{
			if (cb_setCustomFlag_arrayLjava_lang_String_ == null)
				cb_setCustomFlag_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomFlag_arrayLjava_lang_String_);
			return cb_setCustomFlag_arrayLjava_lang_String_;
		}

		static void n_SetCustomFlag_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customFlag)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] customFlag = (string[]) JNIEnv.GetArray (native_customFlag, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetCustomFlag (customFlag);
			if (customFlag != null)
				JNIEnv.CopyArray (customFlag, native_customFlag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setCustomFlag' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setCustomFlag", "([Ljava/lang/String;)V", "GetSetCustomFlag_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetCustomFlag (string[] customFlag)
		{
			const string __id = "setCustomFlag.([Ljava/lang/String;)V";
			IntPtr native_customFlag = JNIEnv.NewArray (customFlag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_customFlag);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (customFlag != null) {
					JNIEnv.CopyArray (native_customFlag, customFlag);
					JNIEnv.DeleteLocalRef (native_customFlag);
				}
			}
		}

		static Delegate cb_setExecuteUrl;
#pragma warning disable 0169
		static Delegate GetSetExecuteUrlHandler ()
		{
			if (cb_setExecuteUrl == null)
				cb_setExecuteUrl = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetExecuteUrl);
			return cb_setExecuteUrl;
		}

		static void n_SetExecuteUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExecuteUrl ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setExecuteUrl' and count(parameter)=0]"
		[Register ("setExecuteUrl", "()V", "GetSetExecuteUrlHandler")]
		public virtual unsafe void SetExecuteUrl ()
		{
			const string __id = "setExecuteUrl.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setImageArray_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageArray_arrayLjava_lang_String_Handler ()
		{
			if (cb_setImageArray_arrayLjava_lang_String_ == null)
				cb_setImageArray_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageArray_arrayLjava_lang_String_);
			return cb_setImageArray_arrayLjava_lang_String_;
		}

		static void n_SetImageArray_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePathArray)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] imagePathArray = (string[]) JNIEnv.GetArray (native_imagePathArray, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetImageArray (imagePathArray);
			if (imagePathArray != null)
				JNIEnv.CopyArray (imagePathArray, native_imagePathArray);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setImageArray' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setImageArray", "([Ljava/lang/String;)V", "GetSetImageArray_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetImageArray (string[] imagePathArray)
		{
			const string __id = "setImageArray.([Ljava/lang/String;)V";
			IntPtr native_imagePathArray = JNIEnv.NewArray (imagePathArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imagePathArray);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (imagePathArray != null) {
					JNIEnv.CopyArray (native_imagePathArray, imagePathArray);
					JNIEnv.DeleteLocalRef (native_imagePathArray);
				}
			}
		}

		static Delegate cb_setInstallUrl;
#pragma warning disable 0169
		static Delegate GetSetInstallUrlHandler ()
		{
			if (cb_setInstallUrl == null)
				cb_setInstallUrl = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetInstallUrl);
			return cb_setInstallUrl;
		}

		static void n_SetInstallUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInstallUrl ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setInstallUrl' and count(parameter)=0]"
		[Register ("setInstallUrl", "()V", "GetSetInstallUrlHandler")]
		public virtual unsafe void SetInstallUrl ()
		{
			const string __id = "setInstallUrl.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setTags_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTags_arrayLjava_lang_String_Handler ()
		{
			if (cb_setTags_arrayLjava_lang_String_ == null)
				cb_setTags_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTags_arrayLjava_lang_String_);
			return cb_setTags_arrayLjava_lang_String_;
		}

		static void n_SetTags_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tags)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] tags = (string[]) JNIEnv.GetArray (native_tags, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetTags (tags);
			if (tags != null)
				JNIEnv.CopyArray (tags, native_tags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='setTags' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setTags", "([Ljava/lang/String;)V", "GetSetTags_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetTags (string[] tags)
		{
			const string __id = "setTags.([Ljava/lang/String;)V";
			IntPtr native_tags = JNIEnv.NewArray (tags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (tags != null) {
					JNIEnv.CopyArray (native_tags, tags);
					JNIEnv.DeleteLocalRef (native_tags);
				}
			}
		}

		static Delegate cb_toMap;
#pragma warning disable 0169
		static Delegate GetToMapHandler ()
		{
			if (cb_toMap == null)
				cb_toMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToMap);
			return cb_toMap;
		}

		static IntPtr n_ToMap (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.InnerShareParams __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.InnerShareParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ToMap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='InnerShareParams']/method[@name='toMap' and count(parameter)=0]"
		[Register ("toMap", "()Ljava/util/HashMap;", "GetToMapHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToMap ()
		{
			const string __id = "toMap.()Ljava/util/HashMap;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/sharesdk/framework/InnerShareParams", DoNotGenerateAcw=true)]
	internal partial class InnerShareParamsInvoker : InnerShareParams {

		public InnerShareParamsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/sharesdk/framework/InnerShareParams", typeof (InnerShareParamsInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
