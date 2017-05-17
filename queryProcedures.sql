--Procedures para realizar diferentes operaciones en la BD
--insertar Cliente
create procedure insertaCliente
	@cedula int,
	@nombre varchar(30),
	@apellido1 varchar(30),
	@apellido2 varchar(30),
	@ciudad varchar (30),
	@pais int,
	@correoElectronico varchar(30)
	as
	begin
		insert into Cliente values(@cedula, @nombre, @apellido1, @apellido2, @ciudad, @pais,@correoElectronico)
	end

--Asignar Servicio a un cliente
create procedure asignarServicioCliente
	@idServicio int,
	@cedula int,
	@estadoServicio varchar(30),
	@idPais int
	as
	begin
		insert into IntermediaClienteyServicio values(@idServicio, @cedula, @estadoServicio, @idPais)
	end
--Asignar una red social a un cliente
create procedure asignarRedSocialCliente
	@cedula int,
	@idRedSocial int
	as
	begin 
		insert into IntermediaRSClienteyCliente values(@cedula, @idRedSocial)
	end

--Actualizar datos cliente
create procedure actualizaCliente
	@cedula int,
	@nombre varchar(30),
	@apellido1 varchar(30),
	@apellido2 varchar(30),
	@ciudad varchar (30),
	@pais int,
	@correoElectronico varchar(30)
	AS
	BEGIN 
      SET NOCOUNT ON 
      UPDATE Cliente
      SET 
			nombre= @nombre ,
			apellido1 = @apellido1,
			apellido2 = @apellido2,
			ciudad = @ciudad,
			pais = @pais,
			correoElectronico = @correoElectronico
			FROM Cliente
			where
			cedula = @cedula
	END

--Eliminar cliente
create procedure eliminaCliente
	@cedula int
	as
	begin
		delete Cliente
		from Cliente
		where cedula=@cedula
	end

--Registrar red social de la empresa

create procedure registrarRS
	@nombreRS varchar(20),
	@nombreUsuarioRS varchar(20),
	@claveRS varchar(120)
	as
	begin
		insert into RRSS values(@nombreRS, @nombreUsuarioRS, @claveRS)
	end

	drop procedure registrarRS