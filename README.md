# FullStxck
  <h2>O seu sistema gerencial grátis e fácil de usar </h2>
  
Os sistemas gerenciais chegaram a um bom tempo para nos ajudar a organizar tarefas que antes eram de um trabalho imenso. O FullStxck veio para revolucionar os sistemas gerenciais livres que possuem hoje, trazendo conosco um sistema completo para cadastro de produtos, cadastro de clientes e geração de relatórios, incluindo geração de boleto e recebimento de pagamento por meio dos boletos. O sistema está na versão v0.1 e irá atualizar em breve, trazendo a geração de boletos e remessas bancárias, automatizando o processso de venda on-line ou pré venda, sendo feito tudo dentro do nosso sistema gerencial

Tecnologias, design patterns e metodologias utilizadas:

No projeto foi utilizado os seguintes padrões: 3 camadas | dal(acesso a dados) -> bll(lógica de negócios) -> GUI(Interface do usuário) |
foi e esa sendo utilizado o padrão de projeto refactoring, onde eu refatoro partes do codigo que poderiam ser melhoradas

<h2> Tela de login </h2>

![Alt text](https://i.ibb.co/xmfSpCj/Screenshot-28.png)

<h2> Tela de Listagem </h2>

![Alt text](https://i.ibb.co/0sjB95K/Screenshot-27.png)

<h2> Estrutura do app.config </h2>

Para o funcionamento do software é preciso que voce tenha uma base de dados, recomendo usar o MySql workbench (Link para download: https://www.mysql.com/products/workbench/)
Para criar uma estrutura de dados compativel com a do software use o seguinte comando:


create database XXXXX;

use XXXXX;

CREATE TABLE `login` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `nickname` varchar(30) NOT NULL,
  `password` varchar(300) NOT NULL,
  PRIMARY KEY (`nickname`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `produtos` (
  `id` bigint DEFAULT NULL,
  `quantidade` bigint DEFAULT NULL,
  `nome` varchar(60) DEFAULT NULL,
  `marca` varchar(60) DEFAULT NULL,
  `ativo` char(1) DEFAULT NULL,
  `modelo` varchar(60) DEFAULT NULL,
  `cor` varchar(60) DEFAULT NULL,
  `tipo` varchar(60) DEFAULT NULL,
  `dono` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

XXXXX - nome do seu banco de dados

<h2> Configurações do app.config </h2>

Agora que criamos a base de dados precisamos configurar o nosso software para que ele comece a usa-lo, vamos lá!

Primeiro abra o arquivo app.config, o nosso interesse é na configuração <connectionStrings>
  o que nos interessa no momento é o "DATABASE" que é o nome da base dados que voce criou(XXXXX) o UID é o usuario do banco de dados criado e PASSWORD é a senha do banco de dados, colocando essas informações o seu software FullStxck está pronto para o uso
  
![Alt text](https://i.ibb.co/kHFx6TB/Screenshot-29.png)
  
  <b>A imagem diz que:</b>
  
<ul>
  <li>Vermelho: Nome do banco </li>
  <li>Amarelo: Usuário do banco</li>
  <li>Verde: Senha do banco </li>
</ul>


<b>após isso o seu software está pronto para uso, qualquer duvida abra uma issue no GitHub, qualquer falha e bug, por favor me contatar</b>
  
  
_O modulo de geração de boletos ainda está sendo desenvolvido. Projeto protegido por licença - Autor: Daniel Felipe aka: Daniel-Kenobi_

