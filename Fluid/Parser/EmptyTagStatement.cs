using Fluid.Ast;
using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Fluid.Parser
{
    internal sealed class EmptyTagStatement : Statement
    {
        private readonly Func<TextWriter, TextEncoder, TemplateContext, Task<Completion>> _render;

        public EmptyTagStatement(Func<TextWriter, TextEncoder, TemplateContext, Task<Completion>> render)
        {
            _render = render ?? throw new ArgumentNullException(nameof(render));
        }

        public override Task<Completion> WriteToAsync(TextWriter writer, TextEncoder encoder, TemplateContext context)
        {
            return _render(writer, encoder, context);
        }
    }
}
