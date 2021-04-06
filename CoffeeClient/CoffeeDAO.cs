using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CoffeeClient
{
    public class CoffeeDAO
    {
        public List<Coffee> SelectAll()
        {
            List<Coffee> coffees = new List<Coffee>();
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Coffee";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Coffee coffee = new Coffee()
                {
                    Code = (int)dr["Code"],
                    Name = (String)dr["Name"],
                    Description = (String)dr["Description"],
                    Price = (int)dr["Price"],
                    Exp = (String)dr["Exp"],
                    Mfg = (String)dr["Mfg"]
                };
                coffees.Add(coffee);
            }

            return coffees;
        }

        public Coffee SelectByCode(int code)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Coffee WHERE Code=@Code";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Code", code));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                Coffee coffee = new Coffee()
                {
                    Code = (int)dr["Code"],
                    Name = (String)dr["Name"],
                    Description = (String)dr["Description"],
                    Price = (int)dr["Price"],
                    Exp = (String)dr["Exp"],
                    Mfg = (String)dr["Mfg"]
                };
                return coffee;
            }

            return null;
        }

        public List<Coffee> SelectByKeyword(String keyword)
        {
            List<Coffee> coffees = new List<Coffee>();
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Coffee WHERE Name LIKE @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Coffee coffee = new Coffee()
                {
                    Code = (int)dr["Code"],
                    Name = (String)dr["Name"],
                    Description = (String)dr["Description"],
                    Price = (int)dr["Price"],
                    Exp = (String)dr["Exp"],
                    Mfg = (String)dr["Mfg"]
                };
                coffees.Add(coffee);
            }

            return coffees;
        }

        public bool Insert(Coffee coffee)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "INSERT INTO Coffee VALUES(@Name, @Description, @Price, @Exp, @Mfg)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Name", coffee.Name));
            com.Parameters.Add(new SqlParameter("@Description", coffee.Description));
            com.Parameters.Add(new SqlParameter("@Price", coffee.Price));
            com.Parameters.Add(new SqlParameter("@Exp", coffee.Exp));
            com.Parameters.Add(new SqlParameter("@Mfg", coffee.Mfg));
            try
            {
                return com.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }
        
        public bool Update(Coffee coffee)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "UPDATE Coffee SET Name=@Name, Description=@Description, Price=@Price, Exp=@Exp, Mfg=@Mfg";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Name", coffee.Name));
            com.Parameters.Add(new SqlParameter("@Description", coffee.Description));
            com.Parameters.Add(new SqlParameter("@Price", coffee.Price));
            com.Parameters.Add(new SqlParameter("@Exp", coffee.Exp));
            com.Parameters.Add(new SqlParameter("@Mfg", coffee.Mfg));
            try
            {
                return com.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }
        
        public bool Delete(int code)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "DELETE FROM Coffee WHERE Code=@Code";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Code", code));
            try
            {
                return com.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}