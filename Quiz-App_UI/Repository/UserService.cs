using Newtonsoft.Json;
using Quiz_App_UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Quiz_App_UI.Repository
{
    public class UserService : IUserRepository
    {
        string baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "https://10.0.2.2:7049/api/User/" : "https://localhost:7049/api/User/";
        public async Task<User> Login(string email, string password)
        {
            var client = new HttpClient();
            string url = baseUrl + email + "/" + password;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                User user = JsonConvert.DeserializeObject<User>(content);
                return await Task.FromResult(user);
            }
            return null!;
        }
    }
}
