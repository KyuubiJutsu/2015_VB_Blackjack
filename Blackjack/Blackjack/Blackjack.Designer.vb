<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blackjack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(blackjack))
        Me.lblUserHand = New System.Windows.Forms.Label()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.lblUserScoreTitle = New System.Windows.Forms.Label()
        Me.lblUserScore = New System.Windows.Forms.Label()
        Me.lblCPUHand = New System.Windows.Forms.Label()
        Me.lblCPUScoreTitle = New System.Windows.Forms.Label()
        Me.lblCPUScore = New System.Windows.Forms.Label()
        Me.btnCheckScores = New System.Windows.Forms.Button()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblTies = New System.Windows.Forms.Label()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.btnResetBlackjack = New System.Windows.Forms.Button()
        Me.pbUserCard1 = New System.Windows.Forms.PictureBox()
        Me.pbUserCard2 = New System.Windows.Forms.PictureBox()
        Me.pbUserCard3 = New System.Windows.Forms.PictureBox()
        Me.pbUserCard4 = New System.Windows.Forms.PictureBox()
        Me.pbUserCard5 = New System.Windows.Forms.PictureBox()
        Me.pbUserCard6 = New System.Windows.Forms.PictureBox()
        Me.pbCPUCard1 = New System.Windows.Forms.PictureBox()
        Me.pbCPUCard2 = New System.Windows.Forms.PictureBox()
        Me.pbCPUCard3 = New System.Windows.Forms.PictureBox()
        Me.pbCPUCard4 = New System.Windows.Forms.PictureBox()
        Me.pbCPUCard5 = New System.Windows.Forms.PictureBox()
        Me.pbCPUCard6 = New System.Windows.Forms.PictureBox()
        Me.btnNewHand = New System.Windows.Forms.Button()
        CType(Me.pbUserCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserCard6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCPUCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCPUCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCPUCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCPUCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCPUCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCPUCard6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserHand
        '
        Me.lblUserHand.AutoSize = True
        Me.lblUserHand.BackColor = System.Drawing.Color.Transparent
        Me.lblUserHand.Font = New System.Drawing.Font("Zorque", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblUserHand.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblUserHand.Location = New System.Drawing.Point(43, 80)
        Me.lblUserHand.Name = "lblUserHand"
        Me.lblUserHand.Size = New System.Drawing.Size(241, 38)
        Me.lblUserHand.TabIndex = 0
        Me.lblUserHand.Text = "Player Hand"
        '
        'btnDraw
        '
        Me.btnDraw.Font = New System.Drawing.Font("Agency FB", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDraw.Location = New System.Drawing.Point(138, 12)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(120, 60)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "&Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'lblUserScoreTitle
        '
        Me.lblUserScoreTitle.AutoSize = True
        Me.lblUserScoreTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblUserScoreTitle.Font = New System.Drawing.Font("Zorque", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblUserScoreTitle.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblUserScoreTitle.Location = New System.Drawing.Point(729, 85)
        Me.lblUserScoreTitle.Name = "lblUserScoreTitle"
        Me.lblUserScoreTitle.Size = New System.Drawing.Size(253, 33)
        Me.lblUserScoreTitle.TabIndex = 2
        Me.lblUserScoreTitle.Text = "Player's Score:"
        '
        'lblUserScore
        '
        Me.lblUserScore.AutoSize = True
        Me.lblUserScore.BackColor = System.Drawing.Color.Transparent
        Me.lblUserScore.Font = New System.Drawing.Font("BankGothic Md BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserScore.ForeColor = System.Drawing.Color.Gold
        Me.lblUserScore.Location = New System.Drawing.Point(843, 146)
        Me.lblUserScore.Name = "lblUserScore"
        Me.lblUserScore.Size = New System.Drawing.Size(60, 50)
        Me.lblUserScore.TabIndex = 3
        Me.lblUserScore.Text = "0"
        '
        'lblCPUHand
        '
        Me.lblCPUHand.AutoSize = True
        Me.lblCPUHand.BackColor = System.Drawing.Color.Transparent
        Me.lblCPUHand.Font = New System.Drawing.Font("Zorque", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblCPUHand.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblCPUHand.Location = New System.Drawing.Point(43, 329)
        Me.lblCPUHand.Name = "lblCPUHand"
        Me.lblCPUHand.Size = New System.Drawing.Size(307, 38)
        Me.lblCPUHand.TabIndex = 4
        Me.lblCPUHand.Text = "Computer Hand"
        '
        'lblCPUScoreTitle
        '
        Me.lblCPUScoreTitle.AutoSize = True
        Me.lblCPUScoreTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCPUScoreTitle.Font = New System.Drawing.Font("Zorque", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblCPUScoreTitle.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCPUScoreTitle.Location = New System.Drawing.Point(675, 334)
        Me.lblCPUScoreTitle.Name = "lblCPUScoreTitle"
        Me.lblCPUScoreTitle.Size = New System.Drawing.Size(307, 33)
        Me.lblCPUScoreTitle.TabIndex = 5
        Me.lblCPUScoreTitle.Text = "Computer's Score:"
        '
        'lblCPUScore
        '
        Me.lblCPUScore.AutoSize = True
        Me.lblCPUScore.BackColor = System.Drawing.Color.Transparent
        Me.lblCPUScore.Font = New System.Drawing.Font("BankGothic Md BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUScore.ForeColor = System.Drawing.Color.Gold
        Me.lblCPUScore.Location = New System.Drawing.Point(843, 406)
        Me.lblCPUScore.Name = "lblCPUScore"
        Me.lblCPUScore.Size = New System.Drawing.Size(60, 50)
        Me.lblCPUScore.TabIndex = 6
        Me.lblCPUScore.Text = "0"
        '
        'btnCheckScores
        '
        Me.btnCheckScores.Enabled = False
        Me.btnCheckScores.Font = New System.Drawing.Font("Agency FB", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckScores.Location = New System.Drawing.Point(264, 12)
        Me.btnCheckScores.Name = "btnCheckScores"
        Me.btnCheckScores.Size = New System.Drawing.Size(140, 60)
        Me.btnCheckScores.TabIndex = 7
        Me.btnCheckScores.Text = "Check &Scores"
        Me.btnCheckScores.UseVisualStyleBackColor = True
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.BackColor = System.Drawing.Color.Transparent
        Me.lblWins.Font = New System.Drawing.Font("BankGothic Md BT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.ForeColor = System.Drawing.Color.Crimson
        Me.lblWins.Location = New System.Drawing.Point(232, 569)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(102, 22)
        Me.lblWins.TabIndex = 8
        Me.lblWins.Text = "Wins: 0"
        '
        'lblTies
        '
        Me.lblTies.AutoSize = True
        Me.lblTies.BackColor = System.Drawing.Color.Transparent
        Me.lblTies.Font = New System.Drawing.Font("BankGothic Md BT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTies.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblTies.Location = New System.Drawing.Point(446, 569)
        Me.lblTies.Name = "lblTies"
        Me.lblTies.Size = New System.Drawing.Size(94, 22)
        Me.lblTies.TabIndex = 9
        Me.lblTies.Text = "Ties: 0"
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.BackColor = System.Drawing.Color.Transparent
        Me.lblLosses.Font = New System.Drawing.Font("BankGothic Md BT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLosses.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLosses.Location = New System.Drawing.Point(621, 569)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(134, 22)
        Me.lblLosses.TabIndex = 10
        Me.lblLosses.Text = "Losses: 0"
        '
        'btnResetBlackjack
        '
        Me.btnResetBlackjack.Enabled = False
        Me.btnResetBlackjack.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetBlackjack.Location = New System.Drawing.Point(862, 550)
        Me.btnResetBlackjack.Name = "btnResetBlackjack"
        Me.btnResetBlackjack.Size = New System.Drawing.Size(120, 60)
        Me.btnResetBlackjack.TabIndex = 11
        Me.btnResetBlackjack.Text = "&Reset"
        Me.btnResetBlackjack.UseVisualStyleBackColor = True
        '
        'pbUserCard1
        '
        Me.pbUserCard1.BackColor = System.Drawing.Color.Transparent
        Me.pbUserCard1.Location = New System.Drawing.Point(67, 129)
        Me.pbUserCard1.Name = "pbUserCard1"
        Me.pbUserCard1.Size = New System.Drawing.Size(95, 130)
        Me.pbUserCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserCard1.TabIndex = 12
        Me.pbUserCard1.TabStop = False
        '
        'pbUserCard2
        '
        Me.pbUserCard2.BackColor = System.Drawing.Color.Transparent
        Me.pbUserCard2.Location = New System.Drawing.Point(168, 129)
        Me.pbUserCard2.Name = "pbUserCard2"
        Me.pbUserCard2.Size = New System.Drawing.Size(95, 130)
        Me.pbUserCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserCard2.TabIndex = 13
        Me.pbUserCard2.TabStop = False
        '
        'pbUserCard3
        '
        Me.pbUserCard3.BackColor = System.Drawing.Color.Transparent
        Me.pbUserCard3.Location = New System.Drawing.Point(269, 129)
        Me.pbUserCard3.Name = "pbUserCard3"
        Me.pbUserCard3.Size = New System.Drawing.Size(95, 130)
        Me.pbUserCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserCard3.TabIndex = 14
        Me.pbUserCard3.TabStop = False
        '
        'pbUserCard4
        '
        Me.pbUserCard4.BackColor = System.Drawing.Color.Transparent
        Me.pbUserCard4.Location = New System.Drawing.Point(370, 129)
        Me.pbUserCard4.Name = "pbUserCard4"
        Me.pbUserCard4.Size = New System.Drawing.Size(95, 130)
        Me.pbUserCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserCard4.TabIndex = 15
        Me.pbUserCard4.TabStop = False
        '
        'pbUserCard5
        '
        Me.pbUserCard5.BackColor = System.Drawing.Color.Transparent
        Me.pbUserCard5.Location = New System.Drawing.Point(471, 129)
        Me.pbUserCard5.Name = "pbUserCard5"
        Me.pbUserCard5.Size = New System.Drawing.Size(95, 130)
        Me.pbUserCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserCard5.TabIndex = 16
        Me.pbUserCard5.TabStop = False
        '
        'pbUserCard6
        '
        Me.pbUserCard6.BackColor = System.Drawing.Color.Transparent
        Me.pbUserCard6.Location = New System.Drawing.Point(572, 129)
        Me.pbUserCard6.Name = "pbUserCard6"
        Me.pbUserCard6.Size = New System.Drawing.Size(95, 130)
        Me.pbUserCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserCard6.TabIndex = 17
        Me.pbUserCard6.TabStop = False
        '
        'pbCPUCard1
        '
        Me.pbCPUCard1.BackColor = System.Drawing.Color.Transparent
        Me.pbCPUCard1.Location = New System.Drawing.Point(67, 384)
        Me.pbCPUCard1.Name = "pbCPUCard1"
        Me.pbCPUCard1.Size = New System.Drawing.Size(95, 130)
        Me.pbCPUCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCPUCard1.TabIndex = 19
        Me.pbCPUCard1.TabStop = False
        '
        'pbCPUCard2
        '
        Me.pbCPUCard2.BackColor = System.Drawing.Color.Transparent
        Me.pbCPUCard2.Location = New System.Drawing.Point(168, 384)
        Me.pbCPUCard2.Name = "pbCPUCard2"
        Me.pbCPUCard2.Size = New System.Drawing.Size(95, 130)
        Me.pbCPUCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCPUCard2.TabIndex = 20
        Me.pbCPUCard2.TabStop = False
        '
        'pbCPUCard3
        '
        Me.pbCPUCard3.BackColor = System.Drawing.Color.Transparent
        Me.pbCPUCard3.Location = New System.Drawing.Point(269, 384)
        Me.pbCPUCard3.Name = "pbCPUCard3"
        Me.pbCPUCard3.Size = New System.Drawing.Size(95, 130)
        Me.pbCPUCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCPUCard3.TabIndex = 21
        Me.pbCPUCard3.TabStop = False
        '
        'pbCPUCard4
        '
        Me.pbCPUCard4.BackColor = System.Drawing.Color.Transparent
        Me.pbCPUCard4.Location = New System.Drawing.Point(370, 384)
        Me.pbCPUCard4.Name = "pbCPUCard4"
        Me.pbCPUCard4.Size = New System.Drawing.Size(95, 130)
        Me.pbCPUCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCPUCard4.TabIndex = 22
        Me.pbCPUCard4.TabStop = False
        '
        'pbCPUCard5
        '
        Me.pbCPUCard5.BackColor = System.Drawing.Color.Transparent
        Me.pbCPUCard5.Location = New System.Drawing.Point(471, 384)
        Me.pbCPUCard5.Name = "pbCPUCard5"
        Me.pbCPUCard5.Size = New System.Drawing.Size(95, 130)
        Me.pbCPUCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCPUCard5.TabIndex = 23
        Me.pbCPUCard5.TabStop = False
        '
        'pbCPUCard6
        '
        Me.pbCPUCard6.BackColor = System.Drawing.Color.Transparent
        Me.pbCPUCard6.Location = New System.Drawing.Point(572, 384)
        Me.pbCPUCard6.Name = "pbCPUCard6"
        Me.pbCPUCard6.Size = New System.Drawing.Size(95, 130)
        Me.pbCPUCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCPUCard6.TabIndex = 24
        Me.pbCPUCard6.TabStop = False
        '
        'btnNewHand
        '
        Me.btnNewHand.Enabled = False
        Me.btnNewHand.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewHand.Location = New System.Drawing.Point(12, 12)
        Me.btnNewHand.Name = "btnNewHand"
        Me.btnNewHand.Size = New System.Drawing.Size(120, 60)
        Me.btnNewHand.TabIndex = 25
        Me.btnNewHand.Text = "New H&and"
        Me.btnNewHand.UseVisualStyleBackColor = True
        '
        'blackjack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 622)
        Me.Controls.Add(Me.btnNewHand)
        Me.Controls.Add(Me.pbCPUCard6)
        Me.Controls.Add(Me.pbCPUCard5)
        Me.Controls.Add(Me.pbCPUCard4)
        Me.Controls.Add(Me.pbCPUCard3)
        Me.Controls.Add(Me.pbCPUCard2)
        Me.Controls.Add(Me.pbCPUCard1)
        Me.Controls.Add(Me.pbUserCard6)
        Me.Controls.Add(Me.pbUserCard5)
        Me.Controls.Add(Me.pbUserCard4)
        Me.Controls.Add(Me.pbUserCard3)
        Me.Controls.Add(Me.pbUserCard2)
        Me.Controls.Add(Me.pbUserCard1)
        Me.Controls.Add(Me.btnResetBlackjack)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.lblTies)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.btnCheckScores)
        Me.Controls.Add(Me.lblCPUScore)
        Me.Controls.Add(Me.lblCPUScoreTitle)
        Me.Controls.Add(Me.lblCPUHand)
        Me.Controls.Add(Me.lblUserScore)
        Me.Controls.Add(Me.lblUserScoreTitle)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.lblUserHand)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1010, 660)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1010, 660)
        Me.Name = "blackjack"
        Me.Text = "Blackjack"
        CType(Me.pbUserCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserCard6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCPUCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCPUCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCPUCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCPUCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCPUCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCPUCard6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserHand As System.Windows.Forms.Label
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    Friend WithEvents lblUserScoreTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserScore As System.Windows.Forms.Label
    Friend WithEvents lblCPUHand As System.Windows.Forms.Label
    Friend WithEvents lblCPUScoreTitle As System.Windows.Forms.Label
    Friend WithEvents lblCPUScore As System.Windows.Forms.Label
    Friend WithEvents btnCheckScores As System.Windows.Forms.Button
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents lblTies As System.Windows.Forms.Label
    Friend WithEvents lblLosses As System.Windows.Forms.Label
    Friend WithEvents btnResetBlackjack As System.Windows.Forms.Button
    Friend WithEvents pbUserCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbUserCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbUserCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbUserCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbUserCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbUserCard6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCPUCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCPUCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCPUCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCPUCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCPUCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCPUCard6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNewHand As System.Windows.Forms.Button

End Class
