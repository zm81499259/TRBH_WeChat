using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeChat.Bussiness.Repository;

namespace WeChat.Application.Library
{
    public partial class GeneralControl<TModel, IRepository>:Controller
         where TModel : class
        where IRepository : IGenericRepository<TModel>
    {
        /// <summary>
        /// 接口当前仓储
        /// </summary>
        public IRepository repository;

        /// <summary>
        /// 实例化仓储
        /// </summary>
        /// <param name="rep"></param>
        public GeneralControl(IRepository rep)
        {
            this.repository = rep;
        }
    }
}