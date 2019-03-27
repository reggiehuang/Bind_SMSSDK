using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Wechat.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatHandlerActivity']"
	[global::Android.Runtime.Register ("cn/sharesdk/wechat/utils/WechatHandlerActivity", DoNotGenerateAcw=true)]
	public partial class WechatHandlerActivity : global::Android.App.Activity {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/wechat/utils/WechatHandlerActivity", typeof (WechatHandlerActivity));
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

		protected WechatHandlerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatHandlerActivity']/constructor[@name='WechatHandlerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WechatHandlerActivity ()
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

		static Delegate cb_onGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_;
#pragma warning disable 0169
		static Delegate GetOnGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_Handler ()
		{
			if (cb_onGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_ == null)
				cb_onGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_);
			return cb_onGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_;
		}

		static void n_OnGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::CN.Sharesdk.Wechat.Utils.WechatHandlerActivity __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WechatHandlerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Wechat.Utils.WXMediaMessage msg = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXMediaMessage> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnGetMessageFromWXReq (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatHandlerActivity']/method[@name='onGetMessageFromWXReq' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.wechat.utils.WXMediaMessage']]"
		[Register ("onGetMessageFromWXReq", "(Lcn/sharesdk/wechat/utils/WXMediaMessage;)V", "GetOnGetMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_Handler")]
		public virtual unsafe void OnGetMessageFromWXReq (global::CN.Sharesdk.Wechat.Utils.WXMediaMessage msg)
		{
			const string __id = "onGetMessageFromWXReq.(Lcn/sharesdk/wechat/utils/WXMediaMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_;
#pragma warning disable 0169
		static Delegate GetOnShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_Handler ()
		{
			if (cb_onShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_ == null)
				cb_onShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_);
			return cb_onShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_;
		}

		static void n_OnShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::CN.Sharesdk.Wechat.Utils.WechatHandlerActivity __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WechatHandlerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Wechat.Utils.WXMediaMessage msg = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Wechat.Utils.WXMediaMessage> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnShowMessageFromWXReq (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatHandlerActivity']/method[@name='onShowMessageFromWXReq' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.wechat.utils.WXMediaMessage']]"
		[Register ("onShowMessageFromWXReq", "(Lcn/sharesdk/wechat/utils/WXMediaMessage;)V", "GetOnShowMessageFromWXReq_Lcn_sharesdk_wechat_utils_WXMediaMessage_Handler")]
		public virtual unsafe void OnShowMessageFromWXReq (global::CN.Sharesdk.Wechat.Utils.WXMediaMessage msg)
		{
			const string __id = "onShowMessageFromWXReq.(Lcn/sharesdk/wechat/utils/WXMediaMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
