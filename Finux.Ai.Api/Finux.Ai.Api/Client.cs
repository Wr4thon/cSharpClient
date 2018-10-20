using Finux.Ai.Api.Contract;

namespace Finux.Ai.Api
{
    using System;
    using System.Net.Http;
    using System.Security;
    using System.Threading.Tasks;

    using Finux.Ai.Api.Contract.DataClasses;
    using Finux.Ai.Api.Contract.DataClasses.Responses;

    public class Client : IClient
    {
        /// <summary>
        /// The client.
        /// </summary>
        private readonly HttpClient client;

        /// <summary>
        /// The base path.
        /// </summary>
        private readonly string basePath;

        /// <summary>
        /// The api endpoint.
        /// </summary>
        private readonly string apiEndpoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="apiEndpoint">
        /// The base path.
        /// </param>
        public Client(string apiEndpoint)
        {
            this.apiEndpoint = apiEndpoint;
            this.basePath = "/api/";
            this.client = new HttpClient();
        }

        public Task<LoginResponse> Login(string email, SecureString password)
        {
            throw new System.NotImplementedException();
        }

        public Task<LoginResponse> Login(string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<LoginResponse> Register(string email, SecureString password, SecureString repeatPassword)
        {
            throw new System.NotImplementedException();
        }
        public Task<LoginResponse> Register(string email, string password, string repeatPassword)
        {
            throw new System.NotImplementedException();
        }

        public void AddProfile(string businessId, string company, string firstName, string sureName)
        {
            throw new System.NotImplementedException();
        }

        public void GetProfile()
        {
            throw new System.NotImplementedException();
        }

        public void ChangePassword(SecureString newPassword, SecureString oldPassword, SecureString repeatPassword)
        {
            throw new System.NotImplementedException();
        }

        public void Feedback(string message, bool reply)
        {
            throw new System.NotImplementedException();
        }

        public async Task<string> Ping()
        {
            StringResponse response = await Get<StringResponse>("ping");
            return response?.Data;
        }

        private async Task<TResponse> Get<TResponse>(string apiPath)
        {
            string requestUri = this.apiEndpoint + this.basePath + apiPath;
            HttpResponseMessage response = await this.client.GetAsync(requestUri);
            string content = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TResponse>(content);
        }
    }
}
