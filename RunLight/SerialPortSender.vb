Imports System.IO.Ports

Public Class SerialPortSender
	Implements IDisposable

	Private disposedValue As Boolean = False	' To detect redundant calls
	Private _spDMXPort As SerialPort

	Public Sub New()
		Debug.WriteLine("Trying available serial ports")

		For Each port As String In SerialPort.GetPortNames()
			Debug.WriteLine("Trying port " & port)

			_spDMXPort = New SerialPort(port, 250000, Parity.None, 8, StopBits.Two)

			Try
				_spDMXPort.Open()
				Exit For
			Catch
			End Try
		Next

		If _spDMXPort IsNot Nothing AndAlso _spDMXPort.IsOpen() Then
			Debug.WriteLine("Serialport opened at " & _spDMXPort.PortName & ", baudrate set at " & _spDMXPort.BaudRate)
		Else
			Throw New Exception("Failed to find and open a serial port")
		End If
	End Sub

	Public Sub Send(ByVal data As Byte())
		If data.Length > 512 Then
			Throw New ArgumentOutOfRangeException("data", data.Length, "Data length can not be higher than 512")
		End If

		'Send break time
		_spDMXPort.BreakState = True
		Threading.Thread.Sleep(20)
		_spDMXPort.BreakState = False

		'Send Mark After Break (MAB)
		_spDMXPort.Write(New Byte() {255}, 0, 1)

		'Send Start Code (SC)
		'_spDMXPort.StopBits = StopBits.Two
		_spDMXPort.Write(New Byte() {0}, 0, 1)

		'Send dmx data
		_spDMXPort.Write(data, 0, data.Length)
	End Sub

	Private Sub ChangePortRate(ByVal baudrate As Integer)
		If _spDMXPort.IsOpen Then
			_spDMXPort.BaudRate = baudrate

			'Debug.WriteLine("Baudrate changed to " & _spDMXPort.BaudRate)
		End If
	End Sub

	' IDisposable
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
		If Not Me.disposedValue Then
			If disposing Then
				' TODO: free other state (managed objects).
			End If

			If _spDMXPort.IsOpen Then
				_spDMXPort.Close()
			End If
		End If
		Me.disposedValue = True
	End Sub

#Region " IDisposable Support "
	' This code added by Visual Basic to correctly implement the disposable pattern.
	Public Sub Dispose() Implements IDisposable.Dispose
		' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
#End Region

End Class
