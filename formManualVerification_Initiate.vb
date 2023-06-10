Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formManualVerification_Initiate

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Form1.FormVerification1.BringToFront()

    End Sub

    Private Sub verifyID()

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server = '" & My.Settings.NameOfServer & "'; port = '" & My.Settings.ConnectionPort & "'; user = '" & My.Settings.Username & "'; Password = '" & My.Settings.Password & "'; database = '" & My.Settings.NameOfDatabase & "'; default command timeout = 10000"

        Dim READER As MySqlDataReader

        Try

            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from voter_management where PersonalIDNumber = '" & txtGhanaCardNumber.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            If READER.HasRows Then

                Form1.FormManualVerification1.FormManualVerification_Doodle1.BringToFront()
                loadingProgressBar.Hide()
                formManualThumbprint.ShowDialog()

            Else

                Form1.FormManualVerification1.FormManualVerification_Error1.BringToFront()
                loadingProgressBar.Hide()

            End If
            READER.Close()

            MySqlConn.Close()

        Catch ex As Exception

            Dim folderPath As String = "C:\VoteManagement"

            If Directory.Exists(folderPath) Then

                IO.File.AppendAllText("C:\VoteManagement\Applicationlog.txt", String.Format("{0}[{1}]{2}", Environment.NewLine, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"), ex.ToString()))

            Else

                My.Computer.FileSystem.CreateDirectory("C:\VoteManagement")
                IO.File.AppendAllText("C:\VoteManagement\Applicationlog.txt", String.Format("{0}[{1}]{2}", Environment.NewLine, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"), ex.ToString()))

            End If

        Finally

            MySqlConn.Dispose()

        End Try

    End Sub

    Private Sub btnVerifyID_Click(sender As Object, e As EventArgs) Handles btnVerifyID.Click

        If txtGhanaCardNumber.Text = "" Or Trim(txtGhanaCardNumber.Text).Length < 1 Then

            MessageBox.Show("Ghana Card number required!")

        Else

            loadingTimer.Start()

        End If

    End Sub

    Private Sub loadingTimer_Tick(sender As Object, e As EventArgs) Handles loadingTimer.Tick

        loadingProgressBar.Show()

        loadingProgressBar.Minimum = 0
        loadingProgressBar.Maximum = 100

        loadingProgressBar.Value = loadingProgressBar.Value + 10

        If loadingProgressBar.Value >= 100 Then

            loadingTimer.Enabled = False

            Try

                verifyID()
                loadingProgressBar.Value = 0
                loadingProgressBar.Hide()

            Catch ex As Exception

                Dim folderPath As String = "C:\VoteManagement"

                If Directory.Exists(folderPath) Then

                    IO.File.AppendAllText("C:\VoteManagement\Applicationlog.txt", String.Format("{0}[{1}]{2}", Environment.NewLine, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"), ex.ToString()))

                Else

                    My.Computer.FileSystem.CreateDirectory("C:\VoteManagement")
                    IO.File.AppendAllText("C:\VoteManagement\Applicationlog.txt", String.Format("{0}[{1}]{2}", Environment.NewLine, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"), ex.ToString()))

                End If

            End Try

        End If

    End Sub
End Class
