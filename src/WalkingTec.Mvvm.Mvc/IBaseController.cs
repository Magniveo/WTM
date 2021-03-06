using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Support.Json;

namespace WalkingTec.Mvvm.Mvc
{
    public interface IBaseController
    {
        Configs ConfigInfo { get; }
        GlobalData GlobaInfo { get; }
        string CurrentCS { get; set; }

        DBTypeEnum? CurrentDbType { get; set; }

        IDataContext DC { get; set; }
        LoginUserInfo LoginUserInfo { get; set; }

        IDistributedCache Cache { get; }

        string BaseUrl { get; set; }

        SimpleLog Log { get; set; }

        IDataContext CreateDC(bool isLog = false);
        [NonAction]
        JsonResult Json(object data, JsonSerializerSettings serializerSettings);

        ModelStateDictionary ModelState { get; }

        IStringLocalizer Localizer { get; }
    }
}
