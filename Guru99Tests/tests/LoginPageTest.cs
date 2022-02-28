using CommonLibs.Implementation;
using NUnit.Framework;

namespace Guru99Tests
{
    public class LoginPageTest
    {
                [Test]
        public void Test1()


        {
            CommonDriver CmDriver = new CommonDriver("chrome");

            CmDriver.NavigateToFirstURL("https://subdstore-replica.vercel.app");
        }
    }
}


