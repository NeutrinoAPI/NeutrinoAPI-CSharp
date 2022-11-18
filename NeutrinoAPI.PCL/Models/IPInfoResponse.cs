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
    public class IPInfoResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private string country;
        private string hostname;
        private string city;
        private string countryCode;
        private double latitude;
        private string region;
        private double longitude;
        private string continentCode;
        private string ip;
        private string countryCode3;
        private string currencyCode;
        private string hostDomain;
        private Dictionary<string, string> timezone;

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
        /// The IPs full hostname (only set if reverse-lookup has been used)
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
        /// Name of the city (if detectable)
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
        /// Location latitude
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude 
        { 
            get 
            {
                return this.latitude; 
            } 
            set 
            {
                this.latitude = value;
                onPropertyChanged("Latitude");
            }
        }

        /// <summary>
        /// Name of the region (if detectable)
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
        /// Location longitude
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude 
        { 
            get 
            {
                return this.longitude; 
            } 
            set 
            {
                this.longitude = value;
                onPropertyChanged("Longitude");
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
        /// ISO 3-letter country code
        /// </summary>
        [JsonProperty("countryCode3")]
        public string CountryCode3 
        { 
            get 
            {
                return this.countryCode3; 
            } 
            set 
            {
                this.countryCode3 = value;
                onPropertyChanged("CountryCode3");
            }
        }

        /// <summary>
        /// ISO 4217 currency code associated with the country
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// The IPs host domain (only set if reverse-lookup has been used)
        /// </summary>
        [JsonProperty("hostDomain")]
        public string HostDomain 
        { 
            get 
            {
                return this.hostDomain; 
            } 
            set 
            {
                this.hostDomain = value;
                onPropertyChanged("HostDomain");
            }
        }

        /// <summary>
        /// Map containing timezone details for the location: <ul> <li>id - the time zone ID as per the IANA time zone database (tzdata)</li> <li>name - the time zone name</li> <li>abbr - the time zone abbreviation</li> <li>date - the current date within the time zone (ISO format)</li> <li>time - the current time within the time zone (ISO format)</li> </ul>
        /// </summary>
        [JsonProperty("timezone")]
        public Dictionary<string, string> Timezone 
        { 
            get 
            {
                return this.timezone; 
            } 
            set 
            {
                this.timezone = value;
                onPropertyChanged("Timezone");
            }
        }
    }
} 