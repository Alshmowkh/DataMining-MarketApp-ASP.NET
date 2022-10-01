Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplicationState
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        'Ì „ Ã·» ·»Ì«‰«  „‰ «·ÃœÊ·
        Dim dp As New OleDbDataAdapter("SELECT email.eml_no, email.eml_dsc, email.eml_r, email.eml_ur, email.eml_pers, email.eml_date, email.cmp_no FROM company INNER JOIN email ON company.cmp_no = email.cmp_no ", con)
        ' Ì „  ⁄»∆… «·œ« « ”Ì  »«·ÃœÊ·
        dp.Fill(ds, "email")
        Dim n As Date = Now
        Dim a As Boolean = False
        Dim b As Boolean = True
        Dim s As New OleDbCommand
        s.Connection = con
        Dim q As Integer = 5
        '    s.CommandType = Data.CommandType.Text
        ' Â‰« Ì „ «÷«›… Ã„·Â «·«” ﬂÌÊ «· «·Œ«’… »«·«œŒ«·
        s.CommandText = "insert into email (  eml_dsc, eml_r, eml_ur, eml_pers, eml_date,cmp_no)values ('" & Me.txtdsc.Text & "'," & a & "," & b & ",'" & Me.TextBox1.Text & "','" & n & "'," & Me.label1.text & ")"
        'Ì „  ‰›Ì– Ã„·… «·«” ﬂÌÊ «·
        s.ExecuteNonQuery()
        con.Close()

    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.txteml.Text = Session("b")
        Me.txtdsc.Text = Session("sub")
        Me.Label1.Text = Session("no")

    End Sub
End Class
