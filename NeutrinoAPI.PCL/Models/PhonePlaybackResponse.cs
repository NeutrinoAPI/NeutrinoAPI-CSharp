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
    public class PhonePlaybackResponse : INotifyPropertyChanged 
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