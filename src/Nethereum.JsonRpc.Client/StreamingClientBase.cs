#if !DOTNET35
using System;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client.RpcMessages;

namespace Nethereum.JsonRpc.Client
{
    public abstract class StreamingClientBase : ClientBase, IStreamingClient
    {
        public event EventHandler<RpcStreamingResponseMessageEventArgs> StreamingMessageReceived;

        public event EventHandler<RpcResponseMessageEventArgs> MessageReceived;

        public event EventHandler<RpcResponseErrorMessageEventArgs> Error;

        protected virtual void OnMessageRecieved(object sender, RpcResponseMessageEventArgs args)
        {
            var handler = MessageReceived;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        protected virtual void OnStreamingMessageRecieved(object sender, RpcStreamingResponseMessageEventArgs args)
        {
            var handler = StreamingMessageReceived;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        protected virtual void OnError(object sender, RpcResponseErrorMessageEventArgs args)
        {
            var handler = Error;
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }
}
#endif