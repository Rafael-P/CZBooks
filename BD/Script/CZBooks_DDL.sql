--DDL

CREATE DATABASE CZBooks
GO

USE CZBooks
GO

CREATE TABLE tiposUsuarios
(
	idTipoUsuario INT PRIMARY KEY IDENTITY
	,tipoUsuario VARCHAR(50) UNIQUE NOT NULL
)
GO

CREATE TABLE usuarios
(
	idUsuario INT PRIMARY KEY IDENTITY
	,nomeUsuario VARCHAR(50) UNIQUE NOT NULL
	,idTipoUsuario INT FOREIGN KEY REFERENCES tiposUsuarios(idTipoUsuario)
)
GO

CREATE TABLE autores
(
	idAutores INT PRIMARY KEY IDENTITY
	,nome VARCHAR(50)
)
GO

CREATE TABLE categorias
(
	idCategoria INT PRIMARY KEY IDENTITY
	,categoria VARCHAR(50)
)
GO

CREATE TABLE livros
(
	idLivro INT PRIMARY KEY IDENTITY
	,titulo VARCHAR(100) UNIQUE NOT NULL
	,sinopse VARCHAR(200) 
	,idCategoria INT FOREIGN KEY REFERENCES categorias(idCategoria)
	,idAutor INT FOREIGN KEY REFERENCES autores(idAutores)
	,dataDaPublicacao VARCHAR(50)
	,preco DECIMAL NOT NULL 
)
GO

CREATE TABLE instituicoes
(
	idInstituicao INT PRIMARY KEY IDENTITY
	,nomeInstituicao VARCHAR(100)
	,endereco VARCHAR(200)
	,telefone VARCHAR(50)
)
GO