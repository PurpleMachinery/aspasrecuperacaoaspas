USE MASTER;
DROP DATABASE estacionamento;
CREATE DATABASE estacionamento;
GO

USE estacionamento;
CREATE TABLE funcionarios(
	pk_idFuncionario INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	telefone NVARCHAR(15) NOT NULL,
	cpf NVARCHAR(11) UNIQUE,
	registro INT
);

CREATE TABLE clientes(
	pk_idCliente INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	telefone NVARCHAR(15) NOT NULL,
	cpf NVARCHAR(11) UNIQUE
);

CREATE TABLE carros(
	pk_idCarro INT PRIMARY KEY IDENTITY(1,1),
	modelo NVARCHAR(40),
	cor NVARCHAR(30),
	placa NVARCHAR(7) UNIQUE NOT NULL,
	fk_idCliente INT REFERENCES clientes(pk_idCliente)
);
