using System;

namespace NUnit
{
    // Basic Assertions
    using NUnit.Framework;
    public class BasicAssertionsExample 
    {
        private readonly Calculator _calculator = new Calculator();
        [Test]
        public void TestAddition() 
        {
            Assert.That(_calculator.Add(2, 2), Is.EqualTo(4));
            Assert.That(_calculator.Add(-1, 1), Is.Zero);
        }
    }

    // Collection Assertions
    using NUnit.Framework.Constraints;
    public class CollectionAssertionsExample 
    {
        private readonly List<int> _numbers = new List<int> { 1, 2, 3 };
        [Test]
        public void TestCollection() 
        {
            Assert.That(_numbers, Has.Member(2));
            Assert.That(_numbers, Is.Ordered);
        }
    }

    // Legacy Exception Handling
    using NUnit.Framework.Legacy;
    public class LegacyExceptionExample 
    {
        [Test]
        public void TestException() 
        {
            Assert.Throws(typeof(DivideByZeroException), () => Divide(1, 0));
            Assert.Catch<ArgumentException>(() => ProcessNegative(-1));
        }
    }

    // COM Interop Testing
    using NUnit.Framework.Internal;
    public class ComInteropExample 
    {
        [Test]
        public void TestComObject() 
        {
            dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
            Assert.That(excel, Is.Not.Null);
            Marshal.ReleaseComObject(excel);
        }
    }

    // Windows Forms Testing
    using NUnit.Framework.Internal.Commands;
    public class WinFormsExample 
    {
        private Form _testForm;
        [Test, STAThread]
        public void TestFormLoad() 
        {
            _testForm = new Form();
            Assert.That(_testForm.IsHandleCreated, Is.False);
            _testForm.Show();
            Assert.That(_testForm.IsHandleCreated, Is.True);
        }
    }

    // Registry Access Testing
    using NUnit.Framework.Internal.Execution;
    public class RegistryExample 
    {
        [Test]
        public void TestRegistryAccess() 
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software"))
            {
                Assert.That(key, Is.Not.Null);
            }
        }
    }

    // Legacy Database Testing
    using NUnit.Framework.Internal.Filters;
    public class LegacyDatabaseExample 
    {
        [Test]
        public void TestOleDbConnection() 
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=legacy.mdb"))
            {
                Assert.That(conn.State, Is.EqualTo(ConnectionState.Closed));
                conn.Open();
                Assert.That(conn.State, Is.EqualTo(ConnectionState.Open));
            }
        }
    }

    // ActiveX Control Testing
    using NUnit.Framework.Internal.Builders;
    public class ActiveXExample 
    {
        [Test]
        public void TestActiveXControl() 
        {
            Type axType = Type.GetTypeFromProgID("MSComCtl2.MonthView");
            Assert.That(axType, Is.Not.Null);
            dynamic ctrl = Activator.CreateInstance(axType);
            Assert.That(ctrl, Is.Not.Null);
        }
    }

    // Legacy XML Testing
    using NUnit.Framework.Interfaces;
    public class LegacyXmlExample 
    {
        [Test]
        public void TestXmlDataDocument() 
        {
            XmlDataDocument xmlDoc = new XmlDataDocument();
            DataSet ds = new DataSet();
            xmlDoc.DataSet = ds;
            Assert.That(xmlDoc.DataSet, Is.SameAs(ds));
        }
    }
}