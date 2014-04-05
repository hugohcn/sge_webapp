set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprCarteiraCRUD
--
-- Descrição : CRUD do objeto tblCarteira
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
-- 12/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblCarteira
--**************************************************************************

CREATE PROCEDURE [sprCarteiraCRUD]
(
 @sprstrOperacao     nchar(1),
 @sprintEspecificoR    smallint,
 @sprintIdCarteira     smallint,
 @sprintIdCliente     smallint,
 @sprfltValorTotal     float,
 @sprdteDataPagamento	datetime,
 @sprfltValorCredito	float,
 @sprbitStatusCarteira  bit
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(ID_Carteira)+1,1)
 FROM tblCarteira

 INSERT INTO tblCarteira (id_Carteira, id_Cliente, fltValorTotal, dteDataPagamento, fltValorCredito, bitStatusCarteira)
 VALUES (@strCodigo, @sprintIdCliente, @sprfltValorTotal, @sprdteDataPagamento, @sprfltValorCredito, @sprbitStatusCarteira)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Carteira
       FROM tblCarteira
       WHERE id_Carteira = @sprintIdCarteira)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Carteira, id_Cliente, fltValorTotal, dteDataPagamento, fltValorCredito, bitStatusCarteira
   FROM tblCarteira
   WHERE id_Carteira = @sprintIdCarteira

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Carteira, id_Cliente, fltValorTotal, dteDataPagamento, fltValorCredito, bitStatusCarteira
    FROM tblCarteira
   
   ELSE IF @sprintEspecificoR = 3   
   SELECT id_Carteira, id_Cliente, fltValorTotal, dteDataPagamento, fltValorCredito, bitStatusCarteira
   FROM tblCarteira
   WHERE id_Cliente = @sprintIdCliente
   
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
   UPDATE tblCarteira
   SET FLTVALORTOTAL    = @sprfltValorTotal,
    dteDataPagamento    = @sprdteDataPagamento,
    fltValorCredito = @sprfltValorCredito,
    bitStatusCarteira  = @sprbitStatusCarteira
   WHERE ID_Carteira = @sprintIdCarteira
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblCarteira
  WHERE ID_Carteira = @sprintIdCarteira
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprCarteiraCRUD TO erp_pipi
