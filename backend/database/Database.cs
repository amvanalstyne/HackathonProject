using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathon.project.HackathonProject.backend.models;

namespace hackathon.project.HackathonProject.backend.database
{
    public class Database
    {
        private string cs;


        public Database()
        {
            cs = "server=tuy8t6uuvh43khkk.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;database=wypwpiobd711vs7a;user=c6w21g0kuls6ov8a;password=u1cyr20tjjxa2zz9;port=3306;";
        }

        public async Task<object> Login(login newLogin){
            string sql = "SELECT Email, Name FROM users WHERE Email = @Email AND Password = @Password;";

            List<MySqlParameter> parms = new();
            parms.Add(new MySqlParameter("@Email", MySqlDbType.String) {Value = newLogin.Email});
            parms.Add(new MySqlParameter("@Password", MySqlDbType.String) {Value = newLogin.Password});

            return await ValidateLogin(sql, parms);
        }
        private async Task<object> ValidateLogin(string sql, List<MySqlParameter> parms){
            using var connection = new MySqlConnection(cs);
            await connection.OpenAsync();
            using var command = new MySqlCommand(sql, connection);

            if(parms != null){
                command.Parameters.AddRange(parms.ToArray());
            }
            using var reader = await command.ExecuteReaderAsync();
            if(await reader.ReadAsync()){
                return new{
                    Email = reader.GetString(0),
                    Name = reader.GetString(1)
                }
            }
            return null;
        }


    }
}