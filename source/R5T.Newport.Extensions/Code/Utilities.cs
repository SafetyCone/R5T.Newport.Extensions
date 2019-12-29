using System;

using Newtonsoft.Json;


namespace R5T.Newport
{
    public static class Utilities
    {
        /// <summary>
        /// Gets a <see cref="JsonSerializer"/> configured to produce indented JSON suitable for serialization to files.
        /// </summary>
        public static JsonSerializer GetStandardJsonSerializer()
        {
            var jsonSerializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            return jsonSerializer;
        }
    }
}
