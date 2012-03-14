using System.Collections.Generic;
using NServiceBus;

namespace Publisher
{
    public class SubscriptionAuthorizer : IAuthorizeSubscriptions
    {
        #region IAuthorizeSubscriptions Members

        public bool AuthorizeSubscribe(string messageType, string clientEndpoint, string clientWindowsIdentity,
                                       IDictionary<string, string> headers)
        {
            return true;
        }

        public bool AuthorizeUnsubscribe(string messageType, string clientEndpoint, string clientWindowsIdentity,
                                         IDictionary<string, string> headers)
        {
            return true;
        }

        #endregion

        public bool AuthorizeSubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
        {
            return true;
        }

        public bool AuthorizeUnsubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
        {
            return true;
        }
    }
}