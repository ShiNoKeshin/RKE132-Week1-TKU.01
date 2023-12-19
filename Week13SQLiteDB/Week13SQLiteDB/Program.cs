using System.ComponentModel.Design;
using System.Data;
using System.Data.SQLite;

ReadData(CreateConnection());
//InsertCustomer(CreateConnection());
//RemoveCustomer(CreateConnection());
FindCustomer(CreateConnection());

static SQLiteConnection CreateConnection()
{
    SQLiteConnection connection = new SQLiteConnection("Data Source=mydb.db; Version = 3; New = True; Compress = True;");

    try
    {
        connection.Open();
        Console.WriteLine("DB found");
    }
    catch
    {
        Console.WriteLine("404");
    }
    return connection;
}

static void ReadData(SQLiteConnection myConnection)
{
    Console.Clear();
    SQLiteDataReader reader;
    SQLiteCommand command;
    
    command = myConnection.CreateCommand();
    command.CommandText = "SELECT customer.firstname, customer.lastname, " +
        "status.statustype, customerContact.customeremail, customer.dateofbirth FROM customerStatus " +
        "JOIN customer ON customer.rowid = customerStatus.customerId " +
        "JOIN status ON status.rowid = customerStatus.statusId " +
        "JOIN customerContact ON customerContact.customerid = customerStatus.customerId " +
        "ORDER BY customer.dateofbirth";
    reader = command.ExecuteReader();

    while (reader.Read())
    {
        string readerStringFirstName = reader.GetString(0);
        string readerStringLastName = reader.GetString(1);
        string readerStringStatus = reader.GetString(2);
        string readerStringEmail = reader.GetString(3);
        string readerStringDOB = reader.GetString(4);

        Console.WriteLine($"Name: {readerStringFirstName} {readerStringLastName}; DOB: {readerStringDOB}; Email: {readerStringEmail}");
    }
    myConnection.Close();
}

static void InsertCustomer(SQLiteConnection myConnection)
{
    SQLiteCommand command;
    string fName, lName, cStatus, cEmail, uDoB;
    //DateTime cDob;

    Console.WriteLine("Enter first name:");
    fName = Console.ReadLine();
    Console.WriteLine("Enter last name:");
    lName = Console.ReadLine();
    //Console.WriteLine("Enter your email:");
    //cEmail = Console.ReadLine();
    Console.WriteLine("Enter your date of birth(YYYY-MM-DD):");
    uDoB = Console.ReadLine();
    //cDob = DateTime.Parse(Console.ReadLine());

    //DateTime dateComp = new DateTime(1993, 8, 21);
    //int resultComp = DateTime.Compare(cDob, dateComp);
    //if (resultComp == 0) cStatus = "3";
    //else cStatus = "1";

    command = myConnection.CreateCommand();
    command.CommandText = $"INSERT INTO customer(firstName, lastName, dateOfBirth) VALUES ('{fName}', '{lName}', '{uDoB}')";
    
    int rowInserted = command.ExecuteNonQuery();
    Console.WriteLine($"Row inserter: {rowInserted}");

    //command = myConnection.CreateCommand();
    //command.CommandText = $"INSERT INTO customerContact(customerId, customerEmail) VALUES ('{rowInserted}', '{cEmail}')" +
    //    $"INSERT INTO customerStatust(customerId, statusId) VALUES ('{rowInserted}', '{cStatus}')";

    ReadData(myConnection);
}

static void RemoveCustomer(SQLiteConnection myConnection)
{
    SQLiteCommand command;
    string idToDelete;
    Console.WriteLine("Enter the ID to delete:");
    idToDelete = Console.ReadLine();

    command = myConnection.CreateCommand();
    command.CommandText = $"DELETE FROM customer WHERE rowid = {idToDelete}";

    int rowDeleted = command.ExecuteNonQuery();
    Console.WriteLine($"{rowDeleted} was removed.");

    ReadData(myConnection);
}

static void FindCustomer(SQLiteConnection myConnection)
{
    SQLiteDataReader reader;
    SQLiteCommand command;
    string searchName;
    
    Console.WriteLine("Enter a first name to display customer data:");
    searchName = Console.ReadLine();
    
    command = myConnection.CreateCommand();
    command.CommandText = $"SELECT customer.rowid, customer.firstName, customer.lastName, status.statusType " +
        $"FROM customerStatus " +
        $"JOIN customer ON customer.rowid = customerStatus.customerId " +
        $"JOIN status ON status.rowid = customerStatus.statusId " +
        $"WHERE firstname LIKE '{searchName}'";
        reader = command.ExecuteReader();
    while (reader.Read())
    {
        string readerRowid = reader["rowid"].ToString();
        string readerStringName = reader.GetString(1);
        string readerStringLastName = reader.GetString(2);
        string readerStringStatus = reader.GetString(3);
        Console.WriteLine($"Search result: ID: {readerRowid}. {readerStringName} {readerStringLastName}. Status: {readerStringStatus}");
    }
    myConnection.Close();
}