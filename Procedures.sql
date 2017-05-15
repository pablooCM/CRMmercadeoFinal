create procedure insertarServicios
	@ID int,
	@Descripci�n varchar(140),
	@FormaDePago varchar(10),
	@Cobertura varchar(20),
	@estadoServicio varchar(20)
	as
	begin
		insert into Servicios values(@ID,@Descripci�n,@FormaDePago,@Cobertura,@estadoServicio)
	end


create procedure actualizarServicios
	@ID int,
	@Descripci�n varchar(140),
	@FormaDePago varchar(10),
	@Cobertura varchar(20),
	@estadoServicio varchar(20)

AS
BEGIN 
      SET NOCOUNT ON 

      UPDATE Servicios
      SET 
			Descripci�n = @Descripci�n,
			FormaDePago = @FormaDePago,
			Cobertura = @Cobertura,
			estadoServicio = @estadoServicio
			FROM   Servicios
			where
			ID = @ID
END

create procedure eliminarServicios
	@ID int
	as
	begin
		delete Servicios
		from Servicios
		where ID = @ID
	end

 