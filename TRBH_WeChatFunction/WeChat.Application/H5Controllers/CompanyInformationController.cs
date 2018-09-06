using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeChat.Application.Library;
using WeChat.Bussiness.Repository;
using WeChat.Model.DataBaseModel;

namespace WeChat.Application.H5Controllers
{
    [RoutePrefix("CompanyInformation")]
    public class CompanyInformationController :GeneralControl<WX_CompanyInoformation, ICompanyInformationRepository>
    {
        public CompanyInformationController() : base(new CompanyInformationRepository()) { }

        // GET: CompanyInformation
        public ActionResult Index()
        {
            var result = this.repository.GetCompanyInformation();
            return View(result);
        }
    }
}