<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
			If wiimote IsNot Nothing Then
				wiimote.Dispose()
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
		Me.btnSendData = New System.Windows.Forms.Button()
		Me.tbDimmer = New System.Windows.Forms.TrackBar()
		Me.txtDimmer = New System.Windows.Forms.TextBox()
		Me.gbDimmer = New System.Windows.Forms.GroupBox()
		Me.gbColor = New System.Windows.Forms.GroupBox()
		Me.tbColor = New System.Windows.Forms.TrackBar()
		Me.txtColor = New System.Windows.Forms.TextBox()
		Me.gbGobo = New System.Windows.Forms.GroupBox()
		Me.tbGobo = New System.Windows.Forms.TrackBar()
		Me.txtGobo = New System.Windows.Forms.TextBox()
		Me.gbRotation = New System.Windows.Forms.GroupBox()
		Me.tbRotation = New System.Windows.Forms.TrackBar()
		Me.txtRotation = New System.Windows.Forms.TextBox()
		Me.gbPan = New System.Windows.Forms.GroupBox()
		Me.tbPan = New System.Windows.Forms.TrackBar()
		Me.txtPan = New System.Windows.Forms.TextBox()
		Me.gbTilt = New System.Windows.Forms.GroupBox()
		Me.tbTilt = New System.Windows.Forms.TrackBar()
		Me.txtTilt = New System.Windows.Forms.TextBox()
		Me.gbPanTiltMacro = New System.Windows.Forms.GroupBox()
		Me.tbPanTilt = New System.Windows.Forms.TrackBar()
		Me.txtPanTiltMacro = New System.Windows.Forms.TextBox()
		Me.btnWiiMote = New System.Windows.Forms.Button()
		CType(Me.tbDimmer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbDimmer.SuspendLayout()
		Me.gbColor.SuspendLayout()
		CType(Me.tbColor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbGobo.SuspendLayout()
		CType(Me.tbGobo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbRotation.SuspendLayout()
		CType(Me.tbRotation, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbPan.SuspendLayout()
		CType(Me.tbPan, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbTilt.SuspendLayout()
		CType(Me.tbTilt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbPanTiltMacro.SuspendLayout()
		CType(Me.tbPanTilt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnSendData
		'
		Me.btnSendData.Location = New System.Drawing.Point(579, 83)
		Me.btnSendData.Margin = New System.Windows.Forms.Padding(2)
		Me.btnSendData.Name = "btnSendData"
		Me.btnSendData.Size = New System.Drawing.Size(90, 22)
		Me.btnSendData.TabIndex = 15
		Me.btnSendData.Text = "Send data"
		Me.btnSendData.UseVisualStyleBackColor = True
		'
		'tbDimmer
		'
		Me.tbDimmer.LargeChange = 17
		Me.tbDimmer.Location = New System.Drawing.Point(4, 16)
		Me.tbDimmer.Margin = New System.Windows.Forms.Padding(2)
		Me.tbDimmer.Maximum = 255
		Me.tbDimmer.Name = "tbDimmer"
		Me.tbDimmer.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tbDimmer.Size = New System.Drawing.Size(45, 195)
		Me.tbDimmer.SmallChange = 8
		Me.tbDimmer.TabIndex = 1
		Me.tbDimmer.TickFrequency = 17
		Me.tbDimmer.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tbDimmer.Value = 255
		'
		'txtDimmer
		'
		Me.txtDimmer.Location = New System.Drawing.Point(4, 215)
		Me.txtDimmer.Margin = New System.Windows.Forms.Padding(2)
		Me.txtDimmer.Name = "txtDimmer"
		Me.txtDimmer.Size = New System.Drawing.Size(47, 20)
		Me.txtDimmer.TabIndex = 2
		Me.txtDimmer.Text = "255"
		Me.txtDimmer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbDimmer
		'
		Me.gbDimmer.Controls.Add(Me.tbDimmer)
		Me.gbDimmer.Controls.Add(Me.txtDimmer)
		Me.gbDimmer.Location = New System.Drawing.Point(8, 8)
		Me.gbDimmer.Margin = New System.Windows.Forms.Padding(2)
		Me.gbDimmer.Name = "gbDimmer"
		Me.gbDimmer.Padding = New System.Windows.Forms.Padding(2)
		Me.gbDimmer.Size = New System.Drawing.Size(56, 242)
		Me.gbDimmer.TabIndex = 4
		Me.gbDimmer.TabStop = False
		Me.gbDimmer.Text = "Dimmer"
		'
		'gbColor
		'
		Me.gbColor.Controls.Add(Me.tbColor)
		Me.gbColor.Controls.Add(Me.txtColor)
		Me.gbColor.Location = New System.Drawing.Point(68, 8)
		Me.gbColor.Margin = New System.Windows.Forms.Padding(2)
		Me.gbColor.Name = "gbColor"
		Me.gbColor.Padding = New System.Windows.Forms.Padding(2)
		Me.gbColor.Size = New System.Drawing.Size(56, 242)
		Me.gbColor.TabIndex = 4
		Me.gbColor.TabStop = False
		Me.gbColor.Text = "Color"
		'
		'tbColor
		'
		Me.tbColor.LargeChange = 24
		Me.tbColor.Location = New System.Drawing.Point(4, 16)
		Me.tbColor.Margin = New System.Windows.Forms.Padding(2)
		Me.tbColor.Maximum = 255
		Me.tbColor.Name = "tbColor"
		Me.tbColor.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tbColor.Size = New System.Drawing.Size(45, 195)
		Me.tbColor.SmallChange = 12
		Me.tbColor.TabIndex = 3
		Me.tbColor.TickFrequency = 12
		Me.tbColor.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		'
		'txtColor
		'
		Me.txtColor.Location = New System.Drawing.Point(4, 215)
		Me.txtColor.Margin = New System.Windows.Forms.Padding(2)
		Me.txtColor.Name = "txtColor"
		Me.txtColor.Size = New System.Drawing.Size(47, 20)
		Me.txtColor.TabIndex = 4
		Me.txtColor.Text = "0"
		Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbGobo
		'
		Me.gbGobo.Controls.Add(Me.tbGobo)
		Me.gbGobo.Controls.Add(Me.txtGobo)
		Me.gbGobo.Location = New System.Drawing.Point(128, 8)
		Me.gbGobo.Margin = New System.Windows.Forms.Padding(2)
		Me.gbGobo.Name = "gbGobo"
		Me.gbGobo.Padding = New System.Windows.Forms.Padding(2)
		Me.gbGobo.Size = New System.Drawing.Size(56, 242)
		Me.gbGobo.TabIndex = 4
		Me.gbGobo.TabStop = False
		Me.gbGobo.Text = "Gobo"
		'
		'tbGobo
		'
		Me.tbGobo.LargeChange = 32
		Me.tbGobo.Location = New System.Drawing.Point(4, 16)
		Me.tbGobo.Margin = New System.Windows.Forms.Padding(2)
		Me.tbGobo.Maximum = 255
		Me.tbGobo.Name = "tbGobo"
		Me.tbGobo.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tbGobo.Size = New System.Drawing.Size(45, 195)
		Me.tbGobo.SmallChange = 16
		Me.tbGobo.TabIndex = 5
		Me.tbGobo.TickFrequency = 16
		Me.tbGobo.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		'
		'txtGobo
		'
		Me.txtGobo.Location = New System.Drawing.Point(4, 215)
		Me.txtGobo.Margin = New System.Windows.Forms.Padding(2)
		Me.txtGobo.Name = "txtGobo"
		Me.txtGobo.Size = New System.Drawing.Size(47, 20)
		Me.txtGobo.TabIndex = 6
		Me.txtGobo.Text = "0"
		Me.txtGobo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbRotation
		'
		Me.gbRotation.Controls.Add(Me.tbRotation)
		Me.gbRotation.Controls.Add(Me.txtRotation)
		Me.gbRotation.Location = New System.Drawing.Point(188, 8)
		Me.gbRotation.Margin = New System.Windows.Forms.Padding(2)
		Me.gbRotation.Name = "gbRotation"
		Me.gbRotation.Padding = New System.Windows.Forms.Padding(2)
		Me.gbRotation.Size = New System.Drawing.Size(56, 242)
		Me.gbRotation.TabIndex = 4
		Me.gbRotation.TabStop = False
		Me.gbRotation.Text = "Rotation"
		'
		'tbRotation
		'
		Me.tbRotation.LargeChange = 17
		Me.tbRotation.Location = New System.Drawing.Point(4, 16)
		Me.tbRotation.Margin = New System.Windows.Forms.Padding(2)
		Me.tbRotation.Maximum = 255
		Me.tbRotation.Name = "tbRotation"
		Me.tbRotation.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tbRotation.Size = New System.Drawing.Size(45, 195)
		Me.tbRotation.SmallChange = 8
		Me.tbRotation.TabIndex = 7
		Me.tbRotation.TickFrequency = 17
		Me.tbRotation.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		'
		'txtRotation
		'
		Me.txtRotation.Location = New System.Drawing.Point(4, 215)
		Me.txtRotation.Margin = New System.Windows.Forms.Padding(2)
		Me.txtRotation.Name = "txtRotation"
		Me.txtRotation.Size = New System.Drawing.Size(47, 20)
		Me.txtRotation.TabIndex = 8
		Me.txtRotation.Text = "0"
		Me.txtRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbPan
		'
		Me.gbPan.Controls.Add(Me.tbPan)
		Me.gbPan.Controls.Add(Me.txtPan)
		Me.gbPan.Location = New System.Drawing.Point(311, 8)
		Me.gbPan.Margin = New System.Windows.Forms.Padding(2)
		Me.gbPan.Name = "gbPan"
		Me.gbPan.Padding = New System.Windows.Forms.Padding(2)
		Me.gbPan.Size = New System.Drawing.Size(56, 242)
		Me.gbPan.TabIndex = 4
		Me.gbPan.TabStop = False
		Me.gbPan.Text = "Pan"
		'
		'tbPan
		'
		Me.tbPan.LargeChange = 32
		Me.tbPan.Location = New System.Drawing.Point(4, 16)
		Me.tbPan.Margin = New System.Windows.Forms.Padding(2)
		Me.tbPan.Maximum = 255
		Me.tbPan.Name = "tbPan"
		Me.tbPan.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tbPan.Size = New System.Drawing.Size(45, 195)
		Me.tbPan.SmallChange = 8
		Me.tbPan.TabIndex = 9
		Me.tbPan.TickFrequency = 16
		Me.tbPan.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tbPan.Value = 128
		'
		'txtPan
		'
		Me.txtPan.Location = New System.Drawing.Point(4, 215)
		Me.txtPan.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPan.Name = "txtPan"
		Me.txtPan.Size = New System.Drawing.Size(47, 20)
		Me.txtPan.TabIndex = 10
		Me.txtPan.Text = "128"
		Me.txtPan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbTilt
		'
		Me.gbTilt.Controls.Add(Me.tbTilt)
		Me.gbTilt.Controls.Add(Me.txtTilt)
		Me.gbTilt.Location = New System.Drawing.Point(371, 8)
		Me.gbTilt.Margin = New System.Windows.Forms.Padding(2)
		Me.gbTilt.Name = "gbTilt"
		Me.gbTilt.Padding = New System.Windows.Forms.Padding(2)
		Me.gbTilt.Size = New System.Drawing.Size(56, 242)
		Me.gbTilt.TabIndex = 4
		Me.gbTilt.TabStop = False
		Me.gbTilt.Text = "Tilt"
		'
		'tbTilt
		'
		Me.tbTilt.LargeChange = 32
		Me.tbTilt.Location = New System.Drawing.Point(4, 16)
		Me.tbTilt.Margin = New System.Windows.Forms.Padding(2)
		Me.tbTilt.Maximum = 255
		Me.tbTilt.Name = "tbTilt"
		Me.tbTilt.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tbTilt.Size = New System.Drawing.Size(45, 195)
		Me.tbTilt.SmallChange = 8
		Me.tbTilt.TabIndex = 11
		Me.tbTilt.TickFrequency = 16
		Me.tbTilt.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tbTilt.Value = 128
		'
		'txtTilt
		'
		Me.txtTilt.Location = New System.Drawing.Point(4, 215)
		Me.txtTilt.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTilt.Name = "txtTilt"
		Me.txtTilt.Size = New System.Drawing.Size(47, 20)
		Me.txtTilt.TabIndex = 12
		Me.txtTilt.Text = "128"
		Me.txtTilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbPanTiltMacro
		'
		Me.gbPanTiltMacro.Controls.Add(Me.tbPanTilt)
		Me.gbPanTiltMacro.Controls.Add(Me.txtPanTiltMacro)
		Me.gbPanTiltMacro.Location = New System.Drawing.Point(431, 8)
		Me.gbPanTiltMacro.Margin = New System.Windows.Forms.Padding(2)
		Me.gbPanTiltMacro.Name = "gbPanTiltMacro"
		Me.gbPanTiltMacro.Padding = New System.Windows.Forms.Padding(2)
		Me.gbPanTiltMacro.Size = New System.Drawing.Size(56, 242)
		Me.gbPanTiltMacro.TabIndex = 5
		Me.gbPanTiltMacro.TabStop = False
		Me.gbPanTiltMacro.Text = "Macro 1"
		'
		'tbPanTilt
		'
		Me.tbPanTilt.LargeChange = 16
		Me.tbPanTilt.Location = New System.Drawing.Point(4, 16)
		Me.tbPanTilt.Margin = New System.Windows.Forms.Padding(2)
		Me.tbPanTilt.Maximum = 255
		Me.tbPanTilt.Name = "tbPanTilt"
		Me.tbPanTilt.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tbPanTilt.Size = New System.Drawing.Size(45, 195)
		Me.tbPanTilt.SmallChange = 16
		Me.tbPanTilt.TabIndex = 13
		Me.tbPanTilt.TickFrequency = 16
		Me.tbPanTilt.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		'
		'txtPanTiltMacro
		'
		Me.txtPanTiltMacro.Location = New System.Drawing.Point(4, 215)
		Me.txtPanTiltMacro.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPanTiltMacro.Name = "txtPanTiltMacro"
		Me.txtPanTiltMacro.Size = New System.Drawing.Size(47, 20)
		Me.txtPanTiltMacro.TabIndex = 14
		Me.txtPanTiltMacro.Text = "0"
		Me.txtPanTiltMacro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'btnWiiMote
		'
		Me.btnWiiMote.Location = New System.Drawing.Point(579, 110)
		Me.btnWiiMote.Name = "btnWiiMote"
		Me.btnWiiMote.Size = New System.Drawing.Size(90, 23)
		Me.btnWiiMote.TabIndex = 16
		Me.btnWiiMote.Text = "Start WiiMote"
		Me.btnWiiMote.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AcceptButton = Me.btnSendData
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(681, 382)
		Me.Controls.Add(Me.btnWiiMote)
		Me.Controls.Add(Me.gbPanTiltMacro)
		Me.Controls.Add(Me.gbTilt)
		Me.Controls.Add(Me.gbPan)
		Me.Controls.Add(Me.gbRotation)
		Me.Controls.Add(Me.gbGobo)
		Me.Controls.Add(Me.gbColor)
		Me.Controls.Add(Me.gbDimmer)
		Me.Controls.Add(Me.btnSendData)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.tbDimmer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbDimmer.ResumeLayout(False)
		Me.gbDimmer.PerformLayout()
		Me.gbColor.ResumeLayout(False)
		Me.gbColor.PerformLayout()
		CType(Me.tbColor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbGobo.ResumeLayout(False)
		Me.gbGobo.PerformLayout()
		CType(Me.tbGobo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbRotation.ResumeLayout(False)
		Me.gbRotation.PerformLayout()
		CType(Me.tbRotation, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbPan.ResumeLayout(False)
		Me.gbPan.PerformLayout()
		CType(Me.tbPan, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbTilt.ResumeLayout(False)
		Me.gbTilt.PerformLayout()
		CType(Me.tbTilt, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbPanTiltMacro.ResumeLayout(False)
		Me.gbPanTiltMacro.PerformLayout()
		CType(Me.tbPanTilt, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnSendData As System.Windows.Forms.Button
	Friend WithEvents tbDimmer As System.Windows.Forms.TrackBar
	Friend WithEvents txtDimmer As System.Windows.Forms.TextBox
	Friend WithEvents gbDimmer As System.Windows.Forms.GroupBox
	Friend WithEvents gbColor As System.Windows.Forms.GroupBox
	Friend WithEvents tbColor As System.Windows.Forms.TrackBar
	Friend WithEvents txtColor As System.Windows.Forms.TextBox
	Friend WithEvents gbGobo As System.Windows.Forms.GroupBox
	Friend WithEvents tbGobo As System.Windows.Forms.TrackBar
	Friend WithEvents txtGobo As System.Windows.Forms.TextBox
	Friend WithEvents gbRotation As System.Windows.Forms.GroupBox
	Friend WithEvents tbRotation As System.Windows.Forms.TrackBar
	Friend WithEvents txtRotation As System.Windows.Forms.TextBox
	Friend WithEvents gbPan As System.Windows.Forms.GroupBox
	Friend WithEvents tbPan As System.Windows.Forms.TrackBar
	Friend WithEvents txtPan As System.Windows.Forms.TextBox
	Friend WithEvents gbTilt As System.Windows.Forms.GroupBox
	Friend WithEvents tbTilt As System.Windows.Forms.TrackBar
	Friend WithEvents txtTilt As System.Windows.Forms.TextBox
	Friend WithEvents gbPanTiltMacro As System.Windows.Forms.GroupBox
	Friend WithEvents tbPanTilt As System.Windows.Forms.TrackBar
	Friend WithEvents txtPanTiltMacro As System.Windows.Forms.TextBox
	Friend WithEvents btnWiiMote As System.Windows.Forms.Button

End Class
