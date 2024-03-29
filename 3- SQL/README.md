#  🛠️ Soluções para as perguntas relacionadas a SQL. É fundamental iniciar a preparação do ambiente, considerando que este ambiente já esteja configurado. Abaixo, encontram-se as respostas após a tabela inicial.

### Tabela usada como base no teste.

```shell
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
```

### 1- Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.
````sql
SELECT pessoa.nome, evento.evento
FROM tabela_pessoa pessoa
LEFT JOIN tabela_evento evento ON pessoa.id = evento.pessoa_id;
````

### 2- Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
````sql
SELECT *
FROM tabela_pessoa
WHERE nome LIKE '%Doe%';
````

### 3- Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.
````sql
INSERT INTO tabela_evento (evento, pessoa_id)
SELECT 'Evento E', id
FROM tabela_pessoa
WHERE nome = 'Lisa Romero';
````

### 4- Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'
````sql
UPDATE tabela_evento
SET pessoa_id = (SELECT id FROM tabela_pessoa WHERE nome = 'John Doe')
WHERE evento = 'Evento D';
````

### 5- Crie uma query para remover o 'Evento B' na 'tabela_evento'.
````sql
DELETE FROM tabela_evento
WHERE evento = 'Evento B';
````

### 6- Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.
````sql
DELETE FROM tabela_pessoa
WHERE id NOT IN (SELECT DISTINCT pessoa_id FROM tabela_evento WHERE pessoa_id IS NOT NULL);
````

### 7- Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)
````sql
ALTER TABLE tabela_pessoa
ADD COLUMN idade INT;
````

### 8- Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:\
````sql
CREATE TABLE tabela_telefone (
    id INT PRIMARY KEY,
    telefone VARCHAR(200),
    pessoa_id INT,
    FOREIGN KEY (pessoa_id) REFERENCES tabela_pessoa(id)
);
````

### 9- Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.

````sql
ALTER TABLE tabela_telefone
ADD UNIQUE INDEX idx_telefone(telefone);
````

### 10- Crie uma query para remover a 'tabela_telefone'.
````sql
DROP TABLE tabela_telefone;
````
