<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrimeFactorer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Please input a positive integer greater than 1: </p>
            <p>
                <asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="goButton" runat="server" Text="Go" OnClick="goButton_Click" /><br /><br />
            <asp:Label ID="resultLabel" runat="server" Text="Your number's prime factors are:"></asp:Label>
        </div>
    </form>
</body>
</html>
