using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']"
	[global::Android.Runtime.Register ("com/mob/MobSDK", DoNotGenerateAcw=true)]
	public partial class MobSDK : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/field[@name='SDK_VERSION_CODE']"
		[Register ("SDK_VERSION_CODE")]
		public static int SdkVersionCode {
			get {
				const string __id = "SDK_VERSION_CODE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/field[@name='SDK_VERSION_NAME']"
		[Register ("SDK_VERSION_NAME")]
		public static string SdkVersionName {
			get {
				const string __id = "SDK_VERSION_NAME.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/MobSDK", typeof (MobSDK));
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

		protected MobSDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/constructor[@name='MobSDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobSDK ()
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

		public static unsafe string AppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='getAppSecret' and count(parameter)=0]"
			[Register ("getAppSecret", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAppSecret.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='getAppkey' and count(parameter)=0]"
			[Register ("getAppkey", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAppkey.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Mob.Commons.InternationalDomain Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Lcom/mob/commons/InternationalDomain;", "")]
			get {
				const string __id = "getDomain.()Lcom/mob/commons/InternationalDomain;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.InternationalDomain> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='setDomain' and count(parameter)=1 and parameter[1][@type='com.mob.commons.InternationalDomain']]"
			[Register ("setDomain", "(Lcom/mob/commons/InternationalDomain;)V", "")]
			set {
				const string __id = "setDomain.(Lcom/mob/commons/InternationalDomain;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool IsMob {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='isMob' and count(parameter)=0]"
			[Register ("isMob", "()Z", "")]
			get {
				const string __id = "isMob.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='addUserWatcher' and count(parameter)=1 and parameter[1][@type='com.mob.MobUser.UserWatcher']]"
		[Register ("addUserWatcher", "(Lcom/mob/MobUser$UserWatcher;)V", "")]
		public static unsafe void AddUserWatcher (global::Com.Mob.MobUser.IUserWatcher p0)
		{
			const string __id = "addUserWatcher.(Lcom/mob/MobUser$UserWatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='clearUser' and count(parameter)=0]"
		[Register ("clearUser", "()V", "")]
		public static unsafe void ClearUser ()
		{
			const string __id = "clearUser.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='exchangeIds' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("exchangeIds", "([Ljava/lang/String;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> ExchangeIds (string[] p0)
		{
			const string __id = "exchangeIds.([Ljava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='getUser' and count(parameter)=1 and parameter[1][@type='com.mob.MobUser.OnUserGotListener']]"
		[Register ("getUser", "(Lcom/mob/MobUser$OnUserGotListener;)V", "")]
		public static unsafe void GetUser (global::Com.Mob.MobUser.IOnUserGotListener p0)
		{
			const string __id = "getUser.(Lcom/mob/MobUser$OnUserGotListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0, string p1)
		{
			const string __id = "init.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "init.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='removeUserWatcher' and count(parameter)=1 and parameter[1][@type='com.mob.MobUser.UserWatcher']]"
		[Register ("removeUserWatcher", "(Lcom/mob/MobUser$UserWatcher;)V", "")]
		public static unsafe void RemoveUserWatcher (global::Com.Mob.MobUser.IUserWatcher p0)
		{
			const string __id = "removeUserWatcher.(Lcom/mob/MobUser$UserWatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='setUser' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setUser", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V", "")]
		public static unsafe void SetUser (string p0, string p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
		{
			const string __id = "setUser.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobSDK']/method[@name='setUser' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[5][@type='java.lang.String']]"
		[Register ("setUser", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)V", "")]
		public static unsafe void SetUser (string p0, string p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3, string p4)
		{
			const string __id = "setUser.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
