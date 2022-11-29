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
RF-09 O site deverá alertar sobre a não atualização da linha do tempo por parte do usuário a partir de determinado período.<br><br>

*Testes Realizados:

![image](https://user-images.githubusercontent.com/105240089/204658721-3fbc17c1-ff32-4f84-9e4c-3f0b7d84d757.png)

* Teste 01:

| Sucesso |	Data: 12/12/1998 12:13 ~ Peso: 80 ~ Altura: 171 ~ Tipo: Sedentário / Título da Dieta: Teste1 ~ Número das Refeições: 5 ~ Objetivo da Dieta: PerdaDePeso. Foi um sucesso, dá para escolher a dieta e tem os detalhes dos alimentos. |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

![image](https://user-images.githubusercontent.com/105240089/200724336-2915bde9-1b19-4ccd-b5c4-648bc4b82209.png)

* Teste 01:

| Sucesso |	Registrar usuário (preenchimentos correto das informações, Homepage, Logoff	Sem erro |

* Teste 02:

| Sucesso |	Login, Credenciais corretas, Homepage, Logoff	Sem erro |

* Teste 03:

| Fracasso | Login, Credenciais incorretas, Esqueceu a senha, Tela de recuperação de senha. Erro no caminho para a página de Tela de recuperação de senha |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

![image](https://user-images.githubusercontent.com/105240089/200724454-9bd2027a-22c2-4998-bd27-f89ad912538b.png)

Teste 01:

| Sucesso |	Tela de Login, Informações do site à esquerda.	Sem erro |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

![image](https://user-images.githubusercontent.com/105240089/204672212-e8e29d79-dbe1-47fb-9586-f0e481e2f016.png)

Teste 01:

| Fracasso |	Menu, Gerir Dietas, Excluir dieta. |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

![image](https://user-images.githubusercontent.com/105240089/204672983-bc48f8ef-c31d-4a8f-b7a0-3a1d70e2f414.png)

Teste 01:

| Sucesso | Editar Perfil, senha: teste1 ~ Data: 12/12/1998 12:13 ~ IsDiabetico: Check, Salvar |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

![image](https://user-images.githubusercontent.com/105240089/204673287-15c351f3-930c-4f25-80b5-3a6a5b85ec43.png)

Teste 01:

| Fracasso | Página Principal, Aviso da linha do tempo, Efetuar atualização do Perfil, Retornar à Tela Principal, Linha do tempo. Não foi possível a realização do passo a passo pois faltou a finalização da página. |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

![image](https://user-images.githubusercontent.com/105240089/204673551-38d33585-c266-49cb-9fd8-965016c17860.png)

Teste 01:

| Sucesso | Página Principal, Relatórios, Verificar a quantidade de dietas, Variação de peso entre dietas, Verificar IMC. Tudo correto. |

