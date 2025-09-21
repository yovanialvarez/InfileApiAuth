CREATE TABLE USUARIO(
	id					int IDENTITY(1,1)	PRIMARY KEY
	, usuario			VARCHAR(50)
	, email				VARCHAR(100)
	, password			VARCHAR(50)
	, nombre			VARCHAR(100)
	, apellido			VARCHAR(100)
	, activo			BIT
)
