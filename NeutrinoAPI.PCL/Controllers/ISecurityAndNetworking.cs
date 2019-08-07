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
    public partial interface ISecurityAndNetworking
    {
        /// <summary>
        /// Analyze and extract provider information for an IP address. See: https://www.neutrinoapi.com/api/ip-probe/
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <return>Returns the Models.IPProbeResponse response from the API call</return>
        Models.IPProbeResponse IPProbe(string ip);

        /// <summary>
        /// Analyze and extract provider information for an IP address. See: https://www.neutrinoapi.com/api/ip-probe/
        /// </summary>
        /// <param name="ip">Required parameter: IPv4 or IPv6 address</param>
        /// <return>Returns the Models.IPProbeResponse response from the API call</return>
        Task<Models.IPProbeResponse> IPProbeAsync(string ip);

        /// <summary>
        /// SMTP based email address verification. See: https://www.neutrinoapi.com/api/email-verify/
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailVerifyResponse response from the API call</return>
        Models.EmailVerifyResponse EmailVerify(string email, bool? fixTypos = false);

        /// <summary>
        /// SMTP based email address verification. See: https://www.neutrinoapi.com/api/email-verify/
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailVerifyResponse response from the API call</return>
        Task<Models.EmailVerifyResponse> EmailVerifyAsync(string email, bool? fixTypos = false);

        /// <summary>
        /// The IP Blocklist API will detect potentially malicious or dangerous IP addresses. See: https://www.neutrinoapi.com/api/ip-blocklist/
        /// </summary>
        /// <param name="ip">Required parameter: An IPv4 or IPv6 address</param>
        /// <return>Returns the Models.IPBlocklistResponse response from the API call</return>
        Models.IPBlocklistResponse IPBlocklist(string ip);

        /// <summary>
        /// The IP Blocklist API will detect potentially malicious or dangerous IP addresses. See: https://www.neutrinoapi.com/api/ip-blocklist/
        /// </summary>
        /// <param name="ip">Required parameter: An IPv4 or IPv6 address</param>
        /// <return>Returns the Models.IPBlocklistResponse response from the API call</return>
        Task<Models.IPBlocklistResponse> IPBlocklistAsync(string ip);

        /// <summary>
        /// Check the reputation of an IP address, domain name, FQDN or URL against a comprehensive list of blacklists and blocklists. See: https://www.neutrinoapi.com/api/host-reputation/
        /// </summary>
        /// <param name="host">Required parameter: An IP address, domain name, FQDN or URL. If you supply a domain/URL it will be checked against the URI DNSBL lists</param>
        /// <param name="listRating">Optional parameter: Only check lists with this rating or better</param>
        /// <return>Returns the Models.HostReputationResponse response from the API call</return>
        Models.HostReputationResponse HostReputation(string host, int? listRating = 3);

        /// <summary>
        /// Check the reputation of an IP address, domain name, FQDN or URL against a comprehensive list of blacklists and blocklists. See: https://www.neutrinoapi.com/api/host-reputation/
        /// </summary>
        /// <param name="host">Required parameter: An IP address, domain name, FQDN or URL. If you supply a domain/URL it will be checked against the URI DNSBL lists</param>
        /// <param name="listRating">Optional parameter: Only check lists with this rating or better</param>
        /// <return>Returns the Models.HostReputationResponse response from the API call</return>
        Task<Models.HostReputationResponse> HostReputationAsync(string host, int? listRating = 3);

    }
} 