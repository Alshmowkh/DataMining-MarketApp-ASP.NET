<%@ Page Language="VB" AutoEventWireup="false" CodeFile="admin3.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

function TABLE1_onclick() {

}

function TextArea1_onclick() {

}

// ]]>
</script>
</head>
<body style="background-color: buttonface">
    <form id="form1" runat="server">
    
    
        <table align="center" style="width: 600px" border="0" dir="rtl">
            <tr>
                <td colspan="7" style="height: 96px; width: 600px;" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/image/d.gif" Width="598px" /></td>
                        
            </tr>
            <tr>
                <td style="width: 600px; height: 77px" align="right" colspan="7" dir="rtl" valign="bottom">
                    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" Width="600px">
                        <DynamicItemTemplate>
                            <%# Eval("Text") %>
                        </DynamicItemTemplate>
                        <Items>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/mine.jpg" Text=" " Value="mine"></asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/shop.jpg" Text=" " Value="shop"></asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/desk.jpg" Text=" " Value="desk"></asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/labtop.jpg" Text=" " Value="labtop">
                            </asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/device.jpg" Text=" " Value="device">
                            </asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/about.jpg" Text=" " Value="about"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                    <asp:Menu ID="Menu3" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2"
                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="White" Height="30px" Orientation="Horizontal"
                        StaticSubMenuIndent="10px" Style="font-weight: normal; font-size: 20pt; background-image: url(image/panel3.jpg)"
                        Width="600px">
                        <StaticSelectedStyle BackColor="#5D7B9D" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicHoverStyle BackColor="#7C6F57" BorderColor="#0000C0" BorderWidth="12px" ForeColor="White" />
                        <DynamicMenuStyle BackColor="#F7F6F3" BorderWidth="12px" />
                        <DynamicSelectedStyle BackColor="#5D7B9D" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticHoverStyle BackColor="Maroon" ForeColor="White" />
                        <Items>
                            <asp:MenuItem NavigateUrl="~/Default.aspx" Text="«·—∆Ì”Ì…" Value="Home"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/searchdesk.aspx" Text="ﬂ„»ÌÊ — „ﬂ »Ì" Value="dec"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/searchlab.aspx" Text="·«»  Ê»" Value="lap"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/searchdvc.aspx" Text="«·ﬁÿ⁄" Value="dvc"></asp:MenuItem>
                            <asp:MenuItem Text="—«”‹‹·‹‹‰«" Value="contact"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
            </tr>
            <tr>
                <td colspan="7" dir="rtl" valign="top" style="width: 600px; height: 17px;">
                    <table style="width: 600px">
                        <tr>
                            <td style="background-image: url(image/left.gif); width: 140px" valign="top">
                                <br />
                            </td>
                            <td colspan="2" 
                                style="background-image: none; width: 460px; background-color: #ffffff;" 
                                valign="top">
                                <table dir="rtl" style="width: 432px">
                                    <tr>
                                        <td colspan="3" style="color: #000000" align="center">
                                            <br />
                                            <strong>
                                            ≈÷«›… «⁄·«‰</strong><br />
                                            <table dir="rtl" style="width: 411px; height: 246px;">
                                                <tr>
                                                    <td style="height: 20px" align="right" colspan="4" valign="top">
                                                        «·ﬁ”„&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;<br />
                                                        <asp:DropDownList ID="dropdept" runat="server" Width="204px">
                                                            <asp:ListItem>«·ﬂ„»ÌÊ —«  «·„ﬂ »Ì…</asp:ListItem>
                                                            <asp:ListItem>«·ﬂ„»ÌÊ —«  «·„Õ„Ê·…</asp:ListItem>
                                                            <asp:ListItem>«·ﬁÿ⁄</asp:ListItem>
                                                            <asp:ListItem>«·⁄—Ê÷ </asp:ListItem>
                                                        </asp:DropDownList>
                                                        <br />
                                                        «·⁄—÷ &nbsp;&nbsp;<br />
                                                        <asp:TextBox ID="txtadvr" runat="server" Width="400px" Height="40px" TextMode="MultiLine"></asp:TextBox>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" align="right" colspan="4">
                                                        «· «—ÌŒ<asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="120px" ShowGridLines="True" Width="408px">
                                                            <SelectedDayStyle BackColor="#000040" Font-Bold="True" />
                                                            <SelectorStyle BackColor="#FFCC66" />
                                                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                                            <OtherMonthDayStyle ForeColor="#CC9966" />
                                                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                                        </asp:Calendar>
                                                    </td>
                                                </tr>
                                            </table>
                                            <asp:Label ID="Label1" runat="server" Font-Bold="False" ForeColor="Red" Text="Label"
                                                Visible="False" Width="240px"></asp:Label>
                                            &nbsp; &nbsp;&nbsp;
                                            <p class="MsoNormal" dir="rtl" style="margin: 0cm 0cm 0pt">
                                                <span lang="AR-SA">
                                                    <asp:Button ID="ButtonAdd" runat="server" Height="24px" Text="≈÷«›…" 
                                                    Width="48px" style="background-image: url(image/d.gif)" />&nbsp;<asp:Button
                                                        ID="Button3" runat="server" Height="24px" Text=" ⁄œÌ·" Width="48px" />
                                                    <asp:Button ID="Button4" runat="server" Height="24px" Text="Õ–›" Width="48px" />
                                                    <asp:Button ID="Button5" runat="server" Height="24px" Text="»ÕÀ" Width="48px" /></span></p>
                                            <p class="MsoNormal" dir="rtl" style="margin: 0cm 0cm 0pt">
                                                <span lang="AR-SA">
                                            <asp:Image ID="Image2" runat="server" Height="122px" Width="88px" />
                                                </span>
                                                <br />
                                                <asp:LinkButton ID="LinkButton1" runat="server" Width="64px">„⁄«Ì‰…</asp:LinkButton>
                                            <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Red" Visible="False" Width="120px"></asp:Label><br />
                                            </p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="3" style="color: #ffffff">
                                            «·⁄—Ê÷<br />
                                            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                                            <br />
                                            &nbsp;&nbsp;<br />
                                            &nbsp; &nbsp;
                                            &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                        </td>
                                    </tr>
                                    </table>
                            </td>
                        </tr>
                        </table>
                </td>
            </tr>
            <tr>
                <td colspan="7" 
                    style="background-image: url(image/footer.gif); height: 60px; width: 600px;" 
                    dir="rtl" valign="top">
                </td>
            </tr>
        </table>
    
   
    </form>
</body>
</html>
