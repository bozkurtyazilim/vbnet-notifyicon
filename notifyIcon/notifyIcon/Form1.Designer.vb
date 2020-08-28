<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProgramıGösterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramıGizleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemTepsisindeSaklaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Bozkurt Yazılım Uygulaması"
        Me.NotifyIcon1.Visible = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sistem Tepsisinde Gizle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Güncelle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramıGösterToolStripMenuItem, Me.ProgramıGizleToolStripMenuItem, Me.AyarlarToolStripMenuItem, Me.SistemTepsisindeSaklaToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(197, 136)
        '
        'ProgramıGösterToolStripMenuItem
        '
        Me.ProgramıGösterToolStripMenuItem.Name = "ProgramıGösterToolStripMenuItem"
        Me.ProgramıGösterToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ProgramıGösterToolStripMenuItem.Text = "Programı Göster"
        '
        'ProgramıGizleToolStripMenuItem
        '
        Me.ProgramıGizleToolStripMenuItem.Name = "ProgramıGizleToolStripMenuItem"
        Me.ProgramıGizleToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ProgramıGizleToolStripMenuItem.Text = "Programı Gizle"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AyarlarToolStripMenuItem.Text = "Ayarlar"
        '
        'SistemTepsisindeSaklaToolStripMenuItem
        '
        Me.SistemTepsisindeSaklaToolStripMenuItem.Name = "SistemTepsisindeSaklaToolStripMenuItem"
        Me.SistemTepsisindeSaklaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SistemTepsisindeSaklaToolStripMenuItem.Text = "Sistem Tepsisinde Sakla"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 288)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ProgramıGösterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramıGizleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyarlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemTepsisindeSaklaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
End Class
