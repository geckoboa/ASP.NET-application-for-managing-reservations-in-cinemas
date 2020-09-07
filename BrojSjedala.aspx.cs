using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;

public partial class BrojSjedala : System.Web.UI.Page
{
    //Pomoću ove metode dobivamo informacije vezane uz mogućnost odabira sjedala koje je na raspolaganju
    //kao i njegova rezervacija

    //PageLoad-čim se stvori stranica, što će se napravit

        //briše se cache, ne zapampti history
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


        SlobodnaSjedala.Text = "Slodobna sjedala su (od 1 do 10 je prvi red ispred platna): ";
        Label2.Text = "";
        Label3.Text = "Rezerviraj sjedalo ";
        Label4.Text = "";
    }


    //Ovom metodom pristupamo bazi podataka(koja se nalazi na navedenoj putanji) i iz nje provjeravamo odabranog sjedala
    //Korisnik pomoću DropDownListe odabire za koji film želi rezervirati mjesto, dobije popis koja je slobodna a koja ne
    // 
    OleDbCommand select;
    OleDbConnection con;
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";
        con.Open();
        string pom = DropDownList1.SelectedValue.ToString();
        select = new OleDbCommand();
        if (pom.Equals("Avengers Endgame") && Request.QueryString["Date"].Equals("30.9.2019.") && Request.QueryString["Time"].Equals("17:30")) 
        {
            select.CommandText = "SELECT id, sjedalono1 FROM avengers WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("avengers");

        }

        if (pom.Equals("Avengers Endgame") && Request.QueryString["Date"].Equals("1.10.2019.") && Request.QueryString["Time"].Equals("18:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM avengers2 WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("avengers");
        }
        if (pom.Equals("Avengers Endgame") && Request.QueryString["Date"].Equals("2.10.2019.") && Request.QueryString["Time"].Equals("19:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM avengers WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("avengers");
        }
        

        if (pom.Equals("Fast and Furious") && Request.QueryString["Date"].Equals("30.9.2019.") && Request.QueryString["Time"].Equals("17:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM fastandf WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("fastandf");
        }

        if (pom.Equals("Fast and Furious") && Request.QueryString["Date"].Equals("1.10.2019.") && Request.QueryString["Time"].Equals("18:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM fastandf2 WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("fastandf");
        }
        if (pom.Equals("Fast and Furious") && Request.QueryString["Date"].Equals("2.10.2019.") && Request.QueryString["Time"].Equals("19:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM fastandf2 WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("fastandf");
        }
        

        if (pom.Equals("Once upon a time in Hollywood") && Request.QueryString["Date"].Equals("30.9.2019.") && Request.QueryString["Time"].Equals("17:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM onceinhollywood WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("onceinhollywood");
        }

        if (pom.Equals("Once upon a time in Hollywood") && Request.QueryString["Date"].Equals("1.10.2019.") && Request.QueryString["Time"].Equals("18:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM onceinhollywood2 WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("onceinhollywood");
        }
        if (pom.Equals("Once upon a time in Hollywood") && Request.QueryString["Date"].Equals("2.10.2019.") && Request.QueryString["Time"].Equals("19:30"))
        {
            select.CommandText = "SELECT id, sjedalono1 FROM onceinhollywood2 WHERE(zauzeto=@zauzetost)";
            citanjeSlobodnihMjesta("onceinhollywood");
        }
        
    }

    private void citanjeSlobodnihMjesta(string table)
    {
        select.Parameters.AddWithValue("@zauzetost", "ne");
        select.Connection = con;
        OleDbDataReader podaci = select.ExecuteReader();
        string niz = ""; // pomoću string niz stavljamo sva slobodna mjesta
        while (podaci.Read())//čitamo redom podatke
        {
            niz += podaci.GetString(1); //stavljamo slobodna mjesta
            niz += ", ";//sljedeće sjedalo
        }
        Label2.Text = niz;
    }

    protected void ButtonRezerviraj_Click(object sender, EventArgs e)
    {
        con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nik Titanik\Desktop\kino.accdb;Persist Security Info=False;";
        con.Open();
        string pom = DropDownList1.SelectedValue.ToString();
        select = new OleDbCommand();

        

        //pokupimo parametar koja nam je prošla stranica poslala
        if (pom.Equals("Avengers Endgame") && Request.QueryString["Date"].Equals("30.9.2019.") && Request.QueryString["Time"].Equals("17:30")) 
        {
            select.CommandText = "UPDATE avengers SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("avengers");
        }
        if (pom.Equals("Avengers Endgame") && Request.QueryString["Date"].Equals("1.10.2019.") && Request.QueryString["Time"].Equals("18:30"))
        {
            select.CommandText = "UPDATE avengers2 SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("avengers");
        }
        if (pom.Equals("Avengers Endgame") && Request.QueryString["Date"].Equals("2.10.2019.") && Request.QueryString["Time"].Equals("19:30"))
        {
            select.CommandText = "UPDATE avengers2 SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("avengers");
        }

        if (pom.Equals("Fast and Furious") && Request.QueryString["Date"].Equals("30.9.2019.") && Request.QueryString["Time"].Equals("17:30"))
        {
            select.CommandText = "UPDATE fastandf SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("fastandf");
        }

        if (pom.Equals("Fast and Furious") && Request.QueryString["Date"].Equals("1.10.2019.") && Request.QueryString["Time"].Equals("18:30"))
        {
            select.CommandText = "UPDATE fastandf2 SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("fastandf");
        }
        if (pom.Equals("Fast and Furious") && Request.QueryString["Date"].Equals("2.10.2019.") && Request.QueryString["Time"].Equals("19:30"))
        {
            select.CommandText = "UPDATE fastandf2 SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("avengers");
        }

        if (pom.Equals("Once upon a time in Hollywood") && Request.QueryString["Date"].Equals("30.9.2019.") && Request.QueryString["Time"].Equals("17:30"))
        {
            select.CommandText = "UPDATE onceinhollywood SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("onceinhollywood");
        }

        if (pom.Equals("Once upon a time in Hollywood") && Request.QueryString["Date"].Equals("1.10.2019.") && Request.QueryString["Time"].Equals("18:30"))
        {
            select.CommandText = "UPDATE onceinhollywood2 SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("onceinhollywood");
        }
        if (pom.Equals("Once upon a time in Hollywood") && Request.QueryString["Date"].Equals("2.10.2019.") && Request.QueryString["Time"].Equals("19:30"))
        {
            select.CommandText = "UPDATE onceinhollywood2 SET zauzeto=@zauzetost, username=@user WHERE sjedalono1=@sjedalo";
            zauzmiMjestoUDvorani("onceinhollywood");
        }

        con.Close();
    }

    private void zauzmiMjestoUDvorani(string table)
    {
        select.Parameters.AddWithValue("@zauzetost", "da");
        select.Parameters.AddWithValue("@user", Request.QueryString["User"]);
        select.Parameters.AddWithValue("@sjedalo", TextBox1.Text);
        select.Connection = con;
        int a = select.ExecuteNonQuery();
        if (a > 0)
        {
            Label4.Text = "uspješno ste rezervirali mjesto";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}