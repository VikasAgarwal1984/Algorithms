using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Test
{
    [TestClass]
    public class ArmstrongTest
    {
        [TestMethod]
        public void Basic()
        {
            ISolve<List<int>> arm = new Armstrong();
            var result = arm.Solve();
            Assert.AreEqual(result.Count, 100);
        }
    }
}
