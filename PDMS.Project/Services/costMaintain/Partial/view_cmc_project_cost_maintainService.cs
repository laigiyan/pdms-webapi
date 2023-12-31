/*
 *所有关于view_cmc_project_cost_maintain类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*view_cmc_project_cost_maintainService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using PDMS.Core.BaseProvider;
using PDMS.Core.Extensions.AutofacManager;
using PDMS.Entity.DomainModels;
using System.Linq;
using PDMS.Core.Utilities;
using System.Linq.Expressions;
using PDMS.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using PDMS.Project.IRepositories;
using PDMS.Core.ManageUser;
using Microsoft.VisualBasic;
using PDMS.Core.DBManager;
using PDMS.WorkFlow.Services;

namespace PDMS.Project.Services
{
    public partial class view_cmc_project_cost_maintainService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly Iview_cmc_project_cost_maintainRepository _repository;//访问数据库


        WebResponseContent webContent=new WebResponseContent();

        [ActivatorUtilitiesConstructor]
        public view_cmc_project_cost_maintainService(
            Iview_cmc_project_cost_maintainRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        public override PageGridData<view_cmc_project_cost_maintain> GetPageData(PageDataOptions options)
        {
            string project_id = "";
            string upg_id = "";
            string part_no = "";
            string part_name = "";
            string fs_approve_status = "";
            string path = "";
            string project_status = "";
           
            string where = " ";
            UserInfo userInfo = UserContext.Current.UserInfo;
             int userId = userInfo.User_Id;
            string dept_code = userInfo.DepartmentCode;
            List<SearchParameters> searchParametersList = new List<SearchParameters>();
            if (!string.IsNullOrEmpty(options.Wheres))
            {
                searchParametersList = options.Wheres.DeserializeObject<List<SearchParameters>>();
                if (searchParametersList != null && searchParametersList.Count > 0)
                {
                    foreach (SearchParameters sp in searchParametersList)
                    {
                        if (sp.Name.ToLower() == "project_id".ToLower())
                        {
                            project_id = sp.Value;
                            if (!string.IsNullOrEmpty(project_id))
                            {
                                where += " and epl.project_id='" + project_id + "'";
                            }
                            continue;
                        }
                        if (sp.Name.ToLower() == "upg_id".ToLower())
                        {
                            upg_id = sp.Value;
                            if (!string.IsNullOrEmpty(upg_id))
                            {
                                where += " and epl.upg_id like '%" + upg_id + "%'";
                            }
                            continue;
                        }
                        if (sp.Name.ToLower() == "part_no".ToLower())
                        {
                            part_no = sp.Value;
                            if (!string.IsNullOrEmpty(part_no))
                            {
                                where += " and epl.part_no like '%" + part_no + "%'";
                            }
                            continue;
                        }
                        if (sp.Name.ToLower() == "part_name".ToLower())
                        {
                            part_name = sp.Value;
                            if (!string.IsNullOrEmpty(part_name))
                            {
                                where += " and epl.part_name like '%" + part_name + "%'";
                            }
                            continue;
                        }
                        if (sp.Name.ToLower() == "fs_approve_status".ToLower())
                        {
                            fs_approve_status = sp.Value;
                            if (!string.IsNullOrEmpty(fs_approve_status))
                            {
                                where += " and epl.fs_approve_status='" + fs_approve_status + "'";
                            }
                            continue;
                        }
                        if (sp.Name.ToLower() == "project_status".ToLower())
                        {
                            project_status = sp.Value;
                            continue;
                        }
                        if (sp.Name.ToLower() == "path".ToLower())
                        {
                            path = sp.Value;
                            continue;
                        }
                    }
                }
            }

            QuerySql = @" select epl.* ,'' as version,main.eo_fee  from cmc_pdms_project_epl epl
                                    left join cmc_pdms_project_main main on main.project_id=epl.project_id
	                               where 1=1
	                                    and kd_type like 'D*%' 
	                                    and Final_version_status='2' and action_type!='delete'";

            if (project_status == "01")
            {
                where += " and  epl_phase='01'";
            }
            else
            {
                where += " and  epl_phase='02'  " ;
            }

            if (path.ToLower() == "/view_cmc_project_group_cost")
            {
                where += " and epl.group_code='"+dept_code+"'";
            }
            else
            {
                where += " and  dev_taker_id= " + userId;
            }
           
             QuerySql += where;
            
            return base.GetPageData(options);
        }

        public override WebResponseContent Update(SaveModel saveModel)
        {//FS成本編列保存
            return cmc_pdms_project_eplService.Instance.updateCost(saveModel);
        }

        /// <summary>
        /// 成本編列確認
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public WebResponseContent costConfirm(SaveModel saveModel)
        {
            var MainDatas = saveModel.MainDatas;
            List<cmc_pdms_project_epl> costList = new List<cmc_pdms_project_epl>();
            //存取提交審批的數據
            List<Dictionary<string, object>> approveDatras = new List<Dictionary<string, object>>();
            SaveModel ModelOne = new SaveModel();
            if (MainDatas.Count != 0)
            {
                try
                {
                    foreach (var item in MainDatas) {
                        cmc_pdms_project_epl cost = new cmc_pdms_project_epl();
                        cost = repository.DbContext.Set<cmc_pdms_project_epl>().Where(x => x.epl_id == Guid.Parse(item["epl_id"].ToString())).FirstOrDefault();
                        if (cost != null) {
                            cost.fs_approve_status = "01";
                            costList.Add(cost);

                            //添加到審批表
                            approveDatras.Add(item);
                        }
                    }




                
                }
                catch (Exception ex) {
                    Core.Services.Logger.Error(Core.Enums.LoggerType.Error, "批量修改前装箱 cmc_pdms_project_epl 表，view_cmc_project_cost_maintainServiceService 文件-->UpdateRange：" + DateTime.Now + ":" + ex.Message);
                    return webContent.Error();
                }

                try
                {
                    if (costList.Count>0) {//更新數據
                        repository.DapperContext.BeginTransaction((r) =>
                        {
                            DBServerProvider.SqlDapper.UpdateRange(costList, x => new { x.fs_approve_status });
                            return true;
                        }, (ex) => { throw new Exception(ex.Message); });
                    }

                }
                catch (Exception ex)
                {
                    Core.Services.Logger.Error(Core.Enums.LoggerType.Error, "批量修改執行 cmc_pdms_project_epl 表，view_cmc_project_cost_maintainServiceService 文件-->UpdateRange：" + DateTime.Now + ":" + ex.Message);

                    return webContent.Error();
                }

                if (approveDatras.Count > 0)
                {//成本編列確認後，做審核流程
                    ModelOne.MainData = saveModel.MainDatas[0];
                    ModelOne.MainDatas = approveDatras;
                    webContent = cmc_pdms_wf_masterService.Instance.MasterUpdate(ModelOne, "01", "02", null);
                }

            }
            return webContent.OK();
            /* string epls = string.Join("','", keys);
             string sql = $@"update cmc_pdms_project_epl set fs_approve_status='01' where epl_id in ('{epls}')";
             try
             {
                 var count3 = repository.DapperContext.ExcuteNonQuery(sql, null);
             }
             catch (Exception ex)
             {

                 Core.Services.Logger.Error(Core.Enums.LoggerType.Error, "開發清冊成本編列確認，view_cmc_project_cost_maintainService 文件：costConfirm：" + DateTime.Now + ":" + ex.Message);
                 return webContent.Error();
             }*/
            //todo寫入審批流程表 cmc_pdms_wf_master和cmc_pdms_wf_epl_fs


        }
    }
}
