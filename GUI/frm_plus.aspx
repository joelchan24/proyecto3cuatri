﻿<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_plus.aspx.cs" Inherits="GUI.frm_plus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <script type="text/javascript" src='https://maps.google.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyCuiUJxL3eVPwCyGdf1P6g9TUQ4KW95YtA'></script>
    
 <style>
        #map_canvas {
    width: 500px;
    height: 400px;
    margin: 2em auto;
}
    </style>

    <div id="map_canvas"></div>

     <script>

        var markers = [
  ['Bondi Beach ,kjakjkja , hjhjhj', -33.890542, 151.274856],
  ['Coogee Beach', -33.923036, 151.259052],
  ['Cronulla Beach', -34.028249, 151.157507],
  ['Manly Beach', -33.80010128657071, 151.28747820854187],
  ['Maroubra Beach', -33.950198, 151.259302]
        ];

        function initializeMaps() {
            var myOptions = {
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                mapTypeControl: false
            };
            var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
            var infowindow = new google.maps.InfoWindow();
            var marker, i;
            var bounds = new google.maps.LatLngBounds();

            for (i = 0; i < markers.length; i++) {
                var pos = new google.maps.LatLng(markers[i][1], markers[i][2]);
                bounds.extend(pos);
                marker = new google.maps.Marker({
                    position: pos,
                    map: map
                });
                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                    return function () {
                        infowindow.setContent(markers[i][0]);
                        infowindow.open(map, marker);
                    }
                })(marker, i));
            }
            map.fitBounds(bounds);
        }

        initializeMaps();




    </script>




















</asp:Content>
