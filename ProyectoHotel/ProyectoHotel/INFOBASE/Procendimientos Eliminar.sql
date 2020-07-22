use ProyectoHotel
go

create procedure EliminarEmpleado(@Identidad varchar(15))
as
Begin
update Empleados set Estado = 'Eliminado' where Identidad = @Identidad
ENd