﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChats
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChats))
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.MChat_diag = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.app_titulo = New System.Windows.Forms.Label()
        Me.btn_salir = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_enviar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_modificar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_fichaMed = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TopPanel.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico.Location = New System.Drawing.Point(5, 713)
        Me.txtDiagnostico.MaxLength = 30
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(178, 29)
        Me.txtDiagnostico.TabIndex = 3
        '
        'MChat_diag
        '
        Me.MChat_diag.AutoSize = True
        Me.MChat_diag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MChat_diag.ForeColor = System.Drawing.Color.Silver
        Me.MChat_diag.Location = New System.Drawing.Point(5, 692)
        Me.MChat_diag.Name = "MChat_diag"
        Me.MChat_diag.Size = New System.Drawing.Size(92, 21)
        Me.MChat_diag.TabIndex = 8
        Me.MChat_diag.Text = "Diagnostico"
        '
        'txtMensaje
        '
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(5, 659)
        Me.txtMensaje.MaxLength = 255
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(458, 30)
        Me.txtMensaje.TabIndex = 1
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.White
        Me.txtChat.Enabled = False
        Me.txtChat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChat.ForeColor = System.Drawing.Color.Black
        Me.txtChat.Location = New System.Drawing.Point(5, 78)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChat.Size = New System.Drawing.Size(575, 576)
        Me.txtChat.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 1200
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.btnMinimize)
        Me.TopPanel.Controls.Add(Me.PictureBox5)
        Me.TopPanel.Controls.Add(Me.app_titulo)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(778, 28)
        Me.TopPanel.TabIndex = 12
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.Minimize_Icon
        Me.btnMinimize.Location = New System.Drawing.Point(744, 5)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Padding = New System.Windows.Forms.Padding(3)
        Me.btnMinimize.Size = New System.Drawing.Size(22, 22)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 10
        Me.btnMinimize.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox5.Location = New System.Drawing.Point(5, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'app_titulo
        '
        Me.app_titulo.AutoSize = True
        Me.app_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.app_titulo.ForeColor = System.Drawing.Color.Silver
        Me.app_titulo.Location = New System.Drawing.Point(38, 2)
        Me.app_titulo.Name = "app_titulo"
        Me.app_titulo.Size = New System.Drawing.Size(344, 25)
        Me.app_titulo.TabIndex = 8
        Me.app_titulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'btn_salir
        '
        Me.btn_salir.Animated = True
        Me.btn_salir.BorderColor = System.Drawing.Color.Transparent
        Me.btn_salir.BorderRadius = 10
        Me.btn_salir.CheckedState.Parent = Me.btn_salir
        Me.btn_salir.CustomImages.Parent = Me.btn_salir
        Me.btn_salir.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_salir.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.HoverState.Parent = Me.btn_salir
        Me.btn_salir.Location = New System.Drawing.Point(12, 36)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.ShadowDecoration.Parent = Me.btn_salir
        Me.btn_salir.Size = New System.Drawing.Size(120, 30)
        Me.btn_salir.TabIndex = 13
        Me.btn_salir.Text = "SALIR"
        '
        'btn_enviar
        '
        Me.btn_enviar.Animated = True
        Me.btn_enviar.BackColor = System.Drawing.Color.Transparent
        Me.btn_enviar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_enviar.BorderThickness = 2
        Me.btn_enviar.CheckedState.Parent = Me.btn_enviar
        Me.btn_enviar.CustomImages.Parent = Me.btn_enviar
        Me.btn_enviar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_enviar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_enviar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_enviar.HoverState.Parent = Me.btn_enviar
        Me.btn_enviar.Location = New System.Drawing.Point(464, 658)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_enviar.ShadowDecoration.BorderRadius = 20
        Me.btn_enviar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_enviar.ShadowDecoration.Depth = 15
        Me.btn_enviar.ShadowDecoration.Enabled = True
        Me.btn_enviar.ShadowDecoration.Parent = Me.btn_enviar
        Me.btn_enviar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(6)
        Me.btn_enviar.Size = New System.Drawing.Size(113, 32)
        Me.btn_enviar.TabIndex = 14
        Me.btn_enviar.Text = "ENVIAR"
        '
        'btn_modificar
        '
        Me.btn_modificar.Animated = True
        Me.btn_modificar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar.BorderRadius = 10
        Me.btn_modificar.BorderThickness = 2
        Me.btn_modificar.CheckedState.Parent = Me.btn_modificar
        Me.btn_modificar.CustomImages.Parent = Me.btn_modificar
        Me.btn_modificar.FillColor = System.Drawing.Color.Empty
        Me.btn_modificar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.White
        Me.btn_modificar.HoverState.Parent = Me.btn_modificar
        Me.btn_modificar.Location = New System.Drawing.Point(189, 713)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.ShadowDecoration.Parent = Me.btn_modificar
        Me.btn_modificar.Size = New System.Drawing.Size(120, 30)
        Me.btn_modificar.TabIndex = 15
        Me.btn_modificar.Text = "MODIFICAR"
        '
        'btn_fichaMed
        '
        Me.btn_fichaMed.Animated = True
        Me.btn_fichaMed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_fichaMed.BorderRadius = 10
        Me.btn_fichaMed.BorderThickness = 2
        Me.btn_fichaMed.CheckedState.Parent = Me.btn_fichaMed
        Me.btn_fichaMed.CustomImages.Parent = Me.btn_fichaMed
        Me.btn_fichaMed.FillColor = System.Drawing.Color.Empty
        Me.btn_fichaMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fichaMed.ForeColor = System.Drawing.Color.White
        Me.btn_fichaMed.HoverState.Parent = Me.btn_fichaMed
        Me.btn_fichaMed.Location = New System.Drawing.Point(380, 713)
        Me.btn_fichaMed.Name = "btn_fichaMed"
        Me.btn_fichaMed.ShadowDecoration.Parent = Me.btn_fichaMed
        Me.btn_fichaMed.Size = New System.Drawing.Size(197, 30)
        Me.btn_fichaMed.TabIndex = 15
        Me.btn_fichaMed.Text = "FICHA MEDICA"
        '
        'txtCi
        '
        Me.txtCi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCi.Location = New System.Drawing.Point(315, 730)
        Me.txtCi.MaxLength = 30
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(11, 29)
        Me.txtCi.TabIndex = 3
        Me.txtCi.Visible = False
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(586, 33)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(192, 726)
        Me.Guna2DataGridView1.TabIndex = 16
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FrmChats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 760)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.btn_fichaMed)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.MChat_diag)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmChats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDiagnostico As TextBox
    Friend WithEvents MChat_diag As Label
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents txtChat As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TopPanel As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents app_titulo As Label
    Friend WithEvents btn_salir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_enviar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_modificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_fichaMed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents txtCi As TextBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
