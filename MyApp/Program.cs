// using System;
// using System.Data.SqlClient;
// using Microsoft.Data.SqlClient;
// class Program
// {
//     static void Main()
//     {
//         try{
//         string connectionString = "Data Source=ACU-HYD-LT-2032;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
//         SqlConnection connection = new SqlConnection(connectionString);
//         connection.Open();
//         Console.WriteLine("Connection established successfully.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error hello world: " + ex.Message);
//         }
//     }
// }

using System;
using Microsoft.Data.SqlClient;
string connectionString = "Data Source=ACU-HYD-LT-2032;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
using SqlConnection connection = new SqlConnection(connectionString);
connection.Open();
// string query = "SELECT * FROM Practice1.dbo.Employee";
// using SqlCommand command = new SqlCommand(query, connection);
// using SqlDataReader reader = command.ExecuteReader();

// string insertQuery = "INSERT INTO Practice1.dbo.Employee (EmpId, EmpName, DeptID) VALUES (6, 'John', '10')";
// using SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
// int InsertRowsAffected = insertCommand.ExecuteNonQuery();
// Console.WriteLine($"Inserted {InsertRowsAffected} rows into the Employee table.");



// string updateQuery = "UPDATE Practice1.dbo.Employee SET EmpName = 'John Doe' WHERE EmpId = 6";
// using SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
// int UpdateRowsAffected = updateCommand.ExecuteNonQuery();
// Console.WriteLine($"Updated {UpdateRowsAffected} rows in the Employee table.");



// while (reader.Read())
// {
//     int employeeId = reader.GetInt32(0); // Assuming EmployeeId is the first column
//     string firstName = reader.GetString(1); // Assuming FirstName is the second column
//     int lastName = reader.GetInt32(3); // Assuming LastName is the third column

//     Console.WriteLine($"Employee ID: {employeeId}, Name: {firstName}, Salary:{lastName}");
// }
// if (!reader.Read())
// {
//     Console.WriteLine("No records found.");
// }

string sql = @"Insert into Practice1.dbo.Employee(EmpId, EmpName, DeptID) values(@EmpId, @EmpName, @DeptID); select Cast(scope_identity() as int);";
using SqlCommand command = new SqlCommand(sql, connection);
command.Parameters.AddWithValue("@EmpId", 7);
command.Parameters.AddWithValue("@EmpName", "Jane");
command.Parameters.AddWithValue("@DeptID", "20");
int newEmployeeId = (int)command.ExecuteScalar();
Console.WriteLine($"New employee created with ID: {newEmployeeId}");

