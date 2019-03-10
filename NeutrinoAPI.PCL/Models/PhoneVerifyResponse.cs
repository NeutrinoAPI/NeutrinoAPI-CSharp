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
    public class PhoneVerifyResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool numberValid;
        private bool calling;
        private string securityCode;

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
        /// The security code generated, you can save this code to perform your own verification or you can use the <a href='https://www.neutrinoapi.com/api/verify-security-code/'>Verify Security Code API</a>
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
    }
} 