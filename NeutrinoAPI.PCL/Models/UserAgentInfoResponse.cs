/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 12/06/2015
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
using NeutrinoAPI.PCL;

namespace NeutrinoAPI.PCL.Models
{
    public class UserAgentInfoResponse : INotifyPropertyChanged 
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
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 