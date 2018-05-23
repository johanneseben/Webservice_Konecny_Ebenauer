using Common.Models;
using Common.Services;
using Nancy;
using Nancy.Responses;
using Nancy.Serialization.JsonNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.ModelBinding;
using Nancy.Security;

namespace Api.Modules
{
    public class Foerderkurs_Schueler_Module : NancyModule
    {
        ErrorLogFile log = Program.log;

        public Foerderkurs_Schueler_Module(Foerderkurs_Schueler_Service foerderkurs_schueler_Service, foerderkursService foederkursService, SchuelerService schuelerService)
            : base("/foederkurs_schueler")
        {
            //Passwortabsicherung des Moduls
            //this.RequiresAuthentication();

            Get["/"] = p =>
            {
                var foeSch = foerderkurs_schueler_Service.Get();
                return new JsonResponse(aufArt, new JsonNetSerializer());
            };

            Get["/bySchuelerID/{id}"] = p =>
            {
                var foeSch = foerderkurs_schueler_Service.GetBySchueler(p.id);
                return new JsonResponse(foeSch, new JsonNetSerializer());
            };


            Post["/"] = p =>
            {
                foerderkurs_Schueler post = this.Bind();
                try
                {
                    var result = foerderkurs_schueler_Service.Add(post);
                }
                catch (Exception ex)
                {
                    log.errorLog(ex.Message);
                    Console.WriteLine(ex.Message);
                    return HttpStatusCode.BadRequest;
                }
                return HttpStatusCode.Created;
            };

            Post["/Schueler/{schuelerID}/Foerderkurs/{foederkursID}"] = p =>
            {
                Schueler sch = schuelerService.Get(p.SchuelerID);
                Foederkurs foe = foerderkursService.Get(p.FoederkursID);

                Foerderkurs_Schueler post = this.Bind();
                post.Schueler = sch;
                post.Foerderkurs = foe;

                sch.foerderkursSchueler.Add(post);
                foe.foerderkursSchueler.Add(post);

                try
                {
                    var result = foerderkurs_schueler_Service.Add(post);
                }
                catch (Exception ex)
                {
                    log.errorLog(ex.Message);
                    Console.WriteLine(ex.Message);
                    return HttpStatusCode.BadRequest;
                }
                return HttpStatusCode.Created;

            };

            Put["/"] = p =>
            {
                foederkurs_Schueler put = this.Bind();
                try
                {
                    var result = foerderkurs_schueler_Service.Update(put);
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
                    var result = foerderkurs_schueler_Service.Delete(p.id);
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