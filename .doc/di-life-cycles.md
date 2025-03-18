## Dependency Injection - Ciclos de Vida

Neste módulo, abordaremos os tipos de ciclo de vida que um objeto pode ter dentro do container de Injeção de Dependência do .NET Core. Para aprofundar esse tema, recomendo a leitura da documentação oficial sobre Injeção de Dependência no ASP.NET Core. Embora seja voltada para ASP.NET Core, ela também explica como o .NET Core gerencia seu container nativo.

A documentação define três tipos principais de ciclo de vida:

### Transient

O Transient é o modelo padrão e o mais comum quando não há uma escolha específica sobre qual ciclo utilizar. Esse modelo define que uma nova instância do objeto será criada sempre que for injetada em alguma classe.

- **Recomendado para:** Objetos leves e serviços sem estado.
- **Vantagem:** Evita compartilhamento de estado entre requisições.
- **Desvantagem:** Pode consumir mais memória, pois cada solicitação cria uma nova instância do objeto.

**Como funciona?**
```

services.AddTransient<IMeuServico, MeuServico>();

```

A cada vez que IMeuServico for solicitado, uma nova instância de MeuServico será criada.

### Scoped

O ciclo Scoped garante que um objeto seja criado apenas uma vez por client request, ou seja, por requisição HTTP.

- **Recomendado para:** Aplicações Web, onde o mesmo objeto pode ser reutilizado durante toda a requisição.
- **Vantagem:** Melhora a eficiência do uso de memória ao evitar múltiplas instâncias desnecessárias.

Atenção ao usar em Middleware! A documentação do .NET recomenda que, ao utilizar serviços Scoped em um middleware, injete-os dentro dos métodos Invoke ou InvokeAsync e não via construtor, pois isso pode causar um comportamento semelhante a um Singleton.

**Como funciona?**
```

services.AddScoped<IMeuServico, MeuServico>();

```

Dentro da mesma requisição HTTP, todas as chamadas para IMeuServico reutilizarão a mesma instância de MeuServico.<br />

### Singleton

O Singleton cria uma única instância do objeto para toda a aplicação e a mantém ativa durante todo o tempo de execução.

- **Recomendado para:** Objetos que devem ser compartilhados globalmente e não dependem do estado do usuário.
- **Vantagem:** Evita a necessidade de recriação de objetos, economizando recursos.
- **Desvantagem:** Pode gerar problemas de concorrência e segurança, especialmente se utilizado com o Entity Framework Core.

- Risco do Singleton com EF Core
Imagine um contexto do Entity Framework Core compartilhado entre todos os usuários da aplicação. Se múltiplos usuários estiverem editando, salvando ou excluindo dados simultaneamente, isso pode causar conflitos e expor falhas de segurança.

**Como funciona?**  
```

services.AddSingleton<IMeuServico, MeuServico>();

```

Toda a aplicação compartilhará uma única instância de MeuServico.

**Qual ciclo de vida utilizar?** <br />

- Para aplicações Web, o uso recomendado é Scoped, pois cada requisição tem sua própria instância.
- Se não houver certeza sobre qual ciclo usar, Transient é a opção mais segura, pois evita compartilhamento indesejado.
- Singleton deve ser usado com cautela, garantindo que o objeto não mantenha estado sensível ao usuário.

### Conclusão

Os ciclos de vida da Injeção de Dependência são fundamentais para garantir a eficiência e segurança da aplicação. A escolha errada pode levar a consumo excessivo de memória (com Transient) ou problemas de concorrência e segurança (com Singleton).

Em nosso projeto, veremos exemplos práticos de cada um desses ciclos de vida, para que você possa aplicá-los corretamente conforme a necessidade da sua aplicação.


<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="di-introduction.md">Voltar: Dependency Injection</a><br />  
</div>
