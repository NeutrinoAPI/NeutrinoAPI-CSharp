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
    public class IPProbeResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private string country;
        private string providerType;
        private string countryCode;
        private string hostname;
        private string providerDomain;
        private string city;
        private string providerWebsite;
        private string ip;
        private string region;
        private string providerDescription;
        private string continentCode;
        private bool isHosting;
        private bool isIsp;

        /// <summary>
        /// Is this a valid IPv4 or IPv6 address
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
        /// Full country name
        /// </summary>
        [JsonProperty("country")]
        public string Country 
        { 
            get 
            {
                return this.country; 
            } 
            set 
            {
                this.country = value;
                onPropertyChanged("Country");
            }
        }

        /// <summary>
        /// The detected provider type. See online API docs for specific provider type details
        /// </summary>
        [JsonProperty("providerType")]
        public string ProviderType 
        { 
            get 
            {
                return this.providerType; 
            } 
            set 
            {
                this.providerType = value;
                onPropertyChanged("ProviderType");
            }
        }

        /// <summary>
        /// ISO 2-letter country code
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode 
        { 
            get 
            {
                return this.countryCode; 
            } 
            set 
            {
                this.countryCode = value;
                onPropertyChanged("CountryCode");
            }
        }

        /// <summary>
        /// The IPs hostname (PTR)
        /// </summary>
        [JsonProperty("hostname")]
        public string Hostname 
        { 
            get 
            {
                return this.hostname; 
            } 
            set 
            {
                this.hostname = value;
                onPropertyChanged("Hostname");
            }
        }

        /// <summary>
        /// The domain name of the provider
        /// </summary>
        [JsonProperty("providerDomain")]
        public string ProviderDomain 
        { 
            get 
            {
                return this.providerDomain; 
            } 
            set 
            {
                this.providerDomain = value;
                onPropertyChanged("ProviderDomain");
            }
        }

        /// <summary>
        /// Full city name (if detectable)
        /// </summary>
        [JsonProperty("city")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// The website URL for the provider
        /// </summary>
        [JsonProperty("providerWebsite")]
        public string ProviderWebsite 
        { 
            get 
            {
                return this.providerWebsite; 
            } 
            set 
            {
                this.providerWebsite = value;
                onPropertyChanged("ProviderWebsite");
            }
        }

        /// <summary>
        /// The IP address
        /// </summary>
        [JsonProperty("ip")]
        public string Ip 
        { 
            get 
            {
                return this.ip; 
            } 
            set 
            {
                this.ip = value;
                onPropertyChanged("Ip");
            }
        }

        /// <summary>
        /// Full region name (if detectable)
        /// </summary>
        [JsonProperty("region")]
        public string Region 
        { 
            get 
            {
                return this.region; 
            } 
            set 
            {
                this.region = value;
                onPropertyChanged("Region");
            }
        }

        /// <summary>
        /// A description of the provider, usually extracted from the providers website or WHOIS record
        /// </summary>
        [JsonProperty("providerDescription")]
        public string ProviderDescription 
        { 
            get 
            {
                return this.providerDescription; 
            } 
            set 
            {
                this.providerDescription = value;
                onPropertyChanged("ProviderDescription");
            }
        }

        /// <summary>
        /// ISO 2-letter continent code
        /// </summary>
        [JsonProperty("continentCode")]
        public string ContinentCode 
        { 
            get 
            {
                return this.continentCode; 
            } 
            set 
            {
                this.continentCode = value;
                onPropertyChanged("ContinentCode");
            }
        }

        /// <summary>
        /// True if this IP belongs to a hosting company. Note that this can still be true even if the provider type is VPN/proxy, this occurs in the case that the IP is detected as both types
        /// </summary>
        [JsonProperty("isHosting")]
        public bool IsHosting 
        { 
            get 
            {
                return this.isHosting; 
            } 
            set 
            {
                this.isHosting = value;
                onPropertyChanged("IsHosting");
            }
        }

        /// <summary>
        /// True if this IP belongs to an ISP. Note that this can still be true even if the provider type is VPN/proxy, this occurs in the case that the IP is detected as both types
        /// </summary>
        [JsonProperty("isIsp")]
        public bool IsIsp 
        { 
            get 
            {
                return this.isIsp; 
            } 
            set 
            {
                this.isIsp = value;
                onPropertyChanged("IsIsp");
            }
        }
    }
} 