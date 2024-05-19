/**
 * Channel automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Discord;
public class Channel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("type")]
    public int? Type { get; set; }
    [JsonPropertyName("guild_id")]
    public string? GuildId { get; set; }
    [JsonPropertyName("position")]
    public int? Position { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
    [JsonPropertyName("nsfw")]
    public bool? Nsfw { get; set; }
    [JsonPropertyName("last_message_id")]
    public string? LastMessageId { get; set; }
    [JsonPropertyName("bitrate")]
    public int? Bitrate { get; set; }
    [JsonPropertyName("user_limit")]
    public int? UserLimit { get; set; }
    [JsonPropertyName("rate_limit_per_user")]
    public int? RateLimitPerUser { get; set; }
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }
    [JsonPropertyName("last_pin_timestamp")]
    public string? LastPinTimestamp { get; set; }
    [JsonPropertyName("rtc_region")]
    public string? RtcRegion { get; set; }
    [JsonPropertyName("video_quality_mode")]
    public int? VideoQualityMode { get; set; }
    [JsonPropertyName("message_count")]
    public int? MessageCount { get; set; }
    [JsonPropertyName("member_count")]
    public int? MemberCount { get; set; }
    [JsonPropertyName("default_auto_archive_duration")]
    public int? DefaultAutoArchiveDuration { get; set; }
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
    [JsonPropertyName("flags")]
    public int? Flags { get; set; }
    [JsonPropertyName("total_message_sent")]
    public int? TotalMessageSent { get; set; }
    [JsonPropertyName("default_sort_order")]
    public int? DefaultSortOrder { get; set; }
    [JsonPropertyName("default_forum_layout")]
    public int? DefaultForumLayout { get; set; }
}