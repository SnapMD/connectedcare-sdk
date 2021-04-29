using System;
using Newtonsoft.Json;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Use this to specify DateTime -> JSON value format. Use DateFormatHandling enum value as optional parameter.
    /// Unspecified (default): '2021-04-22T14:00:00',
    /// Local: '2021-04-22T14:00:00+03:00' (server timezone is used),
    /// Utc: '2021-04-22T14:00:00Z',
    /// RoundtripKind: one of previous results (depends on (DateTime)[your value].Kind)
    /// </summary>
    public class DateTimeZoneHandlingConverter: JsonConverter<DateTime>
    {
        private readonly DateTimeZoneHandling _handling;

        // ReSharper disable once UnusedMember.Global
        // used in JsonConverter attribute constructor implicitly
        public DateTimeZoneHandlingConverter():this(DateTimeZoneHandling.Unspecified)
        {
        }

        // ReSharper disable once MemberCanBePrivate.Global
        // may be used if custom handling required
        public DateTimeZoneHandlingConverter(DateTimeZoneHandling handling)
        {
            _handling = handling;
        }

        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            var dateFormatHandling = serializer.DateFormatHandling;
            var result = JsonConvert.ToString(value, dateFormatHandling, _handling);
            writer.WriteRawValue(result);
        }

        public override DateTime ReadJson(JsonReader reader,
            Type objectType,
            DateTime existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
        }

        public override bool CanRead => false;
    }
}
