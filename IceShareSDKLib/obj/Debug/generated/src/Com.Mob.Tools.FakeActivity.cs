using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']"
	[global::Android.Runtime.Register ("com/mob/tools/FakeActivity", DoNotGenerateAcw=true)]
	public partial class FakeActivity : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/field[@name='activity']"
		[Register ("activity")]
		protected global::Android.App.Activity Activity {
			get {
				const string __id = "activity.Landroid/app/Activity;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "activity.Landroid/app/Activity;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/FakeActivity", typeof (FakeActivity));
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

		protected FakeActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/constructor[@name='FakeActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FakeActivity ()
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

		static Delegate cb_getContentView;
#pragma warning disable 0169
		static Delegate GetGetContentViewHandler ()
		{
			if (cb_getContentView == null)
				cb_getContentView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentView);
			return cb_getContentView;
		}

		static IntPtr n_GetContentView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentView);
		}
#pragma warning restore 0169

		static Delegate cb_setContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetContentView_Landroid_view_View_Handler ()
		{
			if (cb_setContentView_Landroid_view_View_ == null)
				cb_setContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentView_Landroid_view_View_);
			return cb_setContentView_Landroid_view_View_;
		}

		static void n_SetContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.ContentView = view;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View ContentView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='getContentView' and count(parameter)=0]"
			[Register ("getContentView", "()Landroid/view/View;", "GetGetContentViewHandler")]
			get {
				const string __id = "getContentView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='setContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setContentView", "(Landroid/view/View;)V", "GetSetContentView_Landroid_view_View_Handler")]
			set {
				const string __id = "setContentView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				const string __id = "getOrientation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getParent;
#pragma warning disable 0169
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParent);
			return cb_getParent;
		}

		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mob.Tools.FakeActivity Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lcom/mob/tools/FakeActivity;", "GetGetParentHandler")]
			get {
				const string __id = "getParent.()Lcom/mob/tools/FakeActivity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_beforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetBeforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_Handler ()
		{
			if (cb_beforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_ == null)
				cb_beforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_BeforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_);
			return cb_beforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_;
		}

		static void n_BeforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, int requestCode, IntPtr native_options)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.BeforeStartActivityForResult (intent, requestCode, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='beforeStartActivityForResult' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("beforeStartActivityForResult", "(Landroid/content/Intent;ILandroid/os/Bundle;)V", "GetBeforeStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_Handler")]
		public virtual unsafe void BeforeStartActivityForResult (global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options)
		{
			const string __id = "beforeStartActivityForResult.(Landroid/content/Intent;ILandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (requestCode);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disableScreenCapture;
#pragma warning disable 0169
		static Delegate GetDisableScreenCaptureHandler ()
		{
			if (cb_disableScreenCapture == null)
				cb_disableScreenCapture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DisableScreenCapture);
			return cb_disableScreenCapture;
		}

		static bool n_DisableScreenCapture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableScreenCapture ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='disableScreenCapture' and count(parameter)=0]"
		[Register ("disableScreenCapture", "()Z", "GetDisableScreenCaptureHandler")]
		protected virtual unsafe bool DisableScreenCapture ()
		{
			const string __id = "disableScreenCapture.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_findViewById_I;
#pragma warning disable 0169
		static Delegate GetFindViewById_IHandler ()
		{
			if (cb_findViewById_I == null)
				cb_findViewById_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FindViewById_I);
			return cb_findViewById_I;
		}

		static IntPtr n_FindViewById_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindViewById (id));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='findViewById' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findViewById", "(I)Landroid/view/View;", "GetFindViewById_IHandler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.view.View"})]
		public virtual unsafe global::Java.Lang.Object FindViewById (int id)
		{
			const string __id = "findViewById.(I)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findViewByResName_Landroid_view_View_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindViewByResName_Landroid_view_View_Ljava_lang_String_Handler ()
		{
			if (cb_findViewByResName_Landroid_view_View_Ljava_lang_String_ == null)
				cb_findViewByResName_Landroid_view_View_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FindViewByResName_Landroid_view_View_Ljava_lang_String_);
			return cb_findViewByResName_Landroid_view_View_Ljava_lang_String_;
		}

		static IntPtr n_FindViewByResName_Landroid_view_View_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_name)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindViewByResName (view, name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='findViewByResName' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String']]"
		[Register ("findViewByResName", "(Landroid/view/View;Ljava/lang/String;)Landroid/view/View;", "GetFindViewByResName_Landroid_view_View_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.view.View"})]
		public virtual unsafe global::Java.Lang.Object FindViewByResName (global::Android.Views.View view, string name)
		{
			const string __id = "findViewByResName.(Landroid/view/View;Ljava/lang/String;)Landroid/view/View;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_findViewByResName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindViewByResName_Ljava_lang_String_Handler ()
		{
			if (cb_findViewByResName_Ljava_lang_String_ == null)
				cb_findViewByResName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindViewByResName_Ljava_lang_String_);
			return cb_findViewByResName_Ljava_lang_String_;
		}

		static IntPtr n_FindViewByResName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindViewByResName (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='findViewByResName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findViewByResName", "(Ljava/lang/String;)Landroid/view/View;", "GetFindViewByResName_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.view.View"})]
		public virtual unsafe global::Java.Lang.Object FindViewByResName (string name)
		{
			const string __id = "findViewByResName.(Ljava/lang/String;)Landroid/view/View;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "")]
		public unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int requestCode, int resultCode, IntPtr native_data)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent data = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (requestCode, resultCode, data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int requestCode, int resultCode, global::Android.Content.Intent data)
		{
			const string __id = "onActivityResult.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestCode);
				__args [1] = new JniArgumentValue (resultCode);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_OnConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration newConfig = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_newConfig, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigurationChanged (newConfig);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration newConfig)
		{
			const string __id = "onConfigurationChanged.(Landroid/content/res/Configuration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newConfig).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCreate);
			return cb_onCreate;
		}

		static void n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "GetOnCreateHandler")]
		public virtual unsafe void OnCreate ()
		{
			const string __id = "onCreate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCreateOptionsMenu_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreateOptionsMenu_Landroid_view_Menu_Handler ()
		{
			if (cb_onCreateOptionsMenu_Landroid_view_Menu_ == null)
				cb_onCreateOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnCreateOptionsMenu_Landroid_view_Menu_);
			return cb_onCreateOptionsMenu_Landroid_view_Menu_;
		}

		static bool n_OnCreateOptionsMenu_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu menu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_menu, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (menu);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", "GetOnCreateOptionsMenu_Landroid_view_Menu_Handler")]
		public virtual unsafe bool OnCreateOptionsMenu (global::Android.Views.IMenu menu)
		{
			const string __id = "onCreateOptionsMenu.(Landroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((menu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menu).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onFinish;
#pragma warning disable 0169
		static Delegate GetOnFinishHandler ()
		{
			if (cb_onFinish == null)
				cb_onFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnFinish);
			return cb_onFinish;
		}

		static bool n_OnFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnFinish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()Z", "GetOnFinishHandler")]
		public virtual unsafe bool OnFinish ()
		{
			const string __id = "onFinish.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onKeyEvent_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyEvent_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyEvent_ILandroid_view_KeyEvent_ == null)
				cb_onKeyEvent_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyEvent_ILandroid_view_KeyEvent_);
			return cb_onKeyEvent_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyEvent_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_e)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyEvent (keyCode, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onKeyEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyEvent", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyEvent_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyEvent (int keyCode, global::Android.Views.KeyEvent e)
		{
			const string __id = "onKeyEvent.(ILandroid/view/KeyEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (keyCode);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onNewIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnNewIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_onNewIntent_Landroid_content_Intent_ == null)
				cb_onNewIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewIntent_Landroid_content_Intent_);
			return cb_onNewIntent_Landroid_content_Intent_;
		}

		static void n_OnNewIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnNewIntent (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onNewIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onNewIntent", "(Landroid/content/Intent;)V", "GetOnNewIntent_Landroid_content_Intent_Handler")]
		public virtual unsafe void OnNewIntent (global::Android.Content.Intent intent)
		{
			const string __id = "onNewIntent.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onOptionsItemSelected_Landroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler ()
		{
			if (cb_onOptionsItemSelected_Landroid_view_MenuItem_ == null)
				cb_onOptionsItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnOptionsItemSelected_Landroid_view_MenuItem_);
			return cb_onOptionsItemSelected_Landroid_view_MenuItem_;
		}

		static bool n_OnOptionsItemSelected_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem item = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_item, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (item);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
		[Register ("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public virtual unsafe bool OnOptionsItemSelected (global::Android.Views.IMenuItem item)
		{
			const string __id = "onOptionsItemSelected.(Landroid/view/MenuItem;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int requestCode, IntPtr native_permissions, IntPtr native_grantResults)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] permissions = (string[]) JNIEnv.GetArray (native_permissions, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] grantResults = (int[]) JNIEnv.GetArray (native_grantResults, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (requestCode, permissions, grantResults);
			if (permissions != null)
				JNIEnv.CopyArray (permissions, native_permissions);
			if (grantResults != null)
				JNIEnv.CopyArray (grantResults, native_grantResults);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int requestCode, string[] permissions, int[] grantResults)
		{
			const string __id = "onRequestPermissionsResult.(I[Ljava/lang/String;[I)V";
			IntPtr native_permissions = JNIEnv.NewArray (permissions);
			IntPtr native_grantResults = JNIEnv.NewArray (grantResults);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestCode);
				__args [1] = new JniArgumentValue (native_permissions);
				__args [2] = new JniArgumentValue (native_grantResults);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (permissions != null) {
					JNIEnv.CopyArray (native_permissions, permissions);
					JNIEnv.DeleteLocalRef (native_permissions);
				}
				if (grantResults != null) {
					JNIEnv.CopyArray (native_grantResults, grantResults);
					JNIEnv.DeleteLocalRef (native_grantResults);
				}
			}
		}

		static Delegate cb_onRestart;
#pragma warning disable 0169
		static Delegate GetOnRestartHandler ()
		{
			if (cb_onRestart == null)
				cb_onRestart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRestart);
			return cb_onRestart;
		}

		static void n_OnRestart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onRestart' and count(parameter)=0]"
		[Register ("onRestart", "()V", "GetOnRestartHandler")]
		public virtual unsafe void OnRestart ()
		{
			const string __id = "onRestart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResult_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetOnResult_Ljava_util_HashMap_Handler ()
		{
			if (cb_onResult_Ljava_util_HashMap_ == null)
				cb_onResult_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Ljava_util_HashMap_);
			return cb_onResult_Ljava_util_HashMap_;
		}

		static void n_OnResult_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_data, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onResult", "(Ljava/util/HashMap;)V", "GetOnResult_Ljava_util_HashMap_Handler")]
		public virtual unsafe void OnResult (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> data)
		{
			const string __id = "onResult.(Ljava/util/HashMap;)V";
			IntPtr native_data = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSetTheme_IZ;
#pragma warning disable 0169
		static Delegate GetOnSetTheme_IZHandler ()
		{
			if (cb_onSetTheme_IZ == null)
				cb_onSetTheme_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, int>) n_OnSetTheme_IZ);
			return cb_onSetTheme_IZ;
		}

		static int n_OnSetTheme_IZ (IntPtr jnienv, IntPtr native__this, int resid, bool atLaunch)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnSetTheme (resid, atLaunch);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onSetTheme' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("onSetTheme", "(IZ)I", "GetOnSetTheme_IZHandler")]
		protected virtual unsafe int OnSetTheme (int resid, bool atLaunch)
		{
			const string __id = "onSetTheme.(IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resid);
				__args [1] = new JniArgumentValue (atLaunch);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='registerExecutor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("registerExecutor", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void RegisterExecutor (string scheme, global::Java.Lang.Object executor)
		{
			const string __id = "registerExecutor.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scheme);
				__args [1] = new JniArgumentValue ((executor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executor).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
			}
		}

		static Delegate cb_requestFullScreen_Z;
#pragma warning disable 0169
		static Delegate GetRequestFullScreen_ZHandler ()
		{
			if (cb_requestFullScreen_Z == null)
				cb_requestFullScreen_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RequestFullScreen_Z);
			return cb_requestFullScreen_Z;
		}

		static void n_RequestFullScreen_Z (IntPtr jnienv, IntPtr native__this, bool fullScreen)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestFullScreen (fullScreen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='requestFullScreen' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("requestFullScreen", "(Z)V", "GetRequestFullScreen_ZHandler")]
		public virtual unsafe void RequestFullScreen (bool fullScreen)
		{
			const string __id = "requestFullScreen.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fullScreen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestLandscapeOrientation;
#pragma warning disable 0169
		static Delegate GetRequestLandscapeOrientationHandler ()
		{
			if (cb_requestLandscapeOrientation == null)
				cb_requestLandscapeOrientation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestLandscapeOrientation);
			return cb_requestLandscapeOrientation;
		}

		static void n_RequestLandscapeOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestLandscapeOrientation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='requestLandscapeOrientation' and count(parameter)=0]"
		[Register ("requestLandscapeOrientation", "()V", "GetRequestLandscapeOrientationHandler")]
		public virtual unsafe void RequestLandscapeOrientation ()
		{
			const string __id = "requestLandscapeOrientation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_requestPermissions_arrayLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetRequestPermissions_arrayLjava_lang_String_IHandler ()
		{
			if (cb_requestPermissions_arrayLjava_lang_String_I == null)
				cb_requestPermissions_arrayLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_RequestPermissions_arrayLjava_lang_String_I);
			return cb_requestPermissions_arrayLjava_lang_String_I;
		}

		static void n_RequestPermissions_arrayLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_permissions, int requestCode)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] permissions = (string[]) JNIEnv.GetArray (native_permissions, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RequestPermissions (permissions, requestCode);
			if (permissions != null)
				JNIEnv.CopyArray (permissions, native_permissions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='requestPermissions' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int']]"
		[Register ("requestPermissions", "([Ljava/lang/String;I)V", "GetRequestPermissions_arrayLjava_lang_String_IHandler")]
		public virtual unsafe void RequestPermissions (string[] permissions, int requestCode)
		{
			const string __id = "requestPermissions.([Ljava/lang/String;I)V";
			IntPtr native_permissions = JNIEnv.NewArray (permissions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_permissions);
				__args [1] = new JniArgumentValue (requestCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (permissions != null) {
					JNIEnv.CopyArray (native_permissions, permissions);
					JNIEnv.DeleteLocalRef (native_permissions);
				}
			}
		}

		static Delegate cb_requestPortraitOrientation;
#pragma warning disable 0169
		static Delegate GetRequestPortraitOrientationHandler ()
		{
			if (cb_requestPortraitOrientation == null)
				cb_requestPortraitOrientation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestPortraitOrientation);
			return cb_requestPortraitOrientation;
		}

		static void n_RequestPortraitOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestPortraitOrientation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='requestPortraitOrientation' and count(parameter)=0]"
		[Register ("requestPortraitOrientation", "()V", "GetRequestPortraitOrientationHandler")]
		public virtual unsafe void RequestPortraitOrientation ()
		{
			const string __id = "requestPortraitOrientation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_requestSensorLandscapeOrientation;
#pragma warning disable 0169
		static Delegate GetRequestSensorLandscapeOrientationHandler ()
		{
			if (cb_requestSensorLandscapeOrientation == null)
				cb_requestSensorLandscapeOrientation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestSensorLandscapeOrientation);
			return cb_requestSensorLandscapeOrientation;
		}

		static void n_RequestSensorLandscapeOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestSensorLandscapeOrientation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='requestSensorLandscapeOrientation' and count(parameter)=0]"
		[Register ("requestSensorLandscapeOrientation", "()V", "GetRequestSensorLandscapeOrientationHandler")]
		public virtual unsafe void RequestSensorLandscapeOrientation ()
		{
			const string __id = "requestSensorLandscapeOrientation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_requestSensorPortraitOrientation;
#pragma warning disable 0169
		static Delegate GetRequestSensorPortraitOrientationHandler ()
		{
			if (cb_requestSensorPortraitOrientation == null)
				cb_requestSensorPortraitOrientation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestSensorPortraitOrientation);
			return cb_requestSensorPortraitOrientation;
		}

		static void n_RequestSensorPortraitOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestSensorPortraitOrientation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='requestSensorPortraitOrientation' and count(parameter)=0]"
		[Register ("requestSensorPortraitOrientation", "()V", "GetRequestSensorPortraitOrientationHandler")]
		public virtual unsafe void RequestSensorPortraitOrientation ()
		{
			const string __id = "requestSensorPortraitOrientation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runOnUIThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnUIThread_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnUIThread_Ljava_lang_Runnable_ == null)
				cb_runOnUIThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunOnUIThread_Ljava_lang_Runnable_);
			return cb_runOnUIThread_Ljava_lang_Runnable_;
		}

		static void n_RunOnUIThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable r = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.RunOnUIThread (r);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='runOnUIThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnUIThread", "(Ljava/lang/Runnable;)V", "GetRunOnUIThread_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void RunOnUIThread (global::Java.Lang.IRunnable r)
		{
			const string __id = "runOnUIThread.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_runOnUIThread_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetRunOnUIThread_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_runOnUIThread_Ljava_lang_Runnable_J == null)
				cb_runOnUIThread_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_RunOnUIThread_Ljava_lang_Runnable_J);
			return cb_runOnUIThread_Ljava_lang_Runnable_J;
		}

		static void n_RunOnUIThread_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_r, long delayMillis)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable r = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.RunOnUIThread (r, delayMillis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='runOnUIThread' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("runOnUIThread", "(Ljava/lang/Runnable;J)V", "GetRunOnUIThread_Ljava_lang_Runnable_JHandler")]
		public virtual unsafe void RunOnUIThread (global::Java.Lang.IRunnable r, long delayMillis)
		{
			const string __id = "runOnUIThread.(Ljava/lang/Runnable;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				__args [1] = new JniArgumentValue (delayMillis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendResult;
#pragma warning disable 0169
		static Delegate GetSendResultHandler ()
		{
			if (cb_sendResult == null)
				cb_sendResult = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendResult);
			return cb_sendResult;
		}

		static void n_SendResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendResult ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='sendResult' and count(parameter)=0]"
		[Register ("sendResult", "()V", "GetSendResultHandler")]
		public virtual unsafe void SendResult ()
		{
			const string __id = "sendResult.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSetActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_setActivity_Landroid_app_Activity_ == null)
				cb_setActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivity_Landroid_app_Activity_);
			return cb_setActivity_Landroid_app_Activity_;
		}

		static void n_SetActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.SetActivity (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe void SetActivity (global::Android.App.Activity activity)
		{
			const string __id = "setActivity.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setContentViewLayoutResName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentViewLayoutResName_Ljava_lang_String_Handler ()
		{
			if (cb_setContentViewLayoutResName_Ljava_lang_String_ == null)
				cb_setContentViewLayoutResName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentViewLayoutResName_Ljava_lang_String_);
			return cb_setContentViewLayoutResName_Ljava_lang_String_;
		}

		static void n_SetContentViewLayoutResName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.SetContentViewLayoutResName (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='setContentViewLayoutResName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentViewLayoutResName", "(Ljava/lang/String;)V", "GetSetContentViewLayoutResName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetContentViewLayoutResName (string name)
		{
			const string __id = "setContentViewLayoutResName.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setRequestedOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetRequestedOrientation_IHandler ()
		{
			if (cb_setRequestedOrientation_I == null)
				cb_setRequestedOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRequestedOrientation_I);
			return cb_setRequestedOrientation_I;
		}

		static void n_SetRequestedOrientation_I (IntPtr jnienv, IntPtr native__this, int requestedOrientation)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestedOrientation (requestedOrientation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='setRequestedOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRequestedOrientation", "(I)V", "GetSetRequestedOrientation_IHandler")]
		public virtual unsafe void SetRequestedOrientation (int requestedOrientation)
		{
			const string __id = "setRequestedOrientation.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (requestedOrientation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='setResult' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setResult", "(Ljava/util/HashMap;)V", "")]
		public unsafe void SetResult (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> result)
		{
			const string __id = "setResult.(Ljava/util/HashMap;)V";
			IntPtr native_result = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (result);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_result);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_result);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='setShell' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
		[Register ("setShell", "(Ljava/lang/Class;)V", "")]
		public static unsafe void SetShell (global::Java.Lang.Class shellClass)
		{
			const string __id = "setShell.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((shellClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shellClass).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_show_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_show_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_show_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Show_Landroid_content_Context_Landroid_content_Intent_);
			return cb_show_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_Show_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_i)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent i = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_i, JniHandleOwnership.DoNotTransfer);
			__this.Show (context, i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='show' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("show", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetShow_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public virtual unsafe void Show (global::Android.Content.Context context, global::Android.Content.Intent i)
		{
			const string __id = "show.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((i == null) ? IntPtr.Zero : ((global::Java.Lang.Object) i).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_;
#pragma warning disable 0169
		static Delegate GetShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_Handler ()
		{
			if (cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_ == null)
				cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_);
			return cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_;
		}

		static void n_ShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_i, IntPtr native_resultReceiver)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent i = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_i, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.FakeActivity resultReceiver = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			__this.ShowForResult (context, i, resultReceiver);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='showForResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='com.mob.tools.FakeActivity']]"
		[Register ("showForResult", "(Landroid/content/Context;Landroid/content/Intent;Lcom/mob/tools/FakeActivity;)V", "GetShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcom_mob_tools_FakeActivity_Handler")]
		public virtual unsafe void ShowForResult (global::Android.Content.Context context, global::Android.Content.Intent i, global::Com.Mob.Tools.FakeActivity resultReceiver)
		{
			const string __id = "showForResult.(Landroid/content/Context;Landroid/content/Intent;Lcom/mob/tools/FakeActivity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((i == null) ? IntPtr.Zero : ((global::Java.Lang.Object) i).Handle);
				__args [2] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivity_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Landroid_content_Intent_Handler ()
		{
			if (cb_startActivity_Landroid_content_Intent_ == null)
				cb_startActivity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivity_Landroid_content_Intent_);
			return cb_startActivity_Landroid_content_Intent_;
		}

		static void n_StartActivity_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='startActivity' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivity", "(Landroid/content/Intent;)V", "GetStartActivity_Landroid_content_Intent_Handler")]
		public virtual unsafe void StartActivity (global::Android.Content.Intent intent)
		{
			const string __id = "startActivity.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivityForResult_Landroid_content_Intent_I;
#pragma warning disable 0169
		static Delegate GetStartActivityForResult_Landroid_content_Intent_IHandler ()
		{
			if (cb_startActivityForResult_Landroid_content_Intent_I == null)
				cb_startActivityForResult_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_StartActivityForResult_Landroid_content_Intent_I);
			return cb_startActivityForResult_Landroid_content_Intent_I;
		}

		static void n_StartActivityForResult_Landroid_content_Intent_I (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, int requestCode)
		{
			global::Com.Mob.Tools.FakeActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityForResult (intent, requestCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='FakeActivity']/method[@name='startActivityForResult' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int']]"
		[Register ("startActivityForResult", "(Landroid/content/Intent;I)V", "GetStartActivityForResult_Landroid_content_Intent_IHandler")]
		public virtual unsafe void StartActivityForResult (global::Android.Content.Intent intent, int requestCode)
		{
			const string __id = "startActivityForResult.(Landroid/content/Intent;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (requestCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
