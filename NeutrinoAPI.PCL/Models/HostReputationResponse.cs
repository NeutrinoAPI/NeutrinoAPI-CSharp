/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io ).
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
        private string host;

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
        /// An array of objects for each DNSBL checked, with the following keys: <ul> <li>is-listed - true if listed, false if not</li> <li>list-name - the name of the DNSBL</li> <li>list-host - the domain/hostname of the DNSBL</li> <li>list-rating - the list rating [1-3] with 1 being the best rating and 3 the lowest rating</li> <li>txt-record - the TXT record returned for this listing (if listed)</li> <li>return-code - the specific return code for this listing (if listed)</li> <li>response-time - the DNSBL server response time in milliseconds</li> </ul>
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
        /// The number of DNSBLs the host is listed on
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

        /// <summary>
        /// The IP address or host name
        /// </summary>
        [JsonProperty("host")]
        public string Host 
        { 
            get 
            {
                return this.host; 
            } 
            set 
            {
                this.host = value;
                onPropertyChanged("Host");
            }
        }
    }
} 