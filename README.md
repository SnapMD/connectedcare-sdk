# connectedcare-sdk

An open-source .NET client wrapper for the SnapMD Connected Care REST API.

General documentation for the REST API can be found at [https://sandbox.connectedcare.md/api/Help/](https://sandbox.connectedcare.md/api/Help/). Additional API documentation is available in [our GitHub wiki](https://github.com/SnapMD/connectedcare-sdk/wiki).

## Dependencies

This project uses [Json.NET](https://github.com/JamesNK/Newtonsoft.Json) for serialization.

## Configuration

Unit tests require a separate config file stored next to the App.config, called `SnapMD.VirtualCare.Sdk.Test.Properties.Settings.csproj`. This file is not in the `.gitignore` file because if it's not in the repository it can result in compilation errors for brand-new installations. The file should look like this:

    <?xml version="1.0"?>
    <SnapMD.VirtualCare.Sdk.Tests.Properties.Settings>
        <setting name="ApiDeveloperId" serializeAs="String">
            <value>******</value>
        </setting>
        <setting name="ApiKey" serializeAs="String">
            <value>*********</value>
        </setting>
        <setting name="TestUsername" serializeAs="String">
            <value>*********</value>
        </setting>
        <setting name="TestPassword" serializeAs="String">
            <value>*********</value>
        </setting>
        <setting name="BaseUrl" serializeAs="String">
            <value>https://sandbox.connectedcare.md/api/</value>
        </setting>
    </SnapMD.VirtualCare.Sdk.Tests.Properties.Settings>

It is crucial that we prevent users' credentials from being stored in the Git repository, so if your settings are discovered in your pull request, it will be rejected. In order to make local changes to this file, use the following Git command:

    git update-index --assume-unchanged SnapMD.VirtualCare.Sdk.Tests/SnapMD.VirtualCare.Sdk.Tests.Properties.Settings.config

## Contributing

We welcome pull requests. However, please make sure you do not store any passwords or API keys in the Git history. When you change the values in app.config, make sure you back up that file and revert your confidential values before committing. This also means if you visit the project's Property pages in Visual Studio, when it asks you if you want to use the new values in the app.config to update your Settings file, remember to click "No". Otherwise, your confidential information will be stored in `Properties/Settings.settings` and `Properties/Settings.Designer.cs`.

## Documentation

Documentation is contained in the GitHub Wiki, but we also have [online MSDN-style class reference documentation](https://snapmd.github.io/connectedcare-sdk/Help). To contribute to the online class reference, you'll need to download the Sandcastle Help File Builder from https://github.com/EWSoftware/SHFB/releases. From the SnapMD connectedcare-sdk GitHub repository, checkout the `develop` branch. Open the solution, make changes as required, and commit them. Then build the "DocumentationBuilder" project. It will output to `DocumentationBuilder\Help`. Copy this folder to the root Help folder, switch to the `gh-pages` branch and submit the changes you've made (the folder is not ignored on this branch). Once pushed the github.io pages will automatically update.