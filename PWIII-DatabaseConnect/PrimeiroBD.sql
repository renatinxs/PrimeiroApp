create database dbBancoApp;
use dbBancoApp;

create table usuario
(
IdUsu int primary key auto_increment,
nomeUsu varchar(50) not null,
Cargo varchar(50) not null,
DataNasc datetime
);

insert into usuario(nomeUsu, Cargo, DataNasc)
       values('Nilson','Gerente','1978/05/01'),
			 ('Bruno','Colaborador','2000/10/12');
             
select * from usuario;

Create table endereco(
Id int primary key auto_increment,
CEP varchar(100) not null,
Estado varchar(70) not null,
Cidade varchar(70) not null,
Bairro varchar(70) not null,
Logradouro varchar(150) not null,
Complemento varchar(150) not null,
Numero varchar(15) not null
);      