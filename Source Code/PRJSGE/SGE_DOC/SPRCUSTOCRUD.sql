set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprCustoCRUD
--
-- Descrição : CRUD do objeto tblCusto
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
-- 15/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblCusto
--**************************************************************************

CREATE PROCEDURE sprCustoCRUD
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdCusto				int,
 @sprintIdTipoCusto			int,
 @sprstrDescricao			varchar(100),
 @sprdteDataCusto			datetime,
 @sprfltValorCusto			float
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_Custo)+1,1)
 FROM tblCusto

 INSERT INTO tblCusto (id_Custo, id_TipoCusto, strDescricao, dteCusto, fltValorCusto)
 VALUES (@strCodigo, @sprintIdTipoCusto, @sprstrDescricao,  @sprdteDataCusto, @sprfltValorCusto)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Custo
       FROM tblCusto
       WHERE id_Custo = @sprintIdCusto)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Custo, id_TipoCusto, strDescricao, dteCusto, fltValorCusto
   FROM tblCusto
   WHERE id_Custo = @sprintIdCusto

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Custo, id_TipoCusto, strDescricao, dteCusto, fltValorCusto
   FROM tblCusto
   
	ELSE IF @sprintEspecificoR = 3  
	SELECT id_Custo, id_TipoCusto, strDescricao, dteCusto, fltValorCusto
   FROM tblCusto
	WHERE id_TipoCusto = @sprintIdTipoCusto

    
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

   UPDATE tblCusto
   SET	id_TipoCusto = @sprintIdTipoCusto,
		strDescricao = @sprstrDescricao,
		dteCusto = @sprdteDataCusto,
		fltValorCusto = @sprfltValorCusto
   WHERE id_Custo = @sprintIdCusto
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblCusto
  WHERE id_Custo = @sprintIdCusto
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprCustoCRUD TO sge