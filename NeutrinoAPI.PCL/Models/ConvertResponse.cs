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
    public class ConvertResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private string result;
        private string fromValue;
        private string toType;
        private string fromType;

        /// <summary>
        /// Was the coversion successful and produced a valid result
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
        /// The result of the conversion
        /// </summary>
        [JsonProperty("result")]
        public string Result 
        { 
            get 
            {
                return this.result; 
            } 
            set 
            {
                this.result = value;
                onPropertyChanged("Result");
            }
        }

        /// <summary>
        /// The value being converted from
        /// </summary>
        [JsonProperty("fromValue")]
        public string FromValue 
        { 
            get 
            {
                return this.fromValue; 
            } 
            set 
            {
                this.fromValue = value;
                onPropertyChanged("FromValue");
            }
        }

        /// <summary>
        /// The type being converted to
        /// </summary>
        [JsonProperty("toType")]
        public string ToType 
        { 
            get 
            {
                return this.toType; 
            } 
            set 
            {
                this.toType = value;
                onPropertyChanged("ToType");
            }
        }

        /// <summary>
        /// The type of the value being converted from
        /// </summary>
        [JsonProperty("fromType")]
        public string FromType 
        { 
            get 
            {
                return this.fromType; 
            } 
            set 
            {
                this.fromType = value;
                onPropertyChanged("FromType");
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