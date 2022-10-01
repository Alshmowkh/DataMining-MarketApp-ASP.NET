Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplicationState
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Session("usr_name") = Me.TextBox2.Text
        Me.Label1.Visible = True
         If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Then
            Me.Label1.Text = "«”„ «·„‘—› «Ê ﬂ·„… «·—Ê— €Ì— „œŒ·…"
            Me.Label2.Visible = True
            Me.Label3.Visible = True
        Else
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim sql1 As String
            sql1 = "select * from Supervisors where super_name='" & Me.TextBox1.Text & "' and super_id=" & Val(Me.TextBox2.Text) & ""

            Dim DBCommand As New OleDbCommand()
            DBCommand.CommandText = sql1
            DBCommand.Connection = con
            Dim Myreader As System.Data.OleDb.OleDbDataReader
            ' Dim reader As New System.Data.OleDb.OleDbDataReader()
            Myreader = DBCommand.ExecuteReader()
            Myreader.Read()
            If (Myreader.HasRows = True) Then
                Myreader.Close()
                Response.Write(Session("super"))
                Me.Button2.Visible = True
                Me.Button3.Visible = True
                Me.Button4.Visible = True
                Me.Label1.Visible = False
                Me.Label2.Visible = False
                Me.Label3.Visible = False
                Me.Label4.Visible = False
                Me.Label5.Visible = False
                Me.TextBox2.Visible = False
                Me.TextBox1.Visible = False
                Me.Button1.Visible = False

                ' Response.Redirect("Default.aspx")

            ElseIf (Myreader.HasRows = False) Then
                Myreader.Close()
                Label1.Text = " «”„ «·„‘—› «Ê ﬂ·„… «·„—Ê— Œ«ÿ∆…"
            End If
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("admin1.aspx")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Response.Redirect("admin2.aspx")
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Response.Redirect("admin3.aspx")
    End Sub
End Class
