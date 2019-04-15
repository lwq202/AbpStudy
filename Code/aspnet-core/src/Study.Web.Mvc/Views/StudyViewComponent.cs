using Abp.AspNetCore.Mvc.ViewComponents;

namespace Study.Web.Views
{
    public abstract class StudyViewComponent : AbpViewComponent
    {
        protected StudyViewComponent()
        {
            LocalizationSourceName = StudyConsts.LocalizationSourceName;
        }
    }
}
