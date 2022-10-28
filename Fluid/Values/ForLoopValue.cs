using System.Globalization;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Fluid.Values
{
    public sealed class ForLoopValue : FluidValue
    {
        public int Length { get; set; }
        public int Index { get; set; }
        public int Index0 { get; set; }
        public int RIndex { get; set; }
        public int RIndex0 { get; set; }
        public bool First { get; set; }
        public bool Last { get; set; }

        public int Count => Length;

        public override FluidValues Type => FluidValues.Dictionary;

        public override bool Equals(FluidValue other)
        {
            return false;
        }

        public override bool ToBooleanValue()
        {
            return false;
        }

        public override decimal ToNumberValue()
        {
            return Length;
        }

        public override object ToObjectValue()
        {
            return null;
        }

        public override string ToStringValue()
        {
            return "forloop";
        }

        public override Task<FluidValue> GetValueAsync(string name, TemplateContext context)
        {
            return name switch
            {
                "length" => Task.FromResult(NumberValue.Create(Length) as FluidValue),
                "index" => Task.FromResult(NumberValue.Create(Index) as FluidValue),
                "index0" => Task.FromResult(NumberValue.Create(Index0) as FluidValue),
                "rindex" => Task.FromResult(NumberValue.Create(RIndex) as FluidValue),
                "rindex0" => Task.FromResult(NumberValue.Create(RIndex0) as FluidValue),
                "first" => Task.FromResult(BooleanValue.Create(First) as FluidValue),
                "last" => Task.FromResult(BooleanValue.Create(Last) as FluidValue),
                _ => Task.FromResult(NilValue.Instance as FluidValue),
            };
        }

        public override void WriteTo(TextWriter writer, TextEncoder encoder, CultureInfo cultureInfo)
        {
        }
    }
}
