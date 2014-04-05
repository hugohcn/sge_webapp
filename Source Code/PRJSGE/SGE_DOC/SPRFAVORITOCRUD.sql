set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprFavoritosCRUD
--
-- Descrição : CRUD do objeto tblFavoritos
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
-- 15/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblFavoritos
--**************************************************************************

CREATE PROCEDURE [sprFavoritosCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdFavorito				int,
 @sprintIdFuncionario			int,
 @sprstrNomeFavorito		varchar(40),
 @sprstrUrlFavorito				varchar(200)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(idFavorito)+1,1)
 FROM tblFavoritos

 INSERT INTO tblFavoritos (id_Favorito, id_Funcionario, strNome, strUrl)
 VALUES (@strCodigo, @sprintIdFuncionario, @sprstrNomeFavorito, @sprstrUrlFavorito)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Favorito
       FROM tblFavoritos
       WHERE id_Favorito = @sprintIdFavorito)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Favorito, id_Funcionario, strNome, strUrl
   FROM tblFavoritos
   WHERE id_Favorito = @sprintIdFavorito

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Favorito, id_Funcionario, strNome, strUrl
    FROM tblFavoritos
   
	SELECT id_Favorito, id_Funcionario, strNome, strUrl
	FROM tblFavoritos
	WHERE id_Funcionario = @sprintIdFuncionario

   --ELSE IF @sprintEspecificoR = 3   
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE strLogin = @sprstrLogin
   
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

   UPDATE tblFavoritos
   SET	strNome = @sprstrNomeFavorito,
		strUrl = @sprstrUrlFavorito
   WHERE id_Favorito = @sprintIdFavorito
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblFavoritos
  WHERE id_Favorito = @sprintIdFavorito
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprFavoritosCRUD TO sge