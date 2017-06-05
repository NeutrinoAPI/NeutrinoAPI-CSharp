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
    public class PhoneValidateResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private string internationalCallingCode;
        private string countryCode;
        private string location;
        private bool isMobile;
        private string type;
        private string internationalNumber;
        private string localNumber;
        private string country;

        /// <summary>
        /// Is this a valid phone number
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
        /// Numbers international calling code
        /// </summary>
        [JsonProperty("internationalCallingCode")]
        public string InternationalCallingCode 
        { 
            get 
            {
                return this.internationalCallingCode; 
            } 
            set 
            {
                this.internationalCallingCode = value;
                onPropertyChanged("InternationalCallingCode");
            }
        }

        /// <summary>
        /// Number location ISO 2-letter country code
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
        /// Number location (could be a city, region or country)
        /// </summary>
        [JsonProperty("location")]
        public string Location 
        { 
            get 
            {
                return this.location; 
            } 
            set 
            {
                this.location = value;
                onPropertyChanged("Location");
            }
        }

        /// <summary>
        /// Is this a mobile number
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
        /// The number type, possible values are: mobile, fixed-line, premium-rate, toll-free, voip, unknown
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
        /// Number represented in international format
        /// </summary>
        [JsonProperty("internationalNumber")]
        public string InternationalNumber 
        { 
            get 
            {
                return this.internationalNumber; 
            } 
            set 
            {
                this.internationalNumber = value;
                onPropertyChanged("InternationalNumber");
            }
        }

        /// <summary>
        /// Number represented in local format
        /// </summary>
        [JsonProperty("localNumber")]
        public string LocalNumber 
        { 
            get 
            {
                return this.localNumber; 
            } 
            set 
            {
                this.localNumber = value;
                onPropertyChanged("LocalNumber");
            }
        }

        /// <summary>
        /// The phone number country
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
    }
} 