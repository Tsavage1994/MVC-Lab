#pragma checksum "C:\Users\there\source\repos\MVC.2_LAB\MVC.2_LAB\Views\MileageFormController1\FormResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99227a835a651f6b084ab8fd651e9396f8130735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MileageFormController1_FormResults), @"mvc.1.0.view", @"/Views/MileageFormController1/FormResults.cshtml")]
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
#line 1 "C:\Users\there\source\repos\MVC.2_LAB\MVC.2_LAB\Views\_ViewImports.cshtml"
using MVC._2_LAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\there\source\repos\MVC.2_LAB\MVC.2_LAB\Views\_ViewImports.cshtml"
using MVC._2_LAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99227a835a651f6b084ab8fd651e9396f8130735", @"/Views/MileageFormController1/FormResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f1c5307a93f60daa14c7fb585c6bfd1802a0e79", @"/Views/_ViewImports.cshtml")]
    public class Views_MileageFormController1_FormResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC._2_LAB.Models.MileageFormController1.FormResultsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Gas in YO CAR: ");
#nullable restore
#line 9 "C:\Users\there\source\repos\MVC.2_LAB\MVC.2_LAB\Views\MileageFormController1\FormResults.cshtml"
              Write(Model.GallonsInTank);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and MPG of ");
#nullable restore
#line 9 "C:\Users\there\source\repos\MVC.2_LAB\MVC.2_LAB\Views\MileageFormController1\FormResults.cshtml"
                                              Write(Model.Mileage);

#line default
#line hidden
#nullable disable
            WriteLiteral(". You can go ");
#nullable restore
#line 9 "C:\Users\there\source\repos\MVC.2_LAB\MVC.2_LAB\Views\MileageFormController1\FormResults.cshtml"
                                                                         Write(Model.Miles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC._2_LAB.Models.MileageFormController1.FormResultsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
