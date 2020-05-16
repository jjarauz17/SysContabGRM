Imports DevExpress.XtraEditors.DXErrorProvider

Module ControlErrores

    Public notEmptyValidationRule As ConditionValidationRule

    Public Sub ValidationRule(ByVal Con As Control)
        notEmptyValidationRule = New ConditionValidationRule()
        If Con.GetType.Name = "TextEdit" Then
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
            notEmptyValidationRule.ErrorText = "Complete la Informacion"
        ElseIf Con.GetType.Name = "MemoEdit" And Con.Enabled = True Then
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
            notEmptyValidationRule.ErrorText = "Complete la Informacion"
        ElseIf Con.GetType.Name = "LookUpEdit" Then
            notEmptyValidationRule.ConditionOperator = ConditionOperator.NotEquals
            notEmptyValidationRule.Value1 = Nothing
            notEmptyValidationRule.Value2 = 0
            notEmptyValidationRule.ErrorText = "Seleccione de la lista"
        ElseIf Con.GetType.Name = "GridLookUpEdit" Then            
            notEmptyValidationRule.ConditionOperator = ConditionOperator.NotEquals
            notEmptyValidationRule.Value1 = Nothing
            notEmptyValidationRule.Value2 = 0
            notEmptyValidationRule.ErrorText = "Seleccione de la lista"
        ElseIf Con.GetType.Name = "SearchLookUpEdit" Then
            notEmptyValidationRule.ConditionOperator = ConditionOperator.NotEquals
            notEmptyValidationRule.Value1 = Nothing
            notEmptyValidationRule.Value2 = 0
            notEmptyValidationRule.ErrorText = "Seleccione de la lista"
        End If
    End Sub

    Public Sub AddValidation(ByRef Formulario As Control, ByRef ValidProvider As DXValidationProvider)
        For Each Con As Control In Formulario.Controls
            If Con.HasChildren Then AddValidation(Con, ValidProvider)
            If Con.Tag = "True" Then
                ValidationRule(Con)
                ValidProvider.SetValidationRule(Con, notEmptyValidationRule)
            End If
        Next

    End Sub

End Module
