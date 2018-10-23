using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TetrisMobKata.Test
{
    [TestClass]
    public class BoardTest
    {
        private Board _sut;
        [TestInitialize]
        public void InitSut()
        {
            _sut = new Board()
            {
                Width = 10,
                Height = 24
            };
        }

        [TestMethod]
        public void BoardShouldHaveWidth()
        {
            Assert.IsTrue(_sut.Width>=0);
        }
        [TestMethod]
        public void BoardShouldHaveHeigth()
        {
            Assert.IsTrue(_sut.Height >= 0);
        }
    }
}
