using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Study.Web.Views
{
    public abstract class StudyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected StudyRazorPage()
        {
            LocalizationSourceName = StudyConsts.LocalizationSourceName;
        }
    }
}
