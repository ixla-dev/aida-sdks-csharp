# Aida.Sdk.Api.InkjetTestApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInkUsage**](InkjetTestApi.md#getinkusage) | **POST** /aida/v1/inkjettest/ink-usage |  |
| [**OnlyPrintMultipass**](InkjetTestApi.md#onlyprintmultipass) | **POST** /aida/v1/inkjettest/only-print-new-multipass |  |
| [**OnlyPrintScanning**](InkjetTestApi.md#onlyprintscanning) | **POST** /aida/v1/inkjettest/only-print-scanning | Load and place manually the image all up (Y&#x3D;0) in Aprint, then start to print from here. |
| [**PrintMultipass**](InkjetTestApi.md#printmultipass) | **POST** /aida/v1/inkjettest/print-new-multipass |  |
| [**ReadCartridge**](InkjetTestApi.md#readcartridge) | **POST** /aida/v1/inkjettest/read-cartridge |  |
| [**ReadCartridgeFromJson**](InkjetTestApi.md#readcartridgefromjson) | **POST** /aida/v1/inkjettest/read-cartridge_from_json |  |
| [**ReadMachineStatus**](InkjetTestApi.md#readmachinestatus) | **POST** /aida/v1/inkjettest/read-machine-status |  |
| [**SetMultipassAlgorithm**](InkjetTestApi.md#setmultipassalgorithm) | **POST** /aida/v1/inkjettest/set-multipass-algorithm |  |
| [**SetPasses**](InkjetTestApi.md#setpasses) | **POST** /aida/v1/inkjettest/set-multipass-n-passes |  |
| [**SetPrintAlgorithm**](InkjetTestApi.md#setprintalgorithm) | **POST** /aida/v1/inkjettest/set-print-algorithm |  |
| [**TestWriteCartridges**](InkjetTestApi.md#testwritecartridges) | **POST** /aida/v1/inkjettest/test-cartridges |  |
| [**WriteCartridge**](InkjetTestApi.md#writecartridge) | **POST** /aida/v1/inkjettest/write-cartridge |  |
| [**WriteJsonCartridge**](InkjetTestApi.md#writejsoncartridge) | **POST** /aida/v1/inkjettest/write-json-cartridge |  |

<a id="getinkusage"></a>
# **GetInkUsage**
> void GetInkUsage ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GetInkUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetInkUsage();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.GetInkUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInkUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetInkUsageWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.GetInkUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="onlyprintmultipass"></a>
# **OnlyPrintMultipass**
> void OnlyPrintMultipass (PrintQuality? printQuality = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class OnlyPrintMultipassExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var printQuality = (PrintQuality) "Draft";  // PrintQuality? |  (optional) 

            try
            {
                apiInstance.OnlyPrintMultipass(printQuality);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.OnlyPrintMultipass: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnlyPrintMultipassWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.OnlyPrintMultipassWithHttpInfo(printQuality);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.OnlyPrintMultipassWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printQuality** | **PrintQuality?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="onlyprintscanning"></a>
# **OnlyPrintScanning**
> void OnlyPrintScanning (int? printPosition = null)

Load and place manually the image all up (Y=0) in Aprint, then start to print from here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class OnlyPrintScanningExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var printPosition = 0;  // int? | Y-axis offset in pixel (optional)  (default to 0)

            try
            {
                // Load and place manually the image all up (Y=0) in Aprint, then start to print from here.
                apiInstance.OnlyPrintScanning(printPosition);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.OnlyPrintScanning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnlyPrintScanningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load and place manually the image all up (Y=0) in Aprint, then start to print from here.
    apiInstance.OnlyPrintScanningWithHttpInfo(printPosition);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.OnlyPrintScanningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printPosition** | **int?** | Y-axis offset in pixel | [optional] [default to 0] |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="printmultipass"></a>
# **PrintMultipass**
> void PrintMultipass (string imagePath = null, int? x = null, int? y = null, int? angle = null, int? printPosition = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class PrintMultipassExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var imagePath = "imagePath_example";  // string |  (optional) 
            var x = 0;  // int? |  (optional)  (default to 0)
            var y = 0;  // int? |  (optional)  (default to 0)
            var angle = 270;  // int? |  (optional)  (default to 270)
            var printPosition = 0;  // int? |  (optional)  (default to 0)

            try
            {
                apiInstance.PrintMultipass(imagePath, x, y, angle, printPosition);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.PrintMultipass: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintMultipassWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PrintMultipassWithHttpInfo(imagePath, x, y, angle, printPosition);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.PrintMultipassWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imagePath** | **string** |  | [optional]  |
| **x** | **int?** |  | [optional] [default to 0] |
| **y** | **int?** |  | [optional] [default to 0] |
| **angle** | **int?** |  | [optional] [default to 270] |
| **printPosition** | **int?** |  | [optional] [default to 0] |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readcartridge"></a>
# **ReadCartridge**
> Cartridge ReadCartridge (ColorName? colorName = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class ReadCartridgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var colorName = (ColorName) "Black";  // ColorName? |  (optional) 

            try
            {
                Cartridge result = apiInstance.ReadCartridge(colorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.ReadCartridge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCartridgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cartridge> response = apiInstance.ReadCartridgeWithHttpInfo(colorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.ReadCartridgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **colorName** | **ColorName?** |  | [optional]  |

### Return type

[**Cartridge**](Cartridge.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readcartridgefromjson"></a>
# **ReadCartridgeFromJson**
> Cartridge ReadCartridgeFromJson ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class ReadCartridgeFromJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);

            try
            {
                Cartridge result = apiInstance.ReadCartridgeFromJson();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.ReadCartridgeFromJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCartridgeFromJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cartridge> response = apiInstance.ReadCartridgeFromJsonWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.ReadCartridgeFromJsonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Cartridge**](Cartridge.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readmachinestatus"></a>
# **ReadMachineStatus**
> void ReadMachineStatus ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class ReadMachineStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ReadMachineStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.ReadMachineStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadMachineStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReadMachineStatusWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.ReadMachineStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setmultipassalgorithm"></a>
# **SetMultipassAlgorithm**
> void SetMultipassAlgorithm (int? value = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class SetMultipassAlgorithmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var value = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetMultipassAlgorithm(value);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.SetMultipassAlgorithm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetMultipassAlgorithmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetMultipassAlgorithmWithHttpInfo(value);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.SetMultipassAlgorithmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **value** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpasses"></a>
# **SetPasses**
> void SetPasses (int? value = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class SetPassesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var value = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetPasses(value);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.SetPasses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPassesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetPassesWithHttpInfo(value);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.SetPassesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **value** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setprintalgorithm"></a>
# **SetPrintAlgorithm**
> void SetPrintAlgorithm (int? value = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class SetPrintAlgorithmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var value = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetPrintAlgorithm(value);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.SetPrintAlgorithm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPrintAlgorithmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetPrintAlgorithmWithHttpInfo(value);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.SetPrintAlgorithmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **value** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="testwritecartridges"></a>
# **TestWriteCartridges**
> void TestWriteCartridges ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class TestWriteCartridgesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.TestWriteCartridges();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.TestWriteCartridges: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestWriteCartridgesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TestWriteCartridgesWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.TestWriteCartridgesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="writecartridge"></a>
# **WriteCartridge**
> void WriteCartridge (ColorName? colorName = null, int? inkConsumed = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class WriteCartridgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);
            var colorName = (ColorName) "Black";  // ColorName? |  (optional) 
            var inkConsumed = 56;  // int? |  (optional) 

            try
            {
                apiInstance.WriteCartridge(colorName, inkConsumed);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.WriteCartridge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteCartridgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteCartridgeWithHttpInfo(colorName, inkConsumed);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.WriteCartridgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **colorName** | **ColorName?** |  | [optional]  |
| **inkConsumed** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="writejsoncartridge"></a>
# **WriteJsonCartridge**
> void WriteJsonCartridge ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class WriteJsonCartridgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InkjetTestApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.WriteJsonCartridge();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetTestApi.WriteJsonCartridge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteJsonCartridgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteJsonCartridgeWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetTestApi.WriteJsonCartridgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

