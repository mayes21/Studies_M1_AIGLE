function googlecharts(jsondata) {
      google.load("visualization", "1", {packages:["corechart"]});
      
      google.setOnLoadCallback(drawChart);
      
      
      /*var jsontext = '{"opinionpositive":38,"opinionneutre":13,"opinionnegative":0}';*/
 /*     var json2 = new Array();
     
 var json2 = (function() {
        var json = null;
        $.ajax({
            'async': false,
            'global': false,
            'url': "opinions.json",
            'dataType': "json",
            'success': function (data) {
                json2 = data;
            }
        });
        return json2;
    })();
    */
     // var json = jsondata.toString();
    //alert(json);
     var parse = jsondata;
     // var jsontext = JSON.stringify(json, null, null);
     // alert(jsontext);
       //   var parse = JSON.parse(json);
	  drawChart();
     
     /* var jsontext = JSON.stringify(content, null, null);
      alert(jsontext);
      var parse = JSON.parse(content);*/
 var chart
      
      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Opinions', 'Statistiques'],
          ['Opinion positives', parse.opinionpositive],
          ['Opinions negatives', parse.opinionnegative],
          ['Opinions neutres', parse.opinionneutre]
        ]);
	
	//alert(jsontext);

        var options = {
          title: 'Composante opinion',
          chartArea:{left:40,top:40,width:"62%",height:"75%"},
           colors:['096A09','FF0000','FFA500']
        };

       chart = new google.visualization.PieChart(document.getElementById('chart_div'));
	
	

        chart.draw(data, options);
      }
      
      
      }
 