﻿using System.Globalization;
using Newtonsoft.Json;
using Restub.Toolbox;

namespace AvitoSdk.Toolbox
{
    /// <summary>
    /// Avito API serializer.
    /// </summary>
    public class AvitoSerializer : NewtonsoftSerializer
    {
        /// <inheritdoc/>
        protected override JsonSerializerSettings CreateJsonSerializerSettings()
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
            settings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            settings.Converters.Add(new Newtonsoft.Json.Converters.IsoDateTimeConverter
            {
                // for some reason, Avito API requires that time zone
                // doesn't have a colon, expecting "+0700" instead of "+07:00"
                DateTimeFormat = @"yyyy-MM-dd\THH:mm:sszz00",
                DateTimeStyles = DateTimeStyles.AllowWhiteSpaces,
            });

            return settings;
        }
    }
}
