using System;
using System.IO;
using Markdig;

namespace MarkdigPreview
{
    class Program
    {
        static void Main(string[] args)
        {
            var md = File.ReadAllText("sample.md");
            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .Use<MetadataExtension>()
                .Build();
            var html = Markdown.ToHtml(md, pipeline);
            Console.WriteLine(html);
        }
    }
}
