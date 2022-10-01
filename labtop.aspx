<%@ Page Language="VB" AutoEventWireup="false" CodeFile="labtop.aspx.vb" Inherits="_Default" %>

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
    <form id="form1" runat="server">
   
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
                                <asp:Menu ID="Menu2" runat="server" ForeColor="Blue" Height="24px" Style="font-size: 16pt;
                                    color: activecaption">
                                    <StaticHoverStyle BackColor="ActiveCaption" ForeColor="White" />
                                    <Items>
                                        <asp:MenuItem NavigateUrl="~/myacount.aspx" Text="Õ”«»Ì" Value="New Item"></asp:MenuItem>
                                    </Items>
                                </asp:Menu>
                                <asp:Menu ID="Menu5" runat="server" ForeColor="Blue" Height="24px" Style="font-size: 16pt;
                                    color: activecaption">
                                    <StaticHoverStyle BackColor="ActiveCaption" ForeColor="White" />
                                    <Items>
                                        <asp:MenuItem NavigateUrl="~/desk.aspx" Text="ﬂ„»ÌÊ — „ﬂ »Ì" Value="New Item"></asp:MenuItem>
                                    </Items>
                                </asp:Menu>
                                <asp:Menu ID="Menu6" runat="server" ForeColor="Blue" Height="24px" Style="font-size: 16pt;
                                    color: activecaption">
                                    <StaticHoverStyle BackColor="ActiveCaption" ForeColor="White" />
                                    <Items>
                                        <asp:MenuItem NavigateUrl="~/device.aspx" Text="«·ﬁÿ⁄" Value="New Item"></asp:MenuItem>
                                    </Items>
                                </asp:Menu>
                                <asp:Menu ID="Menu7" runat="server" ForeColor="Blue" Height="24px" Style="font-size: 16pt;
                                    color: activecaption">
                                    <StaticHoverStyle BackColor="ActiveCaption" ForeColor="White" />
                                    <Items>
                                        <asp:MenuItem NavigateUrl="~/admin3.aspx" Text="«·⁄—Ê÷" Value="New Item"></asp:MenuItem>
                                    </Items>
                                </asp:Menu>
                                <asp:Menu ID="Menu14" runat="server" ForeColor="#0000C0" Height="24px" Style="font-size: 16pt;
                                    color: activecaption">
                                    <Items>
                                        <asp:MenuItem Text="Œ—ÊÃ" Value="New Item"></asp:MenuItem>
                                    </Items>
                                </asp:Menu>
                            </td>
                            <td colspan="2" rowspan="2" style="background-image: none; width: 460px; background-color: #ffffff;" valign="top">
                                <table dir="rtl" style="width: 432px">
                                    <tr>
                                        <td colspan="3" style="color: #000000" align="center">
                                            <br />
                                            <br />
                                            «œŒ· „Ê«’›«  «··«»  Ê» «·–Ì  —€» ›Ì ≈÷«› Â<br />
                                            <br />
                                            <table dir="rtl" style="width: 368px">
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        «·„ÊœÌ·</td>
                                                    <td style="width: 105px; height: 20px" valign="top">
                                                        <asp:TextBox ID="txtmodel" runat="server" Width="100px"></asp:TextBox></td>
                                                    <td style="width: 91px; height: 20px">
                                                        «·‰Ê⁄</td>
                                                    <td style="width: 110px; height: 20px">
                                                        <asp:TextBox ID="Texttype" runat="server" Width="100px"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px; height: 20px">
                                                        «·Â«—œÌ”ﬂ</td>
                                                    <td style="width: 105px; height: 20px">
                                                        <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox></td>
                                                    <td style="width: 91px; height: 20px">
                                                        «·–«ﬂ—…</td>
                                                    <td style="width: 110px; height: 20px">
                                                        <asp:TextBox ID="TextBox2" runat="server" Width="100px"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px">
                                                        «·„⁄«·Ã</td>
                                                    <td style="width: 105px">
                                                        <asp:TextBox ID="txtprss" runat="server" Width="100px"></asp:TextBox></td>
                                                    <td style="width: 91px">
                                                        «·‘«‘…</td>
                                                    <td style="width: 110px">
                                                        <asp:TextBox ID="txtscrn" runat="server" Width="105px"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 85px">
                                                        «·”⁄—</td>
                                                    <td style="width: 105px">
                                                        <asp:TextBox ID="txtcost" runat="server" Width="100px"></asp:TextBox></td>
                                                    <td style="width: 91px">
                                                        √Œ—Ï</td>
                                                    <td style="width: 110px">
                                                        <asp:TextBox ID="txtdother" runat="server" Width="105px"></asp:TextBox></td>
                                                </tr>
                                            </table>
                                            <asp:Label ID="Label1" runat="server" Font-Bold="False" ForeColor="Red" Text="Label"
                                                Visible="False" Width="240px"></asp:Label>
                                            &nbsp; &nbsp;&nbsp;
                                            <p class="MsoNormal" dir="rtl" style="margin: 0cm 0cm 0pt">
                                                <span lang="AR-SA">&nbsp;<asp:Button ID="Button5" runat="server" Height="24px" Text="≈÷«›…" Width="72px" /><asp:Button
                                                        ID="Button2" runat="server" Height="24px" Text=" ⁄œÌ·" Width="72px" /><asp:Button
                                                            ID="Button3" runat="server" Height="24px" Text="Õ–›" Width="72px" /></span><br />
                                            <br />
                                            </p>
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
