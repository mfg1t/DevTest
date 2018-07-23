using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThirdPartyTools.Tests
{
    [TestClass()]
    public class FileDetailsTests
    {
        [TestMethod()]
        public void VersionTest()
        {
            FileDetails fd = new FileDetails();
            fd.Version(@"c:\test.txt");
        }

        [TestMethod()]
        public void SizeTest()
        {
            FileDetails fd = new FileDetails();
            fd.Size(@"c:\test.txt");
        }
    }
}