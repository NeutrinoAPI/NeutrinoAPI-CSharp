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
        /// Parse, validate and clean an email address. See: https://www.neutrinoapi.com/api/email-validate/
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        public Models.EmailValidateResponse EmailValidate(string email, bool? fixTypos = false)
        {
            Task<Models.EmailValidateResponse> t = EmailValidateAsync(email, fixTypos);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Parse, validate and clean an email address. See: https://www.neutrinoapi.com/api/email-validate/
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        public async Task<Models.EmailValidateResponse> EmailValidateAsync(string email, bool? fixTypos = false)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

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
        /// Parse, validate and get detailed user-agent information from a user agent string. See: https://www.neutrinoapi.com/api/user-agent-info/
        /// </summary>
        /// <param name="userAgent">Required parameter: A user agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        public Models.UserAgentInfoResponse UserAgentInfo(string userAgent)
        {
            Task<Models.UserAgentInfoResponse> t = UserAgentInfoAsync(userAgent);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Parse, validate and get detailed user-agent information from a user agent string. See: https://www.neutrinoapi.com/api/user-agent-info/
        /// </summary>
        /// <param name="userAgent">Required parameter: A user agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        public async Task<Models.UserAgentInfoResponse> UserAgentInfoAsync(string userAgent)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

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
        /// Detect bad words, swear words and profanity in a given text. See: https://www.neutrinoapi.com/api/bad-word-filter/
        /// </summary>
        /// <param name="content">Required parameter: The content to scan. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        public Models.BadWordFilterResponse BadWordFilter(string content, string censorCharacter = null)
        {
            Task<Models.BadWordFilterResponse> t = BadWordFilterAsync(content, censorCharacter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text. See: https://www.neutrinoapi.com/api/bad-word-filter/
        /// </summary>
        /// <param name="content">Required parameter: The content to scan. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        public async Task<Models.BadWordFilterResponse> BadWordFilterAsync(string content, string censorCharacter = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

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
        /// A powerful unit conversion tool. See: https://www.neutrinoapi.com/api/convert/
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from (e.g. 10.95)</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from (e.g. USD)</param>
        /// <param name="toType">Required parameter: The type to convert to (e.g. EUR)</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        public Models.ConvertResponse Convert(string fromValue, string fromType, string toType)
        {
            Task<Models.ConvertResponse> t = ConvertAsync(fromValue, fromType, toType);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// A powerful unit conversion tool. See: https://www.neutrinoapi.com/api/convert/
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from (e.g. 10.95)</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from (e.g. USD)</param>
        /// <param name="toType">Required parameter: The type to convert to (e.g. EUR)</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        public async Task<Models.ConvertResponse> ConvertAsync(string fromValue, string fromType, string toType)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

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
        /// Parse, validate and get location information about a phone number. See: https://www.neutrinoapi.com/api/phone-validate/
        /// </summary>
        /// <param name="number">Required parameter: A phone number. This can be in international format (E.164) or local format. If passing local format you should use the 'country-code' or 'ip' options as well</param>
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
        /// Parse, validate and get location information about a phone number. See: https://www.neutrinoapi.com/api/phone-validate/
        /// </summary>
        /// <param name="number">Required parameter: A phone number. This can be in international format (E.164) or local format. If passing local format you should use the 'country-code' or 'ip' options as well</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="ip">Optional parameter: Pass in a users IP address and we will assume numbers are based in the country of the IP address</param>
        /// <return>Returns the Models.PhoneValidateResponse response from the API call</return>
        public async Task<Models.PhoneValidateResponse> PhoneValidateAsync(string number, string countryCode = null, string ip = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

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