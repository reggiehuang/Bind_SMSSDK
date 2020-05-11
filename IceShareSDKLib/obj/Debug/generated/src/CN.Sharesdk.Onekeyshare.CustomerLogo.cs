using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='CustomerLogo']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/CustomerLogo", DoNotGenerateAcw=true)]
	public partial class CustomerLogo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='CustomerLogo']/field[@name='label']"
		[Register ("label")]
		public string Label {
			get {
				const string __id = "label.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "label.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='CustomerLogo']/field[@name='listener']"
		[Register ("listener")]
		public global::Android.Views.View.IOnClickListener Listener {
			get {
				const string __id = "listener.Landroid/view/View$OnClickListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "listener.Landroid/view/View$OnClickListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='CustomerLogo']/field[@name='logo']"
		[Register ("logo")]
		public global::Android.Graphics.Bitmap Logo {
			get {
				const string __id = "logo.Landroid/graphics/Bitmap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "logo.Landroid/graphics/Bitmap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/CustomerLogo", typeof (CustomerLogo));
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

		protected CustomerLogo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='CustomerLogo']/constructor[@name='CustomerLogo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomerLogo ()
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
