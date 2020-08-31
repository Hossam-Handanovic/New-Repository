
Imports System.Speech
Imports System.Diagnostics

Public Class fremMainWindow


    ' create a robot voice to recognize the user’s voice 
    Dim WithEvents MyVoice As New Recognition.SpeechRecognitionEngine




    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'activate the default audio device "Mic"
        MyVoice.SetInputToDefaultAudioDevice()
        CheckBox1.Visible = False ' in order to hide checkbox from the screeen
        'Create a var MyGrammar
        Dim MyGrammar As New Recognition.SrgsGrammar.SrgsDocument

        'Create a var MyWordsRule
        Dim MyWordsRule As New Recognition.SrgsGrammar.SrgsRule("words")

        'Create a var MyWordsRule
        Dim MyWords As New Recognition.SrgsGrammar.SrgsOneOf("Hi", "Alpha", "Go Alpha",
        "Alpha", "How are you", "What is your name", "Fine",
        "good", "not good", "bad", "I have bad mood ",
        "Alpha How are you", "what is time clock",
        " Alpha what is time now", " Alpha the time now ",
        "time", "Alpha what is time clock", "show this time", "show time", "show it",
        "show", "alpha close", "close", "Alpha shut down", "shut down", "hello", "who is your designer",
        "who is your owner", "Google", "Open google", "facebook", "open facebook", "Restart windows",
        "Restart", "shutdown", "how old are you", "what is your age", "can you speak arabic", "do you have another langauge to speak",
        "can you speak spanish", "can you speak french", "what is your favourite song",
        "what is your prefered song", "what is your best song", "ok show me", "open google maps", "how to fix slow in my windows")

        'Add the words I speak onto the system
        MyWordsRule.Add(MyWords)

        'Add the MyWordRule onto the system
        MyGrammar.Rules.Add(MyWordsRule)

        'The location to MyWordRule
        MyGrammar.Root = MyWordsRule

        'When you hear my voice, LoadGrammar
        MyVoice.LoadGrammar(New Recognition.Grammar(MyGrammar))

        'recognise my voice on form load
        MyVoice.RecognizeAsync()

    End Sub


    'recognise my voice every time I speak
    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles MyVoice.RecognizeCompleted

        MyVoice.RecognizeAsync()

    End Sub
    Dim SAPI


    'recognise my voice and if the case exists, execute the procedure
    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles MyVoice.SpeechRecognized
        SAPI = CreateObject("SAPI.spvoice")
        Dim time_date As DateTime = DateTime.Now


        If (CheckBox1.Checked) Then
            If (e.Result.Text = "Hi") Then
                SAPI.Speak("hi")
            End If

            If (e.Result.Text = "Alpha") Then
                SAPI.Speak("yes")
            End If

            If (e.Result.Text = "How are you" OrElse e.Result.Text = "Alpha How are you") Then
                SAPI.Speak("I am good and you")
            End If

            If (e.Result.Text = "Fine" OrElse e.Result.Text = "good") Then
                SAPI.Speak("I hope that")
            End If

            If (e.Result.Text = "not good" OrElse e.Result.Text = "bad" OrElse e.Result.Text = "I have bad mood") Then
                SAPI.Speak("why what is happen")
            End If


            If (e.Result.Text = "Alpha how are you") Then
                SAPI.Speak("hi")
            End If

            If (e.Result.Text = "what is time clock" OrElse e.Result.Text = "time" OrElse e.Result.Text = " what is time now" OrElse e.Result.Text = "Alpha what is time clock" OrElse e.Result.Text = " Alpha the time now " OrElse e.Result.Text = " Alpha what is time now") Then


                SAPI.Speak(time_date)
            End If

            If (e.Result.Text = "show this time" OrElse e.Result.Text = "show time" OrElse e.Result.Text = "show it" OrElse e.Result.Text = "show") Then

                frmTime.Show()

            End If

            If (e.Result.Text = "alpha close" OrElse e.Result.Text = "close" OrElse e.Result.Text = "Alpha shut down" OrElse e.Result.Text = "shut down") Then
                SAPI.Speak("Yes i will")
                Me.Close()
            End If

            If (e.Result.Text = "hello") Then
                SAPI.Speak("hi")
            End If


            If (e.Result.Text = "who is your designer" OrElse e.Result.Text = "who is your owner") Then
                SAPI.Speak("my desiner is hossam handanovich ")
            End If

            If (e.Result.Text = "Google") Then
                Process.Start("https://www.google.com")
            End If

            If (e.Result.Text = "Open google") Then
                Process.Start("https://www.google.com")
            End If

            If (e.Result.Text = "facebook") Then
                Process.Start("https://wwww.facebook.com")

            End If

            If (e.Result.Text = " open facebook") Then
                Process.Start("https://wwww.facebook.com")

            End If

            If (e.Result.Text = "Restart windows") Then
                System.Diagnostics.Process.Start("shutdown", "-r -t 00")
                ' r is the restart
                ' t the time of shutting down
            End If

            If (e.Result.Text = "shutdown") Then
                System.Diagnostics.Process.Start("shutdown", "-s -t 00")
                's is shutting down
            End If

            If (e.Result.Text = "how old are you") Then
                SAPI.speak("I think I older than you I am joking with you I my developer doesnt give me access to tell you")
            End If

            If (e.Result.Text = "what is yor age") Then
                SAPI.speak("I think I older than you I am joking with you I my developer doesnt give me access to tell you")
            End If

            If (e.Result.Text = "can you speak arabic") Then
                SAPI.speak("now I cannot speak an arabic if you tell me why I will answer that Go and ask my developer")

            ElseIf (e.Result.Text = "do you have another langauge to speak") Then
                SAPI.speak("now I cannot speak an arabic if you tell me why I will answer that Go and ask my developer")

            ElseIf (e.Result.Text = "can you speak spanish") Then
                SAPI.speak("now I cannot speak a spanish if you tell me why I will answer that Go and ask my developer")

            ElseIf (e.Result.Text = "can you speak french") Then
                SAPI.speak("now I cannot speak a french if you tell me why I will answer that Go and ask my developer")
            End If

            If (e.Result.Text = "what is your favourite song" OrElse e.Result.Text = "what is your prefered song" OrElse e.Result.Text = "what is your best song") Then
                SAPI.Speak("in my mind if you want me to show this song on youtube i will")


            End If

            If (e.Result.Text = "ok show me") Then
                SAPI.speak("ok i will but you should now that when you tell ok again i will open this video")
                Process.Start("https://www.youtube.com/watch?v=W9P_qUnMaFg&list=RDGYFJjwXtsU4&index=5")
            End If

            If (e.Result.Text = "open google maps") Then
                Process.Start("https://www.google.com.eg/maps/")
            End If

            If (e.Result.Text = "how to fix slow in my windows") Then
                SAPI.speak("you should firstly check for any update for your windows")
                SAPI.speak("and then check the update for your graphic card whether invidia or AMD or Intel")
                SAPI.speak("i will open the official links to check update for it")
                Process.Start("https://www.amd.com/en/support")
                Process.Start("https://www.nvidia.com/Download/index.aspx")
                Process.Start("https://downloadcenter.intel.com/")
                SAPI.speak("after that we have the finally step")
                Process.Start("https://dl.dropboxusercontent.com/s/hanl7hxbhd72jek/s.png?dl=0")
                SAPI.speak("if there is no any change in the performance there is another way throug this image")
                Process.Start("https://dl.dropboxusercontent.com/s/1hftpl1c880titm/Untitled-2.png?dl=0")

            End If

        End If





    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CheckBox1.Checked = False 'to make communication between the picturebox on and the checkbox 
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        CheckBox1.Checked = True 'to make communication between the picturebox on and the checkbox 
        PictureBox3.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim closeornot As DialogResult = MessageBox.Show("Are you sure to exit", "Go-Alpha", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If (closeornot = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form3.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class