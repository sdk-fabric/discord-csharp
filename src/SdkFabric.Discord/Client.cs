/**
 * Client automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Credentials;
using Sdkgen.Client.Exception;

namespace SdkFabric.Discord;

public class Client : ClientAbstract
{
    public Client(string baseUrl, ICredentials credentials) : base(baseUrl, credentials)
    {
    }

    public ChannelTag Channel()
    {
        return new ChannelTag(
            this.HttpClient,
            this.Parser
        );
    }



    public static Client Build(string token)
    {
        return new Client("https://discord.com/api/v10", new HttpBearer(token));
    }
}
