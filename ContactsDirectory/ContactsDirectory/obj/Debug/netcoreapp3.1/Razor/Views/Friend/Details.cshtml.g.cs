#pragma checksum "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08796c7cd4f9474f227c56d907660b381d96271a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_Details), @"mvc.1.0.view", @"/Views/Friend/Details.cshtml")]
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
#line 1 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\_ViewImports.cshtml"
using ContactsDirectory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\_ViewImports.cshtml"
using ContactsDirectory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08796c7cd4f9474f227c56d907660b381d96271a", @"/Views/Friend/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c2030ad3a3e6f0e9cc56388325e262a01098a", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactsDirectory.Models.PersonViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
  
    ViewData["Title"] = "Friend Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table class=\"table table-hover\"> \r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 9 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>Address</td>\r\n            <td>\r\n                <table id=\"address\" class=\"table table-bordered table-hover\">\r\n\r\n                    <tbody>\r\n");
#nullable restore
#line 20 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                         foreach (var address in Model.Adresses)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 23 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                               Write(address.Locality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 24 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                               Write(address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 25 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                               Write(address.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 27 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </td>
        </tr>
        <tr>
            <td>Contact</td>
            <td>
                <table id=""contacts"" class=""table table-bordered table-hover"">

                    <tbody>
");
#nullable restore
#line 38 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                         foreach (var contact in Model.Contacts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 41 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                               Write(contact.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"
                               Write(contact.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 44 "F:\MyDevEnv\GitHub_Workspace\ContactsDirectory\ContactsDirectory\ContactsDirectory\Views\Friend\Details.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </td>\r\n\r\n        </tr>\r\n        </tbody>\r\n</table>\r\n\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactsDirectory.Models.PersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
