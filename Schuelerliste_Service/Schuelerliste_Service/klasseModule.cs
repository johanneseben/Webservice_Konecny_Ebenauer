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
    public class KlasseModule : NancyModule
    {
        ErrorLogFile log = Program.log;

        public KlasseModule(KlasseService klasseService)
            : base("/klasse")
        {
            Get["/"] = p =>
            {
                var klasse = klasseService.Get();
                return new JsonResponse(klasse, new JsonNetSerializer());
            };

            Get["/{id}"] = p =>
            {
                var klasse = klasseService.Get(p.id);
                if (klasse == null)
                {
                    return HttpStatusCode.NotFound;
                }
                return new JsonResponse(klasse, new JsonNetSerializer());
            };

            Post["/"] = p =>
            {
                Klasse post = this.Bind();
                try
                {
                    var result = klasseService.Add(post);
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
                Klasse put = this.Bind();
                try
                {
                    var result = klasseService.Update(put);
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
                    var result = klasseService.Delete(p.id);
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

