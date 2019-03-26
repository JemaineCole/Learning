<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="aspDotNetCrud.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            EmployeeID<asp:TextBox ID="txtEmployeeID" runat="server" style="margin-left: 30px" OnTextChanged="txtEmployeeID_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="btDisplay" runat="server" OnClick="btDisplay_Click" Text="Display" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btClear" runat="server" OnClick="btClear_Click" Text="Clear" />
        <p>
            <asp:Label ID="lblSuccessMsg" runat="server" ForeColor="#00FF40"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblErrorMsg" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                </Columns>
            </asp:GridView>
        </p>
    </form>
</body>
</html>
