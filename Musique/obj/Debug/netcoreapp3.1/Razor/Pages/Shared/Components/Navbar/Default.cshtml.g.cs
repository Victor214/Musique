#pragma checksum "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b0b8df35611d37ef1b8fc1bf944dde28eef1e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Musique.Pages.Shared.Components.Navbar.Pages_Shared_Components_Navbar_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Navbar/Default.cshtml")]
namespace Musique.Pages.Shared.Components.Navbar
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
#line 1 "C:\Users\Victor\source\repos\Musique\Musique\Pages\_ViewImports.cshtml"
using Musique;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b0b8df35611d37ef1b8fc1bf944dde28eef1e9", @"/Pages/Shared/Components/Navbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e171c9e7c7d05fee265dd53e500af9f1ef94f153", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Navbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdc-tab mdc-tab--active underlineless"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("tab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-selected", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Header (TopAppBar) -->
<header class=""mdc-top-app-bar mdc-top-app-bar--fixed top-bar mdc-elevation--z5"" data-mdc-auto-init=""MDCTopAppBar"">
    <div class=""mdc-top-app-bar__row"">
        <section class=""mdc-top-app-bar__section mdc-top-app-bar__section--align-start"">
            <span class=""mdc-top-app-bar__title"">
                <span class=""material-icons music-icon"">music_note</span>
                Musique
            </span>
        </section>

        <div class=""row"">
            <div class=""col"">
                <!-- Create new sections as needed-->
                <section class=""mdc-top-app-bar__section mdc-top-app-bar__section--align-end google-name-section"">

                </section>

                <section class=""mdc-top-app-bar__section mdc-top-app-bar__section--align-end"">
                    <!-- Tab Bar inside a Top App Bar -->
                    <div class=""mdc-tab-bar"" role=""tablist"">
                        <div class=""mdc-tab-scroller menu-tab-bar"">
     ");
            WriteLiteral(@"                       <div class=""mdc-tab-scroller__scroll-area"">
                                <div class=""mdc-tab-scroller__scroll-content"">
                                    <!-- Google Account Name -->
                                    <div class=""mdc-tab mdc-tab--active underlineless"" asp-page=""/Index"" role=""tab"" aria-selected=""true"" tabindex=""0"">
                                        <!-- set it to --active depending on which page we are (likely will have to migrate this to a view component) -->
                                        <span class=""mdc-tab__content mdc-typography--caption"">
                                            <span class=""mdc-tab__text-label"">
");
#nullable restore
#line 30 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                                 if (User.Identity.IsAuthenticated)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div>Welcome, ");
#nullable restore
#line 32 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                                             Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 33 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </span>\r\n                                        </span>\r\n                                    </div>\r\n\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                     if (!User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b0b8df35611d37ef1b8fc1bf944dde28eef1e99872", async() => {
                WriteLiteral(@"
                                            <!-- set it to --active depending on which page we are (likely will have to migrate this to a view component) -->
                                            <span class=""mdc-tab__content mdc-typography--caption"">
                                                <span class=""mdc-tab__icon material-icons"" aria-hidden=""true"">home</span>
                                                <span class=""mdc-tab__text-label"">Home</span>
                                            </span>
                                            <span class=""mdc-tab-indicator mdc-tab-indicator--active"">
                                                <span class=""mdc-tab-indicator__content mdc-tab-indicator__content--underline""></span>
                                            </span>
                                            <span class=""mdc-tab__ripple""></span>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b0b8df35611d37ef1b8fc1bf944dde28eef1e912678", async() => {
                WriteLiteral(@"
                                            <!-- set it to --active depending on which page we are (likely will have to migrate this to a view component) -->
                                            <span class=""mdc-tab__content mdc-typography--caption"">
                                                <span class=""mdc-tab__icon material-icons"" aria-hidden=""true"">dashboard</span>
                                                <span class=""mdc-tab__text-label"">Dashboard</span>
                                            </span>
                                            <span class=""mdc-tab-indicator mdc-tab-indicator--active"">
                                                <span class=""mdc-tab-indicator__content mdc-tab-indicator__content--underline""></span>
                                            </span>
                                            <span class=""mdc-tab__ripple""></span>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <!-- Login Button  -->\r\n                                    <!-- (Only shown for logged out users)  -->\r\n");
#nullable restore
#line 70 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                     if (!User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b0b8df35611d37ef1b8fc1bf944dde28eef1e915879", async() => {
                WriteLiteral(@"
                                            <span class=""mdc-tab__content mdc-typography--caption"">
                                                <span class=""mdc-tab__icon material-icons"" aria-hidden=""true"">login</span>
                                                <span class=""mdc-tab__text-label"">Login</span>
                                            </span>
                                            <span class=""mdc-tab-indicator mdc-tab-indicator"">
                                                <span class=""mdc-tab-indicator__content mdc-tab-indicator__content--underline""></span>
                                            </span>
                                            <span class=""mdc-tab__ripple""></span>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    <!-- Google Sign Out Button  -->\r\n                                    <!-- (Only shown for logged in users) -->\r\n");
#nullable restore
#line 87 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                     if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""g-signin2"" hidden></div>
                                        <a class=""mdc-tab mdc-tab--active underlineless"" onclick=""signOut();"" role=""tab"" aria-selected=""true"" tabindex=""3"">
                                            <span class=""mdc-tab__content mdc-typography--caption"">
                                                <span class=""mdc-tab__icon material-icons"" aria-hidden=""true"">logout</span>
                                                <span class=""mdc-tab__text-label"">Logout</span>
                                            </span>
                                            <span class=""mdc-tab-indicator mdc-tab-indicator"">
                                                <span class=""mdc-tab-indicator__content mdc-tab-indicator__content--underline""></span>
                                            </span>
                                            <span class=""mdc-tab__ripple""></span>
                                        </a>
            WriteLiteral("\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b0b8df35611d37ef1b8fc1bf944dde28eef1e920000", async() => {
                WriteLiteral("\r\n                                            <input name=\"test\" type=\"hidden\" />\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <script>
                                            function signOut() {
                                                var auth2 = gapi.auth2.getAuthInstance();
                                                auth2.signOut().then(function () {
                                                    // Redirect to logout page
                                                    console.log('User signed out.');
                                                    document.getElementById('logoutForm').submit();
                                                });
                                            }
                                        </script>
");
#nullable restore
#line 113 "C:\Users\Victor\source\repos\Musique\Musique\Pages\Shared\Components\Navbar\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>

  
    </div>
</header>

<!-- Autoinit Header -->
<script type=""text/javascript"">
        window.mdc.autoInit();
</script>");
        }
        #pragma warning restore 1998
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