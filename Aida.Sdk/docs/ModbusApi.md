# Aida.Sdk.Api.ModbusApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AidaV1ModbusPortLoopReadPost**](ModbusApi.md#aidav1modbusportloopreadpost) | **POST** /aida/v1/modbus/{port}/loop-read |  |
| [**AidaV1ModbusPortSlaveIdHexRegistersGet**](ModbusApi.md#aidav1modbusportslaveidhexregistersget) | **GET** /aida/v1/modbus/{port}/{slaveId_hex}/registers |  |
| [**GetModbusClients**](ModbusApi.md#getmodbusclients) | **GET** /aida/v1/modbus/clients |  |
| [**ReadAllRegisters**](ModbusApi.md#readallregisters) | **GET** /aida/v1/modbus/{port}/{slaveId_hex}/registers/all |  |
| [**ReadHoldingRegisters**](ModbusApi.md#readholdingregisters) | **POST** /aida/v1/modbus/{port}/read-holding-registers |  |
| [**WriteSingleRegister**](ModbusApi.md#writesingleregister) | **POST** /aida/v1/modbus/{port}/write-register |  |

<a id="aidav1modbusportloopreadpost"></a>
# **AidaV1ModbusPortLoopReadPost**
> void AidaV1ModbusPortLoopReadPost (string port, int? slave = null, int? address = null, int? lenght = null)



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
    public class AidaV1ModbusPortLoopReadPostExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var slave = 56;  // int? |  (optional) 
            var address = 56;  // int? |  (optional) 
            var lenght = 56;  // int? |  (optional) 

            try
            {
                apiInstance.AidaV1ModbusPortLoopReadPost(port, slave, address, lenght);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.AidaV1ModbusPortLoopReadPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1ModbusPortLoopReadPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1ModbusPortLoopReadPostWithHttpInfo(port, slave, address, lenght);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.AidaV1ModbusPortLoopReadPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **slave** | **int?** |  | [optional]  |
| **address** | **int?** |  | [optional]  |
| **lenght** | **int?** |  | [optional]  |

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

<a id="aidav1modbusportslaveidhexregistersget"></a>
# **AidaV1ModbusPortSlaveIdHexRegistersGet**
> string AidaV1ModbusPortSlaveIdHexRegistersGet (string port, string slaveIdHex, string startHex = null, string lengthHex = null)



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
    public class AidaV1ModbusPortSlaveIdHexRegistersGetExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var slaveIdHex = "slaveIdHex_example";  // string | 
            var startHex = "startHex_example";  // string |  (optional) 
            var lengthHex = "lengthHex_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.AidaV1ModbusPortSlaveIdHexRegistersGet(port, slaveIdHex, startHex, lengthHex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.AidaV1ModbusPortSlaveIdHexRegistersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1ModbusPortSlaveIdHexRegistersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.AidaV1ModbusPortSlaveIdHexRegistersGetWithHttpInfo(port, slaveIdHex, startHex, lengthHex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.AidaV1ModbusPortSlaveIdHexRegistersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **slaveIdHex** | **string** |  |  |
| **startHex** | **string** |  | [optional]  |
| **lengthHex** | **string** |  | [optional]  |

### Return type

**string**

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

<a id="getmodbusclients"></a>
# **GetModbusClients**
> void GetModbusClients ()



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
    public class GetModbusClientsExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetModbusClients();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.GetModbusClients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetModbusClientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetModbusClientsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.GetModbusClientsWithHttpInfo: " + e.Message);
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

<a id="readallregisters"></a>
# **ReadAllRegisters**
> List&lt;int&gt; ReadAllRegisters (string slaveIdHex, string port)



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
    public class ReadAllRegistersExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var slaveIdHex = "slaveIdHex_example";  // string | 
            var port = "port_example";  // string | 

            try
            {
                List<int> result = apiInstance.ReadAllRegisters(slaveIdHex, port);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.ReadAllRegisters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadAllRegistersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<int>> response = apiInstance.ReadAllRegistersWithHttpInfo(slaveIdHex, port);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.ReadAllRegistersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slaveIdHex** | **string** |  |  |
| **port** | **string** |  |  |

### Return type

**List<int>**

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

<a id="readholdingregisters"></a>
# **ReadHoldingRegisters**
> void ReadHoldingRegisters (string port, string body = null)



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
    public class ReadHoldingRegistersExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var body = "body_example";  // string |  (optional) 

            try
            {
                apiInstance.ReadHoldingRegisters(port, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.ReadHoldingRegisters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadHoldingRegistersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReadHoldingRegistersWithHttpInfo(port, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.ReadHoldingRegistersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **body** | **string** |  | [optional]  |

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

<a id="writesingleregister"></a>
# **WriteSingleRegister**
> void WriteSingleRegister (string port, string body = null)



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
    public class WriteSingleRegisterExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var body = "body_example";  // string |  (optional) 

            try
            {
                apiInstance.WriteSingleRegister(port, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.WriteSingleRegister: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteSingleRegisterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteSingleRegisterWithHttpInfo(port, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.WriteSingleRegisterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **body** | **string** |  | [optional]  |

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

