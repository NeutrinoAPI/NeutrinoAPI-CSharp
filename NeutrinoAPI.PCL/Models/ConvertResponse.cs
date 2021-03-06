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
    public class ConvertResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private string result;
        private string fromValue;
        private string toType;
        private string fromType;
        private int resultFloat;

        /// <summary>
        /// True if the coversion was successful and produced a valid result
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
        /// The result of the conversion in string format
        /// </summary>
        [JsonProperty("result")]
        public string Result 
        { 
            get 
            {
                return this.result; 
            } 
            set 
            {
                this.result = value;
                onPropertyChanged("Result");
            }
        }

        /// <summary>
        /// The value being converted from
        /// </summary>
        [JsonProperty("fromValue")]
        public string FromValue 
        { 
            get 
            {
                return this.fromValue; 
            } 
            set 
            {
                this.fromValue = value;
                onPropertyChanged("FromValue");
            }
        }

        /// <summary>
        /// The type being converted to
        /// </summary>
        [JsonProperty("toType")]
        public string ToType 
        { 
            get 
            {
                return this.toType; 
            } 
            set 
            {
                this.toType = value;
                onPropertyChanged("ToType");
            }
        }

        /// <summary>
        /// The type of the value being converted from
        /// </summary>
        [JsonProperty("fromType")]
        public string FromType 
        { 
            get 
            {
                return this.fromType; 
            } 
            set 
            {
                this.fromType = value;
                onPropertyChanged("FromType");
            }
        }

        /// <summary>
        /// The result of the conversion as a floating-point number
        /// </summary>
        [JsonProperty("resultFloat")]
        public int ResultFloat 
        { 
            get 
            {
                return this.resultFloat; 
            } 
            set 
            {
                this.resultFloat = value;
                onPropertyChanged("ResultFloat");
            }
        }
    }
} 