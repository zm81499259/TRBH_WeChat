using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Model.DataBaseModel;

namespace WeChat.Bussiness.Repository
{
    /// <summary>
    /// 公司仓储
    /// </summary>
    public interface ICompanyInformationRepository : IGenericRepository<WX_CompanyInoformation>
    {
        List<WX_CompanyInoformation> GetCompanyInformation();
    }
    public class CompanyInformationRepository:GenericRepository<WX_CompanyInoformation>, ICompanyInformationRepository
    {
        public CompanyInformationRepository():base()
        {

        }
        public CompanyInformationRepository(ModelContext context)
            :base(context)
        {

        }
        /// <summary>
        /// 获取全部公司信息
        /// </summary>
        /// <returns></returns>
        public List<WX_CompanyInoformation> GetCompanyInformation()
        {
            return this.Context.WX_CompanyInoformation.ToList();
        }
    }
}
