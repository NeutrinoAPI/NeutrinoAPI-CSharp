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
    public class PhonePlaybackResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool calling;
        private bool numberValid;

        /// <summary>
        /// True if the call is being made now
        /// </summary>
        [JsonProperty("calling")]
        public bool Calling 
        { 
            get 
            {
                return this.calling; 
            } 
            set 
            {
                this.calling = value;
                onPropertyChanged("Calling");
            }
        }

        /// <summary>
        /// Is this a valid phone number
        /// </summary>
        [JsonProperty("number-valid")]
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
    }
} 