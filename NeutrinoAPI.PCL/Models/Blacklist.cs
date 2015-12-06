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
    public class Blacklist : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool isListed;
        private string listHost;
        private int listRating;
        private string listName;
        private string txtRecord;

        /// <summary>
        /// true if listed, false if not
        /// </summary>
        [JsonProperty("isListed")]
        public bool IsListed 
        { 
            get 
            {
                return this.isListed; 
            } 
            set 
            {
                this.isListed = value;
                onPropertyChanged("IsListed");
            }
        }

        /// <summary>
        /// the domain/hostname of the DNSBL
        /// </summary>
        [JsonProperty("listHost")]
        public string ListHost 
        { 
            get 
            {
                return this.listHost; 
            } 
            set 
            {
                this.listHost = value;
                onPropertyChanged("ListHost");
            }
        }

        /// <summary>
        /// the list rating [1-3] with 1 being the best rating and 3 the lowest rating
        /// </summary>
        [JsonProperty("listRating")]
        public int ListRating 
        { 
            get 
            {
                return this.listRating; 
            } 
            set 
            {
                this.listRating = value;
                onPropertyChanged("ListRating");
            }
        }

        /// <summary>
        /// the name of the DNSBL
        /// </summary>
        [JsonProperty("listName")]
        public string ListName 
        { 
            get 
            {
                return this.listName; 
            } 
            set 
            {
                this.listName = value;
                onPropertyChanged("ListName");
            }
        }

        /// <summary>
        /// the TXT record returned for this listing (if listed)
        /// </summary>
        [JsonProperty("txtRecord")]
        public string TxtRecord 
        { 
            get 
            {
                return this.txtRecord; 
            } 
            set 
            {
                this.txtRecord = value;
                onPropertyChanged("TxtRecord");
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