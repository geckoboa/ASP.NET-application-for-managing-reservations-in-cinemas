using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Redirect metodama preusmjeravamo korisnika na drugo web mjesto, u ovom slučaju Podaci.aspx i Prijava.aspx
    protected void Podaci_Click(object sender, EventArgs e)
    {
        Response.Redirect("Podaci.aspx");
    }

    protected void Rezervacija_Click(object sender, EventArgs e)
    {
        Response.Redirect("Prijava.aspx");
    }

    protected void ButtonSlike_Click(object sender, EventArgs e)
    {
        Response.Redirect("Slike.aspx");
    }
}