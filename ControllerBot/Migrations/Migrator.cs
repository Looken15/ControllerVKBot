using DbUp;

namespace ControllerBot.Migrations;

public static class Migrator
{
    public static void Migrate(WebApplication app)
    {
        var connectionString = app.Configuration["PostgresConnectionString"];
        var result = DeployChanges.To
            .PostgresqlDatabase(connectionString)
            .WithScriptsFromFileSystem("Migrations/Scripts")
            .Build()
            .PerformUpgrade();

        if (!result.Successful)
        {
            throw new Exception("migration failed!");
        }
    }
}