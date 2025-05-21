IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'sp_CriarClientes')

BEGIN
	PRINT 'Dropping Procedure sp_CriarClientes'
	DROP  Procedure  sp_CriarClientes
END
 
GO
 
PRINT 'Creating Procedure sp_CriarClientes'

GO
/*
===========================================================
Autor: Bruno Silva
Data de criação: 21/05/2025
Última modificação: 21/05/2025
Descrição: Procedure criar clientes com base nos dados informados.

Parâmetros: Dados de entrada necessários para criação do cliente
    
Retorno:
    Criar o cliente no banco de dados com os dados informados.
===========================================================
*/
CREATE PROCEDURE sp_CriarClientes	
	@Nome NVARCHAR(100),
	@Email NVARCHAR(100),
	@Telefone NVARCHAR(20),
	@Cpf_Cnpj NVARCHAR(20),
	@Endereco NVARCHAR(200),
	@Numero NVARCHAR(10),
	@Complemento NVARCHAR(50),
	@Bairro NVARCHAR(50),
	@Cidade NVARCHAR(50),
	@Estado NVARCHAR(2),
	@Cep NVARCHAR(10),
	@Condominio_id INT,
	@Proprietario_id INT,
	@Unidade NVARCHAR(10)
AS

BEGIN
	SET NOCOUNT ON;
	INSERT INTO clientes (Nome, Email, Telefone, Cpf_Cnpj, Endereco, Numero, Complemento, Bairro, Cidade, Estado, Cep, Created_at, Updated_at, Condominio_id, Proprietario_id, Unidade)
	VALUES (@Nome, @Email, @Telefone, @Cpf_Cnpj, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Cep, GETDATE(), GETDATE(), @Condominio_id, @Proprietario_id, @Unidade);
	SELECT SCOPE_IDENTITY() AS Id;
END