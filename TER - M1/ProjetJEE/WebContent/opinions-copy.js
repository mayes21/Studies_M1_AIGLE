var map;
var epsg4326 ;
var epsg900913;
var epsg2154;
var style_green;
var vectorLayerJSON ;
      
    OpenLayers.ProxyHost = "/cgi-bin/proxy.cgi?url=";
    
    
function init() {
 
  var options = {
		controls: [],
		hover: false,
		projection: epsg900913,
		displayProjection: epsg4326,
		units : "m",
		extent: [-5, 35, 15, 55],
		maxResolution: 156543.0339,
		maxExtent: new OpenLayers.Bounds(-20037508, -20037508, 20037508, 20037508.34)
	};
	

 
 epsg4326 = new OpenLayers.Projection('EPSG:4326');
 epsg900913 = new OpenLayers.Projection('EPSG:900913');



  map = new OpenLayers.Map('', options);
  
  var osmLayer = new OpenLayers.Layer.OSM();
  var gmap = new OpenLayers.Layer.Google("Google Streets", {visibility: false});
  var gsat = new OpenLayers.Layer.Google(
	"Google Satellite",
	{type: google.maps.MapTypeId.SATELLITE, numZoomLevels: 22,
	sphericalMercator: true}
  );

  var opinionswms = new OpenLayers.Layer.WMS(
      "Toutes Opinions",
      "http://localhost:8080/geoserver/tiger/wms",
      {
      projection: epsg900913,
      layers: "tiger:ToutesOpinions",
      transparent: true,
      format: 'image/png'
      },
      {
      singleTile: false,
      opacity: 1,
      isBaseLayer : false
	
      });
  
    var opinionsnegatif = new OpenLayers.Layer.WMS(
  "Opinions Négatifs",
  "http://localhost:8080/geoserver/tiger/wms",
  {
  projection: epsg900913,
  layers: "tiger:negatop",
  transparent: true,
  format: 'image/png'
  },
  {
  singleTile: false,
  opacity: 1,
  isBaseLayer : false
});
    
     var opinionspostifs = new OpenLayers.Layer.WMS(
  "Opinions Positifs",
  "http://localhost:8080/geoserver/tiger/wms",
  {
  projection: epsg900913,
  layers: "tiger:Opinions-Positifs",
  transparent: true,
  format: 'image/png'
  },
  {
  singleTile: false,
  opacity: 1,
  isBaseLayer : false
});
    
     
  var sousquartiers = new OpenLayers.Layer.WMS(
  "Sous Quartiers",
  "http://localhost:8080/geoserver/tiger/wms",
  {
  projection: epsg900913,
  layers: "tiger:sousquartiers1",
  transparent: true,
  format: 'image/png'
  },
  {
  singleTile: false,
  opacity: 0.5,
  isBaseLayer : false
});
  
  var opinionsfilter = new OpenLayers.Layer.WMS(
  "OpinionsFilter",
  "http://localhost:8080/geoserver/tiger/wms",
  {
  projection: epsg900913,
  layers: "tiger:opinionFilter",
  transparent: true,
   cql_filter: 'somme>1',
  format: 'image/png'
  },
  {
  singleTile: false,
  opacity: 1,
  isBaseLayer : false
});
  
  
 var myStyles = new OpenLayers.StyleMap({
        "default": new OpenLayers.Style({
	  //label:"${nombre}",
            strokeColor: "${getFillColor}",
            fillColor: "${getFillColor}",
            strokeWidth: 2,
            strokeOpacity: 0.9,
            fillOpacity: 0.9,
            pointRadius: "${getpointradius}"
        },{
            context: {
                getFillColor:function(feature) {
		  var sum = 0;
		   for (var i=0;i<feature.cluster.length;i++){
		     
		     sum += parseFloat(feature.cluster[i].data.somme);

		   }
                    if (sum ==-1)
                        return '#F4FA58';
		    
                    else if (sum<0)
                        return '#FF0000';
		    else if (sum>0)
                        return '#00FF00';
                },
		nombre:function(feat) {
		  var sum = 0;
		   for (var i=0;i<feat.cluster.length;i++){
		     sum += parseFloat(feat.cluster[i].data.somme);
		   }
		   return sum;
                },
		getpointradius:function(radius){
		 var sum = 0; 
		  for (var i=0;i<radius.cluster.length;i++){
		     sum += parseFloat(radius.cluster[i].data.somme);
                   /* if (feat.cluster[0].data.somme >= 1)
		      
                        return feat.cluster[0].data.somme;
                    else 
                        return feat.cluster[0].data.somme;*/
		   }
                    return Math.min(radius.cluster.length, 7) + 5;
		  
		}
            }
        })
        ,"select": new OpenLayers.Style({
            fillColor: "#254117",
            strokeColor: " #254117",
        }),
        "hover": new OpenLayers.Style({
           fillOpacity: 0.3,
	   strokeOpacity : 1,
	   strokeWidth: 2.5
	   
        })
    });
 var val = 1;
 
  var filter = new OpenLayers.Filter.Comparison({
   type: OpenLayers.Filter.Comparison.EQUAL_TO,
   property: "somme",
   value: 1
});
  
  
  
 

 var wfsLayer = new OpenLayers.Layer.Vector(
                "WFS Opinions",
                {
                    strategies : [ 
                               new OpenLayers.Strategy.BBOX(),
				new OpenLayers.Strategy.Refresh({ "force": true }),
			       new OpenLayers.Strategy.Cluster()],
              opacity:0.9,
                    protocol: new OpenLayers.Protocol.WFS({
                        version: "1.1.0"
                        ,srsName: "EPSG:4326"
                        ,url: "http://localhost:8080/geoserver/wfs"
			
                        
                        ,featureType: "filteropinionnew"
                        ,geometryName: "geom_spatial",
			 extractAttributes: true
                    }),
		    //filter:filter
		    //styleMap : myStyles
		});
 
 wfsLayer["styleMap"]=myStyles;
 
 
 
 
  
 
            var report = function(e) {
                OpenLayers.Console.log(e.type, e.feature.id);
            };
 var highlightCtrl = new OpenLayers.Control.SelectFeature(wfsLayer, {
                hover: true,
                highlightOnly: true,
                renderIntent: "hover",
                eventListeners: {
                    beforefeaturehighlighted: report,
                    featurehighlighted: report,
                    featureunhighlighted: report
                }
            });

            var selectCtrl = new OpenLayers.Control.SelectFeature(wfsLayer,
                {clickout: true}
            );

            map.addControl(highlightCtrl);
            map.addControl(selectCtrl);

            highlightCtrl.activate();
            selectCtrl.activate();
  /*var mywfs = new OpenLayers.Layer.Vector(
			"Medicago",{
				strategies : [ new OpenLayers.Strategy.BBOX(),
				               new OpenLayers.Strategy.Fixed()
				,new OpenLayers.Strategy.Cluster({distance: 0.01})],
				protocol: new OpenLayers.Protocol.HTTP(
						{url : "http://localhost:8080/geoserver/wfs?",
							params: {format:"WFS",
							service: "WFS",
							version: "1.0.0",
							request: "GetFeature",
							typename: "tiger:opinionFilter",
							SRS: "EPSG:4326"},
							format : new OpenLayers.Format.GML()
						}),
						geometryName : "geom_spatial",
						stylemap: myStyles,
						extractAttributes: true
			});
  
  
  
  sf = new OpenLayers.Control.SelectFeature(mywfs, options)
map.addControl(sf);
sf.activate();



            var report = function(e) {
                OpenLayers.Console.log(e.type, e.feature.id);
            };
            
            var highlightCtrl = new OpenLayers.Control.SelectFeature(mywfs, {
                hover: true,
                highlightOnly: true,
                renderIntent: "hover",
                eventListeners: {
                    beforefeaturehighlighted: report,
                    featurehighlighted: report,
                    featureunhighlighted: report
                }
            });Opinions

            var selectCtrl = new OpenLayers.Control.SelectFeature(mywfs,
                {clickout: true}
            );

            map.addControl(highlightCtrl);
            map.addControl(selectCtrl);

            highlightCtrl.activate();
            selectCtrl.activate();*/

	
  

 

    map.addLayers([osmLayer, gmap, gsat,wfsLayer]);
    

   /*  var info = new OpenLayers.Control.WMSGetFeatureInfo({
            url: 'http://localhost:8080/geoserver/tiger/wms',
	    layers: [opinionspostifs,opinionsnegatif,opinionswms,sousquartiers],
            title: 'Informations',
            queryVisible: true,
            eventListeners: {
                getfeatureinfo: function(e) {
                   new GeoExt.Popup({
                title: "Feature Info",
                 autoWidth: true,
		 autoHeight: true,
               
		html:e.text,
               
                map: map,
                location: e.xy,
                
            }).show();
                }
            }
        });
        map.addControl(info);
        info.activate();*/
	
map.addControl(new OpenLayers.Control.MousePosition({displayProjection: epsg4326})); //affichage localisation de la souris
var mapBounds = new OpenLayers.Bounds(3.527489,43.353706,3.695807,43.406295).transform(epsg4326,epsg900913);
//vectorLayer.addFeatures([pointFeature, pointFeature2]);


map.zoomToMaxExtent();
map.addControl(new OpenLayers.Control.Navigation());
map.addControl(new OpenLayers.Control.PanZoomBar({zoomWorldIcon: true}));
map.addControl(new OpenLayers.Control.OverviewMap({autoPan : true}));
map.addControl(new OpenLayers.Control.KeyboardDefaults()); //se déplacer avec le clavier
map.addControl(new OpenLayers.Control.ScaleLine()); //barre d'échelle
map.addControl(new OpenLayers.Control.LayerSwitcher());


//************************* Sélection zoom*******************


var scaleStore = new GeoExt.data.ScaleStore({map: map});


var zoomSelector = new Ext.form.ComboBox({
        store: scaleStore,
        emptyText: "Zoom Level",
        tpl: '<tpl for="."><div class="x-combo-list-item">1 : {[parseInt(values.scale)]}</div></tpl>',
        editable: false,
        triggerAction: 'all', // needed so that the combo box doesn't filter by its current content
        mode: 'local' // keep the combo box from forcing a lot of unneeded data refreshes
    });

    zoomSelector.on('select', 
        function(combo, record, index) {
            map.zoomTo(record.data.level);
        },
        this
    );     

    map.events.register('zoomend', this, function() {
        var scale = scaleStore.queryBy(function(record){
            return this.map.getZoom() == record.data.level;
        });

        if (scale.length > 0) {
            scale = scale.items[0];
            zoomSelector.setValue("1 : " + parseInt(scale.data.scale));
        } else {
            if (!zoomSelector.rendered) return;
            zoomSelector.clearValue();
        }
    });
    
//***************************************************************
    

    var mapPanel = new GeoExt.MapPanel({
map: map,
region : 'center',
height: '800',
width: '600',
title: 'Opinions',
collapsible: false,
border: true,
extent: mapBounds,
//plugins: new GeoExt.ZoomSliderTip()
bbar: [zoomSelector]
});
    


var treeConfig = new OpenLayers.Format.JSON().write([
        {
            nodeType    : 'gx_baselayercontainer',
            text        : 'Fonds de cartes',
	    icon       : 'Layers.png'
            ,expanded   : false
            ,allowDrag  : false
            ,allowDrop  : false
            ,draggable  : false
        }, {
           text        : 'Points Opinions'
            ,allowDrag  : true
            ,allowDrop  : true
            ,draggable  : true
            ,icon       : 'image.jpg'
            ,expanded   : false
            ,children   : [
            
		 {
		   nodeType    : 'gx_layer'
                    ,draggable  : true
                    ,layer      : 'WFS Opinions'
                    ,qtip       : "WFS Opinions"
            	    ,icon       : 'pointvert.png'
		   
		 }
                
		
                
                
            ]
        }
        
], true);

    var layerTree = new Ext.tree.TreePanel({
        title       : "Layers"
        ,root: {
            nodeType    : "async"
            ,expanded   : true
            ,children   : Ext.decode(treeConfig)
        }
        ,loader: new Ext.tree.TreeLoader({
            applyLoader: false
        })
        ,animate    : true
        ,enableDD   : true
        ,useArrows  : true        
        ,rootVisible: false
    });
    
      function createPopup(feature) {
        var popupExt;  
      if (!popupExt) { 
       popupExt = new GeoExt.Popup({
            title: 'Berger',
            location: feature,
	    html: "<b>Département : "+feature.cluster[0].data.somme,
            maximizable: false,
            collapsible: false,
	    autoWidth: true,
	    unpinnable: false,
	    anchored: true,
        });
      popupExt.show();	
      }
            if (popupExt) { 
	  popupExt.feature = null;
	  popupExt.destroy();
       popupExt = new GeoExt.Popup({
            title: 'Berger',
            location: feature,
	    html:"<b>Département : "+ feature.cluster[0].data.somme,
            maximizable: false,
            collapsible: false,
	    autoWidth: true,
	    unpinnable: false,
	    anchored: true,
        });
     popupExt.show();	
      }
      }     
         
      /*  wfsLayer.events.on({
        featureselected: function(e) {
            createPopup(e.feature);
	   
	}
    });*/

 var accordion = new Ext.Panel({
        margins : '5 0 5 5'
        ,split  : true
        ,width  : 160
        ,layout :'accordion'
        ,items  : [layerTree]
    });  
 
	var eastPanel = new Ext.Panel({  
	title   : 'Légende et données'      
        ,region : 'east'
        , collapsible : 'true'
        ,layout : 'fit'
        ,width  : 220   
        ,items  : [accordion]
    });

	var content;
        var cont;
	var contjson;
	var contstring = "";
	
	var grid_store = new Ext.data.JsonStore({
	  
	  
	  fields: [
       {name: 'id', type: 'string'},
       {name: 'phrase',type: 'string'}
    ]
	});
    wfsLayer.events.on({
featureselected: function(e) {
if(typeof(popup) != "undefined"){
popup.destroy();
}
content ="<html><body><table border=1>" +
"<tr><th><font face=arial size=2><b>Id" +
"</b></font></th><th><font face=arial size=2><b>Test" +
"</b></font></th><tr>" ;
for (var i=0; i < e.feature.cluster.length; ++i)
content+=
"<tr><td><font face=arial size=2>"+e.feature.cluster[i].data.id_spatialentity+
"</font></td><td><font face=arial size=2>"+e.feature.cluster[i].data.contenu+
"</font></td></tr>";
content+="</table></body></html>"

var result1 = content;
cont = "";

for (var i=0; i < e.feature.cluster.length; ++i){
  if (e.feature.cluster.length == 1){
    cont+="[{\"id\": \""+ e.feature.cluster[i].data.id_spatialentity + "\",\"se_valeur\":\""+e.feature.cluster[i].data.se_valeur+"\",\"se_type\":\""+e.feature.cluster[i].data.se_type+"\",\"te_nom\":\""+e.feature.cluster[i].data.te_nom+"\",\"phrase\":\""+e.feature.cluster[i].data.contenu+"\"}]";
  }
  else if(i==0){
cont+="[{\"id\": \""+ e.feature.cluster[i].data.id_spatialentity + "\",\"se_valeur\":\""+e.feature.cluster[i].data.se_valeur+"\",\"se_type\":\""+e.feature.cluster[i].data.se_type+"\",\"te_nom\":\""+e.feature.cluster[i].data.te_nom+"\",\"phrase\":\""+e.feature.cluster[i].data.contenu+"\"},";
  }
  else if(i<e.feature.cluster.length-1){
cont+="{\"id\": \""+ e.feature.cluster[i].data.id_spatialentity + "\",\"se_valeur\":\""+e.feature.cluster[i].data.se_valeur+"\",\"se_type\":\""+e.feature.cluster[i].data.se_type+"\",\"te_nom\":\""+e.feature.cluster[i].data.te_nom+"\",\"phrase\":\""+e.feature.cluster[i].data.contenu+"\"},";
  }
  else{
    cont+="{\"id\": \""+ e.feature.cluster[i].data.id_spatialentity + "\",\"se_valeur\":\""+e.feature.cluster[i].data.se_valeur+"\",\"se_type\":\""+e.feature.cluster[i].data.se_type+"\",\"te_nom\":\""+e.feature.cluster[i].data.te_nom+"\",\"phrase\":\""+e.feature.cluster[i].data.contenu+"\"}]";

  }
}
    //  alert(cont);

      
      
    contstring = cont.toString();
    grid_view.getView().refresh();
    contjson = JSON.parse(contstring);
    
    contstring = JSON.stringify(contjson);
    //alert(contstring);
    
    var oneSite = Ext.data.Record.create([
            {"name": 'id'},
            {"name": 'phrase'},
	    {"name": 'te_nom'},
	    {"name": 'se_type'},
	    {"name": 'se_valeur'}
        ]);

    
    var readerr = new Ext.data.JsonReader({   
	type:'json',
	id: "id"
	
    });
    
    grid_store = new Ext.data.JsonStore({
      reader:readerr,
          autoLoad : true,

    fields: [
       {name: 'id', type: 'int'},
       {name: 'phrase',type: 'string'},
       {name: 'te_nom',type: 'string'},
       {name: 'se_type',type: 'string'},
       {name: 'se_valeur',type: 'string'}

    ],
    data: contjson,
});
    

    grid_view.store = grid_store;
    grid_view.getView().refresh();
    southPanel.expand(true);


}


});
    
      
   
   
   var lieuxBergersGridModel = new Ext.grid.ColumnModel({
columns: [
new Ext.grid.RowNumberer(),
 {
id : "id",
header : "id",
width : 150,
dataIndex : "id",
sortable: true
}, {
id : "phrase",
header : "Phrase",
width : 150,
dataIndex : "phrase",
sortable: true
} , {
id : "te_nom",
header : "te_nom",
width : 150,
dataIndex : "te_nom",
sortable: true
} , {
id : "se_type",
header : "se_type",
width : 150,
dataIndex : "se_type",
sortable: true
} , {
id : "se_valeur",
header : "se_valeur",
width : 150,
dataIndex : "se_valeur",
sortable: true
} 
]
});
   

    
    

    // create the Grid
var grid_view =new Ext.grid.GridPanel({
    store: grid_store,
    height: 350,
    colModel: lieuxBergersGridModel,
    width: 600,
   
    });
    
  

/*
    var storejson = new Ext.data.Store({
    autoLoad: true,
    data : contjson,
    model: {fields: [
        {name: 'name'},
        {name: 'phrase'}
	    ]},
    proxy: {
        type: 'memory',
        reader: {
            type: 'json',
            record: 'data_type'
        }
    }
});
    
    
    
    
 var grid = new Ext.grid.GridPanel({
	id: 'gridPanel',
	title     : 'Grid example',
	width     : 250,
	height    : 250,
      // renderTo  : 'grid-example',
	store     : storejson,
	columns: [
	    {    header: 'name',
		dataIndex: 'name'
	    },
	    {
		header: 'phrase',
		dataIndex: 'phrase'
	    }
	]          
    });    
    */
    
    
    var examplegrid = new Ext.Panel({
        title   : 'Départements'
        ,layout :'fit'      
    });    
    
  /* var leftSideGrid= {
		xtype:'panel',
		layout:'table',
		id:'totalPanel',
		border:true,
		defaults:{
		bodyStyle:'padding:5px;font-size:11px',
		border:false
		},
		
		layoutConfig: {
			columns: 2
		},
		
		items: [
    {html:'<b>Payments</b>',width:90}, {id:'numPayments',html:'0',width:90},
	{html:'<b>Total</b>',width:90}, {xtype: 'box', autoEl: {id:'total'},html:'$0.00',width:90},
    {html:'<b>Subtotal</b>'},{id:'subTotal',html:'$0.00',width:'100%'},
    {html:'<b>Grand Total</b>'},{id:'grTotal',html:'$0.00',width:'100%'}
		]
	};*/
	
	
	
	var southPanel = new Ext.Panel({
	  title: 'Détail opinions',
region : 'south',
layout : 'fit',
collapsed: true,
//hidden:true,
collapsible: true,
width : '100%',
height : 150,
items : [grid_view]
});


new Ext.Viewport({
layout: "border",
defaults: {
split: true
},
items: [
mapPanel,
eastPanel,
southPanel
]
});
}


  