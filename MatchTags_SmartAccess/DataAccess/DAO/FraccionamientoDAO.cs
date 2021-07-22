using MatchTags_SmartAccess.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTags_SmartAccess.DataAccess.DAO
{
    public static class FraccionamientoDAO
    {
        /// <summary>
        /// Obtiene todos los fraccionamientos
        /// </summary>
        /// <returns></returns>
        public static List<FraccionamientoDTO> ObtenerFraccionamientosAll()
        {
            try
            {
                List<FraccionamientoDTO> listaFracc = new List<FraccionamientoDTO>();
                using (var db = new SAEntities())
                {
                    listaFracc = (from fracc in db.Fraccionamiento.AsNoTracking()
                                  select new FraccionamientoDTO()
                                  {
                                      IdFraccionamiento = fracc.IdFraccionamiento,
                                      Nombre = fracc.Nombre,
                                      IP = fracc.IP,
                                      ServerSql = fracc.ServerSql,
                                      PuertoSql = fracc.PuertoSql,
                                      UserSql = fracc.UserSql,
                                      PswSql = fracc.PswSql
                                  }).ToList();


                    return listaFracc;
                }
            }
            catch (Exception ex)
            {
                InertErrorLog(ex, "FraccionamientoDAO.ObtenerFraccionamientosAll");
                return null;
            }
        }

        /// <summary>
        /// Obtiene fraccionamiento por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FraccionamientoDTO ObtenerFraccionamientoById(int id)
        {
            try
            {
                FraccionamientoDTO Fracc = new FraccionamientoDTO();
                using (var db = new SAEntities())
                {
                    Fracc = (from fracc in db.Fraccionamiento.AsNoTracking()
                             where fracc.IdFraccionamiento == id
                             select new FraccionamientoDTO()
                             {
                                 IdFraccionamiento = fracc.IdFraccionamiento,
                                 Nombre = fracc.Nombre,
                                 IP = fracc.IP,
                                 ServerSql = fracc.ServerSql,
                                 PuertoSql = fracc.PuertoSql,
                                 UserSql = fracc.UserSql,
                                 PswSql = fracc.PswSql
                             }).FirstOrDefault();


                    return Fracc;
                }
            }
            catch (Exception ex)
            {
                InertErrorLog(ex, "FraccionamientoDAO.ObtenerFraccionamientoById");
                return null;
            }
        }

        private static async void InertErrorLog(Exception ex, string ModuloAction)
        {
            using (var db = new SAEntities())
            {
                db.ErrorLog.Add(new ErrorLog()
                {
                    Error = ex.Message,
                    Fecha = DateTime.Now,
                    Modulo = ModuloAction,
                });

                await db.SaveChangesAsync();
            }
        }
    }
}
