using Microsoft.Data.SqlClient;
using WalletDalContract;
using WalletFunction;

namespace WalletRepositories
{
    public class WalletRepository : IWalletRepository
    {
        public void Add(RubBalance rub)
        {
            string connectionString = "Data Source=DESKTOP-M2QA1DM\\SQLEXPRESS;Initial Catalog=walbase;User ID=User;Password=;Encrypt=False;Trusted_Connection=True";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO Wallets (rub) VALUES ({rub.Rub})";
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
