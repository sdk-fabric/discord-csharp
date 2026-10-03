
# discord-csharp

This [SDK](https://github.com/sdk-fabric/discord-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/sdkfabric/discord

## Usage

```csharp
using SdkFabric.Discord.Client;

Client client = Client.Build("[access_token]")

// Get a channel by ID.
Channel response = client.Channel().get("channel_id");

// Update a channel's settings.
Channel response = client.Channel().update("channel_id", new Channel_Update());

// Delete a channel, or close a private message.
Channel response = client.Channel().delete("channel_id");

// Returns all pinned messages in the channel as an array of message objects.
List<Message> response = client.Channel().getPins("channel_id");

// Create a new invite object for the channel.
Channel_Invite response = client.Channel().createInvite("channel_id", new Channel_Invite());

// Retrieves the messages in a channel.
List<Message> response = client.Message().getAll("channel_id", "around", "before", "after", 1);

// Retrieves a specific message in the channel.
Message response = client.Message().get("channel_id", "message_id");

// Post a message to a guild text or DM channel.
Message response = client.Message().create("channel_id", new Message());

// Edit a previously sent message.
Message response = client.Message().update("channel_id", "message_id", new Message());

// Delete a message.
object response = client.Message().remove("channel_id", "message_id");

// Crosspost a message in an Announcement Channel to following channels.
Message response = client.Message().crosspost("channel_id", "message_id");

List<User> response = client.Message().getReactionsByEmoji("channel_id", "message_id", "emoji", 1, "after", 1);

object response = client.Message().deleteAllReactions("channel_id", "message_id");

// Returns the user object of the requester's account.
User response = client.User().getCurrent();

// Returns a user object for a given user ID.
User response = client.User().get("user_id");
```
