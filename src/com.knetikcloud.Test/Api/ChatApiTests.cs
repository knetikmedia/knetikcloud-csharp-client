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
    ///  Class for testing ChatApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ChatApiTests
    {
        private ChatApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChatApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChatApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChatApi
            //Assert.IsInstanceOfType(typeof(ChatApi), instance, "instance is a ChatApi");
        }

        
        /// <summary>
        /// Test AcknowledgeChatMessage
        /// </summary>
        [Test]
        public void AcknowledgeChatMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? readCount = null;
            //instance.AcknowledgeChatMessage(id, readCount);
            
        }
        
        /// <summary>
        /// Test AddChatMessageBlacklist
        /// </summary>
        [Test]
        public void AddChatMessageBlacklistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? blacklistedUserId = null;
            //string id = null;
            //instance.AddChatMessageBlacklist(blacklistedUserId, id);
            
        }
        
        /// <summary>
        /// Test DeleteChatMessage
        /// </summary>
        [Test]
        public void DeleteChatMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteChatMessage(id);
            
        }
        
        /// <summary>
        /// Test EditChatMessage
        /// </summary>
        [Test]
        public void EditChatMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ChatMessageResource chatMessageResource = null;
            //instance.EditChatMessage(id, chatMessageResource);
            
        }
        
        /// <summary>
        /// Test GetChatMessage
        /// </summary>
        [Test]
        public void GetChatMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetChatMessage(id);
            //Assert.IsInstanceOf<ChatMessageResource> (response, "response is ChatMessageResource");
        }
        
        /// <summary>
        /// Test GetChatMessageBlacklist
        /// </summary>
        [Test]
        public void GetChatMessageBlacklistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetChatMessageBlacklist(id);
            //Assert.IsInstanceOf<List<ChatBlacklistResource>> (response, "response is List<ChatBlacklistResource>");
        }
        
        /// <summary>
        /// Test GetChatThreads
        /// </summary>
        [Test]
        public void GetChatThreadsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetChatThreads(size, page, order);
            //Assert.IsInstanceOf<PageResourceChatUserThreadResource> (response, "response is PageResourceChatUserThreadResource");
        }
        
        /// <summary>
        /// Test GetDirectMessages
        /// </summary>
        [Test]
        public void GetDirectMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetDirectMessages(id, size, page, order);
            //Assert.IsInstanceOf<PageResourceChatMessageResource> (response, "response is PageResourceChatMessageResource");
        }
        
        /// <summary>
        /// Test GetThreadMessages
        /// </summary>
        [Test]
        public void GetThreadMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetThreadMessages(id, size, page, order);
            //Assert.IsInstanceOf<PageResourceChatMessageResource> (response, "response is PageResourceChatMessageResource");
        }
        
        /// <summary>
        /// Test GetTopicMessages
        /// </summary>
        [Test]
        public void GetTopicMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetTopicMessages(id, size, page, order);
            //Assert.IsInstanceOf<PageResourceChatMessageResource> (response, "response is PageResourceChatMessageResource");
        }
        
        /// <summary>
        /// Test RemoveChatBlacklist
        /// </summary>
        [Test]
        public void RemoveChatBlacklistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? blacklistedUserId = null;
            //string id = null;
            //instance.RemoveChatBlacklist(blacklistedUserId, id);
            
        }
        
        /// <summary>
        /// Test SendMessage
        /// </summary>
        [Test]
        public void SendMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChatMessageResource chatMessageResource = null;
            //var response = instance.SendMessage(chatMessageResource);
            //Assert.IsInstanceOf<ChatMessageResource> (response, "response is ChatMessageResource");
        }
        
    }

}
