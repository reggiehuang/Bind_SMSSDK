using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/network/NetworkHelper", DoNotGenerateAcw=true)]
	public partial class NetworkHelper : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/field[@name='connectionTimeout']"
		[Register ("connectionTimeout")]
		public static int ConnectionTimeout {
			get {
				const string __id = "connectionTimeout.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "connectionTimeout.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/field[@name='readTimout']"
		[Register ("readTimout")]
		public static int ReadTimout {
			get {
				const string __id = "readTimout.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "readTimout.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.NetworkTimeOut']"
		[global::Android.Runtime.Register ("com/mob/tools/network/NetworkHelper$NetworkTimeOut", DoNotGenerateAcw=true)]
		public partial class NetworkTimeOut : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.NetworkTimeOut']/field[@name='connectionTimeout']"
			[Register ("connectionTimeout")]
			public int ConnectionTimeout {
				get {
					const string __id = "connectionTimeout.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "connectionTimeout.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.NetworkTimeOut']/field[@name='readTimout']"
			[Register ("readTimout")]
			public int ReadTimout {
				get {
					const string __id = "readTimout.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "readTimout.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/NetworkHelper$NetworkTimeOut", typeof (NetworkTimeOut));
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

			protected NetworkTimeOut (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.NetworkTimeOut']/constructor[@name='NetworkHelper.NetworkTimeOut' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe NetworkTimeOut ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.SimpleX509TrustManager']"
		[global::Android.Runtime.Register ("com/mob/tools/network/NetworkHelper$SimpleX509TrustManager", DoNotGenerateAcw=true)]
		public sealed partial class SimpleX509TrustManager : global::Java.Lang.Object, global::Javax.Net.Ssl.IX509TrustManager {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/NetworkHelper$SimpleX509TrustManager", typeof (SimpleX509TrustManager));
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

			internal SimpleX509TrustManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.SimpleX509TrustManager']/constructor[@name='NetworkHelper.SimpleX509TrustManager' and count(parameter)=1 and parameter[1][@type='java.security.KeyStore']]"
			[Register (".ctor", "(Ljava/security/KeyStore;)V", "")]
			public unsafe SimpleX509TrustManager (global::Java.Security.KeyStore keystore)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/security/KeyStore;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((keystore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keystore).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.SimpleX509TrustManager']/method[@name='checkClientTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "")]
			public unsafe void CheckClientTrusted (global::Java.Security.Cert.X509Certificate[] certificates, string authType)
			{
				const string __id = "checkClientTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V";
				IntPtr native_certificates = JNIEnv.NewArray (certificates);
				IntPtr native_authType = JNIEnv.NewString (authType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_certificates);
					__args [1] = new JniArgumentValue (native_authType);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (certificates != null) {
						JNIEnv.CopyArray (native_certificates, certificates);
						JNIEnv.DeleteLocalRef (native_certificates);
					}
					JNIEnv.DeleteLocalRef (native_authType);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.SimpleX509TrustManager']/method[@name='checkServerTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "")]
			public unsafe void CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] certificates, string authType)
			{
				const string __id = "checkServerTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V";
				IntPtr native_certificates = JNIEnv.NewArray (certificates);
				IntPtr native_authType = JNIEnv.NewString (authType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_certificates);
					__args [1] = new JniArgumentValue (native_authType);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (certificates != null) {
						JNIEnv.CopyArray (native_certificates, certificates);
						JNIEnv.DeleteLocalRef (native_certificates);
					}
					JNIEnv.DeleteLocalRef (native_authType);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper.SimpleX509TrustManager']/method[@name='getAcceptedIssuers' and count(parameter)=0]"
			[Register ("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", "")]
			public unsafe global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers ()
			{
				const string __id = "getAcceptedIssuers.()[Ljava/security/cert/X509Certificate;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/NetworkHelper", typeof (NetworkHelper));
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

		protected NetworkHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/constructor[@name='NetworkHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkHelper ()
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

		public static unsafe bool FollowRedirects {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='getFollowRedirects' and count(parameter)=0]"
			[Register ("getFollowRedirects", "()Z", "GetGetFollowRedirectsHandler")]
			get {
				const string __id = "getFollowRedirects.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='setFollowRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFollowRedirects", "(Z)V", "GetSetFollowRedirects_ZHandler")]
			set {
				const string __id = "setFollowRedirects.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInstanceFollowRedirects;
#pragma warning disable 0169
		static Delegate GetGetInstanceFollowRedirectsHandler ()
		{
			if (cb_getInstanceFollowRedirects == null)
				cb_getInstanceFollowRedirects = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetInstanceFollowRedirects);
			return cb_getInstanceFollowRedirects;
		}

		static bool n_GetInstanceFollowRedirects (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InstanceFollowRedirects;
		}
#pragma warning restore 0169

		static Delegate cb_setInstanceFollowRedirects_Z;
#pragma warning disable 0169
		static Delegate GetSetInstanceFollowRedirects_ZHandler ()
		{
			if (cb_setInstanceFollowRedirects_Z == null)
				cb_setInstanceFollowRedirects_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInstanceFollowRedirects_Z);
			return cb_setInstanceFollowRedirects_Z;
		}

		static void n_SetInstanceFollowRedirects_Z (IntPtr jnienv, IntPtr native__this, bool followRedirects)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InstanceFollowRedirects = followRedirects;
		}
#pragma warning restore 0169

		public virtual unsafe bool InstanceFollowRedirects {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='getInstanceFollowRedirects' and count(parameter)=0]"
			[Register ("getInstanceFollowRedirects", "()Z", "GetGetInstanceFollowRedirectsHandler")]
			get {
				const string __id = "getInstanceFollowRedirects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='setInstanceFollowRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInstanceFollowRedirects", "(Z)V", "GetSetInstanceFollowRedirects_ZHandler")]
			set {
				const string __id = "setInstanceFollowRedirects.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetDownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_DownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_DownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url, IntPtr native_cacheFolder, bool skipIfCached, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string cacheFolder = JNIEnv.GetString (native_cacheFolder, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DownloadCache (context, url, cacheFolder, skipIfCached, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='downloadCache' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("downloadCache", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZLcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetDownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string DownloadCache (global::Android.Content.Context context, string url, string cacheFolder, bool skipIfCached, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "downloadCache.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZLcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_cacheFolder = JNIEnv.NewString (cacheFolder);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue (native_cacheFolder);
				__args [3] = new JniArgumentValue (skipIfCached);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_cacheFolder);
			}
		}

		static Delegate cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_;
#pragma warning disable 0169
		static Delegate GetDownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_Handler ()
		{
			if (cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_ == null)
				cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_DownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_);
			return cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_;
		}

		static IntPtr n_DownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url, IntPtr native_cacheFolder, bool skipIfCached, IntPtr native_timeout, IntPtr native_downloadListener)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string cacheFolder = JNIEnv.GetString (native_cacheFolder, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.FileDownloadListener downloadListener = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FileDownloadListener> (native_downloadListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DownloadCache (context, url, cacheFolder, skipIfCached, timeout, downloadListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='downloadCache' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut'] and parameter[6][@type='com.mob.tools.network.FileDownloadListener']]"
		[Register ("downloadCache", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZLcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/FileDownloadListener;)Ljava/lang/String;", "GetDownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZLcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_FileDownloadListener_Handler")]
		public virtual unsafe string DownloadCache (global::Android.Content.Context context, string url, string cacheFolder, bool skipIfCached, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout, global::Com.Mob.Tools.Network.FileDownloadListener downloadListener)
		{
			const string __id = "downloadCache.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZLcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/FileDownloadListener;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_cacheFolder = JNIEnv.NewString (cacheFolder);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue (native_cacheFolder);
				__args [3] = new JniArgumentValue (skipIfCached);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				__args [5] = new JniArgumentValue ((downloadListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downloadListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_cacheFolder);
			}
		}

		static Delegate cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetGetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_GetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, IntPtr native_headers, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.GetHttpPostResponse (url, values, file, headers, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='getHttpPostResponse' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[6][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("getHttpPostResponse", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetGetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void GetHttpPostResponse (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "getHttpPostResponse.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [5] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_headers, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpGet (url, values, headers, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpGet' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpGet", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpGet (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpGet.(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_headers);
				__args [3] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, IntPtr native_headers, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (__this.HttpHead (url, values, file, headers, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpHead' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpHead", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/util/ArrayList;", "GetHttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> HttpHead (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpHead.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/util/ArrayList;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_HttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, long offset, IntPtr native_headers, IntPtr native_listener, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IOnReadListener listener = (global::Com.Mob.Tools.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IOnReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.HttpPatch (url, values, file, offset, headers, listener, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPatch' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='long'] and parameter[5][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[6][@type='com.mob.tools.network.OnReadListener'] and parameter[7][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[8][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPatch", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;JLjava/util/ArrayList;Lcom/mob/tools/network/OnReadListener;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetHttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void HttpPatch (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, long offset, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.IOnReadListener listener, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPatch.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;JLjava/util/ArrayList;Lcom/mob/tools/network/OnReadListener;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (offset);
				__args [4] = new JniArgumentValue (native_headers);
				__args [5] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [6] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [7] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_HttpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, long offset, IntPtr native_headers, IntPtr native_listener, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IOnReadListener listener = (global::Com.Mob.Tools.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IOnReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.HttpPatchImpl23 (url, values, file, offset, headers, listener, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPatchImpl23' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='long'] and parameter[5][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[6][@type='com.mob.tools.network.OnReadListener'] and parameter[7][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[8][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPatchImpl23", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;JLjava/util/ArrayList;Lcom/mob/tools/network/OnReadListener;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetHttpPatchImpl23_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_JLjava_util_ArrayList_Lcom_mob_tools_network_OnReadListener_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void HttpPatchImpl23 (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, long offset, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.IOnReadListener listener, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPatchImpl23.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;JLjava/util/ArrayList;Lcom/mob/tools/network/OnReadListener;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (offset);
				__args [4] = new JniArgumentValue (native_headers);
				__args [5] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [6] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [7] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_data, IntPtr native_headers, int chunkLength, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.HttpPost (url, values, data, headers, chunkLength, @callback, timeout);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='int'] and parameter[6][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[7][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;[BLjava/util/ArrayList;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void HttpPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, byte[] data, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, int chunkLength, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPost.(Ljava/lang/String;Ljava/util/ArrayList;[BLjava/util/ArrayList;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_data);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue (chunkLength);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [6] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, IntPtr native_headers, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPost (url, values, file, headers, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPost.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, IntPtr native_headers, int chunkLength, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPost (url, values, file, headers, chunkLength, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='int'] and parameter[6][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, int chunkLength, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPost.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue (chunkLength);
				__args [5] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, int chunkLength, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.HttpPost (url, headers, chunkLength, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='int'] and parameter[4][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void HttpPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, int chunkLength, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPost.(Ljava/lang/String;Ljava/util/ArrayList;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue (chunkLength);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, int chunkLength, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPost (url, headers, chunkLength, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='int'] and parameter[4][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, int chunkLength, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPost.(Ljava/lang/String;Ljava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue (chunkLength);
				__args [3] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_files, IntPtr native_headers, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_files, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.HttpPost (url, values, files, headers, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[6][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void HttpPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> files, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPost.(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (files);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_files);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [5] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_files);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_files, IntPtr native_headers, int chunkLength, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_files, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.HttpPost (url, values, files, headers, chunkLength, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='int'] and parameter[6][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[7][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void HttpPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> files, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, int chunkLength, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPost.(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (files);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_files);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue (chunkLength);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [6] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_files);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_files, IntPtr native_headers, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_files, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPostFiles (url, values, files, headers, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPostFiles' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPostFiles", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpPostFiles (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> files, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPostFiles.(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (files);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_files);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_files);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_files, IntPtr native_headers, int chunkLength, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_files, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPostFiles (url, values, files, headers, chunkLength, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPostFiles' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='int'] and parameter[6][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPostFiles", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpPostFiles (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> files, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, int chunkLength, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPostFiles.(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_files = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (files);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_files);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue (chunkLength);
				__args [5] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_files);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HttpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_data, IntPtr native_headers, int chunkLength, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPostFilesChecked (url, values, data, headers, chunkLength, timeout));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPostFilesChecked' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='int'] and parameter[6][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPostFilesChecked", "(Ljava/lang/String;Ljava/util/ArrayList;[BLjava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpPostFilesChecked_Ljava_lang_String_Ljava_util_ArrayList_arrayBLjava_util_ArrayList_ILcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpPostFilesChecked (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, byte[] data, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, int chunkLength, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPostFilesChecked.(Ljava/lang/String;Ljava/util/ArrayList;[BLjava/util/ArrayList;ILcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_data);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue (chunkLength);
				__args [5] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetHttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_HttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, IntPtr native_headers, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPut (url, values, file, headers, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPut' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("httpPut", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetHttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string HttpPut (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "httpPut.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_;
#pragma warning disable 0169
		static Delegate GetHttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_Handler ()
		{
			if (cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_ == null)
				cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_);
			return cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_;
		}

		static IntPtr n_HttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_file, IntPtr native_headers, IntPtr native_timeout, IntPtr native_listener)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.KVPair file = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.KVPair> (native_file, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IOnReadListener listener = (global::Com.Mob.Tools.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IOnReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPut (url, values, file, headers, timeout, listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='httpPut' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut'] and parameter[6][@type='com.mob.tools.network.OnReadListener']]"
		[Register ("httpPut", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/OnReadListener;)Ljava/lang/String;", "GetHttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_KVPair_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_OnReadListener_Handler")]
		public virtual unsafe string HttpPut (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::Com.Mob.Tools.Network.KVPair file, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout, global::Com.Mob.Tools.Network.IOnReadListener listener)
		{
			const string __id = "httpPut.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/KVPair;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/OnReadListener;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [3] = new JniArgumentValue (native_headers);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				__args [5] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetJsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_JsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static IntPtr n_JsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_headers, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.JsonPost (url, values, headers, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='jsonPost' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("jsonPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;", "GetJsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe string JsonPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "jsonPost.(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_headers);
				__args [3] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_;
#pragma warning disable 0169
		static Delegate GetJsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_Handler ()
		{
			if (cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_ == null)
				cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_JsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_);
			return cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_;
		}

		static void n_JsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_headers, IntPtr native_timeout, IntPtr native__callback)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.JsonPost (url, values, headers, timeout, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='jsonPost' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut'] and parameter[5][@type='com.mob.tools.network.HttpResponseCallback']]"
		[Register ("jsonPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/HttpResponseCallback;)V", "GetJsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_Handler")]
		public virtual unsafe void JsonPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback)
		{
			const string __id = "jsonPost.(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/HttpResponseCallback;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_headers);
				__args [3] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_jsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_;
#pragma warning disable 0169
		static Delegate GetJsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_Handler ()
		{
			if (cb_jsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_ == null)
				cb_jsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_JsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_);
			return cb_jsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_;
		}

		static void n_JsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_values, IntPtr native_headers, IntPtr native_timeout, IntPtr native__callback)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.JsonPost (url, values, headers, timeout, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='jsonPost' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut'] and parameter[5][@type='com.mob.tools.network.HttpResponseCallback']]"
		[Register ("jsonPost", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/HttpResponseCallback;)V", "GetJsonPost_Ljava_lang_String_Ljava_util_HashMap_Ljava_util_ArrayList_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Lcom_mob_tools_network_HttpResponseCallback_Handler")]
		public virtual unsafe void JsonPost (string url, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> values, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback)
		{
			const string __id = "jsonPost.(Ljava/lang/String;Ljava/util/HashMap;Ljava/util/ArrayList;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;Lcom/mob/tools/network/HttpResponseCallback;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_values = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (values);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_values);
				__args [2] = new JniArgumentValue (native_headers);
				__args [3] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetRawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_RawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.RawGet (url, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='rawGet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[3][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("rawGet", "(Ljava/lang/String;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetRawGet_Ljava_lang_String_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void RawGet (string url, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "rawGet.(Ljava/lang/String;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetRawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_rawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_RawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IRawNetworkCallback @callback = (global::Com.Mob.Tools.Network.IRawNetworkCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IRawNetworkCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.RawGet (url, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='rawGet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.network.RawNetworkCallback'] and parameter[3][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("rawGet", "(Ljava/lang/String;Lcom/mob/tools/network/RawNetworkCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetRawGet_Ljava_lang_String_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void RawGet (string url, global::Com.Mob.Tools.Network.IRawNetworkCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "rawGet.(Ljava/lang/String;Lcom/mob/tools/network/RawNetworkCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetRawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_RawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.RawGet (url, headers, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='rawGet' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[4][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("rawGet", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetRawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void RawGet (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "rawGet.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetRawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_rawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_RawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IRawNetworkCallback @callback = (global::Com.Mob.Tools.Network.IRawNetworkCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IRawNetworkCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.RawGet (url, headers, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='rawGet' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.RawNetworkCallback'] and parameter[4][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("rawGet", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/RawNetworkCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetRawGet_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void RawGet (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.IRawNetworkCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "rawGet.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/RawNetworkCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, IntPtr native_data, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.HTTPPart data = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.RawPost (url, headers, data, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='rawPost' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.HTTPPart'] and parameter[4][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HTTPPart;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void RawPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.HTTPPart data, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "rawPost.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HTTPPart;Lcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, IntPtr native_data, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.HTTPPart data = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IRawNetworkCallback @callback = (global::Com.Mob.Tools.Network.IRawNetworkCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IRawNetworkCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.RawPost (url, headers, data, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='rawPost' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.HTTPPart'] and parameter[4][@type='com.mob.tools.network.RawNetworkCallback'] and parameter[5][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HTTPPart;Lcom/mob/tools/network/RawNetworkCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_Lcom_mob_tools_network_RawNetworkCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void RawPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.HTTPPart data, global::Com.Mob.Tools.Network.IRawNetworkCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "rawPost.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HTTPPart;Lcom/mob/tools/network/RawNetworkCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [4] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static Delegate cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
#pragma warning disable 0169
		static Delegate GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler ()
		{
			if (cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ == null)
				cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_);
			return cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_;
		}

		static void n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, IntPtr native_data, int chunkLength, IntPtr native__callback, IntPtr native_timeout)
		{
			global::Com.Mob.Tools.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.HTTPPart data = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IHttpResponseCallback @callback = (global::Com.Mob.Tools.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IHttpResponseCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut> (native_timeout, JniHandleOwnership.DoNotTransfer);
			__this.RawPost (url, headers, data, chunkLength, @callback, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='NetworkHelper']/method[@name='rawPost' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.mob.tools.network.HTTPPart'] and parameter[4][@type='int'] and parameter[5][@type='com.mob.tools.network.HttpResponseCallback'] and parameter[6][@type='com.mob.tools.network.NetworkHelper.NetworkTimeOut']]"
		[Register ("rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HTTPPart;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V", "GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcom_mob_tools_network_HTTPPart_ILcom_mob_tools_network_HttpResponseCallback_Lcom_mob_tools_network_NetworkHelper_NetworkTimeOut_Handler")]
		public virtual unsafe void RawPost (string url, global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> headers, global::Com.Mob.Tools.Network.HTTPPart data, int chunkLength, global::Com.Mob.Tools.Network.IHttpResponseCallback @callback, global::Com.Mob.Tools.Network.NetworkHelper.NetworkTimeOut timeout)
		{
			const string __id = "rawPost.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/mob/tools/network/HTTPPart;ILcom/mob/tools/network/HttpResponseCallback;Lcom/mob/tools/network/NetworkHelper$NetworkTimeOut;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_headers = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [3] = new JniArgumentValue (chunkLength);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [5] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

	}
}
