Public Class Form1
    Public WithEvents SFD As New SaveFileDialog
    Dim SelectedItem As String = "ACTION!"
    Dim A As New List(Of String) From {"ACTION!", "ADVENTURE TIME", "AFRO CIRCUS", "AI SE EU TE PEGO", "AIR HORN", "AN ENEMY", "ANGRY CAT", "APPARENTLY", "APPLAUSE", "ARCHIVMENT", "ARROW IN THE KNEE", "A-TEAM", "AVE MARIA", "AWW", "AYBABTU"}
    Dim B As New List(Of String) From {"BAAAAAKAAAAA", "BABY FINN", "BABY LAUGH", "BACKTRACED IT", "BAD BOYS", "BADUMTSS", "BALLS OF STEEL", "BARBIE GIRL", "BARKING DOG", "BARREL ROLL", "BATMAN", "BAYWATCH", "BAZINGA", "BECAUSE I'M HAPPY", "BENNY HILL", "BEST CRY", "BOLEAKALELE", "BOMBERMAN", "BOND", "BOO", "BRUH", "BUONGIORNO PRINCIPESSA", "BURNED", "BURP"}
    Dim C As New List(Of String) From {"CABLE GUY", "CALL ME MAYBE", "CALL ON ME", "CAN'T TOUCH THIS", "CAR KEY", "CARAMELLDANSEN", "CARELESS WHISPER", "CASH", "CAVALRY CHARGE", "CELEBRATION", "CENSOR BEEP", "CHALLENGE ACCEPTED", "CHAN CHAN", "CHAN", "CHARLIE'S ANGELS", "CHEWBACCA", "CHICKA WAH WAH", "CHICKEN", "CHIQUITITA", "CHIQUITO", "CHUCK TESTA", "CIRCUS", "CLICKER", "COMBOBREAKER", "CONSECUENCES", "COOKIE MONSTER", "COOLCOOLCOOL", "COW", "CREEPER", "CRICKETS", "CRUSH DESTROY", "CUCKOO", "CUEK", "CYBERPOLICE"}
    Dim D As New List(Of String) From {"DEATH METAL ROOSTER", "DEJAME HABLAR", "DEMACIA", "DEN DEN MUSHI", "DERP SONG", "DID I DO THAT?", "DIEGU", "DODOO", "DOH", "DOLPHIN", "DOMINIQUE", "DOOR BELL", "DORAEMON", "DRACULA", "DRAMA", "DRAMATIC", "DRUMROLL", "DUCK HUNT", "DUCK TOY", "DUEL TIME", "DUMBASS", "DURKA DURK"}
    Dim E As New List(Of String) From {"E UMA CILADA BINO", "EA SPORTS", "EAGLE", "ELEMENTARY", "ENJUTO", "EPIC SAX GUY", "EVERYBODY DANCE NOW", "EVERYTHING IS AWESOME", "EVIL", "EXORCIST", "EXTERMINATE"}
    Dim F As New List(Of String) From {"FAILED THIS CITY", "FALCON PUNCH", "FART", "FATALITY", "FHRITP", "FIFTH", "FIGHT CLUB", "FINISH HIM", "FIRE IN THE HOLE", "FIREWORKS", "FUCK OFF", "FUNFAIR", "FUS RO DAH!"}
    Dim G As New List(Of String) From {"GAAAY", "GAME OVER", "GANGNAM STYLE", "GARBAGE DAY", "GENERAL LEE", "GG", "GHOST BUSTERS", "GO!BWAHH!", "GODFATHER", "GODZILLA ROAR", "GOLLUM", "GOOD MORNING VIETNAM", "GOOFY", "GRYFFINDOR", "GUESS WHO", "GUILE'S THEME"}
    Dim H As New List(Of String) From {"HAALT STOP!", "HADOUKEN", "HALLELUJAH", "HAMMER TIME", "HAPPY BIRTHDAY", "HASTA LA VISTA BABY", "HEADSHOT", "HEAVY MACHINE GUN", "HEY APPLE", "HO HO HO", "HOBBITS", "HODOR", "HOUSTON", "HOW ABOUT NO", "HOW YOU DOIN?", "HUMP DAY", "HUNGER GAMES"}
    Dim I As New List(Of String) From {"I AM THE LAW", "I CAN SMELL YOU", "I DO COCAINE", "I JUST HAD SEX", "I KILL YOU", "I LIKE TO MOVE IT", "I LIKE TURTLES", "I SEE DEAD PEOPLE", "I WILL KILL YOU", "I'LL BE BACK", "I'M READY", "INCEPTION", "INDIANA JONES", "INSPECTOR GADGET", "IT'S A TRAP", "IT'S GONE"}
    Dim J As New List(Of String) From {"JACK IN THE BOX", "JAWS", "JINGLE BELLS", "JOSEBA", "JURASSIC PARK"}
    Dim K As New List(Of String) From {"KALINKA", "KAME", "KAWAII", "KEYBOARD CAT", "KHAAAN", "KILL BILL", "KIM POSSIBLE", "KISS", "KITT"}
    Dim L As New List(Of String) From {"LA CUCARACHA", "LACASITOS", "LASER SABER", "LAUGH", "LAW & ORDER", "LAZOR", "LEGEN...DARY", "LEROY", "LIKE A BOSS", "LIKE A GLOVE", "LITTLE FRIEND", "LOOK AT MY HORSE", "LOOKS GOOD", "LOONEY TUNES", "LOSING HORN", "LOST", "LOVE", "LOW PRICE"}
    Dim M As New List(Of String) From {"MAHNA MAHNA", "MAIS OU MENOS", "MARIO", "MARIO 1UP", "MARIO COIN", "MARVIN", "MEDIC", "MONDOZA", "MERMAID EVIL", "MERRY CHRISTMAS", "METAL GEAR", "METAL GEAR CODEC", "MICHAEL JACKSON", "MIND THE GAP", "MINION HELLO", "MLB", "MODEM", "MONSTERKILL", "MORPHING TIME", "MOSQUITO", "MSN", "MUDKIP", "MURLOC"}
    Dim N As New List(Of String) From {"NAILED IT", "NANANA BATMAN", "NAPALM", "NARWHALES", "NEIN", "NO GOD NO!", "NOBODY GOT TIME", "NOKIA", "NOOO", "NOPE", "NOT AT THE TABLE", "NOT CHRISTIAN", "NOT SIMPLY", "NUCLEAR ALARM", "NYAN"}
    Dim O As New List(Of String) From {"OBJECTION", "OH BOB SAGET", "OH GOOOOD FOR YOU!", "OH MY", "OH MY GOAT!", "OH NO", "OLA K ASE", "OLD GREG", "OLD SPICE", "OMMMM", "ONE MISSED CALL", "OOOOH", "OSCAR GOES TO", "OVER 9000"}
    Dim P As New List(Of String) From {"PACMAN LIFE", "PENNY", "PENTAKILL", "PERRY THE PLATYPUS", "PIKACHU", "PINGAS", "PINK PANTHER", "PIRATE", "PLAY WITH ME", "POKEMON HEAL", "POLICE SIREN", "POPCORN", "PORTAL TURRET", "POWER OF GREYSKULL", "POWER RANGERS", "PREDATOR", "PS3 TROPHY", "PSYCHO", "PUDDI PUDDI", "PUNCH"}
    'Dim Q As New List(Of String) From {""}
    Dim R As New List(Of String) From {"R2D2", "RABBIDS", "READY TO RUMBLE", "REDEEM YOURSELF", "RELEASE THE KRAKEN", "RETARD ALERT", "RETARDED POLICEMAN", "RICK ROLL", "ROADHOUSE", "ROCKY", "RUN FOREST RUN"}
    Dim S As New List(Of String) From {"SABRE DANCE", "SAD MOMENT", "SAD TROMBO", "SAW", "SAY MY NAME", "SCHOOL BELL", "SCRATCH", "SCREAMING GOAT", "SEGA", "SEXY AND I KNOW IT", "SHALL NOT PASS", "SHALL WE BEGIN?", "SHE SAID", "SHIN CHAN", "SHORYUKEN", "SHOTGUN", "SHUFFLING", "SHUT UP", "SILENCE", "SIXTY FOAR", "SKULLKID", "SLENDER", "SMELLY CAT", "SO FLUFFY", "SO SAY WE ALL", "SOFT KITTY", "SPARTA", "SPONGEBOB", "SPOON", "SPORTS CENTER", "STAY A WHILE", "STELIO KONTOS", "STRIPTEASE", "STUPID HOE", "SUIT UP", "SURPRISE MOTHERFUCKER", "SWANEE"}
    Dim T As New List(Of String) From {"TA TA TAAAA", "TADA", "TADALALA", "TAKE A SELFIE", "TALK TO THE HAND", "TARDIS", "TARZAN", "TEAM DEATHMATCH", "TEEMO", "TETRIS", "THAT WAS EASY", "THE BIG BANG THEORY", "THE FINAL COUNTDOWN", "THE FOX SAYS", "THE HARLEM SHAKE", "THEY KILLED KENNY", "THEY SEE ME ROLLIN", "THINK MUSIC", "THIS IS PATRIK", "THUG LIFE", "THX", "TIMMY!", "TOASTY", "TOMORROW FOR SURE", "TRALALA", "TRANSFORMERS", "TRIUMPH", "TROLOLO", "THUMBLEWEED", "TWILIGHT ZONE"}
    Dim U As New List(Of String) From {"UHH SEXY", "UNSTOPABLE"}
    Dim V As New List(Of String) From {"VALKYRES", "VICTORY FF", "VICTORY SCREECH", "VOLDEMORT LAUGH", "VUVUZELA"}
    Dim W As New List(Of String) From {"WAKAWAKA", "WALLE", "WAT", "WATAHHH", "WE DID IT!", "WE WILL ROCK YOU", "WEDDING", "WESTERN", "WHIP", "WHISTLE WOLF", "WHO IS YOUR DADDY?", "WHO LET THE DOGS OUT?", "WHY SO SERIOUS", "WILHELM SCREAM", "WINDOWS 95", "WINDOWS STOP", "WINTER IS COMING", "WOLF", "WOLOLO", "WOODY LAUGH", "WORMS BYE BYE", "WRONG", "WRONG COX", "WTF BOOM"}
    Dim X As New List(Of String) From {"X-FILES"}
    Dim Y As New List(Of String) From {"YA TU SABEH", "YABBADABBADO", "YEAHHH", "YEHA", "YIPPIE KAY YEAH", "YOU ARE TOO SLOW", "YOU DUN GOOFED", "YOU GET NOTHING", "YOU KNOW NOTHING"}
    Dim Z As New List(Of String) From {"ZAS", "ZASCA", "ZELDA ITEM", "ZELDA LISTEN", "ZELDA SACRET", "ZOIDBERG"}
    Dim Raute As New List(Of String) From {"2 GIRLS 1 CUP", "20 PERCENT COOLER"}

    Private Sub gen()
        'Wird beim cb_alphabet.SelectedIndexChanged aufgerufen
        Select Case cb_alphabet.SelectedItem.ToString()
            Case "A"
                cb_name.DataSource = A
            Case "B"
                cb_name.DataSource = B
            Case "C"
                cb_name.DataSource = C
            Case "D"
                cb_name.DataSource = D
            Case "E"
                cb_name.DataSource = E
            Case "F"
                cb_name.DataSource = F
            Case "G"
                cb_name.DataSource = G
            Case "H"
                cb_name.DataSource = H
            Case "I"
                cb_name.DataSource = I
            Case "J"
                cb_name.DataSource = J
            Case "K"
                cb_name.DataSource = K
            Case "L"
                cb_name.DataSource = L
            Case "M"
                cb_name.DataSource = M
            Case "N"
                cb_name.DataSource = N
            Case "O"
                cb_name.DataSource = O
            Case "P"
                cb_name.DataSource = P
            Case "Q"
                cb_name.DataSource = Nothing
            Case "R"
                cb_name.DataSource = R
            Case "S"
                cb_name.DataSource = S
            Case "T"
                cb_name.DataSource = T
            Case "U"
                cb_name.DataSource = U
            Case "V"
                cb_name.DataSource = V
            Case "W"
                cb_name.DataSource = W
            Case "X"
                cb_name.DataSource = X
            Case "Y"
                cb_name.DataSource = Y
            Case "Z"
                cb_name.DataSource = Z
            Case "#"
                cb_name.DataSource = Raute
        End Select
        If cb_alphabet.SelectedItem = "A" Then
            cb_name.SelectedItem = "ACTION!"
        ElseIf cb_alphabet.SelectedItem = "B" Then
            cb_name.SelectedItem = "BAAAAAKAAAAA"
        ElseIf cb_alphabet.SelectedItem = "C" Then
            cb_name.SelectedItem = "CABLE GUY"
        ElseIf cb_alphabet.SelectedItem = "D" Then
            cb_name.SelectedItem = "DEATH METAL ROOSTER"
        ElseIf cb_alphabet.SelectedItem = "E" Then
            cb_name.SelectedItem = "E UMA CILADA BINO"
        ElseIf cb_alphabet.SelectedItem = "F" Then
            cb_name.SelectedItem = "FAILED THIS CITY"
        ElseIf cb_alphabet.SelectedItem = "G" Then
            cb_name.SelectedItem = "GAAAY"
        ElseIf cb_alphabet.SelectedItem = "H" Then
            cb_name.SelectedItem = "HAALT STOP!"
        ElseIf cb_alphabet.SelectedItem = "I" Then
            cb_name.SelectedItem = "I AM THE LAW"
        ElseIf cb_alphabet.SelectedItem = "J" Then
            cb_name.SelectedItem = "JACK IN THE BOX"
        ElseIf cb_alphabet.SelectedItem = "K" Then
            cb_name.SelectedItem = "KALINKA"
        ElseIf cb_alphabet.SelectedItem = "L" Then
            cb_name.SelectedItem = "LA CUCARACHA"
        ElseIf cb_alphabet.SelectedItem = "M" Then
            cb_name.SelectedItem = "MAHNA MAHNA"
        ElseIf cb_alphabet.SelectedItem = "N" Then
            cb_name.SelectedItem = "NAILED IT"
        ElseIf cb_alphabet.SelectedItem = "O" Then
            cb_name.SelectedItem = "OBJECTION"
        ElseIf cb_alphabet.SelectedItem = "P" Then
            cb_name.SelectedItem = "PACMAN LIFE"
            'ElseIf cb_alphabet.SelectedItem = "Q" Then
            '    cb_name.SelectedItem = ""
        ElseIf cb_alphabet.SelectedItem = "R" Then
            cb_name.SelectedItem = "R2D2"
        ElseIf cb_alphabet.SelectedItem = "S" Then
            cb_name.SelectedItem = "SABRE DANCE"
        ElseIf cb_alphabet.SelectedItem = "T" Then
            cb_name.SelectedItem = "TA TA TAAAA"
        ElseIf cb_alphabet.SelectedItem = "U" Then
            cb_name.SelectedItem = "UHH SEXY"
        ElseIf cb_alphabet.SelectedItem = "V" Then
            cb_name.SelectedItem = "VALKYRES"
        ElseIf cb_alphabet.SelectedItem = "W" Then
            cb_name.SelectedItem = "WAKAWAKA"
        ElseIf cb_alphabet.SelectedItem = "X" Then
            cb_name.SelectedItem = "X-FILES"
        ElseIf cb_alphabet.SelectedItem = "Y" Then
            cb_name.SelectedItem = "YA TU SABEH"
        ElseIf cb_alphabet.SelectedItem = "Z" Then
            cb_name.SelectedItem = "ZAS"
        ElseIf cb_alphabet.SelectedItem = "#" Then
            cb_name.SelectedItem = "2 GIRLS 1 CUP"
        End If
    End Sub

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        If Player.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Player.Ctlcontrols.stop()
            If SelectedItem <> cb_name.SelectedItem Then
                play()
            End If
        Else
            play()
        End If
        SelectedItem = cb_name.SelectedItem
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub cb_alphabet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_alphabet.SelectedIndexChanged
        gen()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Player.settings.volume = 100
        cb_alphabet.SelectedItem = "A"
        cb_name.SelectedItem = "ACTION!"
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        SFD.FileName = "nichts gewählt"
        SFD.Filter = "MP4-Dateien|*.mp4|Alle Dateien|*.*"
        SFD.Title = "speichern"
        SFD.ShowDialog()
    End Sub

    Private Sub SFD_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SFD.FileOk
        If cb_name.SelectedItem = "ACTION!" Then
            FileIO.FileSystem.CopyFile(Application.StartupPath & "\Töne\DID I DO THAT[Fragezeichen].mp4", SFD.FileName)
        ElseIf cb_name.SelectedItem = "ADVENTURE TIME" Then
            FileIO.FileSystem.CopyFile(Application.StartupPath & "\Töne\HOW YOU DOIN[Fragezeichen].mp4", SFD.FileName)
        ElseIf cb_name.SelectedItem = "SHALL WE BEGIN?" Then
            FileIO.FileSystem.CopyFile(Application.StartupPath & "\Töne\SHALL WE BEGIN[Fragezeichen].mp4", SFD.FileName)
        ElseIf cb_name.SelectedItem = "WHO IS YOUR DADDY?" Then
            FileIO.FileSystem.CopyFile(Application.StartupPath & "\Töne\WHO IS YOUR DADDY[Fragezeichen].mp4", SFD.FileName)
        ElseIf cb_name.SelectedItem = "WHO LET THE DOGS OUT?" Then
            FileIO.FileSystem.CopyFile(Application.StartupPath & "\Töne\WHO LET THE DOGS OUT[Fragezeichen].mp4", SFD.FileName)
        Else
            FileIO.FileSystem.CopyFile(Application.StartupPath & "\Töne\" & cb_name.SelectedItem & ".mp4", SFD.FileName)
        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        play()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        Player.Ctlcontrols.pause()
    End Sub

    Private Sub ResumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeToolStripMenuItem.Click
        Player.Ctlcontrols.play()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        Player.Ctlcontrols.stop()
    End Sub

    Private Sub Pause2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pause2ToolStripMenuItem.Click
        Player.Ctlcontrols.pause()
    End Sub

    Private Sub Snooze(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub play()
        If cb_name.SelectedItem = "DID I DO THAT?" Then
            Player.URL = Application.StartupPath & "\Töne\DID I DO THAT[Fragezeichen].mp4"
        ElseIf cb_name.SelectedItem = "HOW YOU DOIN?" Then
            Player.URL = Application.StartupPath & "\Töne\HOW YOU DOIN[Fragezeichen].mp4"
        ElseIf cb_name.SelectedItem = "SHALL WE BEGIN?" Then
            Player.URL = Application.StartupPath & "\Töne\SHALL WE BEGIN[Fragezeichen].mp4"
        ElseIf cb_name.SelectedItem = "WHO IS YOUR DADDY?" Then
            Player.URL = Application.StartupPath & "\Töne\WHO IS YOUR DADDY[Fragezeichen].mp4"
        ElseIf cb_name.SelectedItem = "WHO LET THE DOGS OUT?" Then
            Player.URL = Application.StartupPath & "\Töne\WHO LET THE DOGS OUT[Fragezeichen].mp4"
        Else
            Player.URL = Application.StartupPath & "\Töne\" & cb_name.SelectedItem & ".mp4"
        End If
        Player.Ctlcontrols.play()
    End Sub
End Class