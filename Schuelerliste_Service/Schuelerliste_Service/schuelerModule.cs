using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Services;
using Nancy.Responses;
using Nancy.Serialization.JsonNet;
using Nancy.ModelBinding;
using Common.Models;
using Nancy.Security;

namespace Api.Modules
{
    public class SchuelerModule : NancyModule
    {
        ErrorLogFile log = Program.log;

        public SchuelerModule(SchuelerService schuelerService)
            : base("/schueler")
        {
            Get["/"] = p =>
            {
                var schueler = schuelerService.Get();
                return new JsonResponse(schueler, new JsonNetSerializer());
            };

            Get["/{id}"] = p =>
            {
                var schueler = schuelerService.Get(p.id);
                if (schueler == null)
                {
                    return HttpStatusCode.NotFound;
                }
                return new JsonResponse(schueler, new JsonNetSerializer());
            };


            Post["/"] = p =>
            {
                Schueler post = this.Bind();
                try
                {
                    var result = schuelerService.Add(post);
                }
                catch (Exception ex)
                {
                    log.errorLog(ex.Message);
                    return HttpStatusCode.BadRequest;
                }
                return HttpStatusCode.Created;
            };

            Put["/"] = p =>
            {
                Schueler put = this.Bind();
                try
                {
                    var result = schuelerService.Update(put);
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
                    var result = schuelerService.Delete(p.id);
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
