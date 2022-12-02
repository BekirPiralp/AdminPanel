using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdminPanel.WebAPI.Controllers.Settled.Ybs_Filo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminPanel.WebAPI.Controllers.Base.Tests;
using AdminPanel.EntityLayer.Concrete.Other.Ybs_Filo;
using AdminPanle.BusinessLayer.Abstract.Other.Ybs_Filo;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using AdminPanel.AppSettings;
using AdminPanel.WebAPI.Extension;

namespace AdminPanel.WebAPI.Controllers.Settled.Ybs_Filo.Tests
{
    [TestClass()]
    public class YBSControllerTests:BaseControllerTests<YBSController, IBusGetTemp, TEMP_SOSYALYARDIM3>
    {
        [AssemblyInitialize]
        public static void Asembly (TestContext context)
        {
            test();
        }

        [TestInitialize]
        public  void Kurulum()
        {
            this.Kur();
        }

        //[TestMethod]
        //public async Task tstt()
        //{
        //    await Task.Delay(10);
        //    Assert.AreEqual(1,1);
        //}
    }
}