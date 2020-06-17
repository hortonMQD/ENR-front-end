﻿using ENR_Bll;
using ENR_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENR_UI.asp.Reception
{
    public partial class BookInformation : System.Web.UI.Page
    {
        protected BookInfo info = new BookInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            BookService service = new BookService();
            info.Id = Request["bookID"];
            service.UpdataDownload(info);
            info = service.SelectBookWithParameter(info)[0];
        }
    }
}