#pragma checksum "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b9cbbde36053f4f78ba978ebd44016af3e0762d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Index), @"mvc.1.0.view", @"/Views/Pets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pets/Index.cshtml", typeof(AspNetCore.Views_Pets_Index))]
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
#line 1 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
using Tamagotchi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b9cbbde36053f4f78ba978ebd44016af3e0762d", @"/Views/Pets/Index.cshtml")]
    public class Views_Pets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 24, true);
            WriteLiteral("\n<h1>My Pets</h1>\n<ul>\n\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(75, 27, true);
            WriteLiteral("  <p>You have no pets!</p>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
}

#line default
#line hidden
#line 10 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
 if(Model.Count != 0)
{
  

#line default
#line hidden
#line 12 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
   foreach (Pet pet in Model)
  {

#line default
#line hidden
            BeginContext(162, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 172, "\"", 197, 2);
            WriteAttributeValue("", 179, "/pets/", 179, 6, true);
#line 14 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
WriteAttributeValue("", 185, pet.GetId(), 185, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(198, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(200, 13, false);
#line 14 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
                                Write(pet.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(213, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
  }

#line default
#line hidden
#line 15 "/Users/Guest/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Index.cshtml"
   
}

#line default
#line hidden
            BeginContext(229, 46, true);
            WriteLiteral("\n</ul>\n<a href=\"/pets/new\">Add a new Pet!</a>\n");
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
