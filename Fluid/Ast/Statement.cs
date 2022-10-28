using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Fluid.Ast
{
    public abstract class Statement
    {
        public static Task<Completion> Break() => Task.FromResult(Completion.Break);
        public static Task<Completion> Normal() => Task.FromResult(Completion.Normal);
        public static Task<Completion> Continue() => Task.FromResult(Completion.Continue);

        public abstract Task<Completion> WriteToAsync(TextWriter writer, TextEncoder encoder, TemplateContext context);
    }
}