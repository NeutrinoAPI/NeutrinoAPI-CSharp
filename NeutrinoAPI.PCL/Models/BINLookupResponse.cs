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
    public class BINLookupResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string country;
        private string ipCity;
        private bool ipMatchesBin;
        private string cardType;
        private string cardCategory;
        private string ipCountryCode;
        private string ipCountry;
        private string issuer;
        private bool ipBlocklisted;
        private bool valid;
        private List<string> ipBlocklists;
        private string issuerWebsite;
        private string countryCode;
        private string ipRegion;
        private string cardBrand;
        private string issuerPhone;

        /// <summary>
        /// Full country name of the issuer
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
        /// The city name (if detectable) from the customer IP
        /// </summary>
        [JsonProperty("ipCity")]
        public string IpCity 
        { 
            get 
            {
                return this.ipCity; 
            } 
            set 
            {
                this.ipCity = value;
                onPropertyChanged("IpCity");
            }
        }

        /// <summary>
        /// True if the customer IP address country matches the BIN country
        /// </summary>
        [JsonProperty("ipMatchesBin")]
        public bool IpMatchesBin 
        { 
            get 
            {
                return this.ipMatchesBin; 
            } 
            set 
            {
                this.ipMatchesBin = value;
                onPropertyChanged("IpMatchesBin");
            }
        }

        /// <summary>
        /// The card type, will always be one of: DEBIT, CREDIT, CHARGE CARD
        /// </summary>
        [JsonProperty("cardType")]
        public string CardType 
        { 
            get 
            {
                return this.cardType; 
            } 
            set 
            {
                this.cardType = value;
                onPropertyChanged("CardType");
            }
        }

        /// <summary>
        /// The card category (if known)
        /// </summary>
        [JsonProperty("cardCategory")]
        public string CardCategory 
        { 
            get 
            {
                return this.cardCategory; 
            } 
            set 
            {
                this.cardCategory = value;
                onPropertyChanged("CardCategory");
            }
        }

        /// <summary>
        /// The ISO 2-letter country code detected from the customer IP
        /// </summary>
        [JsonProperty("ipCountryCode")]
        public string IpCountryCode 
        { 
            get 
            {
                return this.ipCountryCode; 
            } 
            set 
            {
                this.ipCountryCode = value;
                onPropertyChanged("IpCountryCode");
            }
        }

        /// <summary>
        /// The country detected from the customer IP
        /// </summary>
        [JsonProperty("ipCountry")]
        public string IpCountry 
        { 
            get 
            {
                return this.ipCountry; 
            } 
            set 
            {
                this.ipCountry = value;
                onPropertyChanged("IpCountry");
            }
        }

        /// <summary>
        /// The card issuer (if known)
        /// </summary>
        [JsonProperty("issuer")]
        public string Issuer 
        { 
            get 
            {
                return this.issuer; 
            } 
            set 
            {
                this.issuer = value;
                onPropertyChanged("Issuer");
            }
        }

        /// <summary>
        /// True if the customer IP is listed on one of our blocklists, see the IP Blocklist API for more details
        /// </summary>
        [JsonProperty("ipBlocklisted")]
        public bool IpBlocklisted 
        { 
            get 
            {
                return this.ipBlocklisted; 
            } 
            set 
            {
                this.ipBlocklisted = value;
                onPropertyChanged("IpBlocklisted");
            }
        }

        /// <summary>
        /// Is this a valid BIN or IIN number
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
        /// An array of strings indicating which blocklists this IP is listed on
        /// </summary>
        [JsonProperty("ipBlocklists")]
        public List<string> IpBlocklists 
        { 
            get 
            {
                return this.ipBlocklists; 
            } 
            set 
            {
                this.ipBlocklists = value;
                onPropertyChanged("IpBlocklists");
            }
        }

        /// <summary>
        /// The card issuer website (if known)
        /// </summary>
        [JsonProperty("issuerWebsite")]
        public string IssuerWebsite 
        { 
            get 
            {
                return this.issuerWebsite; 
            } 
            set 
            {
                this.issuerWebsite = value;
                onPropertyChanged("IssuerWebsite");
            }
        }

        /// <summary>
        /// ISO 2-letter country code of the issuer
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
        /// The region name (if detectable) from the customer IP
        /// </summary>
        [JsonProperty("ipRegion")]
        public string IpRegion 
        { 
            get 
            {
                return this.ipRegion; 
            } 
            set 
            {
                this.ipRegion = value;
                onPropertyChanged("IpRegion");
            }
        }

        /// <summary>
        /// The card brand (e.g. Visa or Mastercard)
        /// </summary>
        [JsonProperty("cardBrand")]
        public string CardBrand 
        { 
            get 
            {
                return this.cardBrand; 
            } 
            set 
            {
                this.cardBrand = value;
                onPropertyChanged("CardBrand");
            }
        }

        /// <summary>
        /// The card issuer phone number (if known)
        /// </summary>
        [JsonProperty("issuerPhone")]
        public string IssuerPhone 
        { 
            get 
            {
                return this.issuerPhone; 
            } 
            set 
            {
                this.issuerPhone = value;
                onPropertyChanged("IssuerPhone");
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