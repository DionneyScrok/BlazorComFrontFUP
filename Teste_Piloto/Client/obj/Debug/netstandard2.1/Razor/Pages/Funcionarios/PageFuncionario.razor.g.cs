#pragma checksum "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb27301bf9156bfcc61b04bb4d940426b6d3ea65"
// <auto-generated/>
#pragma warning disable 1591
namespace Teste_Piloto.Client.Pages.Funcionarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Faculdade_FUP_Project.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class PageFuncionario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                  Funcionario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                 OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group col-md-12 roboto");
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.AddMarkupContent(14, "<label>Nome</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "required", true);
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.NomeFuncionario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.NomeFuncionario = __value, Funcionario.NomeFuncionario))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.NomeFuncionario));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 9 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.NomeFuncionario

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(28, "\n            ");
                __builder2.AddMarkupContent(29, "<label>RG</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "required", true);
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.Rg

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Rg = __value, Funcionario.Rg))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Rg));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 14 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.Rg

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(39, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(43, "\n            ");
                __builder2.AddMarkupContent(44, "<label>CPF</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "required", true);
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.Cpf

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Cpf = __value, Funcionario.Cpf))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Cpf));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 20 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.Cpf

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(58, "\n            ");
                __builder2.AddMarkupContent(59, "<label>Data Nascimento</label>\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputDate_3(__builder2, 60, 61, "form-control", 62, true, 63, 
#nullable restore
#line 25 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.Datanascimento

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Datanascimento = __value, Funcionario.Datanascimento)), 65, () => Funcionario.Datanascimento);
                __builder2.AddMarkupContent(66, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_4(__builder2, 67, 68, 
#nullable restore
#line 26 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.Datanascimento

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(73, "\n            ");
                __builder2.AddMarkupContent(74, "<label>Data Contratação</label>\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputDate_5(__builder2, 75, 76, "form-control", 77, true, 78, 
#nullable restore
#line 31 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.DataContratacao

#line default
#line hidden
#nullable disable
                , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.DataContratacao = __value, Funcionario.DataContratacao)), 80, () => Funcionario.DataContratacao);
                __builder2.AddMarkupContent(81, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_6(__builder2, 82, 83, 
#nullable restore
#line 32 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.DataContratacao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(84, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(88, "\n            ");
                __builder2.AddMarkupContent(89, "<label>Data Demissão</label>\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputDate_7(__builder2, 90, 91, "form-control", 92, true, 93, 
#nullable restore
#line 37 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.DataDemissao

#line default
#line hidden
#nullable disable
                , 94, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.DataDemissao = __value, Funcionario.DataDemissao)), 95, () => Funcionario.DataDemissao);
                __builder2.AddMarkupContent(96, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_8(__builder2, 97, 98, 
#nullable restore
#line 38 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.DataDemissao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(99, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n        ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(103, "\n            ");
                __builder2.AddMarkupContent(104, "<label>Gênero</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(105);
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "required", true);
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.Genero

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Genero = __value, Funcionario.Genero))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Genero));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_9(__builder2, 112, 113, 
#nullable restore
#line 44 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.Genero

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(114, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\n        ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(118, "\n            ");
                __builder2.AddMarkupContent(119, "<label>Salário</label>\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputNumber_10(__builder2, 120, 121, "form-control", 122, true, 123, 
#nullable restore
#line 49 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                       Funcionario.SalarioFuncionario

#line default
#line hidden
#nullable disable
                , 124, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.SalarioFuncionario = __value, Funcionario.SalarioFuncionario)), 125, () => Funcionario.SalarioFuncionario);
                __builder2.AddMarkupContent(126, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_11(__builder2, 127, 128, 
#nullable restore
#line 50 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.SalarioFuncionario

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(129, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\n        ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(133, "\n            ");
                __builder2.AddMarkupContent(134, "<label>Email</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(135);
                __builder2.AddAttribute(136, "class", "form-control");
                __builder2.AddAttribute(137, "required", true);
                __builder2.AddAttribute(138, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(139, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Email = __value, Funcionario.Email))));
                __builder2.AddAttribute(140, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(141, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_12(__builder2, 142, 143, 
#nullable restore
#line 56 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(144, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\n        ");
                __builder2.OpenElement(146, "div");
                __builder2.AddAttribute(147, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(148, "\n            ");
                __builder2.AddMarkupContent(149, "<label>Telefone</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(150);
                __builder2.AddAttribute(151, "class", "form-control");
                __builder2.AddAttribute(152, "required", true);
                __builder2.AddAttribute(153, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                     Funcionario.Telefone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(154, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Telefone = __value, Funcionario.Telefone))));
                __builder2.AddAttribute(155, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Telefone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(156, "\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateValidationMessage_13(__builder2, 157, 158, 
#nullable restore
#line 62 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                      () =>Funcionario.Telefone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(159, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\n        ");
                __builder2.OpenElement(161, "div");
                __builder2.AddAttribute(162, "class", "form-group col-md-6 roboto");
                __builder2.AddMarkupContent(163, "\n            ");
                __builder2.AddMarkupContent(164, "<label>Nome Chefe</label>\n            ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputSelect_14(__builder2, 165, 166, "form-control", 167, true, 168, 
#nullable restore
#line 67 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                       Funcionario.NomeChefe

#line default
#line hidden
#nullable disable
                , 169, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.NomeChefe = __value, Funcionario.NomeChefe)), 170, () => Funcionario.NomeChefe, 171, (__builder3) => {
                    __builder3.AddMarkupContent(172, "\n\n");
#nullable restore
#line 69 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                 if (chefias != null)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(173, "<option value>Select...</option>\n");
#nullable restore
#line 73 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                         foreach (var chefia in chefias)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(174, "option");
                    __builder3.AddAttribute(175, "value", 
#nullable restore
#line 75 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                chefia.NomeChefia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(176, 
#nullable restore
#line 75 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                    chefia.NomeChefia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 75 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                               }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(177, "            ");
                }
                );
                __builder2.AddMarkupContent(178, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\n        ");
                __builder2.OpenElement(180, "button");
                __builder2.AddAttribute(181, "type", "submit");
                __builder2.AddAttribute(182, "class", "btn-add w-50 rounded-pill");
                __builder2.AddAttribute(183, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                                          OnValidSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(184, 
#nullable restore
#line 88 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                                                          ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\n\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
 
    public List<Chefia> chefias { get; set; }
    [Parameter] public Funcionario Funcionario { get; set; }
    [Parameter] public string ButtonText { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await LoadChefias();
    }
    async Task LoadChefias()
    {
        chefias = await http.GetFromJsonAsync<List<Chefia>>("api/chefias");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_12<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_13<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_14<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
