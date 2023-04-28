using YamlDotNet.Serialization;

namespace MyPortfolio.Models;

public class BlogFrontMatter
{
    [YamlMember(Alias = "title")]
    public required string Title { get; set; }

    [YamlMember(Alias = "slug")]
    public required string Slug { get; set; }

    [YamlMember(Alias = "author")]
    public required string Author { get; set; }

    [YamlMember(Alias = "category")]
    public required string Category { get; set; }

    [YamlMember(Alias = "tags")]
    public required string Tags { get; set; }

    [YamlIgnore]
    public string[]? GetTags => Tags?
       .Split(",", StringSplitOptions.RemoveEmptyEntries)
       .Select(x => x.Trim())
       .ToArray();
}
