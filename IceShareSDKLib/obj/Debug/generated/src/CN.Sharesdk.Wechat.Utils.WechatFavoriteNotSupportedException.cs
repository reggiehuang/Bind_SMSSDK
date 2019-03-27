using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Wechat.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatFavoriteNotSupportedException']"
	[global::Android.Runtime.Register ("cn/sharesdk/wechat/utils/WechatFavoriteNotSupportedException", DoNotGenerateAcw=true)]
	public partial class WechatFavoriteNotSupportedException : global::Java.Lang.Exception {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/wechat/utils/WechatFavoriteNotSupportedException", typeof (WechatFavoriteNotSupportedException));
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

		protected WechatFavoriteNotSupportedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.wechat.utils']/class[@name='WechatFavoriteNotSupportedException']/constructor[@name='WechatFavoriteNotSupportedException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WechatFavoriteNotSupportedException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
