# VisualStudioTemplates
Commonly used Visual Studio templates

## Install Instructions



Copy the template's folder and content into the following folder

```
%USERPROFILE%\Documents\Visual Studio 2019\Templates\ItemTemplates
```

See also: [How to: Locate and organize project and item templates](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-locate-and-organize-project-and-item-templates?view=vs-2019)

## Templates

### Item Templates

#### [MediatrService](/ItemTemplates/MediatrService)

This template creates the three standard MediatR Request (Command), Response, and Handler class files.

Includes a basic ILogger<> from Microsoft.Extensions.Logging.

Just enter a name of the command and it will create a folder that matches the name and the three files.

Example if you enter in a name of "GetUser" it will create the following folder stucture:

```
/GetUser/GetUserRequest.cs
/GetUser/GetUserResponse.cs
/GetUser/GetUserHandler.cs
```
