
using GestãoDeEquipamentos.WinFormsApp.Negocio;
using Microsoft.Win32;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public class ContextoDados
    {
        public List<Fabricante> Fabricantes { get; set; }
        public List<Equipamento> Equipamentos { get; set; }
        public List<Chamado> Chamados { get; set; }

        private string pastaArmazenamento = "C:\\Temp";
        private string ArquivoArmazenamento = "dados.json";

        public ContextoDados()
        {
            Fabricantes = new List<Fabricante>();
            Equipamentos = new List<Equipamento>();
            Chamados = new List<Chamado>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if(carregarDados)
                Carregar();
        }

        public void Salvar()
        {
            string caminhoCompleto = Path.Combine(pastaArmazenamento, ArquivoArmazenamento);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve,
            };

            string json = JsonSerializer.Serialize(this, options);

            if (!Directory.Exists(pastaArmazenamento))
                Directory.CreateDirectory(pastaArmazenamento);

            File.WriteAllText(caminhoCompleto, json);
        }

        public void Carregar()
        {
          
            string caminhoCompleto = Path.Combine(pastaArmazenamento, ArquivoArmazenamento);

            if (!File.Exists(caminhoCompleto))
                return;

            string json = File.ReadAllText(caminhoCompleto);

            if (string.IsNullOrWhiteSpace(json))
                return;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
            };

            ContextoDados contextoArmazenado = JsonSerializer.Deserialize<ContextoDados>(json, options);

            if (contextoArmazenado == null)
                return;

            this.Fabricantes = contextoArmazenado.Fabricantes;
            this.Chamados = contextoArmazenado.Chamados;
            this.Equipamentos = contextoArmazenado.Equipamentos;
        }
    }
}
