# .Net Core and Vue Application

This repository includes a simple backend api built in .Net Core and a simple frontend built in Vue 3.x. The backend RESTful api has endpoints to GET, POST, and DELETE favorite foods. The frontend application will display all foods in the database, and allow the user to create and delete indivdual foods. You can also add an 'isTasty' attribute, that will change the color of the card displaying the individual food.

Technologies used:

Vue, .Net Core, Axios, Bulma

## To Run

You will need the following softwares installed:

[Node & NPM CLI](https://nodejs.org/en/)

[.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)

### Backend Application

In the terminal (root of the repository), run the following:

```
$ cd api
$ dotnet build
$ dotnet run
```

### Frontend Application

In the terminal (root of the repository), run the following:

```
$ cd frontend
$ npm install
$ npm start
```

Note: The frontend of this application was bootstrapped using the Vue CLI.
