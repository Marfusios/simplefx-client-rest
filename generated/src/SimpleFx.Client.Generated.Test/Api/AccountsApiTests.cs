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
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountsApiTests : IDisposable
    {
        private AccountsApi instance;

        public AccountsApiTests()
        {
            instance = new AccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountsApi
            //Assert.IsType(typeof(AccountsApi), instance, "instance is a AccountsApi");
        }

        
        /// <summary>
        /// Test V3AccountsGetAccount
        /// </summary>
        [Fact]
        public void V3AccountsGetAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Reality reality = null;
            //int account = null;
            //var response = instance.V3AccountsGetAccount(reality, account);
            //Assert.IsType<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test V3AccountsGetAccounts
        /// </summary>
        [Fact]
        public void V3AccountsGetAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V3AccountsGetAccounts();
            //Assert.IsType<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
    }

}
