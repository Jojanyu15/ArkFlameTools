<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.runmru = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnadap = New System.Windows.Forms.Button()
        Me.muicache = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.recentdocs = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lastvisitedpid = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.opensavedpid = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.temp = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.minecraft = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.prefetch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'runmru
        '
        Me.runmru.Location = New System.Drawing.Point(15, 87)
        Me.runmru.Name = "runmru"
        Me.runmru.Size = New System.Drawing.Size(140, 36)
        Me.runmru.TabIndex = 1
        Me.runmru.Text = "RunMRU"
        Me.runmru.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RunMRU (Comandos ejecutados " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """regedit, appdata entre otros"")."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnadap)
        Me.GroupBox1.Controls.Add(Me.muicache)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.recentdocs)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lastvisitedpid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.opensavedpid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.runmru)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 274)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRADAS DE REGISTRO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(366, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 65)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Adaptadores (aqui puedes encontrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "las modificaciones en regedit ilegales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "impor" &
    "tante ver adaptadores y cada una" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de las interfaces" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnadap
        '
        Me.btnadap.Location = New System.Drawing.Point(357, 223)
        Me.btnadap.Name = "btnadap"
        Me.btnadap.Size = New System.Drawing.Size(184, 36)
        Me.btnadap.TabIndex = 11
        Me.btnadap.Text = "Adaptadores"
        Me.btnadap.UseVisualStyleBackColor = True
        '
        'muicache
        '
        Me.muicache.Location = New System.Drawing.Point(191, 223)
        Me.muicache.Name = "muicache"
        Me.muicache.Size = New System.Drawing.Size(140, 36)
        Me.muicache.TabIndex = 9
        Me.muicache.Text = "Mui Cache"
        Me.muicache.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 39)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "MuiCache(En esta clave se " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "almacenan las últimas aplicaciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ".EXE ejecutadas e" &
    "n el equipo.)"
        '
        'recentdocs
        '
        Me.recentdocs.Location = New System.Drawing.Point(15, 223)
        Me.recentdocs.Name = "recentdocs"
        Me.recentdocs.Size = New System.Drawing.Size(140, 36)
        Me.recentdocs.TabIndex = 7
        Me.recentdocs.Text = "Recent Docs"
        Me.recentdocs.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 65)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RecentDocs (Buscando aquí " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se puede conocer la ubicación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exacta donde otras per" &
    "sonas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "han guardado sus documentos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "recientemente)"
        '
        'lastvisitedpid
        '
        Me.lastvisitedpid.Location = New System.Drawing.Point(357, 87)
        Me.lastvisitedpid.Name = "lastvisitedpid"
        Me.lastvisitedpid.Size = New System.Drawing.Size(184, 36)
        Me.lastvisitedpid.TabIndex = 5
        Me.lastvisitedpid.Text = "LastVisitedPidlMRU"
        Me.lastvisitedpid.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 52)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LastVisitedPidlMRU(Similar a la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "anterior  en este registro se almacenan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los d" &
    "atos de claves abiertas y guardadas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "recientemente."
        '
        'opensavedpid
        '
        Me.opensavedpid.Location = New System.Drawing.Point(187, 87)
        Me.opensavedpid.Name = "opensavedpid"
        Me.opensavedpid.Size = New System.Drawing.Size(140, 36)
        Me.opensavedpid.TabIndex = 3
        Me.opensavedpid.Text = "OpenSavePidlMRU"
        Me.opensavedpid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 52)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OpenSavePidlMRU (Archivos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ordenados por extensión de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " todo lo que se ha abierto" &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o guardado)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.temp)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.minecraft)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.prefetch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 167)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCESO RÁPIDO"
        '
        'temp
        '
        Me.temp.Cursor = System.Windows.Forms.Cursors.Default
        Me.temp.Location = New System.Drawing.Point(361, 82)
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(140, 36)
        Me.temp.TabIndex = 13
        Me.temp.Text = "Temp"
        Me.temp.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(358, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 65)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Temp (Carpeta que contiene" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los archivos temporales del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sistema)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'minecraft
        '
        Me.minecraft.Cursor = System.Windows.Forms.Cursors.Default
        Me.minecraft.Location = New System.Drawing.Point(187, 82)
        Me.minecraft.Name = "minecraft"
        Me.minecraft.Size = New System.Drawing.Size(140, 36)
        Me.minecraft.TabIndex = 11
        Me.minecraft.Text = ".Minecraft"
        Me.minecraft.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(188, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Carpeta .Minecraft" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'prefetch
        '
        Me.prefetch.Location = New System.Drawing.Point(15, 82)
        Me.prefetch.Name = "prefetch"
        Me.prefetch.Size = New System.Drawing.Size(140, 36)
        Me.prefetch.TabIndex = 9
        Me.prefetch.Text = "Prefetch"
        Me.prefetch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 39)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "PREFETCH (Carpeta cacheada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "con las aplicaciones abiertas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "recientemente)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 521)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "inicio"
        Me.Text = "ArkSsTools by Jojanyu and QXTH"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents runmru As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents muicache As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents recentdocs As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lastvisitedpid As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents opensavedpid As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents prefetch As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents temp As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents minecraft As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnadap As Button
End Class
