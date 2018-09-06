using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace WeChat.Model.DataBaseModel
{
    public partial class ModelContext
    {
        public ModelContext()
               : base(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)
        {
        }
    }
}
