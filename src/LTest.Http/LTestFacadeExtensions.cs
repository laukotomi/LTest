using LTest.Http.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace LTest
{
    /// <summary>
    /// Extensions for integration test service provider.
    /// </summary>
    public static class LTestFacadeExtensions
    {
        /// <summary>
        /// Returns the http request builder.
        /// </summary>
        /// <param name="serviceProvider">Integration test service provider.</param>
        public static HttpRequestBuilder GetHttpRequestBuilder(this LTestFacade serviceProvider)
        {
            return serviceProvider.GetRequiredService<HttpRequestBuilder>();
        }

        /// <summary>
        /// Returns the http request builder.
        /// </summary>
        /// <param name="serviceProvider">Integration test service provider.</param>
        /// <typeparam name="TController">Type of the controller.</typeparam>
        public static HttpRequestBuilder<TController> GetHttpRequestBuilder<TController>(this LTestFacade serviceProvider)
            where TController : ControllerBase
        {
            return serviceProvider.GetRequiredService<HttpRequestBuilder<TController>>();
        }
    }
}