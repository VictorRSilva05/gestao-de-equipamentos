using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Negocio
{
    public class Chamado : EntidadeBase<Chamado>
    {
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

        public override string Validar()
        {
            string erros = "";

            if (string.IsNullOrEmpty(DescricaoChamado))
                erros += "É necessário informar uma descrição ao chamado.\n";

            if (Equipamento is null)
                erros += "É necessário informar um equipamento.\n";

            return erros;
        }

        public override void AtualizarRegistro(Chamado chamadoEditado)
        {
            TituloChamado = chamadoEditado.TituloChamado;
            DescricaoChamado = chamadoEditado.DescricaoChamado;
            Equipamento = chamadoEditado.Equipamento;
            DataAbertura = chamadoEditado.DataAbertura;
        }
    }
}
