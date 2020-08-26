
Imports Microsoft.Win32

Public Class inicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub runmru_Click(sender As Object, e As EventArgs) Handles runmru.Click
        Dim v As Visualizacion = New Visualizacion(0)
        v.Show()
    End Sub

    Private Sub prefetch_Click(sender As Object, e As EventArgs) Handles prefetch.Click
        Process.Start("explorer.exe", String.Format("/n, /e, {0}", "C:\Windows\Prefetch"))
    End Sub

    Private Sub minecraft_Click(sender As Object, e As EventArgs) Handles minecraft.Click
        Process.Start("explorer.exe", String.Format("/n, /e, {0}", "C:\Users\mmtbp\AppData\Roaming\.minecraft"))

    End Sub

    Private Sub temp_Click(sender As Object, e As EventArgs) Handles temp.Click
        Process.Start("explorer.exe", String.Format("/n, /e, {0}", "C:\Users\mmtbp\AppData\Local\Temp"))
    End Sub

    Private Sub opensavedpid_Click(sender As Object, e As EventArgs) Handles opensavedpid.Click
        Dim v As Visualizacion = New Visualizacion(1)
        v.Show()
    End Sub

    Private Sub lastvisitedpid_Click(sender As Object, e As EventArgs) Handles lastvisitedpid.Click
        Dim v As Visualizacion = New Visualizacion(2)
        v.Show()
    End Sub

    Private Sub recentdocs_Click(sender As Object, e As EventArgs) Handles recentdocs.Click
        Dim v As Visualizacion = New Visualizacion(3)
        v.Show()
    End Sub

    Private Sub muicache_Click(sender As Object, e As EventArgs) Handles muicache.Click
        Dim v As Visualizacion = New Visualizacion(4)
        v.Show()
    End Sub

    Private Sub btnadap_Click(sender As Object, e As EventArgs) Handles btnadap.Click

        Dim registryLocation = "Equipo\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters"
        Dim registryLastKey = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit"

        Registry.SetValue(registryLastKey, "LastKey", registryLocation)
        For Each p As Process In Process.GetProcessesByName("regedit")
            p.Kill()
        Next
        Process.Start("regedit.exe")
    End Sub
End Class
