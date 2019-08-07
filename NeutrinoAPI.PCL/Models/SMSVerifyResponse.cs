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
    public class SMSVerifyResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool numberValid;
        private string securityCode;
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
        /// The security code generated, you can save this code to perform your own verification or you can use the <a href="https://www.neutrinoapi.com/api/verify-security-code/">Verify Security Code API</a>
        /// </summary>
        [JsonProperty("securityCode")]
        public string SecurityCode 
        { 
            get 
            {
                return this.securityCode; 
            } 
            set 
            {
                this.securityCode = value;
                onPropertyChanged("SecurityCode");
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