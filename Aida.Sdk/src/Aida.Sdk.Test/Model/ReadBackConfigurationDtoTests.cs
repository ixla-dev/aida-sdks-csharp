/*
 * aida
 *
 * 1.0.703.4
 *
 * The version of the OpenAPI document: 1.0.703.4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Aida.Sdk.Model;
using Aida.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Aida.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing ReadBackConfigurationDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReadBackConfigurationDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReadBackConfigurationDto
        //private ReadBackConfigurationDto instance;

        public ReadBackConfigurationDtoTests()
        {
            // TODO uncomment below to create an instance of ReadBackConfigurationDto
            //instance = new ReadBackConfigurationDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReadBackConfigurationDto
        /// </summary>
        [Fact]
        public void ReadBackConfigurationDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" ReadBackConfigurationDto
            //Assert.IsType<ReadBackConfigurationDto>(instance);
        }

        /// <summary>
        /// Test deserialize a ChipReadBackConfigurationDto from type ReadBackConfigurationDto
        /// </summary>
        [Fact]
        public void ChipReadBackConfigurationDtoDeserializeFromReadBackConfigurationDtoTest()
        {
            // TODO uncomment below to test deserialize a ChipReadBackConfigurationDto from type ReadBackConfigurationDto
            //Assert.IsType<ReadBackConfigurationDto>(JsonConvert.DeserializeObject<ReadBackConfigurationDto>(new ChipReadBackConfigurationDto().ToJson()));
        }

        /// <summary>
        /// Test deserialize a MagneticReadBackConfigurationDto from type ReadBackConfigurationDto
        /// </summary>
        [Fact]
        public void MagneticReadBackConfigurationDtoDeserializeFromReadBackConfigurationDtoTest()
        {
            // TODO uncomment below to test deserialize a MagneticReadBackConfigurationDto from type ReadBackConfigurationDto
            //Assert.IsType<ReadBackConfigurationDto>(JsonConvert.DeserializeObject<ReadBackConfigurationDto>(new MagneticReadBackConfigurationDto().ToJson()));
        }

        /// <summary>
        /// Test deserialize a OcrReadBackConfigurationDto from type ReadBackConfigurationDto
        /// </summary>
        [Fact]
        public void OcrReadBackConfigurationDtoDeserializeFromReadBackConfigurationDtoTest()
        {
            // TODO uncomment below to test deserialize a OcrReadBackConfigurationDto from type ReadBackConfigurationDto
            //Assert.IsType<ReadBackConfigurationDto>(JsonConvert.DeserializeObject<ReadBackConfigurationDto>(new OcrReadBackConfigurationDto().ToJson()));
        }

        /// <summary>
        /// Test the property 'Discriminator'
        /// </summary>
        [Fact]
        public void DiscriminatorTest()
        {
            // TODO unit test for the property 'Discriminator'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'ReadBackType'
        /// </summary>
        [Fact]
        public void ReadBackTypeTest()
        {
            // TODO unit test for the property 'ReadBackType'
        }

        /// <summary>
        /// Test the property 'RequiredSide'
        /// </summary>
        [Fact]
        public void RequiredSideTest()
        {
            // TODO unit test for the property 'RequiredSide'
        }

        /// <summary>
        /// Test the property 'JobTemplateId'
        /// </summary>
        [Fact]
        public void JobTemplateIdTest()
        {
            // TODO unit test for the property 'JobTemplateId'
        }
    }
}
