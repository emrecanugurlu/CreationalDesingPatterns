
DatabaseCreater creater = new DatabaseCreater();
creater.createDatabase(new MsSqlFactory());

enum DatabaseType
{
    Oracle,
    MsSql,
    MySql,
    PostgreSql
}

class Database
{
    public DatabaseType DatabaseType { get; set; }
    public Command Command { get; set; }
    public Connection Connection { get; set; }
}

enum ConnectionState
{
    Open,
    Close
}
class Connection
{
    public string ConnectionString { get; set; }
    public ConnectionState State { get; set; }
    public bool Connect()
    {
        State = ConnectionState.Open;
        return true;
    }

    public bool Disconnect()
    {
        State = ConnectionState.Close;
        return true;
    }
}

class Command
{
    public void Execute(string command)
    {

    }
}

class DatabaseCreater
{
    Command Command;
    Connection Connection;
    DatabaseType DatabaseType;
    public Database createDatabase(IDatabaseFactory databaseFactory)
    {
        Database _database = new Database();
        Command = databaseFactory.createCommand();
        Connection = databaseFactory.createConnection();
        DatabaseType = databaseFactory.createDatabseType();
        _database.Connection = Connection;
        _database.DatabaseType = DatabaseType;
        _database.Command = Command;
        return _database;
        
    }
}

interface IDatabaseFactory
{
    public Connection createConnection();
    public Command createCommand();
    public DatabaseType createDatabseType();

}

class MsSqlFactory : IDatabaseFactory
{
    public Command createCommand()
    {
        return new Command { };
    }

    public Connection createConnection()
    {
        throw new NotImplementedException();
    }

    public DatabaseType createDatabseType()
    {
        return DatabaseType.MsSql;
    }
}

