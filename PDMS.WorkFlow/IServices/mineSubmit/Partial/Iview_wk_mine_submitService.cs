/*
*所有关于view_wk_mine_submit类的业务代码接口应在此处编写
*/
using PDMS.Core.BaseProvider;
using PDMS.Entity.DomainModels;
using PDMS.Core.Utilities;
using System.Linq.Expressions;
namespace PDMS.WorkFlow.IServices
{
    public partial interface Iview_wk_mine_submitService
    {

        public WebResponseContent callBack(SaveModel saveModel);
    }
 }
