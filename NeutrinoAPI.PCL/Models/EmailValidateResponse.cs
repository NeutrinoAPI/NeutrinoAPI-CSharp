/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 01/07/2016
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
using NeutrinoAPI.PCL;

namespace NeutrinoAPI.PCL.Models
{
    public class EmailValidateResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private bool syntaxError;
        private string domain;
        private bool domainError;
        private bool isFreemail;
        private string email;

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 