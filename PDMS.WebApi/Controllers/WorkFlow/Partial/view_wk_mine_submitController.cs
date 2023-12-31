/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("view_wk_mine_submit",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using PDMS.Entity.DomainModels;
using PDMS.WorkFlow.IServices;
using PDMS.Core.Filters;
using PDMS.Core.Utilities;

namespace PDMS.WorkFlow.Controllers
{
    public partial class view_wk_mine_submitController
    {
        private readonly Iview_wk_mine_submitService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public view_wk_mine_submitController(
            Iview_wk_mine_submitService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        //提交功能
        [ApiActionPermission()]
        [HttpPost, Route("callBack")]
        public WebResponseContent callBack([FromBody] SaveModel saveModel)
        {
            return Service.callBack(saveModel);
        }
    }
}
