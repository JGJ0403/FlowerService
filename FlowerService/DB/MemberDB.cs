using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace FlowerService
{
    public class Member
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string IsAdmin { get; set; }
    }

   public  class MemberDB : IDisposable  // 클로즈를 원하는대로 구현하기 위해 
    {
        MySqlConnection conn; // 실제 생성은 생성자에서

        public MemberDB() // 생성자
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["flower"].ConnectionString;
            // 빈생성자를 반들었다가 커넥션 스트링 속성으로 준것
            conn.Open();
        }

        public Member Login(string uid, string pwd) //멤버클래스 속성의 메서드
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn; // 의미???
            cmd.CommandText = @"select user_id, user_name, user_email from flwuser
                                             where user_id = @user_id and  user_pwd = @user_pwd";

            // 트랙잭션은 여러개 있을때 사용

            cmd.Parameters.Add("@user_id", MySqlDbType.VarChar);
            cmd.Parameters["@user_id"].Value = uid;
            cmd.Parameters.Add("@user_pwd", MySqlDbType.VarChar);
            cmd.Parameters["@user_pwd"].Value = pwd;

            MySqlDataReader reader =  cmd.ExecuteReader();
            if (reader.Read()) // 로그인 성공하면
            {
                Member member = new Member();
                member.ID = reader["user_id"].ToString();
                member.Name = reader["user_name"].ToString();
                member.Email = reader["user_email"].ToString();

                return member; // return 타입이 Member 
            }
            else // 로그인실패, false 라면 읽지 않는다
            {
                return null;  // return 타입이 Member => 없을땐 모든래퍼런스의 초기값 Null 사용
            }
        }

        public int SearchPwd(string uid, string name, string email)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"select user_id, user_name, user_email 
                                             from flwuser
                                             where user_id = @user_id, user_name = @user_name, user_email = @user_email";
            cmd.Connection = conn;

            cmd.Parameters.Add("@user_id", MySqlDbType.VarChar);
            cmd.Parameters["@user_id"].Value = uid;
            cmd.Parameters.Add("@user_name", MySqlDbType.VarChar);
            cmd.Parameters["@user_name"].Value = name;
            cmd.Parameters.Add("@user_email", MySqlDbType.VarChar);
            cmd.Parameters["@user_email"].Value = email;

            return Convert.ToInt32(cmd.ExecuteScalar()); // ?
        }

        public bool UpdatePwd(string newPwd, string uid) // 아이디 패스워드 치기
        {
            try 
            { 
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update flwuser set user_pwd = @user_pwd where user_id = @user_id";
            cmd.Connection = conn;

            cmd.Parameters.Add("@user_pwd", MySqlDbType.VarChar);
            cmd.Parameters["@user_pwd"].Value = newPwd;

            cmd.Parameters.Add("@user_id", MySqlDbType.VarChar);
            cmd.Parameters["@user_id"].Value = uid;

                // ExecuteNonQuery()는 적용된 행이 수를 반환
                // 정상적인 실행을 했을 때에도 적용된 행의 수에 따라서 다른 결과를 처리할 수 있다.
                int iRows = cmd.ExecuteNonQuery();
                if (iRows > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetCodeListByCategory(string category)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"select Code, CodeName 
                                             from commonCode where category = @category
                                             order by code; ";
            cmd.Connection = conn;

            cmd.Parameters.Add("@category", MySqlDbType.VarChar);
            cmd.Parameters["@category"].Value = category;

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
