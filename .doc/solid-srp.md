## SRP – Single Responsibility Principle
Neste módulo, abordaremos o SRP (Single Responsibility Principle), ou Princípio da Responsabilidade Única, que estabelece o seguinte conceito:

> "Uma classe deve ter apenas um motivo para ser modificada."

Esse princípio é o primeiro e mais importante do SOLID, além de ser o mais simples de entender. A responsabilidade única refere-se ao propósito de uma classe. Se uma classe tem apenas um motivo para ser modificada, isso significa que ela realiza apenas uma função específica.

### Exemplo de Violação do SRP

Vamos considerar uma classe que envia e-mails. Por que ela poderia ser modificada no futuro?

- Se a forma de envio de e-mails mudar (exemplo: trocar de SMTP para API de terceiros).
- Se, além de enviar e-mails, essa classe também formatar o texto em HTML e substituir imagens.

Se a classe tem múltiplas responsabilidades, ela pode precisar ser alterada por motivos diferentes, tornando seu código mais difícil de manter e escalar.

### Aplicação do SRP Além das Classes

O SRP não se aplica apenas a classes, mas também a outros níveis do código:

- Camadas de uma aplicação → A camada de negócios deve lidar apenas com regras de negócio, sem interagir com detalhes de infraestrutura.
- Métodos dentro de uma classe → Um método deve ser responsável por uma única tarefa bem definida.

Muitas vezes, há um equívoco sobre SRP, onde algumas pessoas acreditam que uma classe não pode ter vários métodos. No entanto, o número de métodos não importa, desde que todos contribuam para a única responsabilidade da classe.

### Exemplo Correto de Aplicação do SRP

Uma classe que envia e-mails pode ter múltiplos métodos que compõem esse envio, como:

```
    public class EmailSender
    {
        public void SendEmail(string recipient, string subject, string body)
        {            
            string formattedBody = FormatBody(body);            
        }

        private string FormatBody(string body)
        {
            return "<html><body>" + body + "</body></html>";
        }
    }

```

**Nesse caso:**
- A classe mantém apenas a responsabilidade de envio de e-mails.
- A formatação do corpo do e-mail é um detalhe interno do processo.
- Se essa classe também lidasse com armazenamento de logs ou geração de relatórios, estaria violando o SRP.

**Conclusão**

Com o SRP em mente, devemos sempre questionar:

- Esta classe está assumindo mais responsabilidades do que deveria?
- Podemos dividir essa funcionalidade para melhorar a separação de responsabilidades?

**Ao seguir esse princípio, garantimos um código mais modular, reutilizável e de fácil manutenção.**

<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="poo.md">Voltar: Princípios SOLID</a><br />  
</div>