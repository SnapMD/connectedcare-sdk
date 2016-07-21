# connectedcare-sdk

An open-source .NET client wrapper for the SnapMD Connected Care REST API.

General documentation for the REST API can be found at [https://sandbox.connectedcare.md/api/Help/](https://sandbox.connectedcare.md/api/Help/). Additional API documentation is available in [our GitHub wiki](https://github.com/SnapMD/connectedcare-sdk/wiki).

## Class Library Documentation

In addition to the documentation contained in the GitHub Wiki, we have [online 
MSDN-style class reference documentation](https://snapmd.github.io/connectedcare-sdk/Help). To contribute to the online class reference, you'll 
need to download the Sandcastle Help File Builder from https://github.com/EWSoftware/SHFB/releases. From the SnapMD connectedcare-sdk GitHub repository, 
checkout the `develop` branch. Open the solution, make changes as required, 
and commit them. Then build the "DocumentationBuilder" project. It will output 
to `DocumentationBuilder\Help`. Switch branches to `gh-pages`, and copy `DocumentationBuilder\Help` on top of the root Help folder, and commit the changes you've made (the folder is not ignored on this branch). Once pushed the github.io pages will automatically update.