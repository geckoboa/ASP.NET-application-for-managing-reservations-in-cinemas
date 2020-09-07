using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;



public partial class Podaci : System.Web.UI.Page
{
    
    //U kontrolu Label spremamo opis za svaki film koji se prikazuje
    protected void Page_Load(object sender, EventArgs e)
    {
        

        Label4.Text= "Osvetnici su se izvorno sastojali od Iron Mana (Tony Stark), Ant-Mana (dr. Henry Pym), Ose (Janet Van Dyne), Thora i Hulka (Bruce Banner).<br> Ubrzo im se pridružio i Kapetan Amerika nakon što je pronađen zaleđen na sjevernom Atlantiku.<br> Spisak članova se iz godine u godinu mijenjao, u grupi su se, između ostalog, nalazili ljudi, mutanti, roboti, izvanzemaljci, pa čak i bivši zlikovci.";
        Label6.Text = "Nakon događaja u četvrtom dijelu serijala, u kojem Dominica prevoze u zatvor, Mia i Brian predvode napad na autobus koji se prevrće na putu i Dominic bježi.<br> Dok ih vlasti traže njih troje bježe u Rio de Janeiro.<br> Čekajući Doma, Mia i Brian se pridružuju Vinceu koji za njih ima poslovni prijedlog. Posao je krađa tri auta iz voza.";
        Label8.Text = "U veljači 1969. holivudski glumac Rick Dalton, bivša zvijezda zapadne televizijske serije 1950-ih Bounty Law, boji se da je njegova karijera gotova.<br> Kasting agent Marvin Schwarz savjetuje mu da napravi špagete vesterne, za koje Dalton smatra da su ispod njega.<br> Brandy - vozi Dalton po gradu jer je Daltonov visoko funkcionirajući alkoholizam doveo do previše DUI-a.<br> Booth se bori da pronađe filmski rad od smrti supruge, za koju se priča da je ubio.";


    }

    protected void Pocetna_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }



    protected void Rezerviraj_Click(object sender, EventArgs e)
    {
        Response.Redirect("Prijava.aspx");
    }

    protected void Rezerviraj1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Prijava.aspx");
    }

    protected void Rezerviraj2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Prijava.aspx");
    }
}