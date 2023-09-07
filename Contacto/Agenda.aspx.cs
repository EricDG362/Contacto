using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contacto
{
    public partial class Agenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath(".") + "/Agenda.txt")) //si existe tal archivo, entponces abrirlo
            {
                StreamReader SR = new StreamReader(Server.MapPath(".") + "/Agenda.txt"); //creamos objeto
               String [] contacto = (SR.ReadToEnd()).Split('\n'); //split es un separador
                SR.Close();
                Label1.Text = "<hr>";
                int count = 0;


                foreach (String line in contacto) {
                    count++;

                    if (count % 4 == 0)
                    {
                        Label1.Text += $"{line} <br/>";
                        Label1.Text += "<hr>";
                    }
                    else
                    {
                        Label1.Text += $"{line} <br/>";

                    }
                }
               


            }
            else
            {
                Label1.Text = "No hay Datos";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }
    }
}