Public Class blackjack
    'Mitchell Van Braeckel
    '13/04/2015
    'plays the card game blackjack with full graphic display and keeps track of score against the computer

    'INPUT
    '=====
    'Draw Button - Click the button to get another card
    'Check Scores Button - Click the buttion to end the game and see who wins (also displays computer's score)
    'New Game (Reset) Button - Restarts the game =-= clears everything
    'New Hand Button - Restarts the game =-= clears everything *except the WW/TT/LL record

    'PROCESSING
    '======
    'Draw Button - (give another card to player) generates a random number and displays the corresponding card in the appropriate picture box for the player and computer hand
    '       updates the score for both player and computer according to card value
    'Check Scores Button - sums up the score for the player and computer based on the value of cards in their hand
    '       reveals other max 6 cards of computers hand -=- smart drawing method for comp/dealer
    '       displays a message declaring who won the game and updates the WW/TT/LL labels appropriately
    '       disables use of Draw Button & Check Scores Button
    'New Game (Reset) Button - restarts the game =-= clears everything & generate new random numbers
    'New Hand Button - Restarts the game =-= clears everything
    '       ***except the WW/TT/LL record

    'OUTPUT
    '======
    'Max of 6 Card Spaces - Picture boxes that display the player's cards/hand
    'Max of 6 Card Spaces - Picture boxes that display the computer's cards/hand
    'Player's Score & Computer's Score - Showed in labels to user
    'Wins & Ties & Losses - Showed in labels to user
    'Message Box to declare winner of game
    'Message Box to declare that the user has become a master of the game

    'card variables as images
    Dim backCard As Image

    'spade suit card variables as images
    Dim spadeAce As Image
    Dim spade2 As Image
    Dim spade3 As Image
    Dim spade4 As Image
    Dim spade5 As Image
    Dim spade6 As Image
    Dim spade7 As Image
    Dim spade8 As Image
    Dim spade9 As Image
    Dim spade10 As Image
    Dim spadeJack As Image
    Dim spadeQueen As Image
    Dim spadeKing As Image

    'variable to generate random #s
    Dim pCard1 As Integer
    Dim pCard2 As Integer
    Dim pCard3 As Integer
    Dim pCard4 As Integer
    Dim pCard5 As Integer
    Dim pCard6 As Integer
    Dim cCard1 As Integer
    Dim cCard2 As Integer
    Dim cCard3 As Integer
    Dim cCard4 As Integer
    Dim cCard5 As Integer
    Dim cCard6 As Integer

    'counts the # of drawn cards
    Dim draw As Integer = 0

    'variable to track player and comp score
    Dim playerScore As Integer
    Dim compScore As Integer

    'variable to track WW/TT/LL record
    Dim wins As Integer = 0
    Dim ties As Integer = 0
    Dim losses As Integer = 0
    '.

    Private Sub blackjack_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'truly randomizes # generation
        Randomize()

        'give card image to each card
        spadeAce = Image.FromFile("ace_of_spades.png")
        spade2 = Image.FromFile("2_of_spades.png")
        spade3 = Image.FromFile("3_of_spades.png")
        spade4 = Image.FromFile("4_of_spades.png")
        spade5 = Image.FromFile("5_of_spades.png")
        spade6 = Image.FromFile("6_of_spades.png")
        spade7 = Image.FromFile("7_of_spades.png")
        spade8 = Image.FromFile("8_of_spades.png")
        spade9 = Image.FromFile("9_of_spades.png")
        spade10 = Image.FromFile("10_of_spades.png")
        spadeJack = Image.FromFile("jack_of_spades.png")
        spadeQueen = Image.FromFile("queen_of_spades.png")
        spadeKing = Image.FromFile("king_of_spades.png")
        backCard = Image.FromFile("back.png")

        'displays rules to the player upon load
        MessageBox.Show("The object of the game is to accumulate cards with point totals as close to 21 without going over 21.  Face cards (Jacks, Queens and Kings) are worth 10 points.  " &
                        "Aces are worth 1 or 11, whichever is preferable by situation (you cannot choose to bust using the higher value of an ace). Other cards are represented by their number.  A player may stand at any time.  " &
                        "To win, you need to beat the dealer without busting.  You bust when your cards total to more than 21 and you lose automatically.  " &
                        "The winner is whoever has closest to a total of 21.  You reach 21 by adding up the values of the cards.  Your goal is to become a master of the game through great wins over the dealer.", "Welcome to Blackjack")
    End Sub

    Private Sub btnDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraw.Click
        'draw cards when pressed
        If draw = 0 Then
            'player draws first card
            pCard1 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If pCard1 = 1 Then
                pbUserCard1.Image = spadeAce
            ElseIf pCard1 = 2 Then
                pbUserCard1.Image = spade2
            ElseIf pCard1 = 3 Then
                pbUserCard1.Image = spade3
            ElseIf pCard1 = 4 Then
                pbUserCard1.Image = spade4
            ElseIf pCard1 = 5 Then
                pbUserCard1.Image = spade5
            ElseIf pCard1 = 6 Then
                pbUserCard1.Image = spade6
            ElseIf pCard1 = 7 Then
                pbUserCard1.Image = spade7
            ElseIf pCard1 = 8 Then
                pbUserCard1.Image = spade8
            ElseIf pCard1 = 9 Then
                pbUserCard1.Image = spade9
            ElseIf pCard1 = 10 Then
                pbUserCard1.Image = spade10
            ElseIf pCard1 = 11 Then
                pbUserCard1.Image = spadeJack
            ElseIf pCard1 = 12 Then
                pbUserCard1.Image = spadeQueen
            ElseIf pCard1 = 13 Then
                pbUserCard1.Image = spadeKing
            End If

            'comp draws first card
            cCard1 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If cCard1 = 1 Then
                pbCPUCard1.Image = spadeAce
            ElseIf cCard1 = 2 Then
                pbCPUCard1.Image = spade2
            ElseIf cCard1 = 3 Then
                pbCPUCard1.Image = spade3
            ElseIf cCard1 = 4 Then
                pbCPUCard1.Image = spade4
            ElseIf cCard1 = 5 Then
                pbCPUCard1.Image = spade5
            ElseIf cCard1 = 6 Then
                pbCPUCard1.Image = spade6
            ElseIf cCard1 = 7 Then
                pbCPUCard1.Image = spade7
            ElseIf cCard1 = 8 Then
                pbCPUCard1.Image = spade8
            ElseIf cCard1 = 9 Then
                pbCPUCard1.Image = spade9
            ElseIf cCard1 = 10 Then
                pbCPUCard1.Image = spade10
            ElseIf cCard1 = 11 Then
                pbCPUCard1.Image = spadeJack
            ElseIf cCard1 = 12 Then
                pbCPUCard1.Image = spadeQueen
            ElseIf cCard1 = 13 Then
                pbCPUCard1.Image = spadeKing
            End If

            'player draws second card
            pCard2 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If pCard2 = 1 Then
                pbUserCard2.Image = spadeAce
            ElseIf pCard2 = 2 Then
                pbUserCard2.Image = spade2
            ElseIf pCard2 = 3 Then
                pbUserCard2.Image = spade3
            ElseIf pCard2 = 4 Then
                pbUserCard2.Image = spade4
            ElseIf pCard2 = 5 Then
                pbUserCard2.Image = spade5
            ElseIf pCard2 = 6 Then
                pbUserCard2.Image = spade6
            ElseIf pCard2 = 7 Then
                pbUserCard2.Image = spade7
            ElseIf pCard2 = 8 Then
                pbUserCard2.Image = spade8
            ElseIf pCard2 = 9 Then
                pbUserCard2.Image = spade9
            ElseIf pCard2 = 10 Then
                pbUserCard2.Image = spade10
            ElseIf pCard2 = 11 Then
                pbUserCard2.Image = spadeJack
            ElseIf pCard2 = 12 Then
                pbUserCard2.Image = spadeQueen
            ElseIf pCard2 = 13 Then
                pbUserCard2.Image = spadeKing
            End If

            'comp draws second card
            cCard2 = Int((13 * Rnd()) + 1)
            'only shows the back of the card because it is hidden from the player
            pbCPUCard2.Image = backCard

        ElseIf draw = 1 Then
            'player draws third card, 1st HIT
            pCard3 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If pCard3 = 1 Then
                pbUserCard3.Image = spadeAce
            ElseIf pCard3 = 2 Then
                pbUserCard3.Image = spade2
            ElseIf pCard3 = 3 Then
                pbUserCard3.Image = spade3
            ElseIf pCard3 = 4 Then
                pbUserCard3.Image = spade4
            ElseIf pCard3 = 5 Then
                pbUserCard3.Image = spade5
            ElseIf pCard3 = 6 Then
                pbUserCard3.Image = spade6
            ElseIf pCard3 = 7 Then
                pbUserCard3.Image = spade7
            ElseIf pCard3 = 8 Then
                pbUserCard3.Image = spade8
            ElseIf pCard3 = 9 Then
                pbUserCard3.Image = spade9
            ElseIf pCard3 = 10 Then
                pbUserCard3.Image = spade10
            ElseIf pCard3 = 11 Then
                pbUserCard3.Image = spadeJack
            ElseIf pCard3 = 12 Then
                pbUserCard3.Image = spadeQueen
            ElseIf pCard3 = 13 Then
                pbUserCard3.Image = spadeKing
            End If

        ElseIf draw = 2 Then
            'player draws 4th card, 2nd HIT
            pCard4 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If pCard4 = 1 Then
                pbUserCard4.Image = spadeAce
            ElseIf pCard4 = 2 Then
                pbUserCard4.Image = spade2
            ElseIf pCard4 = 3 Then
                pbUserCard4.Image = spade3
            ElseIf pCard4 = 4 Then
                pbUserCard4.Image = spade4
            ElseIf pCard4 = 5 Then
                pbUserCard4.Image = spade5
            ElseIf pCard4 = 6 Then
                pbUserCard4.Image = spade6
            ElseIf pCard4 = 7 Then
                pbUserCard4.Image = spade7
            ElseIf pCard4 = 8 Then
                pbUserCard4.Image = spade8
            ElseIf pCard4 = 9 Then
                pbUserCard4.Image = spade9
            ElseIf pCard4 = 10 Then
                pbUserCard4.Image = spade10
            ElseIf pCard4 = 11 Then
                pbUserCard4.Image = spadeJack
            ElseIf pCard4 = 12 Then
                pbUserCard4.Image = spadeQueen
            ElseIf pCard4 = 13 Then
                pbUserCard4.Image = spadeKing
            End If

        ElseIf draw = 3 Then
            'player draws 5th card, 3rd HIT
            pCard5 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If pCard5 = 1 Then
                pbUserCard5.Image = spadeAce
            ElseIf pCard5 = 2 Then
                pbUserCard5.Image = spade2
            ElseIf pCard5 = 3 Then
                pbUserCard5.Image = spade3
            ElseIf pCard5 = 4 Then
                pbUserCard5.Image = spade4
            ElseIf pCard5 = 5 Then
                pbUserCard5.Image = spade5
            ElseIf pCard5 = 6 Then
                pbUserCard5.Image = spade6
            ElseIf pCard5 = 7 Then
                pbUserCard5.Image = spade7
            ElseIf pCard5 = 8 Then
                pbUserCard5.Image = spade8
            ElseIf pCard5 = 9 Then
                pbUserCard5.Image = spade9
            ElseIf pCard5 = 10 Then
                pbUserCard5.Image = spade10
            ElseIf pCard5 = 11 Then
                pbUserCard5.Image = spadeJack
            ElseIf pCard5 = 12 Then
                pbUserCard5.Image = spadeQueen
            ElseIf pCard5 = 13 Then
                pbUserCard5.Image = spadeKing
            End If

        ElseIf draw = 4 Then
            'player draws 6th card, 4th HIT
            pCard6 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If pCard6 = 1 Then
                pbUserCard6.Image = spadeAce
            ElseIf pCard6 = 2 Then
                pbUserCard6.Image = spade2
            ElseIf pCard6 = 3 Then
                pbUserCard6.Image = spade3
            ElseIf pCard6 = 4 Then
                pbUserCard6.Image = spade4
            ElseIf pCard6 = 5 Then
                pbUserCard6.Image = spade5
            ElseIf pCard6 = 6 Then
                pbUserCard6.Image = spade6
            ElseIf pCard6 = 7 Then
                pbUserCard6.Image = spade7
            ElseIf pCard6 = 8 Then
                pbUserCard6.Image = spade8
            ElseIf pCard6 = 9 Then
                pbUserCard6.Image = spade9
            ElseIf pCard6 = 10 Then
                pbUserCard6.Image = spade10
            ElseIf pCard6 = 11 Then
                pbUserCard6.Image = spadeJack
            ElseIf pCard6 = 12 Then
                pbUserCard6.Image = spadeQueen
            ElseIf pCard6 = 13 Then
                pbUserCard6.Image = spadeKing
            End If

            'disables use of Draw button
            btnDraw.Enabled = False
        End If

        'counts the # of drawn cards
        draw = draw + 1

        'change numeric value of face cards to correct #s to calc score
        If pCard1 = 11 Then
            pCard1 = 10
        ElseIf pCard1 = 12 Then
            pCard1 = 10
        ElseIf pCard1 = 13 Then
            pCard1 = 10
        End If
        If pCard2 = 11 Then
            pCard2 = 10
        ElseIf pCard2 = 12 Then
            pCard2 = 10
        ElseIf pCard2 = 13 Then
            pCard2 = 10
        End If
        If pCard3 = 11 Then
            pCard3 = 10
        ElseIf pCard3 = 12 Then
            pCard3 = 10
        ElseIf pCard3 = 13 Then
            pCard3 = 10
        End If
        If pCard4 = 11 Then
            pCard4 = 10
        ElseIf pCard4 = 12 Then
            pCard4 = 10
        ElseIf pCard4 = 13 Then
            pCard4 = 10
        End If
        If pCard5 = 11 Then
            pCard5 = 10
        ElseIf pCard5 = 12 Then
            pCard5 = 10
        ElseIf pCard5 = 13 Then
            pCard5 = 10
        End If
        If pCard6 = 11 Then
            pCard6 = 10
        ElseIf pCard6 = 12 Then
            pCard6 = 10
        ElseIf pCard6 = 13 Then
            pCard6 = 10
        End If
        If cCard1 = 11 Then
            cCard1 = 10
        ElseIf cCard1 = 12 Then
            cCard1 = 10
        ElseIf cCard1 = 13 Then
            cCard1 = 10
        End If
        If cCard2 = 11 Then
            cCard2 = 10
        ElseIf cCard2 = 12 Then
            cCard2 = 10
        ElseIf cCard2 = 13 Then
            cCard2 = 10
        End If

        'calc player score
        playerScore = pCard1 + pCard2 + pCard3 + pCard4 + pCard5 + pCard6
        'make a rule that enables SOFT or HARD ACE for player
        If playerScore < 12 And pCard1 = 1 Then
            playerScore = playerScore + 10
        ElseIf playerScore < 12 And pCard2 = 1 Then
            playerScore = playerScore + 10
        ElseIf playerScore < 12 And pCard3 = 1 Then
            playerScore = playerScore + 10
        ElseIf playerScore < 12 And pCard4 = 1 Then
            playerScore = playerScore + 10
        ElseIf playerScore < 12 And pCard5 = 1 Then
            playerScore = playerScore + 10
        ElseIf playerScore < 12 And pCard6 = 1 Then
            playerScore = playerScore + 10
        Else
            playerScore = pCard1 + pCard2 + pCard3 + pCard4 + pCard5 + pCard6
        End If

        'calc comp score
        compScore = cCard1  'only 1st card can be seen at this point
        'display the comp score in lbl
        lblCPUScore.Text = compScore
        If cCard1 = 1 Then
            lblCPUScore.Text = "11"
        End If

        'display player score in lbl
        lblUserScore.Text = playerScore

        'enable Check Scores button
        btnCheckScores.Enabled = True
    End Sub

    Private Sub btnCheckScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckScores.Click
        'disables Draw btn & this btn
        btnDraw.Enabled = False
        btnCheckScores.Enabled = False

        'comp has already drawn second card, but now value is revealed to player
        'so
        'places the corresponding card in the pic box
        If cCard2 = 1 Then
            pbCPUCard2.Image = spadeAce
        ElseIf cCard2 = 2 Then
            pbCPUCard2.Image = spade2
        ElseIf cCard2 = 3 Then
            pbCPUCard2.Image = spade3
        ElseIf cCard2 = 4 Then
            pbCPUCard2.Image = spade4
        ElseIf cCard2 = 5 Then
            pbCPUCard2.Image = spade5
        ElseIf cCard2 = 6 Then
            pbCPUCard2.Image = spade6
        ElseIf cCard2 = 7 Then
            pbCPUCard2.Image = spade7
        ElseIf cCard2 = 8 Then
            pbCPUCard2.Image = spade8
        ElseIf cCard2 = 9 Then
            pbCPUCard2.Image = spade9
        ElseIf cCard2 = 10 Then
            pbCPUCard2.Image = spade10
        ElseIf cCard2 = 11 Then
            pbCPUCard2.Image = spadeJack
        ElseIf cCard2 = 12 Then
            pbCPUCard2.Image = spadeQueen
        ElseIf cCard2 = 13 Then
            pbCPUCard2.Image = spadeKing
        End If

        'change numeric value of face cards to correct #s to calc score
        If cCard2 = 11 Then
            cCard2 = 10
        ElseIf cCard2 = 12 Then
            cCard2 = 10
        ElseIf cCard2 = 13 Then
            cCard2 = 10
        End If

        'calc REAL comp score
        compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        'make a rule that enables SOFT or HARD ACE for comp
        If compScore < 12 And cCard1 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard2 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard3 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard4 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard5 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard6 = 1 Then
            compScore = compScore + 10
        Else
            compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        End If

        'rule for how comp draws another card - if his score is < 17
        If compScore < 17 Then
            'comp draws 3rd card, 1st HIT
            cCard3 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If cCard3 = 1 Then
                pbCPUCard3.Image = spadeAce
            ElseIf cCard3 = 2 Then
                pbCPUCard3.Image = spade2
            ElseIf cCard3 = 3 Then
                pbCPUCard3.Image = spade3
            ElseIf cCard3 = 4 Then
                pbCPUCard3.Image = spade4
            ElseIf cCard3 = 5 Then
                pbCPUCard3.Image = spade5
            ElseIf cCard3 = 6 Then
                pbCPUCard3.Image = spade6
            ElseIf cCard3 = 7 Then
                pbCPUCard3.Image = spade7
            ElseIf cCard3 = 8 Then
                pbCPUCard3.Image = spade8
            ElseIf cCard3 = 9 Then
                pbCPUCard3.Image = spade9
            ElseIf cCard3 = 10 Then
                pbCPUCard3.Image = spade10
            ElseIf cCard3 = 11 Then
                pbCPUCard3.Image = spadeJack
            ElseIf cCard3 = 12 Then
                pbCPUCard3.Image = spadeQueen
            ElseIf cCard3 = 13 Then
                pbCPUCard3.Image = spadeKing
            End If
        End If

        'change numeric value of face cards and aces to correct #s to calc score
        If cCard3 = 11 Then
            cCard3 = 10
        ElseIf cCard3 = 12 Then
            cCard3 = 10
        ElseIf cCard3 = 13 Then
            cCard3 = 10
        End If

        'calc REAL comp score after 1st HIT
        compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        'make a rule that enables SOFT or HARD ACE for comp
        If compScore < 12 And cCard1 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard2 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard3 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard4 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard5 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard6 = 1 Then
            compScore = compScore + 10
        Else
            compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        End If

        'rule for how comp draws another card - if his score is < 17 (x2)
        If compScore < 17 Then
            'comp draws 4th card, 2nd HIT
            cCard4 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If cCard4 = 1 Then
                pbCPUCard4.Image = spadeAce
            ElseIf cCard4 = 2 Then
                pbCPUCard4.Image = spade2
            ElseIf cCard4 = 3 Then
                pbCPUCard4.Image = spade3
            ElseIf cCard4 = 4 Then
                pbCPUCard4.Image = spade4
            ElseIf cCard4 = 5 Then
                pbCPUCard4.Image = spade5
            ElseIf cCard4 = 6 Then
                pbCPUCard4.Image = spade6
            ElseIf cCard4 = 7 Then
                pbCPUCard4.Image = spade7
            ElseIf cCard4 = 8 Then
                pbCPUCard4.Image = spade8
            ElseIf cCard4 = 9 Then
                pbCPUCard4.Image = spade9
            ElseIf cCard4 = 10 Then
                pbCPUCard4.Image = spade10
            ElseIf cCard4 = 11 Then
                pbCPUCard4.Image = spadeJack
            ElseIf cCard4 = 12 Then
                pbCPUCard4.Image = spadeQueen
            ElseIf cCard4 = 13 Then
                pbCPUCard4.Image = spadeKing
            End If
        End If

        'change numeric value of face cards and aces to correct #s to calc score
        If cCard4 = 11 Then
            cCard4 = 10
        ElseIf cCard4 = 12 Then
            cCard4 = 10
        ElseIf cCard4 = 13 Then
            cCard4 = 10
        End If

        'calc REAL comp score after 2nd HIT
        compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        'make a rule that enables SOFT or HARD ACE for comp
        If compScore < 12 And cCard1 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard2 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard3 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard4 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard5 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard6 = 1 Then
            compScore = compScore + 10
        Else
            compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        End If

        'rule for how comp draws another card - if his score is < 17 (x3)
        If compScore < 17 Then
            'comp draws 5th card, 3rd HIT
            cCard5 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If cCard5 = 1 Then
                pbCPUCard5.Image = spadeAce
            ElseIf cCard5 = 2 Then
                pbCPUCard5.Image = spade2
            ElseIf cCard5 = 3 Then
                pbCPUCard5.Image = spade3
            ElseIf cCard5 = 4 Then
                pbCPUCard5.Image = spade4
            ElseIf cCard5 = 5 Then
                pbCPUCard5.Image = spade5
            ElseIf cCard5 = 6 Then
                pbCPUCard5.Image = spade6
            ElseIf cCard5 = 7 Then
                pbCPUCard5.Image = spade7
            ElseIf cCard5 = 8 Then
                pbCPUCard5.Image = spade8
            ElseIf cCard5 = 9 Then
                pbCPUCard5.Image = spade9
            ElseIf cCard5 = 10 Then
                pbCPUCard5.Image = spade10
            ElseIf cCard5 = 11 Then
                pbCPUCard5.Image = spadeJack
            ElseIf cCard5 = 12 Then
                pbCPUCard5.Image = spadeQueen
            ElseIf cCard5 = 13 Then
                pbCPUCard5.Image = spadeKing
            End If
        End If

        'change numeric value of face cards and aces to correct #s to calc score
        If cCard5 = 11 Then
            cCard5 = 10
        ElseIf cCard5 = 12 Then
            cCard5 = 10
        ElseIf cCard5 = 13 Then
            cCard5 = 10
        End If

        'calc REAL comp score after 3rd HIT
        compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        'make a rule that enables SOFT or HARD ACE for comp
        If compScore < 12 And cCard1 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard2 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard3 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard4 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard5 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard6 = 1 Then
            compScore = compScore + 10
        Else
            compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        End If

        'rule for how comp draws another card - if his score is < 17 (x4)
        If compScore < 17 Then
            'comp draws 6th card, 4th HIT
            cCard6 = Int((13 * Rnd()) + 1)
            'places the corresponding card in the pic box
            If cCard6 = 1 Then
                pbCPUCard6.Image = spadeAce
            ElseIf cCard6 = 2 Then
                pbCPUCard6.Image = spade2
            ElseIf cCard6 = 3 Then
                pbCPUCard6.Image = spade3
            ElseIf cCard6 = 4 Then
                pbCPUCard6.Image = spade4
            ElseIf cCard6 = 5 Then
                pbCPUCard6.Image = spade5
            ElseIf cCard6 = 6 Then
                pbCPUCard6.Image = spade6
            ElseIf cCard6 = 7 Then
                pbCPUCard6.Image = spade7
            ElseIf cCard6 = 8 Then
                pbCPUCard6.Image = spade8
            ElseIf cCard6 = 9 Then
                pbCPUCard6.Image = spade9
            ElseIf cCard6 = 10 Then
                pbCPUCard6.Image = spade10
            ElseIf cCard6 = 11 Then
                pbCPUCard6.Image = spadeJack
            ElseIf cCard6 = 12 Then
                pbCPUCard6.Image = spadeQueen
            ElseIf cCard6 = 13 Then
                pbCPUCard6.Image = spadeKing
            End If
        End If

        'change numeric value of face cards and aces to correct #s to calc score
        If cCard6 = 11 Then
            cCard6 = 10
        ElseIf cCard6 = 12 Then
            cCard6 = 10
        ElseIf cCard6 = 13 Then
            cCard6 = 10
        End If

        'calc REAL comp score after 4th HIT
        compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        'make a rule that enables SOFT or HARD ACE for comp
        If compScore < 12 And cCard1 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard2 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard3 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard4 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard5 = 1 Then
            compScore = compScore + 10
        ElseIf compScore < 12 And cCard6 = 1 Then
            compScore = compScore + 10
        Else
            compScore = cCard1 + cCard2 + cCard3 + cCard4 + cCard5 + cCard6
        End If

        'redisplay the new comp score after finish smart drawing/hitting itself
        lblCPUScore.Text = compScore

        'declares winner of the round
        If compScore > 21 And playerScore < 22 Then
            'player wins by comp bust
            MessageBox.Show("You WIN!  The dealer busted!", "CONGRATULATIONS")
            btnDraw.Enabled = False
            btnCheckScores.Enabled = False
            'count the # of wins
            wins = wins + 1
            lblWins.Text = "Wins: " & wins
        ElseIf playerScore < 22 And playerScore > compScore Then
            'player wins by having greater score under 21
            MessageBox.Show("You WIN!", "CONGRATULATIONS")
            btnDraw.Enabled = False
            btnCheckScores.Enabled = False
            'count the # of wins
            wins = wins + 1
            lblWins.Text = "Wins: " & wins
        ElseIf compScore < 22 And compScore > playerScore Then
            'comp wins by having greater score under 21
            MessageBox.Show("You LOSE!", "TRY AGAIN")
            btnDraw.Enabled = False
            btnCheckScores.Enabled = False
            'count the # of losses
            losses = losses + 1
            lblLosses.Text = "Losses: " & losses
        ElseIf playerScore > 21 And compScore < 22 Then
            'comp wins by player bust
            MessageBox.Show("Bust! You LOSE!", "BUSTED")
            btnDraw.Enabled = False
            btnCheckScores.Enabled = False
            'count the # of losses
            losses = losses + 1
            lblLosses.Text = "Losses: " & losses
        ElseIf playerScore > 21 And compScore > 21 Then
            'double bust (Tie)
            MessageBox.Show("No Winner!  It's a tie!", "DOUBLE BUST")
            btnDraw.Enabled = False
            btnCheckScores.Enabled = False
            'count the # of ties
            ties = ties + 1
            lblTies.Text = "Ties: " & ties
        ElseIf playerScore = compScore Then
            'tie by equal score
            MessageBox.Show("No Winner!", "TIE GAME")
            btnDraw.Enabled = False
            btnCheckScores.Enabled = False
            'count the # of ties
            ties = ties + 1
            lblTies.Text = "Ties: " & ties
        End If

        'enable the Reset btn & New Hand btn
        btnResetBlackjack.Enabled = True
        btnNewHand.Enabled = True
    End Sub

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetBlackjack.Click
        'resets everything to start a new game without closing the program
        '   ***AND resets WW/TT/LL record
        'draw tab reset
        draw = 0
        'scores reset
        playerScore = 0
        compScore = 0
        lblUserScore.Text = playerScore
        lblCPUScore.Text = compScore
        'rnd # variables reset even though don't need to
        pCard1 = 0
        pCard2 = 0
        pCard3 = 0
        pCard4 = 0
        pCard5 = 0
        pCard6 = 0
        cCard1 = 0
        cCard2 = 0
        cCard3 = 0
        cCard4 = 0
        cCard5 = 0
        cCard6 = 0
        'reset WW/TT/LL record
        wins = 0
        lblWins.Text = "Wins: " & wins
        ties = 0
        lblTies.Text = "Ties: " & ties
        losses = 0
        lblLosses.Text = "Losses: " & losses
        'card pics reset
        pbUserCard1.Image = Nothing
        pbUserCard2.Image = Nothing
        pbUserCard3.Image = Nothing
        pbUserCard4.Image = Nothing
        pbUserCard5.Image = Nothing
        pbUserCard6.Image = Nothing
        pbCPUCard1.Image = Nothing
        pbCPUCard2.Image = Nothing
        pbCPUCard3.Image = Nothing
        pbCPUCard4.Image = Nothing
        pbCPUCard5.Image = Nothing
        pbCPUCard6.Image = Nothing
        're-enable use of Draw & Check Scores btns
        btnDraw.Enabled = True
        btnCheckScores.Enabled = True
        'disable this btn & New hand btn & Check Scores button
        btnResetBlackjack.Enabled = False
        btnNewHand.Enabled = False
        btnCheckScores.Enabled = False
    End Sub

    Private Sub btnNewHand_Click(sender As System.Object, e As System.EventArgs) Handles btnNewHand.Click
        'resets everything to start a new game without closing the program
        '   still keeps track of WW/TT/LL record
        'draw tab reset
        draw = 0
        'scores reset
        playerScore = 0
        compScore = 0
        lblUserScore.Text = playerScore
        lblCPUScore.Text = compScore
        'rnd # variables reset even though don't need to
        pCard1 = 0
        pCard2 = 0
        pCard3 = 0
        pCard4 = 0
        pCard5 = 0
        pCard6 = 0
        cCard1 = 0
        cCard2 = 0
        cCard3 = 0
        cCard4 = 0
        cCard5 = 0
        cCard6 = 0
        'card pics reset
        pbUserCard1.Image = Nothing
        pbUserCard2.Image = Nothing
        pbUserCard3.Image = Nothing
        pbUserCard4.Image = Nothing
        pbUserCard5.Image = Nothing
        pbUserCard6.Image = Nothing
        pbCPUCard1.Image = Nothing
        pbCPUCard2.Image = Nothing
        pbCPUCard3.Image = Nothing
        pbCPUCard4.Image = Nothing
        pbCPUCard5.Image = Nothing
        pbCPUCard6.Image = Nothing
        're-enable use of Draw & Check Scores btns
        btnDraw.Enabled = True
        btnCheckScores.Enabled = True
        'disable this btn & Reset btn & Check Scores button
        btnNewHand.Enabled = False
        btnCheckScores.Enabled = False

        'congratulatory message for having 5 more wins than comp and force reset
        If wins > losses + 4 Then
            MessageBox.Show("You are now a master at Blackjack!" & vbCrLf & "Please play again", "CONGRATULATIONS - YOU HAVE REACHED A NEW LEVEL OF POWER")
            'reset WW/TT/LL record
            wins = 0
            lblWins.Text = "Wins: " & wins
            ties = 0
            lblTies.Text = "Ties: " & ties
            losses = 0
            lblLosses.Text = "Losses: " & losses
            'disable this Reset button
            btnResetBlackjack.Enabled = False
        End If
    End Sub
End Class
