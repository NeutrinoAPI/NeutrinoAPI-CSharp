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
    public class HLRLookupResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool numberValid;
        private string internationalCallingCode;
        private string mnc;
        private string numberType;
        private bool hlrValid;
        private string hlrStatus;
        private string portedNetwork;
        private string imsi;
        private string mcc;
        private string internationalNumber;
        private string localNumber;
        private string countryCode;
        private bool isPorted;
        private string msin;
        private string location;
        private string originNetwork;
        private bool isMobile;
        private bool isRoaming;
        private string country;

        /// <summary>
        /// Is this a valid phone number (mobile or otherwise)
        /// </summary>
        [JsonProperty("numberValid")]
        public bool NumberValid 
        { 
            get 
            {
                return this.numberValid; 
            } 
            set 
            {
                this.numberValid = value;
                onPropertyChanged("NumberValid");
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
        /// The mobile MNC number (only set if HLR lookup valid)
        /// </summary>
        [JsonProperty("mnc")]
        public string Mnc 
        { 
            get 
            {
                return this.mnc; 
            } 
            set 
            {
                this.mnc = value;
                onPropertyChanged("Mnc");
            }
        }

        /// <summary>
        /// The number type, possible values are: mobile, fixed-line, premium-rate, toll-free, voip, unknown
        /// </summary>
        [JsonProperty("numberType")]
        public string NumberType 
        { 
            get 
            {
                return this.numberType; 
            } 
            set 
            {
                this.numberType = value;
                onPropertyChanged("NumberType");
            }
        }

        /// <summary>
        /// Was the HLR lookup successful. If true then this is a working and registered cell-phone or mobile device (SMS and phone calls will be delivered)
        /// </summary>
        [JsonProperty("hlrValid")]
        public bool HlrValid 
        { 
            get 
            {
                return this.hlrValid; 
            } 
            set 
            {
                this.hlrValid = value;
                onPropertyChanged("HlrValid");
            }
        }

        /// <summary>
        /// The HLR lookup status. See API docs for specific status details
        /// </summary>
        [JsonProperty("hlrStatus")]
        public string HlrStatus 
        { 
            get 
            {
                return this.hlrStatus; 
            } 
            set 
            {
                this.hlrStatus = value;
                onPropertyChanged("HlrStatus");
            }
        }

        /// <summary>
        /// If the number has been ported, the ported to mobile carrier name (only set if HLR lookup valid)
        /// </summary>
        [JsonProperty("portedNetwork")]
        public string PortedNetwork 
        { 
            get 
            {
                return this.portedNetwork; 
            } 
            set 
            {
                this.portedNetwork = value;
                onPropertyChanged("PortedNetwork");
            }
        }

        /// <summary>
        /// The mobile IMSI number (only set if HLR lookup valid)
        /// </summary>
        [JsonProperty("imsi")]
        public string Imsi 
        { 
            get 
            {
                return this.imsi; 
            } 
            set 
            {
                this.imsi = value;
                onPropertyChanged("Imsi");
            }
        }

        /// <summary>
        /// The mobile MCC number (only set if HLR lookup valid)
        /// </summary>
        [JsonProperty("mcc")]
        public string Mcc 
        { 
            get 
            {
                return this.mcc; 
            } 
            set 
            {
                this.mcc = value;
                onPropertyChanged("Mcc");
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
        /// Has this number been ported to another network
        /// </summary>
        [JsonProperty("isPorted")]
        public bool IsPorted 
        { 
            get 
            {
                return this.isPorted; 
            } 
            set 
            {
                this.isPorted = value;
                onPropertyChanged("IsPorted");
            }
        }

        /// <summary>
        /// The mobile MSIN number (only set if HLR lookup valid)
        /// </summary>
        [JsonProperty("msin")]
        public string Msin 
        { 
            get 
            {
                return this.msin; 
            } 
            set 
            {
                this.msin = value;
                onPropertyChanged("Msin");
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
        /// The origin mobile carrier name (only set if HLR lookup valid)
        /// </summary>
        [JsonProperty("originNetwork")]
        public string OriginNetwork 
        { 
            get 
            {
                return this.originNetwork; 
            } 
            set 
            {
                this.originNetwork = value;
                onPropertyChanged("OriginNetwork");
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
        /// Is this number currently roaming from its origin country
        /// </summary>
        [JsonProperty("isRoaming")]
        public bool IsRoaming 
        { 
            get 
            {
                return this.isRoaming; 
            } 
            set 
            {
                this.isRoaming = value;
                onPropertyChanged("IsRoaming");
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