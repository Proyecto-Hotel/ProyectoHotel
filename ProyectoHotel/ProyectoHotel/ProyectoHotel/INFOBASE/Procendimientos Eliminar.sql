use ProyectoHotel
go

create procedure EliminarEmpleado(@Identidad varchar(15))
as
Begin
update Empleados set Estado = 'Eliminado' where Identidad = @Identidad
ENd
go

create procedure EliminarHuesped(@Identidad Varchar(15))
as
Begin
Update Huesped set Estado = 'Eliminado' where Identidad = @Identidad
End
go

create procedure EliminarReservacion(@IdReservacion int)
as
Begin
Update Reservacion set Estado = 'Eliminado' where IdReservacion = @IdReservacion
End
go
create procedure EliminarTipoEmpleado(@id int )
as
Begin 
update TipoEmpleado set Estado = 'Eliminado' where IdTipoEmpleado = @id
END
go 

alter procedure EliminarUsuario(@UserName as Varchar(45) )
as
Begin
if exists (select UserName from Usuarios where UserName = @UserName and Estado = 'Activo')
update Usuarios set Estado = 'Eliminado'  where UserName = @UserName
else
raiserror('Error!! Este Usuario no existe, utiliza otro por favor', 16, 1)
end
go
select * from Usuarios

