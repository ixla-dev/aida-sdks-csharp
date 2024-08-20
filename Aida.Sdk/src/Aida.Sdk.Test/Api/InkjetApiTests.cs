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
    ///  Class for testing InkjetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InkjetApiTests : IDisposable
    {
        private InkjetApi instance;

        public InkjetApiTests()
        {
            instance = new InkjetApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InkjetApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InkjetApi
            //Assert.IsType<InkjetApi>(instance);
        }

        /// <summary>
        /// Test AddEntityToInkjetLayout
        /// </summary>
        [Fact]
        public void AddEntityToInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int inkjetLayoutId = null;
            //string entityName = null;
            //int? xPosition = null;
            //int? yPosition = null;
            //List<FileParameter> imageFile = null;
            //instance.AddEntityToInkjetLayout(inkjetLayoutId, entityName, xPosition, yPosition, imageFile);
        }

        /// <summary>
        /// Test AidaV1InkjetLogerrorIdPut
        /// </summary>
        [Fact]
        public void AidaV1InkjetLogerrorIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //AidaLogEntry aidaLogEntry = null;
            //instance.AidaV1InkjetLogerrorIdPut(id, aidaLogEntry);
        }

        /// <summary>
        /// Test AidaV1InkjetLogerrorPost
        /// </summary>
        [Fact]
        public void AidaV1InkjetLogerrorPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AidaLogEntry aidaLogEntry = null;
            //instance.AidaV1InkjetLogerrorPost(aidaLogEntry);
        }

        /// <summary>
        /// Test AidaV1InkjetPrintStatusGet
        /// </summary>
        [Fact]
        public void AidaV1InkjetPrintStatusGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AidaV1InkjetPrintStatusGet();
            //Assert.IsType<PrintStatus>(response);
        }

        /// <summary>
        /// Test AidaV1InkjetPrintheadMoveToPrintareaPost
        /// </summary>
        [Fact]
        public void AidaV1InkjetPrintheadMoveToPrintareaPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.AidaV1InkjetPrintheadMoveToPrintareaPost();
        }

        /// <summary>
        /// Test AidaV1InkjetSetPrintheadOffsetPost
        /// </summary>
        [Fact]
        public void AidaV1InkjetSetPrintheadOffsetPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? x = null;
            //instance.AidaV1InkjetSetPrintheadOffsetPost(x);
        }

        /// <summary>
        /// Test AidaV1InkjetStartCyclePost
        /// </summary>
        [Fact]
        public void AidaV1InkjetStartCyclePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenericCycleTypes? cycle = null;
            //instance.AidaV1InkjetStartCyclePost(cycle);
        }

        /// <summary>
        /// Test AidaV1InkjetStartPrintPost
        /// </summary>
        [Fact]
        public void AidaV1InkjetStartPrintPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? x = null;
            //PrintCycleModes? modes = null;
            //instance.AidaV1InkjetStartPrintPost(x, modes);
        }

        /// <summary>
        /// Test CanPrint
        /// </summary>
        [Fact]
        public void CanPrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CanPrint();
            //Assert.IsType<CanPrintDto>(response);
        }

        /// <summary>
        /// Test CloseJob
        /// </summary>
        [Fact]
        public void CloseJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.CloseJob();
        }

        /// <summary>
        /// Test CreateInkjetLayout
        /// </summary>
        [Fact]
        public void CreateInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string inkjetLayoutName = null;
            //var response = instance.CreateInkjetLayout(inkjetLayoutName);
            //Assert.IsType<int>(response);
        }

        /// <summary>
        /// Test CreateNewJob
        /// </summary>
        [Fact]
        public void CreateNewJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.CreateNewJob();
        }

        /// <summary>
        /// Test DeleteInkjetLayout
        /// </summary>
        [Fact]
        public void DeleteInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteInkjetLayout(id);
        }

        /// <summary>
        /// Test EnablePrint
        /// </summary>
        [Fact]
        public void EnablePrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.EnablePrint();
        }

        /// <summary>
        /// Test FindInkjetLayouts
        /// </summary>
        [Fact]
        public void FindInkjetLayoutsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? includeFile = null;
            //bool? includeEntities = null;
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.FindInkjetLayouts(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<SearchInkjetLayoutsResultDto>(response);
        }

        /// <summary>
        /// Test GetActiveEntities
        /// </summary>
        [Fact]
        public void GetActiveEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetActiveEntities();
            //Assert.IsType<InkjetLayoutDto>(response);
        }

        /// <summary>
        /// Test GetAssignableInkjetLayoutsByJobTemplateId
        /// </summary>
        [Fact]
        public void GetAssignableInkjetLayoutsByJobTemplateIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //int? pageSize = null;
            //string supportSide = null;
            //var response = instance.GetAssignableInkjetLayoutsByJobTemplateId(id, page, pageSize, supportSide);
            //Assert.IsType<SearchInkjetLayoutsResultDto>(response);
        }

        /// <summary>
        /// Test GetCleaningConfiguration
        /// </summary>
        [Fact]
        public void GetCleaningConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCleaningConfiguration();
            //Assert.IsType<CleaningConfigurationDto>(response);
        }

        /// <summary>
        /// Test GetCuringSettings
        /// </summary>
        [Fact]
        public void GetCuringSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCuringSettings();
            //Assert.IsType<CuringSettingsDto>(response);
        }

        /// <summary>
        /// Test GetHeatersTemperature
        /// </summary>
        [Fact]
        public void GetHeatersTemperatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetHeatersTemperature();
            //Assert.IsType<InkjetTemperaturesDto>(response);
        }

        /// <summary>
        /// Test GetInkjetMaintenanceStatus
        /// </summary>
        [Fact]
        public void GetInkjetMaintenanceStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInkjetMaintenanceStatus();
            //Assert.IsType<InkjetMaintenanceStatusDto>(response);
        }

        /// <summary>
        /// Test GetMultipassImages
        /// </summary>
        [Fact]
        public void GetMultipassImagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetMultipassImages();
        }

        /// <summary>
        /// Test GetPinningSettings
        /// </summary>
        [Fact]
        public void GetPinningSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPinningSettings();
            //Assert.IsType<PinningSettingsDto>(response);
        }

        /// <summary>
        /// Test GetPrintLayoutPreview
        /// </summary>
        [Fact]
        public void GetPrintLayoutPreviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetPrintLayoutPreview();
        }

        /// <summary>
        /// Test GetPrinterPrintSettings
        /// </summary>
        [Fact]
        public void GetPrinterPrintSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPrinterPrintSettings();
            //Assert.IsType<PrintSettingsDto>(response);
        }

        /// <summary>
        /// Test GetVacuumPressure
        /// </summary>
        [Fact]
        public void GetVacuumPressureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVacuumPressure();
            //Assert.IsType<float>(response);
        }

        /// <summary>
        /// Test GetXPrintState
        /// </summary>
        [Fact]
        public void GetXPrintStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetXPrintState();
            //Assert.IsType<PrinterStateDto>(response);
        }

        /// <summary>
        /// Test InkjetLayoutPreview
        /// </summary>
        [Fact]
        public void InkjetLayoutPreviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int inkjetLayoutId = null;
            //instance.InkjetLayoutPreview(inkjetLayoutId);
        }

        /// <summary>
        /// Test InsertImage
        /// </summary>
        [Fact]
        public void InsertImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityName = null;
            //int? x = null;
            //int? y = null;
            //int? pageId = null;
            //List<FileParameter> images = null;
            //instance.InsertImage(entityName, x, y, pageId, images);
        }

        /// <summary>
        /// Test IsMultiPrintRunning
        /// </summary>
        [Fact]
        public void IsMultiPrintRunningTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.IsMultiPrintRunning();
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test IsPrinting
        /// </summary>
        [Fact]
        public void IsPrintingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.IsPrinting();
        }

        /// <summary>
        /// Test IsReady
        /// </summary>
        [Fact]
        public void IsReadyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.IsReady();
        }

        /// <summary>
        /// Test JobInsertImage
        /// </summary>
        [Fact]
        public void JobInsertImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string imagePath = null;
            //int? angle = null;
            //int? x = null;
            //int? y = null;
            //instance.JobInsertImage(imagePath, angle, x, y);
        }

        /// <summary>
        /// Test LoadInkjetLayout
        /// </summary>
        [Fact]
        public void LoadInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int inkjetLayoutId = null;
            //instance.LoadInkjetLayout(inkjetLayoutId);
        }

        /// <summary>
        /// Test LoadTestImage
        /// </summary>
        [Fact]
        public void LoadTestImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? x = null;
            //int? y = null;
            //int? pageId = null;
            //instance.LoadTestImage(x, y, pageId);
        }

        /// <summary>
        /// Test MoveHeadToCapping
        /// </summary>
        [Fact]
        public void MoveHeadToCappingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.MoveHeadToCapping();
        }

        /// <summary>
        /// Test MoveHeadToMaintenance
        /// </summary>
        [Fact]
        public void MoveHeadToMaintenanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.MoveHeadToMaintenance();
        }

        /// <summary>
        /// Test MoveHeadToParking
        /// </summary>
        [Fact]
        public void MoveHeadToParkingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.MoveHeadToParking();
        }

        /// <summary>
        /// Test NewJob
        /// </summary>
        [Fact]
        public void NewJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string imagePath = null;
            //instance.NewJob(imagePath);
        }

        /// <summary>
        /// Test NozzleCheck
        /// </summary>
        [Fact]
        public void NozzleCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.NozzleCheck();
        }

        /// <summary>
        /// Test PerformDeepCleaning
        /// </summary>
        [Fact]
        public void PerformDeepCleaningTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? strongPurgeCount = null;
            //int? normalPurgeCount = null;
            //bool? includeLightCleaning = null;
            //instance.PerformDeepCleaning(strongPurgeCount, normalPurgeCount, includeLightCleaning);
        }

        /// <summary>
        /// Test PerformLightCleaning
        /// </summary>
        [Fact]
        public void PerformLightCleaningTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? wipeBefore = null;
            //instance.PerformLightCleaning(wipeBefore);
        }

        /// <summary>
        /// Test PerformNormalCleaning
        /// </summary>
        [Fact]
        public void PerformNormalCleaningTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? purgeCount = null;
            //bool? includeLightCleaning = null;
            //instance.PerformNormalCleaning(purgeCount, includeLightCleaning);
        }

        /// <summary>
        /// Test PerformPurge
        /// </summary>
        [Fact]
        public void PerformPurgeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? useStrong = null;
            //instance.PerformPurge(useStrong);
        }

        /// <summary>
        /// Test PerformSpitting
        /// </summary>
        [Fact]
        public void PerformSpittingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? firingSpeed = null;
            //int? numSpits = null;
            //instance.PerformSpitting(firingSpeed, numSpits);
        }

        /// <summary>
        /// Test PerformWiping
        /// </summary>
        [Fact]
        public void PerformWipingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.PerformWiping();
        }

        /// <summary>
        /// Test Print
        /// </summary>
        [Fact]
        public void PrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offsetX = null;
            //int? offsetY = null;
            //int? pageId = null;
            //int? printSettingsId = null;
            //int? passes = null;
            //PrintCycleModes? printCycle = null;
            //instance.Print(offsetX, offsetY, pageId, printSettingsId, passes, printCycle);
        }

        /// <summary>
        /// Test PrintInkjetLayout
        /// </summary>
        [Fact]
        public void PrintInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int inkjetLayoutId = null;
            //int? offsetX = null;
            //int? offsetY = null;
            //instance.PrintInkjetLayout(inkjetLayoutId, offsetX, offsetY);
        }

        /// <summary>
        /// Test PrintTestImage
        /// </summary>
        [Fact]
        public void PrintTestImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.PrintTestImage();
        }

        /// <summary>
        /// Test RenameInkjetLayout
        /// </summary>
        [Fact]
        public void RenameInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string name = null;
            //var response = instance.RenameInkjetLayout(id, name);
            //Assert.IsType<InkjetLayoutDto>(response);
        }

        /// <summary>
        /// Test ResetInkjetPrinter
        /// </summary>
        [Fact]
        public void ResetInkjetPrinterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ResetInkjetPrinter();
        }

        /// <summary>
        /// Test Resolution
        /// </summary>
        [Fact]
        public void ResolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.Resolution();
        }

        /// <summary>
        /// Test SetCleaningConfiguration
        /// </summary>
        [Fact]
        public void SetCleaningConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CleaningConfigurationDto cleaningConfigurationDto = null;
            //instance.SetCleaningConfiguration(cleaningConfigurationDto);
        }

        /// <summary>
        /// Test SetCuringSettings
        /// </summary>
        [Fact]
        public void SetCuringSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? curingEnabled = null;
            //bool? dualCuringEnabled = null;
            //bool? fumeExtractorEnabled = null;
            //int? level = null;
            //int? speed = null;
            //instance.SetCuringSettings(curingEnabled, dualCuringEnabled, fumeExtractorEnabled, level, speed);
        }

        /// <summary>
        /// Test SetHeaterTemperature
        /// </summary>
        [Fact]
        public void SetHeaterTemperatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? heaterTemperature = null;
            //instance.SetHeaterTemperature(heaterTemperature);
        }

        /// <summary>
        /// Test SetLampColor
        /// </summary>
        [Fact]
        public void SetLampColorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenericLampColors? color = null;
            //instance.SetLampColor(color);
        }

        /// <summary>
        /// Test SetPinningSettings
        /// </summary>
        [Fact]
        public void SetPinningSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? enabled = null;
            //int? level = null;
            //instance.SetPinningSettings(enabled, level);
        }

        /// <summary>
        /// Test SetPrintSettings
        /// </summary>
        [Fact]
        public void SetPrintSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobTemplateInkjetLayoutId = null;
            //int? id = null;
            //int? printSpeed = null;
            //bool? verticalMirrorEnabled = null;
            //bool? horizontalMirrorEnabled = null;
            //bool? cMYKDirectEnabled = null;
            //bool? enableC = null;
            //bool? enableM = null;
            //bool? enableY = null;
            //bool? enableK = null;
            //int? dropSize = null;
            //bool? multipass = null;
            //int? numberOfPasses = null;
            //int? dataPageId = null;
            //instance.SetPrintSettings(jobTemplateInkjetLayoutId, id, printSpeed, verticalMirrorEnabled, horizontalMirrorEnabled, cMYKDirectEnabled, enableC, enableM, enableY, enableK, dropSize, multipass, numberOfPasses, dataPageId);
        }

        /// <summary>
        /// Test StartMultiPrint
        /// </summary>
        [Fact]
        public void StartMultiPrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? xRepetitions = null;
            //int? xOffset = null;
            //int? yRepetitions = null;
            //int? yDelta = null;
            //float? areaWidth = null;
            //instance.StartMultiPrint(xRepetitions, xOffset, yRepetitions, yDelta, areaWidth);
        }

        /// <summary>
        /// Test StopMultiPrint
        /// </summary>
        [Fact]
        public void StopMultiPrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.StopMultiPrint();
        }

        /// <summary>
        /// Test StopPrint
        /// </summary>
        [Fact]
        public void StopPrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.StopPrint();
        }

        /// <summary>
        /// Test Test
        /// </summary>
        [Fact]
        public void TestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.Test();
        }

        /// <summary>
        /// Test ToggleCapping
        /// </summary>
        [Fact]
        public void ToggleCappingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? moveUp = null;
            //instance.ToggleCapping(moveUp);
        }

        /// <summary>
        /// Test ToggleCappingPump
        /// </summary>
        [Fact]
        public void ToggleCappingPumpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? stop = null;
            //instance.ToggleCappingPump(stop);
        }

        /// <summary>
        /// Test ToggleInkPriming
        /// </summary>
        [Fact]
        public void ToggleInkPrimingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? stop = null;
            //instance.ToggleInkPriming(stop);
        }

        /// <summary>
        /// Test ValidateInkjetLayoutName
        /// </summary>
        [Fact]
        public void ValidateInkjetLayoutNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //string body = null;
            //var response = instance.ValidateInkjetLayoutName(scannerId, body);
            //Assert.IsType<NameValidationResultDto>(response);
        }
    }
}
