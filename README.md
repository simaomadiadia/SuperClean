# SuperClean

Descrição do Sistema
SuperClean – A app que o ajuda a calendarizar a limpeza da sua casa.
Pretende-se criar um programa em C#, a desenvolver em modo consola, que ajude os
utilizadores a manter a sua residência limpa, através de um histórico de limpezas e um
planificador de limpeza.
A aplicação deverá ter em conta os seguintes requisitos:

R01 – A app pode ser usada por vários utilizadores, sem que haja partilha de dados entre si. Os
utilizadores são apenas identificados pelo username, que tem no máximo 8 caracteres, entre
letras e dígitos.

R02 - Cada utilizador poderá criar uma única residência, sendo esta composta por várias áreas
gerais, tais como: garagem, piso 0, piso 1, etc. Cada uma destas áreas poderá conter várias
divisões: quarto, sala, WC, etc.
R03 – Cada divisão deverá ter as seguintes propriedades:
  •Name – Define o nome da divisão e pode ter no máximo 10 caracteres;
  •CleanTime – Tempo de limpeza em minutos para cada divisão;
  •CleanInterval – Tempo expectável, em dias, até que seja necessário efetuar uma nova limpeza na divisão.
  •Id – Identificador único que permite referenciar de forma exclusiva cada divisão.
  
R04 – Permitir criar, editar, apagar pisos e divisões.

R05 – Apresentar a residência em formato árvore, similar à seguinte representação:

R06 - A estrutura em árvore deverá permitir auferir se a divisão está suja ou não, com um
sistema de cores que varie entre o verde, amarelo e o vermelho. Verde indica que a divisão está
3 / 4 limpa, devendo ir progredindo para o vermelho. A cor amarela deverá ser apresentada entre 1
dia antes da data prevista de limpeza e 2 dias depois, se não foi limpa.

R07 – As barras verticais indicam: a) o número de dias desde a última limpeza, se a data
prevista de limpeza ainda não foi ultrapassada (geralmente a verde) e b) o n.º de dias que
passaram desde a data prevista de limpeza (sem esta ter sido feita).
Nota: Devem ser apresentadas no máximo 20 barras verticais.

R08 – A qualquer momento, deve ser possível registar e apagar uma limpeza em qualquer
divisão.
Uma forma rápida de registar uma limpeza, deverá ser através do id da divisão, utilizando os
seguintes comandos:
  - Marcar limpeza – clean 01 ( a limpeza fica marcada para a divisão 01 tendo em atenção a data atual.
  - Remover última limpeza – remove clean 01 É apagada a última limpeza tendo em atenção a data atual
    
R09 – Deverá ser possível persistir os dados em ficheiro com os dados em Json. Cada ficheiro é
identificado pelo identificador do utilizador.

R10 – Sempre que estamos na vista em árvore, deverá ser possível simular uma data futura ou
anterior, usando as setas direcionais para a esquerda e direita. A representação deverá adaptar-
se corretamente de acordo com a data selecionada.

R11 – Disponibilize uma vista que permita listar todas divisões, por ordem de necessidade de
limpeza.
