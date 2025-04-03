-- criando banco de dados
CREATE DATABASE bdEcommerce2a;
-- usando o banco de dados
use bdEcommerce2a;
-- criando as tabelas do bando de dados
create table Usuario(
Id int primary key auto_increment,
Nome varchar(40) not null,
Email varchar(40) not null,
Senha varchar(40) not null
);
create table Cliente(
CodCLi int primary key auto_increment,
NomeCli varchar(40) not null,
TelCli varchar(20) not null,
EmailCli varchar(40) not null
);
-- CONSULTANDO AS TABELAS DO BANCO
select * from Usuario;
select * from Cliente;