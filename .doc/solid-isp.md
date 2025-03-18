## ISP - Interface Segregsation Principle

Neste módulo, abordaremos o ISP **(Interface Segregation Principle)**, ou Princípio da Segregação de Interface.

> “Clientes não devem ser forçados a depender de métodos que não usam.”

Para entender essa frase, precisamos interpretar o que significa "clientes" nesse contexto. Aqui, clientes referem-se às classes que implementam interfaces. O princípio estabelece que uma classe não deve ser obrigada a implementar métodos que não são relevantes para ela.

## Por que isso é importante?

Quando utilizamos interfaces muito grandes, acabamos forçando classes a implementar métodos desnecessários. Isso gera código acoplado, difícil de manter e que viola o princípio da responsabilidade única.

Uma forma alternativa de expressar esse princípio é:

> “Muitas interfaces específicas são melhores do que uma única interface grande.”

## Aplicação do ISP na Prática

O ISP propõe que, ao invés de criarmos interfaces genéricas e inchadas, devemos segmentá-las em interfaces menores e mais específicas, garantindo que cada classe implemente apenas o que realmente precisa.

## Demonstração Prática

No nosso projeto, veremos:

- Um exemplo de violação do ISP. 
- Uma solução correta aplicando o princípio.

Ao final desse módulo, você entenderá como segregar interfaces corretamente, tornando seu código mais flexível, desacoplado e fácil de manter.

<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="solid-lsp.md">Voltar: LSP – Liskov Substitution Principle</a><br />  
</div>