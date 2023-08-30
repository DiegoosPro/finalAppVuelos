/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     20/06/2023 16:08:50                          */
/*==============================================================*/
create database bddvuelos;
go
use  bddvuelos;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_AEROPUERTOS') and o.name = 'FK_TAB_AERO_REFERENCE_TAB_CIUD')
alter table TAB_AEROPUERTOS
   drop constraint FK_TAB_AERO_REFERENCE_TAB_CIUD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_CIUDADES') and o.name = 'FK_TAB_CIUD_REFERENCE_TAB_PAIS')
alter table TAB_CIUDADES
   drop constraint FK_TAB_CIUD_REFERENCE_TAB_PAIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PLAZAS') and o.name = 'FK_TAB_PLAZ_REFERENCE_TAB_RESE')
alter table TAB_PLAZAS
   drop constraint FK_TAB_PLAZ_REFERENCE_TAB_RESE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PLAZAS') and o.name = 'FK_TAB_PLAZ_REFERENCE_TAB_TARJ')
alter table TAB_PLAZAS
   drop constraint FK_TAB_PLAZ_REFERENCE_TAB_TARJ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_RESERVACIONES') and o.name = 'FK_TAB_RESE_REFERENCE_TAB_CLIE')
alter table TAB_RESERVACIONES
   drop constraint FK_TAB_RESE_REFERENCE_TAB_CLIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_RESERVACIONES') and o.name = 'FK_TAB_RESE_REFERENCE_TAB_VUEL')
alter table TAB_RESERVACIONES
   drop constraint FK_TAB_RESE_REFERENCE_TAB_VUEL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_TARJETAEMBARQUE') and o.name = 'FK_TAB_TARJ_REFERENCE_TAB_CLIE')
alter table TAB_TARJETAEMBARQUE
   drop constraint FK_TAB_TARJ_REFERENCE_TAB_CLIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_TARJETAEMBARQUE') and o.name = 'FK_TAB_TARJ_REFERENCE_TAB_VUEL')
alter table TAB_TARJETAEMBARQUE
   drop constraint FK_TAB_TARJ_REFERENCE_TAB_VUEL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_VUELOS') and o.name = 'FK_TAB_VUEL_REFERENCE_TAB_AERO1')
alter table TAB_VUELOS
   drop constraint FK_TAB_VUEL_REFERENCE_TAB_AERO1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_VUELOS') and o.name = 'FK_TAB_VUEL_REFERENCE_TAB_AERO')
alter table TAB_VUELOS
   drop constraint FK_TAB_VUEL_REFERENCE_TAB_AERO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_AEROPUERTOS')
            and   type = 'U')
   drop table TAB_AEROPUERTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CIUDADES')
            and   type = 'U')
   drop table TAB_CIUDADES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CLIENTES')
            and   type = 'U')
   drop table TAB_CLIENTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PAISES')
            and   type = 'U')
   drop table TAB_PAISES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PLAZAS')
            and   type = 'U')
   drop table TAB_PLAZAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_RESERVACIONES')
            and   type = 'U')
   drop table TAB_RESERVACIONES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_TARJETAEMBARQUE')
            and   type = 'U')
   drop table TAB_TARJETAEMBARQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_VUELOS')
            and   type = 'U')
   drop table TAB_VUELOS
go

/*==============================================================*/
/* Table: TAB_AEROPUERTOS                                       */
/*==============================================================*/
create table TAB_AEROPUERTOS (
   ID_AEROPUERTO        integer              identity,
   ID_CIUDAD            integer              null,
   CODIGO_AEROPUERTO    varchar(10)          null,
   NOMBRE_AEROPUERTO    varchar(50)          null,
   constraint PK_TAB_AEROPUERTOS primary key (ID_AEROPUERTO)
)
go

/*==============================================================*/
/* Table: TAB_CIUDADES                                          */
/*==============================================================*/
create table TAB_CIUDADES (
   ID_CIUDAD            integer              identity,
   ID_PAIS              integer              null,
   CIUDAD               varchar(50)          null,
   constraint PK_TAB_CIUDADES primary key (ID_CIUDAD)
)
go

/*==============================================================*/
/* Table: TAB_CLIENTES                                          */
/*==============================================================*/
create table TAB_CLIENTES (
   ID_CLIENTE           integer              identity,
   DNI                  varchar(10)          null,
   NOMBRE               varchar(50)          null,
   APELLIDO             varchar(50)          null,
   DIRECCION            varchar(100)         null,
   TELEFONO             varchar(10)          null,
   TARJETACREDITO       varchar(13)          null,
   constraint PK_TAB_CLIENTES primary key (ID_CLIENTE)
)
go

/*==============================================================*/
/* Table: TAB_PAISES                                            */
/*==============================================================*/
create table TAB_PAISES (
   ID_PAIS              integer              identity,
   PAIS                 varchar(20)          null,
   constraint PK_TAB_PAISES primary key (ID_PAIS)
)
go

/*==============================================================*/
/* Table: TAB_PLAZAS                                            */
/*==============================================================*/
create table TAB_PLAZAS (
   ID_PLAZA             integer              identity,
   ID_RESERVA           integer              null,
   ID_TARJETAEMBARQUE   integer              null,
   NRO_PLANTA           int                  null,
   FILA_ASIENTO         int                  null,
   COLUMNA_ASIENTO      int                  null,
   ASIGNADO_TARGETA     char(2)              null,
   constraint PK_TAB_PLAZAS primary key (ID_PLAZA)
)
go

/*==============================================================*/
/* Table: TAB_RESERVACIONES                                     */
/*==============================================================*/
create table TAB_RESERVACIONES (
   ID_RESERVA           integer              identity,
   ID_CLIENTE           integer              null,
   ID_VUELO             integer              null,
   FECHARESERVA_        date                 null,
   constraint PK_TAB_RESERVACIONES primary key (ID_RESERVA)
)
go

/*==============================================================*/
/* Table: TAB_TARJETAEMBARQUE                                   */
/*==============================================================*/
create table TAB_TARJETAEMBARQUE (
   ID_TARJETAEMBARQUE   integer              identity,
   ID_CLIENTE           integer              null,
   ID_VUELO             integer              null,
   FECHAEMISION         date                 null,
   constraint PK_TAB_TARJETAEMBARQUE primary key (ID_TARJETAEMBARQUE)
)
go

/*==============================================================*/
/* Table: TAB_VUELOS                                            */
/*==============================================================*/
create table TAB_VUELOS (
   ID_VUELO             integer              identity,
   ID_AEROPUERTO_LLEGADA integer              null,
   ID_AEROPUERTO_SALIDA integer              null,
   CODIGO_VUELO         varchar(50)          null,
   HORA_SALIDSA         datetime             null,
   HORA_LLEGADA         datetime             null,
   FECHA                datetime             null,
   constraint PK_TAB_VUELOS primary key (ID_VUELO)
)
go

alter table TAB_AEROPUERTOS
   add constraint FK_TAB_AERO_REFERENCE_TAB_CIUD foreign key (ID_CIUDAD)
      references TAB_CIUDADES (ID_CIUDAD)
go

alter table TAB_CIUDADES
   add constraint FK_TAB_CIUD_REFERENCE_TAB_PAIS foreign key (ID_PAIS)
      references TAB_PAISES (ID_PAIS)
go

alter table TAB_PLAZAS
   add constraint FK_TAB_PLAZ_REFERENCE_TAB_RESE foreign key (ID_RESERVA)
      references TAB_RESERVACIONES (ID_RESERVA)
go

alter table TAB_PLAZAS
   add constraint FK_TAB_PLAZ_REFERENCE_TAB_TARJ foreign key (ID_TARJETAEMBARQUE)
      references TAB_TARJETAEMBARQUE (ID_TARJETAEMBARQUE)
go

alter table TAB_RESERVACIONES
   add constraint FK_TAB_RESE_REFERENCE_TAB_CLIE foreign key (ID_CLIENTE)
      references TAB_CLIENTES (ID_CLIENTE)
go

alter table TAB_RESERVACIONES
   add constraint FK_TAB_RESE_REFERENCE_TAB_VUEL foreign key (ID_VUELO)
      references TAB_VUELOS (ID_VUELO)
go

alter table TAB_TARJETAEMBARQUE
   add constraint FK_TAB_TARJ_REFERENCE_TAB_CLIE foreign key (ID_CLIENTE)
      references TAB_CLIENTES (ID_CLIENTE)
go

alter table TAB_TARJETAEMBARQUE
   add constraint FK_TAB_TARJ_REFERENCE_TAB_VUEL foreign key (ID_VUELO)
      references TAB_VUELOS (ID_VUELO)
go

alter table TAB_VUELOS
   add constraint FK_TAB_VUEL_REFERENCE_TAB_AERO1 foreign key (ID_AEROPUERTO_LLEGADA)
      references TAB_AEROPUERTOS (ID_AEROPUERTO)
go

alter table TAB_VUELOS
   add constraint FK_TAB_VUEL_REFERENCE_TAB_AERO foreign key (ID_AEROPUERTO_SALIDA)
      references TAB_AEROPUERTOS (ID_AEROPUERTO)
go

