# Linn IT dev trial

We write apps and services for various areas of the business and present them all to our users under one umbrella 'Linn Apps' experience. Anywhere on Linn Apps you can see a menu that looks something like <a href="https://linn.github.io/react-components-library/?path=/story/components-navigation--default">this</a>.

The data behind the menu is served up as a json from http://app.linn.co.uk/intranet/menu-no-auth, which our react clients GET request in order to render the menu.

Your task is to write a simple .Net middle-man service that can perform some operations on the menu before passing it along to the client.

Your service will have to make an http GET request to the above url to fetch the menu.json, deserialize that data into a suitable C# structure informed by the shape of the json object, and then perform operations on the menu before passing it along to the client. 

You can use chrome, POSTMAN or a similiar http client to interact with your endpoint(s).
Feel free to use any nuget packages you like to help you out, e.g. to make the http request for the menu data, to deserialize the response json etc..

### Base Goal
You should implement a simple REST API with the following endpoint:  <code>/api/search</code>

The endpoint should service a GET request with one <code>string searchTerm</code> query parameter. It should return a 200 response with a json array of all MenuItems that contain the <strong>word(s)</strong> in the searchTerm in their Title field if any exist, or a 404 response if not. 

The search should only run on words, e.g. a search for 'Works' will return the Menu Item titled 'Works Orders Utility', but a search for just 'Wo' won't.

The search should be case insensitive.

There's no pressure to finish the task in the short time we have, but if you do you...

### Further Goals
Implement an additional endpoint: <code>api/section</code>

It should take one string parameter <code>sectionName</code>. 

It should return a 200 response with only Menu Items in the relevant section of the menu as specified by the sectionName parameter. e.g. if you look at the data the first section is called 'Production'. A 404 response should be returned if an invalid section name is entered. Again the search should be case insensitive.

### Template Structure
We've provided a simple .net project here to get you started. 

The Domain contains a <code>Menu</code> and a <code>MenuItem</code> class that will represent the menu in C#. The menu should consist of MenuItems, but how you structure the data it is up to you. There's an <code>IDomainService</code> that you should implement to filter the menu data appropriately.

There's a skeleton <code>IMenuService</code> in the Proxy project which we expect you will implement to make an http request for the initial menu.json and convert it into your C# domain objects.

The Service currenly has the one search endpoint for you to implement.

The Test project provides some testing boilerplate to get you started writing tests

### To run the Service
cd into the Service folder and do 

<code>dotnet run</code>

The web server will be listening on locahost:50001 by default.

### To run the tests
cd into the Tests directory and do 

<code> dotnet test </code>

### Debugging
We have provided a vscode launch config which should allow you to use the <a href="https://code.visualstudio.com/docs/editor/debugging">Visual Studio Code debugger</a>. You might need to install some extensions - we can help you get your environment set up if you get stuck.
