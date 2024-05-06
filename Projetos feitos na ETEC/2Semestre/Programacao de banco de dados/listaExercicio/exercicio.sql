-- Exercicio 1
create database guilherme;
use guilherme;

create table tbUsuario(
IdUsuario int primary key,
NomeUsuario varchar(45),
DataNascimento date
);
create table tbEstado(
Id int primary key,
Uf varchar (2)
);
create table tbCliente(
CodigoCli smallint primary key,
Nome varchar(50),
Endereco varchar(60)
);
create table tbProduto(
Barras decimal (13,0),
Valor decimal (21,4),
Descricao varchar (500)
);
describe tbProduto;
show tables;
show DATABASES;

alter table tbCliente modify Nome varchar (58);
alter table tbProduto add Qtd int;
drop table tbEstado;
ALTER TABLE tbUsuario DROP COLUMN DataNascimento;


-- Exercicio 2
create database Mauro;

use Mauro;

create table tbproduto(
	IdProp int primary key,
	NomeProd varchar(50) not null,
	Qtd int,
	DataValidade DATE not null,
	Valor decimal (10,2) not null
);

create table tbcliente(
	Codigo int primary key,
	NomeCli varchar(50) not null,
	DataNascimento DATE
);

describe tbcliente;
Show databases;

-- Exercicio 3
create database dbcomercio;

use dbcomercio;

create table tbCliente(
	id int primary key,
    NomeCli varchar(200) not null,
    NumEnd smallint not null,
    CompEnd varchar(50)
);

create table tbClientePF(
	CPF int(11) primary key,
    RG 	int(9),
    Rgdig char(1),
    nascimento date not null    
);


-- Exercicio 4
create database Terezinha;

use Terezinha;

create table tbProduto(
	idProp int primary key,
	NomeProd varchar(50) not null,
	Qtd int,
	DataValidade Date not null,
	Valor decimal(10,2) not null
);

show tables;

describe tbProduto;

alter table tbProduto add Peso decimal(3,2);

alter table tbProduto add Cor varchar(50);

alter table tbProduto add Marca varchar(50);


-- Exercicio 5
create database cleide;

use cleide;

create table tbvenda (
    nf int auto_increment primary key,
    datavalidade date not null
);

alter table tbvenda add column preco decimal(10,2) not null,
add column qtd smallint unsigned not null;

alter table tbvenda drop column datavalidade;

alter table tbvenda add column datavenda date;

create table produto (
    codigob bigint(13) not null,
    nomeprod varchar(50) not null,
    primary key (codigob)
);

alter table tbvenda add column codigob bigint(13) not null, 
add constraint fk_codigo_produto foreign key (codigob) references produto(codigob);


-- Exercicio 6
create database dbdesenvolvimento;
use dbdesenvolvimento;

create table tbproduto (
    idprop int primary key,
    nomeprod varchar(50) not null,
    qtd int,
    datavalidade date not null,
    preco decimal(10,2) not null
);

alter table tbproduto add column peso decimal(10,2),
add column cor varchar(50),
add column marca varchar(50) not null;

alter table tbproduto drop column cor;

alter table tbproduto modify column peso decimal(10,2) not null;

alter table tbproduto add column cor varchar(50);


-- Segundo banco de dados do exercicio 6
create database dblojagrande;
use dblojagrande;

-- nome pedido no exercicio foi dblojica.tbcliente, contudo utilizar o ponto causa erro por ser comando 
create table dblojicatbcliente (
    nomecli varchar(50) not null,
    codigocli int primary key,
    datacadastro date not null
);

create table dblojagrande.tbfuncionario (
    nomefunc varchar(50) not null,
    codigofunc int primary key,
    datacadastro datetime not null
);

drop database dblojagrande;

alter table dblojica.tbcliente add column cpf char(11) not null unique;


-- Exercicio 7
-- Kaique Vieira e Guilherme Leonardo
create database dbescola;

use dbescola;

create table tbcliente (
    id int primary key,
    nomeclid varchar(50) not null,
    numend smallint,
    datacadastro datetime default current_timestamp
);


alter table tbcliente add column cpf char(11) unique not null;

alter table tbcliente add column cep char(5);

-- Segundo banco de dados 
create database dbempresa;

use dbempresa;

create table tbendereco (
    cep char(5) primary key,
    logradouro varchar(250) not null,
    iduf tinyint
);

alter table tbendereco add constraint fk_cep_tbcliente foreign key (cep) references tbendereco (cep);

/* Perguntas para o professor o Kaique Vieira:
 1-tinyText bigText são parecidos com o varchar ou char?  
 2-Quando criamos um check?  
 3-Diferença entre DDL's, EXCEL e PowerBI?
 
 Dificuldades Guilherme Leonardo:
  1°Dificuldade até o momento: Nomenclatura, posso alterar o nome para ficar condizente, por exemplo ao invés de preço com ç e ter que escrever preco, posso escrever valor?
  2°Dificuldade, por estar vendo outras linguagens de programação, as vezes me perco na nomenclatura, aqui no SQL, Existem nomenclaturas de comandos que possuem espaço, como por exemplo: Primary Key, as vezes eu erro pensando que é junto.
  3° Vejo alguns profissionais digitando em maisculo os comandos e código, isso é considerado boa prática?
*/

drop database dbempresa;


-- Exercicio 8
use dbescola;

create table tbest(
IdUf tinyint primary key,
NomeUFS VARCHAR(2) not null,
NomeEstado varchar(40) not null
);

alter table tbEndereco add constraint Fk_IdUF_TbEndereco Foreign Key (IdUf) references tbest (IdUf);

alter table tbest drop column NomeEstado;

rename table tbest to tbEstado;

-- https://www.bosontreinamentos.com.br/mysql/como-renomear-colunas-usando-comandos-sql-no-mysql/
ALTER TABLE tbEstado CHANGE COLUMN NomeUFS NomeUf varchar(2);

describe tbEstado; -- Fui ver se funcionou msm

alter table tbendereco add column IdCid mediumint ;

use dbescola;

create table tbcidade(
IdCid mediumint primary key,
NomeCidade varchar(50) not null
);

ALTER TABLE tbcidade modify COLUMN NomeCidade varchar(250);

alter table tbEndereco add constraint Fk_IdCid_TbEndereco Foreign Key (IdCid) references tbcidade (IdCid);


-- Exercicio 9

