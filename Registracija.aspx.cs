using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;

public partial class Registracija : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Source.Text = ""; 
        
    }

    protected void Regi_Click(object sender, EventArgs e)
    {
        OleDbConnection con = new OleDbConnection();
        
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";
        

       
        con.Open();
        OleDbCommand select = new OleDbCommand();
        select.CommandText = "SELECT Username FROM Users WHERE(Username = @user)";
       
       

        select.Parameters.AddWithValue("@user", this.TextBox1.Text);//ono što korisnik napiše i textbox se koristi kao parametar u bazi
        select.Connection = con;

        
        OleDbDataReader podaci = select.ExecuteReader();
        podaci.Read();
        if (podaci.HasRows==false)//ako ne nađe red u bazi, ovaj dio petlje će stvoriti korisnika
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "insert into [users] (username, pass) VALUES(@user,@pass)";
            
            //string CommandText1 = " insert into [users] (username, pass) VALUES(@user,@pass)";
            //SqlCommand cmd = new SqlCommand(CommandText1, con);

            cmd.Parameters.AddWithValue("@user", this.TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", this.TextBox2.Text);

            cmd.Connection = con;

            int a = cmd.ExecuteNonQuery();// izvršavanje naredbe, insert, delete itd
            if (a > 0)// ako je veće 0, uspješna je registracija
            {
                Source.ForeColor = System.Drawing.Color.Green;
                Source.Text = "uspješna registracija";
                Response.AddHeader("REFRESH", "3;URL=Prijava.aspx");
                //Response.Redirect("Prijava.aspx");
            }
            
        }
        else//nije uspješna
        {
            Source.ForeColor = System.Drawing.Color.Red;
            Source.Text = "korisničko ime već postoji";
            TextBox2.Text = "";
        }
        con.Close();
    }



    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
