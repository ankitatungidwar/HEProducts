//using Autofac;
//using Autofac.Integration.Mvc;
//using HEProducts.Core.Contracts;
//using HEProducts.Core.Model;
//using HEProducts.DataAccess.InMemory;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace HEProducts.WebUI.App_Start
//{
//    public class ContainerConfig : Controller
//    {
//        internal static void RegisterContainer()
//        {
//            var builder = new ContainerBuilder();

//            builder.RegisterControllers(typeof(HEProducts.WebUI.MvcApplication).Assembly);
//            /*  builder.RegisterApiControllers(typeof(MvcApplication).Assembly);*/
//            /*  builder.RegisterType<InMemoryRestaurantData>()
//                     .As<IRestaurantData>()
//                     .SingleInstance();*/

//            builder.RegisterType<InMemoryRepository<BaseEntity>>()
//                   .As<IRepository<BaseEntity>>().SingleInstance();
//            /* .InstancePerRequest();//everytime we make request--bdcontext should create bcoz dbcontext talk with sqldb
//      builder.RegisterType<MyRestaurantDBContext>().InstancePerRequest();*/

//            var container = builder.Build();

//            System.Web.Mvc.DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

//            /*  httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);*/
//            // GET: ContainerConfig
//            /*      public ActionResult Index()
//              {
//                  return View();
//              }*/
//        }
//    }
//}