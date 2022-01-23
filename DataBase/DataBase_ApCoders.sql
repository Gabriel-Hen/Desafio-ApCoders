/* DataBase_ApCoders_Logico: */

CREATE TABLE Despesas (
    descricao varchar(250),
    tipo_despesa varchar(250),
    valor decimal,
    vencimento_fatura DATE,
    status_pagamento BOOLEAN,
    unidade_id INT
);

CREATE TABLE Unidade (
    identificacao varchar(250),
    proprietario varchar(250),
    condominio varchar(250),
    endereco varchar(250),
    ID INT PRIMARY KEY
);

CREATE TABLE Inquilinos (
    nome varchar(250),
    idade NUMERIC,
    sexo BOOLEAN,
    telefone varchar(13),
    email varchar(250),
    unidade_id INT
);
 
ALTER TABLE Despesas ADD CONSTRAINT FK_Despesas_1
    FOREIGN KEY (unidade_id)
    REFERENCES Unidade (ID)
    ON DELETE CASCADE;
 
ALTER TABLE Inquilinos ADD CONSTRAINT FK_Inquilinos_1
    FOREIGN KEY (unidade_id)
    REFERENCES Unidade (ID)
    ON DELETE CASCADE;