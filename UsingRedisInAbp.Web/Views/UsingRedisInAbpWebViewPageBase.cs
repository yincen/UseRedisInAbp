using Abp.Web.Mvc.Views;

namespace UsingRedisInAbp.Web.Views
{
    public abstract class UsingRedisInAbpWebViewPageBase : UsingRedisInAbpWebViewPageBase<dynamic>
    {

    }

    public abstract class UsingRedisInAbpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected UsingRedisInAbpWebViewPageBase()
        {
            LocalizationSourceName = UsingRedisInAbpConsts.LocalizationSourceName;
        }
    }
}