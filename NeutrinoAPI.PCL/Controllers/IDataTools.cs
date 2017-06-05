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
    public partial interface IDataTools
    {
        /// <summary>
        /// A powerful unit and currency conversion tool
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from</param>
        /// <param name="toType">Required parameter: The type to convert to</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        Models.ConvertResponse Convert(string fromValue, string fromType, string toType);

        /// <summary>
        /// A powerful unit and currency conversion tool
        /// </summary>
        /// <param name="fromValue">Required parameter: The value to convert from</param>
        /// <param name="fromType">Required parameter: The type of the value to convert from</param>
        /// <param name="toType">Required parameter: The type to convert to</param>
        /// <return>Returns the Models.ConvertResponse response from the API call</return>
        Task<Models.ConvertResponse> ConvertAsync(string fromValue, string fromType, string toType);

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text
        /// </summary>
        /// <param name="content">Required parameter: The text content to check. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        Models.BadWordFilterResponse BadWordFilter(string content, string censorCharacter = null);

        /// <summary>
        /// Detect bad words, swear words and profanity in a given text
        /// </summary>
        /// <param name="content">Required parameter: The text content to check. This can be either a URL to load content from or an actual content string</param>
        /// <param name="censorCharacter">Optional parameter: The character to use to censor out the bad words found</param>
        /// <return>Returns the Models.BadWordFilterResponse response from the API call</return>
        Task<Models.BadWordFilterResponse> BadWordFilterAsync(string content, string censorCharacter = null);

        /// <summary>
        /// Parse, validate and clean an email address
        /// </summary>
        /// <param name="email">Required parameter: The email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        Models.EmailValidateResponse EmailValidate(string email, bool? fixTypos = false);

        /// <summary>
        /// Parse, validate and clean an email address
        /// </summary>
        /// <param name="email">Required parameter: The email address</param>
        /// <param name="fixTypos">Optional parameter: Automatically attempt to fix typos in the address</param>
        /// <return>Returns the Models.EmailValidateResponse response from the API call</return>
        Task<Models.EmailValidateResponse> EmailValidateAsync(string email, bool? fixTypos = false);

        /// <summary>
        /// Clean and sanitize untrusted HTML
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are: plain-text, simple-text, basic-html, basic-html-with-images, advanced-html</param>
        /// <return>Returns the Stream response from the API call</return>
        Stream HTMLClean(string content, string outputType);

        /// <summary>
        /// Clean and sanitize untrusted HTML
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are: plain-text, simple-text, basic-html, basic-html-with-images, advanced-html</param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> HTMLCleanAsync(string content, string outputType);

        /// <summary>
        /// Code highlight will take raw source code and convert into nicely formatted HTML with syntax and keyword highlighting
        /// </summary>
        /// <param name="content">Required parameter: The source content. This can be either a URL to load from or an actual content string</param>
        /// <param name="type">Required parameter: The code type. See the API docs for all supported types</param>
        /// <param name="addKeywordLinks">Optional parameter: Add links on source code keywords to the relevant language documentation</param>
        /// <return>Returns the Stream response from the API call</return>
        Stream CodeHighlight(string content, string type, bool? addKeywordLinks = false);

        /// <summary>
        /// Code highlight will take raw source code and convert into nicely formatted HTML with syntax and keyword highlighting
        /// </summary>
        /// <param name="content">Required parameter: The source content. This can be either a URL to load from or an actual content string</param>
        /// <param name="type">Required parameter: The code type. See the API docs for all supported types</param>
        /// <param name="addKeywordLinks">Optional parameter: Add links on source code keywords to the relevant language documentation</param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> CodeHighlightAsync(string content, string type, bool? addKeywordLinks = false);

        /// <summary>
        /// Parse, validate and get detailed user-agent information from a user agent string
        /// </summary>
        /// <param name="userAgent">Required parameter: A user-agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        Models.UserAgentInfoResponse UserAgentInfo(string userAgent);

        /// <summary>
        /// Parse, validate and get detailed user-agent information from a user agent string
        /// </summary>
        /// <param name="userAgent">Required parameter: A user-agent string</param>
        /// <return>Returns the Models.UserAgentInfoResponse response from the API call</return>
        Task<Models.UserAgentInfoResponse> UserAgentInfoAsync(string userAgent);

        /// <summary>
        /// Extract specific HTML tag contents or attributes from complex HTML or XHTML content
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="tag">Required parameter: The HTML tag(s) to extract data from. This can just be a simple tag name like 'img' OR a CSS/jQuery style selector</param>
        /// <param name="attribute">Optional parameter: If set, then extract data from the specified tag attribute. If not set, then data will be extracted from the tags inner content</param>
        /// <param name="baseUrl">Optional parameter: The base URL to replace into realive links</param>
        /// <return>Returns the Models.HTMLExtractResponse response from the API call</return>
        Models.HTMLExtractResponse HTMLExtract(
                string content,
                string tag,
                string attribute = null,
                string baseUrl = null);

        /// <summary>
        /// Extract specific HTML tag contents or attributes from complex HTML or XHTML content
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="tag">Required parameter: The HTML tag(s) to extract data from. This can just be a simple tag name like 'img' OR a CSS/jQuery style selector</param>
        /// <param name="attribute">Optional parameter: If set, then extract data from the specified tag attribute. If not set, then data will be extracted from the tags inner content</param>
        /// <param name="baseUrl">Optional parameter: The base URL to replace into realive links</param>
        /// <return>Returns the Models.HTMLExtractResponse response from the API call</return>
        Task<Models.HTMLExtractResponse> HTMLExtractAsync(
                string content,
                string tag,
                string attribute = null,
                string baseUrl = null);

        /// <summary>
        /// Parse, validate and get location information about a phone number
        /// </summary>
        /// <param name="number">Required parameter: The phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="ip">Optional parameter: Pass in a users IP address and we will assume numbers are based in the country of the IP address</param>
        /// <return>Returns the Models.PhoneValidateResponse response from the API call</return>
        Models.PhoneValidateResponse PhoneValidate(string number, string countryCode = null, string ip = null);

        /// <summary>
        /// Parse, validate and get location information about a phone number
        /// </summary>
        /// <param name="number">Required parameter: The phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="ip">Optional parameter: Pass in a users IP address and we will assume numbers are based in the country of the IP address</param>
        /// <return>Returns the Models.PhoneValidateResponse response from the API call</return>
        Task<Models.PhoneValidateResponse> PhoneValidateAsync(string number, string countryCode = null, string ip = null);

    }
} 