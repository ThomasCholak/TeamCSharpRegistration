#pragma checksum "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\Catalog\Browse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be798465981d222453c5148ccd6db1c9cddd11fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Browse), @"mvc.1.0.view", @"/Views/Catalog/Browse.cshtml")]
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
#line 1 "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\_ViewImports.cshtml"
using TeamCSharpRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\_ViewImports.cshtml"
using TeamCSharpRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be798465981d222453c5148ccd6db1c9cddd11fd", @"/Views/Catalog/Browse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e5609841641eb4beba4f53f71b9da5ab3d34f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Browse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!--Marshall - Provided styling for table.-->
<style>
    .course-catalog-table > tr > td {
    }

    .course-catalog-table td, .course-catalog-table th {
        padding-left: 0.25em;
        padding-right: 0.25em;
    }
</style>
<h1>Welcome to the course catalog!</h1>

<!-- Shanice - Setup course table using List passed by Entity to 
                verify connection  of front and back end.-->
<table class=""course-catalog-table"">
    <thead>
        <tr>
            <th>Course Name</th>
            <th>Course Number</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\Catalog\Browse.cshtml"
         foreach (Course course in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <style>\n                table, th, td {\n                border: 1px solid black;\n                 }\n            </style>\n                    <tr>\n                        <td>");
#nullable restore
#line 33 "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\Catalog\Browse.cshtml"
                       Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 34 "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\Catalog\Browse.cshtml"
                       Write(course.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\Catalog\Browse.cshtml"
                                          Write(course.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>");
#nullable restore
#line 35 "C:\Users\Thomas\Desktop\TeamCSharpRegistration-master\TeamCSharpRegistration\Views\Catalog\Browse.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
