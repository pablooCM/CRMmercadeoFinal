--Procedures para realizar diferentes operaciones en la BD
--CRUD de cliente
create procedure insertaCliente
	@cedula int,
	@nombre varchar(50),
	@apellido1 varchar(50),
	@apellido2 varchar(50),
	@ciudad varchar (50),
	@pais varchar (50),
	@correoElectronico varchar(50),
	@serviciosCliente int, 
	@redesSociales varchar(20)
	as
	begin
		insert into Clientes values(@cedula, @nombre,@apellido1, @apellido2, @ciudad, @pais,@correoElectronico,@serviciosCliente, @redesSociales)
	end


create procedure actualizaCliente
	@cedula int,
	@nombre varchar(50),
	@apellido1 varchar(50),
	@apellido2 varchar(50),
	@ciudad varchar (50),
	@pais varchar (50),
	@correoElectronico varchar(50),
	@serviciosCliente int, 
	@redesSociales varchar(20)

AS
BEGIN 
      SET NOCOUNT ON 

      UPDATE Clientes
      SET 
			nombreCliente= @nombre ,
			apellido1Cliente = @apellido1,
			apellido2Cliente = @apellido2,
			ciudad = @ciudad,
			pais = @pais,
			correoElectronico = @correoElectronico,
			serviciosCliente = @serviciosCliente,
			redesSociales = @redesSociales
			FROM   Clientes
			where
			cedula = @cedula
END

create procedure eliminaCliente
	@cedula int
	as
	begin
		delete Clientes
		from Clientes
		where cedula=@cedula
	end

--Registrar red social de la empresa

create procedure registrarRS
	@nombreRS varchar(20),
	@nombreUsuarioRS varchar(20),
	@claveRS varchar(120)
	as
	begin
		insert into RedesSociales values(@nombreRS, @nombreUsuarioRS, @claveRS)
	end
--CRUD Servicios
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
			descripcionServicio = @Descripci�n,
			formaDePago = @FormaDePago,
			coberturaServicio = @Cobertura,
			estadoServicio = @estadoServicio
			FROM   Servicios
			where
			idServicio = @ID
END

create procedure eliminarServicios
	@ID int
	as
	begin
		delete Servicios
		from Servicios
		where idServicio = @ID
	end

 