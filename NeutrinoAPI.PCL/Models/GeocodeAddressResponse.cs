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
    public class GeocodeAddressResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int found;
        private List<Location> locations;

        /// <summary>
        /// The number of possible matching locations found
        /// </summary>
        [JsonProperty("found")]
        public int Found 
        { 
            get 
            {
                return this.found; 
            } 
            set 
            {
                this.found = value;
                onPropertyChanged("Found");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("locations")]
        public List<Location> Locations 
        { 
            get 
            {
                return this.locations; 
            } 
            set 
            {
                this.locations = value;
                onPropertyChanged("Locations");
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