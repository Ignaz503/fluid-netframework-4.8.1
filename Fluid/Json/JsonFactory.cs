using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fluid.Json;

public static class JsonFactory
{
    public static Func<Stream, IJsonWriterOptions, IUtf8JsonWriter> WriterFactory { get; set; } = static (str, options) => new NoJsonWrite();

    public static Func<IJsonWriterOptions> OptionsFactory { get; set; } = static () => new DefaultJsonOptions();
}
