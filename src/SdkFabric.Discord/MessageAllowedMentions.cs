/**
 * MessageAllowedMentions automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Discord;
public class MessageAllowedMentions
{
    [JsonPropertyName("parse")]
    public List<string>? Parse { get; set; }
    [JsonPropertyName("roles")]
    public List<string>? Roles { get; set; }
    [JsonPropertyName("users")]
    public List<string>? Users { get; set; }
    [JsonPropertyName("replied_user")]
    public bool? RepliedUser { get; set; }
}