using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using BoilerSupplier.CrossCutting;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;




namespace BoilerSupplier.Repository
{
    
    internal class Repository<TDomainObject>
    {
        //private IConfiguration _config;
        //protected readonly string DbConnection;

        //public Repository(IConfiguration config)
        //{
        //    _config = config;

        //    DbConnection = _config.GetSection("ConnectionStrings").GetSection("DbConnection").Value;
          
        //}


        public Repository() { }

        public IConfiguration Configuration { get; }


        
        /// <summary>
        /// Read-Only property to get database connection string
        /// </summary>
        private string ConnectionString
        {
            get
            {
                //return DbConnection;
                //var DbConnection=_config.GetSection("ConnectionStrings").GetSection("DbConnection").Value;
                //return Configuration.GetConnectionString("BoilerSupplierConnection");
                //return "Data Source=103.233.79.87;Initial Catalog=acqmain;User ID=sa;Password=Beedu@123;";
                return "Data Source=.;Initial Catalog=BoilerSourcing;User ID=sa;Password=Boiler@123456;";
               //return "Data Source=.;Initial Catalog=BoilerSourcingDemo;User ID=sa;Password=Boiler@2018;";
            }
        }

        public List<TProperty> GetAll<TIdentity, TProperty>(
            ISelectionFactory<TIdentity> selectionFactory,
            IDomainObjectFactory<TProperty> domainObjectFactory,
            TIdentity identity)
        {
            List<TProperty> results = new List<TProperty>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (IDbCommand command = selectionFactory.ConstructSelectCommand(identity))
                {
                    command.Connection = connection;
                    command.CommandTimeout = 3600;
                    using (IDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            results.Add(domainObjectFactory.Construct(dataReader));
                        }
                    }
                }
            }
            return results;
        }

        public TProperty GetValue<TIdentity, TProperty>(
            ISelectionFactory<TIdentity> selectionFactory,
            IDomainObjectFactory<TProperty> domainObjectFactory,
            TIdentity identity)
        {
            TProperty result = default(TProperty);
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                using (IDbCommand command = selectionFactory.ConstructSelectCommand(identity))
                {
                    command.Connection = sqlConnection;
                    command.CommandTimeout = 3600;
                    using (IDataReader rdr = command.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            result = domainObjectFactory.Construct(rdr);
                        }
                    }
                }
            }
            return result;
        }

        //public void Save<TIdentity>(IUpdateFactory<TIdentity> updateFactory, TIdentity identity)
        //{
        //    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
        //    {
        //        sqlConnection.Open();
        //        using (IDbCommand command = updateFactory.ConstructUpdateCommand(identity))
        //        {
        //            command.Connection = sqlConnection;
        //            command.CommandTimeout = 3600;
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public TDomainObject Update<TIdentity, TDomainObject>(
        //    IUpdateFactory<TIdentity> updateFactory,
        //    IGetDomainObjectFactory<TDomainObject> domainObjectFactory,
        //    TIdentity identity)
        //{
        //    TDomainObject result = default(TDomainObject);
        //    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
        //    {
        //        sqlConnection.Open();
        //        using (IDbCommand command = updateFactory.ConstructUpdateCommand(identity))
        //        {
        //            command.Connection = sqlConnection;
        //            command.CommandTimeout = 3600;
        //            command.ExecuteNonQuery();
        //            result = domainObjectFactory.Update(command);
        //        }
        //    }
        //    return result;
        //}
    }
}
