IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'sp_ListarClientes')

BEGIN
	PRINT 'Dropping Procedure sp_ListarClientes'
	DROP  Procedure  sp_ListarClientes
END
 
GO
 
PRINT 'Creating Procedure sp_ListarClientes'

GO
/*
===========================================================
Autor: Bruno Silva
Data de criação: 21/05/2025
Última modificação: 21/05/2025
Descrição: Procedure para listar os clientes cadastrados no sistema

Parâmetros: Não existe parâmetros para essa proc.    
    
Retorno:
    Retorna os dados dos clientes cadastrados no sistema.
===========================================================
*/
CREATE  Procedure sp_ListarClientes

AS
BEGIN
   SET NOCOUNT ON;

   SELECT 
        c.Id,
        c.Nome,
        c.Email,
        c.Telefone,
        c.Cpf_Cnpj,
        c.Endereco,
        c.Numero,
        c.Complemento,
        c.Bairro,
        c.Cidade,
        c.Estado,
        c.Cep,
        c.Created_at,
        c.Updated_at,
        c.Condominio_id,
        c.Proprietario_id,
        c.Unidade
       
   FROM clientes c WITH (NOLOCK)
    
END

GO
   