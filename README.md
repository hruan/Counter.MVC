# Introduction

In this lab we'll explore different approaches to automation in Azure through
deploying an application consisting of a MVC frontend and an Web API backend to
an environment running on Azure.

There are a few ways of approaching automation:

  - Sending commands via a CLI client, e.g. using [Powershell][5] or [the
      cross-platform version][6] equivalent running on Node.js
  - Describe your environment using [Azure resource manager templates][7] (ARM
      templates) and provisioning it using the CLI client
  - Using a language of choice supported by an Azure SDK, e.g. Java and
      [C#][8], and programmatically provision the environment.
  - Or a combination using the above.

Hopefully, we have enough attendants to cover all approaches above!

# Pre-requisites

  - Install the latest versions of the following:
      - [Azure SDK][9]
      - [Azure Powershell][10]
      - (Optional) Visual Studio 2015 offers (in)complete tooling for writing
	  ARM templates that may be of help
  - Once installed, setup Powershell by running in a Azure Powershell window:
      - `Add-AzureAccount` and login if necessary
      - `Select-AzureSubscription ".NET Backend Lab"`
      - `Switch-AzureMode AzureResourceManager`
      - Verify `Get-AzureResourceGroup Default-Web-NorthEurope` returns a list
	  of resources
  - Clone the application repositories from
      https://github.com/hruan/Counter.MVC and
      https://github.com/hruan/Counter.API

# Tips and useful links

## The application

  - Application configuration is fetched from environment variables.
      `LocalConfiguration.cs` in either project lists its respective required
      variables.
  - Application state is stored in Azure Table Storage.

## CLI

  - Powershell cmdlets follows the patter `<VERB>-Azure<NOUN>` where `<VERB>`
      is frequently `New`, `Get`, or `Remove` and used for creating,
      retrieving, and deleting Azure resources respectively, e.g. `New-AzureVM`
      will create a new VM. The `NOUN` is the name of the service, e.g.
      `Get-AzureWebApp` will return an object representing an Azure Web App.
  - `Get-Help <cmdlet>` shows documentation for a given cmdlet. Note that
      documentation is sparse at the time of writing (2015-08-16).
  - `Get-Help <cmdlet> -Examples` will display example usages if available
  - A full list of commands is available through `Get-Help *-azure*`
  - Auto-completion is available for cmdlets as well as parameters by hitting
      the `Tab`-key
  - Note that `Switch-AzureMode` will soon be [deprecated][3] and resource
      manager cmdlets will receive a `RM` prefix, e.g. `New-AzureVM` will
      become `New-AzureRMVM`.

## ARM templates

  - Read up about [the template "language"][7] and [how to deploy the
      templates][11]
  - There are sample templates [here][12] or [directly via GitHub][1]
  - Documentation for resource properties are severely lacking at the time of
      writing. The [template schemas][2] may be used as a source of
      documentation, especially the ["root" schemas][13].

## MAML

  - MAML is [available on NuGet][4]. The preview versions may be offers a more
      up-to-date API.
  - IntelliSense is your friend :)

[1]: https://github.com/Azure/azure-quickstart-templates
[2]: https://github.com/Azure/azure-resource-manager-schemas
[3]: https://github.com/Azure/azure-powershell/wiki/Deprecation-of-Switch-AzureMode-in-Azure-PowerShell
[4]: https://www.nuget.org/packages/Microsoft.WindowsAzure.Management.Libraries
[5]: https://github.com/Azure/azure-powershell
[6]: https://github.com/Azure/azure-xplat-cli
[7]: https://azure.microsoft.com/en-us/documentation/articles/resource-group-authoring-templates/
[8]: http://www.jeff.wilcox.name/2014/04/wamlmaml/
[9]: http://azure.microsoft.com/blog/2015/07/20/announcing-the-azure-sdk-2-7-for-net/
[10]: https://github.com/Azure/azure-powershell/releases
[11]: https://azure.microsoft.com/en-us/documentation/articles/resource-group-template-deploy/
[12]: http://azure.microsoft.com/en-us/documentation/templates/
[13]: https://github.com/Azure/azure-resource-manager-schemas/tree/master/schemas/2015-01-01
