using Refit;
using System.Net;

namespace ExampleForms.Web.Components.Shared
{
    public static class MockExceptions
    {
        /// <summary>
        /// Simula una excepcion
        /// </summary>
        /// <returns></returns>
        public static async Task SimulateApiException(string simulateApiException)
        {
            // Simular un escenario donde la API devuelve un error

            RefitSettings refitSettings = new();

            HttpResponseMessage response;

            HttpRequestMessage httpRequestMessage = new(method: HttpMethod.Post,
                                                        requestUri: "https://fakestoreapi.com/");

            switch (simulateApiException)
            {
                case "InternalServerError":
                    response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    {
                        Content = new StringContent("Internal Server Error...")
                    };

                    throw await ApiException.Create(message: httpRequestMessage,
                                                    httpMethod: HttpMethod.Post,
                                                    response: response,
                                                    refitSettings: refitSettings);
                case "BadRequest":

                    response = new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Los valores enviados no son correctos...")
                    };

                    throw await ApiException.Create(message: httpRequestMessage,
                                                    httpMethod: HttpMethod.Post,
                                                    response: response,
                                                    refitSettings: refitSettings);

            }

        }
    }
}
