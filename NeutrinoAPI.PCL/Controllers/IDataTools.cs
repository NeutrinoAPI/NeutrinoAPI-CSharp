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
    public partial interface IDataTools
    {
        /// <summary>
        /// Parse, validate and clean an email address. See: https://www.neutrinoapi.com/api/email-validate/
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        Models.EmailValidateResponse EmailValidate(string email, bool? fixTypos = false);

        /// <summary>
        /// Parse, validate and clean an email address. See: https://www.neutrinoapi.com/api/email-validate/
        /// </summary>
        /// <param name="email">Required parameter: An email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        Task<Models.EmailValidateResponse> EmailValidateAsync(string email, bool? fixTypos = false);

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text. See: https://www.neutrinoapi.com/api/bad-word-filter/
        /// </summary>
        /// <param name="content">Required parameter: The content to scan. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        Models.BadWordFilterResponse BadWordFilter(string content, string censorCharacter = null);

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text. See: https://www.neutrinoapi.com/api/bad-word-filter/
        /// </summary>
        /// <param name="content">Required parameter: The content to scan. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        Task<Models.BadWordFilterResponse> BadWordFilterAsync(string content, string censorCharacter = null);

        /// <summary>
        /// A powerful unit conversion tool. See: https://www.neutrinoapi.com/api/convert/
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from (e.g. 10.95)</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from (e.g. USD)</param>
        /// <param name="toType">Required parameter: The type to convert to (e.g. EUR)</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        Models.ConvertResponse Convert(string fromValue, string fromType, string toType);

        /// <summary>
        /// A powerful unit conversion tool. See: https://www.neutrinoapi.com/api/convert/
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from (e.g. 10.95)</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from (e.g. USD)</param>
        /// <param name="toType">Required parameter: The type to convert to (e.g. EUR)</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        Task<Models.ConvertResponse> ConvertAsync(string fromValue, string fromType, string toType);

        /// <summary>
        /// Parse, validate and get location information about a phone number. See: https://www.neutrinoapi.com/api/phone-validate/
        /// </summary>
        /// <param name="number">Required parameter: A phone number. This can be in international format (E.164) or local format. If passing local format you should use the 'country-code' or 'ip' options as well</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="ip">Optional parameter: Pass in a users IP address and we will assume numbers are based in the country of the IP address</param>
        /// <return>Returns the Models.PhoneValidateResponse response from the API call</return>
        Models.PhoneValidateResponse PhoneValidate(string number, string countryCode = null, string ip = null);

        /// <summary>
        /// Parse, validate and get location information about a phone number. See: https://www.neutrinoapi.com/api/phone-validate/
        /// </summary>
        /// <param name="number">Required parameter: A phone number. This can be in international format (E.164) or local format. If passing local format you should use the 'country-code' or 'ip' options as well</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country.<br/>If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="ip">Optional parameter: Pass in a users IP address and we will assume numbers are based in the country of the IP address</param>
        /// <return>Returns the Models.PhoneValidateResponse response from the API call</return>
        Task<Models.PhoneValidateResponse> PhoneValidateAsync(string number, string countryCode = null, string ip = null);

        /// <summary>
        /// Parse, validate and get detailed user-agent information from a user agent string. See: https://www.neutrinoapi.com/api/user-agent-info/
        /// </summary>
        /// <param name="userAgent">Required parameter: A user agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        Models.UserAgentInfoResponse UserAgentInfo(string userAgent);

        /// <summary>
        /// Parse, validate and get detailed user-agent information from a user agent string. See: https://www.neutrinoapi.com/api/user-agent-info/
        /// </summary>
        /// <param name="userAgent">Required parameter: A user agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        Task<Models.UserAgentInfoResponse> UserAgentInfoAsync(string userAgent);

    }
} 