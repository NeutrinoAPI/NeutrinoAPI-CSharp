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
    public class BadWordFilterResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<string> badWordsList;
        private int badWordsTotal;
        private string censoredContent;
        private bool isBad;

        /// <summary>
        /// Array of the bad words found
        /// </summary>
        [JsonProperty("badWordsList")]
        public List<string> BadWordsList 
        { 
            get 
            {
                return this.badWordsList; 
            } 
            set 
            {
                this.badWordsList = value;
                onPropertyChanged("BadWordsList");
            }
        }

        /// <summary>
        /// Total number of bad words detected
        /// </summary>
        [JsonProperty("badWordsTotal")]
        public int BadWordsTotal 
        { 
            get 
            {
                return this.badWordsTotal; 
            } 
            set 
            {
                this.badWordsTotal = value;
                onPropertyChanged("BadWordsTotal");
            }
        }

        /// <summary>
        /// The censored content (only set if censor-character has been set)
        /// </summary>
        [JsonProperty("censoredContent")]
        public string CensoredContent 
        { 
            get 
            {
                return this.censoredContent; 
            } 
            set 
            {
                this.censoredContent = value;
                onPropertyChanged("CensoredContent");
            }
        }

        /// <summary>
        /// Does the text contain bad words
        /// </summary>
        [JsonProperty("isBad")]
        public bool IsBad 
        { 
            get 
            {
                return this.isBad; 
            } 
            set 
            {
                this.isBad = value;
                onPropertyChanged("IsBad");
            }
        }
    }
} 