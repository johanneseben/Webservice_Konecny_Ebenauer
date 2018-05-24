using Common.Services;
using Nancy;
using Nancy.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.ModelBinding;
using Common.Models;
using Nancy.Serialization.JsonNet;
using Nancy.Security;

namespace Api.Modules
{
    public class foerderkursModule : NancyModule
    {
        ErrorLogFile log = Program.log;

        public foerderkursModule(FoerderkursService foerderkursService)
            : base("/foerderkurs")
        {
            Get["/"] = p =>
            {
                var auftraege = foerderkursService.Get();
                return new JsonResponse(foerderkurs, new JsonNetSerializer());
            };

            Get["/{id}"] = p =>
            {
                var foerderkurs = foerderkursService.Get(p.id);
                if (foerderkurs == null)
                {
                    return HttpStatusCode.NotFound;
                }
                return new JsonResponse(foerderkurs, new JsonNetSerializer());
            };

            Get["/byKundeId/{id}"] = p =>
            {
                var foerderkurse = foerderkursService.GetBySchueler(p.id);
                return new JsonResponse(foerderkurse, new JsonNetSerializer());
            };

            Post["/"] = p =>
            {
                Foerderkurs post = this.Bind();
                try
                {
                    var result = foerderkursService.Add(post);
                }
                catch (Exception ex)
                {
                    log.errorLog(ex.Message);
                    return HttpStatusCode.BadRequest;
                }
                return new JsonResponse(post, new JsonNetSerializer());
            };

            Put["/"] = p =>
            {
                Foerderkurs put = this.Bind();
                try
                {
                    var result = foerderkursService.Update(put);
                }
                catch (Exception ex)
                {
                    log.errorLog(ex.Message);
                    return HttpStatusCode.BadRequest;
                }
                return HttpStatusCode.OK;
            };

            Delete["/{id}"] = p =>
            {
                try
                {
                    var result = foerderkursService.Delete(p.id);
                    return new JsonResponse(result, new DefaultJsonSerializer());
                }
                catch (Exception ex)
                {
                    log.errorLog(ex.Message);
                    return HttpStatusCode.BadRequest;
                }
            };
        }
    }
}