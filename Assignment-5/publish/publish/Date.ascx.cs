﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace publish
{
    public partial class Date : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToLongDateString();
            String time = DateTime.Now.ToLongTimeString();
            this.lblDate.Text = date + ", " + time;
        }
    }
}