using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public static class GeradorIds
    {
        public static int IdEquipamentos = 0;
        public static int IdChamados = 0;
        public static int IdFabricantes = 0;

        public static int GerarIdEquipamento()
        {
            IdEquipamentos++;
            return IdEquipamentos;
        }
        public static int GerarIdChamado()
        {
            IdChamados++;
            return IdChamados;
        }

        public static int GerarIdFabricantes()
        {
            IdFabricantes++;
            return IdFabricantes;
        }
    }
}
