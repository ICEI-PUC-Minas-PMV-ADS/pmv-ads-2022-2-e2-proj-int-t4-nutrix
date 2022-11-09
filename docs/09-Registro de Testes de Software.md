# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

  Utilizamos os seguintes Casos de Teste:

CT-02 – Efetuar registro, login e logoff
CT-03 – Visualizar apresentação da ideia do site
CT-05 – Edição dos dados do usuário

  E designamos as seguintes estratégias de testes:

CT-02 – Árvore de decisão
CT-03 – Caso de Uso
CT-05 – Caso de Uso

  O projeto do Teste ficou organizado da seguinte forma:

CT-02 - Árvore de decisão:

![image](https://user-images.githubusercontent.com/105240089/200723845-2ff345b2-37c4-4eac-a88d-369ccd5e1068.png)

CT-03 – Caso de uso:

RF-01	O site deve fornecer uma apresentação sobre a ideia geral do projeto.

CT-05 – Caso de uso:

RF-03	O site deve permitir a edição do perfil do usuário (CRUD).


Caso de Teste	CT-02 - Efetuar registro, login e logoff
Requisitos Associados	RF-02 - O site deve trabalhar com login e logoff para o usuário
Objetivo do Teste	Verificar se as funções de registro, login e logoff estão funcionando corretamente
Passos	1) Acessar o Navegador
2) Informar o endereço do Site
3) Visualizar a página inicial
4) Selecionar a opção de registro
5) Preencher as informações solicitadas
6) Confirmar o registro
7) Retornar a página inicial
8) Preencher as credenciais
9) Clicar no botão de login
10) Visualizar a página principal
11) Selecionar a opção de perfil no canto superior direito
12) Selecionar a opção “Logoff”
13) Visualizar a página inicial
Critérios de Êxito	•	Os redirecionamentos de página devem ocorrer corretamente, erros devem ser acusados ao preencher dados incorretos.

Teste 01:

Sucesso	Registrar usuário (preenchimentos correto das informações, Homepage, Logoff	Sem erro

Teste 02:

Sucesso	Login, Credenciais corretas, Homepage, Logoff	Sem erro





Teste 03:

Fracasso	Login, Credenciais incorretas, Esqueceu a senha, Tela de recuperação de senha	Erro no caminho para a página de Tela de recuperação de senha


Caso de Teste	CT-03 - Visualizar apresentação da ideia do site
Requisitos Associados	RF-01 - O site deve fornecer uma apresentação sobre a ideia geral do projeto.
Objetivo do Teste	Verificar se o resumo presente na tela inicial atende a meta estabelecida no requisito
Passos	1) Acessar o Navegador
2) Informar o endereço do Site
3) Visualizar a página inicial
Critérios de Êxito	•	A página deve apresentar em destaque uma explicação objetiva e sucinta do objetivo do mesmo, a explicação deve estar no lado esquerdo da página de forma adjacente ao menu de login

Teste 01:

Sucesso	Tela de Login, Informações do site à esquerda	Sem erro


  


![cats](https://user-images.githubusercontent.com/105240089/198921282-c16226b4-9f4b-4c77-80fa-0609285e73b3.jpg)
