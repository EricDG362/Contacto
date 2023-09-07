using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contacto
{
    public partial class Carga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter st = new StreamWriter($"{Server.MapPath(".")}/Agenda.txt", true); //con true en vez de reemplazarlo lo agraga a un segundo contacto
            st.WriteLine(TextBox1.Text);
            st.WriteLine(TextBox2.Text);
            st.WriteLine(TextBox3.Text);
            st.WriteLine(TextBox4.Text);
            st.Close();

            Label4.Text = $"Datos Guardados en: {Server.MapPath(".")}.";




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }
    }
}