Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplicationState
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '@@@@
        If Session("usr_name") = "" Then
            Response.Redirect("default.aspx")
        Else
            Me.Label1.Text = Session("hello")
            Me.Label1.Visible = True
            Me.Label2.Visible = True
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim m As Boolean = True
            Dim a As Integer = Session("usr_name")
            Dim dp As New OleDbDataAdapter("SELECT email.eml_no, email.eml_dsc, email.eml_r, email.eml_ur, email.eml_pers, email.eml_date, email.cmp_no FROM company INNER JOIN email ON company.cmp_no = email.cmp_no where eml_ur=" & m & " AND email.cmp_no=" & a & "", con)
            Dim ds As New Data.DataSet
            dp.Fill(ds, "mail")
            con.Close()
            Dim i As Integer
            Dim q As Integer
            For i = 0 To ds.Tables("mail").Rows.Count - 1
                'ds.Tables("mail").Rows.Count(-1)
                If ds.Tables("mail").Rows(i).Item("eml_ur") = True Then
                    q = i + 1
                    Me.LinkButton1.Text = q
                End If
            Next
            GridView2.DataSource = ds
            GridView2.DataBind()
        End If
    End Sub

    Protected Sub Menu14_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu14.MenuItemClick
        '3.0
        Session("usr_name") = Nothing
        Response.Redirect("default.aspx")
    End Sub
    Protected Sub GridView2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.SelectedIndexChanged
        '1
        Dim i As Integer
        For i = 0 To Me.GridView2.Rows.Count - 1
            Session("sa") = Me.GridView2.SelectedDataKey(i).ToString()
        Next
    End Sub

    Protected Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        '2.1
        If (e.CommandName = "Repaly") Then
            Dim EmailNo As Int32
            EmailNo = Convert.ToInt32(e.CommandArgument.ToString())
            Response.Redirect("Mail.aspx?MailNo={0}", EmailNo)
        End If
    End Sub

    Protected Sub Menu2_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu2.MenuItemClick

    End Sub

    Protected Sub Menu7_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu7.MenuItemClick

    End Sub
End Class
