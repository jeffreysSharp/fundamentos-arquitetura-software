# Fundamentos da Arquitetura de Software .NET 9 | C# 13
## Olá, seja bem-vindo ao curso de Arquitetura de Software!

Eu sou Jeferson Almeida, profissional com 22 anos de experiência no desenvolvimento de sistemas dinâmicos e interativos para a web, com forte expertise em usabilidade, arquitetura da informação e engenharia de software. Minha especialização está na análise e desenvolvimento de sistemas de larga escala e baixa latência, sempre focando em soluções eficientes, escaláveis e de alto desempenho. 

Serei o seu instrutor neste curso, que representa o primeiro passo na jornada para se tornar um Arquiteto de Software. Ao longo das aulas, abordaremos todos os fundamentos essenciais que um desenvolvedor precisa dominar para aprimorar suas habilidades e evoluir para um nível técnico mais avançado. 

Vale ressaltar que este curso não é exclusivo para quem deseja se tornar um Arquiteto, mas sim um aperfeiçoamento técnico indispensável para todos os desenvolvedores que buscam excelência na criação de sistemas robustos e bem estruturados. 

Antes de alcançar esse nível, é essencial ser um desenvolvedor altamente qualificado. Por isso, os conceitos abordados neste curso são fundamentais para qualquer profissional que aspire a essa posição. 

Além disso, este curso é ideal para desenvolvedores que desejam aprimorar suas habilidades, adotando boas práticas de programação e padrões exigidos em projetos de alto nível e grande escala. 

Ao final, você terá adquirido um conhecimento sólido que permitirá não apenas evoluir como desenvolvedor, mas também dar os primeiros passos rumo à Arquitetura de Software. 

Todos os exemplos apresentados ao longo do curso foram desenvolvidos com **.NET Core 9.0 e C# 13**, garantindo que você aprenda com as tecnologias mais recentes do mercado. 

## O que é Arquitetura de Software

Existe muita confusão na separação de responsabilidades entre um Arquiteto de Software e um Desenvolvedor de Software. Para entender essa distinção, é fundamental saber o que é Arquitetura e, consequentemente, onde termina o papel do desenvolvedor e onde começa o do Arquiteto. 

A resposta é simples! 

> “Arquitetura é a organização fundamental de um sisterma incorporada em seus componentes, relacionamentos com o ambiente e os princípios que conduzem o seu design e evolução.”   

Essa definição está documentada na **ISO/IEC/IEEE 42010:2022**, um padrão internacional que estabelece diretrizes para a Arquitetura de Sistemas e Software. 

Portanto, existe um padrão bem definido para caracterizar Arquitetura, e isso se aplica não apenas ao desenvolvimento de software, mas a qualquer sistema dentro da Tecnologia da Informação. Ou seja, a Arquitetura é a organização fundamental de um sistema, e esse sistema não é apenas um software, mas sim uma estrutura integrada, composta por componentes e seus relacionamentos. 

Para mais detalhes, acesse:<br /> 
[ISO/IEC/IEEE 42010:2022](https://www.iso.org/obp/ui/en/#iso:std:iso-iec-ieee:42010:ed-2:v1:en)

### Finalizando o Assunto: Como Conceituar, Definir e Gerenciar a Governança da Arquitetura? 

Essas são perguntas que talvez você ainda não tenha feito, mas grandes arquitetos de empresas gigantes já fizeram: 

- Como conceituar a Arquitetura? 
- Como definir a Arquitetura? 
- Como gerir a governança da Arquitetura? 

A conceituação da Arquitetura é essencial para garantir que exista um entendimento padronizado sobre o que realmente é Arquitetura. Quem define isso? Existe algum órgão ou entidade que estabelece um padrão? Ou cada um define Arquitetura por conta própria? 

Além disso, como podemos formalizar essa definição e garantir governança arquitetural dentro de uma empresa? Imagine que você trabalha em uma grande multinacional e precisa definir uma governança de Arquitetura para que todas as filiais e equipes de TI sigam diretrizes unificadas, garantindo padrões mínimos e um pensamento compartilhado sobre Arquitetura. 

Para isso, existem dois conceitos fundamentais que ajudam a estruturar a governança da Arquitetura de Software, sendo um deles o **The Open Group Architecture Framework (TOGAF). 
**
 

### O Que é o TOGAF? 

O The Open Group Architecture Framework (TOGAF) é um framework de Arquitetura que fornece uma abordagem estruturada para projetar, planejar, implementar e governar a Arquitetura Empresarial de uma organização. 

Mas atenção: TOGAF não é apenas um modelo de arquitetura em camadas ou um simples template de design. Ele vai muito além disso. 

Para você ter uma ideia, o manual do TOGAF tem cerca de 900 páginas e cobre diversos aspectos essenciais da Arquitetura Empresarial. 

Uma analogia interessante: 
Se o PMBOK é um guia para gestão de projetos, o TOGAF é o equivalente para Arquitetura Empresarial. 

 

### Por que o TOGAF não é Amplamente Utilizado? 

Muitas empresas e arquitetos desconhecem ou não adotam o TOGAF, pois ele é extremamente complexo e detalhado. No entanto, ele é amplamente utilizado em grandes corporações que buscam padronização e governança robusta. 

O TOGAF cobre temas como: 
- Padrões Arquiteturais e boas práticas para implementação. 
- Migration Planning – planejamento da evolução da arquitetura. 
- Governança e Gestão de Mudanças na arquitetura de sistemas. 
- Interação com diferentes níveis de administração dentro da organização. 
- Princípios de Arquitetura – definição de qualidade, governança e estratégias. 
- Atendimento às áreas de negócios, dados e tecnologia dentro da empresa. 
- Frameworks e técnicas para gestão de Arquitetura Empresarial. 

Diferente de guias mais técnicos que abordam design patterns, o TOGAF se concentra em um nível conceitual e estratégico, orientado a grandes empresas e ambientes corporativos complexos. 

Ele também define entregáveis arquiteturais, porém de forma conceitual, sem foco em implementação prática. 

### TOGAF: Um Framework para Poucos? 

Sinceramente, o TOGAF não é para todos. Seu nível de formalidade e complexidade não é necessário para todas as empresas, pois pode tornar-se excessivamente burocrático. 

No entanto, para empresas que precisam de uma arquitetura altamente organizada e padronizada, o TOGAF pode ser um diferencial estratégico. Inclusive, existem certificações TOGAF com diferentes níveis, voltadas para arquitetos que desejam atuar no nível mais alto da Arquitetura Empresarial. 

No final das contas, o TOGAF é um framework poderoso, projetado para permitir que toda a organização fale a mesma língua arquitetural, garantindo alinhamento, eficiência e governança sólida. 

Se o seu objetivo é atuar como um Arquiteto de Software em empresas de grande porte, conhecer o TOGAF pode ser um diferencial significativo. 

O outro framework relevante que posso apresentar é a própria ISO/IEC/IEEE 42010, que trata sobre Sistemas de Software, Engenharia de Software e descrição de Arquitetura. 

Embora seja um documento mais curto em comparação ao TOGAF, ele ainda assim aborda conceitos fundamentais sobre Engenharia de Software, descrição de Arquitetura e relacionamentos entre componentes e ambientes. 

Para quem busca um entendimento mais acadêmico e conceitual, esse documento é uma excelente referência. Ele é especialmente útil para aqueles que desejam aprofundar-se em pesquisa e teoria da Arquitetura de Software. 

Contudo, vale ressaltar que ler esse documento ou aplicar TOGAF não faz de ninguém um Arquiteto de Software. O verdadeiro papel da Arquitetura vai muito além de simplesmente estruturar uma aplicação em camadas e fazê-la funcionar. Arquitetura é um conceito mais amplo e estratégico, que exige visão sistêmica, tomada de decisão e alinhamento com os objetivos do negócio. 

Com essas reflexões e diretrizes, encerramos este módulo, deixando claro que Arquitetura de Software é um campo profundo, estratégico e essencial para a construção de sistemas bem estruturados e escaláveis. 


### Perfil do Arquiteto de Software 

### Responsabilidades do Arquiteto de Software 
O Arquiteto de Software é um dos profissionais mais estratégicos na Engenharia de Software, pois atua no planejamento, design e definição das diretrizes técnicas para garantir que o Sistema seja escalável, seguro, eficiente e alinhado às necessidades do negócio. 

Abaixo estão suas principais responsabilidades: 

### Definição da Arquitetura do Sistema 
- Criar e documentar a Arquitetura do software, definindo padrões, tecnologias e frameworks. 
- Escolher modelos arquiteturais adequados, como Monólito, Microsserviços, Serverless ou Event-Driven Architecture (EDA). 
- Estruturar o software em camadas, módulos e componentes, garantindo alta coesão e baixo acoplamento. 
- Garantia de Qualidade e Padrões Técnicos 
- Definir boas práticas de desenvolvimento, como Clean Code, SOLID e Domain-Driven Design (DDD). 
- Estabelecer padrões de testes automatizados (unitários, integração e carga) para garantir a confiabilidade do sistema. 
- Monitorar Code Review e Pair Programming, assegurando qualidade no código-fonte. 

### Escolha de Tecnologias e Ferramentas 
- Avaliar e selecionar frameworks, bibliotecas, bancos de dados, ferramentas de CI/CD e soluções cloud. 
- Garantir compatibilidade e integração entre tecnologias dentro do ecossistema da empresa. 
- Definir padrões de API REST, gRPC, GraphQL e mensageria (Kafka, RabbitMQ) para integração eficiente. 

### Escalabilidade e Performance
- Planejar soluções para alta escalabilidade, garantindo que o sistema suporte picos de acesso.
- Definir estratégias de cache (Redis, Memcached) e otimizações de banco de dados (indexação, sharding, partitioning). 
- Utilizar técnicas de Load Balancing e Auto Scaling em ambientes cloud (AWS, Azure, GCP). 

### Segurança e Conformidade 
- Implementar práticas de segurança para prevenir ataques como SQL Injection, XSS, CSRF.
- Definir políticas de autenticação e autorização (OAuth2, JWT, OpenID Connect). 
- Garantir conformidade com LGPD, GDPR e outras regulamentações. 

### Integração Contínua e DevOps 
- Trabalhar com CI/CD (Continuous Integration / Continuous Deployment) para automação de deploys. 
- Garantir um pipeline eficiente, utilizando ferramentas como Docker, Kubernetes, Terraform e Ansible. 
- Monitorar e otimizar logs, métricas e health checks com Prometheus, Grafana e Elastic Stack. 

### Comunicação e Alinhamento com as Equipes
- Atuar como ponte entre desenvolvedores, gerentes de produto e stakeholders.
- Explicar decisões arquiteturais para times técnicos e não técnicos. 
- Garantir que os times sigam a arquitetura definida, oferecendo mentoria e suporte técnico. 

### Governança e Evolução da Arquitetura
- Criar e manter documentação arquitetural utilizando C4 Model, UML e ADR (Architecture Decision Records).
- Realizar revisões periódicas da arquitetura para adaptar-se a novas necessidades do negócio.
- Definir políticas de governança, padronização e versionamento de código e APIs. 

### Conclusão 
O Arquiteto de Software tem um papel estratégico e técnico, garantindo que o sistema seja escalável, seguro, performático e bem estruturado. Ele não é apenas um desenvolvedor experiente, mas sim um profissional que toma decisões de alto nível, guiando a equipe para construir softwares robustos e alinhados aos objetivos da empresa. 


## Pilares da Programação Orientada a Objetos (OOP)
Neste módulo, exploraremos a Programação Orientada a Objetos (OOP), um conceito fundamental na engenharia de software. Você provavelmente já teve contato com OOP na faculdade, em cursos de programação ou até mesmo por conta própria, e pode considerá-la um conceito simples.

No entanto, aqui iremos aprofundar o estudo com seriedade, analisando suas bases, aplicações práticas e melhores práticas, garantindo uma compreensão sólida e avançada da Programação Orientada a Objetos.

### A Origem da Programação Orientada a Objetos
O termo Programação Orientada a Objetos (POO) foi criado por Alan Kay, o mesmo criador da linguagem Smalltalk. Embora esse paradigma tenha sido desenvolvido anteriormente, sua popularização ocorreu principalmente na década de 1990, consolidando-se como um dos modelos mais utilizados no desenvolvimento de software.

A POO é um paradigma essencial no desenvolvimento de software moderno. Ela permite organizar o código de forma intuitiva, reutilizável e escalável. No C#, a POO é amplamente utilizada para desenvolver aplicações robustas e modulares.

### Os Pilares Fundamentais da Programação Orientada a Objetos
Os pilares fundamentais da Programação Orientada a Objetos são:
- Estado e comportamento (definição dos atributos e métodos dos objetos).
- Abstração (ocultar detalhes internos e expor apenas o essencial).
- Herança (compartilhamento de características entre classes).
- Polimorfismo (capacidade de um método ter diferentes implementações).
- Encapsulamento (restringir o acesso direto aos dados internos de um objeto).

### A Importância da OOP no Mercado
- Dominar os princípios da Orientação a Objetos é essencial para:
- Aplicar boas práticas de design de código e padrões arquiteturais.
- Trabalhar com .NET, Java e outros frameworks populares.
- Ter um diferencial competitivo no mercado de trabalho.
- Passar por entrevistas técnicas e explicar conceitos com exemplos claros.
- Implementar design patterns e estilos arquiteturais corretamente.

Embora existam outras abordagens, como a programação funcional, a maioria das empresas ainda utiliza OOP em grande escala. Se você deseja ter oportunidades no mercado, é essencial dominar esses conceitos.

### Baixo Acoplamento e Alta Coesão: Conceitos Essenciais
Dois conceitos fundamentais na OOP são baixo acoplamento e alta coesão. Muitas pessoas mencionam esses termos sem realmente entendê-los, então vamos esclarecer.

### O Que é Acoplamento?
O acoplamento refere-se ao grau de dependência entre objetos. Se um objeto depende diretamente de outro, qualquer alteração pode impactar ambos, gerando fragilidade no código.

### Exemplo de alto acoplamento:**
Quando uma classe instancia diretamente outra classe dentro dela, ou quando a herança é mal utilizada, causando forte dependência entre os objetos.

**Se um objeto muda, o outro também é impactado.**

### O Que é Coesão?
A coesão representa o grau de responsabilidade única de um objeto. Um sistema com alta coesão possui módulos independentes, cada um executando uma única responsabilidade sem depender fortemente de outros.

### Exemplo de alta coesão:
Classes trabalhando lado a lado, cada uma cumprindo seu papel específico, sem dependências desnecessárias.

## Se um objeto muda, os outros continuam funcionando normalmente.

### Acoplamento vs. Coesão
| Conceito     | Definição                                      | Impacto no Código                                                 |
|--------------|------------------------------------------------|-------------------------------------------------------------------|
| Acoplamento  | Dependência direta entre objetos               | Torna o código rígido e frágil, dificultando a manutenção.        |
| Coesão       | Cada objeto executa uma única responsabilidade | Facilita a manutenção e reuso, tornando o código mais organizado. |

### Aplicando na Prática
No desenvolvimento orientado a objetos, devemos sempre buscar baixo acoplamento e alta coesão. Isso melhora a manutenibilidade, reutilização e escalabilidade do código.

Agora que entendemos esses princípios fundamentais, vamos explorar em detalhes cada um dos pilares da OOP! 

## Estado e comportamento 

Agora vamos aprofundar ainda mais os conceitos da Programação Orientada a Objetos (OOP). A partir deste ponto, utilizaremos um modelo prático, um projeto especialmente desenvolvido para demonstrar exemplos reais de cada conceito abordado. 

Para acompanhar e praticar os exemplos, você pode fazer o download do projeto diretamente no meu repositório do GitHub: 

Repositório no GitHub: 
https://github.com/jeffreysSharp/fundamentos-arquitetura-software 
 
Através desse projeto, iremos explorar os fundamentos da OOP na prática, garantindo um aprendizado mais dinâmico e aplicável ao mercado de trabalho. 

## Estrutura do projeto
Este projeto segue a estrutura apresentada na imagem abaixo, proporcionando uma organização clara e modular para facilitar o entendimento e a implementação dos conceitos abordados. 

![](.doc/img/1-estrutura-solucao.JPG)

Com este projeto base, você poderá acompanhar os módulos, experimentar os conceitos na prática, realizar testes e explorar diferentes implementações.

Neste módulo, você aprenderá dois conceitos fundamentais da Programação Orientada a Objetos: Classes e Objetos.

## Definições de Classes
A classe é um dos conceitos fundamentais da Programação Orientada a Objetos (OOP). Em C#, classes servem como modelos para criar objetos, encapsulando atributos (dados) e métodos (comportamentos).

## O Que é uma Classe?
Uma classe é uma estrutura de código que define um conjunto de propriedades (atributos) e comportamentos (métodos) de um objeto. Ela funciona como um molde para a criação de instâncias (objetos) que compartilham as mesmas características e funcionalidades.

### Estrutura Básica de uma Classe
```
public class ClassName
{
    // Atributos (Propriedades)
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    // Construtor
    public ClassName(int property1, string property2)
    {
        Property1 = property1;
        Property2 = property2;
    }

    // Método
    public void Method()
    {
        Console.WriteLine("Executando método!");
    }
}

```

### Características das Classes
- Encapsulam atributos e comportamentos.
- Possuem modificadores de acesso (public, private, protected, etc.).
- Podem ter construtores para inicialização de objetos.
- Podem herdar de outras classes (herança).
- Podem implementar interfaces para definir contratos de comportamento.

### Criando uma Classe House (Casa)                
Vamos criar uma classe House, que representará uma casa com atributos (cor, número de quartos, tamanho) e métodos (abrir porta, fechar porta, exibir informações).

```
public class House
{
    // Atributos (Propriedades)
    public string Color { get; set; }
    public int NumberOfRooms { get; set; }
    public double Size { get; set; } // Tamanho em metros quadrados

    // Construtor
    public House(string color, int numberOfRooms, double size)
    {
        Color = color;
        NumberOfRooms = numberOfRooms;
        Size = size;
    }

    // Métodos
    public void OpenDoor()
    {
        Console.WriteLine("A porta foi aberta!");
    }

    public void CloseDoor()
    {
        Console.WriteLine("A porta foi fechada!");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Casa de cor {Color}, com {NumberOfRooms} quartos e {Size}m².");
    }
}

```

### Criando e Utilizando um Objeto da Classe House
Agora, vamos instanciar um objeto da classe House e chamar seus métodos.

```

class Program
{
    static void Main()
    {
        // Criando um objeto da classe House
        House myHouse = new House("Azul", 3, 120.5);
        
        // Exibindo informações
        myHouse.DisplayInfo();
        
        // Abrindo e fechando a porta
        myHouse.OpenDoor();
        myHouse.CloseDoor();
    }
}

```

**Saída Esperada:**

```
Casa de cor Azul, com 3 quartos e 120.5m².
A porta foi aberta!
A porta foi fechada!

```

### Construtores e Sobrecarga de Métodos
Em C#, uma classe pode ter múltiplos construtores (sobrecarga) para permitir diferentes formas de inicialização.

```

public class House
{
    public string Color { get; set; }
    public int NumberOfRooms { get; set; }
    public double Size { get; set; }

    // Construtor padrão
    public House()
    {
        Color = "Branco";
        NumberOfRooms = 2;
        Size = 80;
    }

    // Construtor com parâmetros
    public House(string color, int numberOfRooms, double size)
    {
        Color = color;
        NumberOfRooms = numberOfRooms;
        Size = size;
    }
}

```

Agora podemos criar uma casa com valores padrões ou definir atributos personalizados.

```

House house1 = new House();
House house2 = new House("Vermelha", 4, 150);

```

Os modificadores de acesso controlam a visibilidade dos membros de uma classe. Os principais são:

| Modificador | Descrição                                                                 |
|-------------|---------------------------------------------------------------------------|
| public      | Acesso permitido de qualquer lugar.                                       |
| private     | Acesso permitido apenas dentro da classe.                                 |
| protected   | Acesso permitido apenas na classe e subclasses.                           |
| internal    | Acesso permitido apenas dentro do mesmo Assembly.                         |

**Exemplo de private e public:**

```
public class House
{
    private bool isDoorOpen;
    
    public void OpenDoor()
    {
        isDoorOpen = true;
        Console.WriteLine("Porta aberta!");
    }
}

```

### isDoorOpen é privado, ou seja, só pode ser acessado dentro da própria classe.

## Conclusão
Agora você conhece tudo sobre Classes em C#!
- Entendeu o conceito e a estrutura de uma classe.
- Viu um exemplo prático com a classe House.
- Aprendeu sobre modificadores de acesso, construtores e métodos.

As classes são a base da Programação Orientada a Objetos (OOP), e entender seu funcionamento é essencial para construir sistemas organizados, escaláveis e eficientes!











