using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/SQLiteHelper", DoNotGenerateAcw=true)]
	public partial class SQLiteHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper.SingleTableDB']"
		[global::Android.Runtime.Register ("com/mob/tools/utils/SQLiteHelper$SingleTableDB", DoNotGenerateAcw=true)]
		public partial class SingleTableDB : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/SQLiteHelper$SingleTableDB", typeof (SingleTableDB));
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

			protected SingleTableDB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_addField_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetAddField_Ljava_lang_String_Ljava_lang_String_ZHandler ()
			{
				if (cb_addField_Ljava_lang_String_Ljava_lang_String_Z == null)
					cb_addField_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddField_Ljava_lang_String_Ljava_lang_String_Z);
				return cb_addField_Ljava_lang_String_Ljava_lang_String_Z;
			}

			static void n_AddField_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_fieldType, bool notNull)
			{
				global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
				string fieldType = JNIEnv.GetString (native_fieldType, JniHandleOwnership.DoNotTransfer);
				__this.AddField (fieldName, fieldType, notNull);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper.SingleTableDB']/method[@name='addField' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
			[Register ("addField", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetAddField_Ljava_lang_String_Ljava_lang_String_ZHandler")]
			public virtual unsafe void AddField (string fieldName, string fieldType, bool notNull)
			{
				const string __id = "addField.(Ljava/lang/String;Ljava/lang/String;Z)V";
				IntPtr native_fieldName = JNIEnv.NewString (fieldName);
				IntPtr native_fieldType = JNIEnv.NewString (fieldType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_fieldName);
					__args [1] = new JniArgumentValue (native_fieldType);
					__args [2] = new JniArgumentValue (notNull);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_fieldName);
					JNIEnv.DeleteLocalRef (native_fieldType);
				}
			}

			static Delegate cb_setPrimary_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetSetPrimary_Ljava_lang_String_ZHandler ()
			{
				if (cb_setPrimary_Ljava_lang_String_Z == null)
					cb_setPrimary_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetPrimary_Ljava_lang_String_Z);
				return cb_setPrimary_Ljava_lang_String_Z;
			}

			static void n_SetPrimary_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, bool autoincrement)
			{
				global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
				__this.SetPrimary (fieldName, autoincrement);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper.SingleTableDB']/method[@name='setPrimary' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register ("setPrimary", "(Ljava/lang/String;Z)V", "GetSetPrimary_Ljava_lang_String_ZHandler")]
			public virtual unsafe void SetPrimary (string fieldName, bool autoincrement)
			{
				const string __id = "setPrimary.(Ljava/lang/String;Z)V";
				IntPtr native_fieldName = JNIEnv.NewString (fieldName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_fieldName);
					__args [1] = new JniArgumentValue (autoincrement);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_fieldName);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/SQLiteHelper", typeof (SQLiteHelper));
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

		protected SQLiteHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/constructor[@name='SQLiteHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SQLiteHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='close' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB']]"
		[Register ("close", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;)V", "")]
		public static unsafe void Close (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db)
		{
			const string __id = "close.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("delete", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Ljava/lang/String;[Ljava/lang/String;)I", "")]
		public static unsafe int Delete (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db, string selection, string[] selectionArgs)
		{
			const string __id = "delete.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Ljava/lang/String;[Ljava/lang/String;)I";
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (native_selection);
				__args [2] = new JniArgumentValue (native_selectionArgs);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='execSQL' and count(parameter)=2 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB'] and parameter[2][@type='java.lang.String']]"
		[Register ("execSQL", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Ljava/lang/String;)V", "")]
		public static unsafe void ExecSQL (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db, string script)
		{
			const string __id = "execSQL.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Ljava/lang/String;)V";
			IntPtr native_script = JNIEnv.NewString (script);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (native_script);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_script);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='getDatabase' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDatabase", "(Landroid/content/Context;Ljava/lang/String;)Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;", "")]
		public static unsafe global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB GetDatabase (global::Android.Content.Context context, string name)
		{
			const string __id = "getDatabase.(Landroid/content/Context;Ljava/lang/String;)Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='getDatabase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDatabase", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;", "")]
		public static unsafe global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB GetDatabase (string path, string name)
		{
			const string __id = "getDatabase.(Ljava/lang/String;Ljava/lang/String;)Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB']]"
		[Register ("getSize", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;)I", "")]
		public static unsafe int GetSize (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db)
		{
			const string __id = "getSize.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB'] and parameter[2][@type='android.content.ContentValues']]"
		[Register ("insert", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Landroid/content/ContentValues;)J", "")]
		public static unsafe long Insert (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db, global::Android.Content.ContentValues values)
		{
			const string __id = "insert.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Landroid/content/ContentValues;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue ((values == null) ? IntPtr.Zero : ((global::Java.Lang.Object) values).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='query' and count(parameter)=5 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("query", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "")]
		public static unsafe global::Android.Database.ICursor Query (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db, string[] columns, string selection, string[] selectionArgs, string sortOrder)
		{
			const string __id = "query.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;";
			IntPtr native_columns = JNIEnv.NewArray (columns);
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			IntPtr native_sortOrder = JNIEnv.NewString (sortOrder);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (native_columns);
				__args [2] = new JniArgumentValue (native_selection);
				__args [3] = new JniArgumentValue (native_selectionArgs);
				__args [4] = new JniArgumentValue (native_sortOrder);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (columns != null) {
					JNIEnv.CopyArray (native_columns, columns);
					JNIEnv.DeleteLocalRef (native_columns);
				}
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
				JNIEnv.DeleteLocalRef (native_sortOrder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='rawQuery' and count(parameter)=3 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("rawQuery", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", "")]
		public static unsafe global::Android.Database.ICursor RawQuery (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db, string script, string[] selectionArgs)
		{
			const string __id = "rawQuery.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;";
			IntPtr native_script = JNIEnv.NewString (script);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (native_script);
				__args [2] = new JniArgumentValue (native_selectionArgs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_script);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='SQLiteHelper']/method[@name='update' and count(parameter)=4 and parameter[1][@type='com.mob.tools.utils.SQLiteHelper.SingleTableDB'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("update", "(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "")]
		public static unsafe int Update (global::Com.Mob.Tools.Utils.SQLiteHelper.SingleTableDB db, global::Android.Content.ContentValues values, string selection, string[] selectionArgs)
		{
			const string __id = "update.(Lcom/mob/tools/utils/SQLiteHelper$SingleTableDB;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I";
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue ((values == null) ? IntPtr.Zero : ((global::Java.Lang.Object) values).Handle);
				__args [2] = new JniArgumentValue (native_selection);
				__args [3] = new JniArgumentValue (native_selectionArgs);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
			}
		}

	}
}
