using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikimediaDumpToolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikimediaDumpToolbox.Tests
{
    [TestClass()]
    public class PageReaderTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PageReaderWithEmptyPath()
        {
            var reader = new PageReader(path: "");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PageReaderWithEmptyXmlReader()
        {
            var reader = new PageReader(reader: null);
        }
    }
}