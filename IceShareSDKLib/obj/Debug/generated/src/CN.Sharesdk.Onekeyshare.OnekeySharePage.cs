using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/OnekeySharePage", DoNotGenerateAcw=true)]
	public partial class OnekeySharePage : global::Com.Mob.Tools.FakeActivity {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/OnekeySharePage", typeof (OnekeySharePage));
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

		protected OnekeySharePage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/constructor[@name='OnekeySharePage' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe OnekeySharePage (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
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

		protected unsafe global::CN.Sharesdk.Framework.IPlatformActionListener Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcn/sharesdk/framework/PlatformActionListener;", "GetGetCallbackHandler")]
			get {
				const string __id = "getCallback.()Lcn/sharesdk/framework/PlatformActionListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::System.Collections.Generic.IList<global::CN.Sharesdk.Onekeyshare.CustomerLogo> CustomerLogos {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='getCustomerLogos' and count(parameter)=0]"
			[Register ("getCustomerLogos", "()Ljava/util/ArrayList;", "GetGetCustomerLogosHandler")]
			get {
				const string __id = "getCustomerLogos.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::CN.Sharesdk.Onekeyshare.CustomerLogo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback CustomizeCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='getCustomizeCallback' and count(parameter)=0]"
			[Register ("getCustomizeCallback", "()Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;", "GetGetCustomizeCallbackHandler")]
			get {
				const string __id = "getCustomizeCallback.()Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::System.Collections.Generic.IDictionary<string, string> HiddenPlatforms {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='getHiddenPlatforms' and count(parameter)=0]"
			[Register ("getHiddenPlatforms", "()Ljava/util/HashMap;", "GetGetHiddenPlatformsHandler")]
			get {
				const string __id = "getHiddenPlatforms.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe bool IsDialogMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='isDialogMode' and count(parameter)=0]"
			[Register ("isDialogMode", "()Z", "GetIsDialogModeHandler")]
			get {
				const string __id = "isDialogMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe bool IsDisableSSO {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='isDisableSSO' and count(parameter)=0]"
			[Register ("isDisableSSO", "()Z", "GetIsDisableSSOHandler")]
			get {
				const string __id = "isDisableSSO.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe bool IsSilent {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='isSilent' and count(parameter)=0]"
			[Register ("isSilent", "()Z", "GetIsSilentHandler")]
			get {
				const string __id = "isSilent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ShareParamsMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='getShareParamsMap' and count(parameter)=0]"
			[Register ("getShareParamsMap", "()Ljava/util/HashMap;", "GetGetShareParamsMapHandler")]
			get {
				const string __id = "getShareParamsMap.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='formateShareData' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform']]"
		[Register ("formateShareData", "(Lcn/sharesdk/framework/Platform;)Lcn/sharesdk/framework/Platform$ShareParams;", "")]
		protected unsafe global::CN.Sharesdk.Framework.Platform.ShareParams FormateShareData (global::CN.Sharesdk.Framework.Platform platform)
		{
			const string __id = "formateShareData.(Lcn/sharesdk/framework/Platform;)Lcn/sharesdk/framework/Platform$ShareParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='isUseClientToShare' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform']]"
		[Register ("isUseClientToShare", "(Lcn/sharesdk/framework/Platform;)Z", "")]
		protected unsafe bool IsUseClientToShare (global::CN.Sharesdk.Framework.Platform platform)
		{
			const string __id = "isUseClientToShare.(Lcn/sharesdk/framework/Platform;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeySharePage']/method[@name='shareSilently' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform']]"
		[Register ("shareSilently", "(Lcn/sharesdk/framework/Platform;)V", "")]
		protected unsafe void ShareSilently (global::CN.Sharesdk.Framework.Platform platform)
		{
			const string __id = "shareSilently.(Lcn/sharesdk/framework/Platform;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
