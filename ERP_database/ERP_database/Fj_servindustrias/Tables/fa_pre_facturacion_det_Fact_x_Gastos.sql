﻿CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_det_Fact_x_Gastos] (
    [IdEmpresa]                      INT           NOT NULL,
    [IdPreFacturacion]               NUMERIC (18)  NOT NULL,
    [secuencia]                      INT           NOT NULL,
    [IdCentro_Costo]                 VARCHAR (20)  NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20)  NULL,
    [IdPunto_cargo]                  INT           NULL,
    [IdEmpresa_ct]                   INT           NULL,
    [IdTipoCbte_ct]                  INT           NULL,
    [IdCbteCble_ct]                  NUMERIC (18)  NULL,
    [secuencia_ct]                   INT           NULL,
    [IdCuota]                        DECIMAL (18)  NULL,
    [secuencia_cuota]                INT           NULL,
    [Cantidad]                       FLOAT (53)    NOT NULL,
    [Costo_Uni]                      FLOAT (53)    NOT NULL,
    [Subtotal]                       FLOAT (53)    NOT NULL,
    [Por_Iva]                        FLOAT (53)    NOT NULL,
    [Valor_Iva]                      FLOAT (53)    NOT NULL,
    [Total]                          FLOAT (53)    NOT NULL,
    [Valor_a_cobrar]                 FLOAT (53)    NOT NULL,
    [Facturar]                       BIT           NOT NULL,
    [IdTarifario]                    NUMERIC (18)  NULL,
    [Porc_ganancia]                  FLOAT (53)    NOT NULL,
    [num_documento]                  VARCHAR (100) NOT NULL,
    [nom_proveedor]                  VARCHAR (300) NOT NULL,
    [Fecha_documento]                DATETIME      NOT NULL,
    [Observacion]                    VARCHAR (500) NULL,
    [IdTipoMovi_grupo]               INT           NULL,
    CONSTRAINT [PK_fa_pre_facturacion_det_Fact_x_Gastos] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPreFacturacion] ASC, [secuencia] ASC),
    CONSTRAINT [FK_fa_pre_facturacion_det_Fact_x_Gastos_fa_pre_facturacion] FOREIGN KEY ([IdEmpresa], [IdPreFacturacion]) REFERENCES [Fj_servindustrias].[fa_pre_facturacion] ([IdEmpresa], [IdPreFacturacion])
);







