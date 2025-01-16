using Microsoft.AspNetCore.Razor;
using Microsoft.AspNetCore.Razor.Runtime;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.Compilation;
using Microsoft.AspNetCore.Razor.Evolution;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Extensions;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.VisualStudio.Web.CodeGeneration.Razor;
using RazorLight;

namespace Razor
{
    // Basic Razor Runtime Example
    public class RazorRuntimeExample
    {
        public void ProcessRazorTemplate(string template)
        {
            var engine = RazorProjectEngine.Create();
            var codeDocument = engine.Process(template);
        }
    }

    // Razor Tag Helper Example
    public class CustomRazorTagHelper : TagHelper 
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "custom";
            output.Content.SetContent("Custom Razor Tag");
        }
    }

    // Razor Hosting Example
    public class RazorHostingExample
    {
        private readonly RazorCompiledItemLoader _loader;

        public RazorHostingExample(RazorCompiledItemLoader loader)
        {
            _loader = loader;
        }
    }

    // Razor Language Example
    public class RazorLanguageExample
    {
        public void ParseRazorCode()
        {
            var engine = RazorProjectEngine.Create();
            var sourceDocument = RazorSourceDocument.Create("@page", "file.cshtml");
        }
    }

    // Razor Compilation Example
    public class RazorCompilationExample
    {
        public void CompileView(string viewPath)
        {
            var compiler = new RazorViewCompiler();
            var result = compiler.CompileView(viewPath);
        }
    }

    // Razor Evolution Example
    public class RazorEvolutionExample
    {
        public void ProcessRazorDocument()
        {
            var engine = RazorProjectEngine.Create();
            var document = RazorCodeDocument.Create(RazorSourceDocument.Create("content", "file.cshtml"));
        }
    }

    // MVC Razor Example
    public class MvcRazorExample : RazorPage<dynamic>
    {
        public override async Task ExecuteAsync()
        {
            await WriteLiteralAsync("<h1>Hello from MVC Razor</h1>");
        }
    }

    // Razor Extensions Example
    public class RazorExtensionsExample
    {
        public void ConfigureRazorExtensions(RazorProjectEngineBuilder builder)
        {
            builder.Features.Add(new CustomRazorExtension());
        }
    }

    // Razor Internal Example
    public class RazorInternalExample
    {
        private readonly IRazorViewEngine _viewEngine;

        public RazorInternalExample(IRazorViewEngine viewEngine)
        {
            _viewEngine = viewEngine;
        }
    }

    // Razor Runtime Compilation Example
    public class RazorRuntimeCompilationExample
    {
        public void ConfigureRuntimeCompilation(IMvcBuilder builder)
        {
            builder.AddRazorRuntimeCompilation();
        }
    }

    // Razor Tag Helpers MVC Example
    public class RazorTagHelpersMvcExample : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "mvc-custom";
            output.Content.SetContent("MVC Custom Tag");
        }
    }

    // Code Analysis Razor Example
    public class CodeAnalysisRazorExample
    {
        public void AnalyzeRazorCode()
        {
            var workspace = new AdhocWorkspace();
            var project = workspace.AddProject("RazorProject", LanguageNames.CSharp);
        }
    }

    // Code Generation Razor Example
    public class CodeGenerationRazorExample
    {
        public void GenerateRazorCode()
        {
            var generator = new RazorPageGenerator();
            var result = generator.GenerateCode("MyPage");
        }
    }

    // RazorLight Example
    public class RazorLightEngineExample
    {
        public async Task RenderTemplate()
        {
            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject("/views")
                .Build();

            var result = await engine.CompileRenderAsync("template.cshtml", new { Name = "John" });
        }
    }
}