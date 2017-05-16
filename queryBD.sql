--Tabla Cliente
create table Cliente(
	cedula int not null,
	CHECK(cedula>=100000000 and cedula<=999999999),
	nombreCliente varchar(50),
	apellido1Cliente varchar(50),
	apellido2Cliente varchar(50),
	ciudad varchar(50),
	pais varchar(50),
	correoElectronico varchar(50)
	primary key (cedula)
)
--Tabla Redes Sociales
create table RedesSociales(
	nombreRedSocial varchar(20),
	nombreUsuario varchar(20),
	claveRedSocial varchar(120),
	primary key (nombreRedSocial)
)
--Tabla intermedia entre RRSS y Cliente
create table IntermediaRRSSyCliente(
	cedula int not null,
	CHECK(cedula>=100000000 and cedula<=999999999),
	nombreRedSocial varchar(20)
	primary key(cedula, nombreRedSocial),
	foreign key (cedula) references Cliente(cedula)
		on delete cascade
		on update cascade,
	foreign key (nombreRedSocial) references RedesSociales(nombreRedSocial)
		on delete cascade
		on update cascade
)

--Tabla Servicios

create table Servicios(
	idServicio int not null,
	CHECK(idServicio >= 1000 and idServicio <= 9999),
	descripcionServicio varchar(60),
	formaDePago varchar (20),
	coberturaServicio varchar(220),
	estadoServicio varchar(40)
	primary key (idServicio)
)

--Tabla de Campanas de Mercadeo
create table CampannasMercadeo(
	idCampanna int,
	nombreCampanna varchar(40),
	fechaInicio date,
	fechaFinal date,
	pais varchar(50),
	costoCampanna int
	primary key (idCampanna)

)


--Tabla intermedia entre Cliente y Servicio
create table IntermediaClienteyServicio(
	cedula int not null,
	CHECK(cedula>=100000000 and cedula<=999999999),
	nombreCliente varchar(50),
	idServicio int not null,
	CHECK(idServicio >= 1000 and idServicio <= 9999),
	primary key(cedula, idServicio),
	foreign key (cedula) references Cliente(cedula)
		on delete cascade
		on update cascade,
	foreign key (idServicio) references Servicios(idServicio)
		on delete cascade
		on update cascade

)

--Tabla intermedia entre CampannaMercadeo y Cliente
create table IntermediaCampannaMercadeoyCliente(
	cedula int not null,
	CHECK(cedula>=100000000 and cedula<=999999999),
	nombreCliente varchar(50),
	idCampanna int,
	primary key(cedula, idCampanna),
	foreign key (cedula) references Cliente(cedula)
		on delete cascade
		on update cascade,
	foreign key (idCampanna) references CampannasMercadeo(idCampanna)
		on delete cascade
		on update cascade
)
insert into Cliente values(115440647, 'Pablo', 'Corrales', 'Mora', 'San Jose','Costa Rica', 'jopablo13@gmail.com')
insert into Servicios values (1111,'agua', 'mensual', 'Costa Rica', 'activo' )
insert into RedesSociales values('Twitter', 'empresa1', 'empresaclave')
insert into CampannasMercadeo values(100,'Conquistando al cacheton','2016-01-01','2016-06-01','Costa Rica',2000)