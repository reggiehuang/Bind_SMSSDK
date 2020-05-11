using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/ResHelper", DoNotGenerateAcw=true)]
	public partial class ResHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/ResHelper", typeof (ResHelper));
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

		protected ResHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/constructor[@name='ResHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='clearCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearCache", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearCache (global::Android.Content.Context context)
		{
			const string __id = "clearCache.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='contentUriToPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("contentUriToPath", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string ContentUriToPath (global::Android.Content.Context context, global::Android.Net.Uri uri)
		{
			const string __id = "contentUriToPath.(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='copyFile' and count(parameter)=2 and parameter[1][@type='java.io.FileInputStream'] and parameter[2][@type='java.io.FileOutputStream']]"
		[Register ("copyFile", "(Ljava/io/FileInputStream;Ljava/io/FileOutputStream;)V", "")]
		public static unsafe void CopyFile (global::System.IO.Stream src, global::System.IO.Stream dst)
		{
			const string __id = "copyFile.(Ljava/io/FileInputStream;Ljava/io/FileOutputStream;)V";
			IntPtr native_src = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (src);
			IntPtr native_dst = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_src);
				__args [1] = new JniArgumentValue (native_dst);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
				JNIEnv.DeleteLocalRef (native_dst);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='copyFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copyFile", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool CopyFile (string fromFilePath, string toFilePath)
		{
			const string __id = "copyFile.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_fromFilePath = JNIEnv.NewString (fromFilePath);
			IntPtr native_toFilePath = JNIEnv.NewString (toFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fromFilePath);
				__args [1] = new JniArgumentValue (native_toFilePath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fromFilePath);
				JNIEnv.DeleteLocalRef (native_toFilePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='covertTimeInYears' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("covertTimeInYears", "(J)[I", "")]
		public static unsafe int[] CovertTimeInYears (long time)
		{
			const string __id = "covertTimeInYears.(J)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (time);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='dateStrToLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dateStrToLong", "(Ljava/lang/String;)J", "")]
		public static unsafe long DateStrToLong (string strDate)
		{
			const string __id = "dateStrToLong.(Ljava/lang/String;)J";
			IntPtr native_strDate = JNIEnv.NewString (strDate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strDate);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_strDate);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='dateToLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dateToLong", "(Ljava/lang/String;)J", "")]
		public static unsafe long DateToLong (string date)
		{
			const string __id = "dateToLong.(Ljava/lang/String;)J";
			IntPtr native_date = JNIEnv.NewString (date);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_date);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_date);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='decodeUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle DecodeUrl (string s)
		{
			const string __id = "decodeUrl.(Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='deleteFileAndFolder' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFileAndFolder", "(Ljava/io/File;)V", "")]
		public static unsafe void DeleteFileAndFolder (global::Java.IO.File folder)
		{
			const string __id = "deleteFileAndFolder.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='deleteFilesInFolder' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFilesInFolder", "(Ljava/io/File;)V", "")]
		public static unsafe void DeleteFilesInFolder (global::Java.IO.File folder)
		{
			const string __id = "deleteFilesInFolder.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='designToDevice' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("designToDevice", "(Landroid/content/Context;FI)I", "")]
		public static unsafe int DesignToDevice (global::Android.Content.Context context, float designScreenDensity, int designPx)
		{
			const string __id = "designToDevice.(Landroid/content/Context;FI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (designScreenDensity);
				__args [2] = new JniArgumentValue (designPx);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='designToDevice' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("designToDevice", "(Landroid/content/Context;II)I", "")]
		public static unsafe int DesignToDevice (global::Android.Content.Context context, int designScreenWidth, int designPx)
		{
			const string __id = "designToDevice.(Landroid/content/Context;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (designScreenWidth);
				__args [2] = new JniArgumentValue (designPx);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='dipToPx' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("dipToPx", "(Landroid/content/Context;I)I", "")]
		public static unsafe int DipToPx (global::Android.Content.Context context, int dip)
		{
			const string __id = "dipToPx.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (dip);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='encodeUrl' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("encodeUrl", "(Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static unsafe string EncodeUrl (global::Android.OS.Bundle parameters)
		{
			const string __id = "encodeUrl.(Landroid/os/Bundle;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='encodeUrl' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.mob.tools.network.KVPair&lt;java.lang.String&gt;&gt;']]"
		[Register ("encodeUrl", "(Ljava/util/ArrayList;)Ljava/lang/String;", "")]
		public static unsafe string EncodeUrl (global::System.Collections.Generic.IList<global::Com.Mob.Tools.Network.KVPair> values)
		{
			const string __id = "encodeUrl.(Ljava/util/ArrayList;)Ljava/lang/String;";
			IntPtr native_values = global::Android.Runtime.JavaList<global::Com.Mob.Tools.Network.KVPair>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='forceCast' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("forceCast", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object ForceCast (global::Java.Lang.Object obj)
		{
			const string __id = "forceCast.(Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='forceCast' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='T']]"
		[Register ("forceCast", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object ForceCast (global::Java.Lang.Object obj, global::Java.Lang.Object defValue)
		{
			const string __id = "forceCast.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_defValue = JNIEnv.ToLocalJniHandle (defValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_defValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_defValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getAnimRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAnimRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetAnimRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getAnimRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getBitmapRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBitmapRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetBitmapRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getBitmapRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getCachePath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCachePath", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCachePath (global::Android.Content.Context context, string category)
		{
			const string __id = "getCachePath.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_category = JNIEnv.NewString (category);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_category);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_category);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getCacheRoot' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCacheRoot", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCacheRoot (global::Android.Content.Context context)
		{
			const string __id = "getCacheRoot.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getCacheRootFile' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCacheRootFile", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetCacheRootFile (global::Android.Content.Context context, string name)
		{
			const string __id = "getCacheRootFile.(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getColorRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getColorRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetColorRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getColorRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getDataCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataCache", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDataCache (global::Android.Content.Context context)
		{
			const string __id = "getDataCache.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getFileSize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getFileSize", "(Ljava/io/File;)J", "")]
		public static unsafe long GetFileSize (global::Java.IO.File file)
		{
			const string __id = "getFileSize.(Ljava/io/File;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getFileSize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileSize", "(Ljava/lang/String;)J", "")]
		public static unsafe long GetFileSize (string path)
		{
			const string __id = "getFileSize.(Ljava/lang/String;)J";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getIdRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIdRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetIdRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getIdRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getImageCachePath' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getImageCachePath", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetImageCachePath (global::Android.Content.Context context)
		{
			const string __id = "getImageCachePath.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getLayoutRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLayoutRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetLayoutRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getLayoutRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getMediaUri' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getMediaUri", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetMediaUri (global::Android.Content.Context context, string filePath, string mimeType)
		{
			const string __id = "getMediaUri.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_filePath);
				__args [2] = new JniArgumentValue (native_mimeType);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getPluralsRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPluralsRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetPluralsRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getPluralsRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getRawRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRawRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetRawRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getRawRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getResId' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getResId", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int GetResId (global::Android.Content.Context context, string resType, string resName)
		{
			const string __id = "getResId.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_resType = JNIEnv.NewString (resType);
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resType);
				__args [2] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resType);
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getScreenHeight' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenHeight", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetScreenHeight (global::Android.Content.Context context)
		{
			const string __id = "getScreenHeight.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getScreenSize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenSize", "(Landroid/content/Context;)[I", "")]
		public static unsafe int[] GetScreenSize (global::Android.Content.Context context)
		{
			const string __id = "getScreenSize.(Landroid/content/Context;)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getScreenWidth' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenWidth", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetScreenWidth (global::Android.Content.Context context)
		{
			const string __id = "getScreenWidth.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getStringArrayRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringArrayRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStringArrayRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getStringArrayRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getStringRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStringRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getStringRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getStringValue' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='T']]"
		[Register ("getStringValue", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetStringValue (global::Android.Content.Context context, string name, global::Java.Lang.Object defaultValue)
		{
			const string __id = "getStringValue.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getStyleRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStyleRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStyleRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getStyleRes.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getStyleableRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStyleableRes", "(Landroid/content/Context;Ljava/lang/String;)[I", "")]
		public static unsafe int[] GetStyleableRes (global::Android.Content.Context context, string resName)
		{
			const string __id = "getStyleableRes.(Landroid/content/Context;Ljava/lang/String;)[I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='getTextLengthInWord' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTextLengthInWord", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetTextLengthInWord (string text)
		{
			const string __id = "getTextLengthInWord.(Ljava/lang/String;)I";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='isEqual' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("isEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool IsEqual (global::Java.Lang.Object o1, global::Java.Lang.Object o2)
		{
			const string __id = "isEqual.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			IntPtr native_o1 = JNIEnv.ToLocalJniHandle (o1);
			IntPtr native_o2 = JNIEnv.ToLocalJniHandle (o2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_o1);
				__args [1] = new JniArgumentValue (native_o2);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_o1);
				JNIEnv.DeleteLocalRef (native_o2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='isLeapYear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLeapYear", "(I)Z", "")]
		public static unsafe bool IsLeapYear (int year)
		{
			const string __id = "isLeapYear.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (year);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='longToDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("longToDate", "(J)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date LongToDate (long time)
		{
			const string __id = "longToDate.(J)Ljava/util/Date;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (time);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='longToTime' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("longToTime", "(JI)Ljava/lang/String;", "")]
		public static unsafe string LongToTime (long time, int level)
		{
			const string __id = "longToTime.(JI)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (time);
				__args [1] = new JniArgumentValue (level);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='parseInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseInt", "(Ljava/lang/String;)I", "")]
		public static unsafe int ParseInt (string @string)
		{
			const string __id = "parseInt.(Ljava/lang/String;)I";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='parseInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("parseInt", "(Ljava/lang/String;I)I", "")]
		public static unsafe int ParseInt (string @string, int radix)
		{
			const string __id = "parseInt.(Ljava/lang/String;I)I";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue (radix);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='parseLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseLong", "(Ljava/lang/String;)J", "")]
		public static unsafe long ParseLong (string @string)
		{
			const string __id = "parseLong.(Ljava/lang/String;)J";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='parseLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("parseLong", "(Ljava/lang/String;I)J", "")]
		public static unsafe long ParseLong (string @string, int radix)
		{
			const string __id = "parseLong.(Ljava/lang/String;I)J";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue (radix);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='pathToContentUri' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("pathToContentUri", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri PathToContentUri (global::Android.Content.Context context, string imagePath)
		{
			const string __id = "pathToContentUri.(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;";
			IntPtr native_imagePath = JNIEnv.NewString (imagePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_imagePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_imagePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='pxToDip' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("pxToDip", "(Landroid/content/Context;I)I", "")]
		public static unsafe int PxToDip (global::Android.Content.Context context, int px)
		{
			const string __id = "pxToDip.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='readObjectFromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readObjectFromFile", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadObjectFromFile (string filePath)
		{
			const string __id = "readObjectFromFile.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='saveObjectToFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("saveObjectToFile", "(Ljava/lang/String;Ljava/lang/Object;)Z", "")]
		public static unsafe bool SaveObjectToFile (string filePath, global::Java.Lang.Object @object)
		{
			const string __id = "saveObjectToFile.(Ljava/lang/String;Ljava/lang/Object;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='setResourceProvider' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setResourceProvider", "(Ljava/lang/Object;)V", "")]
		public static unsafe void SetResourceProvider (global::Java.Lang.Object rp)
		{
			const string __id = "setResourceProvider.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rp).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='strToDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("strToDate", "(Ljava/lang/String;)J", "")]
		public static unsafe long StrToDate (string strDate)
		{
			const string __id = "strToDate.(Ljava/lang/String;)J";
			IntPtr native_strDate = JNIEnv.NewString (strDate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strDate);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_strDate);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static new unsafe string ToString (global::Java.Lang.Object obj)
		{
			const string __id = "toString.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='toWordText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("toWordText", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string ToWordText (string text, int lenInWord)
		{
			const string __id = "toWordText.(Ljava/lang/String;I)Ljava/lang/String;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (lenInWord);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='urlToBundle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlToBundle", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle UrlToBundle (string url)
		{
			const string __id = "urlToBundle.(Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ResHelper']/method[@name='videoPathToContentUri' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("videoPathToContentUri", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri VideoPathToContentUri (global::Android.Content.Context context, string videoPath)
		{
			const string __id = "videoPathToContentUri.(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;";
			IntPtr native_videoPath = JNIEnv.NewString (videoPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_videoPath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_videoPath);
			}
		}

	}
}
