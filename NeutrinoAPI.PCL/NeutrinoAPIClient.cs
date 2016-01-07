/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 01/07/2016
 */
using System;
using NeutrinoAPI.PCL.Controllers;

namespace NeutrinoAPI.PCL
{
    public partial class NeutrinoAPIClient
    {

        /// <summary>
        /// Singleton access to Geolocation controller
        /// </summary>
        public GeolocationController Geolocation
        {
            get
            {
                return GeolocationController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Telephony controller
        /// </summary>
        public TelephonyController Telephony
        {
            get
            {
                return TelephonyController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DataTools controller
        /// </summary>
        public DataToolsController DataTools
        {
            get
            {
                return DataToolsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Imaging controller
        /// </summary>
        public ImagingController Imaging
        {
            get
            {
                return ImagingController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to SecurityAndNetworking controller
        /// </summary>
        public SecurityAndNetworkingController SecurityAndNetworking
        {
            get
            {
                return SecurityAndNetworkingController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ECommerce controller
        /// </summary>
        public ECommerceController ECommerce
        {
            get
            {
                return ECommerceController.Instance;
            }
        }

        /// <summary>
        /// Client constructor
        /// </summary>
        public NeutrinoAPIClient(string userId, string apiKey)
        {
            Configuration.UserId = userId;
            Configuration.ApiKey = apiKey;
        }
    }
}