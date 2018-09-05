﻿CREATE TABLE [dbo].[prod_GestionProductivaAcero_CusTalme] (
    [IdEmpresa]                  INT           NOT NULL,
    [IdSucursal]                 INT           NOT NULL,
    [IdGestionAceria]            NUMERIC (18)  NOT NULL,
    [Fecha]                      DATETIME      NOT NULL,
    [IdHorno]                    INT           NOT NULL,
    [IdColada]                   NUMERIC (18)  NOT NULL,
    [chat_En_Horno]              FLOAT (53)    NOT NULL,
    [chat_Cargada]               FLOAT (53)    NOT NULL,
    [Vaci_TempC]                 FLOAT (53)    NOT NULL,
    [Vaci_acero]                 FLOAT (53)    NOT NULL,
    [EnHor_Acero]                FLOAT (53)    NOT NULL,
    [EnHor_Perdida]              FLOAT (53)    NOT NULL,
    [Comps_C]                    FLOAT (53)    NOT NULL,
    [Comps_Si]                   FLOAT (53)    NOT NULL,
    [Comps_Mn]                   FLOAT (53)    NOT NULL,
    [Comps_P]                    FLOAT (53)    NOT NULL,
    [Comps_S]                    FLOAT (53)    NOT NULL,
    [Comps_SAE]                  FLOAT (53)    NOT NULL,
    [AdiMet_Carburante]          FLOAT (53)    NOT NULL,
    [AdiMet_Cal]                 FLOAT (53)    NOT NULL,
    [AdiMet_Desercoriante]       FLOAT (53)    NOT NULL,
    [Tiem_Encendido]             TIME (0)      NOT NULL,
    [Tiem_Apagado]               TIME (0)      NOT NULL,
    [Tiem_Fundicion]             TIME (0)      NOT NULL,
    [Tiem_Vaciado]               TIME (0)      NOT NULL,
    [Tiem_Total]                 TIME (0)      NOT NULL,
    [Ener_Ea]                    FLOAT (53)    NOT NULL,
    [Ener_Er]                    FLOAT (53)    NOT NULL,
    [Ener_Total]                 FLOAT (53)    NOT NULL,
    [Ferroa_FeSi]                FLOAT (53)    NOT NULL,
    [Ferroa_FeMn]                FLOAT (53)    NOT NULL,
    [IndiHor_Rendimiento]        FLOAT (53)    NOT NULL,
    [IndiHor_Productividad]      FLOAT (53)    NOT NULL,
    [Tundish]                    NUMERIC (18)  NOT NULL,
    [InicioCC]                   TIME (0)      NOT NULL,
    [FinCC]                      TIME (0)      NOT NULL,
    [Tiempo]                     TIME (0)      NOT NULL,
    [AceroCldo]                  FLOAT (53)    NOT NULL,
    [Palanquilla]                FLOAT (53)    NOT NULL,
    [Marrano]                    FLOAT (53)    NOT NULL,
    [Escoria]                    FLOAT (53)    NOT NULL,
    [PerdidaCC]                  FLOAT (53)    NOT NULL,
    [RendtCC]                    FLOAT (53)    NOT NULL,
    [ProductivCC]                FLOAT (53)    NOT NULL,
    [IdProducto_TipoPalanquilla] FLOAT (53)    NOT NULL,
    [Unidades]                   FLOAT (53)    NOT NULL,
    [Longitud]                   FLOAT (53)    NOT NULL,
    [PesoUnitario]               FLOAT (53)    NOT NULL,
    [PesoMetro]                  FLOAT (53)    NOT NULL,
    [Perdida]                    FLOAT (53)    NOT NULL,
    [ProdRend]                   FLOAT (53)    NOT NULL,
    [ProdProduct]                FLOAT (53)    NOT NULL,
    [Observacion]                VARCHAR (250) NOT NULL,
    [IdUsuario]                  VARCHAR (20)  NOT NULL,
    [Fecha_Transaccion]          DATETIME      NOT NULL,
    [IdUsuarioUltModi]           VARCHAR (20)  NULL,
    [Fecha_UltMod]               DATETIME      NULL,
    [Fecha_UltAnu]               DATETIME      NULL,
    [MotivoAnulacion]            VARCHAR (100) NULL,
    [nom_pc]                     VARCHAR (25)  NULL,
    [ip]                         VARCHAR (25)  NULL,
    [Estado]                     VARCHAR (1)   NOT NULL,
    [Termopares]                 FLOAT (53)    NULL,
    [FeSiMn]                     FLOAT (53)    NULL,
    CONSTRAINT [PK_prod_GestionProductivaAcero_CusTalme] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdGestionAceria] ASC)
);
