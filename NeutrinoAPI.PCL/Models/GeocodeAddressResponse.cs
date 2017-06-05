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
    public class GeocodeAddressResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int found;
        private List<Models.Location> locations;

        /// <summary>
        /// The number of possible matching locations found
        /// </summary>
        [JsonProperty("found")]
        public int Found 
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
        /// Array of matching location objects
        /// </summary>
        [JsonProperty("locations")]
        public List<Models.Location> Locations 
        { 
            get 
            {
                return this.locations; 
            } 
            set 
            {
                this.locations = value;
                onPropertyChanged("Locations");
            }
        }
    }
} 