using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="TipoPagoControllerTest.DetailsTest.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace ERP_ZORZAL.Controllers.Tests
{
    public partial class TipoPagoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TipoPagoControllerTest))]
public void DetailsTest296()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TipoPagoController tipoPagoController;
      ActionResult actionResult;
      tipoPagoController = new TipoPagoController();
      ((Controller)tipoPagoController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoPagoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoPagoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tipoPagoController).Url = (UrlHelper)null;
      ((Controller)tipoPagoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoPagoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)tipoPagoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoPagoController).ValidateRequest = false;
      ((ControllerBase)tipoPagoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tipoPagoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoPagoController);
      actionResult = this.DetailsTest(tipoPagoController, default(short?));
      disposables.Dispose();
      Assert.IsNotNull((object)tipoPagoController);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoPagoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoPagoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoPagoController).Url);
      Assert.IsNull(((ControllerBase)tipoPagoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoPagoController).ValidateRequest);
    }
}
    }
}
