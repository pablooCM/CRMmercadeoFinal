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

