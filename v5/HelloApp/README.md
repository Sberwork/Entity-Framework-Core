info: 17.11.2020 17:43:05.925 CoreEventId.ContextInitialized[10403] (Microsoft.EntityFrameworkCore.Infrastructure)
      Entity Framework Core 5.0.0 initialized 'ApplicationContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
dbug: 17.11.2020 17:43:06.012 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opening connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:06.467 RelationalEventId.ConnectionOpened[20001] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opened connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:06.478 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command)
      Creating DbCommand for 'ExecuteNonQuery'.
dbug: 17.11.2020 17:43:06.485 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command)
      Created DbCommand for 'ExecuteNonQuery' (7ms).
dbug: 17.11.2020 17:43:06.493 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
info: 17.11.2020 17:43:06.520 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (30ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
dbug: 17.11.2020 17:43:06.524 RelationalEventId.ConnectionClosing[20002] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closing connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:06.531 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closed connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:06.643 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opening connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:06.648 RelationalEventId.ConnectionOpened[20001] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opened connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:06.649 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command)
      Creating DbCommand for 'ExecuteNonQuery'.
dbug: 17.11.2020 17:43:06.649 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command)
      Created DbCommand for 'ExecuteNonQuery' (0ms).
dbug: 17.11.2020 17:43:06.649 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
      IF SERVERPROPERTY('EngineEdition') <> 5
      BEGIN
          ALTER DATABASE [helloappdb] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
      END;
info: 17.11.2020 17:43:09.655 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (3,006ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      IF SERVERPROPERTY('EngineEdition') <> 5
      BEGIN
          ALTER DATABASE [helloappdb] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
      END;
dbug: 17.11.2020 17:43:09.656 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command)
      Creating DbCommand for 'ExecuteNonQuery'.
dbug: 17.11.2020 17:43:09.656 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command)
      Created DbCommand for 'ExecuteNonQuery' (0ms).
dbug: 17.11.2020 17:43:09.658 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
      DROP DATABASE [helloappdb];
info: 17.11.2020 17:43:09.692 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (34ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      DROP DATABASE [helloappdb];
dbug: 17.11.2020 17:43:09.693 RelationalEventId.ConnectionClosing[20002] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closing connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:09.695 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closed connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:09.698 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opening connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:09.706 RelationalEventId.ConnectionError[20004] (Microsoft.EntityFrameworkCore.Database.Connection)
      An error occurred using the connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:09.710 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opening connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:09.711 RelationalEventId.ConnectionOpened[20001] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opened connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:09.711 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command)
      Creating DbCommand for 'ExecuteNonQuery'.
dbug: 17.11.2020 17:43:09.711 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command)
      Created DbCommand for 'ExecuteNonQuery' (0ms).
dbug: 17.11.2020 17:43:09.712 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
      CREATE DATABASE [helloappdb];
info: 17.11.2020 17:43:10.169 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (457ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      CREATE DATABASE [helloappdb];
dbug: 17.11.2020 17:43:10.169 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command)
      Creating DbCommand for 'ExecuteNonQuery'.
dbug: 17.11.2020 17:43:10.171 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command)
      Created DbCommand for 'ExecuteNonQuery' (1ms).
dbug: 17.11.2020 17:43:10.174 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
      IF SERVERPROPERTY('EngineEdition') <> 5
      BEGIN
          ALTER DATABASE [helloappdb] SET READ_COMMITTED_SNAPSHOT ON;
      END;
info: 17.11.2020 17:43:10.229 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (55ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      IF SERVERPROPERTY('EngineEdition') <> 5
      BEGIN
          ALTER DATABASE [helloappdb] SET READ_COMMITTED_SNAPSHOT ON;
      END;
dbug: 17.11.2020 17:43:10.231 RelationalEventId.ConnectionClosing[20002] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closing connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.233 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closed connection to database 'master' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.234 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opening connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.238 RelationalEventId.ConnectionOpened[20001] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opened connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.238 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command)
      Creating DbCommand for 'ExecuteNonQuery'.
dbug: 17.11.2020 17:43:10.238 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command)
      Created DbCommand for 'ExecuteNonQuery' (0ms).
dbug: 17.11.2020 17:43:10.241 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
info: 17.11.2020 17:43:10.242 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
dbug: 17.11.2020 17:43:10.244 RelationalEventId.ConnectionClosing[20002] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closing connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.244 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closed connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.321 CoreEventId.DetectChangesStarting[10800] (Microsoft.EntityFrameworkCore.ChangeTracking)
      DetectChanges starting for 'ApplicationContext'.
dbug: 17.11.2020 17:43:10.325 CoreEventId.DetectChangesCompleted[10801] (Microsoft.EntityFrameworkCore.ChangeTracking)
      DetectChanges completed for 'ApplicationContext'.
dbug: 17.11.2020 17:43:10.335 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opening connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.335 RelationalEventId.ConnectionOpened[20001] (Microsoft.EntityFrameworkCore.Database.Connection)
      Opened connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.338 RelationalEventId.TransactionStarting[20209] (Microsoft.EntityFrameworkCore.Database.Transaction)
      Beginning transaction with isolation level 'Unspecified'.
dbug: 17.11.2020 17:43:10.351 RelationalEventId.TransactionStarted[20200] (Microsoft.EntityFrameworkCore.Database.Transaction)
      Began transaction with isolation level 'ReadCommitted'.
dbug: 17.11.2020 17:43:10.352 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command)
      Creating DbCommand for 'ExecuteNonQuery'.
dbug: 17.11.2020 17:43:10.354 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command)
      Created DbCommand for 'ExecuteNonQuery' (1ms).
dbug: 17.11.2020 17:43:10.355 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Users] (
          [Id] int NOT NULL IDENTITY,
          [Name] nvarchar(max) NULL,
          [Age] int NOT NULL,
          CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
      );
info: 17.11.2020 17:43:10.363 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (8ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Users] (
          [Id] int NOT NULL IDENTITY,
          [Name] nvarchar(max) NULL,
          [Age] int NOT NULL,
          CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
      );
dbug: 17.11.2020 17:43:10.368 RelationalEventId.TransactionCommitting[20210] (Microsoft.EntityFrameworkCore.Database.Transaction)
      Committing transaction.
dbug: 17.11.2020 17:43:10.371 RelationalEventId.TransactionCommitted[20202] (Microsoft.EntityFrameworkCore.Database.Transaction)
      Committed transaction.
dbug: 17.11.2020 17:43:10.372 RelationalEventId.TransactionDisposed[20204] (Microsoft.EntityFrameworkCore.Database.Transaction)
      Disposing transaction.
dbug: 17.11.2020 17:43:10.374 RelationalEventId.ConnectionClosing[20002] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closing connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.
dbug: 17.11.2020 17:43:10.374 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)
      Closed connection to database 'helloappdb' on server '(localdb)\mssqllocaldb'.


//https://metanit.com/sharp/entityframeworkcore/2.16.php