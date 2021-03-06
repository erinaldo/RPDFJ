﻿CREATE VIEW Fj_servindustrias.vwROLES_Rpt001
AS
SELECT        dbo.ro_nomina_x_horas_extras.IdEmpresa, dbo.ro_nomina_x_horas_extras.IdEmpleado, dbo.ro_nomina_x_horas_extras.IdNominaTipo, dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui, 
                         dbo.ro_nomina_x_horas_extras.IdPeriodo, dbo.ro_nomina_x_horas_extras.IdCalendario, dbo.ro_nomina_x_horas_extras.IdTurno, dbo.ro_nomina_x_horas_extras.IdHorario, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, dbo.ro_nomina_x_horas_extras.FechaRegistro, dbo.ro_nomina_x_horas_extras.time_entrada1, 
                         dbo.ro_nomina_x_horas_extras.time_salida1, dbo.ro_nomina_x_horas_extras.time_entrada2, dbo.ro_nomina_x_horas_extras.time_salida2, dbo.ro_nomina_x_horas_extras.hora_trabajada, 
                         dbo.ro_nomina_x_horas_extras.hora_extra25, dbo.ro_nomina_x_horas_extras.hora_extra50, dbo.ro_nomina_x_horas_extras.hora_extra100, Fj_servindustrias.ro_Grupo_empleado.Calculo_Horas_extras_Sobre, 
                         dbo.ct_centro_costo_sub_centro_costo.Centro_costo
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_nomina_x_horas_extras ON dbo.ro_empleado.IdEmpresa = dbo.ro_nomina_x_horas_extras.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_nomina_x_horas_extras.IdEmpleado INNER JOIN
                         dbo.ro_periodo ON dbo.ro_nomina_x_horas_extras.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_nomina_x_horas_extras.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND dbo.ro_empleado.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo INNER JOIN
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpleado INNER JOIN
                         dbo.Af_Activo_fijo ON Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdActivo_fijo = dbo.Af_Activo_fijo.IdActivoFijo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON dbo.Af_Activo_fijo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         dbo.Af_Activo_fijo.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo AND dbo.Af_Activo_fijo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwROLES_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     Right = 573
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_Activo_Fijo (Fj_servindustrias)"
            Begin Extent = 
               Top = 0
               Left = 621
               Bottom = 185
               Right = 805
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 6
               Left = 949
               Bottom = 229
               Right = 1212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 225
               Left = 943
               Bottom = 426
               Right = 1206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwROLES_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[5] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 223
               Left = 595
               Bottom = 353
               Right = 800
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 207
               Left = 524
               Bottom = 337
               Right = 705
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_nomina_x_horas_extras"
            Begin Extent = 
               Top = 291
               Left = 499
               Bottom = 421
               Right = 727
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_periodo"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 259
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Grupo_empleado (Fj_servindustrias)"
            Begin Extent = 
               Top = 264
               Left = 336
               Bottom = 525
          ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwROLES_Rpt001';

