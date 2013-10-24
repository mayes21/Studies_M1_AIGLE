import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Iterator;
import java.util.Random;
import java.util.Set;
import java.util.Vector;

import org.json.JSONArray;
import org.json.JSONObject;

import com.bdd.RequeteBdd;


public class ParseurRequete {
	
	public static String ParserRequeteDocuments(ResultSet resultat) throws SQLException {		
		/**/

		/* Depreciate
		 * String[] avis = {"positif", "neutre", "negatif"};
		String[] urlImage = {"images/green-circle.png", "images/orange-circle.png", "images/red-circle.png"};*/
		
		
		JSONObject Retour = new JSONObject();
		Retour.put("wiki-url", "http://simile.mit.edu/shelf/");
		Retour.put( "wiki-section", "Simile JFK Timeline");
		Retour.put("dateTimeFormat", "Gregorian");
		
		
		JSONObject evenement = new JSONObject();
		
		 while ( resultat.next() ) {
			 
			 Date start = resultat.getDate("datedebut");
			 Date end = resultat.getDate("datefin");
			 String titre = resultat.getString("file_name");
			 String classname = titre.replaceAll(" ", "-");
			 /*String description = resultat.getString("description");
			 int opinion = resultat.getInt("opinion");*/
			
			//creation document
			evenement = new JSONObject();
			evenement.put("start", start);
			evenement.put("end", end);
			evenement.put("title", titre);
			evenement.put("classname", classname);
			
			/* depraciate
			evenement.put("title", titre);
			evenement.put("description", description);
			switch (opinion) {
			case -1:
				evenement.put("icon", urlImage[2]);
				evenement.put("classname", avis[2]);
				break;
				
			case 0:
				evenement.put("icon", urlImage[1]);
				evenement.put("classname", avis[1]);
				break;
			case 1:
				evenement.put("icon", urlImage[0]);
				evenement.put("classname", avis[0]);
				break;

			default:
				break;
			}
			
			*/
			//rajoute evenement
			Retour.append("events", evenement);
		}
		 	
		return Retour.toString();
	}
	
	public static String ParserRequeteOpinion(ResultSet resultat, String nomDoc) throws SQLException {

		JSONObject Retour = new JSONObject();

		 while ( resultat.next() ) {
			 
			 JSONObject opinion = new JSONObject();
			 
			 //recupere pour chaque date du document o_neg, o_neutre, o_pos
			 int o_neg = resultat.getInt("o_neg");
			 int o_neu = resultat.getInt("o_neu");
			 int o_pos = resultat.getInt("o_pos");
	 	 
			 int nbOp = o_neg + o_neu + o_pos;

			 int taille = 0;

			if (taille == 1) {
				taille = 30;
			}else if (taille == 2){
				taille = 40;
			}else{
				taille = 50;
			}
			
			 
			//genere url google chart 
			 String url = "http://chart.apis.google.com/chart?cht=p&chd=t:"+o_pos+","+o_neg+","+o_neu+"&chs="+taille+"x"+taille+"&chco=096A09,FF0000,FDF1B8&chf=bg,s,ffffff00";
			 opinion.put("urlImg", url);
			 opinion.put("taille", taille);
			 
			 RequeteBdd test = new RequeteBdd();
		
			 //pour chaque date recupere l'enssembles des phrase associés
			 try{
				 ResultSet res = test.requetePhraseParDateEtDoc(resultat.getString("file_name"),resultat.getString("te_valeur"));

				 while (res.next()){
					 JSONObject tmpjson = new JSONObject();
					 tmpjson.put("contenu", res.getString("contenu"));
					 opinion.append("phrases", tmpjson);
				 }
				 
			 }catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			 
			 //calcule position evenement sur la frise			
			 Date dateEvt = resultat.getDate("te_valeur");
			 long posEvent = 0;
				try {
					
					Vector<Date> debfin = test.requeteDebutFinDocument(nomDoc);
					Date debut = debfin.get(0);
					Date fin = debfin.get(1);

					
					long intervalle = fin.getTime() - debut.getTime();
					long eventIntervalle = dateEvt.getTime() - debut.getTime();
					
					posEvent = (eventIntervalle * 100) / intervalle;					
					opinion.put("pos",posEvent);
									
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				test.fermerConnexion();		
				
				Retour.append("opinion", opinion);
		 }
		 
		return Retour.toString();
	}
	
	
	public static String ParserRequeteContraintesSpatiales(ResultSet resultat) throws SQLException {
		
		
		/**/
		JSONObject Retour = new JSONObject();	

		 while ( resultat.next() ) {
			 Retour.put("id", resultat.getInt("id"));
		 }
		//System.out.println(Retour);
		return Retour.toString();
	}
	
	
	public static String jeuxTestContraintesSpatiales(){
		String retour = "{'ids':[{'id' : 1},{'id' : 2}]}";
		return retour;
	}
	
	
	public static String jeuxTestOpinion(){
		String retour = "{'opinion':[" +
				"{'pos':'20','urlImg':'images/red-circle.png','taille':10, 'id' : 1, 'phrases':[{'id': 1, 'contenu' : 'phase1'},{'id': 2, 'contenu' : 'phase2'}]}," +
				"{'pos':'50','urlImg':'images/green-circle.png','taille':10, 'id' : 2, 'phrases':[{'id': 1, 'contenu' : 'phase1'},{'id': 2, 'contenu' : 'phase2'}]}," +
				"{'pos':'80','urlImg':'images/orange-circle.png','taille':10, 'id' : 3, 'phrases':[{'id': 1, 'contenu' : 'phase1'},{'id': 2, 'contenu' : 'phase2'}]}," +
								"]}";
		
		
		return retour;
	}
	
	
	public static String jeuxTestDocument(){
		String retour = "{'wiki-url':'http://simile.mit.edu/shelf'," +
				"'wiki-section':'Simile Cubism Timeline'," +
				"'dateTimeFormat':'Gregorian'," +
				"'events':[" +
					"{'start':'May 28 2011 09:00:00 GMT'," +
					"'end':'Jun 28 2011 09:00:00 GMT'," +
					"'title':'Bande-1','classname':'Nom-doc1'}," +
					
				    "{'start':'Jun 16 2011 00:00:00 GMT'," +
				    "'end':'Aug 30 2011 00:00:00 GMT'," +
				    "'title':'Bande-2','classname':'Nom-doc2'}," +
				    
				    "{'start':'Jul 16 2011 00:00:00 GMT'," +
				    "'end':'Aug 30 2011 00:00:00 GMT'," +
				    "'title':'Bande-3'," +
				    "'classname':'Nom-doc3'}]}";
		
		
		return retour;
	}


}
