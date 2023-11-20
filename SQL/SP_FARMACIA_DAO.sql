--SP

--PRODUCTOS

GO
CREATE PROCEDURE SP_INSERT_PRODUCTO
@NOMBRE VARCHAR(50),
@DESCRIPCION VARCHAR(100),
@TIPO_PRODUCTO INT,
@MARCA INT,
@PROVEEDOR INT,
@PAIS INT,
@STOCK INT,
@PRECIO DECIMAL(10,2),
@CARACTERISTICA INT
AS
BEGIN
	INSERT INTO PRODUCTOS(ID_PRODUCTO, NOMBRE, DESCRIPCION, ID_T_PRODUCTO, ID_MARCA, ID_PROVEEDOR,
	ID_PAIS, STOCK, PRECIO, ID_CARACTERISTICA)
	VALUES((SELECT MAX(ID_PRODUCTO) + 1 FROM PRODUCTOS), @NOMBRE, @DESCRIPCION, @TIPO_PRODUCTO, @MARCA, @PROVEEDOR,
	@PAIS, @STOCK, @PRECIO, @CARACTERISTICA)
END;
GO

CREATE PROCEDURE SP_UPDATE_PRODUCTO
@ID_PRODUCTO INT,
@NOMBRE VARCHAR(50),
@DESCRIPCION VARCHAR(100),
@TIPO_PRODUCTO INT,
@MARCA INT,
@PROVEEDOR INT,
@PAIS INT,
@STOCK INT,
@PRECIO DECIMAL(10,2),
@CARACTERISTICA INT
AS
BEGIN	
	UPDATE PRODUCTOS SET 
		NOMBRE = @NOMBRE,
		DESCRIPCION = @DESCRIPCION,
		ID_T_PRODUCTO = @TIPO_PRODUCTO,
		ID_MARCA = @MARCA,
		ID_PROVEEDOR = @PROVEEDOR,
		ID_PAIS = @PAIS,
		STOCK = @STOCK,
		PRECIO = @PRECIO,
		ID_CARACTERISTICA = @CARACTERISTICA
	WHERE ID_PRODUCTO = @ID_PRODUCTO
END;
GO

CREATE PROCEDURE SP_DELETE_PRODUCTO
@ID_PRODUCTO INT
AS
BEGIN
	DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = @ID_PRODUCTO
END;
GO

CREATE PROCEDURE SP_GET_MARCAS
AS
BEGIN
	SELECT ID_MARCA, MARCA 
	FROM MARCAS
	ORDER BY MARCA 
END;
GO

CREATE PROCEDURE SP_GET_PAISES
AS
BEGIN
	SELECT ID_PAIS, PAIS 
	FROM PAISES
	ORDER BY PAIS
END;
GO

CREATE PROCEDURE SP_CONSULTAR_PRODUCTO
@ID INT
AS
BEGIN
	SELECT ID_PRODUCTO, NOMBRE, PRECIO, T.ID_T_PRODUCTO 'ID_T_PRODUCTO', T.TIPO 'TIPO'
	FROM PRODUCTOS P, TIPOS_PRODUCTOS T
	WHERE P.ID_T_PRODUCTO = T.ID_T_PRODUCTO AND P.ID_PRODUCTO = @ID
END;
GO

CREATE PROCEDURE SP_GET_PROVEEDOR
AS
BEGIN
	SELECT ID_PROVEEDOR, NOMBRE 
	FROM PROVEEDORES
	ORDER BY NOMBRE
END;
GO

CREATE PROCEDURE SP_GET_TIPO_PRODUCTO
AS
BEGIN
	SELECT ID_T_PRODUCTO, TIPO 
	FROM TIPOS_PRODUCTOS
	ORDER BY TIPO
END;
GO

CREATE PROCEDURE SP_GET_CARACTERISTICA
AS
BEGIN
	SELECT ID_CARACTERISTICA, CARACTERISTICA 
	FROM CARACTERISTICAS
	ORDER BY CARACTERISTICA
END;
GO

--CLIENTES
CREATE PROCEDURE SP_INSERT_CLIENTE
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@OBRA_SOCIAL INT,
@BARRIO INT,
@DNI BIGINT,
@TELEFONO BIGINT,
@EMAIL VARCHAR(50),
@SEXO BIT
AS
BEGIN
	INSERT INTO CLIENTES(ID_CLIENTE, NOMBRE, APELLIDO, ID_OBRASOCIAL, ID_BARRIO, DNI,
	TELEFONO, EMAIL, SEXO)
	VALUES((SELECT MAX(ID_CLIENTE) + 1 FROM CLIENTES), @NOMBRE, @APELLIDO, @OBRA_SOCIAL, @BARRIO, @DNI, @TELEFONO, @EMAIL,
	@SEXO)
END;
GO

CREATE PROCEDURE SP_GET_CLIENTE
@ID INT
AS
BEGIN
	SELECT ID_CLIENTE, C.NOMBRE, APELLIDO, O.ID_OBRASOCIAL, O.NOMBRE, C.ID_BARRIO, B.BARRIO, DNI, TELEFONO,
	EMAIL, SEXO
	FROM CLIENTES C, OBRA_SOCIAL O, BARRIOS B
	WHERE C.ID_OBRASOCIAL = O.ID_OBRASOCIAL AND C.ID_BARRIO = B.ID_BARRIO AND ID_CLIENTE = @ID
END;
GO

CREATE PROCEDURE SP_GET_CLIENTES
AS
BEGIN
	SELECT ID_CLIENTE, C.NOMBRE, APELLIDO, O.ID_OBRASOCIAL, O.NOMBRE, C.ID_BARRIO, B.BARRIO, DNI, TELEFONO,
	EMAIL, SEXO
	FROM CLIENTES C, OBRA_SOCIAL O, BARRIOS B
	WHERE C.ID_OBRASOCIAL = O.ID_OBRASOCIAL AND C.ID_BARRIO = B.ID_BARRIO 
END;
GO

CREATE PROCEDURE SP_UPDATE_CLIENTE
@ID INT,
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@OBRA_SOCIAL INT,
@BARRIO INT,
@DNI BIGINT,
@TELEFONO BIGINT,
@EMAIL VARCHAR(50),
@SEXO BIT
AS
BEGIN
	UPDATE CLIENTES SET
		NOMBRE = @NOMBRE,
		APELLIDO = @APELLIDO,
		ID_OBRASOCIAL = @OBRA_SOCIAL,
		ID_BARRIO = @BARRIO,
		DNI = @DNI,
		TELEFONO = @TELEFONO,
		EMAIL = @EMAIL,
		SEXO = @SEXO
	WHERE ID_CLIENTE = @ID
END;
GO

CREATE PROCEDURE SP_DELETE_CLIENTE
@ID INT
AS
BEGIN 
	DELETE FROM CLIENTES WHERE ID_CLIENTE = @ID
END;
GO

CREATE PROCEDURE SP_GET_BARRIOS
AS
BEGIN
	SELECT ID_BARRIO, BARRIO 
	FROM BARRIOS 
	ORDER BY BARRIO
END;