IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'sp_DeletarCliente')

BEGIN
	PRINT 'Dropping Procedure sp_DeletarCliente'
	DROP  Procedure  sp_DeletarCliente
END
 
GO
 
PRINT 'Creating Procedure sp_DeletarCliente'

GO
/*
===========================================================
Autor: Bruno Silva
Data de criação: 21/05/2025
Última modificação: 21/05/2025
Descrição: Procedure para deletar cliente com base no Id

Parâmetros: Dado de entrada é o Id do cliente a ser deletado.
    
Retorno:
    Exclui o cliente do banco de dados com base no Id.
===========================================================
*/
CREATE PROCEDURE sp_DeletarCliente
	@Id INT
AS

BEGIN
	SET NOCOUNT ON;
	DELETE FROM clientes WHERE Id = @Id;
END