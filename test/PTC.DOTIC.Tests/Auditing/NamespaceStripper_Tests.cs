using PTC.DOTIC.Auditing;
using Shouldly;
using Xunit;

namespace PTC.DOTIC.Tests.Auditing
{
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("PTC.DOTIC.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("PTC.DOTIC.Auditing.GenericEntityService`1[[PTC.DOTIC.Storage.BinaryObject, PTC.DOTIC.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("PTC.DOTIC.Auditing.XEntityService`1[PTC.DOTIC.Auditing.AService`5[[PTC.DOTIC.Storage.BinaryObject, PTC.DOTIC.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[PTC.DOTIC.Storage.TestObject, PTC.DOTIC.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
