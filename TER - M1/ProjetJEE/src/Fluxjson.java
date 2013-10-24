import org.json.*;

import com.bdd.*;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.ByteArrayInputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.PrintWriter;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Random;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class GenerationFluxJson
 */
public class Fluxjson extends HttpServlet {
	private static final long serialVersionUID = 1L;
	public static final String ATT_FLUX = "fluxJson";
	public static final String VUE = "/json.jsp";
	public static final int TAILLE_TAMPON = 10240; // 10ko	
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Fluxjson() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		/* on-line */
		RequeteBdd test = new RequeteBdd();
		ParseurRequete fluxjson = new ParseurRequete();
		String json = "";
		
		
		String requete = request.getParameter("requete");
		String argv = request.getParameter("argv");
		
		
		/*String requete = "requeteopinion";
		String argv = "La-mer-avant-tout";*/
		System.out.println("requete : "+requete);
		/*System.out.println("argv : "+argv);*/
		
		
		//recupere pointeur sur la requete
		// * cas requeteDocuement
		// * cas requeteOpinionDocument
		// * cas requeteContraintesSpatiales
		
		if(requete.equals("requetecontraintesspatiales")){
			String dateMin = request.getParameter("datemin");
			String dateMax = request.getParameter("datemax");
			
			ResultSet reponse = test.requeteContrainteSpatiale(dateMin, dateMax);
			//format la reponse pour le client
			/*try {
				json = fluxjson.ParserRequeteContraintesSpatiales(reponse);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			test.fermerConnexion();*/
			json = fluxjson.jeuxTestContraintesSpatiales();
		}
			
		if(requete.equals("requetedocument")){
			
			try {
				ResultSet reponse = test.requeteDocuments();
				//format la reponse pour le client
				json = fluxjson.ParserRequeteDocuments(reponse);
				
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
			 test.fermerConnexion();		 
			//json = fluxjson.jeuxTestDocument();
			
		}else{
			if(requete.equals("requeteopinion")){
			
			 argv = argv.replaceAll("-", " ");

			 try {
				ResultSet reponse = test.requeteOpinionsParDate(argv);
				//format la reponse pour le client
				json = fluxjson.ParserRequeteOpinion(reponse, argv);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
			test.fermerConnexion();
			
			//json = fluxjson.jeuxTestOpinion();
			 
			}
		}

		
		
		
		

		response.setContentType("application/json;  charset=utf-8;");
		// Get the printwriter object from response to write the required json object to the output stream      
		PrintWriter out = response.getWriter();
		out.write(json.toString());
		out.flush();
	
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
