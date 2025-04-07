# Teste Técnico Magma³

Projeto desenvolvido para o Teste Técnico da empresa Magma³.

## 📚 Descrição

API Web desenvolvida em ASP.NET Core para gerenciamento de clientes e integração com API externa.

Principais funcionalidades:
- Cadastro, listagem e consulta de clientes.
- Consumo de API externa para obtenção de ativos.
- Filtragem de ativos por data de última comunicação.
- Implementação de autenticação JWT.
- Separação de camadas seguindo boas práticas (DTOs, Services, Controllers).

## 🚀 Tecnologias Utilizadas

- ASP.NET Core 8
- MongoDB + MongoDB.Driver
- AutoMapper
- Swashbuckle (Swagger)
- JWT Bearer Authentication
- C#

## 📂 Estrutura do Projeto

TesteTecnicoMagma/
├── TesteTecnicoMagma.API/           # API principal (Controllers, Configurações)
│   ├── Controllers/                  # Endpoints HTTP
│   ├── DTOs/                         # Data Transfer Objects
│   ├── Middlewares/                  # Tratamento de exceções, autenticação, etc.
│   ├── Program.cs                    # Configuração e inicialização da aplicação
├── TesteTecnicoMagma.Entities/       # Definições das entidades
├── TesteTecnicoMagma.Services/       # Lógica de negócio (Service Layer)
├── TesteTecnicoMagma.Data/            # Acesso ao MongoDB (Repositórios e Contextos)
└── README.md                          # Este arquivo maravilhoso que você está lendo


