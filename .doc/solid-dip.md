## DIP - Dependency Inversion Principle

Neste módulo, abordaremos o DIP **(Dependency Inversion Principle)**, também conhecido como Princípio da Inversão de Dependência ou Inversão de Controle. Ambas as formas são aceitas e se referem ao mesmo conceito, que está diretamente ligado à abstração.

> “Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações; abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.”

Uma forma mais direta de interpretar esse princípio é:

> “Dependa de abstrações, não de implementações.”

### O que isso significa na prática?

Já entendemos que implementação refere-se a uma classe concreta, enquanto abstração se dá por meio de interfaces ou classes abstratas. O DIP nos ensina que:

- Classes de alto nível (responsáveis por regras de negócio) não devem depender diretamente de classes concretas.
- Tanto classes de alto nível quanto de baixo nível devem depender de abstrações (interfaces ou classes abstratas).
- As abstrações nunca devem depender de detalhes, mas sim o contrário.

### A importância do DIP dentro do SOLID

O DIP é um dos princípios mais importantes do SOLID, pois torna todos os outros princípios mais aplicáveis. Sem ele, o próprio **SRP (Princípio da Responsabilidade Única)** perderia seu propósito, pois um código fortemente acoplado dificulta a separação de responsabilidades.

### Demonstração Prática

Neste módulo, veremos:

- Um exemplo de violação do DIP.
- Uma solução correta aplicando o princípio.

Ao final, você compreenderá como a inversão de dependência melhora a flexibilidade, manutenibilidade e testabilidade do código, garantindo uma arquitetura mais robusta e sustentável.

<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="solid-isp.md">Voltar: ISP – Interface Segregation Principle</a><br />  
</div>