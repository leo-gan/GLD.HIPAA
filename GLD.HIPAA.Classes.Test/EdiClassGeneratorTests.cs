using System.IO;
using System.Linq;
using GLD.HIPAA.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GLD.HIPAA.Classes.Test
{
    [TestClass]
    public class EdiClassGeneratorTests
    {
        private const string XsdFilePath = @"C:\Projects\GLD\HIPAA\GLD.HIPAA\GLD.HIPAA.Classes\XmlSchemas\";

        private const string ClassFilePath = @"C:\Projects\GLD\HIPAA\GLD.HIPAA\GLD.HIPAA.Classes\Classes\";
        private XsdParser _gen;

        [TestMethod]
        public void CreateClassFile()
        {
            const string className = @"X12_00501_835";

            CreateAFile(className);
        }

        /// <summary>
        /// To generate classes from Xsd schemas. If class existed, it will be recreated.
        /// </summary>
        [TestMethod]
        public void CreateAllClassFiles()
        {
            var files = Directory.EnumerateFiles(XsdFilePath);
            Assert.IsNotNull(files);

            foreach (var file in files.Select(Path.GetFileNameWithoutExtension))
                CreateAFile(file);
        }

        private void CreateAFile(string className)
        {
            _gen = new XsdParser(XsdFilePath + className + ".xsd");

            var generatedFileFullName = ClassFilePath + className + ".cs";
            if (File.Exists(generatedFileFullName))
                File.Delete(generatedFileFullName);
            //_gen.EdiNodeTree = new Node() {Name = "Name", IsOptional = true, Nodes = null, Segment = null};
            _gen.CreateClassFile(ClassFilePath, className);
            Assert.AreNotEqual(_gen.EdiDocument, null);
            Assert.IsTrue(File.Exists(generatedFileFullName));
        }
    }
}