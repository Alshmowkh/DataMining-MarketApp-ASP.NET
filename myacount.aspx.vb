Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplicationState
Partial Class _Default
    Inherits System.Web.UI.Page
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtcmname.Text = Session("usr_name")
        ''WHERE eml_no=" & Session("user_name") & "
        Me.Label1.Text = Session("hello")
        Dim cona As New OleDbConnection
        cona.ConnectionString = ConfigurationManager.AppSettings("con")
        cona.Open()
        Dim sql As String = "select * from company  where cmp_no=" & Session("usr_name") & ""
        Dim dp As New OleDbDataAdapter
        Dim ds As New Data.DataSet
        dp = New OleDbDataAdapter(sql, cona)
        dp.Fill(ds, "company")
        Dim i As Integer
        For i = 0 To ds.Tables("company").Rows.Count - 1
            Me.txtcmname.Text = ds.Tables("company").Rows(i).Item(1)
        Next
    End Sub

    Protected Sub Menu14_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu14.MenuItemClick
        Response.Redirect("default.aspx")
        Session("usr_name") = 0
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cona As New OleDbConnection
        cona.ConnectionString = ConfigurationManager.AppSettings("con")
        cona.Open()
        Dim sql As String = "select * from company"
        Dim dp As New OleDbDataAdapter
        Dim ds As New Data.DataSet
        dp = New OleDbDataAdapter(sql, cona)
        dp.Fill(ds, "company")
        Dim savrr As New OleDbCommand
        savrr.Connection = cona
        ' Ì „ «” Œœ«„ Ã„·… «·«” ﬂÌÊ «· «·Œ«’… »«· ⁄œÌ·
        savrr.CommandText = "UPDATE company SET cmp_name='" & Me.txtcmname.Text & "',cmp_cntry='" & Me.drpcntry.Text & "',cmp_city='" & Me.drpcity.Text & "',cmp_strt='" & Me.drpstreet.Text & "',cmp_tel='" & Me.txttel.Text & "',cmp_mob='" & Me.txtmobile.Text & "',cmp_mail='" & Me.txtemail.Text & "',cmp_other='" & Me.txtother.Text & "' where cmp_no=" & Session("usr_name") & ""
        'Â‰« Ì „  ‰›Ì– «·Ã„·…
        savrr.ExecuteNonQuery()
        'MsgBox(" „ «· ⁄œÌ· »‰Ã«Õ", MsgBoxStyle.Information)
        cona.Close()

    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click

    End Sub

    Protected Sub drpstreet_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpstreet.TextChanged

    End Sub

    Protected Sub Menu2_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu2.MenuItemClick
        Me.txtcmname.Text = Session("usr_name")
        ''WHERE eml_no=" & Session("user_name") & "

        Dim cona As New OleDbConnection
        cona.ConnectionString = ConfigurationManager.AppSettings("con")
        cona.Open()
        Dim sql As String = "select * from company  where cmp_name='" & Me.Label1.Text & "'"
        Dim dp As New OleDbDataAdapter
        Dim ds As New Data.DataSet
        dp = New OleDbDataAdapter(sql, cona)
        dp.Fill(ds, "company")
        Dim i As Integer
        For i = 0 To ds.Tables("company").Rows.Count - 1
            Me.txtcmname.Text = ds.Tables("company").Rows(i).Item(1)
            Me.TextBox3.Text = ds.Tables("company").Rows(i).Item(0)
            Me.drpcntry.Text = ds.Tables("company").Rows(i).Item(2)
            Me.drpcity.Text = ds.Tables("company").Rows(i).Item(3)
            Me.drpstreet.Text = ds.Tables("company").Rows(i).Item(4)
            Me.txttel.Text = ds.Tables("company").Rows(i).Item(5)
            Me.txtmobile.Text = ds.Tables("company").Rows(i).Item(6)
            Me.txtemail.Text = ds.Tables("company").Rows(i).Item(7)
            Me.txtother.Text = ds.Tables("company").Rows(i).Item(8)

        Next
    End Sub
End Class
