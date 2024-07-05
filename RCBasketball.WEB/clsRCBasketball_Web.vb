Imports System.Net.Mail

Public Class clsRCBasketball_Web
    Public Sub SendMailMessage(ByVal theNotification As String)

        Try



            Dim [to] As String = My.Settings.EmailTo
            Dim [cc] As String = String.Empty

            Dim mMailMessage As New MailMessage()

            mMailMessage.From = New MailAddress(My.Settings.EmailFrom)   ' Set the sender address of the mail message
            mMailMessage.To.Add([to])  ' Set the recepient address of the mail message

            ' Check If the bcc value Is null Or an empty string
            If (My.Settings.EmailBcc <> Nothing) AndAlso (My.Settings.EmailBcc <> String.Empty) Then
                'Set the Bcc address of the mail message
                mMailMessage.Bcc.Add(New MailAddress(My.Settings.EmailBcc))
            End If

            If (My.Settings.EmailCc <> Nothing) AndAlso (My.Settings.EmailCc <> String.Empty) Then  ' Check if the cc value is null or an empty value
                ' Set the CC address of the mail message
                mMailMessage.CC.Add([cc])
            End If

            mMailMessage.Subject = My.Settings.EmailSubject  ' Set the subject of the mail message"
            mMailMessage.Body = theNotification  ' Set the body of the mail message
            mMailMessage.IsBodyHtml = True  ' Set the format of the mail message body as HTML
            mMailMessage.Priority = MailPriority.Normal ' Set the priority of the mail message to normal

            Dim mSmtpClient As New SmtpClient(My.Settings.SmtpServerID) ' Instantiate a new instance of SmtpClient

            mSmtpClient.Send(mMailMessage) ' Send the mail message

            mMailMessage.Dispose()

        Catch ex As Exception

        End Try
    End Sub
End Class
