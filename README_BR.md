| Language | File         |
|----------|--------------|
| 🇺🇸 EN    | [README.md](/README.md)    |
| 🇧🇷 BR    | [README_BR.md](/README_BR.md) |

# Bem vindo ao Peace ERP!

A intenção desta aplicação é ser utilizada por ONGs (Organizações Não Governamentais), preferencialmente por ONGs Sociais.

# Contribuir
Para contribuir, consulte nosso "Guia de Contribuição" (link a definir)

# Linguagem
Esta aplicação utilizará C# com .NET Core 7

# Arquitetura
A arquitetura utilizada é o [Clean Architecture](https://www.youtube.com/watch?v=o_TH-Y78tt4).
<br><img alt="Imagem da arquitetura do Clean Architure" src="/img/clean_architecture.jpg" width="400"/>

Se você não tem ideia do que estamos falando, pense neste modelo:
<br><img alt="Imagem da distribuição de camadas do Clean Architecture" src="/img/ca_layers.png" width="600" />

<details>
<summary>Estrutura de pastas</summary>

```
📁 Data                                // Camada de Dados (Cuida dos assuntos de Disco e Nuvem)
  📁 Features                          // Funcionalidades de Dados
    📁 Categories                      // Tudo relacionado a Categorias em Data
      📁 Repositories                  // Repositórios de Categorias
        📁 Cloud                       // Tudo relacionado a cloud (APIs, por exemplo)
          📁 Mappers                   // Mapeadores das classes cloud
            📄 CategoryRestMapper      // Mapeador de categorias cloud
            📄 UserRestMapper          // Mapeador de usuário cloud
          📁 Entities                  // Entidades utilizadas no cloud
                                       // (Aqui dentro podemos colocar pastas Request/Response caso necessário)
            📄 CategoryRest            // Entidade de Categoria para requisições cloud
            📄 UserRest                // Entidade de Usuário pra requisições cloud
          📄 CategoryCloudRepository   // Implementação do repositório cloud
          📄 ICategoryCloudRepository  // Interface do repositório de cloud
        📁 Disk                        // Tudo relacionado a disco (Banco de Dados, Arquivos)
          📁 Mappers                   // Mapeadores das classes disk
            📄 CategoryMySqlMapper     // Mapeador de categorias disk
            📄 UserSqlMapper           // Mapeador de usuário disk
          📁 Entities                  // Entidades utilizadas no disco
            📄 CategoryMySql           // Entidade de Categoria disco (como Banco de Dados, por exemplo)
            📄 UserMySql               // Entidade de Usuário disco (como Banco de Dados, por exemplo)
          📄 CategoryDiskRepository    // Implementação do repositório disco (aqui podemos ter um para MySql,
                                       // um para Postgres... mas todos devem implementar ICategoryDiskRepository)
          📄 ICategoryDiskRepository   // Interface do repositório de disco
      📄 CategoryService               // Implementação do Serviço de Categorias
    📁 Users                           // Tudo relacionado a Usuários em Data (mesmo exemplo acima)
📁 Domain                              // Camada de Domínio (Lógica e Regras de Negócio)
  📁 Features                          // Funcionalidades da Aplicação
    📁 Categories                      // Casos de Uso de Categorias
      📄 GetCategoriesUseCase          // Caso de Uso pegar todas as Categorias
      📄 GetCategoryByIdUseCase        // Caso de Uso para pegar uma Categoria por id
      📄 InsertCategoryUseCase         // Caso de Uso para inserir uma Categoria
    📁 Users                           // Casos de Uso de Usuários
      📄 CreateUserUseCase             // Cria um novo Usuário
      📄 UserLoginUseCase              // Tenta efetuar o login do Usuário
  📁 Entities                          // Modelos (Entidades) de Negócio
    📄 Category                        // Categoria
    📄 User                            // Usuário
  📁 Repository                        // Interfaces de Negócio
    📄 ICategoryRepository             // Interface para definir métodos de Categoria
    📄 IUserRepository                 // Interface para definir métodos de Usuário
📁 Presentation                        // Camada de Apresentação
  📁 Exceptions                        // Exceções de retorno da API
    📄 CategoryIdNotFound              // Exceção retornada quando não é encontrada a categoria
    📄 UserLoginException              // Exceção retornada quando o login/senha do usuário é inválido
  📁 Features                          // Controllers da aplicação
    📄 CategoryController              // Controller de Categoria
    📄 UserController                  // Controller de Usuário
  📁 Entities                          // Modelos (Entidades) exclusivos da Apresentação
    📁 Mappers                         // Mapeadores das entidades do Presentation
      📄 CategoryRequestMapper         // Mapeador de CategoryRequest
      📄 CategoryResponseMapper        // Mapeador de CategoryResponse
      📄 UserCreateRequestMapper       // Mapeador de UserCreateRequest
      📄 UserLoginRequestMapper        // Mapeador de UserLoginRequest
      📄 UserResponseMapper            // Mapeador de UserResponse
    📁 Requests                        // Em API's utilizamos para definir as entidades de entrada
      📄 CategoryRequest               // Entidade de requisição para Categorias
      📄 UserCreateRequest             // Entidade de requisição para criação de Usuários
      📄 UserLoginRequest              // Entidade de requisição para login de Usuários
    📁 Responses                       // Em API's utilizamos para definir as entidades de saída
      📄 CategoryResponse              // Entidade de requisição para resposta de Categorias
      📄 UserResponse                  // Entidade de requisição para resposta de Usuários
```
</details>

# Pacotes / Frameworks / Técnicas
* [Dependency Injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
* [Rx.NET](https://github.com/dotnet/reactive)
* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
* [Serilog](https://www.nuget.org/packages/serilog/)

# Contribuidores
<a href="https://github.com/RiseDevs/peace-erp/graphs/contributors"><img src="https://contrib.rocks/image?repo=RiseDevs/peace-erp" /></a>

# Autores
| [<img src="https://github.com/marcosrocha85.png?size=115" width=115><br><sub>@marcosrocha85</sub>](https://github.com/marcosrocha85) | [<img src="https://github.com/eimigueloliveir.png?size=115" width=115><br><sub>@eimigueloliveir</sub>](https://github.com/eimigueloliveir) |
| :---: | :---: |
