
Imports System.IO
Imports Microsoft.Win32

Public Class inicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        Application.Exit()
        End
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

    Private Sub regscanner_Click(sender As Object, e As EventArgs) Handles regscanner.Click
        Dim SetupPath As String = Application.StartupPath & "\regscan.exe"
        Try
            For Each p As Process In Process.GetProcessesByName("regscan")
                p.Kill()
            Next
            Using sCreateMSIFile As New FileStream(SetupPath, FileMode.Create)
                sCreateMSIFile.Write(My.Resources.RegScanner, 0, My.Resources.RegScanner.Length)
                sCreateMSIFile.Close()
            End Using
            Process.Start(SetupPath)
        Catch ex As Exception
            Process.Start(My.Computer.FileSystem.CurrentDirectory + "\regscan.exe")
        End Try

    End Sub

    Private Sub everything_Click(sender As Object, e As EventArgs) Handles everything.Click
        Dim SetupPath As String = Application.StartupPath & "\sseverything.exe"

        Try
            For Each p As Process In Process.GetProcessesByName("sseverything")
                p.Kill()
            Next
            Using sCreateMSIFile As New FileStream(SetupPath, FileMode.Create)
                sCreateMSIFile.Write(My.Resources.Everything, 0, My.Resources.Everything.Length)
                sCreateMSIFile.Close()
            End Using
            Process.Start(SetupPath)

        Catch ex As Exception
            Process.Start(My.Computer.FileSystem.CurrentDirectory + "\sseverything.exe")
        End Try



    End Sub

    Private Sub process_Click(sender As Object, e As EventArgs) Handles processh.Click
        Dim SetupPath As String = Application.StartupPath & "\processhacker.exe"
        Try
            For Each p As Process In Process.GetProcessesByName("processhacker")
                p.Kill()
            Next
            Using sCreateMSIFile As New FileStream(SetupPath, FileMode.Create)
                sCreateMSIFile.Write(My.Resources.ProcessHacker, 0, My.Resources.ProcessHacker.Length)
                sCreateMSIFile.Close()
            End Using
            Process.Start(SetupPath)

        Catch ex As Exception
            Process.Start(My.Computer.FileSystem.CurrentDirectory + "\processhacker.exe")
        End Try
    End Sub

    Private Sub lastactivity_Click(sender As Object, e As EventArgs) Handles lastactivity.Click
        Dim SetupPath As String = Application.StartupPath & "\lastactivity.exe"
        Try
            For Each p As Process In Process.GetProcessesByName("lastactivity")
                p.Kill()
            Next
            Using sCreateMSIFile As New FileStream(SetupPath, FileMode.Create)
                sCreateMSIFile.Write(My.Resources.LastActivityView, 0, My.Resources.LastActivityView.Length)
                sCreateMSIFile.Close()
            End Using
            Process.Start(SetupPath)
        Catch ex As Exception
            Process.Start(My.Computer.FileSystem.CurrentDirectory + "\lastactivity.exe")
        End Try


    End Sub
End Class
