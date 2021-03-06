using System;
using NServiceBus;
using NServiceBus.Persistence.Sql.ScriptBuilder;

public static class SqlDialectConverter
{
    public static BuildSqlDialect Convert(this SqlDialect sqlDialect)
    {
       if(sqlDialect is SqlDialect.MsSqlServer)
       {
           return BuildSqlDialect.MsSqlServer;
       }

        if (sqlDialect is SqlDialect.MySql)
        {
            return BuildSqlDialect.MySql;
        }

        if (sqlDialect is SqlDialect.Oracle)
        {
            return BuildSqlDialect.Oracle;
        }

        throw new Exception($"Unknown SqlDialect: {sqlDialect.Name}.");
    }
    public static SqlDialect Convert(this BuildSqlDialect sqlDialect, string schema = null)
    {
        switch (sqlDialect)
        {
            case BuildSqlDialect.MsSqlServer:
                var dialect = new SqlDialect.MsSqlServer();
                dialect.Schema = schema;
                return dialect;
            case BuildSqlDialect.MySql:
                return new SqlDialect.MySql();
            case BuildSqlDialect.Oracle:
                return new SqlDialect.Oracle();
            default:
                throw new Exception($"Unknown BuildSqlDialect: {sqlDialect}.");
        }
    }
}