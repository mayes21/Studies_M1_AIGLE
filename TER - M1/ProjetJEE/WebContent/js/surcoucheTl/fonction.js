function posCamembert(ele, reponse){
	
	var posOpinion = reponse.pos * ele.width() / 100;//produite en croix
	var urlImage = reponse.urlImg;
	var taille = reponse.taille;
	var idPhrase = reponse.id;
	
	 var niveau = (taille / 2) * -1;
		
	 ele.append('<img class="camembert id-phrase-'+idPhrase+'" src="'+urlImage+'" style="position:absolute; margin-top:'+niveau+'px; margin-left: '+posOpinion+'px;"></img>');
	var tmp = reponse.phrases[0].contenu;
	//alert(tmp);
	 //ici : chargement fonction click sur les evenements
}


//tabId : tableau d'entier
function filtreContrainteSpatiale(tabId){
		for (var i=0; i < tabId.length; i++){
			var tmp = "img.id-phrase-"+tabId[i];
			$(tmp).hide();
		}
}
