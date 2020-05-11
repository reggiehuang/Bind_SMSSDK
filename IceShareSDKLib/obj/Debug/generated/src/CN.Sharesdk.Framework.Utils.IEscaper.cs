using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework.Utils {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.framework.utils']/interface[@name='Escaper']"
	[Register ("cn/sharesdk/framework/utils/Escaper", "", "CN.Sharesdk.Framework.Utils.IEscaperInvoker")]
	public partial interface IEscaper : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/interface[@name='Escaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='java.lang.Appendable']]"
		[Register ("escape", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;", "GetEscape_Ljava_lang_Appendable_Handler:CN.Sharesdk.Framework.Utils.IEscaperInvoker, IceShareSDKLib")]
		global::Java.Lang.IAppendable Escape (global::Java.Lang.IAppendable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.utils']/interface[@name='Escaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escape", "(Ljava/lang/String;)Ljava/lang/String;", "GetEscape_Ljava_lang_String_Handler:CN.Sharesdk.Framework.Utils.IEscaperInvoker, IceShareSDKLib")]
		string Escape (string p0);

	}

	[global::Android.Runtime.Register ("cn/sharesdk/framework/utils/Escaper", DoNotGenerateAcw=true)]
	internal partial class IEscaperInvoker : global::Java.Lang.Object, IEscaper {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/utils/Escaper", typeof (IEscaperInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IEscaper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEscaper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.sharesdk.framework.utils.Escaper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEscaperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_escape_Ljava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetEscape_Ljava_lang_Appendable_Handler ()
		{
			if (cb_escape_Ljava_lang_Appendable_ == null)
				cb_escape_Ljava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Escape_Ljava_lang_Appendable_);
			return cb_escape_Ljava_lang_Appendable_;
		}

		static IntPtr n_Escape_Ljava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Utils.IEscaper __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Utils.IEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IAppendable p0 = (global::Java.Lang.IAppendable)global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Escape (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_escape_Ljava_lang_Appendable_;
		public unsafe global::Java.Lang.IAppendable Escape (global::Java.Lang.IAppendable p0)
		{
			if (id_escape_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_escape_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "escape", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Java.Lang.IAppendable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_escape_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_escape_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscape_Ljava_lang_String_Handler ()
		{
			if (cb_escape_Ljava_lang_String_ == null)
				cb_escape_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Escape_Ljava_lang_String_);
			return cb_escape_Ljava_lang_String_;
		}

		static IntPtr n_Escape_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Utils.IEscaper __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Utils.IEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Escape (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_escape_Ljava_lang_String_;
		public unsafe string Escape (string p0)
		{
			if (id_escape_Ljava_lang_String_ == IntPtr.Zero)
				id_escape_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escape", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_escape_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
