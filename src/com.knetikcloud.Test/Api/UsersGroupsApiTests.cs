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
    ///  Class for testing UsersGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersGroupsApiTests
    {
        private UsersGroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersGroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersGroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersGroupsApi
            //Assert.IsInstanceOfType(typeof(UsersGroupsApi), instance, "instance is a UsersGroupsApi");
        }

        
        /// <summary>
        /// Test AddMemberToGroup
        /// </summary>
        [Test]
        public void AddMemberToGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //GroupMemberResource user = null;
            //var response = instance.AddMemberToGroup(uniqueName, user);
            //Assert.IsInstanceOf<GroupMemberResource> (response, "response is GroupMemberResource");
        }
        
        /// <summary>
        /// Test AddMembersToGroup
        /// </summary>
        [Test]
        public void AddMembersToGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //List<GroupMemberResource> users = null;
            //var response = instance.AddMembersToGroup(uniqueName, users);
            //Assert.IsInstanceOf<List<GroupMemberResource>> (response, "response is List<GroupMemberResource>");
        }
        
        /// <summary>
        /// Test CreateGroup
        /// </summary>
        [Test]
        public void CreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupResource groupResource = null;
            //var response = instance.CreateGroup(groupResource);
            //Assert.IsInstanceOf<GroupResource> (response, "response is GroupResource");
        }
        
        /// <summary>
        /// Test CreateGroupMemberTemplate
        /// </summary>
        [Test]
        public void CreateGroupMemberTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource groupMemberTemplateResource = null;
            //var response = instance.CreateGroupMemberTemplate(groupMemberTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test CreateGroupTemplate
        /// </summary>
        [Test]
        public void CreateGroupTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource groupTemplateResource = null;
            //var response = instance.CreateGroupTemplate(groupTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test DeleteGroup
        /// </summary>
        [Test]
        public void DeleteGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //instance.DeleteGroup(uniqueName);
            
        }
        
        /// <summary>
        /// Test DeleteGroupMemberTemplate
        /// </summary>
        [Test]
        public void DeleteGroupMemberTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteGroupMemberTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test DeleteGroupTemplate
        /// </summary>
        [Test]
        public void DeleteGroupTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteGroupTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Test]
        public void GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //var response = instance.GetGroup(uniqueName);
            //Assert.IsInstanceOf<GroupResource> (response, "response is GroupResource");
        }
        
        /// <summary>
        /// Test GetGroupMember
        /// </summary>
        [Test]
        public void GetGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //int? userId = null;
            //var response = instance.GetGroupMember(uniqueName, userId);
            //Assert.IsInstanceOf<GroupMemberResource> (response, "response is GroupMemberResource");
        }
        
        /// <summary>
        /// Test GetGroupMemberTemplate
        /// </summary>
        [Test]
        public void GetGroupMemberTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetGroupMemberTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetGroupMemberTemplates
        /// </summary>
        [Test]
        public void GetGroupMemberTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetGroupMemberTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetGroupMembers
        /// </summary>
        [Test]
        public void GetGroupMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetGroupMembers(uniqueName, size, page, order);
            //Assert.IsInstanceOf<PageResourceGroupMemberResource> (response, "response is PageResourceGroupMemberResource");
        }
        
        /// <summary>
        /// Test GetGroupTemplate
        /// </summary>
        [Test]
        public void GetGroupTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetGroupTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetGroupTemplates
        /// </summary>
        [Test]
        public void GetGroupTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetGroupTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetGroupsForUser
        /// </summary>
        [Test]
        public void GetGroupsForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //bool? filterChildren = null;
            //var response = instance.GetGroupsForUser(userId, filterChildren);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test ListGroups
        /// </summary>
        [Test]
        public void ListGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterTemplate = null;
            //string filterMemberCount = null;
            //string filterName = null;
            //string filterUniqueName = null;
            //string filterParent = null;
            //string filterStatus = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.ListGroups(filterTemplate, filterMemberCount, filterName, filterUniqueName, filterParent, filterStatus, size, page, order);
            //Assert.IsInstanceOf<PageResourceGroupResource> (response, "response is PageResourceGroupResource");
        }
        
        /// <summary>
        /// Test RemoveGroupMember
        /// </summary>
        [Test]
        public void RemoveGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //int? userId = null;
            //instance.RemoveGroupMember(uniqueName, userId);
            
        }
        
        /// <summary>
        /// Test UpdateGroup
        /// </summary>
        [Test]
        public void UpdateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //GroupResource groupResource = null;
            //instance.UpdateGroup(uniqueName, groupResource);
            
        }
        
        /// <summary>
        /// Test UpdateGroupMemberProperties
        /// </summary>
        [Test]
        public void UpdateGroupMemberPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //int? userId = null;
            //StringWrapper order = null;
            //instance.UpdateGroupMemberProperties(uniqueName, userId, order);
            
        }
        
        /// <summary>
        /// Test UpdateGroupMemberProperties1
        /// </summary>
        [Test]
        public void UpdateGroupMemberProperties1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //int? userId = null;
            //Object properties = null;
            //instance.UpdateGroupMemberProperties1(uniqueName, userId, properties);
            
        }
        
        /// <summary>
        /// Test UpdateGroupMemberStatus
        /// </summary>
        [Test]
        public void UpdateGroupMemberStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueName = null;
            //int? userId = null;
            //string status = null;
            //instance.UpdateGroupMemberStatus(uniqueName, userId, status);
            
        }
        
        /// <summary>
        /// Test UpdateGroupMemberTemplate
        /// </summary>
        [Test]
        public void UpdateGroupMemberTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource groupMemberTemplateResource = null;
            //var response = instance.UpdateGroupMemberTemplate(id, groupMemberTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test UpdateGroupTemplate
        /// </summary>
        [Test]
        public void UpdateGroupTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource groupTemplateResource = null;
            //var response = instance.UpdateGroupTemplate(id, groupTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
    }

}
