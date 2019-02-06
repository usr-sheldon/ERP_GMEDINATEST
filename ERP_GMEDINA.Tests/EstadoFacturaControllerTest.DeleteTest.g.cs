using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Inspinia_MVC5_SeedProject.Controllers;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Inspinia_MVC5_SeedProject.Controllers.Tests
{
    public partial class EstadoFacturaControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(EstadoFacturaControllerTest))]
public void EstadoFactura_DeleteTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      EstadoFacturaController estadoFacturaController;
      ActionResult actionResult;
      estadoFacturaController = EstadoFacturaControllerFactory.Create
                                    ((IDependencyResolver)null, (IActionInvoker)null, 
                                     (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                                     (ControllerContext)null, (TempDataDictionary)null, 
                                     false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)estadoFacturaController);
      actionResult = this.DeleteTest(estadoFacturaController, default(byte?));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)estadoFacturaController);
      Assert.IsNotNull(((Controller)estadoFacturaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)estadoFacturaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull
          (((Controller)estadoFacturaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)estadoFacturaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)estadoFacturaController).Url);
      Assert.IsNull(((ControllerBase)estadoFacturaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)estadoFacturaController).ValidateRequest);
    }
}
    }
}
