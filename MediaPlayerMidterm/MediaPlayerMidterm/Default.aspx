<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MediaPlayerMidterm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE HTML>

    <html>
    <head>
        <%-- CSS template header--%>
        <title>Visualize by TEMPLATED</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" href="assets/css/main.css" />
        <%-- End CSS Template--%>


        <%--jPlayer/jQuery Header--%>
        <link type="text/css" href="/skin/pink.flag/jplayer.pink.flag.css" rel="stylesheet" />
        <script type="text/javascript" src="Scripts/jquery-3.1.1.min.js"></script>
        <script type="text/javascript" src="jPlayer_Scripts/jquery.jplayer.min.js"></script>


        <script type="text/javascript">
            $(document).ready(function () {
                $("#jquery_jplayer_1").jPlayer({
                    ready: function () {
                        $(this).jPlayer("setMedia", {
                            title: "Bubble",
                            m4a: "http://www.jplayer.org/audio/m4a/Miaow-07-Bubble.m4a",
                            oga: "http://www.jplayer.org/audio/ogg/Miaow-07-Bubble.ogg"
                        });
                    },
                    cssSelectorAncestor: "#jp_container_1",
                    swfPath: "/js",
                    supplied: "m4a, oga",
                    useStateClassSkin: true,
                    autoBlur: false,
                    smoothPlayBar: true,
                    keyEnabled: true,
                    remainingDuration: true,
                    toggleDuration: true
                });
            });
        </script>
        <%--End jplayer header--%>
    </head>







    <body>

        <!-- Wrapper -->
        <div id="wrapper">

            <!-- Header -->
            <header id="header">
                <span class="avatar">
                    <img src="images/avatar.jpg" alt="" /></span>
                <h1>This is <strong>Visualize</strong>, a responsive site template designed by <a href="http://templated.co">TEMPLATED</a><br />
                    and released for free under the Creative Commons License.</h1>


                <%--  Create jPlayer interface--%>
                <div id="jquery_jplayer_1" class="jp-jplayer"></div>
                <div id="jp_container_1" class="jp-audio" role="application" aria-label="media player">
                    <div class="jp-type-single">
                        <div class="jp-gui jp-interface">
                            <div class="jp-volume-controls">
                                <button class="jp-mute" role="button" tabindex="0">mute</button>
                                <button class="jp-volume-max" role="button" tabindex="0">max volume</button>
                                <div class="jp-volume-bar">
                                    <div class="jp-volume-bar-value"></div>
                                </div>
                            </div>
                            <div class="jp-controls-holder">
                                <div class="jp-controls">
                                    <button class="jp-play" role="button" tabindex="0">play</button>
                                    <button class="jp-stop" role="button" tabindex="0">stop</button>
                                </div>
                                <div class="jp-progress">
                                    <div class="jp-seek-bar">
                                        <div class="jp-play-bar"></div>
                                    </div>
                                </div>
                                <div class="jp-current-time" role="timer" aria-label="time">&nbsp;</div>
                                <div class="jp-duration" role="timer" aria-label="duration">&nbsp;</div>
                                <div class="jp-toggles">
                                    <button class="jp-repeat" role="button" tabindex="0">repeat</button>
                                </div>
                            </div>
                        </div>
                        <div class="jp-details">
                            <div class="jp-title" aria-label="title">&nbsp;</div>
                        </div>
                        <div class="jp-no-solution">
                            <span>Update Required</span>
                            To play the media you will need to either update your browser to a recent version or update your <a href="http://get.adobe.com/flashplayer/" target="_blank">Flash plugin</a>.
                        </div>
                    </div>
                </div>
                <%--    End jPlayer interface--%>


                <ul class="icons">
                    <li><a href="#" class="icon style2 fa-twitter"><span class="label">Twitter</span></a></li>
                    <li><a href="#" class="icon style2 fa-facebook"><span class="label">Facebook</span></a></li>
                    <li><a href="#" class="icon style2 fa-instagram"><span class="label">Instagram</span></a></li>
                    <li><a href="#" class="icon style2 fa-500px"><span class="label">500px</span></a></li>
                    <li><a href="#" class="icon style2 fa-envelope-o"><span class="label">Email</span></a></li>
                </ul>
            </header>
            <!-- Main -->
            <section id="main">

                <!-- Thumbnails -->
                <section class="thumbnails">
                    <div>
                        <a href="images/fulls/01.jpg">
                            <img src="images/thumbs/01.jpg" alt="" />
                            <h3>Lorem ipsum dolor sit amet</h3>
                        </a>
                        <a href="images/fulls/02.jpg">
                            <img src="images/thumbs/02.jpg" alt="" />
                            <h3>Lorem ipsum dolor sit amet</h3>
                        </a>
                    </div>
                    <div>
                        <a href="images/fulls/03.jpg">
                            <img src="images/thumbs/03.jpg" alt="" />
                            <h3>Lorem ipsum dolor sit amet</h3>
                        </a>
                        <a href="images/fulls/04.jpg">
                            <img src="images/thumbs/04.jpg" alt="" />
                            <h3>Lorem ipsum dolor sit amet</h3>
                        </a>
                        <a href="images/fulls/05.jpg">
                            <img src="images/thumbs/05.jpg" alt="" />
                            <h3>Lorem ipsum dolor sit amet</h3>
                        </a>
                    </div>
                    <div>
                        <a href="images/fulls/06.jpg">
                            <img src="images/thumbs/06.jpg" alt="" />
                            <h3>Lorem ipsum dolor sit amet</h3>
                        </a>
                        <a href="images/fulls/07.jpg">
                            <img src="images/thumbs/07.jpg" alt="" />
                            <h3>Lorem ipsum dolor sit amet</h3>
                        </a>
                    </div>
                </section>

            </section>

            <!-- Footer -->
            <footer id="footer">
                <p>&copy; Untitled. All rights reserved. Design: <a href="http://templated.co">TEMPLATED</a>. Demo Images: <a href="http://unsplash.com">Unsplash</a>.</p>
            </footer>

        </div>

        <!-- Scripts -->
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/js/jquery.poptrox.min.js"></script>
        <script src="assets/js/skel.min.js"></script>
        <script src="assets/js/main.js"></script>



    </body>
    </html>
</asp:Content>
