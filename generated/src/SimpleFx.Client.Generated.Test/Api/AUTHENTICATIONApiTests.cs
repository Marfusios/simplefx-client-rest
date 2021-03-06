/* 
 * SimpleFX
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Model;

namespace SimpleFx.Client.Generated.Test
{
    /// <summary>
    ///  Class for testing AUTHENTICATIONApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AUTHENTICATIONApiTests : IDisposable
    {
        private AUTHENTICATIONApi instance;

        public AUTHENTICATIONApiTests()
        {
            instance = new AUTHENTICATIONApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AUTHENTICATIONApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AUTHENTICATIONApi
            //Assert.IsType(typeof(AUTHENTICATIONApi), instance, "instance is a AUTHENTICATIONApi");
        }

        
        /// <summary>
        /// Test ApiV3AuthKeyPost
        /// </summary>
        [Fact]
        public void ApiV3AuthKeyPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject inlineObject = null;
            //var response = instance.ApiV3AuthKeyPost(inlineObject);
            //Assert.IsType<InlineResponse200> (response, "response is InlineResponse200");
        }
        
    }

}
