using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Web.UI.HtmlControls;

public partial class Prijava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpContext.Current.Response.Cache.SetAllowResponseInBrowserHistory(false);
        HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        HttpContext.Current.Response.Cache.SetNoStore();
        Response.Cache.SetExpires(System.DateTime.Now);
        Response.Cache.SetValidUntilExpires(true);

        Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);

        HttpContext.Current.Response.Cache.SetNoServerCaching();
        HttpContext.Current.Response.Cache.SetNoStore();

        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();

        LabelPoruka.Text = "";
    }
    
    
    protected void Pocetna_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        OleDbConnection con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";//putanja baze
        con.Open();
        OleDbCommand select = new OleDbCommand();
        select.CommandText = "SELECT id, Username FROM Users WHERE Username = @user and pass = @pass";
        select.Parameters.AddWithValue("@user", this.TextBox1.Text);
        select.Parameters.AddWithValue("@pass", this.TextBox2.Text);
        select.Connection = con;

        OleDbDataReader podaci = select.ExecuteReader();
        podaci.Read();



        if (TextBox1.Text.Equals("admin") && TextBox2.Text.Equals("pass")){ 
            Response.Redirect("ZaZaposlenike.aspx");
        }
        else if(podaci.HasRows)
        {
            Session["username"] = TextBox1.Text.Trim();
            Response.Redirect(String.Format("DateTime.aspx?User={0}",TextBox1.Text));
            
            
        }
        else
        {
            
            LabelPoruka.ForeColor = System.Drawing.Color.Red;
            LabelPoruka.Text = "Krivi podaci ";
            TextBox2.Text = "";
            
        }
        podaci.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registracija.aspx");
    }
}