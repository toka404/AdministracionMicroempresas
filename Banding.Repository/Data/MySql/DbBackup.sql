drop database banding;

create database banding;

use banding;

/*==============================================================*/
/* Table: CATEGORIA                                             */
/*==============================================================*/
create table CATEGORIA
(
   ID_CATEGORIA         int not null auto_increment comment '',
   NOMBRE_CATEGORIA     varchar(1024)  comment '',
   primary key (ID_CATEGORIA)
);

/*==============================================================*/
/* Table: DETALLE_FACTURA                                       */
/*==============================================================*/
create table DETALLE_FACTURA
(
   ID_CABECERA          int not null comment '',
   ID_PRODUCTO          int not null  comment '',
   CANTIDAD_VENDIDA     decimal  comment '',
   PRECIO_TOTAL         decimal  comment ''
);

/*==============================================================*/
/* Table: EMPRENDIMIENTO                                        */
/*==============================================================*/
create table EMPRENDIMIENTO
(
   ID_EMPRENDIMIENTO    int not null auto_increment comment '',
   ID_CATEGORIA         int not null  comment '',
   NOMBRE_EMPRENDIMIENTO varchar(1024)  comment '',
   DESCRIPCION_EMPRENDIMIENTO varchar(1024)  comment '',
   LOGO                 varchar(1024)  comment '',
   primary key (ID_EMPRENDIMIENTO)
);

/*==============================================================*/
/* Table: FACTURA_CABECERA                                      */
/*==============================================================*/
create table FACTURA_CABECERA
(
   ID_CABECERA          int not null auto_increment comment '',
   ID_IVA               int not null  comment '',
   FECHA_CABECERA       date not null comment '',
   NOMBRE_CLIENTE       varchar(1024) not null comment '',
   CEDULA_CLIENTE       varchar(1024) not null comment '',
   TELEFONO_CLIENTE     varchar(1024) not null comment '',
   DIRECCION_CLIENTE    varchar(1024) not null  comment '',
   NRO_FACTURA          int not null comment '',
   SUBTOTAL             decimal not null  comment '',
   IVA_TOTAL            decimal comment '',
   TOTAL                decimal not null comment '',
   IVA_CERO             decimal comment '',
   primary key (ID_CABECERA)
);

/*==============================================================*/
/* Table: IVA                                                   */
/*==============================================================*/
create table IVA
(
   ID_IVA               int not null auto_increment comment '',
   VALOR_IVA            decimal  comment '',
   primary key (ID_IVA)
);

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO
(
   ID_PRODUCTO          int not null auto_increment comment '',
   ID_EMPRENDIMIENTO    int not null  comment '',
   NOMBRE_PRODUCTO      varchar(1024)  not null comment '',
   PRECIO_FABRICACION   decimal  not null  comment '',
   DESCRIPCION          varchar(1024)  comment '',
   FOTO                 varchar(1024)  comment '',
   STOCK                int  not null comment '',
   FECHA_CADUCIDAD      date  comment '',
   PRECIO_VENTA         decimal  not null comment '',
   IVA                  varchar(1)  not null comment '',
   primary key (ID_PRODUCTO)
);

/*==============================================================*/
/* Table: PRODUCTO_TIENE_PROVEEDOR                              */
/*==============================================================*/
create table PRODUCTO_TIENE_PROVEEDOR
(
   ID_PROVEEDOR         int  not null comment '',
   ID_PRODUCTO          int  not null comment ''
);

/*==============================================================*/
/* Table: PROVEEDOR                                             */
/*==============================================================*/
create table PROVEEDOR
(
   ID_PROVEEDOR         int not null auto_increment comment '',
   ID_PROVINCIA         int not null  comment '',
   NOMBRE_PROVEEDOR     varchar(1024)  comment '',
   TELEFONO             varchar(1024)  comment '',
   E_MAIL_PROVEEDOR     varchar(1024)  comment '',
   PRODUCTO             varchar(1024)  comment '',
   RUC                  varchar(1024)  comment '',
   primary key (ID_PROVEEDOR)
);

/*==============================================================*/
/* Table: PROVINCIA                                             */
/*==============================================================*/
create table PROVINCIA
(
   ID_PROVINCIA         int not null auto_increment comment '',
   NOMBRE_PROVINCIA            varchar(1024) NOT NULL comment '',
   primary key (ID_PROVINCIA)
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO
(
   ID_USUARIO           int not null auto_increment comment '',
   ID_PROVINCIA         int not null  comment '',
   NOMBRE_USUARIO       varchar(1024)  comment '',
   APELLIDO_USUARIO     varchar(1024)  comment '',
   CELULAR              varchar(1024)  comment '',
   E_MAIL               varchar(1024)  comment '',
   USERNAME     varchar(1024) not null  comment '',
   CONTRASENA           varchar(1024) not null  comment '',
   primary key (ID_USUARIO)
);

/*==============================================================*/
/* Table: USUARIO_TIENE_EMPRENDIMIENTOS                         */
/*==============================================================*/
create table USUARIO_TIENE_EMPRENDIMIENTOS
(
   ID_USUARIO           int not null comment '',
   ID_EMPRENDIMIENTO    int not null comment ''
);

alter table DETALLE_FACTURA add constraint FK_DETALLE__DETALLE_F_FACTURA_ foreign key (ID_CABECERA)
      references FACTURA_CABECERA (ID_CABECERA);

alter table DETALLE_FACTURA add constraint FK_DETALLE__PRODUCTO__PRODUCTO foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_PRODUCTO);

alter table EMPRENDIMIENTO add constraint FK_EMPRENDI_EMPRENDIM_CATEGORI foreign key (ID_CATEGORIA)
      references CATEGORIA (ID_CATEGORIA);

alter table FACTURA_CABECERA add constraint FK_FACTURA__FACTURA_C_IVA foreign key (ID_IVA)
      references IVA (ID_IVA);

alter table PRODUCTO add constraint FK_PRODUCTO_EMPRENDIM_EMPRENDI foreign key (ID_EMPRENDIMIENTO)
      references EMPRENDIMIENTO (ID_EMPRENDIMIENTO);

alter table PRODUCTO_TIENE_PROVEEDOR add constraint FK_PRODUCTO_PRODUCTO__PRODUCTO foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_PRODUCTO);

alter table PRODUCTO_TIENE_PROVEEDOR add constraint FK_PRODUCTO_PROVEEDOR_PROVEEDO foreign key (ID_PROVEEDOR)
      references PROVEEDOR (ID_PROVEEDOR);

alter table PROVEEDOR add constraint FK_PROVEEDO_PROVINCIA_PROVINCI foreign key (ID_PROVINCIA)
      references PROVINCIA (ID_PROVINCIA);

alter table USUARIO add constraint FK_USUARIO_USUARIO_T_PROVINCI foreign key (ID_PROVINCIA)
      references PROVINCIA (ID_PROVINCIA);

alter table USUARIO_TIENE_EMPRENDIMIENTOS add constraint FK_USUARIO__EMPRENDIM_EMPRENDI foreign key (ID_EMPRENDIMIENTO)
      references EMPRENDIMIENTO (ID_EMPRENDIMIENTO);

alter table USUARIO_TIENE_EMPRENDIMIENTOS add constraint FK_USUARIO__USUARIO_T_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO);
