using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Stud_Page : System.Web.UI.Page
{
    List<Student> students = new List<Student>();
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 0; i < 5; i++)
        {
            students.Add(new Student() { Id = i, Firstname = "Test " + i, Lastname = "Test " + i, Number = "0995555552 " + i, Email = "test@test.test", Img_url = "https://cloud.netlifyusercontent.com/assets/344dbf88-fdf9-42bb-adb4-46f01eedd629/242ce817-97a3-48fe-9acd-b1bf97930b01/09-posterization-opt.jpg" });
        }

        students.Add(new Student() { Id = 6, Firstname = "Vanya", Lastname = "test", Number = "911", Img_url = "none" });

        Repeater1.DataSource = students;
        Repeater1.DataBind();

        GridView1.DataSource = students;
        GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string email = (string)DataBinder.Eval(e.Row.DataItem, "Email");

            //if (email == null)
            //{
            //    e.Row.BackColor = Color.Red;
            //}

            //e.Row.BackColor = Color.Green;
        }
    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        int index = GridView1.SelectedIndex;

        int ID = (int)GridView1.SelectedDataKey.Values["Id"];

        //string firstname = (string)DataBinder.Eval(e.)
    }
}

public class Student
{
    private int id;
    private string firstname;
    private string lastname;
    private string number;
    private string email;
    private string img_url;

    public string Firstname { get => firstname; set => firstname = value; }
    public string Lastname { get => lastname; set => lastname = value; }
    public string Number { get => number; set => number = value; }
    public string Email { get => email; set => email = value; }
    public string Img_url { get => img_url; set => img_url = value; }
    public int Id { get => id; set => id = value; }
}