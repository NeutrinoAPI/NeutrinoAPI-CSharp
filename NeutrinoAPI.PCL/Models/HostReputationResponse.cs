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
    public class HostReputationResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool isListed;
        private List<Models.Blacklist> lists;
        private int listCount;

        /// <summary>
        /// Is this host blacklisted
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
        /// An array of objects for each DNSBL checked
        /// </summary>
        [JsonProperty("lists")]
        public List<Models.Blacklist> Lists 
        { 
            get 
            {
                return this.lists; 
            } 
            set 
            {
                this.lists = value;
                onPropertyChanged("Lists");
            }
        }

        /// <summary>
        /// The number of DNSBL's the host is listed on
        /// </summary>
        [JsonProperty("listCount")]
        public int ListCount 
        { 
            get 
            {
                return this.listCount; 
            } 
            set 
            {
                this.listCount = value;
                onPropertyChanged("ListCount");
            }
        }
    }
} 