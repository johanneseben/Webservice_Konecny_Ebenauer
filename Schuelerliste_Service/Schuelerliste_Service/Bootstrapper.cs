namespace Api
{
    using Common.Models;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using Nancy;
    using Nancy.TinyIoc;
    using NHibernate;
    using NHibernate.Tool.hbm2ddl;
    using System;
    using Common;
    using Nancy.Bootstrapper;
    using Nancy.Authentication.Basic;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private readonly ISessionFactory _sessionFactory;

        public Bootstrapper()
        {
            _sessionFactory = CreateSessionFactory();

           
            var session = _sessionFactory.OpenSession();

            using (var tran = session.BeginTransaction())
            {
                try
                {
                   
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }


        }

        protected override void ApplicationStartup(TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            pipelines.EnableBasicAuthentication(new BasicAuthenticationConfiguration(container.Resolve<IUserValidator>(), "Projektname"));
        }

        protected override void ConfigureRequestContainer(TinyIoCContainer container, NancyContext context)
        {
            base.ConfigureRequestContainer(container, context);
            container.Register((c, o) => _sessionFactory.OpenSession());
        }

        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently
                .Configure()
                //.Database(MySQLConfiguration.Standard.ConnectionString("Server=[ServerIp]; Port=3306;Database=[Database]; Uid=[Username]; Pwd=[Password];"))
                .Database(MySQLConfiguration.Standard.ConnectionString("Server=127.0.0.1; Port=3306;Database=auftrag; Uid=root;"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Kunde>())
                //uncomment to update schema db 
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
              //uncoment to create schema db, each time the app is launched the db will be created
              //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
              .BuildSessionFactory();
        }
    }
}