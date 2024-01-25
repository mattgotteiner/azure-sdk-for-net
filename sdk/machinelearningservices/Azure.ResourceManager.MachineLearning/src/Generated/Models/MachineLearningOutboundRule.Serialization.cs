// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownOutboundRule))]
    public partial class MachineLearningOutboundRule : IUtf8JsonSerializable, IJsonModel<MachineLearningOutboundRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningOutboundRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningOutboundRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutboundRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOutboundRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutboundRuleType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineLearningOutboundRule IJsonModel<MachineLearningOutboundRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutboundRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOutboundRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningOutboundRule(document.RootElement, options);
        }

        internal static MachineLearningOutboundRule DeserializeMachineLearningOutboundRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FQDN": return FqdnOutboundRule.DeserializeFqdnOutboundRule(element);
                    case "PrivateEndpoint": return PrivateEndpointOutboundRule.DeserializePrivateEndpointOutboundRule(element);
                    case "ServiceTag": return ServiceTagOutboundRule.DeserializeServiceTagOutboundRule(element);
                }
            }
            return UnknownOutboundRule.DeserializeUnknownOutboundRule(element);
        }

        BinaryData IPersistableModel<MachineLearningOutboundRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutboundRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOutboundRule)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningOutboundRule IPersistableModel<MachineLearningOutboundRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutboundRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningOutboundRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOutboundRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningOutboundRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
