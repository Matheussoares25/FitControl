
CREATE DATABASE academia;
USE academia;


CREATE TABLE Planos (
    id_planos INT AUTO_INCREMENT PRIMARY KEY,
    Nome_plano VARCHAR(80) NOT NULL,
    Valor_plano DECIMAL(10,2) NOT NULL
);

CREATE TABLE Estado (
id_estado INT AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(200) NOT NULL,
sigla CHAR(2) NOT NULL UNIQUE
);

CREATE TABLE Cidade (
id_cidade INT AUTO_INCREMENT PRIMARY KEY,
estado_id_estado INT NOT NULL,
nome VARCHAR(200) NOT NULL,
UNIQUE (nome, estado_id_estado),
CONSTRAINT fk_estado FOREIGN KEY (estado_id_estado) REFERENCES Estado(id_estado)
);

CREATE TABLE Bairro (
id_bairro INT AUTO_INCREMENT PRIMARY KEY,
cidade_id_cidade INT NOT NULL,
nome VARCHAR(200) NOT NULL,
UNIQUE (nome, cidade_id_cidade),
CONSTRAINT fk_cidade FOREIGN KEY (cidade_id_cidade) REFERENCES Cidade(id_cidade)
);

CREATE TABLE Logradouro (
id_logradouro INT AUTO_INCREMENT PRIMARY KEY,
bairro_id_bairro INT NOT NULL,
nome VARCHAR(200) NOT NULL,
tipo VARCHAR(50) NOT NULL,
UNIQUE (nome, bairro_id_bairro),
CONSTRAINT fk_bairro FOREIGN KEY (bairro_id_bairro) REFERENCES Bairro(id_bairro)
);

CREATE TABLE Unidades (
    id_unidades INT AUTO_INCREMENT PRIMARY KEY,
	logradouro_id_logradouro INT NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(100),
    telefone VARCHAR(20),
    cnpj_unidade VARCHAR(20) UNIQUE,
    CONSTRAINT fk_enderecoUni FOREIGN KEY (logradouro_id_logradouro) REFERENCES Logradouro (id_logradouro) 
);


CREATE TABLE Alunos (
    id_aluno INT AUTO_INCREMENT PRIMARY KEY,
    Nome_al VARCHAR(85) NOT NULL,
    CPF_al VARCHAR(11) NOT NULL UNIQUE,
    Idade_al INT,
    Genero_al VARCHAR(15),
    Numero_matricula VARCHAR(25),
    plano_al INT,
    unidade INT,

    FOREIGN KEY (plano_al) REFERENCES Planos(id_planos),
    FOREIGN KEY (unidade) REFERENCES Unidades(id_unidades)
);

CREATE TABLE Pagtos (
    id_pagtos INT AUTO_INCREMENT PRIMARY KEY,
    id_unidade INT NOT NULL,
    Cod_pagto VARCHAR(80),
    data_pagto DATE,
    plano INT,
    aluno_pag INT,

    FOREIGN KEY (id_unidade) REFERENCES Unidades(id_unidades),
    FOREIGN KEY (plano) REFERENCES Planos(id_planos),
    FOREIGN KEY (aluno_pag) REFERENCES Alunos(id_aluno)
);

