using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/AsyncImageView", DoNotGenerateAcw=true)]
	public partial class AsyncImageView : global::Android.Widget.ImageView, global::Android.OS.Handler.ICallback, global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/AsyncImageView", typeof (AsyncImageView));
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

		protected AsyncImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/constructor[@name='AsyncImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AsyncImageView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/constructor[@name='AsyncImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AsyncImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/constructor[@name='AsyncImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AsyncImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_deleteCachedFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteCachedFile_Ljava_lang_String_Handler ()
		{
			if (cb_deleteCachedFile_Ljava_lang_String_ == null)
				cb_deleteCachedFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteCachedFile_Ljava_lang_String_);
			return cb_deleteCachedFile_Ljava_lang_String_;
		}

		static void n_DeleteCachedFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.DeleteCachedFile (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='deleteCachedFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteCachedFile", "(Ljava/lang/String;)V", "GetDeleteCachedFile_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteCachedFile (string url)
		{
			const string __id = "deleteCachedFile.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_Execute_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_defaultBm)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap defaultBm = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_defaultBm, JniHandleOwnership.DoNotTransfer);
			__this.Execute (url, defaultBm);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("execute", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetExecute_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void Execute (string url, global::Android.Graphics.Bitmap defaultBm)
		{
			const string __id = "execute.(Ljava/lang/String;Landroid/graphics/Bitmap;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((defaultBm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultBm).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == null)
				cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_);
			return cb_execute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		}

		static void n_Execute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_defaultBm, IntPtr native_errorBm)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap defaultBm = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_defaultBm, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap errorBm = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_errorBm, JniHandleOwnership.DoNotTransfer);
			__this.Execute (url, defaultBm, errorBm);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register ("execute", "(Ljava/lang/String;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "GetExecute_Ljava_lang_String_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void Execute (string url, global::Android.Graphics.Bitmap defaultBm, global::Android.Graphics.Bitmap errorBm)
		{
			const string __id = "execute.(Ljava/lang/String;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((defaultBm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultBm).Handle);
				__args [2] = new JniArgumentValue ((errorBm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorBm).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_execute_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_IHandler ()
		{
			if (cb_execute_Ljava_lang_String_I == null)
				cb_execute_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Execute_Ljava_lang_String_I);
			return cb_execute_Ljava_lang_String_I;
		}

		static void n_Execute_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_url, int defaultRes)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Execute (url, defaultRes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("execute", "(Ljava/lang/String;I)V", "GetExecute_Ljava_lang_String_IHandler")]
		public virtual unsafe void Execute (string url, int defaultRes)
		{
			const string __id = "execute.(Ljava/lang/String;I)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (defaultRes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_execute_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_IIHandler ()
		{
			if (cb_execute_Ljava_lang_String_II == null)
				cb_execute_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Execute_Ljava_lang_String_II);
			return cb_execute_Ljava_lang_String_II;
		}

		static void n_Execute_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_url, int defaultRes, int errorRes)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Execute (url, defaultRes, errorRes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("execute", "(Ljava/lang/String;II)V", "GetExecute_Ljava_lang_String_IIHandler")]
		public virtual unsafe void Execute (string url, int defaultRes, int errorRes)
		{
			const string __id = "execute.(Ljava/lang/String;II)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (defaultRes);
				__args [2] = new JniArgumentValue (errorRes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (msg);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetOnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_OnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_bm)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bm = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bm, JniHandleOwnership.DoNotTransfer);
			__this.OnImageGot (url, bm);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='onImageGot' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("onImageGot", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetOnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void OnImageGot (string url, global::Android.Graphics.Bitmap bm)
		{
			const string __id = "onImageGot.(Ljava/lang/String;Landroid/graphics/Bitmap;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bm).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_removeRamCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveRamCache_Ljava_lang_String_Handler ()
		{
			if (cb_removeRamCache_Ljava_lang_String_ == null)
				cb_removeRamCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveRamCache_Ljava_lang_String_);
			return cb_removeRamCache_Ljava_lang_String_;
		}

		static void n_RemoveRamCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRamCache (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='removeRamCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeRamCache", "(Ljava/lang/String;)V", "GetRemoveRamCache_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveRamCache (string url)
		{
			const string __id = "removeRamCache.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_setBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitmap_Landroid_graphics_Bitmap_);
			return cb_setBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bm)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bm = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bm, JniHandleOwnership.DoNotTransfer);
			__this.SetBitmap (bm);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetBitmap (global::Android.Graphics.Bitmap bm)
		{
			const string __id = "setBitmap.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bm).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCompressOptions_IIIJ;
#pragma warning disable 0169
		static Delegate GetSetCompressOptions_IIIJHandler ()
		{
			if (cb_setCompressOptions_IIIJ == null)
				cb_setCompressOptions_IIIJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, long>) n_SetCompressOptions_IIIJ);
			return cb_setCompressOptions_IIIJ;
		}

		static void n_SetCompressOptions_IIIJ (IntPtr jnienv, IntPtr native__this, int desiredWidth, int desiredHeight, int quality, long maxBytes)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCompressOptions (desiredWidth, desiredHeight, quality, maxBytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='setCompressOptions' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("setCompressOptions", "(IIIJ)V", "GetSetCompressOptions_IIIJHandler")]
		public virtual unsafe void SetCompressOptions (int desiredWidth, int desiredHeight, int quality, long maxBytes)
		{
			const string __id = "setCompressOptions.(IIIJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (desiredWidth);
				__args [1] = new JniArgumentValue (desiredHeight);
				__args [2] = new JniArgumentValue (quality);
				__args [3] = new JniArgumentValue (maxBytes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRound_F;
#pragma warning disable 0169
		static Delegate GetSetRound_FHandler ()
		{
			if (cb_setRound_F == null)
				cb_setRound_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRound_F);
			return cb_setRound_F;
		}

		static void n_SetRound_F (IntPtr jnienv, IntPtr native__this, float radius)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRound (radius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='setRound' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRound", "(F)V", "GetSetRound_FHandler")]
		public virtual unsafe void SetRound (float radius)
		{
			const string __id = "setRound.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radius);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRound_FFFF;
#pragma warning disable 0169
		static Delegate GetSetRound_FFFFHandler ()
		{
			if (cb_setRound_FFFF == null)
				cb_setRound_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SetRound_FFFF);
			return cb_setRound_FFFF;
		}

		static void n_SetRound_FFFF (IntPtr jnienv, IntPtr native__this, float leftTop, float rightTop, float rightBottom, float leftBottom)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRound (leftTop, rightTop, rightBottom, leftBottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='setRound' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("setRound", "(FFFF)V", "GetSetRound_FFFFHandler")]
		public virtual unsafe void SetRound (float leftTop, float rightTop, float rightBottom, float leftBottom)
		{
			const string __id = "setRound.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (leftTop);
				__args [1] = new JniArgumentValue (rightTop);
				__args [2] = new JniArgumentValue (rightBottom);
				__args [3] = new JniArgumentValue (leftBottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScaleToCropCenter_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleToCropCenter_ZHandler ()
		{
			if (cb_setScaleToCropCenter_Z == null)
				cb_setScaleToCropCenter_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleToCropCenter_Z);
			return cb_setScaleToCropCenter_Z;
		}

		static void n_SetScaleToCropCenter_Z (IntPtr jnienv, IntPtr native__this, bool scaleToCrop)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleToCropCenter (scaleToCrop);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='setScaleToCropCenter' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScaleToCropCenter", "(Z)V", "GetSetScaleToCropCenter_ZHandler")]
		public virtual unsafe void SetScaleToCropCenter (bool scaleToCrop)
		{
			const string __id = "setScaleToCropCenter.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (scaleToCrop);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUseCacheOption_ZZ;
#pragma warning disable 0169
		static Delegate GetSetUseCacheOption_ZZHandler ()
		{
			if (cb_setUseCacheOption_ZZ == null)
				cb_setUseCacheOption_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_SetUseCacheOption_ZZ);
			return cb_setUseCacheOption_ZZ;
		}

		static void n_SetUseCacheOption_ZZ (IntPtr jnienv, IntPtr native__this, bool useRamCache, bool useDiskCache)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseCacheOption (useRamCache, useDiskCache);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='setUseCacheOption' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("setUseCacheOption", "(ZZ)V", "GetSetUseCacheOption_ZZHandler")]
		public virtual unsafe void SetUseCacheOption (bool useRamCache, bool useDiskCache)
		{
			const string __id = "setUseCacheOption.(ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (useRamCache);
				__args [1] = new JniArgumentValue (useDiskCache);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUseCacheOption_ZZJ;
#pragma warning disable 0169
		static Delegate GetSetUseCacheOption_ZZJHandler ()
		{
			if (cb_setUseCacheOption_ZZJ == null)
				cb_setUseCacheOption_ZZJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, long>) n_SetUseCacheOption_ZZJ);
			return cb_setUseCacheOption_ZZJ;
		}

		static void n_SetUseCacheOption_ZZJ (IntPtr jnienv, IntPtr native__this, bool useRamCache, bool useDiskCache, long diskCacheTime)
		{
			global::Com.Mob.Tools.Gui.AsyncImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.AsyncImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseCacheOption (useRamCache, useDiskCache, diskCacheTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='AsyncImageView']/method[@name='setUseCacheOption' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='long']]"
		[Register ("setUseCacheOption", "(ZZJ)V", "GetSetUseCacheOption_ZZJHandler")]
		public virtual unsafe void SetUseCacheOption (bool useRamCache, bool useDiskCache, long diskCacheTime)
		{
			const string __id = "setUseCacheOption.(ZZJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (useRamCache);
				__args [1] = new JniArgumentValue (useDiskCache);
				__args [2] = new JniArgumentValue (diskCacheTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
