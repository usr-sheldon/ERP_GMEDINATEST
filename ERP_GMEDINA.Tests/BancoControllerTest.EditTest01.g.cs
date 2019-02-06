using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ERP_ZORZAL.Controllers.Tests
{
    public partial class BancoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(BancoControllerTest))]
public void Banco_EditTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      BancoController bancoController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      bancoController = BancoControllerFactory.Create
                            ((IDependencyResolver)null, (IActionInvoker)null, 
                             (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                             s0, (TempDataDictionary)null, 
                             false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)bancoController);
      actionResult = this.EditTest01(bancoController, (tbBanco)null);
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)bancoController);
      Assert.IsNotNull(((Controller)bancoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)bancoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)bancoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)bancoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)bancoController).Url);
      Assert.IsNotNull(((ControllerBase)bancoController).ControllerContext);
      Assert.IsNull(((ControllerBase)bancoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)bancoController).ValidateRequest);
    }
}
    }
}
