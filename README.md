# ASP.NET-application-for-managing-reservations-in-cinemas

DateTime.aspx.cs: this site contains a Session object that saves informations for the user. If the session is empty, the user will be redirected to the site „Prijava.aspx“.
The page also contains a button calendar and when pressed, its saved as data input. „Page.IsPostBack“ is used for dynamic created controls.

Broj Sjedala.aspx.cs: this site contains a method where we get information related to the possibility of choosing the seat that is available, as well as his reservation. Page-Load what the page will do when created. This site also contains code that deletes "Cache" where the user no longer has access to the previous page after logging out, ie the page is remembered history.

Default.aspx.cs: this site contains methods that redirect the user to another website, and in this case "Data.aspx" "Login.aspx".

Prijava.aspx.cs: contains a button by which the user comes back to the initial site. The site contains a piece of code where the employee enters his username and password. Only the employee knows the username and password of his account. If the data read from the database is correct, Response.Redirect is done. If the data is incorrect, the specified message is displayed in red.

Registracija.aspx.cs: this site contains a piece of code that creates the user. With an if statement it is asked if a user exists in the database. If not, he is created.
