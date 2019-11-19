using System;

namespace Dia_da_Semana
{
    class diadasemana
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        public string envia
        {
            get
            {
                return "O dia da Semana em que você nasceu é " + data.ToString("dddd")+".";
            }
        }
    }
}
