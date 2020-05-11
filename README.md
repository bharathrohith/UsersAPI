# UsersAPI

To get started
- Install and Open PostgreSQL through pg4Admin
  - Create a userLogin with username : dev and password : dev.
- Migrate your Models to the DB.
  - Open VS Code or VS Community/Professional
  - Open Nuget Package Manager Console and type these commands
    - PM> enable-migrations
    - PM> add-migration initial
    - PM> update-database
  - Run the app (Ctrl + F5)
- After the DB and table have been created, Run the Db script in the pg4Admin Querytool.
- Open Postman and start using the api   
