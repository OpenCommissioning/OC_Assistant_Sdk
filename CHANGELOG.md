# Change Log

All notable changes to this project will be documented in this file. See [versionize](https://github.com/versionize/versionize) for commit guidelines.

<a name="2.1.0"></a>
## [2.1.0](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v2.1.0) (2025-11-21)

### Features

* add a base class for extensions ([d1b1cab](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/d1b1cabc21a603b46c3c24b103b86a5af862a7f6))
* upgrade to .NET 10. .NET Framework is no longer supported ([a0ad550](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/a0ad5503a6dc08c05dd822550f10030e1d82e568))

### Bug Fixes

* adjust the IAppControl interface to work with the new ExtensionBase class ([777c66b](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/777c66bafa812cb624a6d28a0d9ed5b7b1231413))
* implement new ClientType ([9d99e8a](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/9d99e8a54923749dcf33aa1a3dc91c6a1ba215ef))

<a name="2.0.2"></a>
## [2.0.2](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v2.0.2) (2025-11-17)

### Bug Fixes

* move TimeScaling to IClient interface for direct access on PluginBase ([337053b](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/337053b47fdcb194c64e1378c6b5903f5a9c3e28))
* replace CommunicationType enum with a generic System.Type ([d81b5a9](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/d81b5a99991ec089a7cb27d70e03d49df2a72492))
* rework of RecordData for less complex structure ([d5153aa](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/d5153aaf8491f56f6c9566e01a769f73e4f12bd9))
* rework of XmlFile ([ab2a8f8](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/ab2a8f823ddd905f945a28c94c178533fa78a282))

<a name="2.0.1"></a>
## [2.0.1](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v2.0.1) (2025-11-13)

### Bug Fixes

* new internal event for requesting a plugin client ([6b8f44f](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/6b8f44fb991ef5256e57acf450e4a6918e4f7bd6))
* remove deprecated RecordDataList ([f95ff26](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/f95ff266e386b9c55565b73f0de0ed9fd55c12da))

<a name="2.0.0"></a>
## [2.0.0](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v2.0.0) (2025-11-10)

### Features

* breaking changes for Assistant v2 ([5422814](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/5422814a76fcb3711056dbe43cecbce9708a39f7))
* new memory-based client for TcpIp communication ([5ed131b](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/5ed131b986fc4431de7f33b7adfb5d784f2b7c18))

### Breaking Changes

* breaking changes for Assistant v2 ([5422814](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/5422814a76fcb3711056dbe43cecbce9708a39f7))

<a name="1.7.2"></a>
## [1.7.2](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v1.7.2) (2025-08-13)

### Bug Fixes

* adapt API to match new Assistant implementation ([006983f](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/006983f7cf2a2b07b6deb856c8e4da0544a69553))

<a name="1.7.1"></a>
## [1.7.1](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v1.7.1) (2025-04-24)

### Bug Fixes

* update ADS Symbol for record data devicelist ([54e311f](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/54e311ff4ebf19757b571e54f0eca55ca1175dfd))

<a name="1.7.0"></a>
## [1.7.0](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v1.7.0) (2025-04-15)

### Features

* implement a dynamic plc port for the ADS client ([f102bd1](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/f102bd14d02695172aac8672a7112d569b38cbf5))

<a name="1.6.1"></a>
## [1.6.1](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v1.6.1) (2025-02-18)

### Bug Fixes

* nuget package multi targeting ([a72a528](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/a72a52899a8d79002c9c25ec484254b118b5d546))

<a name="1.6.0"></a>
## [1.6.0](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v1.6.0) (2025-01-28)

### Features

* add a Stopwatch extension class with a high-precision-waitable-timer. the old extension method WaitUntil is marked as deprecated ([3ae930d](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/3ae930dd5f0493b06a3030b15290dfbff8059c9b))

<a name="1.5.0"></a>
## [1.5.0](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v1.5.0) (2025-01-03)

### Features

* add an AmsNetId property to the local api. can be used to connect to the TwinCAT Usermode Runtime ([41246f9](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/41246f9c2f9f6703d240e4bb85ff4f65a84603b2))
* implement the new AmsNetId for all AdsClient connections ([cb83ae3](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/cb83ae32375b6a1102f89b70e27a01de09104e42))

<a name="1.4.3"></a>
## [1.4.3](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/releases/tag/v1.4.3) (2024-11-18)

### Bug Fixes

* repair summaries for the PluginBase class ([dff8341](https://www.github.com/OpenCommissioning/OC_Assistant_Sdk/commit/dff8341e0b82a7f87e76b1e025db0236d912b82a))

