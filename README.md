# WebApi CRUD

###Task: Implement Web API for entering project data into the database (task tracker)
 #### Functional requirements: <br>
•Ability to create / view / edit / delete information about projects <br>
•Ability to create / view / edit / delete task information <br>
•Ability to add and remove tasks from a project (one project can contain several tasks) <br>
•Ability to view all tasks in the project <br>

<br><br>
Prerequisites:<br>
•Visual Studio<br>
•SQL Server<br>

<br><br>
Setting Up This Demo:<br><br>
1.Download the SQL Server backup file Скрипты SQL Server2.zip and restore the database using the backup file. <br><br>
2.Download and open this demo in VisualStudio. Make sure you’re connected to the Internet so that it is possible to download packages required by the project. <br><br>
3.Install: •Microsoft.EntityFrameworkCore •Microsoft.EntityFrameworkCoreSqlServer •Microsoft.EntityFrameworkCoreTools •Swashbuckle.AspNetCore <br><br>
4.In the Solution Explorer, open the file appsettings.json, and modify the Data Source, Initial Catalog, User ID, and Password in the connection string based on your environment. Note that the value of the Initial Catalog must be the same as the name of database (DbProject by default) you restored in the SQL Server.
![image](https://user-images.githubusercontent.com/56864414/153051800-7210f1ce-6d1f-4b70-9c1e-550bc06c4cae.png) <br><br>
The code above also specifies the connection name as “DbProject”. The connection name must be the same as the one in the ConfigureServices method of Startup.cs:
![image](https://user-images.githubusercontent.com/56864414/153051925-94874920-ea93-431f-9d5f-c38e483cb3b0.png)
