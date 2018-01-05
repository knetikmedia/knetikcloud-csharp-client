/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
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

using com.knetikcloud.Client;
using com.knetikcloud.Api;
using com.knetikcloud.Model;

namespace com.knetikcloud.Test
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
        /// Test AddUserToVideoWhitelist
        /// </summary>
        [Test]
        public void AddUserToVideoWhitelistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //IntWrapper userId = null;
            //instance.AddUserToVideoWhitelist(id, userId);
            
        }
        
        /// <summary>
        /// Test AddVideo
        /// </summary>
        [Test]
        public void AddVideoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VideoResource videoResource = null;
            //var response = instance.AddVideo(videoResource);
            //Assert.IsInstanceOf<VideoResource> (response, "response is VideoResource");
        }
        
        /// <summary>
        /// Test AddVideoComment
        /// </summary>
        [Test]
        public void AddVideoCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //CommentResource commentResource = null;
            //var response = instance.AddVideoComment(videoId, commentResource);
            //Assert.IsInstanceOf<CommentResource> (response, "response is CommentResource");
        }
        
        /// <summary>
        /// Test AddVideoContributor
        /// </summary>
        [Test]
        public void AddVideoContributorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //ContributionResource contributionResource = null;
            //instance.AddVideoContributor(videoId, contributionResource);
            
        }
        
        /// <summary>
        /// Test AddVideoFlag
        /// </summary>
        [Test]
        public void AddVideoFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //StringWrapper reason = null;
            //var response = instance.AddVideoFlag(videoId, reason);
            //Assert.IsInstanceOf<FlagResource> (response, "response is FlagResource");
        }
        
        /// <summary>
        /// Test AddVideoRelationships
        /// </summary>
        [Test]
        public void AddVideoRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //VideoRelationshipResource videoRelationshipResource = null;
            //var response = instance.AddVideoRelationships(videoId, videoRelationshipResource);
            //Assert.IsInstanceOf<VideoRelationshipResource> (response, "response is VideoRelationshipResource");
        }
        
        /// <summary>
        /// Test CreateVideoDisposition
        /// </summary>
        [Test]
        public void CreateVideoDispositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //DispositionResource dispositionResource = null;
            //var response = instance.CreateVideoDisposition(videoId, dispositionResource);
            //Assert.IsInstanceOf<DispositionResource> (response, "response is DispositionResource");
        }
        
        /// <summary>
        /// Test CreateVideoTemplate
        /// </summary>
        [Test]
        public void CreateVideoTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource videoTemplateResource = null;
            //var response = instance.CreateVideoTemplate(videoTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test DeleteVideo
        /// </summary>
        [Test]
        public void DeleteVideoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteVideo(id);
            
        }
        
        /// <summary>
        /// Test DeleteVideoComment
        /// </summary>
        [Test]
        public void DeleteVideoCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? id = null;
            //instance.DeleteVideoComment(videoId, id);
            
        }
        
        /// <summary>
        /// Test DeleteVideoDisposition
        /// </summary>
        [Test]
        public void DeleteVideoDispositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? dispositionId = null;
            //instance.DeleteVideoDisposition(dispositionId);
            
        }
        
        /// <summary>
        /// Test DeleteVideoFlag
        /// </summary>
        [Test]
        public void DeleteVideoFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //instance.DeleteVideoFlag(videoId);
            
        }
        
        /// <summary>
        /// Test DeleteVideoRelationship
        /// </summary>
        [Test]
        public void DeleteVideoRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? id = null;
            //instance.DeleteVideoRelationship(videoId, id);
            
        }
        
        /// <summary>
        /// Test DeleteVideoTemplate
        /// </summary>
        [Test]
        public void DeleteVideoTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteVideoTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetUserVideos
        /// </summary>
        [Test]
        public void GetUserVideosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //bool? excludeFlagged = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUserVideos(userId, excludeFlagged, size, page);
            //Assert.IsInstanceOf<PageResourceVideoResource> (response, "response is PageResourceVideoResource");
        }
        
        /// <summary>
        /// Test GetVideo
        /// </summary>
        [Test]
        public void GetVideoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetVideo(id);
            //Assert.IsInstanceOf<VideoResource> (response, "response is VideoResource");
        }
        
        /// <summary>
        /// Test GetVideoComments
        /// </summary>
        [Test]
        public void GetVideoCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetVideoComments(videoId, size, page);
            //Assert.IsInstanceOf<PageResourceCommentResource> (response, "response is PageResourceCommentResource");
        }
        
        /// <summary>
        /// Test GetVideoDispositions
        /// </summary>
        [Test]
        public void GetVideoDispositionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? videoId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetVideoDispositions(videoId, size, page);
            //Assert.IsInstanceOf<PageResourceDispositionResource> (response, "response is PageResourceDispositionResource");
        }
        
        /// <summary>
        /// Test GetVideoRelationships
        /// </summary>
        [Test]
        public void GetVideoRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetVideoRelationships(videoId, size, page);
            //Assert.IsInstanceOf<PageResourceVideoRelationshipResource> (response, "response is PageResourceVideoRelationshipResource");
        }
        
        /// <summary>
        /// Test GetVideoTemplate
        /// </summary>
        [Test]
        public void GetVideoTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetVideoTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetVideoTemplates
        /// </summary>
        [Test]
        public void GetVideoTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetVideoTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetVideos
        /// </summary>
        [Test]
        public void GetVideosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? excludeFlagged = null;
            //int? filterVideosByUploader = null;
            //string filterCategory = null;
            //string filterTagset = null;
            //string filterVideosByName = null;
            //int? filterVideosByContributor = null;
            //int? filterVideosByAuthor = null;
            //bool? filterHasAuthor = null;
            //bool? filterHasUploader = null;
            //string filterRelatedTo = null;
            //bool? filterFriends = null;
            //string filterDisposition = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetVideos(excludeFlagged, filterVideosByUploader, filterCategory, filterTagset, filterVideosByName, filterVideosByContributor, filterVideosByAuthor, filterHasAuthor, filterHasUploader, filterRelatedTo, filterFriends, filterDisposition, size, page, order);
            //Assert.IsInstanceOf<PageResourceVideoResource> (response, "response is PageResourceVideoResource");
        }
        
        /// <summary>
        /// Test RemoveUserFromVideoWhitelist
        /// </summary>
        [Test]
        public void RemoveUserFromVideoWhitelistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //int? id = null;
            //instance.RemoveUserFromVideoWhitelist(videoId, id);
            
        }
        
        /// <summary>
        /// Test RemoveVideoContributor
        /// </summary>
        [Test]
        public void RemoveVideoContributorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //int? id = null;
            //instance.RemoveVideoContributor(videoId, id);
            
        }
        
        /// <summary>
        /// Test UpdateVideo
        /// </summary>
        [Test]
        public void UpdateVideoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //VideoResource videoResource = null;
            //instance.UpdateVideo(id, videoResource);
            
        }
        
        /// <summary>
        /// Test UpdateVideoComment
        /// </summary>
        [Test]
        public void UpdateVideoCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? id = null;
            //StringWrapper content = null;
            //instance.UpdateVideoComment(videoId, id, content);
            
        }
        
        /// <summary>
        /// Test UpdateVideoRelationship
        /// </summary>
        [Test]
        public void UpdateVideoRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? videoId = null;
            //long? relationshipId = null;
            //StringWrapper details = null;
            //instance.UpdateVideoRelationship(videoId, relationshipId, details);
            
        }
        
        /// <summary>
        /// Test UpdateVideoTemplate
        /// </summary>
        [Test]
        public void UpdateVideoTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource videoTemplateResource = null;
            //var response = instance.UpdateVideoTemplate(id, videoTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test ViewVideo
        /// </summary>
        [Test]
        public void ViewVideoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.ViewVideo(id);
            
        }
        
    }

}
