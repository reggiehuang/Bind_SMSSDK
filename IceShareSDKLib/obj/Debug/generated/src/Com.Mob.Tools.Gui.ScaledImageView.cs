using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/ScaledImageView", DoNotGenerateAcw=true)]
	public partial class ScaledImageView : global::Android.Widget.ImageView, global::Android.Views.View.IOnTouchListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='ScaledImageView.OnMatrixChangedListener']"
		[Register ("com/mob/tools/gui/ScaledImageView$OnMatrixChangedListener", "", "Com.Mob.Tools.Gui.ScaledImageView/IOnMatrixChangedListenerInvoker")]
		public partial interface IOnMatrixChangedListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='ScaledImageView.OnMatrixChangedListener']/method[@name='onMactrixChage' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
			[Register ("onMactrixChage", "(Landroid/graphics/Matrix;)V", "GetOnMactrixChage_Landroid_graphics_Matrix_Handler:Com.Mob.Tools.Gui.ScaledImageView/IOnMatrixChangedListenerInvoker, IceShareSDKLib")]
			void OnMactrixChage (global::Android.Graphics.Matrix p0);

		}

		[global::Android.Runtime.Register ("com/mob/tools/gui/ScaledImageView$OnMatrixChangedListener", DoNotGenerateAcw=true)]
		internal partial class IOnMatrixChangedListenerInvoker : global::Java.Lang.Object, IOnMatrixChangedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/ScaledImageView$OnMatrixChangedListener", typeof (IOnMatrixChangedListenerInvoker));

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

			public static IOnMatrixChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMatrixChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.gui.ScaledImageView.OnMatrixChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMatrixChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMactrixChage_Landroid_graphics_Matrix_;
#pragma warning disable 0169
			static Delegate GetOnMactrixChage_Landroid_graphics_Matrix_Handler ()
			{
				if (cb_onMactrixChage_Landroid_graphics_Matrix_ == null)
					cb_onMactrixChage_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMactrixChage_Landroid_graphics_Matrix_);
				return cb_onMactrixChage_Landroid_graphics_Matrix_;
			}

			static void n_OnMactrixChage_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMactrixChage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMactrixChage_Landroid_graphics_Matrix_;
			public unsafe void OnMactrixChage (global::Android.Graphics.Matrix p0)
			{
				if (id_onMactrixChage_Landroid_graphics_Matrix_ == IntPtr.Zero)
					id_onMactrixChage_Landroid_graphics_Matrix_ = JNIEnv.GetMethodID (class_ref, "onMactrixChage", "(Landroid/graphics/Matrix;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMactrixChage_Landroid_graphics_Matrix_, __args);
			}

		}

		// event args for com.mob.tools.gui.ScaledImageView.OnMatrixChangedListener.onMactrixChage
		public partial class MatrixChangedEventArgs : global::System.EventArgs {

			public MatrixChangedEventArgs (global::Android.Graphics.Matrix p0)
			{
				this.p0 = p0;
			}

			global::Android.Graphics.Matrix p0;
			public global::Android.Graphics.Matrix P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mob/tools/gui/ScaledImageView_OnMatrixChangedListenerImplementor")]
		internal sealed partial class IOnMatrixChangedListenerImplementor : global::Java.Lang.Object, IOnMatrixChangedListener {

			object sender;

			public IOnMatrixChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/tools/gui/ScaledImageView_OnMatrixChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MatrixChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnMactrixChage (global::Android.Graphics.Matrix p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MatrixChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMatrixChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/ScaledImageView", typeof (ScaledImageView));
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

		protected ScaledImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/constructor[@name='ScaledImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ScaledImageView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/constructor[@name='ScaledImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ScaledImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attributeSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attributeSet).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/constructor[@name='ScaledImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ScaledImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attributeSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attributeSet).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCropedBitmap_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetGetCropedBitmap_Landroid_graphics_Rect_Handler ()
		{
			if (cb_getCropedBitmap_Landroid_graphics_Rect_ == null)
				cb_getCropedBitmap_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCropedBitmap_Landroid_graphics_Rect_);
			return cb_getCropedBitmap_Landroid_graphics_Rect_;
		}

		static IntPtr n_GetCropedBitmap_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cropRect)
		{
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect cropRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_cropRect, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCropedBitmap (cropRect));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='getCropedBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("getCropedBitmap", "(Landroid/graphics/Rect;)Landroid/graphics/Bitmap;", "GetGetCropedBitmap_Landroid_graphics_Rect_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetCropedBitmap (global::Android.Graphics.Rect cropRect)
		{
			const string __id = "getCropedBitmap.(Landroid/graphics/Rect;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cropRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cropRect).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_e)
		{
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (v, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View v, global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouch.(Landroid/view/View;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rotateLeft;
#pragma warning disable 0169
		static Delegate GetRotateLeftHandler ()
		{
			if (cb_rotateLeft == null)
				cb_rotateLeft = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RotateLeft);
			return cb_rotateLeft;
		}

		static void n_RotateLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotateLeft ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='rotateLeft' and count(parameter)=0]"
		[Register ("rotateLeft", "()V", "GetRotateLeftHandler")]
		public virtual unsafe void RotateLeft ()
		{
			const string __id = "rotateLeft.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_rotateRight;
#pragma warning disable 0169
		static Delegate GetRotateRightHandler ()
		{
			if (cb_rotateRight == null)
				cb_rotateRight = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RotateRight);
			return cb_rotateRight;
		}

		static void n_RotateRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotateRight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='rotateRight' and count(parameter)=0]"
		[Register ("rotateRight", "()V", "GetRotateRightHandler")]
		public virtual unsafe void RotateRight ()
		{
			const string __id = "rotateRight.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bm = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bm, JniHandleOwnership.DoNotTransfer);
			__this.SetBitmap (bm);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
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

		static Delegate cb_setOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_Handler ()
		{
			if (cb_setOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_ == null)
				cb_setOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_);
			return cb_setOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_;
		}

		static void n_SetOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener l = (global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMatrixChangedListener (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='setOnMatrixChangedListener' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.ScaledImageView.OnMatrixChangedListener']]"
		[Register ("setOnMatrixChangedListener", "(Lcom/mob/tools/gui/ScaledImageView$OnMatrixChangedListener;)V", "GetSetOnMatrixChangedListener_Lcom_mob_tools_gui_ScaledImageView_OnMatrixChangedListener_Handler")]
		public virtual unsafe void SetOnMatrixChangedListener (global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener l)
		{
			const string __id = "setOnMatrixChangedListener.(Lcom/mob/tools/gui/ScaledImageView$OnMatrixChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomIn);
			return cb_zoomIn;
		}

		static void n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()V", "GetZoomInHandler")]
		public virtual unsafe void ZoomIn ()
		{
			const string __id = "zoomIn.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomOut);
			return cb_zoomOut;
		}

		static void n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.ScaledImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScaledImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ScaledImageView']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()V", "GetZoomOutHandler")]
		public virtual unsafe void ZoomOut ()
		{
			const string __id = "zoomOut.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener"
		public event EventHandler<global::Com.Mob.Tools.Gui.ScaledImageView.MatrixChangedEventArgs> MatrixChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener, global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListenerImplementor>(
						ref weak_implementor_SetOnMatrixChangedListener,
						__CreateIOnMatrixChangedListenerImplementor,
						SetOnMatrixChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListener, global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListenerImplementor>(
						ref weak_implementor_SetOnMatrixChangedListener,
						global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListenerImplementor.__IsEmpty,
						__v => SetOnMatrixChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMatrixChangedListener;

		global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListenerImplementor __CreateIOnMatrixChangedListenerImplementor ()
		{
			return new global::Com.Mob.Tools.Gui.ScaledImageView.IOnMatrixChangedListenerImplementor (this);
		}
#endregion
	}
}
