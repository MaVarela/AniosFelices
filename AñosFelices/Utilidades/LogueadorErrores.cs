using System;
using System.IO;

namespace AñosFelices.Utilidades
{
    /// <summary>
    /// Se encarga de loguear las excepciones
    /// </summary>
    public static class LogueadorErrores
    {
        /// <summary>
        /// Se encarga de loguear las excepciones
        /// </summary>
        public static void Loguear(Exception ex)
        {
            /*string strPath = @"C:\Logs\Errores.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Comienzo============= " + DateTime.Now);
                sw.WriteLine("Mensaje de error: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========Fin============= " + DateTime.Now);
            }*/
        }
    }
}
