/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeutrinoAPI;
using NeutrinoAPI.Utilities;
using NeutrinoAPI.Http.Request;
using NeutrinoAPI.Http.Response;
using NeutrinoAPI.Http.Client;
using NeutrinoAPI.Models;

namespace NeutrinoAPI.Controllers
{
    public partial interface IECommerce
    {
        /// <summary>
        /// Perform a BIN (Bank Identification Number) or IIN (Issuer Identification Number) lookup. See: https://www.neutrinoapi.com/api/bin-lookup/
        /// </summary>
        /// <param name="binNumber">Required parameter: The BIN or IIN number (the first 6 digits of a credit card number)</param>
        /// <param name="customerIp">Optional parameter: Pass in a customers remote IP address. The API will then determine the country of the IP address and match it against the BIN country. This feature is designed for fraud prevention and detection checks.</param>
        /// <return>Returns the Models.BINLookupResponse response from the API call</return>
        Models.BINLookupResponse BINLookup(string binNumber, string customerIp = null);

        /// <summary>
        /// Perform a BIN (Bank Identification Number) or IIN (Issuer Identification Number) lookup. See: https://www.neutrinoapi.com/api/bin-lookup/
        /// </summary>
        /// <param name="binNumber">Required parameter: The BIN or IIN number (the first 6 digits of a credit card number)</param>
        /// <param name="customerIp">Optional parameter: Pass in a customers remote IP address. The API will then determine the country of the IP address and match it against the BIN country. This feature is designed for fraud prevention and detection checks.</param>
        /// <return>Returns the Models.BINLookupResponse response from the API call</return>
        Task<Models.BINLookupResponse> BINLookupAsync(string binNumber, string customerIp = null);

    }
} 