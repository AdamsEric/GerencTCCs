CREATE PROCEDURE uspCursoInserir
	@CursoNome nvarchar(80),
	@CursoUnidadeID int,
	@CursoCoordenador int
AS
BEGIN
	INSERT INTO tblCurso
	(
		CursoNome,
		CursoUnidadeID
	)
	VALUES
	(
		@CursoNome,
		@CursoUnidadeID
	)
	SELECT @@IDENTITY AS RETORNO
END



CREATE PROCEDURE uspCursoAlterar
	@CursoID int,
	@CursoNome nvarchar(80),
	@CursoUnidadeID int
AS
BEGIN
	UPDATE tblCurso
	SET
		CursoNome = @CursoNome,
		CursoUnidadeID = @CursoUnidadeID
	WHERE
		CursoID = @CursoID

	SELECT @CursoID AS RETORNO
END




CREATE PROCEDURE uspCursoExcluir
	@CursoID int
AS
BEGIN
	DELETE FROM tblCurso
	WHERE
		CursoID = @CursoID

	SELECT @CursoID AS RETORNO
END



CREATE PROCEDURE uspCursoConsultarPorNome
	@CursoNome nvarchar(80)
AS
BEGIN

	SELECT
		CursoID,
		CursoNome,
		CursoUnidadeID
	FROM
		tblCurso
	WHERE
		CursoNome LIKE '%' + @CursoNome + '%'
END