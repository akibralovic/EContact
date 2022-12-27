namespace EContactTest
{
    [TestClass]
    public class EContactTest
    {
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                WindowsFormsApp1.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }


    }
}