using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="NotaCreditoControllerTest._IndexDevolucionTest.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;
using ERP_ZORZAL.Controllers;

namespace ERP_GMEDINA.Controllers.Tests
{
    public partial class NotaCreditoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(NotaCreditoControllerTest))]
public void _IndexDevolucionTest960()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      NotaCreditoController notaCreditoController;
      ActionResult actionResult;
      notaCreditoController = new NotaCreditoController();
      ((Controller)notaCreditoController).Resolver = (IDependencyResolver)null;
      ((Controller)notaCreditoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)notaCreditoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)notaCreditoController).Url = (UrlHelper)null;
      ((Controller)notaCreditoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)notaCreditoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)notaCreditoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)notaCreditoController).ValidateRequest = false;
      ((ControllerBase)notaCreditoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)notaCreditoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)notaCreditoController);
      actionResult = this._IndexDevolucionTest(notaCreditoController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)notaCreditoController);
      Assert.IsNotNull(((Controller)notaCreditoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)notaCreditoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)notaCreditoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)notaCreditoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)notaCreditoController).Url);
      Assert.IsNull(((ControllerBase)notaCreditoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)notaCreditoController).ValidateRequest);
    }
}
    }
}
