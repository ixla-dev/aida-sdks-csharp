/*
 * aida
 *
 * 1.0.703.4
 *
 * The version of the OpenAPI document: 1.0.703.4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Aida.Sdk.Client;
using Aida.Sdk.Api;
// uncomment below to import models
//using Aida.Sdk.Model;

namespace Aida.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ServiceApiTests : IDisposable
    {
        private ServiceApi instance;

        public ServiceApiTests()
        {
            instance = new ServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ServiceApi
            //Assert.IsType<ServiceApi>(instance);
        }

        /// <summary>
        /// Test CancelTest
        /// </summary>
        [Fact]
        public void CancelTestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.CancelTest();
        }

        /// <summary>
        /// Test GetTestState
        /// </summary>
        [Fact]
        public void GetTestStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DiagnosticTaskType? taskType = null;
            //var response = instance.GetTestState(taskType);
            //Assert.IsType<DiagnosticTaskState>(response);
        }

        /// <summary>
        /// Test StartTestAutopos
        /// </summary>
        [Fact]
        public void StartTestAutoposTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestAutoposStartParams testAutoposStartParams = null;
            //instance.StartTestAutopos(testAutoposStartParams);
        }

        /// <summary>
        /// Test StartTestMagStripe
        /// </summary>
        [Fact]
        public void StartTestMagStripeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestMagStripeStartParams testMagStripeStartParams = null;
            //instance.StartTestMagStripe(testMagStripeStartParams);
        }

        /// <summary>
        /// Test StartTestOcr
        /// </summary>
        [Fact]
        public void StartTestOcrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestOcrStartParams testOcrStartParams = null;
            //instance.StartTestOcr(testOcrStartParams);
        }

        /// <summary>
        /// Test StartTestTransport
        /// </summary>
        [Fact]
        public void StartTestTransportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestTransportStartParams testTransportStartParams = null;
            //instance.StartTestTransport(testTransportStartParams);
        }
    }
}
