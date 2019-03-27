using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Wechat.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']"
	[global::Android.Runtime.Register ("cn/sharesdk/wechat/utils/WechatResp", DoNotGenerateAcw=true)]
	public abstract partial class WechatResp : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/field[@name='f']"
		[Register ("f")]
		public int F {
			get {
				const string __id = "f.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "f.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/field[@name='g']"
		[Register ("g")]
		public string G {
			get {
				const string __id = "g.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "g.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/field[@name='h']"
		[Register ("h")]
		public string H {
			get {
				const string __id = "h.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "h.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		[Register ("cn/sharesdk/wechat/utils/WechatResp$ErrCode", DoNotGenerateAcw=true)]
		public abstract class ErrCode : Java.Lang.Object {

			internal ErrCode ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WechatResp.ErrCode']/field[@name='ERR_AUTH_DENIED']"
			[Register ("ERR_AUTH_DENIED")]
			public const int ErrAuthDenied = (int) -4;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WechatResp.ErrCode']/field[@name='ERR_COMM']"
			[Register ("ERR_COMM")]
			public const int ErrComm = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WechatResp.ErrCode']/field[@name='ERR_OK']"
			[Register ("ERR_OK")]
			public const int ErrOk = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WechatResp.ErrCode']/field[@name='ERR_SENT_FAILED']"
			[Register ("ERR_SENT_FAILED")]
			public const int ErrSentFailed = (int) -3;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WechatResp.ErrCode']/field[@name='ERR_UNSUPPORT']"
			[Register ("ERR_UNSUPPORT")]
			public const int ErrUnsupport = (int) -5;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/interface[@name='WechatResp.ErrCode']/field[@name='ERR_USER_CANCEL']"
			[Register ("ERR_USER_CANCEL")]
			public const int ErrUserCancel = (int) -2;
		}

		[Register ("cn/sharesdk/wechat/utils/WechatResp$ErrCode", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'ErrCode' type. This type will be removed in a future release.")]
		public abstract class ErrCodeConsts : ErrCode {

			private ErrCodeConsts ()
			{
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/wechat/utils/WechatResp", typeof (WechatResp));
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

		protected WechatResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/constructor[@name='WechatResp' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe WechatResp (global::Android.OS.Bundle paramBundle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Bundle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((paramBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramBundle).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_A);
			return cb_a;
		}

		static int n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Wechat.Utils.WechatResp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WechatResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "GetAHandler")]
		public abstract int A ();

		static Delegate cb_a_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_os_Bundle_Handler ()
		{
			if (cb_a_Landroid_os_Bundle_ == null)
				cb_a_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Landroid_os_Bundle_);
			return cb_a_Landroid_os_Bundle_;
		}

		static void n_A_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Wechat.Utils.WechatResp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WechatResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("a", "(Landroid/os/Bundle;)V", "GetA_Landroid_os_Bundle_Handler")]
		public virtual unsafe void A (global::Android.OS.Bundle p0)
		{
			const string __id = "a.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_b_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetB_Landroid_os_Bundle_Handler ()
		{
			if (cb_b_Landroid_os_Bundle_ == null)
				cb_b_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Landroid_os_Bundle_);
			return cb_b_Landroid_os_Bundle_;
		}

		static void n_B_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Wechat.Utils.WechatResp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WechatResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("b", "(Landroid/os/Bundle;)V", "GetB_Landroid_os_Bundle_Handler")]
		public virtual unsafe void B (global::Android.OS.Bundle p0)
		{
			const string __id = "b.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/sharesdk/wechat/utils/WechatResp", DoNotGenerateAcw=true)]
	internal partial class WechatRespInvoker : WechatResp {

		public WechatRespInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/sharesdk/wechat/utils/WechatResp", typeof (WechatRespInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatResp']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "GetAHandler")]
		public override unsafe int A ()
		{
			const string __id = "a.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

}
