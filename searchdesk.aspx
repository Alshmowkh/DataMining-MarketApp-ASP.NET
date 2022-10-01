<%@ Page Language="VB" AutoEventWireup="false" CodeFile="searchdesk.aspx.vb" Inherits="_Default" %>

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



// ]]>
</script>
</head>
<body style="background-color: buttonface">
    <form id="form1" runat="server" method="post">
        <table align="center" style="width: 600px" border="0" dir="rtl">
            <tr>
                <td colspan="7" style="height: 96px; width: 661px;" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/image/d.gif" Width="598px" /></td>
                        
            </tr>
            <tr>
                <td style="width: 661px; height: 77px" align="right" colspan="7" dir="rtl" valign="bottom">
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
                <td colspan="7" rowspan="4" dir="rtl" valign="top" style="width: 661px; height: 17px;">
                    <table style="width: 600px">
                        <tr>
                            <td rowspan="2" style="background-image: url(image/left.gif); width: 140px" valign="top">
                                <br />
                                <table style="width: 140px">
                                    <tr>
                                        <td style="font-size: 12pt; background-image: none; width: 56px; height: 22px">
                                            «·„‹”‹ Œ‹œ„</td>
                                        <td colspan="2">
                                            <asp:TextBox ID="TextBox1" runat="server" Width="84px"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: 12pt; width: 56px">
                                            &nbsp;ﬂ·„… «·”—</td>
                                        <td colspan="2">
                                            <asp:TextBox ID="TextBox2" runat="server" Width="84px"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                        </td>
                                        <td align="center" colspan="2" valign="middle">
                                            <asp:Button ID="Button1" runat="server" Font-Bold="False" Font-Size="Medium" Text="œŒÊ·"
                                                Width="56px" /></td>
                                    </tr>
                                </table>
                            </td>
                            <td colspan="2" rowspan="2" style="background-image: none; width: 460px; background-color: #ffffff;" valign="top">
                                <table dir="rtl" style="width: 432px">
                                    <tr>
                                        <td colspan="3" style="color: #000000" align="center">
                                            <br />
                                            &nbsp;„Ê«’›«  «·ﬂ„»ÌÊ — «·„ﬂ »Ì «·–Ì  —€» ›Ì ‘—«¡Â&nbsp;<br />
                                            <table dir="rtl" style="width: 368px">
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        «·œÊ·…</td>
                                                    <td style="width: 100px; height: 20px">
                                                        <asp:DropDownList ID="drpcntry" runat="server" Width="100px" AutoPostBack="True">
                                                            <asp:ListItem>«Œ — «·œÊ·…</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                    <td style="width: 100px; height: 20px">
                                                        «·„œÌ‰…</td>
                                                    <td style="width: 105px; height: 20px">
                                                        <asp:DropDownList ID="drpcity" runat="server" Width="105px" AutoPostBack="True">
                                                            <asp:ListItem>«Œ — «·„œÌ‰…</asp:ListItem>
                                                            <asp:ListItem></asp:ListItem>
                                                        </asp:DropDownList></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        „—ﬂ“ «·»Ì⁄</td>
                                                    <td style="width: 100px; height: 20px" valign="top"><asp:DropDownList ID="drpcmp" runat="server" Width="100px" AutoPostBack="True">
                                                        <asp:ListItem>«Œ — „‰ «·ﬁ«∆„…</asp:ListItem>
                                                    </asp:DropDownList></td>
                                                    <td style="width: 100px; height: 20px">
                                                        «·‰Ê⁄</td>
                                                    <td style="width: 105px; height: 20px">
                                                        <asp:DropDownList ID="drptypecm" runat="server" Width="105px" AutoPostBack="True" ForeColor="Black">
                                                            <asp:ListItem>«Œ — «·‰Ê⁄</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        «·„ÊœÌ·</td>
                                                    <td style="width: 100px; height: 20px">
                                                        <asp:DropDownList ID="dropmodel" runat="server" Width="100px" AutoPostBack="True">
                                                            <asp:ListItem>«Œ — «·„ÊœÌ·</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                    <td style="width: 100px; height: 20px">
                                                        </td>
                                                    <td style="width: 105px; height: 20px">
                                                        <asp:Button ID="Button6" runat="server" Height="24px" Text="»ÕÀ" Width="72px" /></td>
                                                </tr>
                                                <tr>
                                                    <td align="left" colspan="4" style="height: 20px">
                                                        <br />
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="4" style="height: 20px">
                                                        <asp:Button ID="Button4" runat="server" Height="24px" Text="√ŸÂ— «·„Ê«’›« " Width="96px" Visible="False" /></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        <asp:Label ID="lb3" runat="server" Font-Size="Smaller" Text="«·Â«—œ œ”ﬂ" Visible="False"
                                                            Width="85px"></asp:Label></td>
                                                    <td align="center" style="width: 100px; height: 20px">
                                                        <asp:Label ID="lb4" runat="server" Text=" " Visible="False" Width="100px" ForeColor="#C04000"></asp:Label></td>
                                                    <td style="width: 100px; height: 20px">
                                                        <asp:Label ID="lb7" runat="server" Text="«·„⁄«·Ã" Visible="False" Width="100px"></asp:Label></td>
                                                    <td style="width: 105px; height: 20px">
                                                        <asp:Label ID="lb8" runat="server" Text=" " Visible="False" ForeColor="#C04000" Width="105px"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        <asp:Label ID="lb5" runat="server" Text="«·–«ﬂ—…" Visible="False" Width="85px"></asp:Label></td>
                                                    <td style="width: 100px; height: 20px">
                                                        <asp:Label ID="lb6" runat="server" Text=" " Visible="False" ForeColor="#C04000" Width="100px"></asp:Label></td>
                                                    <td style="width: 100px; height: 20px">
                                                        <asp:Label ID="Label9" runat="server" Text="«·‘«‘…" Visible="False" Width="100px"></asp:Label></td>
                                                    <td style="width: 105px; height: 20px">
                                                        <asp:Label ID="lb10" runat="server" Text=" " Visible="False" ForeColor="#C04000" Width="105px"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        <asp:Label ID="Label11" runat="server" Text="«Œ—Ï " Visible="False" Width="85px"></asp:Label></td>
                                                    <td style="width: 100px; height: 20px">
                                                        <asp:Label ID="lb12" runat="server" Text=" " Visible="False" ForeColor="#C04000" Width="100px"></asp:Label></td>
                                                    <td style="width: 100px; height: 20px">
                                                        <asp:Label ID="Label1" runat="server" Text="«·”⁄—" Visible="False" Width="100px"></asp:Label></td>
                                                    <td style="width: 105px; height: 20px">
                                                        <asp:Label ID="lb14" runat="server" Text=" " Visible="False" ForeColor="#C04000" Width="105px"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="4" rowspan="3" valign="middle">
                                                        <br />
                                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
                                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="sendcomp" runat="server"
                                                            Font-Bold="True" Font-Size="12pt" Text=" —«”· «·„Õ·" Width="104px" />
                                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                        &nbsp; &nbsp; &nbsp; &nbsp;</td>
                                                </tr>
                                                <tr>
                                                </tr>
                                                <tr>
                                                </tr>
                                            </table>
                                            &nbsp;
                                            &nbsp; &nbsp;&nbsp;
                                            <p class="MsoNormal" dir="rtl" style="margin: 0cm 0cm 0pt">
                                                <span lang="AR-SA">&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                                                </span></p>
                                            <br />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="3" rowspan="2" style="color: #ffffff">
                                            «·⁄—Ê÷<br />
                                            <br />
                                            &nbsp; &nbsp;
                                            &nbsp; &nbsp;
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td colspan="7" rowspan="1" style="background-image: url(image/footer.gif); height: 60px; width: 661px;" dir="rtl" valign="top">
                </td>
            </tr>
        </table>
    
   
    </form>
</body>
</html>
