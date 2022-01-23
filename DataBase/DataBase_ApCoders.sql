CREATE DATABASE apcoders

USE apcoders

CREATE TABLE Despesas (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Unidade_ID INT,
    descricao VARCHAR(250),
    tipo_despesa VARCHAR(250),
    valor DECIMAL,
    vencimento_fatura DATE,
    status_pagamento VARCHAR(6)
);

CREATE TABLE Unidade (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    identificacao VARCHAR(250),
    proprietario VARCHAR(250),
    condominio VARCHAR(250),
    endereco VARCHAR(400)
);

CREATE TABLE Inquilinos (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Unidade_ID INT,
    nome VARCHAR(250),
    idade INT,
    sexo VARCHAR(10),
    telefone VARCHAR(14),
    email VARCHAR(250)
);
 
ALTER TABLE Despesas ADD CONSTRAINT FK_Despesas_2
    FOREIGN KEY (Unidade_ID)
    REFERENCES Unidade (ID)
    ON DELETE CASCADE;
 
ALTER TABLE Inquilinos ADD CONSTRAINT FK_Inquilinos_2
    FOREIGN KEY (Unidade_ID)
    REFERENCES Unidade (ID)
    ON DELETE CASCADE;
