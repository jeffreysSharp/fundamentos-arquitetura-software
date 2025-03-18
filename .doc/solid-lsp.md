## LSP - Liskov Substitution Principle
Neste módulo, abordaremos o LSP (Liskov Substitution Principle), ou Princípio da Substituição de Liskov. Esse princípio leva o nome de Barbara Liskov, uma cientista da computação que foi a primeira mulher a receber um Ph.D. na área.

O LSP é um princípio fundamental do SOLID, mas pode ser um pouco complexo de compreender no início. Ele estabelece que:

> “Se q(x) é uma propriedade demonstrável dos objetos x do tipo T, então q(y) deve ser verdadeiro para objetos y do tipo S, onde S é um subtipo de T.”

Essa definição pode parecer complicada, mas sua interpretação prática é bem simples:<br />

> “Subclasses devem ser substituíveis por suas superclasses.”

### O que isso significa?

Uma subclasse é uma classe especializada que herda de uma superclasse (ou classe base). O LSP afirma que uma subclasse deve ser capaz de substituir sua superclasse sem causar problemas no código.

Mesmo com essa explicação, pode ser difícil entender por que isso é tão importante. Então, vejamos um exemplo clássico:<br />

### O Exemplo do Pato e o Problema da Abstração

Uma frase que ilustra bem o LSP é:

> “Se nada como um pato, voa como um pato, mas precisa de baterias, então provavelmente há um problema na abstração.”

**Esse conceito pode ser aplicado ao seguinte cenário:**<br />

- Imagine que temos uma classe base chamada Pato, com os métodos Nadar() e Voar().

- Agora, queremos criar uma subclasse chamada PatoDeBrinquedo, que herda de Pato.

- O problema surge quando tentamos substituir um Pato por um PatoDeBrinquedo. Ao chamarmos Voar(), o PatoDeBrinquedo não pode voar — ele precisa de baterias!

Isso cria uma desconexão na abstração: PatoDeBrinquedo não pode ser tratado como um Pato real sem gerar problemas. Essa violação do LSP nos mostra que a herança foi mal aplicada. Uma solução melhor seria usar composição ao invés de herança, garantindo que a classe PatoDeBrinquedo tenha apenas os comportamentos adequados.

### O LSP como Teste para uma Boa Herança

O Princípio da Substituição de Liskov funciona como uma prova real da herança. Se você quer garantir que uma subclasse realmente deveria herdar de uma superclasse, aplique o LSP:

- Se a subclasse puder substituir a superclasse sem causar problemas, a herança está correta.
- Se a substituição gerar inconsistências no comportamento esperado, então a herança foi mal aplicada.

## Demonstração Prática

No nosso projeto, veremos:

- Um exemplo de violação do LSP.
- Uma solução correta para esse problema.

**Ao final desse módulo, você entenderá quando a herança deve ou não ser utilizada, garantindo um código mais flexível e bem estruturado.**


<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="solid-ocp.md">Voltar: OCP – Open Closed Principle</a><br />  
     <a href="solid-lsp.md">Voltar: OCP – Interface Segregation Principle</a><br />  
</div>