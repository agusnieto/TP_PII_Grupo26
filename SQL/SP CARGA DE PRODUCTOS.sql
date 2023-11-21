CREATE PROCEDURE SP_FACTURACION_PRODUCTO
@id INT
AS 
BEGIN
	SELECT * from PRODUCTOS P
	left join  tipos_productos tp on p.ID_T_PRODUCTO = tp.ID_T_PRODUCTO 
	where p.ID_PRODUCTO = @id
END;

select * from servicios