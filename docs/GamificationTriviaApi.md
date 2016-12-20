# IO.Swagger.Api.GamificationTriviaApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAnswersUsingPOST**](GamificationTriviaApi.md#addanswersusingpost) | **POST** /trivia/questions/{question_id}/answers | Add an answer to a question
[**AddTagUsingPOST**](GamificationTriviaApi.md#addtagusingpost) | **POST** /trivia/questions/{id}/tags | Add a tag to a question
[**BatchAddTagUsingPOST**](GamificationTriviaApi.md#batchaddtagusingpost) | **POST** /trivia/questions/tags | Add a tag to a batch of questions
[**BatchRemoveTagUsingDELETE**](GamificationTriviaApi.md#batchremovetagusingdelete) | **DELETE** /trivia/questions/tags/{tag} | Remove a tag from a batch of questions
[**BulkUpdateUsingPUT**](GamificationTriviaApi.md#bulkupdateusingput) | **PUT** /trivia/questions | Bulk update questions
[**CountQuestionsUsingGET**](GamificationTriviaApi.md#countquestionsusingget) | **GET** /trivia/questions/count | Count questions based on filters.
[**CreateQuestionTemplateUsingPOST**](GamificationTriviaApi.md#createquestiontemplateusingpost) | **POST** /trivia/questions/templates | Create a question template
[**CreateQuestionUsingPOST**](GamificationTriviaApi.md#createquestionusingpost) | **POST** /trivia/questions | Create a question
[**CreateUsingPOST**](GamificationTriviaApi.md#createusingpost) | **POST** /trivia/import | Create an import job
[**DeleteQuestionTemplateUsingDELETE**](GamificationTriviaApi.md#deletequestiontemplateusingdelete) | **DELETE** /trivia/questions/templates/{id} | Delete a question template
[**DeleteQuestionUsingDELETE**](GamificationTriviaApi.md#deletequestionusingdelete) | **DELETE** /trivia/questions/{id} | Delete a question
[**DeleteUsingDELETE**](GamificationTriviaApi.md#deleteusingdelete) | **DELETE** /trivia/import/{id} | Delete an import job
[**GetAnswerUsingGET**](GamificationTriviaApi.md#getanswerusingget) | **GET** /trivia/questions/{question_id}/answers/{id} | Get an answer for a question
[**GetAnswersUsingGET**](GamificationTriviaApi.md#getanswersusingget) | **GET** /trivia/questions/{question_id}/answers | List the answers available for a question
[**GetListUsingGET1**](GamificationTriviaApi.md#getlistusingget1) | **GET** /trivia/import | Get a list of import job
[**GetQuestionTemplateUsingGET**](GamificationTriviaApi.md#getquestiontemplateusingget) | **GET** /trivia/questions/templates/{id} | Get a single question template
[**GetQuestionTemplatesUsingGET**](GamificationTriviaApi.md#getquestiontemplatesusingget) | **GET** /trivia/questions/templates | List and search question templates
[**GetQuestionUsingGET**](GamificationTriviaApi.md#getquestionusingget) | **GET** /trivia/questions/{id} | Get a single question
[**GetQuestionsDeltaUsingGET**](GamificationTriviaApi.md#getquestionsdeltausingget) | **GET** /trivia/questions/delta | List question deltas in ascending order of updated date
[**GetQuestionsUsingGET**](GamificationTriviaApi.md#getquestionsusingget) | **GET** /trivia/questions | List and search questions
[**GetTagsUsingGET1**](GamificationTriviaApi.md#gettagsusingget1) | **GET** /trivia/questions/{id}/tags | List the tags for a question
[**GetTagsUsingGET2**](GamificationTriviaApi.md#gettagsusingget2) | **GET** /trivia/tags | List and search tags by the beginning of the string
[**GetUsingGET**](GamificationTriviaApi.md#getusingget) | **GET** /trivia/import/{id} | Get an import job
[**RemoveAnswersUsingDELETE**](GamificationTriviaApi.md#removeanswersusingdelete) | **DELETE** /trivia/questions/{question_id}/answers/{id} | Remove an answer from a question
[**RemoveTagUsingDELETE**](GamificationTriviaApi.md#removetagusingdelete) | **DELETE** /trivia/questions/{id}/tags/{tag} | Remove a tag from a question
[**StartProcessUsingPOST**](GamificationTriviaApi.md#startprocessusingpost) | **POST** /trivia/import/{id}/process | Start processing an import job
[**UpdateAnswerUsingPUT**](GamificationTriviaApi.md#updateanswerusingput) | **PUT** /trivia/questions/{question_id}/answers/{id} | Update an answer for a question
[**UpdateQuestionTemplateUsingPUT**](GamificationTriviaApi.md#updatequestiontemplateusingput) | **PUT** /trivia/questions/templates/{id} | Update a question template
[**UpdateQuestionUsingPUT**](GamificationTriviaApi.md#updatequestionusingput) | **PUT** /trivia/questions/{id} | Update a question
[**UpdateUsingPUT**](GamificationTriviaApi.md#updateusingput) | **PUT** /trivia/import/{id} | Update an import job


<a name="addanswersusingpost"></a>
# **AddAnswersUsingPOST**
> AnswerResource AddAnswersUsingPOST (string questionId, AnswerResource answer = null)

Add an answer to a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAnswersUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var answer = new AnswerResource(); // AnswerResource | The new answer (optional) 

            try
            {
                // Add an answer to a question
                AnswerResource result = apiInstance.AddAnswersUsingPOST(questionId, answer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.AddAnswersUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **answer** | [**AnswerResource**](AnswerResource.md)| The new answer | [optional] 

### Return type

[**AnswerResource**](AnswerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtagusingpost"></a>
# **AddTagUsingPOST**
> void AddTagUsingPOST (string id, string tag = null)

Add a tag to a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddTagUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question
            var tag = tag_example;  // string | The new tag (optional) 

            try
            {
                // Add a tag to a question
                apiInstance.AddTagUsingPOST(id, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.AddTagUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **tag** | **string**| The new tag | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchaddtagusingpost"></a>
# **BatchAddTagUsingPOST**
> int? BatchAddTagUsingPOST (string tag = null, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTag = null, string filterTagset = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

Add a tag to a batch of questions

All questions that dont't have the tag and match filters will have it added. The returned number is the number of questions updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BatchAddTagUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var tag = tag_example;  // string | The tag to add (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Add a tag to a batch of questions
                int? result = apiInstance.BatchAddTagUsingPOST(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.BatchAddTagUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| The tag to add | [optional] 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchremovetagusingdelete"></a>
# **BatchRemoveTagUsingDELETE**
> int? BatchRemoveTagUsingDELETE (string tag, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTag = null, string filterTagset = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

Remove a tag from a batch of questions

ll questions that have the tag and match filters will have it removed. The returned number is the number of questions updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BatchRemoveTagUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var tag = tag_example;  // string | The tag to remove
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Remove a tag from a batch of questions
                int? result = apiInstance.BatchRemoveTagUsingDELETE(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.BatchRemoveTagUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| The tag to remove | 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdateusingput"></a>
# **BulkUpdateUsingPUT**
> int? BulkUpdateUsingPUT (QuestionResource question = null, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTagset = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

Bulk update questions

Will update all questions that match filters used (or all questions in system if no filters used). Body should match a question resource with only those properties you wish to set. Null values will be ignored. Returned number is how many were updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkUpdateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var question = new QuestionResource(); // QuestionResource | New values for a set of question fields (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Bulk update questions
                int? result = apiInstance.BulkUpdateUsingPUT(question, filterSearch, filterIdset, filterCategory, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.BulkUpdateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **question** | [**QuestionResource**](QuestionResource.md)| New values for a set of question fields | [optional] 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countquestionsusingget"></a>
# **CountQuestionsUsingGET**
> long? CountQuestionsUsingGET (string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTag = null, string filterTagset = null, string filterType = null, bool? filterPublished = null)

Count questions based on filters.

This is also provided by the list endpoint so you don't need to call this for pagination purposes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CountQuestionsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 

            try
            {
                // Count questions based on filters.
                long? result = apiInstance.CountQuestionsUsingGET(filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.CountQuestionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 

### Return type

**long?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createquestiontemplateusingpost"></a>
# **CreateQuestionTemplateUsingPOST**
> QuestionTemplateResource CreateQuestionTemplateUsingPOST (QuestionTemplateResource questionTemplateResource = null)

Create a question template

Question templates define a type of question and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateQuestionTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionTemplateResource = new QuestionTemplateResource(); // QuestionTemplateResource | The question template resource object (optional) 

            try
            {
                // Create a question template
                QuestionTemplateResource result = apiInstance.CreateQuestionTemplateUsingPOST(questionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.CreateQuestionTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionTemplateResource** | [**QuestionTemplateResource**](QuestionTemplateResource.md)| The question template resource object | [optional] 

### Return type

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createquestionusingpost"></a>
# **CreateQuestionUsingPOST**
> QuestionResource CreateQuestionUsingPOST (QuestionResource question = null)

Create a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateQuestionUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var question = new QuestionResource(); // QuestionResource | The new question (optional) 

            try
            {
                // Create a question
                QuestionResource result = apiInstance.CreateQuestionUsingPOST(question);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.CreateQuestionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **question** | [**QuestionResource**](QuestionResource.md)| The new question | [optional] 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createusingpost"></a>
# **CreateUsingPOST**
> ImportJobResource CreateUsingPOST (ImportJobResource request = null)

Create an import job

Set up a job to import a set of trivia questions from a cvs file at a remote url. the file will be validated asynchronously but will not be processed until started manually with the process endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var request = new ImportJobResource(); // ImportJobResource | The new import job (optional) 

            try
            {
                // Create an import job
                ImportJobResource result = apiInstance.CreateUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.CreateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ImportJobResource**](ImportJobResource.md)| The new import job | [optional] 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestiontemplateusingdelete"></a>
# **DeleteQuestionTemplateUsingDELETE**
> void DeleteQuestionTemplateUsingDELETE (string id, string cascade = null)

Delete a question template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteQuestionTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a question template
                apiInstance.DeleteQuestionTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.DeleteQuestionTemplateUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| The value needed to delete used templates | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestionusingdelete"></a>
# **DeleteQuestionUsingDELETE**
> void DeleteQuestionUsingDELETE (string id)

Delete a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteQuestionUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // Delete a question
                apiInstance.DeleteQuestionUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.DeleteQuestionUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusingdelete"></a>
# **DeleteUsingDELETE**
> void DeleteUsingDELETE (long? id)

Delete an import job

Also deletes all questions that were imported by it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job

            try
            {
                // Delete an import job
                apiInstance.DeleteUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.DeleteUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getanswerusingget"></a>
# **GetAnswerUsingGET**
> AnswerResource GetAnswerUsingGET (string questionId, string id)

Get an answer for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAnswerUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer

            try
            {
                // Get an answer for a question
                AnswerResource result = apiInstance.GetAnswerUsingGET(questionId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetAnswerUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 

### Return type

[**AnswerResource**](AnswerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getanswersusingget"></a>
# **GetAnswersUsingGET**
> List<AnswerResource> GetAnswersUsingGET (string questionId)

List the answers available for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAnswersUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question

            try
            {
                // List the answers available for a question
                List&lt;AnswerResource&gt; result = apiInstance.GetAnswersUsingGET(questionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetAnswersUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 

### Return type

[**List<AnswerResource>**](AnswerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistusingget1"></a>
# **GetListUsingGET1**
> PageImportJobResource GetListUsingGET1 (string filterVendor = null, string filterCategory = null, string filterName = null, string filterStatus = null, int? size = null, int? page = null, string order = null)

Get a list of import job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetListUsingGET1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var filterVendor = filterVendor_example;  // string | Filter for jobs by vendor id (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for jobs by category id (optional) 
            var filterName = filterName_example;  // string | Filter for jobs which name *STARTS* with the given string (optional) 
            var filterStatus = filterStatus_example;  // string | Filter for jobs that are in a specific set of statuses (comma separated) (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get a list of import job
                PageImportJobResource result = apiInstance.GetListUsingGET1(filterVendor, filterCategory, filterName, filterStatus, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetListUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterVendor** | **string**| Filter for jobs by vendor id | [optional] 
 **filterCategory** | **string**| Filter for jobs by category id | [optional] 
 **filterName** | **string**| Filter for jobs which name *STARTS* with the given string | [optional] 
 **filterStatus** | **string**| Filter for jobs that are in a specific set of statuses (comma separated) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageImportJobResource**](PageImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontemplateusingget"></a>
# **GetQuestionTemplateUsingGET**
> QuestionTemplateResource GetQuestionTemplateUsingGET (string id)

Get a single question template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single question template
                QuestionTemplateResource result = apiInstance.GetQuestionTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionTemplateUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 

### Return type

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontemplatesusingget"></a>
# **GetQuestionTemplatesUsingGET**
> PageQuestionTemplateResource GetQuestionTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search question templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search question templates
                PageQuestionTemplateResource result = apiInstance.GetQuestionTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionTemplatesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageQuestionTemplateResource**](PageQuestionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionusingget"></a>
# **GetQuestionUsingGET**
> QuestionResource GetQuestionUsingGET (string id)

Get a single question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // Get a single question
                QuestionResource result = apiInstance.GetQuestionUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionsdeltausingget"></a>
# **GetQuestionsDeltaUsingGET**
> List<DeltaResource> GetQuestionsDeltaUsingGET (long? since = null)

List question deltas in ascending order of updated date

The 'since' parameter is important to avoid getting a full list of all questions. Implementors should make sure they pass the updated date of the last resource loaded, not the date of the last request, in order to avoid gaps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionsDeltaUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var since = 789;  // long? | Timestamp in seconds (optional) 

            try
            {
                // List question deltas in ascending order of updated date
                List&lt;DeltaResource&gt; result = apiInstance.GetQuestionsDeltaUsingGET(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionsDeltaUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **long?**| Timestamp in seconds | [optional] 

### Return type

[**List<DeltaResource>**](DeltaResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionsusingget"></a>
# **GetQuestionsUsingGET**
> PageQuestionResource GetQuestionsUsingGET (int? size = null, int? page = null, string order = null, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTagset = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

List and search questions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // List and search questions
                PageQuestionResource result = apiInstance.GetQuestionsUsingGET(size, page, order, filterSearch, filterIdset, filterCategory, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

[**PageQuestionResource**](PageQuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagsusingget1"></a>
# **GetTagsUsingGET1**
> List<string> GetTagsUsingGET1 (string id)

List the tags for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTagsUsingGET1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // List the tags for a question
                List&lt;string&gt; result = apiInstance.GetTagsUsingGET1(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetTagsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

**List<string>**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagsusingget2"></a>
# **GetTagsUsingGET2**
> Collectionstring GetTagsUsingGET2 (string filterSearch = null, string filterCategory = null, long? filterImportId = null)

List and search tags by the beginning of the string

For performance reasons, search & category filters are mutually exclusive. If category is specified, search filter will be ignored in order to do fast matches for typeahead.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTagsUsingGET2Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var filterSearch = filterSearch_example;  // string | Filter for tags starting with the given text (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for tags on questions from a specific category (optional) 
            var filterImportId = 789;  // long? | Filter for tags on questions from a specific import job (optional) 

            try
            {
                // List and search tags by the beginning of the string
                Collectionstring result = apiInstance.GetTagsUsingGET2(filterSearch, filterCategory, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetTagsUsingGET2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for tags starting with the given text | [optional] 
 **filterCategory** | **string**| Filter for tags on questions from a specific category | [optional] 
 **filterImportId** | **long?**| Filter for tags on questions from a specific import job | [optional] 

### Return type

[**Collectionstring**](Collectionstring.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusingget"></a>
# **GetUsingGET**
> ImportJobResource GetUsingGET (long? id)

Get an import job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job

            try
            {
                // Get an import job
                ImportJobResource result = apiInstance.GetUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeanswersusingdelete"></a>
# **RemoveAnswersUsingDELETE**
> void RemoveAnswersUsingDELETE (string questionId, string id)

Remove an answer from a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveAnswersUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer

            try
            {
                // Remove an answer from a question
                apiInstance.RemoveAnswersUsingDELETE(questionId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.RemoveAnswersUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetagusingdelete"></a>
# **RemoveTagUsingDELETE**
> void RemoveTagUsingDELETE (string id, string tag)

Remove a tag from a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveTagUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question
            var tag = tag_example;  // string | The tag to remove

            try
            {
                // Remove a tag from a question
                apiInstance.RemoveTagUsingDELETE(id, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.RemoveTagUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **tag** | **string**| The tag to remove | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startprocessusingpost"></a>
# **StartProcessUsingPOST**
> ImportJobResource StartProcessUsingPOST (long? id, bool? publishNow)

Start processing an import job

Will process the CSV file and add new questions asynchronously. The status of the job must be 'VALID'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StartProcessUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job
            var publishNow = true;  // bool? | Whether the new questions should be published live immediately

            try
            {
                // Start processing an import job
                ImportJobResource result = apiInstance.StartProcessUsingPOST(id, publishNow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.StartProcessUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 
 **publishNow** | **bool?**| Whether the new questions should be published live immediately | 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateanswerusingput"></a>
# **UpdateAnswerUsingPUT**
> void UpdateAnswerUsingPUT (string questionId, string id, AnswerResource answer = null)

Update an answer for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAnswerUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer
            var answer = new AnswerResource(); // AnswerResource | The updated answer (optional) 

            try
            {
                // Update an answer for a question
                apiInstance.UpdateAnswerUsingPUT(questionId, id, answer);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateAnswerUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 
 **answer** | [**AnswerResource**](AnswerResource.md)| The updated answer | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestiontemplateusingput"></a>
# **UpdateQuestionTemplateUsingPUT**
> void UpdateQuestionTemplateUsingPUT (string id, QuestionTemplateResource questionTemplateResource = null)

Update a question template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateQuestionTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the template
            var questionTemplateResource = new QuestionTemplateResource(); // QuestionTemplateResource | The question template resource object (optional) 

            try
            {
                // Update a question template
                apiInstance.UpdateQuestionTemplateUsingPUT(id, questionTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateQuestionTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **questionTemplateResource** | [**QuestionTemplateResource**](QuestionTemplateResource.md)| The question template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestionusingput"></a>
# **UpdateQuestionUsingPUT**
> QuestionResource UpdateQuestionUsingPUT (string id, QuestionResource question = null)

Update a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateQuestionUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question
            var question = new QuestionResource(); // QuestionResource | The updated question (optional) 

            try
            {
                // Update a question
                QuestionResource result = apiInstance.UpdateQuestionUsingPUT(id, question);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateQuestionUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **question** | [**QuestionResource**](QuestionResource.md)| The updated question | [optional] 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusingput"></a>
# **UpdateUsingPUT**
> ImportJobResource UpdateUsingPUT (long? id, ImportJobResource request = null)

Update an import job

Changes should be made before process is started for there to be any effect.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job
            var request = new ImportJobResource(); // ImportJobResource | The updated job (optional) 

            try
            {
                // Update an import job
                ImportJobResource result = apiInstance.UpdateUsingPUT(id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 
 **request** | [**ImportJobResource**](ImportJobResource.md)| The updated job | [optional] 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

