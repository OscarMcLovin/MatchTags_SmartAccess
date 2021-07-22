using MatchTags_SmartAccess.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTags_SmartAccess.DataAccess.DAO
{
    public static class TagsDAO
    {
        /// <summary>
        /// Obtener todos los tags de un fraccionamiento dado
        /// </summary>
        /// <param name="fracc"></param>
        /// <returns></returns>
        public static List<TagDTO> ObtenerTagsByFracc(FraccionamientoDTO fracc)
        {
            var listTags = new List<TagDTO>();
            try
            {
                var cadenaConection = obtenerCadenaConection(fracc);
                using (var db = new ACCFRACCEntities(cadenaConection))
                {
                    listTags = (from tags in db.AccFracc_Tags where tags.Activo == 1 select tags);                                
                }

                return listTags;
            }
            catch (Exception ex)
            {
                InertErrorLog(ex, "TagsDAO.ObtenerTagsByFracc", fracc);
                return listTags;
            }
        }

        /// <summary>
        /// Insertar un nuevo tag
        /// </summary>
        /// <param name="tag">Tag a insertar</param>
        /// <param name="fracc">Fraccionamiento donde se insertará el nuevo tag</param>
        /// <returns></returns>
        public static int InsertTag(AccFracc_Tags tag, FraccionamientoDTO fracc)
        {           
            try
            {
                string cadena = obtenerCadenaConection(fracc);
                using (var db = new ACCFRACCEntities(cadena))
                {
                    db.AccFracc_Tags.Add(tag);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                InertErrorLog(ex, "TagsDAO.InsertTag", fracc);
                return 0;
            }
        }

        /// <summary>
        /// Obtener la cadena de conexión de un fraccionamiento
        /// </summary>
        /// <param name="fracc"></param>
        /// <returns></returns>
        private static string obtenerCadenaConection(FraccionamientoDTO fracc)
        {
            try
            {
                //Validar que todos los campos de conexión a la bd no estén vacíos o null.
                if (string.IsNullOrWhiteSpace(fracc.IP) || string.IsNullOrWhiteSpace(fracc.PuertoSql) ||
                    string.IsNullOrWhiteSpace(fracc.ServerSql) || string.IsNullOrWhiteSpace(fracc.UserSql) || string.IsNullOrWhiteSpace(fracc.PswSql))
                {
                    return null;
                }

                //Cadena de conexión del servidor
                //string connectionString = $"Server={fracc.IP},{fracc.PuertoSql};Database={fracc.ServerSql};User Id={fracc.UserSql};Password={fracc.PswSql};";
                var CadenaConnection = $"metadata=res://*/DBFraccModel.csdl|res://*/DBFraccModel.ssdl|res://*/DBFraccModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source={fracc.IP},{fracc.PuertoSql};persist security info=True;user id={fracc.ServerSql};password={fracc.PswSql};MultipleActiveResultSets=True;App=EntityFramework&quot;";


                return CadenaConnection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Insertar errores en el log en base de datos
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="ModuloAction"></param>
        /// <param name="fracc"></param>
        private static async void InertErrorLog(Exception ex, string ModuloAction, FraccionamientoDTO fracc)
        {
            //string cadena = obtenerCadenaConection(fracc);
            //using (var db = new FraccEntities(cadena))
            //{
            //    db.AccFracc_ErrorLogs.Add(new AccFracc_ErrorLogs()
            //    {
            //        Error = ex.Message,
            //        FechaErrorLog = DateTime.Now,
            //        Modulo = ModuloAction
            //    });
            //    await db.SaveChangesAsync();
            //}
        }
    }
}
