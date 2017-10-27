use aniosfelicesdb;



select * from dbo.Rol;


select * from dbo.Usuario;
select * from dbo.Habitacion where IdHabitacion = 1;
select * from dbo.Cama;


SELECT camas0_.IdHabitacion as idhabi1_0_1_, camas0_.IdCama as idcama2_0_1_, camas0_.Estado as estado3_0_0_ FROM dbo.Cama camas0_ WHERE camas0_.IdHabitacion=1;