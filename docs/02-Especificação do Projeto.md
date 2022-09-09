# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

<h3>Ana Cláudia</h3>

<img src="https://cdn-icons-png.flaticon.com/512/4140/4140051.png" width="100" height="100" />
<h4>Idade:</h4> 33
<h4>Ocupação:</h4> Trabalha como contadora de uma empresa renomada.
<h4>Motivações:</h4>
<ul>
 <li>Melhorar a saúde</li>
 <li>Emagrecer</li>
 <li>Falta de conhecimento</li>
</ul>
 
 <h4>Frustações:</h4>
<ul>
 <li>Saúde debilitada</li>
 <li>Dificuldade com atividade física</li>
 <li>Alimentação negligenciada</li>
</ul>
 
<h4>Hobbies, História:</h4>
<ul>
 <li>Amante de redes sociais</li>
 <li>Entusiasta de jogos eletrônicos</li>
</ul>
 
<h4>Aplicativos:</h4>
<ul>
 <li>Instagram</li>
 <li>Linkedin</li>
 <li>Tinder</li>
 <li>Pinterest</li>
 <li>iFood</li>
</ul>

<hr />

<h3>Carlos Santos</h3>

<img src="https://cdn-icons-png.flaticon.com/512/4140/4140048.png" width="100" height="100"/>
<h4>Idade:</h4> 31
<h4>Ocupação:</h4> Bartender
<h4>Motivações:</h4>
<ul>
 <li>Ganho de massa magra</li>
 <li>Acompanhamento de evolução</li>
 <li>Melhorar performance nos exercícios</li>
</ul>
 
 <h4>Frustações:</h4>
<ul>
 <li>Poucos ganhos na musculação</li>
 <li>Melhorar tempos na corrida</li>
</ul>
 
<h4>Hobbies, História:</h4>
<ul>
 <li>Musculação</li>
 <li>Corrida</li>
 <li>Apreciador de esportes</li>
</ul>
 
<h4>Aplicativos:</h4>
<ul>
 <li>Instagram</li>
 <li>Linkedin</li>
 <li>Tinder</li>
 <li>Strava</li>
</ul>

<hr />

<h3>Ana Cláudia</h3>

<img src="https://cdn-icons-png.flaticon.com/512/4140/4140076.png" width="100" height="100"/>
<h4>Idade:</h4> 28
<h4>Ocupação:</h4> Lojista do ramo de vestimentas.
<h4>Motivações:</h4>
<ul>
 <li>Ganho de massa</li>
 <li>Economia</li>
 <li>Alimentar-se melhor</li>
</ul>
 
 <h4>Frustações:</h4>
<ul>
 <li>Dificuldade financeira</li>
 <li>Dificuldade de ganho de massa</li>
 <li>Problemas de saúde</li>
</ul>
 
<h4>Hobbies, História:</h4>
<ul>
 <li>Cozinhar</li>
 <li>Jogar vôlei casualmente</li>
 <li>Jardinagem</li>
</ul>
 
<h4>Aplicativos:</h4>
<ul>
 <li>Instagram</li>
 <li>Linkedin</li>
 <li>Tinder</li>
 <li>Twitter</li>
</ul>
 

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`     | PARA ... `MOTIVO/VALOR`                               |
|--------------------|----------------------------------------|-------------------------------------------------------|
|Ana Cláudia         | Emagrecer de forma correta             | Evitar engordar novamente                             |
|Ana Cláudia         | Obter uma alimentação mais saudável    | Ficar melhor de saúde e evitar doenças                |
|Carlos Santos       | Dificuldade de ganhar massa magra      | Aumentar/manter a quantidade de músculos              |
|Carlos Santos       | Melhorar a performance de seus treinos | Obter melhores resultados em um espaço de tempo menor |
|Maria Alice         | Aumentar o índice de massa corporal de | Reforçar sua saúde e obter bons hábitos alimentares   |
|Maria Alice         | Melhorar a suplementação de nutrientes | Evitar problemas de saúde por falta de vitaminas      |


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                                    | Prioridade |
|------|---------------------------------------------------------------------------|------------|
|RF-001| O site deve fornecer uma apresentação sobre a ideia geral do projeto      |    MÉDIA   | 
|RF-002| O site deve trabalhar com login e logoff para o usuário                   |    ALTA    |
|RF-003| O site deve permitir a edição do perfil do usuário (CRUD)                 |    ALTA    | 
|RF-004| O site deverá elaborar uma dieta com refeições balanceadas, de acordo     |    ALTA    |
|      |com o perfil do usuário                                                    |            |
|RF-005| O site deve permitir a edição das dietas armazenadas (CRUD)               |    MÉDIA   | 
|RF-006| O site deve permitir ao usuário visualizar o valor nutricional de cada    |    BAIXA   |
|      |alimento que compõem a refeição                                            |            | 
|RF-007| O site deve calcular a quantidade de água ideal a ser ingerida            |    ALTA    |
|RF-008| O site deverá oferecer uma linha do tempo mostrando a evolução do usuário,|    ALTA    |
|      |alimentada pelas dietas cadastradas e alterações no perfil                 |            | 
|RF-009| O site deverá alertar sobre a não atualização da linha do tempo por parte |    BAIXA   |
|      |do usuário a partir de determinado período                                 |            |
|RF-010| O site deverá apresentar relatórios sobre o desenvolvimento do usuário    |    ALTA    |
|      |baseando-se nos dados fornecidos pelo mesmo                                |            | 
|RF-011| O site deverá fornecer um relatório demonstrando o total de dietas já     |    BAIXA   |
|      |criadas                                                                    |            |
|RF-012| O site deverá fornecer um relatório que contém um registro das variações  |    MÉDIA   |
|      |no peso do usuário                                                         |            | 
|RF-013| O site deverá fornecer um relatório que contém advertências sobre a       |    MÉDIA   |
|      |situação de saúde do usuário                                               |            |

### Requisitos não Funcionais

|ID     | Descrição do Requisito                                                   | Prioridade |
|-------|--------------------------------------------------------------------------|------------|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente          |    ALTA    | 
|na Internet (Repl.it, GitHub Pages, Heroku);                                      |            |
|RNF-002| O site deverá ser responsivo permitindo a visualização em um celular     |    ALTA    |
|de forma adequada                                                                 |            |
|RNF-003| O site deve ter bom nível de contraste entre os elementos da tela        |    MÉDIA   | 
|em conformidade                                                                   |            |
|RNF-004| O site deve ser compatível com os principais navegadores do mercado      |    ALTA    |
|(Google Chrome, Firefox, Microsoft Edge)                                          |            |
|RNF-005| A aplicação deverá armazenar as informações em um banco de dados (MySQL) |    ALTA    |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID     | Descrição da Restrição                                                   |
|-------|--------------------------------------------------------------------------|
|RE-001 | O projeto deverá ser entregue no final do semestre letivo, não podendo   |
|extrapolar a data de 11/12/2022.                                                  |
|RE-002 | O aplicativo deve se restringir às tecnologias Frontend e Backend.       |            
|RNE-003| A equipe não pode subcontratar o desenvolvimento do trabalho.            |


## Diagrama de Casos de Uso

Segue abaixo o diagrama de casos de uso que representa a ideia central de nossa aplicação.


