using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Configuration;
using System.Data.SQLite;
using System.Text.RegularExpressions;


public class DatabaseService
{
    private readonly string _connectionString;

    public DatabaseService(string dbPath)
    {
        _connectionString = $"Data Source={dbPath}";
    }
    [SQLiteFunction(Name = "REGEXP", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class RegExpFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            if (args.Length != 2) return false;
            string pattern = args[0].ToString();
            string input = args[1].ToString();
            return Regex.IsMatch(input, pattern);
        }
    }

    //1: вставити в таблицю Користувачі
    public void InsertUsersData(string name, string email, string password)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            //SQLiteFunction.RegisterFunction(typeof(RegExpFunction));


            using (var command = connection.CreateCommand())
            {
                //command.CommandText = "PRAGMA journal_mode=WAL;";
                command.CommandText = "INSERT INTO users (name, email, password) VALUES(@name, @email, @password)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
    //2: вставити в таблицю Прибутки
    public void InsertIncomesData(string category, string income_date, double income_sum, int account_id)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                // Виправлений SQL-запит
                command.CommandText = "INSERT INTO incomes (category, income_date, income_sum, account_id) VALUES(@category, @income_date, @income_sum, @account_id)";
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@income_date", income_date);
                command.Parameters.AddWithValue("@income_sum", income_sum);
                command.Parameters.AddWithValue("@account_id", account_id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    //3: вставити в таблицю ЗапланованіПлатежі
    public void InsertPlannedExpensesData(string name, double plannedSum, int notificationDate, int userId)
    {

        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO planned_expenses (name, planned_sum, notification_date, user_id) VALUES(@name, @planned_sum, @notification_date, @user_id)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@planned_sum", plannedSum);
                command.Parameters.AddWithValue("@notification_date", notificationDate);
                command.Parameters.AddWithValue("@user_id", userId);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    //4: вставити в таблицю Заощадження
    public void InsertSavingsData(string targetName, double targetSum, double currentSum, string endDate, int userId)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO savings (target_name, target_sum, current_sum, end_date, user_id) VALUES(@target_name, @target_sum, @current_sum, @end_date, @user_id)";
                command.Parameters.AddWithValue("@target_name", targetName);
                command.Parameters.AddWithValue("@target_sum", targetSum);
                command.Parameters.AddWithValue("@current_sum", currentSum);
                command.Parameters.AddWithValue("@end_date", endDate);
                command.Parameters.AddWithValue("@user_id", userId);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }


    //5: вставити в таблицю КатегоріїВитрат
    public void InsertExpensesCategoriesData(string name, int? userId = null)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                if (userId == null)
                {
                    command.CommandText = "INSERT INTO expenses_categories (name) VALUES(@name)";
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command.CommandText = "INSERT INTO expenses_categories (name, user_id) VALUES(@name, @user_id)";
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }
    }

    //6: Вставити в таблицю Рахунки
    public void InsertAccountsData(string type, string name, double balance, int userId, string? cardNumber = null)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                if (cardNumber == null)
                {
                    command.CommandText = "INSERT INTO accounts (type, name, balance, user_id) VALUES(@type, @name, @balance, @user_id)";
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@balance", balance);
                    command.Parameters.AddWithValue("@user_id", userId);
                }
                else
                {
                    command.CommandText = "INSERT INTO accounts (type, name, card_number, balance, user_id) VALUES(@type, @name, @card_number, @balance, @user_id)";
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@card_number", cardNumber);
                    command.Parameters.AddWithValue("@balance", balance);
                    command.Parameters.AddWithValue("@user_id", userId);
                }

                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }


    //7: Вставити в таблицю Витрати
    public void InsertExpensesData(int categoryId, string expenseDate, double expenseSum, int accountId)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO expenses (category_id, expense_date, expense_sum, account_id) VALUES(@category_id, @expense_date, @expense_sum, @account_id)";
                command.Parameters.AddWithValue("@category_id", categoryId);
                command.Parameters.AddWithValue("@expense_date", expenseDate);
                command.Parameters.AddWithValue("@expense_sum", expenseSum);
                command.Parameters.AddWithValue("@account_id", accountId);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }


    //7: Взяти інфу з Витрати
    public void GetFullExpensesData()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM expenses";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)}, Category ID: {reader.GetInt32(1)}, Expense Date: {reader.GetString(2)}, Expense Sum: {reader.GetDouble(3)}, Account ID: {reader.GetInt32(4)}");
                    }
                }
            }
            connection.Close();
        }
    }

    //6: Взяти інфу з Рахунки
    public void GetFullAccountsData()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM accounts";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var type = reader.GetString(1);
                        var name = reader.GetString(2);
                        var cardNumber = reader.IsDBNull(3) ? "-" : reader.GetString(3); // Перевірка на null для cardNumber
                        var balance = reader.GetDouble(4);
                        var userId = reader.GetInt32(5); 

                        Console.WriteLine($"ID: {id}, Type: {type}, Name: {name}, Card Number: {cardNumber}, Balance: {balance}, User ID: {userId}");
                    }
                }
            }
            connection.Close();
        }
    }


    //5: Взяти інфу з КатегоріїВитрат
    public void GetFullExpensesCategoriesData()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM expenses_categories";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0); // ID
                        string name = reader.GetString(1); // Name

                        // Перевірка, чи user_id не є NULL
                        if (!reader.IsDBNull(2)) // Перевіряємо третій стовпець (user_id)
                        {
                            int userId = reader.GetInt32(2); // Отримуємо user_id
                            Console.WriteLine($"ID: {id}, Name: {name}, User ID: {userId}");
                        }
                        else
                        {
                            Console.WriteLine($"ID: {id}, Name: {name}, User ID: Not assigned");
                        }
                    }
                }
            }
            connection.Close();
        }
    }

    //1: взяти інфу з Заощаджень
    public void GetFullSavingsData()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM savings";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)}, Target Name: {reader.GetString(1)}, Target Sum: {reader.GetDouble(2)}, Current Sum: {reader.GetDouble(3)}, End Date: {reader.GetString(4)}, User ID: {reader.GetInt32(5)}");
                    }
                }
            }
            connection.Close();
        }
    }

    //2: взяти інфу з ЗапланованихПлатежів
    public void GetFullPlannedExpensesData()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM planned_expenses";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Planned Sum: {reader.GetDouble(2)}, Notification Date: {reader.GetInt32(3)}, User ID: {reader.GetInt32(4)}");
                    }
                }
            }
            connection.Close();
        }
    }

    //3: взяти інфу з Прибуток
    public void GetFullIncomesData()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM incomes";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)}, Category: {reader.GetString(1)}, Date {reader.GetString(2)}, Sum: {reader.GetDouble(3)}, Account id: {reader.GetInt32(4)}");
                    }
                }
            }
            connection.Close();
        }
    }

    //4: взяти інфу з Користувачі
    public void GetFullUsersData()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM users";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Email: {reader.GetString(2)}, Password: {reader.GetString(3)}");
                    }
                }
            }
            connection.Close();
        }
    }

    public void DeleteAllFromUsers()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM users";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteAllFromAccounts()

    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM accounts";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteAllFromIncomes()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM incomes";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteAllFromExpensesCategories()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM expenses_categories";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteAllFromExpenses()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM expenses";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteAllFromSavings()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM savings";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteAllFromPlannedExpenses()
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM planned_expenses";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }


}