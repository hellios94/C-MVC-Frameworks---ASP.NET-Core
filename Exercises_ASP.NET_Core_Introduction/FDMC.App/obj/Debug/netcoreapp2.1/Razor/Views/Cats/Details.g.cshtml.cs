#pragma checksum "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7df8035b0262346e0371c4c1d1426d7cdafbd36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cats_Details), @"mvc.1.0.view", @"/Views/Cats/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cats/Details.cshtml", typeof(AspNetCore.Views_Cats_Details))]
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
#line 1 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\_ViewImports.cshtml"
using FDMC.App;

#line default
#line hidden
#line 2 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\_ViewImports.cshtml"
using FDMC.App.Models;

#line default
#line hidden
#line 1 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml"
using FDMC.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7df8035b0262346e0371c4c1d1426d7cdafbd36", @"/Views/Cats/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce5ef016b60d259fc6991db360483d53b8663e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Cats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 10, true);
            WriteLiteral("\r\n    <h1>");
            EndContext();
            BeginContext(91, 10, false);
#line 9 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(101, 17, true);
            WriteLiteral("</h1>\r\n\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 118, "\"", 139, 1);
#line 11 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml"
WriteAttributeValue("", 124, Model.ImageUrl, 124, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 140, "\"", 157, 1);
#line 11 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml"
WriteAttributeValue("", 146, Model.Name, 146, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(158, 68, true);
            WriteLiteral(" style=\"max-width: 300px\"/>\r\n\r\n    <p style=\"font-weight:bold\">Age: ");
            EndContext();
            BeginContext(227, 9, false);
#line 13 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml"
                                Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(236, 46, true);
            WriteLiteral("</p>\r\n    <p style=\"font-weight:bold;\">Breed: ");
            EndContext();
            BeginContext(283, 11, false);
#line 14 "D:\.Net Developement\C# MVC Frameworks - ASP.NET Core\Exercises_ASP.NET_Core_Introduction\FDMC.App\Views\Cats\Details.cshtml"
                                   Write(Model.Breed);

#line default
#line hidden
            EndContext();
            BeginContext(294, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cat> Html { get; private set; }
    }
}
#pragma warning restore 1591
