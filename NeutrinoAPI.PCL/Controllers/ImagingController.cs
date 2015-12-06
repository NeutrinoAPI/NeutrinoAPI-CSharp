/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 12/06/2015
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeutrinoAPI.PCL;
using NeutrinoAPI.PCL.Http.Request;
using NeutrinoAPI.PCL.Http.Response;
using NeutrinoAPI.PCL.Http.Client;

using NeutrinoAPI.PCL.Models;

namespace NeutrinoAPI.PCL.Controllers
{
    public partial class ImagingController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ImagingController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ImagingController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ImagingController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Generate a QR code as a PNG image. See: https://www.neutrinoapi.com/api/qr-code/
        /// </summary>
        /// <param name="content">Required parameter: The content to encode into the QR code (e.g. a URL or a phone number)</param>
        /// <param name="bgColor">Optional parameter: The QR code background color (you should always use a light color for this)</param>
        /// <param name="fgColor">Optional parameter: The QR code foreground color (you should always use a dark color for this)</param>
        /// <param name="height">Optional parameter: The height of the QR code (in px)</param>
        /// <param name="width">Optional parameter: The width of the QR code (in px)</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream CreateQRCode(
                string content,
                string bgColor = null,
                string fgColor = null,
                int? height = null,
                int? width = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/qr-code");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "width", (null != width) ? width : 250 },
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"}
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                {"content", content},
                {"bg-color", (null != bgColor) ? bgColor : "#ffffff"},
                {"fg-color", (null != fgColor) ? fgColor : "#000000"},
                {"height", (null != height) ? height : 250}
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = ClientInstance.ExecuteAsBinary(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Convert HTML content into PDF documents. See: https://www.neutrinoapi.com/api/html-to-pdf/
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="htmlWidth">Optional parameter: The width (in px) to render the HTML document at</param>
        /// <param name="margin">Optional parameter: The PDF document margin (in mm)</param>
        /// <param name="title">Optional parameter: The PDF document title</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream CreateHTMLToPDF(
                string content,
                int? htmlWidth = null,
                int? margin = null,
                string title = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/html-to-pdf");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"}
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                {"content", content},
                {"html-width", (null != htmlWidth) ? htmlWidth : 1024},
                {"margin", (null != margin) ? margin : 10},
                {"title", title}
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = ClientInstance.ExecuteAsBinary(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Resize an image and output as either JPEG or PNG. See: https://www.neutrinoapi.com/api/image-resize/
        /// </summary>
        /// <param name="height">Required parameter: Height to resize to (in px)</param>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="width">Required parameter: Width to resize to (in px)</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream CreateImageResize(
                int height,
                string imageUrl,
                int width,
                string format = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/image-resize");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"}
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                {"height", height},
                {"image-url", imageUrl},
                {"width", width},
                {"format", (null != format) ? format : "png"}
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = ClientInstance.ExecuteAsBinary(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Watermark one image with another image. See: https://www.neutrinoapi.com/api/image-watermark/
        /// </summary>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="watermarkUrl">Required parameter: The URL to the watermark image</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <param name="height">Optional parameter: If set resize the resulting image to this height (preserving aspect ratio)</param>
        /// <param name="opacity">Optional parameter: The opacity of the watermark (0 to 100)</param>
        /// <param name="position">Optional parameter: The position of the watermark image, possible values are: center, top-left, top-center, top-right, bottom-left, bottom-center, bottom-right</param>
        /// <param name="width">Optional parameter: If set resize the resulting image to this width (preserving aspect ratio)</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream CreateImageWatermark(
                string imageUrl,
                string watermarkUrl,
                string format = null,
                int? height = null,
                int? opacity = null,
                string position = null,
                int? width = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/image-watermark");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"}
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                {"image-url", imageUrl},
                {"watermark-url", watermarkUrl},
                {"format", (null != format) ? format : "png"},
                {"height", height},
                {"opacity", (null != opacity) ? opacity : 50},
                {"position", (null != position) ? position : "center"},
                {"width", width}
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = ClientInstance.ExecuteAsBinary(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 