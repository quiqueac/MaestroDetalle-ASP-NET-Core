#pragma checksum "C:\Users\CARRILLO URTIZ\Downloads\MaestroDetalle\MaestroDetalle\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "448dea49ead0214837c020dba8e7426b39a1f9e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\CARRILLO URTIZ\Downloads\MaestroDetalle\MaestroDetalle\Views\_ViewImports.cshtml"
using MaestroDetalle;

#line default
#line hidden
#line 2 "C:\Users\CARRILLO URTIZ\Downloads\MaestroDetalle\MaestroDetalle\Views\_ViewImports.cshtml"
using MaestroDetalle.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448dea49ead0214837c020dba8e7426b39a1f9e7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6051e6deb102ee15440914f48395c98e7c7ad66f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\CARRILLO URTIZ\Downloads\MaestroDetalle\MaestroDetalle\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2676, true);
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header"">
        Venta
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <div class=""mb-2"">
                    <label for=""exampleInputEmail"" class=""form-label"">Numero Documento</label>
                    <input type=""text"" class=""form-control form-control-sm"" id=""txtnumerodocumento"" />
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""mb-2"">
                    <label for=""exampleInputEmail"" class=""form-label"">Razon Social</label>
                    <input type=""text"" class=""form-control form-control-sm"" id=""txtrazonsocial"" />
                </div>
            </div>
        </div>
        <hr />
        <div class=""row align-items-end"">
            <div class=""col-sm-3"">
                <div class=""mb-2"">
                    <label for=""exampleInputEmail"" class=""form-label"">Producto</label>
                    <input type");
            WriteLiteral(@"=""text"" class=""form-control form-control-sm"" id=""txtproducto"" />
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""mb-2"">
                    <label for=""exampleInputEmail"" class=""form-label"">Precio</label>
                    <input type=""text"" class=""form-control form-control-sm"" id=""txtprecio"" />
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""mb-2"">
                    <label for=""exampleInputEmail"" class=""form-label"">Cantidad</label>
                    <input type=""text"" class=""form-control form-control-sm"" id=""txtcantidad"" />
                </div>
            </div>
            <div class=""col-sm-3"">
                <button class=""btn btn-primary mb-2 btn-sm"" id=""btnAgregar"">Agregar</button>
                <button class=""btn btn-primary mb-2 btn-sm"" id=""btnTerminar"">Terminar</button>
            </div>
        </div>
        <div class=""row"">
            <div class=""col");
            WriteLiteral(@"-sm-12"">
                <table class=""table table-bordered table-sm"" id=""tbProducto"">
                    <thead class=""table-dark"">
                        <tr>
                            <th scope=""col"">Producto</th>
                            <th scope=""col"">Precio</th>
                            <th scope=""col"">Cantidad</th>
                            <th scope=""col"">Total</th>
                        </tr>
                    </thead>
                    <tbody>
                        
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2738, 1530, true);
                WriteLiteral(@" 
    <script>
        $(""#btnAgregar"").on(""click"", function () {
            var total = parseFloat($(""#txtprecio"").val()) * parseFloat($(""#txtcantidad"").val())

            $(""#tbProducto tbody"").append(
                $(""<tr>"").append(
                    $(""<td>"").text($(""#txtproducto"").val()),
                    $(""<td>"").text($(""#txtprecio"").val()),
                    $(""<td>"").text($(""#txtcantidad"").val()),
                    $(""<td>"").text(total)
                )
            )
        })

        $(""#btnTerminar"").on(""click"", function () {
            var detalle_venta = []
            var total = 0

            $(""#tbProducto > tbody > tr"").each(function (index, tr) {
                detalle_venta.push(
                    {
                        Producto: $(tr).find(""td:eq(0)"").text(),
                        Precio: parseFloat($(tr).find(""td:eq(1)"").text()),
                        Cantidad: parseInt($(tr).find(""td:eq(2)"").text()),
                        Total: pars");
                WriteLiteral(@"eFloat($(tr).find(""td:eq(3)"").text())
                    }
                )
                total = total + parseFloat($(tr).find(""td:eq(3)"").text());
            })

            var venta = {
                NumeroDocumento: $(""#txtnumerodocumento"").val(),
                RazonSocial: $(""#txtrazonsocial"").val(),
                Total: total,
                lstDetalleVenta: detalle_venta
            }

            console.log(venta);

            jQuery.ajax({
                url: """);
                EndContext();
                BeginContext(4269, 33, false);
#line 109 "C:\Users\CARRILLO URTIZ\Downloads\MaestroDetalle\MaestroDetalle\Views\Home\Index.cshtml"
                 Write(Url.Action("GuardarVenta","Home"));

#line default
#line hidden
                EndContext();
                BeginContext(4302, 445, true);
                WriteLiteral(@""",
                type: ""POST"",
                data: JSON.stringify(venta),
                dataType: ""json"",
                contentType: ""application/json; charset=utf-8"",
                success: function (data) {
                    console.log(data)

                    if (data.respuesta) {
                        alert(""Venta Registrada"")
                    }
                }
            })
        })
    </script>
");
                EndContext();
            }
            );
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
