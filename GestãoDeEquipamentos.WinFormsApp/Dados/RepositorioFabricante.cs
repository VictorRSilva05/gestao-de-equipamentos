

using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using GestãoDeEquipamentos.WinFormsApp.Negocio;

namespace GestãoDeEquipamentos.WinFormsApp.Dados
{
    public class RepositorioFabricante : RepositorioBase
    {
        public List<Fabricante> fabricantes = new List<Fabricante>();

        public RepositorioFabricante() { }
    }
}
