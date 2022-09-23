create database Agenda;

use Agenda;

CREATE TABLE Contatos(
	ID int identity,
	Nome varchar(50),
	Telefone varchar(50),
	Apelido varchar(50),
	Email varchar(50));

insert into Contatos values ('Giovani', '16992804976', 'Não tenho', 'Watzeckdev@gmail.com');

SELECT * FROM Contatos;