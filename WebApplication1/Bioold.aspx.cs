using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Bio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MainContent.Text = Strings.biograpBul;
        }

        protected void aboutMe_Click(object sender, EventArgs e)
        {

        }
    }
}