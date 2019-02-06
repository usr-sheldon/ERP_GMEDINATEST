using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for PedidoController</summary>
    [TestClass]
    [PexClass(typeof(PedidoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PedidoControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public PedidoController ConstructorTest()
        {
            PedidoController target = new PedidoController();
            return target;
            // TODO: add assertions to method PedidoControllerTest.ConstructorTest()
        }

    

        /// <summary>Test stub for EditPedido(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditPedidoTest([PexAssumeUnderTest]PedidoController target, int? id)
        {
            ActionResult result = target.EditPedido(id);
            return result;
            // TODO: add assertions to method PedidoControllerTest.EditPedidoTest(PedidoController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for EditPedido(Nullable`1&lt;Int32&gt;, tbPedido)</summary>
        [PexMethod]
        public ActionResult EditPedidoTest01(
            [PexAssumeUnderTest]PedidoController target,
            int? id,
            tbPedido tbPedido
        )
        {
            ActionResult result = target.EditPedido(id, tbPedido);
            return result;
            // TODO: add assertions to method PedidoControllerTest.EditPedidoTest01(PedidoController, Nullable`1<Int32>, tbPedido)
        }

        /// <summary>Test stub for Facturar(tbPedido)</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(NotImplementedException))]
        public ActionResult FacturarTest([PexAssumeUnderTest]PedidoController target, tbPedido Pedido)
        {
            ActionResult result = target.Facturar(Pedido);
            return result;
            // TODO: add assertions to method PedidoControllerTest.FacturarTest(PedidoController, tbPedido)
        }

        /// <summary>Test stub for GetDetallePedido(Int32)</summary>
        [PexMethod(MaxConstraintSolverTime = 2)]
        public JsonResult GetDetallePedidoTest([PexAssumeUnderTest]PedidoController target, int pedido)
        {
            JsonResult result = target.GetDetallePedido(pedido);
            return result;
            // TODO: add assertions to method PedidoControllerTest.GetDetallePedidoTest(PedidoController, Int32)
        }

        /// <summary>Test stub for GuardarPedidoDetalle(tbPedidoDetalle)</summary>
        [PexMethod]
        public JsonResult GuardarPedidoDetalleTest([PexAssumeUnderTest]PedidoController target, tbPedidoDetalle PedidoDetalles)
        {
            JsonResult result = target.GuardarPedidoDetalle(PedidoDetalles);
            return result;
            // TODO: add assertions to method PedidoControllerTest.GuardarPedidoDetalleTest(PedidoController, tbPedidoDetalle)
        }

     
        /// <summary>Test stub for IndexPedido()</summary>
        [PexMethod]
        public ActionResult IndexPedidoTest([PexAssumeUnderTest]PedidoController target)
        {
            ActionResult result = target.IndexPedido();
            return result;
            // TODO: add assertions to method PedidoControllerTest.IndexPedidoTest(PedidoController)
        }

        /// <summary>Test stub for getPedidoDetalle(Int32)</summary>
        [PexMethod(MaxConstraintSolverTime = 2)]
        public JsonResult getPedidoDetalleTest([PexAssumeUnderTest]PedidoController target, int pedd_Id)
        {
            JsonResult result = target.getPedidoDetalle(pedd_Id);
            return result;
            // TODO: add assertions to method PedidoControllerTest.getPedidoDetalleTest(PedidoController, Int32)
        }
    }
}
