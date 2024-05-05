/**
 * Message automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Discord;
public class Message
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    [JsonPropertyName("nonce")]
    public string? Nonce { get; set; }
    [JsonPropertyName("tts")]
    public bool? Tts { get; set; }
    [JsonPropertyName("embeds")]
    public List<MessageEmbed>? Embeds { get; set; }
    [JsonPropertyName("allowed_mentions")]
    public MessageAllowedMentions? AllowedMentions { get; set; }
    [JsonPropertyName("message_reference")]
    public string? MessageReference { get; set; }
    [JsonPropertyName("flags")]
    public int? Flags { get; set; }
    [JsonPropertyName("enforce_nonce")]
    public bool? EnforceNonce { get; set; }
}
