#pragma checksum "C:\Users\yumii\OneDrive\Escritorio\TEC\I Semestre\Diseño de Software\Proyecto\Visual Studio - Project\PetStay\Pages\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac8091c7bec53ac8184a3ebdb6b85acfef556f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PetStay.Pages.Pages_Registro), @"mvc.1.0.razor-page", @"/Pages/Registro.cshtml")]
namespace PetStay.Pages
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
#line 1 "C:\Users\yumii\OneDrive\Escritorio\TEC\I Semestre\Diseño de Software\Proyecto\Visual Studio - Project\PetStay\Pages\_ViewImports.cshtml"
using PetStay;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac8091c7bec53ac8184a3ebdb6b85acfef556f0", @"/Pages/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb477f7bd30767f8c5788057fc275b0ec9468158", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Registro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("anuncio-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/petlogo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\yumii\OneDrive\Escritorio\TEC\I Semestre\Diseño de Software\Proyecto\Visual Studio - Project\PetStay\Pages\Registro.cshtml"
  
    ViewData["Title"] = "Registro";
    Layout = "LayoutLogin";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"limiter\">\r\n    <div class=\"container-login100\" style=\"background-image: url(\'images/bg-01.jpg\');\">\r\n        <div class=\"wrap-login100\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac8091c7bec53ac8184a3ebdb6b85acfef556f05117", async() => {
                WriteLiteral(@"
                <span class=""login100-form-logo"">
                    <i class=""zmdi zmdi-landscape""></i>
                </span>

                <h1 style=""color:#004879"">Registro de usuario </h1>

                <h2>
                    Por favor proporciona los siguientes datos para poder realizar el registro.
                </h2>
                <div class=""cont-formulario"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bac8091c7bec53ac8184a3ebdb6b85acfef556f05797", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    <div style=""display: flex;flex-direction: column;"">
                        <div class=""wrap-input100 validate-input "" data-validate=""Nombre"">
                            <h3 style=""font-size: 20px;"">Nombre</h3><br>
                            <input class=""input100 form-entry"" type=""text"" size=""40"" name=""nombre"" required>
                            <span class=""focus-input100"" data-placeholder=""&#xf207;""></span>
                        </div><br>

                        <div class=""wrap-input100 validate-input"">
                            <h3 style=""font-size: 20px;"">Apellidos </h3><br>
                            <input class=""input100 form-entry"" type=""text"" size=""40"" name=""apellidos"" required>
                            <span class=""focus-input100"" data-placeholder=""&#xf207;""></span>
                        </div><br>

                        <div class=""wrap-input100 validate-input"">
                            <h3 style=""font-size: 20px;"">Dirección de correo ele");
                WriteLiteral(@"ctrónico:</h3><br>
                            <input class="" input100 form-entry"" type=""text"" size=""40"" name=""correo"" required>
                            <span class=""focus-input100"" data-placeholder=""&#xf207;""></span>
                        </div><br>
                        <div class=""wrap-input100 validate-input"">
                            <h3 style=""font-size: 20px;"">Contraseña:</h3><br>
                            <input class="" input100 form-entry"" type=""password"" size=""40"" name=""contraseña"" required>
                            <span class=""focus-input100"" data-placeholder=""&#xf207;""></span>
                        </div><br>
                        <div class=""wrap-input100 validate-input"">
                            <h3 style=""font-size: 20px;"">Confirmar contraseña:</h3><br>
                            <input class="" input100 form-entry"" type=""password"" size=""40"" name=""contraseñaConfirmada"" required>
                            <span class=""focus-input100"" data-placeholder=""&#xf20");
                WriteLiteral("7;\"></span>\r\n                        </div><br>\r\n                        <button style=\"align-self: center;\" class=\"btn-accept\">Registrar usuario</button>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        // Mostrar mensaje de error si existe\r\n        var errorMessage = \'");
#nullable restore
#line 65 "C:\Users\yumii\OneDrive\Escritorio\TEC\I Semestre\Diseño de Software\Proyecto\Visual Studio - Project\PetStay\Pages\Registro.cshtml"
                       Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        if (errorMessage !== """") {
            // Crear un elemento div con el mensaje de error
            var errorDiv = document.createElement(""div"");
            errorDiv.className = ""alert alert-danger"";
            errorDiv.innerText = errorMessage;

            // Insertar el elemento div en la página
            var form = document.getElementsByTagName(""form"")[0];
            form.insertBefore(errorDiv, form.firstChild);

            // Restaurar los valores ingresados por el usuario
            var correo = '");
#nullable restore
#line 77 "C:\Users\yumii\OneDrive\Escritorio\TEC\I Semestre\Diseño de Software\Proyecto\Visual Studio - Project\PetStay\Pages\Registro.cshtml"
                     Write(TempData["Correo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            var contraseña = \'");
#nullable restore
#line 78 "C:\Users\yumii\OneDrive\Escritorio\TEC\I Semestre\Diseño de Software\Proyecto\Visual Studio - Project\PetStay\Pages\Registro.cshtml"
                         Write(TempData["Contraseña"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            document.getElementById(\"Correo\").value = correo;\r\n            document.getElementById(\"Contraseña\").value = contraseña;\r\n        }\r\n\r\n        // Mostrar mensaje de éxito si existe\r\n        var successMessage = \'");
#nullable restore
#line 84 "C:\Users\yumii\OneDrive\Escritorio\TEC\I Semestre\Diseño de Software\Proyecto\Visual Studio - Project\PetStay\Pages\Registro.cshtml"
                         Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        if (successMessage !== """") {
            // Crear un elemento div con el mensaje de éxito
            var successDiv = document.createElement(""div"");
            successDiv.className = ""alert alert-success"";
            successDiv.innerText = successMessage;

            // Insertar el elemento div en la página
            var form = document.getElementsByTagName(""form"")[0];
            form.insertBefore(successDiv, form.firstChild);
        }

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetStay.Pages.RegistroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PetStay.Pages.RegistroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PetStay.Pages.RegistroModel>)PageContext?.ViewData;
        public PetStay.Pages.RegistroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
