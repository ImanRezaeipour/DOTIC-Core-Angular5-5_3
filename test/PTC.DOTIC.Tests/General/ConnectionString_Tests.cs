using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace PTC.DOTIC.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=DOTIC; Trusted_Connection=True;");
            csb["Database"].ShouldBe("DOTIC");
        }
    }
}
