using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Filesys {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']"
	[global::Android.Runtime.Register ("com/mob/commons/filesys/FileUploader", DoNotGenerateAcw=true)]
	public partial class FileUploader : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedAudio']"
		[global::Android.Runtime.Register ("com/mob/commons/filesys/FileUploader$UploadedAudio", DoNotGenerateAcw=true)]
		public partial class UploadedAudio : global::Com.Mob.Commons.Filesys.FileUploader.UploadedFile {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedAudio']/field[@name='durationUSec']"
			[Register ("durationUSec")]
			public int DurationUSec {
				get {
					const string __id = "durationUSec.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "durationUSec.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/filesys/FileUploader$UploadedAudio", typeof (UploadedAudio));
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

			protected UploadedAudio (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedAudio']/constructor[@name='FileUploader.UploadedAudio' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
			public unsafe UploadedAudio (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/HashMap;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedAvatar']"
		[global::Android.Runtime.Register ("com/mob/commons/filesys/FileUploader$UploadedAvatar", DoNotGenerateAcw=true)]
		public partial class UploadedAvatar : global::Com.Mob.Commons.Filesys.FileUploader.UploadedImage {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/filesys/FileUploader$UploadedAvatar", typeof (UploadedAvatar));
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

			protected UploadedAvatar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedAvatar']/constructor[@name='FileUploader.UploadedAvatar' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
			public unsafe UploadedAvatar (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/HashMap;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedFile']"
		[global::Android.Runtime.Register ("com/mob/commons/filesys/FileUploader$UploadedFile", DoNotGenerateAcw=true)]
		public partial class UploadedFile : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedFile']/field[@name='id']"
			[Register ("id")]
			public string Id {
				get {
					const string __id = "id.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "id.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedFile']/field[@name='url']"
			[Register ("url")]
			public string Url {
				get {
					const string __id = "url.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "url.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/filesys/FileUploader$UploadedFile", typeof (UploadedFile));
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

			protected UploadedFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedFile']/constructor[@name='FileUploader.UploadedFile' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
			public unsafe UploadedFile (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/HashMap;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedImage']"
		[global::Android.Runtime.Register ("com/mob/commons/filesys/FileUploader$UploadedImage", DoNotGenerateAcw=true)]
		public partial class UploadedImage : global::Com.Mob.Commons.Filesys.FileUploader.UploadedFile {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedImage']/field[@name='zoomList']"
			[Register ("zoomList")]
			public global::System.Collections.IDictionary ZoomList {
				get {
					const string __id = "zoomList.Ljava/util/HashMap;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "zoomList.Ljava/util/HashMap;";

					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/filesys/FileUploader$UploadedImage", typeof (UploadedImage));
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

			protected UploadedImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedImage']/constructor[@name='FileUploader.UploadedImage' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
			public unsafe UploadedImage (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/HashMap;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedVideo']"
		[global::Android.Runtime.Register ("com/mob/commons/filesys/FileUploader$UploadedVideo", DoNotGenerateAcw=true)]
		public partial class UploadedVideo : global::Com.Mob.Commons.Filesys.FileUploader.UploadedFile {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedVideo']/field[@name='durationUSec']"
			[Register ("durationUSec")]
			public int DurationUSec {
				get {
					const string __id = "durationUSec.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "durationUSec.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedVideo']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					const string __id = "height.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "height.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedVideo']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					const string __id = "width.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "width.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/filesys/FileUploader$UploadedVideo", typeof (UploadedVideo));
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

			protected UploadedVideo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader.UploadedVideo']/constructor[@name='FileUploader.UploadedVideo' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
			public unsafe UploadedVideo (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/HashMap;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/filesys/FileUploader", typeof (FileUploader));
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

		protected FileUploader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/constructor[@name='FileUploader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUploader ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='setUploadServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUploadServer", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetUploadServer (string p0)
		{
			const string __id = "setUploadServer.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='uploadAudio' and count(parameter)=3 and parameter[1][@type='com.mob.commons.MobProduct'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("uploadAudio", "(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z)Lcom/mob/commons/filesys/FileUploader$UploadedAudio;", "")]
		public static unsafe global::Com.Mob.Commons.Filesys.FileUploader.UploadedAudio UploadAudio (global::Com.Mob.Commons.IMobProduct p0, string p1, bool p2)
		{
			const string __id = "uploadAudio.(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z)Lcom/mob/commons/filesys/FileUploader$UploadedAudio;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Filesys.FileUploader.UploadedAudio> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='uploadAvatar' and count(parameter)=2 and parameter[1][@type='com.mob.commons.MobProduct'] and parameter[2][@type='java.lang.String']]"
		[Register ("uploadAvatar", "(Lcom/mob/commons/MobProduct;Ljava/lang/String;)Lcom/mob/commons/filesys/FileUploader$UploadedAvatar;", "")]
		public static unsafe global::Com.Mob.Commons.Filesys.FileUploader.UploadedAvatar UploadAvatar (global::Com.Mob.Commons.IMobProduct p0, string p1)
		{
			const string __id = "uploadAvatar.(Lcom/mob/commons/MobProduct;Ljava/lang/String;)Lcom/mob/commons/filesys/FileUploader$UploadedAvatar;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Filesys.FileUploader.UploadedAvatar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='uploadAvatar' and count(parameter)=4 and parameter[1][@type='com.mob.commons.MobProduct'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='int...']]"
		[Register ("uploadAvatar", "(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z[I)Lcom/mob/commons/filesys/FileUploader$UploadedAvatar;", "")]
		public static unsafe global::Com.Mob.Commons.Filesys.FileUploader.UploadedAvatar UploadAvatar (global::Com.Mob.Commons.IMobProduct p0, string p1, bool p2, params int[] p3)
		{
			const string __id = "uploadAvatar.(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z[I)Lcom/mob/commons/filesys/FileUploader$UploadedAvatar;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Filesys.FileUploader.UploadedAvatar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='uploadFile' and count(parameter)=3 and parameter[1][@type='com.mob.commons.MobProduct'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("uploadFile", "(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z)Lcom/mob/commons/filesys/FileUploader$UploadedFile;", "")]
		public static unsafe global::Com.Mob.Commons.Filesys.FileUploader.UploadedFile UploadFile (global::Com.Mob.Commons.IMobProduct p0, string p1, bool p2)
		{
			const string __id = "uploadFile.(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z)Lcom/mob/commons/filesys/FileUploader$UploadedFile;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Filesys.FileUploader.UploadedFile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='uploadImage' and count(parameter)=2 and parameter[1][@type='com.mob.commons.MobProduct'] and parameter[2][@type='java.lang.String']]"
		[Register ("uploadImage", "(Lcom/mob/commons/MobProduct;Ljava/lang/String;)Lcom/mob/commons/filesys/FileUploader$UploadedImage;", "")]
		public static unsafe global::Com.Mob.Commons.Filesys.FileUploader.UploadedImage UploadImage (global::Com.Mob.Commons.IMobProduct p0, string p1)
		{
			const string __id = "uploadImage.(Lcom/mob/commons/MobProduct;Ljava/lang/String;)Lcom/mob/commons/filesys/FileUploader$UploadedImage;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Filesys.FileUploader.UploadedImage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='uploadImage' and count(parameter)=4 and parameter[1][@type='com.mob.commons.MobProduct'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='int...']]"
		[Register ("uploadImage", "(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z[I)Lcom/mob/commons/filesys/FileUploader$UploadedImage;", "")]
		public static unsafe global::Com.Mob.Commons.Filesys.FileUploader.UploadedImage UploadImage (global::Com.Mob.Commons.IMobProduct p0, string p1, bool p2, params int[] p3)
		{
			const string __id = "uploadImage.(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z[I)Lcom/mob/commons/filesys/FileUploader$UploadedImage;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Filesys.FileUploader.UploadedImage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.filesys']/class[@name='FileUploader']/method[@name='uploadVideo' and count(parameter)=3 and parameter[1][@type='com.mob.commons.MobProduct'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("uploadVideo", "(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z)Lcom/mob/commons/filesys/FileUploader$UploadedVideo;", "")]
		public static unsafe global::Com.Mob.Commons.Filesys.FileUploader.UploadedVideo UploadVideo (global::Com.Mob.Commons.IMobProduct p0, string p1, bool p2)
		{
			const string __id = "uploadVideo.(Lcom/mob/commons/MobProduct;Ljava/lang/String;Z)Lcom/mob/commons/filesys/FileUploader$UploadedVideo;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Filesys.FileUploader.UploadedVideo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
