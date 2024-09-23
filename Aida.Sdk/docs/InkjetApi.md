# Aida.Sdk.Api.InkjetApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddEntityToInkjetLayout**](InkjetApi.md#addentitytoinkjetlayout) | **POST** /aida/v1/inkjet/layouts/{inkjetLayoutId}/add-entity |  |
| [**AidaV1InkjetLogerrorIdPut**](InkjetApi.md#aidav1inkjetlogerroridput) | **PUT** /aida/v1/inkjet/logerror/{id} |  |
| [**AidaV1InkjetLogerrorPost**](InkjetApi.md#aidav1inkjetlogerrorpost) | **POST** /aida/v1/inkjet/logerror |  |
| [**AidaV1InkjetPrintStatusGet**](InkjetApi.md#aidav1inkjetprintstatusget) | **GET** /aida/v1/inkjet/print-status |  |
| [**AidaV1InkjetPrintheadMoveToPrintareaPost**](InkjetApi.md#aidav1inkjetprintheadmovetoprintareapost) | **POST** /aida/v1/inkjet/printhead/move-to-printarea |  |
| [**AidaV1InkjetSetPrintheadOffsetPost**](InkjetApi.md#aidav1inkjetsetprintheadoffsetpost) | **POST** /aida/v1/inkjet/set-printhead-offset |  |
| [**AidaV1InkjetStartCyclePost**](InkjetApi.md#aidav1inkjetstartcyclepost) | **POST** /aida/v1/inkjet/start-cycle |  |
| [**AidaV1InkjetStartPrintPost**](InkjetApi.md#aidav1inkjetstartprintpost) | **POST** /aida/v1/inkjet/start-print |  |
| [**CanPrint**](InkjetApi.md#canprint) | **GET** /aida/v1/inkjet/can-print |  |
| [**CloseJob**](InkjetApi.md#closejob) | **POST** /aida/v1/inkjet/shingling-close-job |  |
| [**CreateInkjetLayout**](InkjetApi.md#createinkjetlayout) | **POST** /aida/v1/inkjet/layouts/create/{inkjetLayoutName} |  |
| [**CreateNewJob**](InkjetApi.md#createnewjob) | **POST** /aida/v1/inkjet/board/create-new-job |  |
| [**DeleteInkjetLayout**](InkjetApi.md#deleteinkjetlayout) | **DELETE** /aida/v1/inkjet/layouts/{id} |  |
| [**EnablePrint**](InkjetApi.md#enableprint) | **POST** /aida/v1/inkjet/board/enable-print |  |
| [**FindInkjetLayouts**](InkjetApi.md#findinkjetlayouts) | **GET** /aida/v1/inkjet/layouts/find |  |
| [**GetActiveEntities**](InkjetApi.md#getactiveentities) | **GET** /aida/v1/inkjet/active-entities |  |
| [**GetAssignableInkjetLayoutsByJobTemplateId**](InkjetApi.md#getassignableinkjetlayoutsbyjobtemplateid) | **GET** /aida/v1/inkjet/job-templates/{id}/layouts/available |  |
| [**GetCleaningConfiguration**](InkjetApi.md#getcleaningconfiguration) | **GET** /aida/v1/inkjet/cleaning/configuration |  |
| [**GetCuringSettings**](InkjetApi.md#getcuringsettings) | **GET** /aida/v1/inkjet/settings/curing-settings |  |
| [**GetHeatersTemperature**](InkjetApi.md#getheaterstemperature) | **GET** /aida/v1/inkjet/settings/heaters-temperature |  |
| [**GetInkjetMaintenanceStatus**](InkjetApi.md#getinkjetmaintenancestatus) | **GET** /aida/v1/inkjet/maintenance/status |  |
| [**GetMultipassImages**](InkjetApi.md#getmultipassimages) | **GET** /aida/v1/inkjet/slicer/images.html |  |
| [**GetPinningSettings**](InkjetApi.md#getpinningsettings) | **GET** /aida/v1/inkjet/settings/pinning-settings |  |
| [**GetPrintLayoutPreview**](InkjetApi.md#getprintlayoutpreview) | **GET** /aida/v1/inkjet/get-print-layout-preview |  |
| [**GetPrinterPrintSettings**](InkjetApi.md#getprinterprintsettings) | **GET** /aida/v1/inkjet/settings/print-settings |  |
| [**GetVacuumPressure**](InkjetApi.md#getvacuumpressure) | **GET** /aida/v1/inkjet/cleaning/vacuum-pressure |  |
| [**GetXPrintState**](InkjetApi.md#getxprintstate) | **GET** /aida/v1/inkjet/state |  |
| [**InkjetLayoutPreview**](InkjetApi.md#inkjetlayoutpreview) | **GET** /aida/v1/inkjet/layouts/{inkjetLayoutId}/preview |  |
| [**InsertImage**](InkjetApi.md#insertimage) | **POST** /aida/v1/inkjet/board/insert-image |  |
| [**IsMultiPrintRunning**](InkjetApi.md#ismultiprintrunning) | **GET** /aida/v1/inkjet/settings/is-multi-print-running |  |
| [**IsPrinting**](InkjetApi.md#isprinting) | **GET** /aida/v1/inkjet/board/is-printing |  |
| [**IsReady**](InkjetApi.md#isready) | **GET** /aida/v1/inkjet/board/is-ready |  |
| [**JobInsertImage**](InkjetApi.md#jobinsertimage) | **POST** /aida/v1/inkjet/shingling-load-image |  |
| [**LoadInkjetLayout**](InkjetApi.md#loadinkjetlayout) | **POST** /aida/v1/inkjet/layouts/{inkjetLayoutId}/load |  |
| [**LoadTestImage**](InkjetApi.md#loadtestimage) | **GET** /aida/v1/inkjet/load-test-image |  |
| [**MoveHeadToCapping**](InkjetApi.md#moveheadtocapping) | **POST** /aida/v1/inkjet/cleaning/move-to-capping |  |
| [**MoveHeadToMaintenance**](InkjetApi.md#moveheadtomaintenance) | **POST** /aida/v1/inkjet/cleaning/move-to-maintenance |  |
| [**MoveHeadToParking**](InkjetApi.md#moveheadtoparking) | **POST** /aida/v1/inkjet/cleaning/move-to-parking |  |
| [**NewJob**](InkjetApi.md#newjob) | **POST** /aida/v1/inkjet/shingling-new-job |  |
| [**NozzleCheck**](InkjetApi.md#nozzlecheck) | **POST** /aida/v1/inkjet/nozzle-check | Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct |
| [**PerformDeepCleaning**](InkjetApi.md#performdeepcleaning) | **POST** /aida/v1/inkjet/cleaning/perform-deep-cleaning |  |
| [**PerformLightCleaning**](InkjetApi.md#performlightcleaning) | **POST** /aida/v1/inkjet/cleaning/perform-light-cleaning |  |
| [**PerformNormalCleaning**](InkjetApi.md#performnormalcleaning) | **POST** /aida/v1/inkjet/cleaning/perform-normal-cleaning |  |
| [**PerformPurge**](InkjetApi.md#performpurge) | **POST** /aida/v1/inkjet/cleaning/perform-purge |  |
| [**PerformSpitting**](InkjetApi.md#performspitting) | **POST** /aida/v1/inkjet/cleaning/perform-spitting |  |
| [**PerformWiping**](InkjetApi.md#performwiping) | **POST** /aida/v1/inkjet/cleaning/perform-wiping |  |
| [**Print**](InkjetApi.md#print) | **POST** /aida/v1/inkjet/print | Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images |
| [**PrintInkjetLayout**](InkjetApi.md#printinkjetlayout) | **POST** /aida/v1/inkjet/layouts/{inkjetLayoutId}/print |  |
| [**PrintTestImage**](InkjetApi.md#printtestimage) | **GET** /aida/v1/inkjet/print-test-image |  |
| [**RenameInkjetLayout**](InkjetApi.md#renameinkjetlayout) | **PUT** /aida/v1/inkjet/layouts/{id} |  |
| [**ResetInkjetPrinter**](InkjetApi.md#resetinkjetprinter) | **POST** /aida/v1/inkjet/reset |  |
| [**Resolution**](InkjetApi.md#resolution) | **GET** /aida/v1/inkjet/board/resolution |  |
| [**SetCleaningConfiguration**](InkjetApi.md#setcleaningconfiguration) | **POST** /aida/v1/inkjet/cleaning/configuration |  |
| [**SetCuringSettings**](InkjetApi.md#setcuringsettings) | **POST** /aida/v1/inkjet/settings/curing-settings |  |
| [**SetHeaterTemperature**](InkjetApi.md#setheatertemperature) | **POST** /aida/v1/inkjet/settings/heater-temperature |  |
| [**SetLampColor**](InkjetApi.md#setlampcolor) | **POST** /aida/v1/inkjet/set-lamp-color |  |
| [**SetPinningSettings**](InkjetApi.md#setpinningsettings) | **POST** /aida/v1/inkjet/settings/pinning-settings |  |
| [**SetPrintSettings**](InkjetApi.md#setprintsettings) | **POST** /aida/v1/inkjet/settings/print-settings |  |
| [**StartMultiPrint**](InkjetApi.md#startmultiprint) | **POST** /aida/v1/inkjet/settings/multi-print-start |  |
| [**StopMultiPrint**](InkjetApi.md#stopmultiprint) | **POST** /aida/v1/inkjet/settings/multi-print-stop |  |
| [**StopPrint**](InkjetApi.md#stopprint) | **POST** /aida/v1/inkjet/stop-print |  |
| [**ToggleCapping**](InkjetApi.md#togglecapping) | **POST** /aida/v1/inkjet/cleaning/toggle-capping |  |
| [**ToggleCappingPump**](InkjetApi.md#togglecappingpump) | **POST** /aida/v1/inkjet/cleaning/toggle-capping-pump |  |
| [**ToggleInkPriming**](InkjetApi.md#toggleinkpriming) | **POST** /aida/v1/inkjet/cleaning/toggle-ink-priming |  |
| [**ValidateInkjetLayoutName**](InkjetApi.md#validateinkjetlayoutname) | **POST** /aida/v1/inkjet/layouts/validate-name |  |

<a id="addentitytoinkjetlayout"></a>
# **AddEntityToInkjetLayout**
> void AddEntityToInkjetLayout (int inkjetLayoutId, string entityName = null, int? xPosition = null, int? yPosition = null, List<FileParameter> imageFile = null)



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
    public class AddEntityToInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 
            var entityName = "entityName_example";  // string |  (optional) 
            var xPosition = 56;  // int? |  (optional) 
            var yPosition = 56;  // int? |  (optional) 
            var imageFile = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                apiInstance.AddEntityToInkjetLayout(inkjetLayoutId, entityName, xPosition, yPosition, imageFile);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AddEntityToInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddEntityToInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddEntityToInkjetLayoutWithHttpInfo(inkjetLayoutId, entityName, xPosition, yPosition, imageFile);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AddEntityToInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |
| **entityName** | **string** |  | [optional]  |
| **xPosition** | **int?** |  | [optional]  |
| **yPosition** | **int?** |  | [optional]  |
| **imageFile** | **List&lt;FileParameter&gt;** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aidav1inkjetlogerroridput"></a>
# **AidaV1InkjetLogerrorIdPut**
> void AidaV1InkjetLogerrorIdPut (Guid id, AidaLogEntry aidaLogEntry = null)



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
    public class AidaV1InkjetLogerrorIdPutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var aidaLogEntry = new AidaLogEntry(); // AidaLogEntry |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetLogerrorIdPut(id, aidaLogEntry);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetLogerrorIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetLogerrorIdPutWithHttpInfo(id, aidaLogEntry);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **aidaLogEntry** | [**AidaLogEntry**](AidaLogEntry.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aidav1inkjetlogerrorpost"></a>
# **AidaV1InkjetLogerrorPost**
> void AidaV1InkjetLogerrorPost (AidaLogEntry aidaLogEntry = null)



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
    public class AidaV1InkjetLogerrorPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var aidaLogEntry = new AidaLogEntry(); // AidaLogEntry |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetLogerrorPost(aidaLogEntry);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetLogerrorPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetLogerrorPostWithHttpInfo(aidaLogEntry);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aidaLogEntry** | [**AidaLogEntry**](AidaLogEntry.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aidav1inkjetprintstatusget"></a>
# **AidaV1InkjetPrintStatusGet**
> PrintStatus AidaV1InkjetPrintStatusGet ()



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
    public class AidaV1InkjetPrintStatusGetExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PrintStatus result = apiInstance.AidaV1InkjetPrintStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetPrintStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrintStatus> response = apiInstance.AidaV1InkjetPrintStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrintStatus**](PrintStatus.md)

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

<a id="aidav1inkjetprintheadmovetoprintareapost"></a>
# **AidaV1InkjetPrintheadMoveToPrintareaPost**
> void AidaV1InkjetPrintheadMoveToPrintareaPost ()



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
    public class AidaV1InkjetPrintheadMoveToPrintareaPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1InkjetPrintheadMoveToPrintareaPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintheadMoveToPrintareaPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetPrintheadMoveToPrintareaPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetPrintheadMoveToPrintareaPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintheadMoveToPrintareaPostWithHttpInfo: " + e.Message);
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

<a id="aidav1inkjetsetprintheadoffsetpost"></a>
# **AidaV1InkjetSetPrintheadOffsetPost**
> void AidaV1InkjetSetPrintheadOffsetPost (int? x = null)



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
    public class AidaV1InkjetSetPrintheadOffsetPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var x = 56;  // int? |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetSetPrintheadOffsetPost(x);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetSetPrintheadOffsetPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetSetPrintheadOffsetPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetSetPrintheadOffsetPostWithHttpInfo(x);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetSetPrintheadOffsetPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **int?** |  | [optional]  |

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

<a id="aidav1inkjetstartcyclepost"></a>
# **AidaV1InkjetStartCyclePost**
> void AidaV1InkjetStartCyclePost (GenericCycleTypes? cycle = null)



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
    public class AidaV1InkjetStartCyclePostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var cycle = (GenericCycleTypes) "EngraveAndPrint";  // GenericCycleTypes? |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetStartCyclePost(cycle);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetStartCyclePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetStartCyclePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetStartCyclePostWithHttpInfo(cycle);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetStartCyclePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cycle** | **GenericCycleTypes?** |  | [optional]  |

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

<a id="aidav1inkjetstartprintpost"></a>
# **AidaV1InkjetStartPrintPost**
> void AidaV1InkjetStartPrintPost (int? x = null, PrintCycleModes? modes = null)



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
    public class AidaV1InkjetStartPrintPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var x = 56;  // int? |  (optional) 
            var modes = (PrintCycleModes) "PrintAndLaser";  // PrintCycleModes? |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetStartPrintPost(x, modes);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetStartPrintPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetStartPrintPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetStartPrintPostWithHttpInfo(x, modes);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetStartPrintPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **int?** |  | [optional]  |
| **modes** | **PrintCycleModes?** |  | [optional]  |

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

<a id="canprint"></a>
# **CanPrint**
> CanPrintDto CanPrint ()



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
    public class CanPrintExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                CanPrintDto result = apiInstance.CanPrint();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.CanPrint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CanPrintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CanPrintDto> response = apiInstance.CanPrintWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.CanPrintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CanPrintDto**](CanPrintDto.md)

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

<a id="closejob"></a>
# **CloseJob**
> void CloseJob ()



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
    public class CloseJobExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.CloseJob();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.CloseJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloseJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CloseJobWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.CloseJobWithHttpInfo: " + e.Message);
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

<a id="createinkjetlayout"></a>
# **CreateInkjetLayout**
> int CreateInkjetLayout (string inkjetLayoutName)



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
    public class CreateInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutName = "inkjetLayoutName_example";  // string | 

            try
            {
                int result = apiInstance.CreateInkjetLayout(inkjetLayoutName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.CreateInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.CreateInkjetLayoutWithHttpInfo(inkjetLayoutName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.CreateInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutName** | **string** |  |  |

### Return type

**int**

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

<a id="createnewjob"></a>
# **CreateNewJob**
> void CreateNewJob ()



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
    public class CreateNewJobExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.CreateNewJob();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.CreateNewJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateNewJobWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.CreateNewJobWithHttpInfo: " + e.Message);
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

<a id="deleteinkjetlayout"></a>
# **DeleteInkjetLayout**
> void DeleteInkjetLayout (int id)



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
    public class DeleteInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                apiInstance.DeleteInkjetLayout(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.DeleteInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteInkjetLayoutWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.DeleteInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

<a id="enableprint"></a>
# **EnablePrint**
> void EnablePrint ()



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
    public class EnablePrintExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.EnablePrint();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.EnablePrint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnablePrintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.EnablePrintWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.EnablePrintWithHttpInfo: " + e.Message);
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

<a id="findinkjetlayouts"></a>
# **FindInkjetLayouts**
> SearchInkjetLayoutsResultDto FindInkjetLayouts (bool? includeFile = null, bool? includeEntities = null, int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



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
    public class FindInkjetLayoutsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var includeFile = true;  // bool? |  (optional) 
            var includeEntities = true;  // bool? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchInkjetLayoutsResultDto result = apiInstance.FindInkjetLayouts(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.FindInkjetLayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindInkjetLayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchInkjetLayoutsResultDto> response = apiInstance.FindInkjetLayoutsWithHttpInfo(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.FindInkjetLayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeFile** | **bool?** |  | [optional]  |
| **includeEntities** | **bool?** |  | [optional]  |
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**SearchInkjetLayoutsResultDto**](SearchInkjetLayoutsResultDto.md)

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

<a id="getactiveentities"></a>
# **GetActiveEntities**
> InkjetLayoutDto GetActiveEntities ()



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
    public class GetActiveEntitiesExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetLayoutDto result = apiInstance.GetActiveEntities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetActiveEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActiveEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetLayoutDto> response = apiInstance.GetActiveEntitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetActiveEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InkjetLayoutDto**](InkjetLayoutDto.md)

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

<a id="getassignableinkjetlayoutsbyjobtemplateid"></a>
# **GetAssignableInkjetLayoutsByJobTemplateId**
> SearchInkjetLayoutsResultDto GetAssignableInkjetLayoutsByJobTemplateId (int id, int? page = null, int? pageSize = null, string supportSide = null)



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
    public class GetAssignableInkjetLayoutsByJobTemplateIdExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 15;  // int? |  (optional)  (default to 15)
            var supportSide = "supportSide_example";  // string |  (optional) 

            try
            {
                SearchInkjetLayoutsResultDto result = apiInstance.GetAssignableInkjetLayoutsByJobTemplateId(id, page, pageSize, supportSide);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetAssignableInkjetLayoutsByJobTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchInkjetLayoutsResultDto> response = apiInstance.GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo(id, page, pageSize, supportSide);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 15] |
| **supportSide** | **string** |  | [optional]  |

### Return type

[**SearchInkjetLayoutsResultDto**](SearchInkjetLayoutsResultDto.md)

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

<a id="getcleaningconfiguration"></a>
# **GetCleaningConfiguration**
> CleaningConfigurationDto GetCleaningConfiguration ()



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
    public class GetCleaningConfigurationExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                CleaningConfigurationDto result = apiInstance.GetCleaningConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetCleaningConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCleaningConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CleaningConfigurationDto> response = apiInstance.GetCleaningConfigurationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetCleaningConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CleaningConfigurationDto**](CleaningConfigurationDto.md)

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

<a id="getcuringsettings"></a>
# **GetCuringSettings**
> CuringSettingsDto GetCuringSettings ()



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
    public class GetCuringSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                CuringSettingsDto result = apiInstance.GetCuringSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetCuringSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCuringSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CuringSettingsDto> response = apiInstance.GetCuringSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetCuringSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CuringSettingsDto**](CuringSettingsDto.md)

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

<a id="getheaterstemperature"></a>
# **GetHeatersTemperature**
> InkjetTemperaturesDto GetHeatersTemperature ()



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
    public class GetHeatersTemperatureExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetTemperaturesDto result = apiInstance.GetHeatersTemperature();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetHeatersTemperature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHeatersTemperatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetTemperaturesDto> response = apiInstance.GetHeatersTemperatureWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetHeatersTemperatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InkjetTemperaturesDto**](InkjetTemperaturesDto.md)

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

<a id="getinkjetmaintenancestatus"></a>
# **GetInkjetMaintenanceStatus**
> InkjetMaintenanceStatusDto GetInkjetMaintenanceStatus ()



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
    public class GetInkjetMaintenanceStatusExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetMaintenanceStatusDto result = apiInstance.GetInkjetMaintenanceStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetInkjetMaintenanceStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInkjetMaintenanceStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetMaintenanceStatusDto> response = apiInstance.GetInkjetMaintenanceStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetInkjetMaintenanceStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InkjetMaintenanceStatusDto**](InkjetMaintenanceStatusDto.md)

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

<a id="getmultipassimages"></a>
# **GetMultipassImages**
> void GetMultipassImages ()



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
    public class GetMultipassImagesExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetMultipassImages();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetMultipassImages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMultipassImagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetMultipassImagesWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetMultipassImagesWithHttpInfo: " + e.Message);
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

<a id="getpinningsettings"></a>
# **GetPinningSettings**
> PinningSettingsDto GetPinningSettings ()



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
    public class GetPinningSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PinningSettingsDto result = apiInstance.GetPinningSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetPinningSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPinningSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PinningSettingsDto> response = apiInstance.GetPinningSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetPinningSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PinningSettingsDto**](PinningSettingsDto.md)

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

<a id="getprintlayoutpreview"></a>
# **GetPrintLayoutPreview**
> void GetPrintLayoutPreview ()



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
    public class GetPrintLayoutPreviewExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPrintLayoutPreview();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetPrintLayoutPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrintLayoutPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetPrintLayoutPreviewWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetPrintLayoutPreviewWithHttpInfo: " + e.Message);
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

<a id="getprinterprintsettings"></a>
# **GetPrinterPrintSettings**
> PrintSettingsDto GetPrinterPrintSettings ()



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
    public class GetPrinterPrintSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PrintSettingsDto result = apiInstance.GetPrinterPrintSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetPrinterPrintSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrinterPrintSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrintSettingsDto> response = apiInstance.GetPrinterPrintSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetPrinterPrintSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrintSettingsDto**](PrintSettingsDto.md)

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

<a id="getvacuumpressure"></a>
# **GetVacuumPressure**
> float GetVacuumPressure ()



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
    public class GetVacuumPressureExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                float result = apiInstance.GetVacuumPressure();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetVacuumPressure: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVacuumPressureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<float> response = apiInstance.GetVacuumPressureWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetVacuumPressureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**float**

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

<a id="getxprintstate"></a>
# **GetXPrintState**
> PrinterStateDto GetXPrintState ()



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
    public class GetXPrintStateExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PrinterStateDto result = apiInstance.GetXPrintState();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetXPrintState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetXPrintStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrinterStateDto> response = apiInstance.GetXPrintStateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetXPrintStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrinterStateDto**](PrinterStateDto.md)

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

<a id="inkjetlayoutpreview"></a>
# **InkjetLayoutPreview**
> void InkjetLayoutPreview (int inkjetLayoutId)



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
    public class InkjetLayoutPreviewExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 

            try
            {
                apiInstance.InkjetLayoutPreview(inkjetLayoutId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.InkjetLayoutPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InkjetLayoutPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.InkjetLayoutPreviewWithHttpInfo(inkjetLayoutId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.InkjetLayoutPreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |

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

<a id="insertimage"></a>
# **InsertImage**
> void InsertImage (string entityName = null, int? x = null, int? y = null, int? pageId = null, List<FileParameter> images = null)



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
    public class InsertImageExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var entityName = "entityName_example";  // string |  (optional) 
            var x = 56;  // int? |  (optional) 
            var y = 56;  // int? |  (optional) 
            var pageId = 56;  // int? |  (optional) 
            var images = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                apiInstance.InsertImage(entityName, x, y, pageId, images);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.InsertImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InsertImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.InsertImageWithHttpInfo(entityName, x, y, pageId, images);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.InsertImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  | [optional]  |
| **x** | **int?** |  | [optional]  |
| **y** | **int?** |  | [optional]  |
| **pageId** | **int?** |  | [optional]  |
| **images** | **List&lt;FileParameter&gt;** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ismultiprintrunning"></a>
# **IsMultiPrintRunning**
> bool IsMultiPrintRunning ()



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
    public class IsMultiPrintRunningExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                bool result = apiInstance.IsMultiPrintRunning();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.IsMultiPrintRunning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsMultiPrintRunningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<bool> response = apiInstance.IsMultiPrintRunningWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.IsMultiPrintRunningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**bool**

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

<a id="isprinting"></a>
# **IsPrinting**
> void IsPrinting ()



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
    public class IsPrintingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.IsPrinting();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.IsPrinting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsPrintingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.IsPrintingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.IsPrintingWithHttpInfo: " + e.Message);
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

<a id="isready"></a>
# **IsReady**
> void IsReady ()



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
    public class IsReadyExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.IsReady();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.IsReady: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsReadyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.IsReadyWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.IsReadyWithHttpInfo: " + e.Message);
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

<a id="jobinsertimage"></a>
# **JobInsertImage**
> void JobInsertImage (string imagePath = null, int? angle = null, int? x = null, int? y = null)



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
    public class JobInsertImageExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var imagePath = "imagePath_example";  // string |  (optional) 
            var angle = 56;  // int? |  (optional) 
            var x = 56;  // int? |  (optional) 
            var y = 56;  // int? |  (optional) 

            try
            {
                apiInstance.JobInsertImage(imagePath, angle, x, y);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.JobInsertImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JobInsertImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.JobInsertImageWithHttpInfo(imagePath, angle, x, y);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.JobInsertImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imagePath** | **string** |  | [optional]  |
| **angle** | **int?** |  | [optional]  |
| **x** | **int?** |  | [optional]  |
| **y** | **int?** |  | [optional]  |

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

<a id="loadinkjetlayout"></a>
# **LoadInkjetLayout**
> void LoadInkjetLayout (int inkjetLayoutId)



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
    public class LoadInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 

            try
            {
                apiInstance.LoadInkjetLayout(inkjetLayoutId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.LoadInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LoadInkjetLayoutWithHttpInfo(inkjetLayoutId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.LoadInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |

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

<a id="loadtestimage"></a>
# **LoadTestImage**
> void LoadTestImage (int? x = null, int? y = null, int? pageId = null)



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
    public class LoadTestImageExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var x = 56;  // int? |  (optional) 
            var y = 56;  // int? |  (optional) 
            var pageId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.LoadTestImage(x, y, pageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.LoadTestImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadTestImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LoadTestImageWithHttpInfo(x, y, pageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.LoadTestImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **int?** |  | [optional]  |
| **y** | **int?** |  | [optional]  |
| **pageId** | **int?** |  | [optional]  |

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

<a id="moveheadtocapping"></a>
# **MoveHeadToCapping**
> void MoveHeadToCapping ()



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
    public class MoveHeadToCappingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.MoveHeadToCapping();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.MoveHeadToCapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveHeadToCappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MoveHeadToCappingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.MoveHeadToCappingWithHttpInfo: " + e.Message);
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

<a id="moveheadtomaintenance"></a>
# **MoveHeadToMaintenance**
> void MoveHeadToMaintenance ()



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
    public class MoveHeadToMaintenanceExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.MoveHeadToMaintenance();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.MoveHeadToMaintenance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveHeadToMaintenanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MoveHeadToMaintenanceWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.MoveHeadToMaintenanceWithHttpInfo: " + e.Message);
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

<a id="moveheadtoparking"></a>
# **MoveHeadToParking**
> void MoveHeadToParking ()



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
    public class MoveHeadToParkingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.MoveHeadToParking();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.MoveHeadToParking: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveHeadToParkingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MoveHeadToParkingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.MoveHeadToParkingWithHttpInfo: " + e.Message);
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

<a id="newjob"></a>
# **NewJob**
> void NewJob (string imagePath = null)



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
    public class NewJobExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var imagePath = "imagePath_example";  // string |  (optional) 

            try
            {
                apiInstance.NewJob(imagePath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.NewJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.NewJobWithHttpInfo(imagePath);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.NewJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imagePath** | **string** |  | [optional]  |

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

<a id="nozzlecheck"></a>
# **NozzleCheck**
> void NozzleCheck ()

Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct

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
    public class NozzleCheckExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                // Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct
                apiInstance.NozzleCheck();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.NozzleCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NozzleCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct
    apiInstance.NozzleCheckWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.NozzleCheckWithHttpInfo: " + e.Message);
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

<a id="performdeepcleaning"></a>
# **PerformDeepCleaning**
> void PerformDeepCleaning (int? strongPurgeCount = null, int? normalPurgeCount = null, bool? includeLightCleaning = null)



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
    public class PerformDeepCleaningExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var strongPurgeCount = 56;  // int? |  (optional) 
            var normalPurgeCount = 56;  // int? |  (optional) 
            var includeLightCleaning = true;  // bool? |  (optional) 

            try
            {
                apiInstance.PerformDeepCleaning(strongPurgeCount, normalPurgeCount, includeLightCleaning);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformDeepCleaning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformDeepCleaningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformDeepCleaningWithHttpInfo(strongPurgeCount, normalPurgeCount, includeLightCleaning);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformDeepCleaningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **strongPurgeCount** | **int?** |  | [optional]  |
| **normalPurgeCount** | **int?** |  | [optional]  |
| **includeLightCleaning** | **bool?** |  | [optional]  |

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

<a id="performlightcleaning"></a>
# **PerformLightCleaning**
> void PerformLightCleaning (bool? wipeBefore = null)



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
    public class PerformLightCleaningExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var wipeBefore = true;  // bool? |  (optional) 

            try
            {
                apiInstance.PerformLightCleaning(wipeBefore);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformLightCleaning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformLightCleaningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformLightCleaningWithHttpInfo(wipeBefore);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformLightCleaningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wipeBefore** | **bool?** |  | [optional]  |

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

<a id="performnormalcleaning"></a>
# **PerformNormalCleaning**
> void PerformNormalCleaning (int? purgeCount = null, bool? includeLightCleaning = null)



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
    public class PerformNormalCleaningExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var purgeCount = 56;  // int? |  (optional) 
            var includeLightCleaning = true;  // bool? |  (optional) 

            try
            {
                apiInstance.PerformNormalCleaning(purgeCount, includeLightCleaning);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformNormalCleaning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformNormalCleaningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformNormalCleaningWithHttpInfo(purgeCount, includeLightCleaning);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformNormalCleaningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **purgeCount** | **int?** |  | [optional]  |
| **includeLightCleaning** | **bool?** |  | [optional]  |

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

<a id="performpurge"></a>
# **PerformPurge**
> void PerformPurge (bool? useStrong = null)



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
    public class PerformPurgeExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var useStrong = false;  // bool? |  (optional)  (default to false)

            try
            {
                apiInstance.PerformPurge(useStrong);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformPurge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformPurgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformPurgeWithHttpInfo(useStrong);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformPurgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **useStrong** | **bool?** |  | [optional] [default to false] |

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

<a id="performspitting"></a>
# **PerformSpitting**
> void PerformSpitting (int? firingSpeed = null, int? numSpits = null)



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
    public class PerformSpittingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var firingSpeed = 56;  // int? |  (optional) 
            var numSpits = 56;  // int? |  (optional) 

            try
            {
                apiInstance.PerformSpitting(firingSpeed, numSpits);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformSpitting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformSpittingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformSpittingWithHttpInfo(firingSpeed, numSpits);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformSpittingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firingSpeed** | **int?** |  | [optional]  |
| **numSpits** | **int?** |  | [optional]  |

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

<a id="performwiping"></a>
# **PerformWiping**
> void PerformWiping ()



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
    public class PerformWipingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PerformWiping();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformWiping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformWipingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformWipingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformWipingWithHttpInfo: " + e.Message);
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

<a id="print"></a>
# **Print**
> void Print (int? offsetX = null, int? offsetY = null, int? pageId = null, int? printSettingsId = null, int? passes = null, PrintCycleModes? printCycle = null)

Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images

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
    public class PrintExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var offsetX = 56;  // int? |  (optional) 
            var offsetY = 56;  // int? |  (optional) 
            var pageId = 56;  // int? |  (optional) 
            var printSettingsId = 56;  // int? |  (optional) 
            var passes = 56;  // int? |  (optional) 
            var printCycle = (PrintCycleModes) "PrintAndLaser";  // PrintCycleModes? |  (optional) 

            try
            {
                // Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images
                apiInstance.Print(offsetX, offsetY, pageId, printSettingsId, passes, printCycle);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.Print: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images
    apiInstance.PrintWithHttpInfo(offsetX, offsetY, pageId, printSettingsId, passes, printCycle);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PrintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offsetX** | **int?** |  | [optional]  |
| **offsetY** | **int?** |  | [optional]  |
| **pageId** | **int?** |  | [optional]  |
| **printSettingsId** | **int?** |  | [optional]  |
| **passes** | **int?** |  | [optional]  |
| **printCycle** | **PrintCycleModes?** |  | [optional]  |

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

<a id="printinkjetlayout"></a>
# **PrintInkjetLayout**
> void PrintInkjetLayout (int inkjetLayoutId, int? offsetX = null, int? offsetY = null)



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
    public class PrintInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 
            var offsetX = 56;  // int? |  (optional) 
            var offsetY = 56;  // int? |  (optional) 

            try
            {
                apiInstance.PrintInkjetLayout(inkjetLayoutId, offsetX, offsetY);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PrintInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PrintInkjetLayoutWithHttpInfo(inkjetLayoutId, offsetX, offsetY);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PrintInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |
| **offsetX** | **int?** |  | [optional]  |
| **offsetY** | **int?** |  | [optional]  |

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

<a id="printtestimage"></a>
# **PrintTestImage**
> void PrintTestImage ()



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
    public class PrintTestImageExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PrintTestImage();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PrintTestImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintTestImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PrintTestImageWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PrintTestImageWithHttpInfo: " + e.Message);
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

<a id="renameinkjetlayout"></a>
# **RenameInkjetLayout**
> InkjetLayoutDto RenameInkjetLayout (int id, string name = null)



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
    public class RenameInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var name = "name_example";  // string |  (optional) 

            try
            {
                InkjetLayoutDto result = apiInstance.RenameInkjetLayout(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.RenameInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetLayoutDto> response = apiInstance.RenameInkjetLayoutWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.RenameInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **name** | **string** |  | [optional]  |

### Return type

[**InkjetLayoutDto**](InkjetLayoutDto.md)

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

<a id="resetinkjetprinter"></a>
# **ResetInkjetPrinter**
> void ResetInkjetPrinter ()



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
    public class ResetInkjetPrinterExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ResetInkjetPrinter();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ResetInkjetPrinter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetInkjetPrinterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ResetInkjetPrinterWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ResetInkjetPrinterWithHttpInfo: " + e.Message);
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

<a id="resolution"></a>
# **Resolution**
> void Resolution ()



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
    public class ResolutionExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.Resolution();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.Resolution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ResolutionWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ResolutionWithHttpInfo: " + e.Message);
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

<a id="setcleaningconfiguration"></a>
# **SetCleaningConfiguration**
> void SetCleaningConfiguration (CleaningConfigurationDto cleaningConfigurationDto = null)



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
    public class SetCleaningConfigurationExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var cleaningConfigurationDto = new CleaningConfigurationDto(); // CleaningConfigurationDto |  (optional) 

            try
            {
                apiInstance.SetCleaningConfiguration(cleaningConfigurationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetCleaningConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetCleaningConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetCleaningConfigurationWithHttpInfo(cleaningConfigurationDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetCleaningConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cleaningConfigurationDto** | [**CleaningConfigurationDto**](CleaningConfigurationDto.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setcuringsettings"></a>
# **SetCuringSettings**
> void SetCuringSettings (bool? curingEnabled = null, bool? dualCuringEnabled = null, bool? fumeExtractorEnabled = null, int? level = null, int? speed = null)



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
    public class SetCuringSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var curingEnabled = true;  // bool? |  (optional) 
            var dualCuringEnabled = true;  // bool? |  (optional) 
            var fumeExtractorEnabled = true;  // bool? |  (optional) 
            var level = 56;  // int? |  (optional) 
            var speed = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetCuringSettings(curingEnabled, dualCuringEnabled, fumeExtractorEnabled, level, speed);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetCuringSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetCuringSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetCuringSettingsWithHttpInfo(curingEnabled, dualCuringEnabled, fumeExtractorEnabled, level, speed);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetCuringSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **curingEnabled** | **bool?** |  | [optional]  |
| **dualCuringEnabled** | **bool?** |  | [optional]  |
| **fumeExtractorEnabled** | **bool?** |  | [optional]  |
| **level** | **int?** |  | [optional]  |
| **speed** | **int?** |  | [optional]  |

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

<a id="setheatertemperature"></a>
# **SetHeaterTemperature**
> void SetHeaterTemperature (int? heaterTemperature = null)



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
    public class SetHeaterTemperatureExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var heaterTemperature = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetHeaterTemperature(heaterTemperature);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetHeaterTemperature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetHeaterTemperatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetHeaterTemperatureWithHttpInfo(heaterTemperature);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetHeaterTemperatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **heaterTemperature** | **int?** |  | [optional]  |

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

<a id="setlampcolor"></a>
# **SetLampColor**
> void SetLampColor (GenericLampColors? color = null)



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
    public class SetLampColorExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var color = (GenericLampColors) "Auto";  // GenericLampColors? |  (optional) 

            try
            {
                apiInstance.SetLampColor(color);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetLampColor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetLampColorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetLampColorWithHttpInfo(color);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetLampColorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **color** | **GenericLampColors?** |  | [optional]  |

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

<a id="setpinningsettings"></a>
# **SetPinningSettings**
> void SetPinningSettings (bool? enabled = null, int? level = null)



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
    public class SetPinningSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var enabled = true;  // bool? |  (optional) 
            var level = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetPinningSettings(enabled, level);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetPinningSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPinningSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetPinningSettingsWithHttpInfo(enabled, level);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetPinningSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enabled** | **bool?** |  | [optional]  |
| **level** | **int?** |  | [optional]  |

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

<a id="setprintsettings"></a>
# **SetPrintSettings**
> void SetPrintSettings (int? jobTemplateInkjetLayoutId = null, int? id = null, int? printSpeed = null, bool? verticalMirrorEnabled = null, bool? horizontalMirrorEnabled = null, bool? cMYKDirectEnabled = null, bool? enableC = null, bool? enableM = null, bool? enableY = null, bool? enableK = null, int? dropSize = null, bool? multipass = null, int? numberOfPasses = null, int? dataPageId = null)



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
    public class SetPrintSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var jobTemplateInkjetLayoutId = 56;  // int? |  (optional) 
            var id = 56;  // int? |  (optional) 
            var printSpeed = 56;  // int? |  (optional) 
            var verticalMirrorEnabled = true;  // bool? |  (optional) 
            var horizontalMirrorEnabled = true;  // bool? |  (optional) 
            var cMYKDirectEnabled = true;  // bool? |  (optional) 
            var enableC = true;  // bool? |  (optional) 
            var enableM = true;  // bool? |  (optional) 
            var enableY = true;  // bool? |  (optional) 
            var enableK = true;  // bool? |  (optional) 
            var dropSize = 56;  // int? |  (optional) 
            var multipass = true;  // bool? |  (optional) 
            var numberOfPasses = 56;  // int? |  (optional) 
            var dataPageId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetPrintSettings(jobTemplateInkjetLayoutId, id, printSpeed, verticalMirrorEnabled, horizontalMirrorEnabled, cMYKDirectEnabled, enableC, enableM, enableY, enableK, dropSize, multipass, numberOfPasses, dataPageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetPrintSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPrintSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetPrintSettingsWithHttpInfo(jobTemplateInkjetLayoutId, id, printSpeed, verticalMirrorEnabled, horizontalMirrorEnabled, cMYKDirectEnabled, enableC, enableM, enableY, enableK, dropSize, multipass, numberOfPasses, dataPageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetPrintSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateInkjetLayoutId** | **int?** |  | [optional]  |
| **id** | **int?** |  | [optional]  |
| **printSpeed** | **int?** |  | [optional]  |
| **verticalMirrorEnabled** | **bool?** |  | [optional]  |
| **horizontalMirrorEnabled** | **bool?** |  | [optional]  |
| **cMYKDirectEnabled** | **bool?** |  | [optional]  |
| **enableC** | **bool?** |  | [optional]  |
| **enableM** | **bool?** |  | [optional]  |
| **enableY** | **bool?** |  | [optional]  |
| **enableK** | **bool?** |  | [optional]  |
| **dropSize** | **int?** |  | [optional]  |
| **multipass** | **bool?** |  | [optional]  |
| **numberOfPasses** | **int?** |  | [optional]  |
| **dataPageId** | **int?** |  | [optional]  |

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

<a id="startmultiprint"></a>
# **StartMultiPrint**
> void StartMultiPrint (int? xRepetitions = null, int? xOffset = null, int? yRepetitions = null, int? yDelta = null, float? areaWidth = null)



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
    public class StartMultiPrintExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var xRepetitions = 56;  // int? |  (optional) 
            var xOffset = 56;  // int? |  (optional) 
            var yRepetitions = 56;  // int? |  (optional) 
            var yDelta = 56;  // int? |  (optional) 
            var areaWidth = 3.4F;  // float? |  (optional) 

            try
            {
                apiInstance.StartMultiPrint(xRepetitions, xOffset, yRepetitions, yDelta, areaWidth);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.StartMultiPrint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartMultiPrintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StartMultiPrintWithHttpInfo(xRepetitions, xOffset, yRepetitions, yDelta, areaWidth);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.StartMultiPrintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xRepetitions** | **int?** |  | [optional]  |
| **xOffset** | **int?** |  | [optional]  |
| **yRepetitions** | **int?** |  | [optional]  |
| **yDelta** | **int?** |  | [optional]  |
| **areaWidth** | **float?** |  | [optional]  |

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

<a id="stopmultiprint"></a>
# **StopMultiPrint**
> void StopMultiPrint ()



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
    public class StopMultiPrintExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.StopMultiPrint();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.StopMultiPrint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopMultiPrintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StopMultiPrintWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.StopMultiPrintWithHttpInfo: " + e.Message);
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

<a id="stopprint"></a>
# **StopPrint**
> void StopPrint ()



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
    public class StopPrintExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.StopPrint();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.StopPrint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopPrintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StopPrintWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.StopPrintWithHttpInfo: " + e.Message);
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

<a id="togglecapping"></a>
# **ToggleCapping**
> void ToggleCapping (bool? moveUp = null)



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
    public class ToggleCappingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var moveUp = false;  // bool? |  (optional)  (default to false)

            try
            {
                apiInstance.ToggleCapping(moveUp);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ToggleCapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToggleCappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToggleCappingWithHttpInfo(moveUp);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ToggleCappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moveUp** | **bool?** |  | [optional] [default to false] |

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

<a id="togglecappingpump"></a>
# **ToggleCappingPump**
> void ToggleCappingPump (bool? stop = null)



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
    public class ToggleCappingPumpExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var stop = true;  // bool? |  (optional)  (default to true)

            try
            {
                apiInstance.ToggleCappingPump(stop);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ToggleCappingPump: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToggleCappingPumpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToggleCappingPumpWithHttpInfo(stop);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ToggleCappingPumpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stop** | **bool?** |  | [optional] [default to true] |

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

<a id="toggleinkpriming"></a>
# **ToggleInkPriming**
> void ToggleInkPriming (bool? stop = null)



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
    public class ToggleInkPrimingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var stop = true;  // bool? |  (optional)  (default to true)

            try
            {
                apiInstance.ToggleInkPriming(stop);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ToggleInkPriming: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToggleInkPrimingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToggleInkPrimingWithHttpInfo(stop);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ToggleInkPrimingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stop** | **bool?** |  | [optional] [default to true] |

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

<a id="validateinkjetlayoutname"></a>
# **ValidateInkjetLayoutName**
> NameValidationResultDto ValidateInkjetLayoutName (string scannerId = null, string body = null)



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
    public class ValidateInkjetLayoutNameExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var body = "body_example";  // string |  (optional) 

            try
            {
                NameValidationResultDto result = apiInstance.ValidateInkjetLayoutName(scannerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ValidateInkjetLayoutName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateInkjetLayoutNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NameValidationResultDto> response = apiInstance.ValidateInkjetLayoutNameWithHttpInfo(scannerId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ValidateInkjetLayoutNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **body** | **string** |  | [optional]  |

### Return type

[**NameValidationResultDto**](NameValidationResultDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

