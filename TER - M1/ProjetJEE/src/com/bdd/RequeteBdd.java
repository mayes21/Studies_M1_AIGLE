package com.bdd;

import java.io.Console;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Vector;
 
import javax.servlet.http.HttpServletRequest;
 
public class RequeteBdd {
	
    /* debug */
    private List<String> messages = new ArrayList<String>();
    
    /*proprietes*/
    String url = "jdbc:postgresql://postgresql.alwaysdata.com:5432/stagesgeom_senterritoire";
    String utilisateur = "stagesgeom_senterritoire";
    String motDePasse = "senterritoire";
    Connection connexion = null;
    Statement statement = null;
    ResultSet resultat = null;
    
    /*constructeur*/
    public RequeteBdd(){
    	ouvrirConnexion();
    }
 
    /*methodes*/
    public void ouvrirConnexion(){
	    /* Chargement du driver JDBC pour Postgresql */
	    try {
	    	System.out.println("Chargement du driver..."); 
	        Class.forName( "org.postgresql.Driver");
	        System.out.println("Driver chargé !");
	    } catch ( ClassNotFoundException e ) {
	        System.out.println("Erreur lors du chargement : le driver n'a pas été trouvé dans le classpath ! <br/>"
	                + e.getMessage() );
	    }
	    
	    try {
			connexion = DriverManager.getConnection(url,utilisateur,motDePasse);
			System.out.println( "Connexion réussie !" );
		} catch (SQLException e1) {
			// TODO Auto-generated catch block
			System.out.println("Connexion echoue");
			e1.printStackTrace();
		}
        
	    
    	try {	 
	        /* Création de l'objet gérant les requêtes */
	       statement = connexion.createStatement();
	       System.out.println( "Objet requête créé !" );
	 
	    } catch ( SQLException e ) {
	    	System.out.println( "Erreur lors de la connexion : <br/>"
	                + e.getMessage() );
	    } finally {
	    	/*System.out.println( "Fermeture de l'objet ResultSet." );
	        if ( resultat != null ) {
	            try {
	                resultat.close();
	            } catch ( SQLException ignore ) {
	            }
	        }
	        messages.add( "Fermeture de l'objet Statement." );
	        if ( statement != null ) {
	            try {
	                statement.close();
	            } catch ( SQLException ignore ) {
	            }
	        }
	        messages.add( "Fermeture de l'objet Connection." );
	        if ( connexion != null ) {
	            try {
	                connexion.close();
	            } catch ( SQLException ignore ) {
	            }
	        }*/
	    }
    }
    public void fermerConnexion(){
    	try {
                resultat.close();
            } catch ( SQLException ignore ) {}
        messages.add( "Fermeture de l'objet Statement." );

        try {
              statement.close();
        } catch ( SQLException ignore ) {}
        
        messages.add( "Fermeture de l'objet Connection." );
        try {
        	connexion.close();
        } catch ( SQLException ignore ) {}
    }
    
    public List<String> executerTests( HttpServletRequest request ) {
    	    /* Chargement du driver JDBC pour Postgresql */
    	    try {
    	        messages.add( "Chargement du driver..." );
    	        Class.forName( "org.postgresql.Driver");
    	        messages.add( "Driver chargé !" );
    	    } catch ( ClassNotFoundException e ) {
    	        messages.add( "Erreur lors du chargement : le driver n'a pas été trouvé dans le classpath ! <br/>"
    	                + e.getMessage() );
    	    }
    	 
    	    /* Connexion à la base de données */
    	    //String url = "jdbc:postgresql://localhost:5432/senterritoire";
    	    String url = "jdbc:postgresql://postgresql.alwaysdata.com:5432/stagesgeom_senterritoire";
    	    String utilisateur = "stagesgeom_senterritoire";
    	    String motDePasse = "senterritoire";
    	    Connection connexion = null;
    	    Statement statement = null;
    	    ResultSet resultat = null;
    	    try {
    	        messages.add( "Connexion à la base de données..." );
    	        connexion = DriverManager.getConnection(url,utilisateur,motDePasse);
    	        messages.add( "Connexion réussie !" );
    	 
    	        /* Création de l'objet gérant les requêtes */
    	       statement = connexion.createStatement();
    	        messages.add( "Objet requête créé !" );
    	 
    	        /* Exécution d'une requête de lecture */
    	        resultat = statement.executeQuery( "SELECT N.doc_dat_creat AS start, D.file_name AS title, A.a_nom AS description, D.source AS link," +								
    	        		"											CAST(Op.o_value AS INTEGER) AS opinion" +
    	        		"											FROM public.document D, public.notice N, public.opinionacteurdocument Op, public.acteur A " +
    	        		"											WHERE D.id_document=cast(N.doc_id as int) " +
    	        		"											AND D.id_document=Op.id_document " +
    	        		"											AND Op.id_acteur=A.id_acteur");
    	  
    	        /* Récupération des données du résultat de la requête de lecture */
    	        while ( resultat.next() ) {
    	        	String titre = resultat.getString("title");
    	        	String description = resultat.getString("description");
    	        	int opinion = resultat.getInt("opinion");
    	            messages.add( "Données retournées par la requête = " + titre + description+ opinion );
    	        }
    	    } catch ( SQLException e ) {
    	        messages.add( "Erreur lors de la connexion : <br/>"
    	                + e.getMessage() );
    	    } finally {
    	        messages.add( "Fermeture de l'objet ResultSet." );
    	        if ( resultat != null ) {
    	            try {
    	                resultat.close();
    	            } catch ( SQLException ignore ) {
    	            }
    	        }
    	        messages.add( "Fermeture de l'objet Statement." );
    	        if ( statement != null ) {
    	            try {
    	                statement.close();
    	            } catch ( SQLException ignore ) {
    	            }
    	        }
    	        messages.add( "Fermeture de l'objet Connection." );
    	        if ( connexion != null ) {
    	            try {
    	                connexion.close();
    	            } catch ( SQLException ignore ) {
    	            }
    	        }
    	    }
    	 
    	    return messages;
   }
    
    /*recupere la date de creation d'un document et sa date de fin */
    public Vector<Date> requeteDebutFinDocument(String nom) throws SQLException{
    	Vector<Date> retour = new Vector<Date>();
    	
    	String requete = "SELECT D.file_name, MIN(T.te_valeur) AS DateDebut, MAX(T.te_valeur) AS DateFin " +
				"FROM public.document D, public.paragraphe Pa, public.phrase Ph, public.index_te I, public.temporalentity T " +
				"WHERE D.id_document = Pa.id_document " +
				" AND  Pa.id_paragraphe = Ph.id_paragraphe " +
				" AND  Ph.id_phrase = I.id_phrase " +
				" AND  I.id_temporalentity = T.id_temporalEntity " +
				" AND D.file_name = '" +nom+"'"+ 
				"GROUP BY D.file_name";

			try {
			/* Exécution d'une requête de lecture */
			resultat = statement.executeQuery(requete);
			
			} catch ( SQLException e ) {
			System.out.println("Erreur lors de la connexion : <br/>"
			        + e.getMessage() );
			System.out.println("requete : requeteDebutFinDocument");
			} finally {}
			
			while (resultat.next()) {
				Date tmp1 = resultat.getDate("datedebut");
				Date tmp2 = resultat.getDate("datefin");
				//System.out.println(tmp1 + " " + tmp2);
				retour.add(tmp1);
				retour.add(tmp2);
			}
    	
    	return retour;
    }
    	
    	
    public ResultSet requeteDocuments() {
    	
    	/*Depreciate
    	 * String requete = "SELECT N.doc_dat_creat AS start, D.file_name AS title, A.a_nom AS description, D.source AS link," +								
        		"											CAST(Op.o_value AS INTEGER) AS opinion" +
        		"											FROM public.document D, public.notice N, public.opinionacteurdocument Op, public.acteur A " +
        		"											WHERE D.id_document=cast(N.doc_id as int) " +
        		"											AND D.id_document=Op.id_document " +
        		"											AND Op.id_acteur=A.id_acteur";*/
    	
    	String requete = "SELECT D.file_name, MIN(T.te_valeur) AS DateDebut, MAX(T.te_valeur) AS DateFin " +
    							"FROM public.document D, public.paragraphe Pa, public.phrase Ph, public.index_te I, public.temporalentity T " +
    							"WHERE D.id_document = Pa.id_document " +
    							" AND  Pa.id_paragraphe = Ph.id_paragraphe " +
    							" AND  Ph.id_phrase = I.id_phrase " +
    							" AND  I.id_temporalentity = T.id_temporalEntity " +
    							"GROUP BY D.file_name";

    	    try {
    	        /* Exécution d'une requête de lecture */
    	        resultat = statement.executeQuery(requete);
    	  
    	    } catch ( SQLException e ) {
    	        System.out.println("Erreur lors de la connexion : <br/>"
    	                + e.getMessage() );
    	        System.out.println("requete : requeteDocuments");
    	    } finally {}
    	 
    	    return resultat;
   }
    
    public ResultSet requeteOpinions(String nomDoc) {
    	    	
    	String requete = "SELECT Ph.contenu, T.te_valeur, Op.o_value " +
    			"FROM public.document D, public.paragraphe Pa, public.phrase Ph, public.index_te I, public.temporalentity T, public.opinionActeurPhrase Op " +
    			"WHERE D.id_document = Pa.id_document " +
    			" AND  Pa.id_paragraphe = Ph.id_paragraphe " +
    			" AND  Ph.id_phrase = I.id_phrase " +
    			" AND  I.id_temporalentity = T.id_temporalEntity " +
    			" AND  Ph.id_phrase = Op.id_phrase" +
    			" AND  D.file_name = '"+nomDoc+"'" +
    			" GROUP BY d.file_name";

    	    try {
    	        /* Exécution d'une requête de lecture */
    	        resultat = statement.executeQuery(requete);
    	        //System.out.println(resultat.getString(1));
    	  
    	    } catch ( SQLException e ) {
    	        System.out.println("Erreur lors de la connexion : <br/>"
    	                + e.getMessage() );
    	        System.out.println("requete : requeteOpinions");
    	    } finally {}
    	 
    	    return resultat;
   }
    
    
    public ResultSet requeteOpinionsParDate(String nomDoc) {
    	
    	String requete = "SELECT D.file_name, T.te_valeur, SUM(CAST(Op.o_pos AS Integer)) as o_pos, SUM(CAST(Op.o_neutre AS Integer)) as o_neu, SUM(CAST(Op.o_neg AS Integer)) as o_neg" +
    			" FROM public.document D, public.paragraphe Pa, public.phrase Ph, public.index_te I, public.temporalentity T, public.opinionActeurPhrase Op " +
    			" WHERE D.id_document = Pa.id_document " +
    			" AND  Pa.id_paragraphe = Ph.id_paragraphe" +
    			" AND  Ph.id_phrase = I.id_phrase" +
    			" AND  I.id_temporalentity = T.id_temporalEntity" +
    			" AND  Ph.id_phrase = Op.id_phrase " +
    			" AND  D.file_name = '"+nomDoc+"'" +
    			" GROUP BY d.file_name, t.te_valeur";

    	    try {
    	        /* Exécution d'une requête de lecture */
    	        resultat = statement.executeQuery(requete);
    	  
    	    } catch ( SQLException e ) {
    	        System.out.println("Erreur lors de la connexion : <br/>"
    	                + e.getMessage() );
    	        System.out.println("requete : requeteOpinionsParDate");
    	    } finally {}
    	 
    	    return resultat;
   }
    
public ResultSet requeteContrainteSpatiale(String dateDebut, String dateFin) {
    	
    	String requete = "SELECT Ph.id_phrase " +
    			"FROM public.phrase Ph, public.Index_te I, public.temporalentity T " +
    			" WHERE Ph.id_phrase = I.id_phrase" +
    			" AND  I.id_temporalentity = T.id_temporalEntity" +
    			" AND  T.te_valeur >= '" + dateDebut + "'" +
    			" AND T.te_valeur <= '" + dateFin + "'";

    	    try {
    	        /* Exécution d'une requête de lecture */
    	        resultat = statement.executeQuery(requete);
    	        //System.out.println(resultat.getString(1));
    	  
    	    } catch ( SQLException e ) {
    	        System.out.println("Erreur lors de la connexion : <br/>"
    	                + e.getMessage() );
    	        System.out.println("requete : requetePhraseParDateEtDoc "+requete);
    	    } finally {}
    	 
    	    return resultat;
   }
    
public ResultSet requetePhraseParDateEtDoc(String nomDoc, String datePhrase) {
    	
    	String requete = "SELECT Ph.id_phrase, Ph.contenu " +
    			"FROM public.document D, public.paragraphe Pa, public.phrase Ph, public.index_te I, public.temporalentity T, public.opinionActeurPhrase Op " +
    			"WHERE D.id_document = Pa.id_document" +
    			" AND  Pa.id_paragraphe = Ph.id_paragraphe" +
    			" AND  Ph.id_phrase = I.id_phrase" +
    			" AND  I.id_temporalentity = T.id_temporalEntity" +
    			" AND  Ph.id_phrase = Op.id_phrase" +
    			" AND  T.te_valeur = '"+ datePhrase + "'" +
    			" AND  D.file_name = '"+ nomDoc + "'";

    	    try {
    	        /* Exécution d'une requête de lecture */
    	        resultat = statement.executeQuery(requete);
    	        //System.out.println(resultat.getString(1));
    	  
    	    } catch ( SQLException e ) {
    	        System.out.println("Erreur lors de la connexion : <br/>"
    	                + e.getMessage() );
    	        System.out.println("requete : requetePhraseParDateEtDoc "+requete);
    	    } finally {}
    	 
    	    return resultat;
   }
}
