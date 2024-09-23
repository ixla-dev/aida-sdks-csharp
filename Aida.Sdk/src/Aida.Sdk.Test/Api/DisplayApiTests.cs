/*
 * aida
 *
 * 1.0.704.0
 *
 * The version of the OpenAPI document: 1.0.704.0
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
    ///  Class for testing DisplayApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DisplayApiTests : IDisposable
    {
        private DisplayApi instance;

        public DisplayApiTests()
        {
            instance = new DisplayApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DisplayApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DisplayApi
            //Assert.IsType<DisplayApi>(instance);
        }

        /// <summary>
        /// Test SendData
        /// </summary>
        [Fact]
        public void SendDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //byte[] body = null;
            //var response = instance.SendData(body);
            //Assert.IsType<DisplayActionResult>(response);
        }

        /// <summary>
        /// Test ShowErrorWindow
        /// </summary>
        [Fact]
        public void ShowErrorWindowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShowErrorWindowParamsDto showErrorWindowParamsDto = null;
            //var response = instance.ShowErrorWindow(showErrorWindowParamsDto);
            //Assert.IsType<DisplayActionResult>(response);
        }

        /// <summary>
        /// Test ShowMainWindow
        /// </summary>
        [Fact]
        public void ShowMainWindowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShowMainWindowParamsDto showMainWindowParamsDto = null;
            //var response = instance.ShowMainWindow(showMainWindowParamsDto);
            //Assert.IsType<DisplayActionResult>(response);
        }

        /// <summary>
        /// Test ShowResetWindow
        /// </summary>
        [Fact]
        public void ShowResetWindowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShowResetButtonParamsDto showResetButtonParamsDto = null;
            //var response = instance.ShowResetWindow(showResetButtonParamsDto);
            //Assert.IsType<DisplayActionResult>(response);
        }
    }
}
