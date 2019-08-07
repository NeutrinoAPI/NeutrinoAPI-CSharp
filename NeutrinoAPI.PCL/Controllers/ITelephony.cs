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
    public partial interface ITelephony
    {
        /// <summary>
        /// Check if a security code from one of the verify APIs is valid. See: https://www.neutrinoapi.com/api/verify-security-code/
        /// </summary>
        /// <param name="securityCode">Required parameter: The security code to verify</param>
        /// <return>Returns the Models.VerifySecurityCodeResponse response from the API call</return>
        Models.VerifySecurityCodeResponse VerifySecurityCode(string securityCode);

        /// <summary>
        /// Check if a security code from one of the verify APIs is valid. See: https://www.neutrinoapi.com/api/verify-security-code/
        /// </summary>
        /// <param name="securityCode">Required parameter: The security code to verify</param>
        /// <return>Returns the Models.VerifySecurityCodeResponse response from the API call</return>
        Task<Models.VerifySecurityCodeResponse> VerifySecurityCodeAsync(string securityCode);

        /// <summary>
        /// Connect to the global mobile cellular network and retrieve the status of a mobile device. See: https://www.neutrinoapi.com/api/hlr-lookup/
        /// </summary>
        /// <param name="number">Required parameter: A phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.HLRLookupResponse response from the API call</return>
        Models.HLRLookupResponse HLRLookup(string number, string countryCode = null);

        /// <summary>
        /// Connect to the global mobile cellular network and retrieve the status of a mobile device. See: https://www.neutrinoapi.com/api/hlr-lookup/
        /// </summary>
        /// <param name="number">Required parameter: A phone number</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.HLRLookupResponse response from the API call</return>
        Task<Models.HLRLookupResponse> HLRLookupAsync(string number, string countryCode = null);

        /// <summary>
        /// Make an automated call to any valid phone number and playback an audio message. See: https://www.neutrinoapi.com/api/phone-playback/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to call. Must be in valid international format</param>
        /// <param name="audioUrl">Required parameter: A URL to a valid audio file. Accepted audio formats are: <ul> <li>MP3</li> <li>WAV</li> <li>OGG</li> </ul>You can use the following MP3 URL for testing: https://www.neutrinoapi.com/test-files/test1.mp3</param>
        /// <return>Returns the Models.PhonePlaybackResponse response from the API call</return>
        Models.PhonePlaybackResponse PhonePlayback(string number, string audioUrl);

        /// <summary>
        /// Make an automated call to any valid phone number and playback an audio message. See: https://www.neutrinoapi.com/api/phone-playback/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to call. Must be in valid international format</param>
        /// <param name="audioUrl">Required parameter: A URL to a valid audio file. Accepted audio formats are: <ul> <li>MP3</li> <li>WAV</li> <li>OGG</li> </ul>You can use the following MP3 URL for testing: https://www.neutrinoapi.com/test-files/test1.mp3</param>
        /// <return>Returns the Models.PhonePlaybackResponse response from the API call</return>
        Task<Models.PhonePlaybackResponse> PhonePlaybackAsync(string number, string audioUrl);

        /// <summary>
        /// Send a unique security code to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (must be between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to send the verification code in, available languages are: <ul> <li>de - German</li> <li>en - English</li> <li>es - Spanish</li> <li>fr - French</li> <li>it - Italian</li> <li>pt - Portuguese</li> <li>ru - Russian</li> </ul></param>
        /// <return>Returns the Models.SMSVerifyResponse response from the API call</return>
        Models.SMSVerifyResponse SMSVerify(
                string number,
                int? codeLength = 5,
                int? securityCode = null,
                string countryCode = null,
                string languageCode = "en");

        /// <summary>
        /// Send a unique security code to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (must be between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to send the verification code in, available languages are: <ul> <li>de - German</li> <li>en - English</li> <li>es - Spanish</li> <li>fr - French</li> <li>it - Italian</li> <li>pt - Portuguese</li> <li>ru - Russian</li> </ul></param>
        /// <return>Returns the Models.SMSVerifyResponse response from the API call</return>
        Task<Models.SMSVerifyResponse> SMSVerifyAsync(
                string number,
                int? codeLength = 5,
                int? securityCode = null,
                string countryCode = null,
                string languageCode = "en");

        /// <summary>
        /// Send a free-form message to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-message/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a message to</param>
        /// <param name="message">Required parameter: The SMS message to send. Messages are truncated to a maximum of 150 characters for ASCII content OR 70 characters for UTF content</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.SMSMessageResponse response from the API call</return>
        Models.SMSMessageResponse SMSMessage(string number, string message, string countryCode = null);

        /// <summary>
        /// Send a free-form message to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-message/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send a message to</param>
        /// <param name="message">Required parameter: The SMS message to send. Messages are truncated to a maximum of 150 characters for ASCII content OR 70 characters for UTF content</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <return>Returns the Models.SMSMessageResponse response from the API call</return>
        Task<Models.SMSMessageResponse> SMSMessageAsync(string number, string message, string countryCode = null);

        /// <summary>
        /// Make an automated call to any valid phone number and playback a unique security code. See: https://www.neutrinoapi.com/api/phone-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send the verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="playbackDelay">Optional parameter: The delay in milliseconds between the playback of each security code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to playback the verification code in, available languages are: <ul> <li>de - German</li> <li>en - English</li> <li>es - Spanish</li> <li>fr - French</li> <li>it - Italian</li> <li>pt - Portuguese</li> <li>ru - Russian</li> </ul></param>
        /// <return>Returns the Models.PhoneVerifyResponse response from the API call</return>
        Models.PhoneVerifyResponse PhoneVerify(
                string number,
                int? codeLength = 6,
                int? securityCode = null,
                int? playbackDelay = 800,
                string countryCode = null,
                string languageCode = "en");

        /// <summary>
        /// Make an automated call to any valid phone number and playback a unique security code. See: https://www.neutrinoapi.com/api/phone-verify/
        /// </summary>
        /// <param name="number">Required parameter: The phone number to send the verification code to</param>
        /// <param name="codeLength">Optional parameter: The number of digits to use in the security code (between 4 and 12)</param>
        /// <param name="securityCode">Optional parameter: Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code</param>
        /// <param name="playbackDelay">Optional parameter: The delay in milliseconds between the playback of each security code</param>
        /// <param name="countryCode">Optional parameter: ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign)</param>
        /// <param name="languageCode">Optional parameter: The language to playback the verification code in, available languages are: <ul> <li>de - German</li> <li>en - English</li> <li>es - Spanish</li> <li>fr - French</li> <li>it - Italian</li> <li>pt - Portuguese</li> <li>ru - Russian</li> </ul></param>
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