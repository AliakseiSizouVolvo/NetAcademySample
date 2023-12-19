using System.Text.Json.Serialization;
using System.Text.Json;

namespace JsonSerializationAndAttributes;

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

