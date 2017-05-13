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