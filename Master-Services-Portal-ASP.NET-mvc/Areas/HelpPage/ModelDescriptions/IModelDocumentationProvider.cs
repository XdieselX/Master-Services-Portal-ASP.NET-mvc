using System;
using System.Reflection;

namespace Master_Services_Portal_ASP.NET_mvc.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}