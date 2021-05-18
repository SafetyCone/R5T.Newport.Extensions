using System;
using System.Threading.Tasks;

using Newtonsoft.Json;

using R5T.Magyar.IO;

using R5T.Newport.Extensions;


namespace R5T.Newport
{
    public static class JsonFileHelper
    {
        /// <summary>
        /// No async version since Newtonsoft does not have async!
        /// </summary>
        public static void WriteToFile<T>(string jsonFilePath, T value, bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
            };

            var serializer = JsonSerializer.Create(settings);

            serializer.Serialize(jsonFilePath, value, overwrite);
        }
    }
}
