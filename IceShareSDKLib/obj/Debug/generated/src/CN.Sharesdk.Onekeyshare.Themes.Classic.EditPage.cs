using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/EditPage", DoNotGenerateAcw=true)]
	public partial class EditPage : global::CN.Sharesdk.Onekeyshare.OnekeySharePage, global::Android.Text.ITextWatcher, global::Android.Views.View.IOnClickListener, global::Java.Lang.IRunnable {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='aivThumb']"
		[Register ("aivThumb")]
		protected global::Com.Mob.Tools.Gui.AsyncImageView AivThumb {
			get {
				const string __id = "aivThumb.Lcom/mob/tools/gui/AsyncImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "aivThumb.Lcom/mob/tools/gui/AsyncImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='etContent']"
		[Register ("etContent")]
		protected global::Android.Widget.EditText EtContent {
			get {
				const string __id = "etContent.Landroid/widget/EditText;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "etContent.Landroid/widget/EditText;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='llBottom']"
		[Register ("llBottom")]
		protected global::Android.Widget.LinearLayout LlBottom {
			get {
				const string __id = "llBottom.Landroid/widget/LinearLayout;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "llBottom.Landroid/widget/LinearLayout;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='llPage']"
		[Register ("llPage")]
		protected global::Android.Widget.LinearLayout LlPage {
			get {
				const string __id = "llPage.Landroid/widget/LinearLayout;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "llPage.Landroid/widget/LinearLayout;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='maxBodyHeight']"
		[Register ("maxBodyHeight")]
		protected int MaxBodyHeight {
			get {
				const string __id = "maxBodyHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxBodyHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='platform']"
		[Register ("platform")]
		protected global::CN.Sharesdk.Framework.Platform Platform {
			get {
				const string __id = "platform.Lcn/sharesdk/framework/Platform;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "platform.Lcn/sharesdk/framework/Platform;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='rlThumb']"
		[Register ("rlThumb")]
		protected global::Android.Widget.RelativeLayout RlThumb {
			get {
				const string __id = "rlThumb.Landroid/widget/RelativeLayout;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rlThumb.Landroid/widget/RelativeLayout;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='rlTitle']"
		[Register ("rlTitle")]
		protected global::Android.Widget.RelativeLayout RlTitle {
			get {
				const string __id = "rlTitle.Landroid/widget/RelativeLayout;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rlTitle.Landroid/widget/RelativeLayout;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='sp']"
		[Register ("sp")]
		protected global::CN.Sharesdk.Framework.Platform.ShareParams Sp {
			get {
				const string __id = "sp.Lcn/sharesdk/framework/Platform$ShareParams;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sp.Lcn/sharesdk/framework/Platform$ShareParams;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='svContent']"
		[Register ("svContent")]
		protected global::Android.Widget.ScrollView SvContent {
			get {
				const string __id = "svContent.Landroid/widget/ScrollView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ScrollView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "svContent.Landroid/widget/ScrollView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='thumb']"
		[Register ("thumb")]
		protected global::Android.Graphics.Bitmap Thumb {
			get {
				const string __id = "thumb.Landroid/graphics/Bitmap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "thumb.Landroid/graphics/Bitmap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='tvAt']"
		[Register ("tvAt")]
		protected global::Android.Widget.TextView TvAt {
			get {
				const string __id = "tvAt.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tvAt.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='tvCancel']"
		[Register ("tvCancel")]
		protected global::Android.Widget.TextView TvCancel {
			get {
				const string __id = "tvCancel.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tvCancel.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='tvShare']"
		[Register ("tvShare")]
		protected global::Android.Widget.TextView TvShare {
			get {
				const string __id = "tvShare.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tvShare.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='tvTextCouter']"
		[Register ("tvTextCouter")]
		protected global::Android.Widget.TextView TvTextCouter {
			get {
				const string __id = "tvTextCouter.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tvTextCouter.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/field[@name='xvRemove']"
		[Register ("xvRemove")]
		protected global::CN.Sharesdk.Onekeyshare.Themes.Classic.XView XvRemove {
			get {
				const string __id = "xvRemove.Lcn/sharesdk/onekeyshare/themes/classic/XView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.XView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "xvRemove.Lcn/sharesdk/onekeyshare/themes/classic/XView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/EditPage", typeof (EditPage));
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

		protected EditPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/constructor[@name='EditPage' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe EditPage (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_afterTextChanged_Landroid_text_Editable_;
#pragma warning disable 0169
		static Delegate GetAfterTextChanged_Landroid_text_Editable_Handler ()
		{
			if (cb_afterTextChanged_Landroid_text_Editable_ == null)
				cb_afterTextChanged_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AfterTextChanged_Landroid_text_Editable_);
			return cb_afterTextChanged_Landroid_text_Editable_;
		}

		static void n_AfterTextChanged_Landroid_text_Editable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Text.IEditable s = (global::Android.Text.IEditable)global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.AfterTextChanged (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='afterTextChanged' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("afterTextChanged", "(Landroid/text/Editable;)V", "GetAfterTextChanged_Landroid_text_Editable_Handler")]
		public virtual unsafe void AfterTextChanged (global::Android.Text.IEditable s)
		{
			const string __id = "afterTextChanged.(Landroid/text/Editable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_beforeTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
		static Delegate GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler ()
		{
			if (cb_beforeTextChanged_Ljava_lang_CharSequence_III == null)
				cb_beforeTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_BeforeTextChanged_Ljava_lang_CharSequence_III);
			return cb_beforeTextChanged_Ljava_lang_CharSequence_III;
		}

		static void n_BeforeTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int count, int after)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence s = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.BeforeTextChanged (s, start, count, after);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='beforeTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", "GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler")]
		public virtual unsafe void BeforeTextChanged (global::Java.Lang.ICharSequence s, int start, int count, int after)
		{
			const string __id = "beforeTextChanged.(Ljava/lang/CharSequence;III)V";
			IntPtr native_s = CharSequence.ToLocalJniHandle (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (count);
				__args [3] = new JniArgumentValue (after);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		public void BeforeTextChanged (string s, int start, int count, int after)
		{
			global::Java.Lang.String jls_s = s == null ? null : new global::Java.Lang.String (s);
			BeforeTextChanged (jls_s, start, count, after);
			jls_s?.Dispose ();
		}

		static Delegate cb_isShowAtUserLayout_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsShowAtUserLayout_Ljava_lang_String_Handler ()
		{
			if (cb_isShowAtUserLayout_Ljava_lang_String_ == null)
				cb_isShowAtUserLayout_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsShowAtUserLayout_Ljava_lang_String_);
			return cb_isShowAtUserLayout_Ljava_lang_String_;
		}

		static bool n_IsShowAtUserLayout_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platformName)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string platformName = JNIEnv.GetString (native_platformName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsShowAtUserLayout (platformName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='isShowAtUserLayout' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isShowAtUserLayout", "(Ljava/lang/String;)Z", "GetIsShowAtUserLayout_Ljava_lang_String_Handler")]
		protected virtual unsafe bool IsShowAtUserLayout (string platformName)
		{
			const string __id = "isShowAtUserLayout.(Ljava/lang/String;)Z";
			IntPtr native_platformName = JNIEnv.NewString (platformName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_platformName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_platformName);
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View v)
		{
			const string __id = "onClick.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
		static Delegate GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler ()
		{
			if (cb_onTextChanged_Ljava_lang_CharSequence_III == null)
				cb_onTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnTextChanged_Ljava_lang_CharSequence_III);
			return cb_onTextChanged_Ljava_lang_CharSequence_III;
		}

		static void n_OnTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int before, int count)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence s = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.OnTextChanged (s, start, before, count);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='onTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onTextChanged", "(Ljava/lang/CharSequence;III)V", "GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler")]
		public virtual unsafe void OnTextChanged (global::Java.Lang.ICharSequence s, int start, int before, int count)
		{
			const string __id = "onTextChanged.(Ljava/lang/CharSequence;III)V";
			IntPtr native_s = CharSequence.ToLocalJniHandle (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (before);
				__args [3] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		public void OnTextChanged (string s, int start, int before, int count)
		{
			global::Java.Lang.String jls_s = s == null ? null : new global::Java.Lang.String (s);
			OnTextChanged (jls_s, start, before, count);
			jls_s?.Dispose ();
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setPlatform_Lcn_sharesdk_framework_Platform_;
#pragma warning disable 0169
		static Delegate GetSetPlatform_Lcn_sharesdk_framework_Platform_Handler ()
		{
			if (cb_setPlatform_Lcn_sharesdk_framework_Platform_ == null)
				cb_setPlatform_Lcn_sharesdk_framework_Platform_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlatform_Lcn_sharesdk_framework_Platform_);
			return cb_setPlatform_Lcn_sharesdk_framework_Platform_;
		}

		static void n_SetPlatform_Lcn_sharesdk_framework_Platform_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platform)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform platform = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_platform, JniHandleOwnership.DoNotTransfer);
			__this.SetPlatform (platform);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='setPlatform' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform']]"
		[Register ("setPlatform", "(Lcn/sharesdk/framework/Platform;)V", "GetSetPlatform_Lcn_sharesdk_framework_Platform_Handler")]
		public virtual unsafe void SetPlatform (global::CN.Sharesdk.Framework.Platform platform)
		{
			const string __id = "setPlatform.(Lcn/sharesdk/framework/Platform;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShareParams_Lcn_sharesdk_framework_Platform_ShareParams_;
#pragma warning disable 0169
		static Delegate GetSetShareParams_Lcn_sharesdk_framework_Platform_ShareParams_Handler ()
		{
			if (cb_setShareParams_Lcn_sharesdk_framework_Platform_ShareParams_ == null)
				cb_setShareParams_Lcn_sharesdk_framework_Platform_ShareParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShareParams_Lcn_sharesdk_framework_Platform_ShareParams_);
			return cb_setShareParams_Lcn_sharesdk_framework_Platform_ShareParams_;
		}

		static void n_SetShareParams_Lcn_sharesdk_framework_Platform_ShareParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sp)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform.ShareParams sp = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.SetShareParams (sp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='EditPage']/method[@name='setShareParams' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("setShareParams", "(Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetSetShareParams_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		public virtual unsafe void SetShareParams (global::CN.Sharesdk.Framework.Platform.ShareParams sp)
		{
			const string __id = "setShareParams.(Lcn/sharesdk/framework/Platform$ShareParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
