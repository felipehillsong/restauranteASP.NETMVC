#pragma checksum "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73209601a7936785347d548fc634c7751fdd0527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurante_Pedidos), @"mvc.1.0.view", @"/Views/Restaurante/Pedidos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurante/Pedidos.cshtml", typeof(AspNetCore.Views_Restaurante_Pedidos))]
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
#line 1 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\_ViewImports.cshtml"
using Restaurante;

#line default
#line hidden
#line 2 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\_ViewImports.cshtml"
using Restaurante.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73209601a7936785347d548fc634c7751fdd0527", @"/Views/Restaurante/Pedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce95565ab14cb6eab89afdc2658dfaeb0263356", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurante_Pedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Restaurante.Models.Pedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
  
    ViewData["Title"] = "Pedidos Cozinha";

#line default
#line hidden
            BeginContext(98, 228, true);
            WriteLiteral("\r\n<h2>Pedidos</h2>\r\n\r\n\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th>Mesa do Cliente</th>\r\n        <th>Nome do Cliente</th>\r\n        <th>Pedidos</th>\r\n        <th>Quantidade</th>\r\n        <th>Horario</th>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
     if(Model != null){
    
    

#line default
#line hidden
#line 19 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
     foreach (var pedido in Model) {

#line default
#line hidden
            BeginContext(395, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(418, 11, false);
#line 21 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.Mesa);

#line default
#line hidden
            EndContext();
            BeginContext(429, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(449, 11, false);
#line 22 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(460, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(480, 13, false);
#line 23 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.Pratos);

#line default
#line hidden
            EndContext();
            BeginContext(493, 19, true);
            WriteLiteral(" <br>\r\n            ");
            EndContext();
            BeginContext(513, 14, false);
#line 24 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.Bebidas);

#line default
#line hidden
            EndContext();
            BeginContext(527, 18, true);
            WriteLiteral("<br>\r\n            ");
            EndContext();
            BeginContext(546, 17, false);
#line 25 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.Sobremesas);

#line default
#line hidden
            EndContext();
            BeginContext(563, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(583, 16, false);
#line 26 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.QtdPratos);

#line default
#line hidden
            EndContext();
            BeginContext(599, 21, true);
            WriteLiteral("  <br> \r\n            ");
            EndContext();
            BeginContext(621, 17, false);
#line 27 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.QtdBebidas);

#line default
#line hidden
            EndContext();
            BeginContext(638, 24, true);
            WriteLiteral(" <br>     \r\n            ");
            EndContext();
            BeginContext(663, 20, false);
#line 28 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.QtdSobremesas);

#line default
#line hidden
            EndContext();
            BeginContext(683, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(703, 11, false);
#line 29 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
       Write(pedido.Data);

#line default
#line hidden
            EndContext();
            BeginContext(714, 40, true);
            WriteLiteral("</td>\r\n        \r\n        \r\n\r\n    </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
    }

#line default
#line hidden
#line 34 "C:\Users\Felipe\source\repos\restauranteASP.NETMVC\Restaurante\Views\Restaurante\Pedidos.cshtml"
     
    }

#line default
#line hidden
            BeginContext(768, 10, true);
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Restaurante.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
