﻿#nullable enable
using System;
using Newtonsoft.Json;

namespace AuthenticatorPro.Shared.Data
{
    [Android.Runtime.Preserve(AllMembers = true)]
    public class ByteArrayConverter : JsonConverter
    {
        public override async void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if(value == null)
                await writer.WriteNullAsync();
            else
                await writer.WriteValueAsync(Convert.ToBase64String((byte[]) value));

            await writer.FlushAsync();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            
            return value == null 
                ? null
                : Convert.FromBase64String(value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(byte[]);
        }
    }
}