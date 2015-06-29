SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE insertarPersona
	-- Add the parameters for the stored procedure here
	@cedulaPersona varchar (15),
	@nombreP varchar(15),
	@apellido1P varchar(20), 
	@apellido2P varchar(20), 
	@telefono varchar(9),
	@emailP varchar(30),
	@contrase�aP varchar(100)
AS
BEGIN
	INSERT INTO Persona(Cedula, Nombre, Apellido1, Apellido2, Tel�fono, Email, Contrase�a)
	VALUES(@cedulaPersona, @nombreP, @apellido1P, @apellido2P, @telefono, @emailP, @contrase�aP)
END
GO