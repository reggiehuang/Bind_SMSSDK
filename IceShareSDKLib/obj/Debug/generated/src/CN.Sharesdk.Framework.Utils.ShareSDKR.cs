using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/utils/ShareSDKR", DoNotGenerateAcw=true)]
	public partial class ShareSDKR : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/framework/utils/ShareSDKR", typeof (ShareSDKR));
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

		protected ShareSDKR (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/constructor[@name='ShareSDKR' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShareSDKR ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getAnimRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAnimRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetAnimRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getAnimRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getBitmapRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBitmapRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetBitmapRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getBitmapRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getColorRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getColorRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetColorRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getColorRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getIdRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIdRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetIdRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getIdRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getLayoutRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLayoutRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetLayoutRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getLayoutRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getPluralsRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPluralsRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetPluralsRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getPluralsRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getRawRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRawRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetRawRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getRawRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getResId' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getResId", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int GetResId (global::Android.Content.Context context, string resType, string resName)
		{
			const string __id = "getResId.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_resType = JNIEnv.NewString (resType);
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resType);
				__args [2] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resType);
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getStringArrayRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringArrayRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStringArrayRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getStringArrayRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getStringRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStringRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getStringRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/class[@name='ShareSDKR']/method[@name='getStyleRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStyleRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStyleRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getStyleRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

	}
}
