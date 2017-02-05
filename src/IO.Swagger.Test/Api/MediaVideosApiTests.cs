/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing MediaVideosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MediaVideosApiTests
    {
        private MediaVideosApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MediaVideosApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MediaVideosApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MediaVideosApi
            //Assert.IsInstanceOfType(typeof(MediaVideosApi), instance, "instance is a MediaVideosApi");
        }

        
        /// <summary>
        /// Test AddCommentUsingPOST1
        /// </summary>
        [Test]
        public void AddCommentUsingPOST1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //CommentResource commentResource = null;
            //var response = instance.AddCommentUsingPOST1(videoId, commentResource);
            //Assert.IsInstanceOf<CommentResource> (response, "response is CommentResource");
        }
        
        /// <summary>
        /// Test AddContributorUsingPOST
        /// </summary>
        [Test]
        public void AddContributorUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //ContributionResource contributionResource = null;
            //instance.AddContributorUsingPOST(videoId, contributionResource);
            
        }
        
        /// <summary>
        /// Test AddDispositionUsingPOST1
        /// </summary>
        [Test]
        public void AddDispositionUsingPOST1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //DispositionResource dispositionResource = null;
            //var response = instance.AddDispositionUsingPOST1(videoId, dispositionResource);
            //Assert.IsInstanceOf<DispositionResource> (response, "response is DispositionResource");
        }
        
        /// <summary>
        /// Test AddFlagUsingPOST
        /// </summary>
        [Test]
        public void AddFlagUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //string reason = null;
            //instance.AddFlagUsingPOST(videoId, reason);
            
        }
        
        /// <summary>
        /// Test AddRelatedUsingPOST
        /// </summary>
        [Test]
        public void AddRelatedUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //VideoRelationshipResource videoRelationshipResource = null;
            //var response = instance.AddRelatedUsingPOST(videoId, videoRelationshipResource);
            //Assert.IsInstanceOf<VideoRelationshipResource> (response, "response is VideoRelationshipResource");
        }
        
        /// <summary>
        /// Test AddVideoUsingPOST
        /// </summary>
        [Test]
        public void AddVideoUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VideoResource videoResource = null;
            //var response = instance.AddVideoUsingPOST(videoResource);
            //Assert.IsInstanceOf<VideoResource> (response, "response is VideoResource");
        }
        
        /// <summary>
        /// Test AddWhitelistUsingPOST
        /// </summary>
        [Test]
        public void AddWhitelistUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //int? userId = null;
            //instance.AddWhitelistUsingPOST(id, userId);
            
        }
        
        /// <summary>
        /// Test DeleteCommentUsingDELETE1
        /// </summary>
        [Test]
        public void DeleteCommentUsingDELETE1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? id = null;
            //instance.DeleteCommentUsingDELETE1(videoId, id);
            
        }
        
        /// <summary>
        /// Test DeleteDispositionUsingDELETE1
        /// </summary>
        [Test]
        public void DeleteDispositionUsingDELETE1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? dispositionId = null;
            //instance.DeleteDispositionUsingDELETE1(dispositionId);
            
        }
        
        /// <summary>
        /// Test DeleteFlagUsingDELETE
        /// </summary>
        [Test]
        public void DeleteFlagUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //instance.DeleteFlagUsingDELETE(videoId);
            
        }
        
        /// <summary>
        /// Test DeleteRelationshipUsingDELETE1
        /// </summary>
        [Test]
        public void DeleteRelationshipUsingDELETE1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? id = null;
            //instance.DeleteRelationshipUsingDELETE1(videoId, id);
            
        }
        
        /// <summary>
        /// Test DeleteVideoUsingDELETE
        /// </summary>
        [Test]
        public void DeleteVideoUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteVideoUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetCommentsUsingGET1
        /// </summary>
        [Test]
        public void GetCommentsUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetCommentsUsingGET1(videoId, size, page);
            //Assert.IsInstanceOf<PageResourceCommentResource> (response, "response is PageResourceCommentResource");
        }
        
        /// <summary>
        /// Test GetDispositionsUsingGET1
        /// </summary>
        [Test]
        public void GetDispositionsUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetDispositionsUsingGET1(videoId, size, page);
            //Assert.IsInstanceOf<PageResourceDispositionResource> (response, "response is PageResourceDispositionResource");
        }
        
        /// <summary>
        /// Test GetRelatedUsingGET
        /// </summary>
        [Test]
        public void GetRelatedUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetRelatedUsingGET(videoId, size, page);
            //Assert.IsInstanceOf<PageResourceVideoRelationshipResource> (response, "response is PageResourceVideoRelationshipResource");
        }
        
        /// <summary>
        /// Test GetUserVideosUsingGET
        /// </summary>
        [Test]
        public void GetUserVideosUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //bool? excludeFlagged = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUserVideosUsingGET(userId, excludeFlagged, size, page);
            //Assert.IsInstanceOf<PageResourceVideoResource> (response, "response is PageResourceVideoResource");
        }
        
        /// <summary>
        /// Test GetVideoUsingGET
        /// </summary>
        [Test]
        public void GetVideoUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetVideoUsingGET(id);
            //Assert.IsInstanceOf<VideoResource> (response, "response is VideoResource");
        }
        
        /// <summary>
        /// Test RemoveContributorUsingDELETE
        /// </summary>
        [Test]
        public void RemoveContributorUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //int? id = null;
            //instance.RemoveContributorUsingDELETE(videoId, id);
            
        }
        
        /// <summary>
        /// Test RemoveWhitelistUsingDELETE
        /// </summary>
        [Test]
        public void RemoveWhitelistUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //int? id = null;
            //instance.RemoveWhitelistUsingDELETE(videoId, id);
            
        }
        
        /// <summary>
        /// Test SearchVideosUsingGET
        /// </summary>
        [Test]
        public void SearchVideosUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? excludeFlagged = null;
            //string filterVideosByUploader = null;
            //string filterCategory = null;
            //string filterTagset = null;
            //string filterVideosByName = null;
            //string filterVideosByContributor = null;
            //string filterVideosByAuthor = null;
            //bool? filterHasAuthor = null;
            //bool? filterHasUploader = null;
            //string filterRelatedTo = null;
            //bool? filterFriends = null;
            //string filterDisposition = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.SearchVideosUsingGET(excludeFlagged, filterVideosByUploader, filterCategory, filterTagset, filterVideosByName, filterVideosByContributor, filterVideosByAuthor, filterHasAuthor, filterHasUploader, filterRelatedTo, filterFriends, filterDisposition, size, page, order);
            //Assert.IsInstanceOf<PageResourceVideoResource> (response, "response is PageResourceVideoResource");
        }
        
        /// <summary>
        /// Test UpdateCommentUsingPUT1
        /// </summary>
        [Test]
        public void UpdateCommentUsingPUT1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? id = null;
            //string content = null;
            //instance.UpdateCommentUsingPUT1(videoId, id, content);
            
        }
        
        /// <summary>
        /// Test UpdateRelationshipUsingPUT1
        /// </summary>
        [Test]
        public void UpdateRelationshipUsingPUT1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? relationshipId = null;
            //string details = null;
            //instance.UpdateRelationshipUsingPUT1(videoId, relationshipId, details);
            
        }
        
        /// <summary>
        /// Test UpdateVideoUsingPUT
        /// </summary>
        [Test]
        public void UpdateVideoUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //VideoResource videoResource = null;
            //instance.UpdateVideoUsingPUT(id, videoResource);
            
        }
        
        /// <summary>
        /// Test ViewVideoUsingPOST
        /// </summary>
        [Test]
        public void ViewVideoUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.ViewVideoUsingPOST(id);
            
        }
        
    }

}