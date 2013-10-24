function onLoad() {
	var eventSource = new Timeline.DefaultEventSource();
	//modification theme
	
	var maFonction = function(){ 
	console.log(this);
	return "images/red-circle.png";
	};
	
	
	var theme = Timeline.ClassicTheme.create(); // create the theme
        theme.event.instant.icon = maFonction();//avec un fonction anomyme pour charger dynamquement le chmein de l'image
	//theme.event.instant.icon = "images/red-circle.png";
	
	
	
	//console.log(maFonction());
   
   var bandInfos = [
     Timeline.createBandInfo({
         eventSource: eventSource,

	/** ZOOM **/
	/*zoomIndex:      5,
        zoomSteps:      new Array(
        {pixelsPerInterval: 100,  unit: Timeline.DateTime.DAY},
	{pixelsPerInterval: 50,  unit: Timeline.DateTime.DAY},
        {pixelsPerInterval: 300,  unit: Timeline.DateTime.MONTH},
	{pixelsPerInterval: 200,  unit: Timeline.DateTime.MONTH},
	{pixelsPerInterval: 100,  unit: Timeline.DateTime.MONTH}
        ),*/

         date: "Jun 28 2011 00:00:00 GMT",
         width: "70%",
         theme: theme,
         intervalUnit: Timeline.DateTime.MONTH,
         intervalPixels: 300,
     }),
     Timeline.createBandInfo({
        overview: true,
         eventSource: eventSource,
         date: "Jun 28 2011 00:00:00 GMT",
         width: "30%",
         intervalUnit: Timeline.DateTime.YEAR,
         intervalPixels: 400
     })
   ];
   bandInfos[0].syncWith = 1;
 
   
   tl = Timeline.create(document.getElementById("my-timeline"), bandInfos);
	
  Timeline.loadJSON("http://localhost:8085/ProjetJEE/Fluxjson?requete=requetedocument", function(json, url) {
       eventSource.loadJSON(json, url);
       $(document).trigger("timelineLoad");
   });   


 }





 


