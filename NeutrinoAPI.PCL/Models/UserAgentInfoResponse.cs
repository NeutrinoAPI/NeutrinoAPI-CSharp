/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io )
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
        /// Mobile device screen width (in px)
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
        /// Mobile device brand
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
        /// Mobile device model
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
        /// Producer or manufacturer
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
        /// Browser software name
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
        /// Mobile device screen height (in px)
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
        /// True if this is a mobile user-agent
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
        /// The user-agent type, possible values are: desktop-browser, email-client, feed-reader, software-library, media-player, mobile-browser, robot, unknown
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
        /// Software version
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
        /// Operating system
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
        /// Mobile device browser
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