﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PDMS.Core.Controllers.Basic;
using PDMS.Core.Extensions;
using PDMS.Core.Filters;
using PDMS.System.IServices;

namespace PDMS.System.Controllers
{
    [Route("api/Sys_Dictionary")]
    public partial class Sys_DictionaryController : ApiBaseController<ISys_DictionaryService>
    {
        public Sys_DictionaryController(ISys_DictionaryService service)
        : base("System", "System", "Sys_Dictionary", service)
        {
        }
    }
}
