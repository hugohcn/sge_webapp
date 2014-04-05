set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprRevendedorCRUD
--
-- Descrição : CRUD do objeto tblRevendedor
--
-- Argumentos:
--
--
--**************************************************************************
--
-- Manutenção
--
--   Data     Autor   Empresa   Descrição
-- ---------- ------------- --------------- ---------------------------
-- 15/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblRevendedor
--**************************************************************************

CREATE PROCEDURE [sprRevendedorCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdRevendedor		int,
 @sprstrNome				varchar(70),
 @sprstrEndereco			varchar(60),
 @strintNumero				int,
 @sprstrBairro				varchar(40),
 @sprstrCidade				varchar(40),
 @sprstrEstado				varchar(40),
 @sprstrCep					varchar(10),
 @sprstrTelefone			varchar(14),
 @sprstrCelular				varchar(14),
 @sprstrFax					varchar(14),
 @sprstrEmail				varchar(90)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_Revendedor)+1,1)
 FROM tblRevendedor

 INSERT INTO tblRevendedor (id_Revendedor, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strTelefone, strCelular,
							strFax, strEmail)
 VALUES (@strCodigo, @sprstrNome, @sprstrEndereco, @strintNumero, @sprstrBairro, @sprstrCidade, @sprstrEstado, @sprstrCep, @sprstrTelefone, @sprstrCelular, @sprstrFax, @sprstrEmail)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Revendedor
       FROM tblRevendedor
       WHERE id_Revendedor = @sprintIdRevendedor)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Revendedor, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strTelefone, strCelular,
							strFax, strEmail
   FROM tblRevendedor
   WHERE id_Revendedor = @sprintIdRevendedor

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
     SELECT id_Revendedor, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strTelefone, strCelular,
							strFax, strEmail
		FROM tblRevendedor
   
	--ELSE IF @sprintEspecificoR = 3  
	--SELECT idFavorito, idFuncionario, strNome, strUrl
	--FROM tblFavoritos
	--WHERE idFuncionario = @sprintIdFuncionario

    
   --ELSE IF @sprintEspecificoR = 4
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE intCurriculoSituacao = @sprintCurriculoSituacao

   --ELSE IF @sprintEspecificoR = 5
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE cd_colabr = @sprstrColaborador
  END
ELSE 

IF @sprstrOperacao = 'U'
   UPDATE tblRevendedor
   SET	strNome = @sprstrNome,
		strEndereco = @sprstrEndereco, 
		intNumero = @strintNumero,
		strBairro = @sprstrBairro, 
		strCidade = @sprstrCidade,
		strEstado = @sprstrEstado, 
		strCep = @sprstrCep, 
		strTelefone = @sprstrTelefone, 
		strCelular = @sprstrCelular,
		strFax = @sprstrFax, 
		strEmail = @sprstrEmail
   FROM tblRevendedor
   WHERE id_Revendedor = @sprintIdRevendedor
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblRevendedor
  WHERE id_Revendedor = @sprintIdRevendedor
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprRevendedorCRUD TO sge