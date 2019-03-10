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
    public class GeocodeReverseResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string country;
        private bool found;
        private string address;
        private string city;
        private string countryCode;
        private string postalCode;
        private string state;
        private Dictionary<string, string> addressComponents;
        private string countryCode3;
        private string currencyCode;
        private string locationType;
        private List<string> locationTags;

        /// <summary>
        /// The country of the location
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
        /// True if these coordinates map to a real location
        /// </summary>
        [JsonProperty("found")]
        public bool Found 
        { 
            get 
            {
                return this.found; 
            } 
            set 
            {
                this.found = value;
                onPropertyChanged("Found");
            }
        }

        /// <summary>
        /// The fully formatted address
        /// </summary>
        [JsonProperty("address")]
        public string Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }

        /// <summary>
        /// The city of the location
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
        /// The ISO 2-letter country code of the location
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
        /// The postal code for the location
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode 
        { 
            get 
            {
                return this.postalCode; 
            } 
            set 
            {
                this.postalCode = value;
                onPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        /// The state of the location
        /// </summary>
        [JsonProperty("state")]
        public string State 
        { 
            get 
            {
                return this.state; 
            } 
            set 
            {
                this.state = value;
                onPropertyChanged("State");
            }
        }

        /// <summary>
        /// The components which make up the address such as road, city, state, etc
        /// </summary>
        [JsonProperty("addressComponents")]
        public Dictionary<string, string> AddressComponents 
        { 
            get 
            {
                return this.addressComponents; 
            } 
            set 
            {
                this.addressComponents = value;
                onPropertyChanged("AddressComponents");
            }
        }

        /// <summary>
        /// The ISO 3-letter country code of the location
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
        /// The detected location type ordered roughly from most to least precise, possible values are:<br/><ul><li>address - indicates a precise street address</li><li>street - accurate to the street level but may not point to the exact location of the house/building number</li><li>city - accurate to the city level, this includes villages, towns, suburbs, etc</li><li>postal-code - indicates a postal code area (no house or street information present)</li><li>railway - location is part of a rail network such as a station or railway track</li><li>natural - indicates a natural feature, for example a mountain peak or a waterway</li><li>island - location is an island or archipelago</li><li>administrative - indicates an administrative boundary such as a country, state or province</li></ul>
        /// </summary>
        [JsonProperty("locationType")]
        public string LocationType 
        { 
            get 
            {
                return this.locationType; 
            } 
            set 
            {
                this.locationType = value;
                onPropertyChanged("LocationType");
            }
        }

        /// <summary>
        /// Array of strings containing any location tags associated with the address. Tags are additional pieces of metadata about a specific location, there are thousands of different tags. Some examples of tags: shop, office, cafe, bank, pub
        /// </summary>
        [JsonProperty("locationTags")]
        public List<string> LocationTags 
        { 
            get 
            {
                return this.locationTags; 
            } 
            set 
            {
                this.locationTags = value;
                onPropertyChanged("LocationTags");
            }
        }
    }
} 