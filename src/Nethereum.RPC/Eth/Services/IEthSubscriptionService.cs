using Nethereum.RPC.Eth.Subscriptions;

namespace Nethereum.RPC.Eth.Services
{
    public interface IEthSubscriptionService
    {
        EthNewBlockHeadersSubscription NewBlockHeadersSubscription { get; }
        EthNewPendingTransactionSubscription NewPendingTransactionSubscription { get; }
    }
}