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
    public partial class PedidoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(PedidoControllerTest))]
[ExpectedException(typeof(NullReferenceException))]
public void PedidosPorFacturar_FacturarTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      PedidoController pedidoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      pedidoController = PedidoControllerFactory.Create
                             ((IDependencyResolver)null, (IActionInvoker)null, 
                              (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                              s0, (TempDataDictionary)null, 
                              false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)pedidoController);
      actionResult = this.FacturarTest(pedidoController, (tbPedido)null);
      disposables.Dispose();
    }
}
    }
}
