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
```

## 📬 Endpoints da API

| Método | Endpoint          | Ação                    |
| ------ | ----------------- | ----------------------- |
| GET    | /api/produto      | Lista todos os produtos |
| GET    | /api/produto/{id} | Busca produto por ID    |
| POST   | /api/produto      | Cria novo produto       |
| PUT    | /api/produto/{id} | Atualiza um produto     |
| DELETE | /api/produto/{id} | Remove um produto       |


## 📌 Observações
Certifique-se de que o MongoDB esteja em execução antes de iniciar a API.

As portas podem variar dependendo do seu launchSettings.json.

## 📄 Licença
Este projeto é de uso acadêmico e livre para fins de estudo e aprimoramento.
