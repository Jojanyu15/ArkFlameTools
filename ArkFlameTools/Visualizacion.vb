
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Public Class Visualizacion

    Private Declare Function FileTimeToSystemTime Lib "kernel32" _
           (ByRef lpFileTime As FILETIME, ByRef lpSystemTime As SYSTEMTIME) As Integer

    Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal Hkey As Integer) As Integer

    Private Declare Function RegOpenKeyEx Lib "advapi32.dll" Alias "RegOpenKeyExA" _
           (ByVal Hkey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer,
           ByRef phkResult As Integer) As Integer

    Private Declare Function RegQueryInfoKey Lib "advapi32.dll" Alias "RegQueryInfoKeyA" _
           (ByVal Hkey As Integer, ByVal lpClass As String, ByRef lpcbClass As Integer, ByVal lpReserved As Integer,
           ByRef lpcSubKeys As Integer, ByRef lpcbMaxSubKeyLen As Integer, ByRef lpcbMaxClassLen As Integer,
           ByRef lpcValues As Integer, ByRef lpcbMaxValueNameLen As Integer, ByRef lpcbMaxValueLen As Integer,
           ByRef lpcbSecurityDescriptor As Integer, ByRef lpftLastWriteTime As FILETIME) As Integer

    Private Structure FILETIME
        Dim dwLowDateTime As Integer
        Dim dwHighDateTime As Integer
    End Structure

    Private Structure SYSTEMTIME
        Dim wYear As Short
        Dim wMonth As Short
        Dim wDayOfWeek As Short
        Dim wDay As Short
        Dim wHour As Short
        Dim wMinute As Short
        Dim wSecond As Short
        Dim wMilliseconds As Short
    End Structure

    Private Const KEY_QUERY_VALUE As Integer = &H1
    Private Const ERROR_SUCCESS As Short = 0
    Public Const HKEY_CLASSES_ROOT As Integer = &H80000000
    Public Const HKEY_LOCAL_MACHINE As Integer = &H80000002
    Public Const HKEY_CURRENT_USER As Integer = &H80000001


    Public Function Reg__QueryInfoKey(ByRef lngHKey As Integer, ByRef strSubKey As String) As String

        Dim intKeyHandle As Integer
        Dim intRetVal As Integer
        Dim typFT As FILETIME
        Dim returned As String
        'Open registry key
        intRetVal = RegOpenKeyEx(lngHKey, strSubKey, 0, KEY_QUERY_VALUE, intKeyHandle)
        If intRetVal = ERROR_SUCCESS Then
            'Collect information
            intRetVal = RegQueryInfoKey(intKeyHandle, vbNullString, 0, 0, 0, 0, 0, 0, 0, 0, 0, typFT) = ERROR_SUCCESS
        End If
        'Output...
        If intRetVal = True Then 'VB6 = 0, NET = -1
            returned = FileTimeToDate(typFT).ToString

            '  MsgBox("Last Write Time: " & FileTimeToDate(typFT))
        Else
            returned = "Error"

            ' MsgBox("Error number: " & intRetVal)
        End If

        'Close any key opened with RegOpenKeyEx.
        Call RegCloseKey(intKeyHandle)
        Return returned
    End Function

    Private Function FileTimeToDate(ByRef File_Time As FILETIME) As Date
        'Convert the FILETIME structure into a Date.
        Dim System_Time As SYSTEMTIME

        'Convert the FILETIME into a SYSTEMTIME...
        Call FileTimeToSystemTime(File_Time, System_Time)
        'Convert a SYSTEMTIME into a Date...
        With System_Time
            FileTimeToDate = .wDay & "/" & .wMonth & "/" & .wYear & " " & .wHour & ":" & .wMinute & ":" & .wSecond
        End With
    End Function

    Private type As Integer

    Public Sub New(ByVal t As Integer)
        InitializeComponent()
        type = t
    End Sub


    Private Sub Visualizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list = New List(Of RegistryData)
        Select Case type
            Case 0
                label.Text = "DATOS EN RUNMRU"
                '    Dim x = retornar()
                '  Debug.Print(x)
                Dim subk = "Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU"
                Dim fecha = Reg__QueryInfoKey(HKEY_CURRENT_USER, subk)
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey(subk)
                For Each dataName In FontKey.GetValueNames()
                    Dim nombre As Object = FontKey.GetValue(dataName)
                    If nombre IsNot Nothing Then

                        regtable.Rows.Add(fecha, nombre.ToString)

                        '    list.Add(New RegistryData(nombre.ToString, nombre.ToString))
                    End If
                Next
                '   regtable.DataSource = list
                FontKey.Close()


            Case 1
                label.Text = "DATOS EN Open Saved Pidl Mru (archivos abiertos sospechosos con extension .exe , .dll, .jar, .bat etc...)"
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\OpenSavePidlMRU")


                For Each dataName In FontKey.GetSubKeyNames()
                    If dataName.Equals("exe") Or dataName.Equals("bat") Or dataName.Equals("dll") Or dataName.Equals("jar") Or dataName.Equals("rar") Or dataName.Equals("zip") Then
                        Dim subk = "Software\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\OpenSavePidlMRU\" + dataName
                        Dim fecha = Reg__QueryInfoKey(HKEY_CURRENT_USER, subk)
                        Dim auxKey = My.Computer.Registry.CurrentUser.OpenSubKey(subk)
                        For Each auxName In auxKey.GetValueNames()
                            Dim s As String = ""
                            Dim nombre As Byte() = auxKey.GetValue(auxName)
                            Dim x = auxKey.GetValue(auxName).ToString


                            Dim Binary As Byte() = auxKey.GetValue(auxName)

                            For i = 0 To nombre.Count - 1
                                s &= Format(nombre(i), "X2") & " "
                            Next
                            Dim resultado = hexConverter(s)

                            If Not resultado.Equals(" ") Then

                                regtable.Rows.Add(fecha, resultado.Substring(8))
                            End If
                        Next
                        auxKey.Close()

                    End If

                Next
                FontKey.Close()

                '--------------------------------------------------------------------------'

            Case 2

                label.Text = "DATOS EN LastVisitedPidlMRU"
                Dim subk = "Software\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\LastVisitedPidlMRU"
                Dim fecha = Reg__QueryInfoKey(HKEY_CURRENT_USER, subk)
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey(subk)
                For Each dataName In FontKey.GetValueNames()
                    Dim s As String = ""
                    Dim nombre As Byte() = FontKey.GetValue(dataName)
                    Dim x = FontKey.GetValue(dataName).ToString


                    Dim Binary As Byte() = FontKey.GetValue(dataName)

                    For i = 0 To nombre.Count - 1
                        s &= Format(nombre(i), "X2") & " "
                    Next
                    Dim resultado = hexConverter(s)
                    If Not resultado.Equals(" ") Then
                        Try
                            Dim puntero = resultado.IndexOf(".")
                            regtable.Rows.Add(fecha, resultado.Substring(0, (puntero + 4)))
                        Catch ex As Exception
                            regtable.Rows.Add(fecha, resultado)
                        End Try

                        ' list.Add(New RegistryData(hexConverter(s), hexConverter(s)))
                    End If
                Next

                'regtable.DataSource = list
                FontKey.Close()

            Case 3
                label.Text = "DATOS EN RecentDocs (Documentos abiertos recientemente)"
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs")


                For Each dataName In FontKey.GetSubKeyNames()
                    If dataName.Equals(".exe") Or dataName.Equals(".bat") Or dataName.Equals(".dll") Or dataName.Equals(".jar") Or dataName.Equals(".rar") Or dataName.Equals(".zip") Or dataName.Equals(".txt") Then
                        Dim subk = "Software\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs\" + dataName
                        Dim auxKey = My.Computer.Registry.CurrentUser.OpenSubKey(subk)
                        label.Text = "DATOS EN LastVisitedPidlMRU"
                        Dim fecha = Reg__QueryInfoKey(HKEY_CURRENT_USER, subk)
                        For Each auxName In auxKey.GetValueNames()

                            Dim s As String = ""
                            Dim nombre As Byte() = auxKey.GetValue(auxName)
                            Dim x = auxKey.GetValue(auxName).ToString


                            Dim Binary As Byte() = auxKey.GetValue(auxName)

                            For i = 0 To nombre.Count - 1
                                s &= Format(nombre(i), "X2") & " "
                            Next
                            Dim resultado = hexConverter(s)
                            If Not resultado.Equals(" ") Then

                                regtable.Rows.Add(fecha, resultado)
                            End If
                        Next
                        auxKey.Close()
                    End If
                Next
                FontKey.Close()
            Case 4
                label.Text = "DATOS EN MUICACHE"
                Dim subk = "Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache"
                Dim fecha = Reg__QueryInfoKey(HKEY_CURRENT_USER, subk)
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey(subk)
                For Each dataName In FontKey.GetValueNames()
                    If dataName IsNot Nothing Then
                        regtable.Rows.Add(fecha, dataName.ToString)

                    End If
                Next
                '   regtable.DataSource = list
                FontKey.Close()
            Case Else

        End Select


    End Sub


    Public Function hexConverter(text) As String
        Dim com As String = " "
        Dim arregloHex() As String = Split(text)
        For i As Integer = 0 To (arregloHex.Length - 2)

            Dim entero = Convert.ToByte(arregloHex(i), 16)
            If entero >= 33 And entero <= 127 And entero <> 38 And entero <> 37 Then
                Dim ASCII_value = Convert.ToChar(Convert.ToUInt32(arregloHex(i), 16))
                com &= ASCII_value

            End If

        Next


        Return com
    End Function

End Class