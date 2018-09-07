using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Bussiness.RespositoryModel;
using WeChat.Model.DataBaseModel;

namespace WeChat.Bussiness.Repository
{
    /// <summary>
    /// 工程仓储
    /// </summary>
    public interface IEngineerRepository:IGenericRepository<CommonRequestModel>
    {
        /// <summary>
        /// 获取工程数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<WX_Engineering> GetEngineering(CommonRequestModel model);
    }
    /// <summary>
    /// 工程仓储
    /// </summary>
    public class EngineerRepository: GenericRepository<CommonRequestModel>,IEngineerRepository
    {
        public EngineerRepository() : base()
        {

        }
        public EngineerRepository(ModelContext context)
            :base(context)
        {

        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<WX_Engineering> GetEngineering(CommonRequestModel model)
        {
            if(model!=null)
            {
                var startTime = DateTime.Now;
                if(model.StartTime==null)
                {
                    model.StartTime =new DateTime(startTime.Year,startTime.Month,1,0,0,0);
                }
                if(model.EndTime==null)
                {
                    startTime = new DateTime(startTime.Year, startTime.Month, 1,23,59,59);
                    model.EndTime = startTime.AddMonths(1).AddDays(-1);
                }
                var result = this.Context.WX_Engineering.Where(x => x.CreateDate >= model.StartTime && x.CreateDate <= model.EndTime).ToList();
                return result;
            }
            return null;
        }
    }
}
