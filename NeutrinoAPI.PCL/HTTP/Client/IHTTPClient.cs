using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NeutrinoAPI.PCL.Http.Request;
using NeutrinoAPI.PCL.Http.Response;

namespace NeutrinoAPI.PCL.Http.Client
{
    public interface IHttpClient
    {
        /// <summary>
        /// Execute a given HttpRequest to get string response back
        /// </summary>
        /// <param name="request">The given HttpRequest to execute</param>
        /// <returns> HttpResponse containing raw information</returns>
        HttpResponse ExecuteAsString(HttpRequest request);

        /// <summary>
        /// Execute a given HttpRequest to get binary response back
        /// </summary>
        /// <param name="request">The given HttpRequest to execute</param>
        /// <returns> HttpResponse containing raw information</returns>
        HttpResponse ExecuteAsBinary(HttpRequest request);

        /// <summary>
        /// Execute a given HttpRequest to get async string response back
        /// </summary>
        /// <param name="request">The given HttpRequest to execute</param>
        /// <returns> HttpResponse containing raw information</returns>
        Task<HttpResponse> ExecuteAsStringAsync(HttpRequest request);

        /// <summary>
        /// Execute a given HttpRequest to get async binary response back
        /// </summary>
        /// <param name="request">The given HttpRequest to execute</param>
        /// <returns> HttpResponse containing raw information</returns>
        Task<HttpResponse> ExecuteAsBinaryAsync(HttpRequest request);

        /// <summary>
        /// Create a simple HTTP GET request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns>HttpRequest initialised with the url specified</returns>
        HttpRequest Get(String queryUrl);
        /// <summary>
        /// Create a simple HTTP POST request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns> HttpRequest initialised with the url specified</returns>
        HttpRequest Post(String queryUrl);
        /// <summary>
        /// Create a simple HTTP PUT request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns> HttpRequest initialised with the url specified</returns>
        HttpRequest Put(String queryUrl);
        /// <summary>
        /// Create a simple HTTP DELETE request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns> HttpRequest initialised with the url specified</returns>
        HttpRequest Delete(String queryUrl);

        /// <summary>
        /// Create a simple HTTP PATCH request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns> HttpRequest initialised with the url specified</returns>
        HttpRequest Patch(String queryUrl);

        /// <summary>
        /// Create a simple HTTP GET request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest Get(String queryUrl, Dictionary<String, String> headers, String username = null, String password = null);

        /// <summary>
        ///  Create a simple HTTP POST request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest Post(String queryUrl, Dictionary<String, String> headers, Dictionary<String, Object> formParameters,
           String username = null, String password = null);

        /// <summary>
        /// Create a simple HTTP POST with a body request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest PostBody(String queryUrl, Dictionary<String, String> headers, String body,
          String username = null, String password = null);

        /// <summary>
        ///  Create a simple HTTP PUT request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest Put(String queryUrl, Dictionary<String, String> headers, Dictionary<String, Object> formParameters,
          String username = null, String password = null);

        /// <summary>
        /// Create a simple HTTP PUT with a body request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest PutBody(String queryUrl, Dictionary<String, String> headers, String body,
         String username = null, String password = null);

        /// <summary>
        ///  Create a simple HTTP PATCH request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest Patch(String queryUrl, Dictionary<String, String> headers, Dictionary<String, Object> formParameters,
         String username = null, String password = null);

        /// <summary>
        /// Create a simple HTTP Patch with a body request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest PatchBody(String queryUrl, Dictionary<String, String> headers, String body,
         String username = null, String password = null);

        /// <summary>
        ///  Create a simple HTTP DELETE request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest Delete(String queryUrl, Dictionary<String, String> headers, Dictionary<String, Object> formParameters,
          String username = null, String password = null);

        /// <summary>
        /// Create a simple HTTP Delete with a body request given relavent parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <param name="username">Basic Auth username</param>
        /// <param name="password">Basic Auth password</param>
        /// <returns> HttpRequest initialised with the http parameters specified</returns>
        HttpRequest DeleteBody(String queryUrl, Dictionary<String, String> headers, String body,
          String username = null, String password = null);
    }
}

