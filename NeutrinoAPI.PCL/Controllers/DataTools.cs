/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io )
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
using NeutrinoAPI.Models;

namespace NeutrinoAPI.Controllers
{
    public partial class DataTools: BaseController, IDataTools
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static DataTools instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static DataTools Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new DataTools();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// A powerful unit and currency conversion tool
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from</param>
        /// <param name="toType">Required parameter: The type to convert to</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        public Models.ConvertResponse Convert(string fromValue, string fromType, string toType)
        {
            Task<Models.ConvertResponse> t = ConvertAsync(fromValue, fromType, toType);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// A powerful unit and currency conversion tool
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from</param>
        /// <param name="toType">Required parameter: The type to convert to</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        public async Task<Models.ConvertResponse> ConvertAsync(string fromValue, string fromType, string toType)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/convert");

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
                new KeyValuePair<string, object>( "from-value", fromValue ),
                new KeyValuePair<string, object>( "from-type", fromType ),
                new KeyValuePair<string, object>( "to-type", toType )
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
                return APIHelper.JsonDeserialize<Models.ConvertResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text
        /// </summary>
        /// <param name="content">Required parameter: The text content to check. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        public Models.BadWordFilterResponse BadWordFilter(string content, string censorCharacter = null)
        {
            Task<Models.BadWordFilterResponse> t = BadWordFilterAsync(content, censorCharacter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text
        /// </summary>
        /// <param name="content">Required parameter: The text content to check. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        public async Task<Models.BadWordFilterResponse> BadWordFilterAsync(string content, string censorCharacter = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/bad-word-filter");

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
                new KeyValuePair<string, object>( "content", content ),
                new KeyValuePair<string, object>( "censor-character", censorCharacter )
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
                return APIHelper.JsonDeserialize<Models.BadWordFilterResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Parse, validate and clean an email address
        /// </summary>
        /// <param name="email">Required parameter: The email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        public Models.EmailValidateResponse EmailValidate(string email, bool? fixTypos = false)
        {
            Task<Models.EmailValidateResponse> t = EmailValidateAsync(email, fixTypos);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Parse, validate and clean an email address
        /// </summary>
        /// <param name="email">Required parameter: The email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        public async Task<Models.EmailValidateResponse> EmailValidateAsync(string email, bool? fixTypos = false)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email-validate");

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
                new KeyValuePair<string, object>( "email", email ),
                new KeyValuePair<string, object>( "fix-typos", (null != fixTypos) ? fixTypos : false )
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
                return APIHelper.JsonDeserialize<Models.EmailValidateResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Clean and sanitize untrusted HTML
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are: plain-text, simple-text, basic-html, basic-html-with-images, advanced-html</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream HTMLClean(string content, string outputType)
        {
            Task<Stream> t = HTMLCleanAsync(content, outputType);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Clean and sanitize untrusted HTML
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are: plain-text, simple-text, basic-html, basic-html-with-images, advanced-html</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> HTMLCleanAsync(string content, string outputType)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

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
        /// Code highlight will take raw source code and convert into nicely formatted HTML with syntax and keyword highlighting
        /// </summary>
        /// <param name="content">Required parameter: The source content. This can be either a URL to load from or an actual content string</param>
        /// <param name="type">Required parameter: The code type. See the API docs for all supported types</param>
        /// <param name="addKeywordLinks">Optional parameter: Add links on source code keywords to the relevant language documentation</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream CodeHighlight(string content, string type, bool? addKeywordLinks = false)
        {
            Task<Stream> t = CodeHighlightAsync(content, type, addKeywordLinks);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Code highlight will take raw source code and convert into nicely formatted HTML with syntax and keyword highlighting
        /// </summary>
        /// <param name="content">Required parameter: The source content. This can be either a URL to load from or an actual content string</param>
        /// <param name="type">Required parameter: The code type. See the API docs for all supported types</param>
        /// <param name="addKeywordLinks">Optional parameter: Add links on source code keywords to the relevant language documentation</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> CodeHighlightAsync(string content, string type, bool? addKeywordLinks = false)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/code-highlight");

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
                new KeyValuePair<string, object>( "type", type ),
                new KeyValuePair<string, object>( "add-keyword-links", (null != addKeywordLinks) ? addKeywordLinks : false )
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
        /// Parse, validate and get detailed user-agent information from a user agent string
        /// </summary>
        /// <param name="userAgent">Required parameter: A user-agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        public Models.UserAgentInfoResponse UserAgentInfo(string userAgent)
        {
            Task<Models.UserAgentInfoResponse> t = UserAgentInfoAsync(userAgent);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Parse, validate and get detailed user-agent information from a user agent string
        /// </summary>
        /// <param name="userAgent">Required parameter: A user-agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        public async Task<Models.UserAgentInfoResponse> UserAgentInfoAsync(string userAgent)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user-agent-info");

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
                new KeyValuePair<string, object>( "user-agent", userAgent )
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
                return APIHelper.JsonDeserialize<Models.UserAgentInfoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Extract specific HTML tag contents or attributes from complex HTML or XHTML content
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="tag">Required parameter: The HTML tag(s) to extract data from. This can just be a simple tag name like 'img' OR a CSS/jQuery style selector</param>
        /// <param name="attribute">Optional parameter: If set, then extract data from the specified tag attribute. If not set, then data will be extracted from the tags inner content</param>
        /// <param name="baseUrl">Optional parameter: The base URL to replace into realive links</param>
        /// <return>Returns the Models.HTMLExtractResponse response from the API call</return>
        public Models.HTMLExtractResponse HTMLExtract(
                string content,
                string tag,
                string attribute = null,
                string baseUrl = null)
        {
            Task<Models.HTMLExtractResponse> t = HTMLExtractAsync(content, tag, attribute, baseUrl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Extract specific HTML tag contents or attributes from complex HTML or XHTML content
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="tag">Required parameter: The HTML tag(s) to extract data from. This can just be a simple tag name like 'img' OR a CSS/jQuery style selector</param>
        /// <param name="attribute">Optional parameter: If set, then extract data from the specified tag attribute. If not set, then data will be extracted from the tags inner content</param>
        /// <param name="baseUrl">Optional parameter: The base URL to replace into realive links</param>
        /// <return>Returns the Models.HTMLExtractResponse response from the API call</return>
        public async Task<Models.HTMLExtractResponse> HTMLExtractAsync(
                string content,
                string tag,
                string attribute = null,
                string baseUrl = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/html-extract-tags");

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
                new KeyValuePair<string, object>( "content", content ),
                new KeyValuePair<string, object>( "tag", tag ),
                new KeyValuePair<string, object>( "attribute", attribute ),
                new KeyValuePair<string, object>( "base-url", baseUrl )
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
                return APIHelper.JsonDeserialize<Models.HTMLExtractResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Parse, validate and get location information about a phone number
        /// </summary>
        /// <param name="number">Required parameter: The phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="ip">Optional parameter: Pass in a users IP address and we will assume numbers are based in the country of the IP address</param>
        /// <return>Returns the Models.PhoneValidateResponse response from the API call</return>
        public Models.PhoneValidateResponse PhoneValidate(string number, string countryCode = null, string ip = null)
        {
            Task<Models.PhoneValidateResponse> t = PhoneValidateAsync(number, countryCode, ip);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Parse, validate and get location information about a phone number
        /// </summary>
        /// <param name="number">Required parameter: The phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="ip">Optional parameter: Pass in a users IP address and we will assume numbers are based in the country of the IP address</param>
        /// <return>Returns the Models.PhoneValidateResponse response from the API call</return>
        public async Task<Models.PhoneValidateResponse> PhoneValidateAsync(string number, string countryCode = null, string ip = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/phone-validate");

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
                new KeyValuePair<string, object>( "number", number ),
                new KeyValuePair<string, object>( "country-code", countryCode ),
                new KeyValuePair<string, object>( "ip", ip )
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
                return APIHelper.JsonDeserialize<Models.PhoneValidateResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 