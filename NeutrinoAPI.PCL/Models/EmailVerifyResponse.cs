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
    public class EmailVerifyResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private bool verified;
        private string email;
        private bool typosFixed;
        private bool syntaxError;
        private bool domainError;
        private string domain;
        private string provider;
        private bool isFreemail;
        private bool isDisposable;
        private bool isPersonal;
        private string smtpStatus;
        private string smtpResponse;
        private bool isCatchAll;
        private bool isDeferred;

        /// <summary>
        /// Is this a valid email address (syntax and domain is valid)
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
        /// True if this address has passed SMTP verification. Check the smtp-status and smtp-response fields for specific verification details
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

        /// <summary>
        /// The full email address (this could be different to the supplied address if typos-fixed is true)
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
        /// The email service provider domain
        /// </summary>
        [JsonProperty("provider")]
        public string Provider 
        { 
            get 
            {
                return this.provider; 
            } 
            set 
            {
                this.provider = value;
                onPropertyChanged("Provider");
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
        /// True if this address is for a person. False if this is a role based address, e.g. admin@, help@, office@, etc.
        /// </summary>
        [JsonProperty("isPersonal")]
        public bool IsPersonal 
        { 
            get 
            {
                return this.isPersonal; 
            } 
            set 
            {
                this.isPersonal = value;
                onPropertyChanged("IsPersonal");
            }
        }

        /// <summary>
        /// The SMTP verification status for the address (see online docs for full details)
        /// </summary>
        [JsonProperty("smtpStatus")]
        public string SmtpStatus 
        { 
            get 
            {
                return this.smtpStatus; 
            } 
            set 
            {
                this.smtpStatus = value;
                onPropertyChanged("SmtpStatus");
            }
        }

        /// <summary>
        /// The raw SMTP response message received during verification
        /// </summary>
        [JsonProperty("smtpResponse")]
        public string SmtpResponse 
        { 
            get 
            {
                return this.smtpResponse; 
            } 
            set 
            {
                this.smtpResponse = value;
                onPropertyChanged("SmtpResponse");
            }
        }

        /// <summary>
        /// True if this email domain has a catch-all policy (it will accept mail for any username)
        /// </summary>
        [JsonProperty("isCatchAll")]
        public bool IsCatchAll 
        { 
            get 
            {
                return this.isCatchAll; 
            } 
            set 
            {
                this.isCatchAll = value;
                onPropertyChanged("IsCatchAll");
            }
        }

        /// <summary>
        /// True if the mail server responded with a temporary failure (either a 4xx response code or unresponsive server). You can retry this address later, we recommend waiting at least 15 minutes before retrying
        /// </summary>
        [JsonProperty("isDeferred")]
        public bool IsDeferred 
        { 
            get 
            {
                return this.isDeferred; 
            } 
            set 
            {
                this.isDeferred = value;
                onPropertyChanged("IsDeferred");
            }
        }
    }
} 