using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/BitmapProcessor", DoNotGenerateAcw=true)]
	public partial class BitmapProcessor : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='BitmapProcessor.BitmapCallback']"
		[Register ("com/mob/tools/gui/BitmapProcessor$BitmapCallback", "", "Com.Mob.Tools.Gui.BitmapProcessor/IBitmapCallbackInvoker")]
		public partial interface IBitmapCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='BitmapProcessor.BitmapCallback']/method[@name='onImageGot' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register ("onImageGot", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetOnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_Handler:Com.Mob.Tools.Gui.BitmapProcessor/IBitmapCallbackInvoker, IceShareSDKLib")]
			void OnImageGot (string p0, global::Android.Graphics.Bitmap p1);

		}

		[global::Android.Runtime.Register ("com/mob/tools/gui/BitmapProcessor$BitmapCallback", DoNotGenerateAcw=true)]
		internal partial class IBitmapCallbackInvoker : global::Java.Lang.Object, IBitmapCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/BitmapProcessor$BitmapCallback", typeof (IBitmapCallbackInvoker));

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

			public static IBitmapCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBitmapCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.gui.BitmapProcessor.BitmapCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBitmapCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
					cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_);
				return cb_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_;
			}

			static void n_OnImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnImageGot (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_;
			public unsafe void OnImageGot (string p0, global::Android.Graphics.Bitmap p1)
			{
				if (id_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onImageGot", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageGot_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.BitmapDesiredOptions']"
		[global::Android.Runtime.Register ("com/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions", DoNotGenerateAcw=true)]
		public partial class BitmapDesiredOptions : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.BitmapDesiredOptions']/field[@name='desiredHeight']"
			[Register ("desiredHeight")]
			public int DesiredHeight {
				get {
					const string __id = "desiredHeight.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "desiredHeight.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.BitmapDesiredOptions']/field[@name='desiredWidth']"
			[Register ("desiredWidth")]
			public int DesiredWidth {
				get {
					const string __id = "desiredWidth.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "desiredWidth.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.BitmapDesiredOptions']/field[@name='maxBytes']"
			[Register ("maxBytes")]
			public long MaxBytes {
				get {
					const string __id = "maxBytes.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxBytes.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.BitmapDesiredOptions']/field[@name='quality']"
			[Register ("quality")]
			public int Quality {
				get {
					const string __id = "quality.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "quality.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions", typeof (BitmapDesiredOptions));
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

			protected BitmapDesiredOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.BitmapDesiredOptions']/constructor[@name='BitmapProcessor.BitmapDesiredOptions' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BitmapDesiredOptions ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.ImageReq']"
		[global::Android.Runtime.Register ("com/mob/tools/gui/BitmapProcessor$ImageReq", DoNotGenerateAcw=true)]
		public partial class ImageReq : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/BitmapProcessor$ImageReq", typeof (ImageReq));
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

			protected ImageReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor.ImageReq']/constructor[@name='BitmapProcessor.ImageReq' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ImageReq ()
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/BitmapProcessor", typeof (BitmapProcessor));
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

		protected BitmapProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/constructor[@name='BitmapProcessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapProcessor ()
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

		public static unsafe long CacheSizeInByte {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='getCacheSizeInByte' and count(parameter)=0]"
			[Register ("getCacheSizeInByte", "()J", "")]
			get {
				const string __id = "getCacheSizeInByte.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string CacheSizeText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='getCacheSizeText' and count(parameter)=0]"
			[Register ("getCacheSizeText", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCacheSizeText.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='deleteCacheDir' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("deleteCacheDir", "(Z)V", "")]
		public static unsafe void DeleteCacheDir (bool sync)
		{
			const string __id = "deleteCacheDir.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sync);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='deleteCachedFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapDesiredOptions']]"
		[Register ("deleteCachedFile", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;)V", "")]
		public static unsafe void DeleteCachedFile (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.BitmapDesiredOptions bitmapDesiredOptions)
		{
			const string __id = "deleteCachedFile.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bitmapDesiredOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmapDesiredOptions).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='getBitmapFromCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitmapFromCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmapFromCache (string url)
		{
			const string __id = "getBitmapFromCache.(Ljava/lang/String;)Landroid/graphics/Bitmap;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='getBitmapFromCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapDesiredOptions']]"
		[Register ("getBitmapFromCache", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmapFromCache (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.BitmapDesiredOptions bitmapDesiredOptions)
		{
			const string __id = "getBitmapFromCache.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;)Landroid/graphics/Bitmap;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bitmapDesiredOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmapDesiredOptions).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("prepare", "(Landroid/content/Context;)V", "")]
		public static unsafe void Prepare (global::Android.Content.Context context)
		{
			const string __id = "prepare.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='process' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapCallback']]"
		[Register ("process", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V", "")]
		public static unsafe void Process (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback @callback)
		{
			const string __id = "process.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='process' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapDesiredOptions'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='com.mob.tools.gui.BitmapProcessor.BitmapCallback']]"
		[Register ("process", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;ZZLcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V", "")]
		public static unsafe void Process (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.BitmapDesiredOptions bmOpt, bool useRamCache, bool useDiskCache, global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback @callback)
		{
			const string __id = "process.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;ZZLcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bmOpt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmOpt).Handle);
				__args [2] = new JniArgumentValue (useRamCache);
				__args [3] = new JniArgumentValue (useDiskCache);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='process' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapDesiredOptions'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='long'] and parameter[6][@type='com.mob.tools.gui.BitmapProcessor.BitmapCallback']]"
		[Register ("process", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;ZZJLcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V", "")]
		public static unsafe void Process (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.BitmapDesiredOptions bmOpt, bool useRamCache, bool useDiskCache, long diskCacheTime, global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback @callback)
		{
			const string __id = "process.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;ZZJLcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bmOpt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmOpt).Handle);
				__args [2] = new JniArgumentValue (useRamCache);
				__args [3] = new JniArgumentValue (useDiskCache);
				__args [4] = new JniArgumentValue (diskCacheTime);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='process' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapDesiredOptions'] and parameter[3][@type='boolean'] and parameter[4][@type='com.mob.tools.gui.BitmapProcessor.BitmapCallback']]"
		[Register ("process", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;ZLcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V", "")]
		public static unsafe void Process (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.BitmapDesiredOptions bmOpt, bool useRamCache, global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback @callback)
		{
			const string __id = "process.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;ZLcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bmOpt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmOpt).Handle);
				__args [2] = new JniArgumentValue (useRamCache);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='process' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapDesiredOptions'] and parameter[3][@type='com.mob.tools.gui.BitmapProcessor.BitmapCallback']]"
		[Register ("process", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;Lcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V", "")]
		public static unsafe void Process (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.BitmapDesiredOptions bmOpt, global::Com.Mob.Tools.Gui.BitmapProcessor.IBitmapCallback @callback)
		{
			const string __id = "process.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;Lcom/mob/tools/gui/BitmapProcessor$BitmapCallback;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bmOpt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmOpt).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='removeBitmapFromRamCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.gui.BitmapProcessor.BitmapDesiredOptions']]"
		[Register ("removeBitmapFromRamCache", "(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;)V", "")]
		public static unsafe void RemoveBitmapFromRamCache (string url, global::Com.Mob.Tools.Gui.BitmapProcessor.BitmapDesiredOptions bitmapDesiredOptions)
		{
			const string __id = "removeBitmapFromRamCache.(Ljava/lang/String;Lcom/mob/tools/gui/BitmapProcessor$BitmapDesiredOptions;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((bitmapDesiredOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmapDesiredOptions).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public static unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='BitmapProcessor']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public static unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
