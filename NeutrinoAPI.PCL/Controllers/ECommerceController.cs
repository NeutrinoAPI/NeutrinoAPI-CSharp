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
    public partial class ECommerceController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ECommerceController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ECommerceController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ECommerceController();
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
        /// <param name="customerIp">Optional parameter: Pass in a customers remote IP address. The API will then determine the country of the IP address and match it against the BIN country. This feature is designed for fraud prevention and detection checks.</param>
        /// <return>Returns the BINLookupResponse response from the API call</return>
        public BINLookupResponse BINLookup(
                string binNumber,
                string customerIp = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/bin-lookup");


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
                { "bin-number", binNumber },
                { "output-case", "camel" },
                { "customer-ip", customerIp }
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
                return APIHelper.JsonDeserialize<BINLookupResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 