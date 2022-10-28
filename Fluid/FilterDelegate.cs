using System.Threading.Tasks;
using Fluid.Values;

namespace Fluid
{
    public delegate Task<FluidValue> FilterDelegate(FluidValue input, FilterArguments arguments, TemplateContext context);
}
