# Linn IT dev trial

We write apps and services for various areas of the business and present them all to our users under one umbrella 'Linn Apps' experience. Anywhere on Linn Apps you can see a menu that looks something like <a href="https://linn.github.io/react-components-library/?path=/story/components-navigation--default">this</a>.

The data behind the menu is served up as a json from http://app.linn.co.uk/intranet/menu-no-auth, which our react clients GET request in order to render the menu.

Your task is to write a simple .Net service that requests the menu and then performs some operations on the menu before passing it along to the client.

Your service will have to make a http GET request to the above url to fetch the menu.json, deserialize that string into a suitable C# structure informed by the shape of the json object, and then perform filter operations on the menu before passing it along to the client. 

You can use chrome, POSTMAN or a similiar http client to interact with your endpoint(s).
Feel free to use any nuget packages you like to help you out, e.g. to make the http request for the menu data, to deserialize the response json etc..

### First Goal
You should model the menu data in C# and implement a <code>DomainService</code> method that takes an object of your <code>Menu</code> class and a <code>string searchTerm</code> and returns a list of all <code>MenuItem</code>'s that have title words equal to the searchTerm, i.e. the search should only run on words, so a search for 'Works' will return the Menu Item titled 'Works Orders Utility', but a search for just 'Wo' won't since 'Wo' isn't a word in the title. The search should be case insensitive.

### Second Goal
You should Implement the <code>GetMenu()</code> method in the <code>IMenuService</code> interface in the Proxy project. This method should make a http request to the <code>/menu-no-auth</code> endpoint specified above and deserialize the response json into your C# <code>Menu</code> data structure. It should return a <code>Menu</code> object to pass to your Domain search method.

### Third Goal
You should then implement a simple REST endpoint:  <code>/menu/search</code> in the Service project. The endpoint will call upon your work in the Domain and Proxy project to filter the menu data.

The request should have one searchTerm <code>string</code> parameter to pass to your domain Search method.

It should return a 200 response with a json array of all MenuItems that your Domain Search Methods returned, or a 404 result if your Domain method didn't return any matches.

### Template Structure
We've provided a simple .net project here to get you started. 

The Domain contains a <code>Menu</code> and a <code>MenuItem</code> class that will represent the menu in C#. The menu should consist of MenuItems, but how you structure the data it is up to you. There's an <code>IDomainService</code> interface that you should implement to filter the menu data appropriately.

There's an <code>IMenuService</code> interface in the Proxy project which we expect you will implement to make a http request for the initial menu.json and convert it into your C# domain objects.

The Service has a single <code>/menu/search</code> endpoint for you to build out.

The Test project provides some testing boilerplate to get you started writing tests for your </code>DomainService</code>.

### To run the Service
cd into the Service folder and do 

<code>dotnet run</code>

The web server will be listening on locahost:5001 by default.

### To run the tests
cd into the Tests directory and do 

<code> dotnet test </code>

### Debugging
We have provided a vscode launch config which should allow you to use the <a href="https://code.visualstudio.com/docs/editor/debugging">Visual Studio Code debugger</a>. You might need to install some extensions - we can help you get your environment set up if you get stuck.



### Trouble building?
The servcie is a .Net Core 2.2 web app, so you'll need to have <a href="https://dotnet.microsoft.com/download/dotnet/2.2">that sdk</a> installed.

Check what version, if any, you are on by doing:

<code>dotnet --version</code>

If that's doesn't say 2.2.x, do

<code>dotnet --list-sdks</code>

To check you have a 2.2.x sdk locally. If you do, do

<code>dotnet new globaljson</code>

and update the file to specify that the app uses your 2.2.x version.

check <code>dotnet --version</code> again and if all is well you should be able to <code>dotnet build</code> etc.

