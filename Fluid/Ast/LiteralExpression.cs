using System.Threading.Tasks;
using Fluid.Values;

namespace Fluid.Ast
{
    public sealed class LiteralExpression : Expression
    {
        public LiteralExpression(FluidValue value)
        {
            Value = value;
        }

        public FluidValue Value { get; }

        public override Task<FluidValue> EvaluateAsync(TemplateContext context)
        {
            return Task.FromResult(Value);
        }
    }
}
