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
    public class HTMLExtractResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int total;
        private List<string> values;

        /// <summary>
        /// The total number of values extracted
        /// </summary>
        [JsonProperty("total")]
        public int Total 
        { 
            get 
            {
                return this.total; 
            } 
            set 
            {
                this.total = value;
                onPropertyChanged("Total");
            }
        }

        /// <summary>
        /// Array of extracted values
        /// </summary>
        [JsonProperty("values")]
        public List<string> Values 
        { 
            get 
            {
                return this.values; 
            } 
            set 
            {
                this.values = value;
                onPropertyChanged("Values");
            }
        }
    }
} 