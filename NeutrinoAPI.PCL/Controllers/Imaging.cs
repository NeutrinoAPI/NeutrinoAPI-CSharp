/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io ).
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
        /// <param name="width">Required parameter: The width to resize to (in px) while preserving aspect ratio</param>
        /// <param name="height">Required parameter: The height to resize to (in px) while preserving aspect ratio</param>
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
        /// <param name="width">Required parameter: The width to resize to (in px) while preserving aspect ratio</param>
        /// <param name="height">Required parameter: The height to resize to (in px) while preserving aspect ratio</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> ImageResizeAsync(
                string imageUrl,
                int width,
                int height,
                string format = "png")
        {
            //the base uri for api requests
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
        /// <param name="fgColor">Optional parameter: The QR code foreground color</param>
        /// <param name="bgColor">Optional parameter: The QR code background color</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream QRCode(
                string content,
                int? width = 256,
                int? height = 256,
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
        /// <param name="fgColor">Optional parameter: The QR code foreground color</param>
        /// <param name="bgColor">Optional parameter: The QR code background color</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> QRCodeAsync(
                string content,
                int? width = 256,
                int? height = 256,
                string fgColor = "#000000",
                string bgColor = "#ffffff")
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/qr-code");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "width", (null != width) ? width : 256 },
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
                new KeyValuePair<string, object>( "height", (null != height) ? height : 256 ),
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
        /// <param name="position">Optional parameter: The position of the watermark image, possible values are:<br/>center, top-left, top-center, top-right, bottom-left, bottom-center, bottom-right</param>
        /// <param name="width">Optional parameter: If set resize the resulting image to this width (in px) while preserving aspect ratio</param>
        /// <param name="height">Optional parameter: If set resize the resulting image to this height (in px) while preserving aspect ratio</param>
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
        /// <param name="position">Optional parameter: The position of the watermark image, possible values are:<br/>center, top-left, top-center, top-right, bottom-left, bottom-center, bottom-right</param>
        /// <param name="width">Optional parameter: If set resize the resulting image to this width (in px) while preserving aspect ratio</param>
        /// <param name="height">Optional parameter: If set resize the resulting image to this height (in px) while preserving aspect ratio</param>
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
            //the base uri for api requests
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
        /// Render HTML content to PDF, JPG or PNG. See: https://www.neutrinoapi.com/api/html5-render/
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
        /// <param name="renderDelay">Optional parameter: Number of milliseconds to wait before rendering the page (can be useful for pages with animations etc)</param>
        /// <param name="headerTextLeft">Optional parameter: Text to print to the left-hand side header of each page. e.g. 'My header - Page {page_number} of {total_pages}'</param>
        /// <param name="headerTextCenter">Optional parameter: Text to print to the center header of each page</param>
        /// <param name="headerTextRight">Optional parameter: Text to print to the right-hand side header of each page</param>
        /// <param name="headerSize">Optional parameter: The height of your header (in mm)</param>
        /// <param name="headerFont">Optional parameter: Set the header font. Fonts available: Times, Courier, Helvetica, Arial</param>
        /// <param name="headerFontSize">Optional parameter: Set the header font size (in pt)</param>
        /// <param name="headerLine">Optional parameter: Draw a full page width horizontal line under your header</param>
        /// <param name="footerTextLeft">Optional parameter: Text to print to the left-hand side footer of each page. e.g. 'My footer - Page {page_number} of {total_pages}'</param>
        /// <param name="footerTextCenter">Optional parameter: Text to print to the center header of each page</param>
        /// <param name="footerTextRight">Optional parameter: Text to print to the right-hand side header of each page</param>
        /// <param name="footerSize">Optional parameter: The height of your footer (in mm)</param>
        /// <param name="footerFont">Optional parameter: Set the footer font. Fonts available: Times, Courier, Helvetica, Arial</param>
        /// <param name="footerFontSize">Optional parameter: Set the footer font size (in pt)</param>
        /// <param name="footerLine">Optional parameter: Draw a full page width horizontal line above your footer</param>
        /// <param name="pageWidth">Optional parameter: Set the PDF page width explicitly (in mm)</param>
        /// <param name="pageHeight">Optional parameter: Set the PDF page height explicitly (in mm)</param>
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
                int? zoom = 1.0,
                bool? grayscale = false,
                bool? mediaPrint = false,
                bool? mediaQueries = false,
                bool? forms = false,
                string css = null,
                int? imageWidth = 1024,
                int? imageHeight = null,
                int? renderDelay = 0,
                string headerTextLeft = null,
                string headerTextCenter = null,
                string headerTextRight = null,
                int? headerSize = 9,
                string headerFont = "Courier",
                int? headerFontSize = 11,
                bool? headerLine = false,
                string footerTextLeft = null,
                string footerTextCenter = null,
                string footerTextRight = null,
                int? footerSize = 9,
                string footerFont = "Courier",
                int? footerFontSize = 11,
                bool? footerLine = false,
                int? pageWidth = null,
                int? pageHeight = null)
        {
            Task<Stream> t = HTML5RenderAsync(content, format, pageSize, title, margin, marginLeft, marginRight, marginTop, marginBottom, landscape, zoom, grayscale, mediaPrint, mediaQueries, forms, css, imageWidth, imageHeight, renderDelay, headerTextLeft, headerTextCenter, headerTextRight, headerSize, headerFont, headerFontSize, headerLine, footerTextLeft, footerTextCenter, footerTextRight, footerSize, footerFont, footerFontSize, footerLine, pageWidth, pageHeight);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Render HTML content to PDF, JPG or PNG. See: https://www.neutrinoapi.com/api/html5-render/
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
        /// <param name="renderDelay">Optional parameter: Number of milliseconds to wait before rendering the page (can be useful for pages with animations etc)</param>
        /// <param name="headerTextLeft">Optional parameter: Text to print to the left-hand side header of each page. e.g. 'My header - Page {page_number} of {total_pages}'</param>
        /// <param name="headerTextCenter">Optional parameter: Text to print to the center header of each page</param>
        /// <param name="headerTextRight">Optional parameter: Text to print to the right-hand side header of each page</param>
        /// <param name="headerSize">Optional parameter: The height of your header (in mm)</param>
        /// <param name="headerFont">Optional parameter: Set the header font. Fonts available: Times, Courier, Helvetica, Arial</param>
        /// <param name="headerFontSize">Optional parameter: Set the header font size (in pt)</param>
        /// <param name="headerLine">Optional parameter: Draw a full page width horizontal line under your header</param>
        /// <param name="footerTextLeft">Optional parameter: Text to print to the left-hand side footer of each page. e.g. 'My footer - Page {page_number} of {total_pages}'</param>
        /// <param name="footerTextCenter">Optional parameter: Text to print to the center header of each page</param>
        /// <param name="footerTextRight">Optional parameter: Text to print to the right-hand side header of each page</param>
        /// <param name="footerSize">Optional parameter: The height of your footer (in mm)</param>
        /// <param name="footerFont">Optional parameter: Set the footer font. Fonts available: Times, Courier, Helvetica, Arial</param>
        /// <param name="footerFontSize">Optional parameter: Set the footer font size (in pt)</param>
        /// <param name="footerLine">Optional parameter: Draw a full page width horizontal line above your footer</param>
        /// <param name="pageWidth">Optional parameter: Set the PDF page width explicitly (in mm)</param>
        /// <param name="pageHeight">Optional parameter: Set the PDF page height explicitly (in mm)</param>
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
                int? zoom = 1.0,
                bool? grayscale = false,
                bool? mediaPrint = false,
                bool? mediaQueries = false,
                bool? forms = false,
                string css = null,
                int? imageWidth = 1024,
                int? imageHeight = null,
                int? renderDelay = 0,
                string headerTextLeft = null,
                string headerTextCenter = null,
                string headerTextRight = null,
                int? headerSize = 9,
                string headerFont = "Courier",
                int? headerFontSize = 11,
                bool? headerLine = false,
                string footerTextLeft = null,
                string footerTextCenter = null,
                string footerTextRight = null,
                int? footerSize = 9,
                string footerFont = "Courier",
                int? footerFontSize = 11,
                bool? footerLine = false,
                int? pageWidth = null,
                int? pageHeight = null)
        {
            //the base uri for api requests
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
                new KeyValuePair<string, object>( "image-height", imageHeight ),
                new KeyValuePair<string, object>( "render-delay", (null != renderDelay) ? renderDelay : 0 ),
                new KeyValuePair<string, object>( "header-text-left", headerTextLeft ),
                new KeyValuePair<string, object>( "header-text-center", headerTextCenter ),
                new KeyValuePair<string, object>( "header-text-right", headerTextRight ),
                new KeyValuePair<string, object>( "header-size", (null != headerSize) ? headerSize : 9 ),
                new KeyValuePair<string, object>( "header-font", (null != headerFont) ? headerFont : "Courier" ),
                new KeyValuePair<string, object>( "header-font-size", (null != headerFontSize) ? headerFontSize : 11 ),
                new KeyValuePair<string, object>( "header-line", (null != headerLine) ? headerLine : false ),
                new KeyValuePair<string, object>( "footer-text-left", footerTextLeft ),
                new KeyValuePair<string, object>( "footer-text-center", footerTextCenter ),
                new KeyValuePair<string, object>( "footer-text-right", footerTextRight ),
                new KeyValuePair<string, object>( "footer-size", (null != footerSize) ? footerSize : 9 ),
                new KeyValuePair<string, object>( "footer-font", (null != footerFont) ? footerFont : "Courier" ),
                new KeyValuePair<string, object>( "footer-font-size", (null != footerFontSize) ? footerFontSize : 11 ),
                new KeyValuePair<string, object>( "footer-line", (null != footerLine) ? footerLine : false ),
                new KeyValuePair<string, object>( "page-width", pageWidth ),
                new KeyValuePair<string, object>( "page-height", pageHeight )
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