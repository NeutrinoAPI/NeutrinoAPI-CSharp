/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 01/07/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeutrinoAPI.PCL;
using NeutrinoAPI.PCL.Http.Request;
using NeutrinoAPI.PCL.Http.Response;
using NeutrinoAPI.PCL.Http.Client;

using NeutrinoAPI.PCL.Models;

namespace NeutrinoAPI.PCL.Controllers
{
    public partial class DataToolsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static DataToolsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static DataToolsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new DataToolsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Parse, validate and get location information about a phone number. See: https://www.neutrinoapi.com/api/phone-validate/
        /// </summary>
        /// <param name="number">Required parameter: The phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the PhoneValidateResponse response from the API call</return>
        public PhoneValidateResponse PhoneValidate(
                string number,
                string countryCode = null)
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "number", number },
                { "output-case", "camel" },
                { "country-code", countryCode }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) ClientInstance.ExecuteAsString(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<PhoneValidateResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Parse, validate and get detailed user-agent information from a user-agent string. See: https://www.neutrinoapi.com/api/user-agent-info/
        /// </summary>
        /// <param name="userAgent">Required parameter: A user-agent string</param>
        /// <return>Returns the UserAgentInfoResponse response from the API call</return>
        public UserAgentInfoResponse UserAgentInfo(
                string userAgent)
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "output-case", "camel" },
                { "user-agent", userAgent }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) ClientInstance.ExecuteAsString(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<UserAgentInfoResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Code highlight will take raw source code and convert into nicely formatted HTML with syntax and keyword highlighting. See: https://www.neutrinoapi.com/api/code-highlight/
        /// </summary>
        /// <param name="content">Required parameter: The source content. This can be either a URL to load from or an actual content string</param>
        /// <param name="type">Required parameter: The code type. See the API docs for all supported types</param>
        /// <param name="addKeywordLinks">Optional parameter: Add links on source code keywords to the relevant language documentation</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream CodeHighlight(
                string content,
                string type,
                bool? addKeywordLinks = null)
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "content", content },
                { "type", type },
                { "add-keyword-links", (null != addKeywordLinks) ? addKeywordLinks : false }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = ClientInstance.ExecuteAsBinary(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text. See: https://www.neutrinoapi.com/api/bad-word-filter/
        /// </summary>
        /// <param name="content">Required parameter: The text content to check. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the BadWordFilterResponse response from the API call</return>
        public BadWordFilterResponse BadWordFilter(
                string content,
                string censorCharacter = null)
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "content", content },
                { "output-case", "camel" },
                { "censor-character", censorCharacter }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) ClientInstance.ExecuteAsString(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<BadWordFilterResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// A powerful unit and currency conversion tool. See: https://www.neutrinoapi.com/api/convert/
        /// </summary>
        /// <param name="fromType">Required parameter: The type of the value to convert from</param>
        /// <param name="fromValue">Required parameter: The value to convert from</param>
        /// <param name="toType">Required parameter: The type to convert to</param>
        /// <return>Returns the ConvertResponse response from the API call</return>
        public ConvertResponse Convert(
                string fromType,
                string fromValue,
                string toType)
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "from-type", fromType },
                { "from-value", fromValue },
                { "output-case", "camel" },
                { "to-type", toType }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) ClientInstance.ExecuteAsString(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ConvertResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Parse, validate and clean an email address. See: https://www.neutrinoapi.com/api/email-validate/
        /// </summary>
        /// <param name="email">Required parameter: The email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the EmailValidateResponse response from the API call</return>
        public EmailValidateResponse EmailValidate(
                string email,
                bool? fixTypos = null)
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "email", email },
                { "output-case", "camel" },
                { "fix-typos", (null != fixTypos) ? fixTypos : false }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) ClientInstance.ExecuteAsString(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<EmailValidateResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Clean and sanitize untrusted HTML. See: https://www.neutrinoapi.com/api/html-clean/
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are: plain-text, simple-text, basic-html, basic-html-with-images, advanced-html</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream HTMLClean(
                string content,
                string outputType)
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "content", content },
                { "output-type", outputType }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = ClientInstance.ExecuteAsBinary(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Extract HTML tag contents or attributes from complex HTML or XHTML content. See: https://www.neutrinoapi.com/api/html-extract-tags/
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="tag">Required parameter: The HTML tag(s) to extract data from. This can just be a simple tag name like 'img' OR a CSS/jQuery style selector</param>
        /// <param name="attribute">Optional parameter: If set, then extract data from the specified tag attribute. If not set, then data will be extracted from the tags inner content</param>
        /// <param name="baseUrl">Optional parameter: The base URL to replace into realive links</param>
        /// <return>Returns the HTMLExtractResponse response from the API call</return>
        public HTMLExtractResponse HTMLExtract(
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
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "content", content },
                { "output-case", "camel" },
                { "tag", tag },
                { "attribute", attribute },
                { "base-url", baseUrl }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) ClientInstance.ExecuteAsString(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<HTMLExtractResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 