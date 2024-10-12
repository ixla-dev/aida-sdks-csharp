/*
 * aida
 *
 * 1.0.713
 *
 * The version of the OpenAPI document: 1.0.713
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
    ///  Class for testing LampApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LampApiTests : IDisposable
    {
        private LampApi instance;

        public LampApiTests()
        {
            instance = new LampApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LampApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LampApi
            //Assert.IsType<LampApi>(instance);
        }

        /// <summary>
        /// Test GetLampState
        /// </summary>
        [Fact]
        public void GetLampStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LampState? state = null;
            //instance.GetLampState(state);
        }

        /// <summary>
        /// Test SetLampState
        /// </summary>
        [Fact]
        public void SetLampStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LampState? state = null;
            //instance.SetLampState(state);
        }
    }
}
