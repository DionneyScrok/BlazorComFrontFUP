#pragma checksum "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa8f1aee4e1036a536ba0c36ba94466367caaa49"
// <auto-generated/>
#pragma warning disable 1591
namespace Teste_Piloto.Client.Pages.Alunos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/alunos/criar")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CADASTRAR NOVO ALUNO</h3>\n<br>\n");
            __builder.OpenComponent<Teste_Piloto.Client.Pages.Alunos.PageAlunos>(1);
            __builder.AddAttribute(2, "Aluno", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Faculdade_FUP_Project.Server.Models.Aluno>(
#nullable restore
#line 7 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Create.razor"
                   aluno

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonText", "Adicionar");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Create.razor"
                                                                 Criar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Create.razor"
       
    private Aluno aluno = new Aluno();
    async Task Criar()
    {
        await http.PostAsJsonAsync("api/alunos", aluno);
        navigation.NavigateTo("alunos");
    }
    //private async Task Criar()
    //{
    //    Console.WriteLine("Create method");
    //    Console.WriteLine(curso.NomeCurso);

    //    try
    //    {
    //        await cursoRepository.CreateCurso(curso);
    //        navigation.NavigateTo("cursos");
    //    }
    //    catch (Exception ex)
    //    {
    //        // ...
    //        Console.WriteLine(ex.Message);
    //    }
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
