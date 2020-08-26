

Public Class Visualizacion
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
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU")
                For Each dataName In FontKey.GetValueNames()
                    Dim nombre As Object = FontKey.GetValue(dataName)
                    If nombre IsNot Nothing Then
                        regtable.Rows.Add(nombre.ToString, nombre.ToString)

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
                        Dim auxKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\OpenSavePidlMRU\" + dataName)
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

                                regtable.Rows.Add(resultado, resultado.Substring(8))
                            End If
                        Next
                        auxKey.Close()

                    End If

                Next
                FontKey.Close()

                '--------------------------------------------------------------------------'

            Case 2

                label.Text = "DATOS EN LastVisitedPidlMRU"
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\LastVisitedPidlMRU")
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
                            regtable.Rows.Add(resultado, resultado.Substring(0, (puntero + 4)))
                        Catch ex As Exception
                            regtable.Rows.Add(resultado, resultado)
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
                        Dim auxKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs\" + dataName)
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

                                regtable.Rows.Add(resultado, resultado)
                            End If
                        Next
                        auxKey.Close()
                    End If
                Next
                FontKey.Close()
            Case 4
                label.Text = "DATOS EN MUICACHE"
                Dim FontKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache")
                For Each dataName In FontKey.GetValueNames()
                    If dataName IsNot Nothing Then
                        regtable.Rows.Add(dataName.ToString, dataName.ToString)

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