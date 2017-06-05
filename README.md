# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (NeutrinoAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=NeutrinoAPI-CSharp&workspaceName=NeutrinoAPI&projectName=NeutrinoAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

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

* [DataTools](#data_tools)
* [ECommerce](#e_commerce)
* [Geolocation](#geolocation)
* [SecurityAndNetworking](#security_and_networking)
* [Telephony](#telephony)
* [Imaging](#imaging)

## <a name="data_tools"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.DataTools") DataTools

### Get singleton instance

The singleton instance of the ``` DataTools ``` class can be accessed from the API Client.

```csharp
IDataTools dataTools = client.DataTools;
```

### <a name="convert"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.Convert") Convert

> A powerful unit and currency conversion tool


```csharp
Task<Models.ConvertResponse> Convert(string fromValue, string fromType, string toType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fromValue |  ``` Required ```  | The value to convert from |
| fromType |  ``` Required ```  | The type of the value to convert from |
| toType |  ``` Required ```  | The type to convert to |


#### Example Usage

```csharp
string fromValue = "from-value";
string fromType = "from-type";
string toType = "to-type";

Models.ConvertResponse result = await dataTools.Convert(fromValue, fromType, toType);

```


### <a name="bad_word_filter"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.BadWordFilter") BadWordFilter

> Detect bad words, swear words and profanity in a given text


```csharp
Task<Models.BadWordFilterResponse> BadWordFilter(string content, string censorCharacter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The text content to check. This can be either a URL to load content from or an actual content string |
| censorCharacter |  ``` Optional ```  | The character to use to censor out the bad words found |


#### Example Usage

```csharp
string content = "content";
string censorCharacter = "censor-character";

Models.BadWordFilterResponse result = await dataTools.BadWordFilter(content, censorCharacter);

```


### <a name="email_validate"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.EmailValidate") EmailValidate

> Parse, validate and clean an email address


```csharp
Task<Models.EmailValidateResponse> EmailValidate(string email, bool? fixTypos = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email address |
| fixTypos |  ``` Optional ```  ``` DefaultValue ```  | Automatically attempt to fix typos in the address |


#### Example Usage

```csharp
string email = "email";
bool? fixTypos = false;

Models.EmailValidateResponse result = await dataTools.EmailValidate(email, fixTypos);

```


### <a name="html_clean"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.HTMLClean") HTMLClean

> Clean and sanitize untrusted HTML


```csharp
Task<Stream> HTMLClean(string content, string outputType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The HTML content. This can be either a URL to load HTML from or an actual HTML content string |
| outputType |  ``` Required ```  | The level of sanitization, possible values are: plain-text, simple-text, basic-html, basic-html-with-images, advanced-html |


#### Example Usage

```csharp
string content = "content";
string outputType = "output-type";

Stream result = await dataTools.HTMLClean(content, outputType);

```


### <a name="code_highlight"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.CodeHighlight") CodeHighlight

> Code highlight will take raw source code and convert into nicely formatted HTML with syntax and keyword highlighting


```csharp
Task<Stream> CodeHighlight(string content, string type, bool? addKeywordLinks = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The source content. This can be either a URL to load from or an actual content string |
| type |  ``` Required ```  | The code type. See the API docs for all supported types |
| addKeywordLinks |  ``` Optional ```  ``` DefaultValue ```  | Add links on source code keywords to the relevant language documentation |


#### Example Usage

```csharp
string content = "content";
string type = "type";
bool? addKeywordLinks = false;

Stream result = await dataTools.CodeHighlight(content, type, addKeywordLinks);

```


### <a name="user_agent_info"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.UserAgentInfo") UserAgentInfo

> Parse, validate and get detailed user-agent information from a user agent string


```csharp
Task<Models.UserAgentInfoResponse> UserAgentInfo(string userAgent)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userAgent |  ``` Required ```  | A user-agent string |


#### Example Usage

```csharp
string userAgent = "user-agent";

Models.UserAgentInfoResponse result = await dataTools.UserAgentInfo(userAgent);

```


### <a name="html_extract"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.HTMLExtract") HTMLExtract

> Extract specific HTML tag contents or attributes from complex HTML or XHTML content


```csharp
Task<Models.HTMLExtractResponse> HTMLExtract(
        string content,
        string tag,
        string attribute = null,
        string baseUrl = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The HTML content. This can be either a URL to load HTML from or an actual HTML content string |
| tag |  ``` Required ```  | The HTML tag(s) to extract data from. This can just be a simple tag name like 'img' OR a CSS/jQuery style selector |
| attribute |  ``` Optional ```  | If set, then extract data from the specified tag attribute. If not set, then data will be extracted from the tags inner content |
| baseUrl |  ``` Optional ```  | The base URL to replace into realive links |


#### Example Usage

```csharp
string content = "content";
string tag = "tag";
string attribute = "attribute";
string baseUrl = "base-url";

Models.HTMLExtractResponse result = await dataTools.HTMLExtract(content, tag, attribute, baseUrl);

```


### <a name="phone_validate"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.DataTools.PhoneValidate") PhoneValidate

> Parse, validate and get location information about a phone number


```csharp
Task<Models.PhoneValidateResponse> PhoneValidate(string number, string countryCode = null, string ip = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | The phone number |
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
| customerIp |  ``` Optional ```  | Pass in a customers remote IP address. The API will then determine the country of the IP address and match it against the BIN country. This feature is designed for fraud prevention and detection checks. |


#### Example Usage

```csharp
string binNumber = "bin-number";
string customerIp = "customer-ip";

Models.BINLookupResponse result = await eCommerce.BINLookup(binNumber, customerIp);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="geolocation"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.Geolocation") Geolocation

### Get singleton instance

The singleton instance of the ``` Geolocation ``` class can be accessed from the API Client.

```csharp
IGeolocation geolocation = client.Geolocation;
```

### <a name="geocode_reverse"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Geolocation.GeocodeReverse") GeocodeReverse

> Convert a geographic coordinate (latitude and longitude) into a real world address or location.


```csharp
Task<Models.GeocodeReverseResponse> GeocodeReverse(double latitude, double longitude, string languageCode = "en")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | The location latitude |
| longitude |  ``` Required ```  | The location longitude |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to display results in, available languages are: de, en, es, fr, it, pt, ru |


#### Example Usage

```csharp
double latitude = 247.411090320633;
double longitude = 247.411090320633;
string languageCode = "en";

Models.GeocodeReverseResponse result = await geolocation.GeocodeReverse(latitude, longitude, languageCode);

```


### <a name="geocode_address"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Geolocation.GeocodeAddress") GeocodeAddress

> Geocode an address, partial address or the name of a location


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
| address |  ``` Required ```  | The address or partial address to try and locate |
| countryCode |  ``` Optional ```  | The ISO 2-letter country code to be biased towards (default is no country bias) |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to display results in, available languages are: de, en, es, fr, it, pt, ru |
| fuzzySearch |  ``` Optional ```  ``` DefaultValue ```  | If no matches are found for the given address, start performing a recursive fuzzy search until a geolocation is found. We use a combination of approximate string matching and data cleansing to find possible location matches |


#### Example Usage

```csharp
string address = "address";
string countryCode = "country-code";
string languageCode = "en";
bool? fuzzySearch = false;

Models.GeocodeAddressResponse result = await geolocation.GeocodeAddress(address, countryCode, languageCode, fuzzySearch);

```


### <a name="ip_info"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Geolocation.IPInfo") IPInfo

> Get location information about an IP address and do reverse DNS (PTR) lookups.


```csharp
Task<Models.IPInfoResponse> IPInfo(string ip, bool? reverseLookup = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ip |  ``` Required ```  | The IP address |
| reverseLookup |  ``` Optional ```  ``` DefaultValue ```  | Do a reverse DNS (PTR) lookup. This option can add extra delay to the request so only use it if you need it |


#### Example Usage

```csharp
string ip = "ip";
bool? reverseLookup = false;

Models.IPInfoResponse result = await geolocation.IPInfo(ip, reverseLookup);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="security_and_networking"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.SecurityAndNetworking") SecurityAndNetworking

### Get singleton instance

The singleton instance of the ``` SecurityAndNetworking ``` class can be accessed from the API Client.

```csharp
ISecurityAndNetworking securityAndNetworking = client.SecurityAndNetworking;
```

### <a name="host_reputation"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.HostReputation") HostReputation

> Check the reputation of an IP address or domain against a comprehensive list of blacklists and blocklists (DNSBLs)


```csharp
Task<Models.HostReputationResponse> HostReputation(string host)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| host |  ``` Required ```  | An IPv4 address or a domain name. If you supply a domain name it will be checked against the URI DNSBL list |


#### Example Usage

```csharp
string host = "host";

Models.HostReputationResponse result = await securityAndNetworking.HostReputation(host);

```


### <a name="ip_blocklist"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.IPBlocklist") IPBlocklist

> The IP Blocklist API will detect potentially malicious or dangerous IP addresses


```csharp
Task<Models.IPBlocklistResponse> IPBlocklist(string ip)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ip |  ``` Required ```  | An IPv4 address |


#### Example Usage

```csharp
string ip = "ip";

Models.IPBlocklistResponse result = await securityAndNetworking.IPBlocklist(ip);

```


### <a name="ip_probe"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.IPProbe") IPProbe

> Analyze and extract provider information for an IP address


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


### <a name="url_info"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.SecurityAndNetworking.URLInfo") URLInfo

> Parse, analyze and retrieve content from the supplied URL


```csharp
Task<Models.URLInfoResponse> URLInfo(string url, bool fetchContent)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| url |  ``` Required ```  | The URL to process |
| fetchContent |  ``` Required ```  | If this URL responds with html, text, json or xml then return the response. This option is useful if you want to perform further processing on the URL content |


#### Example Usage

```csharp
string url = "url";
bool fetchContent = true;

Models.URLInfoResponse result = await securityAndNetworking.URLInfo(url, fetchContent);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="telephony"></a>![Class: ](https://apidocs.io/img/class.png "NeutrinoAPI.Controllers.Telephony") Telephony

### Get singleton instance

The singleton instance of the ``` Telephony ``` class can be accessed from the API Client.

```csharp
ITelephony telephony = client.Telephony;
```

### <a name="hlr_lookup"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.HLRLookup") HLRLookup

> Connect to the global mobile cellular network and retrieve the status of a mobile device


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


### <a name="verify_security_code"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.VerifySecurityCode") VerifySecurityCode

> Check if a security code from one of the verify APIs is valid


```csharp
Task<Models.VerifySecurityCodeResponse> VerifySecurityCode(int securityCode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| securityCode |  ``` Required ```  | The security code to verify |


#### Example Usage

```csharp
int securityCode = 247;

Models.VerifySecurityCodeResponse result = await telephony.VerifySecurityCode(securityCode);

```


### <a name="sms_verify"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.SMSVerify") SMSVerify

> Send a unique security code to any mobile device via SMS


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
| securityCode |  ``` Optional ```  | ass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported) |
| countryCode |  ``` Optional ```  | ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign) |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to send the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian |


#### Example Usage

```csharp
string number = "number";
int? codeLength = 5;
int? securityCode = 247;
string countryCode = "country-code";
string languageCode = "en";

Models.SMSVerifyResponse result = await telephony.SMSVerify(number, codeLength, securityCode, countryCode, languageCode);

```


### <a name="phone_playback"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.PhonePlayback") PhonePlayback

> Make an automated call to any valid phone number and playback an audio message


```csharp
Task<Models.PhonePlaybackResponse> PhonePlayback(string number, string audioUrl)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | The phone number to call. Must be valid international format |
| audioUrl |  ``` Required ```  | A URL to a valid audio file. Accepted audio formats are: MP3, WAV, OGG |


#### Example Usage

```csharp
string number = "number";
string audioUrl = "audio-url";

Models.PhonePlaybackResponse result = await telephony.PhonePlayback(number, audioUrl);

```


### <a name="phone_verify"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Telephony.PhoneVerify") PhoneVerify

> Make an automated call to any valid phone number and playback a unique security code


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
| securityCode |  ``` Optional ```  | Pass in your own security code. This is useful if you have implemented TOTP or similar 2FA methods. If not set then we will generate a secure random code (only numerical security codes are currently supported) |
| playbackDelay |  ``` Optional ```  ``` DefaultValue ```  | The delay in milliseconds between the playback of each security code |
| countryCode |  ``` Optional ```  | ISO 2-letter country code, assume numbers are based in this country. If not set numbers are assumed to be in international format (with or without the leading + sign) |
| languageCode |  ``` Optional ```  ``` DefaultValue ```  | The language to playback the verification code in, available languages are: de - German, en - English, es - Spanish, fr - Fench, it - Italian, pt - Portuguese, ru - Russian |


#### Example Usage

```csharp
string number = "number";
int? codeLength = 6;
int? securityCode = 247;
int? playbackDelay = 800;
string countryCode = "country-code";
string languageCode = "en";

Models.PhoneVerifyResponse result = await telephony.PhoneVerify(number, codeLength, securityCode, playbackDelay, countryCode, languageCode);

```


[Back to List of Controllers](#list_of_controllers)

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
| width |  ``` Required ```  | Width to resize to (in px) |
| height |  ``` Required ```  | Height to resize to (in px) |
| format |  ``` Optional ```  ``` DefaultValue ```  | The output image format, can be either png or jpg |


#### Example Usage

```csharp
string imageUrl = "image-url";
int width = 247;
int height = 247;
string format = "png";

Stream result = await imaging.ImageResize(imageUrl, width, height, format);

```


### <a name="qr_code"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Imaging.QRCode") QRCode

> Generate a QR code as a PNG image. See: https://www.neutrinoapi.com/api/qr-code/


```csharp
Task<Stream> QRCode(
        string content,
        int? width = 250,
        int? height = 250,
        string fgColor = "#000000",
        string bgColor = "#ffffff")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| content |  ``` Required ```  | The content to encode into the QR code (e.g. a URL or a phone number) |
| width |  ``` Optional ```  ``` DefaultValue ```  | The width of the QR code (in px) |
| height |  ``` Optional ```  ``` DefaultValue ```  | The height of the QR code (in px) |
| fgColor |  ``` Optional ```  ``` DefaultValue ```  | The QR code foreground color (you should always use a dark color for this) |
| bgColor |  ``` Optional ```  ``` DefaultValue ```  | The QR code background color (you should always use a light color for this) |


#### Example Usage

```csharp
string content = "content";
int? width = 250;
int? height = 250;
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
| width |  ``` Optional ```  | If set resize the resulting image to this width (preserving aspect ratio) |
| height |  ``` Optional ```  | If set resize the resulting image to this height (preserving aspect ratio) |


#### Example Usage

```csharp
string imageUrl = "image-url";
string watermarkUrl = "watermark-url";
int? opacity = 50;
string format = "png";
string position = "center";
int? width = 247;
int? height = 247;

Stream result = await imaging.ImageWatermark(imageUrl, watermarkUrl, opacity, format, position, width, height);

```


### <a name="html5_render"></a>![Method: ](https://apidocs.io/img/method.png "NeutrinoAPI.Controllers.Imaging.HTML5Render") HTML5Render

> Render HTML and HTML5 content to PDF, JPG or PNG


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
        double? zoom = 1.0,
        bool? grayscale = false,
        bool? mediaPrint = false,
        bool? mediaQueries = false,
        bool? forms = false,
        string css = null,
        int? imageWidth = 1024,
        int? imageHeight = null)
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
double? zoom = 1.0;
bool? grayscale = false;
bool? mediaPrint = false;
bool? mediaQueries = false;
bool? forms = false;
string css = "css";
int? imageWidth = 1024;
int? imageHeight = 247;

Stream result = await imaging.HTML5Render(content, format, pageSize, title, margin, marginLeft, marginRight, marginTop, marginBottom, landscape, zoom, grayscale, mediaPrint, mediaQueries, forms, css, imageWidth, imageHeight);

```


[Back to List of Controllers](#list_of_controllers)



