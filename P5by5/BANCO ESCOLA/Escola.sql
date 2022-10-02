create database Escola; --Criar o banco Escola

--Usa o banco 
use Escola;

--Cria a tabela Aluno
create table Aluno(
	RA varchar(10) constraint PK_Aluno primary key,
	Nome varchar(50) not null);

--Cria a tabela Disciplinag
create table Disciplina(
	Sigla varchar(10) constraint PK_Disciplina primary key,
	Nome varchar(50) not null,
	CargaHoraria int not null);
		
--Cria a tabela Matricula
create table Matricula(
	RA varchar(10) constraint FK_MAT_ALUNO foreign key (RA) references Aluno(RA),
	Sigla varchar(10) constraint FK_MAT_DISC foreign key (Sigla) references Disciplina(Sigla),
	DataAno int not null,
	DataSemestre int not null,
	Falta int,
	Nota1 decimal(10,1),
	Nota2 decimal(10,1),
	NotaSub decimal(10,1),
	Media decimal(10,1),
	Situacao varchar(10),
	constraint PK_Matricula primary key (RA, Sigla, DataAno, DataSemestre));
	   
--Criar aluno
insert Aluno
	values('F19654', 'Giovani Rocha Lima'),
		  ('G65412', 'Pedro Barbosa'),
		  ('A98432', 'Julia Quintara'),
		  ('B98744', 'Quincas Maniroco'),
		  ('C98756', 'Jorge Stupefaza'),
		  ('D951753', 'João Sannin'),
		  ('E852456', 'Lucia Takapilora'),
		  ('F439876', 'Bernardo Barnabé'),
		  ('G863321', 'Junin Play'),
		  ('H431985', 'Bernardo Barrelos');

--Criar Disciplina
insert Disciplina 
	Values ('CA1','Cálculo 1',40),
		   ('CA2','Cálculo 2',40),
		   ('POO','Programção Orientada a Objetos',40),
		   ('MD1','Modelagem de Dados 1',40),
		   ('MD2','Modelagem de Dados 2',40),
		   ('SDI','Segurança da Informação',40),
		   ('ETC','Ética',40),
		   ('ET1','Estátistica 1',40),
		   ('ET2','Estátistica 2',40),
		   ('LGC','Lógica',40);

--Criar Matricula 
insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('F19654','CA1', 2021,1),
		  ('F19654','CA2', 2021,1),
		  ('F19654','POO', 2021,1),
		  ('F19654','MD1', 2021,1),
		  ('F19654','MD2', 2021,1),
		  ('F19654','SDI', 2021,1),
		  ('F19654','ETC', 2021,1),
		  ('F19654','ET1', 2021,1),
		  ('F19654','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('G65412','CA1', 2021,1),
		  ('G65412','CA2', 2021,1),
		  ('G65412','POO', 2021,1),
		  ('G65412','MD1', 2021,1),
		  ('G65412','MD2', 2021,1),
		  ('G65412','SDI', 2021,1),
		  ('G65412','ETC', 2021,1),
		  ('G65412','ET1', 2021,1),		  
		  ('G65412','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('A98432','CA1', 2021,1),
		  ('A98432','CA2', 2021,1),
		  ('A98432','POO', 2021,1),
		  ('A98432','MD1', 2021,1),
		  ('A98432','MD2', 2021,1),
		  ('A98432','SDI', 2021,1),
		  ('A98432','ETC', 2021,1),
		  ('A98432','ET1', 2021,1),		  
		  ('A98432','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('B98744','CA1', 2021,1),
		  ('B98744','CA2', 2021,1),
		  ('B98744','POO', 2021,1),
		  ('B98744','MD1', 2021,1),
		  ('B98744','MD2', 2021,1),
		  ('B98744','SDI', 2021,1),
		  ('B98744','ETC', 2021,1),
		  ('B98744','ET1', 2021,1),		  
		  ('B98744','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('C98756','CA1', 2021,1),
		  ('C98756','CA2', 2021,1),
		  ('C98756','POO', 2021,1),
		  ('C98756','MD1', 2021,1),
		  ('C98756','MD2', 2021,1),
		  ('C98756','SDI', 2021,1),
		  ('C98756','ETC', 2021,1),
		  ('C98756','ET1', 2021,1),
		  ('C98756','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('D951753','CA1', 2021,1),
		  ('D951753','CA2', 2021,1),
		  ('D951753','POO', 2021,1),
		  ('D951753','MD1', 2021,1),
		  ('D951753','MD2', 2021,1),
		  ('D951753','SDI', 2021,1),
		  ('D951753','ETC', 2021,1),
		  ('C98756','ET1', 2021,1),		  
		  ('C98756','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('E852456','CA1', 2021,1),
		  ('E852456','CA2', 2021,1),
		  ('E852456','POO', 2021,1),
		  ('E852456','MD1', 2021,1),
		  ('E852456','MD2', 2021,1),
		  ('E852456','SDI', 2021,1),
		  ('E852456','ETC', 2021,1),
		  ('E852456','ET1', 2021,1),		  
		  ('E852456','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('F439876','CA1', 2021,1),
		  ('F439876','CA2', 2021,1),
		  ('F439876','POO', 2021,1),
		  ('F439876','MD1', 2021,1),
		  ('F439876','MD2', 2021,1),
		  ('F439876','SDI', 2021,1),
		  ('F439876','ETC', 2021,1),
		  ('F439876','ET1', 2021,1),		  
		  ('F439876','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('G863321','CA1', 2021,1),
		  ('G863321','CA2', 2021,1),
		  ('G863321','POO', 2021,1),
		  ('G863321','MD1', 2021,1),
		  ('G863321','MD2', 2021,1),
		  ('G863321','SDI', 2021,1),
		  ('G863321','ETC', 2021,1),
		  ('G863321','ET1', 2021,1),		  
		  ('G863321','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('H431985','CA1', 2021,1),
		  ('H431985','CA2', 2021,1),
		  ('H431985','POO', 2021,1),
		  ('H431985','MD1', 2021,1),
		  ('H431985','MD2', 2021,1),
		  ('H431985','SDI', 2021,1),
		  ('H431985','ETC', 2021,1),
		  ('H431985','ET1', 2021,1),		  
		  ('H431985','LGC', 2021,1);

insert Matricula (RA, Sigla, DataAno, DataSemestre)
	values('F19654','CA1', 2021,2),
		  ('F19654','CA2', 2021,2),
		  ('F19654','POO', 2021,2),
		  ('F19654','MD1', 2021,2),
		  ('F19654','MD2', 2021,2),
		  ('F19654','SDI', 2021,2),
		  ('F19654','ETC', 2021,2),
		  ('F19654','ET1', 2021,2),		
		  ('F19654','LGC', 2021,2);

--Trigger media, calcula as notas dos alunos por disciplina
CREATE TRIGGER [trg_Media]
ON [Matricula]
AFTER UPDATE
AS
IF (UPDATE(Nota1) OR UPDATE(Nota2) OR UPDATE(NotaSub))
BEGIN
	DECLARE @RA			VARCHAR(10),
			@SIGLA		VARCHAR(10),
			@NOTA1		DECIMAL(10,1),
			@NOTA2		DECIMAL(10,1),
			@NOTASUB	DECIMAL(10,1)

	SELECT @RA = RA, @SIGLA = Sigla, @NOTA1 = Nota1, @NOTA2 = Nota2, @NOTASUB = NotaSub from inserted
		
	IF(@NOTA2 >= 0)
	BEGIN	

	IF(((@NOTA1 + @NOTA2)/2)>= 5.0)
		UPDATE Matricula SET Media = ((@NOTA1 + @NOTA2) / 2.0) WHERE RA = @RA AND Sigla = @SIGLA	

	IF(@NOTASUB >= 0)
	BEGIN
		IF (@NOTA1 > @NOTA2)		
				UPDATE Matricula SET Media = ((@NOTA1 + @NOTASUB) / 2.0) WHERE RA = @RA AND Sigla = @SIGLA	
		ELSE		
			UPDATE Matricula SET Media = ((@NOTA2 + @NOTASUB) / 2.0 )WHERE RA = @RA AND Sigla = @SIGLA
	END
	END
END

--Trigger de rematricula, todo aluno que reprovar em alguma disciplina
--ira ser rematriculado automaticamente no ano posterior no mesmo semestre
CREATE TRIGGER [trg_Rematricula]
ON [Matricula]
AFTER UPDATE 
AS 
IF (UPDATE(Situacao))
BEGIN
	DECLARE @RA			VARCHAR(10)
	DECLARE @SIGLA		VARCHAR(10)
	DECLARE @SITUACAO	VARCHAR(10)
	DECLARE @DATASEMESTRE    INT
	DECLARE @DATAANO    INT
				
	SELECT @RA = RA, @SIGLA = Sigla, @SITUACAO = Situacao, @DATASEMESTRE = DataSemestre, @DATAANO = DataAno from inserted

	IF(@SITUACAO = 'RN' OR @SITUACAO = 'RF' AND @DATAANO = 2021 AND @DATASEMESTRE = 1)
	insert Matricula (RA, Sigla, DataAno, DataSemestre)values (@RA, @SIGLA, (@DATAANO+1), @DATASEMESTRE)

	IF(@SITUACAO = 'RN' OR @SITUACAO = 'RF' AND @DATAANO = 2021 AND @DATASEMESTRE = 2)
	insert Matricula (RA, Sigla, DataAno, DataSemestre)values (@RA, @SIGLA, (@DATAANO+1), @DATASEMESTRE)	
END

--Trigger Situacao, verifica a situação de cada aluno e da a informação de ap ou rp
--AP = aprovado, RN = reprovado por nota, RF = reprovado por falta
CREATE TRIGGER [trg_Situacao]
ON [Matricula]
AFTER UPDATE 
AS 
IF (UPDATE(Media))
BEGIN
	DECLARE @RA			VARCHAR(10)
	DECLARE @SIGLA		VARCHAR(10)
	DECLARE @MEDIA		DECIMAL(10,1)
	DECLARE @NOTASUB    DECIMAL(10,1)
	DECLARE @FALTA		INT
	DECLARE @CARGAHORARIA	INT
			
	SELECT @CARGAHORARIA = CargaHoraria from Disciplina
	SELECT @RA = RA, @SIGLA = Sigla, @NOTASUB = NotaSub, @FALTA = Falta, @MEDIA = Media from inserted

	IF(@MEDIA >= 5 AND @FALTA <= (@CARGAHORARIA*0.25))
		UPDATE Matricula SET Situacao = 'AP' WHERE RA = @RA AND Sigla = @SIGLA
	ELSE
	BEGIN
		IF(@NOTASUB >= 0)
			UPDATE Matricula SET Situacao = 'RN' WHERE RA = @RA AND Sigla = @SIGLA;	
			 
		IF(@FALTA > (@CARGAHORARIA*0.25))		
			UPDATE Matricula SET Situacao = 'RF' WHERE RA = @RA AND Sigla = @SIGLA	
	END			
END

--Inserindo alguns valores dos atributos de matricula
UPDATE Matricula SET Nota1=10, Nota2=9 , Falta = 9 WHERE RA='F19654'AND Sigla = 'CA1';
UPDATE Matricula SET Nota1=10, Nota2=9 , Falta = 9 WHERE RA='G65412'AND Sigla = 'CA1';
UPDATE Matricula SET Nota1=9, Nota2=9 , Falta = 0 WHERE RA='F19654'AND Sigla = 'CA2';
UPDATE Matricula SET Nota1=9, Nota2=9 , Falta = 0 WHERE RA='G65412'AND Sigla = 'CA2';
UPDATE Matricula SET Nota1=5 , Falta = 15 WHERE RA='F19654'AND Sigla = 'POO';
UPDATE Matricula SET Nota2=5 WHERE RA='F19654'AND Sigla = 'POO';
UPDATE Matricula SET Nota1=5 , Falta = 15 WHERE RA='G65412'AND Sigla = 'POO';
UPDATE Matricula SET Nota2=5 WHERE RA='G65412'AND Sigla = 'POO';
UPDATE Matricula SET Nota1=10, Nota2=9 , Falta = 9 WHERE RA='F19654'AND Sigla = 'MD1';
UPDATE Matricula SET Nota1=10, Nota2=9 , Falta = 9 WHERE RA='G65412'AND Sigla = 'MD1';
UPDATE Matricula SET Nota1=5, Nota2=5 , Falta = 9 WHERE RA='F19654'AND Sigla = 'MD2';
UPDATE Matricula SET Nota1=5, Nota2=5 , Falta = 9 WHERE RA='G65412'AND Sigla = 'MD2';
UPDATE Matricula SET Nota1=10, Nota2=9 , Falta = 9 WHERE RA='F19654'AND Sigla = 'SDI';
UPDATE Matricula SET Nota1=10, Nota2=9 , Falta = 9 WHERE RA='G65412'AND Sigla = 'SDI';
UPDATE Matricula SET Nota1=5, Nota2=0, Falta = 9 WHERE RA='F19654'AND Sigla = 'ETC';
UPDATE Matricula SET NotaSub = 2 WHERE RA='F19654'AND Sigla = 'ETC';
UPDATE Matricula Set NotaSub=1 WHERE RA='F19654'AND Sigla = 'ETC';
UPDATE Matricula SET Nota1=5, Nota2=0 , Falta = 9 WHERE RA='G65412'AND Sigla = 'ETC';
UPDATE Matricula SET NotaSub = 3 WHERE RA='G65412'AND Sigla = 'ETC';
UPDATE Matricula SET Nota1=5, Nota2=0 , Falta = 0 WHERE RA='F19654'AND Sigla = 'ET1';
UPDATE Matricula SET NotaSub = 2 WHERE RA='F19654'AND Sigla = 'ET1';
UPDATE Matricula SET Nota1=5, Nota2=0 , Falta = 0 WHERE RA='G65412'AND Sigla = 'ET1';
UPDATE Matricula SET NotaSub = 2 WHERE RA='G65412'AND Sigla = 'ET1';
UPDATE Matricula SET Nota1=5, Nota2=0 , Falta = 0 WHERE RA='F19654'AND Sigla = 'ET2';
UPDATE Matricula SET NotaSub = 2 WHERE RA='F19654'AND Sigla = 'ET2';
UPDATE Matricula SET Nota1=5, Nota2=0 , Falta = 0 WHERE RA='G65412'AND Sigla = 'ET2';
UPDATE Matricula SET NotaSub = 2 WHERE RA='G65412'AND Sigla = 'ET1';
UPDATE Matricula SET Nota1=10, Nota2=10 , Falta = 0 WHERE RA='F19654'AND Sigla = 'ET2';
UPDATE Matricula SET Nota1=10, Nota2=10 , Falta = 0 WHERE RA='G65412'AND Sigla = 'ET2';

--Teste de impressão
select * from Matricula WHERE DataAno = 2021;

-- Quais são alunos de uma determinada disciplina ministrada no ano de 2021, 
-- com suas notas, faltas e Situação Final.

select aluno.Nome as 'Nome do Aluno', aluno.RA, disciplina.Nome as 'Disciplina', matricula.Sigla, DataAno, Nota1 as 'Nota 1', Nota2 as 'Nota 2', NotaSub as 'Nota Substitutiva', Media, Falta, Situacao from Matricula
inner join Disciplina on
	disciplina.Sigla = matricula.Sigla	
join Aluno on
	aluno.RA = matricula.RA WHERE matricula.Sigla = 'CA1'
	

--Quais são as notas, faltas e situação final (Boletim) de um aluno em todas 
--as disciplinas por ele cursadas no ano de 2021, no segundo semestre.

select aluno.Nome as 'Nome do Aluno', aluno.RA, disciplina.Nome as 'Disciplina', matricula.Sigla, DataAno, Nota1 as 'Nota 1', Nota2 as 'Nota 2', NotaSub as 'Nota Substitutiva', Media, Falta, Situacao from Matricula
inner join Disciplina on
	disciplina.Sigla = matricula.Sigla	
join Aluno on
	aluno.RA = matricula.RA WHERE aluno.RA = 'F19654' AND matricula.DataAno = 2021 AND matricula.DataSemestre = 2
	

--Quais são os alunos reprovados por nota (média inferior a cinco) no ano de 2021
--e, o nome das disciplinas em que eles reprovaram, com suas notas e médias.

select aluno.Nome as 'Nome do Aluno', aluno.RA, disciplina.Nome as 'Disciplina',matricula.Sigla, DataAno, Nota1 as 'Nota 1', Nota2 as 'Nota 2', NotaSub as 'Nota Substitutiva', Media, Falta, Situacao from Matricula
inner join Disciplina on
	disciplina.Sigla = matricula.Sigla	
join Aluno on
	aluno.RA = matricula.RA 
	WHERE Matricula.Situacao = 'RN' AND matricula.DataAno = 2021

