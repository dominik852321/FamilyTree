#pragma checksum "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "345f165b58e00f1c76e29ce22cf2397e579da52c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__people), @"mvc.1.0.view", @"/Views/Home/_people.cshtml")]
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
#line 1 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\_ViewImports.cshtml"
using DominikO_Tree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\_ViewImports.cshtml"
using DominikO_Tree.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\_ViewImports.cshtml"
using DominikO_Tree.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345f165b58e00f1c76e29ce22cf2397e579da52c", @"/Views/Home/_people.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb79f2d06251e60e585940dcad6a27f230fc5a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__people : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
 foreach (var a in Model.Where(x => x.ParentId == 0))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"list-group-item m-1\" style=\"cursor: pointer;\" data-toggle=\"collapse\" data-target=#");
#nullable restore
#line 6 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                                                                            Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=", 217, "", 239, 1);
#nullable restore
#line 7 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
WriteAttributeValue("", 232, a.Name, 232, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                              Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=", 272, "", 283, 1);
#nullable restore
#line 9 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
WriteAttributeValue("", 276, a.Name, 276, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\">\r\n        <ul>\r\n");
#nullable restore
#line 11 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
             foreach (var b in Model.Where(x => x.ParentId == a.Id))
            {
              

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item m-1\" style=\"cursor: pointer;\" data-toggle=\"collapse\"\r\n                        data-target=#");
#nullable restore
#line 15 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=", 584, "", 606, 1);
#nullable restore
#line 15 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
WriteAttributeValue("", 599, b.Name, 599, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                                                                   Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=", 647, "", 658, 1);
#nullable restore
#line 17 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
WriteAttributeValue("", 651, b.Name, 651, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\">\r\n                        <ul>\r\n");
#nullable restore
#line 19 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                             foreach (var c in Model.Where(x => x.ParentId == b.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item m-1\" style=\"cursor: pointer;\" data-toggle=\"collapse\"\r\n                                  data-target=#");
#nullable restore
#line 22 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                          Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=", 1013, "", 1035, 1);
#nullable restore
#line 22 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
WriteAttributeValue("", 1028, c.Name, 1028, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                                                                             Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
            WriteLiteral("                                  <div");
            BeginWriteAttribute("id", " id=", 1090, "", 1101, 1);
#nullable restore
#line 24 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
WriteAttributeValue("", 1094, c.Name, 1094, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\">\r\n                                      <ul>\r\n");
#nullable restore
#line 26 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                           foreach (var d in Model.Where(x => x.ParentId == c.Id))
                                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                              <li class=\"list-group-item m-1\" >");
#nullable restore
#line 28 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                                                          Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      </ul>\r\n                                  </div>\r\n");
#nullable restore
#line 32 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 35 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\Dominik\Projekty\DominikO_Tree\Views\Home\_people.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591