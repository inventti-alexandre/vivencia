using MySql.Data.MySqlClient;

namespace Software.Basico.DB.Base
{
    class Connection
    {
        public MySqlConnection Create()
        {
            //Base de dados Local
            string connectionString = "server=localhost;database=Biblioteca_A;uid=root;password=1234;sslmode=none";

            //Base de dados FREI
            //string connectionString = "server=192.168.0.100;database=Biblioteca_A;uid=nsf;password=nsf@2018;sslmode=none";

            //Base de dados Azure
            //string connectionString = "server=70.37.57.127;database=Biblioteca_A;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
