Imports System.IO
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim result As DialogResult = oFile.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Dim sPath As String = oFile.FileName

            Dim fileReader As StreamReader = New StreamReader(sPath)

            Do While fileReader.Peek > -1
                txtString.Text += fileReader.ReadLine() + Environment.NewLine
            Loop

            fileReader.Close()

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtString.Text <> "" Then
            Dim sConnStr As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
            Dim objConnection As New SqlConnection(sConnStr)

            Try
                Dim sql As String = "sptblDescription_InsertData"

                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = objConnection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = sql
                        .Parameters.Add("@Desc", SqlDbType.VarChar).Value = txtString.Text
                    End With
                    objConnection.Open()
                    cmd.ExecuteNonQuery()

                End Using
            Catch ex As Exception

            Finally
                objConnection.Close()

            End Try

        End If
    End Sub
End Class
