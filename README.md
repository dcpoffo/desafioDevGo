# desafioDevGo

### Aplicação desenvolvida para avaliação do Programa GoDEV_

## O Problema
A ProWay vai realizar um treinamento para uma grande empresa de TI de Blumenau, especializada em softwares de gestão. O treinamento será realizado em 2 etapas e as pessoas serão divididas em salas com lotação variável. Serão realizados também dois intervalos de café em 2 espaços distintos. Criar o sistema que gerenciará este evento.

## Bases Utilizadas
Para cadastrar treinamentos, serão usandas as base Pessoa, SalaTreinamento, SalaCafe, Etapa, HorarioCafe, PessoaSalaTreinamento. Estas bases armazenam e disponibilizam informações para o cadastro de treinamentos. Cada base é usada como Classe para o desenvolvimento da aplicação.

### Pessoa
Pessoas que farão o treinamento
```
Id int AUTO_INCREMENT
Nome longtext
Sobrenome longtext
```

### SalaTreinamento
Salas onde serão os treinamentos
```
Id int AUTO_INCREMENT
Nome longtext 
Lotacao int
```

### SalaCafe
Espaços onde será servido o vafé
```
Id int AUTO_INCREMENT
Nome longtext 
```

### Etapa
Horário de início e término dos treinamentos
```
Id int AUTO_INCREMENT,
fim datetime NOT NULL,
Inicio datetime NOT NULL,
```

### HorarioCafe
Horário de início e término para servir o café
```
Id int AUTO_INCREMENT,
fim datetime NOT NULL,
Inicio datetime NOT NULL,
```

### PessoSalaTreinamento
Onde serão armazenados os dados dos treinamentos
```
Id int AUTO_INCREMENT
SalaTreinamentoId int NOT NULL
PessoaId int NOT NULL
EtapaId int NOT NULL
HorarioCafeId int NOT NULL
SalaCafeId int NOT NULL
```

## Estrutura do Projeto
Aplicação principal, desenvolvida em Angular utilizando a IDE VSCode. Para o design das interfaces, foi utilizado Angular Material.
O projeto foi desenvolvido com a seguinte estrutura:

### front-end (\frontend)
```
ng new frontend
```

#### Estrutura do frontend
* components - para cada entidade, foi criado um componente para as ações Criar (create), Ler (read), Atualizar (update) e Apagar (delete)
```
ng generate component classe-acao
Ex.: ng generate component pessoa-read
```
 - views - Componente para "Apresentação" da entidade: opcão para um novo registro da entidade e a leitura (read) na mesma.
 - models - Modelo das Entidades utilizadas: Pessoa, SalaTreinamento, SalaCafe, Etapa, HorarioCafe, PessoaSalaTreinamento
 - services - Para cada entidade, foram criados servicos para comunicação com a API: getAll, getById, Post, Put, Delete, entre outros
```
ng generate service entidade
Ex.: ng generate service pessoa
```
A comunicação com a API é feita através dos caminhos:
```
baseURL = `${environment.mainUrlAPI}entidade`
mainUrlAPI: 'http://localhost:5000/'
Ex.:
getAll(): Observable<Pessoa[]> {
    return this.http.get<Pessoa[]>(this.baseURL).pipe(
    map((obj) => obj),
    catchError((e) => this.errorHandler(e))
);
```
Rotas
```
http://localhost:4200/pessoas
http://localhost:4200/salasTreinamento
http://localhost:4200/salasCafe
http://localhost:4200/etapas
http://localhost:4200/horariosCafe
http://localhost:4200/pessoasSalaTreinamento

http://localhost:4200/entidade/delete/id
http://localhost:4200/entidade/update/id

pesquisaPessoasResultado/id
pesquisaSalaTreinamentoResultado/id
pesquisaSalaCafeResultado/id
```

### back-end (\backend)
API desenvolvida em .Net Core para comunicação entre o Banco de Dados MySQL e a aplicação principal.
```
dotnet new webapi
```

#### Estrutura do backend
 - data
    - DataContext: através dele podemos acessar os métodos create, read, update, delete e outros metodos de interação com o banco de dados.
    - IRepository: interface que contém a assinatura de metodos padrões (Add, Update, Delete, SaveChanges) e referentes a cada modelo.
    - Repositoy: classe que implementa a interface IRepository.
 - Controllers: responsável por responder as requisições em nossa API.
 - models: modelo da aplicação, que seriam as referências as tabelas que temos no banco de dados.
 - Migrations: guarda informações das migrações qua são feitas. Através do comando abaixo, EF Core "liga" as informações contidas na pasta models com as contidas no DbContext e cria um esquema da nossa base de dados: banco e tabelas, criando um histórico dentro desta pasta.
Com o próximo comando, o EF cria/atualiza o banco de dados a partir da migração.
```
dotnet ef migrations add Nome-Migracao
dotnet ef database update
```

Depois de pronta, para testar a API, foi utilizado o Postman. O objetivo é fazer requisições HTTP e avaliar se as repostas (retornos) foram dentro do esperado.

## ---------------------------------
## Executando a aplicação no VSCode
## ---------------------------------

Para que a aplicação seja executada, deve-se abrir o terminal no VSCode e executar os seguintes comandos:
(os próximos dois passos, devem ser executados apenas na primeira vez ou somente quando necessário)
- Passo 1: dentro de \backend: (executar somente uma vez, para a criação da base de dados)
```
dotnet ef database update
```
- Passo 2: dentro de \frontend: 
O próximo passo faz-se necessário somente caso necessite baixar/atualizar alguma dependencia do projeto. Antes da primeira vez que for rodar a aplicação, deve-se baixar todas as dependencias do projeto, executando o procedimento abaixo.
```
npm update
```
(os passos a seguir, devem ser executados SOMENTE após os passos anteriores)
- Passo 3: dentro de \backend:
Para rodar a API 
```
dotnet watch run
```
- Passo 4: dentro de \frontend:
Para rodar a aplicação principal
```
npm start
```
Se não apresentar nenhum erro, pode-se acessar a aplicação pelo navegador, através do endereço http://localhost:4200

## Retornos
Retorno das requisições feitas através do Postman

### Obter Pessoas
- GetAll: obtem todos os Pessoas cadastradas
```` json
url = http://localhost:5000/pessoa
method = GET
{
    "id": 
    "nome":
    "sobrenome":
}
````
- GetById: obtem determinada pessoa pelo Id
```` json
url = http://localhost:5000/pessoa/id
method = GET
{
    "id": 
    "nome":       
    "sobrenome:
}
````

### Obter Salas disponiveis para Treinamento
- GetAll: obtem todas as Salas de Treinamento cadastradas
```` json
url = http://localhost:5000/salaTreinamento
method = GET
{
    "id": 
    "nome":
    "lotacao":
}
````
- GetById: obtem determinada Sala de Treinamento pelo Id
```` json
url = http://localhost:5000/salaTreinamento/id
method = GET
{
    "id": 
    "nome":       
    "lotacao:
}
````

### Obter Espaços para Cafe
- GetAll: obtem todos os Espaços para Café
```` json
url = http://localhost:5000/salaCafe
method = GET
{
    "id": 
    "nome":
}
````
- GetById: obtem determinado Espaços para Café pelo Id
```` json
url = http://localhost:5000/salaCafe/id
method = GET
{
    "id": 
    "nome":
}
````

### Obter Horários disponíveis para Treinamentos
- GetAll: obtem todos os Horários de Treinamento
```` json
url = http://localhost:5000/etapa
method = GET
{
    "inicio": 
    "fin":
}
````
- GetById: obtem determinado Horário de Treinamento pelo Id
```` json
url = http://localhost:5000/etapa/id
method = GET
{
    "inicio": 
    "fim":
}
````

### Obter Horario de Café
- GetAll: obtem todos os Horários de Café
```` json
url = http://localhost:5000/horarioCafe
method = GET
{
    "inicio": 
    "fin":
}
````
- GetById: obtem determinado Horário de Café pelo Id
```` json
url = http://localhost:5000/horarioCafe/id
method = GET
{
    "inicio": 
    "fim":
}
````

### Obter Informaçoes sobre Treinamentos
- GetAll: obtem todos os treinamentos, trazendo Sala de Treinamento, a Pessoa, a Etapa (horário do Treinamento), Espaço para Café e Horario de Café vinculados
```` json
url = http://localhost:5000/pessoaSalaTreinamento
method = GET
{
    "id":
    "salaTreinamentoId":
    "pessoaId":
    "etapaId":
    "salaCafeId":
    "horarioCafeId":
}
````
- GetById: obtem informações de determinado Treinamento pelo Id
```` json
url = http://localhost:5000/pessoaSalaTreinamento/id
method = GET
{
    "id":
    "salaTreinamentoId":
    "pessoaId":
    "etapaId":
    "salaCafeId":
    "horarioCafeId":
    }
}
````
- GetByPessoaId: obtem os treinamentos de determinada pessoa, trazendo Sala de Treinamento, a Pessoa, a Etapa (horário do Treinamento), Espaço para Café e Horario de Café vinculados
```` json
url = http://localhost:5000/pessoaSalaTreinamento/pessoaId=
````
- GetBySalaTreinamentoId: obtem uma lista de pessoas cadastradas em treinamentos em determinada sala, trazendo Sala de Treinamento, a Pessoa, a Etapa (horário do Treinamento), Espaço para Café e Horario de Café vinculados
```` json
url = http://localhost:5000/pessoaSalaTreinamento/salaTreinamentoId=
````
- GetBySalaCafeId: obtem uma lista de pessoas cadastradas em treinamentos em determinada sala (espaço) de café, trazendo Sala de Treinamento, a Pessoa, a Etapa (horário do Treinamento), Espaço para Café e Horario de Café vinculados
```` json
url = http://localhost:5000/pessoaSalaTreinamento/salaCafeId=
```` json
method = GET
{
        "id":
        "salaTreinamentoId": 
        "pessoaId": 
        "etapaId": 
        "salaCafeId": 
        "horarioCafeId": 
        "salaTreinamento": {
            "id": 
            "nome": 
            "lotacao": 
        },
        "pessoa": {
            "id": 
            "nome": 
            "sobrenome": 
        },
        "etapa": {
            "id":
            "inicio": 
            "fim": 
        },
        "salaCafe": {
            "id": 
            "nome":
        },
        "horarioCafe": {
            "id": 
            "inicio": 
            "fim":
        }
    }
````
