﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusinessTravelExpenses
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusinessTravelExpenses))
    Me.btnPreview = New System.Windows.Forms.Button()
    Me.txtOrg = New System.Windows.Forms.TextBox()
    Me.txtPlace = New System.Windows.Forms.TextBox()
    Me.txtDates = New System.Windows.Forms.TextBox()
    Me.txtTaxi = New System.Windows.Forms.TextBox()
    Me.txtMealsEnt = New System.Windows.Forms.TextBox()
    Me.txtAirFare = New System.Windows.Forms.TextBox()
    Me.txtLodging = New System.Windows.Forms.TextBox()
    Me.lblTaxi = New System.Windows.Forms.Label()
    Me.lblLodging = New System.Windows.Forms.Label()
    Me.lblAirfare = New System.Windows.Forms.Label()
    Me.lblMealsEnt = New System.Windows.Forms.Label()
    Me.lblPlace = New System.Windows.Forms.Label()
    Me.lblDates = New System.Windows.Forms.Label()
    Me.lblOrg = New System.Windows.Forms.Label()
    Me.btnPrint = New System.Windows.Forms.Button()
    Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
    Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
    Me.SuspendLayout
    '
    'btnPreview
    '
    Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnPreview.Location = New System.Drawing.Point(22, 231)
    Me.btnPreview.Name = "btnPreview"
    Me.btnPreview.Size = New System.Drawing.Size(249, 36)
    Me.btnPreview.TabIndex = 32
    Me.btnPreview.Text = "Preview Business Travel Expenses Attachment"
    Me.btnPreview.UseVisualStyleBackColor = true
    '
    'txtOrg
    '
    Me.txtOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtOrg.Location = New System.Drawing.Point(180, 10)
    Me.txtOrg.Margin = New System.Windows.Forms.Padding(4)
    Me.txtOrg.Name = "txtOrg"
    Me.txtOrg.Size = New System.Drawing.Size(94, 20)
    Me.txtOrg.TabIndex = 18
    '
    'txtPlace
    '
    Me.txtPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtPlace.Location = New System.Drawing.Point(180, 60)
    Me.txtPlace.Margin = New System.Windows.Forms.Padding(4)
    Me.txtPlace.Name = "txtPlace"
    Me.txtPlace.Size = New System.Drawing.Size(94, 20)
    Me.txtPlace.TabIndex = 22
    '
    'txtDates
    '
    Me.txtDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtDates.Location = New System.Drawing.Point(180, 35)
    Me.txtDates.Margin = New System.Windows.Forms.Padding(4)
    Me.txtDates.Name = "txtDates"
    Me.txtDates.Size = New System.Drawing.Size(94, 20)
    Me.txtDates.TabIndex = 20
    '
    'txtTaxi
    '
    Me.txtTaxi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtTaxi.Location = New System.Drawing.Point(180, 160)
    Me.txtTaxi.Margin = New System.Windows.Forms.Padding(4)
    Me.txtTaxi.Name = "txtTaxi"
    Me.txtTaxi.Size = New System.Drawing.Size(94, 20)
    Me.txtTaxi.TabIndex = 30
    '
    'txtMealsEnt
    '
    Me.txtMealsEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtMealsEnt.Location = New System.Drawing.Point(180, 85)
    Me.txtMealsEnt.Margin = New System.Windows.Forms.Padding(4)
    Me.txtMealsEnt.Name = "txtMealsEnt"
    Me.txtMealsEnt.Size = New System.Drawing.Size(94, 20)
    Me.txtMealsEnt.TabIndex = 24
    '
    'txtAirFare
    '
    Me.txtAirFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtAirFare.Location = New System.Drawing.Point(180, 110)
    Me.txtAirFare.Margin = New System.Windows.Forms.Padding(4)
    Me.txtAirFare.Name = "txtAirFare"
    Me.txtAirFare.Size = New System.Drawing.Size(94, 20)
    Me.txtAirFare.TabIndex = 26
    '
    'txtLodging
    '
    Me.txtLodging.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtLodging.Location = New System.Drawing.Point(180, 135)
    Me.txtLodging.Margin = New System.Windows.Forms.Padding(4)
    Me.txtLodging.Name = "txtLodging"
    Me.txtLodging.Size = New System.Drawing.Size(94, 20)
    Me.txtLodging.TabIndex = 28
    '
    'lblTaxi
    '
    Me.lblTaxi.AutoSize = true
    Me.lblTaxi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTaxi.Location = New System.Drawing.Point(108, 163)
    Me.lblTaxi.Margin = New System.Windows.Forms.Padding(5, 4, 3, 4)
    Me.lblTaxi.Name = "lblTaxi"
    Me.lblTaxi.Size = New System.Drawing.Size(56, 13)
    Me.lblTaxi.TabIndex = 29
    Me.lblTaxi.Text = "Taxi fares:"
    '
    'lblLodging
    '
    Me.lblLodging.AutoSize = true
    Me.lblLodging.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblLodging.Location = New System.Drawing.Point(116, 138)
    Me.lblLodging.Margin = New System.Windows.Forms.Padding(5, 4, 3, 4)
    Me.lblLodging.Name = "lblLodging"
    Me.lblLodging.Size = New System.Drawing.Size(48, 13)
    Me.lblLodging.TabIndex = 27
    Me.lblLodging.Text = "Lodging:"
    '
    'lblAirfare
    '
    Me.lblAirfare.AutoSize = true
    Me.lblAirfare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblAirfare.Location = New System.Drawing.Point(95, 113)
    Me.lblAirfare.Margin = New System.Windows.Forms.Padding(5, 4, 3, 4)
    Me.lblAirfare.Name = "lblAirfare"
    Me.lblAirfare.Size = New System.Drawing.Size(69, 13)
    Me.lblAirfare.TabIndex = 25
    Me.lblAirfare.Text = "Airplane fare:"
    '
    'lblMealsEnt
    '
    Me.lblMealsEnt.AutoSize = true
    Me.lblMealsEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblMealsEnt.Location = New System.Drawing.Point(38, 88)
    Me.lblMealsEnt.Margin = New System.Windows.Forms.Padding(5, 4, 3, 4)
    Me.lblMealsEnt.Name = "lblMealsEnt"
    Me.lblMealsEnt.Size = New System.Drawing.Size(126, 13)
    Me.lblMealsEnt.TabIndex = 23
    Me.lblMealsEnt.Text = "Meals and entertainment:"
    '
    'lblPlace
    '
    Me.lblPlace.AutoSize = true
    Me.lblPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblPlace.Location = New System.Drawing.Point(113, 63)
    Me.lblPlace.Margin = New System.Windows.Forms.Padding(5, 4, 3, 4)
    Me.lblPlace.Name = "lblPlace"
    Me.lblPlace.Size = New System.Drawing.Size(51, 13)
    Me.lblPlace.TabIndex = 21
    Me.lblPlace.Text = "Location:"
    '
    'lblDates
    '
    Me.lblDates.AutoSize = true
    Me.lblDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblDates.Location = New System.Drawing.Point(126, 38)
    Me.lblDates.Margin = New System.Windows.Forms.Padding(5, 4, 1, 4)
    Me.lblDates.Name = "lblDates"
    Me.lblDates.Size = New System.Drawing.Size(38, 13)
    Me.lblDates.TabIndex = 19
    Me.lblDates.Text = "Dates:"
    '
    'lblOrg
    '
    Me.lblOrg.AutoSize = true
    Me.lblOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblOrg.Location = New System.Drawing.Point(62, 13)
    Me.lblOrg.Margin = New System.Windows.Forms.Padding(5, 4, 1, 4)
    Me.lblOrg.Name = "lblOrg"
    Me.lblOrg.Size = New System.Drawing.Size(102, 13)
    Me.lblOrg.TabIndex = 17
    Me.lblOrg.Text = "Organization visited:"
    '
    'btnPrint
    '
    Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnPrint.Location = New System.Drawing.Point(22, 188)
    Me.btnPrint.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnPrint.Name = "btnPrint"
    Me.btnPrint.Size = New System.Drawing.Size(249, 36)
    Me.btnPrint.TabIndex = 31
    Me.btnPrint.Text = "Print Business Travel Expenses Attachment"
    '
    'PrintDocument1
    '
    '
    'PrintPreviewDialog1
    '
    Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
    Me.PrintPreviewDialog1.Enabled = true
    Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"),System.Drawing.Icon)
    Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
    Me.PrintPreviewDialog1.Visible = false
    '
    'frmBusinessTravelExpenses
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(300, 287)
    Me.Controls.Add(Me.btnPreview)
    Me.Controls.Add(Me.txtOrg)
    Me.Controls.Add(Me.txtPlace)
    Me.Controls.Add(Me.txtDates)
    Me.Controls.Add(Me.txtTaxi)
    Me.Controls.Add(Me.txtMealsEnt)
    Me.Controls.Add(Me.txtAirFare)
    Me.Controls.Add(Me.txtLodging)
    Me.Controls.Add(Me.lblTaxi)
    Me.Controls.Add(Me.lblLodging)
    Me.Controls.Add(Me.lblAirfare)
    Me.Controls.Add(Me.lblMealsEnt)
    Me.Controls.Add(Me.lblPlace)
    Me.Controls.Add(Me.lblDates)
    Me.Controls.Add(Me.lblOrg)
    Me.Controls.Add(Me.btnPrint)
    Me.Name = "frmBusinessTravelExpenses"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Business Travel Expenses"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents btnPreview As Button
  Friend WithEvents txtOrg As TextBox
  Friend WithEvents txtPlace As TextBox
  Friend WithEvents txtDates As TextBox
  Friend WithEvents txtTaxi As TextBox
  Friend WithEvents txtMealsEnt As TextBox
  Friend WithEvents txtAirFare As TextBox
  Friend WithEvents txtLodging As TextBox
  Friend WithEvents lblTaxi As Label
  Friend WithEvents lblLodging As Label
  Friend WithEvents lblAirfare As Label
  Friend WithEvents lblMealsEnt As Label
  Friend WithEvents lblPlace As Label
  Friend WithEvents lblDates As Label
  Friend WithEvents lblOrg As Label
  Friend WithEvents btnPrint As Button
  Friend WithEvents PrintDocument1 As Printing.PrintDocument
  Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
