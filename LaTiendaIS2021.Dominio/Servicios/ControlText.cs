using System.Text.RegularExpressions;

namespace LaTiendaIS2021.Dominio.Servicios
{
    public class ControlText
    {
        private static bool Acierto { get; set; }
        public static bool ControlTexto(string text)
        {

            if ((!Regex.Match(text, "^[[A-z -']+$").Success))
            {
                Acierto = false;
            }
            else Acierto = true;

            return Acierto;

        }

        public static bool ControlNum(string text)
        {
            if ((!Regex.Match(text, "[0-9]").Success))
            {
                Acierto = false;
            }
            else Acierto = true;

            return Acierto;
        }
    }
}
