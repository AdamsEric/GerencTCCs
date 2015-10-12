CREATE PROCEDURE uspProfessorInserir
	@ProfessorNome nvarchar(70),
	@ProfessorMatricula nvarchar(15),
	@ProfessorTelefone varchar(15)
AS
BEGIN
	INSERT INTO tblProfessor
	(
		ProfessorNome,
		ProfessorMatricula,
		ProfessorTelefone
	)
	VALUES
	(
		@ProfessorNome,
		@ProfessorMatricula,
		@ProfessorTelefone
	)
	SELECT @@IDENTITY AS RETORNO
END




CREATE PROCEDURE uspProfessorAlterar
	@ProfessorID int,
	@ProfessorNome nvarchar(70),
	@ProfessorMatricula nvarchar(15),
	@ProfessorTelefone varchar(15)
AS
BEGIN
	UPDATE tblProfessor
	SET
		ProfessorNome = @ProfessorNome,
		ProfessorMatricula = @ProfessorMatricula,
		ProfessorTelefone = @ProfessorTelefone
	WHERE
		ProfessorID = @ProfessorID

	SELECT @ProfessorID AS RETORNO
END




CREATE PROCEDURE uspProfessorExcluir
	@ProfessorID int
AS
BEGIN
	DELETE FROM tblProfessor
	WHERE
		ProfessorID = @ProfessorID

	SELECT @ProfessorID AS RETORNO
END



CREATE PROCEDURE uspProfessorConsultarPorNome
	@ProfessorNome nvarchar(70)
AS
BEGIN

	SELECT
		ProfessorID,
		ProfessorNome,
		ProfessorMatricula,
		ProfessorTelefone
	FROM
		tblProfessor
	WHERE
		ProfessorNome LIKE '%' + @ProfessorNome + '%'

END


CREATE PROCEDURE uspProfessorConsultarPorMatricula
	@ProfessorMatricula varchar(13)
AS
BEGIN

	SELECT
		ProfessorID,
		ProfessorNome,
		ProfessorMatricula,
		ProfessorTelefone
	FROM
		tblProfessor
	WHERE
		ProfessorMatricula LIKE '%' + @ProfessorMatricula + '%'

END