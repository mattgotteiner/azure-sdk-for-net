// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningResourceConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningResourceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningResourceConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningResourceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningResourceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningResourceConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            if (Optional.IsDefined(InstanceType))
            {
                if (InstanceType != null)
                {
                    writer.WritePropertyName("instanceType"u8);
                    writer.WriteStringValue(InstanceType);
                }
                else
                {
                    writer.WriteNull("instanceType");
                }
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                if (Locations != null)
                {
                    writer.WritePropertyName("locations"u8);
                    writer.WriteStartArray();
                    foreach (var item in Locations)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("locations");
                }
            }
            if (Optional.IsDefined(MaxInstanceCount))
            {
                if (MaxInstanceCount != null)
                {
                    writer.WritePropertyName("maxInstanceCount"u8);
                    writer.WriteNumberValue(MaxInstanceCount.Value);
                }
                else
                {
                    writer.WriteNull("maxInstanceCount");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                        using (JsonDocument document = JsonDocument.Parse(item.Value))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
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

        MachineLearningResourceConfiguration IJsonModel<MachineLearningResourceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningResourceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningResourceConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningResourceConfiguration(document.RootElement, options);
        }

        internal static MachineLearningResourceConfiguration DeserializeMachineLearningResourceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> instanceCount = default;
            Optional<string> instanceType = default;
            Optional<IList<string>> locations = default;
            Optional<int?> maxInstanceCount = default;
            Optional<IDictionary<string, BinaryData>> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceType = null;
                        continue;
                    }
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        locations = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("maxInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxInstanceCount = null;
                        continue;
                    }
                    maxInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningResourceConfiguration(Optional.ToNullable(instanceCount), instanceType.Value, Optional.ToList(locations), Optional.ToNullable(maxInstanceCount), Optional.ToDictionary(properties), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningResourceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningResourceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningResourceConfiguration)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningResourceConfiguration IPersistableModel<MachineLearningResourceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningResourceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningResourceConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningResourceConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningResourceConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
