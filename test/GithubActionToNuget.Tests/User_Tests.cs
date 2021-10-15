using Shouldly;
using System;
using Xunit;

namespace GithubActionToNuget.Tests
{
    public class User_Tests
    {

        [Fact]
        public void GetUserName()
        {
            var userAppService = new UserAppService();
            var userName = userAppService.GetUserName("admin");

            userName.ShouldBe("admin");
        }
    }
}
