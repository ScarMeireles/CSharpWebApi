using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace CSharpWEBAPI.AppHost.Models
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("preco")]
        public double Preco { get; set; }

        [BsonElement("estoque")]
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
