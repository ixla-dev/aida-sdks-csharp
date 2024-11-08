/*
 * aida
 *
 * 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
 *
 * The version of the OpenAPI document: 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
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

namespace Aida.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ModbusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModbusApiTests : IDisposable
    {
        private ModbusApi instance;

        public ModbusApiTests()
        {
            instance = new ModbusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModbusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ModbusApi
            //Assert.IsType<ModbusApi>(instance);
        }

        /// <summary>
        /// Test AidaV1ModbusPortLoopReadPost
        /// </summary>
        [Fact]
        public void AidaV1ModbusPortLoopReadPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string port = null;
            //int? slave = null;
            //int? address = null;
            //int? lenght = null;
            //instance.AidaV1ModbusPortLoopReadPost(port, slave, address, lenght);
        }

        /// <summary>
        /// Test AidaV1ModbusPortSlaveIdHexRegistersGet
        /// </summary>
        [Fact]
        public void AidaV1ModbusPortSlaveIdHexRegistersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string port = null;
            //string slaveIdHex = null;
            //string startHex = null;
            //string lengthHex = null;
            //var response = instance.AidaV1ModbusPortSlaveIdHexRegistersGet(port, slaveIdHex, startHex, lengthHex);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetModbusClients
        /// </summary>
        [Fact]
        public void GetModbusClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetModbusClients();
        }

        /// <summary>
        /// Test ReadAllRegisters
        /// </summary>
        [Fact]
        public void ReadAllRegistersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string slaveIdHex = null;
            //string port = null;
            //var response = instance.ReadAllRegisters(slaveIdHex, port);
            //Assert.IsType<List<int>>(response);
        }

        /// <summary>
        /// Test ReadHoldingRegisters
        /// </summary>
        [Fact]
        public void ReadHoldingRegistersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string port = null;
            //string body = null;
            //instance.ReadHoldingRegisters(port, body);
        }

        /// <summary>
        /// Test WriteSingleRegister
        /// </summary>
        [Fact]
        public void WriteSingleRegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string port = null;
            //string body = null;
            //instance.WriteSingleRegister(port, body);
        }
    }
}
