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
    public partial class Geolocation: BaseController, IGeolocation
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static Geolocation instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static Geolocation Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new Geolocation();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Convert a geographic coordinate (latitude and longitude) into a real world address. See: https://www.neutrinoapi.com/api/geocode-reverse/
        /// </summary>
        /// <param name="latitude">Required parameter: The location latitude in decimal degrees format</param>
        /// <param name="longitude">Required parameter: The location longitude in decimal degrees format</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="zoom">Optional parameter: The zoom level to respond with: <ul> <li>address - the most precise address available</li> <li>street - the street level</li> <li>city - the city level</li> <li>state - the state level</li> <li>country - the country level</li> </ul></param>
        /// <return>Returns the Models.GeocodeReverseResponse response from the API call</return>
        public Models.GeocodeReverseResponse GeocodeReverse(
                string latitude,
                string longitude,
                string languageCode = "en",
                string zoom = "address")
        {
            Task<Models.GeocodeReverseResponse> t = GeocodeReverseAsync(latitude, longitude, languageCode, zoom);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Convert a geographic coordinate (latitude and longitude) into a real world address. See: https://www.neutrinoapi.com/api/geocode-reverse/
        /// </summary>
        /// <param name="latitude">Required parameter: The location latitude in decimal degrees format</param>
        /// <param name="longitude">Required parameter: The location longitude in decimal degrees format</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="zoom">Optional parameter: The zoom level to respond with: <ul> <li>address - the most precise address available</li> <li>street - the street level</li> <li>city - the city level</li> <li>state - the state level</li> <li>country - the country level</li> </ul></param>
        /// <return>Returns the Models.GeocodeReverseResponse response from the API call</return>
        public async Task<Models.GeocodeReverseResponse> GeocodeReverseAsync(
                string latitude,
                string longitude,
                string languageCode = "en",
                string zoom = "address")
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/geocode-reverse");

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
                new KeyValuePair<string, object>( "latitude", latitude ),
                new KeyValuePair<string, object>( "longitude", longitude ),
                new KeyValuePair<string, object>( "language-code", (null != languageCode) ? languageCode : "en" ),
                new KeyValuePair<string, object>( "zoom", (null != zoom) ? zoom : "address" )
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
                return APIHelper.JsonDeserialize<Models.GeocodeReverseResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get location information about an IP address and do reverse DNS (PTR) lookups. See: https://www.neutrinoapi.com/api/ip-info/
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <param name="reverseLookup">Optional parameter: Do a reverse DNS (PTR) lookup. This option can add extra delay to the request so only use it if you need it</param>
        /// <return>Returns the Models.IPInfoResponse response from the API call</return>
        public Models.IPInfoResponse IPInfo(string ip, bool? reverseLookup = false)
        {
            Task<Models.IPInfoResponse> t = IPInfoAsync(ip, reverseLookup);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get location information about an IP address and do reverse DNS (PTR) lookups. See: https://www.neutrinoapi.com/api/ip-info/
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <param name="reverseLookup">Optional parameter: Do a reverse DNS (PTR) lookup. This option can add extra delay to the request so only use it if you need it</param>
        /// <return>Returns the Models.IPInfoResponse response from the API call</return>
        public async Task<Models.IPInfoResponse> IPInfoAsync(string ip, bool? reverseLookup = false)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ip-info");

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
                new KeyValuePair<string, object>( "ip", ip ),
                new KeyValuePair<string, object>( "reverse-lookup", (null != reverseLookup) ? reverseLookup : false )
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
                return APIHelper.JsonDeserialize<Models.IPInfoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Geocode an address, partial address or just the name of a place. See: https://www.neutrinoapi.com/api/geocode-address/
        /// </summary>
        /// <param name="address">Required parameter: The address, partial address or name of a place to try and locate</param>
        /// <param name="countryCode">Optional parameter: The ISO 2-letter country code to be biased towards (the default is no country bias)</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="fuzzySearch">Optional parameter: If no matches are found for the given address, start performing a recursive fuzzy search until a geolocation is found. This option is recommended for processing user input or implementing auto-complete. We use a combination of approximate string matching and data cleansing to find possible location matches</param>
        /// <return>Returns the Models.GeocodeAddressResponse response from the API call</return>
        public Models.GeocodeAddressResponse GeocodeAddress(
                string address,
                string countryCode = null,
                string languageCode = "en",
                bool? fuzzySearch = false)
        {
            Task<Models.GeocodeAddressResponse> t = GeocodeAddressAsync(address, countryCode, languageCode, fuzzySearch);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Geocode an address, partial address or just the name of a place. See: https://www.neutrinoapi.com/api/geocode-address/
        /// </summary>
        /// <param name="address">Required parameter: The address, partial address or name of a place to try and locate</param>
        /// <param name="countryCode">Optional parameter: The ISO 2-letter country code to be biased towards (the default is no country bias)</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="fuzzySearch">Optional parameter: If no matches are found for the given address, start performing a recursive fuzzy search until a geolocation is found. This option is recommended for processing user input or implementing auto-complete. We use a combination of approximate string matching and data cleansing to find possible location matches</param>
        /// <return>Returns the Models.GeocodeAddressResponse response from the API call</return>
        public async Task<Models.GeocodeAddressResponse> GeocodeAddressAsync(
                string address,
                string countryCode = null,
                string languageCode = "en",
                bool? fuzzySearch = false)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/geocode-address");

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
                new KeyValuePair<string, object>( "address", address ),
                new KeyValuePair<string, object>( "country-code", countryCode ),
                new KeyValuePair<string, object>( "language-code", (null != languageCode) ? languageCode : "en" ),
                new KeyValuePair<string, object>( "fuzzy-search", (null != fuzzySearch) ? fuzzySearch : false )
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
                return APIHelper.JsonDeserialize<Models.GeocodeAddressResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 