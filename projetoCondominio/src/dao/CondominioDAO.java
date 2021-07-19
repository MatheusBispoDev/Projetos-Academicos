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
import javax.swing.JOptionPane;
import model.Condominio;

/**
 *
 * @author Familia Coelho
 */
public class CondominioDAO {
    public void create(Condominio c) {
        Connection con = ConnectionFactory.getConnection();
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_condominio (codigo,empresa,andar,salas,vagas_estacionamento) VALUES(?,?,?,?,?)");
            
            stmt.setInt(1, c.getCodigo());
            stmt.setInt(2, c.getEmpresa());
            stmt.setString(3, c.getAndar());
            stmt.setInt(4, c.getSalas());
            stmt.setInt(5, c.getVagas_Estacionamento());
            
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Salvo com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public List<Condominio> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Condominio> cond = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_condominio");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Condominio c = new Condominio();

                c.setCodigo(rs.getInt("codigo"));
                c.setEmpresa(rs.getInt("empresa"));
                c.setAndar(rs.getString("andar"));  
                c.setSalas(rs.getInt("salas"));
                c.setVagas_Estacionamento(rs.getInt("vagas_estacionamento"));
                
                cond.add(c);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Condominio.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return cond;
    }
    
     public void update(Condominio c) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_condominio SET empresa = ?, andar = ?, salas = ?,"
                    + "vagas_estacionamento = ? WHERE codigo = ?");            
            
            
            stmt.setInt(1, c.getEmpresa());
            stmt.setString(2, c.getAndar());
            stmt.setInt(3, c.getSalas());
            stmt.setInt(4, c.getVagas_Estacionamento());
            stmt.setInt(5, c.getCodigo());
            
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
}
