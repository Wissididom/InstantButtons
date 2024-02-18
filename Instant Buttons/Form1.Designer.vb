<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cb_alphabet = New System.Windows.Forms.ComboBox()
        Me.cb_name = New System.Windows.Forms.ComboBox()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BefehleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pause2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_alphabet
        '
        Me.cb_alphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_alphabet.FormattingEnabled = True
        Me.cb_alphabet.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "#"})
        Me.cb_alphabet.Location = New System.Drawing.Point(12, 12)
        Me.cb_alphabet.Name = "cb_alphabet"
        Me.cb_alphabet.Size = New System.Drawing.Size(36, 21)
        Me.cb_alphabet.TabIndex = 0
        '
        'cb_name
        '
        Me.cb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_name.FormattingEnabled = True
        Me.cb_name.Location = New System.Drawing.Point(54, 12)
        Me.cb_name.Name = "cb_name"
        Me.cb_name.Size = New System.Drawing.Size(294, 21)
        Me.cb_name.TabIndex = 1
        '
        'btn_play
        '
        Me.btn_play.Location = New System.Drawing.Point(61, 39)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(75, 23)
        Me.btn_play.TabIndex = 2
        Me.btn_play.Text = "abspielen"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_end.Location = New System.Drawing.Point(142, 39)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 23)
        Me.btn_end.TabIndex = 3
        Me.btn_end.Text = "beenden"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(224, 39)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "speichern"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(306, 39)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(75, 23)
        Me.Player.TabIndex = 6
        Me.Player.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BefehleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Visible = False
        '
        'BefehleToolStripMenuItem
        '
        Me.BefehleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResumeToolStripMenuItem, Me.StopToolStripMenuItem, Me.Pause2ToolStripMenuItem})
        Me.BefehleToolStripMenuItem.Name = "BefehleToolStripMenuItem"
        Me.BefehleToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.BefehleToolStripMenuItem.Text = "Befehle"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Pause), System.Windows.Forms.Keys)
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'ResumeToolStripMenuItem
        '
        Me.ResumeToolStripMenuItem.Name = "ResumeToolStripMenuItem"
        Me.ResumeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResumeToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ResumeToolStripMenuItem.Text = "Resume"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'Pause2ToolStripMenuItem
        '
        Me.Pause2ToolStripMenuItem.Name = "Pause2ToolStripMenuItem"
        Me.Pause2ToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Pause2ToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.Pause2ToolStripMenuItem.Text = "Pause2"
        '
        'Form1
        '
        Me.AcceptButton = Me.btn_play
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_end
        Me.ClientSize = New System.Drawing.Size(360, 74)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.cb_name)
        Me.Controls.Add(Me.cb_alphabet)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instant Buttons"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_alphabet As System.Windows.Forms.ComboBox
    Friend WithEvents cb_name As System.Windows.Forms.ComboBox
    Friend WithEvents btn_play As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BefehleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pause2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
