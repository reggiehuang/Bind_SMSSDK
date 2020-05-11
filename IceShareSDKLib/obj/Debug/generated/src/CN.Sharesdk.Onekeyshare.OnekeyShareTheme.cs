using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareTheme']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/OnekeyShareTheme", DoNotGenerateAcw=true)]
	public sealed partial class OnekeyShareTheme : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareTheme']/field[@name='CLASSIC']"
		[Register ("CLASSIC")]
		public static global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme Classic {
			get {
				const string __id = "CLASSIC.Lcn/sharesdk/onekeyshare/OnekeyShareTheme;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/OnekeyShareTheme", typeof (OnekeyShareTheme));
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

		internal OnekeyShareTheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl Impl {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareTheme']/method[@name='getImpl' and count(parameter)=0]"
			[Register ("getImpl", "()Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;", "")]
			get {
				const string __id = "getImpl.()Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareTheme']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareTheme']/method[@name='fromValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromValue", "(I)Lcn/sharesdk/onekeyshare/OnekeyShareTheme;", "")]
		public static unsafe global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme FromValue (int value)
		{
			const string __id = "fromValue.(I)Lcn/sharesdk/onekeyshare/OnekeyShareTheme;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareTheme']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcn/sharesdk/onekeyshare/OnekeyShareTheme;", "")]
		public static unsafe global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcn/sharesdk/onekeyshare/OnekeyShareTheme;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareTheme']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcn/sharesdk/onekeyshare/OnekeyShareTheme;", "")]
		public static unsafe global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme[] Values ()
		{
			const string __id = "values.()[Lcn/sharesdk/onekeyshare/OnekeyShareTheme;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::CN.Sharesdk.Onekeyshare.OnekeyShareTheme));
			} finally {
			}
		}

	}
}
