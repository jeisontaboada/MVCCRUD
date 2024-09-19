# MVCCRUD

base de datos:

create database pruebaEntrada;
use pruebaEntrada;

create table usuario(
  id int auto_increment primary key,
  nombre varchar(50) not null,
  apellido varchar(50) not null,
  dni char(8) not null unique
)
;

