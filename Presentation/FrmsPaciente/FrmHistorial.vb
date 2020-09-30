﻿Public Class FrmHistorial

    Private Sub FrmHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvHistorial.DataSource = FrmLogIn.paci.VerDiagnosticos
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        DgvHistorial.DataSource = FrmLogIn.paci.VerDiagnosticosFecha(DateTimePicker1.Text)
    End Sub

    Private Sub btnEntre_Click(sender As Object, e As EventArgs) Handles btnEntre.Click
        DgvHistorial.DataSource = FrmLogIn.paci.VerDiagnosticosEntreFecha(DateTimePicker1.Text, DateTimePicker2.Text)

    End Sub

    Private Sub switch_CheckedChanged(sender As Object, e As EventArgs) Handles switch.CheckedChanged
        If switch.Checked Then
            btnEntre.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            btnEntre.Enabled = False
            DateTimePicker2.Enabled = False
        End If

    End Sub

End Class