Respostas para as questões de SQL. É importante preparar inicialmente o ambiente, partindo do pressuposto que este ambiente já esteja pronto, abaixo estão as respostas pós a tabela base. 

+----+--------------+
| tabela_pessoa     |
+----+--------------+
| id | nome         |
+----+--------------+
|  1 | John Doe     |
|  2 | Jane Doe     |
|  3 | Alice Jones  |
|  4 | Bobby Louis  |
|  5 | Lisa Romero  |
+----+--------------+
+----+----------------+-----------+
| tabela_evento                   |
+----+----------------+-----------+
| id | evento         | pessoa_id |
+----+----------------+-----------+
|  1 | Evento A       |  2        |
|  2 | Evento B       |  3        |
|  3 | Evento C       |  2        |
|  4 | Evento D       |  NULL     |
+----+----------------+-----------+


1- Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.

SELECT pessoa.nome, evento.evento
FROM tabela_pessoa pessoa
LEFT JOIN tabela_evento evento ON pessoa.id = evento.pessoa_id;

2- Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.

SELECT *
FROM tabela_pessoa
WHERE nome LIKE '%Doe%';

3- Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.

INSERT INTO tabela_evento (evento, pessoa_id)
SELECT 'Evento E', id
FROM tabela_pessoa
WHERE nome = 'Lisa Romero';

4- Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'

UPDATE tabela_evento
SET pessoa_id = (SELECT id FROM tabela_pessoa WHERE nome = 'John Doe')
WHERE evento = 'Evento D';

5- Crie uma query para remover o 'Evento B' na 'tabela_evento'.

DELETE FROM tabela_evento
WHERE evento = 'Evento B';

6- Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.

Gerênciamento de tabelas

DELETE FROM tabela_pessoa
WHERE id NOT IN (SELECT DISTINCT pessoa_id FROM tabela_evento WHERE pessoa_id IS NOT NULL);

7- Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)

ALTER TABLE tabela_pessoa
ADD COLUMN idade INT;

8- Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:\

CREATE TABLE tabela_telefone (
    id INT PRIMARY KEY,
    telefone VARCHAR(200),
    pessoa_id INT,
    FOREIGN KEY (pessoa_id) REFERENCES tabela_pessoa(id)
);

9- Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.

ALTER TABLE tabela_telefone
ADD UNIQUE INDEX idx_telefone(telefone);

10- Crie uma query para remover a 'tabela_telefone'.

DROP TABLE tabela_telefone;