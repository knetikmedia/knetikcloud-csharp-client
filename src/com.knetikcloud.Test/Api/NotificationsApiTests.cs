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
    ///  Class for testing NotificationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NotificationsApiTests
    {
        private NotificationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NotificationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NotificationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NotificationsApi
            //Assert.IsInstanceOfType(typeof(NotificationsApi), instance, "instance is a NotificationsApi");
        }

        
        /// <summary>
        /// Test CreateNotificationType
        /// </summary>
        [Test]
        public void CreateNotificationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NotificationTypeResource notificationType = null;
            //var response = instance.CreateNotificationType(notificationType);
            //Assert.IsInstanceOf<NotificationTypeResource> (response, "response is NotificationTypeResource");
        }
        
        /// <summary>
        /// Test DeleteNotificationType
        /// </summary>
        [Test]
        public void DeleteNotificationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteNotificationType(id);
            
        }
        
        /// <summary>
        /// Test GetNotificationType
        /// </summary>
        [Test]
        public void GetNotificationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetNotificationType(id);
            //Assert.IsInstanceOf<NotificationTypeResource> (response, "response is NotificationTypeResource");
        }
        
        /// <summary>
        /// Test GetNotificationTypes
        /// </summary>
        [Test]
        public void GetNotificationTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetNotificationTypes(size, page, order);
            //Assert.IsInstanceOf<PageResourceNotificationTypeResource> (response, "response is PageResourceNotificationTypeResource");
        }
        
        /// <summary>
        /// Test GetUserNotificationInfo
        /// </summary>
        [Test]
        public void GetUserNotificationInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string typeId = null;
            //string userId = null;
            //var response = instance.GetUserNotificationInfo(typeId, userId);
            //Assert.IsInstanceOf<NotificationUserTypeResource> (response, "response is NotificationUserTypeResource");
        }
        
        /// <summary>
        /// Test GetUserNotificationInfoList
        /// </summary>
        [Test]
        public void GetUserNotificationInfoListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetUserNotificationInfoList(userId, size, page, order);
            //Assert.IsInstanceOf<PageResourceNotificationUserTypeResource> (response, "response is PageResourceNotificationUserTypeResource");
        }
        
        /// <summary>
        /// Test GetUserNotifications
        /// </summary>
        [Test]
        public void GetUserNotificationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filterStatus = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetUserNotifications(id, filterStatus, size, page, order);
            //Assert.IsInstanceOf<PageResourceUserNotificationResource> (response, "response is PageResourceUserNotificationResource");
        }
        
        /// <summary>
        /// Test SendNotification
        /// </summary>
        [Test]
        public void SendNotificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NotificationResource notification = null;
            //var response = instance.SendNotification(notification);
            //Assert.IsInstanceOf<NotificationResource> (response, "response is NotificationResource");
        }
        
        /// <summary>
        /// Test SetUserNotificationStatus
        /// </summary>
        [Test]
        public void SetUserNotificationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string notificationId = null;
            //ValueWrapperstring notification = null;
            //instance.SetUserNotificationStatus(userId, notificationId, notification);
            
        }
        
        /// <summary>
        /// Test SilenceDirectNotifications
        /// </summary>
        [Test]
        public void SilenceDirectNotificationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string typeId = null;
            //string userId = null;
            //ValueWrapperboolean silenced = null;
            //instance.SilenceDirectNotifications(typeId, userId, silenced);
            
        }
        
        /// <summary>
        /// Test UpdateNotificationType
        /// </summary>
        [Test]
        public void UpdateNotificationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //NotificationTypeResource notificationType = null;
            //var response = instance.UpdateNotificationType(id, notificationType);
            //Assert.IsInstanceOf<NotificationTypeResource> (response, "response is NotificationTypeResource");
        }
        
    }

}
