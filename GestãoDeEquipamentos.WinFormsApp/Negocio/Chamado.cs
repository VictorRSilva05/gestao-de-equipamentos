using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Negocio
{
    public class Chamado
    {
        public int Id { get; set; }
        public TipoChamadoEnum TituloChamado { get; set; }
        public string DescricaoChamado { get; set; }
        public Equipamento Equipamento { get; set; }
        public DateOnly DataAbertura { get; set; }

        public Chamado()
        {
        }
        public Chamado(TipoChamadoEnum tituloChamado, string descricaoChamado, Equipamento equipamento, DateOnly dataAbertura)
        {
            TituloChamado = tituloChamado;
            DescricaoChamado = descricaoChamado;
            Equipamento = equipamento;
            DataAbertura = dataAbertura;
        }

        public string Validar()
        {
            string erros = "";

            if (string.IsNullOrEmpty(DescricaoChamado))
                erros += "É necessário informar uma descrição ao chamado.\n";

            if (Equipamento is null)
                erros += "É necessário informar um equipamento.\n";

            return erros;
        }
    }
}
