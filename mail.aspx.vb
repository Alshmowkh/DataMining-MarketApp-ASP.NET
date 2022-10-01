Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplicationState
Partial Class _Default
    Inherits System.Web.UI.Page
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session("mail")

        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim i As Integer


        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT distinct * FROM email where eml_dsc='" & Session("mail") & "' ", con)
        dp.Fill(ds, "email")
        For i = 0 To ds.Tables("email").Rows.Count - 1
            'Me.txtname.Text = ds.Tables("email").Rows(0).Item(1)
            Me.txteml.Text = ds.Tables("email").Rows(0).Item(4)
            Me.txtdsc.Text = ds.Tables("email").Rows(0).Item(1)

        Next
        con.Close()
    End Sub
End Class
