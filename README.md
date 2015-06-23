# connectedcare-sdk

An open-source .NET client wrapper for the SnapMD Connected Care REST API.

General documentation for the REST API can be found at [https://sandbox.connectedcare.md/api/Help/](https://sandbox.connectedcare.md/api/Help/).

## Dependencies

This project uses [Json.NET](https://github.com/JamesNK/Newtonsoft.Json) for serialization.

## Contributing

We welcome pull requests. However, please make sure you do not store any passwords or API keys in the Git history. When you change the values in app.config, make sure you back up that file and revert your confidential values before committing. This also means if you visit the project's Property pages in Visual Studio, when it asks you if you want to use the new values in the app.config to update your Settings file, remember to click "No". Otherwise, your confidential information will be stored in `Properties/Settings.settings` and `Properties/Settings.Designer.cs`.