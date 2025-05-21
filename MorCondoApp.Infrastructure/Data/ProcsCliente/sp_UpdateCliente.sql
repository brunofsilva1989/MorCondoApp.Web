IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'sp_UpdateCliente')

BEGIN
	PRINT 'Dropping Procedure sp_UpdateCliente'
	DROP  Procedure  sp_UpdateCliente
END
 
GO
 
PRINT 'Creating Procedure sp_UpdateCliente'

GO
/*
===========================================================
Autor: Bruno Silva
Data de criação: 18/05/2025
Última modificação: 18/05/2025
Descrição: Procedure para listar os clientes cadastrados no sistema

Parâmetros: Não existe parâmetros para essa proc.    
    
Retorno:
    Retorna os dados dos clientes cadastrados no sistema.
===========================================================
*/
CREATE PROCEDURE sp_UpdateCliente
	@Id INT,
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
	UPDATE clientes
	 SET Nome = @Nome,
		 Email = @Email,
		 Telefone = @Telefone,
		 Cpf_Cnpj = @Cpf_Cnpj,
		 Endereco = @Endereco,
		 Numero = @Numero,
		 Complemento = @Complemento,
		 Bairro = @Bairro,
		 Cidade = @Cidade,
		 Estado = @Estado,
		 Cep = @Cep,
		 Updated_at = GETDATE(),
		 Condominio_id = @Condominio_id,
		 Proprietario_id = @Proprietario_id,
		 Unidade = @Unidade
	WHERE Id = @Id;
END