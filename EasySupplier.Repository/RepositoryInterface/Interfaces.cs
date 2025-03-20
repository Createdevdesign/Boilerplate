using System.Data;

namespace BoilerSupplier.Repository
{
    public interface ISelectionFactory<TIdentityObject>
    {
        IDbCommand ConstructSelectCommand(TIdentityObject idObject);
    }

    public interface IDomainObjectFactory<TDomainObject>
    {
        TDomainObject Construct(IDataReader reader);
    }

    public interface IDeleteFactory<TDomainObject>
    {
        IDbCommand ConstructDeleteCommand(TDomainObject domainObject);
    }

    public interface IGetDomainObjectFactory<TDomainObject>
    {
        TDomainObject Update(IDbCommand command);
    }

    public interface IInsertionFactory<TIdentityObject>
    {
        IDbCommand ConstructInsertCommand(TIdentityObject idObject);
    }

    public interface IUpdateFactory<TDomainObject>
    {
        IDbCommand ConstructUpdateCommand(TDomainObject domainObject);
    }
}
