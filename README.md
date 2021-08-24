# VisualStudioTemplates
Commonly used Visual Studio templates

## Item Templates

### [MediatrService](/ItemTemplates/MediatrService)

This template creates the three standard MediatR Request (Command), Response, and Handler class files.

Includes a basic ILogger<> from Microsoft.Extensions.Logging.

Just enter a name of the command and it will create a folder that matches the name and the three files.

Example if you enter in a name of "GetUser" it will create the following folder stucture:

```
 /GetUser/GetUserRequest.cs
 /GetUser/GetUserResponse.cs
 /GetUser/GetUserHandler.cs
```