#pragma checksum "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d37d93d469d1beb4c16dda4b78318ded4afa89a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\akmal\InvoiceKu\Views\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\akmal\InvoiceKu\Views\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\akmal\InvoiceKu\Views\_ViewImports.cshtml"
using InvoiceKu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\akmal\InvoiceKu\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
using Serenity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
using InvoiceKu.Administration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d37d93d469d1beb4c16dda4b78318ded4afa89a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4ae420adb1e9fa71547bc20b6b418563e9d6fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/ChangePassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-flat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Signout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n");
#nullable restore
#line 9 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
  
    Func<string, HtmlString> json = x => new HtmlString(Serenity.JSON.Stringify(x));
    var hideNav = (string)Context.Request.Query["hideNav"] == "1";
    var logged = User?.Identity?.Name;
    var themeCookie = Context.Request.Cookies["ThemePreference"];
    var theme = !themeCookie.IsEmptyOrNull() ? themeCookie : "blue";
    var darkSidebar = theme != null && theme.IndexOf("light") < 0;
    var rtl = System.Globalization.CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft;
    var user = User.GetUserDefinition<UserDefinition>(UserRetriever);
    var userImage = VirtualPathUtility.ToAbsolute(Context,
    (user == null || string.IsNullOrEmpty(user.UserImage)) ? "~/assets/images/bg-images/photo-placeholder.png" :
    "~/upload/" + user.UserImage);
    var tenantName = "";
    using (var connection = SqlConnections.NewFor<TenantRow>())
    {
        if (user != null)
        {
            var tenant = connection.ById<TenantRow>(user.TenantId);
            tenantName = tenant.TenantName;
        }
        else
        {
            Context.Response.Redirect("/Account/Signout");
        }
    }
    var defaultOptions = DefaultOptions.Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--[if IE 8]> <html lang=\"");
#nullable restore
#line 36 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                      Write(System.Globalization.CultureInfo.CurrentUICulture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"ie8 no-js\"> <![endif]-->\n<!--[if IE 9]> <html lang=\"");
#nullable restore
#line 37 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                      Write(System.Globalization.CultureInfo.CurrentUICulture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"ie9 no-js\"> <![endif]-->\n<!--[if !IE]><!-->\n<html");
            BeginWriteAttribute("lang", " lang=\"", 1716, "\"", 1778, 1);
#nullable restore
#line 39 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1723, System.Globalization.CultureInfo.CurrentUICulture.Name, 1723, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\n    class=\"", 1779, "\"", 1866, 3);
            WriteAttributeValue("", 1791, "no-js", 1791, 5, true);
#nullable restore
#line 40 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1796, hideNav ? " no-navigation" : "", 1796, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1830, Html.Raw(rtl ? " dir=\"rtl\"" : ""), 1830, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n<!--<![endif]-->\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d37d93d469d1beb4c16dda4b78318ded4afa89a10498", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d37d93d469d1beb4c16dda4b78318ded4afa89a10759", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
       WriteLiteral(MVC.Views.Shared._LayoutHead);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
#nullable restore
#line 45 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
Write(RenderSection("Head", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <title>");
#nullable restore
#line 46 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 46 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                             Write(Texts.Navigation.SiteTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d37d93d469d1beb4c16dda4b78318ded4afa89a13746", async() => {
                WriteLiteral("\n    <div id=\"PageBackground\" style=\"display: none\"></div>\n");
#nullable restore
#line 52 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
     if (hideNav)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script type=\"text/javascript\">\n            $(function () {\n            ");
#nullable restore
#line 56 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
       Write(RenderSection("PageInitScript", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            });\n        </script>\n        <div id=\"page-outer-nonav\">\n            <div id=\"page-container\" class=\"page-container-common\">\n                ");
#nullable restore
#line 61 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 64 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"wrapper\">\n            <header class=\"main-header\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d37d93d469d1beb4c16dda4b78318ded4afa89a15248", async() => {
                    WriteLiteral("\n                    <span class=\"logo-mini\">\n                        <div class=\"logo-bg\">\n");
                    WriteLiteral("                            <i class=\"fa fa-superpowers\"></i>\n                        </div>\n                    </span>\n                    <span class=\"logo-lg\">\n                        <div class=\"logo-bg\">\n");
                    WriteLiteral("                            <i class=\"fa fa-superpowers\"></i>\n                        </div>\n                        <b>");
#nullable restore
#line 81 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                      Write(defaultOptions.ApplicationName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b>\n                    </span>\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <nav class=""navbar navbar-static-top"" role=""navigation"">
                    <a href=""#"" class=""sidebar-toggle"" data-toggle=""offcanvas"" role=""button"">
                        <span class=""sr-only"">Toggle navigation</span>
                    </a>

                    <div class=""navbar-custom-menu"">
                        <ul class=""nav navbar-nav"">
                            <li class=""dropdown user user-menu"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                    <img");
                BeginWriteAttribute("src", " src=\"", 4078, "\"", 4094, 1);
#nullable restore
#line 93 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4084, userImage, 4084, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"user-image\" alt=\"User Image\">\n                                    <span class=\"hidden-xs\">");
#nullable restore
#line 94 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                                       Write(User?.Identity?.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                </a>
                                <ul class=""dropdown-menu"">
                                    <!-- User image -->
                                <li class=""user-header"">
                                        <img");
                BeginWriteAttribute("src", " src=\"", 4475, "\"", 4491, 1);
#nullable restore
#line 99 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4481, userImage, 4481, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-circle\" alt=\"User Image\">\n\n                                        <p>\n                                            ");
#nullable restore
#line 102 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                        Write(user != null ? user.DisplayName : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </p>
                                    </li>

                                    <!-- Menu Footer-->
                                <li class=""user-footer"">
                                        <div class=""pull-left"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d37d93d469d1beb4c16dda4b78318ded4afa89a19851", async() => {
                    WriteLiteral("<i\n                                                class=\"fa fa-lock fa-fw\"></i>\n                                                ");
#nullable restore
#line 111 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                           Write(Texts.Forms.Membership.ChangePassword.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        </div>\n                                        <div class=\"pull-right\">\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d37d93d469d1beb4c16dda4b78318ded4afa89a21608", async() => {
                    WriteLiteral("<i\n                                                class=\"fa fa-sign-out fa-fw\"></i>\n                                                ");
#nullable restore
#line 116 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                           Write(Localizer.Get("Navigation.LogoutLink"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </li>
                                </ul>
                            </li>

                            <li>
                                <a href=""#"" data-toggle=""control-sidebar""><i class=""fa fa-sliders""></i></a>
                            </li>
                        </ul>
                    </div>
                </nav>
            </header>

            <aside class=""main-sidebar"">
                <section class=""sidebar"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d37d93d469d1beb4c16dda4b78318ded4afa89a23733", async() => {
                    WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" id=""SidebarSearch"" name=""q"" class=""form-control"" autocomplete=""off"">
                            <span class=""input-group-btn"">
                                <button type=""button"" name=""search"" id=""search-btn"" class=""btn btn-flat""><i
                                    class=""fa fa-search""></i></button>
                            </span>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    <ul class=\"sidebar-menu\" id=\"SidebarMenu\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d37d93d469d1beb4c16dda4b78318ded4afa89a26014", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                           WriteLiteral(MVC.Views.Shared.LeftNavigation);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 143 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new InvoiceKu.Navigation.NavigationModel(Context);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </ul>\n                </section>\n            </aside>\n\n            <div class=\"content-wrapper\">\n");
#nullable restore
#line 149 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                 if (IsSectionDefined("ContentHeader"))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <section class=\"content-header\">\n                        ");
#nullable restore
#line 152 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                   Write(RenderSection("ContentHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </section>\n");
#nullable restore
#line 154 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <section class=\"content\">\n                    ");
#nullable restore
#line 156 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </section>\n            </div>\n\n            <footer class=\"main-footer\">\n                <div class=\"pull-right hidden-xs\">\n                    ");
#nullable restore
#line 162 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
               Write(defaultOptions.ApplicationName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Company: ");
#nullable restore
#line 162 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                                          Write(tenantName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <strong>");
#nullable restore
#line 164 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                   Write(defaultOptions.CopyrightWording);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> ");
#nullable restore
#line 164 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                                             Write(Texts.Site.Layout.FooterRights.ToString(Localizer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </footer>\n\n            <aside class=\"control-sidebar control-sidebar-dark\">\n                <div class=\"tab-content\">\n                    <div class=\"tab-pane active\" id=\"control-sidebar-settings-tab\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d37d93d469d1beb4c16dda4b78318ded4afa89a30720", async() => {
                    WriteLiteral("\n                            <h3 class=\"control-sidebar-heading\">");
#nullable restore
#line 171 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                                           Write(Texts.Site.Layout.GeneralSettings.ToString(Localizer));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h3>\n\n                            <div class=\"form-group\">\n                                <label\n                                class=\"control-sidebar-subheading\">");
#nullable restore
#line 175 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                                              Write(Texts.Site.Layout.Language.ToString(Localizer));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\n                                <select id=\"LanguageSelect\" class=\"form-control\"></select>\n                            </div>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </div>\n                </div>\n            </aside>\n            <div class=\"control-sidebar-bg\"></div>\n        </div>\n");
                WriteLiteral("        <script type=\"text/javascript\">\n            $().ready(function () {\n                new InvoiceKu.Common.SidebarSearch($(\'#SidebarSearch\'), $(\'#SidebarMenu\')).init();\n                new InvoiceKu.Common.LanguageSelection($(\'#LanguageSelect\'), \'");
#nullable restore
#line 188 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
                                                                          Write(System.Globalization.CultureInfo.CurrentUICulture.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\n            ");
#nullable restore
#line 189 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
       Write(RenderSection("PageInitScript", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

                var doLayout = function () {
                    height = (this.window.innerHeight > 0) ? this.window.innerHeight : this.screen.height;
                    height -= $('header.main-header').outerHeight() || 0;
                    height -= $('section.content-header').outerHeight() || 0;
                    height -= $('footer.main-footer').outerHeight() || 0;
                    if (height < 200) height = 200;
                    $(""section.content"").css(""min-height"", (height) + ""px"");

                    $('body').triggerHandler('layout');
                };

                $(window).bind(""load resize layout"", doLayout);
                doLayout();
            });
        </script>
");
#nullable restore
#line 206 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2090, "s-", 2090, 2, true);
#nullable restore
#line 49 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 2092, ViewData["PageId"], 2092, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2113, "Page", 2113, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 9, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 2130, ViewData["BodyClass"], 2130, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 2154, "fixed", 2155, 6, true);
            AddHtmlAttributeValue(" ", 2160, "sidebar-mini", 2161, 13, true);
            AddHtmlAttributeValue(" ", 2173, "hold-transition", 2174, 16, true);
            AddHtmlAttributeValue(" ", 2189, "skin-", 2190, 6, true);
#nullable restore
#line 50 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 2195, theme, 2195, 6, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue(" ", 2201, darkSidebar ? "dark-sidebar" : "light-sidebar", 2202, 49, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 2251, hideNav ? " no-navigation" : " has-layout-event", 2251, 51, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\akmal\InvoiceKu\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 2302, rtl ? " rtl" : "", 2302, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<DefaultOptions> DefaultOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISqlConnections SqlConnections { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.Abstractions.IUserRetrieveService UserRetriever { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
