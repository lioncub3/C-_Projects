using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calc : System.Web.UI.Page
{
    static int a;
    static int b;
    protected void Page_Load(object sender, EventArgs e)
    {
        Chart1.DataSource = "";
    }

    public static string GetSum(HttpContext context)
    {
        return (a + b).ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);
    }
}