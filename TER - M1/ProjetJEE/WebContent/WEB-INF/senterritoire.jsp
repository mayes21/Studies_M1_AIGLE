 <%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<title>Opinions TER 2013</title>

<meta http-equiv="content-type" content="text/html; charset=utf-8"/>
<script type="text/javascript" src="http://www.openlayers.org/api/OpenLayers.js"></script>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
<script src="http://maps.google.com/maps/api/js?v=3.6&sensor=false"></script>

<script src="opinions.js"> </script>
<script src="googlecharts.js"> </script>

<script src="ext-3.4.0/adapter/ext/ext-base.js" type="text/javascript"></script>
<script src="ext-3.4.0/ext-all.js"  type="text/javascript"></script>
<script src="ext-3.4.0/src/locale/ext-lang-fr.js" type="text/javascript"></script>
<script src="GeoExt/lib/GeoExt.js" type="text/javascript"></script>
<script type="text/javascript" src="https://www.google.com/jsapi"></script>
<script src="http://code.jquery.com/jquery-1.9.1.js"></script>

<script type="text/javascript" src="GVisualizationPanel.js"></script>


<script>
      var json = {"opinionpositive":0,"opinionneutre":0,"opinionnegative":0};
      var jsontext = JSON.stringify(json, null, null);
      //var parse = JSON.parse(jsontext);
    googlecharts(jsontext);
</script>

<!-- frise -->
<!-- mode offline -->
<script src="js/jquery-1.8.1.min.js"></script>
<script src="js/timeline/src/ajax/api//simile-ajax-api.js?bundle=false" type="text/javascript"></script>
<script src="js/timeline/src/webapp/api/timeline-api.js?bundle=false" type="text/javascript"></script>

<script src="js/timeline-simile.js" type="text/javascript"></script>
<script src="js/surcoucheTl/surcoucheTl.js" type="text/javascript"></script>
<script src="js/surcoucheTl/fonction.js" type="text/javascript"></script>
<script src="js/surcoucheTl/trigger.js" type="text/javascript"></script>


<link rel="stylesheet" href="style2.css" type="text/css">
<link rel="stylesheet" href="exemples.css" type="text/css">
<link rel="stylesheet" type="text/css" href="ext-3.4.0/resources/css/ext-all.css"></link>
<link rel="stylesheet" type="text/css" href="ext-3.4.0/resources/css/xtheme-gray.css" /></link>
<link rel="stylesheet" type="text/css" href="GeoExt/resources/css/geoext-all.css"></link>

  </head>
  
  <body onLoad="onLoad(); init(); initializeChart();">

	 <div id="my-timeline" style="height: 150px; border: 1px solid #aaa"></div>
    <div id="mainpanel" style="float: left"></div> 
    <div id="chart_div" style="float: right"></div>   
    
    
    
  </body>
</html>
