using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DateTime : System.Web.UI.Page
{
    Button button;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //glob varijabla, komuni između pageva, ako je prazno mora se na prijavu
        if (Session["username"] ==null)
        {
            Response.Redirect("Prijava.aspx");
        }

        String date = Calendar1.SelectedDate.ToShortDateString();
        //npr stnisne se gumb/podatak, kalendar je tu podatak
        //postbag kod dinamičkih stvorenih kontrola
        if (Page.IsPostBack && date.Equals("1.10.2019."))
        {
            

            Button button = new Button();
            Label1.Text = "Vrijeme početka filma";
            button.Text = "18:30";
            button.ID = "button1";
            button.Click += new System.EventHandler(rezervirajTerminDrugi);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(button);
        }
        if (Page.IsPostBack && date.Equals("30.9.2019."))
        {
            
            Button button = new Button();
            Label1.Text = "Vrijeme početka filma";
            button.Text = "17:30";
            button.ID = "button1";
            button.Click += new System.EventHandler(rezervirajTermin);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(button);
        }
        if (Page.IsPostBack && date.Equals("2.10.2019."))
        {

            Button button = new Button();
            Label1.Text = "Vrijeme početka filma";
            button.Text = "19:30";
            button.ID = "button1";
            button.Click += new System.EventHandler(rezervirajTerminTreci);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(button);
        }
        

    }


    private void rezervirajTerminTreci(object sender, EventArgs e)
    {
        Response.Redirect(String.Format("BrojSjedala.aspx?User={0}&Date=2.10.2019.&Time=19:30", Request.QueryString["User"]));
    }

    private void rezervirajTerminDrugi(object sender, EventArgs e)
    {
        //zovemo stranicu tu i šaljemo određene podatke npr 18:30
        Response.Redirect(String.Format("BrojSjedala.aspx?User={0}&Date=1.10.2019.&Time=18:30", Request.QueryString["User"]));
    }
    protected void rezervirajTermin(object sender, EventArgs e)
    {
        Response.Redirect(String.Format("BrojSjedala.aspx?User={0}&Date=30.9.2019.&Time=17:30", Request.QueryString["User"]));
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {//biramo datume u toj metodi
        String date = Calendar1.SelectedDate.ToShortDateString();
       
        if (date.Equals("30.9.2019."))
        {
            Panel2.Controls.Clear();
            Button button = new Button();
            Label1.Text = "Vrijeme početka filma";
            button.Text = "17:30";
            button.ID = "button1";
            button.Click += new System.EventHandler(rezervirajTermin);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(button);
            
            
            
        }
        else if (date.Equals("1.10.2019."))
        {
            Panel2.Controls.Clear();
            Button button = new Button();
            Label1.Text = "Vrijeme početka filma";
            button.Text = "18:30";
            button.ID = "button1";
            button.Click += new System.EventHandler(rezervirajTerminDrugi);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(button);


            
        }
        else if (date.Equals("2.10.2019."))
        {
            Panel2.Controls.Clear();
            Button button = new Button();
            Label1.Text = "Vrijeme početka filma";
            button.Text = "19:30";
            button.ID = "button1";
            button.Click += new System.EventHandler(rezervirajTerminDrugi);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(button);



        }
        
        else
        {
            Panel2.Controls.Clear();
        }

        
        
    }


    protected void Odjava_Click(object sender, EventArgs e)
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

        Session.Abandon();
        Response.Redirect("Prijava.aspx");
    }
}