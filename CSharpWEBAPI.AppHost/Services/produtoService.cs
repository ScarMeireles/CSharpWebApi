using MongoDB.Driver;
using CSharpWEBAPI.AppHost.Models; 
using Microsoft.Extensions.Configuration;


namespace CSharpWEBAPI.Services
{
    public class ProdutoService
    {
        private readonly IMongoCollection<Produto> _produtos;

        public ProdutoService(IConfiguration config)
        {
            try
            {
                // Conecta ao servidor MongoDB usando a string de conexão do appsettings.json
                var client = new MongoClient(config.GetConnectionString("MongoDB"));

                // Acessa o banco de dados chamado LojaArthurMeireles
                var database = client.GetDatabase("LojaArthurMeireles");

                // Acessa a coleção chamada Produtos
                _produtos = database.GetCollection<Produto>("Produtos");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao Database", ex);
            }
        }

        // Obtém todos os produtos
        public List<Produto> Get() =>
            _produtos.Find(p => true).ToList();

        // Obtém um produto por ID
        public Produto Get(string id)
        {
            var produto = _produtos.Find(p => p.Id == id).FirstOrDefault();
            if (produto == null)
            {
                throw new Exception($"Produto com id {id} não encontrado.");
            }
            return produto;
        }

        // Cria um novo produto
        public Produto Create(Produto produto)
        {
            try
            {
                _produtos.InsertOne(produto);
                return produto;
            }
            catch (Exception ex)
            {
                // Log or handle exception as necessary
                throw new Exception("Erro ao criar o produto", ex);
            }
        }

        // Atualiza um produto existente
        public void Update(string id, Produto produto)
        {
            try
            {
                _produtos.ReplaceOne(p => p.Id == id, produto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar o produto com id {id}", ex);
            }
        }

        // Deleta um produto
        public void Delete(string id)
        {
            try
            {
                _produtos.DeleteOne(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao deletar o produto com id {id}", ex);
            }
        }
    }
}
