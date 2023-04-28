using Markdig.Extensions.Yaml;
using Markdig;
using YamlDotNet.Serialization;
using Markdig.Syntax;
using MyPortfolio.Models;
using Markdig.Parsers;
using Markdig.Syntax.Inlines;
using Markdig.Renderers;

namespace MyPortfolio;




public static class MarkdownExtensions
{
    private static readonly IDeserializer YamlDeserializer =
        new DeserializerBuilder()
        .IgnoreUnmatchedProperties()
        .Build();

    private static readonly MarkdownPipeline Pipeline
        = new MarkdownPipelineBuilder()
        .UseYamlFrontMatter()
         .UseCustomContainers()
        .Build();


    public static string Render(this string markdown)
    {
        var writer = new StringWriter();
        var renderer = new HtmlRenderer(writer);
        Pipeline.Setup(renderer);

        var document = MarkdownParser.Parse(markdown, Pipeline);
        renderer.Render(document);
        writer.Flush();

        return writer.ToString();
    }

    public static T GetFrontMatter<T>(this string markdown)
    {
        var document = Markdown.Parse(markdown, Pipeline);

        var block = document
            .Descendants<YamlFrontMatterBlock>()
            .FirstOrDefault();

        if (block == null)
            return default;

     

        var yaml =
            block
            // this is not a mistake
            // we have to call .Lines 2x
            .Lines // StringLineGroup[]
            .Lines // StringLine[]
            .OrderByDescending(x => x.Line)
            .Select(x => $"{x}\n")
            .ToList()
            .Select(x => x.Replace("---", string.Empty))
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Aggregate((s, agg) => agg + s);

        return YamlDeserializer.Deserialize<T>(yaml);
    }
}