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
import model.Visitante;

/**
 *
 * @author Michael
 */
public class VisitanteDAO {
    public void create(Visitante v) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_visitante (rg,nome,telefone,endereco,num,cep,foto)VALUES(?,?,?,?,?,?,?)");
            stmt.setString(1, v.getRg());
            stmt.setString(2, v.getNome());
            stmt.setString(3, v.getTelefone());
            stmt.setString(4, v.getEndereco());
            stmt.setInt(5, v.getNum());
            stmt.setString(6, v.getCep());
            stmt.setString(7, v.getFoto());
            

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Salvo com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public List<Visitante> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Visitante> visitantes = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_visitante");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Visitante visitante = new Visitante();

                visitante.setRg(rs.getString("rg"));
                visitante.setNome(rs.getString("nome"));  
                visitante.setTelefone(rs.getString("telefone"));
                visitante.setEndereco(rs.getString("endereco"));
                visitante.setNum(rs.getInt("num"));
                visitante.setCep(rs.getString("cep"));
                visitante.setFoto(rs.getString("foto"));
                visitantes.add(visitante);
            }

        } catch (SQLException ex) {
            Logger.getLogger(VisitanteDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return visitantes;
    }
    
        public List<Visitante> readForDesc(String nome) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Visitante> visitantes = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_visitante WHERE nome LIKE ?");
            stmt.setString(1, "%"+nome+"%");
            
            rs = stmt.executeQuery();

            while (rs.next()) {

                Visitante visitante = new Visitante();

                visitante.setRg(rs.getString("rg"));
                visitante.setNome(rs.getString("nome"));  
                visitante.setTelefone(rs.getString("telefone"));
                visitante.setEndereco(rs.getString("endereco"));
                visitante.setNum(rs.getInt("num"));
                visitante.setCep(rs.getString("cep"));
                visitante.setFoto(rs.getString("foto"));
                
                visitantes.add(visitante);
            }

        } catch (SQLException ex) {
            Logger.getLogger(FuncionarioDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return visitantes;
    }
        
    public void update(Visitante v) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_visitante SET nome = ?,telefone = ?,endereco = ?,num = ?,cep = ?,foto = ? WHERE rg = ?");            
            stmt.setString(1, v.getNome());
            stmt.setString(2, v.getTelefone());
            stmt.setString(3, v.getEndereco());
            stmt.setInt(4, v.getNum());
            stmt.setString(5, v.getCep());
            stmt.setString(6, v.getFoto());
            stmt.setString(7, v.getRg());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public void delete(Visitante v) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("DELETE FROM tb_visitante WHERE rg = ?");
            stmt.setString(1, v.getRg());

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Excluido com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao excluir: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public boolean validar(String rg) {
        Connection con = ConnectionFactory.getConnection();        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        boolean val = false;
        
        try {
            stmt = con.prepareStatement("Select * FROM tb_visitante WHERE rg = ?");
            stmt.setString(1, rg);

             rs = stmt.executeQuery();

            if (rs.next()) {                
                val = true;
            }
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao validar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
        return val;
    }   
    
    public Visitante readRg(String rg) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;
        Visitante visitante = new Visitante();
       

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_visitante WHERE rg = ?");
            stmt.setString(1, rg);
            
            rs = stmt.executeQuery();

            while (rs.next()) {
                visitante.setRg(rs.getString("rg"));
                visitante.setNome(rs.getString("nome"));  
                visitante.setTelefone(rs.getString("telefone"));
                visitante.setEndereco(rs.getString("endereco"));
                visitante.setNum(rs.getInt("num"));
                visitante.setCep(rs.getString("cep"));
                visitante.setFoto(rs.getString("foto"));
            }

        } catch (SQLException ex) {
            Logger.getLogger(FuncionarioDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return visitante;
    }
}
