using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication1
{
    public partial class MultiColumn : System.Web.UI.Page
    {
        protected void gridLookup_Init(object sender, EventArgs e)
        {
            gridLookup.GridView.Width = 500;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            gridLookup.DataSource = Contact.GetContacts();

            gridLookup.DataBind();
        }


    }
}