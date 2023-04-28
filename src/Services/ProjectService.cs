using MyPortfolio.Abstractions;
using MyPortfolio.Models;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace MyPortfolio.Services;

public class ProjectService : IProjectService
{
    private readonly HttpClient http;
    public ProjectService(HttpClient http) => this.http = http;
    public Task<List<Project>> GetAllAsync() => http.GetFromJsonAsync<List<Project>>("sample-data/projects.json");
}
