<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MediaPlayerMidterm._Default" %>



<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">
<div>
        <div>
            <asp:Button ID="btnPlay" runat="server" OnClick="btnPlay_Click" Text="Play" Width="157px" />
            <div>
            <asp:Button ID="btnSkip" runat="server"  Text="&gt;" Width="73px" OnClick="btnSkip_Click" />
</div>
        </div>
        </div>
        <asp:FileUpload ID="fuUpload" runat="server" />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" Width="157px" />

    </form>
</asp:Content>
