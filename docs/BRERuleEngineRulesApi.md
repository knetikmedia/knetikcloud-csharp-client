# IO.Swagger.Api.BRERuleEngineRulesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertExpressionToStringUsingPOST**](BRERuleEngineRulesApi.md#convertexpressiontostringusingpost) | **POST** /bre/rules/expression-as-string | Returns a string representation of the provided expression
[**CreateRuleUsingPOST**](BRERuleEngineRulesApi.md#createruleusingpost) | **POST** /bre/rules | Create a rule
[**DeleteRuleUsingDELETE**](BRERuleEngineRulesApi.md#deleteruleusingdelete) | **DELETE** /bre/rules/{id} | Delete a rule
[**EnableRuleUsingPUT**](BRERuleEngineRulesApi.md#enableruleusingput) | **PUT** /bre/rules/{id}/enabled | Enable or disable a rule
[**GetRuleUsingGET**](BRERuleEngineRulesApi.md#getruleusingget) | **GET** /bre/rules/{id} | Get a single rule
[**GetRulesUsingGET**](BRERuleEngineRulesApi.md#getrulesusingget) | **GET** /bre/rules | List rules
[**UpdateRuleUsingPUT**](BRERuleEngineRulesApi.md#updateruleusingput) | **PUT** /bre/rules/{id} | Update a rule


<a name="convertexpressiontostringusingpost"></a>
# **ConvertExpressionToStringUsingPOST**
> string ConvertExpressionToStringUsingPOST (Expressionobject expression = null)

Returns a string representation of the provided expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConvertExpressionToStringUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var expression = new Expressionobject(); // Expressionobject | The expression (optional) 

            try
            {
                // Returns a string representation of the provided expression
                string result = apiInstance.ConvertExpressionToStringUsingPOST(expression);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.ConvertExpressionToStringUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expression** | [**Expressionobject**](Expressionobject.md)| The expression | [optional] 

### Return type

**string**

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createruleusingpost"></a>
# **CreateRuleUsingPOST**
> BreRule CreateRuleUsingPOST (BreRule breRule = null)

Create a rule

Rules define which actions to run when a given event verifies the specified conditions. Conditions and actions are defined by binding event or context parameters to arguments. Conditions also known as Predicates are logical expressions that result in a boolean. Operators are used to describe rules between arguments to form that condition. There are 3 families of operators: Boolean, Math and String. Math and String operators are functions that transform arguments into numbers or strings...<h1>Boolean Operators</h1><br /><br />1 arg:<br />======<br /><br /><ul> <li>IS_NULL</li> <li>IS_NOT_NULL</li> <li>STRING_IS_EMPTY</li> <li>NOT </li> <li>MAP_IS_EMPTY</li></ul><br />2 args:<br />=======<br /><br /><ul> <li>EQ</li> <li>NE (Not Equals)</li> <li>GT (Greater Than)</li> <li>GOE (Greater Or Equals)</li> <li>LT (Lesser Than)</li> <li>LOE (Lesser Or Equals)</li> <li>OR</li> <li>AND</li> <li>XNOR</li> <li>XOR</li> <li>CONTAINS_KEY (for maps only)</li> <li>CONTAINS_VALUE (for maps only)</li> <li>MATCHES (regex)</li> <li>MATCHES_IC (regex ignore case)</li> <li>STARTS_WITH</li> <li>STARTS_WITH_IC</li> <li>EQ_IGNORE_CASE</li> <li>ENDS_WITH</li> <li>ENDS_WITH_IC</li> <li>STRING_CONTAINS</li> <li>STRING_CONTAINS_IC</li> <li>LIKE (SQL like)</li></ul><br />3 args exceptions:<br />=================<br /><br /><ul> <li>BETWEEN</li></ul><br />n args:<br />=======<br /><br /><ul> <li>IN</li> <li>NOT_INT</li></ul><h1>Math Operators</h1>1 arg:<br />=====<br /><br /><ul> <li>NEGATE</li> <li>MAP_SIZE</li> <li>STRING_LENGTH</li> <li>CEIL</li> <li>ABS</li> <li>FLOOR</li> <li>ROUND</li> <li>RANDOM (no arg)</li> <li>RANDOM2 (seed arg)</li> <li>NUMCAST</li> <li>HOUR</li> <li>MINUTE</li> <li>SECOND</li> <li>MILLISECOND</li> <li>YEAR</li> <li>WEEK</li> <li>YEAR_MONTH</li> <li>YEAR_WEEK</li> <li>DAY_OF_WEEK</li> <li>DAY_OF_MONTH</li> <li>DAY_OF_YEAR</li> <li>WEEK</li> <li>WEEK</li> <li>WEEK</li></ul><br /><br />2 args:<br />======<br /><br /><ul> <li>ADD</li> <li>DIV</li> <li>MULT</li> <li>SUB</li> <li>POWER</li> <li>MOD</li> <li>LOCATE (index of (string, char))</li> <li>DIFF_YEARS</li> <li>DIFF_MONTHS</li> <li>DIFF_WEEKS</li> <li>DIFF_DAYS</li> <li>DIFF_HOURS</li> <li>DIFF_MINUTES</li> <li>DIFF_SECONDS</li></ul><br /><br />2 args:<br />======<br /><br /><ul> <li>MIN</li> <li>MAX</li></ul><h1>String Operators</h1>0 arg:<br />=====<br /><br /><ul> <li>CURRENT_TIME</li></ul><br /><br />1 arg:<br />=====<br /><br /><ul> <li>CURRENT_TIME</li> <li>LOWER</li> <li>UPPER</li> <li>TRIM</li> <li>STRING_CAST</li></ul><br /><br />2 args:<br />=====<br /><br /><ul> <li>CHAR_AT</li> <li>SUBSTR_1ARG (substr(string, start))</li> <li>CONCAT</li> <li>TRIM</li> <li>STRING_CAST</li></ul><br /><br />3 args:<br />=====<br /><br /><ul> <li>SUBSTR_2ARGS (substr(string, start, length))</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRuleUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var breRule = new BreRule(); // BreRule | The BRE rule object (optional) 

            try
            {
                // Create a rule
                BreRule result = apiInstance.CreateRuleUsingPOST(breRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.CreateRuleUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breRule** | [**BreRule**](BreRule.md)| The BRE rule object | [optional] 

### Return type

[**BreRule**](BreRule.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteruleusingdelete"></a>
# **DeleteRuleUsingDELETE**
> void DeleteRuleUsingDELETE (string id)

Delete a rule

May fail if there are existing rules against it. Cannot delete core rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRuleUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule

            try
            {
                // Delete a rule
                apiInstance.DeleteRuleUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.DeleteRuleUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enableruleusingput"></a>
# **EnableRuleUsingPUT**
> void EnableRuleUsingPUT (string id, BooleanResource enabled = null)

Enable or disable a rule

This is helpful for turning off systems rules which cannot be deleted or modified otherwise

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnableRuleUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule
            var enabled = new BooleanResource(); // BooleanResource | The boolean value (optional) 

            try
            {
                // Enable or disable a rule
                apiInstance.EnableRuleUsingPUT(id, enabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.EnableRuleUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 
 **enabled** | [**BooleanResource**](BooleanResource.md)| The boolean value | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getruleusingget"></a>
# **GetRuleUsingGET**
> BreRule GetRuleUsingGET (string id)

Get a single rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule

            try
            {
                // Get a single rule
                BreRule result = apiInstance.GetRuleUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.GetRuleUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 

### Return type

[**BreRule**](BreRule.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulesusingget"></a>
# **GetRulesUsingGET**
> PageResourceBreRule GetRulesUsingGET (string filterName = null, bool? filterEnabled = null, bool? filterSystem = null, string filterTrigger = null, string filterAction = null, string filterCondition = null, int? size = null, int? page = null)

List rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRulesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var filterName = filterName_example;  // string | Filter for rules containing the given name (optional) 
            var filterEnabled = true;  // bool? | Filter for rules by active status, null for both (optional)  (default to null)
            var filterSystem = true;  // bool? | Filter for rules that are system rules when true, or not when false. Leave off for both mixed (optional) 
            var filterTrigger = filterTrigger_example;  // string | Filter for rules that are for the trigger with the given name (optional) 
            var filterAction = filterAction_example;  // string | Filter for rules that use the action with the given name (optional) 
            var filterCondition = filterCondition_example;  // string | Filter for rules that have a condition containing the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List rules
                PageResourceBreRule result = apiInstance.GetRulesUsingGET(filterName, filterEnabled, filterSystem, filterTrigger, filterAction, filterCondition, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.GetRulesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filter for rules containing the given name | [optional] 
 **filterEnabled** | **bool?**| Filter for rules by active status, null for both | [optional] [default to null]
 **filterSystem** | **bool?**| Filter for rules that are system rules when true, or not when false. Leave off for both mixed | [optional] 
 **filterTrigger** | **string**| Filter for rules that are for the trigger with the given name | [optional] 
 **filterAction** | **string**| Filter for rules that use the action with the given name | [optional] 
 **filterCondition** | **string**| Filter for rules that have a condition containing the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceBreRule**](PageResourceBreRule.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateruleusingput"></a>
# **UpdateRuleUsingPUT**
> void UpdateRuleUsingPUT (string id, BreRule breRule = null)

Update a rule

Cannot update system rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRuleUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule
            var breRule = new BreRule(); // BreRule | The BRE rule object (optional) 

            try
            {
                // Update a rule
                apiInstance.UpdateRuleUsingPUT(id, breRule);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.UpdateRuleUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 
 **breRule** | [**BreRule**](BreRule.md)| The BRE rule object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

