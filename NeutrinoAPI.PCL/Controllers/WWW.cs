/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using NeutrinoAPI;
using NeutrinoAPI.Utilities;
using NeutrinoAPI.Http.Request;
using NeutrinoAPI.Http.Response;
using NeutrinoAPI.Http.Client;
using NeutrinoAPI.Exceptions;

namespace NeutrinoAPI.Controllers
{
    public partial class WWW: BaseController, IWWW
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static WWW instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static WWW Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new WWW();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Parse, analyze and retrieve content from the supplied URL. See: https://www.neutrinoapi.com/api/url-info/
        /// </summary>
        /// <param name="url">Required parameter: The URL to probe</param>
        /// <param name="fetchContent">Optional parameter: If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content (e.g. with the HTML Extract or HTML Clean APIs)</param>
        /// <param name="ignoreCertificateErrors">Optional parameter: Ignore any TLS/SSL certificate errors and load the URL anyway</param>
        /// <param name="timeout">Optional parameter: Timeout in seconds. Give up if still trying to load the URL after this number of seconds</param>
        /// <return>Returns the Models.URLInfoResponse response from the API call</return>
        public Models.URLInfoResponse URLInfo(
                string url,
                bool? fetchContent = false,
                bool? ignoreCertificateErrors = false,
                int? timeout = 20)
        {
            Task<Models.URLInfoResponse> t = URLInfoAsync(url, fetchContent, ignoreCertificateErrors, timeout);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Parse, analyze and retrieve content from the supplied URL. See: https://www.neutrinoapi.com/api/url-info/
        /// </summary>
        /// <param name="url">Required parameter: The URL to probe</param>
        /// <param name="fetchContent">Optional parameter: If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content (e.g. with the HTML Extract or HTML Clean APIs)</param>
        /// <param name="ignoreCertificateErrors">Optional parameter: Ignore any TLS/SSL certificate errors and load the URL anyway</param>
        /// <param name="timeout">Optional parameter: Timeout in seconds. Give up if still trying to load the URL after this number of seconds</param>
        /// <return>Returns the Models.URLInfoResponse response from the API call</return>
        public async Task<Models.URLInfoResponse> URLInfoAsync(
                string url,
                bool? fetchContent = false,
                bool? ignoreCertificateErrors = false,
                int? timeout = 20)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/url-info");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "output-case", "camel" ),
                new KeyValuePair<string, object>( "url", url ),
                new KeyValuePair<string, object>( "fetch-content", (null != fetchContent) ? fetchContent : false ),
                new KeyValuePair<string, object>( "ignore-certificate-errors", (null != ignoreCertificateErrors) ? ignoreCertificateErrors : false ),
                new KeyValuePair<string, object>( "timeout", (null != timeout) ? timeout : 20 )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.URLInfoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Clean and sanitize untrusted HTML. See: https://www.neutrinoapi.com/api/html-clean/
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are: <b>plain-text</b>: reduce the content to plain text only (no HTML tags at all) <b>simple-text</b>: allow only very basic text formatting tags like b, em, i, strong, u <b>basic-html</b>: allow advanced text formatting and hyper links <b>basic-html-with-images</b>: same as basic html but also allows image tags <b>advanced-html</b>: same as basic html with images but also allows many more common HTML tags like table, ul, dl, pre</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream HTMLClean(string content, string outputType)
        {
            Task<Stream> t = HTMLCleanAsync(content, outputType);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Clean and sanitize untrusted HTML. See: https://www.neutrinoapi.com/api/html-clean/
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are: <b>plain-text</b>: reduce the content to plain text only (no HTML tags at all) <b>simple-text</b>: allow only very basic text formatting tags like b, em, i, strong, u <b>basic-html</b>: allow advanced text formatting and hyper links <b>basic-html-with-images</b>: same as basic html but also allows image tags <b>advanced-html</b>: same as basic html with images but also allows many more common HTML tags like table, ul, dl, pre</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> HTMLCleanAsync(string content, string outputType)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/html-clean");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "content", content ),
                new KeyValuePair<string, object>( "output-type", outputType )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Browser bot can extract content, interact with keyboard and mouse events, and execute JavaScript on a website. See: https://www.neutrinoapi.com/api/browser-bot/
        /// </summary>
        /// <param name="url">Required parameter: The URL to load</param>
        /// <param name="timeout">Optional parameter: Timeout in seconds. Give up if still trying to load the page after this number of seconds</param>
        /// <param name="delay">Optional parameter: Delay in seconds to wait before capturing any page data, executing selectors or JavaScript</param>
        /// <param name="selector">Optional parameter: Extract content from the page DOM using this selector. Commonly known as a CSS selector, you can find a good reference <a href="https://www.w3schools.com/cssref/css_selectors.asp">here</a></param>
        /// <param name="exec">Optional parameter: Execute JavaScript on the page. Each array element should contain a valid JavaScript statement in string form. If a statement returns any kind of value it will be returned in the 'exec-results' response. For your convenience you can also use the following special shortcut functions: <div> sleep(seconds); Just wait/sleep for the specified number of seconds. click('selector'); Click on the first element matching the given selector. focus('selector'); Focus on the first element matching the given selector. keys('characters'); Send the specified keyboard characters. Use click() or focus() first to send keys to a specific element. enter(); Send the Enter key. tab(); Send the Tab key. </div> Example: <div> [ "click('#button-id')", "sleep(1)", "click('.field-class')", "keys('1234')", "enter()" ] </div></param>
        /// <param name="userAgent">Optional parameter: Override the browsers default user-agent string with this one</param>
        /// <param name="ignoreCertificateErrors">Optional parameter: Ignore any TLS/SSL certificate errors and load the page anyway</param>
        /// <return>Returns the Models.BrowserBotResponse response from the API call</return>
        public Models.BrowserBotResponse BrowserBot(
                string url,
                int? timeout = 30,
                int? delay = 3,
                string selector = null,
                List<string> exec = null,
                string userAgent = null,
                bool? ignoreCertificateErrors = false)
        {
            Task<Models.BrowserBotResponse> t = BrowserBotAsync(url, timeout, delay, selector, exec, userAgent, ignoreCertificateErrors);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Browser bot can extract content, interact with keyboard and mouse events, and execute JavaScript on a website. See: https://www.neutrinoapi.com/api/browser-bot/
        /// </summary>
        /// <param name="url">Required parameter: The URL to load</param>
        /// <param name="timeout">Optional parameter: Timeout in seconds. Give up if still trying to load the page after this number of seconds</param>
        /// <param name="delay">Optional parameter: Delay in seconds to wait before capturing any page data, executing selectors or JavaScript</param>
        /// <param name="selector">Optional parameter: Extract content from the page DOM using this selector. Commonly known as a CSS selector, you can find a good reference <a href="https://www.w3schools.com/cssref/css_selectors.asp">here</a></param>
        /// <param name="exec">Optional parameter: Execute JavaScript on the page. Each array element should contain a valid JavaScript statement in string form. If a statement returns any kind of value it will be returned in the 'exec-results' response. For your convenience you can also use the following special shortcut functions: <div> sleep(seconds); Just wait/sleep for the specified number of seconds. click('selector'); Click on the first element matching the given selector. focus('selector'); Focus on the first element matching the given selector. keys('characters'); Send the specified keyboard characters. Use click() or focus() first to send keys to a specific element. enter(); Send the Enter key. tab(); Send the Tab key. </div> Example: <div> [ "click('#button-id')", "sleep(1)", "click('.field-class')", "keys('1234')", "enter()" ] </div></param>
        /// <param name="userAgent">Optional parameter: Override the browsers default user-agent string with this one</param>
        /// <param name="ignoreCertificateErrors">Optional parameter: Ignore any TLS/SSL certificate errors and load the page anyway</param>
        /// <return>Returns the Models.BrowserBotResponse response from the API call</return>
        public async Task<Models.BrowserBotResponse> BrowserBotAsync(
                string url,
                int? timeout = 30,
                int? delay = 3,
                string selector = null,
                List<string> exec = null,
                string userAgent = null,
                bool? ignoreCertificateErrors = false)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/browser-bot");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "output-case", "camel" ),
                new KeyValuePair<string, object>( "url", url ),
                new KeyValuePair<string, object>( "timeout", (null != timeout) ? timeout : 30 ),
                new KeyValuePair<string, object>( "delay", (null != delay) ? delay : 3 ),
                new KeyValuePair<string, object>( "selector", selector ),
                new KeyValuePair<string, object>( "user-agent", userAgent ),
                new KeyValuePair<string, object>( "ignore-certificate-errors", (null != ignoreCertificateErrors) ? ignoreCertificateErrors : false )
            };
            _fields.AddRange(APIHelper.PrepareFormFieldsFromObject("exec", exec, arrayDeserializationFormat: ArrayDeserializationFormat));
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.BrowserBotResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 