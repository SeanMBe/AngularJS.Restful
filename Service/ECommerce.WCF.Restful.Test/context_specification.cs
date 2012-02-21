using Machine.Specifications;

namespace ECommerce.WCF.Restful.Test
{
    public abstract class context_specification<TSubjectUnderTest>
        where TSubjectUnderTest : class
    {
        private static IAutoMockingContainer<TSubjectUnderTest> _autoMockingContainer;
        protected static TSubjectUnderTest Sut { get; set; }

        Establish context = () =>
                                {
                                    _autoMockingContainer = new StructureMapAMC<TSubjectUnderTest>();
                                    Sut = _autoMockingContainer.Create();
                                };

        Cleanup stuff = () =>
                            {
                                Sut = null;
                                _autoMockingContainer = null;
                            };

        protected static TDependency Dependency<TDependency>()
            where TDependency : class
        {
            return _autoMockingContainer.GetMock<TDependency>();
        }

        protected static TStub Stub<TStub>()
            where TStub : class
        {
            return _autoMockingContainer.GetStub<TStub>();
        }
    }
}