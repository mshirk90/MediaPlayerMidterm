<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MediaPlayerMidterm._Default" %>



<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">

    <p>
        <br />
    </p>

    <p>
    </p>
    <p>
   
    </p>
    <p>

    </p>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        <div>

            <div>
                <div>
                 
                   <%-- <asp:Repeater ID="rptMusic" runat="server" OnItemCommand="rptMusic_ItemCommand">
                        <ItemTemplate>
                            <div>
                                <address></address>
                                <a id='<%# DataBinder.Eval(Container.DataItem, "MusicPath")  %>' href="Default.aspx">
                                    <div>
                                        <div>
                                            <asp:Label id="lblMusicPath" runat ="server" Text='<%# DataBinder.Eval(Container.DataItem, "MusicPath")  %>' Visible="false"></asp:Label>
                                            <p><%# DataBinder.Eval(Container.DataItem, "ArtistName")  %>       <%# DataBinder.Eval(Container.DataItem, "TrackName")  %> </p>
                                            
                                        </div>
                                    </div>
                           </a> </div>
                        </ItemTemplate>
                    </asp:Repeater>--%>
                </div>
            </div>
        </div>

<form id="form1" runat="server">


    <div>
                     <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" DataSourceID="dsMusicDatabase" DataTextField="ArtistName" DataValueField="ArtistName" CausesValidation="True" Height="85px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="1493px">
            <asp:ListItem Value="ArtistName">Artist Name</asp:ListItem>
                 <asp:ListItem Value="TrackName">Track Name</asp:ListItem>
                 <asp:ListItem Enabled="False" Value="MusicPath">Music Path</asp:ListItem>
        </asp:ListBox>
        <asp:SqlDataSource ID="dsMusicDatabase" runat="server" ConnectionString="<%$ ConnectionStrings:MattsPracticeDatabaseConnectionString %>" SelectCommand="SELECT [ArtistName], [TrackName], [MusicPath] FROM [tblPost]"></asp:SqlDataSource>
    </div>




      <div><label>Artist</label>  <asp:TextBox ID="txtArtist" runat="server"></asp:TextBox></div>
       <div> <label>Track</label>  <asp:TextBox ID="txtTrack" runat="server"></asp:TextBox></div>
        <asp:FileUpload ID="fuUpload" runat="server" />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" Width="157px" />

        <br />

    </form>
</asp:Content>
