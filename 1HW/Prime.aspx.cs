using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 99;
            string result = "YES";
            if(a == 1)
            {
                Response.Write("NO");
            }else if (a == 2)
            {
                Response.Write("YES");
            }
            else
            {
                for (int i = 2; i <= 9; i++)
                {
                    if (a % i == 0)
                    {
                        result = "NO";
                        break;
                    }
                }
            }
            Response.Write(result);
            //if (check)
            //{
            //    
            //}
            //else
            //{
            //    Response.Write("YES");
            //}

        }
    }
}