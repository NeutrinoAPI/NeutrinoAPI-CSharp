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
    public class URLInfoResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int httpStatusMessage;
        private string serverRegion;
        private Dictionary<string, string> query;
        private string serverName;
        private int urlPort;
        private string serverCountry;
        private bool real;
        private string serverCity;
        private string urlPath;
        private string url;
        private bool valid;
        private string serverHostname;
        private int loadTime;
        private bool httpOk;
        private int contentSize;
        private int httpStatus;
        private string serverCountryCode;
        private string contentEncoding;
        private string serverIp;
        private string urlProtocol;
        private string contentType;
        private bool httpRedirect;
        private string content;

        /// <summary>
        /// The HTTP status message assoicated with the status code
        /// </summary>
        [JsonProperty("httpStatusMessage")]
        public int HttpStatusMessage 
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
        /// The servers IP geo-location: full region name (if detectable)
        /// </summary>
        [JsonProperty("serverRegion")]
        public string ServerRegion 
        { 
            get 
            {
                return this.serverRegion; 
            } 
            set 
            {
                this.serverRegion = value;
                onPropertyChanged("ServerRegion");
            }
        }

        /// <summary>
        /// A key-value map of the URL query paramaters
        /// </summary>
        [JsonProperty("query")]
        public Dictionary<string, string> Query 
        { 
            get 
            {
                return this.query; 
            } 
            set 
            {
                this.query = value;
                onPropertyChanged("Query");
            }
        }

        /// <summary>
        /// The name of the server software hosting this URL
        /// </summary>
        [JsonProperty("serverName")]
        public string ServerName 
        { 
            get 
            {
                return this.serverName; 
            } 
            set 
            {
                this.serverName = value;
                onPropertyChanged("ServerName");
            }
        }

        /// <summary>
        /// The URL port
        /// </summary>
        [JsonProperty("urlPort")]
        public int UrlPort 
        { 
            get 
            {
                return this.urlPort; 
            } 
            set 
            {
                this.urlPort = value;
                onPropertyChanged("UrlPort");
            }
        }

        /// <summary>
        /// The servers IP geo-location: full country name
        /// </summary>
        [JsonProperty("serverCountry")]
        public string ServerCountry 
        { 
            get 
            {
                return this.serverCountry; 
            } 
            set 
            {
                this.serverCountry = value;
                onPropertyChanged("ServerCountry");
            }
        }

        /// <summary>
        /// Is this URL actually serving real content
        /// </summary>
        [JsonProperty("real")]
        public bool Real 
        { 
            get 
            {
                return this.real; 
            } 
            set 
            {
                this.real = value;
                onPropertyChanged("Real");
            }
        }

        /// <summary>
        /// The servers IP geo-location: full city name (if detectable)
        /// </summary>
        [JsonProperty("serverCity")]
        public string ServerCity 
        { 
            get 
            {
                return this.serverCity; 
            } 
            set 
            {
                this.serverCity = value;
                onPropertyChanged("ServerCity");
            }
        }

        /// <summary>
        /// The URL path
        /// </summary>
        [JsonProperty("urlPath")]
        public string UrlPath 
        { 
            get 
            {
                return this.urlPath; 
            } 
            set 
            {
                this.urlPath = value;
                onPropertyChanged("UrlPath");
            }
        }

        /// <summary>
        /// The fully qualified URL. This may be different to the URL requested if http-redirect is true
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
        /// Is this a valid well-formed URL
        /// </summary>
        [JsonProperty("valid")]
        public bool Valid 
        { 
            get 
            {
                return this.valid; 
            } 
            set 
            {
                this.valid = value;
                onPropertyChanged("Valid");
            }
        }

        /// <summary>
        /// The servers hostname (PTR record)
        /// </summary>
        [JsonProperty("serverHostname")]
        public string ServerHostname 
        { 
            get 
            {
                return this.serverHostname; 
            } 
            set 
            {
                this.serverHostname = value;
                onPropertyChanged("ServerHostname");
            }
        }

        /// <summary>
        /// The time taken to load the URL content in seconds
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
        /// True if this URL responded with an HTTP OK (200) status
        /// </summary>
        [JsonProperty("httpOk")]
        public bool HttpOk 
        { 
            get 
            {
                return this.httpOk; 
            } 
            set 
            {
                this.httpOk = value;
                onPropertyChanged("HttpOk");
            }
        }

        /// <summary>
        /// The size of the URL content in bytes
        /// </summary>
        [JsonProperty("contentSize")]
        public int ContentSize 
        { 
            get 
            {
                return this.contentSize; 
            } 
            set 
            {
                this.contentSize = value;
                onPropertyChanged("ContentSize");
            }
        }

        /// <summary>
        /// The HTTP status code this URL responded with. An HTTP status of 0 indicates a network level issue
        /// </summary>
        [JsonProperty("httpStatus")]
        public int HttpStatus 
        { 
            get 
            {
                return this.httpStatus; 
            } 
            set 
            {
                this.httpStatus = value;
                onPropertyChanged("HttpStatus");
            }
        }

        /// <summary>
        /// The servers IP geo-location: ISO 2-letter country code
        /// </summary>
        [JsonProperty("serverCountryCode")]
        public string ServerCountryCode 
        { 
            get 
            {
                return this.serverCountryCode; 
            } 
            set 
            {
                this.serverCountryCode = value;
                onPropertyChanged("ServerCountryCode");
            }
        }

        /// <summary>
        /// The encoding format the URL uses
        /// </summary>
        [JsonProperty("contentEncoding")]
        public string ContentEncoding 
        { 
            get 
            {
                return this.contentEncoding; 
            } 
            set 
            {
                this.contentEncoding = value;
                onPropertyChanged("ContentEncoding");
            }
        }

        /// <summary>
        /// The IP address of the server hosting this URL
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
        /// The URL protocol, usually http or https
        /// </summary>
        [JsonProperty("urlProtocol")]
        public string UrlProtocol 
        { 
            get 
            {
                return this.urlProtocol; 
            } 
            set 
            {
                this.urlProtocol = value;
                onPropertyChanged("UrlProtocol");
            }
        }

        /// <summary>
        /// The content-type this URL serves
        /// </summary>
        [JsonProperty("contentType")]
        public string ContentType 
        { 
            get 
            {
                return this.contentType; 
            } 
            set 
            {
                this.contentType = value;
                onPropertyChanged("ContentType");
            }
        }

        /// <summary>
        /// True if this URL responded with an HTTP redirect
        /// </summary>
        [JsonProperty("httpRedirect")]
        public bool HttpRedirect 
        { 
            get 
            {
                return this.httpRedirect; 
            } 
            set 
            {
                this.httpRedirect = value;
                onPropertyChanged("HttpRedirect");
            }
        }

        /// <summary>
        /// The actual content this URL responded with. Only set if the 'fetch-content' option was used
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
    }
} 