/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import factory.ConnectionFactory;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.Recepcao;

/**
 *
 * @author Familia Coelho
 */
public class RecepcaoDAO {
     public void create(Recepcao r) {
        Connection con = ConnectionFactory.getConnection();
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_recepcao (codigo,dia,hora,rg) VALUES(?,?,?,?)");
            
            stmt.setInt(1, r.getCodigo());
            stmt.setString(2, r.getDia());
            stmt.setString(3, r.getHora());
            stmt.setString(4, r.getRg());
            
            stmt.executeUpdate();

            } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public List<Recepcao> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Recepcao> recepcoes = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_recepcao");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Recepcao recepcao = new Recepcao();

                recepcao.setCodigo(rs.getInt("codig"));
                recepcao.setDia(rs.getString("dia"));
                recepcao.setHora(rs.getString("hora"));  
                recepcao.setRg(rs.getString("rg")); 
                
                recepcoes.add(recepcao);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Recepcao.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return recepcoes;
    }       
    
    public int cod_read() {
        Connection con = ConnectionFactory.getConnection();        
        PreparedStatement stmt = null;
        ResultSet rs = null;
        int cod = 0;
        try {
            stmt = con.prepareStatement("SELECT codigo FROM tb_recepcao ORDER BY codigo DESC LIMIT 1");            
            rs = stmt.executeQuery();

            Recepcao rec = new Recepcao();
            while (rs.next()) {
                rec.setCodigo(rs.getInt("codigo"));                
                cod = rec.getCodigo();  
            }
            return cod;
        } catch (SQLException ex) {
            Logger.getLogger(RecepcaoDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }        
       return -1;
    }
}