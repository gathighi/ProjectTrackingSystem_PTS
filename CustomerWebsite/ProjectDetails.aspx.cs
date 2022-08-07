using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerWebsite.customerwebservice;

namespace CustomerWebsite
{
    public partial class ProjectDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ShowProjectDetails()
        {
            if (Session["id"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                PTSCustomerWebService service = new PTSCustomerWebService();

                project[] projects = service.GetListOfProjects((int)Session["id"]);
             

                for (int i = 0; i < projects.Length; i++)
                {
                    project p = projects[i];
                    Response.Write("<p> project: <b>" + p.Name + "</b><br>");
                    task[] tasks = p.Tasks;
                    
                   /* for(int j=0; j< tasks.Length; j++)
                    {
                        task t = tasks[j];
                        Response.Write("task: <i>" + t.Name + " - " + t.theStatus + "</i><br>");
                         
                    }
                    Response.Write("</p>");
                   */
                }
            }
        }
    }
}