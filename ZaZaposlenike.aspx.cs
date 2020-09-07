using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class ZaZaposlenike : System.Web.UI.Page
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


        Label1.Text = "";
        Label2.Text = "";
        Label3.Text = "";
        Label4.Text = "";
        Label5.Text = "";
        Label6.Text = "";

        OleDbConnection con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";
        con.Open();

        OleDbCommand select1 = new OleDbCommand();
        select1.CommandText = "SELECT id, sjedalono1 FROM avengers WHERE(zauzeto=@zauzetost)";
        select1.Parameters.AddWithValue("@zauzetost", "da");
        select1.Connection = con;
        OleDbDataReader podaci1 = select1.ExecuteReader();
        string niz1 = ""; // pomoću string niz stavljamo sva slobodna mjesta
        while (podaci1.Read())//čitamo redom podatke
        {
            niz1 += podaci1.GetString(1); //stavljamo slobodna mjesta
            niz1 += ", ";//sljedeće sjedalo
        }
        Label1.Text = niz1;

        OleDbCommand select2 = new OleDbCommand();
        select2.CommandText = "SELECT id, sjedalono1 FROM fastandf WHERE(zauzeto=@zauzetost)";
        select2.Parameters.AddWithValue("@zauzetost", "da");
        select2.Connection = con;
        OleDbDataReader podaci2 = select2.ExecuteReader();
        string niz2 = ""; // pomoću string niz stavljamo sva slobodna mjesta
        while (podaci2.Read())//čitamo redom podatke
        {
            niz2 += podaci2.GetString(1); //stavljamo slobodna mjesta
            niz2 += ", ";//sljedeće sjedalo
        }
        Label3.Text = niz2;

        OleDbCommand select3 = new OleDbCommand();
        select3.CommandText = "SELECT id, sjedalono1 FROM onceinhollywood WHERE(zauzeto=@zauzetost)";
        select3.Parameters.AddWithValue("@zauzetost", "da");
        select3.Connection = con;
        OleDbDataReader podaci3 = select3.ExecuteReader();
        string niz3 = ""; // pomoću string niz stavljamo sva slobodna mjesta
        while (podaci3.Read())//čitamo redom podatke
        {
            niz3 += podaci3.GetString(1); //stavljamo slobodna mjesta
            niz3 += ", ";//sljedeće sjedalo
        }
        Label5.Text = niz3;

    }

    protected void ButtonOtkazi_Click(object sender, EventArgs e)
    {
        OleDbConnection con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";
        con.Open();

        OleDbCommand select = new OleDbCommand();
        select.CommandText = "UPDATE avengers SET zauzeto=@zauzetost WHERE sjedalono1=@sjedalo";
        select.Parameters.AddWithValue("@zauzetost", "ne");
        select.Parameters.AddWithValue("@sjedalo", TextBox1.Text);
        //select.Parameters.AddWithValue("@user", Request.QueryString["Name"]);
        select.Connection = con;
        int a = select.ExecuteNonQuery();
        if (a > 0)
        {
            Label2.Text = "uspješno ste otkazali mjesto";
        }
    }

    protected void ButtonOtkazi0_Click(object sender, EventArgs e)
    {
        OleDbConnection con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";
        con.Open();

        OleDbCommand select = new OleDbCommand();
        select.CommandText = "UPDATE fastandf SET zauzeto=@zauzetost WHERE sjedalono1=@sjedalo";
        select.Parameters.AddWithValue("@zauzetost", "ne");
        select.Parameters.AddWithValue("@sjedalo", TextBox2.Text);
        //select.Parameters.AddWithValue("@user", Request.QueryString["Name"]);
        select.Connection = con;
        int a = select.ExecuteNonQuery();
        if (a > 0)
        {
            Label4.Text = "uspješno ste otkazali mjesto";
        }
    }

    protected void ButtonOtkazi1_Click(object sender, EventArgs e)
    {
        OleDbConnection con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";
        con.Open();

        OleDbCommand select = new OleDbCommand();
        select.CommandText = "UPDATE onceinhollywood SET zauzeto=@zauzetost WHERE sjedalono1=@sjedalo";
        select.Parameters.AddWithValue("@zauzetost", "ne");
        select.Parameters.AddWithValue("@sjedalo", TextBox3.Text);
        //select.Parameters.AddWithValue("@user", Request.QueryString["Name"]);
        select.Connection = con;
        int a = select.ExecuteNonQuery();
        if (a > 0)
        {
            Label6.Text = "uspješno ste otkazali mjesto";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}