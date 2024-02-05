using Microsoft.Data.SqlClient;
using WalletDalContract;
using WalletFunction;
using static WalletFunction.Amount;

namespace WalletRepositories
{
    public class WalletRepository : IWalletRepository
    {
        public void Add(AmountType type)
        {
            string connectionString = "Data Source=DESKTOP-M2QA1DM\\SQLEXPRESS;Initial Catalog=walbase;User ID=User;Password=;Encrypt=False;Trusted_Connection=True";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO Wallets (rub) VALUES({type})";
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
