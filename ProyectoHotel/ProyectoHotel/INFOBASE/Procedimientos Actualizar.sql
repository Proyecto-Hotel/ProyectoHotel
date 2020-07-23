use ProyectoHotel
go



---------------------------------ACTUALIZAR---------------------------------------------------------
-----------------------------EMPLEADO---------------------------------------------------
create procedure actualizarEmpleados(
	@Identidad varchar(15),
	@Nombre varchar(45),
	@Apellido varchar(45),
	@Telefono int,
	@CorreoElectronico varchar(45),
	@RTN varchar(16),
	@TipoEmpleado int,
	@idHorario int

)
	as begin
	if exists(select @Identidad, Estado from Empleados where Identidad=@Identidad and Estado='Activo')
	update Empleados
	set Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, CorreoElectronico = @CorreoElectronico, RTN = @RTN, IdTipoElmpleado = @TipoEmpleado, IdHorarios = @idHorario
	where Identidad=@Identidad
	else
	raiserror('El usuario no puede ser modificado, Ingrese otro usuario',16,1)
	end
	go
---------------------------------HABITACIONES----------------------------------------------------------------
create procedure actualizarHabitaciones(
	@IdHabitacion int,
	@Precio int,
	@Estado varchar(15)
)
	as begin
	if exists(select @IdHabitacion,Estado from habitaciones where IdHabitacion=@IdHabitacion and Estado='Libre')
		update habitaciones
		set Precio=@Precio, Estado=@Estado
		where IdHabitacion=@IdHabitacion
	else
		raiserror('No se pudo actualizar esta habitacion, Ingrese otra',16,1)
end
go
-----------------------------------------HORARIOS---------------------------------------------------------
create procedure actualizarHorarios(
	@idHorarios int,
	@Horarios varchar(45),
	@Descripcion varchar(45)
)
	as begin 
	if exists(select @idHorarios from Horarios where idHorarios=@idHorarios)
		update Horarios
		set Horarios=@Horarios, Descripcion=@Descripcion
		where idHorarios=@idHorarios
	else
		raiserror('No se puede actualizar este Horario, Ingrese otro',16,1)
end
go
-------------------------------------------HUESPED---------------------------------------------------------
create procedure actualizarHuesped(
	@Identidad varchar(15),
	@Nombre varchar(45),
	@Apellido varchar(45),
	@Telefono int,
	@CorreoElectronico varchar(45),
	@RTN varchar(16)
)
as begin
	if exists(select @Identidad, Estado from Huesped where Identidad=@Identidad and Estado='Activo')
		update Huesped
		set Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono, CorreoElectronico=@CorreoElectronico,RTN=@RTN
		where Identidad=@Identidad
	else
		raiserror('El Huesped no puede ser modificado, Ingrese otro Huesped',16,1)
end
go

-----------------------------------------RESERVACION-----------------------------------------------------
----PENDIENTE--------------------------------------------
create procedure actualizarReservacion(
	@IdReservacion int,
	@FechaReservacion datetime,
	@CantidadDias int,
	@NumTarjeta varchar(16)
)
as begin
	if exists(select @IdReservacion from Reservacion where IdReservacion=@IdReservacion)
		update Reservacion
		set FechaReservacion=@FechaReservacion,CantidadDias=@CantidadDias,NumTarjeta=@NumTarjeta
		where IdReservacion=@IdReservacion
	else
		raiserror('La reservacion no puede ser modificada, Ingrese otra Reservacion',16,1)
end
go
-------------------------------------------TIPO EMPLEADO-----------------------------------------------------
create procedure actualizarTipoEmpleado(
	@IdTipoEmpleado int,
	@Puesto varchar(45),
	@Sueldo int
)
as begin 
	if exists(select @IdTipoEmpleado from TipoEmpleado where IdTipoEmpleado=@IdTipoEmpleado)
		update TipoEmpleado
		set Puesto=@Puesto, Sueldo=@Sueldo
		where IdTipoEmpleado=@IdTipoEmpleado
	else
		raiserror('El tipo de Empleado no puede ser modificado, Ingrese otro tipo de Empleado',16,1)
end
go
---------------------------------------------TIPO HABITACIONES---------------------------------------------------------
create procedure actualizarTipoHabitacion(
	@IdTipoHabitaciones int,
	@Nombre varchar(45),
	@capacidad int
)
as begin
	if exists(select @IdTipoHabitaciones from tipoHabitaciones where IdTipoHabitaciones=@IdTipoHabitaciones)
		update tipoHabitaciones
		set Nombre=@Nombre, capacidad=@capacidad
		where IdTipoHabitaciones=@IdTipoHabitaciones
	else
		raiserror('El tipo de Habitacion no puede ser modificado, Ingrese otro tipo de Habitacion',16,1)
end
go
-----------------------------------------------USUARIOS---------------------------------------------------------------------
Alter procedure actualizarUsuarios(
	
	@UserName varchar(45),
	@Psw varchar(45),
	@Identidad varchar(15)
)
as begin 
	if exists(select @Identidad from Usuarios where Identidad=@Identidad)
	update Usuarios
	set UserName=@UserName, Psw=@Psw
	where Identidad=@Identidad
	else
		raiserror('El Usuario no puede ser modificado, Ingrese otro Usuario',16,1)
end
go

