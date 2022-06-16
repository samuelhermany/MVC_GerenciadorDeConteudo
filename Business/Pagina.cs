using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pagina
    {
        // Retorna a lista do banco de dados, organizando as colunas em propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public List<Pagina> Lista()
        {
            var lista = new List<Pagina>();
            var paginaDb = new Database.Pagina();
            foreach (DataRow row in paginaDb.Lista().Rows)
            {
                var pagina = new Pagina();
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["data"]);
                
                lista.Add(pagina);
            }

            return lista;
        }

        public static Pagina BuscaPorId(int id)
        {
            var pagina = new Pagina();
            var paginaDb = new Database.Pagina();
            foreach (DataRow row in paginaDb.BuscaPorId(id).Rows)
            {
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["data"]);
            }

            return pagina;
        }

        // Ação para enviar para o database
        public void Save()
        {
            new Database.Pagina().Salvar(this.Id, this.Nome, this.Conteudo, this.Data);
        }

        public static void Excluir(int id)
        {
            new Database.Pagina().Excluir(id);
        }
    }
}
