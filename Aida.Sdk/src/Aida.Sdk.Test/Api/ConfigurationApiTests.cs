/*
 * aida
 *
 * 1.0.703.2
 *
 * The version of the OpenAPI document: 1.0.703.2
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
    ///  Class for testing ConfigurationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConfigurationApiTests : IDisposable
    {
        private ConfigurationApi instance;

        public ConfigurationApiTests()
        {
            instance = new ConfigurationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConfigurationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConfigurationApi
            //Assert.IsType<ConfigurationApi>(instance);
        }

        /// <summary>
        /// Test GetConfigurationKeys
        /// </summary>
        [Fact]
        public void GetConfigurationKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetConfigurationKeys();
            //Assert.IsType<Dictionary<string, string>>(response);
        }

        /// <summary>
        /// Test ReloadConfiguration
        /// </summary>
        [Fact]
        public void ReloadConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ReloadConfiguration();
        }

        /// <summary>
        /// Test UpdateConfigFile
        /// </summary>
        [Fact]
        public void UpdateConfigFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //List<FileParameter> fileParameter = null;
            //instance.UpdateConfigFile(scannerId, fileParameter);
        }
    }
}
