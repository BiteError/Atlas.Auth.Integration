using System;
using Atlas.Auth.Client.Api;
using Atlas.Auth.Client.Client;
using Atlas.Auth.Client.Model;

namespace Atlas.Auth.Integration
{
    class Program
    {
        static void Main(string[] args)
        {
            var authUrl = "http://31.148.0.53";

            var username = "test@example.com";
            var password = "strongpasword";


            LoginApi loginApi = new LoginApi(authUrl);
            ApiResponse<LoginMessageModel> loginResult = loginApi
                .ApiV1LoginPostWithHttpInfo(new LoginModel(username, password));

            switch (loginResult.StatusCode)
            {
                case 200:
                {
                    string sessionId = loginResult.Data.SessionId;

                    var tokenApi = new TokenApi(authUrl);
                    var tokenResult = tokenApi.ApiV1TokenSessionIdPostWithHttpInfo(sessionId);

                    switch (tokenResult.StatusCode)
                    {
                        case 201:
                        {
                            var tokenInfo = tokenResult.Data;

                            if ((tokenInfo.ExpiredAt - DateTime.UtcNow) < TimeSpan.FromSeconds(180))
                            {
                                //TODO: prolongate token
                            }

                            var userApi = new UserApi(authUrl);
                            var userResult = userApi.ApiV1UserByTokenGetWithHttpInfo(tokenInfo.Token);

                            switch (userResult.StatusCode)
                            {
                                case 200:
                                {
                                    Console.WriteLine(userResult.Data.Name);
                                    break;
                                }
                                case 401:
                                {
                                    Console.WriteLine($"user result {userResult.StatusCode}");
                                    //TODO: relogin with retry policy
                                    break;
                                }
                                case 500:
                                {
                                    Console.WriteLine($"user result {userResult.StatusCode}");
                                    //TODO: get again with retry policy
                                    break;
                                }
                            }

                            break;
                        }
                        case 401:
                        {
                            Console.WriteLine($"user result {tokenResult.StatusCode}");
                            //TODO: relogin with retry policy
                            break;
                        }
                        case 500:
                        {
                            Console.WriteLine($"user result {tokenResult.StatusCode}");
                            //TODO: get again with retry policy
                            break;
                        }
                    }

                    break;
                }
                case 401:
                {
                    Console.WriteLine($"user result {loginResult.StatusCode}");
                    //TODO: check username/password and relogin
                    break;
                }
                case 500:
                {
                    Console.WriteLine($"user result {loginResult.StatusCode}");
                    //TODO: relogin with retry policy
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
