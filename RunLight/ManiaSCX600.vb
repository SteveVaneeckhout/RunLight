Public Class ManiaSCX600
	Implements IDMXDevice

	Private _iAddress As Integer
	Private _eDmxMode As DmxMode
	Private _lSettings As List(Of Byte)

	Public Property Manufacturer() As String Implements IDMXDevice.Manufacturer
		Get
			Return "Martin"
		End Get
		Set(ByVal value As String)

		End Set
	End Property

	Public Property Name() As String Implements IDMXDevice.Name
		Get
			Return "Mania SCX-600"
		End Get
		Set(ByVal value As String)

		End Set
	End Property

	Public Property Address() As Integer Implements IDMXDevice.Address
		Get
			Return _iAddress
		End Get
		Set(ByVal value As Integer)
			_iAddress = value
		End Set
	End Property

	Public Property AddressCount() As Integer Implements IDMXDevice.AddressCount
		Get
			If DMXMode = RunLight.DmxMode.DmxMode1 Then
				Return 7
			ElseIf DMXMode = RunLight.DmxMode.DmxMode2 Then
				Return 11
			Else
				Return 0
			End If
		End Get
		Set(ByVal value As Integer)

		End Set
	End Property

	Public Property DMXMode() As DmxMode Implements IDMXDevice.DMXMode
		Get
			Return _eDmxMode
		End Get
		Set(ByVal value As DmxMode)
			_eDmxMode = value
		End Set
	End Property

	Public Property State() As Byte() Implements IDMXDevice.State
		Get
			Return _lSettings.ToArray
		End Get
		Set(ByVal value As Byte())
			_lSettings = New List(Of Byte)(value)
		End Set
	End Property

	Public Sub New(address As Integer, mode As DmxMode)
		_lSettings = New List(Of Byte)(7)
		With _lSettings
			.Add(8)		' Shutter open
			.Add(255)	' 100%
			.Add(0)		' Color wheel (red)
			.Add(0)		' Gobo selection (open)
			.Add(0)		' Gobo rotation type (stop)
			.Add(128)	' Pan (neutral)
			.Add(128)	' Tilt (neutral)
			.Add(0)
			.Add(0)
			.Add(0)
			.Add(0)
		End With
		DMXMode = mode
		address = address
	End Sub

	Public Function GetSetting(ByVal channel As Integer) As Byte Implements IDMXDevice.GetSetting
		Return _lSettings(channel - 1)
	End Function

	Public Sub SetSetting(ByVal channel As Integer, ByVal value As Byte) Implements IDMXDevice.SetSetting
		_lSettings(channel - 1) = value
	End Sub

End Class
