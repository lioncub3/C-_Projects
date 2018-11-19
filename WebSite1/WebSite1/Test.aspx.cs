using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    List<Student> students = new List<Student>();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
}

public class Student
{
    private string firstName;
    public string FirstName { get => firstName; set => firstName = value; }

    private string lastName;

    public string LastName { get => lastName; set => lastName = value; }
}