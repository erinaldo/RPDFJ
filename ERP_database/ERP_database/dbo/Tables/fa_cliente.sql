﻿CREATE TABLE [dbo].[fa_cliente] (
    [IdEmpresa]                 INT            NOT NULL,
    [IdCliente]                 NUMERIC (18)   NOT NULL,
    [Codigo]                    VARCHAR (50)   NULL,
    [IdPersona]                 NUMERIC (18)   NOT NULL,
    [IdSucursal]                INT            NOT NULL,
    [IdVendedor]                INT            NOT NULL,
    [Idtipo_cliente]            INT            NOT NULL,
    [IdTipoCredito]             VARCHAR (3)    NOT NULL,
    [cl_Cat_crediticia]         CHAR (1)       NOT NULL,
    [cl_plazo]                  INT            NOT NULL,
    [cl_porcentaje_descuento]   FLOAT (53)     NOT NULL,
    [IdCtaCble_cxc]             VARCHAR (20)   NULL,
    [IdCtaCble_Anti]            VARCHAR (20)   NULL,
    [cl_Cell_Garante]           NVARCHAR (13)  NULL,
    [cl_Garante]                VARCHAR (100)  NULL,
    [cl_Mail_Garante]           VARCHAR (60)   NULL,
    [cl_observacion]            VARCHAR (130)  NOT NULL,
    [IdCiudad]                  VARCHAR (25)   NOT NULL,
    [cl_Cupo]                   FLOAT (53)     NOT NULL,
    [IdClienteRelacionado]      NUMERIC (10)   NULL,
    [cl_LocalComercial]         NVARCHAR (500) NULL,
    [cl_Rep_Legal]              VARCHAR (100)  NULL,
    [cl_Mail_Rep_Legal]         VARCHAR (60)   NULL,
    [cl_Cell_Rep_Legal]         VARCHAR (13)   NULL,
    [cl_Ger_Gen]                VARCHAR (100)  NULL,
    [cl_Mail_Ger_Gen]           VARCHAR (60)   NULL,
    [cl_Cell_Ger_Gen]           VARCHAR (13)   NULL,
    [cl_casilla]                VARCHAR (50)   NOT NULL,
    [cl_fax]                    VARCHAR (50)   NOT NULL,
    [IdActividadComercial]      VARCHAR (15)   NOT NULL,
    [IdUsuario]                 VARCHAR (20)   NOT NULL,
    [Fecha_Transac]             DATETIME       NOT NULL,
    [IdUsuarioUltMod]           VARCHAR (20)   NULL,
    [Fecha_UltMod]              DATETIME       NULL,
    [IdUsuarioUltAnu]           VARCHAR (20)   NULL,
    [Fecha_UltAnu]              DATETIME       NULL,
    [nom_pc]                    VARCHAR (20)   NOT NULL,
    [ip]                        VARCHAR (25)   NOT NULL,
    [Estado]                    CHAR (1)       NOT NULL,
    [Mail_Principal]            VARCHAR (50)   NOT NULL,
    [Mail_Secundario1]          VARCHAR (50)   NULL,
    [Mail_Secundario2]          VARCHAR (50)   NULL,
    [IdCentroCosto_CXC]         VARCHAR (20)   NULL,
    [IdCentroCosto_Anticipo]    VARCHAR (20)   NULL,
    [IdCentroCosto_CXC_Credito] VARCHAR (20)   NULL,
    [IdCtaCble_cxc_Credito]     VARCHAR (20)   NULL,
    [IdParroquia]               VARCHAR (25)   NULL,
    [es_empresa_relacionada]    BIT            NULL,
    CONSTRAINT [PK_fa_cliente] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCliente] ASC),
    CONSTRAINT [FK_fa_cliente_ct_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto_CXC]) REFERENCES [dbo].[ct_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_fa_cliente_ct_centro_costo1] FOREIGN KEY ([IdEmpresa], [IdCentroCosto_Anticipo]) REFERENCES [dbo].[ct_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_fa_cliente_ct_centro_costo2] FOREIGN KEY ([IdEmpresa], [IdCentroCosto_CXC_Credito]) REFERENCES [dbo].[ct_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_fa_cliente_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble_cxc]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_fa_cliente_ct_plancta1] FOREIGN KEY ([IdEmpresa], [IdCtaCble_Anti]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_fa_cliente_ct_plancta2] FOREIGN KEY ([IdEmpresa], [IdCtaCble_cxc_Credito]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_fa_cliente_fa_catalogo] FOREIGN KEY ([IdActividadComercial]) REFERENCES [dbo].[fa_catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_fa_cliente_fa_cliente_tipo] FOREIGN KEY ([IdEmpresa], [Idtipo_cliente]) REFERENCES [dbo].[fa_cliente_tipo] ([IdEmpresa], [Idtipo_cliente]),
    CONSTRAINT [FK_fa_cliente_tb_ciudad] FOREIGN KEY ([IdCiudad]) REFERENCES [dbo].[tb_ciudad] ([IdCiudad]),
    CONSTRAINT [FK_fa_cliente_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa]),
    CONSTRAINT [FK_fa_cliente_tb_persona] FOREIGN KEY ([IdPersona]) REFERENCES [dbo].[tb_persona] ([IdPersona])
);
