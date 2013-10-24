$(document).on("timelineLoad",function(){
	
	 var bande = $('.timeline-event-tape');//recupere l'enssemble des bandes doc de la frise
	 var longueurBande1 = bande.width();
	 
	//parcours chaque bande 
	//recuperer l'enssemble des opinions asssociées à un document pour placer les camememberts
	 bande.each(function( index ) {

		var bandecourante = $(this);
		
		//ajoute conteneur à la bande
		var style = $(this).attr('style').split(';');
		var gauche = style[0].split(':');
		var largeur = style[1].split(':');
		var top = style[3].split(':');

		bandecourante.wrap('<div class="new"/>');
		bandecourante.parent().css('background','blue');
		bandecourante.parent().css('left',gauche[1]);
		bandecourante.parent().css('width',largeur[1]);
		bandecourante.parent().css('height','4px');
		bandecourante.parent().css('top',top[1]);
		bandecourante.parent().css('position','relative');


		//recupere classename -> extrait le nom du document
		var classes = $(this).attr('class').split(' ');
		var docNom = classes[1];
		
		//requete ajax pour recuperer les opinions associés au document?
		/*var reponse = {};
		var xmlhttp = new XMLHttpRequest();
		alert('appel requete opinion');
		xmlhttp.open("GET", "http://localhost:8085/ProjetJEE/Fluxjson?requete=requeteopinion&argv="+docNom+"", true);
		xmlhttp.onreadystatechange = function () {
 			if (xmlhttp.readyState == 4 && xmlhttp.status == 200){
   				reponse = eval('('+xmlhttp.responseText+')');
   				alert('reponse requete opinion');
				//place les camemberts
				for (var i=0; i < reponse.opinion.length; i++){
					posCamembert(bandecourante.parent(), reponse.opinion[i]);
				}
				 
 			}
		};
		xmlhttp.send(null);*/

		var reponse = {};
		var xmlhttp = new XMLHttpRequest();
		xmlhttp.open("GET", "http://localhost:8085/ProjetJEE/Fluxjson?requete=requeteopinion&argv="+docNom, true);
		xmlhttp.onreadystatechange = function () {
		if (xmlhttp.readyState == 4 && xmlhttp.status == 200){
		reponse = eval('('+xmlhttp.responseText+')');

		//place les camemberts
		for (var i=0; i < reponse.opinion.length; i++){
			posCamembert(bandecourante.parent(), reponse.opinion[i]);
		}
		}
		};
		xmlhttp.send(null);
		 });
	
	$(document).trigger("evtChargee");
	//$(document).trigger("contraintesTemporelles");
});


//variables globales
var tabIdPhraseMinMax = new Array();
var tabIdPhraseFiltrer = ['2','3'];

$(document).on("evtChargee",function(){

	filtreContrainteSpatiale(tabIdPhraseFiltrer);

	//alert('chargement');
	/*$(window).mousewheel(function () {
		$(document).trigger("timelineLoad");
		//alert('appel evenement scroll');
	});*/

	//
	$('#my-timeline').mouseup(function () {
		//$(document).trigger("timelineLoad");
		$(document).trigger("contraintesTemporelles");
		//alert('appel evenement mouseup');
	});
});






$(document).on("contraintesTemporelles", function(){
	var dateMin = new Date(tl.getBand(0).getMinVisibleDate());
	var dateMax = new Date(tl.getBand(0).getMaxVisibleDate());
	//alert(dateMin.getFullYear() +' : '+ dateMax);
	var xmlhttp = new XMLHttpRequest();
	/*xmlhttp.open("GET", "http://localhost:8080/Que-pense-t-on-de-Montpellier-Agglomeration/Fluxjson?requete=requetecontraintesspatiales&datemin="+dateMin+"&datemax="+dateMax+"", true);*/
	xmlhttp.open("GET", "http://localhost/timeline-v2/contraintesTemp.json", true);
	xmlhttp.onreadystatechange = function () {
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200){
				reponse = eval('('+xmlhttp.responseText+')');
		
				//initialise tableau				
				tabIdPhrase = new Array();
				
				for (var i=0; i < reponse.ids.length; i++){
					tabIdPhraseMinMax.push(reponse.ids[i].id);
				}
				
			}
	};
	xmlhttp.send(null);
});
