drop database dbescola;
create database DBEscola;

use DBEscola;

create table tblAlunos(
   id int not null primary key auto_increment,
   nome varchar(50) not null,
   idade int not null,
   unidade char(1) not null,
   serie int not null,
   turma char(1) not null
);
insert into tblAlunos values(null,'Gabriel',17,'B',2,'E');
insert into tblAlunos values(null,'Dias',17,'B',2,'E');
insert into tblAlunos values(null,'Diogo',17,'B',2,'E');
insert into tblAlunos values(null,'Daniel',17,'B',2,'E');
insert into tblAlunos values(null,'Lacerda',17,'B',2,'E');

select * from tblalunos;

create table tblDisciplinas(
id int not null primary key auto_increment,
nome varchar(40) not null,
cargaH int not null
);

create table tblProfessores(
id int not null primary key auto_increment,
nome varchar(40) not null,
dtAdmissao date not null,
cpf varchar(11) not null,
telefone varchar(14) not null,
disciplina varchar(30) not null,
turno char not null,
escolaridade varchar(20) not null
);

desc tblDisciplinas;


