namespace MyPortfolio.Models;

public class AboutMe
{
    public string Description { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();    
}