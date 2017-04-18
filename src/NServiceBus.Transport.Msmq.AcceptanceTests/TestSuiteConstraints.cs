﻿namespace NServiceBus.AcceptanceTests
{
    using AcceptanceTesting.Support;

    public partial class TestSuiteConstraints
    {
        public bool SupportsDtc => true;
        public bool SupportsCrossQueueTransactions => true;
        public bool SupportsNativePubSub => false;
        public bool SupportsNativeDeferral => false;
        public bool SupportsOutbox => true;
        public IConfigureEndpointTestExecution TransportConfiguration { get; } = new ConfigureEndpointMsmqTransport();
        public IConfigureEndpointTestExecution PersistenceConfiguration { get; } = new ConfigureEndpointInMemoryPersistence();
    }
}