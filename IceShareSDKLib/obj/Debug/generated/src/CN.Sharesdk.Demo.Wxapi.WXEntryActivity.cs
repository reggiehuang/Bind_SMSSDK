using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Demo.Wxapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.demo.wxapi']/class[@name='WXEntryActivity']"
	[global::Android.Runtime.Register ("cn/sharesdk/demo/wxapi/WXEntryActivity", DoNotGenerateAcw=true)]
	public partial class WXEntryActivity : global::CN.Sharesdk.Wechat.Utils.WechatHandlerActivity {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/demo/wxapi/WXEntryActivity", typeof (WXEntryActivity));
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

		protected WXEntryActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.demo.wxapi']/class[@name='WXEntryActivity']/constructor[@name='WXEntryActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WXEntryActivity ()
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

	}
}
