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
    public class EmailValidateResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private bool syntaxError;
        private string domain;
        private bool domainError;
        private bool isFreemail;
        private string email;
        private bool isDisposable;
        private bool typosFixed;

        /// <summary>
        /// Is this a valid email
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
        /// True if this address has a syntax error
        /// </summary>
        [JsonProperty("syntaxError")]
        public bool SyntaxError 
        { 
            get 
            {
                return this.syntaxError; 
            } 
            set 
            {
                this.syntaxError = value;
                onPropertyChanged("SyntaxError");
            }
        }

        /// <summary>
        /// The email domain
        /// </summary>
        [JsonProperty("domain")]
        public string Domain 
        { 
            get 
            {
                return this.domain; 
            } 
            set 
            {
                this.domain = value;
                onPropertyChanged("Domain");
            }
        }

        /// <summary>
        /// True if this address has a domain error (e.g. no valid mail server records)
        /// </summary>
        [JsonProperty("domainError")]
        public bool DomainError 
        { 
            get 
            {
                return this.domainError; 
            } 
            set 
            {
                this.domainError = value;
                onPropertyChanged("DomainError");
            }
        }

        /// <summary>
        /// True if this address is a free-mail address
        /// </summary>
        [JsonProperty("isFreemail")]
        public bool IsFreemail 
        { 
            get 
            {
                return this.isFreemail; 
            } 
            set 
            {
                this.isFreemail = value;
                onPropertyChanged("IsFreemail");
            }
        }

        /// <summary>
        /// The full email address (this could be different to the supplied address if fix-typos is used)
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// True if this address is a disposable, temporary or darknet related email address
        /// </summary>
        [JsonProperty("isDisposable")]
        public bool IsDisposable 
        { 
            get 
            {
                return this.isDisposable; 
            } 
            set 
            {
                this.isDisposable = value;
                onPropertyChanged("IsDisposable");
            }
        }

        /// <summary>
        /// True if typos have been fixed
        /// </summary>
        [JsonProperty("typosFixed")]
        public bool TyposFixed 
        { 
            get 
            {
                return this.typosFixed; 
            } 
            set 
            {
                this.typosFixed = value;
                onPropertyChanged("TyposFixed");
            }
        }
    }
} 