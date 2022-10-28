using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Fluid
{
    public interface IFluidTemplate
    {
        Task RenderAsync(TextWriter writer, TextEncoder encoder, TemplateContext context);
    }
}
