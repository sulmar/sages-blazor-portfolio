using Microsoft.AspNetCore.Components;
using MyPortfolio.Abstractions;
using MyPortfolio.Models;
using System.Net.Http.Json;

namespace MyPortfolio.Components;

public partial class Portfolio
{
    [Inject]
    public IProjectService Api { get; set; }

    private List<Project>? projects;

    protected override async Task OnInitializedAsync()
    {
        projects = await Api.GetAllAsync();
    }
}
