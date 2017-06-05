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
    public class Blacklist : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool isListed;
        private string listHost;
        private int listRating;
        private string listName;
        private string txtRecord;
        private int responseTime;

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
        /// the DNSBL server response time in milliseconds
        /// </summary>
        [JsonProperty("responseTime")]
        public int ResponseTime 
        { 
            get 
            {
                return this.responseTime; 
            } 
            set 
            {
                this.responseTime = value;
                onPropertyChanged("ResponseTime");
            }
        }
    }
} 