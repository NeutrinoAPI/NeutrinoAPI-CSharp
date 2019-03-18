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
    public class HLRLookupResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool numberValid;
        private int internationalCallingCode;
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
        private string countryCode3;
        private string currencyCode;
        private string roamingCountryCode;
        private string msc;

        /// <summary>
        /// True if this a valid phone number
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
        /// The numbers international calling code
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
        /// The mobile MNC number (Mobile Network Code)
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
        /// The number type, possible values are:<br/><ul><li>mobile</li><li>fixed-line</li><li>premium-rate</li><li>toll-free</li><li>voip</li><li>unknown</li></ul>
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
        /// The HLR lookup status, possible values are:<br/><ul><li>ok - the HLR lookup was successful and the device is connected</li><li>absent - the number was once registered but the device has been switched off or out of network range for some time</li><li>unknown - the number is not known by the mobile network</li><li>invalid  - the number is not a valid mobile MSISDN number</li><li>fixed-line - the number is a registered fixed-line not mobile</li><li>voip - the number has been detected as a VOIP line</li><li>failed - the HLR lookup has failed, we could not determine the real status of this number</li></ul>
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
        /// If the number has been ported, the ported to carrier name
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
        /// The mobile IMSI number (International Mobile Subscriber Identity)
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
        /// The mobile MCC number (Mobile Country Code)
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
        /// The number represented in full international format
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
        /// The number location as an ISO 2-letter country code
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
        /// The mobile MSIN number (Mobile Subscription Identification Number)
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
        /// The number location. Could be a city, region or country depending on the type of number
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
        /// The origin mobile carrier name
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
        /// True if this is a mobile number (only true with 100% certainty, if the number type is unknown this value will be false)
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

        /// <summary>
        /// The number location as an ISO 3-letter country code
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
        /// If the number is currently roaming, the ISO 2-letter country code of the roaming in country
        /// </summary>
        [JsonProperty("roamingCountryCode")]
        public string RoamingCountryCode 
        { 
            get 
            {
                return this.roamingCountryCode; 
            } 
            set 
            {
                this.roamingCountryCode = value;
                onPropertyChanged("RoamingCountryCode");
            }
        }

        /// <summary>
        /// The mobile MSC number (Mobile Switching Center)
        /// </summary>
        [JsonProperty("msc")]
        public string Msc 
        { 
            get 
            {
                return this.msc; 
            } 
            set 
            {
                this.msc = value;
                onPropertyChanged("Msc");
            }
        }
    }
} 