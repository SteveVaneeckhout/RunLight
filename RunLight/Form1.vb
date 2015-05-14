Public Class Form1
	Private _dMania As ManiaSCX600
	Private runny As Runner
	Private wiimote As WiimoteLib.Wiimote

	Public Sub New()
		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		_dMania = New ManiaSCX600(1, DmxMode.DmxMode2)
		_dMania.Address = 1
		runny = New Runner()
	End Sub

	Private Sub UpdateUniverseData()
		Dim bla As New List(Of Byte)()

		bla.AddRange(_dMania.State)
		runny.UniverseData = bla.ToArray
	End Sub

	Private Sub tbDimmer_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDimmer.Scroll
		txtDimmer.Text = tbDimmer.Value

		_dMania.SetSetting(2, CByte(tbDimmer.Value))
		UpdateUniverseData()
	End Sub

	Private Sub txtDimmer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDimmer.KeyDown
		Dim bValue As Byte

		If e.KeyCode = Keys.Up Then
			If Byte.TryParse(txtDimmer.Text, bValue) AndAlso bValue < 255 Then
				txtDimmer.Text = bValue + 1
				tbDimmer.Value = bValue + 1

				UpdateUniverseData()

				e.Handled = True
			End If
		ElseIf e.KeyCode = Keys.Down Then
			If Byte.TryParse(txtDimmer.Text, bValue) AndAlso bValue > 0 Then
				txtDimmer.Text = bValue - 1
				tbDimmer.Value = bValue - 1

				UpdateUniverseData()

				e.Handled = True
			End If
		End If
	End Sub

	Private Sub txtDimmer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDimmer.TextChanged
		Dim bValue As Byte = 0

		If Byte.TryParse(txtDimmer.Text, bValue) Then
			tbDimmer.Value = bValue
		End If
	End Sub

	Private Sub btnSendData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendData.Click
		If btnSendData.Text = "Send data" Then
			btnSendData.Text = "Stop sending"

			UpdateUniverseData()
			runny.Start()
		Else
			btnSendData.Text = "Send data"

			runny.Stop()
		End If
	End Sub

	Private Sub tbColor_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbColor.Scroll
		txtColor.Text = tbColor.Value

		_dMania.SetSetting(3, CByte(tbColor.Value))
		UpdateUniverseData()
	End Sub

	Private Sub tbPan_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPan.Scroll
		txtPan.Text = tbPan.Value

		_dMania.SetSetting(6, CByte(tbPan.Value))
		UpdateUniverseData()
	End Sub

	Private Sub tbTilt_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTilt.Scroll
		txtTilt.Text = tbTilt.Value

		_dMania.SetSetting(7, CByte(tbTilt.Value))
		UpdateUniverseData()
	End Sub

	Private Sub tbGobo_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGobo.Scroll
		txtGobo.Text = tbGobo.Value

		_dMania.SetSetting(4, CByte(tbGobo.Value))
		UpdateUniverseData()
	End Sub

	Private Sub tbRotation_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRotation.Scroll
		txtRotation.Text = tbRotation.Value

		_dMania.SetSetting(5, CByte(tbRotation.Value))
		UpdateUniverseData()
	End Sub

	Private Sub tbPanTilt_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPanTilt.Scroll
		txtPanTiltMacro.Text = tbPanTilt.Value

		_dMania.SetSetting(8, CByte(tbPanTilt.Value))
		UpdateUniverseData()
	End Sub

	Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.Space Then
			If _dMania.GetSetting(1) <> 0 Then
				_dMania.SetSetting(1, 0)
				UpdateUniverseData()
			End If
		End If
	End Sub

	Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
		If e.KeyCode = Keys.Space Then
			_dMania.SetSetting(1, 8)
			UpdateUniverseData()
		End If
	End Sub

	Private Sub btnWiiMote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWiiMote.Click
		If btnWiiMote.Text = "Start WiiMote" Then
			wiimote = New WiimoteLib.Wiimote()


			wiimote.Connect()
			wiimote.SetReportType(WiimoteLib.InputReport.ButtonsAccel, False)
			AddHandler wiimote.WiimoteChanged, AddressOf WiiButtonPressed

			btnWiiMote.Text = "Stop WiiMote"
		Else
			wiimote.Disconnect()
			RemoveHandler wiimote.WiimoteChanged, AddressOf WiiButtonPressed

			btnWiiMote.Text = "Start WiiMote"
		End If
	End Sub

	Delegate Sub SetTextCallback(ByVal sender As Object, ByVal e As WiimoteLib.WiimoteChangedEventArgs)

	Private Sub WiiButtonPressed(ByVal sender As Object, ByVal e As WiimoteLib.WiimoteChangedEventArgs)
		If InvokeRequired Then
			Dim d As New SetTextCallback(AddressOf WiiButtonPressed)
			Me.Invoke(d, sender, e)

			Return
		End If

		If e.WiimoteState.ButtonState.Plus Then
			If tbDimmer.Value < tbDimmer.Maximum Then
				tbDimmer.Value += 1
				txtDimmer.Text = tbDimmer.Value
				_dMania.SetSetting(2, tbDimmer.Value)
			End If
		End If
		If e.WiimoteState.ButtonState.Minus Then
			If tbDimmer.Value > tbDimmer.Minimum Then
				tbDimmer.Value -= 1
				txtDimmer.Text = tbDimmer.Value
				_dMania.SetSetting(2, tbDimmer.Value)
			End If
		End If
		If e.WiimoteState.ButtonState.Left Then
			If tbGobo.Value >= tbGobo.Minimum + tbGobo.SmallChange Then
				tbGobo.Value -= tbGobo.SmallChange

				txtGobo.Text = tbGobo.Value

				_dMania.SetSetting(4, CByte(tbGobo.Value))
			End If
		End If
		If e.WiimoteState.ButtonState.Right Then
			If tbGobo.Value <= tbGobo.Maximum - tbGobo.SmallChange Then
				tbGobo.Value += tbGobo.SmallChange

				txtGobo.Text = tbGobo.Value

				_dMania.SetSetting(4, CByte(tbGobo.Value))
			End If
		End If
		If e.WiimoteState.ButtonState.Up Then
			If tbColor.Value <= tbColor.Maximum - tbColor.SmallChange Then
				tbColor.Value += tbColor.SmallChange

				txtColor.Text = tbColor.Value

				_dMania.SetSetting(3, CByte(tbColor.Value))
			End If
		End If
		If e.WiimoteState.ButtonState.Down Then
			If tbColor.Value >= tbColor.Minimum + tbColor.SmallChange Then
				tbColor.Value -= tbColor.SmallChange

				txtColor.Text = tbColor.Value

				_dMania.SetSetting(3, CByte(tbColor.Value))
			End If
		End If
		If e.WiimoteState.ButtonState.B Then
			If _dMania.GetSetting(1) <> 95 Then _dMania.SetSetting(1, 95)
		Else
			If _dMania.GetSetting(1) <> 8 Then _dMania.SetSetting(1, 8)
		End If

		Dim y As Single
		y = e.WiimoteState.AccelState.Values.Y

		If y >= 0.8 Then
			_dMania.SetSetting(7, 0)

		ElseIf y <= -0.8 Then
			_dMania.SetSetting(7, 255)
		Else
			_dMania.SetSetting(7, Convert.ToByte((160 * y + 128)))
		End If
		txtTilt.Text = tbTilt.Value

		Dim z, x As Single
		z = e.WiimoteState.AccelState.Values.Z
		x = e.WiimoteState.AccelState.Values.X

		If z <= 0.2 And x < 0 Then
			_dMania.SetSetting(6, 0)
		ElseIf z >= 0.8 And x > 0 Then
			_dMania.SetSetting(6, 128)
		ElseIf z <= 0.2 And x > 0 Then
			_dMania.SetSetting(6, 255)
		End If

		UpdateUniverseData()
	End Sub
End Class
