#pragma checksum "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adbb3c44bdea606b6578f33c830c35d8071a67b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewTasksToDo), @"mvc.1.0.view", @"/Views/Home/ViewTasksToDo.cshtml")]
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
#line 1 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\_ViewImports.cshtml"
using Capstone_ToDo_List_REVISITED;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\_ViewImports.cshtml"
using Capstone_ToDo_List_REVISITED.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adbb3c44bdea606b6578f33c830c35d8071a67b0", @"/Views/Home/ViewTasksToDo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01011427fb71e2e2a53d27806cdc57d152a5b5fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewTasksToDo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Devs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
   
    ViewData["Title"] = "TaskIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Task Index</h1>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table table-bordered shadow table-hover table-info\">\r\n    <tr class=\"d-table-row\">\r\n        <th>TaskName</th>\r\n        <th>ItemDescription</th>\r\n        <th>DueDate</th>\r\n        <th>Complete</th>\r\n        <th></th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
     foreach (Devs Website in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
   Write(Website.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
   Write(Website.ItemDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
   Write(Website.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
     if (@Website.Complete == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>YEAH YOU DID IT! Nice job.</td>\r\n");
#nullable restore
#line 31 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>Not done yet! Keep pushing.</td>\r\n");
#nullable restore
#line 35 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td class=\"btn-danger\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 969, 2);
            WriteAttributeValue("", 936, "../Home/DeleteTask?Id=", 936, 22, true);
#nullable restore
#line 37 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
WriteAttributeValue("", 958, Website.Id, 958, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete this task</a>\r\n       \r\n    </td>\r\n    <td class=\"btn btn-success\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1097, 2);
            WriteAttributeValue("", 1064, "../Home/UpdateTask?Id=", 1064, 22, true);
#nullable restore
#line 41 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
WriteAttributeValue("", 1086, Website.Id, 1086, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update this task</a>\r\n</tr>\r\n");
#nullable restore
#line 43 "C:\Users\yllek\source\repos\Capstone ToDo List REVISITED\Capstone ToDo List REVISITED\Views\Home\ViewTasksToDo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"../Home/AddTask\" class=\"btn-primary\">Add a new task!</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Devs>> Html { get; private set; }
    }
}
#pragma warning restore 1591