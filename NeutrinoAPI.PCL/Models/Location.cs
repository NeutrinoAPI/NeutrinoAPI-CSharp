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
    public class Location : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string country;
        private string address;
        private string city;
        private string countryCode;
        private double latitude;
        private string postalCode;
        private double longitude;
        private string state;
        private Dictionary<string, string> addressComponents;

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
        /// The location latitude
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
        /// The location longitude
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
        /// The state of the location (if applicable)
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
        /// The components which make up the address such as road, city, state etc. May also include additional metadata about the address
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
    }
} 