#pragma checksum "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dbf4ecb602fe47167158a231c75bcceecdcecc0"
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
#nullable restore
#line 2 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
using Faculdade_FUP_Project.Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Alunos")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
 if (alunos == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Carregando!!!");
#nullable restore
#line 7 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                              
}
else if (alunos.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div>\n        <a href=\"alunos/criar\" value=\"Criar\">\n            <button class=\"btn-criar roboto rounded-pill border-0 my-5\">Criar</button>\n        </a>\n    </div>\n");
#nullable restore
#line 16 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<div>\n        <a href=\"alunos/criar\" value=\"Criar\">\n            <button class=\"btn-criar roboto rounded-pill border-0 my-5\">Criar</button>\n        </a>\n    </div>\n");
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table roboto text-uppercase font-tabela");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddMarkupContent(9, "<thead>\n            <tr>\n\n                <th>Nome</th>\n                <th>Genero</th>\n                <th>Data Inicio Curso</th>\n                <th>Nome Curso</th>\n\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\n");
#nullable restore
#line 37 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
             foreach (var aluno in alunos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "tr");
            __builder.AddAttribute(14, "class", "table roboto text-uppercase font-tabela");
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 40 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                     aluno.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 41 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                     aluno.Genero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 42 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                     aluno.DataInicioCurso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 43 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                     aluno.NomeCurso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n                ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "alunos/edit/" + (
#nullable restore
#line 45 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                                      aluno.AlunoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "button-geral");
            __builder.AddContent(31, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, " |\n                ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "alunos/details/" + (
#nullable restore
#line 46 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                                         aluno.AlunoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "button-geral");
            __builder.AddContent(36, "Detalhes");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, " |\n                ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
                               () => ExcluirAluno(aluno.AlunoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "button-geral");
            __builder.AddContent(41, "Deletar");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#nullable restore
#line 50 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
#nullable restore
#line 54 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\dionn\Downloads\Versao com front\Teste_Piloto\Client\Pages\Alunos\Index.razor"
       
    public List<Aluno> alunos;
    protected override async Task OnInitializedAsync()
    {
        await LoadAlunos();
    }
    async Task LoadAlunos()
    {
        alunos = await http.GetFromJsonAsync<List<Aluno>>("api/alunos");
    }
    async Task ExcluirAluno(int id)
    {
        await http.DeleteAsync($"api/alunos/{id}");
        await LoadAlunos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
