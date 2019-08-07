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
    public class PhoneValidateResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private int internationalCallingCode;
        private string countryCode;
        private string location;
        private bool isMobile;
        private string type;
        private string internationalNumber;
        private string localNumber;
        private string country;
        private string countryCode3;
        private string currencyCode;

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
        /// The international calling code
        /// </summary>
        [JsonProperty("internationalCallingCode")]
        public int InternationalCallingCode 
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
        /// The phone number country as an ISO 2-letter country code
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
        /// The phone number location. Could be a city, region or country depending on the type of number
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
        /// True if this is a mobile number. If the number type is unknown this value will be false, use HLR lookup instead
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
        /// The predicted number type. Note: type detection is not possible in some countries which have no predictable prefix pattern (you can use the HLR Lookup API in these cases) Possible values are: <ul> <li>mobile</li> <li>fixed-line</li> <li>premium-rate</li> <li>toll-free</li> <li>voip</li> <li>unknown (use HLR lookup)</li> </ul>
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
        /// The number represented in full international format (E.164)
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
        /// The number represented in local dialing format
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

        /// <summary>
        /// The phone number country as an ISO 3-letter country code
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
    }
} 