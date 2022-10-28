using System.Threading.Tasks;
using Fluid.Values;

namespace Fluid.Ast
{
    public abstract class MemberSegment
    {
        /// <summary>
        /// Resolves the member of a <see cref="FluidValue"/> instance.
        /// </summary>
        public abstract Task<FluidValue> ResolveAsync(FluidValue value, TemplateContext context);
    }
}
