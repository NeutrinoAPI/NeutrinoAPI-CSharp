/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io ).
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

namespace NeutrinoAPI.Controllers
{
    public partial interface IGeolocation
    {
        /// <summary>
        /// Convert a geographic coordinate (latitude and longitude) into a real world address. See: https://www.neutrinoapi.com/api/geocode-reverse/
        /// </summary>
        /// <param name="latitude">Required parameter: The location latitude in decimal degrees format</param>
        /// <param name="longitude">Required parameter: The location longitude in decimal degrees format</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="zoom">Optional parameter: The zoom level to respond with: <ul> <li>address - the most precise address available</li> <li>street - the street level</li> <li>city - the city level</li> <li>state - the state level</li> <li>country - the country level</li> </ul></param>
        /// <return>Returns the Models.GeocodeReverseResponse response from the API call</return>
        Models.GeocodeReverseResponse GeocodeReverse(
                string latitude,
                string longitude,
                string languageCode = "en",
                string zoom = "address");

        /// <summary>
        /// Convert a geographic coordinate (latitude and longitude) into a real world address. See: https://www.neutrinoapi.com/api/geocode-reverse/
        /// </summary>
        /// <param name="latitude">Required parameter: The location latitude in decimal degrees format</param>
        /// <param name="longitude">Required parameter: The location longitude in decimal degrees format</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="zoom">Optional parameter: The zoom level to respond with: <ul> <li>address - the most precise address available</li> <li>street - the street level</li> <li>city - the city level</li> <li>state - the state level</li> <li>country - the country level</li> </ul></param>
        /// <return>Returns the Models.GeocodeReverseResponse response from the API call</return>
        Task<Models.GeocodeReverseResponse> GeocodeReverseAsync(
                string latitude,
                string longitude,
                string languageCode = "en",
                string zoom = "address");

        /// <summary>
        /// Get location information about an IP address and do reverse DNS (PTR) lookups. See: https://www.neutrinoapi.com/api/ip-info/
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <param name="reverseLookup">Optional parameter: Do a reverse DNS (PTR) lookup. This option can add extra delay to the request so only use it if you need it</param>
        /// <return>Returns the Models.IPInfoResponse response from the API call</return>
        Models.IPInfoResponse IPInfo(string ip, bool? reverseLookup = false);

        /// <summary>
        /// Get location information about an IP address and do reverse DNS (PTR) lookups. See: https://www.neutrinoapi.com/api/ip-info/
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <param name="reverseLookup">Optional parameter: Do a reverse DNS (PTR) lookup. This option can add extra delay to the request so only use it if you need it</param>
        /// <return>Returns the Models.IPInfoResponse response from the API call</return>
        Task<Models.IPInfoResponse> IPInfoAsync(string ip, bool? reverseLookup = false);

        /// <summary>
        /// Geocode an address, partial address or just the name of a place. See: https://www.neutrinoapi.com/api/geocode-address/
        /// </summary>
        /// <param name="address">Required parameter: The address, partial address or name of a place to try and locate</param>
        /// <param name="countryCode">Optional parameter: The ISO 2-letter country code to be biased towards (the default is no country bias)</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="fuzzySearch">Optional parameter: If no matches are found for the given address, start performing a recursive fuzzy search until a geolocation is found. This option is recommended for processing user input or implementing auto-complete. We use a combination of approximate string matching and data cleansing to find possible location matches</param>
        /// <return>Returns the Models.GeocodeAddressResponse response from the API call</return>
        Models.GeocodeAddressResponse GeocodeAddress(
                string address,
                string countryCode = null,
                string languageCode = "en",
                bool? fuzzySearch = false);

        /// <summary>
        /// Geocode an address, partial address or just the name of a place. See: https://www.neutrinoapi.com/api/geocode-address/
        /// </summary>
        /// <param name="address">Required parameter: The address, partial address or name of a place to try and locate</param>
        /// <param name="countryCode">Optional parameter: The ISO 2-letter country code to be biased towards (the default is no country bias)</param>
        /// <param name="languageCode">Optional parameter: The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul></param>
        /// <param name="fuzzySearch">Optional parameter: If no matches are found for the given address, start performing a recursive fuzzy search until a geolocation is found. This option is recommended for processing user input or implementing auto-complete. We use a combination of approximate string matching and data cleansing to find possible location matches</param>
        /// <return>Returns the Models.GeocodeAddressResponse response from the API call</return>
        Task<Models.GeocodeAddressResponse> GeocodeAddressAsync(
                string address,
                string countryCode = null,
                string languageCode = "en",
                bool? fuzzySearch = false);

    }
} 