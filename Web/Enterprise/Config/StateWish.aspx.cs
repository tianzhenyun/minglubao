﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MLMGC.DataEntity.Enterprise;
using MLMGC.BLL.Enterprise;

namespace Web.Enterprise.Config
{
    public partial class StateWish : MLMGC.Security.EnterprisePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { databind(); }
        }

        protected void databind()
        {
            T_Wish bll = new T_Wish();
            rpList.DataSource = bll.GetList(new E_Wish() { EnterpriseID=EnterpriceID});
            rpList.DataBind();
        }
    }
}