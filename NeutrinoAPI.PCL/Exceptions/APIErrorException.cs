/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NeutrinoAPI.Http.Client;

using NeutrinoAPI.Models;
using NeutrinoAPI;
using NeutrinoAPI.Utilities;


namespace NeutrinoAPI.Exceptions
{
    public class APIErrorException : APIException 
    {
        // These fields hold the values for the public properties.
        private int apiError;
        private string apiErrorMsg;

        /// <summary>
        /// API error code. If set and > 0 then an API error has occurred your request could not be completed
        /// </summary>
        [JsonProperty("apiError")]
        public int ApiError 
        { 
            get 
            {
                return this.apiError; 
            } 
            private set 
            {
                this.apiError = value;
            }
        }

        /// <summary>
        /// API error message
        /// </summary>
        [JsonProperty("apiErrorMsg")]
        public string ApiErrorMsg 
        { 
            get 
            {
                return this.apiErrorMsg; 
            } 
            private set 
            {
                this.apiErrorMsg = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public APIErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 