using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using GestãoDeEquipamentos.WinFormsApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Dados
{
    public class RepositorioEquipamentoEmArquivo : RepositorioBaseEmArquivo<Equipamento>, IRepositorioEquipamento
    {
    }
}
