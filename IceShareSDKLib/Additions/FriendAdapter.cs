using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic
{

    // Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']"
    [global::Android.Runtime.Register("cn/sharesdk/onekeyshare/themes/classic/FriendAdapter", DoNotGenerateAcw = true)]
    public partial class FriendAdapter : global::Com.Mob.Tools.Gui.PullToRequestListAdapter, global::CN.Sharesdk.Framework.IPlatformActionListener
    {

        // Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']"
        [global::Android.Runtime.Register("cn/sharesdk/onekeyshare/themes/classic/FriendAdapter$Following", DoNotGenerateAcw = true)]
        public partial class Following : global::Java.Lang.Object
        {



            // Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']/field[@name='atName']"
            [Register("atName")]
            public string AtName
            {
                get
                {
                    const string __id = "atName.Ljava/lang/String;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return JNIEnv.GetString(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "atName.Ljava/lang/String;";

                    IntPtr native_value = JNIEnv.NewString(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']/field[@name='checked']"
            [Register("checked")]
            public bool Checked
            {
                get
                {
                    const string __id = "checked.Z";

                    var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                    return __v;
                }
                set
                {
                    const string __id = "checked.Z";

                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, value);
                    }
                    finally
                    {
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']/field[@name='description']"
            [Register("description")]
            public string Description
            {
                get
                {
                    const string __id = "description.Ljava/lang/String;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return JNIEnv.GetString(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "description.Ljava/lang/String;";

                    IntPtr native_value = JNIEnv.NewString(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']/field[@name='icon']"
            [Register("icon")]
            public string Icon
            {
                get
                {
                    const string __id = "icon.Ljava/lang/String;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return JNIEnv.GetString(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "icon.Ljava/lang/String;";

                    IntPtr native_value = JNIEnv.NewString(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']/field[@name='screenName']"
            [Register("screenName")]
            public string ScreenName
            {
                get
                {
                    const string __id = "screenName.Ljava/lang/String;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return JNIEnv.GetString(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "screenName.Ljava/lang/String;";

                    IntPtr native_value = JNIEnv.NewString(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']/field[@name='uid']"
            [Register("uid")]
            public string Uid
            {
                get
                {
                    const string __id = "uid.Ljava/lang/String;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return JNIEnv.GetString(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "uid.Ljava/lang/String;";

                    IntPtr native_value = JNIEnv.NewString(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }
            internal new static readonly JniPeerMembers _members = new XAPeerMembers("cn/sharesdk/onekeyshare/themes/classic/FriendAdapter$Following", typeof(Following));
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

            protected Following(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            // Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter.Following']/constructor[@name='FriendAdapter.Following' and count(parameter)=0]"
            [Register(".ctor", "()V", "")]
            public unsafe Following()
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

        }

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("cn/sharesdk/onekeyshare/themes/classic/FriendAdapter", typeof(FriendAdapter));
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

        protected FriendAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        // Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/constructor[@name='FriendAdapter' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.onekeyshare.themes.classic.FriendListPage'] and parameter[2][@type='com.mob.tools.gui.PullToRequestView']]"
        [Register(".ctor", "(Lcn/sharesdk/onekeyshare/themes/classic/FriendListPage;Lcom/mob/tools/gui/PullToRequestView;)V", "")]
        public unsafe FriendAdapter(global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage activity, global::Com.Mob.Tools.Gui.PullToRequestView view)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "(Lcn/sharesdk/onekeyshare/themes/classic/FriendListPage;Lcom/mob/tools/gui/PullToRequestView;)V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object)activity).Handle);
                __args[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object)view).Handle);
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_getCount;
#pragma warning disable 0169
        static Delegate GetGetCountHandler()
        {
            if (cb_getCount == null)
                cb_getCount = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_GetCount);
            return cb_getCount;
        }

        static int n_GetCount(IntPtr jnienv, IntPtr native__this)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Count;
        }
#pragma warning restore 0169

        public override unsafe int Count
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='getCount' and count(parameter)=0]"
            [Register("getCount", "()I", "GetGetCountHandler")]
            get
            {
                const string __id = "getCount.()I";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                    return __rm;
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getFooterView;
#pragma warning disable 0169
        static Delegate GetGetFooterViewHandler()
        {
            if (cb_getFooterView == null)
                cb_getFooterView = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetFooterView);
            return cb_getFooterView;
        }

        static IntPtr n_GetFooterView(IntPtr jnienv, IntPtr native__this)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FooterView);
        }
#pragma warning restore 0169

        public override unsafe global::Android.Views.View FooterView
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='getFooterView' and count(parameter)=0]"
            [Register("getFooterView", "()Landroid/view/View;", "GetGetFooterViewHandler")]
            get
            {
                const string __id = "getFooterView.()Landroid/view/View;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Android.Views.View>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getHeaderView;
#pragma warning disable 0169
        static Delegate GetGetHeaderViewHandler()
        {
            if (cb_getHeaderView == null)
                cb_getHeaderView = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetHeaderView);
            return cb_getHeaderView;
        }

        static IntPtr n_GetHeaderView(IntPtr jnienv, IntPtr native__this)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.HeaderView);
        }
#pragma warning restore 0169

        public override unsafe global::Android.Views.View HeaderView
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='getHeaderView' and count(parameter)=0]"
            [Register("getHeaderView", "()Landroid/view/View;", "GetGetHeaderViewHandler")]
            get
            {
                const string __id = "getHeaderView.()Landroid/view/View;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Android.Views.View>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getItem_I;
#pragma warning disable 0169
        static Delegate GetGetItem_IHandler()
        {
            if (cb_getItem_I == null)
                cb_getItem_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_GetItem_I);
            return cb_getItem_I;
        }

        static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.GetItem(position));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getItem", "(I)Lcn/sharesdk/onekeyshare/themes/classic/FriendAdapter$Following;", "GetGetItem_IHandler")]
        public override unsafe global::Java.Lang.Object GetItem(int position)
        {
            const string __id = "getItem.(I)Lcn/sharesdk/onekeyshare/themes/classic/FriendAdapter$Following;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter.Following>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_getItemId_I;
#pragma warning disable 0169
        static Delegate GetGetItemId_IHandler()
        {
            if (cb_getItemId_I == null)
                cb_getItemId_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, long>)n_GetItemId_I);
            return cb_getItemId_I;
        }

        static long n_GetItemId_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetItemId(position);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getItemId", "(I)J", "GetGetItemId_IHandler")]
        public override unsafe long GetItemId(int position)
        {
            const string __id = "getItemId.(I)J";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualInt64Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
        static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler()
        {
            if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
                cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>)n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
            return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
        }

        static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.View convertView = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_convertView, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetView(position, convertView, parent));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
        [Register("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
        public override unsafe global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
        {
            const string __id = "getView.(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(position);
                __args[1] = new JniArgumentValue((convertView == null) ? IntPtr.Zero : ((global::Java.Lang.Object)convertView).Handle);
                __args[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object)parent).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Android.Views.View>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_onCancel_Lcn_sharesdk_framework_Platform_I;
#pragma warning disable 0169
        static Delegate GetOnCancel_Lcn_sharesdk_framework_Platform_IHandler()
        {
            if (cb_onCancel_Lcn_sharesdk_framework_Platform_I == null)
                cb_onCancel_Lcn_sharesdk_framework_Platform_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnCancel_Lcn_sharesdk_framework_Platform_I);
            return cb_onCancel_Lcn_sharesdk_framework_Platform_I;
        }

        static void n_OnCancel_Lcn_sharesdk_framework_Platform_I(IntPtr jnienv, IntPtr native__this, IntPtr native_plat, int action)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::CN.Sharesdk.Framework.Platform plat = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform>(native_plat, JniHandleOwnership.DoNotTransfer);
            __this.OnCancel(plat, action);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='onCancel' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int']]"
        [Register("onCancel", "(Lcn/sharesdk/framework/Platform;I)V", "GetOnCancel_Lcn_sharesdk_framework_Platform_IHandler")]
        public virtual unsafe void OnCancel(global::CN.Sharesdk.Framework.Platform plat, int action)
        {
            const string __id = "onCancel.(Lcn/sharesdk/framework/Platform;I)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((plat == null) ? IntPtr.Zero : ((global::Java.Lang.Object)plat).Handle);
                __args[1] = new JniArgumentValue(action);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_;
#pragma warning disable 0169
        static Delegate GetOnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_Handler()
        {
            if (cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ == null)
                cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>)n_OnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_);
            return cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_;
        }

        static void n_OnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_(IntPtr jnienv, IntPtr native__this, IntPtr native_plat, int action, IntPtr native_res)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::CN.Sharesdk.Framework.Platform plat = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform>(native_plat, JniHandleOwnership.DoNotTransfer);
            var res = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle(native_res, JniHandleOwnership.DoNotTransfer);
            __this.OnComplete(plat, action, res);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
        [Register("onComplete", "(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V", "GetOnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_Handler")]
        public virtual unsafe void OnComplete(global::CN.Sharesdk.Framework.Platform plat, int action, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> res)
        {
            const string __id = "onComplete.(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V";
            IntPtr native_res = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle(res);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((plat == null) ? IntPtr.Zero : ((global::Java.Lang.Object)plat).Handle);
                __args[1] = new JniArgumentValue(action);
                __args[2] = new JniArgumentValue(native_res);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_res);
            }
        }

        static Delegate cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_;
#pragma warning disable 0169
        static Delegate GetOnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_Handler()
        {
            if (cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ == null)
                cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>)n_OnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_);
            return cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_;
        }

        static void n_OnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_plat, int action, IntPtr native_t)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::CN.Sharesdk.Framework.Platform plat = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform>(native_plat, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable>(native_t, JniHandleOwnership.DoNotTransfer);
            __this.OnError(plat, action, t);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Throwable']]"
        [Register("onError", "(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V", "GetOnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_Handler")]
        public virtual unsafe void OnError(global::CN.Sharesdk.Framework.Platform plat, int action, global::Java.Lang.Throwable t)
        {
            const string __id = "onError.(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((plat == null) ? IntPtr.Zero : ((global::Java.Lang.Object)plat).Handle);
                __args[1] = new JniArgumentValue(action);
                __args[2] = new JniArgumentValue((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable)t).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
#pragma warning disable 0169
        static Delegate GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler()
        {
            if (cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ == null)
                cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_);
            return cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
        }

        static void n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Widget.AdapterView.IOnItemClickListener listener = (global::Android.Widget.AdapterView.IOnItemClickListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
            __this.SetOnItemClickListener(listener);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='setOnItemClickListener' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView.OnItemClickListener']]"
        [Register("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", "GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler")]
        public virtual unsafe void SetOnItemClickListener(global::Android.Widget.AdapterView.IOnItemClickListener listener)
        {
            const string __id = "setOnItemClickListener.(Landroid/widget/AdapterView$OnItemClickListener;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)listener).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setPlatform_Lcn_sharesdk_framework_Platform_;
#pragma warning disable 0169
        static Delegate GetSetPlatform_Lcn_sharesdk_framework_Platform_Handler()
        {
            if (cb_setPlatform_Lcn_sharesdk_framework_Platform_ == null)
                cb_setPlatform_Lcn_sharesdk_framework_Platform_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetPlatform_Lcn_sharesdk_framework_Platform_);
            return cb_setPlatform_Lcn_sharesdk_framework_Platform_;
        }

        static void n_SetPlatform_Lcn_sharesdk_framework_Platform_(IntPtr jnienv, IntPtr native__this, IntPtr native_platform)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::CN.Sharesdk.Framework.Platform platform = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform>(native_platform, JniHandleOwnership.DoNotTransfer);
            __this.SetPlatform(platform);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='setPlatform' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform']]"
        [Register("setPlatform", "(Lcn/sharesdk/framework/Platform;)V", "GetSetPlatform_Lcn_sharesdk_framework_Platform_Handler")]
        public virtual unsafe void SetPlatform(global::CN.Sharesdk.Framework.Platform platform)
        {
            const string __id = "setPlatform.(Lcn/sharesdk/framework/Platform;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object)platform).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setRatio_F;
#pragma warning disable 0169
        static Delegate GetSetRatio_FHandler()
        {
            if (cb_setRatio_F == null)
                cb_setRatio_F = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, float>)n_SetRatio_F);
            return cb_setRatio_F;
        }

        static void n_SetRatio_F(IntPtr jnienv, IntPtr native__this, float ratio)
        {
            global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetRatio(ratio);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendAdapter']/method[@name='setRatio' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setRatio", "(F)V", "GetSetRatio_FHandler")]
        public virtual unsafe void SetRatio(float ratio)
        {
            const string __id = "setRatio.(F)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(ratio);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

    }
}
