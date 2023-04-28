// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var folder = "/blog/_posts";

var directory = Directory
    .GetFiles(folder);

var posts = directory
    .Select(File.ReadAllText)
    .Select(md => md.GetFrontMatter<BlogFrontMatter>())
    .ToList();

Console.WriteLine(posts.Count);