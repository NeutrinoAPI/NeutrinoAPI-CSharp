/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 01/07/2016
 */
using System;
using NeutrinoAPI.PCL.Http.Client;

namespace NeutrinoAPI.PCL
{
    public class APIException : Exception
    {
        /// <summary>
        /// The HTTP response code from the API request
        /// </summary>
        public int ResponseCode
        {
            get { return this.HttpContext != null ? HttpContext.Response.StatusCode : -1; }
        }

		/// <summary>
        /// HttpContext stores the request and response
        /// </summary>
        public HttpContext HttpContext { get; set; }
        
        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public APIException(string reason, HttpContext context)
            : base(reason)
        {
            this.HttpContext = context;
        }
    }
}