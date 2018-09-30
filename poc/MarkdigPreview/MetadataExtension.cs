using Markdig;
using Markdig.Renderers;

namespace MarkdigPreview
{
    public class MetadataExtension : IMarkdownExtension
    {
        public void Setup(MarkdownPipelineBuilder pipeline)
        {

        }

        public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
        {
            var htmlRenderer = renderer as HtmlRenderer;
        }
    }
}
