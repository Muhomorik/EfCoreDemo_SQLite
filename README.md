Links

[.NET Framework - New Database](https://docs.microsoft.com/en-us/ef/core/get-started/full-dotnet/new-db)

[.NET Core - New Database - SQLite](https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite#comments-container)

Problems:

https://github.com/dotnet/cli/issues/2802

## Article SQlite code: ##

    dotnet ef migrations add MyFirstMigration
    dotnet ef database update

In project.json folder:

    No executable found matching command "dotnet-ef"

## Article SQL code: ##

    Tools –> NuGet Package Manager –> Package Manager Console

    Run Add-Migration MyFirstMigration to scaffold a migration to create the initial set of tables for your model.

    Run Update-Database to apply the new migration to the database. Because your database doesn't exist yet, it will be created for you before the migration is applied.

### Result: ###

    PM> Add-Migration MyFirstMigration
    To undo this action, use Remove-Migration.
    PM> Update-Database
    Executed DbCommand (10ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    PRAGMA foreign_keys=ON;
    Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    PRAGMA foreign_keys=ON;
    Executed DbCommand (196ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    CREATE TABLE "__EFMigrationsHistory" (
        "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
        "ProductVersion" TEXT NOT NULL
    );
    Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    PRAGMA foreign_keys=ON;
    Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    PRAGMA foreign_keys=ON;
    Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    SELECT COUNT(*) FROM "sqlite_master" WHERE "name" = '__EFMigrationsHistory' AND "type" = 'table';
    Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    PRAGMA foreign_keys=ON;
    Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    SELECT "MigrationId", "ProductVersion"
    FROM "__EFMigrationsHistory"
    ORDER BY "MigrationId";
    Applying migration '20161127212101_MyFirstMigration'.
    Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    PRAGMA foreign_keys=ON;
    Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    CREATE TABLE "Blogs" (
        "BlogId" INTEGER NOT NULL CONSTRAINT "PK_Blogs" PRIMARY KEY AUTOINCREMENT,
        "Url" TEXT
    );
    Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    CREATE TABLE "Posts" (
        "PostId" INTEGER NOT NULL CONSTRAINT "PK_Posts" PRIMARY KEY AUTOINCREMENT,
        "BlogId" INTEGER NOT NULL,
        "Content" TEXT,
        "Title" TEXT,
        CONSTRAINT "FK_Posts_Blogs_BlogId" FOREIGN KEY ("BlogId") REFERENCES "Blogs" ("BlogId") ON DELETE CASCADE
    );
    Executed DbCommand (20ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    CREATE INDEX "IX_Posts_BlogId" ON "Posts" ("BlogId");
    Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20161127212101_MyFirstMigration', '1.1.0-rtm-22752');
    Done.
    PM> 