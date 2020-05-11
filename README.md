# Entity FrameWork Best Practices
 
# Table of context

[Motivation](#_Toc40047671)

[Build Application](#_Toc40047672)

[Prepare DB](#_Toc40047673)

[Run API](#_Toc40047674)

## Motivation

 Source code produced acording to [tutorial](https://www.youtube.com/watch?v=qkJ9keBmQWo).

Entity Framework is an amazing set of tooling around data access. With EFCore, that tooling becomes even more powerful. So why is it that I still don't recommend that people use EFCore? In this video, I will walk you through the best practices of Entity Framework and EFCore and point out the pitfalls to avoid. We will discuss where there are problems and what to do to resolve those problems.

## Build Application

1. Install .NET Core 2.2.11 SDK ([https://dotnet.microsoft.com/download/dotnet-core/2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2))
2. Install Microsoft Visual Studio 2017 Version 15.9.22
3. Open solution .\EntityFrameWorkBestPractices\EFDemoWeb\EFDemoWeb.sln
4. Restore nuget packages (all used packages available on nuge1.org )

## Prepare DB

1. Edit .\EntityFrameWorkBestPractices\EFDemoWeb\EFDemoWeb\appsettings.json
2. Edit section ConnectionStrings

Sample configuration to connect MS SQL LocalDB

Server=(localdb)\\mssqllocaldb

Database=EntityFrameWorkBP

User=sa

Password=1111

&quot;ConnectionStrings&quot;: {

&quot;LocalDataBase&quot;: &quot;Server=(localdb)\\mssqllocaldb;Database=EntityFrameWorkBP;Trusted\_Connection=True;ConnectRetryCount=0;User Id=sa;Password=1111;&quot;

}

- Download LacalDB [https://www.microsoft.com/en-us/download/details.aspx?id=55994](https://www.microsoft.com/en-us/download/details.aspx?id=55994)
- Check the LocalDB instance [https://blog.jetbrains.com/datagrip/2016/10/07/connecting-datagrip-to-sql-server-express-localdb/](https://blog.jetbrains.com/datagrip/2016/10/07/connecting-datagrip-to-sql-server-express-localdb/) )
- Entity Framework Connection strings [https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings](https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings)

1. Build Solution EFDemoWeb.sln
2. Run Package Manage Console
3. In Package Manage Console select &quot;Default project&quot; EFDemoWeb.cproj assembly
4. In Package Manage Console run update-database

## Run API

1. Open solution .\EntityFrameWorkBestPractices\EFDemoWeb\EFDemoWeb.sln
2. Set as StartUp project EFDemoWeb.cproj
3. Run application In Debug or Release configuration
4. In browser will be opened url https://localhost:nnnnn/ where nnnnn your Express IIS port
