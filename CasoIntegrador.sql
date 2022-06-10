
create database nota_poli

use nota_poli

create table notas (
    id int identity(1,1) not null,
    estudiante nvarchar(50),
    corte1 float,
    corte2 float,
    corte3 float,
    notaDefinitiva float
)