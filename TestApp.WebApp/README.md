# Create database
In solution dictionary

```powershell
dotnet ef database update --project TestApp.WebApp
```

# Update database schema
If model has been changed migration is needed.
In solution dictionary

```powershell
dotnet ef migrations add <MigrationName> --project TestApp.WebApp
```
