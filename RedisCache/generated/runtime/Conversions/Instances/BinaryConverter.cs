﻿using System;

namespace Carbon.Json.Converters
{
    internal sealed class BinaryConverter : JsonConverter<byte[]>
    {
        public override JsonNode ToJson(byte[] value) => new XBinary(value);

        public override byte[] FromJson(JsonNode node)
        {
            switch (node.Type)
            {
                case JsonType.String : return Convert.FromBase64String(node.ToString());    // Base64 Encoded
                case JsonType.Binary : return ((XBinary)node).Value;
            }

            throw new ConversionException(node, typeof(byte[]));
        }
    }
}