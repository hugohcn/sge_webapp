set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprSaldoCarteiraCRUD
--
-- Descrição : CRUD do objeto tblSaldoCarteira
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
-- 12/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblSaldoCarteira
--**************************************************************************

CREATE PROCEDURE [sprSaldoCarteiraCRUD]
(
 @sprstrOperacao     nchar(1),
 @sprintEspecificoR    smallint,
 @sprintIdSaldoCarteira     smallint,
 @sprintIdCarteira     smallint,
 @sprdteBaixa     datetime
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(idSaldo)+1,1)
 FROM tblSaldoCarteira

 INSERT INTO tblSaldoCarteira (idSaldo, id_Carteira, dteBaixa)
 VALUES (@strCodigo, @sprintIdCarteira, @sprdteBaixa)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT idSaldo
       FROM tblSaldoCarteira
       WHERE idSaldo = @sprintIdSaldoCarteira)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT idSaldo, id_Carteira, dteBaixa
   FROM tblSaldoCarteira
   WHERE idSaldo = @sprintIdSaldoCarteira

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT idSaldo, id_Carteira, dteBaixa
    FROM tblSaldoCarteira
   
   ELSE IF @sprintEspecificoR = 3   
   SELECT idSaldo, id_Carteira, dteBaixa
   FROM tblSaldoCarteira
   WHERE id_Carteira = @sprintIdCarteira
   
   ELSE IF @sprintEspecificoR = 4
   SELECT idSaldo, id_Carteira, dteBaixa
   FROM tblSaldoCarteira
   WHERE dteBaixa = @sprdteBaixa

   --ELSE IF @sprintEspecificoR = 5
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE cd_colabr = @sprstrColaborador
  END
ELSE 

IF @sprstrOperacao = 'U'
   UPDATE tblSaldoCarteira
   SET dteBaixa    = @sprdteBaixa
   WHERE idSaldo = @sprintIdSaldoCarteira
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblSaldoCarteira
  WHERE idSaldo = @sprintIdSaldoCarteira AND id_Carteira = @sprintIdCarteira
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprCarteiraCRUD TO sge