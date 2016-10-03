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
                    <asp:Repeater ID="rptMusic" runat="server" OnItemCommand="rptMusic_ItemCommand">
                        <ItemTemplate>
                            <div>
                                <a>
                                    <div>
                                        <div>
                                            <asp:Label id="lblMusicPath" runat ="server" Text='<%# DataBinder.Eval(Container.DataItem, "MusicPath")  %>' Visible="false"></asp:Label>
                                            <p><%# DataBinder.Eval(Container.DataItem, "ArtistName")  %>       <%# DataBinder.Eval(Container.DataItem, "TrackName")  %> </p>
                                            
                                        </div>
                                    </div>
                           </a> </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>

<form id="form1" runat="server">
        <asp:FileUpload ID="fuUpload" runat="server" />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" Width="157px" />

    </form>
</asp:Content>
