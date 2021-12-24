# Getting started

The general-purpose API

### NuGet

Install NeutrinoAPI from [NuGet](https://www.nuget.org/packages/NeutrinoAPI/):

```
Install-Package NeutrinoAPI
```


## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (NeutrinoAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

## How to Use

The following section explains how to use the NeutrinoAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

### 3. Add reference of the library project

In order to use the NeutrinoAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` NeutrinoAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```NeutrinoAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| userId | Your user ID |
| apiKey | Your API key |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string userId = "userId"; // Your user ID
string apiKey = "apiKey"; // Your API key

NeutrinoAPIClient client = new NeutrinoAPIClient(userId, apiKey);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [Imaging](#imaging)
* [Telephony](#telephony)
* [DataTools](#data_tools)
* [SecurityAndNetworking](#security_and_networking)
* [Geolocation](#geolocation)
* [ECommerce](#e_commerce)
* [WWW](#www)

## <a name="imaging"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.Imaging") Imaging

### Get singleton instance

The singleton instance of the ``` Imaging ``` class can be accessed from the API Client.

```csharp
IImaging imaging = client.Imaging;
```

### <a name="image_resize"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Imaging.ImageResize") ImageResize

> Resize an image and output as either JPEG or PNG. See: https://www.neutrinoapi.com/api/image-resize/


```csharp
Task<Stream> ImageResize(
        string imageUrl,
        int width,
        int height,
        string format = "png")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| imageUrl |  ``` Required ```  | The URL to the source image |
| width |  ``` Required ```  | The width to resize to (in px) while preserving aspect ratio |
| height |  ``` Required ```  | The height to resize to (in px) while preserving aspect ratio |
| format |  ``` Optional ```  ``` DefaultValue ```  | The output image format, can be either png or jpg |


#### Example Usage

```csharp
string imageUrl = "image-url";
int width = 137;
int height = 137;
string format = "png";

Stream result = await imaging.ImageResize(imageUrl, width, height, format);

```


### <a name="qr_code"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Imaging.QRCode") QRCode

> Generate a QR code as a PNG image. See: https://www.neutrinoapi.com/api/qr-code/


```csharp
Task<Stream> QRCode(
        string content,
        int? width = 256,
        int? height = 256,
        string fgColor = "#000000",
        string bgColor = "#ffffff")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The content to encode into the QR code (e.g. a URL or a phone number) |
| width |  ``` Optional ```  ``` DefaultValue ```  | The width of the QR code (in px) |
| height |  ``` Optional ```  ``` DefaultValue ```  | The height of the QR code (in px) |
| fgColor |  ``` Optional ```  ``` DefaultValue ```  | The QR code foreground color |
| bgColor |  ``` Optional ```  ``` DefaultValue ```  | The QR code background color |


#### Example Usage

```csharp
string content = "content";
int? width = 256;
int? height = 256;
string fgColor = "#000000";
string bgColor = "#ffffff";

Stream result = await imaging.QRCode(content, width, height, fgColor, bgColor);

```


### <a name="image_watermark"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Imaging.ImageWatermark") ImageWatermark

> Watermark one image with another image. See: https://www.neutrinoapi.com/api/image-watermark/


```csharp
Task<Stream> ImageWatermark(
        string imageUrl,
        string watermarkUrl,
        int? opacity = 50,
        string format = "png",
        string position = "center",
        int? width = null,
        int? height = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| imageUrl |  ``` Required ```  | The URL to the source image |
| watermarkUrl |  ``` Required ```  | The URL to the watermark image |
| opacity |  ``` Optional ```  ``` DefaultValue ```  | The opacity of the watermark (0 to 100) |
| format |  ``` Optional ```  ``` DefaultValue ```  | The output image format, can be either png or jpg |
| position |  ``` Optional ```  ``` DefaultValue ```  | The position of the watermark image, possible values are: center, top-left, top-center, top-right, bottom-left, bottom-center, bottom-right |
| width |  ``` Optional ```  | If set resize the resulting image to this width (in px) while preserving aspect ratio |
| height |  ``` Optional ```  | If set resize the resulting image to this height (in px) while preserving aspect ratio |


#### Example Usage

```csharp
string imageUrl = "image-url";
string watermarkUrl = "watermark-url";
int? opacity = 50;
string format = "png";
string position = "center";
int? width = 137;
int? height = 137;

Stream result = await imaging.ImageWatermark(imageUrl, watermarkUrl, opacity, format, position, width, height);

```


### <a name="html5_render"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Imaging.HTML5Render") HTML5Render

> Render HTML content to PDF, JPG or PNG. See: https://www.neutrinoapi.com/api/html5-render/


```csharp
Task<Stream> HTML5Render(
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
        int? zoom = 1,
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
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The HTML content. This can be either a URL to load HTML from or an actual HTML content string |
| format |  ``` Optional ```  ``` DefaultValue ```  | Which format to output, available options are: PDF, PNG, JPG |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Set the document page size, can be one of: A0 - A9, B0 - B10, Comm10E, DLE or Letter |
| title |  ``` Optional ```  | The document title |
| margin |  ``` Optional ```  ``` DefaultValue ```  | The document margin (in mm) |
| marginLeft |  ``` Optional ```  ``` DefaultValue ```  | The document left margin (in mm) |
| marginRight |  ``` Optional ```  ``` DefaultValue ```  | The document right margin (in mm) |
| marginTop |  ``` Optional ```  ``` DefaultValue ```  | The document top margin (in mm) |
| marginBottom |  ``` Optional ```  ``` DefaultValue ```  | The document bottom margin (in mm) |
| landscape |  ``` Optional ```  ``` DefaultValue ```  | Set the document to lanscape orientation |
| zoom |  ``` Optional ```  ``` DefaultValue ```  | Set the zoom factor when rendering the page (2.0 for double size, 0.5 for half size) |
| grayscale |  ``` Optional ```  ``` DefaultValue ```  | Render the final document in grayscale |
| mediaPrint |  ``` Optional ```  ``` DefaultValue ```  | Use @media print CSS styles to render the document |
| mediaQueries |  ``` Optional ```  ``` DefaultValue ```  | Activate all @media queries before rendering. This can be useful if you wan't to render the mobile version of a responsive website |
| forms |  ``` Optional ```  ``` DefaultValue ```  | Generate real (fillable) PDF forms from HTML forms |
| css |  ``` Optional ```  | Inject custom CSS into the HTML. e.g. 'body { background-color: red;}' |
| imageWidth |  ``` Optional ```  ``` DefaultValue ```  | If rendering to an image format (PNG or JPG) use this image width (in pixels) |
| imageHeight |  ``` Optional ```  | If rendering to an image format (PNG or JPG) use this image height (in pixels). The default is automatic which dynamically sets the image height based on the content |
| renderDelay |  ``` Optional ```  ``` DefaultValue ```  | Number of milliseconds to wait before rendering the page (can be useful for pages with animations etc) |
| headerTextLeft |  ``` Optional ```  | Text to print to the left-hand side header of each page. e.g. 'My header - Page {page_number} of {total_pages}' |
| headerTextCenter |  ``` Optional ```  | Text to print to the center header of each page |
| headerTextRight |  ``` Optional ```  | Text to print to the right-hand side header of each page |
| headerSize |  ``` Optional ```  ``` DefaultValue ```  | The height of your header (in mm) |
| headerFont |  ``` Optional ```  ``` DefaultValue ```  | Set the header font. Fonts available: Times, Courier, Helvetica, Arial |
| headerFontSize |  ``` Optional ```  ``` DefaultValue ```  | Set the header font size (in pt) |
| headerLine |  ``` Optional ```  ``` DefaultValue ```  | Draw a full page width horizontal line under your header |
| footerTextLeft |  ``` Optional ```  | Text to print to the left-hand side footer of each page. e.g. 'My footer - Page {page_number} of {total_pages}' |
| footerTextCenter |  ``` Optional ```  | Text to print to the center header of each page |
| footerTextRight |  ``` Optional ```  | Text to print to the right-hand side header of each page |
| footerSize |  ``` Optional ```  ``` DefaultValue ```  | The height of your footer (in mm) |
| footerFont |  ``` Optional ```  ``` DefaultValue ```  | Set the footer font. Fonts available: Times, Courier, Helvetica, Arial |
| footerFontSize |  ``` Optional ```  ``` DefaultValue ```  | Set the footer font size (in pt) |
| footerLine |  ``` Optional ```  ``` DefaultValue ```  | Draw a full page width horizontal line above your footer |
| pageWidth |  ``` Optional ```  | Set the PDF page width explicitly (in mm) |
| pageHeight |  ``` Optional ```  | Set the PDF page height explicitly (in mm) |


#### Example Usage

```csharp
string content = "content";
string format = "PDF";
string pageSize = "A4";
string title = "title";
int? margin = 0;
int? marginLeft = 0;
int? marginRight = 0;
int? marginTop = 0;
int? marginBottom = 0;
bool? landscape = false;
int? zoom = 1;
bool? grayscale = false;
bool? mediaPrint = false;
bool? mediaQueries = false;
bool? forms = false;
string css = "css";
int? imageWidth = 1024;
int? imageHeight = 137;
int? renderDelay = 0;
string headerTextLeft = "header-text-left";
string headerTextCenter = "header-text-center";
string headerTextRight = "header-text-right";
int? headerSize = 9;
string headerFont = "Courier";
int? headerFontSize = 11;
bool? headerLine = false;
string footerTextLeft = "footer-text-left";
string footerTextCenter = "footer-text-center";
string footerTextRight = "footer-text-right";
int? footerSize = 9;
string footerFont = "Courier";
int? footerFontSize = 11;
bool? footerLine = false;
int? pageWidth = 137;
int? pageHeight = 137;

Stream result = await imaging.HTML5Render(content, format, pageSize, title, margin, marginLeft, marginRight, marginTop, marginBottom, landscape, zoom, grayscale, mediaPrint, mediaQueries, forms, css, imageWidth, imageHeight, renderDelay, headerTextLeft, headerTextCenter, headerTextRight, headerSize, headerFont, headerFontSize, headerLine, footerTextLeft, footerTextCenter, footerTextRight, footerSize, footerFont, footerFontSize, footerLine, pageWidth, pageHeight);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="telephony"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.Telephony") Telephony

### Get singleton instance

The singleton instance of the ``` Telephony ``` class can be accessed from the API Client.

```csharp
ITelephony telephony = client.Telephony;
```

### <a name="verify_security_code"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.VerifySecurityCode") VerifySecurityCode

> Check if a security code from one of the verify APIs is valid. See: https://www.neutrinoapi.com/api/verify-security-code/


```csharp
Task<Models.VerifySecurityCodeResponse> VerifySecurityCode(string securityCode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| securityCode |  ``` Required ```  | The security code to verify |


#### Example Usage

```csharp
string securityCode = "security-code";

Models.VerifySecurityCodeResponse result = await telephony.VerifySecurityCode(securityCode);

```


### <a name="hlr_lookup"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.HLRLookup") HLRLookup

> Connect to the global mobile cellular network and retrieve the status of a mobile device. See: https://www.neutrinoapi.com/api/hlr-lookup/


```csharp
Task<Models.HLRLookupResponse> HLRLookup(string number, string countryCode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | A phone number |
| countryCode |  ``` Optional ```  | ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign) |


#### Example Usage

```csharp
string number = "number";
string countryCode = "country-code";

Models.HLRLookupResponse result = await telephony.HLRLookup(number, countryCode);

```


### <a name="phone_playback"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.PhonePlayback") PhonePlayback

> Make an automated call to any valid phone number and playback an audio message. See: https://www.neutrinoapi.com/api/phone-playback/


```csharp
Task<Models.PhonePlaybackResponse> PhonePlayback(string number, string audioUrl)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | The phone number to call. Must be in valid international format |
| audioUrl |  ``` Required ```  | A URL to a valid audio file. Accepted audio formats are: <ul> <li>MP3</li> <li>WAV</li> <li>OGG</li> </ul>You can use the following MP3 URL for testing: https://www.neutrinoapi.com/test-files/test1.mp3 |


#### Example Usage

```csharp
string number = "number";
string audioUrl = "audio-url";

Models.PhonePlaybackResponse result = await telephony.PhonePlayback(number, audioUrl);

```


### <a name="sms_verify"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.SMSVerify") SMSVerify

> Send a unique security code to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-verify/


```csharp
Task<Models.SMSVerifyResponse> SMSVerify(
        string number,
        int? codeLength = 5,
        int? securityCode = null,
        string countryCode = null,
        string languageCode = "en")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | The phone number to send a verification code to |
| codeLength |  ``` Optional ```  ``` DefaultValue ```  | The number of digits to use in the security code (must be between 4 and 12) |
| securityCode |  ``` Optional ```  | Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code |
| countryCode |  ``` Optional ```  | ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign) |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to send the verification code in, available languages are: <ul> <li>de - German</li> <li>en - English</li> <li>es - Spanish</li> <li>fr - French</li> <li>it - Italian</li> <li>pt - Portuguese</li> <li>ru - Russian</li> </ul> |


#### Example Usage

```csharp
string number = "number";
int? codeLength = 5;
int? securityCode = 228;
string countryCode = "country-code";
string languageCode = "en";

Models.SMSVerifyResponse result = await telephony.SMSVerify(number, codeLength, securityCode, countryCode, languageCode);

```


### <a name="sms_message"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.SMSMessage") SMSMessage

> Send a free-form message to any mobile device via SMS. See: https://www.neutrinoapi.com/api/sms-message/


```csharp
Task<Models.SMSMessageResponse> SMSMessage(string number, string message, string countryCode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | The phone number to send a message to |
| message |  ``` Required ```  | The SMS message to send. Messages are truncated to a maximum of 150 characters for ASCII content OR 70 characters for UTF content |
| countryCode |  ``` Optional ```  | ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign) |


#### Example Usage

```csharp
string number = "number";
string message = "message";
string countryCode = "country-code";

Models.SMSMessageResponse result = await telephony.SMSMessage(number, message, countryCode);

```


### <a name="phone_verify"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.PhoneVerify") PhoneVerify

> Make an automated call to any valid phone number and playback a unique security code. See: https://www.neutrinoapi.com/api/phone-verify/


```csharp
Task<Models.PhoneVerifyResponse> PhoneVerify(
        string number,
        int? codeLength = 6,
        int? securityCode = null,
        int? playbackDelay = 800,
        string countryCode = null,
        string languageCode = "en")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | The phone number to send the verification code to |
| codeLength |  ``` Optional ```  ``` DefaultValue ```  | The number of digits to use in the security code (between 4 and 12) |
| securityCode |  ``` Optional ```  | Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code |
| playbackDelay |  ``` Optional ```  ``` DefaultValue ```  | The delay in milliseconds between the playback of each security code |
| countryCode |  ``` Optional ```  | ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign) |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to playback the verification code in, available languages are: <ul> <li>de - German</li> <li>en - English</li> <li>es - Spanish</li> <li>fr - French</li> <li>it - Italian</li> <li>pt - Portuguese</li> <li>ru - Russian</li> </ul> |


#### Example Usage

```csharp
string number = "number";
int? codeLength = 6;
int? securityCode = 228;
int? playbackDelay = 800;
string countryCode = "country-code";
string languageCode = "en";

Models.PhoneVerifyResponse result = await telephony.PhoneVerify(number, codeLength, securityCode, playbackDelay, countryCode, languageCode);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="data_tools"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.DataTools") DataTools

### Get singleton instance

The singleton instance of the ``` DataTools ``` class can be accessed from the API Client.

```csharp
IDataTools dataTools = client.DataTools;
```

### <a name="email_validate"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.EmailValidate") EmailValidate

> Parse, validate and clean an email address. See: https://www.neutrinoapi.com/api/email-validate/


```csharp
Task<Models.EmailValidateResponse> EmailValidate(string email, bool? fixTypos = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | An email address |
| fixTypos |  ``` Optional ```  ``` DefaultValue ```  | Automatically attempt to fix typos in the address |


#### Example Usage

```csharp
string email = "email";
bool? fixTypos = false;

Models.EmailValidateResponse result = await dataTools.EmailValidate(email, fixTypos);

```


### <a name="user_agent_info"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.UserAgentInfo") UserAgentInfo

> Parse, validate and get detailed user-agent information from a user agent string. See: https://www.neutrinoapi.com/api/user-agent-info/


```csharp
Task<Models.UserAgentInfoResponse> UserAgentInfo(string userAgent)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userAgent |  ``` Required ```  | A user agent string |


#### Example Usage

```csharp
string userAgent = "user-agent";

Models.UserAgentInfoResponse result = await dataTools.UserAgentInfo(userAgent);

```


### <a name="bad_word_filter"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.BadWordFilter") BadWordFilter

> Detect bad words, swear words and profanity in a given text. See: https://www.neutrinoapi.com/api/bad-word-filter/


```csharp
Task<Models.BadWordFilterResponse> BadWordFilter(string content, string censorCharacter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The content to scan. This can be either a URL to load content from or an actual content string |
| censorCharacter |  ``` Optional ```  | The character to use to censor out the bad words found |


#### Example Usage

```csharp
string content = "content";
string censorCharacter = "censor-character";

Models.BadWordFilterResponse result = await dataTools.BadWordFilter(content, censorCharacter);

```


### <a name="convert"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.Convert") Convert

> A powerful unit conversion tool. See: https://www.neutrinoapi.com/api/convert/


```csharp
Task<Models.ConvertResponse> Convert(string fromValue, string fromType, string toType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fromValue |  ``` Required ```  | The value to convert from (e.g. 10.95) |
| fromType |  ``` Required ```  | The type of the value to convert from (e.g. USD) |
| toType |  ``` Required ```  | The type to convert to (e.g. EUR) |


#### Example Usage

```csharp
string fromValue = "from-value";
string fromType = "from-type";
string toType = "to-type";

Models.ConvertResponse result = await dataTools.Convert(fromValue, fromType, toType);

```


### <a name="phone_validate"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.PhoneValidate") PhoneValidate

> Parse, validate and get location information about a phone number. See: https://www.neutrinoapi.com/api/phone-validate/


```csharp
Task<Models.PhoneValidateResponse> PhoneValidate(string number, string countryCode = null, string ip = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | A phone number. This can be in international format (E.164) or local format. If passing local format you should use the 'country-code' or 'ip' options as well |
| countryCode |  ``` Optional ```  | ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign) |
| ip |  ``` Optional ```  | Pass in a users IP address and we will assume numbers are based in the country of the IP address |


#### Example Usage

```csharp
string number = "number";
string countryCode = "country-code";
string ip = "ip";

Models.PhoneValidateResponse result = await dataTools.PhoneValidate(number, countryCode, ip);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="security_and_networking"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.SecurityAndNetworking") SecurityAndNetworking

### Get singleton instance

The singleton instance of the ``` SecurityAndNetworking ``` class can be accessed from the API Client.

```csharp
ISecurityAndNetworking securityAndNetworking = client.SecurityAndNetworking;
```

### <a name="ip_probe"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.IPProbe") IPProbe

> Analyze and extract provider information for an IP address. See: https://www.neutrinoapi.com/api/ip-probe/


```csharp
Task<Models.IPProbeResponse> IPProbe(string ip)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ip |  ``` Required ```  | IPv4 or IPv6 address |


#### Example Usage

```csharp
string ip = "ip";

Models.IPProbeResponse result = await securityAndNetworking.IPProbe(ip);

```


### <a name="email_verify"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.EmailVerify") EmailVerify

> SMTP based email address verification. See: https://www.neutrinoapi.com/api/email-verify/


```csharp
Task<Models.EmailVerifyResponse> EmailVerify(string email, bool? fixTypos = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | An email address |
| fixTypos |  ``` Optional ```  ``` DefaultValue ```  | Automatically attempt to fix typos in the address |


#### Example Usage

```csharp
string email = "email";
bool? fixTypos = false;

Models.EmailVerifyResponse result = await securityAndNetworking.EmailVerify(email, fixTypos);

```


### <a name="ip_blocklist"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.IPBlocklist") IPBlocklist

> The IP Blocklist API will detect potentially malicious or dangerous IP addresses. See: https://www.neutrinoapi.com/api/ip-blocklist/


```csharp
Task<Models.IPBlocklistResponse> IPBlocklist(string ip)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ip |  ``` Required ```  | An IPv4 or IPv6 address |


#### Example Usage

```csharp
string ip = "ip";

Models.IPBlocklistResponse result = await securityAndNetworking.IPBlocklist(ip);

```


### <a name="host_reputation"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.HostReputation") HostReputation

> Check the reputation of an IP address, domain name, FQDN or URL against a comprehensive list of blacklists and blocklists. See: https://www.neutrinoapi.com/api/host-reputation/


```csharp
Task<Models.HostReputationResponse> HostReputation(string host, int? listRating = 3)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| host |  ``` Required ```  | An IP address, domain name, FQDN or URL. If you supply a domain/URL it will be checked against the URI DNSBL lists |
| listRating |  ``` Optional ```  ``` DefaultValue ```  | Only check lists with this rating or better |


#### Example Usage

```csharp
string host = "host";
int? listRating = 3;

Models.HostReputationResponse result = await securityAndNetworking.HostReputation(host, listRating);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="geolocation"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.Geolocation") Geolocation

### Get singleton instance

The singleton instance of the ``` Geolocation ``` class can be accessed from the API Client.

```csharp
IGeolocation geolocation = client.Geolocation;
```

### <a name="geocode_reverse"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Geolocation.GeocodeReverse") GeocodeReverse

> Convert a geographic coordinate (latitude and longitude) into a real world address. See: https://www.neutrinoapi.com/api/geocode-reverse/


```csharp
Task<Models.GeocodeReverseResponse> GeocodeReverse(
        string latitude,
        string longitude,
        string languageCode = "en",
        string zoom = "address")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | The location latitude in decimal degrees format |
| longitude |  ``` Required ```  | The location longitude in decimal degrees format |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul> |
| zoom |  ``` Optional ```  ``` DefaultValue ```  | The zoom level to respond with: <ul> <li>address - the most precise address available</li> <li>street - the street level</li> <li>city - the city level</li> <li>state - the state level</li> <li>country - the country level</li> </ul> |


#### Example Usage

```csharp
string latitude = "latitude";
string longitude = "longitude";
string languageCode = "en";
string zoom = "address";

Models.GeocodeReverseResponse result = await geolocation.GeocodeReverse(latitude, longitude, languageCode, zoom);

```


### <a name="ip_info"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Geolocation.IPInfo") IPInfo

> Get location information about an IP address and do reverse DNS (PTR) lookups. See: https://www.neutrinoapi.com/api/ip-info/


```csharp
Task<Models.IPInfoResponse> IPInfo(string ip, bool? reverseLookup = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ip |  ``` Required ```  | IPv4 or IPv6 address |
| reverseLookup |  ``` Optional ```  ``` DefaultValue ```  | Do a reverse DNS (PTR) lookup. This option can add extra delay to the request so only use it if you need it |


#### Example Usage

```csharp
string ip = "ip";
bool? reverseLookup = false;

Models.IPInfoResponse result = await geolocation.IPInfo(ip, reverseLookup);

```


### <a name="geocode_address"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Geolocation.GeocodeAddress") GeocodeAddress

> Geocode an address, partial address or just the name of a place. See: https://www.neutrinoapi.com/api/geocode-address/


```csharp
Task<Models.GeocodeAddressResponse> GeocodeAddress(
        string address,
        string countryCode = null,
        string languageCode = "en",
        bool? fuzzySearch = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| address |  ``` Required ```  | The address, partial address or name of a place to try and locate |
| countryCode |  ``` Optional ```  | The ISO 2-letter country code to be biased towards (the default is no country bias) |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to display results in, available languages are: <ul> <li>de, en, es, fr, it, pt, ru</li> </ul> |
| fuzzySearch |  ``` Optional ```  ``` DefaultValue ```  | If no matches are found for the given address, start performing a recursive fuzzy search until a geolocation is found. This option is recommended for processing user input or implementing auto-complete. We use a combination of approximate string matching and data cleansing to find possible location matches |


#### Example Usage

```csharp
string address = "address";
string countryCode = "country-code";
string languageCode = "en";
bool? fuzzySearch = false;

Models.GeocodeAddressResponse result = await geolocation.GeocodeAddress(address, countryCode, languageCode, fuzzySearch);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="e_commerce"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.ECommerce") ECommerce

### Get singleton instance

The singleton instance of the ``` ECommerce ``` class can be accessed from the API Client.

```csharp
IECommerce eCommerce = client.ECommerce;
```

### <a name="bin_lookup"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.ECommerce.BINLookup") BINLookup

> Perform a BIN (Bank Identification Number) or IIN (Issuer Identification Number) lookup. See: https://www.neutrinoapi.com/api/bin-lookup/


```csharp
Task<Models.BINLookupResponse> BINLookup(string binNumber, string customerIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| binNumber |  ``` Required ```  | The BIN or IIN number (the first 6 digits of a credit card number) |
| customerIp |  ``` Optional ```  | Pass in the customers IP address and we will return some extra information about them |


#### Example Usage

```csharp
string binNumber = "bin-number";
string customerIp = "customer-ip";

Models.BINLookupResponse result = await eCommerce.BINLookup(binNumber, customerIp);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="www"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.WWW") WWW

### Get singleton instance

The singleton instance of the ``` WWW ``` class can be accessed from the API Client.

```csharp
IWWW wWW = client.WWW;
```

### <a name="url_info"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.WWW.URLInfo") URLInfo

> Parse, analyze and retrieve content from the supplied URL. See: https://www.neutrinoapi.com/api/url-info/


```csharp
Task<Models.URLInfoResponse> URLInfo(
        string url,
        bool? fetchContent = false,
        bool? ignoreCertificateErrors = false,
        int? timeout = 20)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| url |  ``` Required ```  | The URL to probe |
| fetchContent |  ``` Optional ```  ``` DefaultValue ```  | If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content (e.g. with the HTML Extract or HTML Clean APIs) |
| ignoreCertificateErrors |  ``` Optional ```  ``` DefaultValue ```  | Ignore any TLS/SSL certificate errors and load the URL anyway |
| timeout |  ``` Optional ```  ``` DefaultValue ```  | Timeout in seconds. Give up if still trying to load the URL after this number of seconds |


#### Example Usage

```csharp
string url = "url";
bool? fetchContent = false;
bool? ignoreCertificateErrors = false;
int? timeout = 20;

Models.URLInfoResponse result = await wWW.URLInfo(url, fetchContent, ignoreCertificateErrors, timeout);

```


### <a name="html_clean"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.WWW.HTMLClean") HTMLClean

> Clean and sanitize untrusted HTML. See: https://www.neutrinoapi.com/api/html-clean/


```csharp
Task<Stream> HTMLClean(string content, string outputType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The HTML content. This can be either a URL to load HTML from or an actual HTML content string |
| outputType |  ``` Required ```  | The level of sanitization, possible values are: <b>plain-text</b>: reduce the content to plain text only (no HTML tags at all) <b>simple-text</b>: allow only very basic text formatting tags like b, em, i, strong, u <b>basic-html</b>: allow advanced text formatting and hyper links <b>basic-html-with-images</b>: same as basic html but also allows image tags <b>advanced-html</b>: same as basic html with images but also allows many more common HTML tags like table, ul, dl, pre |


#### Example Usage

```csharp
string content = "content";
string outputType = "output-type";

Stream result = await wWW.HTMLClean(content, outputType);

```


### <a name="browser_bot"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.WWW.BrowserBot") BrowserBot

> Browser bot can extract content, interact with keyboard and mouse events, and execute JavaScript on a website. See: https://www.neutrinoapi.com/api/browser-bot/


```csharp
Task<Models.BrowserBotResponse> BrowserBot(
        string url,
        int? timeout = 30,
        int? delay = 3,
        string selector = null,
        List<string> exec = null,
        string userAgent = null,
        bool? ignoreCertificateErrors = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| url |  ``` Required ```  | The URL to load |
| timeout |  ``` Optional ```  ``` DefaultValue ```  | Timeout in seconds. Give up if still trying to load the page after this number of seconds |
| delay |  ``` Optional ```  ``` DefaultValue ```  | Delay in seconds to wait before capturing any page data, executing selectors or JavaScript |
| selector |  ``` Optional ```  | Extract content from the page DOM using this selector. Commonly known as a CSS selector, you can find a good reference <a href="https://www.w3schools.com/cssref/css_selectors.asp">here</a> |
| exec |  ``` Optional ```  ``` Collection ```  | Execute JavaScript on the page. Each array element should contain a valid JavaScript statement in string form. If a statement returns any kind of value it will be returned in the 'exec-results' response. For your convenience you can also use the following special shortcut functions: <div> sleep(seconds); Just wait/sleep for the specified number of seconds. click('selector'); Click on the first element matching the given selector. focus('selector'); Focus on the first element matching the given selector. keys('characters'); Send the specified keyboard characters. Use click() or focus() first to send keys to a specific element. enter(); Send the Enter key. tab(); Send the Tab key. </div> Example: <div> [ "click('#button-id')", "sleep(1)", "click('.field-class')", "keys('1234')", "enter()" ] </div> |
| userAgent |  ``` Optional ```  | Override the browsers default user-agent string with this one |
| ignoreCertificateErrors |  ``` Optional ```  ``` DefaultValue ```  | Ignore any TLS/SSL certificate errors and load the page anyway |


#### Example Usage

```csharp
string url = "url";
int? timeout = 30;
int? delay = 3;
string selector = "selector";
List<string> exec = new List<string> { "exec" };
string userAgent = "user-agent";
bool? ignoreCertificateErrors = false;

Models.BrowserBotResponse result = await wWW.BrowserBot(url, timeout, delay, selector, exec, userAgent, ignoreCertificateErrors);

```


[Back to List of Controllers](#list_of_controllers)



