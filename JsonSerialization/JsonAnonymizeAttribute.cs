using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonSerialization;

public class JsonAnonymizeConverterInner : JsonConverter<string?>
{
    public override string Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
            JsonSerializerOptions options) => reader.GetString();

    public override void Write(
        Utf8JsonWriter writer,
        string stringValue,
        JsonSerializerOptions options) =>
            writer.WriteStringValue(String.IsNullOrWhiteSpace(stringValue) ? null : "anonymized");
      
}

