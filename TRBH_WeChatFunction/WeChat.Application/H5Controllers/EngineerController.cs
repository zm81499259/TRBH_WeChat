using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeChat.Application.Library;
using WeChat.Bussiness.Repository;
using WeChat.Bussiness.RespositoryModel;

namespace WeChat.Application.H5Controllers
{
    /// <summary>
    /// 工程控制器
    /// </summary>
    [RoutePrefix("Engineer")]
    public class EngineerController : GeneralControl<CommonRequestModel, IEngineerRepository>
    {
        public EngineerController() : base(new EngineerRepository()) { }
        // GET: Engineer
        public ActionResult Index()
        {
            var model = new CommonRequestModel();
            var result = this.repository.GetEngineering(model);
            return View(result);
        }
    }
}