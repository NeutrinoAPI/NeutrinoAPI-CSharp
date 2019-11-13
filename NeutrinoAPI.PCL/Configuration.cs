using System.Collections.Generic;
using System.Text;
using NeutrinoAPI.Utilities;
using NeutrinoAPI.Models;
namespace NeutrinoAPI
{
    public partial class Configuration
    {


        public enum Environments
        {
            //Multicloud endpoint
            MULTICLOUD,
            //AWS endpoint
            AWS,
            //GCP endpoint
            GCP,
            //MS Azure endpoint
            MSA,
        }
        public enum Servers
        {
            ENUM_DEFAULT,
        }

        //The current environment being used
        public static Environments Environment = Environments.MULTICLOUD;

        //Your user ID
        //TODO: Replace the UserId with an appropriate value
        public static string UserId = "";

        //Your API key
        //TODO: Replace the ApiKey with an appropriate value
        public static string ApiKey = "";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.MULTICLOUD,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://neutrinoapi.net/" },
                    }
                },
                { 
                    Environments.AWS,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://aws.neutrinoapi.net/" },
                    }
                },
                { 
                    Environments.GCP,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://gcp.neutrinoapi.net/" },
                    }
                },
                { 
                    Environments.MSA,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://msa.neutrinoapi.net/" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.ENUM_DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}