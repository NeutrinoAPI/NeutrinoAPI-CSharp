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
    public partial class Telephony: BaseController, ITelephony
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static Telephony instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static Telephony Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new Telephony();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Connect to the global mobile cellular network and retrieve the status of a mobile device. See: https://www.neutrinoapi.com/api/hlr-lookup/
        /// </summary>
        /// <param name="number">Required parameter: A phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.HLRLookupResponse response from the API call</return>
        public Models.HLRLookupResponse HLRLookup(string number, string countryCode = null)
        {
            Task<Models.HLRLookupResponse> t = HLRLookupAsync(number, countryCode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Connect to the global mobile cellular network and retrieve the status of a mobile device. See: https://www.neutrinoapi.com/api/hlr-lookup/
        /// </summary>
        /// <param name="number">Required parameter: A phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.HLRLookupResponse response from the API call</return>
        public async Task<Models.HLRLookupResponse> HLRLookupAsync(string number, string countryCode = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/hlr-lookup");

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
                new KeyValuePair<string, object>( "country-code", countryCode )
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
                return APIHelper.JsonDeserialize<Models.HLRLookupResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Make an automated call to any valid phone number and playback an audio message. See: https://www.neutrinoapi.com/api/phone-playback/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to call. Must be in valid international format</param>
        /// <param name="audioUrl">Required parameter: A URL to a valid audio file. Accepted audio formats are:<ul><li>MP3</li><li>WAV</li><li>OGG</ul></ul>You can use the following MP3 URL for testing:<br/>https://www.neutrinoapi.com/test-files/test1.mp3</param>
        /// <return>Returns the Models.PhonePlaybackResponse response from the API call</return>
        public Models.PhonePlaybackResponse PhonePlayback(string number, string audioUrl)
        {
            Task<Models.PhonePlaybackResponse> t = PhonePlaybackAsync(number, audioUrl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Make an automated call to any valid phone number and playback an audio message. See: https://www.neutrinoapi.com/api/phone-playback/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to call. Must be in valid international format</param>
        /// <param name="audioUrl">Required parameter: A URL to a valid audio file. Accepted audio formats are:<ul><li>MP3</li><li>WAV</li><li>OGG</ul></ul>You can use the following MP3 URL for testing:<br/>https://www.neutrinoapi.com/test-files/test1.mp3</param>
        /// <return>Returns the Models.PhonePlaybackResponse response from the API call</return>
        public async Task<Models.PhonePlaybackResponse> PhonePlaybackAsync(string number, string audioUrl)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/phone-playback");

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
                new KeyValuePair<string, object>( "audio-url", audioUrl )
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
                return APIHelper.JsonDeserialize<Models.PhonePlaybackResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Check if a security code from one of the verify APIs is valid. See: https://www.neutrinoapi.com/api/verify-security-code/
        /// </summary>
        /// <param name="securityCode">Required parameter: The security code to verify</param>
        /// <return>Returns the Models.VerifySecurityCodeResponse response from the API call</return>
        public Models.VerifySecurityCodeResponse VerifySecurityCode(string securityCode)
        {
            Task<Models.VerifySecurityCodeResponse> t = VerifySecurityCodeAsync(securityCode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Check if a security code from one of the verify APIs is valid. See: https://www.neutrinoapi.com/api/verify-security-code/
        /// </summary>
        /// <param name="securityCode">Required parameter: The security code to verify</param>
        /// <return>Returns the Models.VerifySecurityCodeResponse response from the API call</return>
        public async Task<Models.VerifySecurityCodeResponse> VerifySecurityCodeAsync(string securityCode)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/verify-security-code");

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
                new KeyValuePair<string, object>( "security-code", securityCode )
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
                return APIHelper.JsonDeserialize<Models.VerifySecurityCodeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Send a unique security code to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (must be between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to send the verification code in, available languages are:<ul><li>de - German</li><li>en - English</li><li>es - Spanish</li><li>fr - French</li><li>it - Italian</li><li>pt - Portuguese</li><li>ru - Russian</li></ul></param>
        /// <return>Returns the Models.SMSVerifyResponse response from the API call</return>
        public Models.SMSVerifyResponse SMSVerify(
                string number,
                int? codeLength = 5,
                int? securityCode = null,
                string countryCode = null,
                string languageCode = "en")
        {
            Task<Models.SMSVerifyResponse> t = SMSVerifyAsync(number, codeLength, securityCode, countryCode, languageCode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send a unique security code to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (must be between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to send the verification code in, available languages are:<ul><li>de - German</li><li>en - English</li><li>es - Spanish</li><li>fr - French</li><li>it - Italian</li><li>pt - Portuguese</li><li>ru - Russian</li></ul></param>
        /// <return>Returns the Models.SMSVerifyResponse response from the API call</return>
        public async Task<Models.SMSVerifyResponse> SMSVerifyAsync(
                string number,
                int? codeLength = 5,
                int? securityCode = null,
                string countryCode = null,
                string languageCode = "en")
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/sms-verify");

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
                new KeyValuePair<string, object>( "code-length", (null != codeLength) ? codeLength : 5 ),
                new KeyValuePair<string, object>( "security-code", securityCode ),
                new KeyValuePair<string, object>( "country-code", countryCode ),
                new KeyValuePair<string, object>( "language-code", (null != languageCode) ? languageCode : "en" )
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
                return APIHelper.JsonDeserialize<Models.SMSVerifyResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Send a free-form message to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-message/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a message to</param>
        /// <param name="message">Required parameter: The SMS message to send. Messages are truncated to a maximum of 150 characters for ASCII content OR 70 characters for UTF content</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.SMSMessageResponse response from the API call</return>
        public Models.SMSMessageResponse SMSMessage(string number, string message, string countryCode = null)
        {
            Task<Models.SMSMessageResponse> t = SMSMessageAsync(number, message, countryCode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send a free-form message to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-message/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a message to</param>
        /// <param name="message">Required parameter: The SMS message to send. Messages are truncated to a maximum of 150 characters for ASCII content OR 70 characters for UTF content</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.SMSMessageResponse response from the API call</return>
        public async Task<Models.SMSMessageResponse> SMSMessageAsync(string number, string message, string countryCode = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/sms-message");

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
                new KeyValuePair<string, object>( "message", message ),
                new KeyValuePair<string, object>( "country-code", countryCode )
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
                return APIHelper.JsonDeserialize<Models.SMSMessageResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Make an automated call to any valid phone number and playback a unique security code. See: https://www.neutrinoapi.com/api/phone-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send the verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="playbackDelay">Optional parameter: The delay in milliseconds between the playback of each security code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to playback the verification code in, available languages are:<ul><li>de - German</li><li>en - English</li><li>es - Spanish</li><li>fr - French</li><li>it - Italian</li><li>pt - Portuguese</li><li>ru - Russian</li></ul></param>
        /// <return>Returns the Models.PhoneVerifyResponse response from the API call</return>
        public Models.PhoneVerifyResponse PhoneVerify(
                string number,
                int? codeLength = 6,
                int? securityCode = null,
                int? playbackDelay = 800,
                string countryCode = null,
                string languageCode = "en")
        {
            Task<Models.PhoneVerifyResponse> t = PhoneVerifyAsync(number, codeLength, securityCode, playbackDelay, countryCode, languageCode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Make an automated call to any valid phone number and playback a unique security code. See: https://www.neutrinoapi.com/api/phone-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send the verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="playbackDelay">Optional parameter: The delay in milliseconds between the playback of each security code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to playback the verification code in, available languages are:<ul><li>de - German</li><li>en - English</li><li>es - Spanish</li><li>fr - French</li><li>it - Italian</li><li>pt - Portuguese</li><li>ru - Russian</li></ul></param>
        /// <return>Returns the Models.PhoneVerifyResponse response from the API call</return>
        public async Task<Models.PhoneVerifyResponse> PhoneVerifyAsync(
                string number,
                int? codeLength = 6,
                int? securityCode = null,
                int? playbackDelay = 800,
                string countryCode = null,
                string languageCode = "en")
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/phone-verify");

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
                new KeyValuePair<string, object>( "code-length", (null != codeLength) ? codeLength : 6 ),
                new KeyValuePair<string, object>( "security-code", securityCode ),
                new KeyValuePair<string, object>( "playback-delay", (null != playbackDelay) ? playbackDelay : 800 ),
                new KeyValuePair<string, object>( "country-code", countryCode ),
                new KeyValuePair<string, object>( "language-code", (null != languageCode) ? languageCode : "en" )
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
                return APIHelper.JsonDeserialize<Models.PhoneVerifyResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 