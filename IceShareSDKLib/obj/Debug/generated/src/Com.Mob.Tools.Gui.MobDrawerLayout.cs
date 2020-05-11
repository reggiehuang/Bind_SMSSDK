using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/MobDrawerLayout", DoNotGenerateAcw=true)]
	public partial class MobDrawerLayout : global::Android.Views.ViewGroup {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']"
		[global::Android.Runtime.Register ("com/mob/tools/gui/MobDrawerLayout$DrawerType", DoNotGenerateAcw=true)]
		public sealed partial class DrawerType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/field[@name='LEFT_BOTTOM']"
			[Register ("LEFT_BOTTOM")]
			public static global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType LeftBottom {
				get {
					const string __id = "LEFT_BOTTOM.Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/field[@name='LEFT_COVER']"
			[Register ("LEFT_COVER")]
			public static global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType LeftCover {
				get {
					const string __id = "LEFT_COVER.Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/field[@name='LEFT_PUSH']"
			[Register ("LEFT_PUSH")]
			public static global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType LeftPush {
				get {
					const string __id = "LEFT_PUSH.Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/field[@name='RIGHT_BOTTOM']"
			[Register ("RIGHT_BOTTOM")]
			public static global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType RightBottom {
				get {
					const string __id = "RIGHT_BOTTOM.Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/field[@name='RIGHT_COVER']"
			[Register ("RIGHT_COVER")]
			public static global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType RightCover {
				get {
					const string __id = "RIGHT_COVER.Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/field[@name='RIGHT_PUSH']"
			[Register ("RIGHT_PUSH")]
			public static global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType RightPush {
				get {
					const string __id = "RIGHT_PUSH.Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/MobDrawerLayout$DrawerType", typeof (DrawerType));
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

			internal DrawerType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;", "")]
			public static unsafe global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout.DrawerType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;", "")]
			public static unsafe global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType[] Values ()
			{
				const string __id = "values.()[Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='MobDrawerLayout.OnDrawerStateChangeListener']"
		[Register ("com/mob/tools/gui/MobDrawerLayout$OnDrawerStateChangeListener", "", "Com.Mob.Tools.Gui.MobDrawerLayout/IOnDrawerStateChangeListenerInvoker")]
		public partial interface IOnDrawerStateChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='MobDrawerLayout.OnDrawerStateChangeListener']/method[@name='onClosing' and count(parameter)=2 and parameter[1][@type='com.mob.tools.gui.MobDrawerLayout'] and parameter[2][@type='int']]"
			[Register ("onClosing", "(Lcom/mob/tools/gui/MobDrawerLayout;I)V", "GetOnClosing_Lcom_mob_tools_gui_MobDrawerLayout_IHandler:Com.Mob.Tools.Gui.MobDrawerLayout/IOnDrawerStateChangeListenerInvoker, IceShareSDKLib")]
			void OnClosing (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='MobDrawerLayout.OnDrawerStateChangeListener']/method[@name='onOpening' and count(parameter)=2 and parameter[1][@type='com.mob.tools.gui.MobDrawerLayout'] and parameter[2][@type='int']]"
			[Register ("onOpening", "(Lcom/mob/tools/gui/MobDrawerLayout;I)V", "GetOnOpening_Lcom_mob_tools_gui_MobDrawerLayout_IHandler:Com.Mob.Tools.Gui.MobDrawerLayout/IOnDrawerStateChangeListenerInvoker, IceShareSDKLib")]
			void OnOpening (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1);

		}

		[global::Android.Runtime.Register ("com/mob/tools/gui/MobDrawerLayout$OnDrawerStateChangeListener", DoNotGenerateAcw=true)]
		internal partial class IOnDrawerStateChangeListenerInvoker : global::Java.Lang.Object, IOnDrawerStateChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/MobDrawerLayout$OnDrawerStateChangeListener", typeof (IOnDrawerStateChangeListenerInvoker));

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

			public static IOnDrawerStateChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDrawerStateChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.gui.MobDrawerLayout.OnDrawerStateChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDrawerStateChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I;
#pragma warning disable 0169
			static Delegate GetOnClosing_Lcom_mob_tools_gui_MobDrawerLayout_IHandler ()
			{
				if (cb_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I == null)
					cb_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnClosing_Lcom_mob_tools_gui_MobDrawerLayout_I);
				return cb_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I;
			}

			static void n_OnClosing_Lcom_mob_tools_gui_MobDrawerLayout_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mob.Tools.Gui.MobDrawerLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClosing (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I;
			public unsafe void OnClosing (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1)
			{
				if (id_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I == IntPtr.Zero)
					id_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I = JNIEnv.GetMethodID (class_ref, "onClosing", "(Lcom/mob/tools/gui/MobDrawerLayout;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClosing_Lcom_mob_tools_gui_MobDrawerLayout_I, __args);
			}

			static Delegate cb_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I;
#pragma warning disable 0169
			static Delegate GetOnOpening_Lcom_mob_tools_gui_MobDrawerLayout_IHandler ()
			{
				if (cb_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I == null)
					cb_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnOpening_Lcom_mob_tools_gui_MobDrawerLayout_I);
				return cb_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I;
			}

			static void n_OnOpening_Lcom_mob_tools_gui_MobDrawerLayout_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mob.Tools.Gui.MobDrawerLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnOpening (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I;
			public unsafe void OnOpening (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1)
			{
				if (id_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I == IntPtr.Zero)
					id_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I = JNIEnv.GetMethodID (class_ref, "onOpening", "(Lcom/mob/tools/gui/MobDrawerLayout;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpening_Lcom_mob_tools_gui_MobDrawerLayout_I, __args);
			}

		}

		// event args for com.mob.tools.gui.MobDrawerLayout.OnDrawerStateChangeListener.onClosing
		public partial class ClosingEventArgs : global::System.EventArgs {

			public ClosingEventArgs (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mob.Tools.Gui.MobDrawerLayout p0;
			public global::Com.Mob.Tools.Gui.MobDrawerLayout P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		// event args for com.mob.tools.gui.MobDrawerLayout.OnDrawerStateChangeListener.onOpening
		public partial class OpeningEventArgs : global::System.EventArgs {

			public OpeningEventArgs (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mob.Tools.Gui.MobDrawerLayout p0;
			public global::Com.Mob.Tools.Gui.MobDrawerLayout P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mob/tools/gui/MobDrawerLayout_OnDrawerStateChangeListenerImplementor")]
		internal sealed partial class IOnDrawerStateChangeListenerImplementor : global::Java.Lang.Object, IOnDrawerStateChangeListener {

			object sender;

			public IOnDrawerStateChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/tools/gui/MobDrawerLayout_OnDrawerStateChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ClosingEventArgs> OnClosingHandler;
#pragma warning restore 0649

			public void OnClosing (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1)
			{
				var __h = OnClosingHandler;
				if (__h != null)
					__h (sender, new ClosingEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<OpeningEventArgs> OnOpeningHandler;
#pragma warning restore 0649

			public void OnOpening (global::Com.Mob.Tools.Gui.MobDrawerLayout p0, int p1)
			{
				var __h = OnOpeningHandler;
				if (__h != null)
					__h (sender, new OpeningEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnDrawerStateChangeListenerImplementor value)
			{
				return value.OnClosingHandler == null && value.OnOpeningHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/MobDrawerLayout", typeof (MobDrawerLayout));
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

		protected MobDrawerLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/constructor[@name='MobDrawerLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobDrawerLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/constructor[@name='MobDrawerLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MobDrawerLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/constructor[@name='MobDrawerLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MobDrawerLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isOpened;
#pragma warning disable 0169
		static Delegate GetIsOpenedHandler ()
		{
			if (cb_isOpened == null)
				cb_isOpened = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpened);
			return cb_isOpened;
		}

		static bool n_IsOpened (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpened;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='isOpened' and count(parameter)=0]"
			[Register ("isOpened", "()Z", "GetIsOpenedHandler")]
			get {
				const string __id = "isOpened.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_close_Z;
#pragma warning disable 0169
		static Delegate GetClose_ZHandler ()
		{
			if (cb_close_Z == null)
				cb_close_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Close_Z);
			return cb_close_Z;
		}

		static void n_Close_Z (IntPtr jnienv, IntPtr native__this, bool immediate)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (immediate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='close' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("close", "(Z)V", "GetClose_ZHandler")]
		public virtual unsafe void Close (bool immediate)
		{
			const string __id = "close.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (immediate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, l, t, r, b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool changed, int l, int t, int r, int b)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (l);
				__args [2] = new JniArgumentValue (t);
				__args [3] = new JniArgumentValue (r);
				__args [4] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public virtual unsafe void Open ()
		{
			const string __id = "open.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_open_Z;
#pragma warning disable 0169
		static Delegate GetOpen_ZHandler ()
		{
			if (cb_open_Z == null)
				cb_open_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Open_Z);
			return cb_open_Z;
		}

		static void n_Open_Z (IntPtr jnienv, IntPtr native__this, bool immediate)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open (immediate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='open' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("open", "(Z)V", "GetOpen_ZHandler")]
		public virtual unsafe void Open (bool immediate)
		{
			const string __id = "open.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (immediate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBody_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetBody_Landroid_view_View_Handler ()
		{
			if (cb_setBody_Landroid_view_View_ == null)
				cb_setBody_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBody_Landroid_view_View_);
			return cb_setBody_Landroid_view_View_;
		}

		static void n_SetBody_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View body = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_body, JniHandleOwnership.DoNotTransfer);
			__this.SetBody (body);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setBody", "(Landroid/view/View;)V", "GetSetBody_Landroid_view_View_Handler")]
		public virtual unsafe void SetBody (global::Android.Views.View body)
		{
			const string __id = "setBody.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawer_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetDrawer_Landroid_view_View_Handler ()
		{
			if (cb_setDrawer_Landroid_view_View_ == null)
				cb_setDrawer_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDrawer_Landroid_view_View_);
			return cb_setDrawer_Landroid_view_View_;
		}

		static void n_SetDrawer_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawer)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View drawer = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_drawer, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawer (drawer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='setDrawer' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setDrawer", "(Landroid/view/View;)V", "GetSetDrawer_Landroid_view_View_Handler")]
		public virtual unsafe void SetDrawer (global::Android.Views.View drawer)
		{
			const string __id = "setDrawer.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_;
#pragma warning disable 0169
		static Delegate GetSetDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_Handler ()
		{
			if (cb_setDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_ == null)
				cb_setDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_);
			return cb_setDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_;
		}

		static void n_SetDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType type = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawerType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='setDrawerType' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.MobDrawerLayout.DrawerType']]"
		[Register ("setDrawerType", "(Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;)V", "GetSetDrawerType_Lcom_mob_tools_gui_MobDrawerLayout_DrawerType_Handler")]
		public virtual unsafe void SetDrawerType (global::Com.Mob.Tools.Gui.MobDrawerLayout.DrawerType type)
		{
			const string __id = "setDrawerType.(Lcom/mob/tools/gui/MobDrawerLayout$DrawerType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawerWidth_D;
#pragma warning disable 0169
		static Delegate GetSetDrawerWidth_DHandler ()
		{
			if (cb_setDrawerWidth_D == null)
				cb_setDrawerWidth_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDrawerWidth_D);
			return cb_setDrawerWidth_D;
		}

		static void n_SetDrawerWidth_D (IntPtr jnienv, IntPtr native__this, double drawerWidth)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawerWidth (drawerWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='setDrawerWidth' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setDrawerWidth", "(D)V", "GetSetDrawerWidth_DHandler")]
		public virtual unsafe void SetDrawerWidth (double drawerWidth)
		{
			const string __id = "setDrawerWidth.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (drawerWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLockScroll_Z;
#pragma warning disable 0169
		static Delegate GetSetLockScroll_ZHandler ()
		{
			if (cb_setLockScroll_Z == null)
				cb_setLockScroll_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLockScroll_Z);
			return cb_setLockScroll_Z;
		}

		static void n_SetLockScroll_Z (IntPtr jnienv, IntPtr native__this, bool @lock)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLockScroll (@lock);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='setLockScroll' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLockScroll", "(Z)V", "GetSetLockScroll_ZHandler")]
		public virtual unsafe void SetLockScroll (bool @lock)
		{
			const string __id = "setLockScroll.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (@lock);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_Handler ()
		{
			if (cb_setOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_ == null)
				cb_setOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_);
			return cb_setOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_;
		}

		static void n_SetOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::Com.Mob.Tools.Gui.MobDrawerLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener l = (global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDrawerStateChangeListener (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobDrawerLayout']/method[@name='setOnDrawerStateChangeListener' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.MobDrawerLayout.OnDrawerStateChangeListener']]"
		[Register ("setOnDrawerStateChangeListener", "(Lcom/mob/tools/gui/MobDrawerLayout$OnDrawerStateChangeListener;)V", "GetSetOnDrawerStateChangeListener_Lcom_mob_tools_gui_MobDrawerLayout_OnDrawerStateChangeListener_Handler")]
		public virtual unsafe void SetOnDrawerStateChangeListener (global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener l)
		{
			const string __id = "setOnDrawerStateChangeListener.(Lcom/mob/tools/gui/MobDrawerLayout$OnDrawerStateChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener"
		public event EventHandler<global::Com.Mob.Tools.Gui.MobDrawerLayout.ClosingEventArgs> Closing {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener, global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor>(
						ref weak_implementor_SetOnDrawerStateChangeListener,
						__CreateIOnDrawerStateChangeListenerImplementor,
						SetOnDrawerStateChangeListener,
						__h => __h.OnClosingHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener, global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor>(
						ref weak_implementor_SetOnDrawerStateChangeListener,
						global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor.__IsEmpty,
						__v => SetOnDrawerStateChangeListener (null),
						__h => __h.OnClosingHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mob.Tools.Gui.MobDrawerLayout.OpeningEventArgs> Opening {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener, global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor>(
						ref weak_implementor_SetOnDrawerStateChangeListener,
						__CreateIOnDrawerStateChangeListenerImplementor,
						SetOnDrawerStateChangeListener,
						__h => __h.OnOpeningHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListener, global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor>(
						ref weak_implementor_SetOnDrawerStateChangeListener,
						global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor.__IsEmpty,
						__v => SetOnDrawerStateChangeListener (null),
						__h => __h.OnOpeningHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDrawerStateChangeListener;

		global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor __CreateIOnDrawerStateChangeListenerImplementor ()
		{
			return new global::Com.Mob.Tools.Gui.MobDrawerLayout.IOnDrawerStateChangeListenerImplementor (this);
		}
#endregion
	}
}
