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
    public partial class TelephonyController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TelephonyController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TelephonyController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TelephonyController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Make an automated call to any valid phone number and playback an audio message. See: https://www.neutrinoapi.com/api/phone-playback/
        /// </summary>
        /// <param name="audioUrl">Required parameter: A URL to a valid audio file. Accepted audio formats are: MP3, WAV, OGG</param>
        /// <param name="number">Required parameter: The phone number to call. Must be valid international format</param>
        /// <return>Returns the PhonePlaybackResponse response from the API call</return>
        public PhonePlaybackResponse PhonePlayback(
                string audioUrl,
                string number)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/phone-playback");


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
                { "audio-url", audioUrl },
                { "number", number },
                { "output-case", "camel" }
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
                return APIHelper.JsonDeserialize<PhonePlaybackResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Check if a security code from one of the verify APIs is valid. See: https://www.neutrinoapi.com/api/verify-security-code/
        /// </summary>
        /// <param name="securityCode">Required parameter: The security code to verify</param>
        /// <return>Returns the VerifySecurityCodeResponse response from the API call</return>
        public VerifySecurityCodeResponse VerifySecurityCode(
                int securityCode)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/verify-security-code");


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
                { "security-code", securityCode }
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
                return APIHelper.JsonDeserialize<VerifySecurityCodeResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Mobile network HLR lookup service. See: https://www.neutrinoapi.com/api/hlr-lookup/
        /// </summary>
        /// <param name="number">Required parameter: A phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the HLRLookupResponse response from the API call</return>
        public HLRLookupResponse HLRLookup(
                string number,
                string countryCode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/hlr-lookup");


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
                return APIHelper.JsonDeserialize<HLRLookupResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Make an automated call to any valid phone number and playback a unique security code. See: https://www.neutrinoapi.com/api/phone-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send the verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (between 4 and 12)</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to playback the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian</param>
        /// <param name="playbackDelay">Optional parameter: The delay in milliseconds between the playback of each security code</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported)</param>
        /// <return>Returns the PhoneVerifyResponse response from the API call</return>
        public PhoneVerifyResponse PhoneVerify(
                string number,
                int? codeLength = null,
                string countryCode = null,
                string languageCode = null,
                int? playbackDelay = null,
                int? securityCode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/phone-verify");


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
                { "code-length", (null != codeLength) ? codeLength : 6 },
                { "country-code", countryCode },
                { "language-code", (null != languageCode) ? languageCode : "en" },
                { "playback-delay", (null != playbackDelay) ? playbackDelay : 800 },
                { "security-code", securityCode }
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
                return APIHelper.JsonDeserialize<PhoneVerifyResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Send a unique security code to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (must be between 4 and 12)</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to send the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian</param>
        /// <param name="securityCode">Optional parameter: ass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported)</param>
        /// <return>Returns the SMSVerifyResponse response from the API call</return>
        public SMSVerifyResponse SMSVerify(
                string number,
                int? codeLength = null,
                string countryCode = null,
                string languageCode = null,
                int? securityCode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/sms-verify");


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
                { "code-length", (null != codeLength) ? codeLength : 5 },
                { "country-code", countryCode },
                { "language-code", (null != languageCode) ? languageCode : "en" },
                { "security-code", securityCode }
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
                return APIHelper.JsonDeserialize<SMSVerifyResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 