using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FigureForge
{
    public class ShapeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Shape);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var type = jObject["$type"]?.Value<string>();

            switch (type)
            {
                case "FigureForge.Rectangle, FigureForge":
                    return jObject.ToObject<Rectangle>(serializer);
                case "FigureForge.Triangle, FigureForge":
                    return jObject.ToObject<Triangle>(serializer);
                case "FigureForge.Circle, FigureForge":
                    return jObject.ToObject<Circle>(serializer);
                case "FigureForge.Square, FigureForge":
                    return jObject.ToObject<Square>(serializer);
                case "FigureForge.Pentagon, FigureForge":
                    return jObject.ToObject<Pentagon>(serializer);
                default:
                    throw new JsonReaderException($"Unknown shape type: {type}");
            }
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => serializer.Serialize(writer, value);
    }
}
