#pragma checksum "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7c7127ed252c5272ce75050b3f1273b5a1e149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Show), @"mvc.1.0.view", @"/Views/Pets/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pets/Show.cshtml", typeof(AspNetCore.Views_Pets_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7c7127ed252c5272ce75050b3f1273b5a1e149", @"/Views/Pets/Show.cshtml")]
    public class Views_Pets_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 22, true);
            WriteLiteral("<h1>My Pet:</h1>\n\n<h2>");
            EndContext();
            BeginContext(23, 15, false);
#line 3 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml"
Write(Model.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(38, 80, true);
            WriteLiteral("</h2>\n\n<a href=\"/pets/new\">Add another pet</a>\n<a href=\"/pets\">View my pets</a>\n");
            EndContext();
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
