﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShowMenuTap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlOutput = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlOutput
        '
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOutput.Location = New System.Drawing.Point(201, 12)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(697, 419)
        Me.pnlOutput.TabIndex = 0
        '
        'FrmShowMenuTap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 517)
        Me.Controls.Add(Me.pnlOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmShowMenuTap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShowMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOutput As Panel
End Class
