using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest() //Expected pass
        {
            FileData.Program.Main(new string[] { "-v", "c:\test.txt" });
        }

        [TestMethod()]
        public void TestFileDataVersionChecker() //Tests the extension version checker
        {
            string input = "-v";
            FileData.Extensions.fdVersionCheck(input);
        }

        [TestMethod()]
        public void TestFileDataSizeChecker() //Tests the extension size checker
        {
            string input = "-s";
            FileData.Extensions.fdSizeCheck(input);
        }
    }
}