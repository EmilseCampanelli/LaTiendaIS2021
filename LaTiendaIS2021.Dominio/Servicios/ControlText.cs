using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Servicios
{
    class ControlText
    {
        public bool Acierto { get; set; }
        public bool ControlTexto(string text)
        {

            if ((!Regex.Match(text, "^[[A-z -']+$").Success))
            {
                Acierto = false;
            }
            else Acierto = true;

            return Acierto;
           
        }

        public bool ControlNum(string text)
        {
            if((!Regex.Match(text, "[0-9]").Success))
            {
                Acierto = false;
            }
            else Acierto = true;

            return Acierto;
        }
    }
}
