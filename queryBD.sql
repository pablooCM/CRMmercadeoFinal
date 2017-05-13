
create table Clientes(
	cedula int not null,
	CHECK(cedula>=100000000 and cedula<=999999999),
	nombreCliente varchar(50),
	apellido1Cliente varchar(50),
	apellido2Cliente varchar(50),
	ciudad varchar(50),
	pais varchar(50),
	correoElectronico varchar(50),
	serviciosCliente int foreign key references Servicios(idServicio),
	redesSociales varchar(20) foreign key references RedesSociales(nombreRedSocial),
	primary key (cedula)
)
create table Servicios(
	idServicio int not null,
	CHECK(idServicio >= 1000 and idServicio <= 9999),
	descripcionServicio varchar(60),
	formaDePago varchar (20),
	coberturaServicio varchar(220),
	estadoServicio varchar(40)
	primary key (idServicio)
)

create table RedesSociales(
	nombreRedSocial varchar(20),
	nombreUsuario varchar(20),
	claveRedSocial varchar(120),
	primary key (nombreRedSocial)
)

create table campannasMercadeo(
	idCampanna int,
	nombreCampanna varchar(40),
	fechaInicio date,
	fechaFinal date,
	pais varchar(50),
	costoCampanna int
	primary key (idCampanna)

)