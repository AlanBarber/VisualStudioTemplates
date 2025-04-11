# VisualStudioTemplates

Here you will find some commonly used Visual Studio templates that I find myself creating over and over. 

## Install Instructions

Copy the template's folder and content into the following folder depending on VS version

```
%USERPROFILE%\Documents\Visual Studio 2019\Templates\ItemTemplates
%USERPROFILE%\Documents\Visual Studio 2022\Templates\ItemTemplates
```

See also: [How to: Locate and organize project and item templates](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-locate-and-organize-project-and-item-templates?view=vs-2019)

## Templates

### Item Templates

#### [BasicRepository](/ItemTemplates/BasicRepository)

Creates a standard Repository class and interface for a given model class.

Includes basic CRUD operations:

```
Task<ICollection<$modelname$>> GetAll();
Task<$modelname$> GetById(int id);
Task<$modelname$> Create($modelname$ item);
void Update($modelname$ item);
void Delete($modelname$ item);
```

#### [MediatrRequest](/ItemTemplates/MediatrRequest)

This template creates the three standard MediatR Request (Command), Response, and Handler class files.

Includes a basic ILogger<T> from Microsoft.Extensions.Logging.

Just enter a name of the command and it will create a folder that matches the name and the three files.

Example if you enter in a name of "GetUser" it will create the following folder stucture:

```
/GetUser/GetUserRequest.cs
/GetUser/GetUserResponse.cs
/GetUser/GetUserHandler.cs
```

#### [ReactClassComponent](/ItemTemplates/ReactClassComponent)

This template creates a basic [ReactJS class component](https://react.dev/reference/react/Component).

```
import React, { Component } from 'react';

export default class $componentname$ extends Component {
	constructor(props) {
        super(props);
        this.state = {
			loading: false
		};
    }
	
	async componentDidMount() {
	}

	render() {
		return (
			<div>
				<p>$componentname$</p>
			</div>
		);
	}	
}
```

#### [ReactFunctionalComponent](/ItemTemplates/ReactFunctionalComponent)

This template creates a basic [ReactJS functional component](https://react.dev/learn/your-first-component).

```
import React, { useState, useEffect } from 'react';

const $componentname$ = (props) => {
    const [loading, setLoading] = useState(false);

    useEffect(() => {

    }, []);

    // Data

    // Render

    return (
        <React.Fragment>$componentname$</React.Fragment>
    );
};
export default $componentname$;
```