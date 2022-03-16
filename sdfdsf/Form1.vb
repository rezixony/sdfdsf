Imports HtmlAgilityPack

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url = "https://www.worldometers.info/coronavirus/"
        Dim web As HtmlWeb = New HtmlWeb()
        Dim htmlDoc = web.Load(url)
        Dim node = htmlDoc.DocumentNode.SelectSingleNode("//*[translate(@id,'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')='maincounter-wrap']/div/span")
        MsgBox(node.InnerHtml.ToString)
        txtCoronaCases.Text = node.InnerHtml.ToString
        'MsgBox(htmlDoc.DocumentNode.InnerHtml)
    End Sub


End Class
