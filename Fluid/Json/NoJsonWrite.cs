using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Fluid.Json;

internal class NoJsonWrite : IUtf8JsonWriter
{
    public void Dispose()
        => Nothing();

    public Task DisposeAsync()
        => Task.CompletedTask;

    public void WriteBooleanValue(bool value)
        => Nothing();

    public void WriteEndArray()
        => Nothing();

    public void WriteEndObject()
        => Nothing();

    public void WriteNullValue()
        => Nothing();

    public void WriteNumberValue(decimal number)
        => Nothing();
    public void WritePropertyName(string key)
        => Nothing();

    public void WriteStartArray()
        => Nothing();

    public void WriteStartObject()
        => Nothing();

    public void WriteStringValue(DateTime dateTime)
        => Nothing();

    public void WriteStringValue(DateTimeOffset dateTime)
        => Nothing();

    public void WriteStringValue(string value)
        => Nothing();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void Nothing() { }
}
