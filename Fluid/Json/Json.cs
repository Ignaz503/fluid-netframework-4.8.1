using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluid.Json;

public static class JsonFactory
{
    public static Func<Stream, IJsonWriterOptions, IUtf8JsonWriter> WriterFactory { get; set; }

    public static Func<IJsonWriterOptions> OptionsFactory { get; set; }
}


/// <summary>
/// Interface for utf8 json writer from system.text.json
/// </summary>
public interface IUtf8JsonWriter : IDisposable
{
    void WriteStartArray();

    void WriteStringValue(DateTime dateTime);
    void WriteStringValue(DateTimeOffset dateTime);
    void WriteStringValue(string value);

    void WriteStartObject();

    void WritePropertyName(string key);

    void WriteNumberValue(decimal number);

    void WriteNullValue();

    void WriteEndObject();

    void WriteEndArray();

    void WriteBooleanValue(bool value);

    Task DisposeAsync();
}

public interface IJsonWriterOptions
{
    public bool Indented { get; set; }
}