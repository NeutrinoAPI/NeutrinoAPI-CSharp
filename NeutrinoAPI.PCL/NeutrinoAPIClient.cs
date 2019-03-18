/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using NeutrinoAPI.Controllers;
using NeutrinoAPI.Http.Client;
using NeutrinoAPI.Utilities;

namespace NeutrinoAPI
{
    public partial class NeutrinoAPIClient: INeutrinoAPIClient
    {

        /// <summary>
        /// Singleton access to WWW controller
        /// </summary>
        public IWWW WWW
        {
            get
            {
                return NeutrinoAPI.Controllers.WWW.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Imaging controller
        /// </summary>
        public IImaging Imaging
        {
            get
            {
                return NeutrinoAPI.Controllers.Imaging.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Telephony controller
        /// </summary>
        public ITelephony Telephony
        {
            get
            {
                return NeutrinoAPI.Controllers.Telephony.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ECommerce controller
        /// </summary>
        public IECommerce ECommerce
        {
            get
            {
                return NeutrinoAPI.Controllers.ECommerce.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Geolocation controller
        /// </summary>
        public IGeolocation Geolocation
        {
            get
            {
                return NeutrinoAPI.Controllers.Geolocation.Instance;
            }
        }

        /// <summary>
        /// Singleton access to SecurityAndNetworking controller
        /// </summary>
        public ISecurityAndNetworking SecurityAndNetworking
        {
            get
            {
                return NeutrinoAPI.Controllers.SecurityAndNetworking.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DataTools controller
        /// </summary>
        public IDataTools DataTools
        {
            get
            {
                return NeutrinoAPI.Controllers.DataTools.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public NeutrinoAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public NeutrinoAPIClient(string userId, string apiKey)
        {
            Configuration.UserId = userId;
            Configuration.ApiKey = apiKey;
        }
        #endregion
    }
}