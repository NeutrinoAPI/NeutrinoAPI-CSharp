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
        /// The detected provider type. See API docs for specific provider type details
        /// </summary>
        [JsonProperty("provider-type")]
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
        [JsonProperty("country-code")]
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
        [JsonProperty("provider-domain")]
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
        [JsonProperty("provider-website")]
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
        [JsonProperty("provider-description")]
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
    }
} 