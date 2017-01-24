using Newtonsoft.Json;

namespace MVParammer.Transformers
{
    public class MapTransformer
    {
        public static string MapToJson(Data.Map map)
        {
            return JsonConvert.SerializeObject(map, Formatting.Indented);
        }

        public static Data.Map JsonToMap(string json)
        {
            return JsonConvert.DeserializeObject<Data.Map>(json);
        }
    }
}
