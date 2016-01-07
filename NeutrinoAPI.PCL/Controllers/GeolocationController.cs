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
    public partial class GeolocationController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static GeolocationController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static GeolocationController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new GeolocationController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get location information about an IP address and do reverse DNS (PTR) lookups. See: https://www.neutrinoapi.com/api/ip-info/
        /// </summary>
        /// <param name="ip">Required parameter: The IP address</param>
        /// <param name="reverseLookup">Optional parameter: Do reverse DNS (PTR) lookup. This option can add extra delay to the request so only use it if you need it</param>
        /// <return>Returns the IPInfoResponse response from the API call</return>
        public IPInfoResponse IPInfo(
                string ip,
                bool? reverseLookup = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ip-info");


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
                { "ip", ip },
                { "output-case", "camel" },
                { "reverse-lookup", (null != reverseLookup) ? reverseLookup : false }
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
                return APIHelper.JsonDeserialize<IPInfoResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Geocode an address or partial address. See: https://www.neutrinoapi.com/api/geocode-address/
        /// </summary>
        /// <param name="address">Required parameter: The address or partial address to try and locate</param>
        /// <param name="countryCode">Optional parameter: The ISO 2-letter country code to be biased towards (default is no country bias)</param>
        /// <param name="languageCode">Optional parameter: The language to display results in</param>
        /// <return>Returns the GeocodeAddressResponse response from the API call</return>
        public GeocodeAddressResponse GeocodeAddress(
                string address,
                string countryCode = null,
                string languageCode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/geocode-address");


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
                { "address", address },
                { "output-case", "camel" },
                { "country-code", countryCode },
                { "language-code", (null != languageCode) ? languageCode : "en" }
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
                return APIHelper.JsonDeserialize<GeocodeAddressResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Reverse geocoding is the process of taking a coordinate (latitude and longitude) and mapping this to a real world address or location. See: https://www.neutrinoapi.com/api/geocode-reverse/
        /// </summary>
        /// <param name="latitude">Required parameter: The location latitude</param>
        /// <param name="longitude">Required parameter: The location longitude</param>
        /// <param name="languageCode">Optional parameter: The language to display results in</param>
        /// <return>Returns the GeocodeReverseResponse response from the API call</return>
        public GeocodeReverseResponse GeocodeReverse(
                double latitude,
                double longitude,
                string languageCode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/geocode-reverse");


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
                { "latitude", latitude },
                { "longitude", longitude },
                { "output-case", "camel" },
                { "language-code", (null != languageCode) ? languageCode : "en" }
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
                return APIHelper.JsonDeserialize<GeocodeReverseResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 