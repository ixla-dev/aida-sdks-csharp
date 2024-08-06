# Aida.Sdk.Api.WorkflowSchedulerApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AidaV1WorkflowSchedulerNamedLocksReleasePost**](WorkflowSchedulerApi.md#aidav1workflowschedulernamedlocksreleasepost) | **POST** /aida/v1/workflow-scheduler/named-locks/release |  |
| [**AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGet**](WorkflowSchedulerApi.md#aidav1workflowschedulersessionscurrentjobinstancesget) | **GET** /aida/v1/workflow-scheduler/sessions/current/job-instances |  |
| [**CancelRunningWorkflowInstances**](WorkflowSchedulerApi.md#cancelrunningworkflowinstances) | **POST** /aida/v1/workflow-scheduler/workflow-instances/running/_cancel |  |
| [**CancelSuspendedWorkflows**](WorkflowSchedulerApi.md#cancelsuspendedworkflows) | **POST** /aida/v1/workflow-scheduler/workflow-instances/suspended/cancel |  |
| [**CancelWorkflowInstance**](WorkflowSchedulerApi.md#cancelworkflowinstance) | **POST** /aida/v1/workflow-scheduler/workflow-instances/{id}/_cancel |  |
| [**ClearPrintQueue**](WorkflowSchedulerApi.md#clearprintqueue) | **DELETE** /aida/v1/workflow-scheduler/print-queue |  |
| [**DeleteWorkflowInstances**](WorkflowSchedulerApi.md#deleteworkflowinstances) | **DELETE** /aida/v1/workflow-scheduler/workflow-instances |  |
| [**GetJobStatus**](WorkflowSchedulerApi.md#getjobstatus) | **POST** /aida/v1/workflow-scheduler/jobs/info |  |
| [**GetMetrics**](WorkflowSchedulerApi.md#getmetrics) | **GET** /aida/v1/workflow-scheduler/metrics |  |
| [**GetNamedLock**](WorkflowSchedulerApi.md#getnamedlock) | **GET** /aida/v1/workflow-scheduler/named-locks/{resourceName} |  |
| [**GetQueuedJobs**](WorkflowSchedulerApi.md#getqueuedjobs) | **GET** /aida/v1/workflow-scheduler/queued-jobs |  |
| [**GetResumeItems**](WorkflowSchedulerApi.md#getresumeitems) | **GET** /aida/v1/workflow-scheduler/resume-items |  |
| [**GetRunningWorkflowIds**](WorkflowSchedulerApi.md#getrunningworkflowids) | **GET** /aida/v1/workflow-scheduler/workflow-instances/running |  |
| [**GetRunningWorkflows**](WorkflowSchedulerApi.md#getrunningworkflows) | **GET** /aida/v1/workflow-scheduler/workflows/running |  |
| [**GetSuspendedWorkflows**](WorkflowSchedulerApi.md#getsuspendedworkflows) | **GET** /aida/v1/workflow-scheduler/workflow-instances/suspended |  |
| [**GetWorkflowBlueprints**](WorkflowSchedulerApi.md#getworkflowblueprints) | **GET** /aida/v1/workflow-scheduler/workflow-blueprints |  |
| [**GetWorkflowContextByWorkflowInstanceId**](WorkflowSchedulerApi.md#getworkflowcontextbyworkflowinstanceid) | **GET** /aida/v1/workflow-scheduler/workflows/{workflowInstanceId}/context |  |
| [**GetWorkflowInstances**](WorkflowSchedulerApi.md#getworkflowinstances) | **GET** /aida/v1/workflow-scheduler/workflow-instances |  |
| [**GetWorkflowRegistry**](WorkflowSchedulerApi.md#getworkflowregistry) | **GET** /aida/v1/workflow-scheduler/workflow-registry |  |
| [**GetWorkflowSchedulerState**](WorkflowSchedulerApi.md#getworkflowschedulerstate) | **GET** /aida/v1/workflow-scheduler/state |  |
| [**ListNamedLocks**](WorkflowSchedulerApi.md#listnamedlocks) | **GET** /aida/v1/workflow-scheduler/named-locks |  |
| [**ResumeWorkflowScheduler**](WorkflowSchedulerApi.md#resumeworkflowscheduler) | **POST** /aida/v1/workflow-scheduler/resume |  |
| [**SignalExternalProcessCompleted**](WorkflowSchedulerApi.md#signalexternalprocesscompleted) | **POST** /aida/v1/workflow-scheduler/workflows/signal/external-process-completed | Notifies a suspended workflow instance when that the external process has completed execution |
| [**StartWorkflowScheduler**](WorkflowSchedulerApi.md#startworkflowscheduler) | **POST** /aida/v1/workflow-scheduler/start |  |
| [**StopWorkflowScheduler**](WorkflowSchedulerApi.md#stopworkflowscheduler) | **POST** /aida/v1/workflow-scheduler/stop |  |
| [**UpdateInvalidDatabaseEntries**](WorkflowSchedulerApi.md#updateinvaliddatabaseentries) | **GET** /aida/v1/workflow-scheduler/update-invalid-database-entries |  |

<a id="aidav1workflowschedulernamedlocksreleasepost"></a>
# **AidaV1WorkflowSchedulerNamedLocksReleasePost**
> void AidaV1WorkflowSchedulerNamedLocksReleasePost (int? ownerId = null, string name = null)



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
    public class AidaV1WorkflowSchedulerNamedLocksReleasePostExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var ownerId = 56;  // int? |  (optional) 
            var name = "name_example";  // string |  (optional) 

            try
            {
                apiInstance.AidaV1WorkflowSchedulerNamedLocksReleasePost(ownerId, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.AidaV1WorkflowSchedulerNamedLocksReleasePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1WorkflowSchedulerNamedLocksReleasePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1WorkflowSchedulerNamedLocksReleasePostWithHttpInfo(ownerId, name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.AidaV1WorkflowSchedulerNamedLocksReleasePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ownerId** | **int?** |  | [optional]  |
| **name** | **string** |  | [optional]  |

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

<a id="aidav1workflowschedulersessionscurrentjobinstancesget"></a>
# **AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGet**
> List&lt;JobInstanceDto&gt; AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGet (JobStatus? status = null)



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
    public class AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGetExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var status = (JobStatus) "None";  // JobStatus? |  (optional) 

            try
            {
                List<JobInstanceDto> result = apiInstance.AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGet(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<JobInstanceDto>> response = apiInstance.AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGetWithHttpInfo(status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.AidaV1WorkflowSchedulerSessionsCurrentJobInstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **JobStatus?** |  | [optional]  |

### Return type

[**List&lt;JobInstanceDto&gt;**](JobInstanceDto.md)

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

<a id="cancelrunningworkflowinstances"></a>
# **CancelRunningWorkflowInstances**
> void CancelRunningWorkflowInstances ()



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
    public class CancelRunningWorkflowInstancesExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.CancelRunningWorkflowInstances();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.CancelRunningWorkflowInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelRunningWorkflowInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CancelRunningWorkflowInstancesWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.CancelRunningWorkflowInstancesWithHttpInfo: " + e.Message);
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

<a id="cancelsuspendedworkflows"></a>
# **CancelSuspendedWorkflows**
> List&lt;WorkflowInstanceSummaryModel&gt; CancelSuspendedWorkflows ()



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
    public class CancelSuspendedWorkflowsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<WorkflowInstanceSummaryModel> result = apiInstance.CancelSuspendedWorkflows();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.CancelSuspendedWorkflows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelSuspendedWorkflowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkflowInstanceSummaryModel>> response = apiInstance.CancelSuspendedWorkflowsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.CancelSuspendedWorkflowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowInstanceSummaryModel&gt;**](WorkflowInstanceSummaryModel.md)

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

<a id="cancelworkflowinstance"></a>
# **CancelWorkflowInstance**
> WorkflowBlueprintSummaryModel CancelWorkflowInstance (string id)



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
    public class CancelWorkflowInstanceExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                WorkflowBlueprintSummaryModel result = apiInstance.CancelWorkflowInstance(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.CancelWorkflowInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelWorkflowInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowBlueprintSummaryModel> response = apiInstance.CancelWorkflowInstanceWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.CancelWorkflowInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**WorkflowBlueprintSummaryModel**](WorkflowBlueprintSummaryModel.md)

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

<a id="clearprintqueue"></a>
# **ClearPrintQueue**
> void ClearPrintQueue (string jobTemplateName = null)



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
    public class ClearPrintQueueExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var jobTemplateName = "jobTemplateName_example";  // string |  (optional) 

            try
            {
                apiInstance.ClearPrintQueue(jobTemplateName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.ClearPrintQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClearPrintQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ClearPrintQueueWithHttpInfo(jobTemplateName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.ClearPrintQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateName** | **string** |  | [optional]  |

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

<a id="deleteworkflowinstances"></a>
# **DeleteWorkflowInstances**
> List&lt;WorkflowInstanceSummaryModel&gt; DeleteWorkflowInstances ()



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
    public class DeleteWorkflowInstancesExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<WorkflowInstanceSummaryModel> result = apiInstance.DeleteWorkflowInstances();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.DeleteWorkflowInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkflowInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkflowInstanceSummaryModel>> response = apiInstance.DeleteWorkflowInstancesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.DeleteWorkflowInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowInstanceSummaryModel&gt;**](WorkflowInstanceSummaryModel.md)

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

<a id="getjobstatus"></a>
# **GetJobStatus**
> List&lt;Job&gt; GetJobStatus (List<int> requestBody = null)



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
    public class GetJobStatusExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var requestBody = new List<int>(); // List<int> |  (optional) 

            try
            {
                List<Job> result = apiInstance.GetJobStatus(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetJobStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJobStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Job>> response = apiInstance.GetJobStatusWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetJobStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;int&gt;**](int.md) |  | [optional]  |

### Return type

[**List&lt;Job&gt;**](Job.md)

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

<a id="getmetrics"></a>
# **GetMetrics**
> RuntimeMetrics GetMetrics ()



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
    public class GetMetricsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                RuntimeMetrics result = apiInstance.GetMetrics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetMetrics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RuntimeMetrics> response = apiInstance.GetMetricsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetMetricsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RuntimeMetrics**](RuntimeMetrics.md)

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

<a id="getnamedlock"></a>
# **GetNamedLock**
> List&lt;Object&gt; GetNamedLock (string resourceName)



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
    public class GetNamedLockExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var resourceName = "resourceName_example";  // string | 

            try
            {
                List<Object> result = apiInstance.GetNamedLock(resourceName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetNamedLock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNamedLockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Object>> response = apiInstance.GetNamedLockWithHttpInfo(resourceName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetNamedLockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceName** | **string** |  |  |

### Return type

**List<Object>**

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

<a id="getqueuedjobs"></a>
# **GetQueuedJobs**
> List&lt;int&gt; GetQueuedJobs ()



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
    public class GetQueuedJobsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<int> result = apiInstance.GetQueuedJobs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetQueuedJobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQueuedJobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<int>> response = apiInstance.GetQueuedJobsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetQueuedJobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="getresumeitems"></a>
# **GetResumeItems**
> List&lt;ResumeItem&gt; GetResumeItems ()



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
    public class GetResumeItemsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<ResumeItem> result = apiInstance.GetResumeItems();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetResumeItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResumeItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ResumeItem>> response = apiInstance.GetResumeItemsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetResumeItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ResumeItem&gt;**](ResumeItem.md)

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

<a id="getrunningworkflowids"></a>
# **GetRunningWorkflowIds**
> List&lt;string&gt; GetRunningWorkflowIds ()



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
    public class GetRunningWorkflowIdsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<string> result = apiInstance.GetRunningWorkflowIds();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetRunningWorkflowIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunningWorkflowIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.GetRunningWorkflowIdsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetRunningWorkflowIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

<a id="getrunningworkflows"></a>
# **GetRunningWorkflows**
> List&lt;WorkflowInstanceSummaryModel&gt; GetRunningWorkflows ()



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
    public class GetRunningWorkflowsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<WorkflowInstanceSummaryModel> result = apiInstance.GetRunningWorkflows();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetRunningWorkflows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunningWorkflowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkflowInstanceSummaryModel>> response = apiInstance.GetRunningWorkflowsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetRunningWorkflowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowInstanceSummaryModel&gt;**](WorkflowInstanceSummaryModel.md)

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

<a id="getsuspendedworkflows"></a>
# **GetSuspendedWorkflows**
> List&lt;WorkflowInstanceSummaryModel&gt; GetSuspendedWorkflows ()



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
    public class GetSuspendedWorkflowsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<WorkflowInstanceSummaryModel> result = apiInstance.GetSuspendedWorkflows();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetSuspendedWorkflows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSuspendedWorkflowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkflowInstanceSummaryModel>> response = apiInstance.GetSuspendedWorkflowsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetSuspendedWorkflowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowInstanceSummaryModel&gt;**](WorkflowInstanceSummaryModel.md)

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

<a id="getworkflowblueprints"></a>
# **GetWorkflowBlueprints**
> List&lt;WorkflowBlueprintSummaryModel&gt; GetWorkflowBlueprints ()



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
    public class GetWorkflowBlueprintsExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<WorkflowBlueprintSummaryModel> result = apiInstance.GetWorkflowBlueprints();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowBlueprints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowBlueprintsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkflowBlueprintSummaryModel>> response = apiInstance.GetWorkflowBlueprintsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowBlueprintsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowBlueprintSummaryModel&gt;**](WorkflowBlueprintSummaryModel.md)

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

<a id="getworkflowcontextbyworkflowinstanceid"></a>
# **GetWorkflowContextByWorkflowInstanceId**
> void GetWorkflowContextByWorkflowInstanceId (string workflowInstanceId)



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
    public class GetWorkflowContextByWorkflowInstanceIdExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var workflowInstanceId = "workflowInstanceId_example";  // string | 

            try
            {
                apiInstance.GetWorkflowContextByWorkflowInstanceId(workflowInstanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowContextByWorkflowInstanceId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowContextByWorkflowInstanceIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetWorkflowContextByWorkflowInstanceIdWithHttpInfo(workflowInstanceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowContextByWorkflowInstanceIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowInstanceId** | **string** |  |  |

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

<a id="getworkflowinstances"></a>
# **GetWorkflowInstances**
> WorkflowInstanceDtoPagedList GetWorkflowInstances (List<WorkflowStatus> status = null, int? page = null, int? pageSize = null)



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
    public class GetWorkflowInstancesExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var status = new List<WorkflowStatus>(); // List<WorkflowStatus> |  (optional) 
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 15;  // int? |  (optional)  (default to 15)

            try
            {
                WorkflowInstanceDtoPagedList result = apiInstance.GetWorkflowInstances(status, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowInstanceDtoPagedList> response = apiInstance.GetWorkflowInstancesWithHttpInfo(status, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | [**List&lt;WorkflowStatus&gt;**](WorkflowStatus.md) |  | [optional]  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 15] |

### Return type

[**WorkflowInstanceDtoPagedList**](WorkflowInstanceDtoPagedList.md)

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

<a id="getworkflowregistry"></a>
# **GetWorkflowRegistry**
> WorkflowBlueprintSummaryModelPagedList GetWorkflowRegistry ()



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
    public class GetWorkflowRegistryExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                WorkflowBlueprintSummaryModelPagedList result = apiInstance.GetWorkflowRegistry();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowBlueprintSummaryModelPagedList> response = apiInstance.GetWorkflowRegistryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkflowBlueprintSummaryModelPagedList**](WorkflowBlueprintSummaryModelPagedList.md)

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

<a id="getworkflowschedulerstate"></a>
# **GetWorkflowSchedulerState**
> WorkflowSchedulerStateDto GetWorkflowSchedulerState ()



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
    public class GetWorkflowSchedulerStateExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                WorkflowSchedulerStateDto result = apiInstance.GetWorkflowSchedulerState();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowSchedulerState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowSchedulerStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowSchedulerStateDto> response = apiInstance.GetWorkflowSchedulerStateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.GetWorkflowSchedulerStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkflowSchedulerStateDto**](WorkflowSchedulerStateDto.md)

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

<a id="listnamedlocks"></a>
# **ListNamedLocks**
> List&lt;Object&gt; ListNamedLocks (string ownerId = null, string resource = null, bool? locked = null)



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
    public class ListNamedLocksExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var ownerId = "ownerId_example";  // string |  (optional) 
            var resource = "resource_example";  // string |  (optional) 
            var locked = false;  // bool? |  (optional)  (default to false)

            try
            {
                List<Object> result = apiInstance.ListNamedLocks(ownerId, resource, locked);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.ListNamedLocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNamedLocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Object>> response = apiInstance.ListNamedLocksWithHttpInfo(ownerId, resource, locked);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.ListNamedLocksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ownerId** | **string** |  | [optional]  |
| **resource** | **string** |  | [optional]  |
| **locked** | **bool?** |  | [optional] [default to false] |

### Return type

**List<Object>**

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

<a id="resumeworkflowscheduler"></a>
# **ResumeWorkflowScheduler**
> List&lt;JobInstance&gt; ResumeWorkflowScheduler ()



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
    public class ResumeWorkflowSchedulerExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                List<JobInstance> result = apiInstance.ResumeWorkflowScheduler();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.ResumeWorkflowScheduler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResumeWorkflowSchedulerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<JobInstance>> response = apiInstance.ResumeWorkflowSchedulerWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.ResumeWorkflowSchedulerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;JobInstance&gt;**](JobInstance.md)

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

<a id="signalexternalprocesscompleted"></a>
# **SignalExternalProcessCompleted**
> List&lt;JobInstance&gt; SignalExternalProcessCompleted (bool? waitForCompletion = null, ExternalProcessCompletedMessage externalProcessCompletedMessage = null)

Notifies a suspended workflow instance when that the external process has completed execution

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
    public class SignalExternalProcessCompletedExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var waitForCompletion = false;  // bool? | If true, the server will respond once the workflow enters the completed/faulted state (optional)  (default to false)
            var externalProcessCompletedMessage = new ExternalProcessCompletedMessage(); // ExternalProcessCompletedMessage | The External process completed message payload (optional) 

            try
            {
                // Notifies a suspended workflow instance when that the external process has completed execution
                List<JobInstance> result = apiInstance.SignalExternalProcessCompleted(waitForCompletion, externalProcessCompletedMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.SignalExternalProcessCompleted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignalExternalProcessCompletedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notifies a suspended workflow instance when that the external process has completed execution
    ApiResponse<List<JobInstance>> response = apiInstance.SignalExternalProcessCompletedWithHttpInfo(waitForCompletion, externalProcessCompletedMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.SignalExternalProcessCompletedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **waitForCompletion** | **bool?** | If true, the server will respond once the workflow enters the completed/faulted state | [optional] [default to false] |
| **externalProcessCompletedMessage** | [**ExternalProcessCompletedMessage**](ExternalProcessCompletedMessage.md) | The External process completed message payload | [optional]  |

### Return type

[**List&lt;JobInstance&gt;**](JobInstance.md)

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

<a id="startworkflowscheduler"></a>
# **StartWorkflowScheduler**
> WorkflowSchedulerStateDto StartWorkflowScheduler (WorkflowSchedulerStartupParamsDto workflowSchedulerStartupParamsDto = null)



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
    public class StartWorkflowSchedulerExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var workflowSchedulerStartupParamsDto = new WorkflowSchedulerStartupParamsDto(); // WorkflowSchedulerStartupParamsDto |  (optional) 

            try
            {
                WorkflowSchedulerStateDto result = apiInstance.StartWorkflowScheduler(workflowSchedulerStartupParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.StartWorkflowScheduler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartWorkflowSchedulerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowSchedulerStateDto> response = apiInstance.StartWorkflowSchedulerWithHttpInfo(workflowSchedulerStartupParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.StartWorkflowSchedulerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowSchedulerStartupParamsDto** | [**WorkflowSchedulerStartupParamsDto**](WorkflowSchedulerStartupParamsDto.md) |  | [optional]  |

### Return type

[**WorkflowSchedulerStateDto**](WorkflowSchedulerStateDto.md)

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

<a id="stopworkflowscheduler"></a>
# **StopWorkflowScheduler**
> WorkflowSchedulerStateDto StopWorkflowScheduler (bool? stopAllRunningWorkflows = null, JobErrorCodes? errorCode = null)



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
    public class StopWorkflowSchedulerExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);
            var stopAllRunningWorkflows = true;  // bool? |  (optional) 
            var errorCode = (JobErrorCodes) "NoErrors";  // JobErrorCodes? |  (optional) 

            try
            {
                WorkflowSchedulerStateDto result = apiInstance.StopWorkflowScheduler(stopAllRunningWorkflows, errorCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.StopWorkflowScheduler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopWorkflowSchedulerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowSchedulerStateDto> response = apiInstance.StopWorkflowSchedulerWithHttpInfo(stopAllRunningWorkflows, errorCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.StopWorkflowSchedulerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stopAllRunningWorkflows** | **bool?** |  | [optional]  |
| **errorCode** | **JobErrorCodes?** |  | [optional]  |

### Return type

[**WorkflowSchedulerStateDto**](WorkflowSchedulerStateDto.md)

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

<a id="updateinvaliddatabaseentries"></a>
# **UpdateInvalidDatabaseEntries**
> void UpdateInvalidDatabaseEntries ()



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
    public class UpdateInvalidDatabaseEntriesExample
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
            var apiInstance = new WorkflowSchedulerApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.UpdateInvalidDatabaseEntries();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowSchedulerApi.UpdateInvalidDatabaseEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInvalidDatabaseEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateInvalidDatabaseEntriesWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowSchedulerApi.UpdateInvalidDatabaseEntriesWithHttpInfo: " + e.Message);
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

