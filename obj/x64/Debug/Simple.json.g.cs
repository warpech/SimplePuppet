// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Simple.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Simple {
using __Simple__ = global::Simple.Simple;
using __SiSchema__ = global::Simple.Simple.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __Simple1__ = global::Simple.Simple.JsonByExample;
using __Simple2__ = global::Simple.Simple.Input;
using __SiHtml__ = global::Simple.Simple.Input.Html;
using __SiText__ = global::Simple.Simple.Input.Text;
using __SiReverse__ = global::Simple.Simple.Input.Reverse;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class Simple : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SiSchema__ DefaultTemplate = new __SiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Simple() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Simple(__SiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SiSchema__ Template { get { return (__SiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private System.String __bf__Text__;
    private System.Int64 __bf__Reverse__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Simple__);
                ClassName = "Simple";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/simple.html";
                Html.SetCustomAccessors((_p_) => { return ((__Simple__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Simple__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Text = Add<__TString__>("Text$");
                Text.DefaultValue = "";
                Text.Editable = true;
                Text.SetCustomAccessors((_p_) => { return ((__Simple__)_p_).__bf__Text__; }, (_p_, _v_) => { ((__Simple__)_p_).__bf__Text__ = (System.String)_v_; }, false);
                Reverse = Add<__TLong__>("Reverse$");
                Reverse.DefaultValue = 0L;
                Reverse.Editable = true;
                Reverse.SetCustomAccessors((_p_) => { return ((__Simple__)_p_).__bf__Reverse__; }, (_p_, _v_) => { ((__Simple__)_p_).__bf__Reverse__ = (System.Int64)_v_; }, false);
                Reverse.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Reverse() { App = (Simple)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((Simple)pup).Handle((Input.Reverse)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Simple__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Text;
            public __TLong__ Reverse;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "Simple.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "Simple.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Text {
#line 3 "Simple.json"
    get {
#line hidden
        return Template.Text.Getter(this); }
#line 3 "Simple.json"
    set {
#line hidden
        Template.Text.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Reverse {
#line 5 "Simple.json"
    get {
#line hidden
        return Template.Reverse.Getter(this); }
#line 5 "Simple.json"
    set {
#line hidden
        Template.Reverse.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Simple__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Text : Input<__Simple__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Reverse : Input<__Simple__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Simple_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
