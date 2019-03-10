/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NeutrinoAPI;
using NeutrinoAPI.Utilities;


namespace NeutrinoAPI.Models
{
    public class BrowserBotResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string url;
        private string content;
        private string mimeType;
        private string title;
        private bool isError;
        private bool isTimeout;
        private string errorMessage;
        private int httpStatusCode;
        private string httpStatusMessage;
        private bool isHttpOk;
        private bool isHttpRedirect;
        private string httpRedirectUrl;
        private string serverIp;
        private int loadTime;
        private Dictionary<string, string> responseHeaders;
        private bool isSecure;
        private Dictionary<string, string> securityDetails;
        private List<string> elements;
        private List<string> execResults;

        /// <summary>
        /// The page URL
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// The complete raw, decompressed and decoded page content. Usually will be either HTML, JSON or XML
        /// </summary>
        [JsonProperty("content")]
        public string Content 
        { 
            get 
            {
                return this.content; 
            } 
            set 
            {
                this.content = value;
                onPropertyChanged("Content");
            }
        }

        /// <summary>
        /// The document MIME type
        /// </summary>
        [JsonProperty("mimeType")]
        public string MimeType 
        { 
            get 
            {
                return this.mimeType; 
            } 
            set 
            {
                this.mimeType = value;
                onPropertyChanged("MimeType");
            }
        }

        /// <summary>
        /// The document title
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        { 
            get 
            {
                return this.title; 
            } 
            set 
            {
                this.title = value;
                onPropertyChanged("Title");
            }
        }

        /// <summary>
        /// True if an error has occurred loading the page. Check the 'error-message' field for details
        /// </summary>
        [JsonProperty("isError")]
        public bool IsError 
        { 
            get 
            {
                return this.isError; 
            } 
            set 
            {
                this.isError = value;
                onPropertyChanged("IsError");
            }
        }

        /// <summary>
        /// True if a timeout occurred while loading the page. You can set the timeout with the request parameter 'timeout'
        /// </summary>
        [JsonProperty("isTimeout")]
        public bool IsTimeout 
        { 
            get 
            {
                return this.isTimeout; 
            } 
            set 
            {
                this.isTimeout = value;
                onPropertyChanged("IsTimeout");
            }
        }

        /// <summary>
        /// Contains the error message if an error has occurred ('is-error' will be true)
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage 
        { 
            get 
            {
                return this.errorMessage; 
            } 
            set 
            {
                this.errorMessage = value;
                onPropertyChanged("ErrorMessage");
            }
        }

        /// <summary>
        /// The HTTP status code the URL returned
        /// </summary>
        [JsonProperty("httpStatusCode")]
        public int HttpStatusCode 
        { 
            get 
            {
                return this.httpStatusCode; 
            } 
            set 
            {
                this.httpStatusCode = value;
                onPropertyChanged("HttpStatusCode");
            }
        }

        /// <summary>
        /// The HTTP status message the URL returned
        /// </summary>
        [JsonProperty("httpStatusMessage")]
        public string HttpStatusMessage 
        { 
            get 
            {
                return this.httpStatusMessage; 
            } 
            set 
            {
                this.httpStatusMessage = value;
                onPropertyChanged("HttpStatusMessage");
            }
        }

        /// <summary>
        /// True if the HTTP status is OK (200)
        /// </summary>
        [JsonProperty("isHttpOk")]
        public bool IsHttpOk 
        { 
            get 
            {
                return this.isHttpOk; 
            } 
            set 
            {
                this.isHttpOk = value;
                onPropertyChanged("IsHttpOk");
            }
        }

        /// <summary>
        /// True if the URL responded with an HTTP redirect
        /// </summary>
        [JsonProperty("isHttpRedirect")]
        public bool IsHttpRedirect 
        { 
            get 
            {
                return this.isHttpRedirect; 
            } 
            set 
            {
                this.isHttpRedirect = value;
                onPropertyChanged("IsHttpRedirect");
            }
        }

        /// <summary>
        /// The redirected URL if the URL responded with an HTTP redirect
        /// </summary>
        [JsonProperty("httpRedirectUrl")]
        public string HttpRedirectUrl 
        { 
            get 
            {
                return this.httpRedirectUrl; 
            } 
            set 
            {
                this.httpRedirectUrl = value;
                onPropertyChanged("HttpRedirectUrl");
            }
        }

        /// <summary>
        /// The HTTP servers IP address
        /// </summary>
        [JsonProperty("serverIp")]
        public string ServerIp 
        { 
            get 
            {
                return this.serverIp; 
            } 
            set 
            {
                this.serverIp = value;
                onPropertyChanged("ServerIp");
            }
        }

        /// <summary>
        /// The number of seconds taken to load the page (from initial request until DOM ready)
        /// </summary>
        [JsonProperty("loadTime")]
        public int LoadTime 
        { 
            get 
            {
                return this.loadTime; 
            } 
            set 
            {
                this.loadTime = value;
                onPropertyChanged("LoadTime");
            }
        }

        /// <summary>
        /// Map containing all the HTTP response headers the URL responded with
        /// </summary>
        [JsonProperty("responseHeaders")]
        public Dictionary<string, string> ResponseHeaders 
        { 
            get 
            {
                return this.responseHeaders; 
            } 
            set 
            {
                this.responseHeaders = value;
                onPropertyChanged("ResponseHeaders");
            }
        }

        /// <summary>
        /// True if the page is secured using TLS/SSL
        /// </summary>
        [JsonProperty("isSecure")]
        public bool IsSecure 
        { 
            get 
            {
                return this.isSecure; 
            } 
            set 
            {
                this.isSecure = value;
                onPropertyChanged("IsSecure");
            }
        }

        /// <summary>
        /// Map containing details of the TLS/SSL setup
        /// </summary>
        [JsonProperty("securityDetails")]
        public Dictionary<string, string> SecurityDetails 
        { 
            get 
            {
                return this.securityDetails; 
            } 
            set 
            {
                this.securityDetails = value;
                onPropertyChanged("SecurityDetails");
            }
        }

        /// <summary>
        /// Array containing all the elements matching the supplied selector.<br/>Each element object will contain the text content, HTML content and all current element attributes
        /// </summary>
        [JsonProperty("elements")]
        public List<string> Elements 
        { 
            get 
            {
                return this.elements; 
            } 
            set 
            {
                this.elements = value;
                onPropertyChanged("Elements");
            }
        }

        /// <summary>
        /// If you executed any JavaScript this array holds the results as objects
        /// </summary>
        [JsonProperty("execResults")]
        public List<string> ExecResults 
        { 
            get 
            {
                return this.execResults; 
            } 
            set 
            {
                this.execResults = value;
                onPropertyChanged("ExecResults");
            }
        }
    }
} 