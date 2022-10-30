using System;
using System.Threading.Tasks;

namespace Fluid.Json;

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
