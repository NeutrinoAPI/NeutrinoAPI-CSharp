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
    public class VerifySecurityCodeResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool verified;

        /// <summary>
        /// True if the code is valid
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified 
        { 
            get 
            {
                return this.verified; 
            } 
            set 
            {
                this.verified = value;
                onPropertyChanged("Verified");
            }
        }
    }
} 