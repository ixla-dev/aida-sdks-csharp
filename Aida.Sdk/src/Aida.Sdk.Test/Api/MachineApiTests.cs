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
    ///  Class for testing MachineApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MachineApiTests : IDisposable
    {
        private MachineApi instance;

        public MachineApiTests()
        {
            instance = new MachineApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MachineApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MachineApi
            //Assert.IsType<MachineApi>(instance);
        }

        /// <summary>
        /// Test GetDeviceDescriptorById
        /// </summary>
        [Fact]
        public void GetDeviceDescriptorByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetDeviceDescriptorById(id);
            //Assert.IsType<DeviceDefinition>(response);
        }

        /// <summary>
        /// Test GetMachineAddresses
        /// </summary>
        [Fact]
        public void GetMachineAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMachineAddresses();
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetMachineStatus
        /// </summary>
        [Fact]
        public void GetMachineStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMachineStatus();
            //Assert.IsType<MachineStatusDto>(response);
        }

        /// <summary>
        /// Test GetSystemInformation
        /// </summary>
        [Fact]
        public void GetSystemInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetSystemInformation();
        }

        /// <summary>
        /// Test ListDevicesByModule
        /// </summary>
        [Fact]
        public void ListDevicesByModuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string moduleId = null;
            //List<DeviceType> deviceType = null;
            //var response = instance.ListDevicesByModule(moduleId, deviceType);
            //Assert.IsType<List<DeviceDefinition>>(response);
        }

        /// <summary>
        /// Test ListModules
        /// </summary>
        [Fact]
        public void ListModulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListModules();
            //Assert.IsType<List<ModuleDefinition>>(response);
        }

        /// <summary>
        /// Test ListScanners
        /// </summary>
        [Fact]
        public void ListScannersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListScanners();
            //Assert.IsType<List<ScannerModuleDefinition>>(response);
        }
    }
}
