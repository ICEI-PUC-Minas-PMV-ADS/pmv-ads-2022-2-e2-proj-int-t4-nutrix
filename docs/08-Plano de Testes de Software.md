# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Criar uma dieta** 	|
|:---:	|:---:	|
|	RF-04 | O site deverá elaborar uma dieta com refeições balanceadas, de acordo com o perfil do usuário.
|	RF-06	| O site deve permitir ao usuário visualizar o valor nutricional de cada alimento que compõem a refeição. 
|	RF-07	| O site deve calcular a quantidade de água ideal a ser ingerida.
|	RF-14	| O site deverá alertar e gerar as dietas baseando-se também nos dados restritivos informados pelo usuário.|
| Objetivo do Teste 	| Verificar se a  dieta está sendo criada corretamente, e que é possível visualizar os dados claramente, seguindo as regras de negócio. |
| Passos 	| 1) Acessar o Navegador <br> 2) Informar o endereço do Site <br> 3) Efetuar o login / registro no sistema <br> 4) Visualizar a página principal <br> 5) Ir à opção “Nova Dieta” <br> 6) Preencher os dados pessoais <br> 7) Informar dados restritivos <br> 8) Preencher os dados da dieta <br> 9) Visualizar cardápio gerado <br> 10) Verificar se as opções exibidas são condizentes com os dados restritivos <br> 11) Trocar algumas opções de refeições <br> 12) Verificar a existência da quantidade de água ideal a ser ingerida. <br> 13) Verificar se os dados dos alimentos estão devidamente exibidos. <br> 14) Clicar na opção de Gerar nova dieta <br> 15) Verificar se é direcionado a página de preenchimento de dados pessoais.|
|Critério de Êxito | A dieta exibida no fim do processo deve estar bem visível com nenhuma informação cortada ou incompleta. <br> A tela de dados pessoais deve carregar as informações da última dieta gerada, e possibilitar alteração. <br> O perfil sempre deve ser automaticamente atualizado após a alteração dos dados pessoais na geração de dieta. <br> A geração de dieta deve ser gerada no mínimo 3 vezes seguindo esses passos com sucesso.|

<hr />

| **Caso de Teste** 	| **CT-02 - Efetuar registro, login e logoff** 	|
|:---:	|:---:	|
|	RF-02 | O site deve trabalhar com login e logoff para o usuário.
| Objetivo do Teste 	| Verificar se a  dieta está sendo criada corretamente, e que é possível visualizar os dados claramente, seguindo as regras de negócio. |
| Passos 	| 1) Acessar o Navegador <br> 2) Informar o endereço do Site <br> 3) Visualizar a página inicial <br> 4) Selecionar a opção de registro <br> 5) Preencher as informações solicitadas <br> 6) Confirmar o registro <br> 7) Retornar a página inicial <br> 8) Preencher as credenciais <br> 9) Clicar no botão de login <br> 10) Visualizar a página principal <br> 11) Selecionar a opção de perfil no canto superior direito <br> 12) Selecionar a opção “Logoff” <br> 13) Visualizar a página inicial <br> |
|Critério de Êxito | Os redirecionamentos de página devem ocorrer corretamente, erros devem ser acusados ao preencher dados incorretos.|


 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
