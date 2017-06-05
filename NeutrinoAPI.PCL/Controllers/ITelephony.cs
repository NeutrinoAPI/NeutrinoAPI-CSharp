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
    public partial interface ITelephony
    {
        /// <summary>
        /// Connect to the global mobile cellular network and retrieve the status of a mobile device
        /// </summary>
        /// <param name="number">Required parameter: A phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.HLRLookupResponse response from the API call</return>
        Models.HLRLookupResponse HLRLookup(string number, string countryCode = null);

        /// <summary>
        /// Connect to the global mobile cellular network and retrieve the status of a mobile device
        /// </summary>
        /// <param name="number">Required parameter: A phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.HLRLookupResponse response from the API call</return>
        Task<Models.HLRLookupResponse> HLRLookupAsync(string number, string countryCode = null);

        /// <summary>
        /// Check if a security code from one of the verify APIs is valid
        /// </summary>
        /// <param name="securityCode">Required parameter: The security code to verify</param>
        /// <return>Returns the Models.VerifySecurityCodeResponse response from the API call</return>
        Models.VerifySecurityCodeResponse VerifySecurityCode(int securityCode);

        /// <summary>
        /// Check if a security code from one of the verify APIs is valid
        /// </summary>
        /// <param name="securityCode">Required parameter: The security code to verify</param>
        /// <return>Returns the Models.VerifySecurityCodeResponse response from the API call</return>
        Task<Models.VerifySecurityCodeResponse> VerifySecurityCodeAsync(int securityCode);

        /// <summary>
        /// Send a unique security code to any mobile device via SMS
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (must be between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: ass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported)</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to send the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian</param>
        /// <return>Returns the Models.SMSVerifyResponse response from the API call</return>
        Models.SMSVerifyResponse SMSVerify(
                string number,
                int? codeLength = 5,
                int? securityCode = null,
                string countryCode = null,
                string languageCode = "en");

        /// <summary>
        /// Send a unique security code to any mobile device via SMS
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (must be between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: ass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported)</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to send the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian</param>
        /// <return>Returns the Models.SMSVerifyResponse response from the API call</return>
        Task<Models.SMSVerifyResponse> SMSVerifyAsync(
                string number,
                int? codeLength = 5,
                int? securityCode = null,
                string countryCode = null,
                string languageCode = "en");

        /// <summary>
        /// Make an automated call to any valid phone number and playback an audio message
        /// </summary>
        /// <param name="number">Required parameter: The phone number to call. Must be valid international format</param>
        /// <param name="audioUrl">Required parameter: A URL to a valid audio file. Accepted audio formats are: MP3, WAV, OGG</param>
        /// <return>Returns the Models.PhonePlaybackResponse response from the API call</return>
        Models.PhonePlaybackResponse PhonePlayback(string number, string audioUrl);

        /// <summary>
        /// Make an automated call to any valid phone number and playback an audio message
        /// </summary>
        /// <param name="number">Required parameter: The phone number to call. Must be valid international format</param>
        /// <param name="audioUrl">Required parameter: A URL to a valid audio file. Accepted audio formats are: MP3, WAV, OGG</param>
        /// <return>Returns the Models.PhonePlaybackResponse response from the API call</return>
        Task<Models.PhonePlaybackResponse> PhonePlaybackAsync(string number, string audioUrl);

        /// <summary>
        /// Make an automated call to any valid phone number and playback a unique security code
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send the verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported)</param>
        /// <param name="playbackDelay">Optional parameter: The delay in milliseconds between the playback of each security code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to playback the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian</param>
        /// <return>Returns the Models.PhoneVerifyResponse response from the API call</return>
        Models.PhoneVerifyResponse PhoneVerify(
                string number,
                int? codeLength = 6,
                int? securityCode = null,
                int? playbackDelay = 800,
                string countryCode = null,
                string languageCode = "en");

        /// <summary>
        /// Make an automated call to any valid phone number and playback a unique security code
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send the verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported)</param>
        /// <param name="playbackDelay">Optional parameter: The delay in milliseconds between the playback of each security code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to playback the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian</param>
        /// <return>Returns the Models.PhoneVerifyResponse response from the API call</return>
        Task<Models.PhoneVerifyResponse> PhoneVerifyAsync(
                string number,
                int? codeLength = 6,
                int? securityCode = null,
                int? playbackDelay = 800,
                string countryCode = null,
                string languageCode = "en");

    }
} 