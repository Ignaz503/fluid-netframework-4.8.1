using Fluid.Ast;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Fluid.Parser
{
    internal sealed class EmptyBlockStatement : Statement
    {
        private readonly Func<IReadOnlyList<Statement>, TextWriter, TextEncoder, TemplateContext, Task<Completion>> _render;

        public EmptyBlockStatement(List<Statement> statements, Func<IReadOnlyList<Statement>, TextWriter, TextEncoder, TemplateContext, Task<Completion>> render)
        {
            _render = render ?? throw new ArgumentNullException(nameof(render));
            Statements = statements ?? throw new ArgumentNullException(nameof(statements));
        }

        public List<Statement> Statements { get; }

        public override Task<Completion> WriteToAsync(TextWriter writer, TextEncoder encoder, TemplateContext context)
        {
            return _render(Statements, writer, encoder, context);
        }
    }
}
