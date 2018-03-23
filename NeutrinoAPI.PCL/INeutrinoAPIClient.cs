/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using NeutrinoAPI.Controllers;

namespace NeutrinoAPI
{
    public partial interface INeutrinoAPIClient
    {

        /// <summary>
        /// Singleton access to Imaging controller
        /// </summary>
        IImaging Imaging { get;}

        /// <summary>
        /// Singleton access to Telephony controller
        /// </summary>
        ITelephony Telephony { get;}

        /// <summary>
        /// Singleton access to DataTools controller
        /// </summary>
        IDataTools DataTools { get;}

        /// <summary>
        /// Singleton access to SecurityAndNetworking controller
        /// </summary>
        ISecurityAndNetworking SecurityAndNetworking { get;}

        /// <summary>
        /// Singleton access to Geolocation controller
        /// </summary>
        IGeolocation Geolocation { get;}

        /// <summary>
        /// Singleton access to ECommerce controller
        /// </summary>
        IECommerce ECommerce { get;}

    }
}