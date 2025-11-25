
CREATE DATABASE academia;
USE academia;


CREATE TABLE Planos (
    id_planos INT AUTO_INCREMENT PRIMARY KEY,
    Nome_plano VARCHAR(80) NOT NULL,
    Valor_plano DECIMAL(10,2) NOT NULL
);



CREATE TABLE Unidades (
    id_unidades INT AUTO_INCREMENT PRIMARY KEY,
	CEP VARCHAR(255) NOT NULL,
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

