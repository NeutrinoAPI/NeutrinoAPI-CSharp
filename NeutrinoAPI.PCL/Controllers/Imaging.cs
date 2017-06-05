/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using NeutrinoAPI;
using NeutrinoAPI.Utilities;
using NeutrinoAPI.Http.Request;
using NeutrinoAPI.Http.Response;
using NeutrinoAPI.Http.Client;
using NeutrinoAPI.Exceptions;
using NeutrinoAPI.Models;

namespace NeutrinoAPI.Controllers
{
    public partial class Imaging: BaseController, IImaging
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static Imaging instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static Imaging Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new Imaging();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Resize an image and output as either JPEG or PNG. See: https://www.neutrinoapi.com/api/image-resize/
        /// </summary>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="width">Required parameter: Width to resize to (in px)</param>
        /// <param name="height">Required parameter: Height to resize to (in px)</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream ImageResize(
                string imageUrl,
                int width,
                int height,
                string format = "png")
        {
            Task<Stream> t = ImageResizeAsync(imageUrl, width, height, format);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Resize an image and output as either JPEG or PNG. See: https://www.neutrinoapi.com/api/image-resize/
        /// </summary>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="width">Required parameter: Width to resize to (in px)</param>
        /// <param name="height">Required parameter: Height to resize to (in px)</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> ImageResizeAsync(
                string imageUrl,
                int width,
                int height,
                string format = "png")
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
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "image-url", imageUrl ),
                new KeyValuePair<string, object>( "width", width ),
                new KeyValuePair<string, object>( "height", height ),
                new KeyValuePair<string, object>( "format", (null != format) ? format : "png" )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Generate a QR code as a PNG image. See: https://www.neutrinoapi.com/api/qr-code/
        /// </summary>
        /// <param name="content">Required parameter: The content to encode into the QR code (e.g. a URL or a phone number)</param>
        /// <param name="width">Optional parameter: The width of the QR code (in px)</param>
        /// <param name="height">Optional parameter: The height of the QR code (in px)</param>
        /// <param name="fgColor">Optional parameter: The QR code foreground color (you should always use a dark color for this)</param>
        /// <param name="bgColor">Optional parameter: The QR code background color (you should always use a light color for this)</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream QRCode(
                string content,
                int? width = 250,
                int? height = 250,
                string fgColor = "#000000",
                string bgColor = "#ffffff")
        {
            Task<Stream> t = QRCodeAsync(content, width, height, fgColor, bgColor);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Generate a QR code as a PNG image. See: https://www.neutrinoapi.com/api/qr-code/
        /// </summary>
        /// <param name="content">Required parameter: The content to encode into the QR code (e.g. a URL or a phone number)</param>
        /// <param name="width">Optional parameter: The width of the QR code (in px)</param>
        /// <param name="height">Optional parameter: The height of the QR code (in px)</param>
        /// <param name="fgColor">Optional parameter: The QR code foreground color (you should always use a dark color for this)</param>
        /// <param name="bgColor">Optional parameter: The QR code background color (you should always use a light color for this)</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> QRCodeAsync(
                string content,
                int? width = 250,
                int? height = 250,
                string fgColor = "#000000",
                string bgColor = "#ffffff")
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
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "content", content ),
                new KeyValuePair<string, object>( "height", (null != height) ? height : 250 ),
                new KeyValuePair<string, object>( "fg-color", (null != fgColor) ? fgColor : "#000000" ),
                new KeyValuePair<string, object>( "bg-color", (null != bgColor) ? bgColor : "#ffffff" )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Watermark one image with another image. See: https://www.neutrinoapi.com/api/image-watermark/
        /// </summary>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="watermarkUrl">Required parameter: The URL to the watermark image</param>
        /// <param name="opacity">Optional parameter: The opacity of the watermark (0 to 100)</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <param name="position">Optional parameter: The position of the watermark image, possible values are: center, top-left, top-center, top-right, bottom-left, bottom-center, bottom-right</param>
        /// <param name="width">Optional parameter: If set resize the resulting image to this width (preserving aspect ratio)</param>
        /// <param name="height">Optional parameter: If set resize the resulting image to this height (preserving aspect ratio)</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream ImageWatermark(
                string imageUrl,
                string watermarkUrl,
                int? opacity = 50,
                string format = "png",
                string position = "center",
                int? width = null,
                int? height = null)
        {
            Task<Stream> t = ImageWatermarkAsync(imageUrl, watermarkUrl, opacity, format, position, width, height);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Watermark one image with another image. See: https://www.neutrinoapi.com/api/image-watermark/
        /// </summary>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="watermarkUrl">Required parameter: The URL to the watermark image</param>
        /// <param name="opacity">Optional parameter: The opacity of the watermark (0 to 100)</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <param name="position">Optional parameter: The position of the watermark image, possible values are: center, top-left, top-center, top-right, bottom-left, bottom-center, bottom-right</param>
        /// <param name="width">Optional parameter: If set resize the resulting image to this width (preserving aspect ratio)</param>
        /// <param name="height">Optional parameter: If set resize the resulting image to this height (preserving aspect ratio)</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> ImageWatermarkAsync(
                string imageUrl,
                string watermarkUrl,
                int? opacity = 50,
                string format = "png",
                string position = "center",
                int? width = null,
                int? height = null)
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
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "image-url", imageUrl ),
                new KeyValuePair<string, object>( "watermark-url", watermarkUrl ),
                new KeyValuePair<string, object>( "opacity", (null != opacity) ? opacity : 50 ),
                new KeyValuePair<string, object>( "format", (null != format) ? format : "png" ),
                new KeyValuePair<string, object>( "position", (null != position) ? position : "center" ),
                new KeyValuePair<string, object>( "width", width ),
                new KeyValuePair<string, object>( "height", height )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Render HTML and HTML5 content to PDF, JPG or PNG
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="format">Optional parameter: Which format to output, available options are: PDF, PNG, JPG</param>
        /// <param name="pageSize">Optional parameter: Set the document page size, can be one of: A0 - A9, B0 - B10, Comm10E, DLE or Letter</param>
        /// <param name="title">Optional parameter: The document title</param>
        /// <param name="margin">Optional parameter: The document margin (in mm)</param>
        /// <param name="marginLeft">Optional parameter: The document left margin (in mm)</param>
        /// <param name="marginRight">Optional parameter: The document right margin (in mm)</param>
        /// <param name="marginTop">Optional parameter: The document top margin (in mm)</param>
        /// <param name="marginBottom">Optional parameter: The document bottom margin (in mm)</param>
        /// <param name="landscape">Optional parameter: Set the document to lanscape orientation</param>
        /// <param name="zoom">Optional parameter: Set the zoom factor when rendering the page (2.0 for double size, 0.5 for half size)</param>
        /// <param name="grayscale">Optional parameter: Render the final document in grayscale</param>
        /// <param name="mediaPrint">Optional parameter: Use @media print CSS styles to render the document</param>
        /// <param name="mediaQueries">Optional parameter: Activate all @media queries before rendering. This can be useful if you wan't to render the mobile version of a responsive website</param>
        /// <param name="forms">Optional parameter: Generate real (fillable) PDF forms from HTML forms</param>
        /// <param name="css">Optional parameter: Inject custom CSS into the HTML. e.g. 'body { background-color: red;}'</param>
        /// <param name="imageWidth">Optional parameter: If rendering to an image format (PNG or JPG) use this image width (in pixels)</param>
        /// <param name="imageHeight">Optional parameter: If rendering to an image format (PNG or JPG) use this image height (in pixels). The default is automatic which dynamically sets the image height based on the content</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream HTML5Render(
                string content,
                string format = "PDF",
                string pageSize = "A4",
                string title = null,
                int? margin = 0,
                int? marginLeft = 0,
                int? marginRight = 0,
                int? marginTop = 0,
                int? marginBottom = 0,
                bool? landscape = false,
                double? zoom = 1.0,
                bool? grayscale = false,
                bool? mediaPrint = false,
                bool? mediaQueries = false,
                bool? forms = false,
                string css = null,
                int? imageWidth = 1024,
                int? imageHeight = null)
        {
            Task<Stream> t = HTML5RenderAsync(content, format, pageSize, title, margin, marginLeft, marginRight, marginTop, marginBottom, landscape, zoom, grayscale, mediaPrint, mediaQueries, forms, css, imageWidth, imageHeight);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Render HTML and HTML5 content to PDF, JPG or PNG
        /// </summary>
        /// <param name="content">Required parameter: The HTML content. This can be either a URL to load HTML from or an actual HTML content string</param>
        /// <param name="format">Optional parameter: Which format to output, available options are: PDF, PNG, JPG</param>
        /// <param name="pageSize">Optional parameter: Set the document page size, can be one of: A0 - A9, B0 - B10, Comm10E, DLE or Letter</param>
        /// <param name="title">Optional parameter: The document title</param>
        /// <param name="margin">Optional parameter: The document margin (in mm)</param>
        /// <param name="marginLeft">Optional parameter: The document left margin (in mm)</param>
        /// <param name="marginRight">Optional parameter: The document right margin (in mm)</param>
        /// <param name="marginTop">Optional parameter: The document top margin (in mm)</param>
        /// <param name="marginBottom">Optional parameter: The document bottom margin (in mm)</param>
        /// <param name="landscape">Optional parameter: Set the document to lanscape orientation</param>
        /// <param name="zoom">Optional parameter: Set the zoom factor when rendering the page (2.0 for double size, 0.5 for half size)</param>
        /// <param name="grayscale">Optional parameter: Render the final document in grayscale</param>
        /// <param name="mediaPrint">Optional parameter: Use @media print CSS styles to render the document</param>
        /// <param name="mediaQueries">Optional parameter: Activate all @media queries before rendering. This can be useful if you wan't to render the mobile version of a responsive website</param>
        /// <param name="forms">Optional parameter: Generate real (fillable) PDF forms from HTML forms</param>
        /// <param name="css">Optional parameter: Inject custom CSS into the HTML. e.g. 'body { background-color: red;}'</param>
        /// <param name="imageWidth">Optional parameter: If rendering to an image format (PNG or JPG) use this image width (in pixels)</param>
        /// <param name="imageHeight">Optional parameter: If rendering to an image format (PNG or JPG) use this image height (in pixels). The default is automatic which dynamically sets the image height based on the content</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> HTML5RenderAsync(
                string content,
                string format = "PDF",
                string pageSize = "A4",
                string title = null,
                int? margin = 0,
                int? marginLeft = 0,
                int? marginRight = 0,
                int? marginTop = 0,
                int? marginBottom = 0,
                bool? landscape = false,
                double? zoom = 1.0,
                bool? grayscale = false,
                bool? mediaPrint = false,
                bool? mediaQueries = false,
                bool? forms = false,
                string css = null,
                int? imageWidth = 1024,
                int? imageHeight = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/html5-render");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "user-id", Configuration.UserId },
                { "api-key", Configuration.ApiKey }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "output-case", "camel" ),
                new KeyValuePair<string, object>( "content", content ),
                new KeyValuePair<string, object>( "format", (null != format) ? format : "PDF" ),
                new KeyValuePair<string, object>( "page-size", (null != pageSize) ? pageSize : "A4" ),
                new KeyValuePair<string, object>( "title", title ),
                new KeyValuePair<string, object>( "margin", (null != margin) ? margin : 0 ),
                new KeyValuePair<string, object>( "margin-left", (null != marginLeft) ? marginLeft : 0 ),
                new KeyValuePair<string, object>( "margin-right", (null != marginRight) ? marginRight : 0 ),
                new KeyValuePair<string, object>( "margin-top", (null != marginTop) ? marginTop : 0 ),
                new KeyValuePair<string, object>( "margin-bottom", (null != marginBottom) ? marginBottom : 0 ),
                new KeyValuePair<string, object>( "landscape", (null != landscape) ? landscape : false ),
                new KeyValuePair<string, object>( "zoom", (null != zoom) ? zoom : 1.0 ),
                new KeyValuePair<string, object>( "grayscale", (null != grayscale) ? grayscale : false ),
                new KeyValuePair<string, object>( "media-print", (null != mediaPrint) ? mediaPrint : false ),
                new KeyValuePair<string, object>( "media-queries", (null != mediaQueries) ? mediaQueries : false ),
                new KeyValuePair<string, object>( "forms", (null != forms) ? forms : false ),
                new KeyValuePair<string, object>( "css", css ),
                new KeyValuePair<string, object>( "image-width", (null != imageWidth) ? imageWidth : 1024 ),
                new KeyValuePair<string, object>( "image-height", imageHeight )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 