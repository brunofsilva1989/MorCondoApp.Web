IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'sp_AutenticarUsuario')

BEGIN
	PRINT 'Dropping Procedure sp_AutenticarUsuario'
	DROP  Procedure  sp_AutenticarUsuario
END
 
GO
 
PRINT 'Creating Procedure sp_AutenticarUsuario'

GO
/*
===========================================================
Autor: Bruno Silva
Data de criação: 05/06/2025
Última modificação: 
Descrição: Procedure para buscar  dados informados o login do sistema.

Parâmetros: Dados de entrada necessários para criação do cliente (email e senha)
    
Retorno:
    Retorna o usuário autenticado com base no email e senha informados.
===========================================================
*/
CREATE PROCEDURE sp_AutenticarUsuario

@EMAIL VARCHAR(255),
@SENHA VARCHAR(255)

AS
BEGIN 
	SELECT TOP 1 *
	FROM usuarios
	WHERE email = @EMAIL AND senha_hash = @SENHA
END