## OCP - Open Closed Principle

Neste módulo, abordaremos o OCP (Open Closed Principle), que representa a letra "O" do SOLID e estabelece o seguinte conceito: 

> "Entidades de software (classes, módulos, funções, etc.) devem estar abertas para extensão, mas fechadas para modificação." 

Esse princípio pode parecer controverso para algumas pessoas, pois muitos se perguntam: 
- "Como assim fechada para modificação?
- Quer dizer que eu não posso alterar minha classe?"

De preferência, não. A ideia do OCP é que uma classe deve estar fechada para modificações diretas e aberta para ser estendida. Isso significa que, ao invés de modificar uma classe existente sempre que surgir um novo requisito, devemos criar extensões para adicionar novos comportamentos sem alterar o código original. 

**Quando modificar e quando estender?**<br />

Ao aplicar esse princípio, devemos nos perguntar:<br /> 

A alteração é para corrigir um comportamento existente? 
- Se sim, a modificação na classe original pode ser necessária. 

**A alteração é para adicionar um novo comportamento?**<br /> 
- Se sim, devemos priorizar a extensão da classe, evitando modificações diretas. 

O OCP não proíbe modificações, mas incentiva um design de código que minimize alterações diretas sempre que possível. Isso melhora a manutenção, reutilização e testabilidade do código. 

### Aplicando o OCP na prática 

Este princípio é melhor compreendido por meio de exemplos de código. No nosso projeto, veremos:<br /> 

- Um exemplo de violação do OCP. 
- Uma solução utilizando Herança. 
- Uma solução utilizando Extensão de Métodos. 

**Ao entender esses exemplos, você perceberá que há diversas oportunidades em que poderia ter aplicado o OCP para tornar seu código mais flexível e sustentável.**



<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="solid-srp.md">Voltar: SRP – Single Responsibility Principle</a><br />  
</div>