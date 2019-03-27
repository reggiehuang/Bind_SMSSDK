using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/BitmapHelper", DoNotGenerateAcw=true)]
	public partial class BitmapHelper : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/utils/BitmapHelper", typeof (BitmapHelper));
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

		protected BitmapHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/constructor[@name='BitmapHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='blur' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("blur", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap Blur (global::Android.Graphics.Bitmap bm, int radius, int scale)
		{
			const string __id = "blur.(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bm).Handle);
				__args [1] = new JniArgumentValue (radius);
				__args [2] = new JniArgumentValue (scale);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='captureView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("captureView", "(Landroid/view/View;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CaptureView (global::Android.Views.View view, int width, int height)
		{
			const string __id = "captureView.(Landroid/view/View;II)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='compressByQuality' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("compressByQuality", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CompressByQuality (global::Android.Graphics.Bitmap src, int quality)
		{
			const string __id = "compressByQuality.(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (quality);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='compressByQuality' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("compressByQuality", "(Landroid/graphics/Bitmap;IZ)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CompressByQuality (global::Android.Graphics.Bitmap src, int quality, bool recycle)
		{
			const string __id = "compressByQuality.(Landroid/graphics/Bitmap;IZ)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (quality);
				__args [2] = new JniArgumentValue (recycle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='compressByQuality' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='long']]"
		[Register ("compressByQuality", "(Landroid/graphics/Bitmap;J)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CompressByQuality (global::Android.Graphics.Bitmap src, long maxByteSize)
		{
			const string __id = "compressByQuality.(Landroid/graphics/Bitmap;J)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (maxByteSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='compressByQuality' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("compressByQuality", "(Landroid/graphics/Bitmap;JZ)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CompressByQuality (global::Android.Graphics.Bitmap src, long maxByteSize, bool recycle)
		{
			const string __id = "compressByQuality.(Landroid/graphics/Bitmap;JZ)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (maxByteSize);
				__args [2] = new JniArgumentValue (recycle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='cropBitmap' and count(parameter)=5 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("cropBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CropBitmap (global::Android.Graphics.Bitmap orginal, int left, int top, int right, int bottom)
		{
			const string __id = "cropBitmap.(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((orginal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) orginal).Handle);
				__args [1] = new JniArgumentValue (left);
				__args [2] = new JniArgumentValue (top);
				__args [3] = new JniArgumentValue (right);
				__args [4] = new JniArgumentValue (bottom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='downloadBitmap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("downloadBitmap", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DownloadBitmap (global::Android.Content.Context context, string imageUrl)
		{
			const string __id = "downloadBitmap.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_imageUrl = JNIEnv.NewString (imageUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_imageUrl);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageUrl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='fixRect' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("fixRect", "([I[I)[I", "")]
		public static unsafe int[] FixRect (int[] src, int[] target)
		{
			const string __id = "fixRect.([I[I)[I";
			IntPtr native_src = JNIEnv.NewArray (src);
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_src);
				__args [1] = new JniArgumentValue (native_target);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='fixRect_2' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("fixRect_2", "([I[I)[I", "")]
		public static unsafe int[] FixRect_2 (int[] src, int[] target)
		{
			const string __id = "fixRect_2.([I[I)[I";
			IntPtr native_src = JNIEnv.NewArray (src);
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_src);
				__args [1] = new JniArgumentValue (native_target);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBitmap", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (global::Android.Content.Context context, string url)
		{
			const string __id = "getBitmap.(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/Bitmap;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register ("getBitmap", "(Ljava/io/File;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (global::Java.IO.File file, int inSampleSize)
		{
			const string __id = "getBitmap.(Ljava/io/File;I)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [1] = new JniArgumentValue (inSampleSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("getBitmap", "(Ljava/io/InputStream;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (global::System.IO.Stream @is, int inSampleSize)
		{
			const string __id = "getBitmap.(Ljava/io/InputStream;I)Landroid/graphics/Bitmap;";
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__is);
				__args [1] = new JniArgumentValue (inSampleSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (string path)
		{
			const string __id = "getBitmap.(Ljava/lang/String;)Landroid/graphics/Bitmap;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getBitmap", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (string path, int inSampleSize)
		{
			const string __id = "getBitmap.(Ljava/lang/String;I)Landroid/graphics/Bitmap;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (inSampleSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBitmapByCompressQuality' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long']]"
		[Register ("getBitmapByCompressQuality", "(Ljava/lang/String;IIIJ)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmapByCompressQuality (string path, int desiredWidth, int desiredHeight, int quality, long maxBytes)
		{
			const string __id = "getBitmapByCompressQuality.(Ljava/lang/String;IIIJ)Landroid/graphics/Bitmap;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (desiredWidth);
				__args [2] = new JniArgumentValue (desiredHeight);
				__args [3] = new JniArgumentValue (quality);
				__args [4] = new JniArgumentValue (maxBytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBitmapByCompressSize' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getBitmapByCompressSize", "(Ljava/lang/String;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmapByCompressSize (string path, int desiredWidth, int desiredHeight)
		{
			const string __id = "getBitmapByCompressSize.(Ljava/lang/String;II)Landroid/graphics/Bitmap;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (desiredWidth);
				__args [2] = new JniArgumentValue (desiredHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBmpFormat' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getBmpFormat", "([B)Landroid/graphics/Bitmap$CompressFormat;", "")]
		public static unsafe global::Android.Graphics.Bitmap.CompressFormat GetBmpFormat (byte[] data)
		{
			const string __id = "getBmpFormat.([B)Landroid/graphics/Bitmap$CompressFormat;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getBmpFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBmpFormat", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;", "")]
		public static unsafe global::Android.Graphics.Bitmap.CompressFormat GetBmpFormat (string filePath)
		{
			const string __id = "getBmpFormat.(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='getMime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMime", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetMime (string file)
		{
			const string __id = "getMime.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_file = JNIEnv.NewString (file);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_file);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='isBlackBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("isBlackBitmap", "(Landroid/graphics/Bitmap;)Z", "")]
		public static unsafe bool IsBlackBitmap (global::Android.Graphics.Bitmap bm)
		{
			const string __id = "isBlackBitmap.(Landroid/graphics/Bitmap;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bm).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='mixAlpha' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("mixAlpha", "(II)I", "")]
		public static unsafe int MixAlpha (int frontARGB, int backRGB)
		{
			const string __id = "mixAlpha.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (frontARGB);
				__args [1] = new JniArgumentValue (backRGB);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='roundBitmap' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float']]"
		[Register ("roundBitmap", "(Landroid/graphics/Bitmap;IIFFFF)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap RoundBitmap (global::Android.Graphics.Bitmap orginal, int width, int height, float leftTop, float rightTop, float rightBottom, float leftBottom)
		{
			const string __id = "roundBitmap.(Landroid/graphics/Bitmap;IIFFFF)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((orginal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) orginal).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				__args [3] = new JniArgumentValue (leftTop);
				__args [4] = new JniArgumentValue (rightTop);
				__args [5] = new JniArgumentValue (rightBottom);
				__args [6] = new JniArgumentValue (leftBottom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='save' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.io.File'] and parameter[3][@type='android.graphics.Bitmap.CompressFormat'] and parameter[4][@type='boolean']]"
		[Register ("save", "(Landroid/graphics/Bitmap;Ljava/io/File;Landroid/graphics/Bitmap$CompressFormat;Z)Z", "")]
		public static unsafe bool Save (global::Android.Graphics.Bitmap src, global::Java.IO.File file, global::Android.Graphics.Bitmap.CompressFormat format, bool recycle)
		{
			const string __id = "save.(Landroid/graphics/Bitmap;Ljava/io/File;Landroid/graphics/Bitmap$CompressFormat;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [2] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [3] = new JniArgumentValue (recycle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='save' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.graphics.Bitmap.CompressFormat']]"
		[Register ("save", "(Landroid/graphics/Bitmap;Ljava/lang/String;Landroid/graphics/Bitmap$CompressFormat;)Z", "")]
		public static unsafe bool Save (global::Android.Graphics.Bitmap src, string filePath, global::Android.Graphics.Bitmap.CompressFormat format)
		{
			const string __id = "save.(Landroid/graphics/Bitmap;Ljava/lang/String;Landroid/graphics/Bitmap$CompressFormat;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (native_filePath);
				__args [2] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='saveBitmap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("saveBitmap", "(Landroid/content/Context;Landroid/graphics/Bitmap;)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmap (global::Android.Content.Context context, global::Android.Graphics.Bitmap bm)
		{
			const string __id = "saveBitmap.(Landroid/content/Context;Landroid/graphics/Bitmap;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((bm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bm).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='saveBitmap' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap.CompressFormat'] and parameter[4][@type='int']]"
		[Register ("saveBitmap", "(Landroid/content/Context;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap$CompressFormat;I)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmap (global::Android.Content.Context context, global::Android.Graphics.Bitmap bm, global::Android.Graphics.Bitmap.CompressFormat format, int quality)
		{
			const string __id = "saveBitmap.(Landroid/content/Context;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap$CompressFormat;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((bm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bm).Handle);
				__args [2] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [3] = new JniArgumentValue (quality);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='saveBitmapByCompress' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("saveBitmapByCompress", "(Ljava/lang/String;III)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmapByCompress (string path, int desiredWidth, int desiredHeight, int quality)
		{
			const string __id = "saveBitmapByCompress.(Ljava/lang/String;III)Ljava/lang/String;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (desiredWidth);
				__args [2] = new JniArgumentValue (desiredHeight);
				__args [3] = new JniArgumentValue (quality);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='saveViewToImage' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("saveViewToImage", "(Landroid/view/View;)Ljava/lang/String;", "")]
		public static unsafe string SaveViewToImage (global::Android.Views.View view)
		{
			const string __id = "saveViewToImage.(Landroid/view/View;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='saveViewToImage' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("saveViewToImage", "(Landroid/view/View;II)Ljava/lang/String;", "")]
		public static unsafe string SaveViewToImage (global::Android.Views.View view, int width, int height)
		{
			const string __id = "saveViewToImage.(Landroid/view/View;II)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='scaleBitmapByHeight' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("scaleBitmapByHeight", "(Landroid/content/Context;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ScaleBitmapByHeight (global::Android.Content.Context context, int resId, int height)
		{
			const string __id = "scaleBitmapByHeight.(Landroid/content/Context;II)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (resId);
				__args [2] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='BitmapHelper']/method[@name='scaleBitmapByHeight' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("scaleBitmapByHeight", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ScaleBitmapByHeight (global::Android.Graphics.Bitmap src, int height)
		{
			const string __id = "scaleBitmapByHeight.(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
