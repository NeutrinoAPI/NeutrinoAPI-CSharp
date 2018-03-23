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

namespace NeutrinoAPI.Controllers
{
    public partial interface ISecurityAndNetworking
    {
        /// <summary>
        /// Check the reputation of an IP address or domain against a comprehensive list of blacklists and blocklists (DNSBLs)
        /// </summary>
        /// <param name="host">Required parameter: An IPv4 address or a domain name. If you supply a domain name it will be checked against the URI DNSBL list</param>
        /// <return>Returns the Models.HostReputationResponse response from the API call</return>
        Models.HostReputationResponse HostReputation(string host);

        /// <summary>
        /// Check the reputation of an IP address or domain against a comprehensive list of blacklists and blocklists (DNSBLs)
        /// </summary>
        /// <param name="host">Required parameter: An IPv4 address or a domain name. If you supply a domain name it will be checked against the URI DNSBL list</param>
        /// <return>Returns the Models.HostReputationResponse response from the API call</return>
        Task<Models.HostReputationResponse> HostReputationAsync(string host);

        /// <summary>
        /// Parse, analyze and retrieve content from the supplied URL
        /// </summary>
        /// <param name="url">Required parameter: The URL to process</param>
        /// <param name="fetchContent">Required parameter: If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content</param>
        /// <return>Returns the Models.URLInfoResponse response from the API call</return>
        Models.URLInfoResponse URLInfo(string url, bool fetchContent);

        /// <summary>
        /// Parse, analyze and retrieve content from the supplied URL
        /// </summary>
        /// <param name="url">Required parameter: The URL to process</param>
        /// <param name="fetchContent">Required parameter: If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content</param>
        /// <return>Returns the Models.URLInfoResponse response from the API call</return>
        Task<Models.URLInfoResponse> URLInfoAsync(string url, bool fetchContent);

        /// <summary>
        /// Analyze and extract provider information for an IP address
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <return>Returns the Models.IPProbeResponse response from the API call</return>
        Models.IPProbeResponse IPProbe(string ip);

        /// <summary>
        /// Analyze and extract provider information for an IP address
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <return>Returns the Models.IPProbeResponse response from the API call</return>
        Task<Models.IPProbeResponse> IPProbeAsync(string ip);

        /// <summary>
        /// The IP Blocklist API will detect potentially malicious or dangerous IP addresses
        /// </summary>
        /// <param name="ip">Required parameter: An IPv4 address</param>
        /// <return>Returns the Models.IPBlocklistResponse response from the API call</return>
        Models.IPBlocklistResponse IPBlocklist(string ip);

        /// <summary>
        /// The IP Blocklist API will detect potentially malicious or dangerous IP addresses
        /// </summary>
        /// <param name="ip">Required parameter: An IPv4 address</param>
        /// <return>Returns the Models.IPBlocklistResponse response from the API call</return>
        Task<Models.IPBlocklistResponse> IPBlocklistAsync(string ip);

        /// <summary>
        /// SMTP based email address verification
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailVerifyResponse response from the API call</return>
        Models.EmailVerifyResponse EmailVerify(string email, bool? fixTypos = null);

        /// <summary>
        /// SMTP based email address verification
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailVerifyResponse response from the API call</return>
        Task<Models.EmailVerifyResponse> EmailVerifyAsync(string email, bool? fixTypos = null);

    }
} 