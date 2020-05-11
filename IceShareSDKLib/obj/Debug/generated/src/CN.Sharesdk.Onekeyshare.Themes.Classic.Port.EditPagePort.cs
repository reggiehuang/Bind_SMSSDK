using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic.Port {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.port']/class[@name='EditPagePort']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/port/EditPagePort", DoNotGenerateAcw=true)]
	public partial class EditPagePort : global::CN.Sharesdk.Onekeyshare.Themes.Classic.EditPage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/port/EditPagePort", typeof (EditPagePort));
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

		protected EditPagePort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.port']/class[@name='EditPagePort']/constructor[@name='EditPagePort' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe EditPagePort (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
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

	}
}
