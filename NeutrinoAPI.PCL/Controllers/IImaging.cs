/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeutrinoAPI;
using NeutrinoAPI.Utilities;
using NeutrinoAPI.Http.Request;
using NeutrinoAPI.Http.Response;
using NeutrinoAPI.Http.Client;
using NeutrinoAPI.Models;

namespace NeutrinoAPI.Controllers
{
    public partial interface IImaging
    {
        /// <summary>
        /// Resize an image and output as either JPEG or PNG. See: https://www.neutrinoapi.com/api/image-resize/
        /// </summary>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="width">Required parameter: Width to resize to (in px)</param>
        /// <param name="height">Required parameter: Height to resize to (in px)</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <return>Returns the Stream response from the API call</return>
        Stream ImageResize(
                string imageUrl,
                int width,
                int height,
                string format = "png");

        /// <summary>
        /// Resize an image and output as either JPEG or PNG. See: https://www.neutrinoapi.com/api/image-resize/
        /// </summary>
        /// <param name="imageUrl">Required parameter: The URL to the source image</param>
        /// <param name="width">Required parameter: Width to resize to (in px)</param>
        /// <param name="height">Required parameter: Height to resize to (in px)</param>
        /// <param name="format">Optional parameter: The output image format, can be either png or jpg</param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> ImageResizeAsync(
                string imageUrl,
                int width,
                int height,
                string format = "png");

        /// <summary>
        /// Generate a QR code as a PNG image. See: https://www.neutrinoapi.com/api/qr-code/
        /// </summary>
        /// <param name="content">Required parameter: The content to encode into the QR code (e.g. a URL or a phone number)</param>
        /// <param name="width">Optional parameter: The width of the QR code (in px)</param>
        /// <param name="height">Optional parameter: The height of the QR code (in px)</param>
        /// <param name="fgColor">Optional parameter: The QR code foreground color (you should always use a dark color for this)</param>
        /// <param name="bgColor">Optional parameter: The QR code background color (you should always use a light color for this)</param>
        /// <return>Returns the Stream response from the API call</return>
        Stream QRCode(
                string content,
                int? width = 250,
                int? height = 250,
                string fgColor = "#000000",
                string bgColor = "#ffffff");

        /// <summary>
        /// Generate a QR code as a PNG image. See: https://www.neutrinoapi.com/api/qr-code/
        /// </summary>
        /// <param name="content">Required parameter: The content to encode into the QR code (e.g. a URL or a phone number)</param>
        /// <param name="width">Optional parameter: The width of the QR code (in px)</param>
        /// <param name="height">Optional parameter: The height of the QR code (in px)</param>
        /// <param name="fgColor">Optional parameter: The QR code foreground color (you should always use a dark color for this)</param>
        /// <param name="bgColor">Optional parameter: The QR code background color (you should always use a light color for this)</param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> QRCodeAsync(
                string content,
                int? width = 250,
                int? height = 250,
                string fgColor = "#000000",
                string bgColor = "#ffffff");

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
        Stream ImageWatermark(
                string imageUrl,
                string watermarkUrl,
                int? opacity = 50,
                string format = "png",
                string position = "center",
                int? width = null,
                int? height = null);

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
        Task<Stream> ImageWatermarkAsync(
                string imageUrl,
                string watermarkUrl,
                int? opacity = 50,
                string format = "png",
                string position = "center",
                int? width = null,
                int? height = null);

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
        Stream HTML5Render(
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
                int? imageHeight = null);

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
        Task<Stream> HTML5RenderAsync(
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
                int? imageHeight = null);

    }
} 