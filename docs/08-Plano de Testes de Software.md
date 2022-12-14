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

<hr />

| **Caso de Teste** 	| **CT-03 - Visualizar apresentação da ideia do site** 	|
|:---:	|:---:	|
|	RF-01 | O site deve fornecer uma apresentação sobre a ideia geral do projeto.
| Objetivo do Teste 	| Verificar se o resumo presente na tela inicial atende a meta estabelecida no requisito |
| Passos 	| 1) Acessar o Navegador <br> 2) Informar o endereço do Site <br> 3) Visualizar a página inicial <br> |
|Critério de Êxito |A página deve apresentar em destaque uma explicação objetiva e sucinta do objetivo do mesmo, a explicação deve estar no lado esquerdo da página de forma adjacente ao menu de login|

<hr />

| **Caso de Teste** 	| **CT-04 - Gestão das dietas já armazenadas** 	|
|:---:	|:---:	|
|	RF-01 | O site deve permitir a edição das dietas armazenadas
| Objetivo do Teste 	| Verificar se a visualização das dietas anteriormente geradas é possível e também a sua exclusão. |
| Passos 	| 1) Acessar o Navegador <br> 2) Informar o endereço do Site<br>3) Efetuar o login / registro no sistema<br>4) Visualizar a página principal<br>5) Ir à opção “Gerir Dietas”<br>6) Visualizar as dietas anteriormente geradas<br>7) Realizar a exclusão de uma Dieta<br>8) Visualizar a atualização no grid das dietas após a exclusão.<br> 9) Clicar nas dietas do menu e visualizar assim como no momento da criação da mesma.|
|Critério de Êxito |Só pode ser feito caso já tenha sido criado algumas dietas, a execução do CT-01 antes desse é uma boa opção.|

<hr />

| **Caso de Teste** 	| **CT-05 - Edição dos dados do usuário** 	|
|:---:	|:---:	|
|	RF-03 | O site deve permitir a edição do perfil do usuário (CRUD).
| Objetivo do Teste 	| Verificar se os dados do usuário estão sendo devidamente armazenados e se é possível editá-los |
| Passos 	| 1) Acessar o Navegador<br>2) Informar o endereço do Site<br>3) Efetuar o login / registro no sistema<br>4) Visualizar a página principal<br>5) Clicar no ícone de usuário no cabeçalho<br>6) Selecionar a opção “Editar perfil”<br>7) Ir a tela de edição de Perfil<br>8) Selecionar a opção de alteração dos dados pessoais<br>9) Alterar os dados<br>10) Salvar<br>11) Visualizar se foi salvo as alterações feitas.<br>12) Retornar a tela para as opções de alterações<br>13) Selecionar a opção de alteração dos dados restritos<br>14) Alterar os dados<br>15) Salvar<br>16) Visualizar se foi salvo as alterações feitas.|
|Critério de Êxito | Ao acessar a tela de alteração de dados do usuário, tanto nos dados restritos quanto para os dados pessoais, deve-se exibir os dados anteriores já posicionados nos campos, possibilitando sua alteração, caso alguma dieta ou atualização manual tenha sido feita. <br> Os testes devem ser efetuados com um usuário novo sem nenhuma alteração dos dados e também com um possuindo alterações manuais e via criação de dieta. <br> Dados inválidos devem ser introduzidos e não deve ser permitido o armazenamento dos mesmos.|

<hr />

| **Caso de Teste** 	| **CT-06 - Exibição correta das funções atreladas a linha do tempo** 	|
|:---:	|:---:	|
|RF-08 | O site deverá oferecer uma linha do tempo mostrando a evolução do usuário, alimentada pelas dietas cadastradas e alterações no perfil.
|RF-09 | O site deverá alertar sobre a não atualização da linha do tempo por parte do usuário a partir de determinado período.
| Objetivo do Teste 	| Verificar se as funções relacionadas à linha do tempo estão sendo executadas corretamente |
| Passos 	| 1) Acessar o Navegador<br>2) Informar o endereço do Site<br> 3) Efetuar o registro e primeiro login no sistema <br> 4) Visualizar a página principal <br> 5) Verificar se o aviso de não atualização da linha do tempo está aparecendo <br> 6) Efetuar uma atualização de perfil<br>7) Retornar à tela principal<br>8) Verificar se o aviso de não atualização desapareceu corretamente <br>9) Selecionar a opção “Linha do tempo” <br>10) Verificar se o redirecionamento de página ocorreu corretamente<br>11) Verificar se na linha do tempo está listada a atualização de perfil feita no passo 6|
|Critério de Êxito | Os redirecionamentos de página devem ocorrer corretamente, e as atualizações feitas no perfil devem surtir os efeitos esperados na tela principal e na tela da linha do tempo.|


<hr />

| **Caso de Teste** 	| **CT-07 - Relatórios do desenvolvimento do usuário** 	|
|:---:	|:---:	|
|RF-10 | O site deverá apresentar relatórios sobre o desenvolvimento do usuário baseando-se nos dados fornecidos pelo mesmo.
|RF-11 | O site deverá fornecer um relatório demonstrando o total de dietas já criadas.
|RF-12 | O site deverá fornecer um relatório que contém um registro das variações no peso do usuário.
|RF-13 | O site deverá fornecer um relatório que contém advertências sobre a situação de saúde do usuário.
| Objetivo do Teste 	| Verificar se os relatórios estão de acordo com cada um dos requisitos prestados, imprimindo corretamente. |
| Passos 	| 1) Acessar o Navegador<br>2) Informar o endereço do Site<br> 3) Efetuar o login / registro no sistema <br> 4) Visualizar a página principal <br> 5) Abrir o Menu e selecionar a opção “Relatórios” <br> 6) Verificar se há o desenvolvimento do usuário de acordo com a quantidade de dietas geradas <br>7) Verificar o número total de dietas geradas<br>8) Verificar as variações de peso entre uma dieta e outra <br>9) Verificar se o site apresentará uma informação de saúde do usuário quando o mesmo está abaixo/entre/acima do peso ideal <br>|
|Critério de Êxito | Para que haja êxito, é preciso realizar o cadastro de dietas pelo menos três vezes <br> As telas relacionadas a cada tópico devem estar funcionando corretamente de acordo com cada requisito |



