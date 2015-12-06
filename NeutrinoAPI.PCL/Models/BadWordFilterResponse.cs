/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 12/06/2015
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
    public class BadWordFilterResponse : INotifyPropertyChanged 
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