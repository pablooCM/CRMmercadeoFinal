create procedure insertarServicios
	@ID int,
	@Descripción varchar(140),
	@FormaDePago varchar(10),
	@Cobertura varchar(20),
	@estadoServicio varchar(20)
	as
	begin
		insert into Servicios values(@ID,@Descripción,@FormaDePago,@Cobertura,@estadoServicio)
	end


create procedure actualizarServicios
	@ID int,
	@Descripción varchar(140),
	@FormaDePago varchar(10),
	@Cobertura varchar(20),
	@estadoServicio varchar(20)

AS
BEGIN 
      SET NOCOUNT ON 

      UPDATE Servicios
      SET 
			Descripción = @Descripción,
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

 