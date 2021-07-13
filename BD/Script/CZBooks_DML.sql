--DML

USE CZBooks
GO

INSERT INTO tiposUsuarios(tipoUsuario)
VALUES ('adm')
	  ,('cliente')	
GO

INSERT INTO Usuarios(nomeUsuario, idTipoUsuario)
VALUES ('adm', 1)
	  ,('Rafael', 2) 
GO

INSERT INTO autores(nome)
VALUES ('J K Rowling')
GO

INSERT INTO categorias(categoria)
VALUES ('Fantasia')
GO

INSERT INTO livros(titulo, sinopse, idCategoria, idAutor, dataDaPublicacao, preco)
VALUES			  ('Harry Potter e a Pedra Filosofal', 'Primeiro livro da colecao', 1, 1, '1997', 25)
				 ,('Harry Potter e a Camera Secreta', 'Segundo livro da colecao', 1, 1, '1998', 26)
				 ,('Harry Potter e o Prisioneiro de Azkaban', 'Terceiro livro da colecao', 1, 1, '1999', 26.90)
GO

INSERT INTO instituicoes(nomeInstituicao, endereco, telefone)
VALUES					('Floreios e Borroes', 'Beco Diagonal', '555777999')
GO

ALTER TABLE usuarios
ADD Email VARCHAR(50)
GO

ALTER TABLE usuarios
ADD Senha VARCHAR(50)
GO

UPDATE usuarios
SET Email = 'adm@adm.com', Senha = '123456'
WHERE idUsuario = 1
GO

UPDATE usuarios
SET Email = 'rafa@email.com', Senha = '123456'
WHERE idUsuario = 2
GO