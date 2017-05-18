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

--Crear servicio
create procedure crearServicio
	@idServicio int,
	@descripcion varchar(30),
	@formaDePago varchar(30),
	@estadoServicio varchar(30)
	as
	begin
		insert into Servicio values(@idServicio, @descripcion, @formaDePago, @estadoServicio)
	end

--Asignar un pais a un servicio
create procedure asignarPaisaServicio
	@idServicio int,
	@idPais int
	as
	begin
		insert into IntermediaServicioyPais values(@idServicio, @idPais)
	end

--Quitar un pais a un servicio
create procedure quitarPaisServicio
	@idServicio int,
	@idPais int
	as
	begin
		delete IntermediaServicioyPais
		from IntermediaServicioyPais
		where idServicio = @idServicio and idPais = @idPais
	end

--Actualizar servicio
create procedure actualizaServicio
	@idServicio int,
	@descripcion varchar(30),
	@formaDePago varchar(30),
	@estadoServicio varchar (30)
	as
	begin
		set nocount on
		update Servicio
		set
			descripcion = @descripcion,
			formaDePago = @formaDePago,
			estadoServicio = @estadoServicio
			from Servicio
			where idServicio = @idServicio
	end

--Eliminar servicio
create procedure eliminaServicio
	@idServicio int
	as
	begin
		delete Servicio
		from Servicio
		where idServicio = @idServicio
	end

--Crear Campanna de mercadeo
create procedure crearCampanna
	@idCampannaMercadeo int,
	@nombreCampanna varchar(40),
	@fechaInicio date,
	@fechaFinal date,
	@costoCampanna int
	as
	begin
		insert into CampannaMercadeo values(@idCampannaMercadeo, @nombreCampanna, @fechaInicio, @fechaFinal, @costoCampanna)
	end
--Asignarle pais a Campanna
create procedure asignarPaisaCampanna
	@idCampannaMercadeo int,
	@idPais int
	as
	begin
		insert into IntermediaPaisyCampannaMercadeo values(@idCampannaMercadeo, @idPais)
	end

--Quitarle pais a Campanna
create procedure quitarPaisCampanna
	@idCampannaMercadeo int,
	@idPais int
	as
	begin
		delete IntermediaPaisyCampannaMercadeo
		from IntermediaPaisyCampannaMercadeo
		where idCampannaMercadeo = @idCampannaMercadeo and idPais = @idPais
	end

--Actualizar Campanna
create procedure actualizaCampanna
	@idCampannaMercadeo int,
	@nombreCampanna varchar (40),
	@fechaInicio date,
	@fechaFinal date,
	@costoCampanna int 
	as
	begin
		set nocount on
		update CampannaMercadeo
		set
			nombreCampanna = @nombreCampanna,
			fechaInicio = @fechaInicio,
			fechaFinal = @fechaFinal,
			costoCampanna = @costoCampanna
			from CampannaMercadeo
			where idCampannaMercadeo = @idCampannaMercadeo
	end
--Eliminar CampannaMercadeo
create procedure eliminaCampanna
	@idCampannaMercadeo int
	as
	begin
		delete CampannaMercadeo
		from CampannaMercadeo
		where idCampannaMercadeo = @idCampannaMercadeo
	end