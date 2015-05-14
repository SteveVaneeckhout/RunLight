Public Class Runner
	Private _bStop, _bStopHigh As Boolean
	Private t, u As Threading.Thread
	Private _bUniverseData() As Byte
	Private _oSyncObject As Object

	Public Sub New()
		_oSyncObject = New Object
	End Sub

	Public Sub Start()
		_bStop = False
		Debug.WriteLine("Runner Started")

		t = New Threading.Thread(AddressOf Statesender)
		t.Start()
	End Sub

	Private Sub Statesender()
		Dim sps As New SerialPortSender()

		While Not _bStop
			SyncLock _oSyncObject
				sps.Send(_bUniverseData)
			End SyncLock
		End While

		sps.Dispose()
		Debug.WriteLine("Runner stopped")
	End Sub

	Public Sub [Stop]()
		Debug.WriteLine("Runner stopping")
		_bStop = True
	End Sub

	Public WriteOnly Property UniverseData() As Byte()
		Set(ByVal value As Byte())
			SyncLock _oSyncObject
				_bUniverseData = value
			End SyncLock
		End Set
	End Property
End Class
