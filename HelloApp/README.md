all right working

https://metanit.com/sharp/entityframeworkcore/2.12.php


* Comment
----------
мы не используем ILoggerFactory и тем более в DbContext-е, так что надо разбираться, читать документацию. Так что я бы убрал весь код, который использует DI из DbContext

если исправлять этот пример, то нужно в консольном приложении создать ServiceCollection . Добавить логирование с провайдером и потом как-то передать ServieProvider в новый dbContext

- а что плохого в DI?
= Как мне кажется, то сложно сразу с этого начинать. А так это основной паттерн почти в любом приложении

Нужно зарегистировать контекст в созданном ServiceCollection

https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.entityframeworkservicecollectionextensions.adddbcontext?view=efcore-5.0
----------
```
'ApplicationContext' generated a temporary value for the property 'Id.User'. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see key values.
Context 'ApplicationContext' started tracking 'User' entity. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see key values.
'ApplicationContext' generated a temporary value for the property 'Id.User'. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see key values.
Context 'ApplicationContext' started tracking 'User' entity. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see key values.
SaveChanges starting for 'ApplicationContext'.
DetectChanges starting for 'ApplicationContext'.
DetectChanges completed for 'ApplicationContext'.
Opening connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Opened connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Beginning transaction with isolation level 'Unspecified'.
Began transaction with isolation level 'ReadCommitted'.
Executing update commands individually as the number of batchable commands (2) is smaller than the minimum batch size (4).
Creating DbCommand for 'ExecuteReader'.
Created DbCommand for 'ExecuteReader' (0ms).
Executing DbCommand [Parameters=[@p0='?' (DbType = Int32), @p1='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
SET NOCOUNT ON;
INSERT INTO [Users] ([Age], [Name])
VALUES (@p0, @p1);
SELECT [Id]
FROM [Users]
WHERE @@ROWCOUNT = 1 AND [Id] = scope_identity();
Executed DbCommand (40ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
SET NOCOUNT ON;
INSERT INTO [Users] ([Age], [Name])
VALUES (@p0, @p1);
SELECT [Id]
FROM [Users]
WHERE @@ROWCOUNT = 1 AND [Id] = scope_identity();
The foreign key property 'User.Id' was detected as changed. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see property values.
A data reader was disposed.
Creating DbCommand for 'ExecuteReader'.
Created DbCommand for 'ExecuteReader' (0ms).
Executing DbCommand [Parameters=[@p0='?' (DbType = Int32), @p1='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
SET NOCOUNT ON;
INSERT INTO [Users] ([Age], [Name])
VALUES (@p0, @p1);
SELECT [Id]
FROM [Users]
WHERE @@ROWCOUNT = 1 AND [Id] = scope_identity();
Executed DbCommand (4ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
SET NOCOUNT ON;
INSERT INTO [Users] ([Age], [Name])
VALUES (@p0, @p1);
SELECT [Id]
FROM [Users]
WHERE @@ROWCOUNT = 1 AND [Id] = scope_identity();
The foreign key property 'User.Id' was detected as changed. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see property values.
A data reader was disposed.
Committing transaction.
Committed transaction.
Closing connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Closed connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Disposing transaction.
An entity of type 'User' tracked by 'ApplicationContext' changed state from 'Added' to 'Unchanged'. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see key values.
An entity of type 'User' tracked by 'ApplicationContext' changed state from 'Added' to 'Unchanged'. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see key values.
SaveChanges completed for 'ApplicationContext' with 2 entities written to the database.
Compiling query expression:
'DbSet<User>()'
Generated query execution expression:
'queryContext => new SingleQueryingEnumerable<User>(
    (RelationalQueryContext)queryContext,
    RelationalCommandCache.SelectExpression(
        Projection Mapping:
            EmptyProjectionMember -> Dictionary<IProperty, int> { [Property: User.Id (int) Required PK AfterSave:Throw ValueGenerated.OnAdd, 0], [Property: User.Age (int) Required, 1], [Property: User.Name (string), 2], }
        SELECT u.Id, u.Age, u.Name
        FROM Users AS u),
    Func<QueryContext, DbDataReader, ResultContext, SingleQueryResultCoordinator, User>,
    HelloApp.ApplicationContext,
    False,
    False
)'
Creating DbCommand for 'ExecuteReader'.
Created DbCommand for 'ExecuteReader' (0ms).
Opening connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Opened connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT [u].[Id], [u].[Age], [u].[Name]
FROM [Users] AS [u]
Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT [u].[Id], [u].[Age], [u].[Name]
FROM [Users] AS [u]
A data reader was disposed.
Closing connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Closed connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
Данные после добавления:
1.Tom - 33
2.Alice - 26
'ApplicationContext' disposed.


C:\Users\halim\source\repos\EF1\HelloApp\HelloApp\bin\Debug\netcoreapp3.1\HelloApp.exe (процесс 9324) завершил работу с кодом 0.
Чтобы автоматически закрывать консоль при остановке отладки, включите параметр "Сервис" ->"Параметры" ->"Отладка" -> "Автоматически закрыть консоль при остановке отладки".
Нажмите любую клавишу, чтобы закрыть это окно…



```
