using Common.Models;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace Common.Services
{
    public class KlasseService : BaseService
    {
        public KlasseService(Func<ISession> session)
            : base(session)
        {
        }

        public IList<Klasse> Get()
        {
            return CurrentSession.CreateCriteria(typeof(Klasse)).List<Klasse>();
        }

        public Klasse Get(int id)
        {
            return CurrentSession.Get<Klasse>(id);
        }


        /*public IList<Kunde> GetByKunde(int KundeID)
        {
            return CurrentSession.CreateCriteria<Kunde>()
                    //.CreateCriteria("Auftraege")
                    .CreateCriteria("Kunde")
                    .Add(Restrictions.Eq("KundeID",KundeID))
                    .List<Auftrag>();
        }*/

        public Klasse Add(Klasse klasse)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (klasse.KlasseID > 0)
                    {
                        throw new Exception(String.Format("A Klasse with KlasseID {0} already exists. To update please use PUT.", klasse.KlasseID));
                    }
                    CurrentSession.Save(klasse);
                    tran.Commit();

                    return klasse;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        public Klasse Update(Klasse klasse)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (klasse.KlasseID == 0)
                    {
                        throw new Exception("For creating a Klasse please use POST");
                    }
                    CurrentSession.Update(klasse);
                    tran.Commit();

                    return klasse;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        public bool Delete(int id)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    var klasse = Get(id);
                    if (klasse != null)
                    {
                        CurrentSession.Delete(klasse);
                        tran.Commit();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }


    }
}
