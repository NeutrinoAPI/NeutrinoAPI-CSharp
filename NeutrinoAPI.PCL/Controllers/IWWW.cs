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
    public partial interface IWWW
    {
        /// <summary>
        /// Browser bot can extract content, interact with keyboard and mouse events, and execute JavaScript on a website. See: https://www.neutrinoapi.com/api/browser-bot/
        /// </summary>
        /// <param name="url">Required parameter: The URL to load</param>
        /// <param name="timeout">Optional parameter: Timeout in seconds. Give up if still trying to load the page after this number of seconds</param>
        /// <param name="delay">Optional parameter: Delay in seconds to wait before executing any selectors or JavaScript</param>
        /// <param name="selector">Optional parameter: Extract content from the page DOM using this selector. Commonly known as a CSS selector, you can find a good reference <a href="https://www.w3schools.com/cssref/css_selectors.asp" target="_blank">here</a></param>
        /// <param name="exec">Optional parameter: Execute JavaScript on the page. Each array element should contain a valid JavaScript statement in string form. If a statement returns any kind of value it will be returned in the 'exec-results' response.<br/><br/>For your convenience you can also use the following special shortcut functions:<br/><div style='padding-left:32px; font-family:inherit; font-size:inherit;'>sleep(seconds); Just wait/sleep for the specified number of seconds.<br/>click('selector'); Click on the first element matching the given selector.<br/>focus('selector'); Focus on the first element matching the given selector.<br/>keys('characters'); Send the specified keyboard characters. Use click() or focus() first to send keys to a specific element.<br/>enter(); Send the Enter key.<br/>tab(); Send the Tab key.<br/></div><br/>Example:<br/><div style='padding-left:32px; font-family:inherit; font-size:inherit;'>[ "click('#button-id')", "sleep(1)", "click('.field-class')", "keys('1234')", "enter()" ]</div></param>
        /// <param name="userAgent">Optional parameter: Override the browsers default user-agent string with this one</param>
        /// <param name="ignoreCertificateErrors">Optional parameter: Ignore any TLS/SSL certificate errors and load the page anyway</param>
        /// <return>Returns the Models.BrowserBotResponse response from the API call</return>
        Models.BrowserBotResponse BrowserBot(
                string url,
                int? timeout = 30,
                int? delay = 2,
                string selector = null,
                List<string> exec,
                string userAgent = null,
                bool? ignoreCertificateErrors = false);

        /// <summary>
        /// Browser bot can extract content, interact with keyboard and mouse events, and execute JavaScript on a website. See: https://www.neutrinoapi.com/api/browser-bot/
        /// </summary>
        /// <param name="url">Required parameter: The URL to load</param>
        /// <param name="timeout">Optional parameter: Timeout in seconds. Give up if still trying to load the page after this number of seconds</param>
        /// <param name="delay">Optional parameter: Delay in seconds to wait before executing any selectors or JavaScript</param>
        /// <param name="selector">Optional parameter: Extract content from the page DOM using this selector. Commonly known as a CSS selector, you can find a good reference <a href="https://www.w3schools.com/cssref/css_selectors.asp" target="_blank">here</a></param>
        /// <param name="exec">Optional parameter: Execute JavaScript on the page. Each array element should contain a valid JavaScript statement in string form. If a statement returns any kind of value it will be returned in the 'exec-results' response.<br/><br/>For your convenience you can also use the following special shortcut functions:<br/><div style='padding-left:32px; font-family:inherit; font-size:inherit;'>sleep(seconds); Just wait/sleep for the specified number of seconds.<br/>click('selector'); Click on the first element matching the given selector.<br/>focus('selector'); Focus on the first element matching the given selector.<br/>keys('characters'); Send the specified keyboard characters. Use click() or focus() first to send keys to a specific element.<br/>enter(); Send the Enter key.<br/>tab(); Send the Tab key.<br/></div><br/>Example:<br/><div style='padding-left:32px; font-family:inherit; font-size:inherit;'>[ "click('#button-id')", "sleep(1)", "click('.field-class')", "keys('1234')", "enter()" ]</div></param>
        /// <param name="userAgent">Optional parameter: Override the browsers default user-agent string with this one</param>
        /// <param name="ignoreCertificateErrors">Optional parameter: Ignore any TLS/SSL certificate errors and load the page anyway</param>
        /// <return>Returns the Models.BrowserBotResponse response from the API call</return>
        Task<Models.BrowserBotResponse> BrowserBotAsync(
                string url,
                int? timeout = 30,
                int? delay = 2,
                string selector = null,
                List<string> exec,
                string userAgent = null,
                bool? ignoreCertificateErrors = false);

        /// <summary>
        /// Clean and sanitize untrusted HTML. See: https://www.neutrinoapi.com/api/html-clean/
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are:<br/><b>plain-text</b>: reduce the content to plain text only (no HTML tags at all)<br/><br/><b>simple-text</b>: allow only very basic text formatting tags like b, em, i, strong, u<br/><br/><b>basic-html</b>: allow advanced text formatting and hyper links<br/><br/><b>basic-html-with-images</b>: same as basic html but also allows image tags<br/><br/><b>advanced-html</b>: same as basic html with images but also allows many more common HTML tags like table, ul, dl, pre<br/></param>
        /// <return>Returns the Stream response from the API call</return>
        Stream HTMLClean(string content, string outputType);

        /// <summary>
        /// Clean and sanitize untrusted HTML. See: https://www.neutrinoapi.com/api/html-clean/
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="outputType">Required parameter: The level of sanitization, possible values are:<br/><b>plain-text</b>: reduce the content to plain text only (no HTML tags at all)<br/><br/><b>simple-text</b>: allow only very basic text formatting tags like b, em, i, strong, u<br/><br/><b>basic-html</b>: allow advanced text formatting and hyper links<br/><br/><b>basic-html-with-images</b>: same as basic html but also allows image tags<br/><br/><b>advanced-html</b>: same as basic html with images but also allows many more common HTML tags like table, ul, dl, pre<br/></param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> HTMLCleanAsync(string content, string outputType);

        /// <summary>
        /// Parse, analyze and retrieve content from the supplied URL. See: https://www.neutrinoapi.com/api/url-info/
        /// </summary>
        /// <param name="url">Required parameter: The URL to probe</param>
        /// <param name="fetchContent">Optional parameter: If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content (e.g. with the HTML Extract or HTML Clean APIs)</param>
        /// <return>Returns the Models.URLInfoResponse response from the API call</return>
        Models.URLInfoResponse URLInfo(string url, bool? fetchContent = false);

        /// <summary>
        /// Parse, analyze and retrieve content from the supplied URL. See: https://www.neutrinoapi.com/api/url-info/
        /// </summary>
        /// <param name="url">Required parameter: The URL to probe</param>
        /// <param name="fetchContent">Optional parameter: If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content (e.g. with the HTML Extract or HTML Clean APIs)</param>
        /// <return>Returns the Models.URLInfoResponse response from the API call</return>
        Task<Models.URLInfoResponse> URLInfoAsync(string url, bool? fetchContent = false);

    }
} 