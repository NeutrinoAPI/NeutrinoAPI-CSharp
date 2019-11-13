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
    public class IPProbeResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool valid;
        private string country;
        private string providerType;
        private string countryCode;
        private string hostname;
        private string providerDomain;
        private string city;
        private string providerWebsite;
        private string ip;
        private string region;
        private string providerDescription;
        private string continentCode;
        private bool isHosting;
        private bool isIsp;
        private string countryCode3;
        private string currencyCode;
        private bool isVpn;
        private bool isProxy;
        private string asn;
        private string asCidr;
        private string asCountryCode;
        private string asCountryCode3;
        private List<string> asDomains;
        private string asDescription;
        private int asAge;
        private string hostDomain;
        private string vpnDomain;

        /// <summary>
        /// Is this a valid IPv4 or IPv6 address
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
        /// Full country name
        /// </summary>
        [JsonProperty("country")]
        public string Country 
        { 
            get 
            {
                return this.country; 
            } 
            set 
            {
                this.country = value;
                onPropertyChanged("Country");
            }
        }

        /// <summary>
        /// The detected provider type, possible values are: <ul> <li>isp - IP belongs to an internet service provider. This includes both mobile, home and business internet providers</li> <li>hosting - IP belongs to a hosting company. This includes website hosting, cloud computing platforms and colocation facilities</li> <li>vpn - IP belongs to a VPN provider</li> <li>proxy - IP belongs to a proxy service. This includes HTTP/SOCKS proxies and browser based proxies</li> <li>university - IP belongs to a university/college/campus</li> <li>government - IP belongs to a government department. This includes military facilities</li> <li>commercial - IP belongs to a commercial entity such as a corporate headquarters or company office</li> <li>unknown - could not identify the provider type</li> </ul>
        /// </summary>
        [JsonProperty("providerType")]
        public string ProviderType 
        { 
            get 
            {
                return this.providerType; 
            } 
            set 
            {
                this.providerType = value;
                onPropertyChanged("ProviderType");
            }
        }

        /// <summary>
        /// ISO 2-letter country code
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode 
        { 
            get 
            {
                return this.countryCode; 
            } 
            set 
            {
                this.countryCode = value;
                onPropertyChanged("CountryCode");
            }
        }

        /// <summary>
        /// The IPs full hostname (PTR)
        /// </summary>
        [JsonProperty("hostname")]
        public string Hostname 
        { 
            get 
            {
                return this.hostname; 
            } 
            set 
            {
                this.hostname = value;
                onPropertyChanged("Hostname");
            }
        }

        /// <summary>
        /// The domain name of the provider
        /// </summary>
        [JsonProperty("providerDomain")]
        public string ProviderDomain 
        { 
            get 
            {
                return this.providerDomain; 
            } 
            set 
            {
                this.providerDomain = value;
                onPropertyChanged("ProviderDomain");
            }
        }

        /// <summary>
        /// Full city name (if detectable)
        /// </summary>
        [JsonProperty("city")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// The website URL for the provider
        /// </summary>
        [JsonProperty("providerWebsite")]
        public string ProviderWebsite 
        { 
            get 
            {
                return this.providerWebsite; 
            } 
            set 
            {
                this.providerWebsite = value;
                onPropertyChanged("ProviderWebsite");
            }
        }

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
        /// Full region name (if detectable)
        /// </summary>
        [JsonProperty("region")]
        public string Region 
        { 
            get 
            {
                return this.region; 
            } 
            set 
            {
                this.region = value;
                onPropertyChanged("Region");
            }
        }

        /// <summary>
        /// A description of the provider (usually extracted from the providers website)
        /// </summary>
        [JsonProperty("providerDescription")]
        public string ProviderDescription 
        { 
            get 
            {
                return this.providerDescription; 
            } 
            set 
            {
                this.providerDescription = value;
                onPropertyChanged("ProviderDescription");
            }
        }

        /// <summary>
        /// ISO 2-letter continent code
        /// </summary>
        [JsonProperty("continentCode")]
        public string ContinentCode 
        { 
            get 
            {
                return this.continentCode; 
            } 
            set 
            {
                this.continentCode = value;
                onPropertyChanged("ContinentCode");
            }
        }

        /// <summary>
        /// True if this IP belongs to a hosting company. Note that this can still be true even if the provider type is VPN/proxy, this occurs in the case that the IP is detected as both types
        /// </summary>
        [JsonProperty("isHosting")]
        public bool IsHosting 
        { 
            get 
            {
                return this.isHosting; 
            } 
            set 
            {
                this.isHosting = value;
                onPropertyChanged("IsHosting");
            }
        }

        /// <summary>
        /// True if this IP belongs to an internet service provider. Note that this can still be true even if the provider type is VPN/proxy, this occurs in the case that the IP is detected as both types
        /// </summary>
        [JsonProperty("isIsp")]
        public bool IsIsp 
        { 
            get 
            {
                return this.isIsp; 
            } 
            set 
            {
                this.isIsp = value;
                onPropertyChanged("IsIsp");
            }
        }

        /// <summary>
        /// ISO 3-letter country code
        /// </summary>
        [JsonProperty("countryCode3")]
        public string CountryCode3 
        { 
            get 
            {
                return this.countryCode3; 
            } 
            set 
            {
                this.countryCode3 = value;
                onPropertyChanged("CountryCode3");
            }
        }

        /// <summary>
        /// ISO 4217 currency code associated with the country
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// True if this IP ia a VPN
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
        /// True if this IP ia a proxy
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
        /// The autonomous system (AS) number
        /// </summary>
        [JsonProperty("asn")]
        public string Asn 
        { 
            get 
            {
                return this.asn; 
            } 
            set 
            {
                this.asn = value;
                onPropertyChanged("Asn");
            }
        }

        /// <summary>
        /// The autonomous system (AS) CIDR range
        /// </summary>
        [JsonProperty("asCidr")]
        public string AsCidr 
        { 
            get 
            {
                return this.asCidr; 
            } 
            set 
            {
                this.asCidr = value;
                onPropertyChanged("AsCidr");
            }
        }

        /// <summary>
        /// The autonomous system (AS) ISO 2-letter country code
        /// </summary>
        [JsonProperty("asCountryCode")]
        public string AsCountryCode 
        { 
            get 
            {
                return this.asCountryCode; 
            } 
            set 
            {
                this.asCountryCode = value;
                onPropertyChanged("AsCountryCode");
            }
        }

        /// <summary>
        /// The autonomous system (AS) ISO 3-letter country code
        /// </summary>
        [JsonProperty("asCountryCode3")]
        public string AsCountryCode3 
        { 
            get 
            {
                return this.asCountryCode3; 
            } 
            set 
            {
                this.asCountryCode3 = value;
                onPropertyChanged("AsCountryCode3");
            }
        }

        /// <summary>
        /// Array of all the domains associated with the autonomous system (AS)
        /// </summary>
        [JsonProperty("asDomains")]
        public List<string> AsDomains 
        { 
            get 
            {
                return this.asDomains; 
            } 
            set 
            {
                this.asDomains = value;
                onPropertyChanged("AsDomains");
            }
        }

        /// <summary>
        /// The autonomous system (AS) description / company name
        /// </summary>
        [JsonProperty("asDescription")]
        public string AsDescription 
        { 
            get 
            {
                return this.asDescription; 
            } 
            set 
            {
                this.asDescription = value;
                onPropertyChanged("AsDescription");
            }
        }

        /// <summary>
        /// The age of the autonomous system (AS) in number of years since registration
        /// </summary>
        [JsonProperty("asAge")]
        public int AsAge 
        { 
            get 
            {
                return this.asAge; 
            } 
            set 
            {
                this.asAge = value;
                onPropertyChanged("AsAge");
            }
        }

        /// <summary>
        /// The IPs host domain
        /// </summary>
        [JsonProperty("hostDomain")]
        public string HostDomain 
        { 
            get 
            {
                return this.hostDomain; 
            } 
            set 
            {
                this.hostDomain = value;
                onPropertyChanged("HostDomain");
            }
        }

        /// <summary>
        /// The domain of the VPN provider (may be empty if the VPN domain is not detectable)
        /// </summary>
        [JsonProperty("vpnDomain")]
        public string VpnDomain 
        { 
            get 
            {
                return this.vpnDomain; 
            } 
            set 
            {
                this.vpnDomain = value;
                onPropertyChanged("VpnDomain");
            }
        }
    }
} 