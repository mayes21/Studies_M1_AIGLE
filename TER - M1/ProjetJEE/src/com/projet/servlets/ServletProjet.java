package com.projet.servlets;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@SuppressWarnings("serial")
public class ServletProjet extends HttpServlet 
{
public void doGet(HttpServletRequest request, HttpServletResponse response ) 
throws ServletException, IOException
{
this.getServletContext().getRequestDispatcher( "/WEB-INF/senterritoire.jsp" ).forward( request, response );
    }

}