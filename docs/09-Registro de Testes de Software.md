# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

  Utilizamos os seguintes Casos de Teste:

CT-01 – Criar uma dieta<br>
CT-02 – Efetuar registro, login e logoff<br>
CT-03 – Visualizar apresentação da ideia do site<br>
CT-04 – Gestão das dietas já armazenadas<br>
CT-05 – Edição dos dados do usuário<br>
CT-06 – Exibição correta das funções atreladas à linha do tempo<br>
CT-07 – Relatórios do desenvolvimento do usuário

  E designamos as seguintes estratégias de testes:

CT-01 – Operabilidade<br>
CT-02 – Árvore de decisão<br>
CT-03 – Observabilidade e Caso de Uso<br>
CT-04 – Observabilidade<br>
CT-05 – Caso de Uso<br>
CT-06 – Observabilidade<br>
CT-07 – Caso de Uso

  O projeto do Teste ficou organizado da seguinte forma:
  
CT-01 – Operabilidade:

Efetuar a dieta e analisar se o passo a passo para criá-la estará correto e sem defeitos.

CT-02 - Árvore de decisão:

![image](https://user-images.githubusercontent.com/105240089/200723845-2ff345b2-37c4-4eac-a88d-369ccd5e1068.png)

CT-03 – Caso de uso:

RF-01	O site deve fornecer uma apresentação sobre a ideia geral do projeto.

CT-04 – Observabilidade:

Checar se as dietas geradas foram armazenadas na parte de dietas armazenadas. 

CT-05 – Caso de uso:

RF-03	O site deve permitir a edição do perfil do usuário (CRUD).

CT-06 – Observabilidade:

Observar se as atualização realizadas no perfil do usuário surtirão o efeito desejado nas telas atreladas à linha do tempo.

CT-07 – Caso de uso:

RF-08 O site deverá oferecer uma linha do tempo mostrando a evolução do usuário, alimentada pelas dietas cadastradas e alterações no perfil.
RF-09 O site deverá alertar sobre a não atualização da linha do tempo por parte do usuário a partir de determinado período.

Testes Realizados:

![image](https://user-images.githubusercontent.com/105240089/200724336-2915bde9-1b19-4ccd-b5c4-648bc4b82209.png)

* Teste 01:

| Sucesso |	Registrar usuário (preenchimentos correto das informações, Homepage, Logoff	Sem erro |

* Teste 02:

| Sucesso |	Login, Credenciais corretas, Homepage, Logoff	Sem erro |

* Teste 03:

| Fracasso | Login, Credenciais incorretas, Esqueceu a senha, Tela de recuperação de senha. Erro no caminho para a página de Tela de recuperação de senha |

![image](https://user-images.githubusercontent.com/105240089/200724454-9bd2027a-22c2-4998-bd27-f89ad912538b.png)

Teste 01:

| Sucesso |	Tela de Login, Informações do site à esquerda.	Sem erro |


![cats](https://user-images.githubusercontent.com/105240089/198921282-c16226b4-9f4b-4c77-80fa-0609285e73b3.jpg)
