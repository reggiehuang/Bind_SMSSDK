using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/utils/FileUtils", typeof (FileUtils));
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

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/constructor[@name='FileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='closeIO' and count(parameter)=1 and parameter[1][@type='java.io.Closeable...']]"
		[Register ("closeIO", "([Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseIO (params global::Java.IO.ICloseable[] closeables)
		{
			const string __id = "closeIO.([Ljava/io/Closeable;)V";
			IntPtr native_closeables = JNIEnv.NewArray (closeables);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_closeables);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (closeables != null) {
					JNIEnv.CopyArray (native_closeables, closeables);
					JNIEnv.DeleteLocalRef (native_closeables);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='createFileByDeleteOldFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("createFileByDeleteOldFile", "(Ljava/io/File;)Z", "")]
		public static unsafe bool CreateFileByDeleteOldFile (global::Java.IO.File file)
		{
			const string __id = "createFileByDeleteOldFile.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='createOrExistsDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("createOrExistsDir", "(Ljava/io/File;)Z", "")]
		public static unsafe bool CreateOrExistsDir (global::Java.IO.File file)
		{
			const string __id = "createOrExistsDir.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='deleteAllInDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteAllInDir", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteAllInDir (global::Java.IO.File dir)
		{
			const string __id = "deleteAllInDir.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='deleteAllInDir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAllInDir", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool DeleteAllInDir (string dirPath)
		{
			const string __id = "deleteAllInDir.(Ljava/lang/String;)Z";
			IntPtr native_dirPath = JNIEnv.NewString (dirPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dirPath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_dirPath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='deleteDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteDir", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteDir (global::Java.IO.File dir)
		{
			const string __id = "deleteDir.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFile", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteFile (global::Java.IO.File file)
		{
			const string __id = "deleteFile.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool DeleteFile (string srcFilePath)
		{
			const string __id = "deleteFile.(Ljava/lang/String;)Z";
			IntPtr native_srcFilePath = JNIEnv.NewString (srcFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_srcFilePath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_srcFilePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='deleteFilesInDirWithFilter' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.FileFilter']]"
		[Register ("deleteFilesInDirWithFilter", "(Ljava/io/File;Ljava/io/FileFilter;)Z", "")]
		public static unsafe bool DeleteFilesInDirWithFilter (global::Java.IO.File dir, global::Java.IO.IFileFilter filter)
		{
			const string __id = "deleteFilesInDirWithFilter.(Ljava/io/File;Ljava/io/FileFilter;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				__args [1] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='getFileByPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileByPath", "(Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetFileByPath (string filePath)
		{
			const string __id = "getFileByPath.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='rename' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("rename", "(Ljava/io/File;Ljava/lang/String;)Z", "")]
		public static unsafe bool Rename (global::Java.IO.File file, string newName)
		{
			const string __id = "rename.(Ljava/io/File;Ljava/lang/String;)Z";
			IntPtr native_newName = JNIEnv.NewString (newName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [1] = new JniArgumentValue (native_newName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_newName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='FileUtils']/method[@name='rename' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("rename", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool Rename (string filePath, string newName)
		{
			const string __id = "rename.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_newName = JNIEnv.NewString (newName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_newName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_newName);
			}
		}

	}
}
