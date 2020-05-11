using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/OnekeyShareThemeImpl", DoNotGenerateAcw=true)]
	public abstract partial class OnekeyShareThemeImpl : global::Java.Lang.Object, global::Android.OS.Handler.ICallback, global::CN.Sharesdk.Framework.IPlatformActionListener {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='callback']"
		[Register ("callback")]
		public global::CN.Sharesdk.Framework.IPlatformActionListener Callback {
			get {
				const string __id = "callback.Lcn/sharesdk/framework/PlatformActionListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "callback.Lcn/sharesdk/framework/PlatformActionListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				const string __id = "context.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "context.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='customerLogos']"
		[Register ("customerLogos")]
		protected global::System.Collections.IList CustomerLogos {
			get {
				const string __id = "customerLogos.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "customerLogos.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='customizeCallback']"
		[Register ("customizeCallback")]
		protected global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback CustomizeCallback {
			get {
				const string __id = "customizeCallback.Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "customizeCallback.Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='dialogMode']"
		[Register ("dialogMode")]
		protected bool DialogMode {
			get {
				const string __id = "dialogMode.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "dialogMode.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='hiddenPlatforms']"
		[Register ("hiddenPlatforms")]
		protected global::System.Collections.IDictionary HiddenPlatforms {
			get {
				const string __id = "hiddenPlatforms.Ljava/util/HashMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "hiddenPlatforms.Ljava/util/HashMap;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='shareParamsMap']"
		[Register ("shareParamsMap")]
		protected global::System.Collections.IDictionary ShareParamsMap {
			get {
				const string __id = "shareParamsMap.Ljava/util/HashMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shareParamsMap.Ljava/util/HashMap;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/field[@name='silent']"
		[Register ("silent")]
		protected bool Silent {
			get {
				const string __id = "silent.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "silent.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/OnekeyShareThemeImpl", typeof (OnekeyShareThemeImpl));
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

		protected OnekeyShareThemeImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/constructor[@name='OnekeyShareThemeImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OnekeyShareThemeImpl ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='disableSSO' and count(parameter)=0]"
		[Register ("disableSSO", "()V", "")]
		public unsafe void DisableSSO ()
		{
			const string __id = "disableSSO.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "")]
		public unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='onCancel' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int']]"
		[Register ("onCancel", "(Lcn/sharesdk/framework/Platform;I)V", "")]
		public unsafe void OnCancel (global::CN.Sharesdk.Framework.Platform platform, int action)
		{
			const string __id = "onCancel.(Lcn/sharesdk/framework/Platform;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				__args [1] = new JniArgumentValue (action);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onComplete", "(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V", "")]
		public unsafe void OnComplete (global::CN.Sharesdk.Framework.Platform platform, int action, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> res)
		{
			const string __id = "onComplete.(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V";
			IntPtr native_res = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (res);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				__args [1] = new JniArgumentValue (action);
				__args [2] = new JniArgumentValue (native_res);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_res);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V", "")]
		public unsafe void OnError (global::CN.Sharesdk.Framework.Platform platform, int action, global::Java.Lang.Throwable t)
		{
			const string __id = "onError.(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				__args [1] = new JniArgumentValue (action);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='setCustomerLogos' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;cn.sharesdk.onekeyshare.CustomerLogo&gt;']]"
		[Register ("setCustomerLogos", "(Ljava/util/ArrayList;)V", "")]
		public unsafe void SetCustomerLogos (global::System.Collections.Generic.IList<global::CN.Sharesdk.Onekeyshare.CustomerLogo> customerLogos)
		{
			const string __id = "setCustomerLogos.(Ljava/util/ArrayList;)V";
			IntPtr native_customerLogos = global::Android.Runtime.JavaList<global::CN.Sharesdk.Onekeyshare.CustomerLogo>.ToLocalJniHandle (customerLogos);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_customerLogos);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_customerLogos);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='setDialogMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDialogMode", "(Z)V", "")]
		public unsafe void SetDialogMode (bool dialogMode)
		{
			const string __id = "setDialogMode.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dialogMode);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='setHiddenPlatforms' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setHiddenPlatforms", "(Ljava/util/HashMap;)V", "")]
		public unsafe void SetHiddenPlatforms (global::System.Collections.Generic.IDictionary<string, string> hiddenPlatforms)
		{
			const string __id = "setHiddenPlatforms.(Ljava/util/HashMap;)V";
			IntPtr native_hiddenPlatforms = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (hiddenPlatforms);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hiddenPlatforms);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hiddenPlatforms);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='setPlatformActionListener' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.PlatformActionListener']]"
		[Register ("setPlatformActionListener", "(Lcn/sharesdk/framework/PlatformActionListener;)V", "")]
		public unsafe void SetPlatformActionListener (global::CN.Sharesdk.Framework.IPlatformActionListener @callback)
		{
			const string __id = "setPlatformActionListener.(Lcn/sharesdk/framework/PlatformActionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='setShareContentCustomizeCallback' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.ShareContentCustomizeCallback']]"
		[Register ("setShareContentCustomizeCallback", "(Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;)V", "")]
		public unsafe void SetShareContentCustomizeCallback (global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback customizeCallback)
		{
			const string __id = "setShareContentCustomizeCallback.(Lcn/sharesdk/onekeyshare/ShareContentCustomizeCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((customizeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customizeCallback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='setShareParamsMap' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setShareParamsMap", "(Ljava/util/HashMap;)V", "")]
		public unsafe void SetShareParamsMap (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> shareParamsMap)
		{
			const string __id = "setShareParamsMap.(Ljava/util/HashMap;)V";
			IntPtr native_shareParamsMap = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (shareParamsMap);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_shareParamsMap);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_shareParamsMap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='setSilent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSilent", "(Z)V", "")]
		public unsafe void SetSilent (bool silent)
		{
			const string __id = "setSilent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (silent);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("show", "(Landroid/content/Context;)V", "")]
		public unsafe void Show (global::Android.Content.Context context)
		{
			const string __id = "show.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_;
#pragma warning disable 0169
		static Delegate GetShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_Handler ()
		{
			if (cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ == null)
				cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_);
			return cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_;
		}

		static void n_ShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform p1 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform.ShareParams p2 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShowEditPage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='showEditPage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.sharesdk.framework.Platform'] and parameter[3][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("showEditPage", "(Landroid/content/Context;Lcn/sharesdk/framework/Platform;Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		protected abstract void ShowEditPage (global::Android.Content.Context p0, global::CN.Sharesdk.Framework.Platform p1, global::CN.Sharesdk.Framework.Platform.ShareParams p2);

		static Delegate cb_showPlatformPage_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShowPlatformPage_Landroid_content_Context_Handler ()
		{
			if (cb_showPlatformPage_Landroid_content_Context_ == null)
				cb_showPlatformPage_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowPlatformPage_Landroid_content_Context_);
			return cb_showPlatformPage_Landroid_content_Context_;
		}

		static void n_ShowPlatformPage_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowPlatformPage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='showPlatformPage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("showPlatformPage", "(Landroid/content/Context;)V", "GetShowPlatformPage_Landroid_content_Context_Handler")]
		protected abstract void ShowPlatformPage (global::Android.Content.Context p0);

#region "Event implementation for CN.Sharesdk.Framework.IPlatformActionListener"
		public event EventHandler<global::CN.Sharesdk.Framework.CancelEventArgs> Cancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor_SetPlatformActionListener,
						__CreateIPlatformActionListenerImplementor,
						SetPlatformActionListener,
						__h => __h.OnCancelHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor_SetPlatformActionListener,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => SetPlatformActionListener (null),
						__h => __h.OnCancelHandler -= value);
			}
		}

		public event EventHandler<global::CN.Sharesdk.Framework.CompleteEventArgs> Complete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor_SetPlatformActionListener,
						__CreateIPlatformActionListenerImplementor,
						SetPlatformActionListener,
						__h => __h.OnCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor_SetPlatformActionListener,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => SetPlatformActionListener (null),
						__h => __h.OnCompleteHandler -= value);
			}
		}

		public event EventHandler<global::CN.Sharesdk.Framework.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor_SetPlatformActionListener,
						__CreateIPlatformActionListenerImplementor,
						SetPlatformActionListener,
						__h => __h.OnErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Sharesdk.Framework.IPlatformActionListener, global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor>(
						ref weak_implementor_SetPlatformActionListener,
						global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor.__IsEmpty,
						__v => SetPlatformActionListener (null),
						__h => __h.OnErrorHandler -= value);
			}
		}

		WeakReference weak_implementor_SetPlatformActionListener;

		global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor __CreateIPlatformActionListenerImplementor ()
		{
			return new global::CN.Sharesdk.Framework.IPlatformActionListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/OnekeyShareThemeImpl", DoNotGenerateAcw=true)]
	internal partial class OnekeyShareThemeImplInvoker : OnekeyShareThemeImpl {

		public OnekeyShareThemeImplInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/OnekeyShareThemeImpl", typeof (OnekeyShareThemeImplInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='showEditPage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.sharesdk.framework.Platform'] and parameter[3][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("showEditPage", "(Landroid/content/Context;Lcn/sharesdk/framework/Platform;Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		protected override unsafe void ShowEditPage (global::Android.Content.Context p0, global::CN.Sharesdk.Framework.Platform p1, global::CN.Sharesdk.Framework.Platform.ShareParams p2)
		{
			const string __id = "showEditPage.(Landroid/content/Context;Lcn/sharesdk/framework/Platform;Lcn/sharesdk/framework/Platform$ShareParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/class[@name='OnekeyShareThemeImpl']/method[@name='showPlatformPage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("showPlatformPage", "(Landroid/content/Context;)V", "GetShowPlatformPage_Landroid_content_Context_Handler")]
		protected override unsafe void ShowPlatformPage (global::Android.Content.Context p0)
		{
			const string __id = "showPlatformPage.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
