using MyPortfolio.Models;

namespace MyPortfolio.Abstractions;

public interface IProjectService
{
    Task<List<Project>> GetAllAsync();
}
