/**
 * MessageEmbed automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Discord;

public class MessageEmbed
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    [JsonPropertyName("color")]
    public int? Color { get; set; }

}

