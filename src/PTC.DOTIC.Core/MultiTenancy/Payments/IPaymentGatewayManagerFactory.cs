using Abp.Dependency;

namespace PTC.DOTIC.MultiTenancy.Payments
{
    public interface IPaymentGatewayManagerFactory
    {
        IDisposableDependencyObjectWrapper<IPaymentGatewayManager> Create(SubscriptionPaymentGatewayType gateway);
    }
}