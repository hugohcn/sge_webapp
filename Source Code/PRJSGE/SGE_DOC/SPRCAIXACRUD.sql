set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
--**************************************************************************
--
-- procedure : sprVendaCRUD
--
-- Descrição : CRUD do objeto tblVenda
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
-- 04/05/2009 Hugo Carvalho Betelhost		SPCRUD do objeto tblVenda
-- 30/06/2009 Hugo Carvalho	Betelhost		Incluido o campo bitstatus e alterada mais um if para retornar dados que estao true.
--**************************************************************************

CREATE PROCEDURE [dbo].[sprCaixaCRUD]
(
 @sprstrOperacao					nchar(1),
 @sprintEspecificoR				smallint,
 @sprintDteCaixa						datetime,
 @sprfltValorAbertura			float,
 @sprfltValorFechamento		float,
 @sprfltValorTransicao		float,
 @sprbitStatus				char(1)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 --SELECT @strCodigo = ISNULL(MAX(id_Venda)+1,1)
 --FROM tblVenda

 INSERT INTO tblCaixa (dteCaixa, fltValorAbertura, fltValorFechamento, fltValorTransicao, bitStatus)
 VALUES (@sprintDteCaixa, @sprfltValorAbertura, @sprfltValorFechamento, @sprfltValorTransicao, @sprbitStatus)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT dteCaixa
       FROM tblCaixa
       WHERE dteCaixa = @sprintDteCaixa)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT dteCaixa, fltValorAbertura, fltValorFechamento, fltValorTransicao, bitStatus
   FROM tblCaixa
   WHERE dteCaixa = @sprintDteCaixa

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT dteCaixa, fltValorAbertura, fltValorFechamento, fltValorTransicao, bitStatus
    FROM tblCaixa
   
	ELSE IF @sprintEspecificoR = 3   
	SELECT dteCaixa, fltValorAbertura, fltValorFechamento, fltValorTransicao, bitStatus
    FROM tblCaixa
	WHERE dteCaixa = (select max(dteCaixa) from tblCaixa) AND bitStatus =  @sprbitStatus

   ELSE IF @sprintEspecificoR = 4   
   SELECT dteCaixa, fltValorAbertura, fltValorFechamento, fltValorTransicao, bitStatus
    FROM tblCaixa
   WHERE bitStatus = @sprbitStatus
   
   ELSE IF @sprintEspecificoR = 5   
	SELECT dteCaixa, fltValorAbertura, fltValorFechamento, fltValorTransicao, bitStatus
    FROM tblCaixa
	WHERE dteCaixa = (select max(dteCaixa) from tblCaixa) 

   --ELSE IF @sprintEspecificoR = 5
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE cd_colabr = @sprstrColaborador
  END
ELSE 

IF @sprstrOperacao = 'U'

   UPDATE tblCaixa
   SET	fltValorAbertura    = @sprfltValorAbertura,
		fltValorFechamento = @sprfltValorFechamento,
		fltValorTransicao = @sprfltValorTransicao,
		bitStatus		= @sprbitStatus
   WHERE dteCaixa = @sprintDteCaixa
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblCaixa
  WHERE dteCaixa = @sprintDteCaixa
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprVendaCRUD TO sge

