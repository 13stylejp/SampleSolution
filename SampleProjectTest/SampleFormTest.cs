using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject;
using NUnit.Framework;

namespace SampleProjectTest
{
    [TestFixture]
    public class SampleFormTest
    {
        SampleForm target = new SampleForm();
        [Test]
        public void テストケース01()
        {
            int ret = 0;

            ret = target.Add(3, 2);

            Assert.AreEqual(ret, 1);

        }

        [Test]
        public void テストケース02()
        {
            int ret = 0;

            ret = target.Add(2, 2);

            Assert.AreEqual(ret, 0);

        }

        [Test]
        public void テストケース03()
        {
            object obj = new object();
            EventArgs e = new EventArgs();

            target.button1_Click(obj, e);
        }
    }
}
