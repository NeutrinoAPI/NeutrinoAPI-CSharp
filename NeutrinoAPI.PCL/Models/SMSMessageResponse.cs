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
    public class SMSMessageResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool numberValid;
        private bool sent;

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
        /// True if the SMS has been sent
        /// </summary>
        [JsonProperty("sent")]
        public bool Sent 
        { 
            get 
            {
                return this.sent; 
            } 
            set 
            {
                this.sent = value;
                onPropertyChanged("Sent");
            }
        }
    }
} 