using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Negocio
{
    public class Equipamento : EntidadeBase<Equipamento>
    {
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public decimal PrecoAquisicao { get; set; }
        public DateOnly DataFabricacao { get; set; }
        public string NumeroSerie
        {
            get
            {
                string tresPrimeirosCaracteres = Nome.Substring(0, 3).ToUpper();

                return $"{tresPrimeirosCaracteres}-{Id}";
            }
        }
        public Equipamento()
        {
        }
        public Equipamento(string nome, string fabricante, decimal precoAquisicao, DateOnly dataFabricacao)
        {
            Nome = nome;
            Fabricante = fabricante;
            PrecoAquisicao = precoAquisicao;
            DataFabricacao = dataFabricacao;
        }

        public override string Validar()
        {
            string erros = "";

            if (string.IsNullOrEmpty(Nome))
                erros += "O campo nome é obrigatório.\n";

            if (string.IsNullOrEmpty(Fabricante))
                erros += "O campo fabricante é obrigatório.\n";

            if (PrecoAquisicao == 0)
                erros += "O campo preço é obrigatório.";

            return erros;
        }

        public override void AtualizarRegistro(Equipamento equipamento)
        {
            Nome = equipamento.Nome;
            Fabricante = equipamento.Fabricante;
            PrecoAquisicao = equipamento.PrecoAquisicao;
            DataFabricacao = equipamento.DataFabricacao;
        }
    }
}
