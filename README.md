# C# Sauce Labs Demo Scripts and Frameworks
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/728698e058a04148a6a0da043ef7be1e)](https://app.codacy.com/gh/saucelabs-training/demo-csharp?utm_source=github.com&utm_medium=referral&utm_content=saucelabs-training/demo-csharp&utm_campaign=Badge_Grade_Dashboard)

This directory contains example scripts and dependencies for running automated Selenium tests on Sauce Labs using C#.

## 🖥 Web automation

* **🥇Best practice frameworks for web testing**
  * [Production-level framework doing web automation on desktop and mobile. Using best practices, parallel, cross-browser, NUnit, Selenium, Appium, Visual](./DotnetCore/Sauce.Demo/Core.BestPractices.Web)
  * [👁‍🗨Visual e2e framework](./DotnetCore/Sauce.Demo/Core.BestPractices.Web/Tests/Desktop/VisualTests.cs) `.net` `best practice`
  * [📱Real devices framework](./DotnetCore/Sauce.Demo/Core.BestPractices.Web/Tests/Mobile) `.net` `best practice`
  
* **Code Examples**
  * [Simple W3C Selenium test](./DotnetCore/Sauce.Demo/Core.Selenium.Examples/SimpleSauceTests.cs) `.net` `mstest`
  * [Accessibility Test](./DotnetCore/Sauce.Demo/Core.Selenium.Examples/AxeAccesibility.cs) `.net` `mstest`
  * [Quick start with Selenium](./SauceExamples/SeleniumNunit/SimpleExamples/SimpleSauceTest.cs) `.net framework`
  * [Parallel, cross-browser, NUnit, Selenium](./SauceExamples/Web.Tests/BestPractices/test) `.net framework`
  * [Selenium W3C examples](./SauceExamples/Selenium4DotNetFramework/Selenium4SauceTests.cs) `.net framework`
  * [CICD with Azure DevOps](https://ultimateqa.com/tfs-vsts-and-azure-devops/#Sauce_Labs_with_Azure_DevOps) `.net framework`
  * [Examples,Selenium,MsTest](./SauceExamples/SeleniumMsTest) `.net framework`
  * [Sauce Labs REST API](./SauceExamples/SeleniumNunit/SimpleExamples/RestApiForVdc.cs) `.net framework`
  * [Set pass/fail status,Selenium,NUnit](https://github.com/saucelabs-training/demo-csharp/blob/5d7e8731e4120ae381d8ff14bcf58d672b3bc2fc/SauceExamples/Web.Tests/BestPractices/test/BaseTest.cs#L60) `.net framework`
  * [Set pass/fail status,Selenium,MsTest](https://github.com/saucelabs-training/demo-csharp/blob/5d7e8731e4120ae381d8ff14bcf58d672b3bc2fc/SauceExamples/SeleniumMsTest/ParallelTests/DataDriven/DataDrivenCrossBrowserParallelMethods.cs#L84) `.net framework`
  * [Visual E2E](./SauceExamples/SeleniumNunit/Visual) `.net framework`
  * [Front-end perf testing examples](./SauceExamples/SeleniumNunit/SaucePerformance/PerformanceDemo.cs) `.net framework`
  * [Performance testing and nework throttling](./SauceExamples/SeleniumNunit/SaucePerformance/CustomCapabilitiesTests.cs) `.net framework`


## 📱Mobile automation

* **🥇Best practice frameworks for mobile testing**
  * [Mobile automation framework](./SauceExamples/Core.Appium.MsTest.BestPractices)`.net` `best practice` `nunit`

* **Examples**
  * Emusim
    * Web
      * [Web test on emusim w/ Android](./SauceExamples/Core.Appium.MsTest.Scripts/Emusim/Browser/AndroidWebTests.cs)
    * Native app
      * [Native app tests](./SauceExamples/DotnetFramework/Appium/Appium4.NUnit.Scripts/RealDevices/NativeApp/UP)
      * Legacy RDC **❗️Deprecated! Use Unified Platform**
        * [Native app tests on legacy RDC](./SauceExamples/Core.Appium.MsTest.Scripts/RealDevices/NativeApp/LegacyRdc)
    
  * Real Devices
    * [Native App, IOS](./SauceExamples/DotnetFramework/Appium/Appium4.NUnit.Scripts/RealDevices/NativeApp/UP/GetStartedIos.cs)
    * [Native App, Android](./SauceExamples/DotnetFramework/Appium/Appium4.NUnit.Scripts/RealDevices/NativeApp/UP/AndroidAdvanced.cs)
    * [Specflow,MsTest in Parallel](./SauceExamples/DotnetCore/Core.Selenium4.MsTest.Scripts/SpecFlow)
    * [Download test assets from real devices](./SauceExamples/Core.Appium.MsTest.Scripts/RealDevices/NativeApp/DownloadAssets.cs)
    * Legacy RDC **❗️Deprecated! Use Unified Platform**
      * [Legacy RDC REST API status updates](./SauceExamples/Core.Appium.MsTest.Scripts/RealDevices/NativeApp/LegacyRdc/iOSExamples.cs)

### [📕 Mobile Testing Training Tutorials](https://github.com/saucelabs-training/demo-java/blob/master/TRAINING.md)


## 🚀 CICD

### Azure DevOps

> **Azure DevOps Sauce Labs Plugin does NOT work!** You cannot view Sauce Labs videos inside of Azure DevOps. You need to go to saucelabs.com to view the test assets. You can add richer logging to your tests and add test asset links directly into the logs (but this is extra work).

[How to configure Azure DevOps with Sauce Labs](https://ultimateqa.com/tfs-vsts-and-azure-devops/#C_with_Sauce_Labs_and_Azure_DevOps)

Example task to run tests in Sauce
```yml
- task: DotNetCoreCLI@2
  displayName: 'Run tests'
  inputs:
    command: test
    projects: '**DotnetCore/Sauce.Demo/*.csproj'
    arguments: '--configuration $(buildConfiguration) --filter TestCategory=desktop'
  env:
    SAUCE_USERNAME: $(sauceUsername)
    SAUCE_ACCESS_KEY: $(sauceKey)
```

## Parallelization capabilities of unit testing libraries

How do different libraries parallelize tests?

|MsTest|NUnit|xUnit|SpecFlow|
|:-------------:|:-------------:|:-------------:|:-------------:|
|Test method|Test class|Test class|Test class|


