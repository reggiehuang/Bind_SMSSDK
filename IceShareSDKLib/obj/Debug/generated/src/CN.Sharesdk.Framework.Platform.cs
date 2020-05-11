using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/Platform", DoNotGenerateAcw=true)]
	public abstract partial class Platform : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_AUTHORIZING']"
		[Register ("ACTION_AUTHORIZING")]
		public const int ActionAuthorizing = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_CUSTOMER']"
		[Register ("ACTION_CUSTOMER")]
		protected const int ActionCustomer = (int) 655360;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_FOLLOWING_USER']"
		[Register ("ACTION_FOLLOWING_USER")]
		public const int ActionFollowingUser = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_GETTING_BILATERAL_LIST']"
		[Register ("ACTION_GETTING_BILATERAL_LIST")]
		protected const int ActionGettingBilateralList = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_GETTING_FOLLOWER_LIST']"
		[Register ("ACTION_GETTING_FOLLOWER_LIST")]
		protected const int ActionGettingFollowerList = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_GETTING_FRIEND_LIST']"
		[Register ("ACTION_GETTING_FRIEND_LIST")]
		public const int ActionGettingFriendList = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_SENDING_DIRECT_MESSAGE']"
		[Register ("ACTION_SENDING_DIRECT_MESSAGE")]
		public const int ActionSendingDirectMessage = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_SHARE']"
		[Register ("ACTION_SHARE")]
		public const int ActionShare = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_TIMELINE']"
		[Register ("ACTION_TIMELINE")]
		public const int ActionTimeline = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='ACTION_USER_INFOR']"
		[Register ("ACTION_USER_INFOR")]
		public const int ActionUserInfor = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='CUSTOMER_ACTION_MASK']"
		[Register ("CUSTOMER_ACTION_MASK")]
		public const int CustomerActionMask = (int) 65535;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='OPEN_WXMINIPROGRAM']"
		[Register ("OPEN_WXMINIPROGRAM")]
		public const int OpenWxminiprogram = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_APPS']"
		[Register ("SHARE_APPS")]
		public const int ShareApps = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_EMOJI']"
		[Register ("SHARE_EMOJI")]
		public const int ShareEmoji = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_FILE']"
		[Register ("SHARE_FILE")]
		public const int ShareFile = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_IMAGE']"
		[Register ("SHARE_IMAGE")]
		public const int ShareImage = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_MUSIC']"
		[Register ("SHARE_MUSIC")]
		public const int ShareMusic = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_TEXT']"
		[Register ("SHARE_TEXT")]
		public const int ShareText = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_VIDEO']"
		[Register ("SHARE_VIDEO")]
		public const int ShareVideo = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_WEBPAGE']"
		[Register ("SHARE_WEBPAGE")]
		public const int ShareWebpage = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_WXMINIPROGRAM']"
		[Register ("SHARE_WXMINIPROGRAM")]
		public const int ShareWxminiprogram = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='SHARE_ZHIFUBAO']"
		[Register ("SHARE_ZHIFUBAO")]
		public const int ShareZhifubao = (int) 10;


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/field[@name='listener']"
		[Register ("listener")]
		protected global::CN.Sharesdk.Framework.IPlatformActionListener Listener {
			get {
				const string __id = "listener.Lcn/sharesdk/framework/PlatformActionListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "listener.Lcn/sharesdk/framework/PlatformActionListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform.ShareParams']"
		[global::Android.Runtime.Register ("cn/sharesdk/framework/Platform$ShareParams", DoNotGenerateAcw=true)]
		public partial class ShareParams : global::CN.Sharesdk.Framework.InnerShareParams {

			static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/Platform$ShareParams", typeof (ShareParams));
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

			protected ShareParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform.ShareParams']/constructor[@name='Platform.ShareParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ShareParams ()
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform.ShareParams']/constructor[@name='Platform.ShareParams' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe ShareParams (string jsonParams)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform.ShareParams']/constructor[@name='Platform.ShareParams' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
			public unsafe ShareParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> @params)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/Platform", typeof (Platform));
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

		protected Platform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/constructor[@name='Platform' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Platform ()
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

		static Delegate cb_getDb;
#pragma warning disable 0169
		static Delegate GetGetDbHandler ()
		{
			if (cb_getDb == null)
				cb_getDb = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDb);
			return cb_getDb;
		}

		static IntPtr n_GetDb (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Db);
		}
#pragma warning restore 0169

		public virtual unsafe global::CN.Sharesdk.Framework.PlatformDb Db {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getDb' and count(parameter)=0]"
			[Register ("getDb", "()Lcn/sharesdk/framework/PlatformDb;", "GetGetDbHandler")]
			get {
				const string __id = "getDb.()Lcn/sharesdk/framework/PlatformDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasShareCallback;
#pragma warning disable 0169
		static Delegate GetHasShareCallbackHandler ()
		{
			if (cb_hasShareCallback == null)
				cb_hasShareCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasShareCallback);
			return cb_hasShareCallback;
		}

		static bool n_HasShareCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasShareCallback;
		}
#pragma warning restore 0169

		public abstract bool HasShareCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='hasShareCallback' and count(parameter)=0]"
			[Register ("hasShareCallback", "()Z", "GetHasShareCallbackHandler")] get;
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				const string __id = "getId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAuthValid;
#pragma warning disable 0169
		static Delegate GetIsAuthValidHandler ()
		{
			if (cb_isAuthValid == null)
				cb_isAuthValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthValid);
			return cb_isAuthValid;
		}

		static bool n_IsAuthValid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthValid;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAuthValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='isAuthValid' and count(parameter)=0]"
			[Register ("isAuthValid", "()Z", "GetIsAuthValidHandler")]
			get {
				const string __id = "isAuthValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isClientValid;
#pragma warning disable 0169
		static Delegate GetIsClientValidHandler ()
		{
			if (cb_isClientValid == null)
				cb_isClientValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClientValid);
			return cb_isClientValid;
		}

		static bool n_IsClientValid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClientValid;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClientValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='isClientValid' and count(parameter)=0]"
			[Register ("isClientValid", "()Z", "GetIsClientValidHandler")]
			get {
				const string __id = "isClientValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSSODisable;
#pragma warning disable 0169
		static Delegate GetIsSSODisableHandler ()
		{
			if (cb_isSSODisable == null)
				cb_isSSODisable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSSODisable);
			return cb_isSSODisable;
		}

		static bool n_IsSSODisable (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSSODisable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSSODisable {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='isSSODisable' and count(parameter)=0]"
			[Register ("isSSODisable", "()Z", "GetIsSSODisableHandler")]
			get {
				const string __id = "isSSODisable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get;
		}

		static Delegate cb_getPlatformActionListener;
#pragma warning disable 0169
		static Delegate GetGetPlatformActionListenerHandler ()
		{
			if (cb_getPlatformActionListener == null)
				cb_getPlatformActionListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatformActionListener);
			return cb_getPlatformActionListener;
		}

		static IntPtr n_GetPlatformActionListener (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlatformActionListener);
		}
#pragma warning restore 0169

		static Delegate cb_setPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_;
#pragma warning disable 0169
		static Delegate GetSetPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_Handler ()
		{
			if (cb_setPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_ == null)
				cb_setPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_);
			return cb_setPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_;
		}

		static void n_SetPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.IPlatformActionListener l = (global::CN.Sharesdk.Framework.IPlatformActionListener)global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.PlatformActionListener = l;
		}
#pragma warning restore 0169

		public virtual unsafe global::CN.Sharesdk.Framework.IPlatformActionListener PlatformActionListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getPlatformActionListener' and count(parameter)=0]"
			[Register ("getPlatformActionListener", "()Lcn/sharesdk/framework/PlatformActionListener;", "GetGetPlatformActionListenerHandler")]
			get {
				const string __id = "getPlatformActionListener.()Lcn/sharesdk/framework/PlatformActionListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='setPlatformActionListener' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.PlatformActionListener']]"
			[Register ("setPlatformActionListener", "(Lcn/sharesdk/framework/PlatformActionListener;)V", "GetSetPlatformActionListener_Lcn_sharesdk_framework_PlatformActionListener_Handler")]
			set {
				const string __id = "setPlatformActionListener.(Lcn/sharesdk/framework/PlatformActionListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformId;
#pragma warning disable 0169
		static Delegate GetGetPlatformIdHandler ()
		{
			if (cb_getPlatformId == null)
				cb_getPlatformId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPlatformId);
			return cb_getPlatformId;
		}

		static int n_GetPlatformId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlatformId;
		}
#pragma warning restore 0169

		protected abstract int PlatformId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getPlatformId' and count(parameter)=0]"
			[Register ("getPlatformId", "()I", "GetGetPlatformIdHandler")] get;
		}

		static Delegate cb_getSortId;
#pragma warning disable 0169
		static Delegate GetGetSortIdHandler ()
		{
			if (cb_getSortId == null)
				cb_getSortId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSortId);
			return cb_getSortId;
		}

		static int n_GetSortId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SortId;
		}
#pragma warning restore 0169

		public virtual unsafe int SortId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getSortId' and count(parameter)=0]"
			[Register ("getSortId", "()I", "GetGetSortIdHandler")]
			get {
				const string __id = "getSortId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		public abstract int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")] get;
		}

		static Delegate cb_SSOSetting_Z;
#pragma warning disable 0169
		static Delegate GetSSOSetting_ZHandler ()
		{
			if (cb_SSOSetting_Z == null)
				cb_SSOSetting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SSOSetting_Z);
			return cb_SSOSetting_Z;
		}

		static void n_SSOSetting_Z (IntPtr jnienv, IntPtr native__this, bool disable)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SSOSetting (disable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='SSOSetting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SSOSetting", "(Z)V", "GetSSOSetting_ZHandler")]
		public virtual unsafe void SSOSetting (bool disable)
		{
			const string __id = "SSOSetting.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_afterRegister_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAfterRegister_ILjava_lang_Object_Handler ()
		{
			if (cb_afterRegister_ILjava_lang_Object_ == null)
				cb_afterRegister_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AfterRegister_ILjava_lang_Object_);
			return cb_afterRegister_ILjava_lang_Object_;
		}

		static void n_AfterRegister_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int action, IntPtr native_extra)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object extra = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_extra, JniHandleOwnership.DoNotTransfer);
			__this.AfterRegister (action, extra);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='afterRegister' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("afterRegister", "(ILjava/lang/Object;)V", "GetAfterRegister_ILjava_lang_Object_Handler")]
		protected virtual unsafe void AfterRegister (int action, global::Java.Lang.Object extra)
		{
			const string __id = "afterRegister.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (action);
				__args [1] = new JniArgumentValue ((extra == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extra).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_authorize;
#pragma warning disable 0169
		static Delegate GetAuthorizeHandler ()
		{
			if (cb_authorize == null)
				cb_authorize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Authorize);
			return cb_authorize;
		}

		static void n_Authorize (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Authorize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='authorize' and count(parameter)=0]"
		[Register ("authorize", "()V", "GetAuthorizeHandler")]
		public virtual unsafe void Authorize ()
		{
			const string __id = "authorize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_authorize_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAuthorize_arrayLjava_lang_String_Handler ()
		{
			if (cb_authorize_arrayLjava_lang_String_ == null)
				cb_authorize_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Authorize_arrayLjava_lang_String_);
			return cb_authorize_arrayLjava_lang_String_;
		}

		static void n_Authorize_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permissions)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] permissions = (string[]) JNIEnv.GetArray (native_permissions, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Authorize (permissions);
			if (permissions != null)
				JNIEnv.CopyArray (permissions, native_permissions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='authorize' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("authorize", "([Ljava/lang/String;)V", "GetAuthorize_arrayLjava_lang_String_Handler")]
		public virtual unsafe void Authorize (string[] permissions)
		{
			const string __id = "authorize.([Ljava/lang/String;)V";
			IntPtr native_permissions = JNIEnv.NewArray (permissions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_permissions);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (permissions != null) {
					JNIEnv.CopyArray (native_permissions, permissions);
					JNIEnv.DeleteLocalRef (native_permissions);
				}
			}
		}

		static Delegate cb_checkAuthorize_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCheckAuthorize_ILjava_lang_Object_Handler ()
		{
			if (cb_checkAuthorize_ILjava_lang_Object_ == null)
				cb_checkAuthorize_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_CheckAuthorize_ILjava_lang_Object_);
			return cb_checkAuthorize_ILjava_lang_Object_;
		}

		static bool n_CheckAuthorize_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckAuthorize (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='checkAuthorize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkAuthorize", "(ILjava/lang/Object;)Z", "GetCheckAuthorize_ILjava_lang_Object_Handler")]
		protected abstract bool CheckAuthorize (int p0, global::Java.Lang.Object p1);

		static Delegate cb_copyDevinfo_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCopyDevinfo_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_copyDevinfo_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_copyDevinfo_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyDevinfo_Ljava_lang_String_Ljava_lang_String_);
			return cb_copyDevinfo_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CopyDevinfo_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_dst)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string src = JNIEnv.GetString (native_src, JniHandleOwnership.DoNotTransfer);
			string dst = JNIEnv.GetString (native_dst, JniHandleOwnership.DoNotTransfer);
			__this.CopyDevinfo (src, dst);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='copyDevinfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copyDevinfo", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCopyDevinfo_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void CopyDevinfo (string src, string dst)
		{
			const string __id = "copyDevinfo.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_src = JNIEnv.NewString (src);
			IntPtr native_dst = JNIEnv.NewString (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_src);
				__args [1] = new JniArgumentValue (native_dst);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
				JNIEnv.DeleteLocalRef (native_dst);
			}
		}

		static Delegate cb_copyNetworkDevinfo_II;
#pragma warning disable 0169
		static Delegate GetCopyNetworkDevinfo_IIHandler ()
		{
			if (cb_copyNetworkDevinfo_II == null)
				cb_copyNetworkDevinfo_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_CopyNetworkDevinfo_II);
			return cb_copyNetworkDevinfo_II;
		}

		static void n_CopyNetworkDevinfo_II (IntPtr jnienv, IntPtr native__this, int src, int dst)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CopyNetworkDevinfo (src, dst);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='copyNetworkDevinfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("copyNetworkDevinfo", "(II)V", "GetCopyNetworkDevinfo_IIHandler")]
		protected virtual unsafe void CopyNetworkDevinfo (int src, int dst)
		{
			const string __id = "copyNetworkDevinfo.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (src);
				__args [1] = new JniArgumentValue (dst);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_customerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetCustomerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_Handler ()
		{
			if (cb_customerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_ == null)
				cb_customerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, short, IntPtr, IntPtr>) n_CustomerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_);
			return cb_customerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_;
		}

		static void n_CustomerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_method, short customerAction, IntPtr native_values, IntPtr native_filePathes)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var filePathes = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_filePathes, JniHandleOwnership.DoNotTransfer);
			__this.CustomerProtocol (url, method, customerAction, values, filePathes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='customerProtocol' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[5][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("customerProtocol", "(Ljava/lang/String;Ljava/lang/String;SLjava/util/HashMap;Ljava/util/HashMap;)V", "GetCustomerProtocol_Ljava_lang_String_Ljava_lang_String_SLjava_util_HashMap_Ljava_util_HashMap_Handler")]
		public virtual unsafe void CustomerProtocol (string url, string method, short customerAction, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> values, global::System.Collections.Generic.IDictionary<string, string> filePathes)
		{
			const string __id = "customerProtocol.(Ljava/lang/String;Ljava/lang/String;SLjava/util/HashMap;Ljava/util/HashMap;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_method = JNIEnv.NewString (method);
			IntPtr native_values = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (values);
			IntPtr native_filePathes = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (filePathes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_method);
				__args [2] = new JniArgumentValue (customerAction);
				__args [3] = new JniArgumentValue (native_values);
				__args [4] = new JniArgumentValue (native_filePathes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_method);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_filePathes);
			}
		}

		static Delegate cb_doAuthorize_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoAuthorize_arrayLjava_lang_String_Handler ()
		{
			if (cb_doAuthorize_arrayLjava_lang_String_ == null)
				cb_doAuthorize_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoAuthorize_arrayLjava_lang_String_);
			return cb_doAuthorize_arrayLjava_lang_String_;
		}

		static void n_DoAuthorize_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.DoAuthorize (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='doAuthorize' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("doAuthorize", "([Ljava/lang/String;)V", "GetDoAuthorize_arrayLjava_lang_String_Handler")]
		protected abstract void DoAuthorize (string[] p0);

		static Delegate cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetDoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_Handler ()
		{
			if (cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_ == null)
				cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_DoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_);
			return cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_;
		}

		static void n_DoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DoCustomerProtocol (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='doCustomerProtocol' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[5][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("doCustomerProtocol", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/HashMap;Ljava/util/HashMap;)V", "GetDoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_Handler")]
		protected abstract void DoCustomerProtocol (string p0, string p1, int p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3, global::System.Collections.Generic.IDictionary<string, string> p4);

		static Delegate cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_;
#pragma warning disable 0169
		static Delegate GetDoShare_Lcn_sharesdk_framework_Platform_ShareParams_Handler ()
		{
			if (cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_ == null)
				cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoShare_Lcn_sharesdk_framework_Platform_ShareParams_);
			return cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_;
		}

		static void n_DoShare_Lcn_sharesdk_framework_Platform_ShareParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform.ShareParams p0 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoShare (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='doShare' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("doShare", "(Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetDoShare_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		protected abstract void DoShare (global::CN.Sharesdk.Framework.Platform.ShareParams p0);

		static Delegate cb_filterFriendshipInfo_ILjava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetFilterFriendshipInfo_ILjava_util_HashMap_Handler ()
		{
			if (cb_filterFriendshipInfo_ILjava_util_HashMap_ == null)
				cb_filterFriendshipInfo_ILjava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_FilterFriendshipInfo_ILjava_util_HashMap_);
			return cb_filterFriendshipInfo_ILjava_util_HashMap_;
		}

		static IntPtr n_FilterFriendshipInfo_ILjava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.FilterFriendshipInfo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='filterFriendshipInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("filterFriendshipInfo", "(ILjava/util/HashMap;)Ljava/util/HashMap;", "GetFilterFriendshipInfo_ILjava_util_HashMap_Handler")]
		protected abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> FilterFriendshipInfo (int p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1);

		static Delegate cb_follow_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFollow_Ljava_lang_String_Handler ()
		{
			if (cb_follow_Ljava_lang_String_ == null)
				cb_follow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Follow_Ljava_lang_String_);
			return cb_follow_Ljava_lang_String_;
		}

		static void n_Follow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Follow (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='follow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("follow", "(Ljava/lang/String;)V", "GetFollow_Ljava_lang_String_Handler")]
		protected abstract void Follow (string p0);

		static Delegate cb_followFriend_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFollowFriend_Ljava_lang_String_Handler ()
		{
			if (cb_followFriend_Ljava_lang_String_ == null)
				cb_followFriend_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FollowFriend_Ljava_lang_String_);
			return cb_followFriend_Ljava_lang_String_;
		}

		static void n_FollowFriend_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.FollowFriend (account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='followFriend' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("followFriend", "(Ljava/lang/String;)V", "GetFollowFriend_Ljava_lang_String_Handler")]
		public virtual unsafe void FollowFriend (string account)
		{
			const string __id = "followFriend.(Ljava/lang/String;)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_account);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_getBilaterals_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBilaterals_IILjava_lang_String_Handler ()
		{
			if (cb_getBilaterals_IILjava_lang_String_ == null)
				cb_getBilaterals_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetBilaterals_IILjava_lang_String_);
			return cb_getBilaterals_IILjava_lang_String_;
		}

		static IntPtr n_GetBilaterals_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetBilaterals (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getBilaterals' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getBilaterals", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetBilaterals_IILjava_lang_String_Handler")]
		protected abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetBilaterals (int p0, int p1, string p2);

		static Delegate cb_getDevinfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDevinfo_Ljava_lang_String_Handler ()
		{
			if (cb_getDevinfo_Ljava_lang_String_ == null)
				cb_getDevinfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDevinfo_Ljava_lang_String_);
			return cb_getDevinfo_Ljava_lang_String_;
		}

		static IntPtr n_GetDevinfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_field)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string field = JNIEnv.GetString (native_field, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDevinfo (field));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getDevinfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDevinfo", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetDevinfo_Ljava_lang_String_Handler")]
		public virtual unsafe string GetDevinfo (string field)
		{
			const string __id = "getDevinfo.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_field = JNIEnv.NewString (field);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_field);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_field);
			}
		}

		static Delegate cb_getDevinfo_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDevinfo_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getDevinfo_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getDevinfo_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDevinfo_Ljava_lang_String_Ljava_lang_String_);
			return cb_getDevinfo_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetDevinfo_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_field)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string field = JNIEnv.GetString (native_field, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDevinfo (name, field));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getDevinfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDevinfo", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetDevinfo_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetDevinfo (string name, string field)
		{
			const string __id = "getDevinfo.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_field = JNIEnv.NewString (field);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_field);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_field);
			}
		}

		static Delegate cb_getFollowers_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFollowers_IILjava_lang_String_Handler ()
		{
			if (cb_getFollowers_IILjava_lang_String_ == null)
				cb_getFollowers_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetFollowers_IILjava_lang_String_);
			return cb_getFollowers_IILjava_lang_String_;
		}

		static IntPtr n_GetFollowers_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetFollowers (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getFollowers' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFollowers", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetFollowers_IILjava_lang_String_Handler")]
		protected abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetFollowers (int p0, int p1, string p2);

		static Delegate cb_getFollowings_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFollowings_IILjava_lang_String_Handler ()
		{
			if (cb_getFollowings_IILjava_lang_String_ == null)
				cb_getFollowings_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetFollowings_IILjava_lang_String_);
			return cb_getFollowings_IILjava_lang_String_;
		}

		static IntPtr n_GetFollowings_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetFollowings (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getFollowings' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFollowings", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetFollowings_IILjava_lang_String_Handler")]
		protected abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetFollowings (int p0, int p1, string p2);

		static Delegate cb_getFriendList_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFriendList_IILjava_lang_String_Handler ()
		{
			if (cb_getFriendList_IILjava_lang_String_ == null)
				cb_getFriendList_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_GetFriendList_IILjava_lang_String_);
			return cb_getFriendList_IILjava_lang_String_;
		}

		static void n_GetFriendList_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetFriendList (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getFriendList' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFriendList", "(IILjava/lang/String;)V", "GetGetFriendList_IILjava_lang_String_Handler")]
		protected abstract void GetFriendList (int p0, int p1, string p2);

		static Delegate cb_getNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_getNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_);
			return cb_getNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int platformId, IntPtr native_onlineField, IntPtr native_offlineField)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string onlineField = JNIEnv.GetString (native_onlineField, JniHandleOwnership.DoNotTransfer);
			string offlineField = JNIEnv.GetString (native_offlineField, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetNetworkDevinfo (platformId, onlineField, offlineField));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getNetworkDevinfo' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getNetworkDevinfo", "(ILjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetNetworkDevinfo_ILjava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe string GetNetworkDevinfo (int platformId, string onlineField, string offlineField)
		{
			const string __id = "getNetworkDevinfo.(ILjava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_onlineField = JNIEnv.NewString (onlineField);
			IntPtr native_offlineField = JNIEnv.NewString (offlineField);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (platformId);
				__args [1] = new JniArgumentValue (native_onlineField);
				__args [2] = new JniArgumentValue (native_offlineField);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_onlineField);
				JNIEnv.DeleteLocalRef (native_offlineField);
			}
		}

		static Delegate cb_getNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_);
			return cb_getNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onlineField, IntPtr native_offlineField)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string onlineField = JNIEnv.GetString (native_onlineField, JniHandleOwnership.DoNotTransfer);
			string offlineField = JNIEnv.GetString (native_offlineField, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetNetworkDevinfo (onlineField, offlineField));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getNetworkDevinfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getNetworkDevinfo", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetNetworkDevinfo_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe string GetNetworkDevinfo (string onlineField, string offlineField)
		{
			const string __id = "getNetworkDevinfo.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_onlineField = JNIEnv.NewString (onlineField);
			IntPtr native_offlineField = JNIEnv.NewString (offlineField);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_onlineField);
				__args [1] = new JniArgumentValue (native_offlineField);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_onlineField);
				JNIEnv.DeleteLocalRef (native_offlineField);
			}
		}

		static Delegate cb_getShortLintk_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetShortLintk_Ljava_lang_String_ZHandler ()
		{
			if (cb_getShortLintk_Ljava_lang_String_Z == null)
				cb_getShortLintk_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetShortLintk_Ljava_lang_String_Z);
			return cb_getShortLintk_Ljava_lang_String_Z;
		}

		static IntPtr n_GetShortLintk_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_text, bool checkHref)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetShortLintk (text, checkHref));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getShortLintk' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getShortLintk", "(Ljava/lang/String;Z)Ljava/lang/String;", "GetGetShortLintk_Ljava_lang_String_ZHandler")]
		public virtual unsafe string GetShortLintk (string text, bool checkHref)
		{
			const string __id = "getShortLintk.(Ljava/lang/String;Z)Ljava/lang/String;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (checkHref);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_getTimeLine_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetGetTimeLine_Ljava_lang_String_IIHandler ()
		{
			if (cb_getTimeLine_Ljava_lang_String_II == null)
				cb_getTimeLine_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_GetTimeLine_Ljava_lang_String_II);
			return cb_getTimeLine_Ljava_lang_String_II;
		}

		static void n_GetTimeLine_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_account, int count, int page)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.GetTimeLine (account, count, page);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getTimeLine' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTimeLine", "(Ljava/lang/String;II)V", "GetGetTimeLine_Ljava_lang_String_IIHandler")]
		public virtual unsafe void GetTimeLine (string account, int count, int page)
		{
			const string __id = "getTimeLine.(Ljava/lang/String;II)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_account);
				__args [1] = new JniArgumentValue (count);
				__args [2] = new JniArgumentValue (page);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_initDevInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitDevInfo_Ljava_lang_String_Handler ()
		{
			if (cb_initDevInfo_Ljava_lang_String_ == null)
				cb_initDevInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitDevInfo_Ljava_lang_String_);
			return cb_initDevInfo_Ljava_lang_String_;
		}

		static void n_InitDevInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitDevInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='initDevInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initDevInfo", "(Ljava/lang/String;)V", "GetInitDevInfo_Ljava_lang_String_Handler")]
		protected abstract void InitDevInfo (string p0);

		static Delegate cb_innerAuthorize_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInnerAuthorize_ILjava_lang_Object_Handler ()
		{
			if (cb_innerAuthorize_ILjava_lang_Object_ == null)
				cb_innerAuthorize_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_InnerAuthorize_ILjava_lang_Object_);
			return cb_innerAuthorize_ILjava_lang_Object_;
		}

		static void n_InnerAuthorize_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int action, IntPtr native_extra)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object extra = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_extra, JniHandleOwnership.DoNotTransfer);
			__this.InnerAuthorize (action, extra);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='innerAuthorize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("innerAuthorize", "(ILjava/lang/Object;)V", "GetInnerAuthorize_ILjava_lang_Object_Handler")]
		protected virtual unsafe void InnerAuthorize (int action, global::Java.Lang.Object extra)
		{
			const string __id = "innerAuthorize.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (action);
				__args [1] = new JniArgumentValue ((extra == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extra).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_listFriend_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetListFriend_IILjava_lang_String_Handler ()
		{
			if (cb_listFriend_IILjava_lang_String_ == null)
				cb_listFriend_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ListFriend_IILjava_lang_String_);
			return cb_listFriend_IILjava_lang_String_;
		}

		static void n_ListFriend_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int count, int page, IntPtr native_account)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.ListFriend (count, page, account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='listFriend' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("listFriend", "(IILjava/lang/String;)V", "GetListFriend_IILjava_lang_String_Handler")]
		public virtual unsafe void ListFriend (int count, int page, string account)
		{
			const string __id = "listFriend.(IILjava/lang/String;)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (page);
				__args [2] = new JniArgumentValue (native_account);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_removeAccount_Z;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_ZHandler ()
		{
			if (cb_removeAccount_Z == null)
				cb_removeAccount_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RemoveAccount_Z);
			return cb_removeAccount_Z;
		}

		static void n_RemoveAccount_Z (IntPtr jnienv, IntPtr native__this, bool removeCookie)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAccount (removeCookie);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("removeAccount", "(Z)V", "GetRemoveAccount_ZHandler")]
		public virtual unsafe void RemoveAccount (bool removeCookie)
		{
			const string __id = "removeAccount.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (removeCookie);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNetworkDevinfo;
#pragma warning disable 0169
		static Delegate GetSetNetworkDevinfoHandler ()
		{
			if (cb_setNetworkDevinfo == null)
				cb_setNetworkDevinfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetNetworkDevinfo);
			return cb_setNetworkDevinfo;
		}

		static void n_SetNetworkDevinfo (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNetworkDevinfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='setNetworkDevinfo' and count(parameter)=0]"
		[Register ("setNetworkDevinfo", "()V", "GetSetNetworkDevinfoHandler")]
		protected abstract void SetNetworkDevinfo ();

		static Delegate cb_share_Lcn_sharesdk_framework_Platform_ShareParams_;
#pragma warning disable 0169
		static Delegate GetShare_Lcn_sharesdk_framework_Platform_ShareParams_Handler ()
		{
			if (cb_share_Lcn_sharesdk_framework_Platform_ShareParams_ == null)
				cb_share_Lcn_sharesdk_framework_Platform_ShareParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Share_Lcn_sharesdk_framework_Platform_ShareParams_);
			return cb_share_Lcn_sharesdk_framework_Platform_ShareParams_;
		}

		static void n_Share_Lcn_sharesdk_framework_Platform_ShareParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform.ShareParams @params = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native__params, JniHandleOwnership.DoNotTransfer);
			__this.Share (@params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='share' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("share", "(Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetShare_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		public virtual unsafe void Share (global::CN.Sharesdk.Framework.Platform.ShareParams @params)
		{
			const string __id = "share.(Lcn/sharesdk/framework/Platform$ShareParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowUser_Ljava_lang_String_Handler ()
		{
			if (cb_showUser_Ljava_lang_String_ == null)
				cb_showUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowUser_Ljava_lang_String_);
			return cb_showUser_Ljava_lang_String_;
		}

		static void n_ShowUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.ShowUser (account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='showUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showUser", "(Ljava/lang/String;)V", "GetShowUser_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowUser (string account)
		{
			const string __id = "showUser.(Ljava/lang/String;)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_account);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_timeline_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTimeline_IILjava_lang_String_Handler ()
		{
			if (cb_timeline_IILjava_lang_String_ == null)
				cb_timeline_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_Timeline_IILjava_lang_String_);
			return cb_timeline_IILjava_lang_String_;
		}

		static void n_Timeline_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Timeline (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='timeline' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("timeline", "(IILjava/lang/String;)V", "GetTimeline_IILjava_lang_String_Handler")]
		protected abstract void Timeline (int p0, int p1, string p2);

		static Delegate cb_uploadImageToFileServer_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetUploadImageToFileServer_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_uploadImageToFileServer_Landroid_graphics_Bitmap_ == null)
				cb_uploadImageToFileServer_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadImageToFileServer_Landroid_graphics_Bitmap_);
			return cb_uploadImageToFileServer_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_UploadImageToFileServer_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageData)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap imageData = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_imageData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UploadImageToFileServer (imageData));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='uploadImageToFileServer' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("uploadImageToFileServer", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetUploadImageToFileServer_Landroid_graphics_Bitmap_Handler")]
		protected virtual unsafe string UploadImageToFileServer (global::Android.Graphics.Bitmap imageData)
		{
			const string __id = "uploadImageToFileServer.(Landroid/graphics/Bitmap;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_uploadImageToFileServer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUploadImageToFileServer_Ljava_lang_String_Handler ()
		{
			if (cb_uploadImageToFileServer_Ljava_lang_String_ == null)
				cb_uploadImageToFileServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadImageToFileServer_Ljava_lang_String_);
			return cb_uploadImageToFileServer_Ljava_lang_String_;
		}

		static IntPtr n_UploadImageToFileServer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePath)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string imagePath = JNIEnv.GetString (native_imagePath, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UploadImageToFileServer (imagePath));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='uploadImageToFileServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uploadImageToFileServer", "(Ljava/lang/String;)Ljava/lang/String;", "GetUploadImageToFileServer_Ljava_lang_String_Handler")]
		protected virtual unsafe string UploadImageToFileServer (string imagePath)
		{
			const string __id = "uploadImageToFileServer.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_imagePath = JNIEnv.NewString (imagePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imagePath);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_imagePath);
			}
		}

		static Delegate cb_userInfor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUserInfor_Ljava_lang_String_Handler ()
		{
			if (cb_userInfor_Ljava_lang_String_ == null)
				cb_userInfor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UserInfor_Ljava_lang_String_);
			return cb_userInfor_Ljava_lang_String_;
		}

		static void n_UserInfor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Platform __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserInfor (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='userInfor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("userInfor", "(Ljava/lang/String;)V", "GetUserInfor_Ljava_lang_String_Handler")]
		protected abstract void UserInfor (string p0);

#region "Event implementation for CN.Sharesdk.Framework.IPlatformActionListener"
		public event EventHandler<global::CN.Sharesdk.Framework.CancelEventArgs> Cancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetPlatformActionListener,
						__CreateIPlatformActionListenerImplementor,
						__v => PlatformActionListener = __v,
						__h => __h.OnCancelHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetPlatformActionListener,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => PlatformActionListener = null,
						__h => __h.OnCancelHandler -= value);
			}
		}

		public event EventHandler<global::CN.Sharesdk.Framework.CompleteEventArgs> Complete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetPlatformActionListener,
						__CreateIPlatformActionListenerImplementor,
						__v => PlatformActionListener = __v,
						__h => __h.OnCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetPlatformActionListener,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => PlatformActionListener = null,
						__h => __h.OnCompleteHandler -= value);
			}
		}

		public event EventHandler<global::CN.Sharesdk.Framework.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetPlatformActionListener,
						__CreateIPlatformActionListenerImplementor,
						__v => PlatformActionListener = __v,
						__h => __h.OnErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetPlatformActionListener,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => PlatformActionListener = null,
						__h => __h.OnErrorHandler -= value);
			}
		}

		WeakReference weak_implementor___SetPlatformActionListener;

		global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor __CreateIPlatformActionListenerImplementor ()
		{
			return new global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("cn/sharesdk/framework/Platform", DoNotGenerateAcw=true)]
	internal partial class PlatformInvoker : Platform {

		public PlatformInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/Platform", typeof (PlatformInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool HasShareCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='hasShareCallback' and count(parameter)=0]"
			[Register ("hasShareCallback", "()Z", "GetHasShareCallbackHandler")]
			get {
				const string __id = "hasShareCallback.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected override unsafe int PlatformId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getPlatformId' and count(parameter)=0]"
			[Register ("getPlatformId", "()I", "GetGetPlatformIdHandler")]
			get {
				const string __id = "getPlatformId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='checkAuthorize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkAuthorize", "(ILjava/lang/Object;)Z", "GetCheckAuthorize_ILjava_lang_Object_Handler")]
		protected override unsafe bool CheckAuthorize (int p0, global::Java.Lang.Object p1)
		{
			const string __id = "checkAuthorize.(ILjava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='doAuthorize' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("doAuthorize", "([Ljava/lang/String;)V", "GetDoAuthorize_arrayLjava_lang_String_Handler")]
		protected override unsafe void DoAuthorize (string[] p0)
		{
			const string __id = "doAuthorize.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='doCustomerProtocol' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[5][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("doCustomerProtocol", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/HashMap;Ljava/util/HashMap;)V", "GetDoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_Handler")]
		protected override unsafe void DoCustomerProtocol (string p0, string p1, int p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3, global::System.Collections.Generic.IDictionary<string, string> p4)
		{
			const string __id = "doCustomerProtocol.(Ljava/lang/String;Ljava/lang/String;ILjava/util/HashMap;Ljava/util/HashMap;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='doShare' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("doShare", "(Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetDoShare_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		protected override unsafe void DoShare (global::CN.Sharesdk.Framework.Platform.ShareParams p0)
		{
			const string __id = "doShare.(Lcn/sharesdk/framework/Platform$ShareParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='filterFriendshipInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("filterFriendshipInfo", "(ILjava/util/HashMap;)Ljava/util/HashMap;", "GetFilterFriendshipInfo_ILjava_util_HashMap_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> FilterFriendshipInfo (int p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			const string __id = "filterFriendshipInfo.(ILjava/util/HashMap;)Ljava/util/HashMap;";
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='follow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("follow", "(Ljava/lang/String;)V", "GetFollow_Ljava_lang_String_Handler")]
		protected override unsafe void Follow (string p0)
		{
			const string __id = "follow.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getBilaterals' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getBilaterals", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetBilaterals_IILjava_lang_String_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetBilaterals (int p0, int p1, string p2)
		{
			const string __id = "getBilaterals.(IILjava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getFollowers' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFollowers", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetFollowers_IILjava_lang_String_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetFollowers (int p0, int p1, string p2)
		{
			const string __id = "getFollowers.(IILjava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getFollowings' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFollowings", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetFollowings_IILjava_lang_String_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetFollowings (int p0, int p1, string p2)
		{
			const string __id = "getFollowings.(IILjava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='getFriendList' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFriendList", "(IILjava/lang/String;)V", "GetGetFriendList_IILjava_lang_String_Handler")]
		protected override unsafe void GetFriendList (int p0, int p1, string p2)
		{
			const string __id = "getFriendList.(IILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='initDevInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initDevInfo", "(Ljava/lang/String;)V", "GetInitDevInfo_Ljava_lang_String_Handler")]
		protected override unsafe void InitDevInfo (string p0)
		{
			const string __id = "initDevInfo.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='setNetworkDevinfo' and count(parameter)=0]"
		[Register ("setNetworkDevinfo", "()V", "GetSetNetworkDevinfoHandler")]
		protected override unsafe void SetNetworkDevinfo ()
		{
			const string __id = "setNetworkDevinfo.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='timeline' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("timeline", "(IILjava/lang/String;)V", "GetTimeline_IILjava_lang_String_Handler")]
		protected override unsafe void Timeline (int p0, int p1, string p2)
		{
			const string __id = "timeline.(IILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Platform']/method[@name='userInfor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("userInfor", "(Ljava/lang/String;)V", "GetUserInfor_Ljava_lang_String_Handler")]
		protected override unsafe void UserInfor (string p0)
		{
			const string __id = "userInfor.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
