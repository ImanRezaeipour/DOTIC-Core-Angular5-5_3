using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using PTC.DOTIC.Authorization.Users;
using PTC.DOTIC.MultiTenancy;

namespace PTC.DOTIC.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}