create table PlanHotel(
	IdPlan int primary key,
	NombrePlan varchar(30) not null,
	DescripcionPlan varchar(200) not null
);

create table Estancia(
	IdEstancia int identity(1,1) primary key,
	FechaHoraEntrada datetime not null,
	FechaHoraSalida datetime not null
);

create table Huesped(
	Cedula varchar(11) primary key,
	NombreCompleto varchar(100) not null,
	Tarjeta varchar(16) not null,
	IdEstancia int,
	IdPlan int,

	foreign key (IdPlan) references PlanHotel(IdPlan),
	foreign key(IdEstancia) references Estancia(IdEstancia)
);

create table rol(
	IDRol int primary key,
	NombreRol varchar(50)
);

insert into rol values('1', 'Gerente TI')
insert into rol values('2', 'Soporte TI')
insert into rol values('3', 'Gerente Servicios al Cliente')
insert into rol values('4', 'Recepcion Servicios al Cliente')
insert into rol values('5', 'SubGerente')
insert into rol values('6', 'Contabilidad')
insert into rol values('7', 'Conserjeria')
insert into rol values('8', 'Recursos Humanos')

drop table Empleado
create table Empleado(
	Cedula varchar(11) primary key,
	NombreCompleto varchar(100) not null,
	CuentaEmpleado varchar(50),
	ClaveEmpleado varchar(50),
	Sueldo numeric(10,2) not null,
	Posicion varchar(70),
	IDRol int null,

	Foreign Key (IDRol) references rol(IDRol)
);
select * from rol
select * from Empleado
insert into Empleado values('40224442208', 'Abel Abraham Feliz Soto', 'afeliz', 'hola', '300000.00', 'Gerente TI', 1)
insert into Empleado values('0014425369', 'Victor Vidal Rodriguez Suero', 'vrodriguez', 'hola', '27000.00', 'Soporte TI', 2)
insert into Empleado values('40226125629', 'Dhara Crisalys Vargas Ramírez', 'dvargas', 'hola', '35000.00', 'Gerente Servicios al Cliente', 3)

insert into Empleado values('22301657734')

insert into Empleado values('00132658496', 'María Esther Cueto Salcedo', 'mcueto', 'rrhh', '30000.00', 'Gerente Recursos Humanos', 8)
insert into Empleado values('00112365786', 'Pedro Soto Díaz', 'psoto', 'conserjeria', '15000.00', 'Conserje', 7)

select NombreRol from rol where IDRol = ''
select IDRol from Empleado
select count(CuentaEmpleado) from Empleado where CuentaEmpleado = 'mcueto' and ClaveEmpleado = 'rrhh' group by NombreCompleto
select NombreCompleto from Empleado where CuentaEmpleado = ''
/*Cambiar rol en el sistema*/