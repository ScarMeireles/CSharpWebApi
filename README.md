# CSharpWEBAPI

API REST em ASP.NET Core para gerenciamento de produtos, com persistência no MongoDB. Desenvolvida com foco em simplicidade e facilidade de testes via Swagger.

---

## 🚀 Funcionalidades

- ✅ Listar todos os produtos
- ✅ Obter um produto pelo ID
- ✅ Criar um novo produto
- ✅ Atualizar um produto existente
- ✅ Remover um produto
- ✅ Integração com MongoDB (local)
- ✅ Testes via Swagger UI

---

## 🛠️ Tecnologias utilizadas

- ASP.NET Core 8 (API)
- MongoDB (via MongoDB.Driver)
- Swagger (Swashbuckle.AspNetCore)
- Visual Studio Code
- MongoDB Compass (interface gráfica para banco)

---


---

## ⚙️ Configuração

### 1. MongoDB

Certifique-se de que o MongoDB está instalado e rodando localmente na porta padrão `27017`.  
Você pode usar o MongoDB Compass para visualizar os dados.

A string de conexão está no `appsettings.json`:

```json
"ConnectionStrings": {
  "MongoDB": "mongodb://localhost:27017"
}

