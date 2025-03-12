using System.Net.Http.Json;
using Ecommerce.OrderMS.Domain.Model;

namespace Ecommerce.OrderMS.Application.HttpClients;

public class UsersMicroserviceClient
{
    private readonly HttpClient _httpClient;

    public UsersMicroserviceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }


    public async Task<UserDTO?> GetUserByUserID(Guid userID)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"/gateway/users/{userID}");

        if (!response.IsSuccessStatusCode)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new HttpRequestException("Bad request", null, System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                throw new HttpRequestException($"Http request failed with status code {response.StatusCode}");
            }
        }


        UserDTO? user = await response.Content.ReadFromJsonAsync<UserDTO>();

        if (user == null)
        {
            throw new ArgumentException("Invalid User ID");
        }

        return user;
    }
}

