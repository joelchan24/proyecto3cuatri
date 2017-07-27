<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_plus.aspx.cs" Inherits="GUI.frm_plus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <script  type="text/javascript"src="http://maps.google.com/maps/api/js?sensor=falseplaces&key=AIzaSyCuiUJxL3eVPwCyGdf1P6g9TUQ4KW95YtA" ></script>
   
    
 <style>
        #map_canvas {
    width: 1100px;
    height: 500px;
    margin: 1em auto;
}
    </style>
    <div class="container">
    <div class="panel panel-default">
        <div class="panel-heading">
             <h3 class="panel-title">EVENTOS CULTURALES</h3>
        </div>
        <div class="panel-body">
             <div id="map_canvas"></div>
         </div>
        
    
    </div>
      </div>
          
     <script>
        
       
         var markers = [
               <asp:Repeater ID="Repeater1" runat="server">
           <ItemTemplate>
  [' <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%>,<%# DataBinder.Eval(Container.DataItem,"nombrecat")%> ,<%# DataBinder.Eval(Container.DataItem,"UBICACIONGEOGRAFICA")%>', <%# DataBinder.Eval(Container.DataItem,"LATITUD")%>,<%# DataBinder.Eval(Container.DataItem,"LONGITUD")%>]
,    </ItemTemplate>
 </asp:Repeater>
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
