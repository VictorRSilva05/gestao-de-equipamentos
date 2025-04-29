
using System.Text.Json;

namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public abstract class RepositorioBaseEmArquivo<T> where T : EntidadeBase<T>
    {
        public List<T> registros = new List<T>();
        private int contadorIds = 0;

        private string caminhoPastaTemp = "C:\\Temp";
        private string nomeArquivo;
        protected RepositorioBaseEmArquivo(string nomeArquivo)
        {
            this.nomeArquivo = nomeArquivo;

            registros = Deserializar();
            
            int maiorId = 0;

            foreach (var registro in registros)
            {
                if (registro.Id > maiorId)
                    maiorId = registro.Id;
            }

            contadorIds = maiorId;
        }
        public void Inserir(T entidade)
        {
            entidade.Id = ++contadorIds;
            registros.Add(entidade);

            Serializar();
        }

        public void Editar(int idRegistro, T registroEditado)
        {
            foreach (var registro in registros)
            {
                if (registro.Id == idRegistro)
                {
                    registro.AtualizarRegistro(registroEditado);

                    Serializar();
                }
            }
        }

        public void Deletar(int idRegistro)
        {
            registros.RemoveAll(e => e.Id == idRegistro);

            Serializar();
        }

        public T SelecionarPorId(int idRegistro)
        {
            foreach (var registro in registros)
            {
                if (registro.Id == idRegistro)
                    return registro;
            }
            return null;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        protected void Serializar()
        {
            string caminhoCompleto = Path.Combine(caminhoPastaTemp,nomeArquivo);

            string json = JsonSerializer.Serialize(registros);

            if(!Directory.Exists(caminhoPastaTemp))
                Directory.CreateDirectory(caminhoPastaTemp);

            File.WriteAllText(caminhoCompleto, json);
        }

        protected List<T> Deserializar()
        {
            List<T> registrosArmazenados = new List<T>();

            string caminhoCompleto = Path.Combine(caminhoPastaTemp, nomeArquivo);

            if(!File.Exists(caminhoCompleto))
                return registrosArmazenados;

            string json = File.ReadAllText(caminhoCompleto);

            if (string.IsNullOrWhiteSpace(json))
                return registrosArmazenados;

            registrosArmazenados = JsonSerializer.Deserialize<List<T>>(json);

            return registrosArmazenados;
        }
    }
}
