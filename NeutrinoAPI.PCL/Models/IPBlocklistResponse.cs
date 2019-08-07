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
    public class IPBlocklistResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string ip;
        private bool isBot;
        private bool isExploitBot;
        private bool isMalware;
        private bool isSpider;
        private bool isDshield;
        private int listCount;
        private bool isProxy;
        private bool isHijacked;
        private bool isTor;
        private bool isSpyware;
        private bool isSpamBot;
        private bool isListed;
        private bool isVpn;
        private int lastSeen;
        private List<string> blocklists;
        private List<string> sensors;

        /// <summary>
        /// The IP address
        /// </summary>
        [JsonProperty("ip")]
        public string Ip 
        { 
            get 
            {
                return this.ip; 
            } 
            set 
            {
                this.ip = value;
                onPropertyChanged("Ip");
            }
        }

        /// <summary>
        /// IP is hosting a malicious bot or is part of a botnet. Includes brute-force crackers
        /// </summary>
        [JsonProperty("isBot")]
        public bool IsBot 
        { 
            get 
            {
                return this.isBot; 
            } 
            set 
            {
                this.isBot = value;
                onPropertyChanged("IsBot");
            }
        }

        /// <summary>
        /// IP is hosting an exploit finding bot or is running exploit scanning software
        /// </summary>
        [JsonProperty("isExploitBot")]
        public bool IsExploitBot 
        { 
            get 
            {
                return this.isExploitBot; 
            } 
            set 
            {
                this.isExploitBot = value;
                onPropertyChanged("IsExploitBot");
            }
        }

        /// <summary>
        /// IP is involved in distributing or is running malware
        /// </summary>
        [JsonProperty("isMalware")]
        public bool IsMalware 
        { 
            get 
            {
                return this.isMalware; 
            } 
            set 
            {
                this.isMalware = value;
                onPropertyChanged("IsMalware");
            }
        }

        /// <summary>
        /// IP is running a hostile web spider / web crawler
        /// </summary>
        [JsonProperty("isSpider")]
        public bool IsSpider 
        { 
            get 
            {
                return this.isSpider; 
            } 
            set 
            {
                this.isSpider = value;
                onPropertyChanged("IsSpider");
            }
        }

        /// <summary>
        /// IP has been flagged as an attack source on DShield (dshield.org)
        /// </summary>
        [JsonProperty("isDshield")]
        public bool IsDshield 
        { 
            get 
            {
                return this.isDshield; 
            } 
            set 
            {
                this.isDshield = value;
                onPropertyChanged("IsDshield");
            }
        }

        /// <summary>
        /// The number of blocklists the IP is listed on
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
        /// IP has been detected as an anonymous web proxy or anonymous HTTP proxy
        /// </summary>
        [JsonProperty("isProxy")]
        public bool IsProxy 
        { 
            get 
            {
                return this.isProxy; 
            } 
            set 
            {
                this.isProxy = value;
                onPropertyChanged("IsProxy");
            }
        }

        /// <summary>
        /// IP is part of a hijacked netblock or a netblock controlled by a criminal organization
        /// </summary>
        [JsonProperty("isHijacked")]
        public bool IsHijacked 
        { 
            get 
            {
                return this.isHijacked; 
            } 
            set 
            {
                this.isHijacked = value;
                onPropertyChanged("IsHijacked");
            }
        }

        /// <summary>
        /// IP is a Tor node or running a Tor related service
        /// </summary>
        [JsonProperty("isTor")]
        public bool IsTor 
        { 
            get 
            {
                return this.isTor; 
            } 
            set 
            {
                this.isTor = value;
                onPropertyChanged("IsTor");
            }
        }

        /// <summary>
        /// IP is involved in distributing or is running spyware
        /// </summary>
        [JsonProperty("isSpyware")]
        public bool IsSpyware 
        { 
            get 
            {
                return this.isSpyware; 
            } 
            set 
            {
                this.isSpyware = value;
                onPropertyChanged("IsSpyware");
            }
        }

        /// <summary>
        /// IP address is hosting a spam bot, comment spamming or any other spamming type software
        /// </summary>
        [JsonProperty("isSpamBot")]
        public bool IsSpamBot 
        { 
            get 
            {
                return this.isSpamBot; 
            } 
            set 
            {
                this.isSpamBot = value;
                onPropertyChanged("IsSpamBot");
            }
        }

        /// <summary>
        /// Is this IP on a blocklist
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
        /// IP has been detected as belonging to a VPN provider
        /// </summary>
        [JsonProperty("isVpn")]
        public bool IsVpn 
        { 
            get 
            {
                return this.isVpn; 
            } 
            set 
            {
                this.isVpn = value;
                onPropertyChanged("IsVpn");
            }
        }

        /// <summary>
        /// The last time this IP was seen on a blocklist (in Unix time or 0 if not listed recently)
        /// </summary>
        [JsonProperty("lastSeen")]
        public int LastSeen 
        { 
            get 
            {
                return this.lastSeen; 
            } 
            set 
            {
                this.lastSeen = value;
                onPropertyChanged("LastSeen");
            }
        }

        /// <summary>
        /// An array of strings indicating which blocklists this IP is listed on (empty if not listed)
        /// </summary>
        [JsonProperty("blocklists")]
        public List<string> Blocklists 
        { 
            get 
            {
                return this.blocklists; 
            } 
            set 
            {
                this.blocklists = value;
                onPropertyChanged("Blocklists");
            }
        }

        /// <summary>
        /// An array of objects containing details on which sensors were used to detect this IP
        /// </summary>
        [JsonProperty("sensors")]
        public List<string> Sensors 
        { 
            get 
            {
                return this.sensors; 
            } 
            set 
            {
                this.sensors = value;
                onPropertyChanged("Sensors");
            }
        }
    }
} 