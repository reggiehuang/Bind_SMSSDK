using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/OnekeyShare", DoNotGenerateAcw=true)]
	public partial class OnekeyShare : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/OnekeyShare", typeof (OnekeyShare));
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

		protected OnekeyShare (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/constructor[@name='OnekeyShare' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OnekeyShare ()
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

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		static Delegate cb_setCallback_Lcn_sharesdk_framework_PlatformActionListener_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcn_sharesdk_framework_PlatformActionListener_Handler ()
		{
			if (cb_setCallback_Lcn_sharesdk_framework_PlatformActionListener_ == null)
				cb_setCallback_Lcn_sharesdk_framework_PlatformActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcn_sharesdk_framework_PlatformActionListener_);
			return cb_setCallback_Lcn_sharesdk_framework_PlatformActionListener_;
		}

		static void n_SetCallback_Lcn_sharesdk_framework_PlatformActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.IPlatformActionListener @callback = (global::CN.Sharesdk.Framework.IPlatformActionListener)global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Callback = @callback;
		}
#pragma warning restore 0169

		public virtual unsafe global::CN.Sharesdk.Framework.IPlatformActionListener Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcn/sharesdk/framework/PlatformActionListener;", "GetGetCallbackHandler")]
			get {
				const string __id = "getCallback.()Lcn/sharesdk/framework/PlatformActionListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.PlatformActionListener']]"
			[Register ("setCallback", "(Lcn/sharesdk/framework/PlatformActionListener;)V", "GetSetCallback_Lcn_sharesdk_framework_PlatformActionListener_Handler")]
			set {
				const string __id = "setCallback.(Lcn/sharesdk/framework/PlatformActionListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShareContentCustomizeCallback;
#pragma warning disable 0169
		static Delegate GetGetShareContentCustomizeCallbackHandler ()
		{
			if (cb_getShareContentCustomizeCallback == null)
				cb_getShareContentCustomizeCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShareContentCustomizeCallback);
			return cb_getShareContentCustomizeCallback;
		}

		static IntPtr n_GetShareContentCustomizeCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShareContentCustomizeCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_;
#pragma warning disable 0169
		static Delegate GetSetShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_Handler ()
		{
			if (cb_setShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_ == null)
				cb_setShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_);
			return cb_setShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_;
		}

		static void n_SetShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback @callback = (global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback)global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ShareContentCustomizeCallback = @callback;
		}
#pragma warning restore 0169

		public virtual unsafe global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback ShareContentCustomizeCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='getShareContentCustomizeCallback' and count(parameter)=0]"
			[Register ("getShareContentCustomizeCallback", "()Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;", "GetGetShareContentCustomizeCallbackHandler")]
			get {
				const string __id = "getShareContentCustomizeCallback.()Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setShareContentCustomizeCallback' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.ShareContentCustomizeCallback']]"
			[Register ("setShareContentCustomizeCallback", "(Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;)V", "GetSetShareContentCustomizeCallback_Lcn_sharesdk_onekeyshare_ShareContentCustomizeCallback_Handler")]
			set {
				const string __id = "setShareContentCustomizeCallback.(Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.Text = text;
		}
#pragma warning restore 0169

		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_addHiddenPlatform_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHiddenPlatform_Ljava_lang_String_Handler ()
		{
			if (cb_addHiddenPlatform_Ljava_lang_String_ == null)
				cb_addHiddenPlatform_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddHiddenPlatform_Ljava_lang_String_);
			return cb_addHiddenPlatform_Ljava_lang_String_;
		}

		static void n_AddHiddenPlatform_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platform)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string platform = JNIEnv.GetString (native_platform, JniHandleOwnership.DoNotTransfer);
			__this.AddHiddenPlatform (platform);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='addHiddenPlatform' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addHiddenPlatform", "(Ljava/lang/String;)V", "GetAddHiddenPlatform_Ljava_lang_String_Handler")]
		public virtual unsafe void AddHiddenPlatform (string platform)
		{
			const string __id = "addHiddenPlatform.(Ljava/lang/String;)V";
			IntPtr native_platform = JNIEnv.NewString (platform);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_platform);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_platform);
			}
		}

		static Delegate cb_disableSSOWhenAuthorize;
#pragma warning disable 0169
		static Delegate GetDisableSSOWhenAuthorizeHandler ()
		{
			if (cb_disableSSOWhenAuthorize == null)
				cb_disableSSOWhenAuthorize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableSSOWhenAuthorize);
			return cb_disableSSOWhenAuthorize;
		}

		static void n_DisableSSOWhenAuthorize (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableSSOWhenAuthorize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='disableSSOWhenAuthorize' and count(parameter)=0]"
		[Register ("disableSSOWhenAuthorize", "()V", "GetDisableSSOWhenAuthorizeHandler")]
		public virtual unsafe void DisableSSOWhenAuthorize ()
		{
			const string __id = "disableSSOWhenAuthorize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			__this.SetAddress (address);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAddress (string address)
		{
			const string __id = "setAddress.(Ljava/lang/String;)V";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_address);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string comment = JNIEnv.GetString (native_comment, JniHandleOwnership.DoNotTransfer);
			__this.SetComment (comment);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setComment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setComment", "(Ljava/lang/String;)V", "GetSetComment_Ljava_lang_String_Handler")]
		public virtual unsafe void SetComment (string comment)
		{
			const string __id = "setComment.(Ljava/lang/String;)V";
			IntPtr native_comment = JNIEnv.NewString (comment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_comment);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_comment);
			}
		}

		static Delegate cb_setCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_ == null)
				cb_setCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_);
			return cb_setCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_;
		}

		static void n_SetCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logo, IntPtr native_label, IntPtr native_ocl)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap logo = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_logo, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener ocl = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_ocl, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomerLogo (logo, label, ocl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setCustomerLogo' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.view.View.OnClickListener']]"
		[Register ("setCustomerLogo", "(Landroid/graphics/Bitmap;Ljava/lang/String;Landroid/view/View$OnClickListener;)V", "GetSetCustomerLogo_Landroid_graphics_Bitmap_Ljava_lang_String_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetCustomerLogo (global::Android.Graphics.Bitmap logo, string label, global::Android.Views.View.IOnClickListener ocl)
		{
			const string __id = "setCustomerLogo.(Landroid/graphics/Bitmap;Ljava/lang/String;Landroid/view/View$OnClickListener;)V";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((logo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logo).Handle);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue ((ocl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ocl).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_setDialogMode_Z;
#pragma warning disable 0169
		static Delegate GetSetDialogMode_ZHandler ()
		{
			if (cb_setDialogMode_Z == null)
				cb_setDialogMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDialogMode_Z);
			return cb_setDialogMode_Z;
		}

		static void n_SetDialogMode_Z (IntPtr jnienv, IntPtr native__this, bool isDialog)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDialogMode (isDialog);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setDialogMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDialogMode", "(Z)V", "GetSetDialogMode_ZHandler")]
		public virtual unsafe void SetDialogMode (bool isDialog)
		{
			const string __id = "setDialogMode.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isDialog);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setExecuteUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExecuteUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setExecuteUrl_Ljava_lang_String_ == null)
				cb_setExecuteUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExecuteUrl_Ljava_lang_String_);
			return cb_setExecuteUrl_Ljava_lang_String_;
		}

		static void n_SetExecuteUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_executeurl)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string executeurl = JNIEnv.GetString (native_executeurl, JniHandleOwnership.DoNotTransfer);
			__this.SetExecuteUrl (executeurl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setExecuteUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setExecuteUrl", "(Ljava/lang/String;)V", "GetSetExecuteUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetExecuteUrl (string executeurl)
		{
			const string __id = "setExecuteUrl.(Ljava/lang/String;)V";
			IntPtr native_executeurl = JNIEnv.NewString (executeurl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_executeurl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_executeurl);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string filePath = JNIEnv.GetString (native_filePath, JniHandleOwnership.DoNotTransfer);
			__this.SetFilePath (filePath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFilePath", "(Ljava/lang/String;)V", "GetSetFilePath_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFilePath (string filePath)
		{
			const string __id = "setFilePath.(Ljava/lang/String;)V";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
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

		static void n_SetImageArray_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageArray)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] imageArray = (string[]) JNIEnv.GetArray (native_imageArray, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetImageArray (imageArray);
			if (imageArray != null)
				JNIEnv.CopyArray (imageArray, native_imageArray);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setImageArray' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setImageArray", "([Ljava/lang/String;)V", "GetSetImageArray_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetImageArray (string[] imageArray)
		{
			const string __id = "setImageArray.([Ljava/lang/String;)V";
			IntPtr native_imageArray = JNIEnv.NewArray (imageArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageArray);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (imageArray != null) {
					JNIEnv.CopyArray (native_imageArray, imageArray);
					JNIEnv.DeleteLocalRef (native_imageArray);
				}
			}
		}

		static Delegate cb_setImageData_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImageData_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImageData_Landroid_graphics_Bitmap_ == null)
				cb_setImageData_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageData_Landroid_graphics_Bitmap_);
			return cb_setImageData_Landroid_graphics_Bitmap_;
		}

		static void n_SetImageData_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iamgeData)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap iamgeData = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_iamgeData, JniHandleOwnership.DoNotTransfer);
			__this.SetImageData (iamgeData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setImageData' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImageData", "(Landroid/graphics/Bitmap;)V", "GetSetImageData_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetImageData (global::Android.Graphics.Bitmap iamgeData)
		{
			const string __id = "setImageData.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iamgeData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iamgeData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string imagePath = JNIEnv.GetString (native_imagePath, JniHandleOwnership.DoNotTransfer);
			__this.SetImagePath (imagePath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setImagePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImagePath", "(Ljava/lang/String;)V", "GetSetImagePath_Ljava_lang_String_Handler")]
		public virtual unsafe void SetImagePath (string imagePath)
		{
			const string __id = "setImagePath.(Ljava/lang/String;)V";
			IntPtr native_imagePath = JNIEnv.NewString (imagePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imagePath);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imagePath);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string imageUrl = JNIEnv.GetString (native_imageUrl, JniHandleOwnership.DoNotTransfer);
			__this.SetImageUrl (imageUrl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImageUrl", "(Ljava/lang/String;)V", "GetSetImageUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetImageUrl (string imageUrl)
		{
			const string __id = "setImageUrl.(Ljava/lang/String;)V";
			IntPtr native_imageUrl = JNIEnv.NewString (imageUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageUrl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageUrl);
			}
		}

		static Delegate cb_setInstallUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInstallUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setInstallUrl_Ljava_lang_String_ == null)
				cb_setInstallUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInstallUrl_Ljava_lang_String_);
			return cb_setInstallUrl_Ljava_lang_String_;
		}

		static void n_SetInstallUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_installurl)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string installurl = JNIEnv.GetString (native_installurl, JniHandleOwnership.DoNotTransfer);
			__this.SetInstallUrl (installurl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setInstallUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInstallUrl", "(Ljava/lang/String;)V", "GetSetInstallUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetInstallUrl (string installurl)
		{
			const string __id = "setInstallUrl.(Ljava/lang/String;)V";
			IntPtr native_installurl = JNIEnv.NewString (installurl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_installurl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_installurl);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLatitude (latitude);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLatitude", "(F)V", "GetSetLatitude_FHandler")]
		public virtual unsafe void SetLatitude (float latitude)
		{
			const string __id = "setLatitude.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (latitude);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLongitude (longitude);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLongitude", "(F)V", "GetSetLongitude_FHandler")]
		public virtual unsafe void SetLongitude (float longitude)
		{
			const string __id = "setLongitude.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (longitude);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string musicUrl = JNIEnv.GetString (native_musicUrl, JniHandleOwnership.DoNotTransfer);
			__this.SetMusicUrl (musicUrl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setMusicUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMusicUrl", "(Ljava/lang/String;)V", "GetSetMusicUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMusicUrl (string musicUrl)
		{
			const string __id = "setMusicUrl.(Ljava/lang/String;)V";
			IntPtr native_musicUrl = JNIEnv.NewString (musicUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_musicUrl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_musicUrl);
			}
		}

		static Delegate cb_setPlatform_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlatform_Ljava_lang_String_Handler ()
		{
			if (cb_setPlatform_Ljava_lang_String_ == null)
				cb_setPlatform_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlatform_Ljava_lang_String_);
			return cb_setPlatform_Ljava_lang_String_;
		}

		static void n_SetPlatform_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platform)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string platform = JNIEnv.GetString (native_platform, JniHandleOwnership.DoNotTransfer);
			__this.SetPlatform (platform);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setPlatform' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPlatform", "(Ljava/lang/String;)V", "GetSetPlatform_Ljava_lang_String_Handler")]
		public virtual unsafe void SetPlatform (string platform)
		{
			const string __id = "setPlatform.(Ljava/lang/String;)V";
			IntPtr native_platform = JNIEnv.NewString (platform);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_platform);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_platform);
			}
		}

		static Delegate cb_setShareToTencentWeiboWhenPerformingQQOrQZoneSharing;
#pragma warning disable 0169
		static Delegate GetSetShareToTencentWeiboWhenPerformingQQOrQZoneSharingHandler ()
		{
			if (cb_setShareToTencentWeiboWhenPerformingQQOrQZoneSharing == null)
				cb_setShareToTencentWeiboWhenPerformingQQOrQZoneSharing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetShareToTencentWeiboWhenPerformingQQOrQZoneSharing);
			return cb_setShareToTencentWeiboWhenPerformingQQOrQZoneSharing;
		}

		static void n_SetShareToTencentWeiboWhenPerformingQQOrQZoneSharing (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShareToTencentWeiboWhenPerformingQQOrQZoneSharing ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setShareToTencentWeiboWhenPerformingQQOrQZoneSharing' and count(parameter)=0]"
		[Register ("setShareToTencentWeiboWhenPerformingQQOrQZoneSharing", "()V", "GetSetShareToTencentWeiboWhenPerformingQQOrQZoneSharingHandler")]
		public virtual unsafe void SetShareToTencentWeiboWhenPerformingQQOrQZoneSharing ()
		{
			const string __id = "setShareToTencentWeiboWhenPerformingQQOrQZoneSharing.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSilent_Z;
#pragma warning disable 0169
		static Delegate GetSetSilent_ZHandler ()
		{
			if (cb_setSilent_Z == null)
				cb_setSilent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSilent_Z);
			return cb_setSilent_Z;
		}

		static void n_SetSilent_Z (IntPtr jnienv, IntPtr native__this, bool silent)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSilent (silent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setSilent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSilent", "(Z)V", "GetSetSilent_ZHandler")]
		public virtual unsafe void SetSilent (bool silent)
		{
			const string __id = "setSilent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (silent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string site = JNIEnv.GetString (native_site, JniHandleOwnership.DoNotTransfer);
			__this.SetSite (site);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setSite' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSite", "(Ljava/lang/String;)V", "GetSetSite_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSite (string site)
		{
			const string __id = "setSite.(Ljava/lang/String;)V";
			IntPtr native_site = JNIEnv.NewString (site);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_site);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_site);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string siteUrl = JNIEnv.GetString (native_siteUrl, JniHandleOwnership.DoNotTransfer);
			__this.SetSiteUrl (siteUrl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setSiteUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSiteUrl", "(Ljava/lang/String;)V", "GetSetSiteUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSiteUrl (string siteUrl)
		{
			const string __id = "setSiteUrl.(Ljava/lang/String;)V";
			IntPtr native_siteUrl = JNIEnv.NewString (siteUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_siteUrl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_siteUrl);
			}
		}

		static Delegate cb_setTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_;
#pragma warning disable 0169
		static Delegate GetSetTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_Handler ()
		{
			if (cb_setTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_ == null)
				cb_setTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_);
			return cb_setTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_;
		}

		static void n_SetTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_theme)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme theme = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme> (native_theme, JniHandleOwnership.DoNotTransfer);
			__this.SetTheme (theme);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setTheme' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareTheme']]"
		[Register ("setTheme", "(Lcn/sharesdk/onekeyshare/OnekeyShareTheme;)V", "GetSetTheme_Lcn_sharesdk_onekeyshare_OnekeyShareTheme_Handler")]
		public virtual unsafe void SetTheme (global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme theme)
		{
			const string __id = "setTheme.(Lcn/sharesdk/onekeyshare/OnekeyShareTheme;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (title);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTitle (string title)
		{
			const string __id = "setTitle.(Ljava/lang/String;)V";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string titleUrl = JNIEnv.GetString (native_titleUrl, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleUrl (titleUrl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setTitleUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleUrl", "(Ljava/lang/String;)V", "GetSetTitleUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTitleUrl (string titleUrl)
		{
			const string __id = "setTitleUrl.(Ljava/lang/String;)V";
			IntPtr native_titleUrl = JNIEnv.NewString (titleUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_titleUrl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleUrl);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetUrl (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUrl (string url)
		{
			const string __id = "setUrl.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string venueDescription = JNIEnv.GetString (native_venueDescription, JniHandleOwnership.DoNotTransfer);
			__this.SetVenueDescription (venueDescription);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setVenueDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVenueDescription", "(Ljava/lang/String;)V", "GetSetVenueDescription_Ljava_lang_String_Handler")]
		public virtual unsafe void SetVenueDescription (string venueDescription)
		{
			const string __id = "setVenueDescription.(Ljava/lang/String;)V";
			IntPtr native_venueDescription = JNIEnv.NewString (venueDescription);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_venueDescription);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_venueDescription);
			}
		}

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
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string venueName = JNIEnv.GetString (native_venueName, JniHandleOwnership.DoNotTransfer);
			__this.SetVenueName (venueName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setVenueName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVenueName", "(Ljava/lang/String;)V", "GetSetVenueName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetVenueName (string venueName)
		{
			const string __id = "setVenueName.(Ljava/lang/String;)V";
			IntPtr native_venueName = JNIEnv.NewString (venueName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_venueName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_venueName);
			}
		}

		static Delegate cb_setVideoUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideoUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setVideoUrl_Ljava_lang_String_ == null)
				cb_setVideoUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoUrl_Ljava_lang_String_);
			return cb_setVideoUrl_Ljava_lang_String_;
		}

		static void n_SetVideoUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoUrl (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setVideoUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVideoUrl", "(Ljava/lang/String;)V", "GetSetVideoUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetVideoUrl (string url)
		{
			const string __id = "setVideoUrl.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_setViewToShare_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetViewToShare_Landroid_view_View_Handler ()
		{
			if (cb_setViewToShare_Landroid_view_View_ == null)
				cb_setViewToShare_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewToShare_Landroid_view_View_);
			return cb_setViewToShare_Landroid_view_View_;
		}

		static void n_SetViewToShare_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_viewToShare)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View viewToShare = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_viewToShare, JniHandleOwnership.DoNotTransfer);
			__this.SetViewToShare (viewToShare);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='setViewToShare' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setViewToShare", "(Landroid/view/View;)V", "GetSetViewToShare_Landroid_view_View_Handler")]
		public virtual unsafe void SetViewToShare (global::Android.Views.View viewToShare)
		{
			const string __id = "setViewToShare.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((viewToShare == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewToShare).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_show_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_content_Context_Handler ()
		{
			if (cb_show_Landroid_content_Context_ == null)
				cb_show_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Show_Landroid_content_Context_);
			return cb_show_Landroid_content_Context_;
		}

		static void n_Show_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShare __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Show (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShare']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("show", "(Landroid/content/Context;)V", "GetShow_Landroid_content_Context_Handler")]
		public virtual unsafe void Show (global::Android.Content.Context context)
		{
			const string __id = "show.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for CN.Sharesdk.Framework.IPlatformActionListener"
		public event EventHandler<global::CN.Sharesdk.Framework.CancelEventArgs> Cancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetCallback,
						__CreateIPlatformActionListenerImplementor,
						__v => Callback = __v,
						__h => __h.OnCancelHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetCallback,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => Callback = null,
						__h => __h.OnCancelHandler -= value);
			}
		}

		public event EventHandler<global::CN.Sharesdk.Framework.CompleteEventArgs> Complete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetCallback,
						__CreateIPlatformActionListenerImplementor,
						__v => Callback = __v,
						__h => __h.OnCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetCallback,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => Callback = null,
						__h => __h.OnCompleteHandler -= value);
			}
		}

		public event EventHandler<global::CN.Sharesdk.Framework.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetCallback,
						__CreateIPlatformActionListenerImplementor,
						__v => Callback = __v,
						__h => __h.OnErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor___SetCallback,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => Callback = null,
						__h => __h.OnErrorHandler -= value);
			}
		}

		WeakReference weak_implementor___SetCallback;

		global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor __CreateIPlatformActionListenerImplementor ()
		{
			return new global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor (this);
		}
#endregion
	}
}
