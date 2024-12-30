# Projeto de Estudos: Autenticação JWT com Token

## Descrição do Projeto
Este projeto foi desenvolvido como parte de meus estudos sobre autenticação e segurança em aplicações .NET. O foco principal foi implementar autenticação baseada em JWT (JSON Web Token) e garantir boas práticas de segurança, como o uso de hashing para senhas de usuários. O projeto também aborda padrões de desenvolvimento, arquitetura limpa e melhores práticas para um código escalável e manutençível.

## Tecnologias e Padrões Utilizados

### Tecnologias
- **Identity Core**: Utilizado para hashing seguro de senhas.
- **.NET 8**: Plataforma principal para desenvolvimento da aplicação.
- **JWT (JSON Web Token)**: Implementado para autenticação e autorização segura.
- **Entity Framework**: Utilizado para mapeamento objeto-relacional (ORM) e acesso ao banco de dados.
- **SQLite**: Banco de dados leve e de fácil configuração para estudos e aplicações pequenas.

### Padrões e Práticas
- **Padrão Repository**: Abstração para acesso e manipulação de dados.
- **Arquitetura Limpa**: Estrutura do projeto organizada em camadas, garantindo separação de responsabilidades.
- **Service Pattern**: Lógica de negócio encapsulada em serviços para melhor organização e reuso.
- **Fluent Validation**: Validação de dados de entrada de forma fluente e reutilizável.
- **Injeção de Dependência**: Gerenciamento centralizado de dependências para promover o desacoplamento.
- **Padronização de Mensagens de Retorno**: Uso de códigos específicos para categorizar mensagens de resposta.
- **Padronização de Respostas da API**: Estrutura uniforme para respostas, facilitando a integração com clientes.
- **Service Extensions**: Métodos de extensão para centralizar a configuração de serviços.
- **DTOs (Data Transfer Objects)**: Uso de objetos de transferência de dados para controlar entradas e saídas da API.
- **Melhores Práticas e Clean Code**: Enfase em código limpo, legível e fácil de manter.

## Estrutura do Projeto

### Camadas
1. **API**: Responsável por expor os endpoints e configurar a injeção de dependências.
2. **Application**: Contém as regras de negócio, validações e padrões como DTOs.
3. **Domain**: Define as entidades principais do sistema.
4. **Infrastructure**: Implementação do acesso a dados usando Entity Framework e integrações externas.

### Funcionalidades Principais
- **Cadastro de Usuários**: Com hashing seguro de senhas.
- **Autenticação JWT**: Geração de tokens para autenticação e controle de sessão.
- **Validação de Dados**: Regras de validação aplicadas a todas as entradas.
- **Endpoints Seguros**: Proteção de endpoints sensíveis com autorização JWT.

## Como Executar

### Requisitos do Projeto
- Visual Studio 2022
- .NET 8 SDK
- SQLite
- Ferramenta para testar APIs (Postman, Insomnia, ou similar)

### Passos para Execução
1. Clone o repositório do projeto.
2. Configure o banco de dados SQLite no arquivo `appsettings.json`.
3. Abra o projeto no Visual Studio 2022.
4. Execute o comando `dotnet ef database update` para criar o banco de dados.
5. Inicie o projeto pressionando **F5**.
6. Utilize uma ferramenta de teste de APIs para consumir os endpoints expostos.

## Estrutura de Respostas da API
As respostas da API seguem o seguinte formato:
```json
{
  "statusCode": 200,
  "success": true,
  "message": "Operation completed successfully.",
  "data": {}
}
```
- **statusCode**: Representa o código HTTP da operação (ex.: 200, 400, 500).
- **success**: Indica se a operação foi bem-sucedida.
- **message**: Mensagem descritiva sobre o resultado da operação.
- **data**: Contém os dados retornados (se aplicável).

A implementação de resposta utiliza o seguinte código:
```csharp
return CustomResponse(
    (int)HttpStatusCode.OK,
    true,
    ControllerMessages.AUTH_OK_001_LOGIN_SUCCESSFUL,
    token
);
```

## Lições Aprendidas
Este projeto proporcionou experiências valiosas, incluindo:
- Implementação segura de autenticação com hashing e JWT.
- Melhoria na organização do código com padrões de arquitetura e design.
- Validação de dados robusta com Fluent Validation.

## Melhorias Futuras
- Implementar testes automatizados para garantir a qualidade do código.
- Adicionar suporte a refresh tokens.
- Criar documentação com Swagger para facilitar o consumo da API.

## Contribuições
Este projeto foi desenvolvido com o objetivo de aprendizado e melhoria de habilidades em .NET. Sugestões e melhorias são sempre bem-vindas!

