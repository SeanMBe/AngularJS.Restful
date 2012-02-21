namespace ECommerce.WCF.Restful.Test
{
    public interface IAutoMockingContainer<TSubject>
        where TSubject : class
    {
        TSubject Create();
        TMock GetMock<TMock>() where TMock : class;
        TStub GetStub<TStub>() where TStub : class;
    }
}