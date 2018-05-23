using Common.Models;
using NHibernate;
using System;
using System.Collections.Generic;

namespace Common.Services
{
    public class SchuelerService : BaseService
    {
        public SchuelerService(Func<ISession> session)
            : base(session)
        {
        }

        public IList<Schueler> Get()
        {
            return CurrentSession.CreateCriteria(typeof(Schueler)).List<Schueler>();
        }

        public Schueler Get(int id)
        {
            return CurrentSession.Get<Schueler>(id);
        }

        public Schueler Add(Schueler schueler)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (schueler.schuelerID > 0)
                    {
                        throw new Exception(String.Format("A Schueler with SchuelerID {0} already exists. To update please use PUT.", schueler.SchuelerID));
                    }
                    CurrentSession.Save(schueler);
                    tran.Commit();

                    return schueler;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        public Schueler Update(Schueler schueler)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (schueler.SchuelerID == 0)
                    {
                        throw new Exception("For creating a artikel please use POST");
                    }
                    CurrentSession.Update(schueler);
                    tran.Commit();

                    return schueler;
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
                    var schueler = Get(id);
                    if (schueler != null)
                    {
                        CurrentSession.Delete(schueler);
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
