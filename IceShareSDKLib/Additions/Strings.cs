using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Strings']"
    [global::Android.Runtime.Register("com/mob/tools/utils/Strings", DoNotGenerateAcw = true)]
    public partial class Strings : global::Java.Lang.Object
    {



        // Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Strings']/field[@name='STRINGS']"
        [Register("STRINGS")]
        public static global::System.Collections.IList StringsGet
        {
            get
            {
                const string __id = "STRINGS.Ljava/util/ArrayList;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Android.Runtime.JavaList.FromJniHandle(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
        }
        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/utils/Strings", typeof(Strings));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected Strings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Strings']/constructor[@name='Strings' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe Strings()
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "()V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), null);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, null);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='Strings']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getString", "(I)Ljava/lang/String;", "")]
        public static unsafe string GetString(int index)
        {
            const string __id = "getString.(I)Ljava/lang/String;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
                return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

    }
}
