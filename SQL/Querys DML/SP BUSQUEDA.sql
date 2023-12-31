CREATE PROCEDURE SP_CONSULTA_STOCK
@NOMBRE VARCHAR(50) = '%'
AS
BEGIN
	SELECT P.ID_PRODUCTO 'ID', P.NOMBRE 'PRODUCTO', P.DESCRIPCION 'DETALLE', 
	V.NOMBRE 'PROVEEDOR', U.PAIS 'PAIS', P.STOCK 'STOCK', P.PRECIO 'PRECIO'
	FROM PRODUCTOS P
	JOIN PROVEEDORES V ON V.ID_PROVEEDOR = P.ID_PROVEEDOR
	JOIN PAISES U ON U.ID_PAIS = P.ID_PAIS
	WHERE P.NOMBRE LIKE CONCAT('%', @NOMBRE, '%');
END;

--EXECUTE SP_CONSULTA_STOCK @NOMBRE = 'BUSQUEDA'