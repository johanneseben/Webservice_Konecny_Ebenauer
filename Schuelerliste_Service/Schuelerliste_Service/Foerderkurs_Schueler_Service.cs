using Common.Models;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace Common.Services
{
    public class Foerderkurs_Schueler_Service : BaseService
    {
        public FoerderkursService(Func<ISession> session)
            : base(session)
        {
        }

        public IList<FoerderkursSchueler> Get()
        {
            return CurrentSession.CreateCriteria(typeof(FoerderkursSchueler)).List<FoerderkursSchueler>();
        }

        public FoerderkursSchueler Get(int id)
        {
            return CurrentSession.Get<FoerderkursSchueler>(id);
        }

        public IList<FoerderkursSchueler> GetByFoerderkurs(int id)
        {
            return CurrentSession.CreateCriteria<FoerderkursSchueler>().Add(Restrictions.Eq("Foerderkurs.FoerderkursID", id)).List<FoerderkursSchueler>();
        }

        public FoerderkursSchueler Add(FoerderkursSchueler foerderkursSchueler)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (foerderkursSchueler.FoerderkursSchueler.ID > 0)
                    {
                        throw new Exception(String.Format("A FoerderkursSchueler with FoerderkursSchuelerID {0} already exists. To update please use PUT.", foerderkursSchueler.FoerderkursSchuelerID));
                    }
                    CurrentSession.Save(foerderkursSchueler);
                    tran.Commit();

                    return foerderkursSchueler;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        public FoerderkursSchueler Update(FoerderkursSchueler foerderkursSchueler)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (foerderkursSchueler.FoerderkursSchuelerID == 0)
                    {
                        throw new Exception("For creating a user please use POST");
                    }
                    CurrentSession.Update(foerderkursSchueler);
                    tran.Commit();

                    return foerderkursSchueler;
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
                    var foerderkursSchueler = Get(id);
                    if (foerderkursSchueler != null)
                    {
                        CurrentSession.Delete(foerderkursSchueler);
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