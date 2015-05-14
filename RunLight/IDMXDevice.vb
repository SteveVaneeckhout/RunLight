Public Interface IDMXDevice
	Property Manufacturer() As String
	Property Name() As String
	Property DMXMode() As DmxMode
	Property AddressCount() As Integer
	Property Address() As Integer
	Property State() As Byte()

	Function GetSetting(ByVal address As Integer) As Byte
	Sub SetSetting(ByVal channel As Integer, ByVal value As Byte)
End Interface

Public Enum DmxMode
	DmxMode1 = 1
	DmxMode2 = 2
End Enum
