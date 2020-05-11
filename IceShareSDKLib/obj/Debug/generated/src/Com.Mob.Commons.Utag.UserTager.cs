using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Utag {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager']"
	[global::Android.Runtime.Register ("com/mob/commons/utag/UserTager", DoNotGenerateAcw=true)]
	public sealed partial class UserTager : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager.CustomTag']"
		[global::Android.Runtime.Register ("com/mob/commons/utag/UserTager$CustomTag", DoNotGenerateAcw=true)]
		public partial class CustomTag : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/utag/UserTager$CustomTag", typeof (CustomTag));
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

			protected CustomTag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_withValue_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetWithValue_Ljava_lang_Boolean_Handler ()
			{
				if (cb_withValue_Ljava_lang_Boolean_ == null)
					cb_withValue_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithValue_Ljava_lang_Boolean_);
				return cb_withValue_Ljava_lang_Boolean_;
			}

			static IntPtr n_WithValue_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Commons.Utag.UserTager.CustomTag __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager.CustomTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithValue (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager.CustomTag']/method[@name='withValue' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("withValue", "(Ljava/lang/Boolean;)Lcom/mob/commons/utag/UserTager;", "GetWithValue_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Com.Mob.Commons.Utag.UserTager WithValue (global::Java.Lang.Boolean p0)
			{
				const string __id = "withValue.(Ljava/lang/Boolean;)Lcom/mob/commons/utag/UserTager;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withValue_Ljava_lang_Number_;
#pragma warning disable 0169
			static Delegate GetWithValue_Ljava_lang_Number_Handler ()
			{
				if (cb_withValue_Ljava_lang_Number_ == null)
					cb_withValue_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithValue_Ljava_lang_Number_);
				return cb_withValue_Ljava_lang_Number_;
			}

			static IntPtr n_WithValue_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Commons.Utag.UserTager.CustomTag __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager.CustomTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Number p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithValue (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager.CustomTag']/method[@name='withValue' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
			[Register ("withValue", "(Ljava/lang/Number;)Lcom/mob/commons/utag/UserTager;", "GetWithValue_Ljava_lang_Number_Handler")]
			public virtual unsafe global::Com.Mob.Commons.Utag.UserTager WithValue (global::Java.Lang.Number p0)
			{
				const string __id = "withValue.(Ljava/lang/Number;)Lcom/mob/commons/utag/UserTager;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withValue_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithValue_Ljava_lang_String_Handler ()
			{
				if (cb_withValue_Ljava_lang_String_ == null)
					cb_withValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithValue_Ljava_lang_String_);
				return cb_withValue_Ljava_lang_String_;
			}

			static IntPtr n_WithValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Commons.Utag.UserTager.CustomTag __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager.CustomTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithValue (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager.CustomTag']/method[@name='withValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withValue", "(Ljava/lang/String;)Lcom/mob/commons/utag/UserTager;", "GetWithValue_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mob.Commons.Utag.UserTager WithValue (string p0)
			{
				const string __id = "withValue.(Ljava/lang/String;)Lcom/mob/commons/utag/UserTager;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/utag/UserTager", typeof (UserTager));
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

		internal UserTager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()V", "")]
		public unsafe void Commit ()
		{
			const string __id = "commit.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;)Lcom/mob/commons/utag/UserTager$CustomTag;", "")]
		public unsafe global::Com.Mob.Commons.Utag.UserTager.CustomTag Set (string p0)
		{
			const string __id = "set.(Ljava/lang/String;)Lcom/mob/commons/utag/UserTager$CustomTag;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager.CustomTag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTager']/method[@name='whenError' and count(parameter)=1 and parameter[1][@type='com.mob.commons.utag.UserTagError']]"
		[Register ("whenError", "(Lcom/mob/commons/utag/UserTagError;)Lcom/mob/commons/utag/UserTager;", "")]
		public unsafe global::Com.Mob.Commons.Utag.UserTager WhenError (global::Com.Mob.Commons.Utag.IUserTagError p0)
		{
			const string __id = "whenError.(Lcom/mob/commons/utag/UserTagError;)Lcom/mob/commons/utag/UserTager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
