using Common.Models;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace Common.Services
{
    public class FoerderkursService : BaseService
    {
        public FoerderkursService(Func<ISession> session)
            : base(session)
        {
        }

        public IList<Foerderkurs> Get()
        {
            return CurrentSession.CreateCriteria(typeof(Foerderkurs)).List<Foerderkurs>();
        }

        public Foerderkurs Get(int id)
        {
            return CurrentSession.Get<Foerderkurs>(id);
        }


        public IList<Foerderkurs> GetBySchüler(int SchülerID)
        {
            return CurrentSession.CreateCriteria<Foerderkurs>()
                    //.CreateCriteria("Auftraege")
                    .CreateCriteria("Foerderkurs")
                    .Add(Restrictions.Eq("FoerderkursID", FoerderkursID))
                    .List<Foerderkurs>();
        }

        public Foerderkurs Add(Foerderkurs foerderkurs)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (foerderkurs.FoerderkursID > 0)
                    {
                        throw new Exception(String.Format("A Foerderkurs with FoerderkursID {0} already exists. To update please use PUT.", foerderkurs.FoerderkursID));
                    }
                    CurrentSession.Save(foerderkurs);
                    tran.Commit();

                    return foerderkurs;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        public Foerderkurs Update(Foerderkurs foerderkurs)
        {
            using (var tran = CurrentSession.BeginTransaction())
            {
                try
                {
                    if (foerderkurs.FoerderkursID == 0)
                    {
                        throw new Exception("For creating a Foerderkurs please use POST");
                    }
                    CurrentSession.Update(foerderkurs);
                    tran.Commit();

                    return foerderkurs;
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
                    var foerderkurs = Get(id);
                    if (foerderkurs != null)
                    {
                        CurrentSession.Delete(foerderkurs);
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
