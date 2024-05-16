create database db_cad_cliente_sharp;
use db_cad_cliente_sharp;

create table tb_acesso(
    nome_usuario varchar(30) not null,
    empresa_parceira varchar(50) not null,
    funcao_cargo varchar(50) not null,
    email_comercial varchar(100) primary key,
    senha varchar(20) not null
);

create table tb_cad_cliente(
    id_cliente smallint primary key,
    data_cad datetime default current_timestamp,
    nome_fantasia varchar(50) default null, 
    razao_social varchar(50) not null unique,
    cnpj char(14) check(cnpj regexp '^[0-9]{2}\.[0-9]{3}\.[0-9]{3}/[0-9]{3}-[0-9]{2}') not null,
    cpf char(11) check(cpf regexp '^[0-9]{3}\.[0-9]{3}\.[0-9]{3}-[0-9]{2}') not null,
    telefone char(13) null check(telefone regexp '^[0-9]{2} [0-9]{8}'),
    email_comercial varchar(100) not null,
    representante varchar(50) not null,
    email_representante varchar(100) not null, 
    celular_representante char(14) null,
    endereco_comercial varchar(50) not null,
    num_endereco varchar(6) not null,
    cep char(8) check(cep regexp '^[0-9]{5}-[0-9]{3}') not null,
    bairro varchar(50) not null,
    cidade varchar(50) not null,
    estado enum('Acre', 'Alagoas', 'Amapá', 'Amazonas', 'Bahia', 'Ceará', 'Distrito Federal', 'Espírito Santo', 'Goiás', 'Maranhão', 'Mato Grosso', 'Mato Grosso do Sul', 'Minas Gerais', 'Pará', 'Paraíba', 'Paraná', 'Pernambuco', 'Piauí', 'Rio de Janeiro', 'Rio Grande do Norte', 'Rio Grande do Sul', 'Rondônia', 'Roraima', 'Santa Catarina', 'São Paulo', 'Sergipe', 'Tocantins') not null,
    produto_servico varchar(50) not null,
    news enum("SIM", "NÃO") default "SIM",
    data_venda_primeira date not null,
    data_venda_ultima date not null
);


