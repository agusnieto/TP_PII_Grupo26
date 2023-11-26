CREATE PROCEDURE SP_GET_PRODUCTOS
AS
BEGIN
SELECT * FROM PRODUCTOS
WHERE ACTIVO IS NULL
END;

CREATE PROCEDURE SP_DELETE_PRODUCTO
@ID INT
AS
BEGIN
	UPDATE PRODUCTOS
	SET ACTIVO = 1
	WHERE ID_PRODUCTO = @ID
END;

-- PROVEEDORES INSERT UPDATE DELETE

CREATE PROCEDURE SP_INSERT_PROVEEDOR
@NOMBRE VARCHAR(50),
@RAZON INT,
@TELEFONO BIGINT,
@EMAIL VARCHAR(50),
@CALLE VARCHAR(50),
@CUIT BIGINT,
@BARRIO INT
AS
BEGIN
	INSERT INTO PROVEEDORES (ID_PROVEEDOR,NOMBRE,ID_RAZON,TELEFONO,EMAIL,CALLE,CUIT,ID_BARRIO)
	VALUES ((SELECT MAX(ID_PROVEEDOR) + 1 FROM PROVEEDORES),@NOMBRE,@RAZON,@TELEFONO,@EMAIL,@CALLE,@CUIT,@BARRIO)
END;

CREATE PROCEDURE SP_UPDATE_PROVEEDOR
@ID INT,
@NOMBRE VARCHAR(50),
@RAZON INT,
@TELEFONO BIGINT,
@EMAIL VARCHAR(50),
@CALLE VARCHAR(50),
@CUIT BIGINT,
@BARRIO INT
AS
BEGIN
	UPDATE PROVEEDORES
	SET NOMBRE = @NOMBRE,
	ID_RAZON = @RAZON,
	TELEFONO = @TELEFONO,
	EMAIL = @EMAIL,
	CALLE = @CALLE,
	CUIT = @CUIT,
	ID_BARRIO = @BARRIO
	WHERE ID_PROVEEDOR = @ID
END;

CREATE PROCEDURE SP_DELETE_PROVEEDOR
@ID INT
AS
BEGIN
	UPDATE PROVEEDORES
	SET ACTIVO = 1
	WHERE ID_PROVEEDOR = @ID
END;

CREATE PROCEDURE SP_GET_PROVEEDORES
AS
BEGIN
	SELECT P.ID_PROVEEDOR 'ID', P.NOMBRE 'NOMBRE', P.ID_RAZON 'ID_RAZON', R.DESCRIPCION 'RAZON', 
	P.ID_BARRIO 'ID_BARRIO' ,  B.BARRIO 'BARRIO', P.CALLE 'CALLE', P.CUIT 'CUIT', 
	P.TELEFONO 'TELEFONO' , P.EMAIL 'EMAIL' FROM PROVEEDORES P
	JOIN RAZON_SOCIAL R ON P.ID_RAZON = R.ID_RAZON
	JOIN BARRIOS B ON P.ID_BARRIO = B.ID_BARRIO
	WHERE ACTIVO IS NULL
END;

-- GET RAZON SOCIAL

CREATE PROCEDURE SP_GET_RAZON_SOCIAL
AS
BEGIN
	SELECT ID_RAZON, DESCRIPCION 
	FROM RAZON_SOCIAL
	ORDER BY DESCRIPCION
END;

-- EMPLEADO INSERT UPDATE DELETE GET

CREATE PROCEDURE SP_INSERT_EMPLEADO
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@PUESTO INT,
@SEDE INT,
@SUELDO DECIMAL(10,2),
@TELEFONO BIGINT,
@EMAIL VARCHAR(50)
AS
BEGIN
	INSERT INTO EMPLEADOS (LEGAJO,NOMBRE,APELLIDO,ID_PUESTO,ID_SEDE,SUELDO,FECHA_INGRESO,TELEFONO,EMAIL)
	VALUES ((SELECT MAX(LEGAJO) + 1 FROM EMPLEADOS),@NOMBRE,@APELLIDO,@PUESTO,@SEDE,@SUELDO,(SELECT GETDATE()),@TELEFONO,@EMAIL)
END;

CREATE PROCEDURE SP_UPDATE_EMPLEADO
@ID INT,
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@PUESTO INT,
@SEDE INT,
@SUELDO DECIMAL(10,2),
@TELEFONO BIGINT,
@EMAIL VARCHAR(50)
AS
BEGIN
	UPDATE EMPLEADOS
	SET NOMBRE = @NOMBRE,
	APELLIDO = @APELLIDO,
	ID_PUESTO = @PUESTO,
	ID_SEDE = @SEDE,
	SUELDO = @SUELDO,
	TELEFONO = @TELEFONO,
	EMAIL = @EMAIL
	WHERE LEGAJO = @ID
END;
	
CREATE PROCEDURE SP_DELETE_EMPLEADO
@ID INT
AS
BEGIN
	UPDATE  EMPLEADOS
	SET ACTIVO = 1,
	FECHA_BAJA = (SELECT(GETDATE()))
	WHERE LEGAJO = @ID
END;

CREATE PROCEDURE SP_GET_EMPLEADOS
AS
BEGIN
	SELECT E.LEGAJO 'LEGAJO', E.NOMBRE 'NOMBRE', E.APELLIDO 'APELLIDO', E.ID_PUESTO 'ID_PUESTO', P.PUESTO 'PUESTO', E.ID_SEDE 'ID_SEDE', S.NOMBRE 'SEDE', E.SUELDO 'SUELDO', E.FECHA_INGRESO 'FECHA_INGRESO', E.FECHA_BAJA 'FECHA_BAJA', E.TELEFONO 'TELEFONO', E.EMAIL 'EMAIL', E.ACTIVO 'ACTIVO' FROM EMPLEADOS E
	JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO
	JOIN SEDES S ON E.ID_SEDE = S.ID_SEDE
	WHERE (ACTIVO = 0 OR ACTIVO IS NULL) OR
	FECHA_BAJA IS NULL
END;

-- GET PUESTOS

CREATE PROCEDURE SP_GET_PUESTOS
AS
BEGIN
	SELECT ID_PUESTO, PUESTO 
	FROM PUESTOS
	ORDER BY PUESTO
END;