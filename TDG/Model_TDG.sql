/*
    *********************************** Model Data Tracker ***********************************
*/

IF object_id('dbo.Vehiculo') is not null
   DROP TABLE dbo.Vehiculo;
IF object_id('dbo.TipoVehiculo') is not null
   DROP TABLE dbo.TipoVehiculo;

/*
    *********************************** Tabla TipoVehiculo ***********************************
*/

 CREATE TABLE dbo.TipoVehiculo (
  Codigo_Id	      UNIQUEIDENTIFIER NOT NULL,
  Nombre		  VARCHAR(200)  NOT NULL,
  Created_At	  DATETIME NULL DEFAULT (GETDATE()),
  Updated_At	  DATETIME NULL,
  CONSTRAINT PK_TipoVehiculo primary key (Codigo_Id)
 );


/*
    *********************************** Tabla Vehiculo ***********************************
*/


CREATE TABLE dbo.Vehiculo(
  Codigo_Id				UNIQUEIDENTIFIER NOT NULL,
  Placa					VARCHAR(100) NOT NULL,
  Marca					VARCHAR(100) NOT NULL,
  Modelo				VARCHAR(100) NOT NULL,
  CodigoInterno			VARCHAR(100) NOT NULL,
  TipoVehiculo_id       UNIQUEIDENTIFIER NOT NULL ,
  Created_At			DATETIME NULL DEFAULT (GETDATE()),
  Updated_At			DATETIME NULL,
  CONSTRAINT AK_Placa UNIQUE(Placa),
  CONSTRAINT PK_Vehiculo primary key (Codigo_Id),
  CONSTRAINT FK_vehiculo_tipovehiculo FOREIGN KEY (TipoVehiculo_id) REFERENCES TipoVehiculo (Codigo_Id) ON DELETE CASCADE
 );

