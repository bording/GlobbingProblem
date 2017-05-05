using NServiceBus.AcceptanceTesting.Support;

namespace NServiceBus.AcceptanceTests
{
    public partial class TestSuiteConstraints : ITestSuiteConstraints
    {
        public bool SupportsDtc => true;

        public bool SupportsCrossQueueTransactions => true;

        public bool SupportsNativePubSub => true;

        public bool SupportsNativeDeferral => true;

        public bool SupportsOutbox => true;

        public IConfigureEndpointTestExecution CreatePersistenceConfiguration() => new ConfigureEndpointInMemoryPersistence();

        public IConfigureEndpointTestExecution CreateTransportConfiguration() => new ConfigureEndpointLearningTransport();
    }
}
