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
    public class UserAgentInfoResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int mobileScreenWidth;
        private string mobileBrand;
        private string mobileModel;
        private string producer;
        private string browserName;
        private int mobileScreenHeight;
        private bool isMobile;
        private string type;
        private string version;
        private string operatingSystem;
        private string mobileBrowser;
        private bool isAndroid;
        private bool isIos;
        private string operatingSystemFamily;
        private string operatingSystemVersion;
        private string engine;
        private string engineVersion;

        /// <summary>
        /// The estimated mobile device screen width in CSS 'px'
        /// </summary>
        [JsonProperty("mobileScreenWidth")]
        public int MobileScreenWidth 
        { 
            get 
            {
                return this.mobileScreenWidth; 
            } 
            set 
            {
                this.mobileScreenWidth = value;
                onPropertyChanged("MobileScreenWidth");
            }
        }

        /// <summary>
        /// The mobile device brand
        /// </summary>
        [JsonProperty("mobileBrand")]
        public string MobileBrand 
        { 
            get 
            {
                return this.mobileBrand; 
            } 
            set 
            {
                this.mobileBrand = value;
                onPropertyChanged("MobileBrand");
            }
        }

        /// <summary>
        /// The mobile device model
        /// </summary>
        [JsonProperty("mobileModel")]
        public string MobileModel 
        { 
            get 
            {
                return this.mobileModel; 
            } 
            set 
            {
                this.mobileModel = value;
                onPropertyChanged("MobileModel");
            }
        }

        /// <summary>
        /// The producer or manufacturer of the user agent
        /// </summary>
        [JsonProperty("producer")]
        public string Producer 
        { 
            get 
            {
                return this.producer; 
            } 
            set 
            {
                this.producer = value;
                onPropertyChanged("Producer");
            }
        }

        /// <summary>
        /// The browser software name
        /// </summary>
        [JsonProperty("browserName")]
        public string BrowserName 
        { 
            get 
            {
                return this.browserName; 
            } 
            set 
            {
                this.browserName = value;
                onPropertyChanged("BrowserName");
            }
        }

        /// <summary>
        /// The estimated mobile device screen height in CSS 'px'
        /// </summary>
        [JsonProperty("mobileScreenHeight")]
        public int MobileScreenHeight 
        { 
            get 
            {
                return this.mobileScreenHeight; 
            } 
            set 
            {
                this.mobileScreenHeight = value;
                onPropertyChanged("MobileScreenHeight");
            }
        }

        /// <summary>
        /// True if this is a mobile user agent
        /// </summary>
        [JsonProperty("isMobile")]
        public bool IsMobile 
        { 
            get 
            {
                return this.isMobile; 
            } 
            set 
            {
                this.isMobile = value;
                onPropertyChanged("IsMobile");
            }
        }

        /// <summary>
        /// The user agent type, possible values are:<br/><ul><li>desktop-browser</li><li>mobile-browser</li><li>email-client</li><li>feed-reader</li><li>software-library</li><li>media-player (includes smart TVs)</li><li>robot</li><li>unknown</li></ul>
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The browser software version
        /// </summary>
        [JsonProperty("version")]
        public string Version 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("Version");
            }
        }

        /// <summary>
        /// The full operating system name which may include the major version number or code name
        /// </summary>
        [JsonProperty("operatingSystem")]
        public string OperatingSystem 
        { 
            get 
            {
                return this.operatingSystem; 
            } 
            set 
            {
                this.operatingSystem = value;
                onPropertyChanged("OperatingSystem");
            }
        }

        /// <summary>
        /// The mobile device browser name (this is usually the same as the browser name)
        /// </summary>
        [JsonProperty("mobileBrowser")]
        public string MobileBrowser 
        { 
            get 
            {
                return this.mobileBrowser; 
            } 
            set 
            {
                this.mobileBrowser = value;
                onPropertyChanged("MobileBrowser");
            }
        }

        /// <summary>
        /// True if this is an Android based mobile user agent
        /// </summary>
        [JsonProperty("isAndroid")]
        public bool IsAndroid 
        { 
            get 
            {
                return this.isAndroid; 
            } 
            set 
            {
                this.isAndroid = value;
                onPropertyChanged("IsAndroid");
            }
        }

        /// <summary>
        /// True if this is an iOS based mobile user agent
        /// </summary>
        [JsonProperty("isIos")]
        public bool IsIos 
        { 
            get 
            {
                return this.isIos; 
            } 
            set 
            {
                this.isIos = value;
                onPropertyChanged("IsIos");
            }
        }

        /// <summary>
        /// The operating system family name, this is the OS name without any version information
        /// </summary>
        [JsonProperty("operatingSystemFamily")]
        public string OperatingSystemFamily 
        { 
            get 
            {
                return this.operatingSystemFamily; 
            } 
            set 
            {
                this.operatingSystemFamily = value;
                onPropertyChanged("OperatingSystemFamily");
            }
        }

        /// <summary>
        /// The operating system version number (if detectable)
        /// </summary>
        [JsonProperty("operatingSystemVersion")]
        public string OperatingSystemVersion 
        { 
            get 
            {
                return this.operatingSystemVersion; 
            } 
            set 
            {
                this.operatingSystemVersion = value;
                onPropertyChanged("OperatingSystemVersion");
            }
        }

        /// <summary>
        /// The browser engine name
        /// </summary>
        [JsonProperty("engine")]
        public string Engine 
        { 
            get 
            {
                return this.engine; 
            } 
            set 
            {
                this.engine = value;
                onPropertyChanged("Engine");
            }
        }

        /// <summary>
        /// The browser engine version (if detectable)
        /// </summary>
        [JsonProperty("engineVersion")]
        public string EngineVersion 
        { 
            get 
            {
                return this.engineVersion; 
            } 
            set 
            {
                this.engineVersion = value;
                onPropertyChanged("EngineVersion");
            }
        }
    }
} 