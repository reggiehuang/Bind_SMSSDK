using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/SmoothScroller", DoNotGenerateAcw=true)]
	public sealed partial class SmoothScroller : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Mob.Tools.Gui.SmoothScroller Default {
			get {
				const string __id = "DEFAULT.Lcom/mob/tools/gui/SmoothScroller;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.SmoothScroller> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']/field[@name='LINEAR_ACC']"
		[Register ("LINEAR_ACC")]
		public static global::Com.Mob.Tools.Gui.SmoothScroller LinearAcc {
			get {
				const string __id = "LINEAR_ACC.Lcom/mob/tools/gui/SmoothScroller;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.SmoothScroller> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']/field[@name='LINEAR_DEC']"
		[Register ("LINEAR_DEC")]
		public static global::Com.Mob.Tools.Gui.SmoothScroller LinearDec {
			get {
				const string __id = "LINEAR_DEC.Lcom/mob/tools/gui/SmoothScroller;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.SmoothScroller> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']/field[@name='OVER_SCROLL']"
		[Register ("OVER_SCROLL")]
		public static global::Com.Mob.Tools.Gui.SmoothScroller OverScroll {
			get {
				const string __id = "OVER_SCROLL.Lcom/mob/tools/gui/SmoothScroller;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.SmoothScroller> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/gui/SmoothScroller", typeof (SmoothScroller));
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

		internal SmoothScroller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']/method[@name='getScroller' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScroller", "(Landroid/content/Context;)Landroid/widget/Scroller;", "")]
		public unsafe global::Android.Widget.Scroller GetScroller (global::Android.Content.Context context)
		{
			const string __id = "getScroller.(Landroid/content/Context;)Landroid/widget/Scroller;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Scroller> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mob/tools/gui/SmoothScroller;", "")]
		public static unsafe global::Com.Mob.Tools.Gui.SmoothScroller ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/mob/tools/gui/SmoothScroller;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.SmoothScroller> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='SmoothScroller']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mob/tools/gui/SmoothScroller;", "")]
		public static unsafe global::Com.Mob.Tools.Gui.SmoothScroller[] Values ()
		{
			const string __id = "values.()[Lcom/mob/tools/gui/SmoothScroller;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Mob.Tools.Gui.SmoothScroller[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mob.Tools.Gui.SmoothScroller));
			} finally {
			}
		}

	}
}
