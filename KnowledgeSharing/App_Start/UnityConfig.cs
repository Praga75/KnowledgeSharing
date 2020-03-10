using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;
using Unity.Mvc5;
using KnowledgeSharing.ServiceLayer;
namespace KnowledgeSharing
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IQuestionsService, QuestionsService>();
            container.RegisterType<IUsersService, UserService>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}