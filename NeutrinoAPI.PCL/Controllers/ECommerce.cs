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
    public partial class ECommerce: BaseController, IECommerce
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ECommerce instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ECommerce Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ECommerce();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Perform a BIN (Bank Identification Number) or IIN (Issuer Identification Number) lookup. See: https://www.neutrinoapi.com/api/bin-lookup/
        /// </summary>
        /// <param name="binNumber">Required parameter: The BIN or IIN number (the first 6 digits of a credit card number)</param>
        /// <param name="customerIp">Optional parameter: Pass in the customers IP address and we will return some extra information about them</param>
        /// <return>Returns the Models.BINLookupResponse response from the API call</return>
        public Models.BINLookupResponse BINLookup(string binNumber, string customerIp = null)
        {
            Task<Models.BINLookupResponse> t = BINLookupAsync(binNumber, customerIp);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Perform a BIN (Bank Identification Number) or IIN (Issuer Identification Number) lookup. See: https://www.neutrinoapi.com/api/bin-lookup/
        /// </summary>
        /// <param name="binNumber">Required parameter: The BIN or IIN number (the first 6 digits of a credit card number)</param>
        /// <param name="customerIp">Optional parameter: Pass in the customers IP address and we will return some extra information about them</param>
        /// <return>Returns the Models.BINLookupResponse response from the API call</return>
        public async Task<Models.BINLookupResponse> BINLookupAsync(string binNumber, string customerIp = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/bin-lookup");

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
                new KeyValuePair<string, object>( "bin-number", binNumber ),
                new KeyValuePair<string, object>( "customer-ip", customerIp )
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
                return APIHelper.JsonDeserialize<Models.BINLookupResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 