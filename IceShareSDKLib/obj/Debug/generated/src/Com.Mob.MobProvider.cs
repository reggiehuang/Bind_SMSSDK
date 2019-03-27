using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']"
	[global::Android.Runtime.Register ("com/mob/MobProvider", DoNotGenerateAcw=true)]
	public partial class MobProvider : global::Android.Content.ContentProvider, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/MobProvider", typeof (MobProvider));
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

		protected MobProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']/constructor[@name='MobProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobProvider ()
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

		static Delegate cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mob.MobProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Delete (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", "GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe int Delete (global::Android.Net.Uri p0, string p1, string[] p2)
		{
			const string __id = "delete.(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getType_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetType_Landroid_net_Uri_Handler ()
		{
			if (cb_getType_Landroid_net_Uri_ == null)
				cb_getType_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetType_Landroid_net_Uri_);
			return cb_getType_Landroid_net_Uri_;
		}

		static IntPtr n_GetType_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.MobProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetType (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']/method[@name='getType' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getType", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetType_Landroid_net_Uri_Handler")]
		public override unsafe string GetType (global::Android.Net.Uri p0)
		{
			const string __id = "getType.(Landroid/net/Uri;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == null)
				cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_);
			return cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		}

		static IntPtr n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.MobProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues']]"
		[Register ("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", "GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler")]
		public override unsafe global::Android.Net.Uri Insert (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1)
		{
			const string __id = "insert.(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnCreate);
			return cb_onCreate;
		}

		static bool n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.MobProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnCreate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()Z", "GetOnCreateHandler")]
		public override unsafe bool OnCreate ()
		{
			const string __id = "onCreate.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Mob.MobProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1, p2, p3, p4));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']/method[@name='query' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Android.Database.ICursor Query (global::Android.Net.Uri p0, string[] p1, string p2, string[] p3, string p4)
		{
			const string __id = "query.(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mob.MobProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Update (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobProvider']/method[@name='update' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe int Update (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
		{
			const string __id = "update.(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
