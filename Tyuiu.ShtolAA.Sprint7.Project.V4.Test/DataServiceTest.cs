using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtolAA.Sprint7.Project.V4.Lib;
using System.IO;
using Tyuiu.ShtolAA.Sprint7.Project.V4.Lib;
namespace Tyuiu.ShtolAA.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path =@"C:\Users\aleks\source\Biblioteka.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
